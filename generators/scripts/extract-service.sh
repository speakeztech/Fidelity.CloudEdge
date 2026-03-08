#!/bin/bash
# extract-service.sh — Extract a single service's OpenAPI subset from the master spec
#
# Usage:
#   ./extract-service.sh <service-key> [--spec <path>] [--output <path>]
#
# Reads path patterns and operation prefix from services.json.
# Uses jq for path filtering and recursive $ref resolution.

source "$(dirname "${BASH_SOURCE[0]}")/lib.sh"

# ─── Arguments ─────────────────────────────────────────────────────

SERVICE_KEY=""
SPEC_FILE="$TEMP_DIR/openapi.json"
OUTPUT_FILE=""

while [[ $# -gt 0 ]]; do
    case "$1" in
        --spec)    SPEC_FILE="$2";  shift 2 ;;
        --output)  OUTPUT_FILE="$2"; shift 2 ;;
        --help|-h)
            echo "Usage: $0 <service-key> [--spec <path>] [--output <path>]"
            exit 0 ;;
        *)
            if [[ -z "$SERVICE_KEY" ]]; then
                SERVICE_KEY="$1"
            else
                print_error "Unknown argument: $1"
                exit 1
            fi
            shift ;;
    esac
done

if [[ -z "$SERVICE_KEY" ]]; then
    print_error "Service key is required. Available services:"
    list_services | sed 's/^/  /'
    exit 1
fi

SERVICE_NAME=$(get_service_name "$SERVICE_KEY")
if [[ -z "$SERVICE_NAME" ]]; then
    print_error "Unknown service: $SERVICE_KEY"
    exit 1
fi

if [[ -z "$OUTPUT_FILE" ]]; then
    OUTPUT_FILE="$TEMP_DIR/${SERVICE_NAME}-openapi.json"
fi

mkdir -p "$(dirname "$OUTPUT_FILE")"

# ─── Ensure spec exists ───────────────────────────────────────────

if [[ ! -f "$SPEC_FILE" ]]; then
    download_openapi_spec "$SPEC_FILE"
fi

# ─── Build path filter ────────────────────────────────────────────

# Collect explicit path patterns
PATTERNS=$(get_path_patterns "$SERVICE_KEY")

# Also check for pathPrefix (used by planned services)
PATH_PREFIX=$(get_path_prefix "$SERVICE_KEY")

OPERATION_PREFIX=$(get_operation_prefix "$SERVICE_KEY")

print_step "Extracting $SERVICE_NAME from OpenAPI spec"

# ─── Extract via jq ───────────────────────────────────────────────
#
# This is a single jq pipeline that:
# 1. Filters paths by exact match or prefix
# 2. Collects all $ref references recursively
# 3. Includes schemas matching the operation prefix
# 4. Includes common response schemas
# 5. Recursively resolves schema dependencies
# 6. Builds a minimal, focused spec

# Build the jq filter arguments
JQ_ARGS=()
JQ_ARGS+=(--arg serviceName "$SERVICE_NAME")
JQ_ARGS+=(--arg opPrefix "$OPERATION_PREFIX")

# Serialize path patterns as JSON array
if [[ -n "$PATTERNS" ]]; then
    PATTERNS_JSON=$(echo "$PATTERNS" | jq -R -s 'split("\n") | map(select(length > 0))')
else
    PATTERNS_JSON="[]"
fi
JQ_ARGS+=(--argjson patterns "$PATTERNS_JSON")

if [[ -n "$PATH_PREFIX" ]]; then
    JQ_ARGS+=(--arg pathPrefix "$PATH_PREFIX")
else
    JQ_ARGS+=(--arg pathPrefix "")
fi

# Use a two-pass approach:
# Pass 1: Extract paths and collect initial schema refs (grep-based, fast)
# Pass 2: Build the filtered spec with resolved dependencies

# Pass 1: Filter paths
jq "${JQ_ARGS[@]}" '
def match_path:
    . as $path |
    if ($patterns | length) > 0 then
        ($patterns | any(. == $path))
    elif ($pathPrefix | length) > 0 then
        ($path | startswith($pathPrefix))
    else
        false
    end;
[.paths | to_entries[] | select(.key | match_path) | .key]
' "$SPEC_FILE" > "$TEMP_DIR/_matched_paths.json"

MATCHED_COUNT=$(jq 'length' "$TEMP_DIR/_matched_paths.json")
if [[ "$MATCHED_COUNT" -eq 0 ]]; then
    print_warn "No paths matched for $SERVICE_NAME"
    echo '{"openapi":"3.0.0","info":{"title":"Empty"},"paths":{},"components":{"schemas":{}}}' > "$OUTPUT_FILE"
    exit 0
fi
print_info "Matched $MATCHED_COUNT paths"

