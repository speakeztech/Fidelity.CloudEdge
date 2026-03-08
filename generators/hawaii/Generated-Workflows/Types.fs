namespace rec Fidelity.CloudEdge.Management.Workflows.Types

type Errors = { code: float; message: string }
type Messages = { code: float; message: string }

type Instances =
    { complete: Option<float>
      errored: Option<float>
      paused: Option<float>
      queued: Option<float>
      running: Option<float>
      terminated: Option<float>
      waiting: Option<float>
      waitingForPause: Option<float> }

type Result =
    { class_name: string
      created_on: System.DateTimeOffset
      id: System.Guid
      instances: Instances
      modified_on: System.DateTimeOffset
      name: string
      script_name: string
      triggered_on: System.DateTimeOffset }

type Resultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorListWorkflows_OK =
    { errors: list<Errors>
      messages: list<Messages>
      result: list<Result>
      result_info: Option<Resultinfo>
      success: bool }

type WorListWorkflows_BadRequestErrors = { code: float; message: string }

type WorListWorkflows_BadRequest =
    { errors: list<WorListWorkflows_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorListWorkflows =
    ///List of all Workflows belonging to a account.
    | OK of payload: WorListWorkflows_OK
    ///Input Validation Error.
    | BadRequest of payload: WorListWorkflows_BadRequest

type WorDeleteWorkflow_OKErrors = { code: float; message: string }
type WorDeleteWorkflow_OKMessages = { code: float; message: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "ok">] Ok
    member this.Format() =
        match this with
        | Ok -> "ok"

type WorDeleteWorkflow_OKResult = { status: Status; success: bool }

type WorDeleteWorkflow_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorDeleteWorkflow_OK =
    { errors: list<WorDeleteWorkflow_OKErrors>
      messages: list<WorDeleteWorkflow_OKMessages>
      result: WorDeleteWorkflow_OKResult
      result_info: Option<WorDeleteWorkflow_OKResultinfo>
      success: bool }

type WorDeleteWorkflow_BadRequestErrors = { code: float; message: string }

type WorDeleteWorkflow_BadRequest =
    { errors: list<WorDeleteWorkflow_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorDeleteWorkflow_NotFoundErrors = { code: float; message: string }

type WorDeleteWorkflow_NotFound =
    { errors: list<WorDeleteWorkflow_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorDeleteWorkflow =
    ///Deletes a Workflow.
    | OK of payload: WorDeleteWorkflow_OK
    ///Workflow has no deployed versions.
    | BadRequest of payload: WorDeleteWorkflow_BadRequest
    ///Workflow not found.
    | NotFound of payload: WorDeleteWorkflow_NotFound

type WorGetWorkflowDetails_OKErrors = { code: float; message: string }
type WorGetWorkflowDetails_OKMessages = { code: float; message: string }

type WorGetWorkflowDetails_OKResultInstances =
    { complete: Option<float>
      errored: Option<float>
      paused: Option<float>
      queued: Option<float>
      running: Option<float>
      terminated: Option<float>
      waiting: Option<float>
      waitingForPause: Option<float> }

type WorGetWorkflowDetails_OKResult =
    { class_name: string
      created_on: System.DateTimeOffset
      id: System.Guid
      instances: WorGetWorkflowDetails_OKResultInstances
      modified_on: System.DateTimeOffset
      name: string
      script_name: string
      triggered_on: System.DateTimeOffset }

type WorGetWorkflowDetails_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorGetWorkflowDetails_OK =
    { errors: list<WorGetWorkflowDetails_OKErrors>
      messages: list<WorGetWorkflowDetails_OKMessages>
      result: WorGetWorkflowDetails_OKResult
      result_info: Option<WorGetWorkflowDetails_OKResultinfo>
      success: bool }

type WorGetWorkflowDetails_BadRequestErrors = { code: float; message: string }

type WorGetWorkflowDetails_BadRequest =
    { errors: list<WorGetWorkflowDetails_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorGetWorkflowDetails_NotFoundErrors = { code: float; message: string }

type WorGetWorkflowDetails_NotFound =
    { errors: list<WorGetWorkflowDetails_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorGetWorkflowDetails =
    ///Get Workflow details.
    | OK of payload: WorGetWorkflowDetails_OK
    ///Workflow has no deployed versions.
    | BadRequest of payload: WorGetWorkflowDetails_BadRequest
    ///Workflow not found.
    | NotFound of payload: WorGetWorkflowDetails_NotFound

type Limits =
    { steps: Option<int> }
    ///Creates an instance of Limits with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Limits = { steps = None }

type WorCreateOrModifyWorkflowPayload =
    { class_name: string
      limits: Option<Limits>
      script_name: string }
    ///Creates an instance of WorCreateOrModifyWorkflowPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (class_name: string, script_name: string): WorCreateOrModifyWorkflowPayload =
        { class_name = class_name
          limits = None
          script_name = script_name }

type WorCreateOrModifyWorkflow_OKErrors = { code: float; message: string }
type WorCreateOrModifyWorkflow_OKMessages = { code: float; message: string }

type WorCreateOrModifyWorkflow_OKResult =
    { class_name: string
      created_on: System.DateTimeOffset
      id: System.Guid
      is_deleted: float
      modified_on: System.DateTimeOffset
      name: string
      script_name: string
      terminator_running: float
      triggered_on: System.DateTimeOffset
      version_id: System.Guid }

type WorCreateOrModifyWorkflow_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorCreateOrModifyWorkflow_OK =
    { errors: list<WorCreateOrModifyWorkflow_OKErrors>
      messages: list<WorCreateOrModifyWorkflow_OKMessages>
      result: WorCreateOrModifyWorkflow_OKResult
      result_info: Option<WorCreateOrModifyWorkflow_OKResultinfo>
      success: bool }

type WorCreateOrModifyWorkflow_BadRequestErrors = { code: float; message: string }

type WorCreateOrModifyWorkflow_BadRequest =
    { errors: list<WorCreateOrModifyWorkflow_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorCreateOrModifyWorkflow =
    ///Create/modify a Workflow based on a deployed script with an existing `WorkflowEntrypoint` class. Must be done after deploying the corresponding script.
    | OK of payload: WorCreateOrModifyWorkflow_OK
    ///Bad Request.
    | BadRequest of payload: WorCreateOrModifyWorkflow_BadRequest

type WorListWorkflowInstances_OKErrors = { code: float; message: string }
type WorListWorkflowInstances_OKMessages = { code: float; message: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorListWorkflowInstances_OKResultStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "paused">] Paused
    | [<CompiledName "errored">] Errored
    | [<CompiledName "terminated">] Terminated
    | [<CompiledName "complete">] Complete
    | [<CompiledName "waitingForPause">] WaitingForPause
    | [<CompiledName "waiting">] Waiting
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Paused -> "paused"
        | Errored -> "errored"
        | Terminated -> "terminated"
        | Complete -> "complete"
        | WaitingForPause -> "waitingForPause"
        | Waiting -> "waiting"

type WorListWorkflowInstances_OKResult =
    { created_on: System.DateTimeOffset
      ended_on: System.DateTimeOffset
      id: string
      modified_on: System.DateTimeOffset
      started_on: System.DateTimeOffset
      status: WorListWorkflowInstances_OKResultStatus
      version_id: System.Guid
      workflow_id: System.Guid }

type WorListWorkflowInstances_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorListWorkflowInstances_OK =
    { errors: list<WorListWorkflowInstances_OKErrors>
      messages: list<WorListWorkflowInstances_OKMessages>
      result: list<WorListWorkflowInstances_OKResult>
      result_info: Option<WorListWorkflowInstances_OKResultinfo>
      success: bool }

type WorListWorkflowInstances_BadRequestErrors = { code: float; message: string }

type WorListWorkflowInstances_BadRequest =
    { errors: list<WorListWorkflowInstances_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorListWorkflowInstances_NotFoundErrors = { code: float; message: string }

type WorListWorkflowInstances_NotFound =
    { errors: list<WorListWorkflowInstances_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorListWorkflowInstances =
    ///List of workflow instances.
    | OK of payload: WorListWorkflowInstances_OK
    ///Input Validation Error.
    | BadRequest of payload: WorListWorkflowInstances_BadRequest
    ///Workflow Name not found.
    | NotFound of payload: WorListWorkflowInstances_NotFound

type Instanceretention =
    { ///Specifies the duration in milliseconds or as a string like '5 minutes'.
      error_retention: Option<Newtonsoft.Json.Linq.JToken>
      ///Specifies the duration in milliseconds or as a string like '5 minutes'.
      success_retention: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of Instanceretention with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Instanceretention =
        { error_retention = None
          success_retention = None }

type WorCreateNewWorkflowInstancePayload =
    { instance_id: Option<string>
      instance_retention: Option<Instanceretention>
      ``params``: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of WorCreateNewWorkflowInstancePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorCreateNewWorkflowInstancePayload =
        { instance_id = None
          instance_retention = None
          ``params`` = None }

type WorCreateNewWorkflowInstance_OKErrors = { code: float; message: string }
type WorCreateNewWorkflowInstance_OKMessages = { code: float; message: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorCreateNewWorkflowInstance_OKResultStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "paused">] Paused
    | [<CompiledName "errored">] Errored
    | [<CompiledName "terminated">] Terminated
    | [<CompiledName "complete">] Complete
    | [<CompiledName "waitingForPause">] WaitingForPause
    | [<CompiledName "waiting">] Waiting
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Paused -> "paused"
        | Errored -> "errored"
        | Terminated -> "terminated"
        | Complete -> "complete"
        | WaitingForPause -> "waitingForPause"
        | Waiting -> "waiting"

type WorCreateNewWorkflowInstance_OKResult =
    { id: string
      status: WorCreateNewWorkflowInstance_OKResultStatus
      version_id: System.Guid
      workflow_id: System.Guid }

type WorCreateNewWorkflowInstance_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorCreateNewWorkflowInstance_OK =
    { errors: list<WorCreateNewWorkflowInstance_OKErrors>
      messages: list<WorCreateNewWorkflowInstance_OKMessages>
      result: WorCreateNewWorkflowInstance_OKResult
      result_info: Option<WorCreateNewWorkflowInstance_OKResultinfo>
      success: bool }

type WorCreateNewWorkflowInstance_BadRequestErrors = { code: float; message: string }

type WorCreateNewWorkflowInstance_BadRequest =
    { errors: list<WorCreateNewWorkflowInstance_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorCreateNewWorkflowInstance_NotFoundErrors = { code: float; message: string }

type WorCreateNewWorkflowInstance_NotFound =
    { errors: list<WorCreateNewWorkflowInstance_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorCreateNewWorkflowInstance =
    ///Create workflow instance. Body is a JSON parsable string that it's passed into the new instance as the event payload.
    | OK of payload: WorCreateNewWorkflowInstance_OK
    ///Provided Workflow ID is not valid.
    | BadRequest of payload: WorCreateNewWorkflowInstance_BadRequest
    ///Workflow Name not found.
    | NotFound of payload: WorCreateNewWorkflowInstance_NotFound

type WorBatchCreateWorkflowInstancePayloadArrayItemInstanceretention =
    { ///Specifies the duration in milliseconds or as a string like '5 minutes'.
      error_retention: Option<Newtonsoft.Json.Linq.JToken>
      ///Specifies the duration in milliseconds or as a string like '5 minutes'.
      success_retention: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of WorBatchCreateWorkflowInstancePayloadArrayItemInstanceretention with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorBatchCreateWorkflowInstancePayloadArrayItemInstanceretention =
        { error_retention = None
          success_retention = None }

type WorBatchCreateWorkflowInstancePayloadArrayItem =
    { instance_id: Option<string>
      instance_retention: Option<WorBatchCreateWorkflowInstancePayloadArrayItemInstanceretention>
      ``params``: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of WorBatchCreateWorkflowInstancePayloadArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorBatchCreateWorkflowInstancePayloadArrayItem =
        { instance_id = None
          instance_retention = None
          ``params`` = None }

type WorBatchCreateWorkflowInstancePayload = list<WorBatchCreateWorkflowInstancePayloadArrayItem>
type WorBatchCreateWorkflowInstance_OKErrors = { code: float; message: string }
type WorBatchCreateWorkflowInstance_OKMessages = { code: float; message: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorBatchCreateWorkflowInstance_OKResultStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "paused">] Paused
    | [<CompiledName "errored">] Errored
    | [<CompiledName "terminated">] Terminated
    | [<CompiledName "complete">] Complete
    | [<CompiledName "waitingForPause">] WaitingForPause
    | [<CompiledName "waiting">] Waiting
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Paused -> "paused"
        | Errored -> "errored"
        | Terminated -> "terminated"
        | Complete -> "complete"
        | WaitingForPause -> "waitingForPause"
        | Waiting -> "waiting"

type WorBatchCreateWorkflowInstance_OKResult =
    { id: string
      status: WorBatchCreateWorkflowInstance_OKResultStatus
      version_id: System.Guid
      workflow_id: System.Guid }

type WorBatchCreateWorkflowInstance_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorBatchCreateWorkflowInstance_OK =
    { errors: list<WorBatchCreateWorkflowInstance_OKErrors>
      messages: list<WorBatchCreateWorkflowInstance_OKMessages>
      result: list<WorBatchCreateWorkflowInstance_OKResult>
      result_info: Option<WorBatchCreateWorkflowInstance_OKResultinfo>
      success: bool }

type WorBatchCreateWorkflowInstance_BadRequestErrors = { code: float; message: string }

type WorBatchCreateWorkflowInstance_BadRequest =
    { errors: list<WorBatchCreateWorkflowInstance_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorBatchCreateWorkflowInstance_NotFoundErrors = { code: float; message: string }

type WorBatchCreateWorkflowInstance_NotFound =
    { errors: list<WorBatchCreateWorkflowInstance_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorBatchCreateWorkflowInstance =
    ///Batch create workflow instances. Body is a JSON list that contain all payloads and ids that are passed into the new instance as the event payload.
    | OK of payload: WorBatchCreateWorkflowInstance_OK
    ///Provided Workflow ID is not valid.
    | BadRequest of payload: WorBatchCreateWorkflowInstance_BadRequest
    ///Workflow Name not found.
    | NotFound of payload: WorBatchCreateWorkflowInstance_NotFound

type WorBatchTerminateWorkflowInstances_OKErrors = { code: float; message: string }
type WorBatchTerminateWorkflowInstances_OKMessages = { code: float; message: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorBatchTerminateWorkflowInstances_OKResultStatus =
    | [<CompiledName "ok">] Ok
    | [<CompiledName "already_running">] Already_running
    member this.Format() =
        match this with
        | Ok -> "ok"
        | Already_running -> "already_running"

type WorBatchTerminateWorkflowInstances_OKResult =
    { instancesTerminated: float
      status: WorBatchTerminateWorkflowInstances_OKResultStatus }

type WorBatchTerminateWorkflowInstances_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorBatchTerminateWorkflowInstances_OK =
    { errors: list<WorBatchTerminateWorkflowInstances_OKErrors>
      messages: list<WorBatchTerminateWorkflowInstances_OKMessages>
      result: WorBatchTerminateWorkflowInstances_OKResult
      result_info: Option<WorBatchTerminateWorkflowInstances_OKResultinfo>
      success: bool }

type WorBatchTerminateWorkflowInstances_BadRequestErrors = { code: float; message: string }

type WorBatchTerminateWorkflowInstances_BadRequest =
    { errors: list<WorBatchTerminateWorkflowInstances_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorBatchTerminateWorkflowInstances_NotFoundErrors = { code: float; message: string }

type WorBatchTerminateWorkflowInstances_NotFound =
    { errors: list<WorBatchTerminateWorkflowInstances_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorBatchTerminateWorkflowInstances =
    ///Batch terminate instances of a workflow, via a async job. Body is a JSON list that contain the ids of the instances to terminate.
    | OK of payload: WorBatchTerminateWorkflowInstances_OK
    ///Provided Workflow ID is not valid.
    | BadRequest of payload: WorBatchTerminateWorkflowInstances_BadRequest
    ///Workflow Name not found.
    | NotFound of payload: WorBatchTerminateWorkflowInstances_NotFound

type WorStatusTerminateWorkflowInstances_OKErrors = { code: float; message: string }
type WorStatusTerminateWorkflowInstances_OKMessages = { code: float; message: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorStatusTerminateWorkflowInstances_OKResultStatus =
    | [<CompiledName "running">] Running
    | [<CompiledName "not_running">] Not_running
    member this.Format() =
        match this with
        | Running -> "running"
        | Not_running -> "not_running"

type WorStatusTerminateWorkflowInstances_OKResult =
    { status: WorStatusTerminateWorkflowInstances_OKResultStatus }

type WorStatusTerminateWorkflowInstances_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorStatusTerminateWorkflowInstances_OK =
    { errors: list<WorStatusTerminateWorkflowInstances_OKErrors>
      messages: list<WorStatusTerminateWorkflowInstances_OKMessages>
      result: WorStatusTerminateWorkflowInstances_OKResult
      result_info: Option<WorStatusTerminateWorkflowInstances_OKResultinfo>
      success: bool }

type WorStatusTerminateWorkflowInstances_BadRequestErrors = { code: float; message: string }

type WorStatusTerminateWorkflowInstances_BadRequest =
    { errors: list<WorStatusTerminateWorkflowInstances_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorStatusTerminateWorkflowInstances_NotFoundErrors = { code: float; message: string }

type WorStatusTerminateWorkflowInstances_NotFound =
    { errors: list<WorStatusTerminateWorkflowInstances_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorStatusTerminateWorkflowInstances =
    ///Get status of the job responsible for terminate all instances of a workflow.
    | OK of payload: WorStatusTerminateWorkflowInstances_OK
    ///Input Validation Error.
    | BadRequest of payload: WorStatusTerminateWorkflowInstances_BadRequest
    ///Workflow Name not found.
    | NotFound of payload: WorStatusTerminateWorkflowInstances_NotFound

type WorDescribeWorkflowInstance_OKErrors = { code: float; message: string }
type WorDescribeWorkflowInstance_OKMessages = { code: float; message: string }
type Error = { message: string; name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorDescribeWorkflowInstance_OKResultStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "paused">] Paused
    | [<CompiledName "errored">] Errored
    | [<CompiledName "terminated">] Terminated
    | [<CompiledName "complete">] Complete
    | [<CompiledName "waitingForPause">] WaitingForPause
    | [<CompiledName "waiting">] Waiting
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Paused -> "paused"
        | Errored -> "errored"
        | Terminated -> "terminated"
        | Complete -> "complete"
        | WaitingForPause -> "waitingForPause"
        | Waiting -> "waiting"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Source =
    | [<CompiledName "unknown">] Unknown
    | [<CompiledName "api">] Api
    | [<CompiledName "binding">] Binding
    | [<CompiledName "event">] Event
    | [<CompiledName "cron">] Cron
    member this.Format() =
        match this with
        | Unknown -> "unknown"
        | Api -> "api"
        | Binding -> "binding"
        | Event -> "event"
        | Cron -> "cron"

type Trigger = { source: Source }

type WorDescribeWorkflowInstance_OKResult =
    { ``end``: System.DateTimeOffset
      error: Error
      output: Newtonsoft.Json.Linq.JToken
      ``params``: Newtonsoft.Json.Linq.JObject
      queued: System.DateTimeOffset
      start: System.DateTimeOffset
      status: WorDescribeWorkflowInstance_OKResultStatus
      step_count: int
      steps: list<string>
      success: bool
      trigger: Trigger
      versionId: System.Guid }

type WorDescribeWorkflowInstance_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorDescribeWorkflowInstance_OK =
    { errors: list<WorDescribeWorkflowInstance_OKErrors>
      messages: list<WorDescribeWorkflowInstance_OKMessages>
      result: WorDescribeWorkflowInstance_OKResult
      result_info: Option<WorDescribeWorkflowInstance_OKResultinfo>
      success: bool }

type WorDescribeWorkflowInstance_BadRequestErrors = { code: float; message: string }

type WorDescribeWorkflowInstance_BadRequest =
    { errors: list<WorDescribeWorkflowInstance_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorDescribeWorkflowInstance_NotFoundErrors = { code: float; message: string }

type WorDescribeWorkflowInstance_NotFound =
    { errors: list<WorDescribeWorkflowInstance_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorDescribeWorkflowInstance =
    ///Get all logs and status from the instance.
    | OK of payload: WorDescribeWorkflowInstance_OK
    ///Bad Request.
    | BadRequest of payload: WorDescribeWorkflowInstance_BadRequest
    ///Instance not found.
    | NotFound of payload: WorDescribeWorkflowInstance_NotFound

type WorSendEventWorkflowInstance_OKErrors = { code: float; message: string }
type WorSendEventWorkflowInstance_OKMessages = { code: float; message: string }

type WorSendEventWorkflowInstance_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorSendEventWorkflowInstance_OK =
    { errors: list<WorSendEventWorkflowInstance_OKErrors>
      messages: list<WorSendEventWorkflowInstance_OKMessages>
      result: Option<Newtonsoft.Json.Linq.JObject>
      result_info: Option<WorSendEventWorkflowInstance_OKResultinfo>
      success: bool }

type WorSendEventWorkflowInstance_BadRequestErrors = { code: float; message: string }

type WorSendEventWorkflowInstance_BadRequest =
    { errors: list<WorSendEventWorkflowInstance_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorSendEventWorkflowInstance_NotFoundErrors = { code: float; message: string }

type WorSendEventWorkflowInstance_NotFound =
    { errors: list<WorSendEventWorkflowInstance_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorSendEventWorkflowInstance =
    ///Send an event to an instance.
    | OK of payload: WorSendEventWorkflowInstance_OK
    ///Bad Request.
    | BadRequest of payload: WorSendEventWorkflowInstance_BadRequest
    ///Workflow not found.
    | NotFound of payload: WorSendEventWorkflowInstance_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorChangeStatusWorkflowInstancePayloadStatus =
    | [<CompiledName "resume">] Resume
    | [<CompiledName "pause">] Pause
    | [<CompiledName "terminate">] Terminate
    | [<CompiledName "restart">] Restart
    member this.Format() =
        match this with
        | Resume -> "resume"
        | Pause -> "pause"
        | Terminate -> "terminate"
        | Restart -> "restart"

type WorChangeStatusWorkflowInstancePayload =
    { ///Apply action to instance.
      status: WorChangeStatusWorkflowInstancePayloadStatus }
    ///Creates an instance of WorChangeStatusWorkflowInstancePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (status: WorChangeStatusWorkflowInstancePayloadStatus): WorChangeStatusWorkflowInstancePayload =
        { status = status }

type WorChangeStatusWorkflowInstance_OKErrors = { code: float; message: string }
type WorChangeStatusWorkflowInstance_OKMessages = { code: float; message: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorChangeStatusWorkflowInstance_OKResultStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "paused">] Paused
    | [<CompiledName "errored">] Errored
    | [<CompiledName "terminated">] Terminated
    | [<CompiledName "complete">] Complete
    | [<CompiledName "waitingForPause">] WaitingForPause
    | [<CompiledName "waiting">] Waiting
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Paused -> "paused"
        | Errored -> "errored"
        | Terminated -> "terminated"
        | Complete -> "complete"
        | WaitingForPause -> "waitingForPause"
        | Waiting -> "waiting"

type WorChangeStatusWorkflowInstance_OKResult =
    { status: WorChangeStatusWorkflowInstance_OKResultStatus
      ///Accepts ISO 8601 with no timezone offsets and in UTC.
      timestamp: System.DateTimeOffset }

type WorChangeStatusWorkflowInstance_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorChangeStatusWorkflowInstance_OK =
    { errors: list<WorChangeStatusWorkflowInstance_OKErrors>
      messages: list<WorChangeStatusWorkflowInstance_OKMessages>
      result: WorChangeStatusWorkflowInstance_OKResult
      result_info: Option<WorChangeStatusWorkflowInstance_OKResultinfo>
      success: bool }

type WorChangeStatusWorkflowInstance_BadRequestErrors = { code: float; message: string }

type WorChangeStatusWorkflowInstance_BadRequest =
    { errors: list<WorChangeStatusWorkflowInstance_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorChangeStatusWorkflowInstance_NotFoundErrors = { code: float; message: string }

type WorChangeStatusWorkflowInstance_NotFound =
    { errors: list<WorChangeStatusWorkflowInstance_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorChangeStatusWorkflowInstance_ConflictErrors = { code: float; message: string }

type WorChangeStatusWorkflowInstance_Conflict =
    { errors: list<WorChangeStatusWorkflowInstance_ConflictErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorChangeStatusWorkflowInstance =
    ///Change status of instance - it can be paused, resumed or terminated.
    | OK of payload: WorChangeStatusWorkflowInstance_OK
    ///Bad Request.
    | BadRequest of payload: WorChangeStatusWorkflowInstance_BadRequest
    ///Instance not found.
    | NotFound of payload: WorChangeStatusWorkflowInstance_NotFound
    ///Instance not in a restartable state.
    | Conflict of payload: WorChangeStatusWorkflowInstance_Conflict

type WorListWorkflowVersions_OKErrors = { code: float; message: string }
type WorListWorkflowVersions_OKMessages = { code: float; message: string }
type WorListWorkflowVersions_OKResultLimits = { steps: Option<int> }

type WorListWorkflowVersions_OKResult =
    { class_name: string
      created_on: System.DateTimeOffset
      has_dag: bool
      id: System.Guid
      limits: Option<WorListWorkflowVersions_OKResultLimits>
      modified_on: System.DateTimeOffset
      workflow_id: System.Guid }

type WorListWorkflowVersions_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorListWorkflowVersions_OK =
    { errors: list<WorListWorkflowVersions_OKErrors>
      messages: list<WorListWorkflowVersions_OKMessages>
      result: list<WorListWorkflowVersions_OKResult>
      result_info: Option<WorListWorkflowVersions_OKResultinfo>
      success: bool }

type WorListWorkflowVersions_BadRequestErrors = { code: float; message: string }

type WorListWorkflowVersions_BadRequest =
    { errors: list<WorListWorkflowVersions_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorListWorkflowVersions =
    ///List deployed workflow versions.
    | OK of payload: WorListWorkflowVersions_OK
    ///Bad Request.
    | BadRequest of payload: WorListWorkflowVersions_BadRequest

type WorDescribeWorkflowVersions_OKErrors = { code: float; message: string }
type WorDescribeWorkflowVersions_OKMessages = { code: float; message: string }
type WorDescribeWorkflowVersions_OKResultLimits = { steps: Option<int> }

type WorDescribeWorkflowVersions_OKResult =
    { class_name: string
      created_on: System.DateTimeOffset
      has_dag: bool
      id: System.Guid
      limits: Option<WorDescribeWorkflowVersions_OKResultLimits>
      modified_on: System.DateTimeOffset
      workflow_id: System.Guid }

type WorDescribeWorkflowVersions_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorDescribeWorkflowVersions_OK =
    { errors: list<WorDescribeWorkflowVersions_OKErrors>
      messages: list<WorDescribeWorkflowVersions_OKMessages>
      result: WorDescribeWorkflowVersions_OKResult
      result_info: Option<WorDescribeWorkflowVersions_OKResultinfo>
      success: bool }

type WorDescribeWorkflowVersions_BadRequestErrors = { code: float; message: string }

type WorDescribeWorkflowVersions_BadRequest =
    { errors: list<WorDescribeWorkflowVersions_BadRequestErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type WorDescribeWorkflowVersions_NotFoundErrors = { code: float; message: string }

type WorDescribeWorkflowVersions_NotFound =
    { errors: list<WorDescribeWorkflowVersions_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorDescribeWorkflowVersions =
    ///Get specific version details.
    | OK of payload: WorDescribeWorkflowVersions_OK
    ///Bad Request.
    | BadRequest of payload: WorDescribeWorkflowVersions_BadRequest
    ///Version not found.
    | NotFound of payload: WorDescribeWorkflowVersions_NotFound

type WorDescribeWorkflowVersionsDag_OKErrors = { code: float; message: string }
type WorDescribeWorkflowVersionsDag_OKMessages = { code: float; message: string }

type WorDescribeWorkflowVersionsDag_OKResult =
    { class_name: string
      created_on: System.DateTimeOffset
      dag: Newtonsoft.Json.Linq.JObject
      id: System.Guid
      modified_on: System.DateTimeOffset
      workflow_id: System.Guid }

type WorDescribeWorkflowVersionsDag_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorDescribeWorkflowVersionsDag_OK =
    { errors: list<WorDescribeWorkflowVersionsDag_OKErrors>
      messages: list<WorDescribeWorkflowVersionsDag_OKMessages>
      result: WorDescribeWorkflowVersionsDag_OKResult
      result_info: Option<WorDescribeWorkflowVersionsDag_OKResultinfo>
      success: bool }

type WorDescribeWorkflowVersionsDag_NotFoundErrors = { code: float; message: string }

type WorDescribeWorkflowVersionsDag_NotFound =
    { errors: list<WorDescribeWorkflowVersionsDag_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorDescribeWorkflowVersionsDag =
    ///Get the parsed DAG for a specific workflow version.
    | OK of payload: WorDescribeWorkflowVersionsDag_OK
    ///Version not found.
    | NotFound of payload: WorDescribeWorkflowVersionsDag_NotFound

type WorDescribeWorkflowVersionsGraph_OKErrors = { code: float; message: string }
type WorDescribeWorkflowVersionsGraph_OKMessages = { code: float; message: string }

type WorDescribeWorkflowVersionsGraph_OKResult =
    { class_name: string
      created_on: System.DateTimeOffset
      dag: Newtonsoft.Json.Linq.JObject
      id: System.Guid
      modified_on: System.DateTimeOffset
      workflow_id: System.Guid }

type WorDescribeWorkflowVersionsGraph_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type WorDescribeWorkflowVersionsGraph_OK =
    { errors: list<WorDescribeWorkflowVersionsGraph_OKErrors>
      messages: list<WorDescribeWorkflowVersionsGraph_OKMessages>
      result: WorDescribeWorkflowVersionsGraph_OKResult
      result_info: Option<WorDescribeWorkflowVersionsGraph_OKResultinfo>
      success: bool }

type WorDescribeWorkflowVersionsGraph_NotFoundErrors = { code: float; message: string }

type WorDescribeWorkflowVersionsGraph_NotFound =
    { errors: list<WorDescribeWorkflowVersionsGraph_NotFoundErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorDescribeWorkflowVersionsGraph =
    ///Get the parsed graph for a specific workflow version.
    | OK of payload: WorDescribeWorkflowVersionsGraph_OK
    ///Version not found.
    | NotFound of payload: WorDescribeWorkflowVersionsGraph_NotFound
