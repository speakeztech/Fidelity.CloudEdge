#!/bin/bash
# preprocess-openapi.sh — Fix OpenAPI spec issues that cause Hawaii to crash
#
# Usage:
#   ./preprocess-openapi.sh <input.json> [output.json]
#
# Fixes applied:
#   1. Empty schema objects in content types (e.g. {"application/json": {}})
#      get a stub schema added: {"schema": {"type": "object"}}
#   2. Responses with null/missing content get a stub application/json response
#   3. Content entries with only non-JSON types get an application/json fallback
#   4. Request bodies with empty or missing schemas get stubs
#   5. Operations missing operationId get one generated from path + method
#   6. Wildcard status codes (4XX, 5XX) are expanded to concrete codes (400, 500)
#   7. Operations with null responses get a stub 200 response
#
# Root cause: Hawaii 0.66.0 crashes with NullReferenceException in
# createResponseType and rewriteOperationVendorJson when operations
# have missing operationIds, wildcard status codes, or null schema fields.
#
# If output is not specified, input file is modified in-place.

set -euo pipefail

INPUT="${1:-}"
OUTPUT="${2:-$INPUT}"

if [[ -z "$INPUT" ]]; then
    echo "Usage: $0 <input.json> [output.json]"
    exit 1
fi

if [[ ! -f "$INPUT" ]]; then
    echo "Error: File not found: $INPUT"
    exit 1
fi

STUB='{"type": "object"}'

jq --argjson stub "$STUB" '

  # Helper: ensure every content-type entry has a schema field
  def fix_content_entries:
    if . == null then
      {"application/json": {"schema": $stub}}
    else
      to_entries | map(
        if .value == null or .value == {} or (.value | has("schema") | not) then
          .value = {"schema": $stub}
        else . end
      ) | from_entries |
      # Also ensure application/json exists
      if has("application/json") then .
      else . + {"application/json": {"schema": (to_entries | .[0].value.schema // $stub)}}
      end
    end;

  # Helper: generate operationId from path and method
  # e.g. /accounts/{account_id}/containers + get => getAccountsContainers
  def make_operation_id($path; $method):
    ($path | gsub("/\\{[^}]+\\}"; "") | split("/") | map(select(length > 0)) |
     map(split("_") | map(. as $s | ($s[0:1] | ascii_upcase) + $s[1:])) |
     flatten | join("")) as $pathPart |
    $method + $pathPart;

  # Helper: expand wildcard status codes to concrete codes
  def expand_status_codes:
    to_entries | map(
      if (.key | test("^[0-9]XX$")) then
        .key = (.key | sub("XX$"; "00"))
      else . end
    ) | from_entries;

  # Walk all operations in all paths
  .paths |= (to_entries | map(
    .key as $pathKey |
    .value |= (to_entries | map(
      if (.key | test("get|put|post|delete|patch")) then
        .key as $method |

        # Fix missing operationId
        (if (.value.operationId == null or .value.operationId == "") then
          .value.operationId = make_operation_id($pathKey; $method)
        else . end) |

        # Fix missing summary
        (if (.value.summary == null) then
          .value.summary = .value.operationId
        else . end) |

        # Fix null or missing responses
        (if (.value.responses == null) then
          .value.responses = {"200": {"description": "OK", "content": {"application/json": {"schema": $stub}}}}
        else
          # Expand wildcard status codes, strip $ref from responses, and fix content entries
          .value.responses |= (expand_status_codes | to_entries | map(
            # Ensure each response has content
            (if .value == null or .value == {} then
              .value = {"description": "Response", "content": {"application/json": {"schema": $stub}}}
            else . end) |
            # Strip $ref from response objects (Hawaii crashes resolving missing $refs)
            (if .value | has("$ref") then
              .value |= del(.["$ref"])
            else . end) |
            .value.content |= fix_content_entries
          ) | from_entries)
        end) |

        # Fix request bodies
        (if .value.requestBody then
          .value.requestBody.content |= fix_content_entries
        else . end)
      else . end
    ) | from_entries)
  ) | from_entries)

' "$INPUT" > "${OUTPUT}.tmp" && mv "${OUTPUT}.tmp" "$OUTPUT"

echo "Preprocessed: $OUTPUT"
