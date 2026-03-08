namespace rec Fidelity.CloudEdge.Management.AIGateway.Types

type Result =
    { created_at: System.DateTimeOffset
      description: string
      enable: bool
      id: string
      mandatory: bool
      modified_at: System.DateTimeOffset
      name: string
      ``type``: string }

type Resultinfo =
    { count: float
      page: float
      per_page: float
      total_count: float }

type AigConfigListEvaluators_OK =
    { result: list<Result>
      result_info: Resultinfo
      success: bool }

type Errors = { message: string }

type AigConfigListEvaluators_BadRequest =
    { errors: list<Errors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListEvaluators =
    ///Returns a list of Evaluators
    | OK of payload: AigConfigListEvaluators_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListEvaluators_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Logmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Contenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type Otel =
    { authorization: string
      content_type: Option<Contenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Ratelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type Usageevents = { payload: string }

type Stripe =
    { authorization: string
      usage_events: list<Usageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Workersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    | [<CompiledName "unified">] Unified
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"
        | Unified -> "unified"

type AigConfigListGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<Newtonsoft.Json.Linq.JToken>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<Logmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<Otel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: Ratelimitingtechnique
      store_id: Option<string>
      stripe: Option<Stripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed
      workers_ai_billing_mode: Option<Workersaibillingmode>
      zdr: Option<bool> }

type AigConfigListGateway_OK =
    { result: list<AigConfigListGateway_OKResult>
      success: bool }

type AigConfigListGateway_BadRequestErrors = { message: string }

type AigConfigListGateway_BadRequest =
    { errors: list<AigConfigListGateway_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGateway =
    ///List objects
    | OK of payload: AigConfigListGateway_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGateway_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGatewayPayloadLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGatewayPayloadRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGatewayPayloadWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    | [<CompiledName "unified">] Unified
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"
        | Unified -> "unified"

type AigConfigCreateGatewayPayload =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      ///gateway id
      id: string
      log_management: Option<int>
      log_management_strategy: Option<AigConfigCreateGatewayPayloadLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: AigConfigCreateGatewayPayloadRatelimitingtechnique
      ///Controls how Workers AI inference calls routed through this gateway are billed
      workers_ai_billing_mode: Option<AigConfigCreateGatewayPayloadWorkersaibillingmode>
      zdr: Option<bool> }
    ///Creates an instance of AigConfigCreateGatewayPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cache_invalidate_on_update: bool,
                          cache_ttl: int,
                          collect_logs: bool,
                          id: string,
                          rate_limiting_interval: int,
                          rate_limiting_limit: int,
                          rate_limiting_technique: AigConfigCreateGatewayPayloadRatelimitingtechnique): AigConfigCreateGatewayPayload =
        { authentication = None
          cache_invalidate_on_update = cache_invalidate_on_update
          cache_ttl = cache_ttl
          collect_logs = collect_logs
          id = id
          log_management = None
          log_management_strategy = None
          logpush = None
          logpush_public_key = None
          rate_limiting_interval = rate_limiting_interval
          rate_limiting_limit = rate_limiting_limit
          rate_limiting_technique = rate_limiting_technique
          workers_ai_billing_mode = None
          zdr = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGateway_OKResultLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGateway_OKResultOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigCreateGateway_OKResultOtel =
    { authorization: string
      content_type: Option<AigConfigCreateGateway_OKResultOtelContenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGateway_OKResultRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AigConfigCreateGateway_OKResultStripeUsageevents = { payload: string }

type AigConfigCreateGateway_OKResultStripe =
    { authorization: string
      usage_events: list<AigConfigCreateGateway_OKResultStripeUsageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGateway_OKResultWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    | [<CompiledName "unified">] Unified
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"
        | Unified -> "unified"

type AigConfigCreateGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<Newtonsoft.Json.Linq.JToken>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigCreateGateway_OKResultLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<AigConfigCreateGateway_OKResultOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: AigConfigCreateGateway_OKResultRatelimitingtechnique
      store_id: Option<string>
      stripe: Option<AigConfigCreateGateway_OKResultStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed
      workers_ai_billing_mode: Option<AigConfigCreateGateway_OKResultWorkersaibillingmode>
      zdr: Option<bool> }

type AigConfigCreateGateway_OK =
    { result: AigConfigCreateGateway_OKResult
      success: bool }

type AigConfigCreateGateway_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigCreateGateway_BadRequest =
    { errors: list<AigConfigCreateGateway_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigCreateGateway =
    ///Returns the created Object
    | OK of payload: AigConfigCreateGateway_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigCreateGateway_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Key =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Operator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type Filters =
    { key: Key
      operator: Operator
      value: list<string> }

type AigConfigListDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<Filters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigListDataset_OK =
    { result: list<AigConfigListDataset_OKResult>
      success: bool }

type AigConfigListDataset_BadRequestErrors = { message: string }

type AigConfigListDataset_BadRequest =
    { errors: list<AigConfigListDataset_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListDataset =
    ///List objects
    | OK of payload: AigConfigListDataset_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListDataset_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateDatasetPayloadFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateDatasetPayloadFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigCreateDatasetPayloadFilters =
    { key: AigConfigCreateDatasetPayloadFiltersKey
      operator: AigConfigCreateDatasetPayloadFiltersOperator
      value: list<string> }
    ///Creates an instance of AigConfigCreateDatasetPayloadFilters with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: AigConfigCreateDatasetPayloadFiltersKey,
                          operator: AigConfigCreateDatasetPayloadFiltersOperator,
                          value: list<string>): AigConfigCreateDatasetPayloadFilters =
        { key = key
          operator = operator
          value = value }

type AigConfigCreateDatasetPayload =
    { enable: bool
      filters: list<AigConfigCreateDatasetPayloadFilters>
      name: string }
    ///Creates an instance of AigConfigCreateDatasetPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enable: bool, filters: list<AigConfigCreateDatasetPayloadFilters>, name: string): AigConfigCreateDatasetPayload =
        { enable = enable
          filters = filters
          name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateDataset_OKResultFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateDataset_OKResultFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigCreateDataset_OKResultFilters =
    { key: AigConfigCreateDataset_OKResultFiltersKey
      operator: AigConfigCreateDataset_OKResultFiltersOperator
      value: list<string> }

type AigConfigCreateDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigCreateDataset_OKResultFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigCreateDataset_OK =
    { result: AigConfigCreateDataset_OKResult
      success: bool }

type AigConfigCreateDataset_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigCreateDataset_BadRequest =
    { errors: list<AigConfigCreateDataset_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigCreateDataset =
    ///Returns the created Object
    | OK of payload: AigConfigCreateDataset_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigCreateDataset_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteDataset_OKResultFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteDataset_OKResultFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigDeleteDataset_OKResultFilters =
    { key: AigConfigDeleteDataset_OKResultFiltersKey
      operator: AigConfigDeleteDataset_OKResultFiltersOperator
      value: list<string> }

type AigConfigDeleteDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigDeleteDataset_OKResultFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigDeleteDataset_OK =
    { result: AigConfigDeleteDataset_OKResult
      success: bool }

type AigConfigDeleteDataset_NotFoundErrors = { code: float; message: string }

type AigConfigDeleteDataset_NotFound =
    { errors: list<AigConfigDeleteDataset_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteDataset =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AigConfigDeleteDataset_OK
    ///Not Found
    | NotFound of payload: AigConfigDeleteDataset_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchDataset_OKResultFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchDataset_OKResultFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigFetchDataset_OKResultFilters =
    { key: AigConfigFetchDataset_OKResultFiltersKey
      operator: AigConfigFetchDataset_OKResultFiltersOperator
      value: list<string> }

type AigConfigFetchDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigFetchDataset_OKResultFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigFetchDataset_OK =
    { result: AigConfigFetchDataset_OKResult
      success: bool }

type AigConfigFetchDataset_NotFoundErrors = { code: float; message: string }

type AigConfigFetchDataset_NotFound =
    { errors: list<AigConfigFetchDataset_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigFetchDataset =
    ///Returns a single object if found
    | OK of payload: AigConfigFetchDataset_OK
    ///Not Found
    | NotFound of payload: AigConfigFetchDataset_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateDatasetPayloadFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateDatasetPayloadFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigUpdateDatasetPayloadFilters =
    { key: AigConfigUpdateDatasetPayloadFiltersKey
      operator: AigConfigUpdateDatasetPayloadFiltersOperator
      value: list<string> }
    ///Creates an instance of AigConfigUpdateDatasetPayloadFilters with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: AigConfigUpdateDatasetPayloadFiltersKey,
                          operator: AigConfigUpdateDatasetPayloadFiltersOperator,
                          value: list<string>): AigConfigUpdateDatasetPayloadFilters =
        { key = key
          operator = operator
          value = value }

type AigConfigUpdateDatasetPayload =
    { enable: bool
      filters: list<AigConfigUpdateDatasetPayloadFilters>
      name: string }
    ///Creates an instance of AigConfigUpdateDatasetPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enable: bool, filters: list<AigConfigUpdateDatasetPayloadFilters>, name: string): AigConfigUpdateDatasetPayload =
        { enable = enable
          filters = filters
          name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateDataset_OKResultFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateDataset_OKResultFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigUpdateDataset_OKResultFilters =
    { key: AigConfigUpdateDataset_OKResultFiltersKey
      operator: AigConfigUpdateDataset_OKResultFiltersOperator
      value: list<string> }

type AigConfigUpdateDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigUpdateDataset_OKResultFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigUpdateDataset_OK =
    { result: AigConfigUpdateDataset_OKResult
      success: bool }

type AigConfigUpdateDataset_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigUpdateDataset_BadRequest =
    { errors: list<AigConfigUpdateDataset_BadRequestErrors>
      success: bool }

type AigConfigUpdateDataset_NotFoundErrors = { code: float; message: string }

type AigConfigUpdateDataset_NotFound =
    { errors: list<AigConfigUpdateDataset_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigUpdateDataset =
    ///Returns the updated Object
    | OK of payload: AigConfigUpdateDataset_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigUpdateDataset_BadRequest
    ///Not Found
    | NotFound of payload: AigConfigUpdateDataset_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DatasetsFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DatasetsFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type DatasetsFilters =
    { key: DatasetsFiltersKey
      operator: DatasetsFiltersOperator
      value: list<string> }

type Datasets =
    { account_id: string
      account_tag: string
      created_at: System.DateTimeOffset
      enable: bool
      filters: list<DatasetsFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type Results =
    { created_at: System.DateTimeOffset
      evaluation_id: string
      evaluation_type_id: string
      id: string
      modified_at: System.DateTimeOffset
      result: string
      status: float
      status_description: string
      total_logs: float }

type AigConfigListEvaluations_OKResult =
    { created_at: System.DateTimeOffset
      datasets: list<Datasets>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      processed: bool
      results: list<Results>
      total_logs: float }

type AigConfigListEvaluations_OK =
    { result: list<AigConfigListEvaluations_OKResult>
      success: bool }

type AigConfigListEvaluations_BadRequestErrors = { message: string }

type AigConfigListEvaluations_BadRequest =
    { errors: list<AigConfigListEvaluations_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListEvaluations =
    ///List objects
    | OK of payload: AigConfigListEvaluations_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListEvaluations_BadRequest

type AigConfigCreateEvaluationsPayload =
    { dataset_ids: list<string>
      evaluation_type_ids: list<string>
      name: string }
    ///Creates an instance of AigConfigCreateEvaluationsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (dataset_ids: list<string>, evaluation_type_ids: list<string>, name: string): AigConfigCreateEvaluationsPayload =
        { dataset_ids = dataset_ids
          evaluation_type_ids = evaluation_type_ids
          name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateEvaluations_OKResultDatasetsFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateEvaluations_OKResultDatasetsFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigCreateEvaluations_OKResultDatasetsFilters =
    { key: AigConfigCreateEvaluations_OKResultDatasetsFiltersKey
      operator: AigConfigCreateEvaluations_OKResultDatasetsFiltersOperator
      value: list<string> }

type AigConfigCreateEvaluations_OKResultDatasets =
    { account_id: string
      account_tag: string
      created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigCreateEvaluations_OKResultDatasetsFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigCreateEvaluations_OKResultResults =
    { created_at: System.DateTimeOffset
      evaluation_id: string
      evaluation_type_id: string
      id: string
      modified_at: System.DateTimeOffset
      result: string
      status: float
      status_description: string
      total_logs: float }

type AigConfigCreateEvaluations_OKResult =
    { created_at: System.DateTimeOffset
      datasets: list<AigConfigCreateEvaluations_OKResultDatasets>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      processed: bool
      results: list<AigConfigCreateEvaluations_OKResultResults>
      total_logs: float }

type AigConfigCreateEvaluations_OK =
    { result: AigConfigCreateEvaluations_OKResult
      success: bool }

type AigConfigCreateEvaluations_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigCreateEvaluations_BadRequest =
    { errors: list<AigConfigCreateEvaluations_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigCreateEvaluations =
    ///Returns the created Object
    | OK of payload: AigConfigCreateEvaluations_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigCreateEvaluations_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteEvaluations_OKResultDatasetsFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteEvaluations_OKResultDatasetsFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigDeleteEvaluations_OKResultDatasetsFilters =
    { key: AigConfigDeleteEvaluations_OKResultDatasetsFiltersKey
      operator: AigConfigDeleteEvaluations_OKResultDatasetsFiltersOperator
      value: list<string> }

type AigConfigDeleteEvaluations_OKResultDatasets =
    { account_id: string
      account_tag: string
      created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigDeleteEvaluations_OKResultDatasetsFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigDeleteEvaluations_OKResultResults =
    { created_at: System.DateTimeOffset
      evaluation_id: string
      evaluation_type_id: string
      id: string
      modified_at: System.DateTimeOffset
      result: string
      status: float
      status_description: string
      total_logs: float }

type AigConfigDeleteEvaluations_OKResult =
    { created_at: System.DateTimeOffset
      datasets: list<AigConfigDeleteEvaluations_OKResultDatasets>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      processed: bool
      results: list<AigConfigDeleteEvaluations_OKResultResults>
      total_logs: float }

type AigConfigDeleteEvaluations_OK =
    { result: AigConfigDeleteEvaluations_OKResult
      success: bool }

type AigConfigDeleteEvaluations_NotFoundErrors = { code: float; message: string }

type AigConfigDeleteEvaluations_NotFound =
    { errors: list<AigConfigDeleteEvaluations_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteEvaluations =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AigConfigDeleteEvaluations_OK
    ///Not Found
    | NotFound of payload: AigConfigDeleteEvaluations_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchEvaluations_OKResultDatasetsFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchEvaluations_OKResultDatasetsFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigFetchEvaluations_OKResultDatasetsFilters =
    { key: AigConfigFetchEvaluations_OKResultDatasetsFiltersKey
      operator: AigConfigFetchEvaluations_OKResultDatasetsFiltersOperator
      value: list<string> }

type AigConfigFetchEvaluations_OKResultDatasets =
    { account_id: string
      account_tag: string
      created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigFetchEvaluations_OKResultDatasetsFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigFetchEvaluations_OKResultResults =
    { created_at: System.DateTimeOffset
      evaluation_id: string
      evaluation_type_id: string
      id: string
      modified_at: System.DateTimeOffset
      result: string
      status: float
      status_description: string
      total_logs: float }

type AigConfigFetchEvaluations_OKResult =
    { created_at: System.DateTimeOffset
      datasets: list<AigConfigFetchEvaluations_OKResultDatasets>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      processed: bool
      results: list<AigConfigFetchEvaluations_OKResultResults>
      total_logs: float }

type AigConfigFetchEvaluations_OK =
    { result: AigConfigFetchEvaluations_OKResult
      success: bool }

type AigConfigFetchEvaluations_NotFoundErrors = { code: float; message: string }

type AigConfigFetchEvaluations_NotFound =
    { errors: list<AigConfigFetchEvaluations_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigFetchEvaluations =
    ///Returns a single object if found
    | OK of payload: AigConfigFetchEvaluations_OK
    ///Not Found
    | NotFound of payload: AigConfigFetchEvaluations_NotFound

type AigConfigDeleteGatewayLogs_OK = { success: bool }
type AigConfigDeleteGatewayLogs_BadRequestErrors = { message: string }

type AigConfigDeleteGatewayLogs_BadRequest =
    { errors: list<AigConfigDeleteGatewayLogs_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteGatewayLogs =
    ///Returns if the delete was successful
    | OK of payload: AigConfigDeleteGatewayLogs_OK
    ///Bad Request
    | BadRequest of payload: AigConfigDeleteGatewayLogs_BadRequest

type AigConfigListGatewayLogs_OKResult =
    { cached: bool
      cost: Option<float>
      created_at: System.DateTimeOffset
      custom_cost: Option<bool>
      duration: int
      id: string
      metadata: Option<string>
      model: string
      model_type: Option<string>
      path: string
      provider: string
      request_content_type: Option<string>
      request_type: Option<string>
      response_content_type: Option<string>
      status_code: Option<int>
      step: Option<int>
      success: bool
      tokens_in: int
      tokens_out: int }

type AigConfigListGatewayLogs_OKResultinfo =
    { count: Option<float>
      max_cost: Option<float>
      max_duration: Option<float>
      max_tokens_in: Option<float>
      max_tokens_out: Option<float>
      max_total_tokens: Option<float>
      min_cost: Option<float>
      min_duration: Option<float>
      min_tokens_in: Option<float>
      min_tokens_out: Option<float>
      min_total_tokens: Option<float>
      page: Option<float>
      per_page: Option<float>
      total_count: Option<float> }

type AigConfigListGatewayLogs_OK =
    { result: list<AigConfigListGatewayLogs_OKResult>
      result_info: AigConfigListGatewayLogs_OKResultinfo
      success: bool }

type AigConfigListGatewayLogs_BadRequestErrors = { message: string }

type AigConfigListGatewayLogs_BadRequest =
    { errors: list<AigConfigListGatewayLogs_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGatewayLogs =
    ///Returns a list of Gateway Logs
    | OK of payload: AigConfigListGatewayLogs_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGatewayLogs_BadRequest

type AigConfigGetGatewayLogDetail_OKResult =
    { cached: bool
      cost: Option<float>
      created_at: System.DateTimeOffset
      custom_cost: Option<bool>
      duration: int
      id: string
      metadata: Option<string>
      model: string
      model_type: Option<string>
      path: string
      provider: string
      request_content_type: Option<string>
      request_head: Option<string>
      request_head_complete: Option<bool>
      request_size: Option<int>
      request_type: Option<string>
      response_content_type: Option<string>
      response_head: Option<string>
      response_head_complete: Option<bool>
      response_size: Option<int>
      status_code: Option<int>
      step: Option<int>
      success: bool
      tokens_in: int
      tokens_out: int }

type AigConfigGetGatewayLogDetail_OK =
    { result: AigConfigGetGatewayLogDetail_OKResult
      success: bool }

type AigConfigGetGatewayLogDetail_NotFoundErrors = { code: float; message: string }

type AigConfigGetGatewayLogDetail_NotFound =
    { errors: list<AigConfigGetGatewayLogDetail_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayLogDetail =
    ///Returns the log details
    | OK of payload: AigConfigGetGatewayLogDetail_OK
    ///Not Found
    | NotFound of payload: AigConfigGetGatewayLogDetail_NotFound

type AigConfigPatchGatewayLogPayload =
    { feedback: Option<float>
      metadata: Option<Map<string, string>>
      score: Option<float> }
    ///Creates an instance of AigConfigPatchGatewayLogPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AigConfigPatchGatewayLogPayload =
        { feedback = None
          metadata = None
          score = None }

type AigConfigPatchGatewayLog_OK =
    { result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AigConfigPatchGatewayLog_NotFoundErrors = { code: float; message: string }

type AigConfigPatchGatewayLog_NotFound =
    { errors: list<AigConfigPatchGatewayLog_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigPatchGatewayLog =
    ///Returns the log details
    | OK of payload: AigConfigPatchGatewayLog_OK
    ///Not Found
    | NotFound of payload: AigConfigPatchGatewayLog_NotFound

type AigConfigGetGatewayLogRequest_NotFoundErrors = { code: float; message: string }

type AigConfigGetGatewayLogRequest_NotFound =
    { errors: list<AigConfigGetGatewayLogRequest_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayLogRequest =
    ///Returns the request body from a specific log
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Not Found
    | NotFound of payload: AigConfigGetGatewayLogRequest_NotFound

type AigConfigGetGatewayLogResponse_NotFoundErrors = { code: float; message: string }

type AigConfigGetGatewayLogResponse_NotFound =
    { errors: list<AigConfigGetGatewayLogResponse_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayLogResponse =
    ///Returns the response body from a specific log
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Not Found
    | NotFound of payload: AigConfigGetGatewayLogResponse_NotFound

type AigConfigListProviders_OKResult =
    { alias: string
      default_config: bool
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret_id: string
      secret_preview: string }

type AigConfigListProviders_OK =
    { result: list<AigConfigListProviders_OKResult>
      success: bool }

type AigConfigListProviders_BadRequestErrors = { message: string }

type AigConfigListProviders_BadRequest =
    { errors: list<AigConfigListProviders_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListProviders =
    ///List objects
    | OK of payload: AigConfigListProviders_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListProviders_BadRequest

type AigConfigCreateProvidersPayload =
    { alias: string
      default_config: bool
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret: string
      secret_id: string }
    ///Creates an instance of AigConfigCreateProvidersPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (alias: string, default_config: bool, provider_slug: string, secret: string, secret_id: string): AigConfigCreateProvidersPayload =
        { alias = alias
          default_config = default_config
          provider_slug = provider_slug
          rate_limit = None
          rate_limit_period = None
          secret = secret
          secret_id = secret_id }

type AigConfigCreateProviders_OKResult =
    { alias: string
      default_config: bool
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret_id: string
      secret_preview: string }

type AigConfigCreateProviders_OK =
    { result: AigConfigCreateProviders_OKResult
      success: bool }

type AigConfigCreateProviders_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigCreateProviders_BadRequest =
    { errors: list<AigConfigCreateProviders_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigCreateProviders =
    ///Returns the created Object
    | OK of payload: AigConfigCreateProviders_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigCreateProviders_BadRequest

type AigConfigDeleteProviders_OKResult =
    { alias: string
      default_config: bool
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret_id: string
      secret_preview: string }

type AigConfigDeleteProviders_OK =
    { result: AigConfigDeleteProviders_OKResult
      success: bool }

type AigConfigDeleteProviders_NotFoundErrors = { code: float; message: string }

type AigConfigDeleteProviders_NotFound =
    { errors: list<AigConfigDeleteProviders_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteProviders =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AigConfigDeleteProviders_OK
    ///Not Found
    | NotFound of payload: AigConfigDeleteProviders_NotFound

type AigConfigUpdateProvidersPayload =
    { secret: string }
    ///Creates an instance of AigConfigUpdateProvidersPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (secret: string): AigConfigUpdateProvidersPayload = { secret = secret }

type AigConfigUpdateProviders_OKResult =
    { alias: string
      default_config: bool
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret_id: string
      secret_preview: string }

type AigConfigUpdateProviders_OK =
    { result: AigConfigUpdateProviders_OKResult
      success: bool }

type AigConfigUpdateProviders_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigUpdateProviders_BadRequest =
    { errors: list<AigConfigUpdateProviders_BadRequestErrors>
      success: bool }

type AigConfigUpdateProviders_NotFoundErrors = { code: float; message: string }

type AigConfigUpdateProviders_NotFound =
    { errors: list<AigConfigUpdateProviders_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigUpdateProviders =
    ///Returns the updated Object
    | OK of payload: AigConfigUpdateProviders_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigUpdateProviders_BadRequest
    ///Not Found
    | NotFound of payload: AigConfigUpdateProviders_NotFound

type Deployment =
    { comment: Option<string>
      created_at: string
      deployment_id: string
      version_id: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Active =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type Version =
    { active: Active
      comment: Option<string>
      created_at: string
      data: string
      version_id: string }

type Routes =
    { account_tag: string
      created_at: System.DateTimeOffset
      deployment: Deployment
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version: Version }

type Data =
    { order_by: string
      order_by_direction: string
      page: float
      per_page: float
      routes: list<Routes> }

type AigConfigListGatewayDynamicRoutes_OK = { data: Data; success: bool }
type AigConfigListGatewayDynamicRoutes_BadRequestErrors = { message: string }

type AigConfigListGatewayDynamicRoutes_BadRequest =
    { errors: list<AigConfigListGatewayDynamicRoutes_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGatewayDynamicRoutes =
    ///Success
    | OK of payload: AigConfigListGatewayDynamicRoutes_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGatewayDynamicRoutes_BadRequest

type AigConfigPostGatewayDynamicRoutePayload =
    { elements: list<string>
      name: string }
    ///Creates an instance of AigConfigPostGatewayDynamicRoutePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (elements: list<string>, name: string): AigConfigPostGatewayDynamicRoutePayload =
        { elements = elements; name = name }

type AigConfigPostGatewayDynamicRoute_OKResultDeployment =
    { comment: Option<string>
      created_at: string
      deployment_id: string
      version_id: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigPostGatewayDynamicRoute_OKResultVersionActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type AigConfigPostGatewayDynamicRoute_OKResultVersion =
    { active: AigConfigPostGatewayDynamicRoute_OKResultVersionActive
      comment: Option<string>
      created_at: string
      data: string
      version_id: string }

type AigConfigPostGatewayDynamicRoute_OKResult =
    { created_at: System.DateTimeOffset
      deployment: AigConfigPostGatewayDynamicRoute_OKResultDeployment
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version: AigConfigPostGatewayDynamicRoute_OKResultVersion }

type AigConfigPostGatewayDynamicRoute_OK =
    { result: AigConfigPostGatewayDynamicRoute_OKResult
      success: bool }

type AigConfigPostGatewayDynamicRoute_BadRequestErrors = { message: string }

type AigConfigPostGatewayDynamicRoute_BadRequest =
    { errors: list<AigConfigPostGatewayDynamicRoute_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigPostGatewayDynamicRoute =
    ///Success
    | OK of payload: AigConfigPostGatewayDynamicRoute_OK
    ///Bad Request
    | BadRequest of payload: AigConfigPostGatewayDynamicRoute_BadRequest

type AigConfigDeleteGatewayDynamicRoute_OKResult =
    { created_at: System.DateTimeOffset
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigDeleteGatewayDynamicRoute_OK =
    { result: AigConfigDeleteGatewayDynamicRoute_OKResult
      success: bool }

type AigConfigDeleteGatewayDynamicRoute_BadRequestErrors = { message: string }

type AigConfigDeleteGatewayDynamicRoute_BadRequest =
    { errors: list<AigConfigDeleteGatewayDynamicRoute_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteGatewayDynamicRoute =
    ///Success
    | OK of payload: AigConfigDeleteGatewayDynamicRoute_OK
    ///Bad Request
    | BadRequest of payload: AigConfigDeleteGatewayDynamicRoute_BadRequest

type AigConfigGetGatewayDynamicRoute_OKResultDeployment =
    { comment: Option<string>
      created_at: string
      deployment_id: string
      version_id: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigGetGatewayDynamicRoute_OKResultVersionActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type AigConfigGetGatewayDynamicRoute_OKResultVersion =
    { active: AigConfigGetGatewayDynamicRoute_OKResultVersionActive
      comment: Option<string>
      created_at: string
      data: string
      version_id: string }

type AigConfigGetGatewayDynamicRoute_OKResult =
    { created_at: System.DateTimeOffset
      deployment: AigConfigGetGatewayDynamicRoute_OKResultDeployment
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version: AigConfigGetGatewayDynamicRoute_OKResultVersion }

type AigConfigGetGatewayDynamicRoute_OK =
    { result: AigConfigGetGatewayDynamicRoute_OKResult
      success: bool }

type AigConfigGetGatewayDynamicRoute_BadRequestErrors = { message: string }

type AigConfigGetGatewayDynamicRoute_BadRequest =
    { errors: list<AigConfigGetGatewayDynamicRoute_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayDynamicRoute =
    ///Success
    | OK of payload: AigConfigGetGatewayDynamicRoute_OK
    ///Bad Request
    | BadRequest of payload: AigConfigGetGatewayDynamicRoute_BadRequest

type AigConfigUpdateGatewayDynamicRoutePayload =
    { name: string }
    ///Creates an instance of AigConfigUpdateGatewayDynamicRoutePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): AigConfigUpdateGatewayDynamicRoutePayload = { name = name }

type RouteDeployment =
    { comment: Option<string>
      created_at: string
      deployment_id: string
      version_id: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RouteVersionActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type RouteVersion =
    { active: RouteVersionActive
      comment: Option<string>
      created_at: string
      data: string
      version_id: string }

type Route =
    { account_tag: string
      created_at: System.DateTimeOffset
      deployment: RouteDeployment
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version: RouteVersion }

type AigConfigUpdateGatewayDynamicRoute_OK = { route: Route; success: bool }

type AigConfigUpdateGatewayDynamicRoute_BadRequestRoute =
    { account_tag: string
      created_at: System.DateTimeOffset
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigUpdateGatewayDynamicRoute_BadRequest =
    { route: AigConfigUpdateGatewayDynamicRoute_BadRequestRoute
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigUpdateGatewayDynamicRoute =
    ///Success
    | OK of payload: AigConfigUpdateGatewayDynamicRoute_OK
    ///Input Error
    | BadRequest of payload: AigConfigUpdateGatewayDynamicRoute_BadRequest

type Deployments =
    { comment: Option<string>
      created_at: string
      deployment_id: string
      version_id: string }

type AigConfigListGatewayDynamicRouteDeployments_OKData =
    { deployments: list<Deployments>
      order_by: string
      order_by_direction: string
      page: float
      per_page: float }

type AigConfigListGatewayDynamicRouteDeployments_OK =
    { data: AigConfigListGatewayDynamicRouteDeployments_OKData
      success: bool }

type AigConfigListGatewayDynamicRouteDeployments_BadRequestErrors = { message: string }

type AigConfigListGatewayDynamicRouteDeployments_BadRequest =
    { errors: list<AigConfigListGatewayDynamicRouteDeployments_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGatewayDynamicRouteDeployments =
    ///Success
    | OK of payload: AigConfigListGatewayDynamicRouteDeployments_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGatewayDynamicRouteDeployments_BadRequest

type AigConfigPostGatewayDynamicRouteDeploymentPayload =
    { comment: string
      version_id: string }
    ///Creates an instance of AigConfigPostGatewayDynamicRouteDeploymentPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (comment: string, version_id: string): AigConfigPostGatewayDynamicRouteDeploymentPayload =
        { comment = comment
          version_id = version_id }

type AigConfigPostGatewayDynamicRouteDeployment_OKResult =
    { created_at: System.DateTimeOffset
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigPostGatewayDynamicRouteDeployment_OK =
    { result: AigConfigPostGatewayDynamicRouteDeployment_OKResult
      success: bool }

type AigConfigPostGatewayDynamicRouteDeployment_BadRequestErrors = { message: string }

type AigConfigPostGatewayDynamicRouteDeployment_BadRequest =
    { errors: list<AigConfigPostGatewayDynamicRouteDeployment_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigPostGatewayDynamicRouteDeployment =
    ///Success
    | OK of payload: AigConfigPostGatewayDynamicRouteDeployment_OK
    ///Bad Request
    | BadRequest of payload: AigConfigPostGatewayDynamicRouteDeployment_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VersionsActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type Versions =
    { active: VersionsActive
      comment: Option<string>
      created_at: string
      data: string
      version_id: string }

type AigConfigListGatewayDynamicRouteVersions_OKData =
    { order_by: string
      order_by_direction: string
      page: float
      per_page: float
      versions: list<Versions> }

type AigConfigListGatewayDynamicRouteVersions_OK =
    { data: AigConfigListGatewayDynamicRouteVersions_OKData
      success: bool }

type AigConfigListGatewayDynamicRouteVersions_BadRequestErrors = { message: string }

type AigConfigListGatewayDynamicRouteVersions_BadRequest =
    { errors: list<AigConfigListGatewayDynamicRouteVersions_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGatewayDynamicRouteVersions =
    ///Success
    | OK of payload: AigConfigListGatewayDynamicRouteVersions_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGatewayDynamicRouteVersions_BadRequest

type AigConfigPostGatewayDynamicRouteVersionPayload =
    { comment: string
      elements: list<string> }
    ///Creates an instance of AigConfigPostGatewayDynamicRouteVersionPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (comment: string, elements: list<string>): AigConfigPostGatewayDynamicRouteVersionPayload =
        { comment = comment
          elements = elements }

type AigConfigPostGatewayDynamicRouteVersion_OKResult =
    { created_at: System.DateTimeOffset
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigPostGatewayDynamicRouteVersion_OK =
    { result: AigConfigPostGatewayDynamicRouteVersion_OKResult
      success: bool }

type AigConfigPostGatewayDynamicRouteVersion_BadRequestErrors = { message: string }

type AigConfigPostGatewayDynamicRouteVersion_BadRequest =
    { errors: list<AigConfigPostGatewayDynamicRouteVersion_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigPostGatewayDynamicRouteVersion =
    ///Success
    | OK of payload: AigConfigPostGatewayDynamicRouteVersion_OK
    ///Bad Request
    | BadRequest of payload: AigConfigPostGatewayDynamicRouteVersion_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigGetGatewayDynamicRouteVersion_OKResultActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type AigConfigGetGatewayDynamicRouteVersion_OKResult =
    { active: AigConfigGetGatewayDynamicRouteVersion_OKResultActive
      comment: Option<string>
      created_at: string
      data: string
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version_id: string }

type AigConfigGetGatewayDynamicRouteVersion_OK =
    { result: AigConfigGetGatewayDynamicRouteVersion_OKResult
      success: bool }

type AigConfigGetGatewayDynamicRouteVersion_BadRequestErrors = { message: string }

type AigConfigGetGatewayDynamicRouteVersion_BadRequest =
    { errors: list<AigConfigGetGatewayDynamicRouteVersion_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayDynamicRouteVersion =
    ///Success
    | OK of payload: AigConfigGetGatewayDynamicRouteVersion_OK
    ///Bad Request
    | BadRequest of payload: AigConfigGetGatewayDynamicRouteVersion_BadRequest

type AigConfigGetGatewayUrl_OK = { result: string; success: bool }
type AigConfigGetGatewayUrl_BadRequestErrors = { message: string }

type AigConfigGetGatewayUrl_BadRequest =
    { errors: list<AigConfigGetGatewayUrl_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayUrl =
    ///Returns the log details
    | OK of payload: AigConfigGetGatewayUrl_OK
    ///Bad Request
    | BadRequest of payload: AigConfigGetGatewayUrl_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteGateway_OKResultLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteGateway_OKResultOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigDeleteGateway_OKResultOtel =
    { authorization: string
      content_type: Option<AigConfigDeleteGateway_OKResultOtelContenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteGateway_OKResultRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AigConfigDeleteGateway_OKResultStripeUsageevents = { payload: string }

type AigConfigDeleteGateway_OKResultStripe =
    { authorization: string
      usage_events: list<AigConfigDeleteGateway_OKResultStripeUsageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteGateway_OKResultWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    | [<CompiledName "unified">] Unified
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"
        | Unified -> "unified"

type AigConfigDeleteGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<Newtonsoft.Json.Linq.JToken>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigDeleteGateway_OKResultLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<AigConfigDeleteGateway_OKResultOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: AigConfigDeleteGateway_OKResultRatelimitingtechnique
      store_id: Option<string>
      stripe: Option<AigConfigDeleteGateway_OKResultStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed
      workers_ai_billing_mode: Option<AigConfigDeleteGateway_OKResultWorkersaibillingmode>
      zdr: Option<bool> }

type AigConfigDeleteGateway_OK =
    { result: AigConfigDeleteGateway_OKResult
      success: bool }

type AigConfigDeleteGateway_NotFoundErrors = { code: float; message: string }

type AigConfigDeleteGateway_NotFound =
    { errors: list<AigConfigDeleteGateway_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteGateway =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AigConfigDeleteGateway_OK
    ///Not Found
    | NotFound of payload: AigConfigDeleteGateway_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchGateway_OKResultLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchGateway_OKResultOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigFetchGateway_OKResultOtel =
    { authorization: string
      content_type: Option<AigConfigFetchGateway_OKResultOtelContenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchGateway_OKResultRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AigConfigFetchGateway_OKResultStripeUsageevents = { payload: string }

type AigConfigFetchGateway_OKResultStripe =
    { authorization: string
      usage_events: list<AigConfigFetchGateway_OKResultStripeUsageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchGateway_OKResultWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    | [<CompiledName "unified">] Unified
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"
        | Unified -> "unified"

type AigConfigFetchGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<Newtonsoft.Json.Linq.JToken>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigFetchGateway_OKResultLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<AigConfigFetchGateway_OKResultOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: AigConfigFetchGateway_OKResultRatelimitingtechnique
      store_id: Option<string>
      stripe: Option<AigConfigFetchGateway_OKResultStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed
      workers_ai_billing_mode: Option<AigConfigFetchGateway_OKResultWorkersaibillingmode>
      zdr: Option<bool> }

type AigConfigFetchGateway_OK =
    { result: AigConfigFetchGateway_OKResult
      success: bool }

type AigConfigFetchGateway_NotFoundErrors = { code: float; message: string }

type AigConfigFetchGateway_NotFound =
    { errors: list<AigConfigFetchGateway_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigFetchGateway =
    ///Returns a single object if found
    | OK of payload: AigConfigFetchGateway_OK
    ///Not Found
    | NotFound of payload: AigConfigFetchGateway_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGatewayPayloadLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGatewayPayloadOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigUpdateGatewayPayloadOtel =
    { authorization: string
      content_type: Option<AigConfigUpdateGatewayPayloadOtelContenttype>
      headers: Map<string, string>
      url: string }
    ///Creates an instance of AigConfigUpdateGatewayPayloadOtel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (authorization: string, headers: Map<string, string>, url: string): AigConfigUpdateGatewayPayloadOtel =
        { authorization = authorization
          content_type = None
          headers = headers
          url = url }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGatewayPayloadRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AigConfigUpdateGatewayPayloadStripeUsageevents =
    { payload: string }
    ///Creates an instance of AigConfigUpdateGatewayPayloadStripeUsageevents with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (payload: string): AigConfigUpdateGatewayPayloadStripeUsageevents = { payload = payload }

type AigConfigUpdateGatewayPayloadStripe =
    { authorization: string
      usage_events: list<AigConfigUpdateGatewayPayloadStripeUsageevents> }
    ///Creates an instance of AigConfigUpdateGatewayPayloadStripe with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (authorization: string, usage_events: list<AigConfigUpdateGatewayPayloadStripeUsageevents>): AigConfigUpdateGatewayPayloadStripe =
        { authorization = authorization
          usage_events = usage_events }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGatewayPayloadWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    | [<CompiledName "unified">] Unified
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"
        | Unified -> "unified"

type AigConfigUpdateGatewayPayload =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      dlp: Option<Newtonsoft.Json.Linq.JToken>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigUpdateGatewayPayloadLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      otel: Option<list<AigConfigUpdateGatewayPayloadOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: AigConfigUpdateGatewayPayloadRatelimitingtechnique
      store_id: Option<string>
      stripe: Option<AigConfigUpdateGatewayPayloadStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed
      workers_ai_billing_mode: Option<AigConfigUpdateGatewayPayloadWorkersaibillingmode>
      zdr: Option<bool> }
    ///Creates an instance of AigConfigUpdateGatewayPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cache_invalidate_on_update: bool,
                          cache_ttl: int,
                          collect_logs: bool,
                          rate_limiting_interval: int,
                          rate_limiting_limit: int,
                          rate_limiting_technique: AigConfigUpdateGatewayPayloadRatelimitingtechnique): AigConfigUpdateGatewayPayload =
        { authentication = None
          cache_invalidate_on_update = cache_invalidate_on_update
          cache_ttl = cache_ttl
          collect_logs = collect_logs
          dlp = None
          log_management = None
          log_management_strategy = None
          logpush = None
          logpush_public_key = None
          otel = None
          rate_limiting_interval = rate_limiting_interval
          rate_limiting_limit = rate_limiting_limit
          rate_limiting_technique = rate_limiting_technique
          store_id = None
          stripe = None
          workers_ai_billing_mode = None
          zdr = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGateway_OKResultLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGateway_OKResultOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigUpdateGateway_OKResultOtel =
    { authorization: string
      content_type: Option<AigConfigUpdateGateway_OKResultOtelContenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGateway_OKResultRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AigConfigUpdateGateway_OKResultStripeUsageevents = { payload: string }

type AigConfigUpdateGateway_OKResultStripe =
    { authorization: string
      usage_events: list<AigConfigUpdateGateway_OKResultStripeUsageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGateway_OKResultWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    | [<CompiledName "unified">] Unified
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"
        | Unified -> "unified"

type AigConfigUpdateGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<Newtonsoft.Json.Linq.JToken>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigUpdateGateway_OKResultLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<AigConfigUpdateGateway_OKResultOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: AigConfigUpdateGateway_OKResultRatelimitingtechnique
      store_id: Option<string>
      stripe: Option<AigConfigUpdateGateway_OKResultStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed
      workers_ai_billing_mode: Option<AigConfigUpdateGateway_OKResultWorkersaibillingmode>
      zdr: Option<bool> }

type AigConfigUpdateGateway_OK =
    { result: AigConfigUpdateGateway_OKResult
      success: bool }

type AigConfigUpdateGateway_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigUpdateGateway_BadRequest =
    { errors: list<AigConfigUpdateGateway_BadRequestErrors>
      success: bool }

type AigConfigUpdateGateway_NotFoundErrors = { code: float; message: string }

type AigConfigUpdateGateway_NotFound =
    { errors: list<AigConfigUpdateGateway_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigUpdateGateway =
    ///Returns the updated Object
    | OK of payload: AigConfigUpdateGateway_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigUpdateGateway_BadRequest
    ///Not Found
    | NotFound of payload: AigConfigUpdateGateway_NotFound
