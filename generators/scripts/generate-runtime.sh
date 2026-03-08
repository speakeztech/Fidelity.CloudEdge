#!/bin/bash
# generate-runtime.sh — Generate Fable-compatible F# bindings from Cloudflare TypeScript definitions
#
# Pipeline:
#   1. Preprocess TypeScript definitions (cycle breaking, intersection simplification)
#   2. Run Glutinum CLI to generate F# bindings
#   3. Post-process generated F# (fix imports, module names, type aliases)
#   4. Deploy to src/Runtime/ projects
#   5. Validate compilation

source "$(dirname "${BASH_SOURCE[0]}")/lib.sh"

GLUTINUM_TEMP="$GLUTINUM_DIR/temp"
mkdir -p "$GLUTINUM_TEMP"

# ─── Step 1: Preprocess ───────────────────────────────────────────

print_step "[1/5] Preprocessing TypeScript Definitions"

WORKERS_TYPES="$PROJECT_ROOT/node_modules/@cloudflare/workers-types/index.d.ts"
AI_TYPES="$PROJECT_ROOT/node_modules/@cloudflare/ai/dist/index.d.ts"

if [[ ! -f "$WORKERS_TYPES" ]]; then
    print_error "workers-types not found. Run: npm install"
    exit 1
fi

node "$SCRIPTS_DIR/preprocess-typescript.js" \
    "$WORKERS_TYPES" \
    "$GLUTINUM_TEMP/preprocessed-workers-types.d.ts"

print_success "Workers types preprocessed"

if [[ -f "$AI_TYPES" ]]; then
    node "$SCRIPTS_DIR/preprocess-typescript.js" \
        "$AI_TYPES" \
        "$GLUTINUM_TEMP/preprocessed-ai-types.d.ts"
    print_success "AI types preprocessed"
else
    print_warn "AI types not found, skipping"
fi

# ─── Step 2: Run Glutinum ─────────────────────────────────────────

print_step "[2/5] Running Glutinum Code Generation"

ensure_glutinum

# Generate worker context bindings
print_info "Generating Worker.Context bindings..."
if npx @glutinum/cli \
    "$GLUTINUM_TEMP/preprocessed-workers-types.d.ts" \
    --out-file "$GLUTINUM_TEMP/WorkerContext-Generated.fs" 2>"$GLUTINUM_TEMP/glutinum-worker.log"; then
    print_success "Worker.Context bindings generated"
else
    print_warn "Glutinum encountered errors (see glutinum-worker.log)"
    print_info "Attempting to use partial output..."
    if [[ ! -f "$GLUTINUM_TEMP/WorkerContext-Generated.fs" ]]; then
        print_error "No output generated for Worker.Context"
        # Fall back to existing hand-written types
        print_info "Keeping existing hand-written Types.fs"
    fi
fi

# Generate AI bindings if available
if [[ -f "$GLUTINUM_TEMP/preprocessed-ai-types.d.ts" ]]; then
    print_info "Generating AI bindings..."
    if npx @glutinum/cli \
        "$GLUTINUM_TEMP/preprocessed-ai-types.d.ts" \
        --out-file "$GLUTINUM_TEMP/AI-Generated.fs" 2>"$GLUTINUM_TEMP/glutinum-ai.log"; then
        print_success "AI bindings generated"
    else
        print_warn "Glutinum encountered errors for AI types (see glutinum-ai.log)"
    fi
fi

# ─── Step 3: Post-process ─────────────────────────────────────────

print_step "[3/5] Post-processing Generated F#"

bash "$SCRIPTS_DIR/postprocess-runtime.sh" "$GLUTINUM_TEMP"

# ─── Step 4: Deploy ───────────────────────────────────────────────

print_step "[4/5] Deploying Runtime Bindings"

WORKER_CTX_DIR="$SRC_DIR/Runtime/CloudEdge.Worker.Context"
AI_DIR="$SRC_DIR/Runtime/CloudEdge.AI"

if [[ -f "$GLUTINUM_TEMP/WorkerContext-Generated.fs" ]]; then
    cp "$GLUTINUM_TEMP/WorkerContext-Generated.fs" "$WORKER_CTX_DIR/Generated.fs"
    print_success "Deployed Worker.Context/Generated.fs"
else
    print_info "No Worker.Context generated output to deploy"
fi

if [[ -f "$GLUTINUM_TEMP/AI-Generated.fs" ]]; then
    cp "$GLUTINUM_TEMP/AI-Generated.fs" "$AI_DIR/Generated.fs"
    print_success "Deployed AI/Generated.fs"
else
    print_info "No AI generated output to deploy"
fi

# ─── Step 5: Validate ─────────────────────────────────────────────

print_step "[5/5] Validating Runtime Compilation"

RUNTIME_FAILED=0
for proj in "$WORKER_CTX_DIR" "$AI_DIR"; do
    proj_name=$(basename "$proj")
    fsproj=$(find "$proj" -name "*.fsproj" -maxdepth 1 2>/dev/null | head -1)
    if [[ -n "$fsproj" ]]; then
        if dotnet build "$fsproj" --nologo -v q 2>/dev/null; then
            print_success "$proj_name compiles"
        else
            print_warn "$proj_name has compilation errors (may need manual attention)"
            RUNTIME_FAILED=1
        fi
    fi
done

if [[ $RUNTIME_FAILED -eq 0 ]]; then
    print_success "Runtime generation complete"
else
    print_warn "Runtime generation complete with warnings"
fi
