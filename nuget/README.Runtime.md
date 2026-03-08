# Fidelity.CloudEdge.Runtime

**F# and Fable bindings for the full Cloudflare Workers Runtime API surface**

> **Worker-side bindings** — Use this package to write Cloudflare Workers in F#. For managing Cloudflare resources from .NET applications, see [Fidelity.CloudEdge.Management](https://www.nuget.org/packages/Fidelity.CloudEdge.Management).

## What is this?

Fidelity.CloudEdge.Runtime provides F# type bindings for the APIs available *inside* a running Cloudflare Worker. These bindings are designed for use with [Fable](https://fable.io/) to compile F# to JavaScript that runs on Cloudflare's edge network.

The package includes 727 types generated from the official [@cloudflare/workers-types](https://github.com/cloudflare/workerd) TypeScript definitions using [Glutinum](https://github.com/glutinum-org/cli), plus hand-crafted helper modules for idiomatic F# usage.

## Supported Services

The runtime surface is split into two tiers. **Dedicated packages** provide hand-crafted types and idiomatic F# helper modules for the most commonly used Cloudflare services. The **Worker.Context** package contains Glutinum-generated bindings covering the remainder of the `@cloudflare/workers-types` surface.

### Dedicated Service Packages

Each package below has its own `Types.fs` and `Helpers.fs` modules with idiomatic F# APIs.

| Package | Namespace | Key Types |
|---------|-----------|-----------|
| **D1** | `Fidelity.CloudEdge.D1` | D1Database, D1PreparedStatement, D1Result\<'T\>, D1ExecResult |
| **KV** | `Fidelity.CloudEdge.KV` | KVNamespace, KVPutOptions, KVListOptions, KVListResult, KVKey |
| **R2** | `Fidelity.CloudEdge.R2` | R2Bucket, R2Object, R2ObjectBody, R2PutOptions, R2HTTPMetadata |
| **DurableObjects** | `Fidelity.CloudEdge.DurableObjects` | DurableObjectId, DurableObjectStub, DurableObjectNamespace |
| **Queues** | `Fidelity.CloudEdge.Queues` | Queue\<'Body\>, Message\<'Body\>, MessageBatch\<'Body\>, QueueSendOptions |
| **AI** | `Fidelity.CloudEdge.AI` | Per-model typed I/O for text generation, embeddings, image generation, speech, translation, classification, object detection |
| **Vectorize** | `Fidelity.CloudEdge.Vectorize` | VectorizeVector, VectorizeMatches, VectorMatch, VectorizeQueryOptions |
| **Hyperdrive** | `Fidelity.CloudEdge.Hyperdrive` | Hyperdrive, connection pooling, PostgreSQL/MySQL URL builders |

### Worker.Context (Generated Bindings)

`Fidelity.CloudEdge.Worker.Context` contains the core Worker runtime types plus the full Glutinum-generated surface from `@cloudflare/workers-types`. All types below share the `Fidelity.CloudEdge.Worker.Context` namespace.

| Category | Key Types |
|----------|-----------|
| **Core Worker APIs** | Request, Response, Headers, FetchEvent, ExecutionContext, Fetcher, ServiceWorkerGlobalScope |
| **Fetch and Networking** | Fetch API, Socket, SocketAddress, SocketOptions, URL, URLPattern, URLSearchParams |
| **Streams** | ReadableStream, WritableStream, TransformStream, FixedLengthStream, CompressionStream, DecompressionStream |
| **Crypto** | SubtleCrypto, CryptoKey, CryptoKeyPair, DigestStream |
| **Cache** | Cache, CacheStorage, CacheQueryOptions |
| **HTMLRewriter** | HTMLRewriter, Element, Comment, Text, DocumentEnd |
| **WebSockets** | WebSocket, WebSocketEventMap, hibernatable WebSocket events |
| **Encoding and Data** | TextEncoderStream, TextDecoderStream, FormData, Blob, BlobOptions |
| **Analytics Engine** | AnalyticsEngineDataset, AnalyticsEngineDataPoint |
| **AI Gateway** | AiGateway routing, logging, and provider configuration |
| **AI Search** | AiSearchInstance, search requests and responses |
| **AutoRAG** | Automated retrieval-augmented generation with search and chat |
| **Containers** | Container runtime with startup options |
| **Workflows** | Durable workflow instances, sleep/retry durations, error handling |
| **Service Bindings** | Fetcher, Service types for service-to-service RPC |
| **Cron Triggers** | ExportedHandlerScheduledHandler, SchedulerWaitOptions |
| **Images** | ImagesBinding, ImageTransformer, transformations, draw, metadata, upload |
| **Media Transforms** | MediaTransformer, MediaTransformationGenerator for video/audio processing |
| **Markdown** | ToMarkdownService for HTML-to-Markdown conversion |
| **Email Routing** | EmailMessage, EmailEvent, ForwardableEmailMessage, SendEmail |
| **Tail and Trace** | TailEvent, TraceItem, TraceLog, TraceMetrics, TraceDiagnosticChannelEvent |

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
lib/net10.0/                       Compiled DLLs for IDE intellisense
fable/                             F# sources for Fable compilation
  Core/                              Shared utilities
  Runtime/
    CloudEdge.Worker.Context/        Core types + Glutinum-generated surface
    CloudEdge.D1/                    D1 database (Types.fs + Helpers.fs)
    CloudEdge.KV/                    KV storage (Types.fs + Helpers.fs)
    CloudEdge.R2/                    R2 object storage (Types.fs + Helpers.fs)
    CloudEdge.DurableObjects/        Durable Objects (Types.fs + Helpers.fs)
    CloudEdge.Queues/                Queue messaging (Types.fs + Helpers.fs)
    CloudEdge.AI/                    Workers AI (Generated.fs + Extensions.fs)
    CloudEdge.Vectorize/             Vector database (Types.fs + Helpers.fs)
    CloudEdge.Hyperdrive/            Database proxy (Types.fs + Helpers.fs)
```

The 727 type count spans all 9 assemblies. `Worker.Context` accounts for the majority via its `Generated.fs` Glutinum output; the dedicated packages contribute focused, hand-crafted types with helper modules.

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
