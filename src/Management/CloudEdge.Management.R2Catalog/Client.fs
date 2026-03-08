namespace rec Fidelity.CloudEdge.Management.R2Catalog

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.R2Catalog.Types
open Fidelity.CloudEdge.Management.R2Catalog.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type R2CatalogClient(httpClient: HttpClient) =
    ///<summary>
    ///Returns a list of R2 buckets that have been enabled as Apache Iceberg catalogs
    ///for the specified account. Each catalog represents an R2 bucket configured
    ///to store Iceberg metadata and data files.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="cancellationToken"></param>
    member this.ListCatalogs(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/r2-catalog" requestParts cancellationToken

            match int status with
            | 200 -> return ListCatalogs.OK(Serializer.deserialize content)
            | 400 -> return ListCatalogs.BadRequest(Serializer.deserialize content)
            | 401 -> return ListCatalogs.Unauthorized(Serializer.deserialize content)
            | 403 -> return ListCatalogs.Forbidden(Serializer.deserialize content)
            | _ -> return ListCatalogs.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve detailed information about a specific R2 catalog by bucket name.
    ///Returns catalog status, maintenance configuration, and credential status.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name.</param>
    ///<param name="cancellationToken"></param>
    member this.GetCatalogDetails(accountId: string, bucketName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetCatalogDetails.OK(Serializer.deserialize content)
            | 400 -> return GetCatalogDetails.BadRequest(Serializer.deserialize content)
            | 401 -> return GetCatalogDetails.Unauthorized(Serializer.deserialize content)
            | 403 -> return GetCatalogDetails.Forbidden(Serializer.deserialize content)
            | 404 -> return GetCatalogDetails.NotFound(Serializer.deserialize content)
            | _ -> return GetCatalogDetails.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Store authentication credentials for a catalog. These credentials are used
    ///to authenticate with R2 storage when performing catalog operations.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name.</param>
    ///<param name="body">Contains request to store catalog credentials.</param>
    ///<param name="cancellationToken"></param>
    member this.StoreCredentials
        (
            accountId: string,
            bucketName: string,
            body: ``r2-data-catalogcatalog-credential-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}/credential"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StoreCredentials.OK(Serializer.deserialize content)
            | 400 -> return StoreCredentials.BadRequest(Serializer.deserialize content)
            | 401 -> return StoreCredentials.Unauthorized(Serializer.deserialize content)
            | 403 -> return StoreCredentials.Forbidden(Serializer.deserialize content)
            | 404 -> return StoreCredentials.NotFound(Serializer.deserialize content)
            | _ -> return StoreCredentials.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Disable an R2 bucket as a catalog. This operation deactivates the catalog
    ///but preserves existing metadata and data files. The catalog can be
    ///re-enabled later.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name to disable as catalog.</param>
    ///<param name="cancellationToken"></param>
    member this.DisableCatalog(accountId: string, bucketName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}/disable"
                    requestParts
                    cancellationToken

            match int status with
            | 204 -> return DisableCatalog.NoContent(Serializer.deserialize content)
            | 400 -> return DisableCatalog.BadRequest(Serializer.deserialize content)
            | 401 -> return DisableCatalog.Unauthorized(Serializer.deserialize content)
            | 403 -> return DisableCatalog.Forbidden(Serializer.deserialize content)
            | 404 -> return DisableCatalog.NotFound(Serializer.deserialize content)
            | _ -> return DisableCatalog.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Enable an R2 bucket as an Apache Iceberg catalog. This operation creates
    ///the necessary catalog infrastructure and activates the bucket for storing
    ///Iceberg metadata and data files.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name to enable as catalog.</param>
    ///<param name="cancellationToken"></param>
    member this.EnableCatalog(accountId: string, bucketName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}/enable"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EnableCatalog.OK(Serializer.deserialize content)
            | 400 -> return EnableCatalog.BadRequest(Serializer.deserialize content)
            | 401 -> return EnableCatalog.Unauthorized(Serializer.deserialize content)
            | 403 -> return EnableCatalog.Forbidden(Serializer.deserialize content)
            | 409 -> return EnableCatalog.Conflict(Serializer.deserialize content)
            | _ -> return EnableCatalog.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve the maintenance configuration for a specific catalog,
    ///including compaction settings and credential status.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name.</param>
    ///<param name="cancellationToken"></param>
    member this.GetMaintenanceConfig(accountId: string, bucketName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}/maintenance-configs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetMaintenanceConfig.OK(Serializer.deserialize content)
            | 400 -> return GetMaintenanceConfig.BadRequest(Serializer.deserialize content)
            | 401 -> return GetMaintenanceConfig.Unauthorized(Serializer.deserialize content)
            | 403 -> return GetMaintenanceConfig.Forbidden(Serializer.deserialize content)
            | 404 -> return GetMaintenanceConfig.NotFound(Serializer.deserialize content)
            | _ -> return GetMaintenanceConfig.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update the maintenance configuration for a catalog. This allows you to
    ///enable or disable compaction and adjust target file sizes for optimization.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name.</param>
    ///<param name="body">Contains request to update catalog maintenance configuration.</param>
    ///<param name="cancellationToken"></param>
    member this.UpdateMaintenanceConfig
        (
            accountId: string,
            bucketName: string,
            body: ``r2-data-catalogcatalog-maintenance-update-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}/maintenance-configs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateMaintenanceConfig.OK(Serializer.deserialize content)
            | 400 -> return UpdateMaintenanceConfig.BadRequest(Serializer.deserialize content)
            | 401 -> return UpdateMaintenanceConfig.Unauthorized(Serializer.deserialize content)
            | 403 -> return UpdateMaintenanceConfig.Forbidden(Serializer.deserialize content)
            | 404 -> return UpdateMaintenanceConfig.NotFound(Serializer.deserialize content)
            | _ -> return UpdateMaintenanceConfig.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a list of namespaces in the specified R2 catalog.
    ///Supports hierarchical filtering and pagination for efficient traversal
    ///of large namespace hierarchies.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name.</param>
    ///<param name="pageToken">
    ///Opaque pagination token from a previous response.
    ///Use this to fetch the next page of results.
    ///</param>
    ///<param name="pageSize">
    ///Maximum number of namespaces to return per page.
    ///Defaults to 100, maximum 1000.
    ///</param>
    ///<param name="parent">
    ///Parent namespace to filter by. Only returns direct children of this namespace.
    ///For nested namespaces, use %1F as separator (e.g., "bronze%1Fanalytics").
    ///Omit this parameter to list top-level namespaces.
    ///</param>
    ///<param name="returnUuids">
    ///Whether to include namespace UUIDs in the response.
    ///Set to true to receive the namespace_uuids array.
    ///</param>
    ///<param name="returnDetails">
    ///Whether to include additional metadata (timestamps).
    ///When true, response includes created_at and updated_at arrays.
    ///</param>
    ///<param name="cancellationToken"></param>
    member this.ListNamespaces
        (
            accountId: string,
            bucketName: string,
            ?pageToken: string,
            ?pageSize: int,
            ?parent: string,
            ?returnUuids: bool,
            ?returnDetails: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  if pageToken.IsSome then
                      RequestPart.query ("page_token", pageToken.Value)
                  if pageSize.IsSome then
                      RequestPart.query ("page_size", pageSize.Value)
                  if parent.IsSome then
                      RequestPart.query ("parent", parent.Value)
                  if returnUuids.IsSome then
                      RequestPart.query ("return_uuids", returnUuids.Value)
                  if returnDetails.IsSome then
                      RequestPart.query ("return_details", returnDetails.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}/namespaces"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListNamespaces.OK(Serializer.deserialize content)
            | 400 -> return ListNamespaces.BadRequest(Serializer.deserialize content)
            | 401 -> return ListNamespaces.Unauthorized(Serializer.deserialize content)
            | 403 -> return ListNamespaces.Forbidden(Serializer.deserialize content)
            | 404 -> return ListNamespaces.NotFound(Serializer.deserialize content)
            | _ -> return ListNamespaces.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a list of tables in the specified namespace within an R2 catalog.
    ///Supports pagination for efficient traversal of large table collections.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name.</param>
    ///<param name="namespace">
    ///The namespace identifier.
    ///For nested namespaces, use %1F as separator (e.g., "bronze%1Fanalytics").
    ///</param>
    ///<param name="pageToken">
    ///Opaque pagination token from a previous response.
    ///Use this to fetch the next page of results.
    ///</param>
    ///<param name="pageSize">
    ///Maximum number of tables to return per page.
    ///Defaults to 100, maximum 1000.
    ///</param>
    ///<param name="returnUuids">
    ///Whether to include table UUIDs in the response.
    ///Set to true to receive the table_uuids array.
    ///</param>
    ///<param name="returnDetails">
    ///Whether to include additional metadata (timestamps, locations).
    ///When true, response includes created_at, updated_at, metadata_locations, and locations arrays.
    ///</param>
    ///<param name="cancellationToken"></param>
    member this.ListTables
        (
            accountId: string,
            bucketName: string,
            ``namespace``: string,
            ?pageToken: string,
            ?pageSize: int,
            ?returnUuids: bool,
            ?returnDetails: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  RequestPart.path ("namespace", ``namespace``)
                  if pageToken.IsSome then
                      RequestPart.query ("page_token", pageToken.Value)
                  if pageSize.IsSome then
                      RequestPart.query ("page_size", pageSize.Value)
                  if returnUuids.IsSome then
                      RequestPart.query ("return_uuids", returnUuids.Value)
                  if returnDetails.IsSome then
                      RequestPart.query ("return_details", returnDetails.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}/namespaces/{namespace}/tables"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListTables.OK(Serializer.deserialize content)
            | 400 -> return ListTables.BadRequest(Serializer.deserialize content)
            | 401 -> return ListTables.Unauthorized(Serializer.deserialize content)
            | 403 -> return ListTables.Forbidden(Serializer.deserialize content)
            | 404 -> return ListTables.NotFound(Serializer.deserialize content)
            | _ -> return ListTables.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve the maintenance configuration for a specific table,
    ///including compaction settings.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name.</param>
    ///<param name="namespace">The namespace identifier (use %1F as separator for nested namespaces).</param>
    ///<param name="tableName">The table name.</param>
    ///<param name="cancellationToken"></param>
    member this.GetTableMaintenanceConfig
        (
            accountId: string,
            bucketName: string,
            ``namespace``: string,
            tableName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  RequestPart.path ("namespace", ``namespace``)
                  RequestPart.path ("table_name", tableName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}/namespaces/{namespace}/tables/{table_name}/maintenance-configs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetTableMaintenanceConfig.OK(Serializer.deserialize content)
            | 400 -> return GetTableMaintenanceConfig.BadRequest(Serializer.deserialize content)
            | 401 -> return GetTableMaintenanceConfig.Unauthorized(Serializer.deserialize content)
            | 403 -> return GetTableMaintenanceConfig.Forbidden(Serializer.deserialize content)
            | 404 -> return GetTableMaintenanceConfig.NotFound(Serializer.deserialize content)
            | _ -> return GetTableMaintenanceConfig.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update the maintenance configuration for a specific table. This allows you to
    ///enable or disable compaction and adjust target file sizes for optimization.
    ///</summary>
    ///<param name="accountId">Identifies the account.</param>
    ///<param name="bucketName">Specifies the R2 bucket name.</param>
    ///<param name="namespace">The namespace identifier (use %1F as separator for nested namespaces).</param>
    ///<param name="tableName">The table name.</param>
    ///<param name="body">Contains request to update table maintenance configuration.</param>
    ///<param name="cancellationToken"></param>
    member this.UpdateTableMaintenanceConfig
        (
            accountId: string,
            bucketName: string,
            ``namespace``: string,
            tableName: string,
            body: ``r2-data-catalogtable-maintenance-update-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("bucket_name", bucketName)
                  RequestPart.path ("namespace", ``namespace``)
                  RequestPart.path ("table_name", tableName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/r2-catalog/{bucket_name}/namespaces/{namespace}/tables/{table_name}/maintenance-configs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateTableMaintenanceConfig.OK(Serializer.deserialize content)
            | 400 -> return UpdateTableMaintenanceConfig.BadRequest(Serializer.deserialize content)
            | 401 -> return UpdateTableMaintenanceConfig.Unauthorized(Serializer.deserialize content)
            | 403 -> return UpdateTableMaintenanceConfig.Forbidden(Serializer.deserialize content)
            | 404 -> return UpdateTableMaintenanceConfig.NotFound(Serializer.deserialize content)
            | _ -> return UpdateTableMaintenanceConfig.InternalServerError(Serializer.deserialize content)
        }
