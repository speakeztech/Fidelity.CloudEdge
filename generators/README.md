# Fidelity.CloudEdge Generators

Code generation tooling for Fidelity.CloudEdge, driven by a central service registry (`services.json`) and orchestrated through bash scripts.

## Structure

```
generators/
├── services.json                  # Master service registry (32 services)
├── scripts/                       # Orchestration and utility scripts
│   ├── generate-management.sh     # Management API generation pipeline
│   ├── generate-runtime.sh        # Runtime binding generation pipeline
│   ├── extract-service.sh         # OpenAPI subset extraction per service
│   ├── preprocess-openapi.sh      # Fixes Hawaii-incompatible OpenAPI patterns
│   ├── preprocess-typescript.js   # Cycle breaking and intersection simplification
│   ├── postprocess-runtime.sh     # F# post-processing for Glutinum output
│   ├── scaffold-management-project.sh  # Creates new management project from template
│   ├── validate.sh                # Structural validation of generated output
│   └── lib.sh                     # Shared functions and constants
├── hawaii/                        # Hawaii (OpenAPI → F#) configuration
│   ├── *-hawaii.json              # Per-service Hawaii configs
│   ├── postprocessors/            # Parameterized F# post-processing scripts
│   │   ├── discriminators.fsx     # Generates DUs from binding types
│   │   ├── jobject-multipart.fsx  # Fixes JObject multipart form data
│   │   └── missing-body-params.fsx # Adds missing body parameters
│   └── temp/                      # Working directory for extracted specs
└── glutinum/                      # Glutinum (TypeScript → F#) configuration
    └── temp/                      # Working directory for preprocessed .d.ts
```

## Service Registry

`services.json` is the single source of truth for all generation. Each service entry defines its OpenAPI path patterns, Hawaii config file, target namespace, and any post-processors required. All services are now marked `"active"` and generating.

Current counts: 32 active.

## Usage

### Management API Generation (Hawaii)

Generate all active services:

```bash
cd generators
bash scripts/generate-management.sh --active-only
```

Generate a single service:

```bash
bash scripts/generate-management.sh --service workers
```

The pipeline for each service: download OpenAPI spec → extract service subset → preprocess spec → run Hawaii → run post-processors → deploy to `src/Management/` → validate compilation.

### Runtime Binding Generation (Glutinum)

```bash
bash scripts/generate-runtime.sh
```

The pipeline: preprocess TypeScript definitions (cycle breaking) → run Glutinum CLI → post-process generated F# → deploy to `src/Runtime/` → validate compilation.

### Scaffold a New Service

```bash
bash scripts/scaffold-management-project.sh <service-key>
```

Creates the project directory, `.fsproj`, and adds it to the solution. The service key must exist in `services.json`.

### Validation

```bash
bash scripts/validate.sh --active-only
```

Checks that generated projects have the expected file structure (`Types.fs`, `Client.fs`, etc.) and compile without errors.

## Post-Processors

Hawaii has known limitations with certain OpenAPI patterns. Post-processors are declared per-service in `services.json` and run automatically during generation.

| Post-Processor | Purpose | Configuration |
|----------------|---------|---------------|
| `discriminators` | Generates F# discriminated unions from OpenAPI discriminator schemas | `listType`, `itemType`, `kindPrefix` |
| `jobject-multipart` | Fixes JObject serialization in multipart form data | None (generic scan) |
| `missing-body-params` | Adds missing request body parameters to client methods | `methodName`, `bodyType` |

## OpenAPI Preprocessing

The Cloudflare OpenAPI spec (~8.3MB) contains patterns that cause Hawaii to throw `NullReferenceException`, specifically empty `application/json: {}` content entries with no `schema` field. The `preprocess-openapi.sh` script fixes these before generation.

## Known Limitations

- Hawaii does not natively support OpenAPI discriminator schemas (handled by the `discriminators` post-processor)
- Glutinum has stack overflow issues with deeply recursive TypeScript interfaces (handled by `preprocess-typescript.js` cycle breaking)
- Some generated type names require backtick escaping in F# due to hyphens and special characters in the OpenAPI spec
