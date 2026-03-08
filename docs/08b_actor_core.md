# Fidelity.CloudEdge Actor Model: Core

> Part of the [Actor Model Design](08a_actor_model_overview.md) series.

## 1. Durable Objects as Actor Substrate

### 1.1 The Single-Concurrency Contract

A Durable Object instance processes at most one request at a time. When a `fetch()` handler or WebSocket message handler is executing, Cloudflare's scheduler holds all other inbound requests in a queue. This is not advisory; it is enforced at the infrastructure level. No user code can violate it.

This contract maps directly onto the actor model's fundamental invariant: an actor processes one message at a time, with exclusive access to its own state. Where `MailboxProcessor` achieves this through a cooperative `async` loop and a `ConcurrentQueue`, a Durable Object achieves it through Cloudflare's execution scheduler. The guarantee is identical; the enforcement mechanism is stronger.

### 1.2 Actor Identity and Location

Every Durable Object has a globally unique identifier, either a hex string or a name-derived ID. This ID serves as the actor's address. The Cloudflare platform guarantees that at most one instance of a given ID exists worldwide at any point in time, regardless of which data center handles the request. This provides a strong identity guarantee that `MailboxProcessor` cannot offer on its own, since mailbox processors are in-process objects with no inherent addressing scheme.

In the Fidelity.CloudEdge model:

- An **actor address** is a `DurableObjectId`.
- An **actor namespace** is a `DurableObjectNamespace`, which serves as the factory (analogous to an `ActorSystem` or `ActorRefProvider`).
- **Location transparency** is provided by Cloudflare's global routing: the caller does not know or care which data center hosts the Durable Object instance.

### 1.3 State Model

Durable Objects offer two state mechanisms:

1. **Transactional Storage** (`state.storage`): A key-value store with ACID transactions local to the DO instance. Reads and writes are synchronous within the execution context. This maps naturally to actor state: mutable fields in the actor class backed by durable storage when persistence is required.

2. **In-Memory State**: Standard JavaScript variables within the DO class. Fast, but lost on eviction. Suitable for caches, counters, or state that can be reconstructed from storage or upstream messages.

The actor model does not prescribe which state mechanism to use. The framework provides helpers for both, allowing developers to choose per-actor based on durability requirements.

## 2. WebSocket as the Message Transport

### 2.1 Why Not HTTP

HTTP is a request-response protocol. Every `fetch()` call to a Durable Object requires a response before the connection closes. This makes HTTP inherently **ask** semantics: the caller sends a message and blocks (or awaits) until a response arrives.

For actor-to-actor communication, this is wasteful. Most actor messages are **tell** semantics: fire-and-forget, no response expected. Implementing tell over HTTP means either:

- Responding immediately with an empty 202, which still incurs the full HTTP round-trip overhead (headers, TLS frames, connection management).
- Holding connections open with long-polling, which consumes resources on both ends.

Neither option is satisfactory. WebSocket eliminates the problem.

### 2.2 WebSocket as Tell Channel

A WebSocket connection between two Durable Objects (or between a Worker and a Durable Object) is a persistent, bidirectional byte stream. Sending a message is a single frame write with no expectation of a response. This is true fire-and-forget:

1. The sender serializes the message into a BAREWire frame.
2. The sender calls `ws.send(frame)`.
3. The sender continues immediately. There is no `await`, no response, no correlation.

This maps directly onto `MailboxProcessor.Post('Msg)`: enqueue a message and return `unit`.

### 2.3 WebSocket as Ask Channel

Ask semantics require correlating a response to a request. The framework achieves this with a correlation ID embedded in the BAREWire frame header:

1. The caller generates a unique correlation ID (e.g., a monotonic counter local to the connection).
2. The caller registers a pending `Promise` keyed by the correlation ID.
3. The caller sends a BAREWire frame with the correlation ID set.
4. The receiver processes the message and sends a response frame with the same correlation ID.
5. The caller's WebSocket message handler matches the correlation ID and resolves the pending `Promise`.

This maps onto `MailboxProcessor.PostAndAsyncReply(fun channel -> Msg(channel))`. The `AsyncReplyChannel` is replaced by the correlation-ID-based promise resolution.

### 2.4 HTTP Fetch as External Ingress

