namespace rec Fidelity.CloudEdge.Management.BrowserRendering

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.BrowserRendering.Types
open Fidelity.CloudEdge.Management.BrowserRendering.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type BrowserRenderingClient(httpClient: HttpClient) =
    ///<summary>
    ///Fetches rendered HTML content from provided URL or HTML. Check available options like `gotoOptions` and `waitFor*` to control page load behaviour.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostContent
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/content"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostContent.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostContent.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostContent.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostContent.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets json from a webpage from a provided URL or HTML. Pass `prompt` or `schema` in the body. Control page loading with `gotoOptions` and `waitFor*` options.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostJson
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/json"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostJson.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostJson.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostJson.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostJson.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get links from a web page.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostLinks
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/links"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostLinks.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostLinks.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostLinks.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostLinks.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets markdown of a webpage from provided URL or HTML. Control page loading with `gotoOptions` and `waitFor*` options.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostMarkdown
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/markdown"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostMarkdown.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostMarkdown.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostMarkdown.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostMarkdown.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches rendered PDF from provided URL or HTML. Check available options like `gotoOptions` and `waitFor*` to control page load behaviour.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostPdf(accountId: string, body: string, ?cacheTTL: float, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/pdf"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostPdf.OK content
            | 400 -> return BrapiPostPdf.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostPdf.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostPdf.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get meta attributes like height, width, text and others of selected elements.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostScrape
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/scrape"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostScrape.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostScrape.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostScrape.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostScrape.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Takes a screenshot of a webpage from provided URL or HTML. Control page loading with `gotoOptions` and `waitFor*` options. Customize screenshots with `viewport`, `fullPage`, `clip` and others.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostScreenshot
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/screenshot"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostScreenshot.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostScreenshot.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostScreenshot.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostScreenshot.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the page's HTML content and screenshot. Control page loading with `gotoOptions` and `waitFor*` options. Customize screenshots with `viewport`, `fullPage`, `clip` and others.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostSnapshot
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/snapshot"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostSnapshot.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostSnapshot.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostSnapshot.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostSnapshot.InternalServerError(Serializer.deserialize content)
        }
