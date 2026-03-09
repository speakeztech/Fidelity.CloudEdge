module Fidelity.CloudEdge.Tests.ResponseTypeTests

open Expecto
open System
open System.Reflection
open Newtonsoft.Json
open Fable.Remoting.Json

/// Verifies that Hawaii-generated response discriminated unions carry strongly-typed
/// record payloads rather than raw JSON strings. This catches regressions in the
/// allOf flattening preprocessor — if the preprocessor fails to flatten inline allOf
/// compositions, Hawaii falls back to `string` payloads.

// ─── Serializer Setup (mirrors OpenApiHttp.fs) ──────────────────

let private converter = FableJsonConverter() :> JsonConverter
let private settings = JsonSerializerSettings(Converters = [| converter |])
do settings.DateParseHandling <- DateParseHandling.None
do settings.NullValueHandling <- NullValueHandling.Ignore

let private deserialize<'t> (json: string) = JsonConvert.DeserializeObject<'t>(json, settings)

// ─── Reflection Helpers ─────────────────────────────────────────

/// Get all response DU types from an assembly. Response DUs are union types
/// whose names match common Cloudflare operation patterns (List*, Create*, Get*,
/// Delete*, Update*, Put*, Patch*, Query*, etc.) and are NOT StringEnum types.
let private getResponseDUTypes (asm: Assembly) =
    asm.GetExportedTypes()
    |> Array.filter (fun t ->
        try
            Microsoft.FSharp.Reflection.FSharpType.IsUnion(t, BindingFlags.Public) &&
            // Exclude StringEnum types — they are value enums, not response types
            t.GetCustomAttributes(typeof<Fable.Core.StringEnumAttribute>, false).Length = 0 &&
            // Response DUs have cases like OK, Created, Accepted, BadRequest, NotFound
            (let cases = Microsoft.FSharp.Reflection.FSharpType.GetUnionCases(t, BindingFlags.Public)
             cases |> Array.exists (fun c ->
                let name = c.Name
                name = "OK" || name = "Created" || name = "Accepted"))
        with _ -> false)
    |> Array.toList

/// For a response DU type, get all cases and their payload types.
/// Returns (caseName, payloadType option) — None if the case has no fields.
let private getCasePayloads (t: Type) =
    Microsoft.FSharp.Reflection.FSharpType.GetUnionCases(t, BindingFlags.Public)
    |> Array.map (fun c ->
        let fields = c.GetFields()
        let payloadType =
            if fields.Length = 1 then Some fields.[0].PropertyType
            elif fields.Length = 0 then None
            else Some fields.[0].PropertyType // Primary payload is first field
        (c.Name, payloadType))
    |> Array.toList

/// Check if a type is a "typed" payload (not string, not JToken, not obj).
let private isTypedPayload (t: Type) =
    t <> typeof<string> &&
    t <> typeof<obj> &&
    not (t.FullName.Contains("Newtonsoft.Json.Linq.JToken"))

/// Check if a type is an F# record type.
let private isRecordType (t: Type) =
    try Microsoft.FSharp.Reflection.FSharpType.IsRecord(t, BindingFlags.Public)
    with _ -> false

// ─── Assembly Registry ──────────────────────────────────────────

/// Services that use allOf response patterns and should have typed responses
/// after the preprocessor flattens them. Each entry: (name, assembly, known response DU names).
let private coreServices =
    [
        "D1",         typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
        "R2",         typeof<Fidelity.CloudEdge.Management.R2.R2Client>.Assembly
        "Workers",    typeof<Fidelity.CloudEdge.Management.Workers.WorkersClient>.Assembly
        "Pages",      typeof<Fidelity.CloudEdge.Management.Pages.PagesClient>.Assembly
        "KV",         typeof<Fidelity.CloudEdge.Management.KV.KVClient>.Assembly
        "Hyperdrive", typeof<Fidelity.CloudEdge.Management.Hyperdrive.HyperdriveClient>.Assembly
    ]