HTTP remains the entry point for external callers: browser clients, API consumers, other Workers that do not maintain a persistent WebSocket. Every HTTP request to a Durable Object is inherently ask (a response is required), so the framework treats `fetch()` as the ingress boundary where external requests are translated into the internal message protocol.

The pattern:

1. External caller sends an HTTP request to a Worker.
2. The Worker resolves the target actor's `DurableObjectId` and calls `stub.fetch(request)`.
3. The Durable Object's `fetch()` handler deserializes the request, processes it as a message, and returns an HTTP response.

For actor-to-actor communication within the Cloudflare platform, WebSocket is preferred. HTTP fetch is reserved for the external boundary.

## 3. BAREWire Serialization

### 3.1 Why BAREWire

BAREWire implements the BARE (Binary Application Record Encoding) protocol with extensions for memory-mapped access and zero-copy semantics. It is already central to Fidelity's native framework for IPC and network interchange. Using it as the serialization layer in CloudEdge provides:

- **Binary efficiency**: No JSON parsing overhead. A discriminated union case with an integer payload serializes to a tag byte plus a varint; approximately 2-5 bytes total versus 30+ bytes of JSON.
- **Schema-driven**: Message types are defined in F# as discriminated unions and records. BAREWire schemas are derived from these types, ensuring that the wire format matches the F# type system.
- **Cross-substrate compatibility**: The same BAREWire encoding works over WebSocket on Cloudflare, over Unix domain sockets in Fidelity native, and over QUIC in future cross-cluster transport. A message serialized on Cloudflare can be deserialized by a native Fidelity actor without translation.

### 3.2 Frame Format

Each WebSocket message is a BAREWire frame:

```
┌──────────────┬──────────────┬───────────────┬──────────────┐
│ Frame Header │ Message Tag  │ Correlation ID│ Payload      │
│ (4 bytes)    │ (varint)     │ (optional)    │ (variable)   │
└──────────────┴──────────────┴───────────────┴──────────────┘
```

- **Frame Header**: Total frame length (uint32, little-endian). Enables the receiver to read complete frames from the WebSocket stream.
- **Message Tag**: BAREWire union discriminator identifying the F# discriminated union case.
- **Correlation ID**: Present only for ask messages. A uint32 scoped to the connection. Zero or absent for tell messages.
- **Payload**: BAREWire-encoded fields of the discriminated union case.

### 3.3 Discriminated Union Mapping

F# discriminated unions map directly to BAREWire tagged unions:

```fsharp
type CounterMsg =
    | Increment                    // tag 0, no payload
    | Add of amount: int           // tag 1, payload: varint
    | GetCount                     // tag 2, no payload (ask; response is int)
```

BAREWire schema (derived automatically):

```
type CounterMsg = union {
    | Increment = void
    | Add = int
    | GetCount = void
}
```

The framework generates serializers and deserializers at compile time (via Fable plugin or source generator), so there is no reflection or runtime schema discovery.

## 4. Actor Lifecycle

### 4.1 Activation

A Durable Object is activated on first access. There is no explicit "start" operation as with `MailboxProcessor.Start`. The actor exists as soon as its ID is referenced:

```fsharp
let counter = env.COUNTERS.idFromName("user-123")
let stub = env.COUNTERS.get(counter)
// The actor is now addressable. It will activate on first message.
```

This is closer to Erlang's process model or Akka's `ActorRef` than to `MailboxProcessor`, which requires explicit instantiation and startup.

### 4.2 Hibernation and Scale-to-Zero

Durable Objects support hibernation: when no messages are in flight and no alarms are pending, the runtime can evict the DO's in-memory state to reclaim resources. Critically, WebSocket connections survive hibernation. The Cloudflare runtime holds the WebSocket at the infrastructure level while the DO's JavaScript context is deallocated.

When a new WebSocket message arrives, the DO is re-activated, its `webSocketMessage()` handler is called, and processing resumes. The cost of a hibernated actor is effectively zero: no memory, no compute, only the WebSocket connection state held by the platform.

This enables a scale-to-zero actor model. An application can instantiate millions of actors (one per user, per session, per device), and only the actively communicating actors consume resources. Idle actors hibernate with their WebSocket connections open, ready to wake on the next message.

