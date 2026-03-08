namespace rec Fidelity.CloudEdge.Management.Tunnels.Types

///Cloudflare account ID
type tunnelaccountid = string
///The cloudflared OS architecture used to establish this connection.
type tunnelarch = string
///UUID of the Cloudflare Tunnel connector.
type tunnelclientid = System.Guid
///The Cloudflare data center used for this connection.
type tunnelcoloname = string

///Indicates if this is a locally or remotely configured tunnel. If `local`, manage the tunnel using a YAML file on the origin machine. If `cloudflare`, manage the tunnel on the Zero Trust dashboard.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type tunnelconfigsrc =
    | [<CompiledName "local">] Local
    | [<CompiledName "cloudflare">] Cloudflare
    member this.Format() =
        match this with
        | Local -> "local"
        | Cloudflare -> "cloudflare"

type tunnelconfigversion = int
///UUID of the Cloudflare Tunnel connection.
type tunnelconnectionid = System.Guid
type tunnelconnections = list<``tunnel_schemas-connection``>
type tunnelconnectionsdeprecated = list<``tunnel_schemas-connection``>
///Timestamp of when the tunnel established at least one connection to Cloudflare's edge. If `null`, the tunnel is inactive.
type tunnelconnsactiveat = System.DateTimeOffset
///Timestamp of when the tunnel became inactive (no connections to Cloudflare's edge). If `null`, the tunnel is active.
type tunnelconnsinactiveat = System.DateTimeOffset
///Timestamp of when the resource was created.
type tunnelcreatedat = System.DateTimeOffset
///Timestamp of when the resource was deleted. If `null`, the resource has not been deleted.
type tunneldeletedat = System.DateTimeOffset
///If provided, include only resources that were created (and not deleted) before this time. URL encoded.
type tunnelexistedat = string
///Features enabled for the Cloudflare Tunnel.
type tunnelfeatures = list<string>
///Identifier.
type tunnelidentifier = string
type tunnelip = string
type tunnelispendingreconnect = bool

///Management resources the token will have access to.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``tunnelmanagement-resources`` =
    | [<CompiledName "logs">] Logs
    member this.Format() =
        match this with
        | Logs -> "logs"

type tunnelmessagesArrayItem =
    { code: int
      message: string }
    ///Creates an instance of tunnelmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunnelmessagesArrayItem = { code = code; message = message }

type tunnelmessages = list<tunnelmessagesArrayItem>
type tunnelpagenumber = float
type tunnelperpage = float
type tunnelremoteconfig = bool
///Timestamp of when the tunnel connection was started.
type tunnelrunat = System.DateTimeOffset

///Indicates if this is a locally or remotely configured tunnel. If `local`, manage the tunnel using a YAML file on the origin machine. If `cloudflare`, manage the tunnel's configuration on the Zero Trust dashboard.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``tunnelschemas-configsrc`` =
    | [<CompiledName "local">] Local
    | [<CompiledName "cloudflare">] Cloudflare
    member this.Format() =
        match this with
        | Local -> "local"
        | Cloudflare -> "cloudflare"

type ``tunnelschemas-configversion`` = int

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type ``tunnelschemas-messagesArrayItem`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of tunnelschemas-messagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelschemas-messagesArrayItem`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``tunnelschemas-messages`` = list<``tunnelschemas-messagesArrayItem``>
///UUID of the tunnel.
type ``tunnelschemas-tunnelid`` = System.Guid

///The status of the tunnel. Valid values are `inactive` (tunnel has never been run), `degraded` (tunnel is active and able to serve traffic but in an unhealthy state), `healthy` (tunnel is active and able to serve traffic), or `down` (tunnel can not serve traffic as it has no connections to the Cloudflare Edge).
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type tunnelstatus =
    | [<CompiledName "inactive">] Inactive
    | [<CompiledName "degraded">] Degraded
    | [<CompiledName "healthy">] Healthy
    | [<CompiledName "down">] Down
    member this.Format() =
        match this with
        | Inactive -> "inactive"
        | Degraded -> "degraded"
        | Healthy -> "healthy"
        | Down -> "down"

type tunneltimestamp = System.DateTimeOffset
///UUID of the tunnel.
type tunneltunnelid = System.Guid
///A user-friendly name for a tunnel.
type tunneltunnelname = string
///Sets the password required to run a locally-managed tunnel. Must be at least 32 bytes and encoded as a base64 string.
type tunneltunnelsecret = string
///The Tunnel Token is used as a mechanism to authenticate the operation of a tunnel.
type tunneltunneltoken = string

