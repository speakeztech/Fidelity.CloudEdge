namespace rec Fidelity.CloudEdge.Management.Hyperdrive

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Hyperdrive.Types
open Fidelity.CloudEdge.Management.Hyperdrive.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type HyperdriveClient(httpClient: HttpClient) =
    ///<summary>
    ///Returns a list of Hyperdrives.
    ///</summary>
    ///<param name="accountId">The Cloudflare account ID.</param>
    ///<param name="cancellationToken"></param>
    member this.ListHyperdrive(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/hyperdrive/configs"
                    requestParts
                    cancellationToken

            return ListHyperdrive.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates and returns a new Hyperdrive configuration.
    ///</summary>
    ///<param name="accountId">The Cloudflare account ID.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateHyperdrive
        (
            accountId: string,
            body: ``hyperdrivehyperdrive-config``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/hyperdrive/configs"
                    requestParts
                    cancellationToken

            return CreateHyperdrive.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes the specified Hyperdrive.
    ///</summary>
    ///<param name="accountId">The Cloudflare account ID.</param>
    ///<param name="hyperdriveId">The unique identifier of the Hyperdrive configuration.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteHyperdrive(accountId: string, hyperdriveId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("hyperdrive_id", hyperdriveId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/hyperdrive/configs/{hyperdrive_id}"
                    requestParts
                    cancellationToken

            return DeleteHyperdrive.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the specified Hyperdrive configuration.
    ///</summary>
    ///<param name="accountId">The Cloudflare account ID.</param>
    ///<param name="hyperdriveId">The unique identifier of the Hyperdrive configuration.</param>
    ///<param name="cancellationToken"></param>
    member this.GetHyperdrive(accountId: string, hyperdriveId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("hyperdrive_id", hyperdriveId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/hyperdrive/configs/{hyperdrive_id}"
                    requestParts
                    cancellationToken

            return GetHyperdrive.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Patches and returns the specified Hyperdrive configuration. Custom caching settings are not kept if caching is disabled.
    ///</summary>
    ///<param name="accountId">The Cloudflare account ID.</param>
    ///<param name="hyperdriveId">The unique identifier of the Hyperdrive configuration.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.PatchHyperdrive
        (
            accountId: string,
            hyperdriveId: string,
            body: ``hyperdrivehyperdrive-config-patch``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("hyperdrive_id", hyperdriveId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/hyperdrive/configs/{hyperdrive_id}"
                    requestParts
                    cancellationToken

            return PatchHyperdrive.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates and returns the specified Hyperdrive configuration.
    ///</summary>
    ///<param name="accountId">The Cloudflare account ID.</param>
    ///<param name="hyperdriveId">The unique identifier of the Hyperdrive configuration.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdateHyperdrive
        (
            accountId: string,
            hyperdriveId: string,
            body: ``hyperdrivehyperdrive-config``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("hyperdrive_id", hyperdriveId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/hyperdrive/configs/{hyperdrive_id}"
                    requestParts
                    cancellationToken

            return UpdateHyperdrive.OK(Serializer.deserialize content)
        }
