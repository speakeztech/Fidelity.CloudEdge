namespace rec Fidelity.CloudEdge.Management.R2

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.R2.Types
open Fidelity.CloudEdge.Management.R2.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type R2Client(httpClient: HttpClient) =
    ///<summary>
    ///Lists all R2 buckets on your account.
    ///</summary>
    member this.R2ListBuckets
        (
            accountId: string,
            ?nameContains: string,
            ?startAfter: string,
            ?perPage: float,
            ?order: string,
            ?direction: string,
            ?cursor: string,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if nameContains.IsSome then
                      RequestPart.query ("name_contains", nameContains.Value)
                  if startAfter.IsSome then
                      RequestPart.query ("start_after", startAfter.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value)
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/r2/buckets" requestParts cancellationToken

            match int status with
            | 200 -> return R2ListBuckets.OK(Serializer.deserialize content)
            | _ -> return R2ListBuckets.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new R2 bucket.
    ///</summary>
    member this.R2CreateBucket
        (
            accountId: string,
            body: R2CreateBucketPayload,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/r2/buckets" requestParts cancellationToken

            match int status with
            | 200 -> return R2CreateBucket.OK(Serializer.deserialize content)
            | _ -> return R2CreateBucket.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an existing R2 bucket.
    ///</summary>
    member this.R2DeleteBucket
        (
            bucketName: string,
            accountId: string,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("bucket_name", bucketName)
                  RequestPart.path ("account_id", accountId)
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/r2/buckets/{bucket_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2DeleteBucket.OK(Serializer.deserialize content)
            | _ -> return R2DeleteBucket.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets properties of an existing R2 bucket.
    ///</summary>
    member this.R2GetBucket
        (
            accountId: string,
            bucketName: string,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/r2/buckets/{bucket_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2GetBucket.OK(Serializer.deserialize content)
            | _ -> return R2GetBucket.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates properties of an existing R2 bucket.
    ///</summary>
    member this.R2PatchBucket
        (
            accountId: string,
            bucketName: string,
            cfR2StorageClass: string,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  RequestPart.header ("cf-r2-storage-class", cfR2StorageClass)
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/r2/buckets/{bucket_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2PatchBucket.OK(Serializer.deserialize content)
            | _ -> return R2PatchBucket.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Disables Sippy on this bucket.
    ///</summary>
    member this.R2DeleteBucketSippyConfig
        (
            bucketName: string,
            accountId: string,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("bucket_name", bucketName)
                  RequestPart.path ("account_id", accountId)
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/r2/buckets/{bucket_name}/sippy"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2DeleteBucketSippyConfig.OK(Serializer.deserialize content)
            | _ -> return R2DeleteBucketSippyConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets configuration for Sippy for an existing R2 bucket.
    ///</summary>
    member this.R2GetBucketSippyConfig
        (
            accountId: string,
            bucketName: string,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/r2/buckets/{bucket_name}/sippy"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2GetBucketSippyConfig.OK(Serializer.deserialize content)
            | _ -> return R2GetBucketSippyConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Sets configuration for Sippy for an existing R2 bucket.
    ///</summary>
    member this.R2PutBucketSippyConfig
        (
            accountId: string,
            bucketName: string,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/r2/buckets/{bucket_name}/sippy"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2PutBucketSippyConfig.OK(Serializer.deserialize content)
            | _ -> return R2PutBucketSippyConfig.BadRequest(Serializer.deserialize content)
        }
