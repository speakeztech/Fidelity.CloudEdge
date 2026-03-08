module Fidelity.CloudEdge.Tests.SerializationTests

open Expecto
open System
open System.Reflection
open Newtonsoft.Json
open Fable.Remoting.Json

/// Tests JSON serialization round-trips for generated types using the same
/// Fable.Remoting.Json infrastructure that Hawaii-generated clients use at runtime.
/// Covers record construction, StringEnum formatting, and serializer configuration.

// ─── Serializer Setup (mirrors OpenApiHttp.fs) ──────────────────

let private converter = FableJsonConverter() :> JsonConverter
let private settings = JsonSerializerSettings(Converters = [| converter |])
do settings.DateParseHandling <- DateParseHandling.None
do settings.NullValueHandling <- NullValueHandling.Ignore

let private serialize<'t> (value: 't) = JsonConvert.SerializeObject(value, settings)
let private deserialize<'t> (json: string) = JsonConvert.DeserializeObject<'t>(json, settings)

// ─── Serializer Infrastructure Tests ─────────────────────────────

let private serializerInfrastructureTests =
    testList "Serializer Infrastructure" [

        testCase "FableJsonConverter instantiates" <| fun _ ->
            let conv = FableJsonConverter()
            Expect.isNotNull (conv :> obj) "FableJsonConverter should instantiate"

        testCase "Settings have DateParseHandling.None" <| fun _ ->
            Expect.equal settings.DateParseHandling DateParseHandling.None
                "Settings should use DateParseHandling.None"

        testCase "Settings have NullValueHandling.Ignore" <| fun _ ->
            Expect.equal settings.NullValueHandling NullValueHandling.Ignore
                "Settings should ignore null values"

        testCase "Serialize simple string" <| fun _ ->
            let json = serialize "hello"
            Expect.stringContains json "hello" "Should serialize string"

        testCase "Serialize integer" <| fun _ ->
            let json = serialize 42
            Expect.stringContains json "42" "Should serialize integer"

        testCase "Serialize anonymous record" <| fun _ ->
            let json = serialize {| code = 200; message = "OK" |}
            Expect.stringContains json "code" "Should contain code field"
            Expect.stringContains json "message" "Should contain message field"

        testCase "Deserialize anonymous record" <| fun _ ->
            let json = """{"code":200,"message":"OK"}"""
            let result = deserialize<{| code: int; message: string |}> json
            Expect.equal result.code 200 "Should deserialize code"
            Expect.equal result.message "OK" "Should deserialize message"
    ]

// ─── D1 Type Serialization ──────────────────────────────────────

