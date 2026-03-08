namespace rec Fidelity.CloudEdge.Management.LoadBalancers.Types

///The 'Host' header allows to override the hostname set in the HTTP request. Current support is 1 'Host' header override per origin.
type ``load-balancingHost`` = list<string>
///The IP address (IPv4 or IPv6) of the origin, or its publicly addressable hostname. Hostnames entered here should resolve directly to the origin, and not be a hostname proxied by Cloudflare. To set an internal/reserved address, virtual_network_id must also be set.
type ``load-balancingaddress`` = string
type ``load-balancingallowinsecure`` = bool

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``EnumForload-balancingcheckregions`` =
    | [<CompiledName "WNAM">] WNAM
    | [<CompiledName "ENAM">] ENAM
    | [<CompiledName "WEU">] WEU
    | [<CompiledName "EEU">] EEU
    | [<CompiledName "NSAM">] NSAM
    | [<CompiledName "SSAM">] SSAM
    | [<CompiledName "OC">] OC
    | [<CompiledName "ME">] ME
    | [<CompiledName "NAF">] NAF
    | [<CompiledName "SAF">] SAF
    | [<CompiledName "SAS">] SAS
    | [<CompiledName "SEAS">] SEAS
    | [<CompiledName "NEAS">] NEAS
    | [<CompiledName "ALL_REGIONS">] ALL_REGIONS
    member this.Format() =
        match this with
        | WNAM -> "WNAM"
        | ENAM -> "ENAM"
        | WEU -> "WEU"
        | EEU -> "EEU"
        | NSAM -> "NSAM"
        | SSAM -> "SSAM"
        | OC -> "OC"
        | ME -> "ME"
        | NAF -> "NAF"
        | SAF -> "SAF"
        | SAS -> "SAS"
        | SEAS -> "SEAS"
        | NEAS -> "NEAS"
        | ALL_REGIONS -> "ALL_REGIONS"

type ``load-balancingcheckregions`` = list<``EnumForload-balancingcheckregions``>
///Identifier.
type ``load-balancingcomponents-schemas-identifier`` = string
type ``load-balancingconsecutivedown`` = int
type ``load-balancingconsecutiveup`` = int
///Object description.
type ``load-balancingdescription`` = string
///This field shows up only if the origin is disabled. This field is set with the time the origin was disabled.
type ``load-balancingdisabledat`` = System.DateTimeOffset
type ``load-balancingenabled`` = bool
///A case-insensitive sub-string to look for in the response body. If this string is not found, the origin will be marked as unhealthy. This parameter is only valid for HTTP and HTTPS monitors.
type ``load-balancingexpectedbody`` = string
///The expected HTTP response code or code range of the health check. This parameter is only valid for HTTP and HTTPS monitors.
type ``load-balancingexpectedcodes`` = string
type ``load-balancingfollowredirects`` = bool
type ``load-balancingidentifier`` = string
type ``load-balancinginterval`` = int
type ``load-balancinglatitude`` = float
type ``load-balancinglongitude`` = float

type ``load-balancingmessagesArrayItem`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmessagesArrayItem`` =
        { code = code; message = message }

type ``load-balancingmessages`` = list<``load-balancingmessagesArrayItem``>
///The method to use for the health check. This defaults to 'GET' for HTTP/HTTPS based checks and 'connection_established' for TCP based health checks.
type ``load-balancingmethod`` = string
type ``load-balancingminimumorigins`` = int
///The ID of the Monitor Group to use for checking the health of origins within this pool.
type ``load-balancingmonitorgroupid`` = string
///The ID of the Monitor to use for checking the health of origins within this pool.
type ``load-balancingmonitorid`` = string
///A short name (tag) for the pool. Only alphanumeric characters, hyphens, and underscores are allowed.
type ``load-balancingname`` = string
///List of networks where Load Balancer or Pool is enabled.
type ``load-balancingnetworks`` = list<string>
///This field is now deprecated. It has been moved to Cloudflare's Centralized Notification service https://developers.cloudflare.com/fundamentals/notifications/. The email address to send health status notifications to. This can be an individual mailbox or a mailing list. Multiple emails can be supplied as a comma delimited list.
type ``load-balancingnotificationemail`` = string
type ``load-balancingoriginport`` = int
type ``load-balancingorigins`` = list<``load-balancing_origin``>
///The email address to send health status notifications to. This field is now deprecated in favor of Cloudflare Notifications for Load Balancing, so only resetting this field with an empty string `""` is accepted.
type ``load-balancingpatchpoolsnotificationemail`` = string
///The endpoint path you want to conduct a health check against. This parameter is only valid for HTTP and HTTPS monitors.
type ``load-balancingpath`` = string
type ``load-balancingport`` = int
///Assign this monitor to emulate the specified zone while probing. This parameter is only valid for HTTP and HTTPS monitors.
type ``load-balancingprobezone`` = string

///A list of Cloudflare regions. WNAM: Western North America, ENAM: Eastern North America, WEU: Western Europe, EEU: Eastern Europe, NSAM: Northern South America, SSAM: Southern South America, OC: Oceania, ME: Middle East, NAF: North Africa, SAF: South Africa, SAS: Southern Asia, SEAS: South East Asia, NEAS: North East Asia).
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``load-balancingregioncode`` =
    | [<CompiledName "WNAM">] WNAM
    | [<CompiledName "ENAM">] ENAM
    | [<CompiledName "WEU">] WEU
    | [<CompiledName "EEU">] EEU
    | [<CompiledName "NSAM">] NSAM
    | [<CompiledName "SSAM">] SSAM
    | [<CompiledName "OC">] OC
    | [<CompiledName "ME">] ME
    | [<CompiledName "NAF">] NAF
    | [<CompiledName "SAF">] SAF
    | [<CompiledName "SAS">] SAS
    | [<CompiledName "SEAS">] SEAS
    | [<CompiledName "NEAS">] NEAS
    member this.Format() =
        match this with
        | WNAM -> "WNAM"
        | ENAM -> "ENAM"
        | WEU -> "WEU"
        | EEU -> "EEU"
        | NSAM -> "NSAM"
        | SSAM -> "SSAM"
        | OC -> "OC"
        | ME -> "ME"
        | NAF -> "NAF"
        | SAF -> "SAF"
        | SAS -> "SAS"
        | SEAS -> "SEAS"
        | NEAS -> "NEAS"

type ``load-balancingretries`` = int
///A human-readable description of the pool.
type ``load-balancingschemas-description`` = string
///This field shows up only if the pool is disabled. This field is set with the time the pool was disabled at.
type ``load-balancingschemas-disabledat`` = System.DateTimeOffset
type ``load-balancingschemas-enabled`` = bool
type ``load-balancingschemas-identifier`` = string
///A human-identifiable name for the origin.
type ``load-balancingschemas-name`` = string
type ``load-balancingschemas-previewid`` = string
///Two-letter subdivision code followed in ISO 3166-2.
type ``load-balancingsubdivisioncodea2`` = string
type ``load-balancingtimeout`` = int
type ``load-balancingtimestamp`` = System.DateTimeOffset

///The protocol to use for the health check. Currently supported protocols are 'HTTP','HTTPS', 'TCP', 'ICMP-PING', 'UDP-ICMP', and 'SMTP'.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``load-balancingtype`` =
    | [<CompiledName "http">] Http
    | [<CompiledName "https">] Https
    | [<CompiledName "tcp">] Tcp
    | [<CompiledName "udp_icmp">] Udp_icmp
    | [<CompiledName "icmp_ping">] Icmp_ping
    | [<CompiledName "smtp">] Smtp
    member this.Format() =
        match this with
        | Http -> "http"
        | Https -> "https"
        | Tcp -> "tcp"
        | Udp_icmp -> "udp_icmp"
        | Icmp_ping -> "icmp_ping"
        | Smtp -> "smtp"

///The virtual network subnet ID the origin belongs in. Virtual network must also belong to the account.
type ``load-balancingvirtualnetworkid`` = string
type ``load-balancingweight`` = float

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

type ``load-balancingapi-paginated-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: ``load-balancingresultinfo`` }
    ///Creates an instance of load-balancingapi-paginated-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (result_info: ``load-balancingresultinfo``): ``load-balancingapi-paginated-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = result_info }

type ``load-balancingapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingapi-response-commonErrors`` =
        { code = code; message = message }

type ``load-balancingapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingapi-response-commonMessages`` =
        { code = code; message = message }

type ``load-balancingapi-response-common`` =
    { errors: list<``load-balancingapi-response-commonErrors``>
      messages: list<``load-balancingapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of load-balancingapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``load-balancingapi-response-commonErrors``>,
                          messages: list<``load-balancingapi-response-commonMessages``>,
                          success: bool): ``load-balancingapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``load-balancingapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of load-balancingapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``load-balancingapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``load-balancingapi-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingapi-response-singleErrors`` =
        { code = code; message = message }

type ``load-balancingapi-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingapi-response-singleMessages`` =
        { code = code; message = message }

type ``load-balancingapi-response-single`` =
    { errors: Option<list<``load-balancingapi-response-singleErrors``>>
      messages: Option<list<``load-balancingapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancingapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingapi-response-single`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingcomponents-schemas-singleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingcomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingcomponents-schemas-singleresponseErrors`` =
        { code = code; message = message }

