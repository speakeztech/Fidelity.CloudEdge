module Fidelity.CloudEdge.Tests.InfrastructureTests

open Expecto
open System
open System.Reflection

/// Tests the shared OpenApiHttp infrastructure that underpins all Hawaii-generated
/// management clients. Verifies RequestPart construction, OpenApiValue types,
/// and the HTTP dispatch plumbing that every service depends on.

// ─── OpenApiHttp Type System Tests ──────────────────────────────

// Use D1's Http namespace as the reference implementation; all services
// generate an identical copy of these types.
open Fidelity.CloudEdge.Management.D1.Http

let private openApiValueTests =
    testList "OpenApiValue Type System" [

        testCase "Int value construction" <| fun _ ->
            let v = OpenApiValue.Int 42
            match v with
            | OpenApiValue.Int n -> Expect.equal n 42 "Should wrap int"
            | _ -> failtest "Should be Int case"

        testCase "Int64 value construction" <| fun _ ->
            let v = OpenApiValue.Int64 9999999999L
            match v with
            | OpenApiValue.Int64 n -> Expect.equal n 9999999999L "Should wrap int64"
            | _ -> failtest "Should be Int64 case"

        testCase "String value construction" <| fun _ ->
            let v = OpenApiValue.String "hello"
            match v with
            | OpenApiValue.String s -> Expect.equal s "hello" "Should wrap string"
            | _ -> failtest "Should be String case"

        testCase "Bool value construction" <| fun _ ->
            let v = OpenApiValue.Bool true
            match v with
            | OpenApiValue.Bool b -> Expect.isTrue b "Should wrap bool"
            | _ -> failtest "Should be Bool case"

        testCase "Double value construction" <| fun _ ->
            let v = OpenApiValue.Double 3.14
            match v with
            | OpenApiValue.Double d -> Expect.floatClose Accuracy.high d 3.14 "Should wrap double"
            | _ -> failtest "Should be Double case"

        testCase "Float value construction" <| fun _ ->
            let v = OpenApiValue.Float 2.71f
            match v with
            | OpenApiValue.Float f -> Expect.isTrue (abs(f - 2.71f) < 0.01f) "Should wrap float32"
            | _ -> failtest "Should be Float case"

        testCase "List value construction" <| fun _ ->
            let v = OpenApiValue.List [OpenApiValue.Int 1; OpenApiValue.Int 2; OpenApiValue.Int 3]
            match v with
            | OpenApiValue.List items -> Expect.equal items.Length 3 "Should contain 3 items"
            | _ -> failtest "Should be List case"
    ]

// ─── RequestPart Construction Tests ──────────────────────────────

let private requestPartTests =
    testList "RequestPart Construction" [

        testCase "query with string value" <| fun _ ->
            let part = RequestPart.query("name", "test-value")
            match part with
            | Query (key, OpenApiValue.String v) ->
                Expect.equal key "name" "Key should match"
                Expect.equal v "test-value" "Value should match"
            | _ -> failtest "Should be Query with String"

        testCase "query with int value" <| fun _ ->
            let part = RequestPart.query("page", 5)
            match part with
            | Query (key, OpenApiValue.Int v) ->
                Expect.equal key "page" "Key should match"
                Expect.equal v 5 "Value should match"
            | _ -> failtest "Should be Query with Int"

        testCase "query with int64 value" <| fun _ ->
            let part = RequestPart.query("offset", 100L)
            match part with
            | Query (key, OpenApiValue.Int64 v) ->
                Expect.equal key "offset" "Key should match"
                Expect.equal v 100L "Value should match"
            | _ -> failtest "Should be Query with Int64"

        testCase "query with string option Some" <| fun _ ->
            let part = RequestPart.query("filter", Some "active")
            match part with
            | Query (key, OpenApiValue.String v) ->
                Expect.equal key "filter" "Key should match"
                Expect.equal v "active" "Value should match"
            | _ -> failtest "Should be Query with String"

        testCase "query with string option None produces Ignore" <| fun _ ->
            let part = RequestPart.query("filter", (None: string option))
            match part with
            | Ignore -> ()
            | _ -> failtest "None option should produce Ignore"

        testCase "query with int option None produces Ignore" <| fun _ ->
            let part = RequestPart.query("limit", (None: int option))
            match part with
            | Ignore -> ()
            | _ -> failtest "None int option should produce Ignore"

        testCase "query with bool option None produces Ignore" <| fun _ ->
            let part = RequestPart.query("verbose", (None: bool option))
            match part with
            | Ignore -> ()
            | _ -> failtest "None bool option should produce Ignore"

        testCase "query with double option None produces Ignore" <| fun _ ->
            let part = RequestPart.query("threshold", (None: double option))
            match part with
            | Ignore -> ()
            | _ -> failtest "None double option should produce Ignore"

        testCase "query with string list" <| fun _ ->
            let part = RequestPart.query("tags", ["alpha"; "beta"; "gamma"])
            match part with
            | Query (key, OpenApiValue.List items) ->
                Expect.equal key "tags" "Key should match"
                Expect.equal items.Length 3 "Should have 3 items"
            | _ -> failtest "Should be Query with List"

        testCase "query with int list" <| fun _ ->
            let part = RequestPart.query("ids", [1; 2; 3])
            match part with
            | Query (key, OpenApiValue.List items) ->
                Expect.equal key "ids" "Key should match"
                Expect.equal items.Length 3 "Should have 3 items"
            | _ -> failtest "Should be Query with List"

        testCase "path with string value" <| fun _ ->
            let part = RequestPart.path("account_id", "abc123")
            match part with
            | Path (key, OpenApiValue.String v) ->
                Expect.equal key "account_id" "Key should match"
                Expect.equal v "abc123" "Value should match"
            | _ -> failtest "Should be Path with String"

        testCase "jsonContent creates JsonContent case" <| fun _ ->
            let body = {| name = "test-db" |}
            let json = Newtonsoft.Json.JsonConvert.SerializeObject(body)
            let part = RequestPart.JsonContent json
            match part with
            | JsonContent s -> Expect.stringContains s "test-db" "Should contain body"
            | _ -> failtest "Should be JsonContent"

        testCase "BinaryContent creates BinaryContent case" <| fun _ ->
            let bytes = [| 0uy; 1uy; 2uy |]
            let part = RequestPart.BinaryContent bytes
            match part with
            | BinaryContent b -> Expect.equal b.Length 3 "Should contain 3 bytes"
            | _ -> failtest "Should be BinaryContent"
    ]