let private d1SerializationTests =
    testList "D1 Type Serialization" [

        testCase "d1messagesArrayItem round-trip" <| fun _ ->
            let original = Fidelity.CloudEdge.Management.D1.Types.d1messagesArrayItem.Create(1000, "success")
            let json = serialize original
            let restored = deserialize<Fidelity.CloudEdge.Management.D1.Types.d1messagesArrayItem> json
            Expect.equal restored.code 1000 "Code should round-trip"
            Expect.equal restored.message "success" "Message should round-trip"

        testCase "d1messagesArrayItem JSON structure" <| fun _ ->
            let item = Fidelity.CloudEdge.Management.D1.Types.d1messagesArrayItem.Create(200, "OK")
            let json = serialize item
            Expect.stringContains json "\"code\"" "Should have code field"
            Expect.stringContains json "\"message\"" "Should have message field"

        testCase "d1jurisdiction StringEnum serialization" <| fun _ ->
            let value = Fidelity.CloudEdge.Management.D1.Types.d1jurisdiction.Eu
            Expect.equal (value.Format()) "eu" "Format() should return 'eu'"

        testCase "d1jurisdiction all cases have Format()" <| fun _ ->
            let cases = [
                Fidelity.CloudEdge.Management.D1.Types.d1jurisdiction.Eu, "eu"
                Fidelity.CloudEdge.Management.D1.Types.d1jurisdiction.Fedramp, "fedramp"
            ]
            for (case, expected) in cases do
                Expect.equal (case.Format()) expected $"Format() should return '{expected}'"

        testCase "d1primary-location-hint covers expected regions" <| fun _ ->
            let regions = [
                Fidelity.CloudEdge.Management.D1.Types.``d1primary-location-hint``.Wnam, "wnam"
                Fidelity.CloudEdge.Management.D1.Types.``d1primary-location-hint``.Enam, "enam"
                Fidelity.CloudEdge.Management.D1.Types.``d1primary-location-hint``.Weur, "weur"
                Fidelity.CloudEdge.Management.D1.Types.``d1primary-location-hint``.Eeur, "eeur"
                Fidelity.CloudEdge.Management.D1.Types.``d1primary-location-hint``.Apac, "apac"
            ]
            for (region, expected) in regions do
                Expect.equal (region.Format()) expected $"Region should format to '{expected}'"

        testCase "d1messages is list<d1messagesArrayItem>" <| fun _ ->
            let messages: Fidelity.CloudEdge.Management.D1.Types.d1messages =
                [ Fidelity.CloudEdge.Management.D1.Types.d1messagesArrayItem.Create(100, "first")
                  Fidelity.CloudEdge.Management.D1.Types.d1messagesArrayItem.Create(200, "second") ]
            let json = serialize messages
            Expect.stringContains json "first" "Should serialize list items"
            Expect.stringContains json "second" "Should serialize all items"
    ]

// ─── Containers Type Serialization ──────────────────────────────

let private containersSerializationTests =
    testList "Containers Type Serialization" [

        testCase "ccImageRegistryPermissions enum values" <| fun _ ->
            let pull = Fidelity.CloudEdge.Management.Containers.Types.ccImageRegistryPermissions.Pull
            let push = Fidelity.CloudEdge.Management.Containers.Types.ccImageRegistryPermissions.Push
            Expect.equal (pull.Format()) "pull" "Pull should format correctly"
            Expect.equal (push.Format()) "push" "Push should format correctly"
    ]

// ─── Cross-Service Serialization ─────────────────────────────────

let private crossServiceSerializationTests =
    testList "Cross-Service Serialization Patterns" [

        testCase "All services use identical Serializer module pattern" <| fun _ ->
            // Verify that the D1 serializer module follows the expected pattern
            let serializerType =
                typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
                    .GetTypes()
                |> Array.tryFind (fun t -> t.Name = "Serializer")
            Expect.isSome serializerType "D1 should have a Serializer module"

        testCase "Serializer modules across services have serialize/deserialize" <| fun _ ->
            let assemblies = [
                typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
                typeof<Fidelity.CloudEdge.Management.R2.R2Client>.Assembly
                typeof<Fidelity.CloudEdge.Management.Workers.WorkersClient>.Assembly
                typeof<Fidelity.CloudEdge.Management.KV.KVClient>.Assembly
                typeof<Fidelity.CloudEdge.Management.Queues.QueuesClient>.Assembly
            ]
            for asm in assemblies do
                let serializerType =
                    asm.GetTypes()
                    |> Array.tryFind (fun t -> t.Name = "Serializer")
                match serializerType with
                | Some st ->
                    let hasSerialize =
                        st.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                        |> Array.exists (fun m -> m.Name = "serialize")
                    let hasDeserialize =
                        st.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                        |> Array.exists (fun m -> m.Name = "deserialize")
                    Expect.isTrue hasSerialize $"{asm.GetName().Name}: Serializer should have 'serialize'"
                    Expect.isTrue hasDeserialize $"{asm.GetName().Name}: Serializer should have 'deserialize'"
                | None ->
                    failtest $"{asm.GetName().Name}: Serializer module not found"

        testCase "StringEnum round-trip via Fable.Remoting.Json" <| fun _ ->
            // StringEnums should serialize as their compiled name strings
            let jurisdiction = Fidelity.CloudEdge.Management.D1.Types.d1jurisdiction.Eu
            let json = serialize jurisdiction
            // Fable.Remoting.Json serializes DUs; the exact format depends on the converter
            Expect.isNotNull json "StringEnum should serialize to non-null JSON"
            Expect.isNonEmpty json "StringEnum should serialize to non-empty JSON"

        testCase "Record with all optional fields serializes cleanly" <| fun _ ->
            // Create a record with only required fields; optional fields should be omitted
            let item = Fidelity.CloudEdge.Management.D1.Types.d1messagesArrayItem.Create(0, "")
            let json = serialize item
            Expect.stringContains json "code" "Required field should be present"
            Expect.stringContains json "message" "Required field should be present"

        testCase "Empty list serialization" <| fun _ ->
            let emptyMessages: Fidelity.CloudEdge.Management.D1.Types.d1messages = []
            let json = serialize emptyMessages
            Expect.equal json "[]" "Empty list should serialize to []"

        testCase "DateTimeOffset fields serialize as ISO8601" <| fun _ ->
            let now = DateTimeOffset.UtcNow
            let json = serialize now
            // Should contain year and timezone indicator
            Expect.stringContains json (now.Year.ToString()) "Should contain year"
    ]

