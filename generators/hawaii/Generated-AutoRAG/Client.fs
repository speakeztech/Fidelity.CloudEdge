namespace rec Fidelity.CloudEdge.Management.AutoRAG

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.AutoRAG.Types
open Fidelity.CloudEdge.Management.AutoRAG.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type AutoRAGClient(httpClient: HttpClient) =
    ///<summary>
    ///AI Search
    ///</summary>
    ///<param name="id">rag id</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AutoragConfigAiSearch
        (
            id: string,
            accountId: string,
            body: AutoragConfigAiSearchPayload,
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
                    "/accounts/{account_id}/autorag/rags/{id}/ai-search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AutoragConfigAiSearch.OK(Serializer.deserialize content)
            | _ -> return AutoragConfigAiSearch.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Files
    ///</summary>
    ///<param name="id">rag id</param>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="search"></param>
    ///<param name="status"></param>
    ///<param name="cancellationToken"></param>
    member this.AutoragConfigFiles
        (
            id: string,
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?status: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/autorag/rags/{id}/files"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AutoragConfigFiles.OK(Serializer.deserialize content)
            | 404 -> return AutoragConfigFiles.NotFound(Serializer.deserialize content)
            | _ -> return AutoragConfigFiles.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///List Jobs
    ///</summary>
    ///<param name="id">rag id</param>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AutoragConfigListJobs
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
                    "/accounts/{account_id}/autorag/rags/{id}/jobs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AutoragConfigListJobs.OK(Serializer.deserialize content)
            | 404 -> return AutoragConfigListJobs.NotFound(Serializer.deserialize content)
            | _ -> return AutoragConfigListJobs.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a Job Details
    ///</summary>
    ///<param name="id">rag id</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AutoragConfigGetJob
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
                    "/accounts/{account_id}/autorag/rags/{id}/jobs/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AutoragConfigGetJob.OK(Serializer.deserialize content)
            | 404 -> return AutoragConfigGetJob.NotFound(Serializer.deserialize content)
            | _ -> return AutoragConfigGetJob.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///List Job Logs
    ///</summary>
    ///<param name="id">rag id</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AutoragConfigListJobLogs
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
                    "/accounts/{account_id}/autorag/rags/{id}/jobs/{job_id}/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AutoragConfigListJobLogs.OK(Serializer.deserialize content)
            | 404 -> return AutoragConfigListJobLogs.NotFound(Serializer.deserialize content)
            | _ -> return AutoragConfigListJobLogs.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Search
    ///</summary>
    ///<param name="id">rag id</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AutoragConfigSearch
        (
            id: string,
            accountId: string,
            body: AutoragConfigSearchPayload,
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
                    "/accounts/{account_id}/autorag/rags/{id}/search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AutoragConfigSearch.OK(Serializer.deserialize content)
            | _ -> return AutoragConfigSearch.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Sync
    ///</summary>
    ///<param name="id">rag id</param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AutoragConfigSync(id: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/autorag/rags/{id}/sync"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AutoragConfigSync.OK(Serializer.deserialize content)
            | 400 -> return AutoragConfigSync.BadRequest(Serializer.deserialize content)
            | 404 -> return AutoragConfigSync.NotFound(Serializer.deserialize content)
            | _ -> return AutoragConfigSync.ServiceUnavailable(Serializer.deserialize content)
        }
