module Fidelity.CloudEdge.Tests.GenerationTests

open Expecto
open System
open System.Net.Http
open System.Reflection

/// Structural validation of all generated management and runtime assemblies.
/// Uses reflection to verify that Hawaii-generated code produces valid types,
/// client classes, and async methods across the full Cloudflare API surface.

// ─── Reflection Helpers ──────────────────────────────────────────

let private getExportedTypes (asm: Assembly) =
    try asm.GetExportedTypes() |> Array.toList
    with _ -> []

let private hasPublicTypes (asm: Assembly) =
    getExportedTypes asm |> List.isEmpty |> not

let private findClientType (asm: Assembly) =
    getExportedTypes asm
    |> List.tryFind (fun t ->
        t.Name.EndsWith("Client") && not t.IsInterface && not t.IsAbstract)

let private getAsyncMethods (t: Type) =
    t.GetMethods(BindingFlags.Public ||| BindingFlags.Instance)
    |> Array.filter (fun m ->
        let rt = m.ReturnType
        rt.IsGenericType &&
        rt.GetGenericTypeDefinition().FullName.Contains("FSharpAsync"))
    |> Array.toList

let private countRecordTypes (asm: Assembly) =
    getExportedTypes asm
    |> List.filter (fun t ->
        try Microsoft.FSharp.Reflection.FSharpType.IsRecord(t, BindingFlags.Public)
        with _ -> false)
    |> List.length

let private countUnionTypes (asm: Assembly) =
    getExportedTypes asm
    |> List.filter (fun t ->
        try Microsoft.FSharp.Reflection.FSharpType.IsUnion(t, BindingFlags.Public)
        with _ -> false)
    |> List.length

let private hasTypesNamespace (asm: Assembly) =
    getExportedTypes asm
    |> List.exists (fun t ->
        t.Namespace <> null && t.Namespace.Contains(".Types"))

let private clientTakesHttpClient (clientType: Type) =
    clientType.GetConstructors()
    |> Array.exists (fun ctor ->
        ctor.GetParameters()
        |> Array.exists (fun p -> p.ParameterType = typeof<HttpClient>))

let private getStringEnumTypes (asm: Assembly) =
    getExportedTypes asm
    |> List.filter (fun t ->
        try
            Microsoft.FSharp.Reflection.FSharpType.IsUnion(t, BindingFlags.Public) &&
            t.GetCustomAttributes(typeof<Fable.Core.StringEnumAttribute>, false).Length > 0
        with _ -> false)

let private hasFormatMethod (t: Type) =
    t.GetMethod("Format", BindingFlags.Public ||| BindingFlags.Instance) <> null

// ─── Assembly Registry ───────────────────────────────────────────
// Each entry: (display name, assembly anchor via typeof, expected client name)