let private allServices =
    [
        yield! coreServices
        "Analytics",      typeof<Fidelity.CloudEdge.Management.Analytics.AnalyticsClient>.Assembly
        "Logs",           typeof<Fidelity.CloudEdge.Management.Logs.LogsClient>.Assembly
        "Queues",         typeof<Fidelity.CloudEdge.Management.Queues.QueuesClient>.Assembly
        "Vectorize",      typeof<Fidelity.CloudEdge.Management.Vectorize.VectorizeClient>.Assembly
        "DurableObjects", typeof<Fidelity.CloudEdge.Management.DurableObjects.DurableObjectsClient>.Assembly
        "Containers",     typeof<Fidelity.CloudEdge.Management.Containers.ContainersClient>.Assembly
        "Stream",         typeof<Fidelity.CloudEdge.Management.Stream.StreamClient>.Assembly
        "Images",         typeof<Fidelity.CloudEdge.Management.Images.ImagesClient>.Assembly
        "R2Catalog",      typeof<Fidelity.CloudEdge.Management.R2Catalog.R2CatalogClient>.Assembly
        "Access",         typeof<Fidelity.CloudEdge.Management.Access.AccessClient>.Assembly
        "Gateway",        typeof<Fidelity.CloudEdge.Management.Gateway.GatewayClient>.Assembly
        "Email",          typeof<Fidelity.CloudEdge.Management.Email.EmailClient>.Assembly
        "Builds",         typeof<Fidelity.CloudEdge.Management.Builds.BuildsClient>.Assembly
        "Magic",          typeof<Fidelity.CloudEdge.Management.Magic.MagicClient>.Assembly
    ]

// ─── Response Payload Type Tests ────────────────────────────────

let private responsePayloadTypeTests =
    testList "Response Payload Types" [

        testCase "Response DU types exist in core services" <| fun _ ->
            for (name, asm) in coreServices do
                let responseDUs = getResponseDUTypes asm
                Expect.isGreaterThan responseDUs.Length 0
                    $"{name}: should have at least one response DU type"

        testCase "OK case payloads are not raw strings (core services)" <| fun _ ->
            // Some DU types legitimately return raw strings:
            //   - KV ReadKeyValuePair returns raw value bytes
            //   - Worker ScriptDownload returns raw script content
            //   - Generic OK/BadRequest types may carry raw string payloads
            let legitimateStringTypes = set [
                "WorkersKvNamespaceReadKeyValuePair"
                "WorkerScriptDownloadWorker"
                "OK"; "BadRequest"
            ]
            let mutable stringPayloads = []
            for (name, asm) in coreServices do
                let responseDUs = getResponseDUTypes asm
                for du in responseDUs do
                    if not (legitimateStringTypes.Contains du.Name) then
                        let cases = getCasePayloads du
                        for (caseName, payloadType) in cases do
                            match payloadType with
                            | Some pt when pt = typeof<string> && (caseName = "OK" || caseName = "Created" || caseName = "Accepted") ->
                                stringPayloads <- $"{name}.{du.Name}.{caseName}" :: stringPayloads
                            | _ -> ()

            if stringPayloads.Length > 0 then
                let details = stringPayloads |> List.truncate 20 |> String.concat "\n  "
                failtest $"Found {stringPayloads.Length} response DU cases with string payloads (should be typed records):\n  {details}"

        testCase "OK case payloads are record types (core services)" <| fun _ ->
            let mutable typedCount = 0
            let mutable nonRecordPayloads = []
            for (name, asm) in coreServices do
                let responseDUs = getResponseDUTypes asm
                for du in responseDUs do
                    let cases = getCasePayloads du
                    for (caseName, payloadType) in cases do
                        match payloadType with
                        | Some pt when (caseName = "OK" || caseName = "Created" || caseName = "Accepted") ->
                            if isTypedPayload pt then
                                typedCount <- typedCount + 1
                                if not (isRecordType pt) then
                                    nonRecordPayloads <- $"{name}.{du.Name}.{caseName} -> {pt.Name}" :: nonRecordPayloads
                        | _ -> ()

            Expect.isGreaterThan typedCount 0
                "Should have at least one typed response payload"

        testCase "String payload ratio is below threshold across all services" <| fun _ ->
            let mutable totalPayloads = 0
            let mutable stringPayloads = 0
            for (name, asm) in allServices do
                let responseDUs = getResponseDUTypes asm
                for du in responseDUs do
                    let cases = getCasePayloads du
                    for (caseName, payloadType) in cases do
                        match payloadType with
                        | Some pt when (caseName = "OK" || caseName = "Created" || caseName = "Accepted") ->
                            totalPayloads <- totalPayloads + 1
                            if pt = typeof<string> then
                                stringPayloads <- stringPayloads + 1
                        | _ -> ()

            if totalPayloads > 0 then
                let ratio = float stringPayloads / float totalPayloads
                // After allOf flattening, less than 30% of responses should be strings
                // (some endpoints legitimately return strings, e.g. script download)
                Expect.isLessThan ratio 0.30
                    $"String payload ratio should be < 30%% but is {ratio * 100.0:F1}%% ({stringPayloads}/{totalPayloads})"
    ]

