namespace rec Fidelity.CloudEdge.Management.Images

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Images.Types
open Fidelity.CloudEdge.Management.Images.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type ImagesClient(httpClient: HttpClient) =
    ///<summary>
    ///Upload an image with up to 10 Megabytes using a single HTTP POST (multipart/form-data) request.
    ///An image can be uploaded by sending an image file or passing an accessible to an API url.
    ///</summary>
    member this.CloudflareImagesUploadAnImageViaUrl
        (
            accountId: string,
            body: imagesimagebasicupload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/images/v1" requestParts cancellationToken

            match int status with
            | 200 -> return CloudflareImagesUploadAnImageViaUrl.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesUploadAnImageViaUrl.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists your signing keys. These can be found on your Cloudflare Images dashboard.
    ///</summary>
    member this.CloudflareImagesKeysListSigningKeys(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/images/v1/keys" requestParts cancellationToken

            match int status with
            | 200 -> return CloudflareImagesKeysListSigningKeys.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesKeysListSigningKeys.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete signing key with specified name. Returns all keys available.
    ///When last key is removed, a new default signing key will be generated.
    ///</summary>
    member this.CloudflareImagesKeysDeleteSigningKey
        (
            signingKeyName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("signing_key_name", signingKeyName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/keys/{signing_key_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesKeysDeleteSigningKey.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesKeysDeleteSigningKey.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new signing key with specified name. Returns all keys available.
    ///</summary>
    member this.CloudflareImagesKeysAddSigningKey
        (
            signingKeyName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("signing_key_name", signingKeyName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/keys/{signing_key_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesKeysAddSigningKey.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesKeysAddSigningKey.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch image statistics details for Cloudflare Images. The returned statistics detail storage usage, including the current image count vs this account's allowance.
    ///</summary>
    member this.CloudflareImagesImagesUsageStatistics(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/images/v1/stats" requestParts cancellationToken

            match int status with
            | 200 -> return CloudflareImagesImagesUsageStatistics.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesImagesUsageStatistics.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists existing variants.
    ///</summary>
    member this.CloudflareImagesVariantsListVariants(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/variants"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesVariantsListVariants.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesVariantsListVariants.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Specify variants that allow you to resize images for different use cases.
    ///</summary>
    member this.CloudflareImagesVariantsCreateAVariant
        (
            accountId: string,
            body: imagesimagevariantdefinition,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/variants"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesVariantsCreateAVariant.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesVariantsCreateAVariant.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deleting a variant purges the cache for all images associated with the variant.
    ///</summary>
    member this.CloudflareImagesVariantsDeleteAVariant
        (
            variantId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("variant_id", variantId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/variants/{variant_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesVariantsDeleteAVariant.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesVariantsDeleteAVariant.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch details for a single variant.
    ///</summary>
    member this.CloudflareImagesVariantsVariantDetails
        (
            variantId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("variant_id", variantId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/variants/{variant_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesVariantsVariantDetails.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesVariantsVariantDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updating a variant purges the cache for all images associated with the variant.
    ///</summary>
    member this.CloudflareImagesVariantsUpdateAVariant
        (
            variantId: string,
            accountId: string,
            body: imagesimagevariantpatchrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("variant_id", variantId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/variants/{variant_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesVariantsUpdateAVariant.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesVariantsUpdateAVariant.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete an image on Cloudflare Images. On success, all copies of the image are deleted and purged from cache.
    ///</summary>
    member this.CloudflareImagesDeleteImage(imageId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("image_id", imageId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/{image_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesDeleteImage.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesDeleteImage.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch details for a single image.
    ///</summary>
    member this.CloudflareImagesImageDetails
        (
            imageId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("image_id", imageId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/{image_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesImageDetails.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesImageDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update image access control. On access control change, all copies of the image are purged from cache.
    ///</summary>
    member this.CloudflareImagesUpdateImage
        (
            imageId: string,
            accountId: string,
            body: imagesimagepatchrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("image_id", imageId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/{image_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesUpdateImage.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesUpdateImage.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch base image. For most images this will be the originally uploaded file. For larger images it can be a near-lossless version of the original.
    ///</summary>
    member this.CloudflareImagesBaseImage(imageId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("image_id", imageId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/images/v1/{image_id}/blob"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesBaseImage.OK content
            | _ -> return CloudflareImagesBaseImage.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List up to 10000 images with up to 1000 results per page. Use the optional parameters below to get a specific range of images.
    ///Pagination is supported via continuation_token.
    ///**Metadata Filtering (Optional):**
    ///You can optionally filter images by custom metadata fields using the `meta.&amp;lt;field&amp;gt;[&amp;lt;operator&amp;gt;]=&amp;lt;value&amp;gt;` syntax.
    ///**Supported Operators:**
    ///- `eq` / `eq:string` / `eq:number` / `eq:boolean` - Exact match
    ///- `in` / `in:string` / `in:number` - Match any value in list (pipe-separated)
    ///**Metadata Filter Constraints:**
    ///- Maximum 5 metadata filters per request
    ///- Maximum 5 levels of nesting (e.g., `meta.first.second.third.fourth.fifth`)
    ///- Maximum 10 elements for list operators (`in`)
    ///- Supports string, number, and boolean value types
    ///**Examples:**
    ///```
    ///# List all images
    ////images/v2
    ///# Filter by metadata [eq]
    ////images/v2?meta.status[eq:string]=active
    ///# Filter by metadata [in]
    ////images/v2?meta.status[in]=pending|deleted|flagged
    ///# Filter by metadata [in:number]
    ////images/v2?meta.ratings[in:number]=4|5
    ///# Filter by nested metadata
    ////images/v2?meta.region.name[eq]=eu-west
    ///# Combine metadata filters with creator
    ////images/v2?meta.status[eq]=active&amp;creator=user123
    ///# Multiple metadata filters (AND logic)
    ////images/v2?meta.status[eq]=active&amp;meta.priority[eq:number]=5
    ///```
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="continuationToken"></param>
    ///<param name="perPage"></param>
    ///<param name="sortOrder"></param>
    ///<param name="creator"></param>
    ///<param name="meta<field><operator>">
    ///Optional metadata filter(s). Multiple filters can be combined with AND logic.
    ///**Operators:**
    ///- `eq`, `eq:string`, `eq:number`, `eq:boolean` - Exact match
    ///- `in`, `in:string`, `in:number` - Match any value in pipe-separated list
    ///**Examples:**
    ///- `meta.status[eq]=active`
    ///- `meta.priority[eq:number]=5`
    ///- `meta.enabled[eq:boolean]=true`
    ///- `meta.region[in]=us-east|us-west|eu-west`
    ///</param>
    ///<param name="cancellationToken"></param>
    member this.CloudflareImagesListImagesV2
        (
            accountId: string,
            ?continuationToken: string,
            ?perPage: float,
            ?sortOrder: string,
            ?creator: string,
            ?``meta<field><operator>``: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if continuationToken.IsSome then
                      RequestPart.query ("continuation_token", continuationToken.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if sortOrder.IsSome then
                      RequestPart.query ("sort_order", sortOrder.Value)
                  if creator.IsSome then
                      RequestPart.query ("creator", creator.Value)
                  if ``meta<field><operator>``.IsSome then
                      RequestPart.query ("meta.<field>[<operator>]", ``meta<field><operator>``.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/images/v2" requestParts cancellationToken

            match int status with
            | 200 -> return CloudflareImagesListImagesV2.OK(Serializer.deserialize content)
            | _ -> return CloudflareImagesListImagesV2.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Direct uploads allow users to upload images without API keys. A common use case are web apps, client-side applications, or mobile devices where users upload content directly to Cloudflare Images. This method creates a draft record for a future image. It returns an upload URL and an image identifier. To verify if the image itself has been uploaded, send an image details request (accounts/:account_identifier/images/v1/:identifier), and check that the `draft: true` property is not present.
    ///</summary>
    member this.CloudflareImagesCreateAuthenticatedDirectUploadUrlV2
        (
            accountId: string,
            body: imagesimagedirectuploadrequestv2,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/images/v2/direct_upload"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareImagesCreateAuthenticatedDirectUploadUrlV2.OK(Serializer.deserialize content)
            | _ ->
                return CloudflareImagesCreateAuthenticatedDirectUploadUrlV2.BadRequest(Serializer.deserialize content)
        }
