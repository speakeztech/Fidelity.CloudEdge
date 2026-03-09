namespace rec Fidelity.CloudEdge.Management.Workers.Types

// Auto-generated type aliases (Hawaii normalization fix)
type ``workers-kv_key_name_bulk`` = ``workers-kvkeynamebulk``
type workers_compatibility_flag = workerscompatibilityflag
type workers_tag = workerstag
type workers_tail_consumers_script = workerstailconsumersscript

// Auto-generated stub types (missing from Hawaii output)
type allowed = string
type classes = string
type cloud = string
type destinations = string
type files = string
type handlers = string
type keys = string
type modules = string
type requests = string
type results = string
type seconds = string
type tags = string
type workers_binding_item = string
type workerssecret = string

type ``workers-kvbulkdelete`` = list<``workers-kv_key_name_bulk``>

type ``workers-kvbulkwriteArrayItem`` =
    { ///Indicates whether or not the server should base64 decode the value before storing it. Useful for writing values that wouldn't otherwise be valid JSON strings, such as images.
      base64: Option<bool>
      ///Expires the key at a certain time, measured in number of seconds since the UNIX epoch.
      expiration: Option<``workers-kvexpiration``>
      ///Expires the key after a number of seconds. Must be at least 60.
      expiration_ttl: Option<``workers-kvexpirationttl``>
      ///A key's name. The name may be at most 512 bytes. All printable, non-whitespace characters are valid.
      key: ``workers-kvkeynamebulk``
      ///Arbitrary JSON that is associated with a key.
      metadata: Option<``workers-kvlistmetadata``>
      ///A UTF-8 encoded string to be stored, up to 25 MiB in length.
      value: string }
    ///Creates an instance of workers-kvbulkwriteArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: ``workers-kvkeynamebulk``, value: string): ``workers-kvbulkwriteArrayItem`` =
        { base64 = None
          expiration = None
          expiration_ttl = None
          key = key
          metadata = None
          value = value }

type ``workers-kvbulkwrite`` = list<``workers-kvbulkwriteArrayItem``>
///Opaque token indicating the position from which to continue when requesting the next set of records if the amount of list results was limited by the limit parameter. A valid value for the cursor can be obtained from the cursors object in the result_info structure.
type ``workers-kvcursor`` = string
type ``workers-kvexpiration`` = float
type ``workers-kvexpirationttl`` = float
///Identifier.
type ``workers-kvidentifier`` = string
///A key's name. The name may be at most 512 bytes. All printable, non-whitespace characters are valid. Use percent-encoding to define key names as part of a URL.
type ``workers-kvkeyname`` = string
///A key's name. The name may be at most 512 bytes. All printable, non-whitespace characters are valid.
type ``workers-kvkeynamebulk`` = string

type ``workers-kvmessagesArrayItem`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kvmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kvmessagesArrayItem`` =
        { code = code; message = message }

type ``workers-kvmessages`` = list<``workers-kvmessagesArrayItem``>
///Namespace identifier tag.
type ``workers-kvnamespaceidentifier`` = string
///A human-readable string name for a Namespace.
type ``workers-kvnamespacetitle`` = string
///Identifer of the account.
type workersaccountidentifier = string
///A JavaScript variable name for the binding.
type workersbindingname = string
type workersbindings = list<workers_binding_item>
///Date indicating targeted support in the Workers runtime. Backwards incompatible fixes to the runtime following this date will not affect this Worker.
type workerscompatibilitydate = string
///Flag that enables or disables a specific feature in the Workers runtime.
type workerscompatibilityflag = string
type workerscompatibilityflags = list<workers_compatibility_flag>
///When the script was created.
type workerscreatedon = System.DateTimeOffset
///Opaque token indicating the position from which to continue when requesting the next set of records. A valid value for the cursor can be obtained from the cursors object in the result_info structure.
type workerscursor = string
///Name of the Workers for Platforms dispatch namespace.
type workersdispatchnamespacename = string
///Identifer of the Worker Domain.
type workersdomainidentifier = string
///Optional environment if the Worker utilizes one.
type workersenvironment = string
///Hashed script content, can be used in a If-None-Match header when updating.
type workersetag = string
type workershasassets = bool
type workershasmodules = bool
///Hostname of the Worker Domain.
type workershostname = string
///Identifier.
type workersidentifier = string
type workerslogpush = bool

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type workersmessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of workersmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): workersmessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type workersmessages = list<workersmessagesArrayItem>
///When the script was last modified.
type workersmodifiedon = System.DateTimeOffset
///Namespace identifier tag.
type workersnamespaceidentifier = string

///Configuration for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Specify mode='smart' for Smart Placement, or one of region/hostname/host.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersplacementmode =
    | [<CompiledName "smart">] Smart
    | [<CompiledName "targeted">] Targeted
    member this.Format() =
        match this with
        | Smart -> "smart"
        | Targeted -> "targeted"

///Status of [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement).
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersplacementstatus =
    | [<CompiledName "SUCCESS">] SUCCESS
    | [<CompiledName "UNSUPPORTED_APPLICATION">] UNSUPPORTED_APPLICATION
    | [<CompiledName "INSUFFICIENT_INVOCATIONS">] INSUFFICIENT_INVOCATIONS
    member this.Format() =
        match this with
        | SUCCESS -> "SUCCESS"
        | UNSUPPORTED_APPLICATION -> "UNSUPPORTED_APPLICATION"
        | INSUFFICIENT_INVOCATIONS -> "INSUFFICIENT_INVOCATIONS"

///Worker environment associated with the zone and hostname.
type ``workersschemas-environment`` = string
///ID of the namespace.
type ``workersschemas-id`` = string
///Name of the script.
type ``workersschemas-scriptname`` = string
///Worker service associated with the zone and hostname.
type ``workersschemas-service`` = string
type workersscriptcount = int
///Name of the script, used in URLs and route configuration.
type workersscriptname = string
///A JavaScript variable name for the secret binding.
type workerssecretname = string
type workerssecretnameurlencoded = bool
///Name of Worker to bind to.
type workersservice = string
type workerstag = string
type workerstags = list<workers_tag>
type workerstailconsumers = list<workers_tail_consumers_script>
type workerstrustedworkers = bool

///Usage model for the Worker invocations.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersusagemodel =
    | [<CompiledName "standard">] Standard
    | [<CompiledName "bundled">] Bundled
    | [<CompiledName "unbound">] Unbound
    member this.Format() =
        match this with
        | Standard -> "standard"
        | Bundled -> "bundled"
        | Unbound -> "unbound"

///API Resource UUID tag.
type workersuuid = string
type workersversionidentifier = string
///Identifier of the zone.
type workerszoneidentifier = string
///Name of the zone.
type workerszonename = string

type Errors =
    { code: int
      message: string }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors = { code = code; message = message }

type Messages =
    { code: int
      message: string }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Messages = { code = code; message = message }

type ``workers-kvapi-response-collection`` =
    { errors: list<Errors>
      messages: list<Messages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``workers-kvresultinfo``> }
    ///Creates an instance of workers-kvapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>, messages: list<Messages>, success: bool): ``workers-kvapi-response-collection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None }

type ``workers-kvapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kvapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kvapi-response-commonErrors`` =
        { code = code; message = message }

type ``workers-kvapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kvapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kvapi-response-commonMessages`` =
        { code = code; message = message }

type ``workers-kvapi-response-common`` =
    { errors: list<``workers-kvapi-response-commonErrors``>
      messages: list<``workers-kvapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of workers-kvapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kvapi-response-commonErrors``>,
                          messages: list<``workers-kvapi-response-commonMessages``>,
                          success: bool): ``workers-kvapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``workers-kvapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of workers-kvapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``workers-kvapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``workers-kvapi-response-common-no-resultErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kvapi-response-common-no-resultErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kvapi-response-common-no-resultErrors`` =
        { code = code; message = message }

type ``workers-kvapi-response-common-no-resultMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kvapi-response-common-no-resultMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kvapi-response-common-no-resultMessages`` =
        { code = code; message = message }

type ``workers-kvapi-response-common-no-result`` =
    { errors: list<``workers-kvapi-response-common-no-resultErrors``>
      messages: list<``workers-kvapi-response-common-no-resultMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of workers-kvapi-response-common-no-result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kvapi-response-common-no-resultErrors``>,
                          messages: list<``workers-kvapi-response-common-no-resultMessages``>,
                          success: bool): ``workers-kvapi-response-common-no-result`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workers-kvbulk-get-result`` =
    { ///Requested keys are paired with their values in an object.
      values: Option<Map<string, string>> }
    ///Creates an instance of workers-kvbulk-get-result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workers-kvbulk-get-result`` = { values = None }

type ``workers-kvbulk-get-result-with-metadata`` =
    { ///Requested keys are paired with their values and metadata in an object.
      values: Option<Map<string, Option<string>>> }
    ///Creates an instance of workers-kvbulk-get-result-with-metadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workers-kvbulk-get-result-with-metadata`` = { values = None }

type ``workers-kvbulk-result`` =
    { ///Number of keys successfully updated.
      successful_key_count: Option<float>
      ///Name of the keys that failed to be fully updated. They should be retried.
      unsuccessful_keys: Option<list<string>> }
    ///Creates an instance of workers-kvbulk-result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workers-kvbulk-result`` =
        { successful_key_count = None
          unsuccessful_keys = None }

type ``workers-kvcreaterenamenamespacebody`` =
    { ///A human-readable string name for a Namespace.
      title: ``workers-kvnamespacetitle`` }
    ///Creates an instance of workers-kvcreaterenamenamespacebody with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (title: ``workers-kvnamespacetitle``): ``workers-kvcreaterenamenamespacebody`` =
        { title = title }

type ``workers-kvcursorresultinfo`` =
    { ///Total results returned based on your list parameters.
      count: Option<float>
      ///Opaque token indicating the position from which to continue when requesting the next set of records if the amount of list results was limited by the limit parameter. A valid value for the cursor can be obtained from the cursors object in the result_info structure.
      cursor: Option<``workers-kvcursor``> }
    ///Creates an instance of workers-kvcursorresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workers-kvcursorresultinfo`` = { count = None; cursor = None }

///A name for a value. A value stored under a given key may be retrieved via the same key.
type ``workers-kvkey`` =
    { ///The time, measured in number of seconds since the UNIX epoch, at which the key will expire. This property is omitted for keys that will not expire.
      expiration: Option<float>
      ///Arbitrary JSON that is associated with a key.
      metadata: Option<``workers-kvlistmetadata``>
      ///A key's name. The name may be at most 512 bytes. All printable, non-whitespace characters are valid. Use percent-encoding to define key names as part of a URL.
      name: ``workers-kvkeyname`` }
    ///Creates an instance of workers-kvkey with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``workers-kvkeyname``): ``workers-kvkey`` =
        { expiration = None
          metadata = None
          name = name }

type ``workers-kvlistmetadata`` = Map<string, Newtonsoft.Json.Linq.JToken>
type ``workers-kvmetadata`` = Map<string, Newtonsoft.Json.Linq.JToken>

type ``workers-kvnamespace`` =
    { ///Namespace identifier tag.
      id: ``workers-kvnamespaceidentifier``
      ///True if keys written on the URL will be URL-decoded before storing. For example, if set to "true", a key written on the URL as "%3F" will be stored as "?".
      supports_url_encoding: Option<bool>
      ///A human-readable string name for a Namespace.
      title: ``workers-kvnamespacetitle`` }
    ///Creates an instance of workers-kvnamespace with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``workers-kvnamespaceidentifier``, title: ``workers-kvnamespacetitle``): ``workers-kvnamespace`` =
        { id = id
          supports_url_encoding = None
          title = title }

type ``workers-kvresultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of workers-kvresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workers-kvresultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

///The statistics object contains information about query performance from the database, it does not include any network latency
type ``workers-observabilityperformanceinformation`` =
    { ///The level of Adaptive Bit Rate (ABR) sampling used for the query. If empty the ABR level is 1
      abr_level: Option<float>
      ///Number of uncompressed bytes read from the table.
      bytes_read: float
      ///Time in seconds for the query to run.
      elapsed: float
      ///Number of rows scanned from the table.
      rows_read: float }
    ///Creates an instance of workers-observabilityperformanceinformation with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bytes_read: float, elapsed: float, rows_read: float): ``workers-observabilityperformanceinformation`` =
        { abr_level = None
          bytes_read = bytes_read
          elapsed = elapsed
          rows_read = rows_read }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type KeyType =
    | [<CompiledName "string">] String
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | String -> "string"
        | Number -> "number"
        | Boolean -> "boolean"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Operator =
    | [<CompiledName "uniq">] Uniq
    | [<CompiledName "count">] Count
    | [<CompiledName "max">] Max
    | [<CompiledName "min">] Min
    | [<CompiledName "sum">] Sum
    | [<CompiledName "avg">] Avg
    | [<CompiledName "median">] Median
    | [<CompiledName "p001">] P001
    | [<CompiledName "p01">] P01
    | [<CompiledName "p05">] P05
    | [<CompiledName "p10">] P10
    | [<CompiledName "p25">] P25
    | [<CompiledName "p75">] P75
    | [<CompiledName "p90">] P90
    | [<CompiledName "p95">] P95
    | [<CompiledName "p99">] P99
    | [<CompiledName "p999">] P999
    | [<CompiledName "stddev">] Stddev
    | [<CompiledName "variance">] Variance
    | [<CompiledName "COUNT_DISTINCT">] COUNT_DISTINCT
    | [<CompiledName "COUNT">] COUNT
    | [<CompiledName "MAX">] MAX
    | [<CompiledName "MIN">] MIN
    | [<CompiledName "SUM">] SUM
    | [<CompiledName "AVG">] AVG
    | [<CompiledName "MEDIAN">] MEDIAN
    | [<CompiledName "STDDEV">] STDDEV
    | [<CompiledName "VARIANCE">] VARIANCE
    member this.Format() =
        match this with
        | Uniq -> "uniq"
        | Count -> "count"
        | Max -> "max"
        | Min -> "min"
        | Sum -> "sum"
        | Avg -> "avg"
        | Median -> "median"
        | P001 -> "p001"
        | P01 -> "p01"
        | P05 -> "p05"
        | P10 -> "p10"
        | P25 -> "p25"
        | P75 -> "p75"
        | P90 -> "p90"
        | P95 -> "p95"
        | P99 -> "p99"
        | P999 -> "p999"
        | Stddev -> "stddev"
        | Variance -> "variance"
        | COUNT_DISTINCT -> "COUNT_DISTINCT"
        | COUNT -> "COUNT"
        | MAX -> "MAX"
        | MIN -> "MIN"
        | SUM -> "SUM"
        | AVG -> "AVG"
        | MEDIAN -> "MEDIAN"
        | STDDEV -> "STDDEV"
        | VARIANCE -> "VARIANCE"

type Calculations =
    { alias: Option<string>
      key: Option<string>
      keyType: Option<KeyType>
      operator: Operator }
    ///Creates an instance of Calculations with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (operator: Operator): Calculations =
        { alias = None
          key = None
          keyType = None
          operator = operator }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type FilterCombination =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    | [<CompiledName "AND">] AND
    | [<CompiledName "OR">] OR
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"
        | AND -> "AND"
        | OR -> "OR"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Operation =
    | [<CompiledName "includes">] Includes
    | [<CompiledName "not_includes">] Not_includes
    | [<CompiledName "starts_with">] Starts_with
    | [<CompiledName "regex">] Regex
    | [<CompiledName "exists">] Exists
    | [<CompiledName "is_null">] Is_null
    | [<CompiledName "in">] In
    | [<CompiledName "not_in">] Not_in
    | [<CompiledName "eq">] Eq
    | [<CompiledName "neq">] Neq
    | [<CompiledName "gt">] Gt
    | [<CompiledName "gte">] Gte
    | [<CompiledName "lt">] Lt
    | [<CompiledName "lte">] Lte
    | [<CompiledName "=">] Equal
    | [<CompiledName "!=">] NotEqual
    | [<CompiledName ">">] GreaterThan
    | [<CompiledName ">=">] GreaterThanOrEqual
    | [<CompiledName "<">] LessThan
    | [<CompiledName "<=">] LessThanOrEqual
    | [<CompiledName "INCLUDES">] INCLUDES
    | [<CompiledName "DOES_NOT_INCLUDE">] DOES_NOT_INCLUDE
    | [<CompiledName "MATCH_REGEX">] MATCH_REGEX
    | [<CompiledName "EXISTS">] EXISTS
    | [<CompiledName "DOES_NOT_EXIST">] DOES_NOT_EXIST
    | [<CompiledName "IN">] IN
    | [<CompiledName "NOT_IN">] NOT_IN
    | [<CompiledName "STARTS_WITH">] STARTS_WITH
    member this.Format() =
        match this with
        | Includes -> "includes"
        | Not_includes -> "not_includes"
        | Starts_with -> "starts_with"
        | Regex -> "regex"
        | Exists -> "exists"
        | Is_null -> "is_null"
        | In -> "in"
        | Not_in -> "not_in"
        | Eq -> "eq"
        | Neq -> "neq"
        | Gt -> "gt"
        | Gte -> "gte"
        | Lt -> "lt"
        | Lte -> "lte"
        | Equal -> "="
        | NotEqual -> "!="
        | GreaterThan -> ">"
        | GreaterThanOrEqual -> ">="
        | LessThan -> "<"
        | LessThanOrEqual -> "<="
        | INCLUDES -> "INCLUDES"
        | DOES_NOT_INCLUDE -> "DOES_NOT_INCLUDE"
        | MATCH_REGEX -> "MATCH_REGEX"
        | EXISTS -> "EXISTS"
        | DOES_NOT_EXIST -> "DOES_NOT_EXIST"
        | IN -> "IN"
        | NOT_IN -> "NOT_IN"
        | STARTS_WITH -> "STARTS_WITH"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "string">] String
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | String -> "string"
        | Number -> "number"
        | Boolean -> "boolean"

