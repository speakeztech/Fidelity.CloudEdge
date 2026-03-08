namespace rec Fidelity.CloudEdge.Management.DurableObjects

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.DurableObjects.Types
open Fidelity.CloudEdge.Management.DurableObjects.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type DurableObjectsClient(httpClient: HttpClient) =
    ///<summary>
    ///Returns the Durable Object namespaces owned by an account.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">Current page.</param>
    ///<param name="perPage">Items per-page.</param>
    ///<param name="cancellationToken"></param>
    member this.DurableObjectsNamespaceListNamespaces
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
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
                    "/accounts/{account_id}/workers/durable_objects/namespaces"
                    requestParts
                    cancellationToken

            return DurableObjectsNamespaceListNamespaces.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the Durable Objects in a given namespace.
    ///</summary>
    member this.DurableObjectsNamespaceListObjects
        (
            accountId: string,
            id: string,
            ?limit: float,
            ?cursor: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workers/durable_objects/namespaces/{id}/objects"
                    requestParts
                    cancellationToken

            return DurableObjectsNamespaceListObjects.OK(Serializer.deserialize content)
        }
