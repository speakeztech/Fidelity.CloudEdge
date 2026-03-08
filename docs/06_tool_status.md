# Fidelity.CloudEdge Tool Status & Known Limitations

**Last Updated**: March 2026

This document tracks the current state of Glutinum and Hawaii as used by the CloudEdge generation pipeline, including known limitations and the mitigations in place.

For the original detailed analysis (Glutinum v0.12.0, Hawaii v0.66.0), see `_archived/06_tool_improvement_analysis_v1.md`.

## Tool Versions

| Tool | Version | Role |
|------|---------|------|
| Hawaii | 0.66.0 | OpenAPI → F# client generation |
| Glutinum CLI | Latest (npx) | TypeScript `.d.ts` → F# binding generation |

## Hawaii: Known Limitations & Mitigations

### 1. NullReferenceException on Empty Schema Entries

**Symptom**: Hawaii crashes when an OpenAPI spec contains `"application/json": {}` with no `schema` field in `requestBody` or response content.

**Root Cause**: `createResponseType` at line 1348 dereferences `.schema` unconditionally.

**Mitigation**: `generators/scripts/preprocess-openapi.sh` ensures every content-type entry has a schema field before Hawaii processes it.

**Services Affected**: KV, Workers, Logs (all now generating cleanly after preprocessing).

### 2. No Native Discriminator Schema Support

**Symptom**: OpenAPI specs using `discriminator` with `oneOf`/`anyOf` produce flat type lists with no discriminated union.

**Mitigation**: The `discriminators.fsx` post-processor generates F# DUs from the binding types. Currently applied to Workers (29 binding type variants).

### 3. Type Name Sanitization Inconsistencies

**Symptom**: Type names containing hyphens, underscores, and `@` symbols are sanitized inconsistently, producing names that do not match between `Types.fs` and `Client.fs`.

**Mitigation**: Manual compilation patches for affected services. Five services (KV, Workers, Logs, Queues, Vectorize) required type name fixes after generation.

**Desired Improvement**: Cumulative sanitization in Hawaii's `sanitizeTypeName` function. A local fork with this fix existed previously; the fix should be upstreamed.

### 4. Missing Body Parameters

**Symptom**: Some endpoints that accept a JSON request body generate client methods with no body parameter.

**Mitigation**: The `missing-body-params.fsx` post-processor adds the missing parameter and `RequestPart.jsonContent` to the requestParts list. Currently applied to Workers' `WorkerPutScriptSecret` method.

### 5. JObject in Multipart Form Data

**Symptom**: Methods using `multipartFormData` pass field values without JSON serialization, causing runtime errors for complex types.

**Mitigation**: The `jobject-multipart.fsx` post-processor adds `.ToString(Newtonsoft.Json.Formatting.None)` conversion where needed.

### 6. Package Dependencies

Hawaii's generated `OpenApiHttp.fs` imports `Fable.Remoting.Json` and `Newtonsoft.Json`. All management `.fsproj` files must reference these packages, not `FSharp.SystemTextJson`.

## Glutinum: Known Limitations & Mitigations

### 1. Cyclic Interface References

**Symptom**: Stack overflow during generation when TypeScript interfaces form reference cycles.

**Mitigation**: `generators/scripts/preprocess-typescript.js` detects cycles and breaks them by replacing back-references with `obj`. The preprocessor detected 6 cyclic interfaces in the current `workers-types` and applied 12 cycle-breaking replacements.

### 2. Reserved Keyword Handling

**Symptom**: Properties like `namespace`, `type`, `end` generate as backtick-escaped identifiers, degrading developer experience.

**Current State**: Backtick escaping works but is ergonomically poor. The preferred approach is `[<CompiledName("namespace")>]` with PascalCase member names, enabling clean F# while preserving JavaScript interop.

**Status**: Not yet automated in Glutinum. Would require a PR to Glutinum's property emission logic.

### 3. Object Expression Syntax (FS3168)

**Symptom**: Glutinum generates `member val` inside object expressions, which F# does not allow.

**Mitigation**: Handled by `postprocess-runtime.sh`, which converts to getter/setter with backing fields.

### 4. Global Values in Namespaces (FS0201)

**Symptom**: Global values placed directly in namespaces produce compilation errors.

**Mitigation**: Handled by `postprocess-runtime.sh`, which wraps globals in a `Globals` module.

## Shared Challenges

### Reserved Keywords in Both Pipelines

Both tools face F# reserved keyword conflicts but resolve them through different mechanisms:

| Aspect | Glutinum (Runtime) | Hawaii (Management) |
|--------|-------------------|---------------------|
| Source truth | JavaScript property names | JSON property names |
| Ideal attribute | `[<CompiledName>]` | `[<JsonPropertyName>]` |
| Target compiler | Fable (JS interop) | Any (JSON serialization) |
| Current approach | Backtick escaping | Backtick escaping |

### Type Ordering Dependencies

F#'s top-down type system requires types to be declared before use. Both tools occasionally generate types in the wrong order. The runtime post-processor handles this for Glutinum output; Hawaii's output has not exhibited this issue with the current service set.

## Upstream Contribution Opportunities

1. **Hawaii**: Cumulative type name sanitization (hyphen + underscore handling)
2. **Hawaii**: Null-safe schema access in `createResponseType`
3. **Hawaii**: Native discriminator schema support (would eliminate the `discriminators.fsx` post-processor)
4. **Glutinum**: `[<CompiledName>]` attribute emission for reserved keywords
5. **Glutinum**: Record generation for pure data structures (currently generates interfaces)
