#!/bin/bash
# lib.sh — Shared utilities for Fidelity.CloudEdge generation scripts
#
# Source this file from other scripts:
#   source "$(dirname "${BASH_SOURCE[0]}")/lib.sh"

set -euo pipefail

# ─── Path Resolution ───────────────────────────────────────────────

SCRIPTS_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
GENERATORS_DIR="$(dirname "$SCRIPTS_DIR")"
PROJECT_ROOT="$(dirname "$GENERATORS_DIR")"
SERVICES_JSON="$GENERATORS_DIR/services.json"
HAWAII_DIR="$GENERATORS_DIR/hawaii"
GLUTINUM_DIR="$GENERATORS_DIR/glutinum"
SRC_DIR="$PROJECT_ROOT/src"
TEMP_DIR="$HAWAII_DIR/temp"

# ─── Output Helpers ────────────────────────────────────────────────

_bold() { tput bold 2>/dev/null || true; }
_reset() { tput sgr0 2>/dev/null || true; }
_color() { tput setaf "$1" 2>/dev/null || true; }

print_step() {
    echo ""
    echo "$(_bold)$(_color 6)$1$(_reset)"
    printf '%*s\n' "${#1}" '' | tr ' ' '-'
}

print_success() { echo "$(_color 2)  ✓ $1$(_reset)"; }
print_info()    { echo "$(_color 8)  $1$(_reset)"; }
print_warn()    { echo "$(_color 3)  ! $1$(_reset)"; }
print_error()   { echo "$(_color 1)  ✗ $1$(_reset)" >&2; }

# ─── Tool Validation ──────────────────────────────────────────────

require_tool() {
    local tool="$1"
    local install_hint="${2:-}"
    if ! command -v "$tool" &>/dev/null; then
        print_error "$tool is required but not installed."
        if [[ -n "$install_hint" ]]; then
            print_info "Install with: $install_hint"
        fi
        return 1
    fi
}

validate_tools() {
    local failed=0
    require_tool "dotnet" "https://dot.net"                || failed=1
    require_tool "node"   "https://nodejs.org"             || failed=1
    require_tool "npm"    "(included with Node.js)"        || failed=1
    require_tool "jq"     "apt install jq / brew install jq" || failed=1
    if [[ $failed -ne 0 ]]; then
        print_error "Missing required tools. Aborting."
        exit 1
    fi
    print_success "All required tools available"
}

# ─── Service Registry Queries ──────────────────────────────────────
# All queries read from $SERVICES_JSON using jq.

# List all service keys
list_services() {
    jq -r '.services | keys[]' "$SERVICES_JSON"
}

# List services filtered by status (active, planned)
list_services_by_status() {
    local status="$1"
    jq -r --arg s "$status" '.services | to_entries[] | select(.value.status == $s) | .key' "$SERVICES_JSON"
}

# Get a single property for a service
get_service_prop() {
    local service="$1"
    local prop="$2"
    jq -r --arg svc "$service" --arg p "$prop" '.services[$svc][$p] // empty' "$SERVICES_JSON"
}

# Get the display name for a service
get_service_name() {
    get_service_prop "$1" "name"
}

# Get the Hawaii config filename for a service
get_hawaii_config() {
    get_service_prop "$1" "hawaiiConfig"
}

# Get the target namespace for a service
get_namespace() {
    get_service_prop "$1" "namespace"
}

# Get the operation prefix for schema matching
get_operation_prefix() {
    get_service_prop "$1" "operationPrefix"
}

# Get path patterns as newline-separated list
get_path_patterns() {
    local service="$1"
    jq -r --arg svc "$service" '.services[$svc].pathPatterns[]' "$SERVICES_JSON" 2>/dev/null || true
}

# Get the path prefix (for planned services using prefix-based extraction)
get_path_prefix() {
    get_service_prop "$1" "pathPrefix"
}

# Get post-processors as JSON array
get_post_processors() {
    local service="$1"
    jq -c --arg svc "$service" '.services[$svc].postProcessors' "$SERVICES_JSON"
}