type Filters =
    { key: string
      operation: Operation
      ``type``: Type
      value: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of Filters with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string, operation: Operation, ``type``: Type): Filters =
        { key = key
          operation = operation
          ``type`` = ``type``
          value = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GroupBysType =
    | [<CompiledName "string">] String
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | String -> "string"
        | Number -> "number"
        | Boolean -> "boolean"

type GroupBys =
    { ``type``: GroupBysType
      value: string }
    ///Creates an instance of GroupBys with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: GroupBysType, value: string): GroupBys = { ``type`` = ``type``; value = value }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type HavingsOperation =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "neq">] Neq
    | [<CompiledName "gt">] Gt
    | [<CompiledName "gte">] Gte
    | [<CompiledName "lt">] Lt
    | [<CompiledName "lte">] Lte
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Neq -> "neq"
        | Gt -> "gt"
        | Gte -> "gte"
        | Lt -> "lt"
        | Lte -> "lte"

type Havings =
    { key: string
      operation: HavingsOperation
      value: float }
    ///Creates an instance of Havings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string, operation: HavingsOperation, value: float): Havings =
        { key = key
          operation = operation
          value = value }

///Define an expression to search using full-text search.
type Needle =
    { isRegex: Option<bool>
      matchCase: Option<bool>
      value: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of Needle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (value: Newtonsoft.Json.Linq.JToken): Needle =
        { isRegex = None
          matchCase = None
          value = value }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Order =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"

///Configure the order of the results returned by the query.
type OrderBy =
    { ///Set the order of the results
      order: Option<Order>
      ///Configure which Calculation to order the results by.
      value: string }
    ///Creates an instance of OrderBy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (value: string): OrderBy = { order = None; value = value }

type Parameters =
    { ///Create Calculations to compute as part of the query.
      calculations: Option<list<Calculations>>
      ///Set the Datasets to query. Leave it empty to query all the datasets.
      datasets: Option<list<string>>
      ///Set a Flag to describe how to combine the filters on the query.
      filterCombination: Option<FilterCombination>
      ///Configure the Filters to apply to the query.
      filters: Option<list<Filters>>
      ///Define how to group the results of the query.
      groupBys: Option<list<GroupBys>>
      ///Configure the Having clauses that filter on calculations in the query result.
      havings: Option<list<Havings>>
      ///Set a limit on the number of results / records returned by the query
      limit: Option<int>
      ///Define an expression to search using full-text search.
      needle: Option<Needle>
      ///Configure the order of the results returned by the query.
      orderBy: Option<OrderBy> }
    ///Creates an instance of Parameters with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Parameters =
        { calculations = None
          datasets = None
          filterCombination = None
          filters = None
          groupBys = None
          havings = None
          limit = None
          needle = None
          orderBy = None }

type ``workers-observabilityquery`` =
    { created: string
      description: string
      ///ID of your environment
      environmentId: string
      ///Flag for alerts automatically created
      generated: bool
      ///ID of the query
      id: string
      ///Query name
      name: string
      parameters: Parameters
      updated: string
      userId: string
      ///ID of your workspace
      workspaceId: string }
    ///Creates an instance of workers-observabilityquery with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created: string,
                          description: string,
                          environmentId: string,
                          generated: bool,
                          id: string,
                          name: string,
                          parameters: Parameters,
                          updated: string,
                          userId: string,
                          workspaceId: string): ``workers-observabilityquery`` =
        { created = created
          description = description
          environmentId = environmentId
          generated = generated
          id = id
          name = name
          parameters = parameters
          updated = updated
          userId = userId
          workspaceId = workspaceId }

type Groups =
    { key: string
      value: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of Groups with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string, value: Newtonsoft.Json.Linq.JToken): Groups = { key = key; value = value }

type Aggregates =
    { count: float
      groups: Option<list<Groups>>
      interval: float
      sampleInterval: float
      value: float }
    ///Creates an instance of Aggregates with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float, interval: float, sampleInterval: float, value: float): Aggregates =
        { count = count
          groups = None
          interval = interval
          sampleInterval = sampleInterval
          value = value }

type DataGroups =
    { key: string
      value: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of DataGroups with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string, value: Newtonsoft.Json.Linq.JToken): DataGroups = { key = key; value = value }

type Data =
    { count: float
      firstSeen: string
      groups: Option<list<DataGroups>>
      interval: float
      lastSeen: string
      sampleInterval: float
      value: float }
    ///Creates an instance of Data with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float,
                          firstSeen: string,
                          interval: float,
                          lastSeen: string,
                          sampleInterval: float,
                          value: float): Data =
        { count = count
          firstSeen = firstSeen
          groups = None
          interval = interval
          lastSeen = lastSeen
          sampleInterval = sampleInterval
          value = value }

type Series =
    { data: list<Data>
      time: string }
    ///Creates an instance of Series with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data: list<Data>, time: string): Series = { data = data; time = time }

type ``workers-observabilityqueryresultsCalculations`` =
    { aggregates: list<Aggregates>
      alias: Option<string>
      calculation: string
      series: list<Series> }
    ///Creates an instance of workers-observabilityqueryresultsCalculations with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (aggregates: list<Aggregates>, calculation: string, series: list<Series>): ``workers-observabilityqueryresultsCalculations`` =
        { aggregates = aggregates
          alias = None
          calculation = calculation
          series = series }

type CompareAggregatesGroups =
    { key: string
      value: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of CompareAggregatesGroups with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string, value: Newtonsoft.Json.Linq.JToken): CompareAggregatesGroups =
        { key = key; value = value }

type CompareAggregates =
    { count: float
      groups: Option<list<CompareAggregatesGroups>>
      interval: float
      sampleInterval: float
      value: float }
    ///Creates an instance of CompareAggregates with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float, interval: float, sampleInterval: float, value: float): CompareAggregates =
        { count = count
          groups = None
          interval = interval
          sampleInterval = sampleInterval
          value = value }

type CompareSeriesDataGroups =
    { key: string
      value: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of CompareSeriesDataGroups with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string, value: Newtonsoft.Json.Linq.JToken): CompareSeriesDataGroups =
        { key = key; value = value }

type CompareSeriesData =
    { count: float
      firstSeen: string
      groups: Option<list<CompareSeriesDataGroups>>
      interval: float
      lastSeen: string
      sampleInterval: float
      value: float }
    ///Creates an instance of CompareSeriesData with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float,
                          firstSeen: string,
                          interval: float,
                          lastSeen: string,
                          sampleInterval: float,
                          value: float): CompareSeriesData =
        { count = count
          firstSeen = firstSeen
          groups = None
          interval = interval
          lastSeen = lastSeen
          sampleInterval = sampleInterval
          value = value }

type CompareSeries =
    { data: list<CompareSeriesData>
      time: string }
    ///Creates an instance of CompareSeries with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data: list<CompareSeriesData>, time: string): CompareSeries = { data = data; time = time }

type Compare =
    { aggregates: list<CompareAggregates>
      alias: Option<string>
      calculation: string
      series: list<CompareSeries> }
    ///Creates an instance of Compare with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (aggregates: list<CompareAggregates>, calculation: string, series: list<CompareSeries>): Compare =
        { aggregates = aggregates
          alias = None
          calculation = calculation
          series = series }

type Fields =
    { key: string
      ``type``: string }
    ///Creates an instance of Fields with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string, ``type``: string): Fields = { key = key; ``type`` = ``type`` }

type EventsSeriesDataAggregates = Map<string, Newtonsoft.Json.Linq.JToken>

type EventsSeriesData =
    { aggregates: EventsSeriesDataAggregates
      count: float
      errors: Option<float>
      ///Groups in the query results.
      groups: Option<Map<string, string>>
      interval: float
      sampleInterval: float }
    ///Creates an instance of EventsSeriesData with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (aggregates: EventsSeriesDataAggregates, count: float, interval: float, sampleInterval: float): EventsSeriesData =
        { aggregates = aggregates
          count = count
          errors = None
          groups = None
          interval = interval
          sampleInterval = sampleInterval }

type EventsSeries =
    { data: list<EventsSeriesData>
      time: string }
    ///Creates an instance of EventsSeries with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data: list<EventsSeriesData>, time: string): EventsSeries = { data = data; time = time }

type Events =
    { count: Option<float>
      events: Option<list<``workers-observabilitytelemetryevent``>>
      fields: Option<list<Fields>>
      series: Option<list<EventsSeries>> }
    ///Creates an instance of Events with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Events =
        { count = None
          events = None
          fields = None
          series = None }

type PatternsSeriesDataGroups =
    { key: string
      value: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of PatternsSeriesDataGroups with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string, value: Newtonsoft.Json.Linq.JToken): PatternsSeriesDataGroups =
        { key = key; value = value }

type PatternsSeriesData =
    { count: float
      groups: Option<list<PatternsSeriesDataGroups>>
      interval: float
      sampleInterval: float
      value: float }
    ///Creates an instance of PatternsSeriesData with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float, interval: float, sampleInterval: float, value: float): PatternsSeriesData =
        { count = count
          groups = None
          interval = interval
          sampleInterval = sampleInterval
          value = value }

type PatternsSeries =
    { data: PatternsSeriesData
      time: string }
    ///Creates an instance of PatternsSeries with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data: PatternsSeriesData, time: string): PatternsSeries = { data = data; time = time }

type Patterns =
    { count: float
      pattern: string
      series: list<PatternsSeries>
      service: string }
    ///Creates an instance of Patterns with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float, pattern: string, series: list<PatternsSeries>, service: string): Patterns =
        { count = count
          pattern = pattern
          series = series
          service = service }

type Traces =
    { errors: Option<list<string>>
      rootSpanName: string
      rootTransactionName: string
      service: list<string>
      spans: float
      traceDurationMs: float
      traceEndMs: float
      traceId: string
      traceStartMs: float }
    ///Creates an instance of Traces with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (rootSpanName: string,
                          rootTransactionName: string,
                          service: list<string>,
                          spans: float,
                          traceDurationMs: float,
                          traceEndMs: float,
                          traceId: string,
                          traceStartMs: float): Traces =
        { errors = None
          rootSpanName = rootSpanName
          rootTransactionName = rootTransactionName
          service = service
          spans = spans
          traceDurationMs = traceDurationMs
          traceEndMs = traceEndMs
          traceId = traceId
          traceStartMs = traceStartMs }

type ``workers-observabilityqueryresults`` =
    { calculations: Option<list<``workers-observabilityqueryresultsCalculations``>>
      compare: Option<list<Compare>>
      events: Option<Events>
      invocations: Option<Map<string, list<``workers-observabilitytelemetryevent``>>>
      patterns: Option<list<Patterns>>
      ///A Workers Observability Query Object
      run: ``workers-observabilityqueryrun``
      ///The statistics object contains information about query performance from the database, it does not include any network latency
      statistics: ``workers-observabilityperformanceinformation``
      traces: Option<list<Traces>> }
    ///Creates an instance of workers-observabilityqueryresults with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (run: ``workers-observabilityqueryrun``,
                          statistics: ``workers-observabilityperformanceinformation``): ``workers-observabilityqueryresults`` =
        { calculations = None
          compare = None
          events = None
          invocations = None
          patterns = None
          run = run
          statistics = statistics
          traces = None }

type Statistics =
    { ///The level of Adaptive Bit Rate (ABR) sampling used for the query. If empty the ABR level is 1
      abr_level: Option<float>
      ///Number of uncompressed bytes read from the table.
      bytes_read: float
      ///Time in seconds for the query to run.
      elapsed: float
      ///Number of rows scanned from the table.
      rows_read: float }
    ///Creates an instance of Statistics with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bytes_read: float, elapsed: float, rows_read: float): Statistics =
        { abr_level = None
          bytes_read = bytes_read
          elapsed = elapsed
          rows_read = rows_read }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "STARTED">] STARTED
    | [<CompiledName "COMPLETED">] COMPLETED
    member this.Format() =
        match this with
        | STARTED -> "STARTED"
        | COMPLETED -> "COMPLETED"

///Time range for the query execution
type Timeframe =
    { ///Start timestamp for the query timeframe (Unix timestamp in milliseconds)
      from: float
      ///End timestamp for the query timeframe (Unix timestamp in milliseconds)
      ``to``: float }
    ///Creates an instance of Timeframe with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (from: float, ``to``: float): Timeframe = { from = from; ``to`` = ``to`` }

///A Workers Observability Query Object
type ``workers-observabilityqueryrun`` =
    { accountId: string
      created: Option<string>
      dry: bool
      granularity: float
      id: string
      query: ``workers-observabilityquery``
      statistics: Option<Statistics>
      status: Status
      ///Time range for the query execution
      timeframe: Timeframe
      updated: Option<string>
      userId: string }
    ///Creates an instance of workers-observabilityqueryrun with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (accountId: string,
                          dry: bool,
                          granularity: float,
                          id: string,
                          query: ``workers-observabilityquery``,
                          status: Status,
                          timeframe: Timeframe,
                          userId: string): ``workers-observabilityqueryrun`` =
        { accountId = accountId
          created = None
          dry = dry
          granularity = granularity
          id = id
          query = query
          statistics = None
          status = status
          timeframe = timeframe
          updated = None
          userId = userId }

type Dollar_metadata =
    { account: Option<string>
      cloudService: Option<string>
      coldStart: Option<int>
      cost: Option<int>
      duration: Option<int>
      endTime: Option<int>
      error: Option<string>
      errorTemplate: Option<string>
      fingerprint: Option<string>
      id: string
      level: Option<string>
      message: Option<string>
      messageTemplate: Option<string>
      metricName: Option<string>
      origin: Option<string>
      parentSpanId: Option<string>
      provider: Option<string>
      region: Option<string>
      requestId: Option<string>
      service: Option<string>
      spanId: Option<string>
      spanName: Option<string>
      stackId: Option<string>
      startTime: Option<int>
      statusCode: Option<int>
      traceDuration: Option<int>
      traceId: Option<string>
      transactionName: Option<string>
      trigger: Option<string>
      ``type``: Option<string>
      url: Option<string> }
    ///Creates an instance of $metadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): Dollar_metadata =
        { account = None
          cloudService = None
          coldStart = None
          cost = None
          duration = None
          endTime = None
          error = None
          errorTemplate = None
          fingerprint = None
          id = id
          level = None
          message = None
          messageTemplate = None
          metricName = None
          origin = None
          parentSpanId = None
          provider = None
          region = None
          requestId = None
          service = None
          spanId = None
          spanName = None
          stackId = None
          startTime = None
          statusCode = None
          traceDuration = None
          traceId = None
          transactionName = None
          trigger = None
          ``type`` = None
          url = None }

///The data structure of a telemetry event
type ``workers-observabilitytelemetryevent`` =
    { ///Cloudflare Containers event information enriches your logs so you can easily identify and debug issues.
      Dollar_containers: Option<Newtonsoft.Json.Linq.JObject>
      Dollar_metadata: Dollar_metadata
      ///Cloudflare Workers event information enriches your logs so you can easily identify and debug issues.
      Dollar_workers: Option<Newtonsoft.Json.Linq.JToken>
      dataset: string
      source: Newtonsoft.Json.Linq.JToken
      timestamp: int }
    ///Creates an instance of workers-observabilitytelemetryevent with all optional fields initialized to None. The required fields are parameters of this function
    static member Create ((``$metadata``): Dollar_metadata,
                          dataset: string,
                          source: Newtonsoft.Json.Linq.JToken,
                          timestamp: int): ``workers-observabilitytelemetryevent`` =
        { Dollar_containers = None
          Dollar_metadata = ``$metadata``
          Dollar_workers = None
          dataset = dataset
          source = source
          timestamp = timestamp }

[<RequireQualifiedAccess>]
type Code =
    | Code10023 = 10023

type workersErrorAuth =
    { ///Code indicating that the user is not authorized to perform this action.
      code: Code
      ///Message explaining that the user lacks access to this feature.
      message: string }
    ///Creates an instance of workersErrorAuth with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: Code, message: string): workersErrorAuth = { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorInternalServerCode =
    | WorkersErrorInternalServerCode10002 = 10002

type workersErrorInternalServer =
    { ///Code indicating that an unknown internal server error has occurred.
      code: workersErrorInternalServerCode
      ///Message explaining that an unknown error occurred and providing guidance for reporting the issue.
      message: string }
    ///Creates an instance of workersErrorInternalServer with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorInternalServerCode, message: string): workersErrorInternalServer =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorMissingParamCode =
    | WorkersErrorMissingParamCode10003 = 10003

type workersErrorMissingParam =
    { ///Code indicating that a required URL parameter is missing.
      code: workersErrorMissingParamCode
      ///Message explaining which required parameter is missing and suggesting to check the URL.
      message: string }
    ///Creates an instance of workersErrorMissingParam with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorMissingParamCode, message: string): workersErrorMissingParam =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerInvalidCode =
    | WorkersErrorWorkerInvalidCode10021 = 10021

type workersErrorWorkerInvalid =
    { ///Code indicating that the Worker request contains invalid data.
      code: workersErrorWorkerInvalidCode
      ///Message explaining why the Worker request is invalid, such as malformed JSON.
      message: string }
    ///Creates an instance of workersErrorWorkerInvalid with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerInvalidCode, message: string): workersErrorWorkerInvalid =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerLimitCode =
    | WorkersErrorWorkerLimitCode10037 = 10037

type workersErrorWorkerLimit =
    { ///Code indicating that the account has exceeded the maximum number of Workers allowed.
      code: workersErrorWorkerLimitCode
      ///Message explaining that the Worker limit has been exceeded and providing guidance.
      message: string }
    ///Creates an instance of workersErrorWorkerLimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerLimitCode, message: string): workersErrorWorkerLimit =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerNameConflictCode =
    | WorkersErrorWorkerNameConflictCode10040 = 10040

type workersErrorWorkerNameConflict =
    { ///Code indicating that a Worker with this name already exists.
      code: workersErrorWorkerNameConflictCode
      ///Message explaining that the Worker name is already in use and suggesting to choose a different name.
      message: string }
    ///Creates an instance of workersErrorWorkerNameConflict with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerNameConflictCode, message: string): workersErrorWorkerNameConflict =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerNameInvalidCode =
    | WorkersErrorWorkerNameInvalidCode10016 = 10016

type workersErrorWorkerNameInvalid =
    { ///Code indicating that the Worker name is invalid.
      code: workersErrorWorkerNameInvalidCode
      ///Message explaining why the Worker name is invalid.
      message: string }
    ///Creates an instance of workersErrorWorkerNameInvalid with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerNameInvalidCode, message: string): workersErrorWorkerNameInvalid =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerNamePreviewLengthLimitCode =
    | WorkersErrorWorkerNamePreviewLengthLimitCode100315 = 100315

type workersErrorWorkerNamePreviewLengthLimit =
    { ///Code indicating that the Worker name is too long to be used with previews enabled.
      code: workersErrorWorkerNamePreviewLengthLimitCode
      ///Message explaining that Worker names with previews enabled cannot exceed 54 characters.
      message: string }
    ///Creates an instance of workersErrorWorkerNamePreviewLengthLimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerNamePreviewLengthLimitCode, message: string): workersErrorWorkerNamePreviewLengthLimit =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerNameSubdomainLengthLimitCode =
    | WorkersErrorWorkerNameSubdomainLengthLimitCode100132 = 100132