### 4.3 Eviction and State Recovery

If a Durable Object is evicted (not just hibernated), in-memory state is lost. The actor must reconstruct its state from transactional storage on next activation. The framework provides a lifecycle hook for this:

```fsharp
type CounterActor() =
    inherit Olivier<CounterMsg>()

    let mutable count = 0

    override this.OnActivate() = async {
        let! stored = this.Storage.get<int>("count")
        count <- stored |> Option.defaultValue 0
    }
```

The `Olivier<'Msg>` base type exposes `this.Storage` as an abstraction over the underlying DO transactional storage, keeping the Cloudflare platform types out of the application code.

For actors with purely ephemeral state (caches, aggregators that periodically flush), eviction simply resets the actor to its initial state.

### 4.4 Lifecycle Signals

Lifecycle signals are distinct from application messages. They do not enter the message queue; they operate at the transport level, ensuring they take effect regardless of queue depth.

The Durable Object model provides a natural mechanism: WebSocket connection state. The `webSocketClose` handler fires when a connection is closed by the remote end, independent of any pending messages in the `webSocketMessage` pipeline. This separation is the foundation for all lifecycle operations.

**Stop (Immediate)**

The Prospero closes the WebSocket connection to the child. The child's `webSocketClose` handler fires, which the `Olivier<'Msg>` base translates into an `OnStop` virtual method call:

```fsharp
type CounterActor() =
    inherit Olivier<CounterMsg>()

    let mutable count = 0

    override this.OnStop() = async {
        // Persist final state before shutdown
        do! this.Storage.put("count", count)
    }
```

`OnStop` runs outside the message processing loop. If the actor is mid-`Handle` when the WebSocket closes, the current message completes (the DO's single-concurrency guarantee ensures this), and then `OnStop` fires. No further messages are dispatched after `OnStop` begins.

For a cascading stop through a supervision tree, each Prospero's `OnStop` closes WebSocket connections to its children, which triggers their `OnStop` in turn. The cascade propagates at transport speed, not message-processing speed.

**Graceful Stop (Drain)**

A graceful stop allows the actor to finish processing queued messages before shutting down. This is a two-phase operation:

1. The Prospero sends a `Draining` lifecycle frame on the WebSocket (a reserved frame type in the BAREWire protocol, distinct from application messages).
2. The Olivier's base class receives `Draining`, stops accepting new messages from external senders, and continues processing the remaining queue.
3. When the queue is empty, the Olivier calls `OnStop` and sends a `Drained` acknowledgment frame back to the Prospero.
4. The Prospero closes the WebSocket.

The `Draining` and `Drained` frames are internal to the framework. Application code does not interact with them directly; it only overrides `OnStop` for cleanup logic.

**Restart**

From the Prospero's perspective, restart is stop followed by re-acquisition:

1. Close the WebSocket to the child (triggering `OnStop`).
2. Obtain a new stub from the `DurableObjectNamespace` using the same name-derived ID.
3. Open a new WebSocket to the stub.

The Durable Object runtime may or may not reuse the same physical instance. If the DO was evicted after the WebSocket close, the new connection activates a fresh instance that runs `OnActivate`. If the DO is still warm, the new WebSocket attaches to the existing instance. In either case, the Prospero's view is consistent: the child is a new logical actor at the same address.

**Lifecycle Hook Summary**

| Hook | Trigger | Runs In |
|------|---------|---------|
| `OnActivate()` | First message or post-eviction recovery | Before first `Handle` |
| `OnStop()` | WebSocket close from supervisor | After final `Handle` completes |
| `OnError(exn)` | Unhandled exception in `Handle` | Inline, before next `Handle` |
| `Handle(msg)` | Each application message | Sequential, one at a time |

All hooks are virtual methods on `Olivier<'Msg>`. `Prospero<'Msg>` extends this with supervision-specific hooks (`OnChildFailed`, `OnChildStopped`).

## 5. Prospero and Olivier on Cloudflare

### 5.1 Supervision Model

In the Fidelity framework, **Prospero** actors are supervisors and **Olivier** actors are workers. This maps onto Durable Objects as follows:

- **Prospero (Supervisor)**: A Durable Object that maintains a registry of child actor IDs and their health status. It holds WebSocket connections to its children and monitors their liveness.
- **Olivier (Worker)**: A Durable Object that performs domain-specific computation. It holds a WebSocket connection back to its supervisor for heartbeats and escalation.

### 5.2 Supervision Strategy

Supervision decisions (restart, stop, escalate) are defined at the Prospero level:

```fsharp
type SupervisionStrategy =
    | OneForOne     // Restart only the failed child
    | OneForAll     // Restart all children if one fails
    | RestForOne    // Restart the failed child and all children started after it

