# Fidelity.CloudEdge Actor Model: Persistence and Observability

> Part of the [Actor Model Design](08a_actor_model_overview.md) series.

## 1. Library Layering

Persistence and observability are opt-in capabilities, following the same pattern as Akka.Persistence in the Akka.NET ecosystem. They sit alongside `Fidelity.CloudEdge.Actor`, not inside it:

```
Fidelity.CloudEdge.Actor.Persistence   (event sourcing, journals, snapshots)
  └── depends on Fidelity.CloudEdge.Actor

Fidelity.CloudEdge.Actor.Observability  (tracing, metrics, diagnostics)
  └── depends on Fidelity.CloudEdge.Actor
```

An actor that does not need persistence uses `Olivier<'Msg>` directly. An actor that needs event sourcing inherits from `PersistentOlivier<'Msg, 'Event, 'State>`, which extends `Olivier<'Msg>` with journal and snapshot semantics. The same principle applies on the native Fidelity substrate; the persistence model is substrate-independent, with the storage backend varying by deployment target.

## 2. Event Sourcing Model

The persistence model is event-sourced. State is derived from an ordered sequence of events, not from direct mutation. The actor processes a command (an inbound message), decides which events to emit, persists those events to a journal, and applies them to its in-memory state.

```fsharp
open Fidelity.CloudEdge.Actor.Persistence

type CounterCommand =
    | Increment
    | Add of int
    | GetCount

type CounterEvent =
    | Incremented
    | Added of int

type CounterState = { Count: int }

type PersistentCounter() =
    inherit PersistentOlivier<CounterCommand, CounterEvent, CounterState>()

    override this.InitialState = { Count = 0 }

    override this.HandleCommand(state, cmd) = async {
        match cmd with
        | Increment ->
            this.Persist(Incremented)
        | Add n ->
            this.Persist(Added n)
        | GetCount ->
            this.Reply(state.Count)
    }

    override this.ApplyEvent(state, event) =
        match event with
        | Incremented -> { state with Count = state.Count + 1 }
        | Added n -> { state with Count = state.Count + n }
```

The separation of commands, events, and state follows the established CQRS/ES pattern. Commands express intent; events express facts. The `ApplyEvent` function is a pure fold over the event stream.

## 3. Journal

The journal is the append-only log of events for a given actor. On Cloudflare, the natural storage backend is DO transactional storage, which provides ACID guarantees local to the actor instance. Each event is stored as a BAREWire-encoded entry keyed by a monotonically increasing sequence number:

```
journal:0001 → BAREWire(Incremented)
journal:0002 → BAREWire(Added 5)
journal:0003 → BAREWire(Incremented)
```

On recovery (post-eviction or restart), the `PersistentOlivier` base replays the journal from the last snapshot forward, folding `ApplyEvent` over each entry to reconstruct the current state. No application code is involved in recovery; the base class handles it using the same `ApplyEvent` the developer already defined.

The journal backend is pluggable. On Cloudflare, DO transactional storage is the default. On native Fidelity, the backend could be a local append-only file, SQLite, or an external event store. The journal interface is defined in the persistence library, not in a substrate-specific binding.

## 4. Snapshots

Replaying a long journal on every recovery is expensive. Snapshots periodically capture the full actor state, allowing recovery to start from the snapshot and replay only subsequent events.

Snapshot policy is configurable per actor:

```fsharp
override this.SnapshotPolicy =
    SnapshotPolicy.EveryNEvents(100)  // Snapshot every 100 events
```

Available policies:

- `EveryNEvents(n)`: Snapshot after every N events.
- `AfterDuration(timespan)`: Snapshot if more than the specified duration has elapsed since the last snapshot.
- `Manual`: The actor calls `this.SaveSnapshot()` explicitly.
- `Never`: No snapshots. Full journal replay on every recovery.

Snapshots are stored in the same backend as the journal (DO transactional storage on Cloudflare). A snapshot entry is a BAREWire-encoded `'State` keyed separately from journal entries. On recovery, the base class loads the latest snapshot, then replays journal entries with sequence numbers greater than the snapshot's sequence number.

## 5. Persistent Queries (Read Side)

Event sourcing enables read-side projections: derived views of actor state maintained by consuming the event journal. On Cloudflare, this maps to a pattern where a dedicated Worker or Durable Object tails the event journal and writes materialized views to D1, KV, or Analytics Engine.

This is a Phase 3+ concern. The initial persistence implementation focuses on the write side (journal, snapshots, recovery). Read-side projections will be designed once the journal format and replication semantics are stable.

## 6. Observability

Cloudflare provides a layered observability surface that the actor framework can instrument without requiring application-level code changes.

### 6.1 Automatic Tracing

Cloudflare Workers support automatic trace instrumentation for fetch calls, binding invocations, and handler lifecycles. Enabling `observability.traces.enabled` in the wrangler configuration captures spans for every DO invocation, WebSocket message handler, and subrequest. The actor framework benefits from this without additional effort: each `Handle` invocation appears as a span in the trace waterfall, with parent-child relationships reflecting the supervision tree.

### 6.2 Analytics Engine

Workers Analytics Engine provides unlimited-cardinality, time-series analytics via a `writeDataPoint()` binding and a SQL query API. The `Observability` library instruments the `Olivier<'Msg>` base class to emit data points on:

- Message throughput per actor (messages received per second, by message tag)
- Handle latency (p50, p95, p99 per actor class)
- Ask correlation latency (time from ask send to response receive)
- Queue depth snapshots (pending messages at each Handle invocation)
- Supervision events (child failures, restarts, stops per Prospero)

These data points are emitted through the Analytics Engine binding; developers do not write instrumentation code. The data is queryable via SQL, enabling dashboards and alerting pipelines.

### 6.3 Diagnostics Channel

Cloudflare Workers support Node.js-compatible `diagnostics_channel`, which emits structured events for significant operations. The actor framework publishes to named channels:

- `fidelity:actor:message` — emitted on each `Handle` invocation with actor ID, message tag, and timestamp
- `fidelity:actor:lifecycle` — emitted on `OnActivate`, `OnStop`, `OnError`
- `fidelity:actor:persistence` — emitted on journal write, snapshot save, and recovery replay
- `fidelity:actor:supervision` — emitted on child failure, restart, stop

These channels are silent by default (zero overhead when no subscriber is attached). A Tail Worker or custom logging pipeline can subscribe to any channel for real-time debugging or structured log export via Logpush.

### 6.4 Native Substrate Parity

The observability interfaces (`IActorMetrics`, `IActorDiagnostics`) are defined in `Fidelity.CloudEdge.Actor.Observability` as abstractions. On Cloudflare, the implementation uses Analytics Engine and Diagnostics Channel. On native Fidelity, the same interfaces would bind to OpenTelemetry, structured logging, or a custom metrics sink. Application code that consumes observability data works across substrates without modification.
