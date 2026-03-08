namespace rec Fidelity.CloudEdge.Management.AISearch

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.AISearch.Types
open Fidelity.CloudEdge.Management.AISearch.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type AISearchClient(httpClient: HttpClient) =
    ///<summary>
    ///List instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="search">Search by id</param>
    ///<param name="orderBy">Order By Column Name</param>
    ///<param name="orderByDirection">Order By Direction</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchListInstances
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?orderBy: string,
            ?orderByDirection: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if orderByDirection.IsSome then
                      RequestPart.query ("order_by_direction", orderByDirection.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchListInstances.OK(Serializer.deserialize content)
            | _ -> return AiSearchListInstances.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new instances.
    ///</summary>
    member this.AiSearchCreateInstances
        (
            accountId: string,
            body: AiSearchCreateInstancesPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return AiSearchCreateInstances.Created(Serializer.deserialize content)
            | _ -> return AiSearchCreateInstances.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchDeleteInstances(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchDeleteInstances.OK(Serializer.deserialize content)
            | _ -> return AiSearchDeleteInstances.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Read instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchFetchInstances(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchFetchInstances.OK(Serializer.deserialize content)
            | 400 -> return AiSearchFetchInstances.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchFetchInstances.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchUpdateInstances
        (
            accountId: string,
            id: string,
            body: AiSearchUpdateInstancesPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchUpdateInstances.OK(Serializer.deserialize content)
            | 400 -> return AiSearchUpdateInstances.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchUpdateInstances.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Performs a chat completion request against an AI Search instance, using indexed content as context for generating responses.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceChatCompletion
        (
            id: string,
            accountId: string,
            body: AiSearchInstanceChatCompletionPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/chat/completions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceChatCompletion.OK(Serializer.deserialize content)
            | _ -> return AiSearchInstanceChatCompletion.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists indexing jobs for an AI Search instance.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceListJobs
        (
            id: string,
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceListJobs.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceListJobs.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceListJobs.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new indexing job for an AI Search instance.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceCreateJob
        (
            id: string,
            accountId: string,
            body: AiSearchInstanceCreateJobPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceCreateJob.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceCreateJob.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceCreateJob.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific AI Search indexing job.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceGetJob
        (
            id: string,
            jobId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceGetJob.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceGetJob.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceGetJob.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the status of an AI Search indexing job.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceChangeJobStatus
        (
            id: string,
            jobId: string,
            accountId: string,
            body: AiSearchInstanceChangeJobStatusPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceChangeJobStatus.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceChangeJobStatus.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceChangeJobStatus.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists log entries for an AI Search indexing job.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceListJobLogs
        (
            id: string,
            jobId: string,
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs/{job_id}/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceListJobLogs.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceListJobLogs.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceListJobLogs.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Executes a semantic search query against an AI Search instance to find relevant indexed content.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceSearch
        (
            id: string,
            accountId: string,
            body: AiSearchInstanceSearchPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceSearch.OK(Serializer.deserialize content)
            | _ -> return AiSearchInstanceSearch.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves usage statistics for AI Search instances.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchStats(id: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/stats"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchStats.OK(Serializer.deserialize content)
            | _ -> return AiSearchStats.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///List tokens.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="orderBy">Order By Column Name</param>
    ///<param name="orderByDirection">Order By Direction</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchListTokens
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?orderBy: string,
            ?orderByDirection: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if orderByDirection.IsSome then
                      RequestPart.query ("order_by_direction", orderByDirection.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/ai-search/tokens" requestParts cancellationToken

            match int status with
            | 200 -> return AiSearchListTokens.OK(Serializer.deserialize content)
            | _ -> return AiSearchListTokens.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new tokens.
    ///</summary>
    member this.AiSearchCreateTokens
        (
            accountId: string,
            body: AiSearchCreateTokensPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return AiSearchCreateTokens.Created(Serializer.deserialize content)
            | _ -> return AiSearchCreateTokens.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete tokens.
    ///</summary>
    member this.AiSearchDeleteTokens(accountId: string, id: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchDeleteTokens.OK(Serializer.deserialize content)
            | _ -> return AiSearchDeleteTokens.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Read tokens.
    ///</summary>
    member this.AiSearchFetchTokens(accountId: string, id: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchFetchTokens.OK(Serializer.deserialize content)
            | 400 -> return AiSearchFetchTokens.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchFetchTokens.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update tokens.
    ///</summary>
    member this.AiSearchUpdateTokens
        (
            accountId: string,
            id: System.Guid,
            body: AiSearchUpdateTokensPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchUpdateTokens.OK(Serializer.deserialize content)
            | 400 -> return AiSearchUpdateTokens.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchUpdateTokens.NotFound(Serializer.deserialize content)
        }