type SupervisionDirective =
    | Restart
    | Stop
    | Escalate
```

When an Olivier actor fails (uncaught exception in its message handler), the error propagates to the Prospero via the WebSocket connection. The Prospero's failure handler evaluates the strategy and issues the appropriate directive.

In the Durable Object model, "restart" means:

1. The Prospero closes the WebSocket to the failed Olivier.
2. The Prospero creates a new `DurableObjectId` (or reuses the same name-based ID) and opens a new WebSocket.
3. The Olivier's new activation initializes fresh state (or recovers from storage, depending on the restart semantics).

### 5.3 Supervision Tree Structure

A typical deployment:

```
Prospero: "session-supervisor"
├── Olivier: "session-user-alice"
├── Olivier: "session-user-bob"
└── Prospero: "chat-room-supervisor"
    ├── Olivier: "room-general"
    └── Olivier: "room-engineering"
```

Each node is a Durable Object. Each edge is a WebSocket connection. The entire tree can span multiple Cloudflare data centers; the platform handles routing transparently.

### 5.4 Elastic Scaling

For referentially transparent Olivier actors (stateless message processors whose output depends solely on the input message), the Prospero can dynamically scale from single-instance to replicated execution using Cloudflare Queues as the pivot.

The Prospero's `ChildSpec` declares a `ScalingPolicy`:

```fsharp
type ScalingPolicy =
    | SingleInstance                          // Stateful; never replicate
    | Elastic of minReplicas: int * maxReplicas: int * queueThreshold: int
```

When an `Elastic` child's queue depth exceeds the threshold, the Prospero:

1. Creates a Cloudflare Queue for the actor's message type (if not already provisioned).
2. Redirects inbound messages from WebSocket delivery to Queue writes.
3. Spawns additional Olivier instances as Queue consumers.
4. Monitors Queue depth and scales replicas up or down within the declared bounds.
5. Reverts to direct WebSocket delivery when the Queue drains and load normalizes.

This is a supervision-level concern. The Olivier code is unchanged; it processes messages through the same `Handle(msg)` path whether messages arrive via WebSocket or Queue consumer handler. The `Olivier<'Msg>` base class adapts both delivery mechanisms into a uniform dispatch.

See [Elastic Scaling in the Overview](08a_actor_model_overview.md#elastic-scaling) for the full architectural description.

## 6. Connection Topology

### 6.1 Intra-Cloudflare

Within Cloudflare, the connection topology is:

```
External Client ──HTTP──▶ Worker (Router)
                              │
                    ┌─────────┼─────────┐
                    ▼         ▼         ▼
               Prospero    Olivier   Olivier
               (DO+WS)    (DO+WS)   (DO+WS)
                  │           │
                  └─────WS────┘
```

- **External clients** connect to a Worker via HTTP.
- **The Router Worker** resolves the target actor and forwards the message via `stub.fetch()` (for ask) or establishes a WebSocket and sends a frame (for tell).
- **Durable Objects** communicate with each other via WebSocket connections established during supervision tree construction.

### 6.2 Cross-Substrate

```
Native Fidelity Cluster                    Cloudflare Edge
┌─────────────────────┐                    ┌──────────────────┐
│  Prospero (native)  │◀──BAREWire/WS──▶  │  Worker (bridge)  │
│       │              │                    │       │           │
│  Olivier (native)   │                    │  Prospero (DO)    │
│  Olivier (native)   │                    │       │           │
└─────────────────────┘                    │  Olivier (DO)     │
                                           │  Olivier (DO)     │
                                           └──────────────────┘
```

A bridge Worker maintains a WebSocket connection to the native cluster. Messages crossing the substrate boundary are BAREWire frames on the wire; no format translation is needed.
