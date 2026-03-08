#!/bin/bash
# update-and-generate.sh — Master generation pipeline for Fidelity.CloudEdge
#
# Replaces generators/update-and-generate.ps1 with a portable bash equivalent.
#
# Usage:
#   ./update-and-generate.sh                  # Full update and regeneration
#   ./update-and-generate.sh --runtime-only   # Only runtime (Glutinum) bindings
#   ./update-and-generate.sh --management-only # Only management (Hawaii) bindings
#   ./update-and-generate.sh --skip-update    # Skip npm/spec updates
#   ./update-and-generate.sh --clean          # Clean temp files first
#   ./update-and-generate.sh --active-only    # Only services with status=active
#   ./update-and-generate.sh --service kv     # Single service only

source "$(dirname "${BASH_SOURCE[0]}")/lib.sh"

# ─── Flags ─────────────────────────────────────────────────────────

SKIP_UPDATE=false
RUNTIME_ONLY=false
MANAGEMENT_ONLY=false
CLEAN=false
ACTIVE_ONLY=false
SINGLE_SERVICE=""

while [[ $# -gt 0 ]]; do
    case "$1" in
        --skip-update)      SKIP_UPDATE=true;      shift ;;
        --runtime-only)     RUNTIME_ONLY=true;     shift ;;
        --management-only)  MANAGEMENT_ONLY=true;  shift ;;
        --clean)            CLEAN=true;            shift ;;
        --active-only)      ACTIVE_ONLY=true;      shift ;;
        --service)          SINGLE_SERVICE="$2";   shift 2 ;;
        --help|-h)
            echo "Usage: $0 [flags]"
            echo "  --skip-update       Skip npm/spec updates"
            echo "  --runtime-only      Only generate runtime (Glutinum) bindings"
            echo "  --management-only   Only generate management (Hawaii) bindings"
            echo "  --clean             Clean temp files before generation"
            echo "  --active-only       Only process services with status=active"
            echo "  --service <key>     Process a single service only"
            exit 0 ;;
        *)
            print_error "Unknown flag: $1"
            exit 1 ;;
    esac
done

# ─── Main ──────────────────────────────────────────────────────────

main() {
    echo ""
    echo "  Fidelity.CloudEdge Binding Generation Pipeline"
    echo "  ─────────────────────────────────────────────────"
    echo ""

    # [0] Validate
    print_step "[0/5] Validating Environment"
    validate_tools

    # [1] Clean
    if [[ "$CLEAN" == "true" ]]; then
        print_step "[1/5] Cleaning Temporary Files"
        rm -rf "$GLUTINUM_DIR/temp" "$HAWAII_DIR/temp"
        print_success "Temp directories cleaned"
    else
        print_info "[1/5] Skipping clean (use --clean to enable)"
    fi

    # [2] Update sources
    if [[ "$SKIP_UPDATE" == "false" ]]; then
        print_step "[2/5] Updating Source Schemas"

        print_info "Downloading latest OpenAPI spec..."
        download_openapi_spec "$TEMP_DIR/openapi.json"

        print_info "Updating npm packages..."
        (cd "$PROJECT_ROOT" && npm update @cloudflare/workers-types @cloudflare/ai 2>/dev/null)
        print_success "npm packages updated"
    else
        print_info "[2/5] Skipping updates (--skip-update)"
    fi

    # [3] Extract service specs
    print_step "[3/5] Extracting Service OpenAPI Specs"

    local services_to_process
    if [[ -n "$SINGLE_SERVICE" ]]; then
        services_to_process="$SINGLE_SERVICE"
    elif [[ "$ACTIVE_ONLY" == "true" ]]; then
        services_to_process=$(list_services_by_status "active")
    else
        services_to_process=$(list_services)
    fi

    if [[ "$RUNTIME_ONLY" != "true" ]]; then
        local extract_count=0
        while IFS= read -r svc; do
            [[ -z "$svc" ]] && continue
            if bash "$SCRIPTS_DIR/extract-service.sh" "$svc" --spec "$TEMP_DIR/openapi.json"; then
                extract_count=$((extract_count + 1))
            else
                print_warn "Extraction failed for $svc, skipping"
            fi
        done <<< "$services_to_process"
        print_success "Extracted $extract_count service specs"
    fi

    # [4] Generate runtime bindings
    if [[ "$MANAGEMENT_ONLY" != "true" ]]; then
        print_step "[4/5] Generating Runtime Bindings (Glutinum)"
        if [[ -x "$SCRIPTS_DIR/generate-runtime.sh" ]]; then
            bash "$SCRIPTS_DIR/generate-runtime.sh"
        else
            print_warn "generate-runtime.sh not found or not executable, skipping"
            print_info "This script will be created in Phase 2"
        fi
    else
        print_info "[4/5] Skipping runtime (--management-only)"
    fi

    # [5] Generate management bindings
    if [[ "$RUNTIME_ONLY" != "true" ]]; then
        print_step "[5/5] Generating Management Bindings (Hawaii)"
        if [[ -x "$SCRIPTS_DIR/generate-management.sh" ]]; then
            bash "$SCRIPTS_DIR/generate-management.sh" "$services_to_process"
        else
            print_warn "generate-management.sh not found or not executable, skipping"
            print_info "This script will be created in Phase 3"
        fi
    else
        print_info "[5/5] Skipping management (--runtime-only)"
    fi

    # Done
    echo ""
    echo "  ─────────────────────────────────────────────────"
    echo "  Generation complete."
    echo ""
}

main "$@"