type workersErrorWorkerNameSubdomainLengthLimit =
    { ///Code indicating that the Worker name is too long to be used as a subdomain.
      code: workersErrorWorkerNameSubdomainLengthLimitCode
      ///Message explaining that the Worker name exceeds the 63 character limit for subdomains.
      message: string }
    ///Creates an instance of workersErrorWorkerNameSubdomainLengthLimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerNameSubdomainLengthLimitCode, message: string): workersErrorWorkerNameSubdomainLengthLimit =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerNotFoundCode =
    | WorkersErrorWorkerNotFoundCode10007 = 10007

type workersErrorWorkerNotFound =
    { ///Code indicating that the Worker does not exist.
      code: workersErrorWorkerNotFoundCode
      ///Message explaining that the Worker was not found.
      message: string }
    ///Creates an instance of workersErrorWorkerNotFound with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerNotFoundCode, message: string): workersErrorWorkerNotFound =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerObservabilitySamplingRateInvalidCode =
    | WorkersErrorWorkerObservabilitySamplingRateInvalidCode100308 = 100308

type workersErrorWorkerObservabilitySamplingRateInvalid =
    { ///Code indicating that an observability sampling rate is invalid.
      code: workersErrorWorkerObservabilitySamplingRateInvalidCode
      ///Message explaining that sampling rates must be between 0 and 1 inclusive.
      message: string }
    ///Creates an instance of workersErrorWorkerObservabilitySamplingRateInvalid with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerObservabilitySamplingRateInvalidCode, message: string): workersErrorWorkerObservabilitySamplingRateInvalid =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerTagInvalidCode =
    | WorkersErrorWorkerTagInvalidCode100134 = 100134

type workersErrorWorkerTagInvalid =
    { ///Code indicating that the Worker has a tag containing invalid characters.
      code: workersErrorWorkerTagInvalidCode
      ///Message explaining that tags cannot contain certain characters like comma or ampersand.
      message: string }
    ///Creates an instance of workersErrorWorkerTagInvalid with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerTagInvalidCode, message: string): workersErrorWorkerTagInvalid =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerTagLengthLimitCode =
    | WorkersErrorWorkerTagLengthLimitCode100102 = 100102

type workersErrorWorkerTagLengthLimit =
    { ///Code indicating that the Worker has a tag that exceeds the maximum tag length.
      code: workersErrorWorkerTagLengthLimitCode
      ///Message explaining why the tag is too long, including the maximum tag length.
      message: string }
    ///Creates an instance of workersErrorWorkerTagLengthLimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerTagLengthLimitCode, message: string): workersErrorWorkerTagLengthLimit =
        { code = code; message = message }

[<RequireQualifiedAccess>]
type workersErrorWorkerTagLimitCode =
    | WorkersErrorWorkerTagLimitCode100103 = 100103

type workersErrorWorkerTagLimit =
    { ///Code indicating that the Worker has exceeded the maximum number of tags allowed.
      code: workersErrorWorkerTagLimitCode
      ///Message explaining that the tag limit has been exceeded and suggesting to remove a tag.
      message: string }
    ///Creates an instance of workersErrorWorkerTagLimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: workersErrorWorkerTagLimitCode, message: string): workersErrorWorkerTagLimit =
        { code = code; message = message }

///Metadata about the version.
type Annotations =
    { ///Human-readable message about the version.
      ``workers/message``: Option<string>
      ///User-provided identifier for the version.
      ``workers/tag``: Option<string>
      ///Operation that triggered the creation of the version.
      ``workers/triggered_by``: Option<string> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Htmlhandling =
    | [<CompiledName "auto-trailing-slash">] AutoTrailingSlash
    | [<CompiledName "force-trailing-slash">] ForceTrailingSlash
    | [<CompiledName "drop-trailing-slash">] DropTrailingSlash
    | [<CompiledName "none">] None
    member this.Format() =
        match this with
        | AutoTrailingSlash -> "auto-trailing-slash"
        | ForceTrailingSlash -> "force-trailing-slash"
        | DropTrailingSlash -> "drop-trailing-slash"
        | None -> "none"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Notfoundhandling =
    | [<CompiledName "none">] None
    | [<CompiledName "404-page">] Numeric_404Page
    | [<CompiledName "single-page-application">] SinglePageApplication
    member this.Format() =
        match this with
        | None -> "none"
        | Numeric_404Page -> "404-page"
        | SinglePageApplication -> "single-page-application"

///Configuration for assets within a Worker.
type Config =
    { ///Determines the redirects and rewrites of requests for HTML content.
      html_handling: Option<Htmlhandling>
      ///Determines the response when a request does not match a static asset, and there is no Worker script.
      not_found_handling: Option<Notfoundhandling>
      run_worker_first: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of Config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Config =
        { html_handling = None
          not_found_handling = None
          run_worker_first = None }

///Configuration for assets within a Worker.
///[`_headers`](https://developers.cloudflare.com/workers/static-assets/headers/#custom-headers) and
///[`_redirects`](https://developers.cloudflare.com/workers/static-assets/redirects/) files should be
///included as modules named `_headers` and `_redirects` with content type `text/plain`.
type Assets =
    { ///Configuration for assets within a Worker.
      config: Option<Config>
      ///Token provided upon successful upload of all files from a registered manifest.
      jwt: Option<string> }
    ///Creates an instance of Assets with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Assets = { config = None; jwt = None }

///Resource limits enforced at runtime.
type Limits =
    { ///CPU time limit in milliseconds.
      cpu_ms: int }
    ///Creates an instance of Limits with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cpu_ms: int): Limits = { cpu_ms = cpu_ms }

type Modules =
    { ///The base64-encoded module content.
      content_base64: byte []
      ///The content type of the module.
      content_type: string
      ///The name of the module.
      name: string }
    ///Creates an instance of Modules with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content_base64: byte [], content_type: string, name: string): Modules =
        { content_base64 = content_base64
          content_type = content_type
          name = name }

type workersVersion =
    { ///Metadata about the version.
      annotations: Option<Annotations>
      ///Configuration for assets within a Worker.
      ///[`_headers`](https://developers.cloudflare.com/workers/static-assets/headers/#custom-headers) and
      ///[`_redirects`](https://developers.cloudflare.com/workers/static-assets/redirects/) files should be
      ///included as modules named `_headers` and `_redirects` with content type `text/plain`.
      assets: Option<Assets>
      ///List of bindings attached to a Worker. You can find more about bindings on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/#bindings.
      bindings: Option<workersbindings>
      ///Date indicating targeted support in the Workers runtime. Backwards incompatible fixes to the runtime following this date will not affect this Worker.
      compatibility_date: Option<workerscompatibilitydate>
      ///Flags that enable or disable certain features in the Workers runtime. Used to enable upcoming features or opt in or out of specific changes not included in a `compatibility_date`.
      compatibility_flags: Option<workerscompatibilityflags>
      ///When the version was created.
      created_on: System.DateTimeOffset
      ///Version identifier.
      id: System.Guid
      ///Resource limits enforced at runtime.
      limits: Option<Limits>
      ///The name of the main module in the `modules` array (e.g. the name of the module that exports a `fetch` handler).
      main_module: Option<string>
      ///Migrations for Durable Objects associated with the version. Migrations are applied when the version is deployed.
      migrations: Option<Newtonsoft.Json.Linq.JToken>
      ///Code, sourcemaps, and other content used at runtime.
      ///This includes [`_headers`](https://developers.cloudflare.com/workers/static-assets/headers/#custom-headers) and
      ///[`_redirects`](https://developers.cloudflare.com/workers/static-assets/redirects/) files used to configure
      ///[Static Assets](https://developers.cloudflare.com/workers/static-assets/). `_headers` and `_redirects` files should be
      ///included as modules named `_headers` and `_redirects` with content type `text/plain`.
      modules: Option<list<Modules>>
      ///The integer version number, starting from one.
      number: int
      ///Configuration for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Specify mode='smart' for Smart Placement, or one of region/hostname/host.
      placement: Option<Newtonsoft.Json.Linq.JObject>
      ///The client used to create the version.
      source: Option<string>
      ///Time in milliseconds spent on [Worker startup](https://developers.cloudflare.com/workers/platform/limits/#worker-startup-time).
      startup_time_ms: Option<int>
      ///All routable URLs that always point to this version. Does not include alias URLs, since aliases can be updated to point to a different version.
      urls: list<string> }
    ///Creates an instance of workersVersion with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created_on: System.DateTimeOffset, id: System.Guid, number: int, urls: list<string>): workersVersion =
        { annotations = None
          assets = None
          bindings = None
          compatibility_date = None
          compatibility_flags = None
          created_on = created_on
          id = id
          limits = None
          main_module = None
          migrations = None
          modules = None
          number = number
          placement = None
          source = None
          startup_time_ms = None
          urls = urls }

///Log settings for the Worker.
type Logs =
    { ///Whether logs are enabled for the Worker.
      enabled: Option<bool>
      ///The sampling rate for logs. From 0 to 1 (1 = 100%, 0.1 = 10%).
      head_sampling_rate: Option<float>
      ///Whether [invocation logs](https://developers.cloudflare.com/workers/observability/logs/workers-logs/#invocation-logs) are enabled for the Worker.
      invocation_logs: Option<bool> }
    ///Creates an instance of Logs with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Logs =
        { enabled = None
          head_sampling_rate = None
          invocation_logs = None }

///Observability settings for the Worker.
type Observability =
    { ///Whether observability is enabled for the Worker.
      enabled: Option<bool>
      ///The sampling rate for observability. From 0 to 1 (1 = 100%, 0.1 = 10%).
      head_sampling_rate: Option<float>
      ///Log settings for the Worker.
      logs: Option<Logs> }
    ///Creates an instance of Observability with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Observability =
        { enabled = None
          head_sampling_rate = None
          logs = None }

type Dispatchnamespaceoutbounds =
    { ///ID of the dispatch namespace.
      namespace_id: string
      ///Name of the dispatch namespace.
      namespace_name: string
      ///ID of the Worker using the dispatch namespace.
      worker_id: string
      ///Name of the Worker using the dispatch namespace.
      worker_name: string }
    ///Creates an instance of Dispatchnamespaceoutbounds with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (namespace_id: string, namespace_name: string, worker_id: string, worker_name: string): Dispatchnamespaceoutbounds =
        { namespace_id = namespace_id
          namespace_name = namespace_name
          worker_id = worker_id
          worker_name = worker_name }

type Domains =
    { ///ID of the TLS certificate issued for the custom domain.
      certificate_id: string
      ///Full hostname of the custom domain, including the zone name.
      hostname: string
      ///ID of the custom domain.
      id: string
      ///ID of the zone.
      zone_id: string
      ///Name of the zone.
      zone_name: string }
    ///Creates an instance of Domains with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (certificate_id: string, hostname: string, id: string, zone_id: string, zone_name: string): Domains =
        { certificate_id = certificate_id
          hostname = hostname
          id = id
          zone_id = zone_id
          zone_name = zone_name }

type Durableobjects =
    { ///ID of the Durable Object namespace being used.
      namespace_id: string
      ///Name of the Durable Object namespace being used.
      namespace_name: string
      ///ID of the Worker using the Durable Object implementation.
      worker_id: string
      ///Name of the Worker using the Durable Object implementation.
      worker_name: string }
    ///Creates an instance of Durableobjects with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (namespace_id: string, namespace_name: string, worker_id: string, worker_name: string): Durableobjects =
        { namespace_id = namespace_id
          namespace_name = namespace_name
          worker_id = worker_id
          worker_name = worker_name }

type Queues =
    { ///ID of the queue consumer configuration.
      queue_consumer_id: string
      ///ID of the queue.
      queue_id: string
      ///Name of the queue.
      queue_name: string }
    ///Creates an instance of Queues with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (queue_consumer_id: string, queue_id: string, queue_name: string): Queues =
        { queue_consumer_id = queue_consumer_id
          queue_id = queue_id
          queue_name = queue_name }

type Workers =
    { ///ID of the referencing Worker.
      id: string
      ///Name of the referencing Worker.
      name: string }
    ///Creates an instance of Workers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string, name: string): Workers = { id = id; name = name }

///Other resources that reference the Worker and depend on it existing.
type References =
    { ///Other Workers that reference the Worker as an outbound for a dispatch namespace.
      dispatch_namespace_outbounds: list<Dispatchnamespaceoutbounds>
      ///Custom domains connected to the Worker.
      domains: list<Domains>
      ///Other Workers that reference Durable Object classes implemented by the Worker.
      durable_objects: list<Durableobjects>
      ///Queues that send messages to the Worker.
      queues: list<Queues>
      ///Other Workers that reference the Worker using [service bindings](https://developers.cloudflare.com/workers/runtime-apis/bindings/service-bindings/).
      workers: list<Workers> }
    ///Creates an instance of References with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (dispatch_namespace_outbounds: list<Dispatchnamespaceoutbounds>,
                          domains: list<Domains>,
                          durable_objects: list<Durableobjects>,
                          queues: list<Queues>,
                          workers: list<Workers>): References =
        { dispatch_namespace_outbounds = dispatch_namespace_outbounds
          domains = domains
          durable_objects = durable_objects
          queues = queues
          workers = workers }

///Subdomain settings for the Worker.
type Subdomain =
    { ///Whether the *.workers.dev subdomain is enabled for the Worker.
      enabled: Option<bool>
      ///Whether [preview URLs](https://developers.cloudflare.com/workers/configuration/previews/) are enabled for the Worker.
      previews_enabled: Option<bool> }
    ///Creates an instance of Subdomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Subdomain =
        { enabled = None
          previews_enabled = None }

type Tailconsumers =
    { ///Name of the consumer Worker.
      name: string }
    ///Creates an instance of Tailconsumers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): Tailconsumers = { name = name }

type workersWorker =
    { ///When the Worker was created.
      created_on: System.DateTimeOffset
      ///When the Worker's most recent deployment was created. `null` if the Worker has never been deployed.
      deployed_on: Option<System.DateTimeOffset>
      ///Immutable ID of the Worker.
      id: string
      ///Whether logpush is enabled for the Worker.
      logpush: bool
      ///Name of the Worker.
      name: string
      ///Observability settings for the Worker.
      observability: Observability
      ///Other resources that reference the Worker and depend on it existing.
      references: References
      ///Subdomain settings for the Worker.
      subdomain: Subdomain
      ///Tags associated with the Worker.
      tags: list<string>
      ///Other Workers that should consume logs from the Worker.
      tail_consumers: list<Tailconsumers>
      ///When the Worker was most recently updated.
      updated_on: System.DateTimeOffset }
    ///Creates an instance of workersWorker with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created_on: System.DateTimeOffset,
                          id: string,
                          logpush: bool,
                          name: string,
                          observability: Observability,
                          references: References,
                          subdomain: Subdomain,
                          tags: list<string>,
                          tail_consumers: list<Tailconsumers>,
                          updated_on: System.DateTimeOffset): workersWorker =
        { created_on = created_on
          deployed_on = None
          id = id
          logpush = logpush
          name = name
          observability = observability
          references = references
          subdomain = subdomain
          tags = tags
          tail_consumers = tail_consumers
          updated_on = updated_on }

type ``workersaccount-settings`` =
    { default_usage_model: Option<string>
      green_compute: Option<bool> }
    ///Creates an instance of workersaccount-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersaccount-settings`` =
        { default_usage_model = None
          green_compute = None }

type ``workersapi-response-collectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersapi-response-collectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-collectionErrorsSource`` = { pointer = None }

type ``workersapi-response-collectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersapi-response-collectionErrorsSource``> }
    ///Creates an instance of workersapi-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersapi-response-collectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersapi-response-collectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersapi-response-collectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-collectionMessagesSource`` = { pointer = None }

type ``workersapi-response-collectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersapi-response-collectionMessagesSource``> }
    ///Creates an instance of workersapi-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersapi-response-collectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Resultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``workersapi-response-collection`` =
    { errors: list<``workersapi-response-collectionErrors``>
      messages: list<``workersapi-response-collectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<Resultinfo> }
    ///Creates an instance of workersapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersapi-response-collectionErrors``>,
                          messages: list<``workersapi-response-collectionMessages``>,
                          success: bool): ``workersapi-response-collection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None }

type ``workersapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-commonErrorsSource`` = { pointer = None }

type ``workersapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersapi-response-commonErrorsSource``> }
    ///Creates an instance of workersapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-commonMessagesSource`` = { pointer = None }

type ``workersapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersapi-response-commonMessagesSource``> }
    ///Creates an instance of workersapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersapi-response-common`` =
    { errors: list<``workersapi-response-commonErrors``>
      messages: list<``workersapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of workersapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersapi-response-commonErrors``>,
                          messages: list<``workersapi-response-commonMessages``>,
                          success: bool): ``workersapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``workersapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of workersapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``workersapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``workersapi-response-null-resultErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersapi-response-null-resultErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-null-resultErrorsSource`` = { pointer = None }

type ``workersapi-response-null-resultErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersapi-response-null-resultErrorsSource``> }
    ///Creates an instance of workersapi-response-null-resultErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersapi-response-null-resultErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersapi-response-null-resultMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersapi-response-null-resultMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-null-resultMessagesSource`` = { pointer = None }

