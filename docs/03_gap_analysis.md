# Fidelity.CloudEdge Gap Analysis & Service Maturity

**Last Updated**: March 2026

## Executive Summary

Fidelity.CloudEdge has completed its generation pipeline maturity. All 32 management services are now active and generating from the Cloudflare OpenAPI spec via Hawaii, and both runtime binding targets (Worker.Context, AI) generate from `@cloudflare/workers-types` via Glutinum. The generation pipeline is config-driven through `services.json`, fully automated via bash scripts, and validated through structural tests (501 passing). A CI/CD workflow (`regenerate-bindings.yml`) handles weekly regeneration from upstream sources.

The project has moved from "can we generate?" to "comprehensive platform coverage."

## Service Maturity Status

### Generation Status Legend

- ✅ **Active**: Generating, compiling, and structurally validated
- 🔧 **Active + Post-Processing**: Generating with post-processor pipeline
- 📋 **Planned**: Scaffolded in solution, Hawaii config exists, awaiting activation
- ❌ **Not Configured**: No generation infrastructure yet

### Management APIs (Hawaii-Generated)

| Service | Key | Status | Post-Processors | Notes |
|---------|-----|--------|-----------------|-------|
| D1 | `d1` | ✅ Active | None | |
| R2 | `r2` | ✅ Active | None | |
| KV | `kv` | ✅ Active | None | Previously blocked by Hawaii NullRef; resolved via `preprocess-openapi.sh` |
| Workers | `workers` | 🔧 Active | discriminators, jobject-multipart, missing-body-params | Most complex service; 29 binding type DU |
| Analytics | `analytics` | ✅ Active | None | |
| Logs | `logs` | ✅ Active | None | Required type alias patches for `logsharestart`/`logshareend` |
| Queues | `queues` | ✅ Active | None | Required DU type additions for `mqconsumer-response`, `mqproducer` |
| Vectorize | `vectorize` | ✅ Active | None | V2 API; required backtick escaping for `@`-prefixed DU patterns |
| Hyperdrive | `hyperdrive` | ✅ Active | None | |
| Durable Objects | `durable-objects` | ✅ Active | None | |
| Pages | `pages` | ✅ Active | None | Uses `pathPrefix` extraction |
| AI | `ai` | ✅ Active | None | |
| AI Gateway | `ai-gateway` | ✅ Active | None | |
| AI Search | `ai-search` | ✅ Active | None | |
| AutoRAG | `autorag` | ✅ Active | None | |
| Containers | `containers` | ✅ Active | None | |
| Workflows | `workflows` | ✅ Active | None | |
| Pipelines | `pipelines` | ✅ Active | None | |
| Browser Rendering | `browser-rendering` | ✅ Active | None | |
| Stream | `stream` | ✅ Active | None | |
| Images | `images` | ✅ Active | None | |
| R2 Catalog | `r2-catalog` | ✅ Active | None | |
| Secrets Store | `secrets-store` | ✅ Active | None | |
| Tunnels | `tunnels` | ✅ Active | None | |
| Access | `access` | ✅ Active | None | |
| Gateway | `gateway` | ✅ Active | None | |
| Email | `email` | ✅ Active | None | |
| Calls | `calls` | ✅ Active | None | |
| Builds | `builds` | ✅ Active | None | |
| Load Balancers | `load-balancers` | ✅ Active | None | |
| Waiting Rooms | `waiting-rooms` | ✅ Active | None | |
| Magic | `magic` | ✅ Active | None | |

### Runtime Bindings (Glutinum-Generated)

| Target | Source | Lines Generated | Status |
|--------|--------|----------------|--------|
| Worker.Context | `@cloudflare/workers-types` | 17,876 | ✅ Active |
| AI | `@cloudflare/ai` | ~1,200 | ✅ Active |

Both runtime targets compile cleanly. The preprocessor detects and breaks cyclic interface references automatically.

## Pipeline Infrastructure

| Component | Status | Notes |
|-----------|--------|-------|
| `services.json` registry | ✅ | 32 services configured |
| OpenAPI spec extraction | ✅ | `jq`-based, supports `pathPatterns` and `pathPrefix` |
| OpenAPI preprocessing | ✅ | Fixes Hawaii NullRef on empty schema entries |
| TypeScript preprocessing | ✅ | Cycle breaking, intersection simplification |
| Hawaii generation | ✅ | 32 services passing |
| Glutinum generation | ✅ | 2 targets passing |
| Post-processor framework | ✅ | 3 parameterized post-processors, config-driven |
| Project scaffolding | ✅ | Automated `.fsproj` creation and solution integration |
| Structural validation | ✅ | 501 tests passing (Expecto) |
| CI/CD regeneration | ✅ | Weekly schedule + manual dispatch, automated PR creation |

## Remaining Gaps

### High Priority

**1. Test Coverage**

Structural tests verify that generated types and client methods exist. Missing: integration tests that exercise the generated clients against the Cloudflare API, serialization round-trip tests, and Fable compilation validation.

**3. Version Pegging**

No mechanism currently locks generated output to specific upstream versions. The CI/CD workflow regenerates from latest, but there is no diff analysis or breaking change detection. A version manifest tracking the OpenAPI spec hash and `workers-types` version per generation run would close this gap.

### Medium Priority

**4. Post-Generation Patches**

Five services (KV, Workers, Logs, Queues, Vectorize) required manual compilation fixes after Hawaii generation. These patches are applied once and persist, but will need reapplication if the services are regenerated. Encoding these as additional post-processors would make regeneration fully automated.

**5. Fable Compilation Validation**

Management APIs are designed to compile via Fable for browser-based tooling. The current validation only runs `dotnet build`. Adding a Fable compilation step to the CI pipeline would catch portability regressions.

### Low Priority

**6. Browser Standard APIs (Runtime)**

Streams, Cache, and WebCrypto APIs are available in `workers-types` but do not have dedicated CloudEdge projects. These are covered by the monolithic `Worker.Context/Generated.fs` binding; dedicated typed wrappers would improve ergonomics.

**7. Sample Application Coverage**

HelloWorker and SecureChat demonstrate basic usage. Additional samples targeting Queues, Vectorize, Hyperdrive, and Durable Objects would validate the generated bindings in realistic scenarios.

## Metrics

| Metric | Current | Target |
|--------|---------|--------|
| Active management services | 32 / 32 | 32 / 32 |
| Runtime binding targets | 2 / 2 | 2 / 2 |
| Post-generation manual patches | 5 services | 0 (automated) |
| Structural test assertions | 501 passing | Expand per service |
| Integration tests | 0 | Per active service |
| CI/CD regeneration | Weekly | Weekly + on upstream release |
| Version pegging | None | Per-generation manifest |
