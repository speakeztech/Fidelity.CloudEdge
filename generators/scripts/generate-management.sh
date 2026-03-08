#!/bin/bash
# generate-management.sh — Orchestrate Hawaii code generation for management clients
#
# Usage:
#   ./generate-management.sh [--service <key>] [--active-only] [--skip-extract] [--skip-build]
#
# Reads service definitions from services.json and for each service:
#   1. Extracts the OpenAPI subset (unless --skip-extract)
#   2. Runs Hawaii code generation
#   3. Runs post-processors declared in services.json
#   4. Deploys generated files to src/Management/
#   5. Validates compilation (unless --skip-build)

source "$(dirname "${BASH_SOURCE[0]}")/lib.sh"

# ─── Arguments ─────────────────────────────────────────────────────

SINGLE_SERVICE=""
ACTIVE_ONLY=false
SKIP_EXTRACT=false
SKIP_BUILD=false

while [[ $# -gt 0 ]]; do
    case "$1" in
        --service)      SINGLE_SERVICE="$2"; shift 2 ;;
        --active-only)  ACTIVE_ONLY=true; shift ;;
        --skip-extract) SKIP_EXTRACT=true; shift ;;
        --skip-build)   SKIP_BUILD=true; shift ;;
        --help|-h)
            echo "Usage: $0 [--service <key>] [--active-only] [--skip-extract] [--skip-build]"
            exit 0 ;;
        *)
            print_error "Unknown argument: $1"
            exit 1 ;;
    esac
done

# ─── Setup ─────────────────────────────────────────────────────────

ensure_hawaii

# Determine which services to process
if [[ -n "$SINGLE_SERVICE" ]]; then
    SERVICES="$SINGLE_SERVICE"
elif [[ "$ACTIVE_ONLY" == true ]]; then
    SERVICES=$(list_services_by_status "active")
else
    SERVICES=$(list_services)
fi

SERVICE_COUNT=$(echo "$SERVICES" | wc -w)
print_step "Management Generation: $SERVICE_COUNT service(s)"

# Download OpenAPI spec if needed for extraction
if [[ "$SKIP_EXTRACT" != true ]]; then
    download_openapi_spec "$TEMP_DIR/openapi.json"
fi

# ─── Process Each Service ──────────────────────────────────────────

PASS=0
FAIL=0
SKIP=0

