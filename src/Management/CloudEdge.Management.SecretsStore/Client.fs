namespace rec Fidelity.CloudEdge.Management.SecretsStore

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.SecretsStore.Types
open Fidelity.CloudEdge.Management.SecretsStore.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type SecretsStoreClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists the number of secrets used in the account.
    ///</summary>
    member this.SecretsStoreQuota(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/quota"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreQuota.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreQuota.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all the stores in an account
    ///</summary>
    member this.SecretsStoreList(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreList.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreList.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a store in the account
    ///</summary>
    member this.SecretsStoreCreate
        (
            accountId: string,
            body: list<``secrets-storecreateStoreObject``>,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreCreate.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreCreate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a single store
    ///</summary>
    member this.SecretsStoreDeleteById(accountId: string, storeId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("store_id", storeId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores/{store_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreDeleteById.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreDeleteById.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns details of a single store
    ///</summary>
    member this.SecretsStoreGetStoreById(accountId: string, storeId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("store_id", storeId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores/{store_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreGetStoreById.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreGetStoreById.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes one or more secrets
    ///</summary>
    member this.SecretsStoreDeleteBulk
        (
            accountId: string,
            storeId: string,
            body: list<``secrets-storedeleteSecretObject``>,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("store_id", storeId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores/{store_id}/secrets"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreDeleteBulk.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreDeleteBulk.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all store secrets
    ///</summary>
    member this.SecretsStoreSecretsList(accountId: string, storeId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("store_id", storeId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores/{store_id}/secrets"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreSecretsList.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreSecretsList.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a secret in the account
    ///</summary>
    member this.SecretsStoreSecretCreate
        (
            accountId: string,
            storeId: string,
            body: list<``secrets-storecreateSecretObject``>,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("store_id", storeId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores/{store_id}/secrets"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreSecretCreate.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreSecretCreate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a single secret
    ///</summary>
    member this.SecretsStoreSecretDeleteById
        (
            accountId: string,
            storeId: string,
            secretId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("store_id", storeId)
                  RequestPart.path ("secret_id", secretId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores/{store_id}/secrets/{secret_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreSecretDeleteById.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreSecretDeleteById.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns details of a single secret
    ///</summary>
    member this.SecretsStoreGetById
        (
            accountId: string,
            storeId: string,
            secretId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("store_id", storeId)
                  RequestPart.path ("secret_id", secretId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores/{store_id}/secrets/{secret_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreGetById.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreGetById.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a single secret
    ///</summary>
    member this.SecretsStorePatchById
        (
            accountId: string,
            storeId: string,
            secretId: string,
            body: ``secrets-storepatchSecretObject``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("store_id", storeId)
                  RequestPart.path ("secret_id", secretId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores/{store_id}/secrets/{secret_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStorePatchById.OK(Serializer.deserialize content)
            | _ -> return SecretsStorePatchById.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Duplicates the secret, keeping the value
    ///</summary>
    member this.SecretsStoreDuplicateById
        (
            accountId: string,
            storeId: string,
            secretId: string,
            body: ``secrets-storeduplicateSecretObject``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("store_id", storeId)
                  RequestPart.path ("secret_id", secretId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/secrets_store/stores/{store_id}/secrets/{secret_id}/duplicate"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SecretsStoreDuplicateById.OK(Serializer.deserialize content)
            | _ -> return SecretsStoreDuplicateById.BadRequest(Serializer.deserialize content)
        }
