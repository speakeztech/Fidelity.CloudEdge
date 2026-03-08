namespace rec Fidelity.CloudEdge.Management.AI

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.AI.Types
open Fidelity.CloudEdge.Management.AI.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type AIClient(httpClient: HttpClient) =
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
            ?filters: list<Newtonsoft.Json.Linq.JObject>,
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
                      RequestPart.query ("filters", Newtonsoft.Json.JsonConvert.SerializeObject(filters.Value))
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
            ?filters: list<Newtonsoft.Json.Linq.JObject>,
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
                      RequestPart.query ("filters", Newtonsoft.Json.JsonConvert.SerializeObject(filters.Value))
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

    ///<summary>
    ///List instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="search">Search by id</param>
    ///<param name="orderBy">Order By Column Name</param>
    ///<param name="orderByDirection">Order By Direction</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchListInstances
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
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
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if orderByDirection.IsSome then
                      RequestPart.query ("order_by_direction", orderByDirection.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchListInstances.OK(Serializer.deserialize content)
            | _ -> return AiSearchListInstances.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new instances.
    ///</summary>
    member this.AiSearchCreateInstances
        (
            accountId: string,
            body: AiSearchCreateInstancesPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return AiSearchCreateInstances.Created(Serializer.deserialize content)
            | _ -> return AiSearchCreateInstances.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchDeleteInstances(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchDeleteInstances.OK(Serializer.deserialize content)
            | _ -> return AiSearchDeleteInstances.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Read instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchFetchInstances(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchFetchInstances.OK(Serializer.deserialize content)
            | 400 -> return AiSearchFetchInstances.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchFetchInstances.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchUpdateInstances
        (
            accountId: string,
            id: string,
            body: AiSearchUpdateInstancesPayload,
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
                    "/accounts/{account_id}/ai-search/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchUpdateInstances.OK(Serializer.deserialize content)
            | 400 -> return AiSearchUpdateInstances.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchUpdateInstances.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Performs a chat completion request against an AI Search instance, using indexed content as context for generating responses.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceChatCompletion
        (
            id: string,
            accountId: string,
            body: AiSearchInstanceChatCompletionPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/chat/completions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceChatCompletion.OK(Serializer.deserialize content)
            | _ -> return AiSearchInstanceChatCompletion.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists indexing jobs for an AI Search instance.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceListJobs
        (
            id: string,
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceListJobs.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceListJobs.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceListJobs.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new indexing job for an AI Search instance.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceCreateJob
        (
            id: string,
            accountId: string,
            body: AiSearchInstanceCreateJobPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceCreateJob.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceCreateJob.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceCreateJob.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific AI Search indexing job.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceGetJob
        (
            id: string,
            jobId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceGetJob.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceGetJob.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceGetJob.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the status of an AI Search indexing job.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceChangeJobStatus
        (
            id: string,
            jobId: string,
            accountId: string,
            body: AiSearchInstanceChangeJobStatusPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceChangeJobStatus.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceChangeJobStatus.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceChangeJobStatus.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists log entries for an AI Search indexing job.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceListJobLogs
        (
            id: string,
            jobId: string,
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs/{job_id}/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceListJobLogs.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceListJobLogs.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceListJobLogs.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Executes a semantic search query against an AI Search instance to find relevant indexed content.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceSearch
        (
            id: string,
            accountId: string,
            body: AiSearchInstanceSearchPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceSearch.OK(Serializer.deserialize content)
            | _ -> return AiSearchInstanceSearch.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves usage statistics for AI Search instances.
    ///</summary>
    ///<param name="id">Use your AI Search ID.</param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchStats(id: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/stats"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchStats.OK(Serializer.deserialize content)
            | _ -> return AiSearchStats.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///List tokens.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="orderBy">Order By Column Name</param>
    ///<param name="orderByDirection">Order By Direction</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchListTokens
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
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/ai-search/tokens" requestParts cancellationToken

            match int status with
            | 200 -> return AiSearchListTokens.OK(Serializer.deserialize content)
            | _ -> return AiSearchListTokens.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new tokens.
    ///</summary>
    member this.AiSearchCreateTokens
        (
            accountId: string,
            body: AiSearchCreateTokensPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return AiSearchCreateTokens.Created(Serializer.deserialize content)
            | _ -> return AiSearchCreateTokens.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete tokens.
    ///</summary>
    member this.AiSearchDeleteTokens(accountId: string, id: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchDeleteTokens.OK(Serializer.deserialize content)
            | _ -> return AiSearchDeleteTokens.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Read tokens.
    ///</summary>
    member this.AiSearchFetchTokens(accountId: string, id: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchFetchTokens.OK(Serializer.deserialize content)
            | 400 -> return AiSearchFetchTokens.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchFetchTokens.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update tokens.
    ///</summary>
    member this.AiSearchUpdateTokens
        (
            accountId: string,
            id: System.Guid,
            body: AiSearchUpdateTokensPayload,
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
                    "/accounts/{account_id}/ai-search/tokens/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchUpdateTokens.OK(Serializer.deserialize content)
            | 400 -> return AiSearchUpdateTokens.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchUpdateTokens.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Author Search
    ///</summary>
    member this.WorkersAiSearchAuthor(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/authors/search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiSearchAuthor.OK(Serializer.deserialize content)
            | _ -> return WorkersAiSearchAuthor.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List Finetunes
    ///</summary>
    member this.WorkersAiListFinetunes(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/ai/finetunes" requestParts cancellationToken

            match int status with
            | 200 -> return WorkersAiListFinetunes.OK(Serializer.deserialize content)
            | _ -> return WorkersAiListFinetunes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Finetune
    ///</summary>
    member this.WorkersAiCreateFinetune
        (
            accountId: string,
            body: WorkersAiCreateFinetunePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/ai/finetunes" requestParts cancellationToken

            match int status with
            | 200 -> return WorkersAiCreateFinetune.OK(Serializer.deserialize content)
            | _ -> return WorkersAiCreateFinetune.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List Public Finetunes
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="limit">Pagination Limit</param>
    ///<param name="offset">Pagination Offset</param>
    ///<param name="orderBy">Order By Column Name</param>
    ///<param name="cancellationToken"></param>
    member this.WorkersAiListPublicFinetunes
        (
            accountId: string,
            ?limit: float,
            ?offset: float,
            ?orderBy: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if offset.IsSome then
                      RequestPart.query ("offset", offset.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("orderBy", orderBy.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/finetunes/public"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiListPublicFinetunes.OK(Serializer.deserialize content)
            | _ -> return WorkersAiListPublicFinetunes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Upload a Finetune Asset
    ///</summary>
    member this.WorkersAiUploadFinetuneAsset
        (
            accountId: string,
            finetuneId: string,
            body: WorkersAiUploadFinetuneAssetPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("finetune_id", finetuneId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/finetunes/{finetune_id}/finetune-assets"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiUploadFinetuneAsset.OK(Serializer.deserialize content)
            | _ -> return WorkersAiUploadFinetuneAsset.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves the input and output JSON schema definition for a Workers AI model.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="model">Model Name</param>
    ///<param name="cancellationToken"></param>
    member this.WorkersAiGetModelSchema(accountId: string, model: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.query ("model", model) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/ai/models/schema" requestParts cancellationToken

            match int status with
            | 200 -> return WorkersAiGetModelSchema.OK(Serializer.deserialize content)
            | _ -> return WorkersAiGetModelSchema.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Model Search
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="perPage"></param>
    ///<param name="page"></param>
    ///<param name="task">Filter by Task Name</param>
    ///<param name="author">Filter by Author</param>
    ///<param name="source">Filter by Source Id</param>
    ///<param name="hideExperimental">Filter to hide experimental models</param>
    ///<param name="search">Search</param>
    ///<param name="cancellationToken"></param>
    member this.WorkersAiSearchModel
        (
            accountId: string,
            ?perPage: int,
            ?page: int,
            ?task: string,
            ?author: string,
            ?source: float,
            ?hideExperimental: bool,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if task.IsSome then
                      RequestPart.query ("task", task.Value)
                  if author.IsSome then
                      RequestPart.query ("author", author.Value)
                  if source.IsSome then
                      RequestPart.query ("source", source.Value)
                  if hideExperimental.IsSome then
                      RequestPart.query ("hide_experimental", hideExperimental.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/ai/models/search" requestParts cancellationToken

            match int status with
            | 200 -> return WorkersAiSearchModel.OK(Serializer.deserialize content)
            | _ -> return WorkersAiSearchModel.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/ai4bharat/indictrans2-en-indic-1B model.
    ///</summary>
    member this.WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B
        (
            accountId: string,
            body: WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1BPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/ai4bharat/indictrans2-en-indic-1B"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/ai4bharat/omni-indictrans2-en-indic-1b model.
    ///</summary>
    member this.WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1b
        (
            accountId: string,
            body: WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1bPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/ai4bharat/omni-indictrans2-en-indic-1b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/aisingapore/gemma-sea-lion-v4-27b-it model.
    ///</summary>
    member this.WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/aisingapore/gemma-sea-lion-v4-27b-it"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/bge-base-en-v1.5 model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiBgeBaseEnV15
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/bge-base-en-v1.5"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiBgeBaseEnV15.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiBgeBaseEnV15.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/bge-large-en-v1.5 model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiBgeLargeEnV15
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/bge-large-en-v1.5"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiBgeLargeEnV15.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiBgeLargeEnV15.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/bge-m3 model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiBgeM3
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/bge-m3"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiBgeM3.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiBgeM3.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/bge-reranker-base model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiBgeRerankerBase
        (
            accountId: string,
            body: WorkersAiPostRunCfBaaiBgeRerankerBasePayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/bge-reranker-base"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiBgeRerankerBase.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiBgeRerankerBase.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/bge-small-en-v1.5 model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiBgeSmallEnV15
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/bge-small-en-v1.5"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiBgeSmallEnV15.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiBgeSmallEnV15.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/omni-bge-base-en-v1.5 model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiOmniBgeBaseEnV15
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/omni-bge-base-en-v1.5"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiOmniBgeBaseEnV15.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiOmniBgeBaseEnV15.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/omni-bge-large-en-v1.5 model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiOmniBgeLargeEnV15
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/omni-bge-large-en-v1.5"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiOmniBgeLargeEnV15.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiOmniBgeLargeEnV15.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/omni-bge-m3 model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiOmniBgeM3
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/omni-bge-m3"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiOmniBgeM3.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiOmniBgeM3.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/omni-bge-small-en-v1.5 model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiOmniBgeSmallEnV15
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/omni-bge-small-en-v1.5"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiOmniBgeSmallEnV15.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiOmniBgeSmallEnV15.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/baai/ray-bge-large-en-v1.5 model.
    ///</summary>
    member this.WorkersAiPostRunCfBaaiRayBgeLargeEnV15
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/baai/ray-bge-large-en-v1.5"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBaaiRayBgeLargeEnV15.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBaaiRayBgeLargeEnV15.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/black-forest-labs/flux-1-schnell model.
    ///</summary>
    member this.WorkersAiPostRunCfBlackForestLabsFlux1Schnell
        (
            accountId: string,
            body: WorkersAiPostRunCfBlackForestLabsFlux1SchnellPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/black-forest-labs/flux-1-schnell"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBlackForestLabsFlux1Schnell.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBlackForestLabsFlux1Schnell.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/black-forest-labs/flux-2-dev model.
    ///</summary>
    member this.WorkersAiPostRunCfBlackForestLabsFlux2Dev
        (
            accountId: string,
            body: WorkersAiPostRunCfBlackForestLabsFlux2DevPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/black-forest-labs/flux-2-dev"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBlackForestLabsFlux2Dev.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBlackForestLabsFlux2Dev.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/black-forest-labs/flux-2-klein-4b model.
    ///</summary>
    member this.WorkersAiPostRunCfBlackForestLabsFlux2Klein4b
        (
            accountId: string,
            body: WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/black-forest-labs/flux-2-klein-4b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBlackForestLabsFlux2Klein4b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBlackForestLabsFlux2Klein4b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/black-forest-labs/flux-2-klein-9b model.
    ///</summary>
    member this.WorkersAiPostRunCfBlackForestLabsFlux2Klein9b
        (
            accountId: string,
            body: WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/black-forest-labs/flux-2-klein-9b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBlackForestLabsFlux2Klein9b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfBlackForestLabsFlux2Klein9b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/bytedance/stable-diffusion-xl-lightning model.
    ///</summary>
    member this.WorkersAiPostRunCfBytedanceStableDiffusionXlLightning
        (
            accountId: string,
            body: WorkersAiPostRunCfBytedanceStableDiffusionXlLightningPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/bytedance/stable-diffusion-xl-lightning"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfBytedanceStableDiffusionXlLightning.OK(Serializer.deserialize content)
            | _ ->
                return WorkersAiPostRunCfBytedanceStableDiffusionXlLightning.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/deepgram/aura model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfDeepgramAura(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/aura"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfDeepgramAura.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfDeepgramAura.DefaultResponse
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/deepgram/aura-1 model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfDeepgramAura1(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/aura-1"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfDeepgramAura1.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfDeepgramAura1.DefaultResponse
        }

    ///<summary>
    ///Runs inference on the @cf/deepgram/aura-1 model.
    ///</summary>
    member this.WorkersAiPostRunCfDeepgramAura1
        (
            accountId: string,
            body: WorkersAiPostRunCfDeepgramAura1Payload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/aura-1"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfDeepgramAura1.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfDeepgramAura1.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/deepgram/aura-1-internal model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfDeepgramAura1Internal
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
                    "/accounts/{account_id}/ai/run/@cf/deepgram/aura-1-internal"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfDeepgramAura1Internal.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfDeepgramAura1Internal.DefaultResponse
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/deepgram/aura-2 model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfDeepgramAura2(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/aura-2"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfDeepgramAura2.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfDeepgramAura2.DefaultResponse
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/deepgram/aura-2-en model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfDeepgramAura2En(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/aura-2-en"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfDeepgramAura2En.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfDeepgramAura2En.DefaultResponse
        }

    ///<summary>
    ///Runs inference on the @cf/deepgram/aura-2-en model.
    ///</summary>
    member this.WorkersAiPostRunCfDeepgramAura2En
        (
            accountId: string,
            body: WorkersAiPostRunCfDeepgramAura2EnPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/aura-2-en"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfDeepgramAura2En.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfDeepgramAura2En.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/deepgram/aura-2-es model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfDeepgramAura2Es(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/aura-2-es"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfDeepgramAura2Es.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfDeepgramAura2Es.DefaultResponse
        }

    ///<summary>
    ///Runs inference on the @cf/deepgram/aura-2-es model.
    ///</summary>
    member this.WorkersAiPostRunCfDeepgramAura2Es
        (
            accountId: string,
            body: WorkersAiPostRunCfDeepgramAura2EsPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/aura-2-es"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfDeepgramAura2Es.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfDeepgramAura2Es.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/deepgram/flux model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfDeepgramFlux(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/flux"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfDeepgramFlux.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfDeepgramFlux.DefaultResponse
        }

    ///<summary>
    ///Runs inference on the @cf/deepgram/flux model.
    ///</summary>
    member this.WorkersAiPostRunCfDeepgramFlux
        (
            accountId: string,
            body: WorkersAiPostRunCfDeepgramFluxPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/flux"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfDeepgramFlux.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfDeepgramFlux.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/deepgram/nova-3 model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfDeepgramNova3(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/nova-3"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfDeepgramNova3.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfDeepgramNova3.DefaultResponse
        }

    ///<summary>
    ///Runs inference on the @cf/deepgram/nova-3 model.
    ///</summary>
    member this.WorkersAiPostRunCfDeepgramNova3
        (
            accountId: string,
            body: WorkersAiPostRunCfDeepgramNova3Payload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepgram/nova-3"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfDeepgramNova3.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfDeepgramNova3.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/deepgram/nova-3-internal model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfDeepgramNova3Internal
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
                    "/accounts/{account_id}/ai/run/@cf/deepgram/nova-3-internal"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfDeepgramNova3Internal.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfDeepgramNova3Internal.DefaultResponse
        }

    ///<summary>
    ///Runs inference on the @cf/deepseek-ai/deepseek-math-7b-instruct model.
    ///</summary>
    member this.WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepseek-ai/deepseek-math-7b-instruct"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/deepseek-ai/deepseek-r1-distill-qwen-32b model.
    ///</summary>
    member this.WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b.OK(Serializer.deserialize content)
            | _ ->
                return WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/defog/sqlcoder-7b-2 model.
    ///</summary>
    member this.WorkersAiPostRunCfDefogSqlcoder7b2
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/defog/sqlcoder-7b-2"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfDefogSqlcoder7b2.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfDefogSqlcoder7b2.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/facebook/bart-large-cnn model.
    ///</summary>
    member this.WorkersAiPostRunCfFacebookBartLargeCnn
        (
            accountId: string,
            body: WorkersAiPostRunCfFacebookBartLargeCnnPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/facebook/bart-large-cnn"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfFacebookBartLargeCnn.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfFacebookBartLargeCnn.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/facebook/nonomni-bart-large-cnn model.
    ///</summary>
    member this.WorkersAiPostRunCfFacebookNonomniBartLargeCnn
        (
            accountId: string,
            body: WorkersAiPostRunCfFacebookNonomniBartLargeCnnPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/facebook/nonomni-bart-large-cnn"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfFacebookNonomniBartLargeCnn.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfFacebookNonomniBartLargeCnn.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/facebook/nonomni-detr-resnet-50 model.
    ///</summary>
    member this.WorkersAiPostRunCfFacebookNonomniDetrResnet50
        (
            accountId: string,
            body: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/facebook/nonomni-detr-resnet-50"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfFacebookNonomniDetrResnet50.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfFacebookNonomniDetrResnet50.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/fblgit/una-cybertron-7b-v2-bf16 model.
    ///</summary>
    member this.WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/fblgit/una-cybertron-7b-v2-bf16"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/google/embeddinggemma-300m model.
    ///</summary>
    member this.WorkersAiPostRunCfGoogleEmbeddinggemma300m
        (
            accountId: string,
            body: WorkersAiPostRunCfGoogleEmbeddinggemma300mPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/google/embeddinggemma-300m"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfGoogleEmbeddinggemma300m.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfGoogleEmbeddinggemma300m.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/google/gemma-2b-it-lora model.
    ///</summary>
    member this.WorkersAiPostRunCfGoogleGemma2bItLora
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/google/gemma-2b-it-lora"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfGoogleGemma2bItLora.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfGoogleGemma2bItLora.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/google/gemma-3-12b-it model.
    ///</summary>
    member this.WorkersAiPostRunCfGoogleGemma312bIt
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/google/gemma-3-12b-it"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfGoogleGemma312bIt.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfGoogleGemma312bIt.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/google/gemma-7b-it-lora model.
    ///</summary>
    member this.WorkersAiPostRunCfGoogleGemma7bItLora
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/google/gemma-7b-it-lora"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfGoogleGemma7bItLora.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfGoogleGemma7bItLora.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/google/omni-embeddinggemma-300m model.
    ///</summary>
    member this.WorkersAiPostRunCfGoogleOmniEmbeddinggemma300m
        (
            accountId: string,
            body: WorkersAiPostRunCfGoogleOmniEmbeddinggemma300mPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/google/omni-embeddinggemma-300m"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfGoogleOmniEmbeddinggemma300m.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfGoogleOmniEmbeddinggemma300m.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/huggingface/distilbert-sst-2-int8 model.
    ///</summary>
    member this.WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8
        (
            accountId: string,
            body: WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8Payload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/huggingface/distilbert-sst-2-int8"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/ibm-granite/granite-4.0-h-micro model.
    ///</summary>
    member this.WorkersAiPostRunCfIbmGraniteGranite40HMicro
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/ibm-granite/granite-4.0-h-micro"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfIbmGraniteGranite40HMicro.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfIbmGraniteGranite40HMicro.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/leonardo/lucid-origin model.
    ///</summary>
    member this.WorkersAiPostRunCfLeonardoLucidOrigin
        (
            accountId: string,
            body: WorkersAiPostRunCfLeonardoLucidOriginPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/leonardo/lucid-origin"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfLeonardoLucidOrigin.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfLeonardoLucidOrigin.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/leonardo/phoenix-1.0 model.
    ///</summary>
    member this.WorkersAiPostRunCfLeonardoPhoenix10
        (
            accountId: string,
            body: WorkersAiPostRunCfLeonardoPhoenix10Payload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/leonardo/phoenix-1.0"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfLeonardoPhoenix10.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfLeonardoPhoenix10.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/lykon/dreamshaper-8-lcm model.
    ///</summary>
    member this.WorkersAiPostRunCfLykonDreamshaper8Lcm
        (
            accountId: string,
            body: WorkersAiPostRunCfLykonDreamshaper8LcmPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/lykon/dreamshaper-8-lcm"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfLykonDreamshaper8Lcm.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfLykonDreamshaper8Lcm.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta-llama/llama-2-7b-chat-hf-lora model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta-llama/llama-2-7b-chat-hf-lora"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-2-7b-chat-fp16 model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama27bChatFp16
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-2-7b-chat-fp16"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama27bChatFp16.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama27bChatFp16.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-2-7b-chat-int8 model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama27bChatInt8
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-2-7b-chat-int8"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama27bChatInt8.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama27bChatInt8.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3-8b-instruct model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama38bInstruct
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3-8b-instruct"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama38bInstruct.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama38bInstruct.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3-8b-instruct-awq model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama38bInstructAwq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3-8b-instruct-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama38bInstructAwq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama38bInstructAwq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3.1-70b-instruct-fp8-fast model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3.1-70b-instruct-fp8-fast"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3.1-8b-instruct-awq model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama318bInstructAwq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3.1-8b-instruct-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama318bInstructAwq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama318bInstructAwq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3.1-8b-instruct-fp8 model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama318bInstructFp8
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3.1-8b-instruct-fp8"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama318bInstructFp8.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama318bInstructFp8.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3.1-8b-instruct-fp8-fast model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama318bInstructFp8Fast
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3.1-8b-instruct-fp8-fast"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama318bInstructFp8Fast.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama318bInstructFp8Fast.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3.2-11b-vision-instruct model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama3211bVisionInstruct
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3.2-11b-vision-instruct"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama3211bVisionInstruct.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama3211bVisionInstruct.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3.2-1b-instruct model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama321bInstruct
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3.2-1b-instruct"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama321bInstruct.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama321bInstruct.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3.2-3b-instruct model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama323bInstruct
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3.2-3b-instruct"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama323bInstruct.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama323bInstruct.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-3.3-70b-instruct-fp8-fast model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-3.3-70b-instruct-fp8-fast"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-4-scout-17b-16e-instruct model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-4-scout-17b-16e-instruct"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/llama-guard-3-8b model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaLlamaGuard38b
        (
            accountId: string,
            body: WorkersAiPostRunCfMetaLlamaGuard38bPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/llama-guard-3-8b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaLlamaGuard38b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaLlamaGuard38b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/meta/m2m100-1.2b model.
    ///</summary>
    member this.WorkersAiPostRunCfMetaM2m10012b
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/meta/m2m100-1.2b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMetaM2m10012b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMetaM2m10012b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/microsoft/nonomni-resnet-50 model.
    ///</summary>
    member this.WorkersAiPostRunCfMicrosoftNonomniResnet50
        (
            accountId: string,
            body: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/microsoft/nonomni-resnet-50"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMicrosoftNonomniResnet50.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMicrosoftNonomniResnet50.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/microsoft/phi-2 model.
    ///</summary>
    member this.WorkersAiPostRunCfMicrosoftPhi2
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/microsoft/phi-2"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMicrosoftPhi2.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMicrosoftPhi2.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/microsoft/resnet-50 model.
    ///</summary>
    member this.WorkersAiPostRunCfMicrosoftResnet50
        (
            accountId: string,
            body: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/microsoft/resnet-50"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMicrosoftResnet50.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMicrosoftResnet50.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/mistral/mistral-7b-instruct-v0.1 model.
    ///</summary>
    member this.WorkersAiPostRunCfMistralMistral7bInstructV01
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/mistral/mistral-7b-instruct-v0.1"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMistralMistral7bInstructV01.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMistralMistral7bInstructV01.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/mistral/mistral-7b-instruct-v0.2-lora model.
    ///</summary>
    member this.WorkersAiPostRunCfMistralMistral7bInstructV02Lora
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/mistral/mistral-7b-instruct-v0.2-lora"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMistralMistral7bInstructV02Lora.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMistralMistral7bInstructV02Lora.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/mistralai/mistral-small-3.1-24b-instruct model.
    ///</summary>
    member this.WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/mistralai/mistral-small-3.1-24b-instruct"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct.OK(Serializer.deserialize content)
            | _ ->
                return WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/myshell-ai/melotts model.
    ///</summary>
    member this.WorkersAiPostRunCfMyshellAiMelotts
        (
            accountId: string,
            body: WorkersAiPostRunCfMyshellAiMelottsPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/myshell-ai/melotts"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfMyshellAiMelotts.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfMyshellAiMelotts.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/openai/gpt-oss-120b model.
    ///</summary>
    member this.WorkersAiPostRunCfOpenaiGptOss120b
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/openai/gpt-oss-120b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfOpenaiGptOss120b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfOpenaiGptOss120b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/openai/gpt-oss-20b model.
    ///</summary>
    member this.WorkersAiPostRunCfOpenaiGptOss20b
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/openai/gpt-oss-20b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfOpenaiGptOss20b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfOpenaiGptOss20b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/openai/whisper model.
    ///</summary>
    member this.WorkersAiPostRunCfOpenaiWhisper
        (
            accountId: string,
            body: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/openai/whisper"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfOpenaiWhisper.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfOpenaiWhisper.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/openai/whisper-large-v3-turbo model.
    ///</summary>
    member this.WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo
        (
            accountId: string,
            body: WorkersAiPostRunCfOpenaiWhisperLargeV3TurboPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/openai/whisper-large-v3-turbo"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/openai/whisper-tiny-en model.
    ///</summary>
    member this.WorkersAiPostRunCfOpenaiWhisperTinyEn
        (
            accountId: string,
            body: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/openai/whisper-tiny-en"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfOpenaiWhisperTinyEn.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfOpenaiWhisperTinyEn.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/openchat/openchat-3.5-0106 model.
    ///</summary>
    member this.WorkersAiPostRunCfOpenchatOpenchat350106
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/openchat/openchat-3.5-0106"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfOpenchatOpenchat350106.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfOpenchatOpenchat350106.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/pfnet/plamo-embedding-1b model.
    ///</summary>
    member this.WorkersAiPostRunCfPfnetPlamoEmbedding1b
        (
            accountId: string,
            body: WorkersAiPostRunCfPfnetPlamoEmbedding1bPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/pfnet/plamo-embedding-1b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfPfnetPlamoEmbedding1b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfPfnetPlamoEmbedding1b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/pipecat-ai/smart-turn-v2 model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2
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
                    "/accounts/{account_id}/ai/run/@cf/pipecat-ai/smart-turn-v2"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2.DefaultResponse
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/pipecat-ai/smart-turn-v3 model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3
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
                    "/accounts/{account_id}/ai/run/@cf/pipecat-ai/smart-turn-v3"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3.DefaultResponse
        }

    ///<summary>
    ///Runs inference on the @cf/qwen/qwen1.5-0.5b-chat model.
    ///</summary>
    member this.WorkersAiPostRunCfQwenQwen1505bChat
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/qwen/qwen1.5-0.5b-chat"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfQwenQwen1505bChat.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfQwenQwen1505bChat.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/qwen/qwen1.5-1.8b-chat model.
    ///</summary>
    member this.WorkersAiPostRunCfQwenQwen1518bChat
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/qwen/qwen1.5-1.8b-chat"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfQwenQwen1518bChat.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfQwenQwen1518bChat.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/qwen/qwen1.5-14b-chat-awq model.
    ///</summary>
    member this.WorkersAiPostRunCfQwenQwen1514bChatAwq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/qwen/qwen1.5-14b-chat-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfQwenQwen1514bChatAwq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfQwenQwen1514bChatAwq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/qwen/qwen1.5-7b-chat-awq model.
    ///</summary>
    member this.WorkersAiPostRunCfQwenQwen157bChatAwq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/qwen/qwen1.5-7b-chat-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfQwenQwen157bChatAwq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfQwenQwen157bChatAwq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/qwen/qwen2.5-coder-32b-instruct model.
    ///</summary>
    member this.WorkersAiPostRunCfQwenQwen25Coder32bInstruct
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/qwen/qwen2.5-coder-32b-instruct"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfQwenQwen25Coder32bInstruct.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfQwenQwen25Coder32bInstruct.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/qwen/qwen3-30b-a3b-fp8 model.
    ///</summary>
    member this.WorkersAiPostRunCfQwenQwen330bA3bFp8
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/qwen/qwen3-30b-a3b-fp8"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfQwenQwen330bA3bFp8.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfQwenQwen330bA3bFp8.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/qwen/qwen3-embedding-0.6b model.
    ///</summary>
    member this.WorkersAiPostRunCfQwenQwen3Embedding06b
        (
            accountId: string,
            body: WorkersAiPostRunCfQwenQwen3Embedding06bPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/qwen/qwen3-embedding-0.6b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfQwenQwen3Embedding06b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfQwenQwen3Embedding06b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/qwen/qwq-32b model.
    ///</summary>
    member this.WorkersAiPostRunCfQwenQwq32b
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/qwen/qwq-32b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfQwenQwq32b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfQwenQwq32b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/runwayml/stable-diffusion-v1-5-img2img model.
    ///</summary>
    member this.WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img
        (
            accountId: string,
            body: WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2imgPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/runwayml/stable-diffusion-v1-5-img2img"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/runwayml/stable-diffusion-v1-5-inpainting model.
    ///</summary>
    member this.WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting
        (
            accountId: string,
            body: WorkersAiPostRunCfRunwaymlStableDiffusionV15InpaintingPayload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/runwayml/stable-diffusion-v1-5-inpainting"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting.OK(Serializer.deserialize content)
            | _ ->
                return WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/stabilityai/stable-diffusion-xl-base-1.0 model.
    ///</summary>
    member this.WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10
        (
            accountId: string,
            body: WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10Payload,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/stabilityai/stable-diffusion-xl-base-1.0"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10.OK(Serializer.deserialize content)
            | _ ->
                return WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/sven/test-pipe-http model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfSvenTestPipeHttp(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/sven/test-pipe-http"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfSvenTestPipeHttp.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfSvenTestPipeHttp.DefaultResponse
        }

    ///<summary>
    ///Opens a WebSocket connection to stream inference results from the @cf/test/hello-world-cog model.
    ///</summary>
    member this.WorkersAiPostWebsocketRunCfTestHelloWorldCog(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/test/hello-world-cog"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return WorkersAiPostWebsocketRunCfTestHelloWorldCog.BadRequest(Serializer.deserialize content)
            | _ -> return WorkersAiPostWebsocketRunCfTestHelloWorldCog.DefaultResponse
        }

    ///<summary>
    ///Runs inference on the @cf/thebloke/discolm-german-7b-v1-awq model.
    ///</summary>
    member this.WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/thebloke/discolm-german-7b-v1-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/tiiuae/falcon-7b-instruct model.
    ///</summary>
    member this.WorkersAiPostRunCfTiiuaeFalcon7bInstruct
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/tiiuae/falcon-7b-instruct"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfTiiuaeFalcon7bInstruct.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfTiiuaeFalcon7bInstruct.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/tinyllama/tinyllama-1.1b-chat-v1.0 model.
    ///</summary>
    member this.WorkersAiPostRunCfTinyllamaTinyllama11bChatV10
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/tinyllama/tinyllama-1.1b-chat-v1.0"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfTinyllamaTinyllama11bChatV10.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfTinyllamaTinyllama11bChatV10.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @cf/zai-org/glm-4.7-flash model.
    ///</summary>
    member this.WorkersAiPostRunCfZaiOrgGlm47Flash
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@cf/zai-org/glm-4.7-flash"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunCfZaiOrgGlm47Flash.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunCfZaiOrgGlm47Flash.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/google/gemma-7b-it model.
    ///</summary>
    member this.WorkersAiPostRunHfGoogleGemma7bIt
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/google/gemma-7b-it"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfGoogleGemma7bIt.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfGoogleGemma7bIt.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/mistral/mistral-7b-instruct-v0.2 model.
    ///</summary>
    member this.WorkersAiPostRunHfMistralMistral7bInstructV02
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/mistral/mistral-7b-instruct-v0.2"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfMistralMistral7bInstructV02.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfMistralMistral7bInstructV02.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/nexusflow/starling-lm-7b-beta model.
    ///</summary>
    member this.WorkersAiPostRunHfNexusflowStarlingLm7bBeta
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/nexusflow/starling-lm-7b-beta"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfNexusflowStarlingLm7bBeta.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfNexusflowStarlingLm7bBeta.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/nousresearch/hermes-2-pro-mistral-7b model.
    ///</summary>
    member this.WorkersAiPostRunHfNousresearchHermes2ProMistral7b
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/nousresearch/hermes-2-pro-mistral-7b"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfNousresearchHermes2ProMistral7b.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfNousresearchHermes2ProMistral7b.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/thebloke/deepseek-coder-6.7b-base-awq model.
    ///</summary>
    member this.WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/thebloke/deepseek-coder-6.7b-base-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/thebloke/deepseek-coder-6.7b-instruct-awq model.
    ///</summary>
    member this.WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/thebloke/deepseek-coder-6.7b-instruct-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq.OK(Serializer.deserialize content)
            | _ ->
                return WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/thebloke/llama-2-13b-chat-awq model.
    ///</summary>
    member this.WorkersAiPostRunHfTheblokeLlama213bChatAwq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/thebloke/llama-2-13b-chat-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfTheblokeLlama213bChatAwq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfTheblokeLlama213bChatAwq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/thebloke/mistral-7b-instruct-v0.1-awq model.
    ///</summary>
    member this.WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/thebloke/mistral-7b-instruct-v0.1-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/thebloke/neural-chat-7b-v3-1-awq model.
    ///</summary>
    member this.WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/thebloke/neural-chat-7b-v3-1-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/thebloke/openhermes-2.5-mistral-7b-awq model.
    ///</summary>
    member this.WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/thebloke/openhermes-2.5-mistral-7b-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Runs inference on the @hf/thebloke/zephyr-7b-beta-awq model.
    ///</summary>
    member this.WorkersAiPostRunHfTheblokeZephyr7bBetaAwq
        (
            accountId: string,
            ?queueRequest: string,
            ?tags: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if queueRequest.IsSome then
                      RequestPart.query ("queueRequest", queueRequest.Value)
                  if tags.IsSome then
                      RequestPart.query ("tags", tags.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/@hf/thebloke/zephyr-7b-beta-awq"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunHfTheblokeZephyr7bBetaAwq.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunHfTheblokeZephyr7bBetaAwq.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///This endpoint provides users with the capability to run specific AI models on-demand.
    ///By submitting the required input data, users can receive real-time predictions or results generated by the chosen AI
    ///model. The endpoint supports various AI model types, ensuring flexibility and adaptability for diverse use cases.
    ///Model specific inputs available in [Cloudflare Docs](https://developers.cloudflare.com/workers-ai/models/).
    ///</summary>
    member this.WorkersAiPostRunModel(accountId: string, modelName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("model_name", modelName) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai/run/{model_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiPostRunModel.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostRunModel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Task Search
    ///</summary>
    member this.WorkersAiSearchTask(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/ai/tasks/search" requestParts cancellationToken

            match int status with
            | 200 -> return WorkersAiSearchTask.OK(Serializer.deserialize content)
            | _ -> return WorkersAiSearchTask.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Converts uploaded files into Markdown format using Workers AI.
    ///</summary>
    member this.WorkersAiPostToMarkdown
        (
            accountId: string,
            body: WorkersAiPostToMarkdownPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/ai/tomarkdown" requestParts cancellationToken

            match int status with
            | 200 -> return WorkersAiPostToMarkdown.OK(Serializer.deserialize content)
            | _ -> return WorkersAiPostToMarkdown.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all file formats supported for conversion to Markdown.
    ///</summary>
    member this.WorkersAiGetToMarkdownSupported(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai/tomarkdown/supported"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorkersAiGetToMarkdownSupported.OK(Serializer.deserialize content)
            | _ -> return WorkersAiGetToMarkdownSupported.BadRequest(Serializer.deserialize content)
        }