///The type of tunnel.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type tunneltunneltype =
    | [<CompiledName "cfd_tunnel">] Cfd_tunnel
    | [<CompiledName "warp_connector">] Warp_connector
    | [<CompiledName "warp">] Warp
    | [<CompiledName "magic">] Magic
    | [<CompiledName "ip_sec">] Ip_sec
    | [<CompiledName "gre">] Gre
    | [<CompiledName "cni">] Cni
    member this.Format() =
        match this with
        | Cfd_tunnel -> "cfd_tunnel"
        | Warp_connector -> "warp_connector"
        | Warp -> "warp"
        | Magic -> "magic"
        | Ip_sec -> "ip_sec"
        | Gre -> "gre"
        | Cni -> "cni"

///The cloudflared version used to establish this connection.
type tunnelversion = string

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

type ``tunnelapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool>
      result_info: Option<tunnelresultinfo> }
    ///Creates an instance of tunnelapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelapi-response-collection`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type ``tunnelapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelapi-response-commonErrors`` =
        { code = code; message = message }

type ``tunnelapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelapi-response-commonMessages`` =
        { code = code; message = message }

type ``tunnelapi-response-common`` =
    { errors: list<``tunnelapi-response-commonErrors``>
      messages: list<``tunnelapi-response-commonMessages``>
      result: Newtonsoft.Json.Linq.JToken
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of tunnelapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``tunnelapi-response-commonErrors``>,
                          messages: list<``tunnelapi-response-commonMessages``>,
                          result: Newtonsoft.Json.Linq.JToken,
                          success: bool): ``tunnelapi-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``tunnelapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of tunnelapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``tunnelapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``tunnelcfd-tunnel-response-collectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelcfd-tunnel-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelcfd-tunnel-response-collectionErrors`` =
        { code = code; message = message }

type ``tunnelcfd-tunnel-response-collectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelcfd-tunnel-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelcfd-tunnel-response-collectionMessages`` =
        { code = code; message = message }

type ``tunnelcfd-tunnel-response-collection`` =
    { errors: Option<list<``tunnelcfd-tunnel-response-collectionErrors``>>
      messages: Option<list<``tunnelcfd-tunnel-response-collectionMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool>
      result_info: Option<tunnelresultinfo> }
    ///Creates an instance of tunnelcfd-tunnel-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelcfd-tunnel-response-collection`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type ``tunnelcfd-tunnel-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelcfd-tunnel-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelcfd-tunnel-response-singleErrors`` =
        { code = code; message = message }

type ``tunnelcfd-tunnel-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelcfd-tunnel-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelcfd-tunnel-response-singleMessages`` =
        { code = code; message = message }

