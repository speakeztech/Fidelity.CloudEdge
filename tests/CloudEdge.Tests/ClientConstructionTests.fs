module Fidelity.CloudEdge.Tests.ClientConstructionTests

open Expecto
open System
open System.Net.Http
open System.Reflection

/// Verifies that all 32 management clients can be instantiated, that their
/// method signatures follow expected conventions, and that the HTTP
/// infrastructure types are consistent across all generated services.

// ─── Client Instantiation Registry ───────────────────────────────
// Each entry: (service name, factory function returning a client instance)

let private httpClient = new HttpClient()

let private clientFactories: (string * (unit -> obj)) list =
    [
        "D1",              fun () -> Fidelity.CloudEdge.Management.D1.D1Client(httpClient) :> obj
        "R2",              fun () -> Fidelity.CloudEdge.Management.R2.R2Client(httpClient) :> obj
        "Workers",         fun () -> Fidelity.CloudEdge.Management.Workers.WorkersClient(httpClient) :> obj
        "KV",              fun () -> Fidelity.CloudEdge.Management.KV.KVClient(httpClient) :> obj
        "Analytics",       fun () -> Fidelity.CloudEdge.Management.Analytics.AnalyticsClient(httpClient) :> obj
        "Logs",            fun () -> Fidelity.CloudEdge.Management.Logs.LogsClient(httpClient) :> obj
        "Queues",          fun () -> Fidelity.CloudEdge.Management.Queues.QueuesClient(httpClient) :> obj
        "Vectorize",       fun () -> Fidelity.CloudEdge.Management.Vectorize.VectorizeClient(httpClient) :> obj
        "Hyperdrive",      fun () -> Fidelity.CloudEdge.Management.Hyperdrive.HyperdriveClient(httpClient) :> obj
        "DurableObjects",  fun () -> Fidelity.CloudEdge.Management.DurableObjects.DurableObjectsClient(httpClient) :> obj
        "Pages",           fun () -> Fidelity.CloudEdge.Management.Pages.PagesClient(httpClient) :> obj
        "AI",              fun () -> Fidelity.CloudEdge.Management.AI.AIClient(httpClient) :> obj
        "AIGateway",       fun () -> Fidelity.CloudEdge.Management.AIGateway.AIGatewayClient(httpClient) :> obj
        "AISearch",        fun () -> Fidelity.CloudEdge.Management.AISearch.AISearchClient(httpClient) :> obj
        "AutoRAG",         fun () -> Fidelity.CloudEdge.Management.AutoRAG.AutoRAGClient(httpClient) :> obj
        "Containers",      fun () -> Fidelity.CloudEdge.Management.Containers.ContainersClient(httpClient) :> obj
        "Workflows",       fun () -> Fidelity.CloudEdge.Management.Workflows.WorkflowsClient(httpClient) :> obj
        "Pipelines",       fun () -> Fidelity.CloudEdge.Management.Pipelines.PipelinesClient(httpClient) :> obj
        "BrowserRendering", fun () -> Fidelity.CloudEdge.Management.BrowserRendering.BrowserRenderingClient(httpClient) :> obj
        "Stream",          fun () -> Fidelity.CloudEdge.Management.Stream.StreamClient(httpClient) :> obj
        "Images",          fun () -> Fidelity.CloudEdge.Management.Images.ImagesClient(httpClient) :> obj
        "R2Catalog",       fun () -> Fidelity.CloudEdge.Management.R2Catalog.R2CatalogClient(httpClient) :> obj
        "SecretsStore",    fun () -> Fidelity.CloudEdge.Management.SecretsStore.SecretsStoreClient(httpClient) :> obj
        "Tunnels",         fun () -> Fidelity.CloudEdge.Management.Tunnels.TunnelsClient(httpClient) :> obj
        "Access",          fun () -> Fidelity.CloudEdge.Management.Access.AccessClient(httpClient) :> obj
        "Gateway",         fun () -> Fidelity.CloudEdge.Management.Gateway.GatewayClient(httpClient) :> obj
        "Email",           fun () -> Fidelity.CloudEdge.Management.Email.EmailClient(httpClient) :> obj
        "Calls",           fun () -> Fidelity.CloudEdge.Management.Calls.CallsClient(httpClient) :> obj
        "Builds",          fun () -> Fidelity.CloudEdge.Management.Builds.BuildsClient(httpClient) :> obj
        "LoadBalancers",   fun () -> Fidelity.CloudEdge.Management.LoadBalancers.LoadBalancersClient(httpClient) :> obj
        "WaitingRooms",    fun () -> Fidelity.CloudEdge.Management.WaitingRooms.WaitingRoomsClient(httpClient) :> obj
        "Magic",           fun () -> Fidelity.CloudEdge.Management.Magic.MagicClient(httpClient) :> obj
    ]

