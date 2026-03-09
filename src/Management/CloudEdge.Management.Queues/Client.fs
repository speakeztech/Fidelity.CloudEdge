namespace rec Fidelity.CloudEdge.Management.Queues

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Queues.Types
open Fidelity.CloudEdge.Management.Queues.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type QueuesClient(httpClient: HttpClient) =
    ///<summary>
    ///Returns the queues owned by an account.
    ///</summary>
    member this.QueuesList(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/queues" requestParts cancellationToken

            match int status with
            | 200 -> return QueuesList.OK(Serializer.deserialize content)
            | _ -> return QueuesList.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new queue
    ///</summary>
    member this.QueuesCreate(accountId: string, body: QueuesCreatePayload, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/queues" requestParts cancellationToken

            match int status with
            | 200 -> return QueuesCreate.OK(Serializer.deserialize content)
            | _ -> return QueuesCreate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a queue
    ///</summary>
    member this.QueuesDelete(queueId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesDelete.OK(Serializer.deserialize content)
            | _ -> return QueuesDelete.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get details about a specific queue.
    ///</summary>
    member this.QueuesGet(queueId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesGet.OK(Serializer.deserialize content)
            | _ -> return QueuesGet.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a Queue.
    ///</summary>
    member this.QueuesUpdatePartial
        (
            queueId: string,
            accountId: string,
            body: mqqueue,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesUpdatePartial.OK(Serializer.deserialize content)
            | _ -> return QueuesUpdatePartial.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a Queue. Note that this endpoint does not support partial updates. If successful, the Queue's configuration is overwritten with the supplied configuration.
    ///</summary>
    member this.QueuesUpdate(queueId: string, accountId: string, body: mqqueue, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesUpdate.OK(Serializer.deserialize content)
            | _ -> return QueuesUpdate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the consumers for a Queue
    ///</summary>
    member this.QueuesListConsumers(queueId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/consumers"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesListConsumers.OK(Serializer.deserialize content)
            | _ -> return QueuesListConsumers.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new consumer for a Queue
    ///</summary>
    member this.QueuesCreateConsumer(queueId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/consumers"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesCreateConsumer.OK(Serializer.deserialize content)
            | _ -> return QueuesCreateConsumer.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes the consumer for a queue.
    ///</summary>
    member this.QueuesDeleteConsumer
        (
            consumerId: string,
            queueId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("consumer_id", consumerId)
                  RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/consumers/{consumer_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesDeleteConsumer.OK(Serializer.deserialize content)
            | _ -> return QueuesDeleteConsumer.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches the consumer for a queue by consumer id
    ///</summary>
    member this.QueuesGetConsumer
        (
            consumerId: string,
            queueId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("consumer_id", consumerId)
                  RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/consumers/{consumer_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesGetConsumer.OK(Serializer.deserialize content)
            | _ -> return QueuesGetConsumer.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the consumer for a queue, or creates one if it does not exist.
    ///</summary>
    member this.QueuesUpdateConsumer
        (
            consumerId: string,
            queueId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("consumer_id", consumerId)
                  RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/consumers/{consumer_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesUpdateConsumer.OK(Serializer.deserialize content)
            | _ -> return QueuesUpdateConsumer.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Push a message to a Queue
    ///</summary>
    member this.QueuesPushMessage
        (
            queueId: string,
            accountId: string,
            body: ``mqqueue-message``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/messages"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesPushMessage.OK(Serializer.deserialize content)
            | _ -> return QueuesPushMessage.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Acknowledge + Retry messages from a Queue
    ///</summary>
    member this.QueuesAckMessages
        (
            queueId: string,
            accountId: string,
            body: QueuesAckMessagesPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/messages/ack"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesAckMessages.OK(Serializer.deserialize content)
            | _ -> return QueuesAckMessages.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Push a batch of message to a Queue
    ///</summary>
    member this.QueuesPushMessages
        (
            queueId: string,
            accountId: string,
            body: ``mqqueue-batch``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/messages/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesPushMessages.OK(Serializer.deserialize content)
            | _ -> return QueuesPushMessages.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Pull a batch of messages from a Queue
    ///</summary>
    member this.QueuesPullMessages
        (
            queueId: string,
            accountId: string,
            body: QueuesPullMessagesPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/messages/pull"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesPullMessages.OK(Serializer.deserialize content)
            | _ -> return QueuesPullMessages.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get details about a Queue's purge status.
    ///</summary>
    member this.QueuesPurgeGet(queueId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/purge"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesPurgeGet.OK(Serializer.deserialize content)
            | _ -> return QueuesPurgeGet.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes all messages from the Queue.
    ///</summary>
    member this.QueuesPurge
        (
            queueId: string,
            accountId: string,
            body: QueuesPurgePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/queues/{queue_id}/purge"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return QueuesPurge.OK(Serializer.deserialize content)
            | _ -> return QueuesPurge.BadRequest(Serializer.deserialize content)
        }
