# Fidelity.CloudEdge.Runtime

**F# and Fable bindings for Cloudflare Workers Runtime APIs**

> **Worker-side bindings** — Use this package to write Cloudflare Workers in F#. For managing Cloudflare resources from .NET applications, see [Fidelity.CloudEdge.Management](https://www.nuget.org/packages/Fidelity.CloudEdge.Management).

## What is this?

Fidelity.CloudEdge.Runtime provides F# type bindings for the APIs available *inside* a running Cloudflare Worker. These bindings are designed for use with [Fable](https://fable.io/) to compile F# to JavaScript that runs on Cloudflare's edge network.

Runtime bindings are generated from the official [@cloudflare/workers-types](https://github.com/cloudflare/workerd) TypeScript definitions using [Glutinum](https://github.com/glutinum-org/cli).

## Supported Services

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Worker.Context** | `Fidelity.CloudEdge.Worker.Context` | Core Worker types: Request, Response, Headers, ExecutionContext, Fetcher |
| **KV** | `Fidelity.CloudEdge.KV` | Key-value storage read/write from within a Worker |
| **R2** | `Fidelity.CloudEdge.R2` | Object storage (S3-compatible) operations |
| **D1** | `Fidelity.CloudEdge.D1` | SQLite database queries and prepared statements |
| **Durable Objects** | `Fidelity.CloudEdge.DurableObjects` | Stateful serverless compute with storage, alarms, and WebSocket hibernation |
| **Queues** | `Fidelity.CloudEdge.Queues` | Message queue producers and consumers |
| **Vectorize** | `Fidelity.CloudEdge.Vectorize` | Vector database for embeddings, similarity search, and metadata filtering |
| **Hyperdrive** | `Fidelity.CloudEdge.Hyperdrive` | Database connection pooling with automatic caching |
| **AI** | `Fidelity.CloudEdge.AI` | Workers AI inference (text generation, embeddings, image models) |

A shared **Core** library (`Fidelity.CloudEdge.Core`) provides common utilities used across all runtime bindings.

## Installation

```bash
dotnet add package Fidelity.CloudEdge.Runtime
```

## Quick Example

```fsharp
open Fidelity.CloudEdge.Worker.Context
open Fidelity.CloudEdge.KV

let handler (request: Request) (env: obj) (ctx: ExecutionContext) =
    promise {
        // Access KV namespace from environment bindings
        let kv = env?MY_KV_NAMESPACE :?> KVNamespace

        // Read a value
        let! value = kv.get "my-key"

        // Return a response
        return Response.create($"Value: {value}")
    }
```

## How It Works

This package includes both compiled .NET DLLs (for IDE support and type checking) and F# source files in a `fable/` folder. When Fable compiles your project, it reads the source files directly and produces JavaScript that calls the Cloudflare Workers runtime APIs.

### Package Structure

```
lib/net10.0/           Compiled DLLs for IDE intellisense
fable/                 F# sources for Fable compilation
  Core/                  Shared utilities
  Runtime/
    CloudEdge.AI/        Workers AI bindings
    CloudEdge.D1/        D1 database bindings
    CloudEdge.KV/        KV storage bindings
    ...
```

## Requirements

- [Fable](https://fable.io/) 4.x for F# to JavaScript compilation
- A Cloudflare Workers project (typically set up with [Wrangler](https://developers.cloudflare.com/workers/wrangler/))
- `Fable.Core` and `Fable.Promise` (included as transitive dependencies)

## Related Package

- **[Fidelity.CloudEdge.Management](https://www.nuget.org/packages/Fidelity.CloudEdge.Management)** — 32 F# clients for Cloudflare's REST Management APIs (create databases, deploy workers, manage buckets, configure tunnels, etc.)

## Links

- [GitHub Repository](https://github.com/FidelityFramework/Fidelity.CloudEdge)
- [Cloudflare Workers Documentation](https://developers.cloudflare.com/workers/)
- [Fable Documentation](https://fable.io/docs/)

## License

MIT OR Apache-2.0
