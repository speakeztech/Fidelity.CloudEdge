namespace rec Fidelity.CloudEdge.Management.Workflows

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Workflows.Types
open Fidelity.CloudEdge.Management.Workflows.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type WorkflowsClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists all workflows configured for the account.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="perPage"></param>
    ///<param name="page"></param>
    ///<param name="search">Allows filtering workflows` name.</param>
    ///<param name="cancellationToken"></param>
    member this.WorListWorkflows
        (
            accountId: string,
            ?perPage: float,
            ?page: float,
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
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/workflows" requestParts cancellationToken

            match int status with
            | 200 -> return WorListWorkflows.OK(Serializer.deserialize content)
            | _ -> return WorListWorkflows.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a Workflow. This only deletes the Workflow and does not delete or modify any Worker associated to this Workflow or bounded to it.
    ///</summary>
    member this.WorDeleteWorkflow(workflowName: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorDeleteWorkflow.OK(Serializer.deserialize content)
            | 400 -> return WorDeleteWorkflow.BadRequest(Serializer.deserialize content)
            | _ -> return WorDeleteWorkflow.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves configuration and metadata for a specific workflow.
    ///</summary>
    member this.WorGetWorkflowDetails(workflowName: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorGetWorkflowDetails.OK(Serializer.deserialize content)
            | 400 -> return WorGetWorkflowDetails.BadRequest(Serializer.deserialize content)
            | _ -> return WorGetWorkflowDetails.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new workflow or updates an existing workflow definition.
    ///</summary>
    member this.WorCreateOrModifyWorkflow
        (
            workflowName: string,
            accountId: string,
            body: WorCreateOrModifyWorkflowPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorCreateOrModifyWorkflow.OK(Serializer.deserialize content)
            | _ -> return WorCreateOrModifyWorkflow.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all instances of a workflow with their execution status.
    ///</summary>
    ///<param name="workflowName"></param>
    ///<param name="accountId"></param>
    ///<param name="page">`page` and `cursor` are mutually exclusive, use one or the other.</param>
    ///<param name="perPage"></param>
    ///<param name="cursor">`page` and `cursor` are mutually exclusive, use one or the other.</param>
    ///<param name="direction">should only be used when `cursor` is used, defines a new direction for the cursor</param>
    ///<param name="status"></param>
    ///<param name="dateStart">Accepts ISO 8601 with no timezone offsets and in UTC.</param>
    ///<param name="dateEnd">Accepts ISO 8601 with no timezone offsets and in UTC.</param>
    ///<param name="cancellationToken"></param>
    member this.WorListWorkflowInstances
        (
            workflowName: string,
            accountId: string,
            ?page: float,
            ?perPage: float,
            ?cursor: string,
            ?direction: string,
            ?status: string,
            ?dateStart: System.DateTimeOffset,
            ?dateEnd: System.DateTimeOffset,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if dateStart.IsSome then
                      RequestPart.query ("date_start", dateStart.Value)
                  if dateEnd.IsSome then
                      RequestPart.query ("date_end", dateEnd.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorListWorkflowInstances.OK(Serializer.deserialize content)
            | 400 -> return WorListWorkflowInstances.BadRequest(Serializer.deserialize content)
            | _ -> return WorListWorkflowInstances.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new instance of a workflow, starting its execution.
    ///</summary>
    member this.WorCreateNewWorkflowInstance
        (
            workflowName: string,
            accountId: string,
            body: WorCreateNewWorkflowInstancePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorCreateNewWorkflowInstance.OK(Serializer.deserialize content)
            | 400 -> return WorCreateNewWorkflowInstance.BadRequest(Serializer.deserialize content)
            | _ -> return WorCreateNewWorkflowInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates multiple workflow instances in a single batch operation.
    ///</summary>
    member this.WorBatchCreateWorkflowInstance
        (
            workflowName: string,
            accountId: string,
            body: WorBatchCreateWorkflowInstancePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/instances/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorBatchCreateWorkflowInstance.OK(Serializer.deserialize content)
            | 400 -> return WorBatchCreateWorkflowInstance.BadRequest(Serializer.deserialize content)
            | _ -> return WorBatchCreateWorkflowInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Terminates multiple workflow instances in a single batch operation.
    ///</summary>
    member this.WorBatchTerminateWorkflowInstances
        (
            workflowName: string,
            accountId: string,
            body: list<string>,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/instances/batch/terminate"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorBatchTerminateWorkflowInstances.OK(Serializer.deserialize content)
            | 400 -> return WorBatchTerminateWorkflowInstances.BadRequest(Serializer.deserialize content)
            | _ -> return WorBatchTerminateWorkflowInstances.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets the status of a bulk workflow instance termination job.
    ///</summary>
    member this.WorStatusTerminateWorkflowInstances
        (
            workflowName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/instances/terminate"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorStatusTerminateWorkflowInstances.OK(Serializer.deserialize content)
            | 400 -> return WorStatusTerminateWorkflowInstances.BadRequest(Serializer.deserialize content)
            | _ -> return WorStatusTerminateWorkflowInstances.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves logs and execution status for a specific workflow instance.
    ///</summary>
    ///<param name="workflowName"></param>
    ///<param name="instanceId"></param>
    ///<param name="accountId"></param>
    ///<param name="simple">When true, omits step details and returns only metadata with step_count.</param>
    ///<param name="order">Step ordering: "asc" (default, oldest first) or "desc" (newest first).</param>
    ///<param name="cancellationToken"></param>
    member this.WorDescribeWorkflowInstance
        (
            workflowName: string,
            instanceId: string,
            accountId: string,
            ?simple: string,
            ?order: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("instance_id", instanceId)
                  RequestPart.path ("account_id", accountId)
                  if simple.IsSome then
                      RequestPart.query ("simple", simple.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/instances/{instance_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorDescribeWorkflowInstance.OK(Serializer.deserialize content)
            | 400 -> return WorDescribeWorkflowInstance.BadRequest(Serializer.deserialize content)
            | _ -> return WorDescribeWorkflowInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Sends an event to a running workflow instance to trigger state transitions.
    ///</summary>
    member this.WorSendEventWorkflowInstance
        (
            workflowName: string,
            instanceId: string,
            eventType: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("instance_id", instanceId)
                  RequestPart.path ("event_type", eventType)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/instances/{instance_id}/events/{event_type}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorSendEventWorkflowInstance.OK(Serializer.deserialize content)
            | 400 -> return WorSendEventWorkflowInstance.BadRequest(Serializer.deserialize content)
            | _ -> return WorSendEventWorkflowInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Changes the execution status of a workflow instance (e.g., pause, resume, terminate).
    ///</summary>
    member this.WorChangeStatusWorkflowInstance
        (
            workflowName: string,
            instanceId: string,
            accountId: string,
            body: WorChangeStatusWorkflowInstancePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("instance_id", instanceId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/instances/{instance_id}/status"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorChangeStatusWorkflowInstance.OK(Serializer.deserialize content)
            | 400 -> return WorChangeStatusWorkflowInstance.BadRequest(Serializer.deserialize content)
            | 404 -> return WorChangeStatusWorkflowInstance.NotFound(Serializer.deserialize content)
            | _ -> return WorChangeStatusWorkflowInstance.Conflict(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all deployed versions of a workflow.
    ///</summary>
    member this.WorListWorkflowVersions
        (
            workflowName: string,
            accountId: string,
            ?perPage: float,
            ?page: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("account_id", accountId)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/versions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorListWorkflowVersions.OK(Serializer.deserialize content)
            | _ -> return WorListWorkflowVersions.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific deployed workflow version.
    ///</summary>
    member this.WorDescribeWorkflowVersions
        (
            workflowName: string,
            versionId: System.Guid,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("version_id", versionId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/versions/{version_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorDescribeWorkflowVersions.OK(Serializer.deserialize content)
            | 400 -> return WorDescribeWorkflowVersions.BadRequest(Serializer.deserialize content)
            | _ -> return WorDescribeWorkflowVersions.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves the directed acyclic graph (DAG) representation of a workflow version.
    ///</summary>
    member this.WorDescribeWorkflowVersionsDag
        (
            workflowName: string,
            versionId: System.Guid,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("version_id", versionId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/versions/{version_id}/dag"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorDescribeWorkflowVersionsDag.OK(Serializer.deserialize content)
            | _ -> return WorDescribeWorkflowVersionsDag.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves the graph visualization of a workflow version.
    ///</summary>
    member this.WorDescribeWorkflowVersionsGraph
        (
            workflowName: string,
            versionId: System.Guid,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("workflow_name", workflowName)
                  RequestPart.path ("version_id", versionId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/workflows/{workflow_name}/versions/{version_id}/graph"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return WorDescribeWorkflowVersionsGraph.OK(Serializer.deserialize content)
            | _ -> return WorDescribeWorkflowVersionsGraph.NotFound(Serializer.deserialize content)
        }