type ``tunnelcfd-tunnel-response-single`` =
    { errors: Option<list<``tunnelcfd-tunnel-response-singleErrors``>>
      messages: Option<list<``tunnelcfd-tunnel-response-singleMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of tunnelcfd-tunnel-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelcfd-tunnel-response-single`` =
        { errors = None
          messages = None
          result = None
          success = None }

///A Cloudflare Tunnel that connects your origin to Cloudflare's edge.
type tunnelcfdtunnel =
    { ///Cloudflare account ID
      account_tag: Option<tunnelaccountid>
      ///Indicates if this is a locally or remotely configured tunnel. If `local`, manage the tunnel using a YAML file on the origin machine. If `cloudflare`, manage the tunnel on the Zero Trust dashboard.
      config_src: Option<tunnelconfigsrc>
      ///Timestamp of when the tunnel established at least one connection to Cloudflare's edge. If `null`, the tunnel is inactive.
      conns_active_at: Option<tunnelconnsactiveat>
      ///Timestamp of when the tunnel became inactive (no connections to Cloudflare's edge). If `null`, the tunnel is active.
      conns_inactive_at: Option<tunnelconnsinactiveat>
      ///Timestamp of when the resource was created.
      created_at: Option<tunnelcreatedat>
      ///Timestamp of when the resource was deleted. If `null`, the resource has not been deleted.
      deleted_at: Option<tunneldeletedat>
      ///UUID of the tunnel.
      id: Option<tunneltunnelid>
      ///Metadata associated with the tunnel.
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      ///A user-friendly name for a tunnel.
      name: Option<tunneltunnelname>
      ///The status of the tunnel. Valid values are `inactive` (tunnel has never been run), `degraded` (tunnel is active and able to serve traffic but in an unhealthy state), `healthy` (tunnel is active and able to serve traffic), or `down` (tunnel can not serve traffic as it has no connections to the Cloudflare Edge).
      status: Option<tunnelstatus>
      ///The type of tunnel.
      tun_type: Option<tunneltunneltype> }
    ///Creates an instance of tunnelcfdtunnel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelcfdtunnel =
        { account_tag = None
          config_src = None
          conns_active_at = None
          conns_inactive_at = None
          created_at = None
          deleted_at = None
          id = None
          metadata = None
          name = None
          status = None
          tun_type = None }

///The tunnel configuration and ingress rules.
type tunnelconfig =
    { ///List of public hostname definitions. At least one ingress rule needs to be defined for the tunnel.
      ingress: Option<list<tunnelingressRule>>
      ///Configuration parameters for the public hostname specific connection settings between cloudflared and origin server.
      originRequest: Option<tunneloriginRequest> }
    ///Creates an instance of tunnelconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelconfig = { ingress = None; originRequest = None }

///Cloudflare Tunnel configuration
type tunnelconfiguration =
    { ///Identifier.
      account_id: Option<tunnelidentifier>
      ///The tunnel configuration and ingress rules.
      config: Option<tunnelconfig>
      created_at: Option<tunneltimestamp>
      ///Indicates if this is a locally or remotely configured tunnel. If `local`, manage the tunnel using a YAML file on the origin machine. If `cloudflare`, manage the tunnel's configuration on the Zero Trust dashboard.
      source: Option<``tunnelschemas-configsrc``>
      ///UUID of the tunnel.
      tunnel_id: Option<``tunnelschemas-tunnelid``>
      ///The version of the Tunnel Configuration.
      version: Option<``tunnelschemas-configversion``> }
    ///Creates an instance of tunnelconfiguration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelconfiguration =
        { account_id = None
          config = None
          created_at = None
          source = None
          tunnel_id = None
          version = None }

type tunnelconfigurationresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of tunnelconfigurationresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelconfigurationresponseErrorsSource = { pointer = None }

type tunnelconfigurationresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<tunnelconfigurationresponseErrorsSource> }
    ///Creates an instance of tunnelconfigurationresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunnelconfigurationresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type tunnelconfigurationresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of tunnelconfigurationresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelconfigurationresponseMessagesSource = { pointer = None }

type tunnelconfigurationresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<tunnelconfigurationresponseMessagesSource> }
    ///Creates an instance of tunnelconfigurationresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunnelconfigurationresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type tunnelconfigurationresponse =
    { errors: Option<list<tunnelconfigurationresponseErrors>>
      messages: Option<list<tunnelconfigurationresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      ///Cloudflare Tunnel configuration
      result: Option<tunnelconfiguration> }
    ///Creates an instance of tunnelconfigurationresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelconfigurationresponse =
        { errors = None
          messages = None
          success = None
          result = None }

type tunnelemptyresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of tunnelemptyresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunnelemptyresponseErrors = { code = code; message = message }

type tunnelemptyresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of tunnelemptyresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunnelemptyresponseMessages = { code = code; message = message }

