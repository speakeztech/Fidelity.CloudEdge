module Fidelity.CloudEdge.Tests.PreprocessorTests

open Expecto
open System
open System.Diagnostics
open System.IO

/// Tests the OpenAPI preprocessor script (preprocess-openapi.sh) that flattens
/// inline allOf response schemas into named schemas. Verifies that the jq-based
/// transformation produces valid OpenAPI specs where response schemas use $ref
/// instead of inline allOf compositions.

// ─── Helpers ────────────────────────────────────────────────────

let private repoRoot =
    let mutable dir = DirectoryInfo(AppContext.BaseDirectory)
    while dir <> null && not (File.Exists(Path.Combine(dir.FullName, "Fidelity.CloudEdge.sln"))) do
        dir <- dir.Parent
    if dir <> null then dir.FullName
    else failwith "Could not find repository root"

let private preprocessorScript = Path.Combine(repoRoot, "generators", "scripts", "preprocess-openapi.sh")
let private specDir = Path.Combine(repoRoot, "generators", "hawaii", "temp")

let private runJq (jqFilter: string) (jsonFile: string) : Result<string, string> =
    let psi = ProcessStartInfo("jq")
    psi.ArgumentList.Add("-r")
    psi.ArgumentList.Add(jqFilter)
    psi.ArgumentList.Add(jsonFile)
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError <- true
    psi.UseShellExecute <- false
    try
        use proc = Process.Start(psi)
        let output = proc.StandardOutput.ReadToEnd()
        let error = proc.StandardError.ReadToEnd()
        proc.WaitForExit(10000) |> ignore
        if proc.ExitCode = 0 then Ok (output.Trim())
        else Error $"jq failed (exit {proc.ExitCode}): {error}"
    with ex -> Error $"Failed to run jq: {ex.Message}"

let private runPreprocessor (inputFile: string) (outputFile: string) : Result<unit, string> =
    let psi = ProcessStartInfo("bash")
    psi.ArgumentList.Add(preprocessorScript)
    psi.ArgumentList.Add(inputFile)
    psi.ArgumentList.Add(outputFile)
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError <- true
    psi.UseShellExecute <- false
    try
        use proc = Process.Start(psi)
        let output = proc.StandardOutput.ReadToEnd()
        let error = proc.StandardError.ReadToEnd()
        proc.WaitForExit(30000) |> ignore
        if proc.ExitCode = 0 then Ok ()
        else Error $"Preprocessor failed (exit {proc.ExitCode}): {error}\n{output}"
    with ex -> Error $"Failed to run preprocessor: {ex.Message}"

/// Count how many inline allOf schemas exist in success response bodies (2xx/3xx)
let private countInlineAllOfInResponses (jsonFile: string) =
    // Uses jq to walk all success response schemas and count those with inline allOf
    let filter =
        "[.paths | to_entries[].value | to_entries[] " +
        "| select(.key | test(\"^(get|put|post|delete|patch)$\")) " +
        "| .value.responses | to_entries[] " +
        "| select(.key | test(\"^[23]\")) | .value " +
        "| .content?[\"application/json\"]?.schema? // empty " +
        "| select(has(\"allOf\")) | select(.allOf | length > 1)] | length"
    match runJq filter jsonFile with
    | Ok count -> int count
    | Error _ -> -1

/// Count named schemas matching a pattern
let private countSchemasMatching (jsonFile: string) (pattern: string) =
    match runJq $".components.schemas | keys[] | select(endswith(\"{pattern}\"))" jsonFile with
    | Ok output ->
        if String.IsNullOrWhiteSpace(output) then 0
        else output.Split('\n', StringSplitOptions.RemoveEmptyEntries).Length
    | Error _ -> -1

/// Check if a specific schema exists and has a 'properties' field (is a flat record)
let private schemaHasProperties (jsonFile: string) (schemaName: string) =
    match runJq $".components.schemas[\"{schemaName}\"] | has(\"properties\")" jsonFile with
    | Ok "true" -> true
    | _ -> false

/// Check if a schema still contains an allOf (i.e., was not fully flattened)
let private schemaHasAllOf (jsonFile: string) (schemaName: string) =
    match runJq $".components.schemas[\"{schemaName}\"] | has(\"allOf\")" jsonFile with
    | Ok "true" -> true
    | _ -> false

/// Get the response schema ref for an operation
let private getResponseSchemaRef (jsonFile: string) (path: string) (method: string) =
    let filter = $".paths[\"{path}\"].{method}.responses[\"200\"].content[\"application/json\"].schema[\"$ref\"] // \"none\""
    match runJq filter jsonFile with
    | Ok ref -> ref
    | Error e -> $"error: {e}"

// ─── Spec File Availability ─────────────────────────────────────

