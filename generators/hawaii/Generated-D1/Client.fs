namespace rec Fidelity.CloudEdge.Management.D1

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.D1.Types
open Fidelity.CloudEdge.Management.D1.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type D1Client(httpClient: HttpClient) =
    ///<summary>
    ///Returns a list of D1 databases.
    ///</summary>
    member this.D1ListDatabases
        (
            accountId: string,
            ?name: string,
            ?page: float,
            ?perPage: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/d1/database" requestParts cancellationToken

            return D1ListDatabases.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the created D1 database.
    ///</summary>
    member this.D1CreateDatabase
        (
            accountId: string,
            body: D1CreateDatabasePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/d1/database" requestParts cancellationToken

            return D1CreateDatabase.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes the specified D1 database.
    ///</summary>
    member this.D1DeleteDatabase(accountId: string, databaseId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("database_id", databaseId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/d1/database/{database_id}"
                    requestParts
                    cancellationToken

            return D1DeleteDatabase.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the specified D1 database.
    ///</summary>
    member this.D1GetDatabase(accountId: string, databaseId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("database_id", databaseId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/d1/database/{database_id}"
                    requestParts
                    cancellationToken

            return D1GetDatabase.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates partially the specified D1 database.
    ///</summary>
    member this.D1UpdatePartialDatabase
        (
            accountId: string,
            databaseId: string,
            body: ``d1database-update-partial-request-body``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("database_id", databaseId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/d1/database/{database_id}"
                    requestParts
                    cancellationToken

            return D1UpdatePartialDatabase.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the specified D1 database.
    ///</summary>
    member this.D1UpdateDatabase
        (
            accountId: string,
            databaseId: string,
            body: ``d1database-update-request-body``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("database_id", databaseId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/d1/database/{database_id}"
                    requestParts
                    cancellationToken

            return D1UpdateDatabase.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the query result as an object.
    ///</summary>
    member this.D1QueryDatabase(accountId: string, databaseId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("database_id", databaseId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/d1/database/{database_id}/query"
                    requestParts
                    cancellationToken

            return D1QueryDatabase.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the query result rows as arrays rather than objects. This is a performance-optimized version of the /query endpoint.
    ///</summary>
    member this.D1RawDatabaseQuery(accountId: string, databaseId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("database_id", databaseId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/d1/database/{database_id}/raw"
                    requestParts
                    cancellationToken

            return D1RawDatabaseQuery.OK(Serializer.deserialize content)
        }