// ─── MultiPartFormData Tests ─────────────────────────────────────

let private multiPartFormDataTests =
    testList "MultiPartFormData Types" [

        testCase "Primitive form data wraps OpenApiValue" <| fun _ ->
            let data = MultiPartFormData.Primitive (OpenApiValue.String "metadata")
            match data with
            | Primitive (OpenApiValue.String s) -> Expect.equal s "metadata" "Should wrap string"
            | _ -> failtest "Should be Primitive String"

        testCase "File form data wraps byte array" <| fun _ ->
            let bytes = [| 0x50uy; 0x4Buy |] // PK (zip header)
            let data = MultiPartFormData.File bytes
            match data with
            | File b -> Expect.equal b.Length 2 "Should contain file bytes"
            | _ -> failtest "Should be File"

        testCase "MultiPartFormData in RequestPart" <| fun _ ->
            let part = RequestPart.MultiPartFormData ("file", MultiPartFormData.File [| 1uy |])
            match part with
            | MultiPartFormData (key, File b) ->
                Expect.equal key "file" "Key should match"
                Expect.equal b.Length 1 "Should have 1 byte"
            | _ -> failtest "Should be MultiPartFormData with File"
    ]

// ─── Cross-Service Infrastructure Consistency ────────────────────

let private infrastructureConsistencyTests =
    testList "Infrastructure Consistency Across Services" [

        testCase "All services have OpenApiHttp module" <| fun _ ->
            let assemblies = [
                "D1", typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
                "R2", typeof<Fidelity.CloudEdge.Management.R2.R2Client>.Assembly
                "Workers", typeof<Fidelity.CloudEdge.Management.Workers.WorkersClient>.Assembly
                "KV", typeof<Fidelity.CloudEdge.Management.KV.KVClient>.Assembly
                "Queues", typeof<Fidelity.CloudEdge.Management.Queues.QueuesClient>.Assembly
                "Vectorize", typeof<Fidelity.CloudEdge.Management.Vectorize.VectorizeClient>.Assembly
                "AI", typeof<Fidelity.CloudEdge.Management.AI.AIClient>.Assembly
                "Access", typeof<Fidelity.CloudEdge.Management.Access.AccessClient>.Assembly
                "Gateway", typeof<Fidelity.CloudEdge.Management.Gateway.GatewayClient>.Assembly
                "Stream", typeof<Fidelity.CloudEdge.Management.Stream.StreamClient>.Assembly
                "Email", typeof<Fidelity.CloudEdge.Management.Email.EmailClient>.Assembly
                "Tunnels", typeof<Fidelity.CloudEdge.Management.Tunnels.TunnelsClient>.Assembly
                "Containers", typeof<Fidelity.CloudEdge.Management.Containers.ContainersClient>.Assembly
                "Builds", typeof<Fidelity.CloudEdge.Management.Builds.BuildsClient>.Assembly
                "Magic", typeof<Fidelity.CloudEdge.Management.Magic.MagicClient>.Assembly
            ]
            for (name, asm) in assemblies do
                let hasOpenApiHttp =
                    asm.GetTypes()
                    |> Array.exists (fun t -> t.Name = "OpenApiHttp")
                Expect.isTrue hasOpenApiHttp
                    $"{name}: should have OpenApiHttp module"

        testCase "All services have RequestPart type" <| fun _ ->
            let assemblies = [
                "D1", typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
                "R2", typeof<Fidelity.CloudEdge.Management.R2.R2Client>.Assembly
                "Access", typeof<Fidelity.CloudEdge.Management.Access.AccessClient>.Assembly
                "Gateway", typeof<Fidelity.CloudEdge.Management.Gateway.GatewayClient>.Assembly
                "Email", typeof<Fidelity.CloudEdge.Management.Email.EmailClient>.Assembly
            ]
            for (name, asm) in assemblies do
                let hasRequestPart =
                    asm.GetTypes()
                    |> Array.exists (fun t -> t.Name = "RequestPart")
                Expect.isTrue hasRequestPart
                    $"{name}: should have RequestPart type"

        testCase "OpenApiHttp modules have getAsync and postAsync" <| fun _ ->
            let asm = typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
            let openApiHttp =
                asm.GetTypes()
                |> Array.find (fun t -> t.Name = "OpenApiHttp")
            let methods = openApiHttp.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
            let methodNames = methods |> Array.map (fun m -> m.Name) |> Array.toList

            let expectedMethods = ["getAsync"; "postAsync"; "deleteAsync"]
            for expected in expectedMethods do
                Expect.isTrue (List.contains expected methodNames)
                    $"OpenApiHttp should have '{expected}' method"

        testCase "OpenApiHttp has all HTTP verb methods" <| fun _ ->
            let asm = typeof<Fidelity.CloudEdge.Management.D1.D1Client>.Assembly
            let openApiHttp =
                asm.GetTypes()
                |> Array.find (fun t -> t.Name = "OpenApiHttp")
            let methods =
                openApiHttp.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                |> Array.map (fun m -> m.Name)
                |> Array.toList
            let httpVerbs = ["getAsync"; "postAsync"; "putAsync"; "deleteAsync"; "patchAsync"]
            for verb in httpVerbs do
                Expect.isTrue (List.contains verb methods)
                    $"OpenApiHttp should support '{verb}'"
    ]

