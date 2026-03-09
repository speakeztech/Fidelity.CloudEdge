namespace rec Fidelity.CloudEdge.Management.Pipelines

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Pipelines.Types
open Fidelity.CloudEdge.Management.Pipelines.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type PipelinesClient(httpClient: HttpClient) =
    ///<summary>
    ///List/Filter Pipelines in Account.
    ///</summary>
    member this.GetV4AccountsByAccountIdPipelinesV1Pipelines
        (
            accountId: string,
            ?page: float,
            ?perPage: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/pipelines"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetV4AccountsByAccountIdPipelinesV1Pipelines.OK(Serializer.deserialize content)
            | _ -> return GetV4AccountsByAccountIdPipelinesV1Pipelines.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Pipeline.
    ///</summary>
    member this.PostV4AccountsByAccountIdPipelinesV1Pipelines
        (
            accountId: string,
            body: PostV4AccountsByAccountIdPipelinesV1PipelinesPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/pipelines"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PostV4AccountsByAccountIdPipelinesV1Pipelines.OK(Serializer.deserialize content)
            | _ -> return PostV4AccountsByAccountIdPipelinesV1Pipelines.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete Pipeline in Account.
    ///</summary>
    member this.DeleteV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId
        (
            accountId: string,
            pipelineId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pipeline_id", pipelineId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/pipelines/{pipeline_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 ->
                return DeleteV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId.OK(Serializer.deserialize content)
            | _ ->
                return
                    DeleteV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId.BadRequest(
                        Serializer.deserialize content
                    )
        }

    ///<summary>
    ///Get Pipelines Details.
    ///</summary>
    member this.GetV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId
        (
            accountId: string,
            pipelineId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pipeline_id", pipelineId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/pipelines/{pipeline_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId.OK(Serializer.deserialize content)
            | _ ->
                return
                    GetV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List/Filter Sinks in Account.
    ///</summary>
    member this.GetV4AccountsByAccountIdPipelinesV1Sinks
        (
            accountId: string,
            ?pipelineId: string,
            ?page: float,
            ?perPage: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if pipelineId.IsSome then
                      RequestPart.query ("pipeline_id", pipelineId.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/sinks"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetV4AccountsByAccountIdPipelinesV1Sinks.OK(Serializer.deserialize content)
            | _ -> return GetV4AccountsByAccountIdPipelinesV1Sinks.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Sink.
    ///</summary>
    member this.PostV4AccountsByAccountIdPipelinesV1Sinks
        (
            accountId: string,
            body: PostV4AccountsByAccountIdPipelinesV1SinksPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/sinks"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PostV4AccountsByAccountIdPipelinesV1Sinks.OK(Serializer.deserialize content)
            | _ -> return PostV4AccountsByAccountIdPipelinesV1Sinks.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete Pipeline in Account.
    ///</summary>
    member this.DeleteV4AccountsByAccountIdPipelinesV1SinksBySinkId
        (
            accountId: string,
            sinkId: string,
            ?force: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sink_id", sinkId)
                  if force.IsSome then
                      RequestPart.query ("force", force.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/sinks/{sink_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteV4AccountsByAccountIdPipelinesV1SinksBySinkId.OK(Serializer.deserialize content)
            | _ -> return DeleteV4AccountsByAccountIdPipelinesV1SinksBySinkId.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get Sink Details.
    ///</summary>
    member this.GetV4AccountsByAccountIdPipelinesV1SinksBySinkId
        (
            accountId: string,
            sinkId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sink_id", sinkId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/sinks/{sink_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetV4AccountsByAccountIdPipelinesV1SinksBySinkId.OK(Serializer.deserialize content)
            | _ -> return GetV4AccountsByAccountIdPipelinesV1SinksBySinkId.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List/Filter Streams in Account.
    ///</summary>
    member this.GetV4AccountsByAccountIdPipelinesV1Streams
        (
            accountId: string,
            ?pipelineId: string,
            ?page: float,
            ?perPage: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if pipelineId.IsSome then
                      RequestPart.query ("pipeline_id", pipelineId.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/streams"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetV4AccountsByAccountIdPipelinesV1Streams.OK(Serializer.deserialize content)
            | _ -> return GetV4AccountsByAccountIdPipelinesV1Streams.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Stream.
    ///</summary>
    member this.PostV4AccountsByAccountIdPipelinesV1Streams
        (
            accountId: string,
            body: PostV4AccountsByAccountIdPipelinesV1StreamsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/streams"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PostV4AccountsByAccountIdPipelinesV1Streams.OK(Serializer.deserialize content)
            | _ -> return PostV4AccountsByAccountIdPipelinesV1Streams.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete Stream in Account.
    ///</summary>
    member this.DeleteV4AccountsByAccountIdPipelinesV1StreamsByStreamId
        (
            accountId: string,
            streamId: string,
            ?force: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("stream_id", streamId)
                  if force.IsSome then
                      RequestPart.query ("force", force.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/streams/{stream_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteV4AccountsByAccountIdPipelinesV1StreamsByStreamId.OK(Serializer.deserialize content)
            | _ ->
                return
                    DeleteV4AccountsByAccountIdPipelinesV1StreamsByStreamId.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get Stream Details.
    ///</summary>
    member this.GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId
        (
            accountId: string,
            streamId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("stream_id", streamId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/streams/{stream_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId.OK(Serializer.deserialize content)
            | _ ->
                return GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a Stream.
    ///</summary>
    member this.PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId
        (
            accountId: string,
            streamId: string,
            body: PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("stream_id", streamId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/streams/{stream_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId.OK(Serializer.deserialize content)
            | _ ->
                return PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Validate Arroyo SQL.
    ///</summary>
    member this.PostV4AccountsByAccountIdPipelinesV1ValidateSql
        (
            accountId: string,
            body: PostV4AccountsByAccountIdPipelinesV1ValidateSqlPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/pipelines/v1/validate_sql"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PostV4AccountsByAccountIdPipelinesV1ValidateSql.OK(Serializer.deserialize content)
            | _ -> return PostV4AccountsByAccountIdPipelinesV1ValidateSql.BadRequest(Serializer.deserialize content)
        }
