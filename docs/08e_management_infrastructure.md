# Fidelity.CloudEdge Actor Model: Management Infrastructure

> Part of the [Actor Model Design](08a_actor_model_overview.md) series.

## 1. Management as Infrastructure Control Plane

The actor model described in documents 08a through 08d operates at runtime on Cloudflare's execution substrate: Durable Objects process messages, WebSockets carry frames, Queues buffer overflow, Analytics Engine records metrics. These services exist as runtime bindings, accessed through `env.*` in the Worker context.

However, runtime bindings presuppose that the underlying infrastructure has been provisioned. A Queue must exist before a Prospero can pivot messages into it. A KV namespace must exist before a dead-letter handler can write failed messages. An Analytics Engine dataset must exist before instrumentation can emit data points. A Logpush job must be configured before structured events flow to an external sink.

`Fidelity.CloudEdge.Management.*` provides the control plane for this provisioning. The 32 management service bindings cover the full Cloudflare API surface, and a subset of them map directly to actor model infrastructure concerns. This document identifies those mappings and describes how the management layer enables programmatic provisioning of the backplane services that the actor model depends on.

The relationship is unidirectional: the actor runtime consumes infrastructure that the management layer provisions. The management layer does not participate in message processing, supervision, or actor lifecycle. It is invoked during deployment, scaling decisions, or operational configuration; not during steady-state message dispatch.

## 2. Service Mapping

The table below maps actor model infrastructure concerns to the management services that provision them. Each entry identifies the concern, the management service, and the specific operations involved.

| Actor Model Concern | Management Service | Key Operations |
|---------------------|-------------------|----------------|
| Actor class deployment | `Management.Workers` | `UploadWorkerModule`, `UpdateUsageModel`, `CronTriggerUpdate` |
| DO namespace discovery | `Management.DurableObjects` | `ListNamespaces`, `ListObjects` |
| Elastic scaling (Queue pivot) | `Management.Queues` | `QueuesCreate`, `QueuesCreateConsumer`, `QueuesUpdate` |
| Dead-letter storage | `Management.KV` | `CreateANamespace`, `WriteKeyValuePairWithMetadata` |
| Read-side projections | `Management.D1` | `CreateDatabase`, `QueryDatabase` |
| Journal archival | `Management.R2` | `CreateBucket` |
| Observability pipeline | `Management.Analytics` | Dataset provisioning |
| Log export | `Management.Logs` | `CreateLogpushJob`, job configuration |
| Live debugging | `Management.Workers` | `TailLogsStartTail` |
| Scheduled maintenance | `Management.Workers` | `CronTriggerUpdateCronTriggers` |
| Secrets distribution | `Management.SecretsStore` | `CreateSecret`, `ListSecrets` |
| Cross-substrate tunnels | `Management.Tunnels` | `CreateATunnel`, tunnel configuration |
| Actor authorization | `Management.Access` | Application policies, short-lived certificates |
| External database access | `Management.Hyperdrive` | `CreateHyperdrive`, connection pooling config |
| Build automation | `Management.Builds` | Worker build pipeline management |

The remaining 17 management services (AI, AIGateway, AISearch, AutoRAG, BrowserRendering, Calls, Containers, Email, Gateway, Images, LoadBalancers, Magic, Pages, Pipelines, R2Catalog, Stream, Vectorize, WaitingRooms) are not directly involved in actor infrastructure provisioning, though individual applications built on the actor model may consume them as domain-specific dependencies.

## 3. Actor Deployment

### 3.1 Worker Script Management

Every actor class compiles (via Fable) to a JavaScript module that runs as a Cloudflare Worker with Durable Object bindings. Deploying an actor system means deploying one or more Worker scripts with the correct binding configuration.

`Management.Workers` provides 19 operations covering the full deployment lifecycle:

- **Script upload**: `WorkerScriptUploadWorkerModule` deploys a compiled actor module. The multipart upload includes the JavaScript entry point, any additional modules (BAREWire serializers, actor class definitions), and a metadata block declaring bindings.
- **Version management**: `WorkerVersionsListVersions`, `WorkerVersionsUploadVersion`, `WorkerVersionsGetVersionDetail` support versioned deployments. A Prospero upgrade can be deployed as a new version with gradual rollout, ensuring that supervision tree changes do not require atomic global deployment.
- **Binding configuration**: The metadata block in the upload declares DO bindings, Queue bindings, KV bindings, Analytics Engine bindings, and Worker Loader bindings. This is the point where the actor model's infrastructure dependencies are declared to the platform.
- **Usage model**: `WorkerScriptFetchUsageModel` and `WorkerScriptUpdateUsageModel` control whether the Worker runs under the Standard or Unbound billing model. Actors with long-running message handlers (event-sourced recovery, large batch processing) may require the Unbound model.

