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
#   8. Inline allOf response schemas are flattened into named schemas
#      (Hawaii falls back to string when it encounters allOf with $ref + inline properties)
#
# Root cause: Hawaii 0.66.0 crashes with NullReferenceException in
# createResponseType and rewriteOperationVendorJson when operations
# have missing operationIds, wildcard status codes, or null schema fields.
# Additionally, Hawaii cannot synthesize concrete types from inline allOf
# compositions that merge a $ref with anonymous properties, falling back
# to returning raw JSON strings instead of typed records.
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

  # Helper: resolve a $ref path like "#/components/schemas/foo" to the actual schema object
  def resolve_ref($root):
    ltrimstr("#/") | split("/") | reduce .[] as $seg ($root; .[$seg]);

  # Helper: deep-merge two schema objects.
  # For "properties", "required" — merge/concatenate. For other keys, right wins.
  def deep_merge_schemas:
    if length == 0 then {}
    elif length == 1 then .[0]
    else
      reduce .[] as $schema ({}; . as $acc |
        reduce ($schema | keys[]) as $key (.;
          if $key == "properties" then
            .properties = (($acc.properties // {}) + $schema.properties)
          elif $key == "required" then
            .required = ((($acc.required // []) + $schema.required) | unique)
          elif $key == "$ref" or $key == "allOf" then
            # Skip — $refs are resolved before merging, allOf is being flattened
            .
          else
            .[$key] = $schema[$key]
          end
        )
      )
    end;

  # Helper: recursively resolve a schema, flattening any allOf compositions.
  # Follows $ref and allOf recursively up to a depth limit to avoid cycles.
  def resolve_and_flatten($root; $depth):
    if $depth > 5 then .
    elif has("$ref") then
      .["$ref"] | resolve_ref($root) | resolve_and_flatten($root; $depth + 1)
    elif has("allOf") then
      [.allOf[] | resolve_and_flatten($root; $depth + 1)] | deep_merge_schemas
    else .
    end;

  # ─── Pass 1: Flatten allOf response schemas ─────────────────────
  #
  # For each operation response schema that uses allOf:
  #   1. Resolve any $ref entries to their schema definitions
  #   2. Deep-merge all allOf members into a single flat schema
  #   3. Create a named schema in components/schemas
  #   4. Replace the inline allOf with a $ref to the new schema
  #
  # This converts patterns like:
  #   "schema": { "allOf": [ {"$ref": "#/.../base"}, {"properties": {"result": ...}} ] }
  # Into:
  #   "schema": { "$ref": "#/components/schemas/operationId_response" }
  # Plus a new entry in components/schemas with the merged properties.

  . as $root |

  # Collect all allOf flattening operations as {name, schema} pairs
  ([.paths | to_entries[] |
    .key as $pathKey |
    .value | to_entries[] |
    select(.key | test("^(get|put|post|delete|patch)$")) |
    .key as $method |
    .value.operationId as $opId |
    .value.responses // {} | to_entries[] |
    select(.key | test("^[23]")) |
    .key as $statusCode |
    .value.content // {} | to_entries[] |
    select(.key | test("json")) |
    .value.schema // {} |
    select(has("allOf")) |
    select(.allOf | length > 1) |
    # Build a schema name from the operationId
    (($opId // ($method + "_" + $pathKey)) | gsub("[^a-zA-Z0-9_-]"; "_")) as $baseName |
    ($baseName + "_response") as $schemaName |
    # Resolve and merge allOf members (recursively flattens nested allOf/$ref)
    {
      name: $schemaName,
      schema: ([.allOf[] | resolve_and_flatten($root; 0)] | deep_merge_schemas | .type = "object")
    }
  ]) as $new_schemas |

  # Add the new schemas to components/schemas
  (if ($new_schemas | length) > 0 then
    .components.schemas += ($new_schemas | map({(.name): .schema}) | add)
  else . end) |

  # Replace inline allOf in responses with $ref to the new named schema
  .paths |= (to_entries | map(
    .key as $pathKey |
    .value |= (to_entries | map(
      if (.key | test("^(get|put|post|delete|patch)$")) then
        .key as $method |
        .value as $op |
        (($op.operationId // ($method + "_" + $pathKey)) | gsub("[^a-zA-Z0-9_-]"; "_")) as $baseName |

        .value.responses |= (to_entries | map(
          if (.key | test("^[23]")) then
            .value.content |= (
              if . != null then
                to_entries | map(
                  if (.key | test("json")) and (.value.schema | has("allOf") // false) and (.value.schema.allOf | length > 1) then
                    .value.schema = {"$ref": ("#/components/schemas/" + $baseName + "_response")}
                  else . end
                ) | from_entries
              else . end
            )
          else . end
        ) | from_entries)
      else . end
    ) | from_entries)
  ) | from_entries) |

  # ─── Pass 1b: Flatten allOf in response-referenced named schemas ─
  #
  # Named schemas directly referenced from response schemas that
  # themselves use allOf suffer the same Hawaii limitation. Flatten only
  # these schemas in-place (not all named schemas, which would break
  # type name derivation for shared/base schemas).

  # Collect schema names directly referenced from response $refs
  ([.paths | to_entries[].value | to_entries[] |
    select(.key | test("^(get|put|post|delete|patch)$")) |
    .value.responses // {} | to_entries[] |
    select(.key | test("^[23]")) |
    .value.content // {} | to_entries[] |
    select(.key | test("json")) |
    .value.schema // {} |
    select(has("$ref")) |
    .["$ref"] | ltrimstr("#/components/schemas/")
  ] | unique) as $response_refs |

  . as $root2 |
  .components.schemas |= (to_entries | map(
    .key as $schema_name |
    if ($response_refs | any(. == $schema_name)) and (.value | has("allOf")) and (.value.allOf | length > 1) then
      .value = ([.value.allOf[] | resolve_and_flatten($root2; 0)] | deep_merge_schemas | .type = "object")
    else . end
  ) | from_entries) |

  # ─── Pass 2: Fix other Hawaii compatibility issues ──────────────

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