type ``workersapi-response-null-resultMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersapi-response-null-resultMessagesSource``> }
    ///Creates an instance of workersapi-response-null-resultMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersapi-response-null-resultMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersapi-response-null-result`` =
    { errors: list<``workersapi-response-null-resultErrors``>
      messages: list<``workersapi-response-null-resultMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of workersapi-response-null-result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersapi-response-null-resultErrors``>,
                          messages: list<``workersapi-response-null-resultMessages``>,
                          success: bool): ``workersapi-response-null-result`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workersapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-singleErrorsSource`` = { pointer = None }

type ``workersapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersapi-response-singleErrorsSource``> }
    ///Creates an instance of workersapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-singleMessagesSource`` = { pointer = None }

type ``workersapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersapi-response-singleMessagesSource``> }
    ///Creates an instance of workersapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersapi-response-single`` =
    { errors: Option<list<``workersapi-response-singleErrors``>>
      messages: Option<list<``workersapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of workersapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-single`` =
        { errors = None
          messages = None
          success = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersassetsConfigHtmlhandling =
    | [<CompiledName "auto-trailing-slash">] AutoTrailingSlash
    | [<CompiledName "force-trailing-slash">] ForceTrailingSlash
    | [<CompiledName "drop-trailing-slash">] DropTrailingSlash
    | [<CompiledName "none">] None
    member this.Format() =
        match this with
        | AutoTrailingSlash -> "auto-trailing-slash"
        | ForceTrailingSlash -> "force-trailing-slash"
        | DropTrailingSlash -> "drop-trailing-slash"
        | None -> "none"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersassetsConfigNotfoundhandling =
    | [<CompiledName "none">] None
    | [<CompiledName "404-page">] Numeric_404Page
    | [<CompiledName "single-page-application">] SinglePageApplication
    member this.Format() =
        match this with
        | None -> "none"
        | Numeric_404Page -> "404-page"
        | SinglePageApplication -> "single-page-application"

///Configuration for assets within a Worker.
type workersassetsConfig =
    { ///The contents of a _headers file (used to attach custom headers on asset responses).
      _headers: Option<string>
      ///The contents of a _redirects file (used to apply redirects or proxy paths ahead of asset serving).
      _redirects: Option<string>
      ///Determines the redirects and rewrites of requests for HTML content.
      html_handling: Option<workersassetsConfigHtmlhandling>
      ///Determines the response when a request does not match a static asset, and there is no Worker script.
      not_found_handling: Option<workersassetsConfigNotfoundhandling>
      run_worker_first: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of workersassetsConfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersassetsConfig =
        { _headers = None
          _redirects = None
          html_handling = None
          not_found_handling = None
          run_worker_first = None }

///Configuration for assets within a Worker.
type workersassets =
    { ///Configuration for assets within a Worker.
      config: Option<workersassetsConfig>
      ///Token provided upon successful upload of all files from a registered manifest.
      jwt: Option<string> }
    ///Creates an instance of workersassets with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersassets = { config = None; jwt = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindaiType =
    | [<CompiledName "ai">] Ai
    member this.Format() =
        match this with
        | Ai -> "ai"

type workersbindingkindai =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindaiType }
    ///Creates an instance of workersbindingkindai with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, ``type``: workersbindingkindaiType): workersbindingkindai =
        { name = name; ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindanalyticsengineType =
    | [<CompiledName "analytics_engine">] Analytics_engine
    member this.Format() =
        match this with
        | Analytics_engine -> "analytics_engine"

type workersbindingkindanalyticsengine =
    { ///The name of the dataset to bind to.
      dataset: string
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindanalyticsengineType }
    ///Creates an instance of workersbindingkindanalyticsengine with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (dataset: string, name: workersbindingname, ``type``: workersbindingkindanalyticsengineType): workersbindingkindanalyticsengine =
        { dataset = dataset
          name = name
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindassetsType =
    | [<CompiledName "assets">] Assets
    member this.Format() =
        match this with
        | Assets -> "assets"

type workersbindingkindassets =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindassetsType }
    ///Creates an instance of workersbindingkindassets with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, ``type``: workersbindingkindassetsType): workersbindingkindassets =
        { name = name; ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindbrowserType =
    | [<CompiledName "browser">] Browser
    member this.Format() =
        match this with
        | Browser -> "browser"

type workersbindingkindbrowser =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindbrowserType }
    ///Creates an instance of workersbindingkindbrowser with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, ``type``: workersbindingkindbrowserType): workersbindingkindbrowser =
        { name = name; ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindd1Type =
    | [<CompiledName "d1">] D1
    member this.Format() =
        match this with
        | D1 -> "d1"

type workersbindingkindd1 =
    { ///Identifier of the D1 database to bind to.
      id: string
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindd1Type }
    ///Creates an instance of workersbindingkindd1 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string, name: workersbindingname, ``type``: workersbindingkindd1Type): workersbindingkindd1 =
        { id = id
          name = name
          ``type`` = ``type`` }

type workersbindingkinddatablob =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The name of the file containing the data content. Only accepted for `service worker syntax` Workers.
      part: string }
    ///Creates an instance of workersbindingkinddatablob with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, part: string): workersbindingkinddatablob =
        { name = name; part = part }

type Params =
    { ///Name of the parameter.
      name: string }
    ///Creates an instance of Params with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): Params = { name = name }

///Outbound worker.
type Worker =
    { ///Entrypoint to invoke on the outbound worker.
      entrypoint: Option<string>
      ///Environment of the outbound worker.
      environment: Option<string>
      ///Name of the outbound worker.
      service: Option<string> }
    ///Creates an instance of Worker with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Worker =
        { entrypoint = None
          environment = None
          service = None }

///Outbound worker.
type Outbound =
    { ///Pass information from the Dispatch Worker to the Outbound Worker through the parameters.
      ``params``: Option<list<Params>>
      ///Outbound worker.
      worker: Option<Worker> }
    ///Creates an instance of Outbound with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Outbound = { ``params`` = None; worker = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkinddispatchnamespaceType =
    | [<CompiledName "dispatch_namespace">] Dispatch_namespace
    member this.Format() =
        match this with
        | Dispatch_namespace -> "dispatch_namespace"

type workersbindingkinddispatchnamespace =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The name of the dispatch namespace.
      ``namespace``: string
      ///Outbound worker.
      outbound: Option<Outbound>
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkinddispatchnamespaceType }
    ///Creates an instance of workersbindingkinddispatchnamespace with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname,
                          ``namespace``: string,
                          ``type``: workersbindingkinddispatchnamespaceType): workersbindingkinddispatchnamespace =
        { name = name
          ``namespace`` = ``namespace``
          outbound = None
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkinddurableobjectnamespaceType =
    | [<CompiledName "durable_object_namespace">] Durable_object_namespace
    member this.Format() =
        match this with
        | Durable_object_namespace -> "durable_object_namespace"

type workersbindingkinddurableobjectnamespace =
    { ///The exported class name of the Durable Object.
      class_name: Option<string>
      ///The dispatch namespace the Durable Object script belongs to.
      dispatch_namespace: Option<string>
      ///The environment of the script_name to bind to.
      environment: Option<string>
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      namespace_id: Option<Newtonsoft.Json.Linq.JToken>
      ///The script where the Durable Object is defined, if it is external to this Worker.
      script_name: Option<string>
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkinddurableobjectnamespaceType }
    ///Creates an instance of workersbindingkinddurableobjectnamespace with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, ``type``: workersbindingkinddurableobjectnamespaceType): workersbindingkinddurableobjectnamespace =
        { class_name = None
          dispatch_namespace = None
          environment = None
          name = name
          namespace_id = None
          script_name = None
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindhyperdriveType =
    | [<CompiledName "hyperdrive">] Hyperdrive
    member this.Format() =
        match this with
        | Hyperdrive -> "hyperdrive"

type workersbindingkindhyperdrive =
    { ///Identifier of the Hyperdrive connection to bind to.
      id: string
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindhyperdriveType }
    ///Creates an instance of workersbindingkindhyperdrive with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string, name: workersbindingname, ``type``: workersbindingkindhyperdriveType): workersbindingkindhyperdrive =
        { id = id
          name = name
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindimagesType =
    | [<CompiledName "images">] Images
    member this.Format() =
        match this with
        | Images -> "images"

type workersbindingkindimages =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindimagesType }
    ///Creates an instance of workersbindingkindimages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, ``type``: workersbindingkindimagesType): workersbindingkindimages =
        { name = name; ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindinheritType =
    | [<CompiledName "inherit">] Inherit
    member this.Format() =
        match this with
        | Inherit -> "inherit"

type workersbindingkindinherit =
    { ///The name of the inherited binding.
      name: string
      ///The old name of the inherited binding. If set, the binding will be renamed from `old_name` to `name` in the new version. If not set, the binding will keep the same name between versions.
      old_name: Option<string>
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindinheritType
      ///Identifier for the version to inherit the binding from, which can be the version ID or the literal "latest" to inherit from the latest version. Defaults to inheriting the binding from the latest version.
      version_id: Option<string> }
    ///Creates an instance of workersbindingkindinherit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, ``type``: workersbindingkindinheritType): workersbindingkindinherit =
        { name = name
          old_name = None
          ``type`` = ``type``
          version_id = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindjsonType =
    | [<CompiledName "json">] Json
    member this.Format() =
        match this with
        | Json -> "json"

type workersbindingkindjson =
    { ///JSON data to use.
      json: Newtonsoft.Json.Linq.JObject
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindjsonType }
    ///Creates an instance of workersbindingkindjson with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (json: Newtonsoft.Json.Linq.JObject,
                          name: workersbindingname,
                          ``type``: workersbindingkindjsonType): workersbindingkindjson =
        { json = json
          name = name
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindkvnamespaceType =
    | [<CompiledName "kv_namespace">] Kv_namespace
    member this.Format() =
        match this with
        | Kv_namespace -> "kv_namespace"

type workersbindingkindkvnamespace =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///Namespace identifier tag.
      namespace_id: workersnamespaceidentifier
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindkvnamespaceType }
    ///Creates an instance of workersbindingkindkvnamespace with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname,
                          namespace_id: workersnamespaceidentifier,
                          ``type``: workersbindingkindkvnamespaceType): workersbindingkindkvnamespace =
        { name = name
          namespace_id = namespace_id
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindmtlscertificateType =
    | [<CompiledName "mtls_certificate">] Mtls_certificate
    member this.Format() =
        match this with
        | Mtls_certificate -> "mtls_certificate"

type workersbindingkindmtlscertificate =
    { ///Identifier of the certificate to bind to.
      certificate_id: string
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindmtlscertificateType }
    ///Creates an instance of workersbindingkindmtlscertificate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (certificate_id: string,
                          name: workersbindingname,
                          ``type``: workersbindingkindmtlscertificateType): workersbindingkindmtlscertificate =
        { certificate_id = certificate_id
          name = name
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindpipelinesType =
    | [<CompiledName "pipelines">] Pipelines
    member this.Format() =
        match this with
        | Pipelines -> "pipelines"

type workersbindingkindpipelines =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///Name of the Pipeline to bind to.
      pipeline: string
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindpipelinesType }
    ///Creates an instance of workersbindingkindpipelines with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, pipeline: string, ``type``: workersbindingkindpipelinesType): workersbindingkindpipelines =
        { name = name
          pipeline = pipeline
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindplaintextType =
    | [<CompiledName "plain_text">] Plain_text
    member this.Format() =
        match this with
        | Plain_text -> "plain_text"

type workersbindingkindplaintext =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The text value to use.
      text: string
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindplaintextType }
    ///Creates an instance of workersbindingkindplaintext with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, text: string, ``type``: workersbindingkindplaintextType): workersbindingkindplaintext =
        { name = name
          text = text
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindqueueType =
    | [<CompiledName "queue">] Queue
    member this.Format() =
        match this with
        | Queue -> "queue"

type workersbindingkindqueue =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///Name of the Queue to bind to.
      queue_name: string
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindqueueType }
    ///Creates an instance of workersbindingkindqueue with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, queue_name: string, ``type``: workersbindingkindqueueType): workersbindingkindqueue =
        { name = name
          queue_name = queue_name
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Jurisdiction =
    | [<CompiledName "eu">] Eu
    | [<CompiledName "fedramp">] Fedramp
    | [<CompiledName "fedramp-high">] FedrampHigh
    member this.Format() =
        match this with
        | Eu -> "eu"
        | Fedramp -> "fedramp"
        | FedrampHigh -> "fedramp-high"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindr2bucketType =
    | [<CompiledName "r2_bucket">] R2_bucket
    member this.Format() =
        match this with
        | R2_bucket -> "r2_bucket"

type workersbindingkindr2bucket =
    { ///R2 bucket to bind to.
      bucket_name: string
      ///The [jurisdiction](https://developers.cloudflare.com/r2/reference/data-location/#jurisdictional-restrictions) of the R2 bucket.
      jurisdiction: Option<Jurisdiction>
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindr2bucketType }
    ///Creates an instance of workersbindingkindr2bucket with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket_name: string, name: workersbindingname, ``type``: workersbindingkindr2bucketType): workersbindingkindr2bucket =
        { bucket_name = bucket_name
          jurisdiction = None
          name = name
          ``type`` = ``type`` }

///The rate limit configuration.
type Simple =
    { ///The limit (requests per period).
      limit: float
      ///The period in seconds.
      period: int }
    ///Creates an instance of Simple with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (limit: float, period: int): Simple = { limit = limit; period = period }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindratelimitType =
    | [<CompiledName "ratelimit">] Ratelimit
    member this.Format() =
        match this with
        | Ratelimit -> "ratelimit"

type workersbindingkindratelimit =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///Identifier of the rate limit namespace to bind to.
      namespace_id: string
      ///The rate limit configuration.
      simple: Simple
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindratelimitType }
    ///Creates an instance of workersbindingkindratelimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname,
                          namespace_id: string,
                          simple: Simple,
                          ``type``: workersbindingkindratelimitType): workersbindingkindratelimit =
        { name = name
          namespace_id = namespace_id
          simple = simple
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Format =
    | [<CompiledName "raw">] Raw
    | [<CompiledName "pkcs8">] Pkcs8
    | [<CompiledName "spki">] Spki
    | [<CompiledName "jwk">] Jwk
    member this.Format() =
        match this with
        | Raw -> "raw"
        | Pkcs8 -> "pkcs8"
        | Spki -> "spki"
        | Jwk -> "jwk"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindsecretkeyType =
    | [<CompiledName "secret_key">] Secret_key
    member this.Format() =
        match this with
        | Secret_key -> "secret_key"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Usages =
    | [<CompiledName "encrypt">] Encrypt
    | [<CompiledName "decrypt">] Decrypt
    | [<CompiledName "sign">] Sign
    | [<CompiledName "verify">] Verify
    | [<CompiledName "deriveKey">] DeriveKey
    | [<CompiledName "deriveBits">] DeriveBits
    | [<CompiledName "wrapKey">] WrapKey
    | [<CompiledName "unwrapKey">] UnwrapKey
    member this.Format() =
        match this with
        | Encrypt -> "encrypt"
        | Decrypt -> "decrypt"
        | Sign -> "sign"
        | Verify -> "verify"
        | DeriveKey -> "deriveKey"
        | DeriveBits -> "deriveBits"
        | WrapKey -> "wrapKey"
        | UnwrapKey -> "unwrapKey"

type workersbindingkindsecretkey =
    { ///Algorithm-specific key parameters. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#algorithm).
      algorithm: Newtonsoft.Json.Linq.JObject
      ///Data format of the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#format).
      format: Format
      ///Base64-encoded key data. Required if `format` is "raw", "pkcs8", or "spki".
      key_base64: Option<string>
      ///Key data in [JSON Web Key](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#json_web_key) format. Required if `format` is "jwk".
      key_jwk: Option<Newtonsoft.Json.Linq.JObject>
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindsecretkeyType
      ///Allowed operations with the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#keyUsages).
      usages: list<Usages> }
    ///Creates an instance of workersbindingkindsecretkey with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (algorithm: Newtonsoft.Json.Linq.JObject,
                          format: Format,
                          name: workersbindingname,
                          ``type``: workersbindingkindsecretkeyType,
                          usages: list<Usages>): workersbindingkindsecretkey =
        { algorithm = algorithm
          format = format
          key_base64 = None
          key_jwk = None
          name = name
          ``type`` = ``type``
          usages = usages }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindsecrettextType =
    | [<CompiledName "secret_text">] Secret_text
    member this.Format() =
        match this with
        | Secret_text -> "secret_text"

type workersbindingkindsecrettext =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The secret value to use.
      text: string
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindsecrettextType }
    ///Creates an instance of workersbindingkindsecrettext with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, text: string, ``type``: workersbindingkindsecrettextType): workersbindingkindsecrettext =
        { name = name
          text = text
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindsecretsstoresecretType =
    | [<CompiledName "secrets_store_secret">] Secrets_store_secret
    member this.Format() =
        match this with
        | Secrets_store_secret -> "secrets_store_secret"

type workersbindingkindsecretsstoresecret =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///Name of the secret in the store.
      secret_name: string
      ///ID of the store containing the secret.
      store_id: string
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindsecretsstoresecretType }
    ///Creates an instance of workersbindingkindsecretsstoresecret with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname,
                          secret_name: string,
                          store_id: string,
                          ``type``: workersbindingkindsecretsstoresecretType): workersbindingkindsecretsstoresecret =
        { name = name
          secret_name = secret_name
          store_id = store_id
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindsendemailType =
    | [<CompiledName "send_email">] Send_email
    member this.Format() =
        match this with
        | Send_email -> "send_email"

type workersbindingkindsendemail =
    { ///List of allowed destination addresses.
      allowed_destination_addresses: Option<list<string>>
      ///List of allowed sender addresses.
      allowed_sender_addresses: Option<list<string>>
      ///Destination address for the email.
      destination_address: Option<string>
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindsendemailType }
    ///Creates an instance of workersbindingkindsendemail with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, ``type``: workersbindingkindsendemailType): workersbindingkindsendemail =
        { allowed_destination_addresses = None
          allowed_sender_addresses = None
          destination_address = None
          name = name
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindserviceType =
    | [<CompiledName "service">] Service
    member this.Format() =
        match this with
        | Service -> "service"

type workersbindingkindservice =
    { ///Entrypoint to invoke on the target Worker.
      entrypoint: Option<string>
      ///Optional environment if the Worker utilizes one.
      environment: Option<string>
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///Name of Worker to bind to.
      service: string
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindserviceType }
    ///Creates an instance of workersbindingkindservice with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, service: string, ``type``: workersbindingkindserviceType): workersbindingkindservice =
        { entrypoint = None
          environment = None
          name = name
          service = service
          ``type`` = ``type`` }

type workersbindingkindtextblob =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The name of the file containing the text content. Only accepted for `service worker syntax` Workers.
      part: string }
    ///Creates an instance of workersbindingkindtextblob with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, part: string): workersbindingkindtextblob =
        { name = name; part = part }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindvectorizeType =
    | [<CompiledName "vectorize">] Vectorize
    member this.Format() =
        match this with
        | Vectorize -> "vectorize"

type workersbindingkindvectorize =
    { ///Name of the Vectorize index to bind to.
      index_name: string
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindvectorizeType }
    ///Creates an instance of workersbindingkindvectorize with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (index_name: string, name: workersbindingname, ``type``: workersbindingkindvectorizeType): workersbindingkindvectorize =
        { index_name = index_name
          name = name
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindversionmetadataType =
    | [<CompiledName "version_metadata">] Version_metadata
    member this.Format() =
        match this with
        | Version_metadata -> "version_metadata"

type workersbindingkindversionmetadata =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindversionmetadataType }
    ///Creates an instance of workersbindingkindversionmetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, ``type``: workersbindingkindversionmetadataType): workersbindingkindversionmetadata =
        { name = name; ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindvpcserviceType =
    | [<CompiledName "vpc_service">] Vpc_service
    member this.Format() =
        match this with
        | Vpc_service -> "vpc_service"

type workersbindingkindvpcservice =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///Identifier of the VPC service to bind to.
      service_id: string
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindvpcserviceType }
    ///Creates an instance of workersbindingkindvpcservice with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, service_id: string, ``type``: workersbindingkindvpcserviceType): workersbindingkindvpcservice =
        { name = name
          service_id = service_id
          ``type`` = ``type`` }

type workersbindingkindwasmmodule =
    { ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///The name of the file containing the WebAssembly module content. Only accepted for `service worker syntax` Workers.
      part: string }
    ///Creates an instance of workersbindingkindwasmmodule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, part: string): workersbindingkindwasmmodule =
        { name = name; part = part }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type workersbindingkindworkflowType =
    | [<CompiledName "workflow">] Workflow
    member this.Format() =
        match this with
        | Workflow -> "workflow"

type workersbindingkindworkflow =
    { ///Class name of the Workflow. Should only be provided if the Workflow belongs to this script.
      class_name: Option<string>
      ///A JavaScript variable name for the binding.
      name: workersbindingname
      ///Script name that contains the Workflow. If not provided, defaults to this script name.
      script_name: Option<string>
      ///The kind of resource that the binding provides.
      ``type``: workersbindingkindworkflowType
      ///Name of the Workflow to bind to.
      workflow_name: string }
    ///Creates an instance of workersbindingkindworkflow with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: workersbindingname, ``type``: workersbindingkindworkflowType, workflow_name: string): workersbindingkindworkflow =
        { class_name = None
          name = name
          script_name = None
          ``type`` = ``type``
          workflow_name = workflow_name }

type ``workerscompleted-upload-assets-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workerscompleted-upload-assets-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workerscompleted-upload-assets-responseErrorsSource`` = { pointer = None }

type ``workerscompleted-upload-assets-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workerscompleted-upload-assets-responseErrorsSource``> }
    ///Creates an instance of workerscompleted-upload-assets-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workerscompleted-upload-assets-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workerscompleted-upload-assets-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workerscompleted-upload-assets-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workerscompleted-upload-assets-responseMessagesSource`` = { pointer = None }

type ``workerscompleted-upload-assets-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workerscompleted-upload-assets-responseMessagesSource``> }
    ///Creates an instance of workerscompleted-upload-assets-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workerscompleted-upload-assets-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Result =
    { ///A "completion" JWT which can be redeemed when creating a Worker version.
      jwt: Option<string> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result = { jwt = None }

type ``workerscompleted-upload-assets-response`` =
    { errors: list<``workerscompleted-upload-assets-responseErrors``>
      messages: list<``workerscompleted-upload-assets-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Result> }
    ///Creates an instance of workerscompleted-upload-assets-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workerscompleted-upload-assets-responseErrors``>,
                          messages: list<``workerscompleted-upload-assets-responseMessages``>,
                          success: bool): ``workerscompleted-upload-assets-response`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workerscreate-assets-upload-session-object`` =
    { ///A manifest ([path]: {hash, size}) map of files to upload. As an example, `/blog/hello-world.html` would be a valid path key.
      manifest: Map<string, ``workersmanifest-value``> }
    ///Creates an instance of workerscreate-assets-upload-session-object with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (manifest: Map<string, ``workersmanifest-value``>): ``workerscreate-assets-upload-session-object`` =
        { manifest = manifest }

