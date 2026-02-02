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

### Framework Hierarchy

```
Fidelity Framework
├── Fidelity.Core           # Core actor model abstractions
├── Fidelity.Firefly        # MLIR backend for bare metal
└── Fidelity.CloudEdge      # Edge extension (this project)
    ├── Runtime             # In-Worker APIs (JavaScript interop)
    └── Management          # Infrastructure provisioning (REST clients)
```

### Dual-Layer Architecture

Fidelity.CloudEdge maintains the dual-layer design pattern:

```
Fidelity.CloudEdge/
└─ src/
   ├── Runtime/                    # In-Worker APIs (JavaScript interop)
   │   ├── CloudEdge.Core/
   │   ├── CloudEdge.Worker.Context/
   │   ├── CloudEdge.D1/
   │   ├── CloudEdge.R2/
   │   ├── CloudEdge.KV/
   │   ├── CloudEdge.AI/
   │   ├── CloudEdge.Queues/
   │   ├── CloudEdge.Vectorize/
   │   ├── CloudEdge.Hyperdrive/
   │   └── CloudEdge.DurableObjects/
   │
   └── Management/                 # REST APIs (HTTP clients)
       ├── CloudEdge.Management.D1/
       ├── CloudEdge.Management.R2/
       ├── CloudEdge.Management.Workers/
       ├── CloudEdge.Management.Analytics/
       ├── CloudEdge.Management.Queues/
       ├── CloudEdge.Management.Vectorize/
       ├── CloudEdge.Management.Hyperdrive/
       └── CloudEdge.Management.DurableObjects/
```