### 3.2 Durable Object Namespace Discovery

`Management.DurableObjects` currently exposes two operations: listing namespaces and listing objects within a namespace. While DO classes are defined in the Worker script and namespaces are created implicitly on first deployment, the management API is useful for:

- **Supervision tree inspection**: A management tool can enumerate all DO namespaces (actor classes) and all active object IDs (actor instances) to reconstruct the supervision tree topology.
- **Capacity planning**: Object counts per namespace indicate the scale of each actor class.
- **Garbage collection**: Identifying orphaned DOs (actors whose supervisor has been removed) that should be cleaned up.

The management API does not create or destroy individual DO instances; that is a runtime concern handled by the supervision layer. Management provides visibility into what exists.

### 3.3 Cron Triggers

`WorkerCronTriggerUpdateCronTriggers` configures scheduled invocations of a Worker. In the actor model, cron triggers serve two purposes:

1. **Periodic supervision health checks**: A cron-triggered Worker can iterate over a Prospero's child registry and verify liveness, acting as an external watchdog for the supervision tree root.
2. **Scheduled actor activation**: Actors that perform periodic work (aggregation flushes, report generation, metric rollups) can be activated on a schedule via cron, with the cron handler sending a message to the target actor's `ActorRef`.

Cron triggers are limited to 3 per Worker. For finer-grained scheduling, DO Alarms (a runtime API, not a management API) provide per-actor scheduling with millisecond precision and unlimited count.

## 4. Elastic Scaling Infrastructure

### 4.1 Queue Provisioning