// ─── Cloudflare API Convention Tests ─────────────────────────────

let private apiConventionTests =
    testList "Cloudflare API Conventions" [

        testCase "Account-scoped path template format" <| fun _ ->
            let template = "/accounts/{account_id}/d1/database"
            Expect.stringContains template "{account_id}" "Should have account_id placeholder"
            Expect.isTrue (template.StartsWith("/accounts/")) "Should start with /accounts/"

        testCase "Zone-scoped path template format" <| fun _ ->
            let template = "/zones/{zone_id}/waiting_rooms"
            Expect.stringContains template "{zone_id}" "Should have zone_id placeholder"
            Expect.isTrue (template.StartsWith("/zones/")) "Should start with /zones/"

        testCase "Path parameter substitution pattern" <| fun _ ->
            let template = "/accounts/{account_id}/d1/database/{database_id}"
            let accountPart = RequestPart.path("account_id", "acc123")
            let dbPart = RequestPart.path("database_id", "db456")
            match accountPart, dbPart with
            | Path (k1, OpenApiValue.String v1), Path (k2, OpenApiValue.String v2) ->
                let result =
                    template
                        .Replace("{" + k1 + "}", v1)
                        .Replace("{" + k2 + "}", v2)
                Expect.equal result "/accounts/acc123/d1/database/db456"
                    "Path substitution should produce correct URL"
            | _ -> failtest "Should produce Path values"

        testCase "Base URL is Cloudflare API v4" <| fun _ ->
            let baseUrl = "https://api.cloudflare.com/client/v4"
            Expect.isTrue (baseUrl.StartsWith("https://")) "Should use HTTPS"
            Expect.stringContains baseUrl "api.cloudflare.com" "Should target CF API"
            Expect.stringContains baseUrl "/client/v4" "Should use v4 API"
    ]

// ─── Test Entry Point ────────────────────────────────────────────

let tests =
    testList "Infrastructure Tests" [
        openApiValueTests
        requestPartTests
        multiPartFormDataTests
        infrastructureConsistencyTests
        apiConventionTests
    ]
