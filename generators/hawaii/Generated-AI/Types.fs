namespace rec Fidelity.CloudEdge.Management.AI.Types

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

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Cachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Datatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type Custommetadata =
    { data_type: Datatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Fusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type Metadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type Chatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type Mcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Technique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type Ratelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<Technique> }

type Searchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type Publicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<Chatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<Mcp>
      rate_limit: Option<Ratelimit>
      search_endpoint: Option<Searchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Direction =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type Boostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<Direction>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Keywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type Retrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<Boostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<Keywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Source =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type Crawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<Source> }

type Contentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type Parseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<Contentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Parsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Storagetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type Storeoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<Storagetype> }

type Webcrawler =
    { crawl_options: Option<Crawloptions>
      parse_options: Option<Parseoptions>
      parse_type: Option<Parsetype>
      store_options: Option<Storeoptions> }

type Sourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<Webcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchListInstances_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<Cachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<Custommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<Fusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<Metadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<Publicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<Retrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<Sourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<Type>
      vectorize_name: string }

type AiSearchListInstances_OK =
    { result: list<AiSearchListInstances_OKResult>
      success: bool }

type AiSearchListInstances_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchListInstances_BadRequest =
    { errors: list<AiSearchListInstances_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchListInstances =
    ///List objects
    | OK of payload: AiSearchListInstances_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchListInstances_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchCreateInstancesPayloadCustommetadata =
    { data_type: AiSearchCreateInstancesPayloadCustommetadataDatatype
      field_name: string }
    ///Creates an instance of AiSearchCreateInstancesPayloadCustommetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data_type: AiSearchCreateInstancesPayloadCustommetadataDatatype, field_name: string): AiSearchCreateInstancesPayloadCustommetadata =
        { data_type = data_type
          field_name = field_name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchCreateInstancesPayloadMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }
    ///Creates an instance of AiSearchCreateInstancesPayloadMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadMetadata =
        { created_from_aisearch_wizard = None
          worker_domain = None }

type AiSearchCreateInstancesPayloadPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparamsChatcompletionsendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparamsChatcompletionsendpoint =
        { disabled = None }

type AiSearchCreateInstancesPayloadPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparamsMcp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparamsMcp =
        { description = None; disabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchCreateInstancesPayloadPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchCreateInstancesPayloadPublicendpointparamsRatelimitTechnique> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparamsRatelimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparamsRatelimit =
        { period_ms = None
          requests = None
          technique = None }

type AiSearchCreateInstancesPayloadPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparamsSearchendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparamsSearchendpoint = { disabled = None }

type AiSearchCreateInstancesPayloadPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchCreateInstancesPayloadPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchCreateInstancesPayloadPublicendpointparamsMcp>
      rate_limit: Option<AiSearchCreateInstancesPayloadPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchCreateInstancesPayloadPublicendpointparamsSearchendpoint> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparams =
        { authorized_hosts = None
          chat_completions_endpoint = None
          enabled = None
          mcp = None
          rate_limit = None
          search_endpoint = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchCreateInstancesPayloadRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchCreateInstancesPayloadRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchCreateInstancesPayloadRetrievaloptionsBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchCreateInstancesPayloadRetrievaloptionsBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchCreateInstancesPayloadRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchCreateInstancesPayloadRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchCreateInstancesPayloadRetrievaloptionsKeywordmatchmode> }
    ///Creates an instance of AiSearchCreateInstancesPayloadRetrievaloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadRetrievaloptions =
        { boost_by = None
          keyword_match_mode = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptionsSource> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptions =
        { depth = None
          include_external_links = None
          include_subdomains = None
          max_age = None
          source = None }

type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (path: string, selector: string): AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector =
        { path = path; selector = selector }

type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptions =
        { content_selector = None
          include_headers = None
          include_images = None
          specific_sitemaps = None
          use_browser_rendering = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptionsStoragetype> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (storage_id: string): AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptions =
        { r2_jurisdiction = None
          storage_id = storage_id
          storage_type = None }

type AiSearchCreateInstancesPayloadSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptions> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawler with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadSourceparamsWebcrawler =
        { crawl_options = None
          parse_options = None
          parse_type = None
          store_options = None }

type AiSearchCreateInstancesPayloadSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawler> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadSourceparams =
        { exclude_items = None
          include_items = None
          prefix = None
          r2_jurisdiction = None
          web_crawler = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchCreateInstancesPayload =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchCreateInstancesPayloadCachethreshold>
      chunk: Option<bool>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      custom_metadata: Option<list<AiSearchCreateInstancesPayloadCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      fusion_method: Option<AiSearchCreateInstancesPayloadFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      max_num_results: Option<int>
      metadata: Option<AiSearchCreateInstancesPayloadMetadata>
      public_endpoint_params: Option<AiSearchCreateInstancesPayloadPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchCreateInstancesPayloadRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchCreateInstancesPayloadSourceparams>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchCreateInstancesPayloadType> }
    ///Creates an instance of AiSearchCreateInstancesPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): AiSearchCreateInstancesPayload =
        { ai_gateway_id = None
          ai_search_model = None
          cache = None
          cache_threshold = None
          chunk = None
          chunk_overlap = None
          chunk_size = None
          custom_metadata = None
          embedding_model = None
          fusion_method = None
          hybrid_search_enabled = None
          id = id
          max_num_results = None
          metadata = None
          public_endpoint_params = None
          reranking = None
          reranking_model = None
          retrieval_options = None
          rewrite_model = None
          rewrite_query = None
          score_threshold = None
          source = None
          source_params = None
          token_id = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchCreateInstances_CreatedResultCustommetadata =
    { data_type: AiSearchCreateInstances_CreatedResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchCreateInstances_CreatedResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchCreateInstances_CreatedResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchCreateInstances_CreatedResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchCreateInstances_CreatedResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsRatelimitTechnique> }

type AiSearchCreateInstances_CreatedResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchCreateInstances_CreatedResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchCreateInstances_CreatedResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchCreateInstances_CreatedResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchCreateInstances_CreatedResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchCreateInstances_CreatedResultRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchCreateInstances_CreatedResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchCreateInstances_CreatedResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchCreateInstances_CreatedResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchCreateInstances_CreatedResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchCreateInstances_CreatedResultCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<AiSearchCreateInstances_CreatedResultFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchCreateInstances_CreatedResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchCreateInstances_CreatedResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchCreateInstances_CreatedResultRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchCreateInstances_CreatedResultSourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchCreateInstances_CreatedResultType>
      vectorize_name: string }

type AiSearchCreateInstances_Created =
    { result: AiSearchCreateInstances_CreatedResult
      success: bool }

type AiSearchCreateInstances_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchCreateInstances_BadRequest =
    { errors: list<AiSearchCreateInstances_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchCreateInstances =
    ///Returns the created Object
    | Created of payload: AiSearchCreateInstances_Created
    ///Input Validation Error
    | BadRequest of payload: AiSearchCreateInstances_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchDeleteInstances_OKResultCustommetadata =
    { data_type: AiSearchDeleteInstances_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchDeleteInstances_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchDeleteInstances_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchDeleteInstances_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchDeleteInstances_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchDeleteInstances_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchDeleteInstances_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchDeleteInstances_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchDeleteInstances_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchDeleteInstances_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchDeleteInstances_OKResultRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchDeleteInstances_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchDeleteInstances_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchDeleteInstances_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchDeleteInstances_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchDeleteInstances_OKResultCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<AiSearchDeleteInstances_OKResultFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchDeleteInstances_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchDeleteInstances_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchDeleteInstances_OKResultRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchDeleteInstances_OKResultSourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchDeleteInstances_OKResultType>
      vectorize_name: string }

type AiSearchDeleteInstances_OK =
    { result: AiSearchDeleteInstances_OKResult
      success: bool }

type AiSearchDeleteInstances_NotFoundErrors = { code: float; message: string }

type AiSearchDeleteInstances_NotFound =
    { errors: list<AiSearchDeleteInstances_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchDeleteInstances =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AiSearchDeleteInstances_OK
    ///Not Found
    | NotFound of payload: AiSearchDeleteInstances_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchFetchInstances_OKResultCustommetadata =
    { data_type: AiSearchFetchInstances_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchFetchInstances_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchFetchInstances_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchFetchInstances_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchFetchInstances_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchFetchInstances_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchFetchInstances_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchFetchInstances_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchFetchInstances_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchFetchInstances_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchFetchInstances_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchFetchInstances_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchFetchInstances_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchFetchInstances_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchFetchInstances_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchFetchInstances_OKResultRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchFetchInstances_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchFetchInstances_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchFetchInstances_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchFetchInstances_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchFetchInstances_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchFetchInstances_OKResultCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<AiSearchFetchInstances_OKResultFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchFetchInstances_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchFetchInstances_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchFetchInstances_OKResultRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchFetchInstances_OKResultSourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchFetchInstances_OKResultType>
      vectorize_name: string }

type AiSearchFetchInstances_OK =
    { result: AiSearchFetchInstances_OKResult
      success: bool }

type AiSearchFetchInstances_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchFetchInstances_BadRequest =
    { errors: list<AiSearchFetchInstances_BadRequestErrors>
      success: bool }

type AiSearchFetchInstances_NotFoundErrors = { code: float; message: string }

type AiSearchFetchInstances_NotFound =
    { errors: list<AiSearchFetchInstances_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchFetchInstances =
    ///Returns a single object if found
    | OK of payload: AiSearchFetchInstances_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchFetchInstances_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchFetchInstances_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchUpdateInstancesPayloadCustommetadata =
    { data_type: AiSearchUpdateInstancesPayloadCustommetadataDatatype
      field_name: string }
    ///Creates an instance of AiSearchUpdateInstancesPayloadCustommetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data_type: AiSearchUpdateInstancesPayloadCustommetadataDatatype, field_name: string): AiSearchUpdateInstancesPayloadCustommetadata =
        { data_type = data_type
          field_name = field_name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchUpdateInstancesPayloadMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadMetadata =
        { created_from_aisearch_wizard = None
          worker_domain = None }

type AiSearchUpdateInstancesPayloadPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparamsChatcompletionsendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparamsChatcompletionsendpoint =
        { disabled = None }

type AiSearchUpdateInstancesPayloadPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparamsMcp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparamsMcp =
        { description = None; disabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimitTechnique> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimit =
        { period_ms = None
          requests = None
          technique = None }

type AiSearchUpdateInstancesPayloadPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparamsSearchendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparamsSearchendpoint = { disabled = None }

type AiSearchUpdateInstancesPayloadPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsMcp>
      rate_limit: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsSearchendpoint> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparams =
        { authorized_hosts = None
          chat_completions_endpoint = None
          enabled = None
          mcp = None
          rate_limit = None
          search_endpoint = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchUpdateInstancesPayloadRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchUpdateInstancesPayloadRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchUpdateInstancesPayloadRetrievaloptionsBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchUpdateInstancesPayloadRetrievaloptionsBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchUpdateInstancesPayloadRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchUpdateInstancesPayloadRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchUpdateInstancesPayloadRetrievaloptionsKeywordmatchmode> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadRetrievaloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadRetrievaloptions =
        { boost_by = None
          keyword_match_mode = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptionsSource> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptions =
        { depth = None
          include_external_links = None
          include_subdomains = None
          max_age = None
          source = None }

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (path: string, selector: string): AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector =
        { path = path; selector = selector }

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptions =
        { content_selector = None
          include_headers = None
          include_images = None
          specific_sitemaps = None
          use_browser_rendering = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptionsStoragetype> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (storage_id: string): AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptions =
        { r2_jurisdiction = None
          storage_id = storage_id
          storage_type = None }

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptions> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawler with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadSourceparamsWebcrawler =
        { crawl_options = None
          parse_options = None
          parse_type = None
          store_options = None }

type AiSearchUpdateInstancesPayloadSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawler> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadSourceparams =
        { exclude_items = None
          include_items = None
          prefix = None
          r2_jurisdiction = None
          web_crawler = None }

type AiSearchUpdateInstancesPayload =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchUpdateInstancesPayloadCachethreshold>
      chunk: Option<bool>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      custom_metadata: Option<list<AiSearchUpdateInstancesPayloadCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      fusion_method: Option<AiSearchUpdateInstancesPayloadFusionmethod>
      hybrid_search_enabled: Option<bool>
      max_num_results: Option<int>
      metadata: Option<AiSearchUpdateInstancesPayloadMetadata>
      paused: Option<bool>
      public_endpoint_params: Option<AiSearchUpdateInstancesPayloadPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchUpdateInstancesPayloadRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source_params: Option<AiSearchUpdateInstancesPayloadSourceparams>
      summarization: Option<bool>
      summarization_model: Option<Newtonsoft.Json.Linq.JToken>
      system_prompt_ai_search: Option<string>
      system_prompt_index_summarization: Option<string>
      system_prompt_rewrite_query: Option<string>
      token_id: Option<System.Guid> }
    ///Creates an instance of AiSearchUpdateInstancesPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayload =
        { ai_gateway_id = None
          ai_search_model = None
          cache = None
          cache_threshold = None
          chunk = None
          chunk_overlap = None
          chunk_size = None
          custom_metadata = None
          embedding_model = None
          fusion_method = None
          hybrid_search_enabled = None
          max_num_results = None
          metadata = None
          paused = None
          public_endpoint_params = None
          reranking = None
          reranking_model = None
          retrieval_options = None
          rewrite_model = None
          rewrite_query = None
          score_threshold = None
          source_params = None
          summarization = None
          summarization_model = None
          system_prompt_ai_search = None
          system_prompt_index_summarization = None
          system_prompt_rewrite_query = None
          token_id = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchUpdateInstances_OKResultCustommetadata =
    { data_type: AiSearchUpdateInstances_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchUpdateInstances_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchUpdateInstances_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchUpdateInstances_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchUpdateInstances_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchUpdateInstances_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchUpdateInstances_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchUpdateInstances_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchUpdateInstances_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchUpdateInstances_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchUpdateInstances_OKResultRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchUpdateInstances_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchUpdateInstances_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchUpdateInstances_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchUpdateInstances_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchUpdateInstances_OKResultCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<AiSearchUpdateInstances_OKResultFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchUpdateInstances_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchUpdateInstances_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchUpdateInstances_OKResultRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchUpdateInstances_OKResultSourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchUpdateInstances_OKResultType>
      vectorize_name: string }

type AiSearchUpdateInstances_OK =
    { result: AiSearchUpdateInstances_OKResult
      success: bool }

type AiSearchUpdateInstances_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchUpdateInstances_BadRequest =
    { errors: list<AiSearchUpdateInstances_BadRequestErrors>
      success: bool }

type AiSearchUpdateInstances_NotFoundErrors = { code: float; message: string }

type AiSearchUpdateInstances_NotFound =
    { errors: list<AiSearchUpdateInstances_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchUpdateInstances =
    ///Returns the updated Object
    | OK of payload: AiSearchUpdateInstances_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchUpdateInstances_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchUpdateInstances_NotFound

type Queryrewrite =
    { enabled: Option<bool>
      model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_prompt: Option<string> }
    ///Creates an instance of Queryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Queryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type Reranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of Reranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Reranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type RetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<RetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of RetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): RetrievalBoostby = { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RetrievalKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Retrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type Retrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<RetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<Newtonsoft.Json.Linq.JObject>
      fusion_method: Option<RetrievalFusionmethod>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<RetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<Retrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of Retrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Retrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type Aisearchoptions =
    { query_rewrite: Option<Queryrewrite>
      reranking: Option<Reranking>
      retrieval: Option<Retrieval> }
    ///Creates an instance of Aisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Aisearchoptions =
        { query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Role =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type Messages =
    { content: string
      role: Role }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: Role): Messages = { content = content; role = role }

type AiSearchInstanceChatCompletionPayload =
    { ai_search_options: Option<Aisearchoptions>
      messages: list<Messages>
      model: Option<Newtonsoft.Json.Linq.JToken>
      stream: Option<bool> }
    ///Creates an instance of AiSearchInstanceChatCompletionPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<Messages>): AiSearchInstanceChatCompletionPayload =
        { ai_search_options = None
          messages = messages
          model = None
          stream = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MessageRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type Message = { content: string; role: MessageRole }

type Choices =
    { index: Option<int>
      message: Message }

type Item =
    { key: string
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      timestamp: Option<float> }

type Scoringdetails =
    { keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type Chunks =
    { id: string
      item: Option<Item>
      score: float
      scoring_details: Option<Scoringdetails>
      text: string
      ``type``: string }

type AiSearchInstanceChatCompletion_OK =
    { choices: list<Choices>
      chunks: list<Chunks>
      id: Option<string>
      model: Option<string>
      object: Option<string> }

type AiSearchInstanceChatCompletion_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceChatCompletion_NotFound =
    { errors: list<AiSearchInstanceChatCompletion_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceChatCompletion =
    ///Returns the chat completions results with retrieved files.
    | OK of payload: AiSearchInstanceChatCompletion_OK
    ///Not Found
    | NotFound of payload: AiSearchInstanceChatCompletion_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceListJobs_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceListJobs_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceListJobs_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceListJobs_OKResultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AiSearchInstanceListJobs_OK =
    { result: list<AiSearchInstanceListJobs_OKResult>
      result_info: AiSearchInstanceListJobs_OKResultinfo
      success: bool }

type AiSearchInstanceListJobs_BadRequestErrors = { message: string }

type AiSearchInstanceListJobs_BadRequest =
    { errors: list<AiSearchInstanceListJobs_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceListJobs_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceListJobs_InternalServerError =
    { errors: list<AiSearchInstanceListJobs_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceListJobs =
    ///Returns a list of AI Search Jobs.
    | OK of payload: AiSearchInstanceListJobs_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceListJobs_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceListJobs_InternalServerError

type AiSearchInstanceCreateJobPayload =
    { description: Option<string> }
    ///Creates an instance of AiSearchInstanceCreateJobPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceCreateJobPayload = { description = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceCreateJob_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceCreateJob_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceCreateJob_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceCreateJob_OK =
    { result: AiSearchInstanceCreateJob_OKResult
      success: bool }

type AiSearchInstanceCreateJob_BadRequestErrors = { message: string }

type AiSearchInstanceCreateJob_BadRequest =
    { errors: list<AiSearchInstanceCreateJob_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceCreateJob_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceCreateJob_InternalServerError =
    { errors: list<AiSearchInstanceCreateJob_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceCreateJob =
    ///Returns the AI Search job id.
    | OK of payload: AiSearchInstanceCreateJob_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceCreateJob_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceCreateJob_InternalServerError

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceGetJob_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceGetJob_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceGetJob_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceGetJob_OK =
    { result: AiSearchInstanceGetJob_OKResult
      success: bool }

type AiSearchInstanceGetJob_BadRequestErrors = { message: string }

type AiSearchInstanceGetJob_BadRequest =
    { errors: list<AiSearchInstanceGetJob_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceGetJob_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceGetJob_InternalServerError =
    { errors: list<AiSearchInstanceGetJob_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceGetJob =
    ///Returns a AI Search Job Details.
    | OK of payload: AiSearchInstanceGetJob_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceGetJob_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceGetJob_InternalServerError

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Action =
    | [<CompiledName "cancel">] Cancel
    member this.Format() =
        match this with
        | Cancel -> "cancel"

type AiSearchInstanceChangeJobStatusPayload =
    { action: Action }
    ///Creates an instance of AiSearchInstanceChangeJobStatusPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: Action): AiSearchInstanceChangeJobStatusPayload = { action = action }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceChangeJobStatus_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceChangeJobStatus_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceChangeJobStatus_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceChangeJobStatus_OK =
    { result: AiSearchInstanceChangeJobStatus_OKResult
      success: bool }

type AiSearchInstanceChangeJobStatus_BadRequestErrors = { message: string }

type AiSearchInstanceChangeJobStatus_BadRequest =
    { errors: list<AiSearchInstanceChangeJobStatus_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceChangeJobStatus_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceChangeJobStatus_InternalServerError =
    { errors: list<AiSearchInstanceChangeJobStatus_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceChangeJobStatus =
    ///Returns the updated AI Search Job.
    | OK of payload: AiSearchInstanceChangeJobStatus_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceChangeJobStatus_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceChangeJobStatus_InternalServerError

type AiSearchInstanceListJobLogs_OKResult =
    { created_at: float
      id: int
      message: string
      message_type: int }

type AiSearchInstanceListJobLogs_OKResultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AiSearchInstanceListJobLogs_OK =
    { result: list<AiSearchInstanceListJobLogs_OKResult>
      result_info: AiSearchInstanceListJobLogs_OKResultinfo
      success: bool }

type AiSearchInstanceListJobLogs_BadRequestErrors = { message: string }

type AiSearchInstanceListJobLogs_BadRequest =
    { errors: list<AiSearchInstanceListJobLogs_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceListJobLogs_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceListJobLogs_InternalServerError =
    { errors: list<AiSearchInstanceListJobLogs_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceListJobLogs =
    ///Returns a list of AI Search Job Logs.
    | OK of payload: AiSearchInstanceListJobLogs_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceListJobLogs_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceListJobLogs_InternalServerError

type AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite =
    { enabled: Option<bool>
      model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_prompt: Option<string> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type AiSearchInstanceSearchPayloadAisearchoptionsReranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsReranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsReranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type AiSearchInstanceSearchPayloadAisearchoptionsRetrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<Newtonsoft.Json.Linq.JObject>
      fusion_method: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsRetrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsRetrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type AiSearchInstanceSearchPayloadAisearchoptions =
    { query_rewrite: Option<AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite>
      reranking: Option<AiSearchInstanceSearchPayloadAisearchoptionsReranking>
      retrieval: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrieval> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptions =
        { query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadMessagesRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type AiSearchInstanceSearchPayloadMessages =
    { content: string
      role: AiSearchInstanceSearchPayloadMessagesRole }
    ///Creates an instance of AiSearchInstanceSearchPayloadMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: AiSearchInstanceSearchPayloadMessagesRole): AiSearchInstanceSearchPayloadMessages =
        { content = content; role = role }

type AiSearchInstanceSearchPayload =
    { ai_search_options: Option<AiSearchInstanceSearchPayloadAisearchoptions>
      messages: list<AiSearchInstanceSearchPayloadMessages> }
    ///Creates an instance of AiSearchInstanceSearchPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<AiSearchInstanceSearchPayloadMessages>): AiSearchInstanceSearchPayload =
        { ai_search_options = None
          messages = messages }

type AiSearchInstanceSearch_OKResultChunksItem =
    { key: string
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      timestamp: Option<float> }

type AiSearchInstanceSearch_OKResultChunksScoringdetails =
    { keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type AiSearchInstanceSearch_OKResultChunks =
    { id: string
      item: Option<AiSearchInstanceSearch_OKResultChunksItem>
      score: float
      scoring_details: Option<AiSearchInstanceSearch_OKResultChunksScoringdetails>
      text: string
      ``type``: string }

type AiSearchInstanceSearch_OKResult =
    { chunks: list<AiSearchInstanceSearch_OKResultChunks>
      search_query: string }

type AiSearchInstanceSearch_OK =
    { result: AiSearchInstanceSearch_OKResult
      success: bool }

type AiSearchInstanceSearch_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceSearch_NotFound =
    { errors: list<AiSearchInstanceSearch_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceSearch =
    ///Returns the search results.
    | OK of payload: AiSearchInstanceSearch_OK
    ///Not Found
    | NotFound of payload: AiSearchInstanceSearch_NotFound

type AiSearchStats_OKResult =
    { completed: Option<int>
      error: Option<int>
      file_embed_errors: Option<Newtonsoft.Json.Linq.JObject>
      index_source_errors: Option<Newtonsoft.Json.Linq.JObject>
      last_activity: Option<System.DateTimeOffset>
      queued: Option<int>
      running: Option<int>
      skipped: Option<int> }

type AiSearchStats_OK =
    { result: AiSearchStats_OKResult
      success: bool }

type AiSearchStats_NotFoundErrors = { code: float; message: string }

type AiSearchStats_NotFound =
    { errors: list<AiSearchStats_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchStats =
    ///Returns the AI Search stats.
    | OK of payload: AiSearchStats_OK
    ///Not Found
    | NotFound of payload: AiSearchStats_NotFound

type AiSearchListTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchListTokens_OK =
    { result: list<AiSearchListTokens_OKResult>
      success: bool }

type AiSearchListTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchListTokens_BadRequest =
    { errors: list<AiSearchListTokens_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchListTokens =
    ///List objects
    | OK of payload: AiSearchListTokens_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchListTokens_BadRequest

type AiSearchCreateTokensPayload =
    { cf_api_id: string
      cf_api_key: string
      legacy: Option<bool>
      name: string }
    ///Creates an instance of AiSearchCreateTokensPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cf_api_id: string, cf_api_key: string, name: string): AiSearchCreateTokensPayload =
        { cf_api_id = cf_api_id
          cf_api_key = cf_api_key
          legacy = None
          name = name }

type AiSearchCreateTokens_CreatedResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchCreateTokens_Created =
    { result: AiSearchCreateTokens_CreatedResult
      success: bool }

type AiSearchCreateTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchCreateTokens_BadRequest =
    { errors: list<AiSearchCreateTokens_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchCreateTokens =
    ///Returns the created Object
    | Created of payload: AiSearchCreateTokens_Created
    ///Input Validation Error
    | BadRequest of payload: AiSearchCreateTokens_BadRequest

type AiSearchDeleteTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchDeleteTokens_OK =
    { result: AiSearchDeleteTokens_OKResult
      success: bool }

type AiSearchDeleteTokens_NotFoundErrors = { code: float; message: string }

type AiSearchDeleteTokens_NotFound =
    { errors: list<AiSearchDeleteTokens_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchDeleteTokens =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AiSearchDeleteTokens_OK
    ///Not Found
    | NotFound of payload: AiSearchDeleteTokens_NotFound

type AiSearchFetchTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchFetchTokens_OK =
    { result: AiSearchFetchTokens_OKResult
      success: bool }

type AiSearchFetchTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchFetchTokens_BadRequest =
    { errors: list<AiSearchFetchTokens_BadRequestErrors>
      success: bool }

type AiSearchFetchTokens_NotFoundErrors = { code: float; message: string }

type AiSearchFetchTokens_NotFound =
    { errors: list<AiSearchFetchTokens_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchFetchTokens =
    ///Returns a single object if found
    | OK of payload: AiSearchFetchTokens_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchFetchTokens_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchFetchTokens_NotFound

type AiSearchUpdateTokensPayload =
    { cf_api_id: string
      cf_api_key: string
      legacy: Option<bool>
      name: string }
    ///Creates an instance of AiSearchUpdateTokensPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cf_api_id: string, cf_api_key: string, name: string): AiSearchUpdateTokensPayload =
        { cf_api_id = cf_api_id
          cf_api_key = cf_api_key
          legacy = None
          name = name }

type AiSearchUpdateTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchUpdateTokens_OK =
    { result: AiSearchUpdateTokens_OKResult
      success: bool }

type AiSearchUpdateTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchUpdateTokens_BadRequest =
    { errors: list<AiSearchUpdateTokens_BadRequestErrors>
      success: bool }

type AiSearchUpdateTokens_NotFoundErrors = { code: float; message: string }

type AiSearchUpdateTokens_NotFound =
    { errors: list<AiSearchUpdateTokens_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchUpdateTokens =
    ///Returns the updated Object
    | OK of payload: AiSearchUpdateTokens_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchUpdateTokens_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchUpdateTokens_NotFound

type WorkersAiSearchAuthor_OK =
    { errors: Newtonsoft.Json.Linq.JArray
      messages: list<string>
      result: Newtonsoft.Json.Linq.JArray
      success: bool }

type WorkersAiSearchAuthor_BadRequestErrors = { message: string }

type WorkersAiSearchAuthor_BadRequest =
    { errors: list<WorkersAiSearchAuthor_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiSearchAuthor =
    ///Returns a list of authors
    | OK of payload: WorkersAiSearchAuthor_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiSearchAuthor_BadRequest

type WorkersAiListFinetunes_OKResult =
    { created_at: System.DateTimeOffset
      description: Option<string>
      id: System.Guid
      model: string
      modified_at: System.DateTimeOffset
      name: string }

type WorkersAiListFinetunes_OK =
    { result: WorkersAiListFinetunes_OKResult
      success: bool }

type WorkersAiListFinetunes_BadRequestErrors = { message: string }

type WorkersAiListFinetunes_BadRequest =
    { errors: list<WorkersAiListFinetunes_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiListFinetunes =
    ///Returns all finetunes
    | OK of payload: WorkersAiListFinetunes_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiListFinetunes_BadRequest

type WorkersAiCreateFinetunePayload =
    { description: Option<string>
      model: string
      name: string
      ``public``: Option<bool> }
    ///Creates an instance of WorkersAiCreateFinetunePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (model: string, name: string): WorkersAiCreateFinetunePayload =
        { description = None
          model = model
          name = name
          ``public`` = None }

type WorkersAiCreateFinetune_OKResult =
    { created_at: System.DateTimeOffset
      description: Option<string>
      id: System.Guid
      model: string
      modified_at: System.DateTimeOffset
      name: string
      ``public``: bool }

type WorkersAiCreateFinetune_OK =
    { result: WorkersAiCreateFinetune_OKResult
      success: bool }

type WorkersAiCreateFinetune_BadRequest =
    { errors: Newtonsoft.Json.Linq.JArray
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiCreateFinetune =
    ///Returns the created finetune
    | OK of payload: WorkersAiCreateFinetune_OK
    ///Finetune creation failed
    | BadRequest of payload: WorkersAiCreateFinetune_BadRequest

type WorkersAiListPublicFinetunes_OKResult =
    { created_at: System.DateTimeOffset
      description: Option<string>
      id: System.Guid
      model: string
      modified_at: System.DateTimeOffset
      name: string
      ``public``: bool }

type WorkersAiListPublicFinetunes_OK =
    { result: list<WorkersAiListPublicFinetunes_OKResult>
      success: bool }

type WorkersAiListPublicFinetunes_BadRequestErrors = { message: string }

type WorkersAiListPublicFinetunes_BadRequest =
    { errors: list<WorkersAiListPublicFinetunes_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiListPublicFinetunes =
    ///Returns all public finetunes
    | OK of payload: WorkersAiListPublicFinetunes_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiListPublicFinetunes_BadRequest

type WorkersAiUploadFinetuneAssetPayload =
    { file: Option<string>
      file_name: Option<string> }
    ///Creates an instance of WorkersAiUploadFinetuneAssetPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorkersAiUploadFinetuneAssetPayload = { file = None; file_name = None }

type WorkersAiUploadFinetuneAsset_OK = { success: bool }

type WorkersAiUploadFinetuneAsset_BadRequest =
    { errors: Newtonsoft.Json.Linq.JArray
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiUploadFinetuneAsset =
    ///Returns successfully if finetunes were uploaded
    | OK of payload: WorkersAiUploadFinetuneAsset_OK
    ///Finetune creation failed
    | BadRequest of payload: WorkersAiUploadFinetuneAsset_BadRequest

type Input =
    { additionalProperties: bool
      description: string
      ``type``: string }

type Output =
    { additionalProperties: bool
      description: string
      ``type``: string }

type WorkersAiGetModelSchema_OKResult = { input: Input; output: Output }

type WorkersAiGetModelSchema_OK =
    { result: WorkersAiGetModelSchema_OKResult
      success: bool }

type WorkersAiGetModelSchema_BadRequestErrors = { message: string }

type WorkersAiGetModelSchema_BadRequest =
    { errors: list<WorkersAiGetModelSchema_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiGetModelSchema =
    ///Model Schema
    | OK of payload: WorkersAiGetModelSchema_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiGetModelSchema_BadRequest

type WorkersAiSearchModel_OK =
    { errors: Newtonsoft.Json.Linq.JArray
      messages: list<string>
      result: Newtonsoft.Json.Linq.JArray
      success: bool }

type WorkersAiSearchModel_NotFound =
    { errors: Newtonsoft.Json.Linq.JArray
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiSearchModel =
    ///Returns a list of models
    | OK of payload: WorkersAiSearchModel_OK
    ///Object not found
    | NotFound of payload: WorkersAiSearchModel_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Targetlanguage =
    | [<CompiledName "asm_Beng">] Asm_Beng
    | [<CompiledName "awa_Deva">] Awa_Deva
    | [<CompiledName "ben_Beng">] Ben_Beng
    | [<CompiledName "bho_Deva">] Bho_Deva
    | [<CompiledName "brx_Deva">] Brx_Deva
    | [<CompiledName "doi_Deva">] Doi_Deva
    | [<CompiledName "eng_Latn">] Eng_Latn
    | [<CompiledName "gom_Deva">] Gom_Deva
    | [<CompiledName "gon_Deva">] Gon_Deva
    | [<CompiledName "guj_Gujr">] Guj_Gujr
    | [<CompiledName "hin_Deva">] Hin_Deva
    | [<CompiledName "hne_Deva">] Hne_Deva
    | [<CompiledName "kan_Knda">] Kan_Knda
    | [<CompiledName "kas_Arab">] Kas_Arab
    | [<CompiledName "kas_Deva">] Kas_Deva
    | [<CompiledName "kha_Latn">] Kha_Latn
    | [<CompiledName "lus_Latn">] Lus_Latn
    | [<CompiledName "mag_Deva">] Mag_Deva
    | [<CompiledName "mai_Deva">] Mai_Deva
    | [<CompiledName "mal_Mlym">] Mal_Mlym
    | [<CompiledName "mar_Deva">] Mar_Deva
    | [<CompiledName "mni_Beng">] Mni_Beng
    | [<CompiledName "mni_Mtei">] Mni_Mtei
    | [<CompiledName "npi_Deva">] Npi_Deva
    | [<CompiledName "ory_Orya">] Ory_Orya
    | [<CompiledName "pan_Guru">] Pan_Guru
    | [<CompiledName "san_Deva">] San_Deva
    | [<CompiledName "sat_Olck">] Sat_Olck
    | [<CompiledName "snd_Arab">] Snd_Arab
    | [<CompiledName "snd_Deva">] Snd_Deva
    | [<CompiledName "tam_Taml">] Tam_Taml
    | [<CompiledName "tel_Telu">] Tel_Telu
    | [<CompiledName "urd_Arab">] Urd_Arab
    | [<CompiledName "unr_Deva">] Unr_Deva
    member this.Format() =
        match this with
        | Asm_Beng -> "asm_Beng"
        | Awa_Deva -> "awa_Deva"
        | Ben_Beng -> "ben_Beng"
        | Bho_Deva -> "bho_Deva"
        | Brx_Deva -> "brx_Deva"
        | Doi_Deva -> "doi_Deva"
        | Eng_Latn -> "eng_Latn"
        | Gom_Deva -> "gom_Deva"
        | Gon_Deva -> "gon_Deva"
        | Guj_Gujr -> "guj_Gujr"
        | Hin_Deva -> "hin_Deva"
        | Hne_Deva -> "hne_Deva"
        | Kan_Knda -> "kan_Knda"
        | Kas_Arab -> "kas_Arab"
        | Kas_Deva -> "kas_Deva"
        | Kha_Latn -> "kha_Latn"
        | Lus_Latn -> "lus_Latn"
        | Mag_Deva -> "mag_Deva"
        | Mai_Deva -> "mai_Deva"
        | Mal_Mlym -> "mal_Mlym"
        | Mar_Deva -> "mar_Deva"
        | Mni_Beng -> "mni_Beng"
        | Mni_Mtei -> "mni_Mtei"
        | Npi_Deva -> "npi_Deva"
        | Ory_Orya -> "ory_Orya"
        | Pan_Guru -> "pan_Guru"
        | San_Deva -> "san_Deva"
        | Sat_Olck -> "sat_Olck"
        | Snd_Arab -> "snd_Arab"
        | Snd_Deva -> "snd_Deva"
        | Tam_Taml -> "tam_Taml"
        | Tel_Telu -> "tel_Telu"
        | Urd_Arab -> "urd_Arab"
        | Unr_Deva -> "unr_Deva"

type WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1BPayload =
    { ///Target langauge to translate to
      target_language: Targetlanguage
      ///Input text to translate. Can be a single string or a list of strings.
      text: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1BPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (target_language: Targetlanguage, text: Newtonsoft.Json.Linq.JToken): WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1BPayload =
        { target_language = target_language
          text = text }

type WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B_BadRequest =
    { errors: list<WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1bPayloadTargetlanguage =
    | [<CompiledName "asm_Beng">] Asm_Beng
    | [<CompiledName "awa_Deva">] Awa_Deva
    | [<CompiledName "ben_Beng">] Ben_Beng
    | [<CompiledName "bho_Deva">] Bho_Deva
    | [<CompiledName "brx_Deva">] Brx_Deva
    | [<CompiledName "doi_Deva">] Doi_Deva
    | [<CompiledName "eng_Latn">] Eng_Latn
    | [<CompiledName "gom_Deva">] Gom_Deva
    | [<CompiledName "gon_Deva">] Gon_Deva
    | [<CompiledName "guj_Gujr">] Guj_Gujr
    | [<CompiledName "hin_Deva">] Hin_Deva
    | [<CompiledName "hne_Deva">] Hne_Deva
    | [<CompiledName "kan_Knda">] Kan_Knda
    | [<CompiledName "kas_Arab">] Kas_Arab
    | [<CompiledName "kas_Deva">] Kas_Deva
    | [<CompiledName "kha_Latn">] Kha_Latn
    | [<CompiledName "lus_Latn">] Lus_Latn
    | [<CompiledName "mag_Deva">] Mag_Deva
    | [<CompiledName "mai_Deva">] Mai_Deva
    | [<CompiledName "mal_Mlym">] Mal_Mlym
    | [<CompiledName "mar_Deva">] Mar_Deva
    | [<CompiledName "mni_Beng">] Mni_Beng
    | [<CompiledName "mni_Mtei">] Mni_Mtei
    | [<CompiledName "npi_Deva">] Npi_Deva
    | [<CompiledName "ory_Orya">] Ory_Orya
    | [<CompiledName "pan_Guru">] Pan_Guru
    | [<CompiledName "san_Deva">] San_Deva
    | [<CompiledName "sat_Olck">] Sat_Olck
    | [<CompiledName "snd_Arab">] Snd_Arab
    | [<CompiledName "snd_Deva">] Snd_Deva
    | [<CompiledName "tam_Taml">] Tam_Taml
    | [<CompiledName "tel_Telu">] Tel_Telu
    | [<CompiledName "urd_Arab">] Urd_Arab
    | [<CompiledName "unr_Deva">] Unr_Deva
    member this.Format() =
        match this with
        | Asm_Beng -> "asm_Beng"
        | Awa_Deva -> "awa_Deva"
        | Ben_Beng -> "ben_Beng"
        | Bho_Deva -> "bho_Deva"
        | Brx_Deva -> "brx_Deva"
        | Doi_Deva -> "doi_Deva"
        | Eng_Latn -> "eng_Latn"
        | Gom_Deva -> "gom_Deva"
        | Gon_Deva -> "gon_Deva"
        | Guj_Gujr -> "guj_Gujr"
        | Hin_Deva -> "hin_Deva"
        | Hne_Deva -> "hne_Deva"
        | Kan_Knda -> "kan_Knda"
        | Kas_Arab -> "kas_Arab"
        | Kas_Deva -> "kas_Deva"
        | Kha_Latn -> "kha_Latn"
        | Lus_Latn -> "lus_Latn"
        | Mag_Deva -> "mag_Deva"
        | Mai_Deva -> "mai_Deva"
        | Mal_Mlym -> "mal_Mlym"
        | Mar_Deva -> "mar_Deva"
        | Mni_Beng -> "mni_Beng"
        | Mni_Mtei -> "mni_Mtei"
        | Npi_Deva -> "npi_Deva"
        | Ory_Orya -> "ory_Orya"
        | Pan_Guru -> "pan_Guru"
        | San_Deva -> "san_Deva"
        | Sat_Olck -> "sat_Olck"
        | Snd_Arab -> "snd_Arab"
        | Snd_Deva -> "snd_Deva"
        | Tam_Taml -> "tam_Taml"
        | Tel_Telu -> "tel_Telu"
        | Urd_Arab -> "urd_Arab"
        | Unr_Deva -> "unr_Deva"

type WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1bPayload =
    { ///Target langauge to translate to
      target_language: WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1bPayloadTargetlanguage
      ///Input text to translate. Can be a single string or a list of strings.
      text: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (target_language: WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1bPayloadTargetlanguage,
                          text: Newtonsoft.Json.Linq.JToken): WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1bPayload =
        { target_language = target_language
          text = text }

type WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1b_BadRequest =
    { errors: list<WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfAi4bharatOmniIndictrans2EnIndic1b_BadRequest

type WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt_BadRequest =
    { errors: list<WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt_BadRequest

type WorkersAiPostRunCfBaaiBgeBaseEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeBaseEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeBaseEnV15_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeBaseEnV15 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeBaseEnV15_BadRequest

type WorkersAiPostRunCfBaaiBgeLargeEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeLargeEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeLargeEnV15_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeLargeEnV15 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeLargeEnV15_BadRequest

type WorkersAiPostRunCfBaaiBgeM3_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeM3_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeM3_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeM3 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeM3_BadRequest

type Contexts =
    { ///One of the provided context content
      text: Option<string> }
    ///Creates an instance of Contexts with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Contexts = { text = None }

type WorkersAiPostRunCfBaaiBgeRerankerBasePayload =
    { ///List of provided contexts. Note that the index in this array is important, as the response will refer to it.
      contexts: list<Contexts>
      ///A query you wish to perform against the provided contexts.
      query: string
      ///Number of returned results starting with the best score.
      top_k: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfBaaiBgeRerankerBasePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (contexts: list<Contexts>, query: string): WorkersAiPostRunCfBaaiBgeRerankerBasePayload =
        { contexts = contexts
          query = query
          top_k = None }

type WorkersAiPostRunCfBaaiBgeRerankerBase_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeRerankerBase_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeRerankerBase_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeRerankerBase =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeRerankerBase_BadRequest

type WorkersAiPostRunCfBaaiBgeSmallEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeSmallEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeSmallEnV15_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeSmallEnV15 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeSmallEnV15_BadRequest

type WorkersAiPostRunCfBaaiOmniBgeBaseEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiOmniBgeBaseEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiOmniBgeBaseEnV15_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiOmniBgeBaseEnV15 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiOmniBgeBaseEnV15_BadRequest

type WorkersAiPostRunCfBaaiOmniBgeLargeEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiOmniBgeLargeEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiOmniBgeLargeEnV15_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiOmniBgeLargeEnV15 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiOmniBgeLargeEnV15_BadRequest

type WorkersAiPostRunCfBaaiOmniBgeM3_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiOmniBgeM3_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiOmniBgeM3_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiOmniBgeM3 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiOmniBgeM3_BadRequest

type WorkersAiPostRunCfBaaiOmniBgeSmallEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiOmniBgeSmallEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiOmniBgeSmallEnV15_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiOmniBgeSmallEnV15 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiOmniBgeSmallEnV15_BadRequest

type WorkersAiPostRunCfBaaiRayBgeLargeEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiRayBgeLargeEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiRayBgeLargeEnV15_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiRayBgeLargeEnV15 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiRayBgeLargeEnV15_BadRequest

type WorkersAiPostRunCfBlackForestLabsFlux1SchnellPayload =
    { ///A text description of the image you want to generate.
      prompt: string
      ///The number of diffusion steps; higher values can improve quality but take longer.
      steps: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux1SchnellPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfBlackForestLabsFlux1SchnellPayload =
        { prompt = prompt; steps = None }

type WorkersAiPostRunCfBlackForestLabsFlux1Schnell_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBlackForestLabsFlux1Schnell_BadRequest =
    { errors: list<WorkersAiPostRunCfBlackForestLabsFlux1Schnell_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBlackForestLabsFlux1Schnell =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBlackForestLabsFlux1Schnell_BadRequest

type Multipart =
    { body: Option<Newtonsoft.Json.Linq.JObject>
      contentType: Option<string> }
    ///Creates an instance of Multipart with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Multipart = { body = None; contentType = None }

type WorkersAiPostRunCfBlackForestLabsFlux2DevPayload =
    { multipart: Multipart }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2DevPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (multipart: Multipart): WorkersAiPostRunCfBlackForestLabsFlux2DevPayload =
        { multipart = multipart }

type WorkersAiPostRunCfBlackForestLabsFlux2Dev_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBlackForestLabsFlux2Dev_BadRequest =
    { errors: list<WorkersAiPostRunCfBlackForestLabsFlux2Dev_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBlackForestLabsFlux2Dev =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBlackForestLabsFlux2Dev_BadRequest

type WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart =
    { body: Option<Newtonsoft.Json.Linq.JObject>
      contentType: Option<string> }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart =
        { body = None; contentType = None }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayload =
    { multipart: WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (multipart: WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart): WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayload =
        { multipart = multipart }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein4b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein4b_BadRequest =
    { errors: list<WorkersAiPostRunCfBlackForestLabsFlux2Klein4b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBlackForestLabsFlux2Klein4b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBlackForestLabsFlux2Klein4b_BadRequest

type WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart =
    { body: Option<Newtonsoft.Json.Linq.JObject>
      contentType: Option<string> }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart =
        { body = None; contentType = None }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayload =
    { multipart: WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (multipart: WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart): WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayload =
        { multipart = multipart }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein9b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein9b_BadRequest =
    { errors: list<WorkersAiPostRunCfBlackForestLabsFlux2Klein9b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBlackForestLabsFlux2Klein9b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBlackForestLabsFlux2Klein9b_BadRequest

type WorkersAiPostRunCfBytedanceStableDiffusionXlLightningPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfBytedanceStableDiffusionXlLightningPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfBytedanceStableDiffusionXlLightningPayload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfBytedanceStableDiffusionXlLightning_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBytedanceStableDiffusionXlLightning_BadRequest =
    { errors: list<WorkersAiPostRunCfBytedanceStableDiffusionXlLightning_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBytedanceStableDiffusionXlLightning =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBytedanceStableDiffusionXlLightning_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramAura_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfDeepgramAura1_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura1_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura1_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura1 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura1_BadRequest
    | DefaultResponse

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Container =
    | [<CompiledName "none">] None
    | [<CompiledName "wav">] Wav
    | [<CompiledName "ogg">] Ogg
    member this.Format() =
        match this with
        | None -> "none"
        | Wav -> "wav"
        | Ogg -> "ogg"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Encoding =
    | [<CompiledName "linear16">] Linear16
    | [<CompiledName "flac">] Flac
    | [<CompiledName "mulaw">] Mulaw
    | [<CompiledName "alaw">] Alaw
    | [<CompiledName "mp3">] Mp3
    | [<CompiledName "opus">] Opus
    | [<CompiledName "aac">] Aac
    member this.Format() =
        match this with
        | Linear16 -> "linear16"
        | Flac -> "flac"
        | Mulaw -> "mulaw"
        | Alaw -> "alaw"
        | Mp3 -> "mp3"
        | Opus -> "opus"
        | Aac -> "aac"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Speaker =
    | [<CompiledName "angus">] Angus
    | [<CompiledName "asteria">] Asteria
    | [<CompiledName "arcas">] Arcas
    | [<CompiledName "orion">] Orion
    | [<CompiledName "orpheus">] Orpheus
    | [<CompiledName "athena">] Athena
    | [<CompiledName "luna">] Luna
    | [<CompiledName "zeus">] Zeus
    | [<CompiledName "perseus">] Perseus
    | [<CompiledName "helios">] Helios
    | [<CompiledName "hera">] Hera
    | [<CompiledName "stella">] Stella
    member this.Format() =
        match this with
        | Angus -> "angus"
        | Asteria -> "asteria"
        | Arcas -> "arcas"
        | Orion -> "orion"
        | Orpheus -> "orpheus"
        | Athena -> "athena"
        | Luna -> "luna"
        | Zeus -> "zeus"
        | Perseus -> "perseus"
        | Helios -> "helios"
        | Hera -> "hera"
        | Stella -> "stella"

type WorkersAiPostRunCfDeepgramAura1Payload =
    { ///The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
      bit_rate: Option<float>
      ///Container specifies the file format wrapper for the output audio. The available options depend on the encoding type..
      container: Option<Container>
      ///Encoding of the output audio.
      encoding: Option<Encoding>
      ///Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
      sample_rate: Option<float>
      ///Speaker used to produce the audio.
      speaker: Option<Speaker>
      ///The text content to be converted to speech
      text: string }
    ///Creates an instance of WorkersAiPostRunCfDeepgramAura1Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: string): WorkersAiPostRunCfDeepgramAura1Payload =
        { bit_rate = None
          container = None
          encoding = None
          sample_rate = None
          speaker = None
          text = text }

type WorkersAiPostRunCfDeepgramAura1_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramAura1_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramAura1_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura1 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramAura1_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramAura1Internal_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura1Internal_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura1Internal_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura1Internal =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura1Internal_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfDeepgramAura2_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura2_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura2_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura2 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura2_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfDeepgramAura2En_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura2En_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura2En_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura2En =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura2En_BadRequest
    | DefaultResponse

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EnPayloadContainer =
    | [<CompiledName "none">] None
    | [<CompiledName "wav">] Wav
    | [<CompiledName "ogg">] Ogg
    member this.Format() =
        match this with
        | None -> "none"
        | Wav -> "wav"
        | Ogg -> "ogg"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EnPayloadEncoding =
    | [<CompiledName "linear16">] Linear16
    | [<CompiledName "flac">] Flac
    | [<CompiledName "mulaw">] Mulaw
    | [<CompiledName "alaw">] Alaw
    | [<CompiledName "mp3">] Mp3
    | [<CompiledName "opus">] Opus
    | [<CompiledName "aac">] Aac
    member this.Format() =
        match this with
        | Linear16 -> "linear16"
        | Flac -> "flac"
        | Mulaw -> "mulaw"
        | Alaw -> "alaw"
        | Mp3 -> "mp3"
        | Opus -> "opus"
        | Aac -> "aac"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EnPayloadSpeaker =
    | [<CompiledName "amalthea">] Amalthea
    | [<CompiledName "andromeda">] Andromeda
    | [<CompiledName "apollo">] Apollo
    | [<CompiledName "arcas">] Arcas
    | [<CompiledName "aries">] Aries
    | [<CompiledName "asteria">] Asteria
    | [<CompiledName "athena">] Athena
    | [<CompiledName "atlas">] Atlas
    | [<CompiledName "aurora">] Aurora
    | [<CompiledName "callista">] Callista
    | [<CompiledName "cora">] Cora
    | [<CompiledName "cordelia">] Cordelia
    | [<CompiledName "delia">] Delia
    | [<CompiledName "draco">] Draco
    | [<CompiledName "electra">] Electra
    | [<CompiledName "harmonia">] Harmonia
    | [<CompiledName "helena">] Helena
    | [<CompiledName "hera">] Hera
    | [<CompiledName "hermes">] Hermes
    | [<CompiledName "hyperion">] Hyperion
    | [<CompiledName "iris">] Iris
    | [<CompiledName "janus">] Janus
    | [<CompiledName "juno">] Juno
    | [<CompiledName "jupiter">] Jupiter
    | [<CompiledName "luna">] Luna
    | [<CompiledName "mars">] Mars
    | [<CompiledName "minerva">] Minerva
    | [<CompiledName "neptune">] Neptune
    | [<CompiledName "odysseus">] Odysseus
    | [<CompiledName "ophelia">] Ophelia
    | [<CompiledName "orion">] Orion
    | [<CompiledName "orpheus">] Orpheus
    | [<CompiledName "pandora">] Pandora
    | [<CompiledName "phoebe">] Phoebe
    | [<CompiledName "pluto">] Pluto
    | [<CompiledName "saturn">] Saturn
    | [<CompiledName "thalia">] Thalia
    | [<CompiledName "theia">] Theia
    | [<CompiledName "vesta">] Vesta
    | [<CompiledName "zeus">] Zeus
    member this.Format() =
        match this with
        | Amalthea -> "amalthea"
        | Andromeda -> "andromeda"
        | Apollo -> "apollo"
        | Arcas -> "arcas"
        | Aries -> "aries"
        | Asteria -> "asteria"
        | Athena -> "athena"
        | Atlas -> "atlas"
        | Aurora -> "aurora"
        | Callista -> "callista"
        | Cora -> "cora"
        | Cordelia -> "cordelia"
        | Delia -> "delia"
        | Draco -> "draco"
        | Electra -> "electra"
        | Harmonia -> "harmonia"
        | Helena -> "helena"
        | Hera -> "hera"
        | Hermes -> "hermes"
        | Hyperion -> "hyperion"
        | Iris -> "iris"
        | Janus -> "janus"
        | Juno -> "juno"
        | Jupiter -> "jupiter"
        | Luna -> "luna"
        | Mars -> "mars"
        | Minerva -> "minerva"
        | Neptune -> "neptune"
        | Odysseus -> "odysseus"
        | Ophelia -> "ophelia"
        | Orion -> "orion"
        | Orpheus -> "orpheus"
        | Pandora -> "pandora"
        | Phoebe -> "phoebe"
        | Pluto -> "pluto"
        | Saturn -> "saturn"
        | Thalia -> "thalia"
        | Theia -> "theia"
        | Vesta -> "vesta"
        | Zeus -> "zeus"

type WorkersAiPostRunCfDeepgramAura2EnPayload =
    { ///The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
      bit_rate: Option<float>
      ///Container specifies the file format wrapper for the output audio. The available options depend on the encoding type..
      container: Option<WorkersAiPostRunCfDeepgramAura2EnPayloadContainer>
      ///Encoding of the output audio.
      encoding: Option<WorkersAiPostRunCfDeepgramAura2EnPayloadEncoding>
      ///Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
      sample_rate: Option<float>
      ///Speaker used to produce the audio.
      speaker: Option<WorkersAiPostRunCfDeepgramAura2EnPayloadSpeaker>
      ///The text content to be converted to speech
      text: string }
    ///Creates an instance of WorkersAiPostRunCfDeepgramAura2EnPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: string): WorkersAiPostRunCfDeepgramAura2EnPayload =
        { bit_rate = None
          container = None
          encoding = None
          sample_rate = None
          speaker = None
          text = text }

type WorkersAiPostRunCfDeepgramAura2En_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramAura2En_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramAura2En_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2En =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramAura2En_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramAura2Es_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura2Es_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura2Es_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura2Es =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura2Es_BadRequest
    | DefaultResponse

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EsPayloadContainer =
    | [<CompiledName "none">] None
    | [<CompiledName "wav">] Wav
    | [<CompiledName "ogg">] Ogg
    member this.Format() =
        match this with
        | None -> "none"
        | Wav -> "wav"
        | Ogg -> "ogg"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EsPayloadEncoding =
    | [<CompiledName "linear16">] Linear16
    | [<CompiledName "flac">] Flac
    | [<CompiledName "mulaw">] Mulaw
    | [<CompiledName "alaw">] Alaw
    | [<CompiledName "mp3">] Mp3
    | [<CompiledName "opus">] Opus
    | [<CompiledName "aac">] Aac
    member this.Format() =
        match this with
        | Linear16 -> "linear16"
        | Flac -> "flac"
        | Mulaw -> "mulaw"
        | Alaw -> "alaw"
        | Mp3 -> "mp3"
        | Opus -> "opus"
        | Aac -> "aac"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EsPayloadSpeaker =
    | [<CompiledName "sirio">] Sirio
    | [<CompiledName "nestor">] Nestor
    | [<CompiledName "carina">] Carina
    | [<CompiledName "celeste">] Celeste
    | [<CompiledName "alvaro">] Alvaro
    | [<CompiledName "diana">] Diana
    | [<CompiledName "aquila">] Aquila
    | [<CompiledName "selena">] Selena
    | [<CompiledName "estrella">] Estrella
    | [<CompiledName "javier">] Javier
    member this.Format() =
        match this with
        | Sirio -> "sirio"
        | Nestor -> "nestor"
        | Carina -> "carina"
        | Celeste -> "celeste"
        | Alvaro -> "alvaro"
        | Diana -> "diana"
        | Aquila -> "aquila"
        | Selena -> "selena"
        | Estrella -> "estrella"
        | Javier -> "javier"

type WorkersAiPostRunCfDeepgramAura2EsPayload =
    { ///The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
      bit_rate: Option<float>
      ///Container specifies the file format wrapper for the output audio. The available options depend on the encoding type..
      container: Option<WorkersAiPostRunCfDeepgramAura2EsPayloadContainer>
      ///Encoding of the output audio.
      encoding: Option<WorkersAiPostRunCfDeepgramAura2EsPayloadEncoding>
      ///Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
      sample_rate: Option<float>
      ///Speaker used to produce the audio.
      speaker: Option<WorkersAiPostRunCfDeepgramAura2EsPayloadSpeaker>
      ///The text content to be converted to speech
      text: string }
    ///Creates an instance of WorkersAiPostRunCfDeepgramAura2EsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: string): WorkersAiPostRunCfDeepgramAura2EsPayload =
        { bit_rate = None
          container = None
          encoding = None
          sample_rate = None
          speaker = None
          text = text }

type WorkersAiPostRunCfDeepgramAura2Es_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramAura2Es_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramAura2Es_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2Es =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramAura2Es_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramFlux_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramFlux_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramFlux_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramFlux =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramFlux_BadRequest
    | DefaultResponse

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramFluxPayloadEncoding =
    | [<CompiledName "linear16">] Linear16
    member this.Format() =
        match this with
        | Linear16 -> "linear16"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Mipoptout =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type WorkersAiPostRunCfDeepgramFluxPayload =
    { ///End-of-turn confidence required to fire an eager end-of-turn event. When set, enables EagerEndOfTurn and TurnResumed events. Valid Values 0.3 - 0.9.
      eager_eot_threshold: Option<string>
      ///Encoding of the audio stream. Currently only supports raw signed little-endian 16-bit PCM.
      encoding: WorkersAiPostRunCfDeepgramFluxPayloadEncoding
      ///End-of-turn confidence required to finish a turn. Valid Values 0.5 - 0.9.
      eot_threshold: Option<string>
      ///A turn will be finished when this much time has passed after speech, regardless of EOT confidence.
      eot_timeout_ms: Option<string>
      ///Keyterm prompting can improve recognition of specialized terminology. Pass multiple keyterm query parameters to boost multiple keyterms.
      keyterm: Option<string>
      ///Opts out requests from the Deepgram Model Improvement Program. Refer to Deepgram Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip
      mip_opt_out: Option<Mipoptout>
      ///Sample rate of the audio stream in Hz.
      sample_rate: string
      ///Label your requests for the purpose of identification during usage reporting
      tag: Option<string> }
    ///Creates an instance of WorkersAiPostRunCfDeepgramFluxPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (encoding: WorkersAiPostRunCfDeepgramFluxPayloadEncoding, sample_rate: string): WorkersAiPostRunCfDeepgramFluxPayload =
        { eager_eot_threshold = None
          encoding = encoding
          eot_threshold = None
          eot_timeout_ms = None
          keyterm = None
          mip_opt_out = None
          sample_rate = sample_rate
          tag = None }

type WorkersAiPostRunCfDeepgramFlux_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramFlux_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramFlux_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramFlux =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramFlux_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramNova3_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramNova3_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramNova3_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramNova3 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramNova3_BadRequest
    | DefaultResponse

type Audio =
    { body: Newtonsoft.Json.Linq.JObject
      contentType: string }
    ///Creates an instance of Audio with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (body: Newtonsoft.Json.Linq.JObject, contentType: string): Audio =
        { body = body
          contentType = contentType }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Customintentmode =
    | [<CompiledName "extended">] Extended
    | [<CompiledName "strict">] Strict
    member this.Format() =
        match this with
        | Extended -> "extended"
        | Strict -> "strict"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Customtopicmode =
    | [<CompiledName "extended">] Extended
    | [<CompiledName "strict">] Strict
    member this.Format() =
        match this with
        | Extended -> "extended"
        | Strict -> "strict"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramNova3PayloadEncoding =
    | [<CompiledName "linear16">] Linear16
    | [<CompiledName "flac">] Flac
    | [<CompiledName "mulaw">] Mulaw
    | [<CompiledName "amr-nb">] AmrNb
    | [<CompiledName "amr-wb">] AmrWb
    | [<CompiledName "opus">] Opus
    | [<CompiledName "speex">] Speex
    | [<CompiledName "g729">] G729
    member this.Format() =
        match this with
        | Linear16 -> "linear16"
        | Flac -> "flac"
        | Mulaw -> "mulaw"
        | AmrNb -> "amr-nb"
        | AmrWb -> "amr-wb"
        | Opus -> "opus"
        | Speex -> "speex"
        | G729 -> "g729"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Mode =
    | [<CompiledName "general">] General
    | [<CompiledName "medical">] Medical
    | [<CompiledName "finance">] Finance
    member this.Format() =
        match this with
        | General -> "general"
        | Medical -> "medical"
        | Finance -> "finance"

type WorkersAiPostRunCfDeepgramNova3Payload =
    { audio: Audio
      ///The number of channels in the submitted audio
      channels: Option<float>
      ///Custom intents you want the model to detect within your input audio if present
      custom_intent: Option<string>
      ///Sets how the model will interpret intents submitted to the custom_intent param. When strict, the model will only return intents submitted using the custom_intent param. When extended, the model will return its own detected intents in addition those submitted using the custom_intents param
      custom_intent_mode: Option<Customintentmode>
      ///Custom topics you want the model to detect within your input audio or text if present Submit up to 100
      custom_topic: Option<string>
      ///Sets how the model will interpret strings submitted to the custom_topic param. When strict, the model will only return topics submitted using the custom_topic param. When extended, the model will return its own detected topics in addition to those submitted using the custom_topic param.
      custom_topic_mode: Option<Customtopicmode>
      ///Identifies and extracts key entities from content in submitted audio
      detect_entities: Option<bool>
      ///Identifies the dominant language spoken in submitted audio
      detect_language: Option<bool>
      ///Recognize speaker changes. Each word in the transcript will be assigned a speaker number starting at 0
      diarize: Option<bool>
      ///Identify and extract key entities from content in submitted audio
      dictation: Option<bool>
      ///Specify the expected encoding of your submitted audio
      encoding: Option<WorkersAiPostRunCfDeepgramNova3PayloadEncoding>
      ///Indicates how long model will wait to detect whether a speaker has finished speaking or pauses for a significant period of time. When set to a value, the streaming endpoint immediately finalizes the transcription for the processed time range and returns the transcript with a speech_final parameter set to true. Can also be set to false to disable endpointing
      endpointing: Option<string>
      ///Arbitrary key-value pairs that are attached to the API response for usage in downstream processing
      extra: Option<string>
      ///Filler Words can help transcribe interruptions in your audio, like 'uh' and 'um'
      filler_words: Option<bool>
      ///Specifies whether the streaming endpoint should provide ongoing transcription updates as more audio is received. When set to true, the endpoint sends continuous updates, meaning transcription results may evolve over time. Note: Supported only for webosockets.
      interim_results: Option<bool>
      ///Key term prompting can boost or suppress specialized terminology and brands.
      keyterm: Option<string>
      ///Keywords can boost or suppress specialized terminology and brands.
      keywords: Option<string>
      ///The BCP-47 language tag that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available.
      language: Option<string>
      ///Spoken measurements will be converted to their corresponding abbreviations.
      measurements: Option<bool>
      ///Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip.
      mip_opt_out: Option<bool>
      ///Mode of operation for the model representing broad area of topic that will be talked about in the supplied audio
      mode: Option<Mode>
      ///Transcribe each audio channel independently.
      multichannel: Option<bool>
      ///Numerals converts numbers from written format to numerical format.
      numerals: Option<bool>
      ///Splits audio into paragraphs to improve transcript readability.
      paragraphs: Option<bool>
      ///Profanity Filter looks for recognized profanity and converts it to the nearest recognized non-profane word or removes it from the transcript completely.
      profanity_filter: Option<bool>
      ///Add punctuation and capitalization to the transcript.
      punctuate: Option<bool>
      ///Redaction removes sensitive information from your transcripts.
      redact: Option<string>
      ///Search for terms or phrases in submitted audio and replaces them.
      replace: Option<string>
      ///Search for terms or phrases in submitted audio.
      search: Option<string>
      ///Recognizes the sentiment throughout a transcript or text.
      sentiment: Option<bool>
      ///Apply formatting to transcript output. When set to true, additional formatting will be applied to transcripts to improve readability.
      smart_format: Option<bool>
      ///Detect topics throughout a transcript or text.
      topics: Option<bool>
      ///Seconds to wait before detecting a pause between words in submitted audio.
      utt_split: Option<float>
      ///Indicates how long model will wait to send an UtteranceEnd message after a word has been transcribed. Use with interim_results. Note: Supported only for webosockets.
      utterance_end_ms: Option<bool>
      ///Segments speech into meaningful semantic units.
      utterances: Option<bool>
      ///Indicates that speech has started. You'll begin receiving Speech Started messages upon speech starting. Note: Supported only for webosockets.
      vad_events: Option<bool> }
    ///Creates an instance of WorkersAiPostRunCfDeepgramNova3Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (audio: Audio): WorkersAiPostRunCfDeepgramNova3Payload =
        { audio = audio
          channels = None
          custom_intent = None
          custom_intent_mode = None
          custom_topic = None
          custom_topic_mode = None
          detect_entities = None
          detect_language = None
          diarize = None
          dictation = None
          encoding = None
          endpointing = None
          extra = None
          filler_words = None
          interim_results = None
          keyterm = None
          keywords = None
          language = None
          measurements = None
          mip_opt_out = None
          mode = None
          multichannel = None
          numerals = None
          paragraphs = None
          profanity_filter = None
          punctuate = None
          redact = None
          replace = None
          search = None
          sentiment = None
          smart_format = None
          topics = None
          utt_split = None
          utterance_end_ms = None
          utterances = None
          vad_events = None }

type WorkersAiPostRunCfDeepgramNova3_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramNova3_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramNova3_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramNova3 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramNova3_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramNova3Internal_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramNova3Internal_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramNova3Internal_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramNova3Internal =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramNova3Internal_BadRequest
    | DefaultResponse

type WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct_BadRequest

type WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b_BadRequest

type WorkersAiPostRunCfDefogSqlcoder7b2_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDefogSqlcoder7b2_BadRequest =
    { errors: list<WorkersAiPostRunCfDefogSqlcoder7b2_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDefogSqlcoder7b2 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDefogSqlcoder7b2_BadRequest

type WorkersAiPostRunCfFacebookBartLargeCnnPayload =
    { ///The text that you want the model to summarize
      input_text: string
      ///The maximum length of the generated summary in tokens
      max_length: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfFacebookBartLargeCnnPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (input_text: string): WorkersAiPostRunCfFacebookBartLargeCnnPayload =
        { input_text = input_text
          max_length = None }

type WorkersAiPostRunCfFacebookBartLargeCnn_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfFacebookBartLargeCnn_BadRequest =
    { errors: list<WorkersAiPostRunCfFacebookBartLargeCnn_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfFacebookBartLargeCnn =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfFacebookBartLargeCnn_BadRequest

type WorkersAiPostRunCfFacebookNonomniBartLargeCnnPayload =
    { ///The text that you want the model to summarize
      input_text: string
      ///The maximum length of the generated summary in tokens
      max_length: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfFacebookNonomniBartLargeCnnPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (input_text: string): WorkersAiPostRunCfFacebookNonomniBartLargeCnnPayload =
        { input_text = input_text
          max_length = None }

type WorkersAiPostRunCfFacebookNonomniBartLargeCnn_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfFacebookNonomniBartLargeCnn_BadRequest =
    { errors: list<WorkersAiPostRunCfFacebookNonomniBartLargeCnn_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfFacebookNonomniBartLargeCnn =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfFacebookNonomniBartLargeCnn_BadRequest

type WorkersAiPostRunCfFacebookNonomniDetrResnet50_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfFacebookNonomniDetrResnet50_BadRequest =
    { errors: list<WorkersAiPostRunCfFacebookNonomniDetrResnet50_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfFacebookNonomniDetrResnet50 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfFacebookNonomniDetrResnet50_BadRequest

type WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16_BadRequest =
    { errors: list<WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16_BadRequest

type WorkersAiPostRunCfGoogleEmbeddinggemma300mPayload =
    { text: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of WorkersAiPostRunCfGoogleEmbeddinggemma300mPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: Newtonsoft.Json.Linq.JToken): WorkersAiPostRunCfGoogleEmbeddinggemma300mPayload =
        { text = text }

type WorkersAiPostRunCfGoogleEmbeddinggemma300m_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleEmbeddinggemma300m_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleEmbeddinggemma300m_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleEmbeddinggemma300m =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleEmbeddinggemma300m_BadRequest

type WorkersAiPostRunCfGoogleGemma2bItLora_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleGemma2bItLora_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleGemma2bItLora_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleGemma2bItLora =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleGemma2bItLora_BadRequest

type WorkersAiPostRunCfGoogleGemma312bIt_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleGemma312bIt_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleGemma312bIt_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleGemma312bIt =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleGemma312bIt_BadRequest

type WorkersAiPostRunCfGoogleGemma7bItLora_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleGemma7bItLora_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleGemma7bItLora_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleGemma7bItLora =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleGemma7bItLora_BadRequest

type WorkersAiPostRunCfGoogleOmniEmbeddinggemma300mPayload =
    { ///Input text to embed. Can be a single string or a list of strings.
      text: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of WorkersAiPostRunCfGoogleOmniEmbeddinggemma300mPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: Newtonsoft.Json.Linq.JToken): WorkersAiPostRunCfGoogleOmniEmbeddinggemma300mPayload =
        { text = text }

type WorkersAiPostRunCfGoogleOmniEmbeddinggemma300m_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleOmniEmbeddinggemma300m_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleOmniEmbeddinggemma300m_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleOmniEmbeddinggemma300m =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleOmniEmbeddinggemma300m_BadRequest

type WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8Payload =
    { ///The text that you want to classify
      text: string }
    ///Creates an instance of WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: string): WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8Payload = { text = text }

type WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8_BadRequest =
    { errors: list<WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8_BadRequest

type WorkersAiPostRunCfIbmGraniteGranite40HMicro_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfIbmGraniteGranite40HMicro_BadRequest =
    { errors: list<WorkersAiPostRunCfIbmGraniteGranite40HMicro_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfIbmGraniteGranite40HMicro =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfIbmGraniteGranite40HMicro_BadRequest

type WorkersAiPostRunCfLeonardoLucidOriginPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate.
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///The number of diffusion steps; higher values can improve quality but take longer
      steps: Option<int>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfLeonardoLucidOriginPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfLeonardoLucidOriginPayload =
        { guidance = None
          height = None
          num_steps = None
          prompt = prompt
          seed = None
          steps = None
          width = None }

type WorkersAiPostRunCfLeonardoLucidOrigin_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfLeonardoLucidOrigin_BadRequest =
    { errors: list<WorkersAiPostRunCfLeonardoLucidOrigin_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfLeonardoLucidOrigin =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfLeonardoLucidOrigin_BadRequest

type WorkersAiPostRunCfLeonardoPhoenix10Payload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///Specify what to exclude from the generated images
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate.
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfLeonardoPhoenix10Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfLeonardoPhoenix10Payload =
        { guidance = None
          height = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          width = None }

type WorkersAiPostRunCfLeonardoPhoenix10_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfLeonardoPhoenix10_BadRequest =
    { errors: list<WorkersAiPostRunCfLeonardoPhoenix10_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfLeonardoPhoenix10 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfLeonardoPhoenix10_BadRequest

type WorkersAiPostRunCfLykonDreamshaper8LcmPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfLykonDreamshaper8LcmPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfLykonDreamshaper8LcmPayload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfLykonDreamshaper8Lcm_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfLykonDreamshaper8Lcm_BadRequest =
    { errors: list<WorkersAiPostRunCfLykonDreamshaper8Lcm_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfLykonDreamshaper8Lcm =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfLykonDreamshaper8Lcm_BadRequest

type WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora_BadRequest

type WorkersAiPostRunCfMetaLlama27bChatFp16_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama27bChatFp16_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama27bChatFp16_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama27bChatFp16 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama27bChatFp16_BadRequest

type WorkersAiPostRunCfMetaLlama27bChatInt8_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama27bChatInt8_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama27bChatInt8_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama27bChatInt8 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama27bChatInt8_BadRequest

type WorkersAiPostRunCfMetaLlama38bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama38bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama38bInstruct_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama38bInstruct =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama38bInstruct_BadRequest

type WorkersAiPostRunCfMetaLlama38bInstructAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama38bInstructAwq_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama38bInstructAwq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama38bInstructAwq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama38bInstructAwq_BadRequest

type WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast_BadRequest

type WorkersAiPostRunCfMetaLlama318bInstructAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama318bInstructAwq_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama318bInstructAwq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama318bInstructAwq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama318bInstructAwq_BadRequest

type WorkersAiPostRunCfMetaLlama318bInstructFp8_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama318bInstructFp8_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama318bInstructFp8_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama318bInstructFp8 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama318bInstructFp8_BadRequest

type WorkersAiPostRunCfMetaLlama318bInstructFp8Fast_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama318bInstructFp8Fast_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama318bInstructFp8Fast_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama318bInstructFp8Fast =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama318bInstructFp8Fast_BadRequest

type WorkersAiPostRunCfMetaLlama3211bVisionInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama3211bVisionInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama3211bVisionInstruct_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama3211bVisionInstruct =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama3211bVisionInstruct_BadRequest

type WorkersAiPostRunCfMetaLlama321bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama321bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama321bInstruct_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama321bInstruct =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama321bInstruct_BadRequest

type WorkersAiPostRunCfMetaLlama323bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama323bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama323bInstruct_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama323bInstruct =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama323bInstruct_BadRequest

type WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast_BadRequest

type WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessagesRole =
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    member this.Format() =
        match this with
        | User -> "user"
        | Assistant -> "assistant"

type WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages =
    { ///The content of the message as a string.
      content: string
      ///The role of the message sender must alternate between 'user' and 'assistant'.
      role: WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessagesRole }
    ///Creates an instance of WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessagesRole): WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages =
        { content = content; role = role }

///Dictate the output format of the generated response.
type Responseformat =
    { ///Set to json_object to process and output generated text as JSON.
      ``type``: Option<string> }
    ///Creates an instance of Responseformat with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Responseformat = { ``type`` = None }

type WorkersAiPostRunCfMetaLlamaGuard38bPayload =
    { ///The maximum number of tokens to generate in the response.
      max_tokens: Option<int>
      ///An array of message objects representing the conversation history.
      messages: list<WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages>
      ///Dictate the output format of the generated response.
      response_format: Option<Responseformat>
      ///Controls the randomness of the output; higher values produce more random results.
      temperature: Option<float> }
    ///Creates an instance of WorkersAiPostRunCfMetaLlamaGuard38bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages>): WorkersAiPostRunCfMetaLlamaGuard38bPayload =
        { max_tokens = None
          messages = messages
          response_format = None
          temperature = None }

type WorkersAiPostRunCfMetaLlamaGuard38b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlamaGuard38b_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlamaGuard38b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlamaGuard38b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlamaGuard38b_BadRequest

type WorkersAiPostRunCfMetaM2m10012b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaM2m10012b_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaM2m10012b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaM2m10012b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaM2m10012b_BadRequest

type WorkersAiPostRunCfMicrosoftNonomniResnet50_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMicrosoftNonomniResnet50_BadRequest =
    { errors: list<WorkersAiPostRunCfMicrosoftNonomniResnet50_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMicrosoftNonomniResnet50 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMicrosoftNonomniResnet50_BadRequest

type WorkersAiPostRunCfMicrosoftPhi2_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMicrosoftPhi2_BadRequest =
    { errors: list<WorkersAiPostRunCfMicrosoftPhi2_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMicrosoftPhi2 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMicrosoftPhi2_BadRequest

type WorkersAiPostRunCfMicrosoftResnet50_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMicrosoftResnet50_BadRequest =
    { errors: list<WorkersAiPostRunCfMicrosoftResnet50_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMicrosoftResnet50 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMicrosoftResnet50_BadRequest

type WorkersAiPostRunCfMistralMistral7bInstructV01_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMistralMistral7bInstructV01_BadRequest =
    { errors: list<WorkersAiPostRunCfMistralMistral7bInstructV01_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMistralMistral7bInstructV01 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMistralMistral7bInstructV01_BadRequest

type WorkersAiPostRunCfMistralMistral7bInstructV02Lora_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMistralMistral7bInstructV02Lora_BadRequest =
    { errors: list<WorkersAiPostRunCfMistralMistral7bInstructV02Lora_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMistralMistral7bInstructV02Lora =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMistralMistral7bInstructV02Lora_BadRequest

type WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct_BadRequest

type WorkersAiPostRunCfMyshellAiMelottsPayload =
    { ///The speech language (e.g., 'en' for English, 'fr' for French). Defaults to 'en' if not specified
      lang: Option<string>
      ///A text description of the audio you want to generate
      prompt: string }
    ///Creates an instance of WorkersAiPostRunCfMyshellAiMelottsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfMyshellAiMelottsPayload = { lang = None; prompt = prompt }

type WorkersAiPostRunCfMyshellAiMelotts_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMyshellAiMelotts_BadRequest =
    { errors: list<WorkersAiPostRunCfMyshellAiMelotts_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMyshellAiMelotts =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMyshellAiMelotts_BadRequest

type WorkersAiPostRunCfOpenaiGptOss120b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiGptOss120b_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiGptOss120b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiGptOss120b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiGptOss120b_BadRequest

type WorkersAiPostRunCfOpenaiGptOss20b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiGptOss20b_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiGptOss20b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiGptOss20b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiGptOss20b_BadRequest

type WorkersAiPostRunCfOpenaiWhisper_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiWhisper_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiWhisper_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiWhisper =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiWhisper_BadRequest

type WorkersAiPostRunCfOpenaiWhisperLargeV3TurboPayload =
    { audio: Newtonsoft.Json.Linq.JToken
      ///The number of beams to use in beam search decoding. Higher values may improve accuracy at the cost of speed.
      beam_size: Option<int>
      ///Threshold for filtering out segments with high compression ratio, which often indicate repetitive or hallucinated text.
      compression_ratio_threshold: Option<float>
      ///Whether to condition on previous text during transcription. Setting to false may help prevent hallucination loops.
      condition_on_previous_text: Option<bool>
      ///Optional threshold (in seconds) to skip silent periods that may cause hallucinations.
      hallucination_silence_threshold: Option<float>
      ///A text prompt to help provide context to the model on the contents of the audio.
      initial_prompt: Option<string>
      ///The language of the audio being transcribed or translated.
      language: Option<string>
      ///Threshold for filtering out segments with low average log probability, indicating low confidence.
      log_prob_threshold: Option<float>
      ///Threshold for detecting no-speech segments. Segments with no-speech probability above this value are skipped.
      no_speech_threshold: Option<float>
      ///The prefix appended to the beginning of the output of the transcription and can guide the transcription result.
      prefix: Option<string>
      ///Supported tasks are 'translate' or 'transcribe'.
      task: Option<string>
      ///Preprocess the audio with a voice activity detection model.
      vad_filter: Option<bool> }
    ///Creates an instance of WorkersAiPostRunCfOpenaiWhisperLargeV3TurboPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (audio: Newtonsoft.Json.Linq.JToken): WorkersAiPostRunCfOpenaiWhisperLargeV3TurboPayload =
        { audio = audio
          beam_size = None
          compression_ratio_threshold = None
          condition_on_previous_text = None
          hallucination_silence_threshold = None
          initial_prompt = None
          language = None
          log_prob_threshold = None
          no_speech_threshold = None
          prefix = None
          task = None
          vad_filter = None }

type WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo_BadRequest

type WorkersAiPostRunCfOpenaiWhisperTinyEn_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiWhisperTinyEn_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiWhisperTinyEn_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiWhisperTinyEn =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiWhisperTinyEn_BadRequest

type WorkersAiPostRunCfOpenchatOpenchat350106_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenchatOpenchat350106_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenchatOpenchat350106_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenchatOpenchat350106 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenchatOpenchat350106_BadRequest

type WorkersAiPostRunCfPfnetPlamoEmbedding1bPayload =
    { ///Input text to embed. Can be a single string or a list of strings.
      text: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of WorkersAiPostRunCfPfnetPlamoEmbedding1bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: Newtonsoft.Json.Linq.JToken): WorkersAiPostRunCfPfnetPlamoEmbedding1bPayload =
        { text = text }

type WorkersAiPostRunCfPfnetPlamoEmbedding1b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfPfnetPlamoEmbedding1b_BadRequest =
    { errors: list<WorkersAiPostRunCfPfnetPlamoEmbedding1b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfPfnetPlamoEmbedding1b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfPfnetPlamoEmbedding1b_BadRequest

type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3_BadRequest
    | DefaultResponse

type WorkersAiPostRunCfQwenQwen1505bChat_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen1505bChat_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen1505bChat_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen1505bChat =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen1505bChat_BadRequest

type WorkersAiPostRunCfQwenQwen1518bChat_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen1518bChat_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen1518bChat_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen1518bChat =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen1518bChat_BadRequest

type WorkersAiPostRunCfQwenQwen1514bChatAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen1514bChatAwq_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen1514bChatAwq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen1514bChatAwq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen1514bChatAwq_BadRequest

type WorkersAiPostRunCfQwenQwen157bChatAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen157bChatAwq_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen157bChatAwq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen157bChatAwq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen157bChatAwq_BadRequest

type WorkersAiPostRunCfQwenQwen25Coder32bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen25Coder32bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen25Coder32bInstruct_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen25Coder32bInstruct =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen25Coder32bInstruct_BadRequest

type WorkersAiPostRunCfQwenQwen330bA3bFp8_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen330bA3bFp8_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen330bA3bFp8_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen330bA3bFp8 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen330bA3bFp8_BadRequest

type WorkersAiPostRunCfQwenQwen3Embedding06bPayload =
    { documents: Option<Newtonsoft.Json.Linq.JToken>
      ///Optional instruction for the task
      instruction: Option<string>
      queries: Option<Newtonsoft.Json.Linq.JToken>
      text: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of WorkersAiPostRunCfQwenQwen3Embedding06bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorkersAiPostRunCfQwenQwen3Embedding06bPayload =
        { documents = None
          instruction = None
          queries = None
          text = None }

type WorkersAiPostRunCfQwenQwen3Embedding06b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen3Embedding06b_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen3Embedding06b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen3Embedding06b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen3Embedding06b_BadRequest

type WorkersAiPostRunCfQwenQwq32b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwq32b_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwq32b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwq32b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwq32b_BadRequest

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2imgPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2imgPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2imgPayload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img_BadRequest =
    { errors: list<WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img_BadRequest

type WorkersAiPostRunCfRunwaymlStableDiffusionV15InpaintingPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfRunwaymlStableDiffusionV15InpaintingPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfRunwaymlStableDiffusionV15InpaintingPayload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting_BadRequest =
    { errors: list<WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting_BadRequest

type WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10Payload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10Payload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10_BadRequest =
    { errors: list<WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10_BadRequest

type WorkersAiPostWebsocketRunCfSvenTestPipeHttp_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfSvenTestPipeHttp_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfSvenTestPipeHttp_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfSvenTestPipeHttp =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfSvenTestPipeHttp_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfTestHelloWorldCog_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfTestHelloWorldCog_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfTestHelloWorldCog_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfTestHelloWorldCog =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfTestHelloWorldCog_BadRequest
    | DefaultResponse

type WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq_BadRequest =
    { errors: list<WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq_BadRequest

type WorkersAiPostRunCfTiiuaeFalcon7bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfTiiuaeFalcon7bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfTiiuaeFalcon7bInstruct_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfTiiuaeFalcon7bInstruct =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfTiiuaeFalcon7bInstruct_BadRequest

type WorkersAiPostRunCfTinyllamaTinyllama11bChatV10_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfTinyllamaTinyllama11bChatV10_BadRequest =
    { errors: list<WorkersAiPostRunCfTinyllamaTinyllama11bChatV10_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfTinyllamaTinyllama11bChatV10 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfTinyllamaTinyllama11bChatV10_BadRequest

type WorkersAiPostRunCfZaiOrgGlm47Flash_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfZaiOrgGlm47Flash_BadRequest =
    { errors: list<WorkersAiPostRunCfZaiOrgGlm47Flash_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfZaiOrgGlm47Flash =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfZaiOrgGlm47Flash_BadRequest

type WorkersAiPostRunHfGoogleGemma7bIt_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfGoogleGemma7bIt_BadRequest =
    { errors: list<WorkersAiPostRunHfGoogleGemma7bIt_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfGoogleGemma7bIt =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfGoogleGemma7bIt_BadRequest

type WorkersAiPostRunHfMistralMistral7bInstructV02_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfMistralMistral7bInstructV02_BadRequest =
    { errors: list<WorkersAiPostRunHfMistralMistral7bInstructV02_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfMistralMistral7bInstructV02 =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfMistralMistral7bInstructV02_BadRequest

type WorkersAiPostRunHfNexusflowStarlingLm7bBeta_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfNexusflowStarlingLm7bBeta_BadRequest =
    { errors: list<WorkersAiPostRunHfNexusflowStarlingLm7bBeta_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfNexusflowStarlingLm7bBeta =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfNexusflowStarlingLm7bBeta_BadRequest

type WorkersAiPostRunHfNousresearchHermes2ProMistral7b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfNousresearchHermes2ProMistral7b_BadRequest =
    { errors: list<WorkersAiPostRunHfNousresearchHermes2ProMistral7b_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfNousresearchHermes2ProMistral7b =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfNousresearchHermes2ProMistral7b_BadRequest

type WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq_BadRequest

type WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq_BadRequest

type WorkersAiPostRunHfTheblokeLlama213bChatAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeLlama213bChatAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeLlama213bChatAwq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeLlama213bChatAwq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeLlama213bChatAwq_BadRequest

type WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq_BadRequest

type WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq_BadRequest

type WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq_BadRequest

type WorkersAiPostRunHfTheblokeZephyr7bBetaAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeZephyr7bBetaAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeZephyr7bBetaAwq_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeZephyr7bBetaAwq =
    ///Object with user data.
    | OK of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeZephyr7bBetaAwq_BadRequest

type WorkersAiPostRunModel_OK =
    { result: Option<Newtonsoft.Json.Linq.JObject> }

type WorkersAiPostRunModel_BadRequestErrors = { message: string }

type WorkersAiPostRunModel_BadRequest =
    { errors: list<WorkersAiPostRunModel_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunModel =
    ///Model response
    | OK of payload: WorkersAiPostRunModel_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiPostRunModel_BadRequest

type WorkersAiSearchTask_OK =
    { errors: Newtonsoft.Json.Linq.JArray
      messages: list<string>
      result: Newtonsoft.Json.Linq.JArray
      success: bool }

type WorkersAiSearchTask_NotFound =
    { errors: Newtonsoft.Json.Linq.JArray
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiSearchTask =
    ///Returns a list of tasks
    | OK of payload: WorkersAiSearchTask_OK
    ///Object not found
    | NotFound of payload: WorkersAiSearchTask_NotFound

type WorkersAiPostToMarkdownPayload =
    { files: list<string> }
    ///Creates an instance of WorkersAiPostToMarkdownPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (files: list<string>): WorkersAiPostToMarkdownPayload = { files = files }

type WorkersAiPostToMarkdown_OKResult =
    { data: string
      format: string
      mimeType: string
      name: string
      tokens: string }

type WorkersAiPostToMarkdown_OK =
    { result: list<WorkersAiPostToMarkdown_OKResult>
      success: bool }

type WorkersAiPostToMarkdown_BadRequestErrors = { message: string }

type WorkersAiPostToMarkdown_BadRequest =
    { errors: list<WorkersAiPostToMarkdown_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostToMarkdown =
    ///Model Schema
    | OK of payload: WorkersAiPostToMarkdown_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiPostToMarkdown_BadRequest

type WorkersAiGetToMarkdownSupported_OKResult = { extension: string; mimeType: string }

type WorkersAiGetToMarkdownSupported_OK =
    { result: list<WorkersAiGetToMarkdownSupported_OKResult>
      success: bool }

type WorkersAiGetToMarkdownSupported_BadRequestErrors = { message: string }

type WorkersAiGetToMarkdownSupported_BadRequest =
    { errors: list<WorkersAiGetToMarkdownSupported_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiGetToMarkdownSupported =
    ///Successful response
    | OK of payload: WorkersAiGetToMarkdownSupported_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiGetToMarkdownSupported_BadRequest
