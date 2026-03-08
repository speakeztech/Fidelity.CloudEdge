# Fidelity.CloudEdge Actor Model: Overview

This document series describes the design of an actor model for Fidelity.CloudEdge, built on Cloudflare Durable Objects as the execution substrate. The model intercepts F#'s `MailboxProcessor` semantics and implements them using infrastructure-enforced single-concurrency, WebSocket-based message transport, and BAREWire binary serialization.

## Motivation

Fable compiles `MailboxProcessor` to JavaScript, but the result is fragile. JavaScript's single-threaded cooperative scheduling model means that any suspension point (an `async` `let!` or `do!`) yields control to the event loop, and Fable's internal queue management loses coherence after several hundred messages. The implementation is nominally supported but practically broken for any non-trivial workload.

Fidelity.CloudEdge sidesteps this entirely. Instead of patching Fable's JavaScript-level actor, the framework intercepts `MailboxProcessor` semantics at the F# source level and maps them onto Cloudflare Durable Objects, which provide infrastructure-enforced single-concurrency execution. The result is an actor model where the sequential processing guarantee is not a software invariant maintained by user-space code; it is a platform contract enforced by Cloudflare's runtime scheduler.

## Library Layering

```
Fidelity.CloudEdge.Actor.Persistence  (event sourcing)
  ├── PersistentOlivier<'Msg,'Ev,'St> event-sourced actor
  ├── Journal                         append-only event log
  ├── Snapshots                       periodic state capture
  └── Recovery                        replay on activation
        │
Fidelity.CloudEdge.Actor.Observability (instrumentation)
  ├── IActorMetrics                   throughput, latency, queue depth
  └── IActorDiagnostics               structured event channels
        │
        ▼  both depend on
Fidelity.CloudEdge.Actor              (semantic layer)
  ├── Olivier<'Msg>                   actor base type
  ├── Prospero<'Msg>                  supervisor base type
  ├── ActorRef<'Msg>                  typed actor reference (tell/ask)
  ├── Supervision strategies          OneForOne, OneForAll, RestForOne
  └── MailboxProcessor intercept      migration surface
        │
        ▼  depends on
Fidelity.CloudEdge.DurableObjects     (platform binding layer)
  ├── DurableObjectState              Cloudflare DO state API
  ├── DurableObjectNamespace          DO factory/identity
  ├── WebSocket hibernation API       connection lifecycle
  └── Transactional storage API       key-value persistence
```

`Fidelity.CloudEdge.DurableObjects` is the low-level binding to Cloudflare's Durable Object runtime, generated via Glutinum from `@cloudflare/workers-types`. It exposes platform types directly: `DurableObjectState`, `DurableObjectId`, `DurableObjectNamespace`, WebSocket handlers, transactional storage.

`Fidelity.CloudEdge.Actor` is the semantic layer. It consumes `DurableObjects` as infrastructure but does not expose Cloudflare-specific types in its public API. A developer writing an Olivier actor works with `Olivier<'Msg>`, `ActorRef<'Msg>`, and supervision types. The fact that these are backed by Durable Objects is an implementation detail, visible in deployment configuration but not in application code.

This separation serves two purposes. First, it allows the actor API surface to remain stable even if the underlying Cloudflare bindings change between `workers-types` releases. Second, it keeps the door open for alternative substrates: the same `Olivier<'Msg>` type signature could, in principle, be backed by a different execution environment without changing application code.

## Tell-First Architecture

Fidelity's native framework is built on tell-first semantics. The default interaction between actors is fire-and-forget; ask is available but discouraged for performance-critical paths. This design principle carries over to CloudEdge.

- **Tell is non-blocking.** The sender does not wait, does not allocate a promise, does not risk timeout. Throughput scales with the number of senders, not with the processing speed of the receiver.
- **Tell is resilient.** If the receiver fails, the sender is unaffected. The message is lost (unless the transport provides durability), but the sender does not hang waiting for a response that will never come.
- **Ask creates coupling.** A sender waiting for a response is coupled to the receiver's latency, error handling, and availability. In a distributed system spanning Cloudflare data centers, this coupling introduces tail-latency risk.

WebSocket frames provide true tell semantics on Cloudflare. A BAREWire frame without a correlation ID is fire-and-forget at the transport level. Ask is supported via correlation IDs but is an explicit, visible choice.