type ``workerscreate-assets-upload-session-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workerscreate-assets-upload-session-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workerscreate-assets-upload-session-responseErrorsSource`` = { pointer = None }

type ``workerscreate-assets-upload-session-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workerscreate-assets-upload-session-responseErrorsSource``> }
    ///Creates an instance of workerscreate-assets-upload-session-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workerscreate-assets-upload-session-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workerscreate-assets-upload-session-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workerscreate-assets-upload-session-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workerscreate-assets-upload-session-responseMessagesSource`` = { pointer = None }

type ``workerscreate-assets-upload-session-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workerscreate-assets-upload-session-responseMessagesSource``> }
    ///Creates an instance of workerscreate-assets-upload-session-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workerscreate-assets-upload-session-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workerscreate-assets-upload-session-responseResult`` =
    { ///The requests to make to upload assets.
      buckets: Option<list<list<string>>>
      ///A JWT to use as authentication for uploading assets.
      jwt: Option<string> }
    ///Creates an instance of workerscreate-assets-upload-session-responseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workerscreate-assets-upload-session-responseResult`` = { buckets = None; jwt = None }

type ``workerscreate-assets-upload-session-response`` =
    { errors: list<``workerscreate-assets-upload-session-responseErrors``>
      messages: list<``workerscreate-assets-upload-session-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``workerscreate-assets-upload-session-responseResult``> }
    ///Creates an instance of workerscreate-assets-upload-session-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workerscreate-assets-upload-session-responseErrors``>,
                          messages: list<``workerscreate-assets-upload-session-responseMessages``>,
                          success: bool): ``workerscreate-assets-upload-session-response`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type workersdeploymentAnnotations =
    { ///Human-readable message about the deployment. Truncated to 100 bytes.
      ``workers/message``: Option<string>
      ///Operation that triggered the creation of the deployment.
      ``workers/triggered_by``: Option<string> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Strategy =
    | [<CompiledName "percentage">] Percentage
    member this.Format() =
        match this with
        | Percentage -> "percentage"

type Versions =
    { percentage: float
      version_id: System.Guid }
    ///Creates an instance of Versions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (percentage: float, version_id: System.Guid): Versions =
        { percentage = percentage
          version_id = version_id }

type workersdeployment =
    { annotations: Option<workersdeploymentAnnotations>
      author_email: Option<string>
      created_on: System.DateTimeOffset
      id: System.Guid
      source: string
      strategy: Strategy
      versions: list<Versions> }
    ///Creates an instance of workersdeployment with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created_on: System.DateTimeOffset,
                          id: System.Guid,
                          source: string,
                          strategy: Strategy,
                          versions: list<Versions>): workersdeployment =
        { annotations = None
          author_email = None
          created_on = created_on
          id = id
          source = source
          strategy = strategy
          versions = versions }

type workersdomain =
    { ///Hostname of the Worker Domain.
      hostname: Option<workershostname>
      ///Identifer of the Worker Domain.
      id: Option<workersdomainidentifier>
      ///Worker service associated with the zone and hostname.
      service: Option<``workersschemas-service``>
      ///Identifier of the zone.
      zone_id: Option<workerszoneidentifier>
      ///Name of the zone.
      zone_name: Option<workerszonename> }
    ///Creates an instance of workersdomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersdomain =
        { hostname = None
          id = None
          service = None
          zone_id = None
          zone_name = None }

type ``workersdomain-response-collectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersdomain-response-collectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersdomain-response-collectionErrorsSource`` = { pointer = None }

type ``workersdomain-response-collectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersdomain-response-collectionErrorsSource``> }
    ///Creates an instance of workersdomain-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersdomain-response-collectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersdomain-response-collectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersdomain-response-collectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersdomain-response-collectionMessagesSource`` = { pointer = None }

type ``workersdomain-response-collectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersdomain-response-collectionMessagesSource``> }
    ///Creates an instance of workersdomain-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersdomain-response-collectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersdomain-response-collection`` =
    { errors: list<``workersdomain-response-collectionErrors``>
      messages: list<``workersdomain-response-collectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<list<workersdomain>> }
    ///Creates an instance of workersdomain-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersdomain-response-collectionErrors``>,
                          messages: list<``workersdomain-response-collectionMessages``>,
                          success: bool): ``workersdomain-response-collection`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workersdomain-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersdomain-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersdomain-response-singleErrorsSource`` = { pointer = None }

type ``workersdomain-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersdomain-response-singleErrorsSource``> }
    ///Creates an instance of workersdomain-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersdomain-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersdomain-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersdomain-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersdomain-response-singleMessagesSource`` = { pointer = None }

type ``workersdomain-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersdomain-response-singleMessagesSource``> }
    ///Creates an instance of workersdomain-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersdomain-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersdomain-response-single`` =
    { errors: list<``workersdomain-response-singleErrors``>
      messages: list<``workersdomain-response-singleMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<workersdomain> }
    ///Creates an instance of workersdomain-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersdomain-response-singleErrors``>,
                          messages: list<``workersdomain-response-singleMessages``>,
                          success: bool): ``workersdomain-response-single`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

///Limits to apply for this Worker.
type workerslimits =
    { ///The amount of CPU time this Worker can use in milliseconds.
      cpu_ms: Option<int> }
    ///Creates an instance of workerslimits with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workerslimits = { cpu_ms = None }

type ``workersmanifest-value`` =
    { ///The hash of the file.
      hash: string
      ///The size of the file in bytes.
      size: int }
    ///Creates an instance of workersmanifest-value with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (hash: string, size: int): ``workersmanifest-value`` = { hash = hash; size = size }

type Renamedclasses =
    { from: Option<string>
      ``to``: Option<string> }
    ///Creates an instance of Renamedclasses with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Renamedclasses = { from = None; ``to`` = None }

type Transferredclasses =
    { from: Option<string>
      from_script: Option<string>
      ``to``: Option<string> }
    ///Creates an instance of Transferredclasses with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Transferredclasses =
        { from = None
          from_script = None
          ``to`` = None }

type workersmigrationstep =
    { ///A list of classes to delete Durable Object namespaces from.
      deleted_classes: Option<list<string>>
      ///A list of classes to create Durable Object namespaces from.
      new_classes: Option<list<string>>
      ///A list of classes to create Durable Object namespaces with SQLite from.
      new_sqlite_classes: Option<list<string>>
      ///A list of classes with Durable Object namespaces that were renamed.
      renamed_classes: Option<list<Renamedclasses>>
      ///A list of transfers for Durable Object namespaces from a different Worker and class to a class defined in this Worker.
      transferred_classes: Option<list<Transferredclasses>> }
    ///Creates an instance of workersmigrationstep with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersmigrationstep =
        { deleted_classes = None
          new_classes = None
          new_sqlite_classes = None
          renamed_classes = None
          transferred_classes = None }

type workersmigrationtagconditions =
    { ///Tag to set as the latest migration tag.
      new_tag: Option<string>
      ///Tag used to verify against the latest migration tag for this Worker. If they don't match, the upload is rejected.
      old_tag: Option<string> }
    ///Creates an instance of workersmigrationtagconditions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersmigrationtagconditions = { new_tag = None; old_tag = None }

///JSON-encoded metadata about the uploaded parts and Worker configuration.
type Metadata =
    { ///Configuration for assets within a Worker.
      assets: Option<workersassets>
      ///List of bindings attached to a Worker. You can find more about bindings on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/#bindings.
      bindings: Option<workersbindings>
      ///Name of the uploaded file that contains the script (e.g. the file adding a listener to the `fetch` event). Indicates a `service worker syntax` Worker.
      body_part: Option<string>
      ///Date indicating targeted support in the Workers runtime. Backwards incompatible fixes to the runtime following this date will not affect this Worker.
      compatibility_date: Option<workerscompatibilitydate>
      ///Flags that enable or disable certain features in the Workers runtime. Used to enable upcoming features or opt in or out of specific changes not included in a `compatibility_date`.
      compatibility_flags: Option<workerscompatibilityflags>
      ///Retain assets which exist for a previously uploaded Worker version; used in lieu of providing a completion token.
      keep_assets: Option<bool>
      ///List of binding types to keep from previous_upload.
      keep_bindings: Option<list<string>>
      ///Limits to apply for this Worker.
      limits: Option<workerslimits>
      ///Whether Logpush is turned on for the Worker.
      logpush: Option<workerslogpush>
      ///Name of the uploaded file that contains the main module (e.g. the file exporting a `fetch` handler). Indicates a `module syntax` Worker.
      main_module: Option<string>
      ///Migrations to apply for Durable Objects associated with this Worker.
      migrations: Option<Newtonsoft.Json.Linq.JToken>
      ///Observability settings for the Worker.
      observability: Option<workersobservability>
      placement: Option<workersplacementinfo>
      ///List of strings to use as tags for this Worker.
      tags: Option<list<string>>
      ///List of Workers that will consume logs from the attached Worker.
      tail_consumers: Option<workerstailconsumers>
      ///Usage model for the Worker invocations.
      usage_model: Option<workersusagemodel> }
    ///Creates an instance of Metadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Metadata =
        { assets = None
          bindings = None
          body_part = None
          compatibility_date = None
          compatibility_flags = None
          keep_assets = None
          keep_bindings = None
          limits = None
          logpush = None
          main_module = None
          migrations = None
          observability = None
          placement = None
          tags = None
          tail_consumers = None
          usage_model = None }

type ``workersmultipart-script`` =
    { ///An array of modules (often JavaScript files) comprising a Worker script. At least one module must be present and referenced in the metadata as `main_module` or `body_part` by filename.&amp;lt;br/&amp;gt;Possible Content-Type(s) are: `application/javascript+module`, `text/javascript+module`, `application/javascript`, `text/javascript`, `text/x-python`, `text/x-python-requirement`, `application/wasm`, `text/plain`, `application/octet-stream`, `application/source-map`.
      files: Option<list<string>>
      ///JSON-encoded metadata about the uploaded parts and Worker configuration.
      metadata: Metadata }
    ///Creates an instance of workersmultipart-script with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (metadata: Metadata): ``workersmultipart-script`` = { files = None; metadata = metadata }

type workersmultiplestepmigrations =
    { ///Tag to set as the latest migration tag.
      new_tag: Option<string>
      ///Tag used to verify against the latest migration tag for this Worker. If they don't match, the upload is rejected.
      old_tag: Option<string>
      ///Migrations to apply in order.
      steps: Option<list<workersmigrationstep>> }
    ///Creates an instance of workersmultiplestepmigrations with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersmultiplestepmigrations =
        { new_tag = None
          old_tag = None
          steps = None }

type workersnamespace =
    { ``class``: Option<string>
      id: Option<string>
      name: Option<string>
      script: Option<string>
      use_sqlite: Option<bool> }
    ///Creates an instance of workersnamespace with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersnamespace =
        { ``class`` = None
          id = None
          name = None
          script = None
          use_sqlite = None }

type ``workersnamespace-list-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersnamespace-list-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-list-responseErrorsSource`` = { pointer = None }

type ``workersnamespace-list-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersnamespace-list-responseErrorsSource``> }
    ///Creates an instance of workersnamespace-list-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersnamespace-list-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersnamespace-list-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersnamespace-list-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-list-responseMessagesSource`` = { pointer = None }

type ``workersnamespace-list-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersnamespace-list-responseMessagesSource``> }
    ///Creates an instance of workersnamespace-list-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersnamespace-list-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersnamespace-list-response`` =
    { errors: list<``workersnamespace-list-responseErrors``>
      messages: list<``workersnamespace-list-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<list<``workersnamespace-response``>> }
    ///Creates an instance of workersnamespace-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersnamespace-list-responseErrors``>,
                          messages: list<``workersnamespace-list-responseMessages``>,
                          success: bool): ``workersnamespace-list-response`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workersnamespace-response`` =
    { ///Identifier.
      created_by: Option<workersidentifier>
      ///When the script was created.
      created_on: Option<workerscreatedon>
      ///Identifier.
      modified_by: Option<workersidentifier>
      ///When the script was last modified.
      modified_on: Option<workersmodifiedon>
      ///API Resource UUID tag.
      namespace_id: Option<workersuuid>
      ///Name of the Workers for Platforms dispatch namespace.
      namespace_name: Option<workersdispatchnamespacename>
      ///The current number of scripts in this Dispatch Namespace.
      script_count: Option<workersscriptcount>
      ///Whether the Workers in the namespace are executed in a "trusted" manner. When a Worker is trusted, it has access to the shared caches for the zone in the Cache API, and has access to the `request.cf` object on incoming Requests. When a Worker is untrusted, caches are not shared across the zone, and `request.cf` is undefined. By default, Workers in a namespace are "untrusted".
      trusted_workers: Option<workerstrustedworkers> }
    ///Creates an instance of workersnamespace-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-response`` =
        { created_by = None
          created_on = None
          modified_by = None
          modified_on = None
          namespace_id = None
          namespace_name = None
          script_count = None
          trusted_workers = None }

///Script and version settings for Workers for Platforms namespace scripts. Same as script-and-version-settings-item but without annotations, which are not supported for namespace scripts.
type ``workersnamespace-script-and-version-settings-item`` =
    { bindings: Option<Newtonsoft.Json.Linq.JToken>
      compatibility_date: Option<Newtonsoft.Json.Linq.JToken>
      compatibility_flags: Option<Newtonsoft.Json.Linq.JToken>
      ///Limits to apply for this Worker.
      limits: Option<workerslimits>
      ///Whether Logpush is turned on for the Worker.
      logpush: Option<workerslogpush>
      ///Migrations to apply for Durable Objects associated with this Worker.
      migrations: Option<Newtonsoft.Json.Linq.JToken>
      ///Observability settings for the Worker.
      observability: Option<workersobservability>
      placement: Option<Newtonsoft.Json.Linq.JToken>
      tags: Option<Newtonsoft.Json.Linq.JToken>
      tail_consumers: Option<Newtonsoft.Json.Linq.JToken>
      ///Usage model for the Worker invocations.
      usage_model: Option<workersusagemodel> }
    ///Creates an instance of workersnamespace-script-and-version-settings-item with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-script-and-version-settings-item`` =
        { bindings = None
          compatibility_date = None
          compatibility_flags = None
          limits = None
          logpush = None
          migrations = None
          observability = None
          placement = None
          tags = None
          tail_consumers = None
          usage_model = None }

type Deleted =
    { ///API Resource UUID tag.
      id: Option<workersuuid> }
    ///Creates an instance of Deleted with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Deleted = { id = None }

///Detail about bulk deletion of scripts in a namespace.
type ``workersnamespace-script-delete-bulk-response`` =
    { deleted: Option<list<Deleted>>
      deleted_count: Option<int>
      has_more: Option<bool> }
    ///Creates an instance of workersnamespace-script-delete-bulk-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-script-delete-bulk-response`` =
        { deleted = None
          deleted_count = None
          has_more = None }