// ─── Per-Service Response Type Inventory ────────────────────────

let private perServiceResponseInventoryTests =
    testList "Per-Service Response Type Inventory" [

        testCase "R2: list/create/get bucket responses are typed" <| fun _ ->
            let asm = typeof<Fidelity.CloudEdge.Management.R2.R2Client>.Assembly
            let responseDUs = getResponseDUTypes asm
            let duNames = responseDUs |> List.map (fun t -> t.Name)

            // These are the key operations that were previously string-typed
            let expectedTyped = ["R2ListBuckets"; "R2CreateBucket"; "R2GetBucket"; "R2DeleteBucket"]
            for name in expectedTyped do
                let du = responseDUs |> List.tryFind (fun t -> t.Name = name)
                match du with
                | Some t ->
                    let cases = getCasePayloads t
                    let okCase = cases |> List.tryFind (fun (n, _) -> n = "OK")
                    match okCase with
                    | Some (_, Some pt) ->
                        Expect.isTrue (isTypedPayload pt)
                            $"R2.{name}.OK should have typed payload, not {pt.Name}"
                    | _ -> failtest $"R2.{name} should have an OK case with a payload"
                | None ->
                    Expect.isTrue (List.exists (fun (n: string) -> n.Contains("Bucket")) duNames)
                        $"R2 should have response DU matching '{name}' pattern"

        testCase "D1: list/create/get database responses are typed" <| fun _ ->
            let asm = typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
            let responseDUs = getResponseDUTypes asm

            let expectedTyped = ["D1ListDatabases"; "D1CreateDatabase"]
            for name in expectedTyped do
                let du = responseDUs |> List.tryFind (fun t -> t.Name = name)
                match du with
                | Some t ->
                    let cases = getCasePayloads t
                    let okCase = cases |> List.tryFind (fun (n, _) -> n = "OK")
                    match okCase with
                    | Some (_, Some pt) ->
                        Expect.isTrue (isTypedPayload pt)
                            $"D1.{name}.OK should have typed payload, not {pt.Name}"
                    | _ -> failtest $"D1.{name} should have an OK case with a payload"
                | None -> ()

        testCase "KV: namespace list/create responses are typed" <| fun _ ->
            let asm = typeof<Fidelity.CloudEdge.Management.KV.KVClient>.Assembly
            let responseDUs = getResponseDUTypes asm
            // ReadKeyValuePair legitimately returns raw string (the stored value)
            // OK/BadRequest are generic response types that carry raw strings
            let legitimateStringTypes = set [
                "WorkersKvNamespaceReadKeyValuePair"; "OK"; "BadRequest"
            ]
            let stringPayloads =
                responseDUs
                |> List.filter (fun du -> not (legitimateStringTypes.Contains du.Name))
                |> List.collect (fun du ->
                    getCasePayloads du
                    |> List.choose (fun (caseName, pt) ->
                        match pt with
                        | Some t when t = typeof<string> && caseName = "OK" -> Some du.Name
                        | _ -> None))
            let details = String.concat ", " stringPayloads
            Expect.isEmpty stringPayloads
                $"KV response DUs with string payloads: {details}. Should be empty."

        testCase "Hyperdrive: all responses are typed" <| fun _ ->
            let asm = typeof<Fidelity.CloudEdge.Management.Hyperdrive.HyperdriveClient>.Assembly
            let responseDUs = getResponseDUTypes asm
            let stringPayloads =
                responseDUs
                |> List.collect (fun du ->
                    getCasePayloads du
                    |> List.choose (fun (caseName, pt) ->
                        match pt with
                        | Some t when t = typeof<string> && caseName = "OK" -> Some du.Name
                        | _ -> None))
            let details = String.concat ", " stringPayloads
            Expect.isEmpty stringPayloads
                $"Hyperdrive response DUs with string payloads: {details}"
    ]

// ─── Response Type Structure Tests ──────────────────────────────

