namespace rec Fidelity.CloudEdge.Management.Workers

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Workers.Types
open Fidelity.CloudEdge.Management.Workers.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type WorkersClient(httpClient: HttpClient) =
    ///<summary>
    ///Fetch a list of uploaded workers.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="tags">Filter scripts by tags. Format: comma-separated list of tag:allowed pairs where allowed is 'yes' or 'no'.</param>
    ///<param name="cancellationToken"></param>
    member this.WorkerScriptListWorkers(accountId: string, ?tags: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/workers/scripts" requestParts cancellationToken

            return WorkerScriptListWorkers.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete your worker. This call has no response body on a successful delete.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName"></param>
    ///<param name="force">If set to true, delete will not be stopped by associated service binding, durable object, or other binding. Any of these associated bindings/durable objects will be deleted along with the script.</param>
    ///<param name="cancellationToken"></param>
    member this.WorkerScriptDeleteWorker
        (
            accountId: string,
            scriptName: string,
            ?force: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  if force.IsSome then
                      RequestPart.query ("force", force.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}"
                    requestParts
                    cancellationToken

            return WorkerScriptDeleteWorker.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch raw script content for your worker. Note this is the original script content, not JSON encoded.
    ///</summary>
    member this.WorkerScriptDownloadWorker
        (
            accountId: string,
            scriptName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}"
                    requestParts
                    cancellationToken

            return WorkerScriptDownloadWorker.OK content
        }

    ///<summary>
    ///Upload a worker module. You can find more about the multipart metadata on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName"></param>
    ///<param name="bindingsInherit">When set to "strict", the upload will fail if any `inherit` type bindings cannot be resolved against the previous version of the Worker. Without this, unresolvable inherit bindings are silently dropped.</param>
    ///<param name="cancellationToken"></param>
    member this.WorkerScriptUploadWorkerModule
        (
            accountId: string,
            scriptName: string,
            ?bindingsInherit: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  if bindingsInherit.IsSome then
                      RequestPart.query ("bindings_inherit", bindingsInherit.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}"
                    requestParts
                    cancellationToken

            return WorkerScriptUploadWorkerModule.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Put script content without touching config or metadata.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName"></param>
    ///<param name="body"></param>
    ///<param name="cFWORKERBODYPART">The multipart name of a script upload part containing script content in service worker format. Alternative to including in a metadata part.</param>
    ///<param name="cFWORKERMAINMODULEPART">The multipart name of a script upload part containing script content in es module format. Alternative to including in a metadata part.</param>
    ///<param name="cancellationToken"></param>
    member this.WorkerScriptPutContent
        (
            accountId: string,
            scriptName: string,
            body: WorkerScriptPutContentPayload,
            ?cFWORKERBODYPART: string,
            ?cFWORKERMAINMODULEPART: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  RequestPart.jsonContent body
                  if cFWORKERBODYPART.IsSome then
                      RequestPart.header ("CF-WORKER-BODY-PART", cFWORKERBODYPART.Value)
                  if cFWORKERMAINMODULEPART.IsSome then
                      RequestPart.header ("CF-WORKER-MAIN-MODULE-PART", cFWORKERMAINMODULEPART.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/content"
                    requestParts
                    cancellationToken

            return WorkerScriptPutContent.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches Cron Triggers for a Worker.
    ///</summary>
    member this.WorkerCronTriggerGetCronTriggers
        (
            accountId: string,
            scriptName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/schedules"
                    requestParts
                    cancellationToken

            return WorkerCronTriggerGetCronTriggers.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates Cron Triggers for a Worker.
    ///</summary>
    member this.WorkerCronTriggerUpdateCronTriggers
        (
            accountId: string,
            scriptName: string,
            body: WorkerCronTriggerUpdateCronTriggersPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/schedules"
                    requestParts
                    cancellationToken

            return WorkerCronTriggerUpdateCronTriggers.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List secrets bound to a script.
    ///</summary>
    member this.WorkerListScriptSecrets(accountId: string, scriptName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/secrets"
                    requestParts
                    cancellationToken

            return WorkerListScriptSecrets.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Add a secret to a script.
    ///</summary>
    member this.WorkerPutScriptSecret(accountId: string, scriptName: string, body: Types.workersbindingkindsecrettext, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/secrets"
                    requestParts
                    cancellationToken

            return WorkerPutScriptSecret.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get list of tails currently deployed on a Worker.
    ///</summary>
    member this.GetAccountsWorkersScriptsTailsByAccountIdAndScriptName
        (
            accountId: string,
            scriptName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/tails"
                    requestParts
                    cancellationToken

            return GetAccountsWorkersScriptsTailsByAccountIdAndScriptName.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Starts a tail that receives logs and exception from a Worker.
    ///</summary>
    member this.WorkerTailLogsStartTail(accountId: string, scriptName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/tails"
                    requestParts
                    cancellationToken

            return WorkerTailLogsStartTail.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches the Usage Model for a given Worker.
    ///</summary>
    member this.WorkerScriptFetchUsageModel
        (
            accountId: string,
            scriptName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/usage-model"
                    requestParts
                    cancellationToken

            return WorkerScriptFetchUsageModel.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the Usage Model for a given Worker. Requires a Workers Paid subscription.
    ///</summary>
    member this.WorkerScriptUpdateUsageModel
        (
            accountId: string,
            scriptName: string,
            body: WorkerScriptUpdateUsageModelPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/usage-model"
                    requestParts
                    cancellationToken

            return WorkerScriptUpdateUsageModel.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List of Worker Versions. The first version in the list is the latest version.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName"></param>
    ///<param name="deployable">Only return versions that can be used in a deployment. Ignores pagination.</param>
    ///<param name="page">Current page.</param>
    ///<param name="perPage">Items per-page.</param>
    ///<param name="cancellationToken"></param>
    member this.WorkerVersionsListVersions
        (
            accountId: string,
            scriptName: string,
            ?deployable: bool,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  if deployable.IsSome then
                      RequestPart.query ("deployable", deployable.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/versions"
                    requestParts
                    cancellationToken

            return WorkerVersionsListVersions.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Upload a Worker Version without deploying to Cloudflare's network. You can find more about the multipart metadata on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName"></param>
    ///<param name="bindingsInherit">When set to "strict", the upload will fail if any `inherit` type bindings cannot be resolved against the previous version of the Worker. Without this, unresolvable inherit bindings are silently dropped.</param>
    ///<param name="cancellationToken"></param>
    member this.WorkerVersionsUploadVersion
        (
            accountId: string,
            scriptName: string,
            ?bindingsInherit: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  if bindingsInherit.IsSome then
                      RequestPart.query ("bindings_inherit", bindingsInherit.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/versions"
                    requestParts
                    cancellationToken

            return WorkerVersionsUploadVersion.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves detailed information about a specific version of a Workers script.
    ///</summary>
    member this.WorkerVersionsGetVersionDetail
        (
            accountId: string,
            scriptName: string,
            versionId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  RequestPart.path ("version_id", versionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workers/scripts/{script_name}/versions/{version_id}"
                    requestParts
                    cancellationToken

            return WorkerVersionsGetVersionDetail.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a Workers subdomain for an account.
    ///</summary>
    member this.WorkerSubdomainDeleteSubdomain(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/workers/subdomain"
                    requestParts
                    cancellationToken

            return WorkerSubdomainDeleteSubdomain.NoContent(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a Workers subdomain for an account.
    ///</summary>
    member this.WorkerSubdomainGetSubdomain(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workers/subdomain"
                    requestParts
                    cancellationToken

            return WorkerSubdomainGetSubdomain.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a Workers subdomain for an account.
    ///</summary>
    member this.WorkerSubdomainCreateSubdomain
        (
            accountId: string,
            body: ``workersschemas-subdomain``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/workers/subdomain"
                    requestParts
                    cancellationToken

            return WorkerSubdomainCreateSubdomain.OK(Serializer.deserialize content)
        }