for service_key in $SERVICES; do
    SERVICE_NAME=$(get_service_name "$service_key")
    HAWAII_CONFIG=$(get_hawaii_config "$service_key")

    if [[ -z "$SERVICE_NAME" ]]; then
        print_warn "Skipping unknown service: $service_key"
        SKIP=$((SKIP + 1))
        continue
    fi

    print_step "$SERVICE_NAME"

    # Step 1: Extract OpenAPI subset
    if [[ "$SKIP_EXTRACT" != true ]]; then
        print_info "Extracting OpenAPI subset..."
        if ! bash "$SCRIPTS_DIR/extract-service.sh" "$service_key" \
                --spec "$TEMP_DIR/openapi.json" \
                --output "$HAWAII_DIR/temp/${SERVICE_NAME}-openapi.json"; then
            print_error "Extraction failed for $SERVICE_NAME"
            FAIL=$((FAIL + 1))
            continue
        fi
    fi

    # Check if the extracted spec has any paths
    SPEC_FILE="$HAWAII_DIR/temp/${SERVICE_NAME}-openapi.json"
    if [[ -f "$SPEC_FILE" ]]; then
        PATH_COUNT=$(count_spec_paths "$SPEC_FILE")
        if [[ "$PATH_COUNT" -eq 0 ]]; then
            print_warn "$SERVICE_NAME: No paths in extracted spec, skipping generation"
            SKIP=$((SKIP + 1))
            continue
        fi
    else
        print_warn "$SERVICE_NAME: No spec file found, skipping"
        SKIP=$((SKIP + 1))
        continue
    fi

    # Step 2: Run Hawaii code generation
    CONFIG_FILE="$HAWAII_DIR/$HAWAII_CONFIG"
    if [[ ! -f "$CONFIG_FILE" ]]; then
        print_error "Hawaii config not found: $CONFIG_FILE"
        FAIL=$((FAIL + 1))
        continue
    fi

    print_info "Running Hawaii..."
    GENERATED_DIR="$HAWAII_DIR/Generated-${SERVICE_NAME}"

    if ! (cd "$HAWAII_DIR" && hawaii --config "$HAWAII_CONFIG" 2>&1); then
        print_error "Hawaii generation failed for $SERVICE_NAME"
        FAIL=$((FAIL + 1))
        continue
    fi

    if [[ ! -d "$GENERATED_DIR" ]]; then
        print_error "Expected output directory not found: $GENERATED_DIR"
        FAIL=$((FAIL + 1))
        continue
    fi

    # Step 3: Run post-processors
    POSTPROCESSORS_DIR="$HAWAII_DIR/postprocessors"

    if has_post_processor "$service_key" "discriminators"; then
        DISC_ARGS=$(get_post_processor_args "$service_key" "discriminators")
        LIST_TYPE=$(echo "$DISC_ARGS" | jq -r '.listType // empty')
        ITEM_TYPE=$(echo "$DISC_ARGS" | jq -r '.itemType // empty')
        KIND_PREFIX=$(echo "$DISC_ARGS" | jq -r '.kindPrefix // empty')

        if [[ -n "$LIST_TYPE" && -n "$ITEM_TYPE" && -n "$KIND_PREFIX" ]]; then
            print_info "Post-processing: discriminators..."
            dotnet fsi "$POSTPROCESSORS_DIR/discriminators.fsx" \
                "$GENERATED_DIR/Types.fs" \
                --list-type "$LIST_TYPE" \
                --item-type "$ITEM_TYPE" \
                --kind-prefix "$KIND_PREFIX"
        fi
    fi

    if has_post_processor "$service_key" "jobject-multipart"; then
        print_info "Post-processing: JObject multipart..."
        dotnet fsi "$POSTPROCESSORS_DIR/jobject-multipart.fsx" \
            "$GENERATED_DIR/Client.fs"
    fi

    if has_post_processor "$service_key" "missing-body-params"; then
        MBP_ARGS=$(get_post_processor_args "$service_key" "missing-body-params")
        METHOD_NAME=$(echo "$MBP_ARGS" | jq -r '.methodName // empty')
        BODY_TYPE=$(echo "$MBP_ARGS" | jq -r '.bodyType // empty')

        if [[ -n "$METHOD_NAME" && -n "$BODY_TYPE" ]]; then
            print_info "Post-processing: missing body params ($METHOD_NAME)..."
            dotnet fsi "$POSTPROCESSORS_DIR/missing-body-params.fsx" \
                "$GENERATED_DIR/Client.fs" \
                --method-name "$METHOD_NAME" \
                --body-type "$BODY_TYPE"
        fi
    fi

    # Step 4: Deploy to src/Management/
    TARGET_DIR="$SRC_DIR/Management/CloudEdge.Management.${SERVICE_NAME}"

    if [[ ! -d "$TARGET_DIR" ]]; then
        print_info "Scaffolding new project: CloudEdge.Management.${SERVICE_NAME}"
        bash "$SCRIPTS_DIR/scaffold-management-project.sh" "$service_key"
    fi

    deploy_generated_files "$service_key"

    # Step 5: Validate compilation
    if [[ "$SKIP_BUILD" != true ]]; then
        print_info "Validating compilation..."
        if dotnet build "$TARGET_DIR" --nologo --verbosity quiet 2>&1; then
            print_success "$SERVICE_NAME: Build succeeded"
        else
            print_warn "$SERVICE_NAME: Build failed (may need manual fixes)"
        fi
    fi

    PASS=$((PASS + 1))
done

# ─── Summary ───────────────────────────────────────────────────────

echo ""
print_step "Management Generation Summary"
print_success "Passed: $PASS"
if [[ $FAIL -gt 0 ]]; then
    print_error "Failed: $FAIL"
fi
if [[ $SKIP -gt 0 ]]; then
    print_warn "Skipped: $SKIP"
fi

if [[ $FAIL -gt 0 ]]; then
    exit 1
fi
