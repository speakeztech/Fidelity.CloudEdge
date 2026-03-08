#!/bin/bash
# validate.sh — Validate generated management bindings
#
# Usage:
#   ./validate.sh [--service <key>] [--active-only] [--skip-build]
#
# For each service:
#   1. Checks that the project directory exists
#   2. Verifies Types.fs exports at least one public type
#   3. Verifies Client.fs exports a client class with async methods
#   4. Runs dotnet build to confirm compilation
#   5. Reports pass/fail summary

source "$(dirname "${BASH_SOURCE[0]}")/lib.sh"

# ─── Arguments ─────────────────────────────────────────────────────

SINGLE_SERVICE=""
ACTIVE_ONLY=false
SKIP_BUILD=false

while [[ $# -gt 0 ]]; do
    case "$1" in
        --service)      SINGLE_SERVICE="$2"; shift 2 ;;
        --active-only)  ACTIVE_ONLY=true; shift ;;
        --skip-build)   SKIP_BUILD=true; shift ;;
        --help|-h)
            echo "Usage: $0 [--service <key>] [--active-only] [--skip-build]"
            exit 0 ;;
        *)
            print_error "Unknown argument: $1"
            exit 1 ;;
    esac
done

# ─── Service Selection ─────────────────────────────────────────────

if [[ -n "$SINGLE_SERVICE" ]]; then
    SERVICES="$SINGLE_SERVICE"
elif [[ "$ACTIVE_ONLY" == true ]]; then
    SERVICES=$(list_services_by_status "active")
else
    SERVICES=$(list_services_by_status "active")
fi

SERVICE_COUNT=$(echo "$SERVICES" | wc -w)
print_step "Validation: $SERVICE_COUNT service(s)"

# ─── Validate Each Service ─────────────────────────────────────────

PASS=0
FAIL=0
WARN=0
DETAILS=""

for service_key in $SERVICES; do
    SERVICE_NAME=$(get_service_name "$service_key")
    PROJECT_DIR="$SRC_DIR/Management/CloudEdge.Management.${SERVICE_NAME}"
    TYPES_FILE="$PROJECT_DIR/Types.fs"
    CLIENT_FILE="$PROJECT_DIR/Client.fs"

    if [[ -z "$SERVICE_NAME" ]]; then
        DETAILS+="  ✗ $service_key: unknown service\n"
        FAIL=$((FAIL + 1))
        continue
    fi

    # Check 1: Project directory exists
    if [[ ! -d "$PROJECT_DIR" ]]; then
        DETAILS+="  ✗ $SERVICE_NAME: project directory missing\n"
        FAIL=$((FAIL + 1))
        continue
    fi

    # Check 2: Types.fs exists and has content
    if [[ ! -f "$TYPES_FILE" ]]; then
        DETAILS+="  ! $SERVICE_NAME: Types.fs missing (not yet generated)\n"
        WARN=$((WARN + 1))
        continue
    fi

    TYPE_COUNT=$(grep -c "^type " "$TYPES_FILE" 2>/dev/null || echo "0")
    if [[ "$TYPE_COUNT" -eq 0 ]]; then
        DETAILS+="  ✗ $SERVICE_NAME: Types.fs has no type definitions\n"
        FAIL=$((FAIL + 1))
        continue
    fi

    # Check 3: Client.fs exists and has async methods
    if [[ ! -f "$CLIENT_FILE" ]]; then
        DETAILS+="  ! $SERVICE_NAME: Client.fs missing (not yet generated)\n"
        WARN=$((WARN + 1))
        continue
    fi

    ASYNC_COUNT=$(grep -c "async {" "$CLIENT_FILE" 2>/dev/null || echo "0")
    if [[ "$ASYNC_COUNT" -eq 0 ]]; then
        DETAILS+="  ✗ $SERVICE_NAME: Client.fs has no async methods\n"
        FAIL=$((FAIL + 1))
        continue
    fi

    # Check 4: Build compilation
    if [[ "$SKIP_BUILD" != true ]]; then
        if dotnet build "$PROJECT_DIR" --nologo --verbosity quiet 2>/dev/null; then
            DETAILS+="  ✓ $SERVICE_NAME: $TYPE_COUNT types, $ASYNC_COUNT methods, build OK\n"
            PASS=$((PASS + 1))
        else
            DETAILS+="  ✗ $SERVICE_NAME: $TYPE_COUNT types, $ASYNC_COUNT methods, BUILD FAILED\n"
            FAIL=$((FAIL + 1))
        fi
    else
        DETAILS+="  ✓ $SERVICE_NAME: $TYPE_COUNT types, $ASYNC_COUNT methods (build skipped)\n"
        PASS=$((PASS + 1))
    fi
done

# ─── Report ────────────────────────────────────────────────────────

echo ""
print_step "Validation Results"
echo -e "$DETAILS"

echo ""
print_success "Passed: $PASS"
if [[ $WARN -gt 0 ]]; then
    print_warn "Warnings: $WARN (not yet generated)"
fi
if [[ $FAIL -gt 0 ]]; then
    print_error "Failed: $FAIL"
fi

# Exit with non-zero if any failures
if [[ $FAIL -gt 0 ]]; then
    exit 1
fi
