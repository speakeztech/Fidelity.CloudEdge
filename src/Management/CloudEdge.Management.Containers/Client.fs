namespace rec Fidelity.CloudEdge.Management.Containers

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Containers.Types
open Fidelity.CloudEdge.Management.Containers.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type ContainersClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists all the container applications that are associated with your account.
    ///</summary>
    ///<param name="name">Filter containers by name</param>
    ///<param name="image">Filter containers by image</param>
    ///<param name="cancellationToken"></param>
    member this.PublicListApplications(?name: string, ?image: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if image.IsSome then
                      RequestPart.query ("image", image.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/containers" requestParts cancellationToken

            match int status with
            | 200 -> return PublicListApplications.OK(Serializer.deserialize content)
            | 401 -> return PublicListApplications.Unauthorized(Serializer.deserialize content)
            | _ -> return PublicListApplications.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Generates temporary credentials for accessing Cloudflare's container image registry. Used for pulling and pushing container images.
    ///</summary>
    ///<param name="domain"></param>
    ///<param name="body">Specifies the configuration for the image registry credential to create.</param>
    ///<param name="cancellationToken"></param>
    member this.GenerateImageRegistryCredentials
        (
            domain: string,
            body: ccImageRegistryCredentialsConfiguration,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("domain", domain)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/containers/registries/{domain}/credentials"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return GenerateImageRegistryCredentials.Created(Serializer.deserialize content)
            | 400 -> return GenerateImageRegistryCredentials.BadRequest(Serializer.deserialize content)
            | 404 -> return GenerateImageRegistryCredentials.NotFound(Serializer.deserialize content)
            | 409 -> return GenerateImageRegistryCredentials.Conflict(Serializer.deserialize content)
            | _ -> return GenerateImageRegistryCredentials.InternalServerError(Serializer.deserialize content)
        }