The elastic scaling pattern described in [08a §Elastic Scaling](08a_actor_model_overview.md#elastic-scaling) requires a Cloudflare Queue as the pivot between direct WebSocket delivery and replicated consumption. `Management.Queues` provides the full lifecycle:

- **Queue creation**: `QueuesCreate` provisions a new Queue. The Prospero (or a deployment script) creates a Queue per actor class that declares an `Elastic` scaling policy.
- **Consumer registration**: `QueuesCreateConsumer` attaches a Worker (or a set of Workers) as consumers of the Queue. For the `Isolate` replica strategy, Worker Loader-spawned isolates consume directly. For the `DurableObject` strategy, the consumer Worker routes messages to replica DO instances.
- **Consumer configuration**: `QueuesUpdateConsumer` adjusts batch size, batch timeout, max retries, and dead-letter queue assignment. These parameters directly affect actor throughput under load:
  - `max_batch_size`: Controls how many messages a replica processes per invocation. Larger batches amortize invocation overhead; smaller batches reduce latency.
  - `max_batch_timeout`: Controls how long the Queue waits to fill a batch before dispatching. Lower values favor latency; higher values favor throughput.
  - `max_retries`: Controls retry behavior for failed messages. Combined with the actor's `OnError` handler, this determines whether a message is retried at the Queue level or escalated to the Prospero.
  - `dead_letter_queue`: Routes permanently failed messages to a separate Queue for inspection, connecting to the dead-letter storage concern (§5.1).

- **Queue monitoring**: `QueuesGet` returns Queue metadata including consumer count and configuration. The Prospero's scaling logic can use this to verify that Queue infrastructure matches the declared `ElasticConfig`.

### 4.2 Provisioning Lifecycle

Queue provisioning can occur at two points:

1. **Deployment time**: A deployment script reads the supervision tree configuration, identifies all `Elastic` children, and pre-provisions Queues and consumer bindings. This is the simpler model; the Queue exists before any actor starts.
2. **Runtime (lazy)**: The Prospero provisions a Queue on first threshold breach, using the management API from within a Worker. This requires the Worker to have API credentials (via a secret binding) and adds latency to the first scaling event, but avoids provisioning Queues for actors that never experience load.

The deployment-time approach is recommended for production. The runtime approach is useful for development and testing.

### 4.3 Worker Builds Integration

`Management.Builds` (22 operations) manages the Worker build pipeline. For elastic scaling with the `Isolate` replica strategy, the build system must produce a standalone JavaScript module that the Worker Loader can instantiate. The build pipeline configuration determines:

- Whether the actor's Fable-compiled output is bundled as a single module or split into chunks
- Which dependencies are included in the isolate module versus assumed from the parent Worker's environment
- Compatibility date and feature flag settings for the isolate runtime

## 5. Persistence Infrastructure

### 5.1 Dead-Letter Storage (KV)

Messages that fail processing after all retries are routed to dead-letter storage. `Management.KV` provisions the namespace:

- **Namespace creation**: `WorkersKvNamespaceCreateANamespace` creates a KV namespace dedicated to dead-letter storage. Convention: `{actor-class}-dead-letters`.
- **Metadata-bearing writes**: `WorkersKvNamespaceWriteKeyValuePairWithMetadata` stores the failed message (BAREWire-encoded) with metadata including the originating actor ID, failure reason, timestamp, and retry count. This metadata enables filtering and replay.
- **Key enumeration**: `WorkersKvNamespaceListANamespace'SKeys` supports dead-letter inspection tooling, listing failed messages by prefix (actor class, date range).
- **Bulk operations**: `WorkersKvNamespaceWriteMultipleKeyValuePairs` enables batch dead-letter writes when multiple messages fail in a single processing cycle.

KV is the default dead-letter backend due to its simplicity and low latency. For queryable dead-letter analysis, D1 is an alternative (§5.2).

### 5.2 Read-Side Projections (D1)

Event-sourced actors maintain their write-side state in DO transactional storage. Read-side projections, materialized views derived from the event journal, can be stored in D1 for SQL-queryable access.

`Management.D1` provisions the database:

- **Database creation**: `D1CreateDatabase` creates a D1 database for a service domain's projections. Location hints (`wnam`, `enam`, `weur`, `eeur`, `apac`, `oc`) place the database near the actors that write to it.
- **Schema management**: `D1QueryDatabase` executes DDL statements to create projection tables. The schema is derived from the event types; each projection defines its own table structure.
- **Query access**: `D1QueryDatabase` and `D1RawDatabaseQuery` support read-side queries. A dashboard or API Worker can query projections without accessing the actor's internal state.

D1's ACID transactions (local to the database) complement DO transactional storage (local to the actor). The journal is the source of truth; D1 projections are eventually consistent derived views.

### 5.3 Journal Archival (R2)

Long-running event-sourced actors accumulate journal entries in DO transactional storage. DO storage has per-object limits (documented by Cloudflare; currently generous but not unlimited). For actors with high event rates, periodic journal archival to R2 prevents storage exhaustion.

`Management.R2` provisions the archival bucket:

- **Bucket creation**: `R2CreateBucket` creates a bucket for journal archives. Convention: `{actor-class}-journal-archive`.
- **Archival flow**: A maintenance Worker (triggered by cron or alarm) reads journal entries older than the latest snapshot, writes them as a BAREWire-encoded batch to R2, and deletes the archived entries from DO storage.
- **Recovery**: If recovery requires events older than what remains in DO storage, the `PersistentOlivier` base can fall back to the R2 archive. This extends the journal's effective capacity to R2's unlimited storage.

R2 is also suitable for storing large message payloads that exceed the practical size for WebSocket frames or Queue messages.

## 6. Observability Infrastructure

### 6.1 Analytics Engine

Analytics Engine datasets are provisioned implicitly on first `writeDataPoint()` call. However, `Management.Analytics` provides dataset visibility and configuration:

- **Dataset discovery**: Enumerate existing datasets to verify that actor instrumentation is flowing.
- **Retention configuration**: Set data retention policies per dataset. Actor metrics (throughput, latency) may have different retention requirements than supervision events (failures, restarts).

The actor framework's `IActorMetrics` implementation writes to Analytics Engine at runtime. The management layer ensures the pipeline exists and is configured correctly before the first actor activates.

### 6.2 Log Export (Logpush)

`Management.Logs` (8 operations) configures Logpush jobs that export structured logs to external systems:

- **Job creation**: `CreateLogpushJob` establishes a pipeline from Cloudflare to an external destination (S3, Splunk, Datadog, etc.).
- **Dataset selection**: The job specifies which log dataset to export. For actor observability, the relevant datasets include Workers traces, Diagnostics Channel events, and custom log streams.
- **Field selection**: `output_options` controls which fields are included in the export. Actor-relevant fields include script name (actor class), DO ID (actor instance), timestamps, and custom blobs from `writeDataPoint()`.
- **Sampling**: For high-throughput actor systems, sampling rates reduce export volume while maintaining statistical significance.

A production actor deployment should have at least two Logpush jobs: one for operational metrics (Analytics Engine data exported for long-term retention) and one for diagnostic events (Diagnostics Channel output for debugging and audit).

### 6.3 Tail Workers (Live Debugging)

`Management.Workers` includes `WorkerTailLogsStartTail`, which attaches a live log stream to a running Worker. In the actor model:

- **Message tracing**: Attach a tail to the router Worker or a specific Prospero to observe message flow in real time.
- **Supervision event monitoring**: Tail a Prospero Worker to observe child failure, restart, and escalation events as they occur.
- **Zero-overhead when detached**: Tail Workers impose no performance cost when no tail is attached. This makes them suitable for on-demand debugging in production.

Tail Workers are configured via `tail_consumers` in the Worker's wrangler configuration. The management API starts and stops the tail stream; the tail consumer Worker processes events.

## 7. Security and Access Control

### 7.1 Secrets Distribution

`Management.SecretsStore` (12 operations) manages secrets that actors may need at runtime:

- **API credentials**: If actors interact with external services (databases, third-party APIs), secrets are stored in the Secrets Store and bound to the Worker as environment variables.
- **Inter-service authentication**: Cross-substrate communication (native Fidelity to CloudEdge) may require authentication tokens. The Secrets Store provides a secure distribution mechanism.
- **Rotation**: Secret rotation does not require redeployment. Updated secrets are available to the Worker on next invocation.

`Management.Workers` also provides `WorkerPutScriptSecret` for per-Worker secret binding, which is the simpler mechanism when secrets are scoped to a single actor class.

### 7.2 Actor Authorization (Access)

`Management.Access` (99 operations) provides Cloudflare Zero Trust integration. For actor systems that accept external requests:

- **Application policies**: Define which external callers can reach the router Worker's HTTP ingress. Policies can restrict access by identity provider, IP range, device posture, or service token.
- **Short-lived certificates**: Issue certificates for cross-substrate communication. A native Fidelity cluster authenticating to a CloudEdge bridge Worker can present a short-lived certificate issued through the Access API.
- **Service tokens**: Machine-to-machine authentication between Workers or between external services and the actor system's HTTP boundary.

Access policies operate at the HTTP ingress layer. WebSocket connections between Durable Objects within Cloudflare do not traverse Access; they are internal to the platform. Authorization is a boundary concern, consistent with the actor model's treatment of HTTP fetch as the external ingress layer.

### 7.3 Cross-Substrate Connectivity (Tunnels)

`Management.Tunnels` (12 operations) manages Cloudflare Tunnels, which provide encrypted connectivity between a private network and Cloudflare's edge:

- **Tunnel creation**: `CreateATunnel` establishes a tunnel from the native Fidelity cluster to Cloudflare. The bridge Worker described in [08b §6.2](08b_actor_core.md#62-cross-substrate) can use a tunnel as the transport layer for BAREWire WebSocket connections.
- **Configuration**: Tunnel routes define which internal endpoints are accessible from Cloudflare. A tunnel route pointing to the native Fidelity cluster's WebSocket endpoint enables cross-substrate actor communication without exposing the cluster to the public internet.

Tunnels are an alternative to public WebSocket endpoints for cross-substrate communication. They provide encryption, authentication, and network-level access control without requiring the native cluster to have a public IP address.

## 8. External Data Access

### 8.1 Hyperdrive

`Management.Hyperdrive` (6 operations) configures connection pooling for external PostgreSQL databases. Actors that need to query an external database (for read-side projections, for enrichment during message processing, or for cross-system data integration) benefit from Hyperdrive's connection pooling and query caching:

- **Configuration**: `CreateHyperdrive` establishes a pooled connection to a PostgreSQL instance. The actor accesses it via an `env.HYPERDRIVE` binding at runtime.
- **Caching**: Hyperdrive caches query results at the edge, reducing latency for repeated reads. Cache duration is configurable per Hyperdrive configuration.
- **Connection reuse**: Workers (and by extension, DO instances) share connections from the pool, avoiding the overhead of establishing a new connection per invocation.

For actor systems that bridge CloudEdge with a traditional database-backed application, Hyperdrive provides the connectivity layer.

## 9. Provisioning Orchestration

The management operations described above are individually simple. The complexity lies in orchestrating them into a coherent deployment pipeline. A complete actor system deployment involves:

1. **Upload Worker scripts** (actor classes, router, bridge) via `Management.Workers`
2. **Verify DO namespaces** are registered via `Management.DurableObjects`
3. **Provision Queues** for each `Elastic` actor class via `Management.Queues`
4. **Create KV namespaces** for dead-letter storage via `Management.KV`
5. **Create D1 databases** for read-side projections via `Management.D1`
6. **Create R2 buckets** for journal archival via `Management.R2`
7. **Configure Logpush jobs** for observability export via `Management.Logs`
8. **Set secrets** for external service credentials via `Management.SecretsStore`
9. **Configure Access policies** for HTTP ingress authorization via `Management.Access`
10. **Establish tunnels** for cross-substrate connectivity via `Management.Tunnels`
11. **Configure cron triggers** for periodic maintenance via `Management.Workers`

This sequence is a natural candidate for a deployment module within the framework: `Fidelity.CloudEdge.Actor.Deployment`. Such a module would read the supervision tree configuration (actor classes, scaling policies, persistence requirements) and invoke the management APIs to provision the required infrastructure. The configuration is declarative; the provisioning is imperative.

```fsharp
type ActorSystemManifest =
    { Name: string
      Workers: WorkerSpec list
      Actors: ActorClassSpec list
      Observability: ObservabilityConfig
      Security: SecurityConfig }

type ActorClassSpec =
    { ClassName: string
      Scaling: ScalingPolicy
      Persistence: PersistenceConfig option
      DeadLetter: DeadLetterConfig option }

type PersistenceConfig =
    { SnapshotPolicy: SnapshotPolicy
      JournalArchival: bool
      ReadSideProjections: ProjectionSpec list }

type DeadLetterConfig =
    { Backend: DeadLetterBackend
      RetentionDays: int }

type DeadLetterBackend =
    | KV
    | D1

type ObservabilityConfig =
    { LogpushDestinations: LogpushDestination list
      AnalyticsRetentionDays: int
      TailWorkersEnabled: bool }
```

A deployment function would walk the manifest and invoke the appropriate management operations:

```fsharp
let deploy (manifest: ActorSystemManifest) (mgmt: ManagementClients) = async {
    // 1. Deploy Worker scripts
    for worker in manifest.Workers do
        do! mgmt.Workers.UploadWorkerModule(worker)

    // 2. Provision infrastructure per actor class
    for actor in manifest.Actors do
        match actor.Scaling with
        | Elastic config ->
            do! mgmt.Queues.Create(actor.ClassName + "-overflow")
            do! mgmt.Queues.CreateConsumer(...)
        | SingleInstance -> ()

        match actor.DeadLetter with
        | Some dl ->
            match dl.Backend with
            | KV -> do! mgmt.KV.CreateNamespace(actor.ClassName + "-dead-letters")
            | D1 -> do! mgmt.D1.CreateDatabase(actor.ClassName + "-dead-letters")
        | None -> ()

        match actor.Persistence with
        | Some p when p.JournalArchival ->
            do! mgmt.R2.CreateBucket(actor.ClassName + "-journal-archive")
        | _ -> ()

    // 3. Configure observability
    for dest in manifest.Observability.LogpushDestinations do
        do! mgmt.Logs.CreateLogpushJob(dest)
}
```

This is a Phase 5+ concern. The initial implementation provisions infrastructure manually or via wrangler configuration. The deployment module automates the process once the actor model's runtime behavior is stable.

## 10. Management Services Not Directly Involved

The following management services are not part of the actor infrastructure but are available to applications built on the actor model:

- **AI, AIGateway, AISearch, AutoRAG**: AI inference and search. An actor could process messages that invoke AI models, but the AI services are domain concerns, not infrastructure.
- **BrowserRendering**: Headless browser automation. Unrelated to actor infrastructure.
- **Calls**: WebRTC-based real-time communication. Could be layered on top of actors for media handling, but is a domain concern.
- **Containers**: Container deployment. An alternative execution substrate, not part of the DO-based actor model.
- **Email**: Email routing. A potential message source (email-to-actor ingress) but not infrastructure.
- **Gateway**: Zero Trust DNS/HTTP gateway policies. Network-level security, not actor-specific.
- **Images**: Image optimization and storage. Domain concern.
- **LoadBalancers, WaitingRooms**: Traffic management. Operate at the HTTP layer before requests reach the actor system.
- **Magic**: Magic Transit/WAN network security. Infrastructure-level networking, below the actor model's abstraction.
- **Pages**: Static site deployment. Unrelated.
- **Pipelines**: Data pipeline management. Could complement actor event streams but is a separate data processing model.
- **R2Catalog**: R2 data catalog. Metadata management for R2 buckets; potentially useful for journal archival discovery but not core infrastructure.
- **Stream**: Video streaming. Domain concern.
- **Vectorize**: Vector database. An actor could write embeddings, but this is a domain concern.
