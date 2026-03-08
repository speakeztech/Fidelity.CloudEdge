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

## Open Questions

1. **WebSocket connection limits**: Cloudflare imposes limits on the number of concurrent WebSocket connections per DO. For supervision trees with many children, this may require connection pooling or hierarchical supervision (Prosperos supervising other Prosperos).

2. **Message ordering across connections**: WebSocket guarantees ordering within a single connection, but not across connections. If Actor A sends messages to Actor C, and Actor B also sends messages to Actor C, the interleaving between A's and B's messages is non-deterministic. This is consistent with standard actor semantics (per-sender ordering, not global ordering).

3. **State migration**: When a Prospero decides to migrate an Olivier from one substrate to another (e.g., Cloudflare to bare metal), the state transfer protocol needs definition. BAREWire can serialize the state, but the trigger, coordination, and consistency guarantees require design.

4. **Back-pressure**: WebSocket does not natively support back-pressure. A fast sender can overwhelm a slow receiver. Options include application-level flow control (credit-based), DO-level rate limiting, or accepting message loss for non-critical paths.
