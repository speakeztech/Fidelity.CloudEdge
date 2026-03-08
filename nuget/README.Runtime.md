# Fidelity.CloudEdge.Runtime

**F# and Fable bindings for the full Cloudflare Workers Runtime API surface**

> **Worker-side bindings** — Use this package to write Cloudflare Workers in F#. For managing Cloudflare resources from .NET applications, see [Fidelity.CloudEdge.Management](https://www.nuget.org/packages/Fidelity.CloudEdge.Management).

## What is this?

Fidelity.CloudEdge.Runtime provides F# type bindings for the APIs available *inside* a running Cloudflare Worker. These bindings are designed for use with [Fable](https://fable.io/) to compile F# to JavaScript that runs on Cloudflare's edge network.

The package includes 727 types generated from the official [@cloudflare/workers-types](https://github.com/cloudflare/workerd) TypeScript definitions using [Glutinum](https://github.com/glutinum-org/cli), plus hand-crafted helper modules for idiomatic F# usage.

## Supported Services

### Core Worker APIs

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Worker.Context** | `Fidelity.CloudEdge.Worker.Context` | Request, Response, Headers, FetchEvent, ExecutionContext, Fetcher, ServiceWorkerGlobalScope |
| **Fetch and Networking** | `Fidelity.CloudEdge.Worker.Context` | Fetch API, Socket, SocketAddress, SocketOptions, URL, URLPattern, URLSearchParams |
| **Streams** | `Fidelity.CloudEdge.Worker.Context` | ReadableStream, WritableStream, TransformStream, FixedLengthStream, CompressionStream, DecompressionStream |
| **Crypto** | `Fidelity.CloudEdge.Worker.Context` | Web Crypto API: SubtleCrypto, CryptoKey, CryptoKeyPair, DigestStream |
| **Cache** | `Fidelity.CloudEdge.Worker.Context` | Cache API, CacheStorage, CacheQueryOptions |
| **HTMLRewriter** | `Fidelity.CloudEdge.Worker.Context` | HTML parsing and transformation on the edge |
| **Encoding** | `Fidelity.CloudEdge.Worker.Context` | TextEncoderStream, TextDecoderStream |
| **Forms and Blobs** | `Fidelity.CloudEdge.Worker.Context` | FormData, Blob, BlobOptions |

### Storage and Data

| Service | Namespace | Description |
|---------|-----------|-------------|
| **KV** | `Fidelity.CloudEdge.KV` | Key-value storage: get, put, delete, list with expiration and metadata |
| **R2** | `Fidelity.CloudEdge.R2` | S3-compatible object storage operations |
| **D1** | `Fidelity.CloudEdge.D1` | SQLite database queries, prepared statements, batch operations, sessions |
| **Durable Objects** | `Fidelity.CloudEdge.DurableObjects` | Stateful compute with transactional storage, alarms, WebSocket hibernation, and RPC |
| **Queues** | `Fidelity.CloudEdge.Queues` | Message queue producers and consumers with retry and batching |
| **Vectorize** | `Fidelity.CloudEdge.Vectorize` | Vector database for embeddings, similarity search, and metadata filtering |
| **Hyperdrive** | `Fidelity.CloudEdge.Hyperdrive` | Database connection pooling with automatic caching |
| **Analytics Engine** | `Fidelity.CloudEdge.Worker.Context` | AnalyticsEngineDataset, AnalyticsEngineDataPoint |

### AI and ML

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Workers AI** | `Fidelity.CloudEdge.AI` | Full inference API with per-model typed inputs and outputs (text generation, embeddings, image generation, speech, translation, classification, object detection, and more) |
| **AI Gateway** | `Fidelity.CloudEdge.Worker.Context` | AiGateway routing, logging, and provider configuration |
| **AI Search** | `Fidelity.CloudEdge.Worker.Context` | AiSearchInstance, search requests and responses |
| **AutoRAG** | `Fidelity.CloudEdge.Worker.Context` | Automated retrieval-augmented generation with search and chat |

### Compute and Orchestration

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Containers** | `Fidelity.CloudEdge.Worker.Context` | Container runtime with startup options |
| **Workflows** | `Fidelity.CloudEdge.Worker.Context` | Durable workflow instances, sleep/retry durations, error handling |
| **Service Bindings** | `Fidelity.CloudEdge.Worker.Context` | Service-to-service RPC via Fetcher and Service types |
| **Cron Triggers** | `Fidelity.CloudEdge.Worker.Context` | ExportedHandlerScheduledHandler, SchedulerWaitOptions |

### Media

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Images** | `Fidelity.CloudEdge.Worker.Context` | ImagesBinding, ImageTransformer, transformations, draw, metadata, upload |
| **Media Transforms** | `Fidelity.CloudEdge.Worker.Context` | MediaTransformer, MediaTransformationGenerator for video/audio processing |
| **Markdown** | `Fidelity.CloudEdge.Worker.Context` | ToMarkdownService for HTML-to-Markdown conversion |

### Email

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Email Routing** | `Fidelity.CloudEdge.Worker.Context` | EmailMessage, EmailEvent, ForwardableEmailMessage, SendEmail |

### Observability

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Tail and Trace** | `Fidelity.CloudEdge.Worker.Context` | TailEvent, TraceItem, TraceLog, TraceMetrics, TraceDiagnosticChannelEvent |
| **WebSockets** | `Fidelity.CloudEdge.Worker.Context` | WebSocket, WebSocketEventMap, hibernatable WebSocket events |

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
    CloudEdge.DurableObjects/  Durable Objects bindings
    CloudEdge.Hyperdrive/      Hyperdrive bindings
    CloudEdge.KV/        KV storage bindings
    CloudEdge.Queues/    Queue bindings
    CloudEdge.R2/        R2 object storage bindings
    CloudEdge.Vectorize/ Vector database bindings
    CloudEdge.Worker.Context/  Core types + full workers-types surface (727 types)
```

## Requirements

- [Fable](https://fable.io/) 4.x for F# to JavaScript compilation
- `Fable.Core` and `Fable.Promise` (included as transitive dependencies)

## Related Package

- **[Fidelity.CloudEdge.Management](https://www.nuget.org/packages/Fidelity.CloudEdge.Management)** — 32 F# clients for Cloudflare's REST Management APIs (create databases, deploy workers, manage buckets, configure tunnels, etc.)

## Links

- [GitHub Repository](https://github.com/FidelityFramework/Fidelity.CloudEdge)
- [Cloudflare Workers Documentation](https://developers.cloudflare.com/workers/)
- [Fable Documentation](https://fable.io/docs/)

## License

MIT OR Apache-2.0
