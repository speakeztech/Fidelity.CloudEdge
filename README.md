# Fidelity.CloudEdge

[![Fidelity.CloudEdge.Runtime](https://img.shields.io/nuget/v/Fidelity.CloudEdge.Runtime?label=Runtime)](https://www.nuget.org/packages/Fidelity.CloudEdge.Runtime)
[![Fidelity.CloudEdge.Management](https://img.shields.io/nuget/v/Fidelity.CloudEdge.Management?label=Management)](https://www.nuget.org/packages/Fidelity.CloudEdge.Management)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE-MIT)
[![License: Apache 2.0](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](LICENSE-APACHE)
[![Powered by Cloudflare](https://img.shields.io/badge/Powered%20by-Cloudflare-orange?logo=cloudflare&logoColor=white)](https://www.cloudflare.com)

**Fidelity.CloudEdge** extends the [Fidelity Framework](https://github.com/FidelityFramework) to Cloudflare's edge platform, providing substrate-agnostic actor model support across bare metal and edge computing environments. Built on F#, Fable, and comprehensive type-safe bindings, it enables seamless actor migration between execution contexts while preserving semantic guarantees.

## Overview

Fidelity.CloudEdge is a **framework extension**, not a standalone tool. It represents the edge computing layer of the broader Fidelity Framework architecture, which provides substrate-transparent actor model abstractions:

- **Bare Metal**: Actors compiled via MLIR through Fidelity.Firefly
- **Edge Computing**: Actors compiled to JavaScript via Fable for Cloudflare Workers
- **Architectural Fidelity**: Same `MailboxProcessor` code, different execution contexts

This dual-substrate approach enables:
- **Actor Migration**: Move actors between bare metal and edge without code changes
- **Hybrid Deployments**: Latency-sensitive operations at the edge, compute-intensive work on bare metal
- **Unified Semantics**: Sequential processing guarantees preserved across contexts

## Architecture

### CloudEdge Dual-Layer

#### Runtime Layer (In-Worker)
- **Purpose**: Operations inside Cloudflare Workers
- **Source**: TypeScript definitions via [Glutinum](https://github.com/glutinum-org/cli)
- **Scope**: 727 types covering the complete `@cloudflare/workers-types` surface
- **Usage**: Direct platform access with microsecond latency
- **Actor Context**: Provides sequential execution guarantees for actor message processing

#### Management Layer (External)
- **Purpose**: Infrastructure provisioning, monitoring, and orchestration
- **Source**: OpenAPI specifications via [Hawaii](https://github.com/Zaid-Ajaj/Hawaii)
- **Scope**: 32 service clients covering the full Cloudflare Management API
- **Usage**: REST API clients for deployment tools and scripts
- **Framework Role**: Enables dynamic resource allocation for actor migrations

## Service Coverage

### Runtime Bindings (727 types)

The Runtime package covers the complete Cloudflare Workers runtime surface:

| Category | Services |
|----------|----------|
| **Core Worker APIs** | Request, Response, Headers, FetchEvent, ExecutionContext, Fetch, Socket, URL, URLPattern, URLSearchParams |
| **Streams** | ReadableStream, WritableStream, TransformStream, FixedLengthStream, CompressionStream, DecompressionStream |
| **Crypto** | Web Crypto API: SubtleCrypto, CryptoKey, CryptoKeyPair, DigestStream |
| **Cache** | Cache API, CacheStorage, CacheQueryOptions |
| **HTMLRewriter** | HTML parsing and transformation on the edge |
| **Storage** | KV, R2, D1 (with sessions), Durable Objects (with RPC, alarms, WebSocket hibernation) |
| **Messaging** | Queues (producers, consumers, retry, batching) |
| **AI/ML** | Workers AI (per-model typed I/O), AI Gateway, AI Search, AutoRAG |
| **Data** | Vectorize, Hyperdrive, Analytics Engine |
| **Compute** | Containers, Workflows, Service Bindings, Cron Triggers |
| **Media** | Images (transform, draw, upload), Media Transforms, Markdown conversion |
| **Email** | EmailMessage, EmailEvent, ForwardableEmailMessage, SendEmail |
| **Observability** | Tail, Trace, TraceLog, TraceMetrics, diagnostic channels |
| **Networking** | WebSocket (with hibernation), Encoding streams, FormData, Blob |

### Management Clients (32 services)

| Category | Services |
|----------|----------|
| **Compute and Storage** | Workers, Pages, Durable Objects, Containers, KV, R2, R2 Catalog, D1, Queues, Hyperdrive, Secrets Store |
| **AI and ML** | AI, AI Gateway, AI Search, AutoRAG, Vectorize |
| **Orchestration** | Workflows, Pipelines |
| **Media** | Stream, Images, Browser Rendering, Calls |
| **Networking and Security** | Access, Gateway, Tunnels, Load Balancers, Waiting Rooms, Magic Transit, Email |
| **Observability and Platform** | Analytics, Logs, Builds |

## Installation

### Runtime Package (For Workers)
```bash
dotnet add package Fidelity.CloudEdge.Runtime
```

### Management Package (For Tools/Scripts)
```bash
dotnet add package Fidelity.CloudEdge.Management
```

## Usage Examples

### Actor Model Example: Sequential Processing

```fsharp
open Fidelity.CloudEdge.Worker.Context
open Fidelity.CloudEdge.DurableObjects
open Fidelity.CloudEdge.D1

// Traditional actor pattern - works identically on bare metal or edge
type CounterMsg =
    | Increment
    | GetCount of AsyncReplyChannel<int>

type Counter() =
    let agent = MailboxProcessor<CounterMsg>.Start(fun inbox ->
        let rec loop count = async {
            let! msg = inbox.Receive()
            match msg with
            | Increment -> return! loop (count + 1)
            | GetCount reply ->
                reply.Reply(count)
                return! loop count
        }
        loop 0)

    member _.Increment() = agent.Post(Increment)
    member _.GetCount() = agent.PostAndReply(GetCount)

// On edge: Durable Object provides sequential execution context
[<DurableObject>]
type CounterDO(state: DurableObjectState, env: Env) =
    let mutable count = 0

    member this.fetch(request: Request) = async {
        // Guaranteed sequential processing - no race conditions
        match request.method with
        | "POST" ->
            count <- count + 1
            return Response.json({| count = count |})
        | "GET" ->
            return Response.json({| count = count |})
        | _ ->
            return Response.methodNotAllowed()
    }
```

### Complete Workflow: Infrastructure + Runtime

```fsharp
// 1. Infrastructure Setup (Management API - runs on your machine)
open Fidelity.CloudEdge.Management.D1
open System.Net.Http

let setupInfrastructure (accountId: string) (apiToken: string) = async {
    let httpClient = new HttpClient()
    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiToken}")

    let d1Client = D1Client(httpClient)
    let! database = d1Client.CreateDatabase(
        accountId = accountId,
        name = "production-db",
        primaryLocationHint = Some "wnam"
    )

    printfn $"Created database: {database.uuid}"
    return database.uuid
}

// 2. Runtime Operations (Runtime API - runs in Worker)
open Fidelity.CloudEdge.D1
open Fidelity.CloudEdge.Worker.Context

[<Export>]
let fetch (request: Request) (env: Env) (ctx: ExecutionContext) =
    async {
        let db = env.DATABASE

        match request.method with
        | "GET" ->
            let! users = db.prepare("SELECT * FROM users").all<User>()
            return Response.json(users)

        | "POST" ->
            let! body = request.json<User>()
            let! result =
                db.prepare("INSERT INTO users (name, email) VALUES (?, ?)")
                  .bind(body.name, body.email)
                  .run()
            return Response.json({| success = result.success |})

        | _ -> return Response.methodNotAllowed()
    }
```

## Sample Projects

### HelloWorker
Basic Worker with KV storage:
```bash
cd samples/HelloWorker
dotnet fable . --outDir dist
npx wrangler dev
```

### SecureChat
Production-ready chat API featuring:
- User authentication via Cloudflare Secrets
- D1 database for message persistence
- PowerShell user management scripts
- Separate React UI with Tailwind CSS

```bash
cd samples/SecureChat
.\scripts\add-user.ps1 -Username alice -Password "Pass123!"
dotnet fable . --outDir dist
npx wrangler dev
```

## Generation Pipeline

Both layers are generated from official Cloudflare specifications:

- **Runtime**: `@cloudflare/workers-types` TypeScript definitions processed by [Glutinum](https://github.com/glutinum-org/cli), producing 727 F# types
- **Management**: [Cloudflare OpenAPI spec](https://github.com/cloudflare/api-schemas) processed by [Hawaii](https://github.com/Zaid-Ajaj/Hawaii), producing 32 service clients

The generation pipeline includes automated preprocessing (`preprocess-openapi.sh`) to handle Hawaii compatibility issues, type sanitization for underscore variants, and query parameter overload resolution. All 32 management services compile cleanly with the current pipeline.

See [generators/README.md](generators/README.md) for pipeline details and [docs/03_gap_analysis.md](docs/03_gap_analysis.md) for service-level status.

## Test Coverage

The test suite validates the full surface area:

- **501 tests** across structural validation, client construction, serialization, and infrastructure checks
- All 32 management assemblies verified via reflection-based data-driven tests
- JSON round-trip serialization with `Fable.Remoting.Json` + `Newtonsoft.Json`
- OpenApiHttp infrastructure consistency across all services

## Vision and Roadmap

### Framework-Level Integration

Fidelity.CloudEdge is evolving toward deeper integration with the broader Fidelity Framework:

#### Actor Migration
- **Dynamic Substrate Selection**: Framework-level orchestration to move actors between bare metal and edge
- **Latency-Aware Placement**: Actors automatically placed based on geographic and computational requirements
- **Seamless State Transfer**: Unified state management across execution contexts

#### Deployment Orchestration
The planned `cfs` CLI will provide type-safe, F#-first deployment with Framework integration:

```fsharp
// deploy.fsx - Framework-aware deployment
#r "nuget: Fidelity.CloudEdge"
open Fidelity.CloudEdge.Deployment

let deploy env = cloudflare {
    account (getAccountId env)

    worker $"api-service-{env}" {
        actors [
            actor<UserService> (durable "user-service")
            actor<RAGAgent> (durable "rag-agent")
        ]

        kv "CACHE" (ensureOrCreate "cache-namespace")
        d1 "DATABASE" (ensureOrCreate "app-database" {
            migrations = "./migrations"
            location = "wnam"
        })

        route $"api-{env}.example.com/*"
    }
}
```

## Documentation

### Core Architecture
- [Architecture Decisions](docs/00_architecture_decisions.md) - Key design choices and roadmap
- [Dual Layer Architecture](docs/01_dual_layer_architecture.md) - Runtime vs Management APIs
- [Code-First Deployment](docs/02_code_first_deployment.md) - Code-driven deployment strategies

### Generation and Status
- [Gap Analysis](docs/03_gap_analysis.md) - Service maturity and remaining gaps
- [Tool Status](docs/06_tool_status.md) - Glutinum/Hawaii limitations and mitigations
- [Generators](generators/README.md) - Generation pipeline usage and configuration

### Concepts and Future
- Actor Model Design - Durable Object actor model with tell/ask semantics
  - [Overview](docs/08a_actor_model_overview.md) - Architecture summary, layering, phases
  - [Actor Core](docs/08b_actor_core.md) - DO substrate, WebSocket, BAREWire, lifecycle, supervision
  - [MailboxProcessor Intercept](docs/08c_mailbox_intercept.md) - API surface, push model, migration
  - [Persistence & Observability](docs/08d_persistence_observability.md) - Event sourcing, journals, instrumentation
- [Firetower Concept](docs/04_firetower_concept.md) - Monitoring tool design
- [Pulumi Insights](docs/05_pulumi_insights.md) - Lessons from Pulumi's approach
- [Pages Direct Upload](docs/07_pages_direct_upload.md) - Pages upload implementation

### Examples
- [Samples](samples/) - Working examples demonstrating framework capabilities

## Contributing

We welcome contributions! See [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines.

## Support

- **Issues**: [GitHub Issues](https://github.com/FidelityFramework/Fidelity.CloudEdge/issues)
- **Discussions**: [GitHub Discussions](https://github.com/FidelityFramework/Fidelity.CloudEdge/discussions)

## License

Licensed under either of

* Apache License, Version 2.0 ([LICENSE-APACHE](LICENSE-APACHE) or http://www.apache.org/licenses/LICENSE-2.0)
* MIT license ([LICENSE-MIT](LICENSE-MIT) or http://opensource.org/licenses/MIT)

at your option.

### Contribution

Unless you explicitly state otherwise, any contribution intentionally submitted for inclusion in the work by you shall be dual licensed as above, without any additional terms or conditions.

---

## Acknowledgments

Fidelity.CloudEdge stands on the shoulders of giants:

- **[Fable](https://fable.io/)** - The magnificent F# to JavaScript compiler enabling substrate-agnostic actors at the edge. Special thanks to Alfonso Garcia-Caro, Maxime Mangel, and all maintainers/contributors.

- **[Glutinum](https://github.com/glutinum-org)** - TypeScript to F# binding generator. Thanks to Maxime Mangel for this invaluable tool that makes Worker bindings possible.

- **[Hawaii](https://github.com/Zaid-Ajaj/Hawaii)** - OpenAPI to F# client generator. Thanks to Zaid Ajaj for creating this and pioneering F# on Cloudflare Workers.

- **[Cloudflare](https://cloudflare.com)** - For building an incredible edge platform with Durable Objects, providing the sequential execution context necessary for actor guarantees at the edge.

This project is SpeakEZ's contribution to the F#, Fable, and Cloudflare communities, and a key component of the broader Fidelity Framework vision.
