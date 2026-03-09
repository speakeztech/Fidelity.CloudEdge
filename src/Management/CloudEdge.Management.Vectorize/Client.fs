namespace rec Fidelity.CloudEdge.Management.Vectorize

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Vectorize.Types
open Fidelity.CloudEdge.Management.Vectorize.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type VectorizeClient(httpClient: HttpClient) =
    ///<summary>
    ///Returns a list of Vectorize Indexes
    ///</summary>
    member this.VectorizeListVectorizeIndexes(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeListVectorizeIndexes.OK(Serializer.deserialize content)
            | _ -> return VectorizeListVectorizeIndexes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates and returns a new Vectorize Index.
    ///</summary>
    member this.VectorizeCreateVectorizeIndex
        (
            accountId: string,
            body: ``vectorizecreate-index-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeCreateVectorizeIndex.OK(Serializer.deserialize content)
            | _ -> return VectorizeCreateVectorizeIndex.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes the specified Vectorize Index.
    ///</summary>
    member this.VectorizeDeleteVectorizeIndex
        (
            accountId: string,
            indexName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeDeleteVectorizeIndex.OK(Serializer.deserialize content)
            | _ -> return VectorizeDeleteVectorizeIndex.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the specified Vectorize Index.
    ///</summary>
    member this.VectorizeGetVectorizeIndex
        (
            accountId: string,
            indexName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeGetVectorizeIndex.OK(Serializer.deserialize content)
            | _ -> return VectorizeGetVectorizeIndex.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a set of vectors from an index by their vector identifiers.
    ///</summary>
    member this.VectorizeDeleteVectorsById
        (
            accountId: string,
            indexName: string,
            body: ``vectorizeindex-delete-vectors-by-id-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/delete_by_ids"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeDeleteVectorsById.OK(Serializer.deserialize content)
            | _ -> return VectorizeDeleteVectorsById.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a set of vectors from an index by their vector identifiers.
    ///</summary>
    member this.VectorizeGetVectorsById
        (
            accountId: string,
            indexName: string,
            body: ``vectorizeindex-get-vectors-by-id-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/get_by_ids"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeGetVectorsById.OK(Serializer.deserialize content)
            | _ -> return VectorizeGetVectorsById.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get information about a vectorize index.
    ///</summary>
    member this.VectorizeIndexInfo(accountId: string, indexName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/info"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeIndexInfo.OK(Serializer.deserialize content)
            | _ -> return VectorizeIndexInfo.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Inserts vectors into the specified index and returns a mutation id corresponding to the vectors enqueued for insertion.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="indexName"></param>
    ///<param name="body">ndjson file containing vectors to insert.</param>
    ///<param name="unparsableBehavior"></param>
    ///<param name="cancellationToken"></param>
    member this.VectorizeInsertVector
        (
            accountId: string,
            indexName: string,
            body: string,
            ?unparsableBehavior: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName)
                  RequestPart.jsonContent body
                  if unparsableBehavior.IsSome then
                      RequestPart.query ("unparsable-behavior", unparsableBehavior.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/insert"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeInsertVector.OK(Serializer.deserialize content)
            | _ -> return VectorizeInsertVector.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a paginated list of vector identifiers from the specified index.
    ///</summary>
    member this.VectorizeListVectors
        (
            accountId: string,
            indexName: string,
            ?count: int,
            ?cursor: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName)
                  if count.IsSome then
                      RequestPart.query ("count", count.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/list"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeListVectors.OK(Serializer.deserialize content)
            | _ -> return VectorizeListVectors.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Enable metadata filtering based on metadata property. Limited to 10 properties.
    ///</summary>
    member this.VectorizeCreateMetadataIndex
        (
            accountId: string,
            indexName: string,
            body: ``vectorizecreate-metadata-index-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/metadata_index/create"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeCreateMetadataIndex.OK(Serializer.deserialize content)
            | _ -> return VectorizeCreateMetadataIndex.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Allow Vectorize to delete the specified metadata index.
    ///</summary>
    member this.VectorizeDeleteMetadataIndex
        (
            accountId: string,
            indexName: string,
            body: ``vectorizedelete-metadata-index-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/metadata_index/delete"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeDeleteMetadataIndex.OK(Serializer.deserialize content)
            | _ -> return VectorizeDeleteMetadataIndex.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List Metadata Indexes for the specified Vectorize Index.
    ///</summary>
    member this.VectorizeListMetadataIndexes
        (
            accountId: string,
            indexName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/metadata_index/list"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeListMetadataIndexes.OK(Serializer.deserialize content)
            | _ -> return VectorizeListMetadataIndexes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Finds vectors closest to a given vector in an index.
    ///</summary>
    member this.VectorizeQueryVector
        (
            accountId: string,
            indexName: string,
            body: ``vectorizeindex-query-v2-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/query"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeQueryVector.OK(Serializer.deserialize content)
            | _ -> return VectorizeQueryVector.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Upserts vectors into the specified index, creating them if they do not exist and returns a mutation id corresponding to the vectors enqueued for upsertion.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="indexName"></param>
    ///<param name="body">ndjson file containing vectors to upsert.</param>
    ///<param name="unparsableBehavior"></param>
    ///<param name="cancellationToken"></param>
    member this.VectorizeUpsertVector
        (
            accountId: string,
            indexName: string,
            body: string,
            ?unparsableBehavior: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("index_name", indexName)
                  RequestPart.jsonContent body
                  if unparsableBehavior.IsSome then
                      RequestPart.query ("unparsable-behavior", unparsableBehavior.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vectorize/v2/indexes/{index_name}/upsert"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return VectorizeUpsertVector.OK(Serializer.deserialize content)
            | _ -> return VectorizeUpsertVector.BadRequest(Serializer.deserialize content)
        }