type ``load-balancingcomponents-schemas-singleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingcomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingcomponents-schemas-singleresponseMessages`` =
        { code = code; message = message }

type ``load-balancingcomponents-schemas-singleresponse`` =
    { errors: Option<list<``load-balancingcomponents-schemas-singleresponseErrors``>>
      messages: Option<list<``load-balancingcomponents-schemas-singleresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancingcomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingcomponents-schemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

///Filter options for a particular resource type (pool or origin). Use null to reset.
type ``load-balancingfilteroptions`` =
    { ///If set true, disable notifications for this type of resource (pool or origin).
      disable: Option<bool>
      ///If present, send notifications only for this health status (e.g. false for only DOWN events). Use null to reset (all events).
      healthy: Option<bool> }
    ///Creates an instance of load-balancingfilteroptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingfilteroptions`` = { disable = None; healthy = None }

type ``load-balancinghealthdetailsErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancinghealthdetailsErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancinghealthdetailsErrors`` =
        { code = code; message = message }

type ``load-balancinghealthdetailsMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancinghealthdetailsMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancinghealthdetailsMessages`` =
        { code = code; message = message }

///List of regions and associated health status.
type Pophealth =
    { ///Whether health check in region is healthy.
      healthy: Option<bool>
      origins: Option<list<``load-balancingorigin-health``>> }
    ///Creates an instance of Pophealth with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Pophealth = { healthy = None; origins = None }

///A list of regions from which to run health checks. Null means every Cloudflare data center.
type Result =
    { ///Pool ID.
      pool_id: Option<string>
      ///List of regions and associated health status.
      pop_health: Option<Pophealth> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result = { pool_id = None; pop_health = None }

type ``load-balancinghealthdetails`` =
    { errors: Option<list<``load-balancinghealthdetailsErrors``>>
      messages: Option<list<``load-balancinghealthdetailsMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancinghealthdetails with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancinghealthdetails`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingidresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingidresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingidresponseErrors`` =
        { code = code; message = message }

type ``load-balancingidresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingidresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingidresponseMessages`` =
        { code = code; message = message }

type ``load-balancingidresponseResult`` =
    { id: Option<``load-balancingidentifier``> }
    ///Creates an instance of load-balancingidresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingidresponseResult`` = { id = None }

type ``load-balancingidresponse`` =
    { errors: Option<list<``load-balancingidresponseErrors``>>
      messages: Option<list<``load-balancingidresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancingidresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingidresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Defaultpolicy =
    | [<CompiledName "random">] Random
    | [<CompiledName "hash">] Hash
    member this.Format() =
        match this with
        | Random -> "random"
        | Hash -> "hash"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Sessionpolicy =
    | [<CompiledName "hash">] Hash
    member this.Format() =
        match this with
        | Hash -> "hash"

///Configures load shedding policies and percentages for the pool.
type ``load-balancingloadshedding`` =
    { ///The percent of traffic to shed from the pool, according to the default policy. Applies to new sessions and traffic without session affinity.
      default_percent: Option<float>
      ///The default policy to use when load shedding. A random policy randomly sheds a given percent of requests. A hash policy computes a hash over the CF-Connecting-IP address and sheds all requests originating from a percent of IPs.
      default_policy: Option<Defaultpolicy>
      ///The percent of existing sessions to shed from the pool, according to the session policy.
      session_percent: Option<float>
      ///Only the hash policy is supported for existing sessions (to avoid exponential decay).
      session_policy: Option<Sessionpolicy> }
    ///Creates an instance of load-balancingloadshedding with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingloadshedding`` =
        { default_percent = None
          default_policy = None
          session_percent = None
          session_policy = None }

type ``load-balancingmonitor`` =
    { ///Do not validate the certificate when monitor use HTTPS. This parameter is currently only valid for HTTP and HTTPS monitors.
      allow_insecure: Option<``load-balancingallowinsecure``>
      ///To be marked unhealthy the monitored origin must fail this healthcheck N consecutive times.
      consecutive_down: Option<``load-balancingconsecutivedown``>
      ///To be marked healthy the monitored origin must pass this healthcheck N consecutive times.
      consecutive_up: Option<``load-balancingconsecutiveup``>
      ///Object description.
      description: Option<``load-balancingdescription``>
      ///A case-insensitive sub-string to look for in the response body. If this string is not found, the origin will be marked as unhealthy. This parameter is only valid for HTTP and HTTPS monitors.
      expected_body: Option<``load-balancingexpectedbody``>
      ///The expected HTTP response code or code range of the health check. This parameter is only valid for HTTP and HTTPS monitors.
      expected_codes: Option<``load-balancingexpectedcodes``>
      ///Follow redirects if returned by the origin. This parameter is only valid for HTTP and HTTPS monitors.
      follow_redirects: Option<``load-balancingfollowredirects``>
      ///The HTTP request headers to send in the health check. It is recommended you set a Host header by default. The User-Agent header cannot be overridden. This parameter is only valid for HTTP and HTTPS monitors.
      header: Option<Map<string, list<string>>>
      ///The interval between each health check. Shorter intervals may improve failover time, but will increase load on the origins as we check from multiple locations.
      interval: Option<``load-balancinginterval``>
      ///The method to use for the health check. This defaults to 'GET' for HTTP/HTTPS based checks and 'connection_established' for TCP based health checks.
      method: Option<``load-balancingmethod``>
      ///The endpoint path you want to conduct a health check against. This parameter is only valid for HTTP and HTTPS monitors.
      path: Option<``load-balancingpath``>
      ///The port number to connect to for the health check. Required for TCP, UDP, and SMTP checks. HTTP and HTTPS checks should only define the port when using a non-standard port (HTTP: default 80, HTTPS: default 443).
      port: Option<``load-balancingport``>
      ///Assign this monitor to emulate the specified zone while probing. This parameter is only valid for HTTP and HTTPS monitors.
      probe_zone: Option<``load-balancingprobezone``>
      ///The number of retries to attempt in case of a timeout before marking the origin as unhealthy. Retries are attempted immediately.
      retries: Option<``load-balancingretries``>
      ///The timeout (in seconds) before marking the health check as failed.
      timeout: Option<``load-balancingtimeout``>
      ///The protocol to use for the health check. Currently supported protocols are 'HTTP','HTTPS', 'TCP', 'ICMP-PING', 'UDP-ICMP', and 'SMTP'.
      ``type``: Option<``load-balancingtype``>
      created_on: Option<``load-balancingtimestamp``>
      id: Option<``load-balancingidentifier``>
      modified_on: Option<``load-balancingtimestamp``> }
    ///Creates an instance of load-balancingmonitor with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor`` =
        { allow_insecure = None
          consecutive_down = None
          consecutive_up = None
          description = None
          expected_body = None
          expected_codes = None
          follow_redirects = None
          header = None
          interval = None
          method = None
          path = None
          port = None
          probe_zone = None
          retries = None
          timeout = None
          ``type`` = None
          created_on = None
          id = None
          modified_on = None }

type ``load-balancingmonitor-editable`` =
    { ///Do not validate the certificate when monitor use HTTPS. This parameter is currently only valid for HTTP and HTTPS monitors.
      allow_insecure: Option<``load-balancingallowinsecure``>
      ///To be marked unhealthy the monitored origin must fail this healthcheck N consecutive times.
      consecutive_down: Option<``load-balancingconsecutivedown``>
      ///To be marked healthy the monitored origin must pass this healthcheck N consecutive times.
      consecutive_up: Option<``load-balancingconsecutiveup``>
      ///Object description.
      description: Option<``load-balancingdescription``>
      ///A case-insensitive sub-string to look for in the response body. If this string is not found, the origin will be marked as unhealthy. This parameter is only valid for HTTP and HTTPS monitors.
      expected_body: Option<``load-balancingexpectedbody``>
      ///The expected HTTP response code or code range of the health check. This parameter is only valid for HTTP and HTTPS monitors.
      expected_codes: Option<``load-balancingexpectedcodes``>
      ///Follow redirects if returned by the origin. This parameter is only valid for HTTP and HTTPS monitors.
      follow_redirects: Option<``load-balancingfollowredirects``>
      ///The HTTP request headers to send in the health check. It is recommended you set a Host header by default. The User-Agent header cannot be overridden. This parameter is only valid for HTTP and HTTPS monitors.
      header: Option<Map<string, list<string>>>
      ///The interval between each health check. Shorter intervals may improve failover time, but will increase load on the origins as we check from multiple locations.
      interval: Option<``load-balancinginterval``>
      ///The method to use for the health check. This defaults to 'GET' for HTTP/HTTPS based checks and 'connection_established' for TCP based health checks.
      method: Option<``load-balancingmethod``>
      ///The endpoint path you want to conduct a health check against. This parameter is only valid for HTTP and HTTPS monitors.
      path: Option<``load-balancingpath``>
      ///The port number to connect to for the health check. Required for TCP, UDP, and SMTP checks. HTTP and HTTPS checks should only define the port when using a non-standard port (HTTP: default 80, HTTPS: default 443).
      port: Option<``load-balancingport``>
      ///Assign this monitor to emulate the specified zone while probing. This parameter is only valid for HTTP and HTTPS monitors.
      probe_zone: Option<``load-balancingprobezone``>
      ///The number of retries to attempt in case of a timeout before marking the origin as unhealthy. Retries are attempted immediately.
      retries: Option<``load-balancingretries``>
      ///The timeout (in seconds) before marking the health check as failed.
      timeout: Option<``load-balancingtimeout``>
      ///The protocol to use for the health check. Currently supported protocols are 'HTTP','HTTPS', 'TCP', 'ICMP-PING', 'UDP-ICMP', and 'SMTP'.
      ``type``: Option<``load-balancingtype``> }
    ///Creates an instance of load-balancingmonitor-editable with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor-editable`` =
        { allow_insecure = None
          consecutive_down = None
          consecutive_up = None
          description = None
          expected_body = None
          expected_codes = None
          follow_redirects = None
          header = None
          interval = None
          method = None
          path = None
          port = None
          probe_zone = None
          retries = None
          timeout = None
          ``type`` = None }

type ``load-balancingmonitor-group`` =
    { ///The timestamp of when the monitor group was created
      created_at: Option<System.DateTimeOffset>
      ///A short description of the monitor group
      description: string
      ///The ID of the Monitor Group to use for checking the health of origins within this pool.
      id: ``load-balancingmonitorgroupid``
      ///List of monitors in this group
      members: list<``load-balancingmonitor-group-member``>
      ///The timestamp of when the monitor group was last updated
      updated_at: Option<System.DateTimeOffset> }
    ///Creates an instance of load-balancingmonitor-group with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (description: string,
                          id: ``load-balancingmonitorgroupid``,
                          members: list<``load-balancingmonitor-group-member``>): ``load-balancingmonitor-group`` =
        { created_at = None
          description = description
          id = id
          members = members
          updated_at = None }

type ``load-balancingmonitor-group-member`` =
    { ///The timestamp of when the monitor was added to the group
      created_at: Option<System.DateTimeOffset>
      ///Whether this monitor is enabled in the group
      enabled: bool
      ///The ID of the Monitor to use for checking the health of origins within this pool.
      monitor_id: ``load-balancingmonitorid``
      ///Whether this monitor is used for monitoring only (does not affect pool health)
      monitoring_only: bool
      ///Whether this monitor must be healthy for the pool to be considered healthy
      must_be_healthy: bool
      ///The timestamp of when the monitor group member was last updated
      updated_at: Option<System.DateTimeOffset> }
    ///Creates an instance of load-balancingmonitor-group-member with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool,
                          monitor_id: ``load-balancingmonitorid``,
                          monitoring_only: bool,
                          must_be_healthy: bool): ``load-balancingmonitor-group-member`` =
        { created_at = None
          enabled = enabled
          monitor_id = monitor_id
          monitoring_only = monitoring_only
          must_be_healthy = must_be_healthy
          updated_at = None }

type ``load-balancingmonitor-group-references-responseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-group-references-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-group-references-responseErrors`` =
        { code = code; message = message }

type ``load-balancingmonitor-group-references-responseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-group-references-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-group-references-responseMessages`` =
        { code = code; message = message }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Referencetype =
    | [<CompiledName "*">] Star
    | [<CompiledName "referral">] Referral
    | [<CompiledName "referrer">] Referrer
    member this.Format() =
        match this with
        | Star -> "*"
        | Referral -> "referral"
        | Referrer -> "referrer"

type ``load-balancingmonitor-group-references-responseResult`` =
    { reference_type: Option<Referencetype>
      resource_id: Option<string>
      resource_name: Option<string>
      resource_type: Option<string> }
    ///Creates an instance of load-balancingmonitor-group-references-responseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor-group-references-responseResult`` =
        { reference_type = None
          resource_id = None
          resource_name = None
          resource_type = None }

type ``load-balancingmonitor-group-references-response`` =
    { errors: Option<list<``load-balancingmonitor-group-references-responseErrors``>>
      messages: Option<list<``load-balancingmonitor-group-references-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      ///List of resources that reference a given monitor group.
      result: Option<list<``load-balancingmonitor-group-references-responseResult``>> }
    ///Creates an instance of load-balancingmonitor-group-references-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor-group-references-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingmonitor-group-response-collectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-group-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-group-response-collectionErrors`` =
        { code = code; message = message }

type ``load-balancingmonitor-group-response-collectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-group-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-group-response-collectionMessages`` =
        { code = code; message = message }

type ``load-balancingmonitor-group-response-collection`` =
    { errors: Option<list<``load-balancingmonitor-group-response-collectionErrors``>>
      messages: Option<list<``load-balancingmonitor-group-response-collectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<``load-balancingmonitor-group``>>
      result_info: Option<``load-balancingresultinfo``> }
    ///Creates an instance of load-balancingmonitor-group-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor-group-response-collection`` =
        { errors = None
          messages = None
          success = None
          result = None
          result_info = None }

type ``load-balancingmonitor-group-single-responseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-group-single-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-group-single-responseErrors`` =
        { code = code; message = message }

type ``load-balancingmonitor-group-single-responseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-group-single-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-group-single-responseMessages`` =
        { code = code; message = message }

type ``load-balancingmonitor-group-single-response`` =
    { errors: Option<list<``load-balancingmonitor-group-single-responseErrors``>>
      messages: Option<list<``load-balancingmonitor-group-single-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<``load-balancingmonitor-group``> }
    ///Creates an instance of load-balancingmonitor-group-single-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor-group-single-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingmonitor-references-responseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-references-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-references-responseErrors`` =
        { code = code; message = message }

type ``load-balancingmonitor-references-responseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-references-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-references-responseMessages`` =
        { code = code; message = message }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``load-balancingmonitor-references-responseResultReferencetype`` =
    | [<CompiledName "*">] Star
    | [<CompiledName "referral">] Referral
    | [<CompiledName "referrer">] Referrer
    member this.Format() =
        match this with
        | Star -> "*"
        | Referral -> "referral"
        | Referrer -> "referrer"

type ``load-balancingmonitor-references-responseResult`` =
    { reference_type: Option<``load-balancingmonitor-references-responseResultReferencetype``>
      resource_id: Option<string>
      resource_name: Option<string>
      resource_type: Option<string> }
    ///Creates an instance of load-balancingmonitor-references-responseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor-references-responseResult`` =
        { reference_type = None
          resource_id = None
          resource_name = None
          resource_type = None }

type ``load-balancingmonitor-references-response`` =
    { errors: Option<list<``load-balancingmonitor-references-responseErrors``>>
      messages: Option<list<``load-balancingmonitor-references-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      ///List of resources that reference a given monitor.
      result: Option<list<``load-balancingmonitor-references-responseResult``>> }
    ///Creates an instance of load-balancingmonitor-references-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor-references-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingmonitor-response-collectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-response-collectionErrors`` =
        { code = code; message = message }

type ``load-balancingmonitor-response-collectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-response-collectionMessages`` =
        { code = code; message = message }

type ``load-balancingmonitor-response-collection`` =
    { errors: Option<list<``load-balancingmonitor-response-collectionErrors``>>
      messages: Option<list<``load-balancingmonitor-response-collectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``load-balancingresultinfo``>
      result: Option<list<``load-balancingmonitor``>> }
    ///Creates an instance of load-balancingmonitor-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``load-balancingmonitor-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-response-singleErrors`` =
        { code = code; message = message }

type ``load-balancingmonitor-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingmonitor-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingmonitor-response-singleMessages`` =
        { code = code; message = message }

type ``load-balancingmonitor-response-single`` =
    { errors: Option<list<``load-balancingmonitor-response-singleErrors``>>
      messages: Option<list<``load-balancingmonitor-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancingmonitor-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingmonitor-response-single`` =
        { errors = None
          messages = None
          success = None
          result = None }

///Filter pool and origin health notifications by resource type or health status. Use null to reset.
type ``load-balancingnotificationfilter`` =
    { ///Filter options for a particular resource type (pool or origin). Use null to reset.
      origin: Option<``load-balancingfilteroptions``>
      ///Filter options for a particular resource type (pool or origin). Use null to reset.
      pool: Option<``load-balancingfilteroptions``> }
    ///Creates an instance of load-balancingnotificationfilter with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingnotificationfilter`` = { origin = None; pool = None }

type ``load-balancingorigin`` =
    { ///The IP address (IPv4 or IPv6) of the origin, or its publicly addressable hostname. Hostnames entered here should resolve directly to the origin, and not be a hostname proxied by Cloudflare. To set an internal/reserved address, virtual_network_id must also be set.
      address: Option<``load-balancingaddress``>
      ///This field shows up only if the origin is disabled. This field is set with the time the origin was disabled.
      disabled_at: Option<``load-balancingdisabledat``>
      ///Whether to enable (the default) this origin within the pool. Disabled origins will not receive traffic and are excluded from health checks. The origin will only be disabled for the current pool.
      enabled: Option<``load-balancingschemas-enabled``>
      ///The request header is used to pass additional information with an HTTP request. Currently supported header is 'Host'.
      header: Option<``load-balancingschemas-header``>
      ///A human-identifiable name for the origin.
      name: Option<``load-balancingschemas-name``>
      ///The port for upstream connections. A value of 0 means the default port for the protocol will be used.
      port: Option<``load-balancingoriginport``>
      ///The virtual network subnet ID the origin belongs in. Virtual network must also belong to the account.
      virtual_network_id: Option<``load-balancingvirtualnetworkid``>
      ///The weight of this origin relative to other origins in the pool. Based on the configured weight the total traffic is distributed among origins within the pool.
      ///- `origin_steering.policy="least_outstanding_requests"`: Use weight to scale the origin's outstanding requests.
      ///- `origin_steering.policy="least_connections"`: Use weight to scale the origin's open connections.
      weight: Option<``load-balancingweight``> }
    ///Creates an instance of load-balancingorigin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingorigin`` =
        { address = None
          disabled_at = None
          enabled = None
          header = None
          name = None
          port = None
          virtual_network_id = None
          weight = None }

type Ip =
    { ///Failure reason.
      failure_reason: Option<string>
      ///Origin health status.
      healthy: Option<bool>
      ///Response code from origin health check.
      response_code: Option<float>
      ///Origin RTT (Round Trip Time) response.
      rtt: Option<string> }
    ///Creates an instance of Ip with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Ip =
        { failure_reason = None
          healthy = None
          response_code = None
          rtt = None }

type ``load-balancingorigin-health`` =
    { ip: Option<Ip> }
    ///Creates an instance of load-balancingorigin-health with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingorigin-health`` = { ip = None }

///The origin ipv4/ipv6 address or domain name mapped to its health data.
type ``load-balancingoriginhealthdata`` =
    { failure_reason: Option<string>
      healthy: Option<bool>
      response_code: Option<float>
      rtt: Option<string> }
    ///Creates an instance of load-balancingoriginhealthdata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingoriginhealthdata`` =
        { failure_reason = None
          healthy = None
          response_code = None
          rtt = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Policy =
    | [<CompiledName "random">] Random
    | [<CompiledName "hash">] Hash
    | [<CompiledName "least_outstanding_requests">] Least_outstanding_requests
    | [<CompiledName "least_connections">] Least_connections
    member this.Format() =
        match this with
        | Random -> "random"
        | Hash -> "hash"
        | Least_outstanding_requests -> "least_outstanding_requests"
        | Least_connections -> "least_connections"

///Configures origin steering for the pool. Controls how origins are selected for new sessions and traffic without session affinity.
type ``load-balancingoriginsteering`` =
    { ///The type of origin steering policy to use.
      ///- `"random"`: Select an origin randomly.
      ///- `"hash"`: Select an origin by computing a hash over the CF-Connecting-IP address.
      ///- `"least_outstanding_requests"`: Select an origin by taking into consideration origin weights, as well as each origin's number of outstanding requests. Origins with more pending requests are weighted proportionately less relative to others.
      ///- `"least_connections"`: Select an origin by taking into consideration origin weights, as well as each origin's number of open connections. Origins with more open connections are weighted proportionately less relative to others. Supported for HTTP/1 and HTTP/2 connections.
      policy: Option<Policy> }
    ///Creates an instance of load-balancingoriginsteering with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingoriginsteering`` = { policy = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Check_regions =
    | [<CompiledName "WNAM">] WNAM
    | [<CompiledName "ENAM">] ENAM
    | [<CompiledName "WEU">] WEU
    | [<CompiledName "EEU">] EEU
    | [<CompiledName "NSAM">] NSAM
    | [<CompiledName "SSAM">] SSAM
    | [<CompiledName "OC">] OC
    | [<CompiledName "ME">] ME
    | [<CompiledName "NAF">] NAF
    | [<CompiledName "SAF">] SAF
    | [<CompiledName "SAS">] SAS
    | [<CompiledName "SEAS">] SEAS
    | [<CompiledName "NEAS">] NEAS
    | [<CompiledName "ALL_REGIONS">] ALL_REGIONS
    member this.Format() =
        match this with
        | WNAM -> "WNAM"
        | ENAM -> "ENAM"
        | WEU -> "WEU"
        | EEU -> "EEU"
        | NSAM -> "NSAM"
        | SSAM -> "SSAM"
        | OC -> "OC"
        | ME -> "ME"
        | NAF -> "NAF"
        | SAF -> "SAF"
        | SAS -> "SAS"
        | SEAS -> "SEAS"
        | NEAS -> "NEAS"
        | ALL_REGIONS -> "ALL_REGIONS"

type ``load-balancingpool`` =
    { ///A list of regions from which to run health checks. Null means every Cloudflare data center.
      check_regions: Option<list<Check_regions>>
      created_on: Option<``load-balancingtimestamp``>
      ///A human-readable description of the pool.
      description: Option<``load-balancingschemas-description``>
      ///This field shows up only if the pool is disabled. This field is set with the time the pool was disabled at.
      disabled_at: Option<``load-balancingschemas-disabledat``>
      ///Whether to enable (the default) or disable this pool. Disabled pools will not receive traffic and are excluded from health checks. Disabling a pool will cause any load balancers using it to failover to the next pool (if any).
      enabled: Option<``load-balancingenabled``>
      id: Option<``load-balancingschemas-identifier``>
      ///The latitude of the data center containing the origins used in this pool in decimal degrees. If this is set, longitude must also be set.
      latitude: Option<``load-balancinglatitude``>
      ///Configures load shedding policies and percentages for the pool.
      load_shedding: Option<``load-balancingloadshedding``>
      ///The longitude of the data center containing the origins used in this pool in decimal degrees. If this is set, latitude must also be set.
      longitude: Option<``load-balancinglongitude``>
      ///The minimum number of origins that must be healthy for this pool to serve traffic. If the number of healthy origins falls below this number, the pool will be marked unhealthy and will failover to the next available pool.
      minimum_origins: Option<``load-balancingminimumorigins``>
      modified_on: Option<``load-balancingtimestamp``>
      ///The ID of the Monitor to use for checking the health of origins within this pool.
      monitor: Option<``load-balancingmonitorid``>
      ///The ID of the Monitor Group to use for checking the health of origins within this pool.
      monitor_group: Option<``load-balancingmonitorgroupid``>
      ///A short name (tag) for the pool. Only alphanumeric characters, hyphens, and underscores are allowed.
      name: Option<``load-balancingname``>
      ///List of networks where Load Balancer or Pool is enabled.
      networks: Option<``load-balancingnetworks``>
      ///This field is now deprecated. It has been moved to Cloudflare's Centralized Notification service https://developers.cloudflare.com/fundamentals/notifications/. The email address to send health status notifications to. This can be an individual mailbox or a mailing list. Multiple emails can be supplied as a comma delimited list.
      notification_email: Option<``load-balancingnotificationemail``>
      ///Filter pool and origin health notifications by resource type or health status. Use null to reset.
      notification_filter: Option<``load-balancingnotificationfilter``>
      ///Configures origin steering for the pool. Controls how origins are selected for new sessions and traffic without session affinity.
      origin_steering: Option<``load-balancingoriginsteering``>
      ///The list of origins within this pool. Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy.
      origins: Option<``load-balancingorigins``> }
    ///Creates an instance of load-balancingpool with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingpool`` =
        { check_regions = None
          created_on = None
          description = None
          disabled_at = None
          enabled = None
          id = None
          latitude = None
          load_shedding = None
          longitude = None
          minimum_origins = None
          modified_on = None
          monitor = None
          monitor_group = None
          name = None
          networks = None
          notification_email = None
          notification_filter = None
          origin_steering = None
          origins = None }

type ``load-balancingpools-references-responseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingpools-references-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingpools-references-responseErrors`` =
        { code = code; message = message }

type ``load-balancingpools-references-responseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingpools-references-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingpools-references-responseMessages`` =
        { code = code; message = message }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``load-balancingpools-references-responseResultReferencetype`` =
    | [<CompiledName "*">] Star
    | [<CompiledName "referral">] Referral
    | [<CompiledName "referrer">] Referrer
    member this.Format() =
        match this with
        | Star -> "*"
        | Referral -> "referral"
        | Referrer -> "referrer"

type ``load-balancingpools-references-responseResult`` =
    { reference_type: Option<``load-balancingpools-references-responseResultReferencetype``>
      resource_id: Option<string>
      resource_name: Option<string>
      resource_type: Option<string> }
    ///Creates an instance of load-balancingpools-references-responseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingpools-references-responseResult`` =
        { reference_type = None
          resource_id = None
          resource_name = None
          resource_type = None }

type ``load-balancingpools-references-response`` =
    { errors: Option<list<``load-balancingpools-references-responseErrors``>>
      messages: Option<list<``load-balancingpools-references-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      ///List of resources that reference a given pool.
      result: Option<list<``load-balancingpools-references-responseResult``>> }
    ///Creates an instance of load-balancingpools-references-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingpools-references-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingpreviewresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingpreviewresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingpreviewresponseErrors`` =
        { code = code; message = message }

type ``load-balancingpreviewresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingpreviewresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingpreviewresponseMessages`` =
        { code = code; message = message }

type ``load-balancingpreviewresponseResult`` =
    { ///Monitored pool IDs mapped to their respective names.
      pools: Option<Map<string, string>>
      preview_id: Option<``load-balancingidentifier``> }
    ///Creates an instance of load-balancingpreviewresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingpreviewresponseResult`` = { pools = None; preview_id = None }

type ``load-balancingpreviewresponse`` =
    { errors: Option<list<``load-balancingpreviewresponseErrors``>>
      messages: Option<list<``load-balancingpreviewresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancingpreviewresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingpreviewresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingpreviewresultresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingpreviewresultresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingpreviewresultresponseErrors`` =
        { code = code; message = message }

type ``load-balancingpreviewresultresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingpreviewresultresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingpreviewresultresponseMessages`` =
        { code = code; message = message }

type ``load-balancingpreviewresultresponse`` =
    { errors: Option<list<``load-balancingpreviewresultresponseErrors``>>
      messages: Option<list<``load-balancingpreviewresultresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancingpreviewresultresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingpreviewresultresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingregioncomponents-schemas-responsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingregioncomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingregioncomponents-schemas-responsecollectionErrors`` =
        { code = code; message = message }

type ``load-balancingregioncomponents-schemas-responsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingregioncomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingregioncomponents-schemas-responsecollectionMessages`` =
        { code = code; message = message }

type ``load-balancingregioncomponents-schemas-responsecollection`` =
    { errors: Option<list<``load-balancingregioncomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``load-balancingregioncomponents-schemas-responsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancingregioncomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingregioncomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``load-balancingresourcereferenceReferencetype`` =
    | [<CompiledName "referral">] Referral
    | [<CompiledName "referrer">] Referrer
    member this.Format() =
        match this with
        | Referral -> "referral"
        | Referrer -> "referrer"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Resourcetype =
    | [<CompiledName "load_balancer">] Load_balancer
    | [<CompiledName "monitor">] Monitor
    | [<CompiledName "pool">] Pool
    member this.Format() =
        match this with
        | Load_balancer -> "load_balancer"
        | Monitor -> "monitor"
        | Pool -> "pool"

///A reference to a load balancer resource.
type ``load-balancingresourcereference`` =
    { ///When listed as a reference, the type (direction) of the reference.
      reference_type: Option<``load-balancingresourcereferenceReferencetype``>
      ///A list of references to (referrer) or from (referral) this resource.
      references: Option<Newtonsoft.Json.Linq.JArray>
      resource_id: Option<string>
      ///The human-identifiable name of the resource.
      resource_name: Option<string>
      ///The type of the resource.
      resource_type: Option<Resourcetype> }
    ///Creates an instance of load-balancingresourcereference with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingresourcereference`` =
        { reference_type = None
          references = None
          resource_id = None
          resource_name = None
          resource_type = None }

type ``load-balancingresultinfo`` =
    { ///Total number of results on the current page.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///Total number of pages available.
      total_pages: Option<float> }
    ///Creates an instance of load-balancingresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingresultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

///The request header is used to pass additional information with an HTTP request. Currently supported header is 'Host'.
type ``load-balancingschemas-header`` =
    { ///The 'Host' header allows to override the hostname set in the HTTP request. Current support is 1 'Host' header override per origin.
      Host: Option<``load-balancingHost``> }
    ///Creates an instance of load-balancingschemas-header with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingschemas-header`` = { Host = None }

type ``load-balancingschemas-idresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingschemas-idresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingschemas-idresponseErrors`` =
        { code = code; message = message }

type ``load-balancingschemas-idresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingschemas-idresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingschemas-idresponseMessages`` =
        { code = code; message = message }

type ``load-balancingschemas-idresponseResult`` =
    { id: Option<``load-balancingschemas-identifier``> }
    ///Creates an instance of load-balancingschemas-idresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingschemas-idresponseResult`` = { id = None }

type ``load-balancingschemas-idresponse`` =
    { errors: Option<list<``load-balancingschemas-idresponseErrors``>>
      messages: Option<list<``load-balancingschemas-idresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancingschemas-idresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingschemas-idresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingschemas-responsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingschemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingschemas-responsecollectionErrors`` =
        { code = code; message = message }

type ``load-balancingschemas-responsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingschemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingschemas-responsecollectionMessages`` =
        { code = code; message = message }

type ``load-balancingschemas-responsecollection`` =
    { errors: Option<list<``load-balancingschemas-responsecollectionErrors``>>
      messages: Option<list<``load-balancingschemas-responsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``load-balancingresultinfo``>
      result: Option<list<``load-balancingpool``>> }
    ///Creates an instance of load-balancingschemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingschemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``load-balancingschemas-singleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingschemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingschemas-singleresponseErrors`` =
        { code = code; message = message }

type ``load-balancingschemas-singleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of load-balancingschemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``load-balancingschemas-singleresponseMessages`` =
        { code = code; message = message }

type ``load-balancingschemas-singleresponse`` =
    { errors: Option<list<``load-balancingschemas-singleresponseErrors``>>
      messages: Option<list<``load-balancingschemas-singleresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of load-balancingschemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingschemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``load-balancingsearch`` =
    { ///A list of resources matching the search query.
      resources: Option<list<``load-balancingresourcereference``>> }
    ///Creates an instance of load-balancingsearch with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingsearch`` = { resources = None }

type ``load-balancingsearchresult`` =
    { result: Option<``load-balancingsearch``> }
    ///Creates an instance of load-balancingsearchresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``load-balancingsearchresult`` = { result = None }

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorGroupsListMonitorGroups =
    ///List Monitor Groups response
    | OK of payload: ``load-balancingmonitor-group-response-collection``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorGroupsCreateMonitorGroup =
    ///Create Monitor Group response
    | OK of payload: ``load-balancingmonitor-group-single-response``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorGroupsDeleteMonitorGroup =
    ///Delete Monitor Group response
    | OK of payload: ``load-balancingmonitor-group-single-response``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorGroupsMonitorGroupDetails =
    ///Monitor Group Details response
    | OK of payload: ``load-balancingmonitor-group-single-response``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorGroupsPatchMonitorGroup =
    ///Patch Monitor Group response
    | OK of payload: ``load-balancingmonitor-group-single-response``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorGroupsUpdateMonitorGroup =
    ///Update Monitor Group response
    | OK of payload: ``load-balancingmonitor-group-single-response``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorGroupsListMonitorGroupReferences =
    ///List Monitor Group References response.
    | OK of payload: ``load-balancingmonitor-group-references-response``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorsListMonitors =
    ///List Monitors response.
    | OK of payload: ``load-balancingmonitor-response-collection``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorsCreateMonitor =
    ///Create Monitor response.
    | OK of payload: ``load-balancingmonitor-response-single``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorsDeleteMonitor =
    ///Delete Monitor response.
    | OK of payload: ``load-balancingidresponse``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorsMonitorDetails =
    ///Monitor Details response.
    | OK of payload: ``load-balancingmonitor-response-single``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorsPatchMonitor =
    ///Patch Monitor response.
    | OK of payload: ``load-balancingmonitor-response-single``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorsUpdateMonitor =
    ///Update Monitor response.
    | OK of payload: ``load-balancingmonitor-response-single``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorsPreviewMonitor =
    ///Preview Monitor response.
    | OK of payload: ``load-balancingpreviewresponse``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorsListMonitorReferences =
    ///List Monitor References response.
    | OK of payload: ``load-balancingmonitor-references-response``

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsListPools =
    ///List Pools response.
    | OK of payload: ``load-balancingschemas-responsecollection``

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsPatchPools =
    ///Patch Pools response.
    | OK of payload: ``load-balancingschemas-responsecollection``

type AccountLoadBalancerPoolsCreatePoolPayload =
    { ///A human-readable description of the pool.
      description: Option<``load-balancingschemas-description``>
      ///Whether to enable (the default) or disable this pool. Disabled pools will not receive traffic and are excluded from health checks. Disabling a pool will cause any load balancers using it to failover to the next pool (if any).
      enabled: Option<``load-balancingenabled``>
      ///The latitude of the data center containing the origins used in this pool in decimal degrees. If this is set, longitude must also be set.
      latitude: Option<``load-balancinglatitude``>
      ///Configures load shedding policies and percentages for the pool.
      load_shedding: Option<``load-balancingloadshedding``>
      ///The longitude of the data center containing the origins used in this pool in decimal degrees. If this is set, latitude must also be set.
      longitude: Option<``load-balancinglongitude``>
      ///The minimum number of origins that must be healthy for this pool to serve traffic. If the number of healthy origins falls below this number, the pool will be marked unhealthy and will failover to the next available pool.
      minimum_origins: Option<``load-balancingminimumorigins``>
      ///The ID of the Monitor to use for checking the health of origins within this pool.
      monitor: Option<``load-balancingmonitorid``>
      ///The ID of the Monitor Group to use for checking the health of origins within this pool.
      monitor_group: Option<``load-balancingmonitorgroupid``>
      ///A short name (tag) for the pool. Only alphanumeric characters, hyphens, and underscores are allowed.
      name: ``load-balancingname``
      ///This field is now deprecated. It has been moved to Cloudflare's Centralized Notification service https://developers.cloudflare.com/fundamentals/notifications/. The email address to send health status notifications to. This can be an individual mailbox or a mailing list. Multiple emails can be supplied as a comma delimited list.
      notification_email: Option<``load-balancingnotificationemail``>
      ///Filter pool and origin health notifications by resource type or health status. Use null to reset.
      notification_filter: Option<``load-balancingnotificationfilter``>
      ///Configures origin steering for the pool. Controls how origins are selected for new sessions and traffic without session affinity.
      origin_steering: Option<``load-balancingoriginsteering``>
      ///The list of origins within this pool. Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy.
      origins: ``load-balancingorigins`` }
    ///Creates an instance of AccountLoadBalancerPoolsCreatePoolPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``load-balancingname``, origins: ``load-balancingorigins``): AccountLoadBalancerPoolsCreatePoolPayload =
        { description = None
          enabled = None
          latitude = None
          load_shedding = None
          longitude = None
          minimum_origins = None
          monitor = None
          monitor_group = None
          name = name
          notification_email = None
          notification_filter = None
          origin_steering = None
          origins = origins }

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsCreatePool =
    ///Create Pool response.
    | OK of payload: ``load-balancingschemas-singleresponse``

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsDeletePool =
    ///Delete Pool response.
    | OK of payload: ``load-balancingschemas-idresponse``

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsPoolDetails =
    ///Pool Details response.
    | OK of payload: ``load-balancingschemas-singleresponse``

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AccountLoadBalancerPoolsPatchPoolPayloadCheck_regions =
    | [<CompiledName "WNAM">] WNAM
    | [<CompiledName "ENAM">] ENAM
    | [<CompiledName "WEU">] WEU
    | [<CompiledName "EEU">] EEU
    | [<CompiledName "NSAM">] NSAM
    | [<CompiledName "SSAM">] SSAM
    | [<CompiledName "OC">] OC
    | [<CompiledName "ME">] ME
    | [<CompiledName "NAF">] NAF
    | [<CompiledName "SAF">] SAF
    | [<CompiledName "SAS">] SAS
    | [<CompiledName "SEAS">] SEAS
    | [<CompiledName "NEAS">] NEAS
    | [<CompiledName "ALL_REGIONS">] ALL_REGIONS
    member this.Format() =
        match this with
        | WNAM -> "WNAM"
        | ENAM -> "ENAM"
        | WEU -> "WEU"
        | EEU -> "EEU"
        | NSAM -> "NSAM"
        | SSAM -> "SSAM"
        | OC -> "OC"
        | ME -> "ME"
        | NAF -> "NAF"
        | SAF -> "SAF"
        | SAS -> "SAS"
        | SEAS -> "SEAS"
        | NEAS -> "NEAS"
        | ALL_REGIONS -> "ALL_REGIONS"

type AccountLoadBalancerPoolsPatchPoolPayload =
    { ///A list of regions from which to run health checks. Null means every Cloudflare data center.
      check_regions: Option<list<AccountLoadBalancerPoolsPatchPoolPayloadCheck_regions>>
      ///A human-readable description of the pool.
      description: Option<``load-balancingschemas-description``>
      ///This field shows up only if the pool is disabled. This field is set with the time the pool was disabled at.
      disabled_at: Option<``load-balancingschemas-disabledat``>
      ///Whether to enable (the default) or disable this pool. Disabled pools will not receive traffic and are excluded from health checks. Disabling a pool will cause any load balancers using it to failover to the next pool (if any).
      enabled: Option<``load-balancingenabled``>
      ///The latitude of the data center containing the origins used in this pool in decimal degrees. If this is set, longitude must also be set.
      latitude: Option<``load-balancinglatitude``>
      ///Configures load shedding policies and percentages for the pool.
      load_shedding: Option<``load-balancingloadshedding``>
      ///The longitude of the data center containing the origins used in this pool in decimal degrees. If this is set, latitude must also be set.
      longitude: Option<``load-balancinglongitude``>
      ///The minimum number of origins that must be healthy for this pool to serve traffic. If the number of healthy origins falls below this number, the pool will be marked unhealthy and will failover to the next available pool.
      minimum_origins: Option<``load-balancingminimumorigins``>
      ///The ID of the Monitor to use for checking the health of origins within this pool.
      monitor: Option<``load-balancingmonitorid``>
      ///The ID of the Monitor Group to use for checking the health of origins within this pool.
      monitor_group: Option<``load-balancingmonitorgroupid``>
      ///A short name (tag) for the pool. Only alphanumeric characters, hyphens, and underscores are allowed.
      name: Option<``load-balancingname``>
      ///This field is now deprecated. It has been moved to Cloudflare's Centralized Notification service https://developers.cloudflare.com/fundamentals/notifications/. The email address to send health status notifications to. This can be an individual mailbox or a mailing list. Multiple emails can be supplied as a comma delimited list.
      notification_email: Option<``load-balancingnotificationemail``>
      ///Filter pool and origin health notifications by resource type or health status. Use null to reset.
      notification_filter: Option<``load-balancingnotificationfilter``>
      ///Configures origin steering for the pool. Controls how origins are selected for new sessions and traffic without session affinity.
      origin_steering: Option<``load-balancingoriginsteering``>
      ///The list of origins within this pool. Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy.
      origins: Option<``load-balancingorigins``> }
    ///Creates an instance of AccountLoadBalancerPoolsPatchPoolPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AccountLoadBalancerPoolsPatchPoolPayload =
        { check_regions = None
          description = None
          disabled_at = None
          enabled = None
          latitude = None
          load_shedding = None
          longitude = None
          minimum_origins = None
          monitor = None
          monitor_group = None
          name = None
          notification_email = None
          notification_filter = None
          origin_steering = None
          origins = None }

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsPatchPool =
    ///Patch Pool response.
    | OK of payload: ``load-balancingschemas-singleresponse``

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AccountLoadBalancerPoolsUpdatePoolPayloadCheck_regions =
    | [<CompiledName "WNAM">] WNAM
    | [<CompiledName "ENAM">] ENAM
    | [<CompiledName "WEU">] WEU
    | [<CompiledName "EEU">] EEU
    | [<CompiledName "NSAM">] NSAM
    | [<CompiledName "SSAM">] SSAM
    | [<CompiledName "OC">] OC
    | [<CompiledName "ME">] ME
    | [<CompiledName "NAF">] NAF
    | [<CompiledName "SAF">] SAF
    | [<CompiledName "SAS">] SAS
    | [<CompiledName "SEAS">] SEAS
    | [<CompiledName "NEAS">] NEAS
    | [<CompiledName "ALL_REGIONS">] ALL_REGIONS
    member this.Format() =
        match this with
        | WNAM -> "WNAM"
        | ENAM -> "ENAM"
        | WEU -> "WEU"
        | EEU -> "EEU"
        | NSAM -> "NSAM"
        | SSAM -> "SSAM"
        | OC -> "OC"
        | ME -> "ME"
        | NAF -> "NAF"
        | SAF -> "SAF"
        | SAS -> "SAS"
        | SEAS -> "SEAS"
        | NEAS -> "NEAS"
        | ALL_REGIONS -> "ALL_REGIONS"

type AccountLoadBalancerPoolsUpdatePoolPayload =
    { ///A list of regions from which to run health checks. Null means every Cloudflare data center.
      check_regions: Option<list<AccountLoadBalancerPoolsUpdatePoolPayloadCheck_regions>>
      ///A human-readable description of the pool.
      description: Option<``load-balancingschemas-description``>
      ///This field shows up only if the pool is disabled. This field is set with the time the pool was disabled at.
      disabled_at: Option<``load-balancingschemas-disabledat``>
      ///Whether to enable (the default) or disable this pool. Disabled pools will not receive traffic and are excluded from health checks. Disabling a pool will cause any load balancers using it to failover to the next pool (if any).
      enabled: Option<``load-balancingenabled``>
      ///The latitude of the data center containing the origins used in this pool in decimal degrees. If this is set, longitude must also be set.
      latitude: Option<``load-balancinglatitude``>
      ///Configures load shedding policies and percentages for the pool.
      load_shedding: Option<``load-balancingloadshedding``>
      ///The longitude of the data center containing the origins used in this pool in decimal degrees. If this is set, latitude must also be set.
      longitude: Option<``load-balancinglongitude``>
      ///The minimum number of origins that must be healthy for this pool to serve traffic. If the number of healthy origins falls below this number, the pool will be marked unhealthy and will failover to the next available pool.
      minimum_origins: Option<``load-balancingminimumorigins``>
      ///The ID of the Monitor to use for checking the health of origins within this pool.
      monitor: Option<``load-balancingmonitorid``>
      ///The ID of the Monitor Group to use for checking the health of origins within this pool.
      monitor_group: Option<``load-balancingmonitorgroupid``>
      ///A short name (tag) for the pool. Only alphanumeric characters, hyphens, and underscores are allowed.
      name: ``load-balancingname``
      ///This field is now deprecated. It has been moved to Cloudflare's Centralized Notification service https://developers.cloudflare.com/fundamentals/notifications/. The email address to send health status notifications to. This can be an individual mailbox or a mailing list. Multiple emails can be supplied as a comma delimited list.
      notification_email: Option<``load-balancingnotificationemail``>
      ///Filter pool and origin health notifications by resource type or health status. Use null to reset.
      notification_filter: Option<``load-balancingnotificationfilter``>
      ///Configures origin steering for the pool. Controls how origins are selected for new sessions and traffic without session affinity.
      origin_steering: Option<``load-balancingoriginsteering``>
      ///The list of origins within this pool. Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy.
      origins: ``load-balancingorigins`` }
    ///Creates an instance of AccountLoadBalancerPoolsUpdatePoolPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``load-balancingname``, origins: ``load-balancingorigins``): AccountLoadBalancerPoolsUpdatePoolPayload =
        { check_regions = None
          description = None
          disabled_at = None
          enabled = None
          latitude = None
          load_shedding = None
          longitude = None
          minimum_origins = None
          monitor = None
          monitor_group = None
          name = name
          notification_email = None
          notification_filter = None
          origin_steering = None
          origins = origins }

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsUpdatePool =
    ///Update Pool response.
    | OK of payload: ``load-balancingschemas-singleresponse``

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsPoolHealthDetails =
    ///Pool Health Details response.
    | OK of payload: ``load-balancinghealthdetails``

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsPreviewPool =
    ///Preview Pool response.
    | OK of payload: ``load-balancingpreviewresponse``

[<RequireQualifiedAccess>]
type AccountLoadBalancerPoolsListPoolReferences =
    ///List Pool References response.
    | OK of payload: ``load-balancingpools-references-response``

[<RequireQualifiedAccess>]
type AccountLoadBalancerMonitorsPreviewResult =
    ///Preview Result response.
    | OK of payload: ``load-balancingpreviewresultresponse``

[<RequireQualifiedAccess>]
type LoadBalancerRegionsListRegions =
    ///List Regions response.
    | OK of payload: ``load-balancingregioncomponents-schemas-responsecollection``

[<RequireQualifiedAccess>]
type LoadBalancerRegionsGetRegion =
    ///Get Region response.
    | OK of payload: ``load-balancingcomponents-schemas-singleresponse``

[<RequireQualifiedAccess>]
type AccountLoadBalancerSearchSearchResources =
    ///Search Resources response.
    | OK of payload: string