HTTP fetch is reserved for the external boundary (browser clients, API consumers). Every HTTP request to a Durable Object is inherently ask; the framework treats `fetch()` as the ingress layer where external requests are translated into the internal message protocol.

## Cross-Substrate Coherence

The Fidelity framework operates across two substrates:

1. **Bare Metal**: Actors compiled via MLIR through Fidelity.Firefly, running as native executables. State is local memory; communication is IPC (Unix sockets, shared memory) or network (TCP, QUIC).
2. **Edge (Cloudflare)**: Actors compiled via Fable to JavaScript, running as Durable Objects. State is DO transactional storage; communication is WebSocket within Cloudflare, HTTP at the boundary.

The goal is **substrate transparency**: a Prospero supervisor running on bare metal can supervise Olivier workers running on Cloudflare, and vice versa. BAREWire provides the bridge; a message serialized by a native Fidelity actor is byte-identical to the same message serialized by a CloudEdge actor.

Cross-substrate transport options include WebSocket (available today) and Media-over-QUIC (MoQ, future). Actor references use a unified `ActorRef<'Msg>` type that dispatches across substrates:

```fsharp
type ActorRef<'Msg> =
    | Local of MailboxProcessor<'Msg>           // Native Fidelity (in-process)
    | Edge of actorId: string * transport: IActorTransport  // Cloudflare (WebSocket to DO)
    | Remote of endpoint: Uri * actorId: string // Cross-substrate (WS or MoQ)
```

Akka.NET interoperability is planned via a BAREWire serializer plugin and a stateless gateway Worker that bridges WebSocket frames to TCP connections.

## Document Index

| Document | Scope |
|----------|-------|
| [08a: Overview](08a_actor_model_overview.md) | This document. Architecture summary, design principles, cross-substrate vision. |
| [08b: Actor Core](08b_actor_core.md) | Durable Object substrate, WebSocket transport, BAREWire serialization, actor lifecycle, supervision (Prospero/Olivier), connection topology. |
| [08c: MailboxProcessor Intercept](08c_mailbox_intercept.md) | Full API surface mapping, push model (TryReceive discouraged), Scan/TryScan unsupported, semantic changes, migration example. |
| [08d: Persistence and Observability](08d_persistence_observability.md) | Event sourcing model, journals, snapshots, read-side projections, Analytics Engine, Diagnostics Channel, tracing. |
| [08e: Management Infrastructure](08e_management_infrastructure.md) | Management API mapping, deployment provisioning, elastic scaling infrastructure, dead-letter storage, observability pipeline, security, cross-substrate tunnels. |

## Implementation Phases

### Phase 1: Foundation

- `Olivier<'Msg>` worker actor base type, backed by a Durable Object with message dispatch
- `ActorRef<'Msg>` typed reference with Tell and Ask primitives
- BAREWire serialization for F# discriminated unions over WebSocket binary frames
- Correlation ID management for ask semantics
- Basic lifecycle: activation, message processing, hibernation, stop

### Phase 2: Supervision

- `Prospero<'Msg>` supervisor actor with child registry and health monitoring
- Supervision strategies (OneForOne, OneForAll, RestForOne)
- WebSocket-based heartbeat and failure detection
- Restart semantics: fresh activation vs. state recovery
- Graceful stop (drain protocol)

### Phase 3: Persistence

- `PersistentOlivier<'Msg, 'Event, 'State>` event-sourced actor base type
- Journal implementation over DO transactional storage (BAREWire-encoded entries)
- Snapshot policies (EveryNEvents, AfterDuration, Manual, Never)
- Recovery: snapshot load + journal replay on activation
- Pluggable journal backend interface for native substrate parity

### Phase 4: Observability

- Analytics Engine instrumentation (message throughput, handle latency, queue depth, supervision events)
- Diagnostics Channel publishers (`fidelity:actor:message`, `fidelity:actor:lifecycle`, `fidelity:actor:persistence`, `fidelity:actor:supervision`)
- `IActorMetrics` / `IActorDiagnostics` abstractions for substrate-independent instrumentation
- Automatic tracing integration via wrangler `observability.traces.enabled`

### Phase 5: Developer Experience