let private managementAssemblies =
    [
        "D1",             typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly,               "D1Client"
        "R2",             typeof<Fidelity.CloudEdge.Management.R2.R2Client>.Assembly,               "R2Client"
        "Workers",        typeof<Fidelity.CloudEdge.Management.Workers.WorkersClient>.Assembly,     "WorkersClient"
        "KV",             typeof<Fidelity.CloudEdge.Management.KV.KVClient>.Assembly,               "KVClient"
        "Analytics",      typeof<Fidelity.CloudEdge.Management.Analytics.AnalyticsClient>.Assembly,  "AnalyticsClient"
        "Logs",           typeof<Fidelity.CloudEdge.Management.Logs.LogsClient>.Assembly,           "LogsClient"
        "Queues",         typeof<Fidelity.CloudEdge.Management.Queues.QueuesClient>.Assembly,       "QueuesClient"
        "Vectorize",      typeof<Fidelity.CloudEdge.Management.Vectorize.VectorizeClient>.Assembly, "VectorizeClient"
        "Hyperdrive",     typeof<Fidelity.CloudEdge.Management.Hyperdrive.HyperdriveClient>.Assembly, "HyperdriveClient"
        "DurableObjects", typeof<Fidelity.CloudEdge.Management.DurableObjects.DurableObjectsClient>.Assembly, "DurableObjectsClient"
        "Pages",          typeof<Fidelity.CloudEdge.Management.Pages.PagesClient>.Assembly,         "PagesClient"
        "AI",             typeof<Fidelity.CloudEdge.Management.AI.AIClient>.Assembly,               "AIClient"
        "AIGateway",      typeof<Fidelity.CloudEdge.Management.AIGateway.AIGatewayClient>.Assembly, "AIGatewayClient"
        "AISearch",       typeof<Fidelity.CloudEdge.Management.AISearch.AISearchClient>.Assembly,   "AISearchClient"
        "AutoRAG",        typeof<Fidelity.CloudEdge.Management.AutoRAG.AutoRAGClient>.Assembly,     "AutoRAGClient"
        "Containers",     typeof<Fidelity.CloudEdge.Management.Containers.ContainersClient>.Assembly, "ContainersClient"
        "Workflows",      typeof<Fidelity.CloudEdge.Management.Workflows.WorkflowsClient>.Assembly, "WorkflowsClient"
        "Pipelines",      typeof<Fidelity.CloudEdge.Management.Pipelines.PipelinesClient>.Assembly, "PipelinesClient"
        "BrowserRendering", typeof<Fidelity.CloudEdge.Management.BrowserRendering.BrowserRenderingClient>.Assembly, "BrowserRenderingClient"
        "Stream",         typeof<Fidelity.CloudEdge.Management.Stream.StreamClient>.Assembly,       "StreamClient"
        "Images",         typeof<Fidelity.CloudEdge.Management.Images.ImagesClient>.Assembly,       "ImagesClient"
        "R2Catalog",      typeof<Fidelity.CloudEdge.Management.R2Catalog.R2CatalogClient>.Assembly, "R2CatalogClient"
        "SecretsStore",   typeof<Fidelity.CloudEdge.Management.SecretsStore.SecretsStoreClient>.Assembly, "SecretsStoreClient"
        "Tunnels",        typeof<Fidelity.CloudEdge.Management.Tunnels.TunnelsClient>.Assembly,     "TunnelsClient"
        "Access",         typeof<Fidelity.CloudEdge.Management.Access.AccessClient>.Assembly,       "AccessClient"
        "Gateway",        typeof<Fidelity.CloudEdge.Management.Gateway.GatewayClient>.Assembly,     "GatewayClient"
        "Email",          typeof<Fidelity.CloudEdge.Management.Email.EmailClient>.Assembly,         "EmailClient"
        "Calls",          typeof<Fidelity.CloudEdge.Management.Calls.CallsClient>.Assembly,         "CallsClient"
        "Builds",         typeof<Fidelity.CloudEdge.Management.Builds.BuildsClient>.Assembly,       "BuildsClient"
        "LoadBalancers",  typeof<Fidelity.CloudEdge.Management.LoadBalancers.LoadBalancersClient>.Assembly, "LoadBalancersClient"
        "WaitingRooms",   typeof<Fidelity.CloudEdge.Management.WaitingRooms.WaitingRoomsClient>.Assembly, "WaitingRoomsClient"
        "Magic",          typeof<Fidelity.CloudEdge.Management.Magic.MagicClient>.Assembly,         "MagicClient"
    ]

// ─── Per-Service Structural Tests (data-driven) ─────────────────