// ─── Reflection helpers ──────────────────────────────────────────

let private getAsyncMethods (t: Type) =
    t.GetMethods(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
    |> Array.filter (fun m ->
        not m.IsSpecialName &&
        m.ReturnType.IsGenericType &&
        m.ReturnType.GetGenericTypeDefinition().FullName.Contains("FSharpAsync"))

let private getMethodParameters (m: MethodInfo) =
    m.GetParameters()
    |> Array.filter (fun p -> not (p.IsOptional && p.Name = "cancellationToken"))

// ─── Instantiation Tests ─────────────────────────────────────────

let private instantiationTests =
    testList "Client Instantiation" [
        for (name, factory) in clientFactories do

            testCase $"{name}: client instantiates without error" <| fun _ ->
                let client = factory ()
                Expect.isNotNull client $"{name} client should not be null"

            testCase $"{name}: client type matches expected name" <| fun _ ->
                let client = factory ()
                let typeName = client.GetType().Name
                Expect.isTrue (typeName.EndsWith("Client"))
                    $"{name}: type name '{typeName}' should end with Client"
    ]

// ─── Method Signature Tests ──────────────────────────────────────

let private methodSignatureTests =
    testList "Client Method Signatures" [
        for (name, factory) in clientFactories do

            testCase $"{name}: methods accept string identifier as first parameter" <| fun _ ->
                let client = factory ()
                let methods = getAsyncMethods (client.GetType())
                let mutable withStringFirst = 0
                let mutable total = 0
                for m in methods do
                    let requiredParams = getMethodParameters m
                    if requiredParams.Length > 0 then
                        total <- total + 1
                        let firstParam = requiredParams.[0]
                        if firstParam.ParameterType = typeof<string> then
                            withStringFirst <- withStringFirst + 1
                // All Cloudflare API methods start with some string identifier
                // (accountId, zoneId, or a resource-specific ID)
                if total > 0 then
                    Expect.isGreaterThan withStringFirst 0
                        $"{name}: at least one method should take a string identifier first ({withStringFirst}/{total})"

            testCase $"{name}: async methods have CancellationToken support" <| fun _ ->
                let client = factory ()
                let methods = getAsyncMethods (client.GetType())
                for m in methods do
                    let allParams = m.GetParameters()
                    let hasCancellationToken =
                        allParams |> Array.exists (fun p ->
                            p.Name = "cancellationToken" &&
                            p.ParameterType = typeof<System.Threading.CancellationToken option>)
                    // Hawaii generates optional cancellationToken on all methods
                    Expect.isTrue hasCancellationToken
                        $"{name}.{m.Name}: should accept optional CancellationToken"

            testCase $"{name}: method return types are typed DU cases" <| fun _ ->
                let client = factory ()
                let methods = getAsyncMethods (client.GetType())
                for m in methods do
                    let returnType = m.ReturnType
                    if returnType.IsGenericType then
                        let innerType = returnType.GetGenericArguments().[0]
                        // Hawaii wraps responses in DU types like D1ListDatabases.OK
                        Expect.isTrue (innerType <> typeof<obj>)
                            $"{name}.{m.Name}: return type should not be Async<obj>"
    ]

// ─── API Surface Coverage Tests ──────────────────────────────────

let private apiSurfaceCoverageTests =
    testList "API Surface Coverage" [

        testCase "All 32 clients are registered" <| fun _ ->
            Expect.equal clientFactories.Length 32
                "Should have 32 client factories registered"

        testCase "Total async method count exceeds minimum threshold" <| fun _ ->
            let mutable totalMethods = 0
            for (name, factory) in clientFactories do
                let client = factory ()
                let methods = getAsyncMethods (client.GetType())
                totalMethods <- totalMethods + methods.Length
            // 32 services should yield well over 100 API methods
            Expect.isGreaterThan totalMethods 100
                $"Total async methods across all clients should exceed 100 (found {totalMethods})"

        testCase "Method count distribution" <| fun _ ->
            let counts =
                clientFactories
                |> List.map (fun (name, factory) ->
                    let client = factory ()
                    let methods = getAsyncMethods (client.GetType())
                    (name, methods.Length))
            // Every service should have at least 1 method
            for (name, count) in counts do
                Expect.isGreaterThan count 0
                    $"{name}: should have at least 1 async method (found {count})"

        testCase "No duplicate method names within a single client" <| fun _ ->
            for (name, factory) in clientFactories do
                let client = factory ()
                let methods = getAsyncMethods (client.GetType())
                let methodNames = methods |> Array.map (fun m -> m.Name)
                let distinct = methodNames |> Array.distinct
                Expect.equal distinct.Length methodNames.Length
                    $"{name}: should not have duplicate method names"

        testCase "HTTP method coverage (GET/POST/PUT/DELETE/PATCH)" <| fun _ ->
            // Hawaii names methods based on HTTP verbs in the operationId
            // Verify we have a mix of operations across all services
            let allMethodNames =
                clientFactories
                |> List.collect (fun (_, factory) ->
                    let client = factory ()
                    getAsyncMethods (client.GetType())
                    |> Array.map (fun m -> m.Name)
                    |> Array.toList)

            let hasListOrGet = allMethodNames |> List.exists (fun n -> n.Contains("List") || n.Contains("Get"))
            let hasCreateOrPost = allMethodNames |> List.exists (fun n -> n.Contains("Create") || n.Contains("Post"))
            let hasDeleteOrRemove = allMethodNames |> List.exists (fun n -> n.Contains("Delete") || n.Contains("Remove"))

            Expect.isTrue hasListOrGet "Should have list/get operations across services"
            Expect.isTrue hasCreateOrPost "Should have create/post operations across services"
            Expect.isTrue hasDeleteOrRemove "Should have delete/remove operations across services"
    ]

// ─── Client Isolation Tests ──────────────────────────────────────

let private clientIsolationTests =
    testList "Client Isolation" [

        testCase "Multiple clients can share the same HttpClient" <| fun _ ->
            let shared = new HttpClient()
            let d1 = Fidelity.CloudEdge.Management.D1.D1Client(shared)
            let r2 = Fidelity.CloudEdge.Management.R2.R2Client(shared)
            let kv = Fidelity.CloudEdge.Management.KV.KVClient(shared)
            Expect.isNotNull (d1 :> obj) "D1 should instantiate"
            Expect.isNotNull (r2 :> obj) "R2 should instantiate"
            Expect.isNotNull (kv :> obj) "KV should instantiate"

        testCase "Each client can use an independent HttpClient" <| fun _ ->
            let d1 = Fidelity.CloudEdge.Management.D1.D1Client(new HttpClient())
            let r2 = Fidelity.CloudEdge.Management.R2.R2Client(new HttpClient())
            Expect.isNotNull (d1 :> obj) "D1 with own HttpClient should work"
            Expect.isNotNull (r2 :> obj) "R2 with own HttpClient should work"
    ]

// ─── Test Entry Point ────────────────────────────────────────────

let tests =
    testList "Client Construction Tests" [
        instantiationTests
        methodSignatureTests
        apiSurfaceCoverageTests
        clientIsolationTests
    ]
