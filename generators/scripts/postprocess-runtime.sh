#!/bin/bash
# postprocess-runtime.sh — Fix common Glutinum output issues
#
# Known patterns:
# 1. REPLACE_ME_WITH_MODULE_NAME placeholder in imports
# 2. Backtick-wrapped module names that aren't valid F#
# 3. Missing namespace declarations
# 4. Duplicate type definitions from partial interface merging
#
# Usage: postprocess-runtime.sh <temp-dir>

source "$(dirname "${BASH_SOURCE[0]}")/lib.sh"

TEMP="$1"
if [[ -z "$TEMP" || ! -d "$TEMP" ]]; then
    print_error "Usage: postprocess-runtime.sh <temp-dir>"
    exit 1
fi

fixups=0

for generated in "$TEMP"/*-Generated.fs; do
    [[ -f "$generated" ]] || continue
    basename=$(basename "$generated")
    print_info "Post-processing $basename..."

    # Fix 1: Replace module name placeholder
    if grep -q "REPLACE_ME_WITH_MODULE_NAME" "$generated"; then
        if [[ "$basename" == *Worker* ]]; then
            sed -i 's/REPLACE_ME_WITH_MODULE_NAME/Fidelity.CloudEdge.Worker.Context/g' "$generated"
        elif [[ "$basename" == *AI* ]]; then
            sed -i 's/REPLACE_ME_WITH_MODULE_NAME/Fidelity.CloudEdge.AI/g' "$generated"
        fi
        fixups=$((fixups + 1))
    fi

    # Fix 2: Ensure namespace is present at top of file
    if ! head -5 "$generated" | grep -q "^namespace\|^module"; then
        if [[ "$basename" == *Worker* ]]; then
            sed -i '1i\namespace Fidelity.CloudEdge.Worker.Context\n' "$generated"
        elif [[ "$basename" == *AI* ]]; then
            sed -i '1i\namespace Fidelity.CloudEdge.AI\n' "$generated"
        fi
        fixups=$((fixups + 1))
    fi

    # Fix 3: Remove backtick-wrapped module names that break compilation
    # Glutinum sometimes generates: module ``cloudflare:workers`` =
    # Replace with sanitized names
    sed -i 's/module ``cloudflare:\([^`]*\)``/module Cloudflare_\1/g' "$generated"
    sed -i "s/module \`\`@cloudflare\/\([^\`]*\)\`\`/module Cloudflare_\1/g" "$generated"

    # Fix 4: Replace 'obj' return types from cycle-broken 'any' with proper types
    # (Glutinum translates TypeScript 'any' to F# 'obj')
    # This is expected and correct for cycle-broken references

    # Fix 5: Remove duplicate open statements
    awk '!seen[$0]++ || !/^open /' "$generated" > "$generated.tmp" && mv "$generated.tmp" "$generated"

    # Fix 6: Ensure Fable.Core imports are present
    if ! grep -q "open Fable.Core" "$generated"; then
        sed -i '/^namespace/a\\nopen Fable.Core\nopen Fable.Core.JsInterop' "$generated"
        fixups=$((fixups + 1))
    fi

    line_count=$(wc -l < "$generated")
    print_success "$basename: $line_count lines, $fixups fixups applied"
done
