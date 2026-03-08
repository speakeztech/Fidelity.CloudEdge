namespace rec Fidelity.CloudEdge.Management.Calls

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Calls.Types
open Fidelity.CloudEdge.Management.Calls.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type CallsClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists all apps in the Cloudflare account
    ///</summary>
    member this.CallsAppsList(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/calls/apps" requestParts cancellationToken

            return CallsAppsList.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Cloudflare calls app. An app is an unique enviroment where each Session can access all Tracks within the app.
    ///</summary>
    member this.CallsAppsCreateANewApp
        (
            accountId: string,
            body: callsappeditablefields,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/calls/apps" requestParts cancellationToken

            return CallsAppsCreateANewApp.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an app from Cloudflare Calls
    ///</summary>
    member this.CallsAppsDeleteApp(appId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/calls/apps/{app_id}"
                    requestParts
                    cancellationToken

            return CallsAppsDeleteApp.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches details for a single Calls app.
    ///</summary>
    member this.CallsAppsRetrieveAppDetails(appId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/calls/apps/{app_id}"
                    requestParts
                    cancellationToken

            return CallsAppsRetrieveAppDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Edit details for a single app.
    ///</summary>
    member this.CallsAppsUpdateAppDetails
        (
            appId: string,
            accountId: string,
            body: callsappeditablefields,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/calls/apps/{app_id}"
                    requestParts
                    cancellationToken

            return CallsAppsUpdateAppDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all TURN keys in the Cloudflare account
    ///</summary>
    member this.CallsTurnKeyList(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/calls/turn_keys" requestParts cancellationToken

            return CallsTurnKeyList.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Cloudflare Calls TURN key.
    ///</summary>
    member this.CallsTurnKeyCreate
        (
            accountId: string,
            body: callsturnkeyeditablefields,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/calls/turn_keys" requestParts cancellationToken

            return CallsTurnKeyCreate.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a TURN key from Cloudflare Calls
    ///</summary>
    member this.CallsDeleteTurnKey(keyId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("key_id", keyId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/calls/turn_keys/{key_id}"
                    requestParts
                    cancellationToken

            return CallsDeleteTurnKey.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches details for a single TURN key.
    ///</summary>
    member this.CallsRetrieveTurnKeyDetails(keyId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("key_id", keyId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/calls/turn_keys/{key_id}"
                    requestParts
                    cancellationToken

            return CallsRetrieveTurnKeyDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Edit details for a single TURN key.
    ///</summary>
    member this.CallsUpdateTurnKey
        (
            keyId: string,
            accountId: string,
            body: callsturnkeyeditablefields,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("key_id", keyId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/calls/turn_keys/{key_id}"
                    requestParts
                    cancellationToken

            return CallsUpdateTurnKey.OK(Serializer.deserialize content)
        }