type tunnelemptyresponse =
    { errors: Option<list<tunnelemptyresponseErrors>>
      messages: Option<list<tunnelemptyresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of tunnelemptyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelemptyresponse =
        { errors = None
          messages = None
          result = None
          success = None }

///Public hostname
type tunnelingressRule =
    { ///Public hostname for this service.
      hostname: string
      ///Configuration parameters for the public hostname specific connection settings between cloudflared and origin server.
      originRequest: Option<tunneloriginRequest>
      ///Requests with this path route to this public hostname.
      path: Option<string>
      ///Protocol and address of destination server. Supported protocols: http://, https://, unix://, tcp://, ssh://, rdp://, unix+tls://, smb://. Alternatively can return a HTTP status code http_status:[code] e.g. 'http_status:404'.
      service: string }
    ///Creates an instance of tunnelingressRule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (hostname: string, service: string): tunnelingressRule =
        { hostname = hostname
          originRequest = None
          path = None
          service = service }

///For all L7 requests to this hostname, cloudflared will validate each request's Cf-Access-Jwt-Assertion request header.
type Access =
    { ///Access applications that are allowed to reach this hostname for this Tunnel. Audience tags can be identified in the dashboard or via the List Access policies API.
      audTag: list<string>
      ///Deny traffic that has not fulfilled Access authorization.
      required: Option<bool>
      teamName: string }
    ///Creates an instance of Access with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (audTag: list<string>, teamName: string): Access =
        { audTag = audTag
          required = None
          teamName = teamName }

///Configuration parameters for the public hostname specific connection settings between cloudflared and origin server.
type tunneloriginRequest =
    { ///For all L7 requests to this hostname, cloudflared will validate each request's Cf-Access-Jwt-Assertion request header.
      access: Option<Access>
      ///Path to the certificate authority (CA) for the certificate of your origin. This option should be used only if your certificate is not signed by Cloudflare.
      caPool: Option<string>
      ///Timeout for establishing a new TCP connection to your origin server. This excludes the time taken to establish TLS, which is controlled by tlsTimeout.
      connectTimeout: Option<int>
      ///Disables chunked transfer encoding. Useful if you are running a WSGI server.
      disableChunkedEncoding: Option<bool>
      ///Attempt to connect to origin using HTTP2. Origin must be configured as https.
      http2Origin: Option<bool>
      ///Sets the HTTP Host header on requests sent to the local service.
      httpHostHeader: Option<string>
      ///Maximum number of idle keepalive connections between Tunnel and your origin. This does not restrict the total number of concurrent connections.
      keepAliveConnections: Option<int>
      ///Timeout after which an idle keepalive connection can be discarded.
      keepAliveTimeout: Option<int>
      ///Auto configure the Hostname on the origin server certificate.
      matchSNItoHost: Option<bool>
      ///Disable the “happy eyeballs” algorithm for IPv4/IPv6 fallback if your local network has misconfigured one of the protocols.
      noHappyEyeballs: Option<bool>
      ///Disables TLS verification of the certificate presented by your origin. Will allow any certificate from the origin to be accepted.
      noTLSVerify: Option<bool>
      ///Hostname that cloudflared should expect from your origin server certificate.
      originServerName: Option<string>
      ///cloudflared starts a proxy server to translate HTTP traffic into TCP when proxying, for example, SSH or RDP. This configures what type of proxy will be started. Valid options are: "" for the regular proxy and "socks" for a SOCKS5 proxy.
      proxyType: Option<string>
      ///The timeout after which a TCP keepalive packet is sent on a connection between Tunnel and the origin server.
      tcpKeepAlive: Option<int>
      ///Timeout for completing a TLS handshake to your origin server, if you have chosen to connect Tunnel to an HTTPS server.
      tlsTimeout: Option<int> }
    ///Creates an instance of tunneloriginRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunneloriginRequest =
        { access = None
          caPool = None
          connectTimeout = None
          disableChunkedEncoding = None
          http2Origin = None
          httpHostHeader = None
          keepAliveConnections = None
          keepAliveTimeout = None
          matchSNItoHost = None
          noHappyEyeballs = None
          noTLSVerify = None
          originServerName = None
          proxyType = None
          tcpKeepAlive = None
          tlsTimeout = None }

type tunnelresultinfo =
    { ///Total number of results for the requested service
      count: Option<float>
      ///Current page within paginated list of results
      page: Option<float>
      ///Number of results per page of results
      per_page: Option<float>
      ///Total results available without any search parameters
      total_count: Option<float> }
    ///Creates an instance of tunnelresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelresultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``tunnelschemas-api-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of tunnelschemas-api-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelschemas-api-response-commonErrorsSource`` = { pointer = None }

type ``tunnelschemas-api-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``tunnelschemas-api-response-commonErrorsSource``> }
    ///Creates an instance of tunnelschemas-api-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelschemas-api-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``tunnelschemas-api-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of tunnelschemas-api-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelschemas-api-response-commonMessagesSource`` = { pointer = None }

type ``tunnelschemas-api-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``tunnelschemas-api-response-commonMessagesSource``> }
    ///Creates an instance of tunnelschemas-api-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelschemas-api-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``tunnelschemas-api-response-common`` =
    { errors: list<``tunnelschemas-api-response-commonErrors``>
      messages: list<``tunnelschemas-api-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of tunnelschemas-api-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``tunnelschemas-api-response-commonErrors``>,
                          messages: list<``tunnelschemas-api-response-commonMessages``>,
                          success: bool): ``tunnelschemas-api-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``tunnelschemas-api-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of tunnelschemas-api-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``tunnelschemas-api-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``tunnelschemas-api-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of tunnelschemas-api-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelschemas-api-response-singleErrorsSource`` = { pointer = None }

type ``tunnelschemas-api-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``tunnelschemas-api-response-singleErrorsSource``> }
    ///Creates an instance of tunnelschemas-api-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelschemas-api-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``tunnelschemas-api-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of tunnelschemas-api-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelschemas-api-response-singleMessagesSource`` = { pointer = None }