///Details about a worker uploaded to a Workers for Platforms namespace.
type ``workersnamespace-script-response`` =
    { ///When the script was created.
      created_on: Option<workerscreatedon>
      ///Name of the Workers for Platforms dispatch namespace.
      dispatch_namespace: Option<workersdispatchnamespacename>
      ///When the script was last modified.
      modified_on: Option<workersmodifiedon>
      script: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of workersnamespace-script-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-script-response`` =
        { created_on = None
          dispatch_namespace = None
          modified_on = None
          script = None }

type ``workersnamespace-script-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersnamespace-script-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-script-response-singleErrorsSource`` = { pointer = None }

type ``workersnamespace-script-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersnamespace-script-response-singleErrorsSource``> }
    ///Creates an instance of workersnamespace-script-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersnamespace-script-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersnamespace-script-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersnamespace-script-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-script-response-singleMessagesSource`` = { pointer = None }

type ``workersnamespace-script-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersnamespace-script-response-singleMessagesSource``> }
    ///Creates an instance of workersnamespace-script-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersnamespace-script-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersnamespace-script-response-single`` =
    { errors: list<``workersnamespace-script-response-singleErrors``>
      messages: list<``workersnamespace-script-response-singleMessages``>
      ///Whether the API call was successful.
      success: bool
      ///Details about a worker uploaded to a Workers for Platforms namespace.
      result: ``workersnamespace-script-response`` }
    ///Creates an instance of workersnamespace-script-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersnamespace-script-response-singleErrors``>,
                          messages: list<``workersnamespace-script-response-singleMessages``>,
                          success: bool,
                          result: ``workersnamespace-script-response``): ``workersnamespace-script-response-single`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``workersnamespace-single-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersnamespace-single-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-single-responseErrorsSource`` = { pointer = None }

type ``workersnamespace-single-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersnamespace-single-responseErrorsSource``> }
    ///Creates an instance of workersnamespace-single-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersnamespace-single-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersnamespace-single-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersnamespace-single-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersnamespace-single-responseMessagesSource`` = { pointer = None }

type ``workersnamespace-single-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersnamespace-single-responseMessagesSource``> }
    ///Creates an instance of workersnamespace-single-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersnamespace-single-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersnamespace-single-response`` =
    { errors: list<``workersnamespace-single-responseErrors``>
      messages: list<``workersnamespace-single-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``workersnamespace-response``> }
    ///Creates an instance of workersnamespace-single-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersnamespace-single-responseErrors``>,
                          messages: list<``workersnamespace-single-responseMessages``>,
                          success: bool): ``workersnamespace-single-response`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type workersobject =
    { ///Whether the Durable Object has stored data.
      hasStoredData: Option<bool>
      ///ID of the Durable Object.
      id: Option<string> }
    ///Creates an instance of workersobject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersobject = { hasStoredData = None; id = None }

///Log settings for the Worker.
type workersobservabilityLogs =
    { ///A list of destinations where logs will be exported to.
      destinations: Option<list<string>>
      ///Whether logs are enabled for the Worker.
      enabled: bool
      ///The sampling rate for logs. From 0 to 1 (1 = 100%, 0.1 = 10%). Default is 1.
      head_sampling_rate: Option<float>
      ///Whether [invocation logs](https://developers.cloudflare.com/workers/observability/logs/workers-logs/#invocation-logs) are enabled for the Worker.
      invocation_logs: bool
      ///Whether log persistence is enabled for the Worker.
      persist: Option<bool> }
    ///Creates an instance of workersobservabilityLogs with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool, invocation_logs: bool): workersobservabilityLogs =
        { destinations = None
          enabled = enabled
          head_sampling_rate = None
          invocation_logs = invocation_logs
          persist = None }

///Observability settings for the Worker.
type workersobservability =
    { ///Whether observability is enabled for the Worker.
      enabled: bool
      ///The sampling rate for incoming requests. From 0 to 1 (1 = 100%, 0.1 = 10%). Default is 1.
      head_sampling_rate: Option<float>
      ///Log settings for the Worker.
      logs: Option<workersobservabilityLogs> }
    ///Creates an instance of workersobservability with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool): workersobservability =
        { enabled = enabled
          head_sampling_rate = None
          logs = None }

type ``workersplacement-provider`` =
    { ///The cloud provider identifier.
      id: string
      ///List of regions available for this provider.
      regions: list<``workersplacement-region``> }
    ///Creates an instance of workersplacement-provider with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string, regions: list<``workersplacement-region``>): ``workersplacement-provider`` =
        { id = id; regions = regions }

type ``workersplacement-region`` =
    { ///The region identifier.
      id: string }
    ///Creates an instance of workersplacement-region with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): ``workersplacement-region`` = { id = id }

type ``workersplacement-regions-response`` =
    { ///List of cloud providers with their available regions.
      providers: list<``workersplacement-provider``> }
    ///Creates an instance of workersplacement-regions-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (providers: list<``workersplacement-provider``>): ``workersplacement-regions-response`` =
        { providers = providers }

type workersplacementinfo =
    { ///The last time the script was analyzed for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement).
      last_analyzed_at: Option<System.DateTimeOffset>
      ///Status of [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement).
      status: Option<workersplacementstatus> }
    ///Creates an instance of workersplacementinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersplacementinfo =
        { last_analyzed_at = None
          status = None }

type workersroute =
    { id: Newtonsoft.Json.Linq.JToken
      ///Pattern to match incoming requests against. [Learn more](https://developers.cloudflare.com/workers/configuration/routing/routes/#matching-behavior).
      pattern: string
      ///Name of the script to run if the route matches.
      script: Option<string> }
    ///Creates an instance of workersroute with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: Newtonsoft.Json.Linq.JToken, pattern: string): workersroute =
        { id = id
          pattern = pattern
          script = None }

type workersschedule =
    { created_on: Option<string>
      cron: string
      modified_on: Option<string> }
    ///Creates an instance of workersschedule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cron: string): workersschedule =
        { created_on = None
          cron = cron
          modified_on = None }

type ``workersschemas-subdomain`` =
    { subdomain: string }
    ///Creates an instance of workersschemas-subdomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (subdomain: string): ``workersschemas-subdomain`` = { subdomain = subdomain }

///Annotations for the Worker version. Annotations are not inherited across settings updates; omitting this field means the new version will have no annotations.
type ``workersscript-and-version-settings-itemAnnotations`` =
    { ///Human-readable message about the version.
      ``workers/message``: Option<string>
      ///User-provided identifier for the version.
      ``workers/tag``: Option<string>
      ///Operation that triggered the creation of the version. This is read-only and set by the server.
      ``workers/triggered_by``: Option<string> }

type ``workersscript-and-version-settings-item`` =
    { ///Annotations for the Worker version. Annotations are not inherited across settings updates; omitting this field means the new version will have no annotations.
      annotations: Option<``workersscript-and-version-settings-itemAnnotations``>
      bindings: Option<Newtonsoft.Json.Linq.JToken>
      compatibility_date: Option<Newtonsoft.Json.Linq.JToken>
      compatibility_flags: Option<Newtonsoft.Json.Linq.JToken>
      ///Limits to apply for this Worker.
      limits: Option<workerslimits>
      ///Whether Logpush is turned on for the Worker.
      logpush: Option<workerslogpush>
      ///Migrations to apply for Durable Objects associated with this Worker.
      migrations: Option<Newtonsoft.Json.Linq.JToken>
      ///Observability settings for the Worker.
      observability: Option<workersobservability>
      placement: Option<Newtonsoft.Json.Linq.JToken>
      tags: Option<Newtonsoft.Json.Linq.JToken>
      tail_consumers: Option<Newtonsoft.Json.Linq.JToken>
      ///Usage model for the Worker invocations.
      usage_model: Option<workersusagemodel> }
    ///Creates an instance of workersscript-and-version-settings-item with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-and-version-settings-item`` =
        { annotations = None
          bindings = None
          compatibility_date = None
          compatibility_flags = None
          limits = None
          logpush = None
          migrations = None
          observability = None
          placement = None
          tags = None
          tail_consumers = None
          usage_model = None }

type ``workersscript-and-version-settings-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-and-version-settings-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-and-version-settings-responseErrorsSource`` = { pointer = None }

type ``workersscript-and-version-settings-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-and-version-settings-responseErrorsSource``> }
    ///Creates an instance of workersscript-and-version-settings-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-and-version-settings-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-and-version-settings-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-and-version-settings-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-and-version-settings-responseMessagesSource`` = { pointer = None }

type ``workersscript-and-version-settings-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-and-version-settings-responseMessagesSource``> }
    ///Creates an instance of workersscript-and-version-settings-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-and-version-settings-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-and-version-settings-response`` =
    { errors: list<``workersscript-and-version-settings-responseErrors``>
      messages: list<``workersscript-and-version-settings-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersscript-and-version-settings-item`` }
    ///Creates an instance of workersscript-and-version-settings-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersscript-and-version-settings-responseErrors``>,
                          messages: list<``workersscript-and-version-settings-responseMessages``>,
                          success: bool,
                          result: ``workersscript-and-version-settings-item``): ``workersscript-and-version-settings-response`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type Namedhandlers =
    { ///The names of handlers exported as part of the named export.
      handlers: Option<list<string>>
      ///The name of the export.
      name: Option<string> }
    ///Creates an instance of Namedhandlers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Namedhandlers = { handlers = None; name = None }

type ``workersscript-response`` =
    { ///Date indicating targeted support in the Workers runtime. Backwards incompatible fixes to the runtime following this date will not affect this Worker.
      compatibility_date: Option<workerscompatibilitydate>
      ///Flags that enable or disable certain features in the Workers runtime. Used to enable upcoming features or opt in or out of specific changes not included in a `compatibility_date`.
      compatibility_flags: Option<workerscompatibilityflags>
      ///When the script was created.
      created_on: Option<workerscreatedon>
      ///Hashed script content, can be used in a If-None-Match header when updating.
      etag: Option<workersetag>
      ///The names of handlers exported as part of the default export.
      handlers: Option<list<string>>
      ///Whether a Worker contains assets.
      has_assets: Option<workershasassets>
      ///Whether a Worker contains modules.
      has_modules: Option<workershasmodules>
      ///The name used to identify the script.
      id: Option<string>
      ///The client most recently used to deploy this Worker.
      last_deployed_from: Option<string>
      ///Whether Logpush is turned on for the Worker.
      logpush: Option<workerslogpush>
      ///The tag of the Durable Object migration that was most recently applied for this Worker.
      migration_tag: Option<string>
      ///When the script was last modified.
      modified_on: Option<workersmodifiedon>
      ///Named exports, such as Durable Object class implementations and named entrypoints.
      named_handlers: Option<list<Namedhandlers>>
      ///Observability settings for the Worker.
      observability: Option<workersobservability>
      placement: Option<workersplacementinfo>
      placement_mode: Option<Newtonsoft.Json.Linq.JToken>
      placement_status: Option<Newtonsoft.Json.Linq.JToken>
      ///The immutable ID of the script.
      tag: Option<string>
      ///Tags associated with the Worker.
      tags: Option<workerstags>
      ///List of Workers that will consume logs from the attached Worker.
      tail_consumers: Option<workerstailconsumers>
      ///Usage model for the Worker invocations.
      usage_model: Option<workersusagemodel> }
    ///Creates an instance of workersscript-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-response`` =
        { compatibility_date = None
          compatibility_flags = None
          created_on = None
          etag = None
          handlers = None
          has_assets = None
          has_modules = None
          id = None
          last_deployed_from = None
          logpush = None
          migration_tag = None
          modified_on = None
          named_handlers = None
          observability = None
          placement = None
          placement_mode = None
          placement_status = None
          tag = None
          tags = None
          tail_consumers = None
          usage_model = None }

type ``workersscript-response-collectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-response-collectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-response-collectionErrorsSource`` = { pointer = None }

type ``workersscript-response-collectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-response-collectionErrorsSource``> }
    ///Creates an instance of workersscript-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-response-collectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-response-collectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-response-collectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-response-collectionMessagesSource`` = { pointer = None }

type ``workersscript-response-collectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-response-collectionMessagesSource``> }
    ///Creates an instance of workersscript-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-response-collectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-response-collection`` =
    { errors: list<``workersscript-response-collectionErrors``>
      messages: list<``workersscript-response-collectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result: list<string> }
    ///Creates an instance of workersscript-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersscript-response-collectionErrors``>,
                          messages: list<``workersscript-response-collectionMessages``>,
                          success: bool,
                          result: list<string>): ``workersscript-response-collection`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``workersscript-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-response-singleErrorsSource`` = { pointer = None }

type ``workersscript-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-response-singleErrorsSource``> }
    ///Creates an instance of workersscript-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-response-singleMessagesSource`` = { pointer = None }

type ``workersscript-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-response-singleMessagesSource``> }
    ///Creates an instance of workersscript-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-response-single`` =
    { errors: list<``workersscript-response-singleErrors``>
      messages: list<``workersscript-response-singleMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of workersscript-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersscript-response-singleErrors``>,
                          messages: list<``workersscript-response-singleMessages``>,
                          success: bool,
                          result: Newtonsoft.Json.Linq.JToken): ``workersscript-response-single`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``workersscript-response-uploadNamedhandlers`` =
    { ///The names of handlers exported as part of the named export.
      handlers: Option<list<string>>
      ///The name of the export.
      name: Option<string> }
    ///Creates an instance of workersscript-response-uploadNamedhandlers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-response-uploadNamedhandlers`` = { handlers = None; name = None }

type ``workersscript-response-upload`` =
    { ///Date indicating targeted support in the Workers runtime. Backwards incompatible fixes to the runtime following this date will not affect this Worker.
      compatibility_date: Option<workerscompatibilitydate>
      ///Flags that enable or disable certain features in the Workers runtime. Used to enable upcoming features or opt in or out of specific changes not included in a `compatibility_date`.
      compatibility_flags: Option<workerscompatibilityflags>
      ///When the script was created.
      created_on: Option<workerscreatedon>
      ///Hashed script content, can be used in a If-None-Match header when updating.
      etag: Option<workersetag>
      ///The names of handlers exported as part of the default export.
      handlers: Option<list<string>>
      ///Whether a Worker contains assets.
      has_assets: Option<workershasassets>
      ///Whether a Worker contains modules.
      has_modules: Option<workershasmodules>
      ///The name used to identify the script.
      id: Option<string>
      ///The client most recently used to deploy this Worker.
      last_deployed_from: Option<string>
      ///Whether Logpush is turned on for the Worker.
      logpush: Option<workerslogpush>
      ///The tag of the Durable Object migration that was most recently applied for this Worker.
      migration_tag: Option<string>
      ///When the script was last modified.
      modified_on: Option<workersmodifiedon>
      ///Named exports, such as Durable Object class implementations and named entrypoints.
      named_handlers: Option<list<``workersscript-response-uploadNamedhandlers``>>
      ///Observability settings for the Worker.
      observability: Option<workersobservability>
      placement: Option<workersplacementinfo>
      placement_mode: Option<Newtonsoft.Json.Linq.JToken>
      placement_status: Option<Newtonsoft.Json.Linq.JToken>
      ///The immutable ID of the script.
      tag: Option<string>
      ///Tags associated with the Worker.
      tags: Option<workerstags>
      ///List of Workers that will consume logs from the attached Worker.
      tail_consumers: Option<workerstailconsumers>
      ///Usage model for the Worker invocations.
      usage_model: Option<workersusagemodel>
      ///The entry point for the script.
      entry_point: Option<string>
      startup_time_ms: int }
    ///Creates an instance of workersscript-response-upload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (startup_time_ms: int): ``workersscript-response-upload`` =
        { compatibility_date = None
          compatibility_flags = None
          created_on = None
          etag = None
          handlers = None
          has_assets = None
          has_modules = None
          id = None
          last_deployed_from = None
          logpush = None
          migration_tag = None
          modified_on = None
          named_handlers = None
          observability = None
          placement = None
          placement_mode = None
          placement_status = None
          tag = None
          tags = None
          tail_consumers = None
          usage_model = None
          entry_point = None
          startup_time_ms = startup_time_ms }

type ``workersscript-response-upload-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-response-upload-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-response-upload-singleErrorsSource`` = { pointer = None }

type ``workersscript-response-upload-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-response-upload-singleErrorsSource``> }
    ///Creates an instance of workersscript-response-upload-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-response-upload-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-response-upload-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-response-upload-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-response-upload-singleMessagesSource`` = { pointer = None }

type ``workersscript-response-upload-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-response-upload-singleMessagesSource``> }
    ///Creates an instance of workersscript-response-upload-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-response-upload-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-response-upload-single`` =
    { errors: list<``workersscript-response-upload-singleErrors``>
      messages: list<``workersscript-response-upload-singleMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersscript-response-upload`` }
    ///Creates an instance of workersscript-response-upload-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersscript-response-upload-singleErrors``>,
                          messages: list<``workersscript-response-upload-singleMessages``>,
                          success: bool,
                          result: ``workersscript-response-upload``): ``workersscript-response-upload-single`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``workersscript-settings-item`` =
    { ///Whether Logpush is turned on for the Worker.
      logpush: Option<workerslogpush>
      observability: Option<Newtonsoft.Json.Linq.JToken>
      tags: Option<Newtonsoft.Json.Linq.JToken>
      ///List of Workers that will consume logs from the attached Worker.
      tail_consumers: Option<list<workerstailconsumersscript>> }
    ///Creates an instance of workersscript-settings-item with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-settings-item`` =
        { logpush = None
          observability = None
          tags = None
          tail_consumers = None }

type ``workersscript-settings-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-settings-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-settings-responseErrorsSource`` = { pointer = None }

type ``workersscript-settings-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-settings-responseErrorsSource``> }
    ///Creates an instance of workersscript-settings-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-settings-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-settings-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersscript-settings-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersscript-settings-responseMessagesSource`` = { pointer = None }