#### Runtime Layer (In-Worker)
- **Purpose**: Operations inside Cloudflare Workers
- **Source**: TypeScript definitions via [Glutinum](https://github.com/glutinum-org/cli)
- **Usage**: Direct platform access with microsecond latency
- **Actor Context**: Provides sequential execution guarantees for actor message processing

#### Management Layer (External)
- **Purpose**: Infrastructure provisioning, monitoring, and orchestration
- **Source**: OpenAPI specifications via [Hawaii](https://github.com/Zaid-Ajaj/Hawaii)
- **Usage**: REST API clients for deployment tools and scripts
- **Framework Role**: Enables dynamic resource allocation for actor migrations

### Actor Model Substrate Transparency

The core insight of Fidelity.CloudEdge is that the actor model doesn't care where it runs:

```fsharp
// Same code, different substrates
type UserActor() =
    let mailbox = MailboxProcessor<UserMsg>.Start(fun inbox ->
        async {
            while true do
                let! msg = inbox.Receive()
                match msg with
                | GetUser userId ->
                    // Sequential processing guaranteed
                    let! user = database.GetUser(userId)
                    // ...
        })

// Bare Metal (via Firefly): MLIR compilation → native code
// Edge (via Fable): F# → JavaScript → V8 in Cloudflare Workers

// Both provide: message queue, sequential processing, state isolation
```

### Durable Objects as Actor Substrate

Cloudflare's Durable Objects provide the sequential execution context necessary for actor model guarantees:

- **Single-threaded execution**: Each Durable Object instance handles one request at a time
- **Guaranteed ordering**: Messages are processed in FIFO order
- **State isolation**: Each actor instance has isolated state
- **Geographic affinity**: Objects can be co-located with data for low latency

This makes Durable Objects a natural substrate for F# actors at the edge:

```fsharp
// RAG Agent as Durable Object
open Fidelity.CloudEdge.DurableObjects
open Fidelity.CloudEdge.AI
open Fidelity.CloudEdge.Vectorize

[<DurableObject>]
type RAGAgent(state: DurableObjectState, env: Env) =
    let vectorize = env.VECTOR_INDEX
    let ai = env.AI

    member this.fetch(request: Request) = async {
        let! query = request.json<QueryRequest>()

        // Sequential processing guaranteed by Durable Object runtime
        let! vectors = vectorize.query(query.embedding, topK = 5)
        let context = vectors |> buildContext
        let! response = ai.run(Llama_3, {| prompt = query.text; context = context |})

        return Response.json(response)
    }
```

## Current Implementation Status

> **⚠️ Important Note**: While the generated code is coherent, extensive testing and validation is required before production use.

### ✅ Generated

| Layer | Package | Description |
|-------|---------|-------------|
| **Runtime** | Fidelity.CloudEdge.Core | Core types and utilities |
| **Runtime** | Fidelity.CloudEdge.Worker.Context | Core Worker types (Request, Response) |
| **Runtime** | Fidelity.CloudEdge.KV | Key-Value storage bindings |
| **Runtime** | Fidelity.CloudEdge.R2 | Object storage bindings |
| **Runtime** | Fidelity.CloudEdge.D1 | Database bindings |
| **Runtime** | Fidelity.CloudEdge.AI | Workers AI bindings |
| **Runtime** | Fidelity.CloudEdge.Queues | Message queue bindings |
| **Runtime** | Fidelity.CloudEdge.Vectorize | Vector database bindings |
| **Runtime** | Fidelity.CloudEdge.Hyperdrive | Database connection pooling |
| **Runtime** | Fidelity.CloudEdge.DurableObjects | Stateful serverless compute (actor substrate) |
| **Management** | Fidelity.CloudEdge.Management.Workers | Worker deployment and configuration |
| **Management** | Fidelity.CloudEdge.Management.R2 | R2 bucket management |
| **Management** | Fidelity.CloudEdge.Management.D1 | D1 database management |
| **Management** | Fidelity.CloudEdge.Management.Analytics | Analytics API client |
| **Management** | Fidelity.CloudEdge.Management.Queues | Queue management |
| **Management** | Fidelity.CloudEdge.Management.Vectorize | Vector index management (V2 API) |
| **Management** | Fidelity.CloudEdge.Management.Hyperdrive | Connection config management |
| **Management** | Fidelity.CloudEdge.Management.DurableObjects | Namespace management |

### 🔄 In Progress

- CloudEdge.Management.KV (Hawaii generation issues)
- CloudEdge.Management.Logs (spec extraction pending)
- Browser APIs (WebSockets, Streams, Cache, WebCrypto)

### 📝 Recent Updates

- **Fidelity.CloudEdge Rebrand** (February 2025): Complete transformation from CloudflareFS to Fidelity.CloudEdge, emphasizing Framework extension and actor model substrate transparency.
- **Namespace Standardization** (January 2025): Unified all Management APIs under consistent `Fidelity.CloudEdge.Management.*` naming.
- **System.Text.Json Migration**: All generated clients now use `FSharp.SystemTextJson` for better Fable compatibility.
- **Hawaii Post-Processing**: Automated post-processing pipeline for discriminated unions and type generation improvements.
- **Vectorize V2 Migration**: Successfully migrated from deprecated V1 API to V2 (August 2024).
- **Full Compilation**: All Runtime and Management packages now compile cleanly with zero errors.

## Installation

### Runtime Packages (For Workers)
```bash
dotnet add package Fidelity.CloudEdge.Runtime
# Or individual packages:
dotnet add package Fidelity.CloudEdge.Worker.Context
dotnet add package Fidelity.CloudEdge.D1
dotnet add package Fidelity.CloudEdge.R2
dotnet add package Fidelity.CloudEdge.KV
```

### Management Packages (For Tools/Scripts)
```bash
dotnet add package Fidelity.CloudEdge.Management
# Or individual packages:
dotnet add package Fidelity.CloudEdge.Management.Workers
dotnet add package Fidelity.CloudEdge.Management.D1
dotnet add package Fidelity.CloudEdge.Management.R2
dotnet add package Fidelity.CloudEdge.Management.Analytics
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

    let d1Client = D1ManagementClient(httpClient)
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
        // env.DATABASE is bound via wrangler.toml
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

### KV Storage Example

```fsharp
// Runtime API - Inside Worker
open Fidelity.CloudEdge.KV

let handleKVRequest (env: Env) = async {
    // Get value
    let! value = env.CACHE.get("user:123")

    // Set with expiration
    do! env.CACHE.put("session:abc", userJson,
        KVPutOptions(expirationTtl = 3600))

    // List keys with prefix
    let! keys = env.CACHE.list(KVListOptions(prefix = "user:"))

    return Response.json(keys)
}
```

### R2 Object Storage Example

```fsharp
// Management API - Create bucket
let createBucket (accountId: string) = async {
    let r2Client = R2ManagementClient(httpClient)
    let! bucket = r2Client.CreateBucket(
        accountId = accountId,
        name = "my-assets",
        location = Some "wnam"
    )
    return bucket
}

// Runtime API - Use bucket
let handleR2Request (env: Env) = async {
    let bucket = env.ASSETS

    // Get object
    let! obj = bucket.get("image.png")
    match obj with
    | Some r2Object ->
        return Response.create(r2Object.body,
            ResponseInit(headers = r2Object.httpMetadata))
    | None ->
        return Response.notFound()
}
```

## Building from Source

### Prerequisites
- .NET 8.0 or later
- Node.js 18+
- Glutinum CLI: `npm install -g @glutinum/cli`
- Hawaii: `dotnet tool install -g hawaii`

### Build Commands

```bash
# Clone repository
git clone https://github.com/speakeztech/Fidelity.CloudEdge.git
cd Fidelity.CloudEdge

# Build entire solution
dotnet build Fidelity.CloudEdge.sln -c Release

# Run tests
dotnet test Fidelity.CloudEdge.sln -c Release

# Build NuGet packages
cd nuget
dotnet fsi build.fsx

# Run sample Worker
cd ../samples/HelloWorker
dotnet fable . --outDir dist
npx wrangler dev
```

## Generation Pipeline

### Runtime Bindings (TypeScript → F#)
```bash
cd generators/glutinum
npx @glutinum/cli generate \
    ../../node_modules/@cloudflare/workers-types/index.d.ts \
    --output ../../src/Runtime/CloudEdge.Worker.Context/Generated.fs
```

### Management APIs (OpenAPI → F#)
```bash
cd generators/hawaii

# 1. Segment the massive OpenAPI spec
dotnet fsi extract-services.fsx

# 2. Generate F# clients
hawaii --config d1-hawaii.json
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

### AskAI
RAG agent demonstrating actor model on edge:
- Durable Objects for stateful actor instances
- Vectorize for semantic search
- Workers AI for LLM inference
- CLI management interface

## Vision & Roadmap

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

    // Actor-aware resource management
    worker $"api-service-{env}" {
        actors [
            // Framework can migrate these between bare metal and edge
            actor<UserService> (durable "user-service")
            actor<RAGAgent> (durable "rag-agent")
        ]

        // Intelligent resource provisioning
        kv "CACHE" (ensureOrCreate "cache-namespace")
        d1 "DATABASE" (ensureOrCreate "app-database" {
            migrations = "./migrations"
            location = "wnam"
        })

        route $"api-{env}.example.com/*"
    }
}

// cfs deploy ./deploy.fsx              # Direct API deployment
// cfs deploy ./deploy.fsx --offline    # Generate wrangler.toml
// cfs deploy ./deploy.fsx --hybrid     # Provision + TOML generation
```

### Firetower - Visual Platform Observatory

Firetower will provide Erlang Observer-style monitoring for the entire Fidelity ecosystem:

- **Actor Visualization**: Live actor topology, message flow, and supervision trees
- **Cross-Substrate Monitoring**: Unified view of actors on bare metal and edge
- **Performance Analytics**: Latency heatmaps, throughput metrics, bottleneck detection
- **Cost Optimization**: Real-time billing estimates and substrate-switching recommendations

### Unified Development Experience

The complete toolkit will provide:

1. **Local Development**: Multi-Worker emulation with F# hot-reload
2. **Hybrid Testing**: Test actor code against both Firefly and Fable backends
3. **CI/CD Integration**: GitHub Actions with automatic substrate selection
4. **Multi-Environment Management**: Development, staging, production configurations
5. **Framework Observability**: Actor lifecycle tracking across substrates

## Documentation

### Core Architecture
- [Architecture Decisions](docs/00_architecture_decisions.md) - Key design choices and roadmap
- [Generation Strategy](docs/01_generation_strategy.md) - Glutinum vs Hawaii code generation
- [Dual Layer Architecture](docs/02_dual_layer_architecture.md) - Runtime vs Management APIs
- [OpenAPI Generation](docs/03_openapi_generation.md) - Hawaii setup and OpenAPI handling

### Implementation Details
- [Code-First Deployment](docs/04_code_first_deployment.md) - Code-driven deployment strategies
- [Gap Analysis](docs/05_gap_analysis.md) - Coverage comparison with workers-sdk
- [Conversion Patterns](docs/08_conversion_patterns.md) - TypeScript to F# patterns

### Tools & Future
- [Firetower Concept](docs/06_firetower_concept.md) - Monitoring tool design
- [Pulumi Insights](docs/07_pulumi_insights.md) - Lessons from Pulumi's approach

### Examples
- [Samples](samples/) - Working examples demonstrating framework capabilities

## Contributing

We welcome contributions! See [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines.

### Development Areas

Fidelity.CloudEdge is advancing toward production-ready bindings and Framework integration:

**Completed**:
- ✅ Complete rebrand to Fidelity.CloudEdge with Framework positioning
- ✅ Management API namespace standardization (all services use `Fidelity.CloudEdge.Management.*`)
- ✅ System.Text.Json migration for Fable compatibility
- ✅ All Runtime bindings (KV, R2, D1, AI, Queues, Vectorize, Hyperdrive, DurableObjects)
- ✅ 8 Management APIs fully generated and compiling

**In Progress**:
- 🔄 KV Management API (Hawaii generation challenges)
- 🔄 Logs Management API (extraction patterns pending)
- 🔄 Framework integration planning for actor migration

**Future Work**:
- Build the `cfs` CLI tool for type-safe, Framework-aware deployment
- Create Firetower monitoring application with cross-substrate visibility
- Implement actor migration between bare metal (Firefly) and edge (Fable)
- Expand sample applications demonstrating actor model patterns
- Contribute improvements back to Glutinum and Hawaii

## Support

- **Issues**: [GitHub Issues](https://github.com/speakeztech/Fidelity.CloudEdge/issues)
- **Discussions**: [GitHub Discussions](https://github.com/speakeztech/Fidelity.CloudEdge/discussions)

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

- **[Fable](https://fable.io/)** - The magnificent F# to JavaScript compiler enabling substrate-agnostic actors at the edge. Special thanks to Alfonso García-Caro, Maxime Mangel, and all maintainers/contributors.

- **[Glutinum](https://github.com/glutinum-org)** - TypeScript to F# binding generator. Thanks to Maxime Mangel for this invaluable tool that makes Worker bindings possible.

- **[Hawaii](https://github.com/Zaid-Ajaj/Hawaii)** - OpenAPI to F# client generator. Thanks to Zaid Ajaj for creating this and pioneering F# on Cloudflare Workers.

- **[F# Software Foundation](https://fsharp.org/)** - For fostering a language that makes functional programming practical and enjoyable, and for `MailboxProcessor` which proves the actor model's substrate transparency.

- **[Cloudflare](https://cloudflare.com)** - For building an incredible edge platform with Durable Objects, providing the sequential execution context necessary for actor guarantees at the edge.

- **CloudflareFS** - This project evolved from CloudflareFS, transforming from standalone tooling into a full Framework extension. We're grateful for the foundations laid by that earlier work.

This project is SpeakEZ's contribution to the F#, Fable, and Cloudflare communities, and a key component of the broader Fidelity Framework vision.