let private specAvailabilityTests =
    testList "Spec File Availability" [

        testCase "Preprocessor script exists" <| fun _ ->
            Expect.isTrue (File.Exists preprocessorScript)
                $"Preprocessor script should exist at {preprocessorScript}"

        testCase "R2 spec exists" <| fun _ ->
            let specFile = Path.Combine(specDir, "R2-openapi.json")
            Expect.isTrue (File.Exists specFile)
                $"R2 spec should exist at {specFile}"

        testCase "D1 spec exists" <| fun _ ->
            let specFile = Path.Combine(specDir, "D1-openapi.json")
            Expect.isTrue (File.Exists specFile)
                $"D1 spec should exist at {specFile}"
    ]

// ─── allOf Flattening Tests ─────────────────────────────────────

let private allOfFlatteningTests =
    testList "allOf Flattening" [

        testCase "R2: preprocessor eliminates all inline allOf in responses" <| fun _ ->
            let inputFile = Path.Combine(specDir, "R2-openapi.json")
            if not (File.Exists inputFile) then skiptest "R2 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    let remainingAllOf = countInlineAllOfInResponses outputFile
                    Expect.equal remainingAllOf 0
                        $"After preprocessing, R2 should have 0 inline allOf in responses (found {remainingAllOf})"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile

        testCase "D1: preprocessor eliminates all inline allOf in responses" <| fun _ ->
            let inputFile = Path.Combine(specDir, "D1-openapi.json")
            if not (File.Exists inputFile) then skiptest "D1 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    let remainingAllOf = countInlineAllOfInResponses outputFile
                    Expect.equal remainingAllOf 0
                        $"After preprocessing, D1 should have 0 inline allOf in responses (found {remainingAllOf})"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile

        testCase "Workers: preprocessor eliminates all inline allOf in responses" <| fun _ ->
            let inputFile = Path.Combine(specDir, "Workers-openapi.json")
            if not (File.Exists inputFile) then skiptest "Workers spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    let remainingAllOf = countInlineAllOfInResponses outputFile
                    Expect.equal remainingAllOf 0
                        $"After preprocessing, Workers should have 0 inline allOf in responses (found {remainingAllOf})"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile

        testCase "All available specs: preprocessor eliminates inline allOf" <| fun _ ->
            let specs = ["R2"; "D1"; "Workers"; "Pages"; "KV"; "Hyperdrive"]
            let mutable failures = []
            for spec in specs do
                let inputFile = Path.Combine(specDir, $"{spec}-openapi.json")
                if File.Exists inputFile then
                    let outputFile = Path.GetTempFileName()
                    try
                        match runPreprocessor inputFile outputFile with
                        | Ok () ->
                            let remaining = countInlineAllOfInResponses outputFile
                            if remaining > 0 then
                                failures <- $"{spec}: {remaining} inline allOf remaining" :: failures
                        | Error e ->
                            failures <- $"{spec}: preprocessor error: {e}" :: failures
                    finally
                        if File.Exists outputFile then File.Delete outputFile

            if failures.Length > 0 then
                let details = String.concat "\n  " failures
                failtest $"allOf flattening failures:\n  {details}"
    ]

// ─── Named Schema Generation Tests ─────────────────────────────

let private namedSchemaTests =
    testList "Named Schema Generation" [

        testCase "R2: preprocessor creates _response named schemas" <| fun _ ->
            let inputFile = Path.Combine(specDir, "R2-openapi.json")
            if not (File.Exists inputFile) then skiptest "R2 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    let count = countSchemasMatching outputFile "_response"
                    Expect.isGreaterThan count 0
                        $"R2 should have _response schemas after preprocessing (found {count})"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile

        testCase "R2: flattened schemas have properties (not allOf)" <| fun _ ->
            let inputFile = Path.Combine(specDir, "R2-openapi.json")
            if not (File.Exists inputFile) then skiptest "R2 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    let schemas = ["r2-list-buckets_response"; "r2-create-bucket_response"; "r2-get-bucket_response"]
                    for schema in schemas do
                        let hasProps = schemaHasProperties outputFile schema
                        let hasAllOf = schemaHasAllOf outputFile schema
                        Expect.isTrue hasProps
                            $"Schema '{schema}' should have direct properties"
                        Expect.isFalse hasAllOf
                            $"Schema '{schema}' should not contain allOf (should be fully flattened)"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile

        testCase "D1: flattened schemas have properties (not allOf)" <| fun _ ->
            let inputFile = Path.Combine(specDir, "D1-openapi.json")
            if not (File.Exists inputFile) then skiptest "D1 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    let schemas = ["d1-list-databases_response"; "d1-create-database_response"]
                    for schema in schemas do
                        let hasProps = schemaHasProperties outputFile schema
                        let hasAllOf = schemaHasAllOf outputFile schema
                        Expect.isTrue hasProps
                            $"Schema '{schema}' should have direct properties"
                        Expect.isFalse hasAllOf
                            $"Schema '{schema}' should not contain allOf (should be fully flattened)"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile
    ]

// ─── Response $ref Replacement Tests ────────────────────────────