# Check if a service has a specific post-processor
has_post_processor() {
    local service="$1"
    local processor="$2"
    local result
    result=$(jq -r --arg svc "$service" --arg pp "$processor" \
        '.services[$svc].postProcessors[] | if type == "object" then .name else . end | select(. == $pp)' \
        "$SERVICES_JSON" 2>/dev/null || true)
    [[ -n "$result" ]]
}

# Get post-processor args as JSON object (or empty)
get_post_processor_args() {
    local service="$1"
    local processor="$2"
    jq -c --arg svc "$service" --arg pp "$processor" \
        '.services[$svc].postProcessors[] | select(type == "object" and .name == $pp) | .args // {}' \
        "$SERVICES_JSON" 2>/dev/null || echo "{}"
}

# ─── OpenAPI Spec Helpers ──────────────────────────────────────────

# Download the latest Cloudflare OpenAPI spec
download_openapi_spec() {
    local output="${1:-$TEMP_DIR/openapi.json}"
    mkdir -p "$(dirname "$output")"

    if [[ -f "$output" ]]; then
        local age_hours
        age_hours=$(( ($(date +%s) - $(stat -c %Y "$output" 2>/dev/null || echo 0)) / 3600 ))
        if [[ $age_hours -lt 24 ]]; then
            print_info "Using cached OpenAPI spec (${age_hours}h old)"
            return 0
        fi
    fi

    print_info "Downloading Cloudflare OpenAPI spec..."
    if curl -sL "https://raw.githubusercontent.com/cloudflare/api-schemas/main/openapi.json" -o "$output"; then
        local size_mb
        size_mb=$(awk "BEGIN {printf \"%.1f\", $(stat -c %s "$output") / 1048576}")
        print_success "OpenAPI spec downloaded (${size_mb} MB)"
    else
        print_error "Failed to download OpenAPI spec"
        return 1
    fi
}

# Count paths in a spec file
count_spec_paths() {
    local spec_file="$1"
    jq '.paths | length' "$spec_file"
}

# Count schemas in a spec file
count_spec_schemas() {
    local spec_file="$1"
    jq '.components.schemas | length' "$spec_file"
}

# ─── Hawaii Helpers ────────────────────────────────────────────────

# Check if Hawaii dotnet tool is available
ensure_hawaii() {
    if ! dotnet tool list -g 2>/dev/null | grep -qi hawaii; then
        print_info "Installing Hawaii globally..."
        dotnet tool install -g hawaii
    fi
    print_success "Hawaii is available"
}

# Check if Glutinum CLI is available
ensure_glutinum() {
    if ! npm list -g @glutinum/cli &>/dev/null; then
        print_info "Installing Glutinum CLI globally..."
        npm install -g @glutinum/cli
    fi
    print_success "Glutinum CLI is available"
}

# ─── File Operations ──────────────────────────────────────────────

# Copy generated files from hawaii output to src/Management project
deploy_generated_files() {
    local service_key="$1"
    local service_name
    service_name=$(get_service_name "$service_key")
    local source_dir="$HAWAII_DIR/Generated-${service_name}"
    local target_dir="$SRC_DIR/Management/CloudEdge.Management.${service_name}"

    if [[ ! -d "$source_dir" ]]; then
        print_error "Generated directory not found: $source_dir"
        return 1
    fi

    mkdir -p "$target_dir"

    local count=0
    for fs_file in "$source_dir"/*.fs; do
        if [[ -f "$fs_file" ]]; then
            cp "$fs_file" "$target_dir/"
            count=$((count + 1))
        fi
    done

    print_success "Deployed $count files to CloudEdge.Management.${service_name}"
}

# ─── Retry Logic ───────────────────────────────────────────────────

retry() {
    local max_attempts="${1:-3}"
    shift
    local attempt=1
    while [[ $attempt -le $max_attempts ]]; do
        if "$@"; then
            return 0
        fi
        print_warn "Attempt $attempt/$max_attempts failed, retrying..."
        attempt=$((attempt + 1))
        sleep 2
    done
    print_error "All $max_attempts attempts failed"
    return 1
}