- MailboxProcessor migration guide and compatibility surface
- Fable compiler plugin or source generator for BAREWire serializer derivation
- Diagnostic tooling: message tracing, supervision tree visualization
- Persistent query / read-side projection patterns

### Phase 6: Cross-Substrate

- BAREWire WebSocket bridge between native Fidelity and CloudEdge
- Unified `ActorRef<'Msg>` that dispatches across substrates
- MoQ transport evaluation and integration
- Akka.NET serializer plugin for BAREWire

## Cloudflare Backplane Services

The actor model does not operate in isolation. Cloudflare provides a full complement of backplane services that address common distributed systems concerns without requiring custom infrastructure. The framework should be designed with awareness that these services exist and can be composed with actors as needed.

| Concern | Cloudflare Service | Actor Model Integration |
|---------|-------------------|------------------------|
| Back-pressure / buffering | Queues | Actors can consume from Queues at their own rate; producers write to Queues instead of sending directly to a slow actor. Queues provide durable, ordered message delivery with configurable batch sizes and retry policies. |
| Scheduled work | Cron Triggers, DO Alarms | Cron Triggers invoke Workers on a schedule; DO Alarms wake individual actors at specific times. Both are push-based, consistent with the actor model's reactive design. |
| Dead-letter storage | KV, D1, R2 | Messages that fail processing after retry can be written to KV (fast, simple), D1 (queryable), or R2 (large payloads) for later inspection or reprocessing. |
| Metrics / alerting | Analytics Engine | Actor throughput, latency, and error rates emitted via `writeDataPoint()` are queryable via SQL. Alerting pipelines can monitor for anomalies and trigger corrective actions. |
| Log export | Logpush | Structured logs from Diagnostics Channel can be exported to external systems (S3, Splunk, Datadog) for long-term retention and cross-system correlation. |
| Real-time debugging | Tail Workers | Attach to live actor traffic for debugging without modifying the actor code or adding instrumentation. Zero overhead when not attached. |
| Distributed tracing | Workers Traces | Automatic span capture across Worker invocations, DO handlers, and subrequests. No SDK required; enable via wrangler configuration. |
| Dynamic compute | Worker Loader | Runtime spawning of lightweight V8 isolates with millisecond startup. Used by the elastic scaling pattern to create disposable replicas that consume from Queues without the overhead of full Durable Objects. |

