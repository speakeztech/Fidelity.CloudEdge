namespace rec Fidelity.CloudEdge.Management.Logs.Types

// Auto-generated stub types (missing from Hawaii output)
type logshareend = string
type logsharelogsresponsejsonlines = string
type logsharestart = string
type region = string

type logcontrolallowoutofregionaccess = bool
type logcontrolflag = bool
///Identifier.
type logcontrolidentifier = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type logcontrolmessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of logcontrolmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): logcontrolmessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type logcontrolmessages = list<logcontrolmessagesArrayItem>
///Name of the region.
type logcontrolregions = string
type logsharecount = int
///The `/received` route by default returns a limited set of fields, and allows customers to override the default field set by specifying individual fields. The reasons for this are: 1. Most customers require only a small subset of fields, but that subset varies from customer to customer; 2. Flat schema is much easier to work with downstream (importing into BigTable etc); 3. Performance (time to process, file size). If `?fields=` is not specified, default field set is returned. This default field set may change at any time. When `?fields=` is provided, each record is returned with the specified fields. `fields` must be specified as a comma separated list without any whitespaces, and all fields must exist. The order in which fields are specified does not matter, and the order of fields in the response is not specified.
type logsharefields = string
///Identifier.
type logshareidentifier = string

type logsharemessagesArrayItemSource =
    { pointer: Option<string> }
    ///Creates an instance of logsharemessagesArrayItemSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): logsharemessagesArrayItemSource = { pointer = None }

type logsharemessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<logsharemessagesArrayItemSource> }
    ///Creates an instance of logsharemessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): logsharemessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type logsharemessages = list<logsharemessagesArrayItem>
///Ray identifier.
type logsharerayidentifier = string
type logsharesample = float

///By default, timestamps in responses are returned as Unix nanosecond integers. The `?timestamps=` argument can be set to change the format in which response timestamps are returned. Possible values are: `unix`, `unixnano`, `rfc3339`. Note that `unix` and `unixnano` return timestamps as integers; `rfc3339` returns timestamps as strings.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type logsharetimestamps =
    | [<CompiledName "unix">] Unix
    | [<CompiledName "unixnano">] Unixnano
    | [<CompiledName "rfc3339">] Rfc3339
    member this.Format() =
        match this with
        | Unix -> "unix"
        | Unixnano -> "unixnano"
        | Rfc3339 -> "rfc3339"

type ErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ErrorsSource = { pointer = None }

type Errors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<ErrorsSource> }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type MessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): MessagesSource = { pointer = None }

type Messages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<MessagesSource> }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Messages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``logcontrolapi-response-common`` =
    { errors: list<Errors>
      messages: list<Messages>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of logcontrolapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>, messages: list<Messages>, success: bool): ``logcontrolapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``logcontrolapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of logcontrolapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``logcontrolapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``logcontrolapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of logcontrolapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``logcontrolapi-response-singleErrorsSource`` = { pointer = None }

type ``logcontrolapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``logcontrolapi-response-singleErrorsSource``> }
    ///Creates an instance of logcontrolapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``logcontrolapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``logcontrolapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of logcontrolapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``logcontrolapi-response-singleMessagesSource`` = { pointer = None }

type ``logcontrolapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``logcontrolapi-response-singleMessagesSource``> }
    ///Creates an instance of logcontrolapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``logcontrolapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``logcontrolapi-response-single`` =
    { errors: Option<list<``logcontrolapi-response-singleErrors``>>
      messages: Option<list<``logcontrolapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of logcontrolapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``logcontrolapi-response-single`` =
        { errors = None
          messages = None
          success = None }

type logcontrolcmbconfig =
    { ///Allow out of region access
      allow_out_of_region_access: Option<logcontrolallowoutofregionaccess>
      ///Name of the region.
      regions: Option<logcontrolregions> }
    ///Creates an instance of logcontrolcmbconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): logcontrolcmbconfig =
        { allow_out_of_region_access = None
          regions = None }

type logcontrolcmbconfigresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of logcontrolcmbconfigresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): logcontrolcmbconfigresponsesingleErrorsSource = { pointer = None }

type logcontrolcmbconfigresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<logcontrolcmbconfigresponsesingleErrorsSource> }
    ///Creates an instance of logcontrolcmbconfigresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): logcontrolcmbconfigresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type logcontrolcmbconfigresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of logcontrolcmbconfigresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): logcontrolcmbconfigresponsesingleMessagesSource = { pointer = None }

type logcontrolcmbconfigresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<logcontrolcmbconfigresponsesingleMessagesSource> }
    ///Creates an instance of logcontrolcmbconfigresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): logcontrolcmbconfigresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type logcontrolcmbconfigresponsesingle =
    { errors: list<logcontrolcmbconfigresponsesingleErrors>
      messages: list<logcontrolcmbconfigresponsesingleMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<logcontrolcmbconfig> }
    ///Creates an instance of logcontrolcmbconfigresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<logcontrolcmbconfigresponsesingleErrors>,
                          messages: list<logcontrolcmbconfigresponsesingleMessages>,
                          success: bool): logcontrolcmbconfigresponsesingle =
        { errors = errors
          messages = messages
          success = success
          result = None }