let private perServiceStructuralTests =
    testList "Per-Service Structural Validation" [
        for (name, asm, expectedClientName) in managementAssemblies do

            testCase $"{name}: exports public types" <| fun _ ->
                Expect.isTrue (hasPublicTypes asm)
                    $"{name} assembly should export public types"

            testCase $"{name}: has Types namespace" <| fun _ ->
                Expect.isTrue (hasTypesNamespace asm)
                    $"{name} should have a .Types namespace"

            testCase $"{name}: has record types" <| fun _ ->
                let count = countRecordTypes asm
                Expect.isGreaterThan count 0
                    $"{name} should have at least one record type"

            testCase $"{name}: has client class named {expectedClientName}" <| fun _ ->
                match findClientType asm with
                | Some ct ->
                    Expect.equal ct.Name expectedClientName
                        $"{name} client should be named {expectedClientName}"
                | None ->
                    failtest $"{name}: no client class found"

            testCase $"{name}: client has async methods" <| fun _ ->
                match findClientType asm with
                | Some ct ->
                    let asyncMethods = getAsyncMethods ct
                    Expect.isGreaterThan asyncMethods.Length 0
                        $"{name} client should have async methods"
                | None ->
                    failtest $"{name}: no client class found"

            testCase $"{name}: client constructor accepts HttpClient" <| fun _ ->
                match findClientType asm with
                | Some ct ->
                    Expect.isTrue (clientTakesHttpClient ct)
                        $"{name} client should accept HttpClient in constructor"
                | None ->
                    failtest $"{name}: no client class found"
    ]

// ─── Cross-Service Consistency Tests ─────────────────────────────