type ``workersscript-settings-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersscript-settings-responseMessagesSource``> }
    ///Creates an instance of workersscript-settings-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersscript-settings-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersscript-settings-response`` =
    { errors: list<``workersscript-settings-responseErrors``>
      messages: list<``workersscript-settings-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersscript-settings-item`` }
    ///Creates an instance of workersscript-settings-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersscript-settings-responseErrors``>,
                          messages: list<``workersscript-settings-responseMessages``>,
                          success: bool,
                          result: ``workersscript-settings-item``): ``workersscript-settings-response`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type workerssinglestepmigrationsRenamedclasses =
    { from: Option<string>
      ``to``: Option<string> }
    ///Creates an instance of workerssinglestepmigrationsRenamedclasses with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workerssinglestepmigrationsRenamedclasses = { from = None; ``to`` = None }

type workerssinglestepmigrationsTransferredclasses =
    { from: Option<string>
      from_script: Option<string>
      ``to``: Option<string> }
    ///Creates an instance of workerssinglestepmigrationsTransferredclasses with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workerssinglestepmigrationsTransferredclasses =
        { from = None
          from_script = None
          ``to`` = None }

type workerssinglestepmigrations =
    { ///Tag to set as the latest migration tag.
      new_tag: Option<string>
      ///Tag used to verify against the latest migration tag for this Worker. If they don't match, the upload is rejected.
      old_tag: Option<string>
      ///A list of classes to delete Durable Object namespaces from.
      deleted_classes: Option<list<string>>
      ///A list of classes to create Durable Object namespaces from.
      new_classes: Option<list<string>>
      ///A list of classes to create Durable Object namespaces with SQLite from.
      new_sqlite_classes: Option<list<string>>
      ///A list of classes with Durable Object namespaces that were renamed.
      renamed_classes: Option<list<workerssinglestepmigrationsRenamedclasses>>
      ///A list of transfers for Durable Object namespaces from a different Worker and class to a class defined in this Worker.
      transferred_classes: Option<list<workerssinglestepmigrationsTransferredclasses>> }
    ///Creates an instance of workerssinglestepmigrations with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workerssinglestepmigrations =
        { new_tag = None
          old_tag = None
          deleted_classes = None
          new_classes = None
          new_sqlite_classes = None
          renamed_classes = None
          transferred_classes = None }

type workerssubdomain =
    { ///Whether the Worker is available on the workers.dev subdomain.
      enabled: bool
      ///Whether the Worker's Preview URLs are available on the workers.dev subdomain.
      previews_enabled: bool }
    ///Creates an instance of workerssubdomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool, previews_enabled: bool): workerssubdomain =
        { enabled = enabled
          previews_enabled = previews_enabled }

type workerstail =
    { expires_at: string
      id: Newtonsoft.Json.Linq.JToken
      url: string }
    ///Creates an instance of workerstail with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (expires_at: string, id: Newtonsoft.Json.Linq.JToken, url: string): workerstail =
        { expires_at = expires_at
          id = id
          url = url }

///A reference to a script that will consume logs from the attached Worker.
type workerstailconsumersscript =
    { ///Optional environment if the Worker utilizes one.
      environment: Option<string>
      ///Optional dispatch namespace the script belongs to.
      ``namespace``: Option<string>
      ///Name of Worker that is to be the consumer.
      service: string }
    ///Creates an instance of workerstailconsumersscript with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (service: string): workerstailconsumersscript =
        { environment = None
          ``namespace`` = None
          service = service }

type ``workersupload-assets-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersupload-assets-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersupload-assets-responseErrorsSource`` = { pointer = None }

type ``workersupload-assets-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersupload-assets-responseErrorsSource``> }
    ///Creates an instance of workersupload-assets-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersupload-assets-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersupload-assets-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersupload-assets-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersupload-assets-responseMessagesSource`` = { pointer = None }

type ``workersupload-assets-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersupload-assets-responseMessagesSource``> }
    ///Creates an instance of workersupload-assets-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersupload-assets-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersupload-assets-response`` =
    { errors: list<``workersupload-assets-responseErrors``>
      messages: list<``workersupload-assets-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of workersupload-assets-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersupload-assets-responseErrors``>,
                          messages: list<``workersupload-assets-responseMessages``>,
                          success: bool): ``workersupload-assets-response`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workersusage-model-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersusage-model-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersusage-model-responseErrorsSource`` = { pointer = None }

type ``workersusage-model-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersusage-model-responseErrorsSource``> }
    ///Creates an instance of workersusage-model-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersusage-model-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersusage-model-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersusage-model-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersusage-model-responseMessagesSource`` = { pointer = None }

type ``workersusage-model-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersusage-model-responseMessagesSource``> }
    ///Creates an instance of workersusage-model-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersusage-model-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersusage-model-responseResult`` =
    { ///Usage model for the Worker invocations.
      usage_model: Option<workersusagemodel>
      ///User-defined resource limits for Workers with standard usage model.
      user_limits: Option<workersuserlimits> }
    ///Creates an instance of workersusage-model-responseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersusage-model-responseResult`` =
        { usage_model = None
          user_limits = None }

type ``workersusage-model-response`` =
    { errors: list<``workersusage-model-responseErrors``>
      messages: list<``workersusage-model-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersusage-model-responseResult`` }
    ///Creates an instance of workersusage-model-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersusage-model-responseErrors``>,
                          messages: list<``workersusage-model-responseMessages``>,
                          success: bool,
                          result: ``workersusage-model-responseResult``): ``workersusage-model-response`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

///User-defined resource limits for Workers with standard usage model.
type workersuserlimits =
    { ///The amount of CPU time this Worker can use in milliseconds.
      cpu_ms: Option<int> }
    ///Creates an instance of workersuserlimits with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersuserlimits = { cpu_ms = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``workersversion-item-fullMetadataSource`` =
    | [<CompiledName "unknown">] Unknown
    | [<CompiledName "api">] Api
    | [<CompiledName "wrangler">] Wrangler
    | [<CompiledName "terraform">] Terraform
    | [<CompiledName "dash">] Dash
    | [<CompiledName "dash_template">] Dash_template
    | [<CompiledName "integration">] Integration
    | [<CompiledName "quick_editor">] Quick_editor
    | [<CompiledName "playground">] Playground
    | [<CompiledName "workersci">] Workersci
    member this.Format() =
        match this with
        | Unknown -> "unknown"
        | Api -> "api"
        | Wrangler -> "wrangler"
        | Terraform -> "terraform"
        | Dash -> "dash"
        | Dash_template -> "dash_template"
        | Integration -> "integration"
        | Quick_editor -> "quick_editor"
        | Playground -> "playground"
        | Workersci -> "workersci"

type ``workersversion-item-fullMetadata`` =
    { ///Email of the user who created the version.
      author_email: Option<string>
      ///Identifier of the user who created the version.
      author_id: Option<string>
      ///When the version was created.
      created_on: Option<string>
      ///Whether the version can be previewed.
      hasPreview: Option<bool>
      ///When the version was last modified.
      modified_on: Option<string>
      ///The source of the version upload.
      source: Option<``workersversion-item-fullMetadataSource``> }
    ///Creates an instance of workersversion-item-fullMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversion-item-fullMetadata`` =
        { author_email = None
          author_id = None
          created_on = None
          hasPreview = None
          modified_on = None
          source = None }

type ScriptNamedhandlers =
    { ///The names of handlers exported as part of the named export.
      handlers: Option<list<string>>
      ///The name of the exported class or entrypoint.
      name: Option<string> }
    ///Creates an instance of ScriptNamedhandlers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ScriptNamedhandlers = { handlers = None; name = None }

type Script =
    { ///Hashed script content
      etag: Option<string>
      ///The names of handlers exported as part of the default export.
      handlers: Option<list<string>>
      ///The client most recently used to deploy this Worker.
      last_deployed_from: Option<string>
      ///Named exports, such as Durable Object class implementations and named entrypoints.
      named_handlers: Option<list<ScriptNamedhandlers>> }
    ///Creates an instance of Script with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Script =
        { etag = None
          handlers = None
          last_deployed_from = None
          named_handlers = None }

///Resource limits for the Worker.
type ScriptruntimeLimits =
    { ///The amount of CPU time this Worker can use in milliseconds.
      cpu_ms: Option<int> }
    ///Creates an instance of ScriptruntimeLimits with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ScriptruntimeLimits = { cpu_ms = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Usagemodel =
    | [<CompiledName "bundled">] Bundled
    | [<CompiledName "unbound">] Unbound
    | [<CompiledName "standard">] Standard
    member this.Format() =
        match this with
        | Bundled -> "bundled"
        | Unbound -> "unbound"
        | Standard -> "standard"

///Runtime configuration for the Worker.
type Scriptruntime =
    { ///Date indicating targeted support in the Workers runtime. Backwards incompatible fixes to the runtime following this date will not affect this Worker.
      compatibility_date: Option<string>
      ///Flags that enable or disable certain features in the Workers runtime.
      compatibility_flags: Option<list<string>>
      ///Resource limits for the Worker.
      limits: Option<ScriptruntimeLimits>
      ///The tag of the Durable Object migration that was most recently applied for this Worker.
      migration_tag: Option<string>
      ///Usage model for the Worker invocations.
      usage_model: Option<Usagemodel> }
    ///Creates an instance of Scriptruntime with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Scriptruntime =
        { compatibility_date = None
          compatibility_flags = None
          limits = None
          migration_tag = None
          usage_model = None }

type Resources =
    { bindings: Option<Newtonsoft.Json.Linq.JToken>
      script: Option<Script>
      ///Runtime configuration for the Worker.
      script_runtime: Option<Scriptruntime> }
    ///Creates an instance of Resources with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resources =
        { bindings = None
          script = None
          script_runtime = None }

type ``workersversion-item-full`` =
    { ///Unique identifier for the version.
      id: Option<string>
      metadata: Option<``workersversion-item-fullMetadata``>
      ///Sequential version number.
      number: Option<float>
      resources: Resources }
    ///Creates an instance of workersversion-item-full with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (resources: Resources): ``workersversion-item-full`` =
        { id = None
          metadata = None
          number = None
          resources = resources }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``workersversion-item-shortMetadataSource`` =
    | [<CompiledName "unknown">] Unknown
    | [<CompiledName "api">] Api
    | [<CompiledName "wrangler">] Wrangler
    | [<CompiledName "terraform">] Terraform
    | [<CompiledName "dash">] Dash
    | [<CompiledName "dash_template">] Dash_template
    | [<CompiledName "integration">] Integration
    | [<CompiledName "quick_editor">] Quick_editor
    | [<CompiledName "playground">] Playground
    | [<CompiledName "workersci">] Workersci
    member this.Format() =
        match this with
        | Unknown -> "unknown"
        | Api -> "api"
        | Wrangler -> "wrangler"
        | Terraform -> "terraform"
        | Dash -> "dash"
        | Dash_template -> "dash_template"
        | Integration -> "integration"
        | Quick_editor -> "quick_editor"
        | Playground -> "playground"
        | Workersci -> "workersci"

type ``workersversion-item-shortMetadata`` =
    { ///Email of the user who created the version.
      author_email: Option<string>
      ///Identifier of the user who created the version.
      author_id: Option<string>
      ///When the version was created.
      created_on: Option<string>
      ///Whether the version can be previewed.
      hasPreview: Option<bool>
      ///When the version was last modified.
      modified_on: Option<string>
      ///The source of the version upload.
      source: Option<``workersversion-item-shortMetadataSource``> }
    ///Creates an instance of workersversion-item-shortMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversion-item-shortMetadata`` =
        { author_email = None
          author_id = None
          created_on = None
          hasPreview = None
          modified_on = None
          source = None }

type ``workersversion-item-short`` =
    { ///Unique identifier for the version.
      id: Option<string>
      metadata: Option<``workersversion-item-shortMetadata``>
      ///Sequential version number.
      number: Option<float> }
    ///Creates an instance of workersversion-item-short with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversion-item-short`` =
        { id = None
          metadata = None
          number = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``workersversion-item-uploadedMetadataSource`` =
    | [<CompiledName "unknown">] Unknown
    | [<CompiledName "api">] Api
    | [<CompiledName "wrangler">] Wrangler
    | [<CompiledName "terraform">] Terraform
    | [<CompiledName "dash">] Dash
    | [<CompiledName "dash_template">] Dash_template
    | [<CompiledName "integration">] Integration
    | [<CompiledName "quick_editor">] Quick_editor
    | [<CompiledName "playground">] Playground
    | [<CompiledName "workersci">] Workersci
    member this.Format() =
        match this with
        | Unknown -> "unknown"
        | Api -> "api"
        | Wrangler -> "wrangler"
        | Terraform -> "terraform"
        | Dash -> "dash"
        | Dash_template -> "dash_template"
        | Integration -> "integration"
        | Quick_editor -> "quick_editor"
        | Playground -> "playground"
        | Workersci -> "workersci"

type ``workersversion-item-uploadedMetadata`` =
    { ///Email of the user who created the version.
      author_email: Option<string>
      ///Identifier of the user who created the version.
      author_id: Option<string>
      ///When the version was created.
      created_on: Option<string>
      ///Whether the version can be previewed.
      hasPreview: Option<bool>
      ///When the version was last modified.
      modified_on: Option<string>
      ///The source of the version upload.
      source: Option<``workersversion-item-uploadedMetadataSource``> }
    ///Creates an instance of workersversion-item-uploadedMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversion-item-uploadedMetadata`` =
        { author_email = None
          author_id = None
          created_on = None
          hasPreview = None
          modified_on = None
          source = None }

type ``workersversion-item-uploadedResourcesScriptNamedhandlers`` =
    { ///The names of handlers exported as part of the named export.
      handlers: Option<list<string>>
      ///The name of the exported class or entrypoint.
      name: Option<string> }
    ///Creates an instance of workersversion-item-uploadedResourcesScriptNamedhandlers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversion-item-uploadedResourcesScriptNamedhandlers`` =
        { handlers = None; name = None }

type ``workersversion-item-uploadedResourcesScript`` =
    { ///Hashed script content
      etag: Option<string>
      ///The names of handlers exported as part of the default export.
      handlers: Option<list<string>>
      ///The client most recently used to deploy this Worker.
      last_deployed_from: Option<string>
      ///Named exports, such as Durable Object class implementations and named entrypoints.
      named_handlers: Option<list<``workersversion-item-uploadedResourcesScriptNamedhandlers``>> }
    ///Creates an instance of workersversion-item-uploadedResourcesScript with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversion-item-uploadedResourcesScript`` =
        { etag = None
          handlers = None
          last_deployed_from = None
          named_handlers = None }

///Resource limits for the Worker.
type ``workersversion-item-uploadedResourcesScriptruntimeLimits`` =
    { ///The amount of CPU time this Worker can use in milliseconds.
      cpu_ms: Option<int> }
    ///Creates an instance of workersversion-item-uploadedResourcesScriptruntimeLimits with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversion-item-uploadedResourcesScriptruntimeLimits`` = { cpu_ms = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``workersversion-item-uploadedResourcesScriptruntimeUsagemodel`` =
    | [<CompiledName "bundled">] Bundled
    | [<CompiledName "unbound">] Unbound
    | [<CompiledName "standard">] Standard
    member this.Format() =
        match this with
        | Bundled -> "bundled"
        | Unbound -> "unbound"
        | Standard -> "standard"

///Runtime configuration for the Worker.
type ``workersversion-item-uploadedResourcesScriptruntime`` =
    { ///Date indicating targeted support in the Workers runtime. Backwards incompatible fixes to the runtime following this date will not affect this Worker.
      compatibility_date: Option<string>
      ///Flags that enable or disable certain features in the Workers runtime.
      compatibility_flags: Option<list<string>>
      ///Resource limits for the Worker.
      limits: Option<``workersversion-item-uploadedResourcesScriptruntimeLimits``>
      ///The tag of the Durable Object migration that was most recently applied for this Worker.
      migration_tag: Option<string>
      ///Usage model for the Worker invocations.
      usage_model: Option<``workersversion-item-uploadedResourcesScriptruntimeUsagemodel``> }
    ///Creates an instance of workersversion-item-uploadedResourcesScriptruntime with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversion-item-uploadedResourcesScriptruntime`` =
        { compatibility_date = None
          compatibility_flags = None
          limits = None
          migration_tag = None
          usage_model = None }

type ``workersversion-item-uploadedResources`` =
    { bindings: Option<Newtonsoft.Json.Linq.JToken>
      script: Option<``workersversion-item-uploadedResourcesScript``>
      ///Runtime configuration for the Worker.
      script_runtime: Option<``workersversion-item-uploadedResourcesScriptruntime``> }
    ///Creates an instance of workersversion-item-uploadedResources with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversion-item-uploadedResources`` =
        { bindings = None
          script = None
          script_runtime = None }

type ``workersversion-item-uploaded`` =
    { ///Unique identifier for the version.
      id: Option<string>
      metadata: Option<``workersversion-item-uploadedMetadata``>
      ///Sequential version number.
      number: Option<float>
      resources: ``workersversion-item-uploadedResources``
      ///Time in milliseconds spent on [Worker startup](https://developers.cloudflare.com/workers/platform/limits/#worker-startup-time).
      startup_time_ms: Option<int> }
    ///Creates an instance of workersversion-item-uploaded with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (resources: ``workersversion-item-uploadedResources``): ``workersversion-item-uploaded`` =
        { id = None
          metadata = None
          number = None
          resources = resources
          startup_time_ms = None }

type ``workersversions-list-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersversions-list-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversions-list-responseErrorsSource`` = { pointer = None }

type ``workersversions-list-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersversions-list-responseErrorsSource``> }
    ///Creates an instance of workersversions-list-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersversions-list-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersversions-list-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersversions-list-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversions-list-responseMessagesSource`` = { pointer = None }

type ``workersversions-list-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersversions-list-responseMessagesSource``> }
    ///Creates an instance of workersversions-list-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersversions-list-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersversions-list-responseResult`` =
    { items: Option<list<``workersversion-item-short``>> }
    ///Creates an instance of workersversions-list-responseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversions-list-responseResult`` = { items = None }

type ``workersversions-list-response`` =
    { errors: list<``workersversions-list-responseErrors``>
      messages: list<``workersversions-list-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersversions-list-responseResult`` }
    ///Creates an instance of workersversions-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersversions-list-responseErrors``>,
                          messages: list<``workersversions-list-responseMessages``>,
                          success: bool,
                          result: ``workersversions-list-responseResult``): ``workersversions-list-response`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``workersversions-single-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersversions-single-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversions-single-responseErrorsSource`` = { pointer = None }

type ``workersversions-single-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersversions-single-responseErrorsSource``> }
    ///Creates an instance of workersversions-single-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersversions-single-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersversions-single-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersversions-single-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversions-single-responseMessagesSource`` = { pointer = None }