type logcontrolretentionflag =
    { ///The log retention flag for Logpull API.
      flag: Option<logcontrolflag> }
    ///Creates an instance of logcontrolretentionflag with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): logcontrolretentionflag = { flag = None }

type logcontrolretentionflagresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of logcontrolretentionflagresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): logcontrolretentionflagresponsesingleErrorsSource = { pointer = None }

type logcontrolretentionflagresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<logcontrolretentionflagresponsesingleErrorsSource> }
    ///Creates an instance of logcontrolretentionflagresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): logcontrolretentionflagresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type logcontrolretentionflagresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of logcontrolretentionflagresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): logcontrolretentionflagresponsesingleMessagesSource = { pointer = None }

type logcontrolretentionflagresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<logcontrolretentionflagresponsesingleMessagesSource> }
    ///Creates an instance of logcontrolretentionflagresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): logcontrolretentionflagresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type logcontrolretentionflagresponsesingle =
    { errors: list<logcontrolretentionflagresponsesingleErrors>
      messages: list<logcontrolretentionflagresponsesingleMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<logcontrolretentionflag> }
    ///Creates an instance of logcontrolretentionflagresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<logcontrolretentionflagresponsesingleErrors>,
                          messages: list<logcontrolretentionflagresponsesingleMessages>,
                          success: bool): logcontrolretentionflagresponsesingle =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``logshareapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of logshareapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``logshareapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type logsharefieldsresponse =
    { key: Option<string> }
    ///Creates an instance of logsharefieldsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): logsharefieldsresponse = { key = None }

type ``delete-accounts-accountid-logs-control-cmb-configresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of delete-accounts-accountid-logs-control-cmb-configresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``delete-accounts-accountid-logs-control-cmb-configresponseErrorsSource`` =
        { pointer = None }

type ``delete-accounts-accountid-logs-control-cmb-configresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``delete-accounts-accountid-logs-control-cmb-configresponseErrorsSource``> }
    ///Creates an instance of delete-accounts-accountid-logs-control-cmb-configresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``delete-accounts-accountid-logs-control-cmb-configresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``delete-accounts-accountid-logs-control-cmb-configresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of delete-accounts-accountid-logs-control-cmb-configresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``delete-accounts-accountid-logs-control-cmb-configresponseMessagesSource`` =
        { pointer = None }

type ``delete-accounts-accountid-logs-control-cmb-configresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``delete-accounts-accountid-logs-control-cmb-configresponseMessagesSource``> }
    ///Creates an instance of delete-accounts-accountid-logs-control-cmb-configresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``delete-accounts-accountid-logs-control-cmb-configresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``delete-accounts-accountid-logs-control-cmb-configresponse`` =
    { errors: list<``delete-accounts-accountid-logs-control-cmb-configresponseErrors``>
      messages: list<``delete-accounts-accountid-logs-control-cmb-configresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of delete-accounts-accountid-logs-control-cmb-configresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``delete-accounts-accountid-logs-control-cmb-configresponseErrors``>,
                          messages: list<``delete-accounts-accountid-logs-control-cmb-configresponseMessages``>,
                          success: bool): ``delete-accounts-accountid-logs-control-cmb-configresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

[<RequireQualifiedAccess>]
type DeleteAccountsAccountIdLogsControlCmbConfig =
    ///Delete CMB config response
    | OK of payload: ``delete-accounts-accountid-logs-control-cmb-configresponse``
    ///Delete CMB config response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type GetAccountsAccountIdLogsControlCmbConfig =
    ///Get CMB config response
    | OK of payload: logcontrolcmbconfigresponsesingle
    ///Get CMB config response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type PostAccountsAccountIdLogsControlCmbConfig =
    ///Update CMB config response
    | OK of payload: logcontrolcmbconfigresponsesingle
    ///Update CMB config response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type GetZonesZoneIdLogsControlRetentionFlag =
    ///Get log retention flag response
    | OK of payload: logcontrolretentionflagresponsesingle
    ///Get log retention flag response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type PostZonesZoneIdLogsControlRetentionFlag =
    ///Update log retention flag response
    | OK of payload: logcontrolretentionflagresponsesingle
    ///Update log retention flag response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type GetZonesZoneIdLogsRayidsRayId =
    ///Get logs RayIDs response
    | OK of payload: logsharelogsresponsejsonlines
    ///Get logs RayIDs response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type GetZonesZoneIdLogsReceived =
    ///Get logs received response
    | OK of payload: logsharelogsresponsejsonlines
    ///Get logs received response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type GetZonesZoneIdLogsReceivedFields =
    ///List fields response
    | OK of payload: logsharefieldsresponse
    ///List fields response failure
    | BadRequest of payload: string
