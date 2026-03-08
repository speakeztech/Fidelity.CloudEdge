# Fidelity.CloudEdge Actor Model: MailboxProcessor Intercept

> Part of the [Actor Model Design](08a_actor_model_overview.md) series.

## 1. Full API Surface

The table below maps every public member of `MailboxProcessor<'Msg>` to its `Fidelity.CloudEdge.Actor` equivalent, along with the intercept status.

**Supported:**

| MailboxProcessor Member | Olivier / ActorRef Equivalent | Notes |
|------------------------|-------------------------------|-------|
| `Post(msg)` | `actorRef.Tell(msg)` | WebSocket tell (fire-and-forget) |
| `PostAndReply(f)` | `actorRef.Ask(msg)` | WebSocket ask (synchronous wait) |
| `PostAndAsyncReply(f)` | `actorRef.Ask(msg)` | WebSocket ask (async) |
| `PostAndAsyncReply(f, timeout)` | `actorRef.Ask(msg, timeout)` | WebSocket ask with explicit timeout |
| `Receive()` | `this.Receive()` | Overridden as `Handle(msg)` dispatch |
| `Start(body)` | Implicit (DO activation) | No explicit start; first message activates |
| `DefaultTimeout` | `this.DefaultTimeout` | Configurable on `Olivier<'Msg>` base; applies to all ask operations originating from this actor |
| `CurrentQueueLength` | `this.PendingCount` | Count of WebSocket frames buffered but not yet dispatched. Reflects the DO runtime's internal queue depth. Useful for diagnostics; not reliable for flow control since the value is a snapshot that may be stale by the time the caller reads it. |
| `Error` event | `this.OnError(exn)` | Virtual method on `Olivier<'Msg>` base, called when the `Handle` override throws. Default behavior: propagate to supervising Prospero via the supervision WebSocket. Override to add logging, metrics, or custom recovery before propagation. |

**Discouraged:**

| MailboxProcessor Member | Status | Rationale |
|------------------------|--------|-----------|
| `TryReceive(timeout)` | Discouraged | See §2 |

**Unsupported:**

| MailboxProcessor Member | Status | Rationale |
|------------------------|--------|-----------|
| `Scan(f)` | Not intercepted | See §3 |
| `TryScan(f, timeout)` | Not intercepted | See §3 |

## 2. TryReceive and the Push Model

`TryReceive(timeout)` is a pull-based primitive: the actor blocks (or awaits) for up to N milliseconds, then returns `None` if no message arrived. This pattern assumes the actor drives its own timing, polling its queue with a deadline.

Durable Objects are push-based. The runtime invokes handlers (`webSocketMessage`, `alarm`, `fetch`) when events arrive; the actor does not sit in a loop pulling from a queue. Implementing `TryReceive` on a push-based substrate requires synthesizing blocking semantics on top of event-driven infrastructure, wrapping a `Promise` around a `setTimeout` and resolving it on either message arrival or timer expiry. It works, but it is swimming against the current.

The recommended pattern is to model timeouts as messages:

```fsharp
type WorkerMsg =
    | ProcessItem of item: Item
    | FlushTimeout                  // pushed by alarm or setTimeout
    | HealthCheck                   // pushed by Prospero on interval

type ItemProcessor() =
    inherit Olivier<WorkerMsg>()

    let mutable batch = []

    override this.Handle(msg) = async {
        match msg with
        | ProcessItem item ->
            batch <- item :: batch
            if batch.Length >= 100 then
                do! this.FlushBatch(batch)
                batch <- []
            else
                this.ScheduleAlarm(TimeSpan.FromSeconds 5.0)
        | FlushTimeout ->
            if batch.Length > 0 then
                do! this.FlushBatch(batch)
                batch <- []
        | HealthCheck ->
            this.Reply({| pending = batch.Length |})
    }
```

In this model there is no polling and no idle wait. The actor processes items as they arrive (push), flushes on a batch size threshold (push from self via immediate dispatch), or flushes on a timer (push from the DO alarm API). Between events, the actor hibernates at zero cost. The timeout is a first-class case in the discriminated union, indistinguishable from any other message.

`TryReceive` remains technically available for migration purposes, but new code should use the push-based timeout pattern exclusively.

## 3. Scan and TryScan

`Scan` and `TryScan` implement selective receive: the actor inspects queued messages, skips those that do not match a predicate, and processes the first match. Skipped messages remain queued in order.

These members are not supported in the CloudEdge intercept. The decision is architectural, not technical.

Selective receive implies that message arrival order does not match processing priority. In a tell-first system, this is a design signal: the actor's message type is conflating concerns that should be separated. An actor that needs to handle `Urgent` before `Routine` is better served by one of these alternatives:

1. **Separate actor types.** Route urgent messages to a dedicated Olivier; route routine messages to another. The Prospero supervises both.
2. **Priority in the message type.** Add an explicit priority field and let the `Handle` override dispatch accordingly. Processing is still sequential, but the actor can defer low-priority work by writing it to storage and replaying later.
3. **Multiple message types.** Split the discriminated union into distinct types handled by distinct actors, each with its own `Olivier<'Msg>` and `ActorRef<'Msg>`.

Migration guidance for code that uses `Scan` or `TryScan`: refactor the selective receive into explicit message prioritization at the type level before porting to CloudEdge.

## 4. What Changes

The key semantic difference: `MailboxProcessor` is an in-process object. An `ActorRef<'Msg>` pointing at an `Olivier<'Msg>` is a remote reference backed by a Durable Object. This means:

1. **Message types must be serializable.** BAREWire handles this, but the constraint is new. `MailboxProcessor` can carry closures and object references; `Olivier<'Msg>` cannot.
2. **`AsyncReplyChannel` becomes a correlation ID.** The channel is no longer a direct callback; it is a promise resolved by a response frame on the WebSocket.
3. **Actor creation is implicit.** There is no explicit `Start(fun inbox -> ...)`. The processing loop is the Durable Object's message handler, and activation is automatic on first message.
4. **Error semantics differ.** An exception in a `MailboxProcessor` loop kills the mailbox. An exception in an Olivier's `Handle` override is caught by the base class and routed to `OnError`, which by default propagates to the supervising Prospero. The DO instance remains alive for subsequent messages unless the Prospero issues a `Stop` directive.

## 5. Migration Example

Before (standard F# MailboxProcessor):

```fsharp
type Msg =
    | Increment
    | GetCount of AsyncReplyChannel<int>

let counter = MailboxProcessor<Msg>.Start(fun inbox ->
    let rec loop count = async {
        let! msg = inbox.Receive()
        match msg with
        | Increment -> return! loop (count + 1)
        | GetCount reply ->
            reply.Reply(count)
            return! loop count
    }
    loop 0)

counter.Post(Increment)
let! count = counter.PostAndAsyncReply(GetCount)
```

After (Fidelity.CloudEdge.Actor):

```fsharp
open Fidelity.CloudEdge.Actor

type CounterMsg =
    | Increment
    | GetCount  // Reply type inferred from handler

type CounterActor() =
    inherit Olivier<CounterMsg>()

    let mutable count = 0

    override this.Handle(msg) = async {
        match msg with
        | Increment ->
            count <- count + 1
        | GetCount ->
            this.Reply(count)
    }
```

The caller:

```fsharp
let counter : ActorRef<CounterMsg> = actors.Get("user-123")
counter.Tell(Increment)             // WebSocket tell
let! count = counter.Ask(GetCount)  // WebSocket ask
```

The processing logic is nearly identical. The infrastructure is entirely different.