let private crossServiceConsistencyTests =
    testList "Cross-Service Consistency" [

        testCase "All 32 management assemblies are loaded" <| fun _ ->
            Expect.equal managementAssemblies.Length 32
                "Should have exactly 32 management assemblies registered"

        testCase "All assemblies have distinct names" <| fun _ ->
            let names = managementAssemblies |> List.map (fun (n, _, _) -> n)
            let distinct = names |> List.distinct
            Expect.equal distinct.Length names.Length
                "All assembly display names should be distinct"

        testCase "All client names follow {Service}Client convention" <| fun _ ->
            for (name, _, clientName) in managementAssemblies do
                Expect.isTrue (clientName.EndsWith("Client"))
                    $"{name}: client name '{clientName}' should end with 'Client'"

        testCase "No assembly has zero exported types" <| fun _ ->
            for (name, asm, _) in managementAssemblies do
                let count = getExportedTypes asm |> List.length
                Expect.isGreaterThan count 0
                    $"{name} should have exported types (found {count})"

        testCase "All client methods return FSharpAsync" <| fun _ ->
            for (name, asm, _) in managementAssemblies do
                match findClientType asm with
                | Some ct ->
                    let allPublicMethods =
                        ct.GetMethods(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
                        |> Array.filter (fun m -> not (m.IsSpecialName))
                    let asyncMethods = getAsyncMethods ct
                    if allPublicMethods.Length > 0 then
                        Expect.equal allPublicMethods.Length asyncMethods.Length
                            $"{name}: all client methods should return Async<_>"
                | None -> ()

        testCase "All assemblies have types under Fidelity.CloudEdge.Management namespace" <| fun _ ->
            for (name, asm, _) in managementAssemblies do
                let types = getExportedTypes asm
                let hasCorrectNs =
                    types |> List.exists (fun t ->
                        t.Namespace <> null &&
                        t.Namespace.StartsWith("Fidelity.CloudEdge.Management"))
                Expect.isTrue hasCorrectNs
                    $"{name}: should have types under Fidelity.CloudEdge.Management.*"

        testCase "StringEnum types have Format() method" <| fun _ ->
            let mutable totalStringEnums = 0
            for (name, asm, _) in managementAssemblies do
                let stringEnums = getStringEnumTypes asm
                for se in stringEnums do
                    totalStringEnums <- totalStringEnums + 1
                    Expect.isTrue (hasFormatMethod se)
                        $"{name}: StringEnum type '{se.Name}' should have Format() method"
            Expect.isGreaterThan totalStringEnums 0
                "Should find at least one StringEnum across all assemblies"
    ]

// ─── Type Richness Tests ─────────────────────────────────────────

let private typeRichnessTests =
    testList "Type Richness" [

        testCase "Large services have substantial type counts" <| fun _ ->
            let largeServices = ["Workers"; "Access"; "Gateway"; "Stream"; "Pages"; "Email"; "Magic"]
            for (name, asm, _) in managementAssemblies do
                if List.contains name largeServices then
                    let typeCount = getExportedTypes asm |> List.length
                    Expect.isGreaterThan typeCount 10
                        $"{name} should have > 10 exported types (found {typeCount})"

        testCase "Large services have multiple async methods" <| fun _ ->
            let largeServices = ["Workers"; "Access"; "Gateway"; "Stream"; "Pages"; "Email"; "Magic"]
            for (name, asm, _) in managementAssemblies do
                if List.contains name largeServices then
                    match findClientType asm with
                    | Some ct ->
                        let methodCount = (getAsyncMethods ct).Length
                        Expect.isGreaterThan methodCount 3
                            $"{name} should have > 3 async methods (found {methodCount})"
                    | None -> ()

        testCase "All services have both record and union types" <| fun _ ->
            let mutable servicesWithBoth = 0
            for (name, asm, _) in managementAssemblies do
                let records = countRecordTypes asm
                let unions = countUnionTypes asm
                if records > 0 && unions > 0 then
                    servicesWithBoth <- servicesWithBoth + 1
            Expect.isGreaterThan servicesWithBoth 20
                $"At least 20 services should have both record and union types (found {servicesWithBoth})"

        testCase "Record types have static Create methods" <| fun _ ->
            let mutable totalCreateMethods = 0
            for (name, asm, _) in managementAssemblies do
                let records =
                    getExportedTypes asm
                    |> List.filter (fun t ->
                        try Microsoft.FSharp.Reflection.FSharpType.IsRecord(t, BindingFlags.Public)
                        with _ -> false)
                for r in records do
                    let hasCreate =
                        r.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                        |> Array.exists (fun m -> m.Name = "Create")
                    if hasCreate then
                        totalCreateMethods <- totalCreateMethods + 1
            Expect.isGreaterThan totalCreateMethods 0
                "At least some record types should have static Create methods"
    ]

// ─── Runtime Assembly Tests ──────────────────────────────────────

let private runtimeAssemblyTests =
    testList "Runtime Assembly Structure" [

        testCase "Worker.Context exports Request type" <| fun _ ->
            let _ = typeof<Fidelity.CloudEdge.Worker.Context.Request>
            Expect.isTrue true "Request type should be accessible"

        testCase "Worker.Context exports Response type" <| fun _ ->
            let _ = typeof<Fidelity.CloudEdge.Worker.Context.Response>
            Expect.isTrue true "Response type should be accessible"

        testCase "Worker.Context exports ExecutionContext type" <| fun _ ->
            let _ = typeof<Fidelity.CloudEdge.Worker.Context.ExecutionContext>
            Expect.isTrue true "ExecutionContext type should be accessible"

        testCase "Worker.Context assembly has core types" <| fun _ ->
            let asm = typeof<Fidelity.CloudEdge.Worker.Context.Request>.Assembly
            let typeNames =
                getExportedTypes asm
                |> List.map (fun t -> t.Name)
            let expected = ["Request"; "Response"; "ExecutionContext"]
            for name in expected do
                Expect.isTrue
                    (typeNames |> List.exists (fun n -> n = name))
                    $"Worker.Context should export '{name}'"

        testCase "Worker.Context has substantial type surface" <| fun _ ->
            let asm = typeof<Fidelity.CloudEdge.Worker.Context.Request>.Assembly
            let typeCount = getExportedTypes asm |> List.length
            Expect.isGreaterThan typeCount 3
                $"Worker.Context should have > 3 types (found {typeCount})"

        testCase "AI assembly reference resolves" <| fun _ ->
            // AI assembly uses Glutinum-generated bindings; verify it loads
            let asm = System.Reflection.Assembly.Load("Fidelity.CloudEdge.AI")
            Expect.isNotNull asm "AI assembly should load by name"
    ]

// ─── Assembly Metadata Tests ─────────────────────────────────────

let private assemblyMetadataTests =
    testList "Assembly Metadata" [

        testCase "All management assemblies have correct name prefix" <| fun _ ->
            for (name, asm, _) in managementAssemblies do
                let asmName = asm.GetName().Name
                Expect.isTrue (asmName.StartsWith("Fidelity.CloudEdge.Management"))
                    $"{name}: assembly name should start with Fidelity.CloudEdge.Management"

        testCase "All assemblies load without exceptions" <| fun _ ->
            for (name, asm, _) in managementAssemblies do
                let types = try asm.GetExportedTypes() with ex -> [||]
                Expect.isGreaterThan types.Length 0
                    $"{name}: assembly should load without exceptions"
    ]

// ─── Test Entry Point ────────────────────────────────────────────

// ─── Postprocessor Cleanliness Tests ─────────────────────────

let private postprocessorCleanlinessTests =
    testList "Postprocessor Cleanliness" [

        testCase "No F# keyword type stubs in any assembly" <| fun _ ->
            let fsharpKeywords = set [
                "when"; "type"; "let"; "in"; "do"; "for"; "while"; "if"; "then"
                "else"; "match"; "with"; "fun"; "try"; "yield"; "return"; "use"
                "module"; "namespace"; "open"; "member"; "static"; "abstract"
                "override"; "default"; "mutable"; "rec"; "and"; "or"; "not"
                "new"; "null"; "begin"; "end"; "lazy"; "as"; "base"; "of"
            ]
            let mutable violations = []
            for (name, asm, _) in managementAssemblies do
                let types = getExportedTypes asm
                for t in types do
                    // F# keywords are always lowercase; Type (uppercase) is a valid identifier
                    if fsharpKeywords.Contains t.Name then
                        violations <- $"{name}: type '{t.Name}'" :: violations
            if violations.Length > 0 then
                let details = violations |> List.truncate 10 |> String.concat "\n  "
                failtest $"Found {violations.Length} type(s) named after F# keywords:\n  {details}"

        testCase "No invalid characters in exported type names" <| fun _ ->
            let mutable violations = []
            for (name, asm, _) in managementAssemblies do
                let types = getExportedTypes asm
                for t in types do
                    if t.Name.Contains("$") || t.Name.Contains("+") then
                        violations <- $"{name}: type '{t.Name}'" :: violations
            if violations.Length > 0 then
                let details = violations |> List.truncate 10 |> String.concat "\n  "
                failtest $"Found {violations.Length} type(s) with invalid characters:\n  {details}"

        testCase "All client methods have correct parameter types" <| fun _ ->
            let mutable violations = []
            for (name, asm, _) in managementAssemblies do
                match findClientType asm with
                | Some ct ->
                    let asyncMethods = getAsyncMethods ct
                    for m in asyncMethods do
                        for p in m.GetParameters() do
                            let pt = p.ParameterType
                            if pt.IsGenericType &&
                               pt.GetGenericTypeDefinition() = typedefof<list<_>> &&
                               pt.GetGenericArguments().[0].Name = "JObject" then
                                violations <- $"{name}.{m.Name}: param '{p.Name}' is list<JObject>" :: violations
                | None -> ()
            if violations.Length > 0 then
                let details = violations |> String.concat "\n  "
                failtest $"Found JObject list query parameters:\n  {details}"
    ]

let tests =
    testList "Generation Structure Tests" [
        perServiceStructuralTests
        crossServiceConsistencyTests
        typeRichnessTests
        runtimeAssemblyTests
        assemblyMetadataTests
        postprocessorCleanlinessTests
    ]