type ``workersversions-single-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersversions-single-responseMessagesSource``> }
    ///Creates an instance of workersversions-single-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersversions-single-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersversions-single-response`` =
    { errors: list<``workersversions-single-responseErrors``>
      messages: list<``workersversions-single-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersversion-item-full`` }
    ///Creates an instance of workersversions-single-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersversions-single-responseErrors``>,
                          messages: list<``workersversions-single-responseMessages``>,
                          success: bool,
                          result: ``workersversion-item-full``): ``workersversions-single-response`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``workersversions-upload-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersversions-upload-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversions-upload-responseErrorsSource`` = { pointer = None }

type ``workersversions-upload-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersversions-upload-responseErrorsSource``> }
    ///Creates an instance of workersversions-upload-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersversions-upload-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersversions-upload-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of workersversions-upload-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersversions-upload-responseMessagesSource`` = { pointer = None }

type ``workersversions-upload-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``workersversions-upload-responseMessagesSource``> }
    ///Creates an instance of workersversions-upload-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workersversions-upload-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``workersversions-upload-response`` =
    { errors: list<``workersversions-upload-responseErrors``>
      messages: list<``workersversions-upload-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersversion-item-uploaded`` }
    ///Creates an instance of workersversions-upload-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workersversions-upload-responseErrors``>,
                          messages: list<``workersversions-upload-responseMessages``>,
                          success: bool,
                          result: ``workersversion-item-uploaded``): ``workersversions-upload-response`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``worker-script-upload-worker-moduleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-script-upload-worker-moduleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-script-upload-worker-moduleresponseErrorsSource`` = { pointer = None }

type ``worker-script-upload-worker-moduleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-script-upload-worker-moduleresponseErrorsSource``> }
    ///Creates an instance of worker-script-upload-worker-moduleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-script-upload-worker-moduleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-script-upload-worker-moduleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-script-upload-worker-moduleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-script-upload-worker-moduleresponseMessagesSource`` = { pointer = None }

type ``worker-script-upload-worker-moduleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-script-upload-worker-moduleresponseMessagesSource``> }
    ///Creates an instance of worker-script-upload-worker-moduleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-script-upload-worker-moduleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-script-upload-worker-moduleresponse`` =
    { errors: list<``worker-script-upload-worker-moduleresponseErrors``>
      messages: list<``worker-script-upload-worker-moduleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersscript-response-upload`` }
    ///Creates an instance of worker-script-upload-worker-moduleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``worker-script-upload-worker-moduleresponseErrors``>,
                          messages: list<``worker-script-upload-worker-moduleresponseMessages``>,
                          success: bool,
                          result: ``workersscript-response-upload``): ``worker-script-upload-worker-moduleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``worker-cron-trigger-get-cron-triggersresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-cron-trigger-get-cron-triggersresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-cron-trigger-get-cron-triggersresponseErrorsSource`` = { pointer = None }

type ``worker-cron-trigger-get-cron-triggersresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-cron-trigger-get-cron-triggersresponseErrorsSource``> }
    ///Creates an instance of worker-cron-trigger-get-cron-triggersresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-cron-trigger-get-cron-triggersresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-cron-trigger-get-cron-triggersresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-cron-trigger-get-cron-triggersresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-cron-trigger-get-cron-triggersresponseMessagesSource`` = { pointer = None }

type ``worker-cron-trigger-get-cron-triggersresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-cron-trigger-get-cron-triggersresponseMessagesSource``> }
    ///Creates an instance of worker-cron-trigger-get-cron-triggersresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-cron-trigger-get-cron-triggersresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-cron-trigger-get-cron-triggersresponseResult`` =
    { schedules: list<workersschedule> }
    ///Creates an instance of worker-cron-trigger-get-cron-triggersresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (schedules: list<workersschedule>): ``worker-cron-trigger-get-cron-triggersresponseResult`` =
        { schedules = schedules }

type ``worker-cron-trigger-get-cron-triggersresponse`` =
    { errors: list<``worker-cron-trigger-get-cron-triggersresponseErrors``>
      messages: list<``worker-cron-trigger-get-cron-triggersresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``worker-cron-trigger-get-cron-triggersresponseResult`` }
    ///Creates an instance of worker-cron-trigger-get-cron-triggersresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``worker-cron-trigger-get-cron-triggersresponseErrors``>,
                          messages: list<``worker-cron-trigger-get-cron-triggersresponseMessages``>,
                          success: bool,
                          result: ``worker-cron-trigger-get-cron-triggersresponseResult``): ``worker-cron-trigger-get-cron-triggersresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``worker-cron-trigger-update-cron-triggersresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-cron-trigger-update-cron-triggersresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-cron-trigger-update-cron-triggersresponseErrorsSource`` = { pointer = None }

type ``worker-cron-trigger-update-cron-triggersresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-cron-trigger-update-cron-triggersresponseErrorsSource``> }
    ///Creates an instance of worker-cron-trigger-update-cron-triggersresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-cron-trigger-update-cron-triggersresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-cron-trigger-update-cron-triggersresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-cron-trigger-update-cron-triggersresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-cron-trigger-update-cron-triggersresponseMessagesSource`` = { pointer = None }

type ``worker-cron-trigger-update-cron-triggersresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-cron-trigger-update-cron-triggersresponseMessagesSource``> }
    ///Creates an instance of worker-cron-trigger-update-cron-triggersresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-cron-trigger-update-cron-triggersresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-cron-trigger-update-cron-triggersresponseResult`` =
    { schedules: list<workersschedule> }
    ///Creates an instance of worker-cron-trigger-update-cron-triggersresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (schedules: list<workersschedule>): ``worker-cron-trigger-update-cron-triggersresponseResult`` =
        { schedules = schedules }

type ``worker-cron-trigger-update-cron-triggersresponse`` =
    { errors: list<``worker-cron-trigger-update-cron-triggersresponseErrors``>
      messages: list<``worker-cron-trigger-update-cron-triggersresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``worker-cron-trigger-update-cron-triggersresponseResult`` }
    ///Creates an instance of worker-cron-trigger-update-cron-triggersresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``worker-cron-trigger-update-cron-triggersresponseErrors``>,
                          messages: list<``worker-cron-trigger-update-cron-triggersresponseMessages``>,
                          success: bool,
                          result: ``worker-cron-trigger-update-cron-triggersresponseResult``): ``worker-cron-trigger-update-cron-triggersresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``worker-list-script-secretsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-list-script-secretsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-list-script-secretsresponseErrorsSource`` = { pointer = None }

type ``worker-list-script-secretsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-list-script-secretsresponseErrorsSource``> }
    ///Creates an instance of worker-list-script-secretsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-list-script-secretsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-list-script-secretsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-list-script-secretsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-list-script-secretsresponseMessagesSource`` = { pointer = None }

type ``worker-list-script-secretsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-list-script-secretsresponseMessagesSource``> }
    ///Creates an instance of worker-list-script-secretsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-list-script-secretsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-list-script-secretsresponse`` =
    { errors: list<``worker-list-script-secretsresponseErrors``>
      messages: list<``worker-list-script-secretsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<list<workerssecret>> }
    ///Creates an instance of worker-list-script-secretsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``worker-list-script-secretsresponseErrors``>,
                          messages: list<``worker-list-script-secretsresponseMessages``>,
                          success: bool): ``worker-list-script-secretsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``worker-put-script-secretresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-put-script-secretresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-put-script-secretresponseErrorsSource`` = { pointer = None }

type ``worker-put-script-secretresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-put-script-secretresponseErrorsSource``> }
    ///Creates an instance of worker-put-script-secretresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-put-script-secretresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-put-script-secretresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-put-script-secretresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-put-script-secretresponseMessagesSource`` = { pointer = None }

type ``worker-put-script-secretresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-put-script-secretresponseMessagesSource``> }
    ///Creates an instance of worker-put-script-secretresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-put-script-secretresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-put-script-secretresponse`` =
    { errors: list<``worker-put-script-secretresponseErrors``>
      messages: list<``worker-put-script-secretresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      ///A secret value accessible through a binding.
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of worker-put-script-secretresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``worker-put-script-secretresponseErrors``>,
                          messages: list<``worker-put-script-secretresponseMessages``>,
                          success: bool): ``worker-put-script-secretresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type getaccountsaccountidworkersscriptsscriptnametailsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of getaccountsaccountidworkersscriptsscriptnametailsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getaccountsaccountidworkersscriptsscriptnametailsresponseErrorsSource = { pointer = None }

type getaccountsaccountidworkersscriptsscriptnametailsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<getaccountsaccountidworkersscriptsscriptnametailsresponseErrorsSource> }
    ///Creates an instance of getaccountsaccountidworkersscriptsscriptnametailsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): getaccountsaccountidworkersscriptsscriptnametailsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type getaccountsaccountidworkersscriptsscriptnametailsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of getaccountsaccountidworkersscriptsscriptnametailsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getaccountsaccountidworkersscriptsscriptnametailsresponseMessagesSource =
        { pointer = None }

type getaccountsaccountidworkersscriptsscriptnametailsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<getaccountsaccountidworkersscriptsscriptnametailsresponseMessagesSource> }
    ///Creates an instance of getaccountsaccountidworkersscriptsscriptnametailsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): getaccountsaccountidworkersscriptsscriptnametailsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type getaccountsaccountidworkersscriptsscriptnametailsresponse =
    { errors: list<getaccountsaccountidworkersscriptsscriptnametailsresponseErrors>
      messages: list<getaccountsaccountidworkersscriptsscriptnametailsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: workerstail }
    ///Creates an instance of getaccountsaccountidworkersscriptsscriptnametailsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<getaccountsaccountidworkersscriptsscriptnametailsresponseErrors>,
                          messages: list<getaccountsaccountidworkersscriptsscriptnametailsresponseMessages>,
                          success: bool,
                          result: workerstail): getaccountsaccountidworkersscriptsscriptnametailsresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``worker-tail-logs-start-tailresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-tail-logs-start-tailresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-tail-logs-start-tailresponseErrorsSource`` = { pointer = None }

type ``worker-tail-logs-start-tailresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-tail-logs-start-tailresponseErrorsSource``> }
    ///Creates an instance of worker-tail-logs-start-tailresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-tail-logs-start-tailresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-tail-logs-start-tailresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-tail-logs-start-tailresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-tail-logs-start-tailresponseMessagesSource`` = { pointer = None }

type ``worker-tail-logs-start-tailresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-tail-logs-start-tailresponseMessagesSource``> }
    ///Creates an instance of worker-tail-logs-start-tailresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-tail-logs-start-tailresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-tail-logs-start-tailresponse`` =
    { errors: list<``worker-tail-logs-start-tailresponseErrors``>
      messages: list<``worker-tail-logs-start-tailresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: workerstail }
    ///Creates an instance of worker-tail-logs-start-tailresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``worker-tail-logs-start-tailresponseErrors``>,
                          messages: list<``worker-tail-logs-start-tailresponseMessages``>,
                          success: bool,
                          result: workerstail): ``worker-tail-logs-start-tailresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``worker-subdomain-get-subdomainresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-subdomain-get-subdomainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-subdomain-get-subdomainresponseErrorsSource`` = { pointer = None }

type ``worker-subdomain-get-subdomainresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-subdomain-get-subdomainresponseErrorsSource``> }
    ///Creates an instance of worker-subdomain-get-subdomainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-subdomain-get-subdomainresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-subdomain-get-subdomainresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-subdomain-get-subdomainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-subdomain-get-subdomainresponseMessagesSource`` = { pointer = None }

type ``worker-subdomain-get-subdomainresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-subdomain-get-subdomainresponseMessagesSource``> }
    ///Creates an instance of worker-subdomain-get-subdomainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-subdomain-get-subdomainresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-subdomain-get-subdomainresponse`` =
    { errors: list<``worker-subdomain-get-subdomainresponseErrors``>
      messages: list<``worker-subdomain-get-subdomainresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersschemas-subdomain`` }
    ///Creates an instance of worker-subdomain-get-subdomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``worker-subdomain-get-subdomainresponseErrors``>,
                          messages: list<``worker-subdomain-get-subdomainresponseMessages``>,
                          success: bool,
                          result: ``workersschemas-subdomain``): ``worker-subdomain-get-subdomainresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``worker-subdomain-create-subdomainresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-subdomain-create-subdomainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-subdomain-create-subdomainresponseErrorsSource`` = { pointer = None }

type ``worker-subdomain-create-subdomainresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-subdomain-create-subdomainresponseErrorsSource``> }
    ///Creates an instance of worker-subdomain-create-subdomainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-subdomain-create-subdomainresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-subdomain-create-subdomainresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of worker-subdomain-create-subdomainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``worker-subdomain-create-subdomainresponseMessagesSource`` = { pointer = None }

type ``worker-subdomain-create-subdomainresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``worker-subdomain-create-subdomainresponseMessagesSource``> }
    ///Creates an instance of worker-subdomain-create-subdomainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``worker-subdomain-create-subdomainresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``worker-subdomain-create-subdomainresponse`` =
    { errors: list<``worker-subdomain-create-subdomainresponseErrors``>
      messages: list<``worker-subdomain-create-subdomainresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workersschemas-subdomain`` }
    ///Creates an instance of worker-subdomain-create-subdomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``worker-subdomain-create-subdomainresponseErrors``>,
                          messages: list<``worker-subdomain-create-subdomainresponseMessages``>,
                          success: bool,
                          result: ``workersschemas-subdomain``): ``worker-subdomain-create-subdomainresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

[<RequireQualifiedAccess>]
type WorkerScriptListWorkers =
    ///List Workers response.
    | OK of payload: ``workersscript-response-collection``
    ///List Workers response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerScriptDeleteWorker =
    ///Delete Worker response.
    | OK of payload: ``workersapi-response-null-result``
    ///Delete Worker response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerScriptDownloadWorker =
    ///Worker successfully downloaded. Returns script content as a multipart form, with no metadata part and no JSON encoding applied.
    | OK of payload: string
    ///Download Worker response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerScriptUploadWorkerModule =
    ///Upload Worker Module response.
    | OK of payload: ``worker-script-upload-worker-moduleresponse``
    ///Upload Worker Module response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

///JSON-encoded metadata about the uploaded parts and Worker configuration.
type WorkerScriptPutContentPayloadMetadata =
    { ///Name of the uploaded file that contains the Worker script (e.g. the file adding a listener to the `fetch` event). Indicates a `service worker syntax` Worker.
      body_part: Option<string>
      ///Name of the uploaded file that contains the main module (e.g. the file exporting a `fetch` handler). Indicates a `module syntax` Worker.
      main_module: Option<string> }
    ///Creates an instance of WorkerScriptPutContentPayloadMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorkerScriptPutContentPayloadMetadata = { body_part = None; main_module = None }

type WorkerScriptPutContentPayload =
    { ///An array of modules (often JavaScript files) comprising a Worker script. At least one module must be present and referenced in the metadata as `main_module` or `body_part` by filename.&amp;lt;br/&amp;gt;Possible Content-Type(s) are: `application/javascript+module`, `text/javascript+module`, `application/javascript`, `text/javascript`, `text/x-python`, `text/x-python-requirement`, `application/wasm`, `text/plain`, `application/octet-stream`, `application/source-map`.
      files: Option<list<string>>
      ///JSON-encoded metadata about the uploaded parts and Worker configuration.
      metadata: WorkerScriptPutContentPayloadMetadata }
    ///Creates an instance of WorkerScriptPutContentPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (metadata: WorkerScriptPutContentPayloadMetadata): WorkerScriptPutContentPayload =
        { files = None; metadata = metadata }

[<RequireQualifiedAccess>]
type WorkerScriptPutContent =
    ///Put script content.
    | OK of payload: ``workersscript-response-single``
    ///Put script content failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerCronTriggerGetCronTriggers =
    ///Get Cron Triggers response.
    | OK of payload: ``worker-cron-trigger-get-cron-triggersresponse``
    ///Get Cron Triggers response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

type WorkerCronTriggerUpdateCronTriggersPayloadArrayItem =
    { created_on: Option<string>
      cron: string
      modified_on: Option<string> }
    ///Creates an instance of WorkerCronTriggerUpdateCronTriggersPayloadArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cron: string): WorkerCronTriggerUpdateCronTriggersPayloadArrayItem =
        { created_on = None
          cron = cron
          modified_on = None }

type WorkerCronTriggerUpdateCronTriggersPayload = list<WorkerCronTriggerUpdateCronTriggersPayloadArrayItem>

[<RequireQualifiedAccess>]
type WorkerCronTriggerUpdateCronTriggers =
    ///Update Cron Triggers response.
    | OK of payload: ``worker-cron-trigger-update-cron-triggersresponse``
    ///Update Cron Triggers response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerListScriptSecrets =
    ///List script secrets.
    | OK of payload: ``worker-list-script-secretsresponse``
    ///List script secrets failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerPutScriptSecret =
    ///Put script secret binding success.
    | OK of payload: ``worker-put-script-secretresponse``
    ///Put script secret binding failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetAccountsWorkersScriptsTails =
    ///List Tails response.
    | OK of payload: getaccountsaccountidworkersscriptsscriptnametailsresponse
    ///List Tails response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerTailLogsStartTail =
    ///Start Tail response.
    | OK of payload: ``worker-tail-logs-start-tailresponse``
    ///Start Tail response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerScriptFetchUsageModel =
    ///Fetch Usage Model response.
    | OK of payload: ``workersusage-model-response``
    ///Fetch Usage Model response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

type WorkerScriptUpdateUsageModelPayload =
    { ///Usage model for the Worker invocations.
      usage_model: Option<workersusagemodel>
      ///User-defined resource limits for Workers with standard usage model.
      user_limits: Option<workersuserlimits> }
    ///Creates an instance of WorkerScriptUpdateUsageModelPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorkerScriptUpdateUsageModelPayload =
        { usage_model = None
          user_limits = None }

[<RequireQualifiedAccess>]
type WorkerScriptUpdateUsageModel =
    ///Update Usage Model response.
    | OK of payload: ``workersusage-model-response``
    ///Update Usage Model response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerVersionsListVersions =
    ///List Versions response.
    | OK of payload: ``workersversions-list-response``
    ///List Versions response failure.
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type WorkerVersionsUploadVersion =
    ///Upload Version response.
    | OK of payload: ``workersversions-upload-response``
    ///Upload Version response failure.
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type WorkerVersionsGetVersionDetail =
    ///Get Version Detail response.
    | OK of payload: ``workersversions-single-response``
    ///Get Version Detail response failure.
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type WorkerSubdomainDeleteSubdomain =
    ///Subdomain deleted successfully.
    | NoContent of payload: Newtonsoft.Json.Linq.JToken
    ///Delete Subdomain response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerSubdomainGetSubdomain =
    ///Get Subdomain response.
    | OK of payload: ``worker-subdomain-get-subdomainresponse``
    ///Get Subdomain response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkerSubdomainCreateSubdomain =
    ///Create Subdomain response.
    | OK of payload: ``worker-subdomain-create-subdomainresponse``
    ///Create Subdomain response failure.
    | BadRequest of payload: ``workersapi-response-common-failure``
