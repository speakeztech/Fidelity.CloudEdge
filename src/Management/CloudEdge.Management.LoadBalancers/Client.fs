namespace rec Fidelity.CloudEdge.Management.LoadBalancers

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.LoadBalancers.Types
open Fidelity.CloudEdge.Management.LoadBalancers.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type LoadBalancersClient(httpClient: HttpClient) =
    ///<summary>
    ///List configured monitor groups.
    ///</summary>
    member this.AccountLoadBalancerMonitorGroupsListMonitorGroups
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitor_groups"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorGroupsListMonitorGroups.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorGroupsListMonitorGroups.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new monitor group.
    ///</summary>
    member this.AccountLoadBalancerMonitorGroupsCreateMonitorGroup
        (
            accountId: string,
            body: ``load-balancingmonitor-group``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitor_groups"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorGroupsCreateMonitorGroup.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorGroupsCreateMonitorGroup.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a configured monitor group.
    ///</summary>
    member this.AccountLoadBalancerMonitorGroupsDeleteMonitorGroup
        (
            monitorGroupId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_group_id", monitorGroupId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitor_groups/{monitor_group_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorGroupsDeleteMonitorGroup.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorGroupsDeleteMonitorGroup.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch a single configured monitor group.
    ///</summary>
    member this.AccountLoadBalancerMonitorGroupsMonitorGroupDetails
        (
            monitorGroupId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_group_id", monitorGroupId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitor_groups/{monitor_group_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorGroupsMonitorGroupDetails.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorGroupsMonitorGroupDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Apply changes to an existing monitor group, overwriting the supplied properties.
    ///</summary>
    member this.AccountLoadBalancerMonitorGroupsPatchMonitorGroup
        (
            monitorGroupId: string,
            accountId: string,
            body: ``load-balancingmonitor-group``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_group_id", monitorGroupId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitor_groups/{monitor_group_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorGroupsPatchMonitorGroup.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorGroupsPatchMonitorGroup.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Modify a configured monitor group.
    ///</summary>
    member this.AccountLoadBalancerMonitorGroupsUpdateMonitorGroup
        (
            monitorGroupId: string,
            accountId: string,
            body: ``load-balancingmonitor-group``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_group_id", monitorGroupId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitor_groups/{monitor_group_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorGroupsUpdateMonitorGroup.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorGroupsUpdateMonitorGroup.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get the list of resources that reference the provided monitor group.
    ///</summary>
    member this.AccountLoadBalancerMonitorGroupsListMonitorGroupReferences
        (
            monitorGroupId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_group_id", monitorGroupId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitor_groups/{monitor_group_id}/references"
                    requestParts
                    cancellationToken

            match int status with
            | 200 ->
                return AccountLoadBalancerMonitorGroupsListMonitorGroupReferences.OK(Serializer.deserialize content)
            | _ ->
                return
                    AccountLoadBalancerMonitorGroupsListMonitorGroupReferences.BadRequest(
                        Serializer.deserialize content
                    )
        }

    ///<summary>
    ///List configured monitors for an account.
    ///</summary>
    member this.AccountLoadBalancerMonitorsListMonitors(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitors"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorsListMonitors.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorsListMonitors.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a configured monitor.
    ///</summary>
    member this.AccountLoadBalancerMonitorsCreateMonitor
        (
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitors"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorsCreateMonitor.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorsCreateMonitor.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a configured monitor.
    ///</summary>
    member this.AccountLoadBalancerMonitorsDeleteMonitor
        (
            monitorId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_id", monitorId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitors/{monitor_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorsDeleteMonitor.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorsDeleteMonitor.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List a single configured monitor for an account.
    ///</summary>
    member this.AccountLoadBalancerMonitorsMonitorDetails
        (
            monitorId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_id", monitorId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitors/{monitor_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorsMonitorDetails.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorsMonitorDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Apply changes to an existing monitor, overwriting the supplied properties.
    ///</summary>
    member this.AccountLoadBalancerMonitorsPatchMonitor
        (
            monitorId: string,
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_id", monitorId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitors/{monitor_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorsPatchMonitor.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorsPatchMonitor.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Modify a configured monitor.
    ///</summary>
    member this.AccountLoadBalancerMonitorsUpdateMonitor
        (
            monitorId: string,
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_id", monitorId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitors/{monitor_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorsUpdateMonitor.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorsUpdateMonitor.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Preview pools using the specified monitor with provided monitor details. The returned preview_id can be used in the preview endpoint to retrieve the results.
    ///</summary>
    member this.AccountLoadBalancerMonitorsPreviewMonitor
        (
            monitorId: string,
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_id", monitorId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitors/{monitor_id}/preview"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorsPreviewMonitor.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorsPreviewMonitor.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get the list of resources that reference the provided monitor.
    ///</summary>
    member this.AccountLoadBalancerMonitorsListMonitorReferences
        (
            monitorId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("monitor_id", monitorId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/monitors/{monitor_id}/references"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorsListMonitorReferences.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorsListMonitorReferences.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List configured pools.
    ///</summary>
    member this.AccountLoadBalancerPoolsListPools
        (
            accountId: string,
            ?monitor: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if monitor.IsSome then
                      RequestPart.query ("monitor", monitor.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsListPools.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsListPools.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Apply changes to a number of existing pools, overwriting the supplied properties. Pools are ordered by ascending `name`. Returns the list of affected pools. Supports the standard pagination query parameters, either `limit`/`offset` or `per_page`/`page`.
    ///</summary>
    member this.AccountLoadBalancerPoolsPatchPools
        (
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsPatchPools.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsPatchPools.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new pool.
    ///</summary>
    member this.AccountLoadBalancerPoolsCreatePool
        (
            accountId: string,
            body: AccountLoadBalancerPoolsCreatePoolPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsCreatePool.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsCreatePool.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a configured pool.
    ///</summary>
    member this.AccountLoadBalancerPoolsDeletePool
        (
            poolId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pool_id", poolId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools/{pool_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsDeletePool.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsDeletePool.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch a single configured pool.
    ///</summary>
    member this.AccountLoadBalancerPoolsPoolDetails
        (
            poolId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pool_id", poolId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools/{pool_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsPoolDetails.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsPoolDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Apply changes to an existing pool, overwriting the supplied properties.
    ///</summary>
    member this.AccountLoadBalancerPoolsPatchPool
        (
            poolId: string,
            accountId: string,
            body: AccountLoadBalancerPoolsPatchPoolPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pool_id", poolId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools/{pool_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsPatchPool.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsPatchPool.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Modify a configured pool.
    ///</summary>
    member this.AccountLoadBalancerPoolsUpdatePool
        (
            poolId: string,
            accountId: string,
            body: AccountLoadBalancerPoolsUpdatePoolPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pool_id", poolId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools/{pool_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsUpdatePool.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsUpdatePool.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch the latest pool health status for a single pool.
    ///</summary>
    member this.AccountLoadBalancerPoolsPoolHealthDetails
        (
            poolId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pool_id", poolId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools/{pool_id}/health"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsPoolHealthDetails.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsPoolHealthDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Preview pool health using provided monitor details. The returned preview_id can be used in the preview endpoint to retrieve the results.
    ///</summary>
    member this.AccountLoadBalancerPoolsPreviewPool
        (
            poolId: string,
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pool_id", poolId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools/{pool_id}/preview"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsPreviewPool.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsPreviewPool.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get the list of resources that reference the provided pool.
    ///</summary>
    member this.AccountLoadBalancerPoolsListPoolReferences
        (
            poolId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pool_id", poolId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/pools/{pool_id}/references"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerPoolsListPoolReferences.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerPoolsListPoolReferences.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get the result of a previous preview operation using the provided preview_id.
    ///</summary>
    member this.AccountLoadBalancerMonitorsPreviewResult
        (
            previewId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("preview_id", previewId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/preview/{preview_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerMonitorsPreviewResult.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerMonitorsPreviewResult.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all region mappings.
    ///</summary>
    member this.LoadBalancerRegionsListRegions
        (
            accountId: string,
            ?subdivisionCode: string,
            ?subdivisionCodeA2: string,
            ?countryCodeA2: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if subdivisionCode.IsSome then
                      RequestPart.query ("subdivision_code", subdivisionCode.Value)
                  if subdivisionCodeA2.IsSome then
                      RequestPart.query ("subdivision_code_a2", subdivisionCodeA2.Value)
                  if countryCodeA2.IsSome then
                      RequestPart.query ("country_code_a2", countryCodeA2.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/regions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return LoadBalancerRegionsListRegions.OK(Serializer.deserialize content)
            | _ -> return LoadBalancerRegionsListRegions.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a single region mapping.
    ///</summary>
    member this.LoadBalancerRegionsGetRegion
        (
            regionId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("region_id", regionId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/regions/{region_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return LoadBalancerRegionsGetRegion.OK(Serializer.deserialize content)
            | _ -> return LoadBalancerRegionsGetRegion.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Search for Load Balancing resources.
    ///</summary>
    member this.AccountLoadBalancerSearchSearchResources
        (
            accountId: string,
            ?query: string,
            ?references: string,
            ?page: float,
            ?perPage: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if query.IsSome then
                      RequestPart.query ("query", query.Value)
                  if references.IsSome then
                      RequestPart.query ("references", references.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/load_balancers/search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccountLoadBalancerSearchSearchResources.OK(Serializer.deserialize content)
            | _ -> return AccountLoadBalancerSearchSearchResources.BadRequest(Serializer.deserialize content)
        }