type ``tunnelschemas-api-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``tunnelschemas-api-response-singleMessagesSource``> }
    ///Creates an instance of tunnelschemas-api-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelschemas-api-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``tunnelschemas-api-response-single`` =
    { errors: Option<list<``tunnelschemas-api-response-singleErrors``>>
      messages: Option<list<``tunnelschemas-api-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of tunnelschemas-api-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelschemas-api-response-single`` =
        { errors = None
          messages = None
          success = None }

type ``tunnelschemas-connection`` =
    { ///UUID of the Cloudflare Tunnel connector.
      client_id: Option<tunnelclientid>
      ///The cloudflared version used to establish this connection.
      client_version: Option<tunnelversion>
      ///The Cloudflare data center used for this connection.
      colo_name: Option<tunnelcoloname>
      ///UUID of the Cloudflare Tunnel connection.
      id: Option<tunnelconnectionid>
      ///Cloudflare continues to track connections for several minutes after they disconnect. This is an optimization to improve latency and reliability of reconnecting.  If `true`, the connection has disconnected but is still being tracked. If `false`, the connection is actively serving traffic.
      is_pending_reconnect: Option<tunnelispendingreconnect>
      ///Timestamp of when the connection was established.
      opened_at: Option<System.DateTimeOffset>
      ///The public IP address of the host running cloudflared.
      origin_ip: Option<Newtonsoft.Json.Linq.JToken>
      ///UUID of the Cloudflare Tunnel connection.
      uuid: Option<tunnelconnectionid> }
    ///Creates an instance of tunnelschemas-connection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelschemas-connection`` =
        { client_id = None
          client_version = None
          colo_name = None
          id = None
          is_pending_reconnect = None
          opened_at = None
          origin_ip = None
          uuid = None }

///A client (typically cloudflared) that maintains connections to a Cloudflare data center.
type tunneltunnelclient =
    { ///The cloudflared OS architecture used to establish this connection.
      arch: Option<tunnelarch>
      ///The version of the remote tunnel configuration. Used internally to sync cloudflared with the Zero Trust dashboard.
      config_version: Option<tunnelconfigversion>
      ///The Cloudflare Tunnel connections between your origin and Cloudflare's edge.
      conns: Option<tunnelconnections>
      ///Features enabled for the Cloudflare Tunnel.
      features: Option<tunnelfeatures>
      ///UUID of the Cloudflare Tunnel connection.
      id: Option<tunnelconnectionid>
      ///Timestamp of when the tunnel connection was started.
      run_at: Option<tunnelrunat>
      ///The cloudflared version used to establish this connection.
      version: Option<tunnelversion> }
    ///Creates an instance of tunneltunnelclient with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunneltunnelclient =
        { arch = None
          config_version = None
          conns = None
          features = None
          id = None
          run_at = None
          version = None }

type tunneltunnelclientresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelclientresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelclientresponseErrors =
        { code = code; message = message }

type tunneltunnelclientresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelclientresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelclientresponseMessages =
        { code = code; message = message }

type tunneltunnelclientresponse =
    { errors: Option<list<tunneltunnelclientresponseErrors>>
      messages: Option<list<tunneltunnelclientresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of tunneltunnelclientresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunneltunnelclientresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type tunneltunnelconnectionsresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelconnectionsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelconnectionsresponseErrors =
        { code = code; message = message }

type tunneltunnelconnectionsresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelconnectionsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelconnectionsresponseMessages =
        { code = code; message = message }

type tunneltunnelconnectionsresponse =
    { errors: Option<list<tunneltunnelconnectionsresponseErrors>>
      messages: Option<list<tunneltunnelconnectionsresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool>
      result_info: Option<tunnelresultinfo> }
    ///Creates an instance of tunneltunnelconnectionsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunneltunnelconnectionsresponse =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type tunneltunnelresponsetokenErrors =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelresponsetokenErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelresponsetokenErrors =
        { code = code; message = message }

type tunneltunnelresponsetokenMessages =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelresponsetokenMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelresponsetokenMessages =
        { code = code; message = message }

type tunneltunnelresponsetoken =
    { errors: Option<list<tunneltunnelresponsetokenErrors>>
      messages: Option<list<tunneltunnelresponsetokenMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of tunneltunnelresponsetoken with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunneltunnelresponsetoken =
        { errors = None
          messages = None
          result = None
          success = None }

[<RequireQualifiedAccess>]
type CloudflareTunnelListCloudflareTunnels =
    ///List Cloudflare Tunnels response
    | OK of payload: ``tunnelcfd-tunnel-response-collection``

type CloudflareTunnelCreateACloudflareTunnelPayload =
    { ///Indicates if this is a locally or remotely configured tunnel. If `local`, manage the tunnel using a YAML file on the origin machine. If `cloudflare`, manage the tunnel on the Zero Trust dashboard.
      config_src: Option<tunnelconfigsrc>
      ///A user-friendly name for a tunnel.
      name: tunneltunnelname
      ///Sets the password required to run a locally-managed tunnel. Must be at least 32 bytes and encoded as a base64 string.
      tunnel_secret: Option<tunneltunnelsecret> }
    ///Creates an instance of CloudflareTunnelCreateACloudflareTunnelPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: tunneltunnelname): CloudflareTunnelCreateACloudflareTunnelPayload =
        { config_src = None
          name = name
          tunnel_secret = None }

[<RequireQualifiedAccess>]
type CloudflareTunnelCreateACloudflareTunnel =
    ///Create a Cloudflare Tunnel response
    | OK of payload: ``tunnelcfd-tunnel-response-single``

[<RequireQualifiedAccess>]
type CloudflareTunnelDeleteACloudflareTunnel =
    ///Delete a Cloudflare Tunnel response
    | OK of payload: ``tunnelcfd-tunnel-response-single``

[<RequireQualifiedAccess>]
type CloudflareTunnelGetACloudflareTunnel =
    ///Get a Cloudflare Tunnel response
    | OK of payload: ``tunnelcfd-tunnel-response-single``

type CloudflareTunnelUpdateACloudflareTunnelPayload =
    { ///A user-friendly name for a tunnel.
      name: Option<tunneltunnelname>
      ///Sets the password required to run a locally-managed tunnel. Must be at least 32 bytes and encoded as a base64 string.
      tunnel_secret: Option<tunneltunnelsecret> }
    ///Creates an instance of CloudflareTunnelUpdateACloudflareTunnelPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): CloudflareTunnelUpdateACloudflareTunnelPayload = { name = None; tunnel_secret = None }

[<RequireQualifiedAccess>]
type CloudflareTunnelUpdateACloudflareTunnel =
    ///Update a Cloudflare Tunnel response
    | OK of payload: ``tunnelcfd-tunnel-response-single``

[<RequireQualifiedAccess>]
type CloudflareTunnelConfigurationGetConfiguration =
    ///Get configuration response
    | OK of payload: tunnelconfigurationresponse

type CloudflareTunnelConfigurationPutConfigurationPayload =
    { ///The tunnel configuration and ingress rules.
      config: Option<tunnelconfig> }
    ///Creates an instance of CloudflareTunnelConfigurationPutConfigurationPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): CloudflareTunnelConfigurationPutConfigurationPayload = { config = None }

[<RequireQualifiedAccess>]
type CloudflareTunnelConfigurationPutConfiguration =
    ///Put configuration response
    | OK of payload: tunnelconfigurationresponse

[<RequireQualifiedAccess>]
type CloudflareTunnelCleanUpCloudflareTunnelConnections =
    ///Clean up Cloudflare Tunnel connections response
    | OK of payload: tunnelemptyresponse

[<RequireQualifiedAccess>]
type CloudflareTunnelListCloudflareTunnelConnections =
    ///List Cloudflare Tunnel connections response
    | OK of payload: tunneltunnelconnectionsresponse

[<RequireQualifiedAccess>]
type CloudflareTunnelGetCloudflareTunnelConnector =
    ///Get Cloudflare Tunnel connector response
    | OK of payload: tunneltunnelclientresponse

type CloudflareTunnelGetACloudflareTunnelManagementTokenPayload =
    { resources: list<``tunnelmanagement-resources``> }
    ///Creates an instance of CloudflareTunnelGetACloudflareTunnelManagementTokenPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (resources: list<``tunnelmanagement-resources``>): CloudflareTunnelGetACloudflareTunnelManagementTokenPayload =
        { resources = resources }

[<RequireQualifiedAccess>]
type CloudflareTunnelGetACloudflareTunnelManagementToken =
    ///Get a Cloudflare Tunnel management token response
    | OK of payload: tunneltunnelresponsetoken

[<RequireQualifiedAccess>]
type CloudflareTunnelGetACloudflareTunnelToken =
    ///Get a Cloudflare Tunnel token response
    | OK of payload: tunneltunnelresponsetoken
