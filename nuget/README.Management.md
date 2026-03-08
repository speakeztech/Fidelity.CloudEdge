# Fidelity.CloudEdge.Management

**F# clients for the full Cloudflare Management API surface**

> **Management-side clients** — Use this package to manage Cloudflare resources from .NET applications. For writing Cloudflare Workers in F#, see [Fidelity.CloudEdge.Runtime](https://www.nuget.org/packages/Fidelity.CloudEdge.Runtime).

## What is this?

Fidelity.CloudEdge.Management provides F# client libraries for Cloudflare's REST Management APIs. Use these to programmatically create, configure, and manage Cloudflare resources from any .NET application, whether that is deployment scripts, admin tools, CI/CD pipelines, or backend services.

All 32 clients are generated from the official [Cloudflare OpenAPI specification](https://github.com/cloudflare/api-schemas) using [Hawaii](https://github.com/Zaid-Ajaj/Hawaii).

## Supported Services (32)

### Compute and Storage

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Workers** | `Fidelity.CloudEdge.Management.Workers` | Deploy and configure Workers scripts |
| **Pages** | `Fidelity.CloudEdge.Management.Pages` | Manage Cloudflare Pages projects |
| **Durable Objects** | `Fidelity.CloudEdge.Management.DurableObjects` | Manage Durable Object namespaces |
| **Containers** | `Fidelity.CloudEdge.Management.Containers` | Manage container deployments |
| **KV** | `Fidelity.CloudEdge.Management.KV` | Create and manage KV namespaces |
| **R2** | `Fidelity.CloudEdge.Management.R2` | Create and manage R2 buckets |
| **R2 Catalog** | `Fidelity.CloudEdge.Management.R2Catalog` | R2 data catalog operations |
| **D1** | `Fidelity.CloudEdge.Management.D1` | Create and manage D1 databases |
| **Queues** | `Fidelity.CloudEdge.Management.Queues` | Create and manage message queues |
| **Hyperdrive** | `Fidelity.CloudEdge.Management.Hyperdrive` | Configure database connection pooling |
| **Secrets Store** | `Fidelity.CloudEdge.Management.SecretsStore` | Manage application secrets |

### AI and ML

| Service | Namespace | Description |
|---------|-----------|-------------|
| **AI** | `Fidelity.CloudEdge.Management.AI` | Workers AI model management and inference |
| **AI Gateway** | `Fidelity.CloudEdge.Management.AIGateway` | AI Gateway routing and observability |
| **AI Search** | `Fidelity.CloudEdge.Management.AISearch` | AI-powered search configuration |
| **AutoRAG** | `Fidelity.CloudEdge.Management.AutoRAG` | Automated retrieval-augmented generation |
| **Vectorize** | `Fidelity.CloudEdge.Management.Vectorize` | Create and manage vector indexes |

### Orchestration

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Workflows** | `Fidelity.CloudEdge.Management.Workflows` | Durable workflow orchestration |
| **Pipelines** | `Fidelity.CloudEdge.Management.Pipelines` | Data pipeline configuration |

### Media

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Stream** | `Fidelity.CloudEdge.Management.Stream` | Video streaming and storage |
| **Images** | `Fidelity.CloudEdge.Management.Images` | Image optimization and delivery |
| **Browser Rendering** | `Fidelity.CloudEdge.Management.BrowserRendering` | Headless browser rendering |
| **Calls** | `Fidelity.CloudEdge.Management.Calls` | Real-time communication (WebRTC) |

### Networking and Security

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Access** | `Fidelity.CloudEdge.Management.Access` | Zero Trust Access policies and applications |
| **Gateway** | `Fidelity.CloudEdge.Management.Gateway` | Zero Trust Gateway DNS and HTTP filtering |
| **Tunnels** | `Fidelity.CloudEdge.Management.Tunnels` | Cloudflare Tunnel management |
| **Load Balancers** | `Fidelity.CloudEdge.Management.LoadBalancers` | Load balancer pools and monitors |
| **Waiting Rooms** | `Fidelity.CloudEdge.Management.WaitingRooms` | Virtual waiting room configuration |
| **Magic** | `Fidelity.CloudEdge.Management.Magic` | Magic Transit and WAN configuration |
| **Email** | `Fidelity.CloudEdge.Management.Email` | Email Routing rules and configuration |

### Observability and Platform

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Analytics** | `Fidelity.CloudEdge.Management.Analytics` | Query analytics data |
| **Logs** | `Fidelity.CloudEdge.Management.Logs` | Logpush and log retrieval |
| **Builds** | `Fidelity.CloudEdge.Management.Builds` | Build and deployment management |

## Installation

```bash
dotnet add package Fidelity.CloudEdge.Management
```

## Quick Example

```fsharp
open System.Net.Http
open Fidelity.CloudEdge.Management.D1

let httpClient = new HttpClient()
httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiToken}")

let d1Client = D1Client(httpClient)

// List all D1 databases in an account
let! databases = d1Client.ListDatabases(accountId)

for db in databases do
    printfn $"Database: {db.Name} (ID: {db.Id})"
```

## Authentication

All Management API calls require authentication. Use either:

- **API Token** (recommended): Create a token at [dash.cloudflare.com/profile/api-tokens](https://dash.cloudflare.com/profile/api-tokens)
- **API Key**: Your Global API Key + email (legacy method)

```fsharp
// API Token (recommended)
httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiToken}")

// Or API Key (legacy)
httpClient.DefaultRequestHeaders.Add("X-Auth-Key", apiKey)
httpClient.DefaultRequestHeaders.Add("X-Auth-Email", email)
```

## Requirements

- .NET Standard 2.0 compatible runtime (.NET 6+, .NET Framework 4.6.1+)
- `System.Net.Http` for HTTP requests
- `Newtonsoft.Json` and `Fable.Remoting.Json` (included as transitive dependencies)

## Related Package

- **[Fidelity.CloudEdge.Runtime](https://www.nuget.org/packages/Fidelity.CloudEdge.Runtime)** — F# and Fable bindings for writing Cloudflare Workers (in-worker APIs for KV, R2, D1, etc.)

## Links

- [GitHub Repository](https://github.com/FidelityFramework/Fidelity.CloudEdge)
- [Cloudflare API Documentation](https://developers.cloudflare.com/api/)

## License

MIT OR Apache-2.0
