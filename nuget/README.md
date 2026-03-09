# Fidelity.CloudEdge NuGet Packages

This folder contains the build scripts and configuration for creating the Fidelity.CloudEdge NuGet packages:

- **Fidelity.CloudEdge.Runtime** - F# and Fable bindings for Cloudflare Workers Runtime APIs
- **Fidelity.CloudEdge.Management** - F# clients for Cloudflare Management APIs

## Building the Packages

From the `nuget/` directory, run:

```bash
dotnet fsi build.fsx
```

This will:
1. Build all projects in Release mode
2. Generate the unified `Fidelity.CloudEdge.Runtime.fsproj` for Fable
3. Create both NuGet packages in `out/`

## Changing the Version

Edit `Directory.Build.props` and update the `<Version>` element:

```xml
<Version>0.1.7</Version>
```

The version is shared by both packages. It can also be overridden at pack time via `/p:PackageVersion=x.y.z`. The GitHub Actions workflow (`nuget-publish.yml`) extracts the version from the git tag automatically.

---

## Fidelity.CloudEdge.Runtime

The `Fidelity.CloudEdge.Runtime` package bundles multiple F# projects into a single NuGet package that works with Fable (F# to JavaScript compiler).

### The Problem

Fable packages need a special structure:
- A `fable/` folder containing an `.fsproj` file and all `.fs` source files
- The `.fsproj` must list all files in the correct compilation order

Maintaining this manually across 10+ projects would be error-prone and tedious.

### The Solution

The `build.fsx` script automatically generates a unified `Fidelity.CloudEdge.Runtime.fsproj` by:

1. Reading each Runtime project's `.fsproj` file
2. Extracting the `<Compile Include="..." />` entries (preserving order)
3. Combining them into a single `.fsproj` with correct relative paths

This means when you add, remove, or rename files in any Runtime project, you just rebuild the package and the unified `.fsproj` is automatically updated.

### Package Structure

```
Fidelity.CloudEdge.Runtime.{version}.nupkg
├── lib/net10.0/           # Compiled DLLs for IDE support
│   ├── Fidelity.CloudEdge.AI.dll
│   ├── Fidelity.CloudEdge.D1.dll
│   ├── Fidelity.CloudEdge.KV.dll
│   └── ...
├── fable/                # Fable sources
│   ├── Fidelity.CloudEdge.Runtime.fsproj   # Unified project file
│   ├── Core/
│   │   └── Fidelity.CloudEdge.Core/*.fs
│   └── Runtime/
│       ├── Fidelity.CloudEdge.AI/*.fs
│       ├── Fidelity.CloudEdge.D1/*.fs
│       └── ...
└── README.md
```

### Projects Included

The package includes Core and all Runtime projects:

- `Fidelity.CloudEdge.Core` - Core utilities
- `Fidelity.CloudEdge.Worker.Context` - Worker context types (Request, Response, etc.)
- `Fidelity.CloudEdge.AI` - Workers AI bindings
- `Fidelity.CloudEdge.D1` - D1 database bindings
- `Fidelity.CloudEdge.DurableObjects` - Durable Objects bindings
- `Fidelity.CloudEdge.Hyperdrive` - Hyperdrive bindings
- `Fidelity.CloudEdge.KV` - KV storage bindings
- `Fidelity.CloudEdge.Queues` - Queues bindings
- `Fidelity.CloudEdge.R2` - R2 storage bindings
- `Fidelity.CloudEdge.Vectorize` - Vectorize bindings

---

## Fidelity.CloudEdge.Management

The `Fidelity.CloudEdge.Management` package provides F# clients for Cloudflare's Management APIs. These are .NET-only (not compatible with Fable) and are used to manage Cloudflare resources from .NET applications.

### Package Structure

```
Fidelity.CloudEdge.Management.{version}.nupkg
├── lib/netstandard2.0/   # Compiled DLLs
│   ├── Fidelity.CloudEdge.Management.Analytics.dll
│   ├── Fidelity.CloudEdge.Management.D1.dll
│   ├── Fidelity.CloudEdge.Management.Workers.dll
│   └── ...
└── README.md
```

### Projects Included (32 services)

- `Fidelity.CloudEdge.Management.Access` - Zero Trust Access management
- `Fidelity.CloudEdge.Management.AI` - Workers AI management
- `Fidelity.CloudEdge.Management.AIGateway` - AI Gateway management
- `Fidelity.CloudEdge.Management.AISearch` - AI Search management
- `Fidelity.CloudEdge.Management.Analytics` - Analytics API client
- `Fidelity.CloudEdge.Management.AutoRAG` - AutoRAG management
- `Fidelity.CloudEdge.Management.BrowserRendering` - Browser Rendering management
- `Fidelity.CloudEdge.Management.Builds` - Builds management
- `Fidelity.CloudEdge.Management.Calls` - Calls management
- `Fidelity.CloudEdge.Management.Containers` - Containers management
- `Fidelity.CloudEdge.Management.D1` - D1 database management
- `Fidelity.CloudEdge.Management.DurableObjects` - Durable Objects management
- `Fidelity.CloudEdge.Management.Email` - Email Routing management
- `Fidelity.CloudEdge.Management.Gateway` - Zero Trust Gateway management
- `Fidelity.CloudEdge.Management.Hyperdrive` - Hyperdrive management
- `Fidelity.CloudEdge.Management.Images` - Images management
- `Fidelity.CloudEdge.Management.KV` - KV storage management
- `Fidelity.CloudEdge.Management.LoadBalancers` - Load Balancers management
- `Fidelity.CloudEdge.Management.Logs` - Logs management
- `Fidelity.CloudEdge.Management.Magic` - Magic Transit management
- `Fidelity.CloudEdge.Management.Pages` - Pages management
- `Fidelity.CloudEdge.Management.Pipelines` - Pipelines management
- `Fidelity.CloudEdge.Management.Queues` - Queues management
- `Fidelity.CloudEdge.Management.R2` - R2 storage management
- `Fidelity.CloudEdge.Management.R2Catalog` - R2 Catalog management
- `Fidelity.CloudEdge.Management.SecretsStore` - Secrets Store management
- `Fidelity.CloudEdge.Management.Stream` - Stream management
- `Fidelity.CloudEdge.Management.Tunnels` - Tunnels management
- `Fidelity.CloudEdge.Management.Vectorize` - Vectorize management
- `Fidelity.CloudEdge.Management.WaitingRooms` - Waiting Rooms management
- `Fidelity.CloudEdge.Management.Workers` - Workers management
- `Fidelity.CloudEdge.Management.Workflows` - Workflows management

---

## Files

| File | Description |
|------|-------------|
| `build.fsx` | Fun.Build script for building and packing |
| `Fidelity.CloudEdge.Runtime.proj` | Runtime package definition (version, metadata, contents) |
| `Fidelity.CloudEdge.Management.proj` | Management package definition (version, metadata, contents) |
| `obj/Fidelity.CloudEdge.Runtime.fsproj` | Auto-generated unified Fable project (in obj/) |
| `out/` | Output folder for .nupkg files (gitignored) |
