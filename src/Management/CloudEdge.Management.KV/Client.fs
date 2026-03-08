namespace rec Fidelity.CloudEdge.Management.KV

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.KV.Types
open Fidelity.CloudEdge.Management.KV.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type KVClient(httpClient: HttpClient) =
    ///<summary>
    ///Returns the namespaces owned by an account.
    ///</summary>
    member this.WorkersKvNamespaceListNamespaces
        (
            accountId: string,
            ?page: float,
            ?perPage: float,
            ?order: string,
            ?direction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceListNamespaces.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a namespace under the given title. A `400` is returned if the account already owns a namespace with this title. A namespace must be explicitly deleted to be replaced.
    ///</summary>
    member this.WorkersKvNamespaceCreateANamespace
        (
            accountId: string,
            body: ``workers-kvcreaterenamenamespacebody``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceCreateANamespace.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes the namespace corresponding to the given ID.
    ///</summary>
    member this.WorkersKvNamespaceRemoveANamespace
        (
            namespaceId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("namespace_id", namespaceId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces/{namespace_id}"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceRemoveANamespace.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get the namespace corresponding to the given ID.
    ///</summary>
    member this.WorkersKvNamespaceGetANamespace
        (
            namespaceId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("namespace_id", namespaceId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces/{namespace_id}"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceGetANamespace.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Modifies a namespace's title.
    ///</summary>
    member this.WorkersKvNamespaceRenameANamespace
        (
            namespaceId: string,
            accountId: string,
            body: ``workers-kvcreaterenamenamespacebody``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("namespace_id", namespaceId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces/{namespace_id}"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceRenameANamespace.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Write multiple keys and values at once. Body should be an array of up to 10,000 key-value pairs to be stored, along with optional expiration information. Existing values and expirations will be overwritten. If neither `expiration` nor `expiration_ttl` is specified, the key-value pair will never expire. If both are set, `expiration_ttl` is used and `expiration` is ignored. The entire request size must be 100 megabytes or less.
    ///</summary>
    member this.WorkersKvNamespaceWriteMultipleKeyValuePairs
        (
            namespaceId: string,
            accountId: string,
            body: ``workers-kvbulkwrite``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("namespace_id", namespaceId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces/{namespace_id}/bulk"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceWriteMultipleKeyValuePairs.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists a namespace's keys.
    ///</summary>
    member this.WorkersKvNamespaceListANamespace'SKeys
        (
            namespaceId: string,
            accountId: string,
            ?limit: float,
            ?prefix: string,
            ?cursor: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("namespace_id", namespaceId)
                  RequestPart.path ("account_id", accountId)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if prefix.IsSome then
                      RequestPart.query ("prefix", prefix.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces/{namespace_id}/keys"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceListANamespace'SKeys.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the metadata associated with the given key in the given namespace. Use URL-encoding to use special characters (for example, `:`, `!`, `%`) in the key name.
    ///</summary>
    member this.WorkersKvNamespaceReadTheMetadataForAKey
        (
            keyName: string,
            namespaceId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("key_name", keyName)
                  RequestPart.path ("namespace_id", namespaceId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces/{namespace_id}/metadata/{key_name}"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceReadTheMetadataForAKey.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a KV pair from the namespace. Use URL-encoding to use special characters (for example, `:`, `!`, `%`) in the key name.
    ///</summary>
    member this.WorkersKvNamespaceDeleteKeyValuePair
        (
            keyName: string,
            namespaceId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("key_name", keyName)
                  RequestPart.path ("namespace_id", namespaceId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces/{namespace_id}/values/{key_name}"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceDeleteKeyValuePair.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the value associated with the given key in the given namespace. Use URL-encoding to use special characters (for example, `:`, `!`, `%`) in the key name. If the KV-pair is set to expire at some point, the expiration time as measured in seconds since the UNIX epoch will be returned in the `expiration` response header.
    ///</summary>
    member this.WorkersKvNamespaceReadKeyValuePair
        (
            keyName: string,
            namespaceId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("key_name", keyName)
                  RequestPart.path ("namespace_id", namespaceId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces/{namespace_id}/values/{key_name}"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceReadKeyValuePair.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Write a value identified by a key. Use URL-encoding to use special characters (for example, `:`, `!`, `%`) in the key name. Body should be the value to be stored. If JSON metadata to be associated with the key/value pair is needed, use `multipart/form-data` content type for your PUT request (see dropdown below in `REQUEST BODY SCHEMA`). Existing values, expirations, and metadata will be overwritten. If neither `expiration` nor `expiration_ttl` is specified, the key-value pair will never expire. If both are set, `expiration_ttl` is used and `expiration` is ignored.
    ///</summary>
    ///<param name="keyName"></param>
    ///<param name="namespaceId"></param>
    ///<param name="accountId"></param>
    ///<param name="body">A byte sequence to be stored, up to 25 MiB in length.</param>
    ///<param name="expiration"></param>
    ///<param name="expirationTtl"></param>
    ///<param name="cancellationToken"></param>
    member this.WorkersKvNamespaceWriteKeyValuePairWithMetadata
        (
            keyName: string,
            namespaceId: string,
            accountId: string,
            body: string,
            ?expiration: float,
            ?expirationTtl: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("key_name", keyName)
                  RequestPart.path ("namespace_id", namespaceId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if expiration.IsSome then
                      RequestPart.query ("expiration", expiration.Value)
                  if expirationTtl.IsSome then
                      RequestPart.query ("expiration_ttl", expirationTtl.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/storage/kv/namespaces/{namespace_id}/values/{key_name}"
                    requestParts
                    cancellationToken

            return WorkersKvNamespaceWriteKeyValuePairWithMetadata.OK(Serializer.deserialize content)
        }