# Collect all $ref values from the filtered paths section using grep (fast)
jq --slurpfile matched "$TEMP_DIR/_matched_paths.json" '
.paths | to_entries | map(select(.key as $k | $matched[0] | index($k))) | from_entries
' "$SPEC_FILE" | { grep -oP '"\$ref"\s*:\s*"#/components/schemas/\K[^"]+' || true; } | sort -u > "$TEMP_DIR/_direct_refs.txt"

# Also collect prefix-matching schemas
jq -r --arg opPrefix "$OPERATION_PREFIX" \
    '.components.schemas | keys[] | select(startswith($opPrefix + "_") or startswith($opPrefix + "-"))' \
    "$SPEC_FILE" >> "$TEMP_DIR/_direct_refs.txt"

# Add common schemas
for common in api-response-common api-response-single api-response-collection messages result_info schemas-errors; do
    echo "$common" >> "$TEMP_DIR/_direct_refs.txt"
done

sort -u "$TEMP_DIR/_direct_refs.txt" -o "$TEMP_DIR/_direct_refs.txt"

# Pre-extract a ref index: for each schema, list its direct $ref dependencies.
# This is done once against the full spec using jq (streaming-friendly).
print_info "Building schema dependency index..."
jq -r '.components.schemas | to_entries[] | .key as $k | [.value | .. | objects | .["$ref"]? // empty | select(startswith("#/components/schemas/")) | ltrimstr("#/components/schemas/")] | unique | .[] | "\($k)\t\(.)"' \
    "$SPEC_FILE" > "$TEMP_DIR/_ref_index.tsv" 2>/dev/null

# Iteratively resolve schema dependencies (breadth-first) using the index
cp "$TEMP_DIR/_direct_refs.txt" "$TEMP_DIR/_all_refs.txt"
for _iteration in $(seq 1 10); do
    # Look up deps for all known schemas from the pre-built index
    # Match only the first column (schema key) exactly
    awk -F'\t' 'NR==FNR {refs[$1]=1; next} ($1 in refs) {print $2}' \
        "$TEMP_DIR/_all_refs.txt" "$TEMP_DIR/_ref_index.tsv" | sort -u > "$TEMP_DIR/_new_refs.txt"

    # Find refs not yet in our set
    comm -23 "$TEMP_DIR/_new_refs.txt" "$TEMP_DIR/_all_refs.txt" > "$TEMP_DIR/_delta_refs.txt"

    if [[ ! -s "$TEMP_DIR/_delta_refs.txt" ]]; then
        break  # No new refs found, dependency resolution complete
    fi

    cat "$TEMP_DIR/_delta_refs.txt" >> "$TEMP_DIR/_all_refs.txt"
    sort -u "$TEMP_DIR/_all_refs.txt" -o "$TEMP_DIR/_all_refs.txt"
done

SCHEMA_COUNT=$(wc -l < "$TEMP_DIR/_all_refs.txt")
print_info "Resolved $SCHEMA_COUNT schema dependencies"

# Final pass: assemble the filtered spec
jq "${JQ_ARGS[@]}" \
    --slurpfile matched "$TEMP_DIR/_matched_paths.json" \
    --slurpfile schemas <(jq -R -s 'split("\n") | map(select(length > 0))' "$TEMP_DIR/_all_refs.txt") '
{
    openapi: .openapi,
    info: {
        title: ("Cloudflare " + $serviceName + " API"),
        description: (.info.description // ""),
        version: (.info.version // "4.0.0")
    },
    servers: .servers,
    paths: (.paths | to_entries | map(select(.key as $k | $matched[0] | index($k))) | from_entries),
    components: {
        schemas: (.components.schemas | to_entries | map(select(.key as $k | $schemas[0] | index($k))) | from_entries),
        parameters: {},
        responses: {},
        examples: {},
        requestBodies: {},
        headers: {},
        securitySchemes: (.components.securitySchemes // {})
    }
}
' "$SPEC_FILE" > "$OUTPUT_FILE"

# Clean up temp files
rm -f "$TEMP_DIR/_matched_paths.json" "$TEMP_DIR/_direct_refs.txt" "$TEMP_DIR/_all_refs.txt" "$TEMP_DIR/_new_refs.txt" "$TEMP_DIR/_delta_refs.txt" "$TEMP_DIR/_ref_index.tsv"

# ─── Report ────────────────────────────────────────────────────────

PATHS_COUNT=$(count_spec_paths "$OUTPUT_FILE")
SCHEMAS_COUNT=$(count_spec_schemas "$OUTPUT_FILE")
SIZE_KB=$(awk "BEGIN {printf \"%.1f\", $(stat -c %s "$OUTPUT_FILE") / 1024}")

print_success "$SERVICE_NAME: $PATHS_COUNT paths, $SCHEMAS_COUNT schemas (${SIZE_KB} KB)"