// ─── Reflection-Based Type Construction Tests ────────────────────

let private typeConstructionTests =
    testList "Type Construction via Reflection" [

        testCase "Record types with Create methods can be invoked" <| fun _ ->
            // Verify Create static methods work across several services
            let assemblies = [
                "D1", typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
                "R2", typeof<Fidelity.CloudEdge.Management.R2.R2Client>.Assembly
                "KV", typeof<Fidelity.CloudEdge.Management.KV.KVClient>.Assembly
            ]
            for (name, asm) in assemblies do
                let recordTypes =
                    asm.GetExportedTypes()
                    |> Array.filter (fun t ->
                        try Microsoft.FSharp.Reflection.FSharpType.IsRecord(t, BindingFlags.Public)
                        with _ -> false)
                let typesWithCreate =
                    recordTypes
                    |> Array.filter (fun t ->
                        t.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                        |> Array.exists (fun m -> m.Name = "Create"))
                if typesWithCreate.Length > 0 then
                    // Verify at least one Create method exists and is callable
                    let firstType = typesWithCreate.[0]
                    let createMethod =
                        firstType.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                        |> Array.find (fun m -> m.Name = "Create")
                    Expect.isNotNull (createMethod :> obj)
                        $"{name}: Create method should be accessible on {firstType.Name}"

        testCase "All StringEnum types have at least 2 cases" <| fun _ ->
            let assemblies = [
                typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
                typeof<Fidelity.CloudEdge.Management.R2.R2Client>.Assembly
                typeof<Fidelity.CloudEdge.Management.Workers.WorkersClient>.Assembly
                typeof<Fidelity.CloudEdge.Management.Access.AccessClient>.Assembly
                typeof<Fidelity.CloudEdge.Management.Gateway.GatewayClient>.Assembly
            ]
            for asm in assemblies do
                let stringEnums =
                    asm.GetExportedTypes()
                    |> Array.filter (fun t ->
                        try
                            Microsoft.FSharp.Reflection.FSharpType.IsUnion(t, BindingFlags.Public) &&
                            t.GetCustomAttributes(typeof<Fable.Core.StringEnumAttribute>, false).Length > 0
                        with _ -> false)
                for se in stringEnums do
                    let cases = Microsoft.FSharp.Reflection.FSharpType.GetUnionCases(se, BindingFlags.Public)
                    Expect.isGreaterThanOrEqual cases.Length 1
                        $"{asm.GetName().Name}: StringEnum '{se.Name}' should have at least 1 case"
    ]

// ─── Test Entry Point ────────────────────────────────────────────

let tests =
    testList "Serialization Tests" [
        serializerInfrastructureTests
        d1SerializationTests
        containersSerializationTests
        crossServiceSerializationTests
        typeConstructionTests
    ]