Back-pressure in particular is well-served by this model. WebSocket does not natively support flow control, but the combination of Queues (as a durable buffer between a fast producer and a slow consumer), Analytics Engine (to detect throughput imbalances), and Prospero supervision (to spawn additional Olivier workers when queue depth exceeds a threshold) provides a complete solution without application-level flow control protocols. See [Elastic Scaling](#elastic-scaling) below for the full pattern.

## Elastic Scaling

### Referential Transparency and Actor Replication

The standard actor model assumes one instance per identity: a single DO processes all messages for a given actor ID. For stateful actors, this is essential. For referentially transparent actors, those whose output is determined solely by the input message with no dependency on local mutable state, the single-instance constraint is a throughput bottleneck, not a correctness requirement.

The framework introduces an elastic scaling pattern for referentially transparent Olivier actors, using Cloudflare Queues as the pivot between single-instance and replicated execution.

### Adaptive Fan-Out

The scaling lifecycle is managed entirely by the supervising Prospero:

1. **Normal operation**: Messages flow via WebSocket directly to the Olivier. Single instance, minimal latency.
2. **Threshold breach**: The Prospero detects queue depth or latency exceeding a configured threshold (via `PendingCount` or Analytics Engine metrics).
3. **Queue pivot**: The Prospero redirects inbound messages from the direct WebSocket path to a Cloudflare Queue bound to the actor's message type.
4. **Replica spawn**: The Prospero spawns replicas as Queue consumers (see [Replica Strategies](#replica-strategies) below). Each replica pulls messages at its own rate with automatic batching and retry.
5. **Drain and converge**: As the Queue drains and throughput normalizes, the Prospero stops replicas and reverts to direct WebSocket delivery.

```
Normal:
  Sender ──WS──▶ Olivier (single instance)

Under load:
  Sender ──WS──▶ Prospero ──▶ Queue
                                │
                    ┌───────────┼───────────┐
                    ▼           ▼           ▼
                Olivier-1   Olivier-2   Olivier-3
                (consumer)  (consumer)  (consumer)
```

The transition is invisible to the sender. The Prospero rewrites the routing; the sender continues to `Tell` via the same `ActorRef`. Queue consumers receive messages through the standard Cloudflare Queue consumer handler, which the `Olivier<'Msg>` base class adapts into the same `Handle(msg)` dispatch path.

### Replica Strategies

The replica instantiation mechanism depends on the weight of the work being scaled.

**Worker Loader Isolates (Lightweight)**

Cloudflare's Worker Loader binding (`worker_loaders`) enables runtime spawning of lightweight V8 isolates with millisecond startup. For referentially transparent Oliviers, the Prospero can use Worker Loader to spin up disposable isolates that consume from the Queue. These isolates carry no identity, no transactional storage, and no WebSocket overhead; they are pure compute units that exist only to process messages and terminate.

```fsharp
type ReplicaStrategy =
    | Isolate       // Worker Loader: lightweight, no state, millisecond startup
    | DurableObject // Full DO: has identity and storage, heavier but recoverable
```

The `Isolate` strategy is appropriate when replicas need only the `Handle(msg)` logic and no access to actor state or storage. The Prospero loads the Olivier's compiled JavaScript via the Worker Loader binding, injects the Queue consumer binding as an environment variable, and the isolate begins processing immediately. When the Queue drains, the Prospero simply stops requesting isolates; they are garbage collected by the runtime.

The `DurableObject` strategy is appropriate when replicas need access to shared state (e.g., a read-only view of a configuration store) or when the work is long-lived enough to benefit from DO hibernation between Queue batches.

**Worker Loader Configuration**

The Prospero's wrangler configuration includes a Worker Loader binding:

```jsonc
{
  "worker_loaders": [
    { "binding": "ACTOR_LOADER" }
  ]
}
```

At runtime, the Prospero resolves replicas by loading the actor's Fable-compiled JavaScript module:

```javascript
let replica = env.ACTOR_LOADER.get(`replica-${actorId}-${n}`, async () => ({
  compatibilityDate: "2025-06-01",
  mainModule: "olivier-handler.js",
  modules: actorModules,
  env: { QUEUE: queueBinding, ACTOR_CONFIG: config }
}));
```

Isolates start in milliseconds and cost less than DOs, making them suitable for burst scaling where the replica count might fluctuate rapidly.

### Supervision Metadata

The Prospero must know which children are eligible for replication. This is expressed as supervision metadata, not as a property of the actor itself:

```fsharp
type ChildSpec<'Msg> =
    { ActorType: Type
      Strategy: SupervisionStrategy
      Scaling: ScalingPolicy }

type ScalingPolicy =
    | SingleInstance                          // Stateful; never replicate
    | Elastic of ElasticConfig

type ElasticConfig =
    { MinReplicas: int
      MaxReplicas: int
      QueueThreshold: int
      ReplicaStrategy: ReplicaStrategy }

type ReplicaStrategy =
    | Isolate       // Worker Loader: lightweight, no state, millisecond startup
    | DurableObject // Full DO: has identity and storage, heavier but recoverable
```

A `SingleInstance` policy means the actor is stateful and must remain a single DO. An `Elastic` policy declares the actor referentially transparent and specifies scaling bounds and the replica instantiation mechanism. The Prospero manages the lifecycle of replicas, the Queue binding, and the routing pivot.

### What Elastic Scaling Solves

This pattern addresses two concerns simultaneously:

- **Back-pressure**: Queues absorb burst traffic that would overwhelm a single actor's WebSocket buffer. Messages are durable and retried on failure; no data is lost.
- **WebSocket connection limits**: Replicas consume from a Queue, not from a WebSocket. The sender maintains a single WebSocket to the Prospero. The fan-out happens behind the Queue, where connection limits do not apply.

## Open Questions

1. **Message ordering under elastic scaling**: When messages are distributed across replicas via a Queue, per-sender ordering is lost. For referentially transparent actors this is acceptable (processing is commutative), but the framework should make this trade-off explicit in the `ScalingPolicy` declaration.

2. **State migration**: When a Prospero decides to migrate an Olivier from one substrate to another (e.g., Cloudflare to bare metal), the state transfer protocol needs definition. BAREWire can serialize the state, but the trigger, coordination, and consistency guarantees require design.
