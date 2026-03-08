namespace rec Fidelity.CloudEdge.Management.WaitingRooms

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.WaitingRooms.Types
open Fidelity.CloudEdge.Management.WaitingRooms.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type WaitingRoomsClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists waiting rooms for zone.
    ///</summary>
    member this.WaitingRoomListWaitingRooms(zoneId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts = [ RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/zones/{zone_id}/waiting_rooms" requestParts cancellationToken

            return WaitingRoomListWaitingRooms.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new waiting room.
    ///</summary>
    member this.WaitingRoomCreateWaitingRoom
        (
            zoneId: string,
            body: waitingroomquerywaitingroom,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/zones/{zone_id}/waiting_rooms" requestParts cancellationToken

            return WaitingRoomCreateWaitingRoom.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a waiting room page preview. Upload a custom waiting room page for preview. You will receive a preview URL in the form `http://waitingrooms.dev/preview/&amp;lt;uuid&amp;gt;`. You can use the following query parameters to change the state of the preview:
    ///1. `force_queue`: Boolean indicating if all users will be queued in the waiting room and no one will be let into the origin website (also known as queueAll).
    ///2. `queue_is_full`: Boolean indicating if the waiting room's queue is currently full and not accepting new users at the moment.
    ///3. `queueing_method`: The queueing method currently used by the waiting room.
    ///	- **fifo** indicates a FIFO queue.
    ///	- **random** indicates a Random queue.
    ///	- **passthrough** indicates a Passthrough queue. Keep in mind that the waiting room page will only be displayed if `force_queue=true` or `event=prequeueing` — for other cases the request will pass through to the origin. For our preview, this will be a fake origin website returning \"Welcome\".
    ///	- **reject** indicates a Reject queue.
    ///4. `event`: Used to preview a waiting room event.
    ///	- **none** indicates no event is occurring.
    ///	- **prequeueing** indicates that an event is prequeueing (between `prequeue_start_time` and `event_start_time`).
    ///	- **started** indicates that an event has started (between `event_start_time` and `event_end_time`).
    ///5. `shuffle_at_event_start`: Boolean indicating if the event will shuffle users in the prequeue when it starts. This can only be set to **true** if an event is active (`event` is not **none**).
    ///For example, you can make a request to `http://waitingrooms.dev/preview/&amp;lt;uuid&amp;gt;?force_queue=false&amp;queue_is_full=false&amp;queueing_method=random&amp;event=started&amp;shuffle_at_event_start=true`
    ///6. `waitTime`: Non-zero, positive integer indicating the estimated wait time in minutes. The default value is 10 minutes.
    ///For example, you can make a request to `http://waitingrooms.dev/preview/&amp;lt;uuid&amp;gt;?waitTime=50` to configure the estimated wait time as 50 minutes.
    ///</summary>
    member this.WaitingRoomCreateACustomWaitingRoomPagePreview
        (
            zoneId: string,
            body: waitingroomquerypreview,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/zones/{zone_id}/waiting_rooms/preview" requestParts cancellationToken

            return WaitingRoomCreateACustomWaitingRoomPagePreview.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get zone-level Waiting Room settings
    ///</summary>
    member this.WaitingRoomGetZoneSettings(zoneId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts = [ RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/zones/{zone_id}/waiting_rooms/settings" requestParts cancellationToken

            return WaitingRoomGetZoneSettings.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Patch zone-level Waiting Room settings
    ///</summary>
    member this.WaitingRoomPatchZoneSettings
        (
            zoneId: string,
            body: waitingroomzonesettings,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/settings"
                    requestParts
                    cancellationToken

            return WaitingRoomPatchZoneSettings.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update zone-level Waiting Room settings
    ///</summary>
    member this.WaitingRoomUpdateZoneSettings
        (
            zoneId: string,
            body: waitingroomzonesettings,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync httpClient "/zones/{zone_id}/waiting_rooms/settings" requestParts cancellationToken

            return WaitingRoomUpdateZoneSettings.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a waiting room.
    ///</summary>
    member this.WaitingRoomDeleteWaitingRoom
        (
            waitingRoomId: string,
            zoneId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomDeleteWaitingRoom.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single configured waiting room.
    ///</summary>
    member this.WaitingRoomWaitingRoomDetails
        (
            waitingRoomId: string,
            zoneId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomWaitingRoomDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Patches a configured waiting room.
    ///</summary>
    member this.WaitingRoomPatchWaitingRoom
        (
            waitingRoomId: string,
            zoneId: string,
            body: waitingroomquerywaitingroom,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomPatchWaitingRoom.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a configured waiting room.
    ///</summary>
    member this.WaitingRoomUpdateWaitingRoom
        (
            waitingRoomId: string,
            zoneId: string,
            body: waitingroomquerywaitingroom,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomUpdateWaitingRoom.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists events for a waiting room.
    ///</summary>
    member this.WaitingRoomListEvents(waitingRoomId: string, zoneId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/events"
                    requestParts
                    cancellationToken

            return WaitingRoomListEvents.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Only available for the Waiting Room Advanced subscription. Creates an event for a waiting room. An event takes place during a specified period of time, temporarily changing the behavior of a waiting room. While the event is active, some of the properties in the event's configuration may either override or inherit from the waiting room's configuration. Note that events cannot overlap with each other, so only one event can be active at a time.
    ///</summary>
    member this.WaitingRoomCreateEvent
        (
            waitingRoomId: string,
            zoneId: string,
            body: waitingroomqueryevent,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/events"
                    requestParts
                    cancellationToken

            return WaitingRoomCreateEvent.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an event for a waiting room.
    ///</summary>
    member this.WaitingRoomDeleteEvent
        (
            eventId: string,
            waitingRoomId: string,
            zoneId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("event_id", eventId)
                  RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/events/{event_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomDeleteEvent.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single configured event for a waiting room.
    ///</summary>
    member this.WaitingRoomEventDetails
        (
            eventId: string,
            waitingRoomId: string,
            zoneId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("event_id", eventId)
                  RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/events/{event_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomEventDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Patches a configured event for a waiting room.
    ///</summary>
    member this.WaitingRoomPatchEvent
        (
            eventId: string,
            waitingRoomId: string,
            zoneId: string,
            body: waitingroomqueryevent,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("event_id", eventId)
                  RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/events/{event_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomPatchEvent.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a configured event for a waiting room.
    ///</summary>
    member this.WaitingRoomUpdateEvent
        (
            eventId: string,
            waitingRoomId: string,
            zoneId: string,
            body: waitingroomqueryevent,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("event_id", eventId)
                  RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/events/{event_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomUpdateEvent.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Previews an event's configuration as if it was active. Inherited fields from the waiting room will be displayed with their current values.
    ///</summary>
    member this.WaitingRoomPreviewActiveEventDetails
        (
            eventId: string,
            waitingRoomId: string,
            zoneId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("event_id", eventId)
                  RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/events/{event_id}/details"
                    requestParts
                    cancellationToken

            return WaitingRoomPreviewActiveEventDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists rules for a waiting room.
    ///</summary>
    member this.WaitingRoomListWaitingRoomRules
        (
            waitingRoomId: string,
            zoneId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/rules"
                    requestParts
                    cancellationToken

            return WaitingRoomListWaitingRoomRules.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Only available for the Waiting Room Advanced subscription. Creates a rule for a waiting room.
    ///</summary>
    member this.WaitingRoomCreateWaitingRoomRule
        (
            waitingRoomId: string,
            zoneId: string,
            body: waitingroomcreaterule,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/rules"
                    requestParts
                    cancellationToken

            return WaitingRoomCreateWaitingRoomRule.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Only available for the Waiting Room Advanced subscription. Replaces all rules for a waiting room.
    ///</summary>
    member this.WaitingRoomReplaceWaitingRoomRules
        (
            waitingRoomId: string,
            zoneId: string,
            body: waitingroomupdaterules,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/rules"
                    requestParts
                    cancellationToken

            return WaitingRoomReplaceWaitingRoomRules.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a rule for a waiting room.
    ///</summary>
    member this.WaitingRoomDeleteWaitingRoomRule
        (
            ruleId: string,
            waitingRoomId: string,
            zoneId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("rule_id", ruleId)
                  RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/rules/{rule_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomDeleteWaitingRoomRule.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Patches a rule for a waiting room.
    ///</summary>
    member this.WaitingRoomPatchWaitingRoomRule
        (
            ruleId: string,
            waitingRoomId: string,
            zoneId: string,
            body: waitingroompatchrule,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("rule_id", ruleId)
                  RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/rules/{rule_id}"
                    requestParts
                    cancellationToken

            return WaitingRoomPatchWaitingRoomRule.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches the status of a configured waiting room. Response fields include:
    ///1. `status`: String indicating the status of the waiting room. The possible status are:
    ///	- **not_queueing** indicates that the configured thresholds have not been met and all users are going through to the origin.
    ///	- **queueing** indicates that the thresholds have been met and some users are held in the waiting room.
    ///	- **event_prequeueing** indicates that an event is active and is currently prequeueing users before it starts.
    ///	- **suspended** indicates that the room is suspended.
    ///2. `event_id`: String of the current event's `id` if an event is active, otherwise an empty string.
    ///3. `estimated_queued_users`: Integer of the estimated number of users currently waiting in the queue.
    ///4. `estimated_total_active_users`: Integer of the estimated number of users currently active on the origin.
    ///5. `max_estimated_time_minutes`: Integer of the maximum estimated time currently presented to the users.
    ///</summary>
    member this.WaitingRoomGetWaitingRoomStatus
        (
            waitingRoomId: string,
            zoneId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("waiting_room_id", waitingRoomId)
                  RequestPart.path ("zone_id", zoneId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/zones/{zone_id}/waiting_rooms/{waiting_room_id}/status"
                    requestParts
                    cancellationToken

            return WaitingRoomGetWaitingRoomStatus.OK(Serializer.deserialize content)
        }