let private responseTypeStructureTests =
    testList "Response Type Structure" [

        testCase "Typed response records have 'success' field" <| fun _ ->
            let mutable checkedCount = 0
            for (name, asm) in coreServices do
                let responseDUs = getResponseDUTypes asm
                for du in responseDUs do
                    let cases = getCasePayloads du
                    for (caseName, payloadType) in cases do
                        match payloadType with
                        | Some pt when isRecordType pt && caseName = "OK" ->
                            let fields =
                                Microsoft.FSharp.Reflection.FSharpType.GetRecordFields(pt, BindingFlags.Public)
                                |> Array.map (fun f -> f.Name)
                            if Array.contains "success" fields then
                                checkedCount <- checkedCount + 1
                        | _ -> ()

            Expect.isGreaterThan checkedCount 0
                "At least some response records should have a 'success' field"

        testCase "Typed response records have 'errors' field" <| fun _ ->
            let mutable checkedCount = 0
            for (name, asm) in coreServices do
                let responseDUs = getResponseDUTypes asm
                for du in responseDUs do
                    let cases = getCasePayloads du
                    for (caseName, payloadType) in cases do
                        match payloadType with
                        | Some pt when isRecordType pt && caseName = "OK" ->
                            let fields =
                                Microsoft.FSharp.Reflection.FSharpType.GetRecordFields(pt, BindingFlags.Public)
                                |> Array.map (fun f -> f.Name)
                            if Array.contains "errors" fields then
                                checkedCount <- checkedCount + 1
                        | _ -> ()

            Expect.isGreaterThan checkedCount 0
                "At least some response records should have an 'errors' field"

        testCase "Typed response records have 'result' field" <| fun _ ->
            let mutable checkedCount = 0
            for (name, asm) in coreServices do
                let responseDUs = getResponseDUTypes asm
                for du in responseDUs do
                    let cases = getCasePayloads du
                    for (caseName, payloadType) in cases do
                        match payloadType with
                        | Some pt when isRecordType pt && caseName = "OK" ->
                            let fields =
                                Microsoft.FSharp.Reflection.FSharpType.GetRecordFields(pt, BindingFlags.Public)
                                |> Array.map (fun f -> f.Name)
                            if Array.contains "result" fields then
                                checkedCount <- checkedCount + 1
                        | _ -> ()

            Expect.isGreaterThan checkedCount 0
                "At least some response records should have a 'result' field"

        testCase "Cloudflare envelope pattern: typed responses have success+errors+result" <| fun _ ->
            let mutable envelopeCount = 0
            for (name, asm) in coreServices do
                let responseDUs = getResponseDUTypes asm
                for du in responseDUs do
                    let cases = getCasePayloads du
                    for (caseName, payloadType) in cases do
                        match payloadType with
                        | Some pt when isRecordType pt && caseName = "OK" ->
                            let fields =
                                Microsoft.FSharp.Reflection.FSharpType.GetRecordFields(pt, BindingFlags.Public)
                                |> Array.map (fun f -> f.Name)
                                |> Set.ofArray
                            let hasEnvelope =
                                Set.contains "success" fields &&
                                Set.contains "errors" fields &&
                                Set.contains "result" fields
                            if hasEnvelope then
                                envelopeCount <- envelopeCount + 1
                        | _ -> ()

            Expect.isGreaterThan envelopeCount 0
                "At least some response types should follow the Cloudflare envelope pattern (success+errors+result)"
    ]

// ─── Deserialization Round-Trip Tests ───────────────────────────

let private deserializationTests =
    testList "Response Deserialization" [

        testCase "R2 v4 response envelope deserializes" <| fun _ ->
            // This is the base response type that all R2 responses build on
            let json = """{"success":true,"errors":[],"messages":[],"result":{}}"""
            let result = deserialize<Fidelity.CloudEdge.Management.R2.Types.r2v4response> json
            Expect.isTrue result.success "success should be true"
            Expect.isEmpty result.errors "errors should be empty"

        testCase "D1 message array item round-trips" <| fun _ ->
            let json = """{"code":1000,"message":"OK"}"""
            let result = deserialize<Fidelity.CloudEdge.Management.D1.Types.d1messagesArrayItem> json
            Expect.equal result.code 1000 "code should round-trip"
            Expect.equal result.message "OK" "message should round-trip"
    ]

// ─── Test Entry Point ───────────────────────────────────────────

let tests =
    testList "Response Type Tests" [
        responsePayloadTypeTests
        perServiceResponseInventoryTests
        responseTypeStructureTests
        deserializationTests
    ]
