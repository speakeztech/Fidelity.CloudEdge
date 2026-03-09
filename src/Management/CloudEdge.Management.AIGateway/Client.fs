namespace rec Fidelity.CloudEdge.Management.AIGateway

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.AIGateway.Types
open Fidelity.CloudEdge.Management.AIGateway.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type AIGatewayClient(httpClient: HttpClient) =
    ///<summary>
    ///List Evaluators
    ///</summary>
    member this.AigConfigListEvaluators
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?orderBy: string,
            ?orderByDirection: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if orderByDirection.IsSome then
                      RequestPart.query ("order_by_direction", orderByDirection.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/evaluation-types"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigListEvaluators.OK(Serializer.deserialize content)
            | _ -> return AigConfigListEvaluators.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all AI Gateway evaluator types configured for the account.
    ///</summary>
    member this.AigConfigListGateway
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigListGateway.OK(Serializer.deserialize content)
            | _ -> return AigConfigListGateway.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new AI Gateway.
    ///</summary>
    member this.AigConfigCreateGateway
        (
            accountId: string,
            body: AigConfigCreateGatewayPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigCreateGateway.OK(Serializer.deserialize content)
            | _ -> return AigConfigCreateGateway.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all AI Gateway evaluator types configured for the account.
    ///</summary>
    member this.AigConfigListDataset
        (
            accountId: string,
            gatewayId: string,
            ?page: int,
            ?perPage: int,
            ?name: string,
            ?enable: bool,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if enable.IsSome then
                      RequestPart.query ("enable", enable.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/datasets"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigListDataset.OK(Serializer.deserialize content)
            | _ -> return AigConfigListDataset.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new AI Gateway.
    ///</summary>
    member this.AigConfigCreateDataset
        (
            gatewayId: string,
            accountId: string,
            body: AigConfigCreateDatasetPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/datasets"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigCreateDataset.OK(Serializer.deserialize content)
            | _ -> return AigConfigCreateDataset.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an AI Gateway dataset.
    ///</summary>
    member this.AigConfigDeleteDataset
        (
            accountId: string,
            gatewayId: string,
            id: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/datasets/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigDeleteDataset.OK(Serializer.deserialize content)
            | _ -> return AigConfigDeleteDataset.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific AI Gateway dataset.
    ///</summary>
    member this.AigConfigFetchDataset
        (
            accountId: string,
            gatewayId: string,
            id: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/datasets/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigFetchDataset.OK(Serializer.deserialize content)
            | _ -> return AigConfigFetchDataset.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing AI Gateway dataset.
    ///</summary>
    member this.AigConfigUpdateDataset
        (
            accountId: string,
            gatewayId: string,
            id: string,
            body: AigConfigUpdateDatasetPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/datasets/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigUpdateDataset.OK(Serializer.deserialize content)
            | 400 -> return AigConfigUpdateDataset.BadRequest(Serializer.deserialize content)
            | _ -> return AigConfigUpdateDataset.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all AI Gateway evaluator types configured for the account.
    ///</summary>
    member this.AigConfigListEvaluations
        (
            accountId: string,
            gatewayId: string,
            ?page: int,
            ?perPage: int,
            ?name: string,
            ?processed: bool,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if processed.IsSome then
                      RequestPart.query ("processed", processed.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/evaluations"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigListEvaluations.OK(Serializer.deserialize content)
            | _ -> return AigConfigListEvaluations.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new AI Gateway.
    ///</summary>
    member this.AigConfigCreateEvaluations
        (
            gatewayId: string,
            accountId: string,
            body: AigConfigCreateEvaluationsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/evaluations"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigCreateEvaluations.OK(Serializer.deserialize content)
            | _ -> return AigConfigCreateEvaluations.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an AI Gateway dataset.
    ///</summary>
    member this.AigConfigDeleteEvaluations
        (
            accountId: string,
            gatewayId: string,
            id: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/evaluations/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigDeleteEvaluations.OK(Serializer.deserialize content)
            | _ -> return AigConfigDeleteEvaluations.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific AI Gateway dataset.
    ///</summary>
    member this.AigConfigFetchEvaluations
        (
            accountId: string,
            gatewayId: string,
            id: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/evaluations/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigFetchEvaluations.OK(Serializer.deserialize content)
            | _ -> return AigConfigFetchEvaluations.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete Gateway Logs
    ///</summary>
    member this.AigConfigDeleteGatewayLogs
        (
            accountId: string,
            gatewayId: string,
            ?orderBy: string,
            ?orderByDirection: string,
            ?filters: string,
            ?limit: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if orderByDirection.IsSome then
                      RequestPart.query ("order_by_direction", orderByDirection.Value)
                  if filters.IsSome then
                      RequestPart.query ("filters", filters.Value)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigDeleteGatewayLogs.OK(Serializer.deserialize content)
            | _ -> return AigConfigDeleteGatewayLogs.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List Gateway Logs
    ///</summary>
    member this.AigConfigListGatewayLogs
        (
            accountId: string,
            gatewayId: string,
            ?search: string,
            ?page: int,
            ?perPage: int,
            ?orderBy: string,
            ?orderByDirection: string,
            ?filters: string,
            ?metaInfo: bool,
            ?direction: string,
            ?startDate: System.DateTimeOffset,
            ?endDate: System.DateTimeOffset,
            ?minCost: float,
            ?maxCost: float,
            ?minTokensIn: float,
            ?maxTokensIn: float,
            ?minTokensOut: float,
            ?maxTokensOut: float,
            ?minTotalTokens: float,
            ?maxTotalTokens: float,
            ?minDuration: float,
            ?maxDuration: float,
            ?feedback: string,
            ?success: bool,
            ?cached: bool,
            ?model: string,
            ?modelType: string,
            ?provider: string,
            ?requestContentType: string,
            ?responseContentType: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if orderByDirection.IsSome then
                      RequestPart.query ("order_by_direction", orderByDirection.Value)
                  if filters.IsSome then
                      RequestPart.query ("filters", filters.Value)
                  if metaInfo.IsSome then
                      RequestPart.query ("meta_info", metaInfo.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if startDate.IsSome then
                      RequestPart.query ("start_date", startDate.Value)
                  if endDate.IsSome then
                      RequestPart.query ("end_date", endDate.Value)
                  if minCost.IsSome then
                      RequestPart.query ("min_cost", minCost.Value)
                  if maxCost.IsSome then
                      RequestPart.query ("max_cost", maxCost.Value)
                  if minTokensIn.IsSome then
                      RequestPart.query ("min_tokens_in", minTokensIn.Value)
                  if maxTokensIn.IsSome then
                      RequestPart.query ("max_tokens_in", maxTokensIn.Value)
                  if minTokensOut.IsSome then
                      RequestPart.query ("min_tokens_out", minTokensOut.Value)
                  if maxTokensOut.IsSome then
                      RequestPart.query ("max_tokens_out", maxTokensOut.Value)
                  if minTotalTokens.IsSome then
                      RequestPart.query ("min_total_tokens", minTotalTokens.Value)
                  if maxTotalTokens.IsSome then
                      RequestPart.query ("max_total_tokens", maxTotalTokens.Value)
                  if minDuration.IsSome then
                      RequestPart.query ("min_duration", minDuration.Value)
                  if maxDuration.IsSome then
                      RequestPart.query ("max_duration", maxDuration.Value)
                  if feedback.IsSome then
                      RequestPart.query ("feedback", feedback.Value)
                  if success.IsSome then
                      RequestPart.query ("success", success.Value)
                  if cached.IsSome then
                      RequestPart.query ("cached", cached.Value)
                  if model.IsSome then
                      RequestPart.query ("model", model.Value)
                  if modelType.IsSome then
                      RequestPart.query ("model_type", modelType.Value)
                  if provider.IsSome then
                      RequestPart.query ("provider", provider.Value)
                  if requestContentType.IsSome then
                      RequestPart.query ("request_content_type", requestContentType.Value)
                  if responseContentType.IsSome then
                      RequestPart.query ("response_content_type", responseContentType.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigListGatewayLogs.OK(Serializer.deserialize content)
            | _ -> return AigConfigListGatewayLogs.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves detailed information for a specific AI Gateway log entry.
    ///</summary>
    member this.AigConfigGetGatewayLogDetail
        (
            id: string,
            gatewayId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/logs/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigGetGatewayLogDetail.OK(Serializer.deserialize content)
            | _ -> return AigConfigGetGatewayLogDetail.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates metadata for an AI Gateway log entry.
    ///</summary>
    member this.AigConfigPatchGatewayLog
        (
            id: string,
            gatewayId: string,
            accountId: string,
            body: AigConfigPatchGatewayLogPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/logs/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigPatchGatewayLog.OK(Serializer.deserialize content)
            | _ -> return AigConfigPatchGatewayLog.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves the original request payload for an AI Gateway log entry.
    ///</summary>
    member this.AigConfigGetGatewayLogRequest
        (
            id: string,
            gatewayId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/logs/{id}/request"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigGetGatewayLogRequest.OK(Serializer.deserialize content)
            | _ -> return AigConfigGetGatewayLogRequest.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves the response payload for an AI Gateway log entry.
    ///</summary>
    member this.AigConfigGetGatewayLogResponse
        (
            id: string,
            gatewayId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/logs/{id}/response"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigGetGatewayLogResponse.OK(Serializer.deserialize content)
            | _ -> return AigConfigGetGatewayLogResponse.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all AI Gateway evaluator types configured for the account.
    ///</summary>
    member this.AigConfigListProviders
        (
            accountId: string,
            gatewayId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/provider_configs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigListProviders.OK(Serializer.deserialize content)
            | _ -> return AigConfigListProviders.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new AI Gateway.
    ///</summary>
    member this.AigConfigCreateProviders
        (
            accountId: string,
            gatewayId: string,
            body: AigConfigCreateProvidersPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/provider_configs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigCreateProviders.OK(Serializer.deserialize content)
            | _ -> return AigConfigCreateProviders.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an AI Gateway dataset.
    ///</summary>
    member this.AigConfigDeleteProviders
        (
            accountId: string,
            gatewayId: string,
            id: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/provider_configs/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigDeleteProviders.OK(Serializer.deserialize content)
            | _ -> return AigConfigDeleteProviders.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing AI Gateway dataset.
    ///</summary>
    member this.AigConfigUpdateProviders
        (
            accountId: string,
            gatewayId: string,
            id: string,
            body: AigConfigUpdateProvidersPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/provider_configs/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigUpdateProviders.OK(Serializer.deserialize content)
            | 400 -> return AigConfigUpdateProviders.BadRequest(Serializer.deserialize content)
            | _ -> return AigConfigUpdateProviders.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///List all AI Gateway Dynamic Routes.
    ///</summary>
    member this.AigConfigListGatewayDynamicRoutes
        (
            accountId: string,
            gatewayId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigListGatewayDynamicRoutes.OK(Serializer.deserialize content)
            | _ -> return AigConfigListGatewayDynamicRoutes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new AI Gateway Dynamic Route.
    ///</summary>
    member this.AigConfigPostGatewayDynamicRoute
        (
            accountId: string,
            gatewayId: string,
            body: AigConfigPostGatewayDynamicRoutePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigPostGatewayDynamicRoute.OK(Serializer.deserialize content)
            | _ -> return AigConfigPostGatewayDynamicRoute.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete an AI Gateway Dynamic Route.
    ///</summary>
    member this.AigConfigDeleteGatewayDynamicRoute
        (
            accountId: string,
            gatewayId: string,
            id: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigDeleteGatewayDynamicRoute.OK(Serializer.deserialize content)
            | _ -> return AigConfigDeleteGatewayDynamicRoute.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get an AI Gateway Dynamic Route.
    ///</summary>
    member this.AigConfigGetGatewayDynamicRoute
        (
            accountId: string,
            gatewayId: string,
            id: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigGetGatewayDynamicRoute.OK(Serializer.deserialize content)
            | _ -> return AigConfigGetGatewayDynamicRoute.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update an AI Gateway Dynamic Route.
    ///</summary>
    member this.AigConfigUpdateGatewayDynamicRoute
        (
            accountId: string,
            gatewayId: string,
            id: string,
            body: AigConfigUpdateGatewayDynamicRoutePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigUpdateGatewayDynamicRoute.OK(Serializer.deserialize content)
            | _ -> return AigConfigUpdateGatewayDynamicRoute.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all AI Gateway Dynamic Route Deployments.
    ///</summary>
    member this.AigConfigListGatewayDynamicRouteDeployments
        (
            accountId: string,
            gatewayId: string,
            id: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes/{id}/deployments"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigListGatewayDynamicRouteDeployments.OK(Serializer.deserialize content)
            | _ -> return AigConfigListGatewayDynamicRouteDeployments.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new AI Gateway Dynamic Route Deployment.
    ///</summary>
    member this.AigConfigPostGatewayDynamicRouteDeployment
        (
            accountId: string,
            gatewayId: string,
            id: string,
            body: AigConfigPostGatewayDynamicRouteDeploymentPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes/{id}/deployments"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigPostGatewayDynamicRouteDeployment.OK(Serializer.deserialize content)
            | _ -> return AigConfigPostGatewayDynamicRouteDeployment.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all AI Gateway Dynamic Route Versions.
    ///</summary>
    member this.AigConfigListGatewayDynamicRouteVersions
        (
            accountId: string,
            gatewayId: string,
            id: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes/{id}/versions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigListGatewayDynamicRouteVersions.OK(Serializer.deserialize content)
            | _ -> return AigConfigListGatewayDynamicRouteVersions.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new AI Gateway Dynamic Route Version.
    ///</summary>
    member this.AigConfigPostGatewayDynamicRouteVersion
        (
            accountId: string,
            gatewayId: string,
            id: string,
            body: AigConfigPostGatewayDynamicRouteVersionPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes/{id}/versions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigPostGatewayDynamicRouteVersion.OK(Serializer.deserialize content)
            | _ -> return AigConfigPostGatewayDynamicRouteVersion.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get an AI Gateway Dynamic Route Version.
    ///</summary>
    member this.AigConfigGetGatewayDynamicRouteVersion
        (
            accountId: string,
            gatewayId: string,
            id: string,
            versionId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("id", id)
                  RequestPart.path ("version_id", versionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/routes/{id}/versions/{version_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigGetGatewayDynamicRouteVersion.OK(Serializer.deserialize content)
            | _ -> return AigConfigGetGatewayDynamicRouteVersion.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves the endpoint URL for an AI Gateway.
    ///</summary>
    member this.AigConfigGetGatewayUrl
        (
            gatewayId: string,
            accountId: string,
            provider: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("gateway_id", gatewayId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("provider", provider) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{gateway_id}/url/{provider}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigGetGatewayUrl.OK(Serializer.deserialize content)
            | _ -> return AigConfigGetGatewayUrl.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an AI Gateway dataset.
    ///</summary>
    member this.AigConfigDeleteGateway(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigDeleteGateway.OK(Serializer.deserialize content)
            | _ -> return AigConfigDeleteGateway.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific AI Gateway dataset.
    ///</summary>
    member this.AigConfigFetchGateway(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigFetchGateway.OK(Serializer.deserialize content)
            | _ -> return AigConfigFetchGateway.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing AI Gateway dataset.
    ///</summary>
    member this.AigConfigUpdateGateway
        (
            accountId: string,
            id: string,
            body: AigConfigUpdateGatewayPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-gateway/gateways/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AigConfigUpdateGateway.OK(Serializer.deserialize content)
            | 400 -> return AigConfigUpdateGateway.BadRequest(Serializer.deserialize content)
            | _ -> return AigConfigUpdateGateway.NotFound(Serializer.deserialize content)
        }