let private refReplacementTests =
    testList "Response $ref Replacement" [

        testCase "R2 list buckets: response points to named schema" <| fun _ ->
            let inputFile = Path.Combine(specDir, "R2-openapi.json")
            if not (File.Exists inputFile) then skiptest "R2 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    let ref = getResponseSchemaRef outputFile "/accounts/{account_id}/r2/buckets" "get"
                    Expect.stringContains ref "#/components/schemas/"
                        "R2 list buckets response should use a $ref"
                    Expect.isFalse (ref = "none")
                        "R2 list buckets should have a response schema ref"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile

        testCase "R2 delete bucket: existing $ref is preserved" <| fun _ ->
            let inputFile = Path.Combine(specDir, "R2-openapi.json")
            if not (File.Exists inputFile) then skiptest "R2 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    let ref = getResponseSchemaRef outputFile "/accounts/{account_id}/r2/buckets/{bucket_name}" "delete"
                    Expect.equal ref "#/components/schemas/r2_v4_response"
                        "R2 delete bucket should still reference r2_v4_response directly"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile
    ]

// ─── Cloudflare Envelope Validation Tests ───────────────────────

let private envelopeValidationTests =
    testList "Cloudflare Envelope Validation" [

        testCase "Flattened schemas contain Cloudflare envelope fields" <| fun _ ->
            let inputFile = Path.Combine(specDir, "R2-openapi.json")
            if not (File.Exists inputFile) then skiptest "R2 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    // Verify the flattened schema has success, errors, messages, result
                    let filter = ".components.schemas[\"r2-list-buckets_response\"].properties | keys"
                    match runJq filter outputFile with
                    | Ok keys ->
                        Expect.stringContains keys "success" "Should have 'success' field"
                        Expect.stringContains keys "errors" "Should have 'errors' field"
                        Expect.stringContains keys "result" "Should have 'result' field"
                    | Error e -> failtest $"jq failed: {e}"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile

        testCase "Flattened schemas have required fields" <| fun _ ->
            let inputFile = Path.Combine(specDir, "R2-openapi.json")
            if not (File.Exists inputFile) then skiptest "R2 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    let filter = ".components.schemas[\"r2-create-bucket_response\"].required"
                    match runJq filter outputFile with
                    | Ok required ->
                        Expect.stringContains required "success" "success should be required"
                        Expect.stringContains required "errors" "errors should be required"
                        Expect.stringContains required "result" "result should be required"
                    | Error e -> failtest $"jq failed: {e}"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile

        testCase "Flattened result field preserves endpoint-specific type" <| fun _ ->
            let inputFile = Path.Combine(specDir, "R2-openapi.json")
            if not (File.Exists inputFile) then skiptest "R2 spec not available"

            let outputFile = Path.GetTempFileName()
            try
                match runPreprocessor inputFile outputFile with
                | Ok () ->
                    // r2-create-bucket_response.result should reference r2_bucket
                    let filter = ".components.schemas[\"r2-create-bucket_response\"].properties.result[\"$ref\"] // \"none\""
                    match runJq filter outputFile with
                    | Ok ref ->
                        Expect.equal ref "#/components/schemas/r2_bucket"
                            "create-bucket result should reference r2_bucket schema"
                    | Error e -> failtest $"jq failed: {e}"

                    // r2-list-buckets_response.result should have buckets array
                    let filter2 = ".components.schemas[\"r2-list-buckets_response\"].properties.result.properties.buckets.type // \"none\""
                    match runJq filter2 outputFile with
                    | Ok resultType ->
                        Expect.equal resultType "array"
                            "list-buckets result should have buckets array"
                    | Error e -> failtest $"jq failed: {e}"
                | Error e -> failtest $"Preprocessor failed: {e}"
            finally
                if File.Exists outputFile then File.Delete outputFile
    ]

// ─── Idempotency Tests ─────────────────────────────────────────

let private idempotencyTests =
    testList "Preprocessor Idempotency" [

        testCase "Running preprocessor twice produces same output" <| fun _ ->
            let inputFile = Path.Combine(specDir, "R2-openapi.json")
            if not (File.Exists inputFile) then skiptest "R2 spec not available"

            let output1 = Path.GetTempFileName()
            let output2 = Path.GetTempFileName()
            try
                match runPreprocessor inputFile output1 with
                | Ok () ->
                    match runPreprocessor output1 output2 with
                    | Ok () ->
                        let content1 = File.ReadAllText(output1)
                        let content2 = File.ReadAllText(output2)
                        Expect.equal content2 content1
                            "Preprocessing an already-preprocessed spec should be idempotent"
                    | Error e -> failtest $"Second preprocessing failed: {e}"
                | Error e -> failtest $"First preprocessing failed: {e}"
            finally
                if File.Exists output1 then File.Delete output1
                if File.Exists output2 then File.Delete output2
    ]

// ─── Test Entry Point ───────────────────────────────────────────

let tests =
    testList "Preprocessor Tests" [
        specAvailabilityTests
        allOfFlatteningTests
        namedSchemaTests
        refReplacementTests
        envelopeValidationTests
        idempotencyTests
    ]
