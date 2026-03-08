namespace rec Fidelity.CloudEdge.Management.Gateway.Types

///Specify the action to perform when the associated traffic, identity, and device posture expressions either absent or evaluate to `true`.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``zero-trust-gatewayaction`` =
    | [<CompiledName "on">] On
    | [<CompiledName "off">] Off
    | [<CompiledName "allow">] Allow
    | [<CompiledName "block">] Block
    | [<CompiledName "scan">] Scan
    | [<CompiledName "noscan">] Noscan
    | [<CompiledName "safesearch">] Safesearch
    | [<CompiledName "ytrestricted">] Ytrestricted
    | [<CompiledName "isolate">] Isolate
    | [<CompiledName "noisolate">] Noisolate
    | [<CompiledName "override">] Override
    | [<CompiledName "l4_override">] L4_override
    | [<CompiledName "egress">] Egress
    | [<CompiledName "resolve">] Resolve
    | [<CompiledName "quarantine">] Quarantine
    | [<CompiledName "redirect">] Redirect
    member this.Format() =
        match this with
        | On -> "on"
        | Off -> "off"
        | Allow -> "allow"
        | Block -> "block"
        | Scan -> "scan"
        | Noscan -> "noscan"
        | Safesearch -> "safesearch"
        | Ytrestricted -> "ytrestricted"
        | Isolate -> "isolate"
        | Noisolate -> "noisolate"
        | Override -> "override"
        | L4_override -> "l4_override"
        | Egress -> "egress"
        | Resolve -> "resolve"
        | Quarantine -> "quarantine"
        | Redirect -> "redirect"

///Specify the name of the application or application type.
type ``zero-trust-gatewayapp-typescomponents-schemas-name`` = string
type ``zero-trust-gatewayappid`` = int
type ``zero-trust-gatewayapptypeid`` = int
type ``zero-trust-gatewayapprovedapps`` = list<int>
///Identify the seed ID.
type ``zero-trust-gatewayauditsshsettingscomponents-schemas-uuid`` = string
type ``zero-trust-gatewaybeta`` = bool

///Indicate the read-only deployment status of the certificate on Cloudflare's edge. Gateway TLS interception can use certificates in the 'available' (previously called 'active') state.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``zero-trust-gatewaybindingstatus`` =
    | [<CompiledName "pending_deployment">] Pending_deployment
    | [<CompiledName "available">] Available
    | [<CompiledName "pending_deletion">] Pending_deletion
    | [<CompiledName "inactive">] Inactive
    member this.Format() =
        match this with
        | Pending_deployment -> "pending_deployment"
        | Available -> "available"
        | Pending_deletion -> "pending_deletion"
        | Inactive -> "inactive"

///Specify the category name.
type ``zero-trust-gatewaycategoriescomponents-schemas-name`` = string
///Specify the Cloudflare account ID.
type ``zero-trust-gatewaycfaccountid`` = string

///Specify which account types can create policies for this category. `blocked` Blocks unconditionally for all accounts. `removalPending` Allows removal from policies but disables addition. `noBlock` Prevents blocking.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``zero-trust-gatewayclass`` =
    | [<CompiledName "free">] Free
    | [<CompiledName "premium">] Premium
    | [<CompiledName "blocked">] Blocked
    | [<CompiledName "removalPending">] RemovalPending
    | [<CompiledName "noBlock">] NoBlock
    member this.Format() =
        match this with
        | Free -> "free"
        | Premium -> "premium"
        | Blocked -> "blocked"
        | RemovalPending -> "removalPending"
        | NoBlock -> "noBlock"

type ``zero-trust-gatewayclient-default`` = bool
///Provide a short summary of domains in the category.
type ``zero-trust-gatewaycomponents-schemas-description`` = string
///Provide the identifier string.
type ``zero-trust-gatewaycomponents-schemas-identifier`` = string
///Specify the rule name.
type ``zero-trust-gatewaycomponents-schemas-name`` = string
type ``zero-trust-gatewaycomponents-schemas-uuid`` = string
///Actual contents of the PAC file
type ``zero-trust-gatewaycontents`` = string
type ``zero-trust-gatewaycount`` = float
///Indicate the date of deletion, if any.
type ``zero-trust-gatewaydeletedat`` = System.DateTimeOffset
///Provide the list description.
type ``zero-trust-gatewaydescription`` = string
///Provide the list item description (optional).
type ``zero-trust-gatewaydescriptionitem`` = string
///Specify the wirefilter expression used for device posture check. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
type ``zero-trust-gatewaydeviceposture`` = string
///Indicate the identifier of the pair of IPv4 addresses assigned to this location.
type ``zero-trust-gatewaydns-destination-ips-id-read`` = string
///Specify the identifier of the pair of IPv4 addresses assigned to this location. When creating a location, if this field is absent or set to null, the pair of shared IPv4 addresses (0e4a32c6-6fb8-4858-9296-98f51631e8e6) is auto-assigned. When updating a location, if this field is absent or set to null, the pre-assigned pair remains unchanged.
type ``zero-trust-gatewaydns-destination-ips-id-write`` = string
///Specify the UUID of the IPv6 block brought to the gateway so that this location's IPv6 address is allocated from the Bring Your Own IPv6 (BYOIPv6) block rather than the standard Cloudflare IPv6 block.
type ``zero-trust-gatewaydnsdestinationipv6blockid`` = string
type ``zero-trust-gatewayecs-support`` = bool
type ``zero-trust-gatewayenabled`` = bool
type ``zero-trust-gatewayenableddownloadphase`` = bool
type ``zero-trust-gatewayenableduploadphase`` = bool
type ``zero-trust-gatewayfailclosed`` = bool

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``EnumForzero-trust-gatewayfilters`` =
    | [<CompiledName "http">] Http
    | [<CompiledName "dns">] Dns
    | [<CompiledName "l4">] L4
    | [<CompiledName "egress">] Egress
    | [<CompiledName "dns_resolver">] Dns_resolver
    member this.Format() =
        match this with
        | Http -> "http"
        | Dns -> "dns"
        | L4 -> "l4"
        | Egress -> "egress"
        | Dns_resolver -> "dns_resolver"

type ``zero-trust-gatewayfilters`` = list<``EnumForzero-trust-gatewayfilters``>
///Specify the gateway internal ID.
type ``zero-trust-gatewaygatewaytag`` = string
type ``zero-trust-gatewayid`` = int
type ``zero-trust-gatewayidentifier`` = string
///Specify the wirefilter expression used for identity matching. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
type ``zero-trust-gatewayidentity`` = string
type ``zero-trust-gatewayinreviewapps`` = list<int>
///Defines the automatically generated IPv6 destination IP assigned to this location. Gateway counts all DNS requests sent to this IP as requests under this location.
type ``zero-trust-gatewayip`` = string
type ``zero-trust-gatewayipnetworks`` = list<``zero-trust-gateway_ip_network``>
///Specify the list of CIDRs to restrict ingress connections.
type ``zero-trust-gatewayips`` = list<string>
type ``zero-trust-gatewayipv4networks`` = list<``zero-trust-gateway_ipv4_network``>
type ``zero-trust-gatewayipv6networks`` = list<``zero-trust-gateway_ipv6_network``>

type ``zero-trust-gatewayitemsArrayItem`` =
    { created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Provide the list item description (optional).
      description: Option<``zero-trust-gatewaydescriptionitem``>
      ///Specify the item value.
      value: Option<``zero-trust-gatewayvalue``> }
    ///Creates an instance of zero-trust-gatewayitemsArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayitemsArrayItem`` =
        { created_at = None
          description = None
          value = None }

type ``zero-trust-gatewayitems`` = list<``zero-trust-gatewayitemsArrayItem``>

type ``zero-trust-gatewayitems-inputArrayItem`` =
    { ///Provide the list item description (optional).
      description: Option<``zero-trust-gatewaydescriptionitem``>
      ///Specify the item value.
      value: Option<``zero-trust-gatewayvalue``> }
    ///Creates an instance of zero-trust-gatewayitems-inputArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayitems-inputArrayItem`` = { description = None; value = None }

type ``zero-trust-gatewayitems-input`` = list<``zero-trust-gatewayitems-inputArrayItem``>

type ``zero-trust-gatewaymessagesArrayItem`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaymessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaymessagesArrayItem`` =
        { code = code; message = message }

type ``zero-trust-gatewaymessages`` = list<``zero-trust-gatewaymessagesArrayItem``>
///Specify the list name.
type ``zero-trust-gatewayname`` = string
///Detailed description of the PAC file.
type ``zero-trust-gatewaypacfilescomponents-schemas-description`` = string
///Name of the PAC file.
type ``zero-trust-gatewaypacfilescomponents-schemas-name`` = string
type ``zero-trust-gatewayprecedence`` = int
///Specify the provider name (usually Cloudflare).
type ``zero-trust-gatewayprovidername`` = string
///Specify the name of the proxy endpoint.
type ``zero-trust-gatewayproxy-endpointscomponents-schemas-name`` = string
///Provide the Base64-encoded HPKE public key that encrypts SSH session logs. See https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/use-cases/ssh/ssh-infrastructure-access/#enable-ssh-command-logging.
type ``zero-trust-gatewaypublickey`` = string
type ``zero-trust-gatewayreadonly`` = bool
type ``zero-trust-gatewayreadonlytimestamp`` = System.DateTimeOffset
///Specify the rule description.
type ``zero-trust-gatewayschemas-description`` = string
type ``zero-trust-gatewayschemas-identifier`` = string
///Specify the location name.
type ``zero-trust-gatewayschemas-name`` = string
///Specify the subdomain to use as the destination in the proxy client.
type ``zero-trust-gatewayschemas-subdomain`` = string

///Specify the list type.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``zero-trust-gatewayschemas-type`` =
    | [<CompiledName "SERIAL">] SERIAL
    | [<CompiledName "URL">] URL
    | [<CompiledName "DOMAIN">] DOMAIN
    | [<CompiledName "EMAIL">] EMAIL
    | [<CompiledName "IP">] IP
    | [<CompiledName "CATEGORY">] CATEGORY
    | [<CompiledName "LOCATION">] LOCATION
    | [<CompiledName "DEVICE">] DEVICE
    member this.Format() =
        match this with
        | SERIAL -> "SERIAL"
        | URL -> "URL"
        | DOMAIN -> "DOMAIN"
        | EMAIL -> "EMAIL"
        | IP -> "IP"
        | CATEGORY -> "CATEGORY"
        | LOCATION -> "LOCATION"
        | DEVICE -> "DEVICE"

///Identify the API resource with a UUID.
type ``zero-trust-gatewayschemas-uuid`` = string
type ``zero-trust-gatewaysharable`` = bool
///URL-friendly version of the PAC file name.
type ``zero-trust-gatewayslug`` = string
///Provide the account tag of the account that created the rule.
type ``zero-trust-gatewaysourceaccount`` = string
///Specify the DNS over HTTPS domain that receives DNS requests. Gateway automatically generates this value.
type ``zero-trust-gatewaysubdomain`` = string
type ``zero-trust-gatewaytimestamp`` = System.DateTimeOffset
///Specify the wirefilter expression used for traffic matching. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
type ``zero-trust-gatewaytraffic`` = string

///Indicate the read-only certificate type, BYO-PKI (custom) or Gateway-managed.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``zero-trust-gatewaytype`` =
    | [<CompiledName "custom">] Custom
    | [<CompiledName "gateway_managed">] Gateway_managed
    member this.Format() =
        match this with
        | Custom -> "custom"
        | Gateway_managed -> "gateway_managed"

type ``zero-trust-gatewayunapprovedapps`` = list<int>
///Unique URL to download the PAC file.
type ``zero-trust-gatewayurl`` = string
///Identify the certificate with a UUID.
type ``zero-trust-gatewayuuid`` = string
///Specify the item value.
type ``zero-trust-gatewayvalue`` = string
type ``zero-trust-gatewayversion`` = int
///Indicate a warning for a misconfigured rule, if any.
type ``zero-trust-gatewaywarningstatus`` = string

type ``zero-trust-gatewayaccount-log-options`` =
    { ///Specify whether to log all requests to this service.
      log_all: Option<bool>
      ///Specify whether to log only blocking requests to this service.
      log_blocks: Option<bool> }
    ///Creates an instance of zero-trust-gatewayaccount-log-options with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayaccount-log-options`` = { log_all = None; log_blocks = None }

///Specify activity log settings.
type ``zero-trust-gatewayactivity-log-settings`` =
    { ///Specify whether to log activity.
      enabled: Option<bool> }
    ///Creates an instance of zero-trust-gatewayactivity-log-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayactivity-log-settings`` = { enabled = None }

///Specify anti-virus settings.
type ``zero-trust-gatewayanti-virus-settings`` =
    { ///Specify whether to enable anti-virus scanning on downloads.
      enabled_download_phase: Option<``zero-trust-gatewayenableddownloadphase``>
      ///Specify whether to enable anti-virus scanning on uploads.
      enabled_upload_phase: Option<``zero-trust-gatewayenableduploadphase``>
      ///Specify whether to block requests for unscannable files.
      fail_closed: Option<``zero-trust-gatewayfailclosed``>
      ///Configure the message the user's device shows during an antivirus scan.
      notification_settings: Option<``zero-trust-gatewaynotificationsettings``> }
    ///Creates an instance of zero-trust-gatewayanti-virus-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayanti-virus-settings`` =
        { enabled_download_phase = None
          enabled_upload_phase = None
          fail_closed = None
          notification_settings = None }

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

type ``zero-trust-gatewayapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``> }
    ///Creates an instance of zero-trust-gatewayapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``zero-trust-gatewayapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayapi-response-commonErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayapi-response-commonMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayapi-response-common`` =
    { errors: list<``zero-trust-gatewayapi-response-commonErrors``>
      messages: list<``zero-trust-gatewayapi-response-commonMessages``>
      ///Indicate whether the API call was successful.
      success: bool }
    ///Creates an instance of zero-trust-gatewayapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``zero-trust-gatewayapi-response-commonErrors``>,
                          messages: list<``zero-trust-gatewayapi-response-commonMessages``>,
                          success: bool): ``zero-trust-gatewayapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``zero-trust-gatewayapi-response-common-failureErrors`` = Map<string, Newtonsoft.Json.Linq.JToken>
type ``zero-trust-gatewayapi-response-common-failureMessages`` = Map<string, Newtonsoft.Json.Linq.JToken>

type ``zero-trust-gatewayapi-response-common-failure`` =
    { errors: ``zero-trust-gatewayapi-response-common-failureErrors``
      messages: ``zero-trust-gatewayapi-response-common-failureMessages``
      result: Newtonsoft.Json.Linq.JObject
      ///Indicate whether the API call was successful.
      success: bool }
    ///Creates an instance of zero-trust-gatewayapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: ``zero-trust-gatewayapi-response-common-failureErrors``,
                          messages: ``zero-trust-gatewayapi-response-common-failureMessages``,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``zero-trust-gatewayapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``zero-trust-gatewayapi-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayapi-response-singleErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayapi-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayapi-response-singleMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayapi-response-single`` =
    { errors: Option<list<``zero-trust-gatewayapi-response-singleErrors``>>
      messages: Option<list<``zero-trust-gatewayapi-response-singleMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of zero-trust-gatewayapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayapi-response-single`` =
        { errors = None
          messages = None
          success = None }

type ``zero-trust-gatewayapp-typescomponents-schemas-responsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayapp-typescomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayapp-typescomponents-schemas-responsecollectionErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayapp-typescomponents-schemas-responsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayapp-typescomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayapp-typescomponents-schemas-responsecollectionMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayapp-typescomponents-schemas-responsecollection`` =
    { errors: Option<list<``zero-trust-gatewayapp-typescomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``zero-trust-gatewayapp-typescomponents-schemas-responsecollectionMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``>
      result: Option<list<``zero-trust-gatewayapp-types``>> }
    ///Creates an instance of zero-trust-gatewayapp-typescomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayapp-typescomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``zero-trust-gatewayapplication`` =
    { ///Identify the type of this application. Multiple applications can share the same type. Refers to the `id` of a returned application type.
      application_type_id: Option<``zero-trust-gatewayapptypeid``>
      created_at: Option<``zero-trust-gatewaytimestamp``>
      ///Identify this application. Only one application per ID.
      id: Option<``zero-trust-gatewayappid``>
      ///Specify the name of the application or application type.
      name: Option<``zero-trust-gatewayapp-typescomponents-schemas-name``> }
    ///Creates an instance of zero-trust-gatewayapplication with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayapplication`` =
        { application_type_id = None
          created_at = None
          id = None
          name = None }

type ``zero-trust-gatewayapplicationtype`` =
    { created_at: Option<``zero-trust-gatewaytimestamp``>
      ///Provide a short summary of applications with this type.
      description: Option<string>
      ///Identify the type of this application. Multiple applications can share the same type. Refers to the `id` of a returned application type.
      id: Option<``zero-trust-gatewayapptypeid``>
      ///Specify the name of the application or application type.
      name: Option<``zero-trust-gatewayapp-typescomponents-schemas-name``> }
    ///Creates an instance of zero-trust-gatewayapplicationtype with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayapplicationtype`` =
        { created_at = None
          description = None
          id = None
          name = None }

type ``zero-trust-gatewayapplicationsreviewstatusresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayapplicationsreviewstatusresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayapplicationsreviewstatusresponseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayapplicationsreviewstatusresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayapplicationsreviewstatusresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayapplicationsreviewstatusresponseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayapplicationsreviewstatusresponse`` =
    { errors: Option<list<``zero-trust-gatewayapplicationsreviewstatusresponseErrors``>>
      messages: Option<list<``zero-trust-gatewayapplicationsreviewstatusresponseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewayapplicationsreviewstatusresponsecontent``> }
    ///Creates an instance of zero-trust-gatewayapplicationsreviewstatusresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayapplicationsreviewstatusresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``zero-trust-gatewayapplicationsreviewstatusresponsecontent`` =
    { ///Contains the ids of the approved applications.
      approved_apps: Option<``zero-trust-gatewayapprovedapps``>
      created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Contains the ids of the applications in review.
      in_review_apps: Option<``zero-trust-gatewayinreviewapps``>
      ///Contains the ids of the unapproved applications.
      unapproved_apps: Option<``zero-trust-gatewayunapprovedapps``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``> }
    ///Creates an instance of zero-trust-gatewayapplicationsreviewstatusresponsecontent with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayapplicationsreviewstatusresponsecontent`` =
        { approved_apps = None
          created_at = None
          in_review_apps = None
          unapproved_apps = None
          updated_at = None }

type ``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponse`` =
    { errors: Option<list<``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponseErrors``>>
      messages: Option<list<``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewaysettings``> }
    ///Creates an instance of zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Mode =
    | [<CompiledName "">] EmptyString
    | [<CompiledName "customized_block_page">] Customized_block_page
    | [<CompiledName "redirect_uri">] Redirect_uri
    member this.Format() =
        match this with
        | EmptyString -> ""
        | Customized_block_page -> "customized_block_page"
        | Redirect_uri -> "redirect_uri"

///Specify block page layout settings.
type ``zero-trust-gatewayblock-page-settings`` =
    { ///Specify the block page background color in `#rrggbb` format when the mode is customized_block_page.
      background_color: Option<string>
      ///Specify whether to enable the custom block page.
      enabled: Option<bool>
      ///Specify the block page footer text when the mode is customized_block_page.
      footer_text: Option<string>
      ///Specify the block page header text when the mode is customized_block_page.
      header_text: Option<string>
      ///Specify whether to append context to target_uri as query parameters. This applies only when the mode is redirect_uri.
      include_context: Option<bool>
      ///Specify the full URL to the logo file when the mode is customized_block_page.
      logo_path: Option<string>
      ///Specify the admin email for users to contact when the mode is customized_block_page.
      mailto_address: Option<string>
      ///Specify the subject line for emails created from the block page when the mode is customized_block_page.
      mailto_subject: Option<string>
      ///Specify whether to redirect users to a Cloudflare-hosted block page or a customer-provided URI.
      mode: Option<Mode>
      ///Specify the block page title when the mode is customized_block_page.
      name: Option<string>
      ///Indicate that this setting was shared via the Orgs API and read only for the current account.
      read_only: Option<bool>
      ///Indicate the account tag of the account that shared this setting.
      source_account: Option<string>
      ///Specify whether to suppress detailed information at the bottom of the block page when the mode is customized_block_page.
      suppress_footer: Option<bool>
      ///Specify the URI to redirect users to when the mode is redirect_uri.
      target_uri: Option<string>
      ///Indicate the version number of the setting.
      version: Option<int> }
    ///Creates an instance of zero-trust-gatewayblock-page-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayblock-page-settings`` =
        { background_color = None
          enabled = None
          footer_text = None
          header_text = None
          include_context = None
          logo_path = None
          mailto_address = None
          mailto_subject = None
          mode = None
          name = None
          read_only = None
          source_account = None
          suppress_footer = None
          target_uri = None
          version = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Inspectionmode =
    | [<CompiledName "deep">] Deep
    | [<CompiledName "shallow">] Shallow
    member this.Format() =
        match this with
        | Deep -> "deep"
        | Shallow -> "shallow"

///Specify the DLP inspection mode.
type ``zero-trust-gatewaybody-scanning-settings`` =
    { ///Specify the inspection mode as either `deep` or `shallow`.
      inspection_mode: Option<Inspectionmode> }
    ///Creates an instance of zero-trust-gatewaybody-scanning-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaybody-scanning-settings`` = { inspection_mode = None }

///Specify Clientless Browser Isolation settings.
type ``zero-trust-gatewaybrowser-isolation-settings`` =
    { ///Specify whether to enable non-identity onramp support for Browser Isolation.
      non_identity_enabled: Option<bool>
      ///Specify whether to enable Clientless Browser Isolation.
      url_browser_isolation_enabled: Option<bool> }
    ///Creates an instance of zero-trust-gatewaybrowser-isolation-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaybrowser-isolation-settings`` =
        { non_identity_enabled = None
          url_browser_isolation_enabled = None }

type ``zero-trust-gatewaycategories`` =
    { ///Indicate whether the category is in beta and subject to change.
      beta: Option<``zero-trust-gatewaybeta``>
      ///Specify which account types can create policies for this category. `blocked` Blocks unconditionally for all accounts. `removalPending` Allows removal from policies but disables addition. `noBlock` Prevents blocking.
      ``class``: Option<``zero-trust-gatewayclass``>
      ///Provide a short summary of domains in the category.
      description: Option<``zero-trust-gatewaycomponents-schemas-description``>
      ///Identify this category. Only one category per ID.
      id: Option<``zero-trust-gatewayid``>
      ///Specify the category name.
      name: Option<``zero-trust-gatewaycategoriescomponents-schemas-name``>
      ///Provide all subcategories for this category.
      subcategories: Option<list<``zero-trust-gatewaysubcategory``>> }
    ///Creates an instance of zero-trust-gatewaycategories with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaycategories`` =
        { beta = None
          ``class`` = None
          description = None
          id = None
          name = None
          subcategories = None }

type ``zero-trust-gatewaycategoriescomponents-schemas-responsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaycategoriescomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaycategoriescomponents-schemas-responsecollectionErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaycategoriescomponents-schemas-responsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaycategoriescomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaycategoriescomponents-schemas-responsecollectionMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewaycategoriescomponents-schemas-responsecollection`` =
    { errors: Option<list<``zero-trust-gatewaycategoriescomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``zero-trust-gatewaycategoriescomponents-schemas-responsecollectionMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``>
      result: Option<list<``zero-trust-gatewaycategories``>> }
    ///Creates an instance of zero-trust-gatewaycategoriescomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaycategoriescomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

///Specify certificate settings for Gateway TLS interception. If unset, the Cloudflare Root CA handles interception.
type ``zero-trust-gatewaycertificate-settings`` =
    { ///Specify the UUID of the certificate used for interception. Ensure the certificate is available at the edge(previously called 'active'). A nil UUID directs Cloudflare to use the Root CA.
      id: string }
    ///Creates an instance of zero-trust-gatewaycertificate-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): ``zero-trust-gatewaycertificate-settings`` = { id = id }

type ``zero-trust-gatewaycertificates`` =
    { ///Indicate the read-only deployment status of the certificate on Cloudflare's edge. Gateway TLS interception can use certificates in the 'available' (previously called 'active') state.
      binding_status: Option<``zero-trust-gatewaybindingstatus``>
      ///Provide the CA certificate (read-only).
      certificate: Option<string>
      created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      expires_on: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Provide the SHA256 fingerprint of the certificate (read-only).
      fingerprint: Option<string>
      ///Identify the certificate with a UUID.
      id: Option<``zero-trust-gatewayuuid``>
      ///Indicate whether Gateway TLS interception uses this certificate (read-only). You cannot set this value directly. To configure interception, use the Gateway configuration setting named `certificate` (read-only).
      in_use: Option<bool>
      ///Indicate the organization that issued the certificate (read-only).
      issuer_org: Option<string>
      ///Provide the entire issuer field of the certificate (read-only).
      issuer_raw: Option<string>
      ///Indicate the read-only certificate type, BYO-PKI (custom) or Gateway-managed.
      ``type``: Option<``zero-trust-gatewaytype``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      uploaded_on: Option<``zero-trust-gatewayreadonlytimestamp``> }
    ///Creates an instance of zero-trust-gatewaycertificates with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaycertificates`` =
        { binding_status = None
          certificate = None
          created_at = None
          expires_on = None
          fingerprint = None
          id = None
          in_use = None
          issuer_org = None
          issuer_raw = None
          ``type`` = None
          updated_at = None
          uploaded_on = None }

type ``zero-trust-gatewaycomponents-schemas-responsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaycomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaycomponents-schemas-responsecollectionErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaycomponents-schemas-responsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaycomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaycomponents-schemas-responsecollectionMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewaycomponents-schemas-responsecollection`` =
    { errors: Option<list<``zero-trust-gatewaycomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``zero-trust-gatewaycomponents-schemas-responsecollectionMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``>
      result: Option<list<``zero-trust-gatewaylocations``>> }
    ///Creates an instance of zero-trust-gatewaycomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaycomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``zero-trust-gatewaycomponents-schemas-singleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaycomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaycomponents-schemas-singleresponseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaycomponents-schemas-singleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaycomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaycomponents-schemas-singleresponseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewaycomponents-schemas-singleresponse`` =
    { errors: Option<list<``zero-trust-gatewaycomponents-schemas-singleresponseErrors``>>
      messages: Option<list<``zero-trust-gatewaycomponents-schemas-singleresponseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewayrules``> }
    ///Creates an instance of zero-trust-gatewaycomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaycomponents-schemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

///Specify custom certificate settings for BYO-PKI. This field is deprecated; use `certificate` instead.
type ``zero-trust-gatewaycustom-certificate-settings`` =
    { ///Indicate the internal certificate status.
      binding_status: Option<string>
      ///Specify whether to enable a custom certificate authority for signing Gateway traffic.
      enabled: bool
      ///Specify the UUID of the certificate (ID from MTLS certificate store).
      id: Option<string>
      updated_at: Option<System.DateTimeOffset> }
    ///Creates an instance of zero-trust-gatewaycustom-certificate-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool): ``zero-trust-gatewaycustom-certificate-settings`` =
        { binding_status = None
          enabled = enabled
          id = None
          updated_at = None }

type ``zero-trust-gatewaydnsresolversettingsv4`` =
    { ///Specify the IPv4 address of the upstream resolver.
      ip: string
      ///Specify a port number to use for the upstream resolver. Defaults to 53 if unspecified.
      port: Option<int>
      ///Indicate whether to connect to this resolver over a private network. Must set when vnet_id set.
      route_through_private_network: Option<bool>
      ///Specify an optional virtual network for this resolver. Uses default virtual network id if omitted.
      vnet_id: Option<string> }
    ///Creates an instance of zero-trust-gatewaydnsresolversettingsv4 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ip: string): ``zero-trust-gatewaydnsresolversettingsv4`` =
        { ip = ip
          port = None
          route_through_private_network = None
          vnet_id = None }

type ``zero-trust-gatewaydnsresolversettingsv6`` =
    { ///Specify the IPv6 address of the upstream resolver.
      ip: string
      ///Specify a port number to use for the upstream resolver. Defaults to 53 if unspecified.
      port: Option<int>
      ///Indicate whether to connect to this resolver over a private network. Must set when vnet_id set.
      route_through_private_network: Option<bool>
      ///Specify an optional virtual network for this resolver. Uses default virtual network id if omitted.
      vnet_id: Option<string> }
    ///Creates an instance of zero-trust-gatewaydnsresolversettingsv6 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ip: string): ``zero-trust-gatewaydnsresolversettingsv6`` =
        { ip = ip
          port = None
          route_through_private_network = None
          vnet_id = None }

type ``zero-trust-gatewaydohendpoint`` =
    { ///Indicate whether the DOH endpoint is enabled for this location.
      enabled: Option<bool>
      ///Specify the list of allowed source IP network ranges for this endpoint. When the list is empty, the endpoint allows all source IPs. The list takes effect only if the endpoint is enabled for this location.
      networks: Option<``zero-trust-gatewayipnetworks``>
      ///Specify whether the DOH endpoint requires user identity authentication.
      require_token: Option<bool> }
    ///Creates an instance of zero-trust-gatewaydohendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaydohendpoint`` =
        { enabled = None
          networks = None
          require_token = None }

type ``zero-trust-gatewaydotendpoint`` =
    { ///Indicate whether the DOT endpoint is enabled for this location.
      enabled: Option<bool>
      ///Specify the list of allowed source IP network ranges for this endpoint. When the list is empty, the endpoint allows all source IPs. The list takes effect only if the endpoint is enabled for this location.
      networks: Option<``zero-trust-gatewayipnetworks``> }
    ///Creates an instance of zero-trust-gatewaydotendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaydotendpoint`` = { enabled = None; networks = None }

type ``zero-trust-gatewayemptyresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayemptyresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayemptyresponseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayemptyresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayemptyresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayemptyresponseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayemptyresponse`` =
    { errors: Option<list<``zero-trust-gatewayemptyresponseErrors``>>
      messages: Option<list<``zero-trust-gatewayemptyresponseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of zero-trust-gatewayemptyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayemptyresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

///Configure the destination endpoints for this location.
type ``zero-trust-gatewayendpoints`` =
    { doh: ``zero-trust-gatewaydohendpoint``
      dot: ``zero-trust-gatewaydotendpoint``
      ipv4: ``zero-trust-gatewayipv4endpoint``
      ipv6: ``zero-trust-gatewayipv6endpoint`` }
    ///Creates an instance of zero-trust-gatewayendpoints with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (doh: ``zero-trust-gatewaydohendpoint``,
                          dot: ``zero-trust-gatewaydotendpoint``,
                          ipv4: ``zero-trust-gatewayipv4endpoint``,
                          ipv6: ``zero-trust-gatewayipv6endpoint``): ``zero-trust-gatewayendpoints`` =
        { doh = doh
          dot = dot
          ipv4 = ipv4
          ipv6 = ipv6 }

///Defines the expiration time stamp and default duration of a DNS policy. Takes precedence over the policy's `schedule` configuration, if any. This  does not apply to HTTP or network policies. Settable only for `dns` rules.
type ``zero-trust-gatewayexpiration`` =
    { ///Defines the default duration a policy active in minutes. Must set in order to use the `reset_expiration` endpoint on this rule.
      duration: Option<int>
      ///Indicates whether the policy is expired.
      expired: Option<bool>
      expires_at: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of zero-trust-gatewayexpiration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (expires_at: Newtonsoft.Json.Linq.JToken): ``zero-trust-gatewayexpiration`` =
        { duration = None
          expired = None
          expires_at = expires_at }

///Configures user email settings for firewall policies. When you enable this, the system standardizes email addresses in the identity portion of the rule to match extended email variants in firewall policies. When you disable this setting, the system matches email addresses exactly as you provide them. Enable this setting if your email uses `.` or `+` modifiers.
type ``zero-trust-gatewayextended-email-matching`` =
    { ///Specify whether to match all variants of user emails (with + or . modifiers) used as criteria in Firewall policies.
      enabled: Option<bool>
      ///Indicate that this setting was shared via the Orgs API and read only for the current account.
      read_only: Option<bool>
      ///Indicate the account tag of the account that shared this setting.
      source_account: Option<string>
      ///Indicate the version number of the setting.
      version: Option<int> }
    ///Creates an instance of zero-trust-gatewayextended-email-matching with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayextended-email-matching`` =
        { enabled = None
          read_only = None
          source_account = None
          version = None }

///Specify FIPS settings.
type ``zero-trust-gatewayfips-settings`` =
    { ///Enforce cipher suites and TLS versions compliant with FIPS 140-2.
      tls: Option<bool> }
    ///Creates an instance of zero-trust-gatewayfips-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayfips-settings`` = { tls = None }

///Configure logging settings for each rule type.
type Settingsbyruletype =
    { ///Configure logging settings for DNS firewall.
      dns: Option<Newtonsoft.Json.Linq.JToken>
      ///Configure logging settings for HTTP/HTTPS firewall.
      http: Option<Newtonsoft.Json.Linq.JToken>
      ///Configure logging settings for Network firewall.
      l4: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of Settingsbyruletype with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Settingsbyruletype = { dns = None; http = None; l4 = None }

type ``zero-trust-gatewaygateway-account-logging-settings`` =
    { ///Indicate whether to redact personally identifiable information from activity logging (PII fields include source IP, user email, user ID, device ID, URL, referrer, and user agent).
      redact_pii: Option<bool>
      ///Configure logging settings for each rule type.
      settings_by_rule_type: Option<Settingsbyruletype> }
    ///Creates an instance of zero-trust-gatewaygateway-account-logging-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaygateway-account-logging-settings`` =
        { redact_pii = None
          settings_by_rule_type = None }

type ``zero-trust-gatewaygateway-account-logging-settings-responseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaygateway-account-logging-settings-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaygateway-account-logging-settings-responseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaygateway-account-logging-settings-responseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaygateway-account-logging-settings-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaygateway-account-logging-settings-responseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewaygateway-account-logging-settings-response`` =
    { errors: Option<list<``zero-trust-gatewaygateway-account-logging-settings-responseErrors``>>
      messages: Option<list<``zero-trust-gatewaygateway-account-logging-settings-responseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewaygateway-account-logging-settings``> }
    ///Creates an instance of zero-trust-gatewaygateway-account-logging-settings-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaygateway-account-logging-settings-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

///Specify account settings.
type Settings =
    { ///Specify activity log settings.
      activity_log: Option<``zero-trust-gatewayactivity-log-settings``>
      ///Specify anti-virus settings.
      antivirus: Option<``zero-trust-gatewayanti-virus-settings``>
      ///Specify block page layout settings.
      block_page: Option<``zero-trust-gatewayblock-page-settings``>
      ///Specify the DLP inspection mode.
      body_scanning: Option<``zero-trust-gatewaybody-scanning-settings``>
      ///Specify Clientless Browser Isolation settings.
      browser_isolation: Option<``zero-trust-gatewaybrowser-isolation-settings``>
      ///Specify certificate settings for Gateway TLS interception. If unset, the Cloudflare Root CA handles interception.
      certificate: Option<``zero-trust-gatewaycertificate-settings``>
      ///Configures user email settings for firewall policies. When you enable this, the system standardizes email addresses in the identity portion of the rule to match extended email variants in firewall policies. When you disable this setting, the system matches email addresses exactly as you provide them. Enable this setting if your email uses `.` or `+` modifiers.
      extended_email_matching: Option<``zero-trust-gatewayextended-email-matching``>
      ///Specify FIPS settings.
      fips: Option<``zero-trust-gatewayfips-settings``>
      ///Enable host selection in egress policies.
      host_selector: Option<``zero-trust-gatewayhost-selector-settings``>
      ///Define the proxy inspection mode.
      inspection: Option<``zero-trust-gatewayinspection-settings``>
      ///Specify whether to detect protocols from the initial bytes of client traffic.
      protocol_detection: Option<``zero-trust-gatewayprotocol-detection``>
      ///Specify whether to enable the sandbox.
      sandbox: Option<``zero-trust-gatewaysandbox``>
      ///Specify whether to inspect encrypted HTTP traffic.
      tls_decrypt: Option<``zero-trust-gatewaytls-settings``> }
    ///Creates an instance of Settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Settings =
        { activity_log = None
          antivirus = None
          block_page = None
          body_scanning = None
          browser_isolation = None
          certificate = None
          extended_email_matching = None
          fips = None
          host_selector = None
          inspection = None
          protocol_detection = None
          sandbox = None
          tls_decrypt = None }

///Specify account settings.
type ``zero-trust-gatewaygateway-account-settings`` =
    { ///Specify account settings.
      settings: Option<Settings> }
    ///Creates an instance of zero-trust-gatewaygateway-account-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaygateway-account-settings`` = { settings = None }

type ``zero-trust-gatewaygatewayaccountErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaygatewayaccountErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaygatewayaccountErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaygatewayaccountMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaygatewayaccountMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaygatewayaccountMessages`` =
        { code = code; message = message }

type Result =
    { ///Specify the gateway internal ID.
      gateway_tag: Option<``zero-trust-gatewaygatewaytag``>
      ///Specify the Cloudflare account ID.
      id: Option<``zero-trust-gatewaycfaccountid``>
      ///Specify the provider name (usually Cloudflare).
      provider_name: Option<``zero-trust-gatewayprovidername``> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result =
        { gateway_tag = None
          id = None
          provider_name = None }

type ``zero-trust-gatewaygatewayaccount`` =
    { errors: Option<list<``zero-trust-gatewaygatewayaccountErrors``>>
      messages: Option<list<``zero-trust-gatewaygatewayaccountMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<Result> }
    ///Creates an instance of zero-trust-gatewaygatewayaccount with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaygatewayaccount`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``zero-trust-gatewaygatewayaccountconfigErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaygatewayaccountconfigErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaygatewayaccountconfigErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaygatewayaccountconfigMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaygatewayaccountconfigMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaygatewayaccountconfigMessages`` =
        { code = code; message = message }

///Specify account settings.
type ``zero-trust-gatewaygatewayaccountconfigResultSettings`` =
    { ///Specify activity log settings.
      activity_log: Option<``zero-trust-gatewayactivity-log-settings``>
      ///Specify anti-virus settings.
      antivirus: Option<``zero-trust-gatewayanti-virus-settings``>
      ///Specify block page layout settings.
      block_page: Option<``zero-trust-gatewayblock-page-settings``>
      ///Specify the DLP inspection mode.
      body_scanning: Option<``zero-trust-gatewaybody-scanning-settings``>
      ///Specify Clientless Browser Isolation settings.
      browser_isolation: Option<``zero-trust-gatewaybrowser-isolation-settings``>
      ///Specify certificate settings for Gateway TLS interception. If unset, the Cloudflare Root CA handles interception.
      certificate: Option<``zero-trust-gatewaycertificate-settings``>
      ///Configures user email settings for firewall policies. When you enable this, the system standardizes email addresses in the identity portion of the rule to match extended email variants in firewall policies. When you disable this setting, the system matches email addresses exactly as you provide them. Enable this setting if your email uses `.` or `+` modifiers.
      extended_email_matching: Option<``zero-trust-gatewayextended-email-matching``>
      ///Specify FIPS settings.
      fips: Option<``zero-trust-gatewayfips-settings``>
      ///Enable host selection in egress policies.
      host_selector: Option<``zero-trust-gatewayhost-selector-settings``>
      ///Define the proxy inspection mode.
      inspection: Option<``zero-trust-gatewayinspection-settings``>
      ///Specify whether to detect protocols from the initial bytes of client traffic.
      protocol_detection: Option<``zero-trust-gatewayprotocol-detection``>
      ///Specify whether to enable the sandbox.
      sandbox: Option<``zero-trust-gatewaysandbox``>
      ///Specify whether to inspect encrypted HTTP traffic.
      tls_decrypt: Option<``zero-trust-gatewaytls-settings``> }
    ///Creates an instance of zero-trust-gatewaygatewayaccountconfigResultSettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaygatewayaccountconfigResultSettings`` =
        { activity_log = None
          antivirus = None
          block_page = None
          body_scanning = None
          browser_isolation = None
          certificate = None
          extended_email_matching = None
          fips = None
          host_selector = None
          inspection = None
          protocol_detection = None
          sandbox = None
          tls_decrypt = None }

type ``zero-trust-gatewaygatewayaccountconfigResult`` =
    { ///Specify account settings.
      settings: Option<``zero-trust-gatewaygatewayaccountconfigResultSettings``>
      created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``> }
    ///Creates an instance of zero-trust-gatewaygatewayaccountconfigResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaygatewayaccountconfigResult`` =
        { settings = None
          created_at = None
          updated_at = None }

type ``zero-trust-gatewaygatewayaccountconfig`` =
    { errors: Option<list<``zero-trust-gatewaygatewayaccountconfigErrors``>>
      messages: Option<list<``zero-trust-gatewaygatewayaccountconfigMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewaygatewayaccountconfigResult``> }
    ///Creates an instance of zero-trust-gatewaygatewayaccountconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaygatewayaccountconfig`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``zero-trust-gatewaygenerate-cert-request`` =
    { ///Sets the certificate validity period in days (range: 1-10,950 days / ~30 years). Defaults to 1,825 days (5 years). **Important**: This field is only settable during the certificate creation.  Certificates becomes immutable after creation - use the `/activate` and `/deactivate` endpoints to manage certificate lifecycle.
      validity_period_days: Option<int> }
    ///Creates an instance of zero-trust-gatewaygenerate-cert-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaygenerate-cert-request`` = { validity_period_days = None }

///Enable host selection in egress policies.
type ``zero-trust-gatewayhost-selector-settings`` =
    { ///Specify whether to enable filtering via hosts for egress policies.
      enabled: Option<bool> }
    ///Creates an instance of zero-trust-gatewayhost-selector-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayhost-selector-settings`` = { enabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``zero-trust-gatewayinspection-settingsMode`` =
    | [<CompiledName "static">] Static
    | [<CompiledName "dynamic">] Dynamic
    member this.Format() =
        match this with
        | Static -> "static"
        | Dynamic -> "dynamic"

///Define the proxy inspection mode.
type ``zero-trust-gatewayinspection-settings`` =
    { ///Define the proxy inspection mode.   1. static: Gateway applies static inspection to HTTP on TCP(80). With TLS decryption on, Gateway inspects HTTPS traffic on TCP(443) and UDP(443).   2. dynamic: Gateway applies protocol detection to inspect HTTP and HTTPS traffic on any port. TLS decryption must remain on to inspect HTTPS traffic.
      mode: Option<``zero-trust-gatewayinspection-settingsMode``> }
    ///Creates an instance of zero-trust-gatewayinspection-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayinspection-settings`` = { mode = None }

type ``zero-trust-gatewayipnetwork`` =
    { ///Specify the IP address or IP CIDR.
      network: string }
    ///Creates an instance of zero-trust-gatewayipnetwork with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (network: string): ``zero-trust-gatewayipnetwork`` = { network = network }

type ``zero-trust-gatewayipv4endpoint`` =
    { ///Indicate whether the IPv4 endpoint is enabled for this location.
      enabled: Option<bool> }
    ///Creates an instance of zero-trust-gatewayipv4endpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayipv4endpoint`` = { enabled = None }

type ``zero-trust-gatewayipv4network`` =
    { ///Specify the IPv4 address or IPv4 CIDR. Limit IPv4 CIDRs to a maximum of /24.
      network: string }
    ///Creates an instance of zero-trust-gatewayipv4network with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (network: string): ``zero-trust-gatewayipv4network`` = { network = network }

type ``zero-trust-gatewayipv6endpoint`` =
    { ///Indicate whether the IPV6 endpoint is enabled for this location.
      enabled: Option<bool>
      ///Specify the list of allowed source IPv6 network ranges for this endpoint. When the list is empty, the endpoint allows all source IPs. The list takes effect only if the endpoint is enabled for this location.
      networks: Option<``zero-trust-gatewayipv6networks``> }
    ///Creates an instance of zero-trust-gatewayipv6endpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayipv6endpoint`` = { enabled = None; networks = None }

type ``zero-trust-gatewayipv6network`` =
    { ///Specify the IPv6 address or IPv6 CIDR.
      network: string }
    ///Creates an instance of zero-trust-gatewayipv6network with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (network: string): ``zero-trust-gatewayipv6network`` = { network = network }

type ``zero-trust-gatewaylistitemresponsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaylistitemresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaylistitemresponsecollectionErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaylistitemresponsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaylistitemresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaylistitemresponsecollectionMessages`` =
        { code = code; message = message }

type Resultinfo =
    { ///Shows the total results returned based on your search parameters.
      count: Option<float>
      ///Show the current page within paginated list of results.
      page: Option<float>
      ///Show the number of results per page of results.
      per_page: Option<float>
      ///Show the total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``zero-trust-gatewaylistitemresponsecollection`` =
    { errors: Option<list<``zero-trust-gatewaylistitemresponsecollectionErrors``>>
      messages: Option<list<``zero-trust-gatewaylistitemresponsecollectionMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``>
      result: Option<list<``zero-trust-gatewayitems``>> }
    ///Creates an instance of zero-trust-gatewaylistitemresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaylistitemresponsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``zero-trust-gatewaylistsingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaylistsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaylistsingleresponseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaylistsingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaylistsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaylistsingleresponseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewaylistsingleresponse`` =
    { errors: Option<list<``zero-trust-gatewaylistsingleresponseErrors``>>
      messages: Option<list<``zero-trust-gatewaylistsingleresponseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewaylists``> }
    ///Creates an instance of zero-trust-gatewaylistsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaylistsingleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type Items =
    { created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Provide the list item description (optional).
      description: Option<``zero-trust-gatewaydescriptionitem``>
      ///Specify the item value.
      value: Option<``zero-trust-gatewayvalue``> }
    ///Creates an instance of Items with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Items =
        { created_at = None
          description = None
          value = None }

type ``zero-trust-gatewaylists`` =
    { ///Indicate the number of items in the list.
      count: Option<``zero-trust-gatewaycount``>
      created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Provide the list description.
      description: Option<``zero-trust-gatewaydescription``>
      ///Identify the API resource with a UUID.
      id: Option<``zero-trust-gatewayschemas-uuid``>
      ///Provide the list items.
      items: Option<list<Items>>
      ///Specify the list name.
      name: Option<``zero-trust-gatewayname``>
      ///Specify the list type.
      ``type``: Option<``zero-trust-gatewayschemas-type``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``> }
    ///Creates an instance of zero-trust-gatewaylists with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaylists`` =
        { count = None
          created_at = None
          description = None
          id = None
          items = None
          name = None
          ``type`` = None
          updated_at = None }

type ``zero-trust-gatewaylocations`` =
    { ///Indicate whether this location is the default location.
      client_default: Option<``zero-trust-gatewayclient-default``>
      created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Indicate the identifier of the pair of IPv4 addresses assigned to this location.
      dns_destination_ips_id: Option<``zero-trust-gatewaydns-destination-ips-id-read``>
      ///Specify the UUID of the IPv6 block brought to the gateway so that this location's IPv6 address is allocated from the Bring Your Own IPv6 (BYOIPv6) block rather than the standard Cloudflare IPv6 block.
      dns_destination_ipv6_block_id: Option<``zero-trust-gatewaydnsdestinationipv6blockid``>
      ///Specify the DNS over HTTPS domain that receives DNS requests. Gateway automatically generates this value.
      doh_subdomain: Option<``zero-trust-gatewaysubdomain``>
      ///Indicate whether the location must resolve EDNS queries.
      ecs_support: Option<``zero-trust-gatewayecs-support``>
      ///Configure the destination endpoints for this location.
      endpoints: Option<``zero-trust-gatewayendpoints``>
      id: Option<``zero-trust-gatewaycomponents-schemas-uuid``>
      ///Defines the automatically generated IPv6 destination IP assigned to this location. Gateway counts all DNS requests sent to this IP as requests under this location.
      ip: Option<``zero-trust-gatewayip``>
      ///Show the primary destination IPv4 address from the pair identified dns_destination_ips_id. This field read-only.
      ipv4_destination: Option<string>
      ///Show the backup destination IPv4 address from the pair identified dns_destination_ips_id. This field read-only.
      ipv4_destination_backup: Option<string>
      ///Specify the location name.
      name: Option<``zero-trust-gatewayschemas-name``>
      ///Specify the list of network ranges from which requests at this location originate. The list takes effect only if it is non-empty and the IPv4 endpoint is enabled for this location.
      networks: Option<``zero-trust-gatewayipv4networks``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``> }
    ///Creates an instance of zero-trust-gatewaylocations with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaylocations`` =
        { client_default = None
          created_at = None
          dns_destination_ips_id = None
          dns_destination_ipv6_block_id = None
          doh_subdomain = None
          ecs_support = None
          endpoints = None
          id = None
          ip = None
          ipv4_destination = None
          ipv4_destination_backup = None
          name = None
          networks = None
          updated_at = None }

///Configure the message the user's device shows during an antivirus scan.
type ``zero-trust-gatewaynotificationsettings`` =
    { ///Specify whether to enable notifications.
      enabled: Option<bool>
      ///Specify whether to include context information as query parameters.
      include_context: Option<bool>
      ///Specify the message to show in the notification.
      msg: Option<string>
      ///Specify a URL that directs users to more information. If unset, the notification opens a block page.
      support_url: Option<string> }
    ///Creates an instance of zero-trust-gatewaynotificationsettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaynotificationsettings`` =
        { enabled = None
          include_context = None
          msg = None
          support_url = None }

type ``zero-trust-gatewaypacfile`` =
    { ///Actual contents of the PAC file
      contents: Option<``zero-trust-gatewaycontents``>
      created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Detailed description of the PAC file.
      description: Option<``zero-trust-gatewaypacfilescomponents-schemas-description``>
      id: Option<``zero-trust-gatewaycomponents-schemas-uuid``>
      ///Name of the PAC file.
      name: Option<``zero-trust-gatewaypacfilescomponents-schemas-name``>
      ///URL-friendly version of the PAC file name.
      slug: Option<``zero-trust-gatewayslug``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Unique URL to download the PAC file.
      url: Option<``zero-trust-gatewayurl``> }
    ///Creates an instance of zero-trust-gatewaypacfile with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaypacfile`` =
        { contents = None
          created_at = None
          description = None
          id = None
          name = None
          slug = None
          updated_at = None
          url = None }

type ``zero-trust-gatewaypacfilescomponents-schemas-responsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaypacfilescomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaypacfilescomponents-schemas-responsecollectionErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaypacfilescomponents-schemas-responsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaypacfilescomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaypacfilescomponents-schemas-responsecollectionMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewaypacfilescomponents-schemas-responsecollectionResult`` =
    { created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Detailed description of the PAC file.
      description: Option<``zero-trust-gatewaypacfilescomponents-schemas-description``>
      id: Option<``zero-trust-gatewaycomponents-schemas-uuid``>
      ///Name of the PAC file.
      name: Option<``zero-trust-gatewaypacfilescomponents-schemas-name``>
      ///URL-friendly version of the PAC file name.
      slug: Option<``zero-trust-gatewayslug``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Unique URL to download the PAC file.
      url: Option<``zero-trust-gatewayurl``> }
    ///Creates an instance of zero-trust-gatewaypacfilescomponents-schemas-responsecollectionResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaypacfilescomponents-schemas-responsecollectionResult`` =
        { created_at = None
          description = None
          id = None
          name = None
          slug = None
          updated_at = None
          url = None }

type ``zero-trust-gatewaypacfilescomponents-schemas-responsecollection`` =
    { errors: Option<list<``zero-trust-gatewaypacfilescomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``zero-trust-gatewaypacfilescomponents-schemas-responsecollectionMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``>
      result: Option<list<``zero-trust-gatewaypacfilescomponents-schemas-responsecollectionResult``>> }
    ///Creates an instance of zero-trust-gatewaypacfilescomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaypacfilescomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``zero-trust-gatewaypacfilescomponents-schemas-singleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaypacfilescomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaypacfilescomponents-schemas-singleresponseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaypacfilescomponents-schemas-singleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaypacfilescomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaypacfilescomponents-schemas-singleresponseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewaypacfilescomponents-schemas-singleresponse`` =
    { errors: Option<list<``zero-trust-gatewaypacfilescomponents-schemas-singleresponseErrors``>>
      messages: Option<list<``zero-trust-gatewaypacfilescomponents-schemas-singleresponseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewaypacfile``> }
    ///Creates an instance of zero-trust-gatewaypacfilescomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaypacfilescomponents-schemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

///Specify whether to detect protocols from the initial bytes of client traffic.
type ``zero-trust-gatewayprotocol-detection`` =
    { ///Specify whether to detect protocols from the initial bytes of client traffic.
      enabled: Option<bool> }
    ///Creates an instance of zero-trust-gatewayprotocol-detection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayprotocol-detection`` = { enabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Kind =
    | [<CompiledName "identity">] Identity
    member this.Format() =
        match this with
        | Identity -> "identity"

type ``zero-trust-gatewayproxy-endpoint-identity`` =
    { created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      id: Option<``zero-trust-gatewaycomponents-schemas-uuid``>
      ///The proxy endpoint kind
      kind: Kind
      ///Specify the name of the proxy endpoint.
      name: ``zero-trust-gatewayproxy-endpointscomponents-schemas-name``
      ///Specify the subdomain to use as the destination in the proxy client.
      subdomain: Option<``zero-trust-gatewayschemas-subdomain``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``> }
    ///Creates an instance of zero-trust-gatewayproxy-endpoint-identity with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (kind: Kind, name: ``zero-trust-gatewayproxy-endpointscomponents-schemas-name``): ``zero-trust-gatewayproxy-endpoint-identity`` =
        { created_at = None
          id = None
          kind = kind
          name = name
          subdomain = None
          updated_at = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``zero-trust-gatewayproxy-endpoint-identity-createKind`` =
    | [<CompiledName "identity">] Identity
    member this.Format() =
        match this with
        | Identity -> "identity"

type ``zero-trust-gatewayproxy-endpoint-identity-create`` =
    { ///The proxy endpoint kind
      kind: ``zero-trust-gatewayproxy-endpoint-identity-createKind``
      ///Specify the name of the proxy endpoint.
      name: ``zero-trust-gatewayproxy-endpointscomponents-schemas-name`` }
    ///Creates an instance of zero-trust-gatewayproxy-endpoint-identity-create with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (kind: ``zero-trust-gatewayproxy-endpoint-identity-createKind``,
                          name: ``zero-trust-gatewayproxy-endpointscomponents-schemas-name``): ``zero-trust-gatewayproxy-endpoint-identity-create`` =
        { kind = kind; name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``zero-trust-gatewayproxy-endpoint-ipKind`` =
    | [<CompiledName "ip">] Ip
    member this.Format() =
        match this with
        | Ip -> "ip"

type ``zero-trust-gatewayproxy-endpoint-ip`` =
    { created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      id: Option<``zero-trust-gatewaycomponents-schemas-uuid``>
      ///Specify the list of CIDRs to restrict ingress connections.
      ips: ``zero-trust-gatewayips``
      ///The proxy endpoint kind
      kind: Option<``zero-trust-gatewayproxy-endpoint-ipKind``>
      ///Specify the name of the proxy endpoint.
      name: ``zero-trust-gatewayproxy-endpointscomponents-schemas-name``
      ///Specify the subdomain to use as the destination in the proxy client.
      subdomain: Option<``zero-trust-gatewayschemas-subdomain``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``> }
    ///Creates an instance of zero-trust-gatewayproxy-endpoint-ip with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ips: ``zero-trust-gatewayips``,
                          name: ``zero-trust-gatewayproxy-endpointscomponents-schemas-name``): ``zero-trust-gatewayproxy-endpoint-ip`` =
        { created_at = None
          id = None
          ips = ips
          kind = None
          name = name
          subdomain = None
          updated_at = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``zero-trust-gatewayproxy-endpoint-ip-createKind`` =
    | [<CompiledName "ip">] Ip
    member this.Format() =
        match this with
        | Ip -> "ip"

type ``zero-trust-gatewayproxy-endpoint-ip-create`` =
    { ///The proxy endpoint kind
      kind: Option<``zero-trust-gatewayproxy-endpoint-ip-createKind``>
      ///Specify the name of the proxy endpoint.
      name: ``zero-trust-gatewayproxy-endpointscomponents-schemas-name`` }
    ///Creates an instance of zero-trust-gatewayproxy-endpoint-ip-create with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``zero-trust-gatewayproxy-endpointscomponents-schemas-name``): ``zero-trust-gatewayproxy-endpoint-ip-create`` =
        { kind = None; name = name }

type ``zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollectionErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollectionMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollection`` =
    { errors: Option<list<``zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollectionMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``>
      result: Option<list<``zero-trust-gatewayproxy-endpoints``>> }
    ///Creates an instance of zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponse`` =
    { errors: Option<list<``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponseErrors``>>
      messages: Option<list<``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``zero-trust-gatewayresponsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayresponsecollectionErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayresponsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayresponsecollectionMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayresponsecollection`` =
    { errors: Option<list<``zero-trust-gatewayresponsecollectionErrors``>>
      messages: Option<list<``zero-trust-gatewayresponsecollectionMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``>
      result: Option<list<``zero-trust-gatewaycertificates``>> }
    ///Creates an instance of zero-trust-gatewayresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayresponsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``zero-trust-gatewayresultinfo`` =
    { ///Indicate the total number of results for the requested service.
      count: Option<float>
      ///Indicate the current page within a paginated list of results.
      page: Option<float>
      ///Indicate the number of results per page.
      per_page: Option<float>
      ///Indicate the total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of zero-trust-gatewayresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayresultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

///Define the settings for the Audit SSH action. Settable only for `l4` rules with `audit_ssh` action.
type Auditssh =
    { ///Enable SSH command logging.
      command_logging: Option<bool> }
    ///Creates an instance of Auditssh with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Auditssh = { command_logging = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Copy =
    | [<CompiledName "enabled">] Enabled
    | [<CompiledName "disabled">] Disabled
    | [<CompiledName "remote_only">] Remote_only
    member this.Format() =
        match this with
        | Enabled -> "enabled"
        | Disabled -> "disabled"
        | Remote_only -> "remote_only"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Download =
    | [<CompiledName "enabled">] Enabled
    | [<CompiledName "disabled">] Disabled
    | [<CompiledName "remote_only">] Remote_only
    member this.Format() =
        match this with
        | Enabled -> "enabled"
        | Disabled -> "disabled"
        | Remote_only -> "remote_only"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Keyboard =
    | [<CompiledName "enabled">] Enabled
    | [<CompiledName "disabled">] Disabled
    member this.Format() =
        match this with
        | Enabled -> "enabled"
        | Disabled -> "disabled"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Paste =
    | [<CompiledName "enabled">] Enabled
    | [<CompiledName "disabled">] Disabled
    | [<CompiledName "remote_only">] Remote_only
    member this.Format() =
        match this with
        | Enabled -> "enabled"
        | Disabled -> "disabled"
        | Remote_only -> "remote_only"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Printing =
    | [<CompiledName "enabled">] Enabled
    | [<CompiledName "disabled">] Disabled
    member this.Format() =
        match this with
        | Enabled -> "enabled"
        | Disabled -> "disabled"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Upload =
    | [<CompiledName "enabled">] Enabled
    | [<CompiledName "disabled">] Disabled
    member this.Format() =
        match this with
        | Enabled -> "enabled"
        | Disabled -> "disabled"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Version =
    | [<CompiledName "v1">] V1
    | [<CompiledName "v2">] V2
    member this.Format() =
        match this with
        | V1 -> "v1"
        | V2 -> "v2"

///Configure browser isolation behavior. Settable only for `http` rules with the action set to `isolate`.
type Bisoadmincontrols =
    { ///Configure copy behavior. If set to remote_only, users cannot copy isolated content from the remote browser to the local clipboard. If this field is absent, copying remains enabled. Applies only when version == "v2".
      copy: Option<Copy>
      ///Set to false to enable copy-pasting. Only applies when `version == "v1"`.
      dcp: Option<bool>
      ///Set to false to enable downloading. Only applies when `version == "v1"`.
      dd: Option<bool>
      ///Set to false to enable keyboard usage. Only applies when `version == "v1"`.
      dk: Option<bool>
      ///Configure download behavior. When set to remote_only, users can view downloads but cannot save them. Applies only when version == "v2".
      download: Option<Download>
      ///Set to false to enable printing. Only applies when `version == "v1"`.
      dp: Option<bool>
      ///Set to false to enable uploading. Only applies when `version == "v1"`.
      du: Option<bool>
      ///Configure keyboard usage behavior. If this field is absent, keyboard usage remains enabled. Applies only when version == "v2".
      keyboard: Option<Keyboard>
      ///Configure paste behavior. If set to remote_only, users cannot paste content from the local clipboard into isolated pages. If this field is absent, pasting remains enabled. Applies only when version == "v2".
      paste: Option<Paste>
      ///Configure print behavior. Default, Printing is enabled. Applies only when version == "v2".
      printing: Option<Printing>
      ///Configure upload behavior. If this field is absent, uploading remains enabled. Applies only when version == "v2".
      upload: Option<Upload>
      ///Indicate which version of the browser isolation controls should apply.
      version: Option<Version> }
    ///Creates an instance of Bisoadmincontrols with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Bisoadmincontrols =
        { copy = None
          dcp = None
          dd = None
          dk = None
          download = None
          dp = None
          du = None
          keyboard = None
          paste = None
          printing = None
          upload = None
          version = None }

///Configure custom block page settings. If missing or null, use the account settings. Settable only for `http` rules with the action set to `block`.
type Blockpage =
    { ///Specify whether to pass the context information as query parameters.
      include_context: Option<bool>
      ///Specify the URI to which the user is redirected.
      target_uri: string }
    ///Creates an instance of Blockpage with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (target_uri: string): Blockpage =
        { include_context = None
          target_uri = target_uri }

///Configure session check behavior. Settable only for `l4` and `http` rules with the action set to `allow`.
type Checksession =
    { ///Sets the required session freshness threshold. The API returns a normalized version of this value.
      duration: Option<string>
      ///Enable session enforcement.
      enforce: Option<bool> }
    ///Creates an instance of Checksession with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Checksession = { duration = None; enforce = None }

///Configure custom resolvers to route queries that match the resolver policy. Unused with 'resolve_dns_through_cloudflare' or 'resolve_dns_internally' settings. DNS queries get routed to the address closest to their origin. Only valid when a rule's action set to 'resolve'. Settable only for `dns_resolver` rules.
type Dnsresolvers =
    { ipv4: Option<list<``zero-trust-gatewaydnsresolversettingsv4``>>
      ipv6: Option<list<``zero-trust-gatewaydnsresolversettingsv6``>> }
    ///Creates an instance of Dnsresolvers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Dnsresolvers = { ipv4 = None; ipv6 = None }

///Configure how Gateway Proxy traffic egresses. You can enable this setting for rules with Egress actions and filters, or omit it to indicate local egress via WARP IPs. Settable only for `egress` rules.
type Egress =
    { ///Specify the IPv4 address to use for egress.
      ipv4: Option<string>
      ///Specify the fallback IPv4 address to use for egress when the primary IPv4 fails. Set '0.0.0.0' to indicate local egress via WARP IPs.
      ipv4_fallback: Option<string>
      ///Specify the IPv6 range to use for egress.
      ipv6: Option<string> }
    ///Creates an instance of Egress with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Egress =
        { ipv4 = None
          ipv4_fallback = None
          ipv6 = None }

///Configure whether a copy of the HTTP request will be sent to storage when the rule matches.
type Forensiccopy =
    { ///Enable sending the copy to storage.
      enabled: Option<bool> }
    ///Creates an instance of Forensiccopy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Forensiccopy = { enabled = None }

///Send matching traffic to the supplied destination IP address and port. Settable only for `l4` rules with the action set to `l4_override`.
type L4override =
    { ///Defines the IPv4 or IPv6 address.
      ip: Option<string>
      ///Defines a port number to use for TCP/UDP overrides.
      port: Option<int> }
    ///Creates an instance of L4override with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): L4override = { ip = None; port = None }

///Configure a notification to display on the user's device when this rule matched. Settable for all types of rules with the action set to `block`.
type Notificationsettings =
    { ///Enable notification.
      enabled: Option<bool>
      ///Indicates whether to pass the context information as query parameters.
      include_context: Option<bool>
      ///Customize the message shown in the notification.
      msg: Option<string>
      ///Defines an optional URL to direct users to additional information. If unset, the notification opens a block page.
      support_url: Option<string> }
    ///Creates an instance of Notificationsettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Notificationsettings =
        { enabled = None
          include_context = None
          msg = None
          support_url = None }

///Configure DLP payload logging. Settable only for `http` rules.
type Payloadlog =
    { ///Enable DLP payload logging for this rule.
      enabled: Option<bool> }
    ///Creates an instance of Payloadlog with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Payloadlog = { enabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type File_types =
    | [<CompiledName "exe">] Exe
    | [<CompiledName "pdf">] Pdf
    | [<CompiledName "doc">] Doc
    | [<CompiledName "docm">] Docm
    | [<CompiledName "docx">] Docx
    | [<CompiledName "rtf">] Rtf
    | [<CompiledName "ppt">] Ppt
    | [<CompiledName "pptx">] Pptx
    | [<CompiledName "xls">] Xls
    | [<CompiledName "xlsm">] Xlsm
    | [<CompiledName "xlsx">] Xlsx
    | [<CompiledName "zip">] Zip
    | [<CompiledName "rar">] Rar
    member this.Format() =
        match this with
        | Exe -> "exe"
        | Pdf -> "pdf"
        | Doc -> "doc"
        | Docm -> "docm"
        | Docx -> "docx"
        | Rtf -> "rtf"
        | Ppt -> "ppt"
        | Pptx -> "pptx"
        | Xls -> "xls"
        | Xlsm -> "xlsm"
        | Xlsx -> "xlsx"
        | Zip -> "zip"
        | Rar -> "rar"

///Configure settings that apply to quarantine rules. Settable only for `http` rules.
type Quarantine =
    { ///Specify the types of files to sandbox.
      file_types: Option<list<File_types>> }
    ///Creates an instance of Quarantine with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Quarantine = { file_types = None }

///Apply settings to redirect rules. Settable only for `http` rules with the action set to `redirect`.
type Redirect =
    { ///Specify whether to pass the context information as query parameters.
      include_context: Option<bool>
      ///Specify whether to append the path and query parameters from the original request to target_uri.
      preserve_path_and_query: Option<bool>
      ///Specify the URI to which the user is redirected.
      target_uri: string }
    ///Creates an instance of Redirect with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (target_uri: string): Redirect =
        { include_context = None
          preserve_path_and_query = None
          target_uri = target_uri }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Fallback =
    | [<CompiledName "none">] None
    | [<CompiledName "public_dns">] Public_dns
    member this.Format() =
        match this with
        | None -> "none"
        | Public_dns -> "public_dns"

///Configure to forward the query to the internal DNS service, passing the specified 'view_id' as input. Not used when 'dns_resolvers' is specified or 'resolve_dns_through_cloudflare' is set. Only valid when a rule's action set to 'resolve'. Settable only for `dns_resolver` rules.
type Resolvednsinternally =
    { ///Specify the fallback behavior to apply when the internal DNS response code differs from 'NOERROR' or when the response data contains only CNAME records for 'A' or 'AAAA' queries.
      fallback: Option<Fallback>
      ///Specify the internal DNS view identifier to pass to the internal DNS service.
      view_id: Option<string> }
    ///Creates an instance of Resolvednsinternally with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resolvednsinternally = { fallback = None; view_id = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Action =
    | [<CompiledName "pass_through">] Pass_through
    | [<CompiledName "block">] Block
    | [<CompiledName "error">] Error
    member this.Format() =
        match this with
        | Pass_through -> "pass_through"
        | Block -> "block"
        | Error -> "error"

///Configure behavior when an upstream certificate is invalid or an SSL error occurs. Settable only for `http` rules with the action set to `allow`.
type Untrustedcert =
    { ///Defines the action performed when an untrusted certificate seen. The default action an error with HTTP code 526.
      action: Option<Action> }
    ///Creates an instance of Untrustedcert with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Untrustedcert = { action = None }

///Defines settings for this rule. Settings apply only to specific rule types and must use compatible selectors. If Terraform detects drift, confirm the setting supports your rule type and check whether the API modifies the value. Use API-returned values in your configuration to prevent drift.
type ``zero-trust-gatewayrule-settings`` =
    { ///Add custom headers to allowed requests as key-value pairs. Use header names as keys that map to arrays of header values. Settable only for `http` rules with the action set to `allow`.
      add_headers: Option<Map<string, list<string>>>
      ///Set to enable MSP children to bypass this rule. Only parent MSP accounts can set this. this rule. Settable for all types of rules.
      allow_child_bypass: Option<bool>
      ///Define the settings for the Audit SSH action. Settable only for `l4` rules with `audit_ssh` action.
      audit_ssh: Option<Auditssh>
      ///Configure browser isolation behavior. Settable only for `http` rules with the action set to `isolate`.
      biso_admin_controls: Option<Bisoadmincontrols>
      ///Configure custom block page settings. If missing or null, use the account settings. Settable only for `http` rules with the action set to `block`.
      block_page: Option<Blockpage>
      ///Enable the custom block page. Settable only for `dns` rules with action `block`.
      block_page_enabled: Option<bool>
      ///Explain why the rule blocks the request. The custom block page shows this text (if enabled). Settable only for `dns`, `l4`, and `http` rules when the action set to `block`.
      block_reason: Option<string>
      ///Set to enable MSP accounts to bypass their parent's rules. Only MSP child accounts can set this. Settable for all types of rules.
      bypass_parent_rule: Option<bool>
      ///Configure session check behavior. Settable only for `l4` and `http` rules with the action set to `allow`.
      check_session: Option<Checksession>
      ///Configure custom resolvers to route queries that match the resolver policy. Unused with 'resolve_dns_through_cloudflare' or 'resolve_dns_internally' settings. DNS queries get routed to the address closest to their origin. Only valid when a rule's action set to 'resolve'. Settable only for `dns_resolver` rules.
      dns_resolvers: Option<Dnsresolvers>
      ///Configure how Gateway Proxy traffic egresses. You can enable this setting for rules with Egress actions and filters, or omit it to indicate local egress via WARP IPs. Settable only for `egress` rules.
      egress: Option<Egress>
      ///Configure whether a copy of the HTTP request will be sent to storage when the rule matches.
      forensic_copy: Option<Forensiccopy>
      ///Ignore category matches at CNAME domains in a response. When off, evaluate categories in this rule against all CNAME domain categories in the response. Settable only for `dns` and `dns_resolver` rules.
      ignore_cname_category_matches: Option<bool>
      ///Specify whether to disable DNSSEC validation (for Allow actions) [INSECURE]. Settable only for `dns` rules.
      insecure_disable_dnssec_validation: Option<bool>
      ///Enable IPs in DNS resolver category blocks. The system blocks only domain name categories unless you enable this setting. Settable only for `dns` and `dns_resolver` rules.
      ip_categories: Option<bool>
      ///Indicates whether to include IPs in DNS resolver indicator feed blocks. Default, indicator feeds block only domain names. Settable only for `dns` and `dns_resolver` rules.
      ip_indicator_feeds: Option<bool>
      ///Send matching traffic to the supplied destination IP address and port. Settable only for `l4` rules with the action set to `l4_override`.
      l4override: Option<L4override>
      ///Configure a notification to display on the user's device when this rule matched. Settable for all types of rules with the action set to `block`.
      notification_settings: Option<Notificationsettings>
      ///Defines a hostname for override, for the matching DNS queries. Settable only for `dns` rules with the action set to `override`.
      override_host: Option<string>
      ///Defines a an IP or set of IPs for overriding matched DNS queries. Settable only for `dns` rules with the action set to `override`.
      override_ips: Option<list<string>>
      ///Configure DLP payload logging. Settable only for `http` rules.
      payload_log: Option<Payloadlog>
      ///Configure settings that apply to quarantine rules. Settable only for `http` rules.
      quarantine: Option<Quarantine>
      ///Apply settings to redirect rules. Settable only for `http` rules with the action set to `redirect`.
      redirect: Option<Redirect>
      ///Configure to forward the query to the internal DNS service, passing the specified 'view_id' as input. Not used when 'dns_resolvers' is specified or 'resolve_dns_through_cloudflare' is set. Only valid when a rule's action set to 'resolve'. Settable only for `dns_resolver` rules.
      resolve_dns_internally: Option<Resolvednsinternally>
      ///Enable to send queries that match the policy to Cloudflare's default 1.1.1.1 DNS resolver. Cannot set when 'dns_resolvers' specified or 'resolve_dns_internally' is set. Only valid when a rule's action set to 'resolve'. Settable only for `dns_resolver` rules.
      resolve_dns_through_cloudflare: Option<bool>
      ///Configure behavior when an upstream certificate is invalid or an SSL error occurs. Settable only for `http` rules with the action set to `allow`.
      untrusted_cert: Option<Untrustedcert> }
    ///Creates an instance of zero-trust-gatewayrule-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayrule-settings`` =
        { add_headers = None
          allow_child_bypass = None
          audit_ssh = None
          biso_admin_controls = None
          block_page = None
          block_page_enabled = None
          block_reason = None
          bypass_parent_rule = None
          check_session = None
          dns_resolvers = None
          egress = None
          forensic_copy = None
          ignore_cname_category_matches = None
          insecure_disable_dnssec_validation = None
          ip_categories = None
          ip_indicator_feeds = None
          l4override = None
          notification_settings = None
          override_host = None
          override_ips = None
          payload_log = None
          quarantine = None
          redirect = None
          resolve_dns_internally = None
          resolve_dns_through_cloudflare = None
          untrusted_cert = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Filters =
    | [<CompiledName "http">] Http
    | [<CompiledName "dns">] Dns
    | [<CompiledName "l4">] L4
    | [<CompiledName "egress">] Egress
    | [<CompiledName "dns_resolver">] Dns_resolver
    member this.Format() =
        match this with
        | Http -> "http"
        | Dns -> "dns"
        | L4 -> "l4"
        | Egress -> "egress"
        | Dns_resolver -> "dns_resolver"

type ``zero-trust-gatewayrules`` =
    { ///Specify the action to perform when the associated traffic, identity, and device posture expressions either absent or evaluate to `true`.
      action: ``zero-trust-gatewayaction``
      created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Indicate the date of deletion, if any.
      deleted_at: Option<``zero-trust-gatewaydeletedat``>
      ///Specify the rule description.
      description: Option<``zero-trust-gatewayschemas-description``>
      ///Specify the wirefilter expression used for device posture check. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
      device_posture: Option<``zero-trust-gatewaydeviceposture``>
      ///Specify whether the rule is enabled.
      enabled: ``zero-trust-gatewayenabled``
      ///Defines the expiration time stamp and default duration of a DNS policy. Takes precedence over the policy's `schedule` configuration, if any. This  does not apply to HTTP or network policies. Settable only for `dns` rules.
      expiration: Option<``zero-trust-gatewayexpiration``>
      ///Specify the protocol or layer to evaluate the traffic, identity, and device posture expressions. Can only contain a single value.
      filters: list<Filters>
      ///Identify the API resource with a UUID.
      id: Option<``zero-trust-gatewayschemas-uuid``>
      ///Specify the wirefilter expression used for identity matching. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
      identity: Option<``zero-trust-gatewayidentity``>
      ///Specify the rule name.
      name: ``zero-trust-gatewaycomponents-schemas-name``
      ///Set the order of your rules. Lower values indicate higher precedence. At each processing phase, evaluate applicable rules in ascending order of this value. Refer to [Order of enforcement](http://developers.cloudflare.com/learning-paths/secure-internet-traffic/understand-policies/order-of-enforcement/#manage-precedence-with-terraform) to manage precedence via Terraform.
      precedence: ``zero-trust-gatewayprecedence``
      ///Indicate that this rule is shared via the Orgs API and read only.
      read_only: Option<``zero-trust-gatewayreadonly``>
      ///Defines settings for this rule. Settings apply only to specific rule types and must use compatible selectors. If Terraform detects drift, confirm the setting supports your rule type and check whether the API modifies the value. Use API-returned values in your configuration to prevent drift.
      rule_settings: Option<``zero-trust-gatewayrule-settings``>
      ///Defines the schedule for activating DNS policies. Settable only for `dns` and `dns_resolver` rules.
      schedule: Option<``zero-trust-gatewayschedule``>
      ///Indicate that this rule is sharable via the Orgs API.
      sharable: Option<``zero-trust-gatewaysharable``>
      ///Provide the account tag of the account that created the rule.
      source_account: Option<``zero-trust-gatewaysourceaccount``>
      ///Specify the wirefilter expression used for traffic matching. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
      traffic: ``zero-trust-gatewaytraffic``
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Indicate the version number of the rule(read-only).
      version: Option<``zero-trust-gatewayversion``>
      ///Indicate a warning for a misconfigured rule, if any.
      warning_status: Option<``zero-trust-gatewaywarningstatus``> }
    ///Creates an instance of zero-trust-gatewayrules with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: ``zero-trust-gatewayaction``,
                          enabled: ``zero-trust-gatewayenabled``,
                          filters: list<Filters>,
                          name: ``zero-trust-gatewaycomponents-schemas-name``,
                          precedence: ``zero-trust-gatewayprecedence``,
                          traffic: ``zero-trust-gatewaytraffic``): ``zero-trust-gatewayrules`` =
        { action = action
          created_at = None
          deleted_at = None
          description = None
          device_posture = None
          enabled = enabled
          expiration = None
          filters = filters
          id = None
          identity = None
          name = name
          precedence = precedence
          read_only = None
          rule_settings = None
          schedule = None
          sharable = None
          source_account = None
          traffic = traffic
          updated_at = None
          version = None
          warning_status = None }

type ``zero-trust-gatewayrulescomponents-schemas-responsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayrulescomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayrulescomponents-schemas-responsecollectionErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayrulescomponents-schemas-responsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayrulescomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayrulescomponents-schemas-responsecollectionMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayrulescomponents-schemas-responsecollection`` =
    { errors: Option<list<``zero-trust-gatewayrulescomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``zero-trust-gatewayrulescomponents-schemas-responsecollectionMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``>
      result: Option<list<``zero-trust-gatewayrules``>> }
    ///Creates an instance of zero-trust-gatewayrulescomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayrulescomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Fallbackaction =
    | [<CompiledName "allow">] Allow
    | [<CompiledName "block">] Block
    member this.Format() =
        match this with
        | Allow -> "allow"
        | Block -> "block"

///Specify whether to enable the sandbox.
type ``zero-trust-gatewaysandbox`` =
    { ///Specify whether to enable the sandbox.
      enabled: Option<bool>
      ///Specify the action to take when the system cannot scan the file.
      fallback_action: Option<Fallbackaction> }
    ///Creates an instance of zero-trust-gatewaysandbox with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaysandbox`` =
        { enabled = None
          fallback_action = None }

///Defines the schedule for activating DNS policies. Settable only for `dns` and `dns_resolver` rules.
type ``zero-trust-gatewayschedule`` =
    { ///Specify the time intervals when the rule is active on Fridays, in the increasing order from 00:00-24:00.  If this parameter omitted, the rule is deactivated on Fridays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
      fri: Option<string>
      ///Specify the time intervals when the rule is active on Mondays, in the increasing order from 00:00-24:00(capped at maximum of 6 time splits). If this parameter omitted, the rule is deactivated on Mondays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
      mon: Option<string>
      ///Specify the time intervals when the rule is active on Saturdays, in the increasing order from 00:00-24:00.  If this parameter omitted, the rule is deactivated on Saturdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
      sat: Option<string>
      ///Specify the time intervals when the rule is active on Sundays, in the increasing order from 00:00-24:00. If this parameter omitted, the rule is deactivated on Sundays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
      sun: Option<string>
      ///Specify the time intervals when the rule is active on Thursdays, in the increasing order from 00:00-24:00. If this parameter omitted, the rule is deactivated on Thursdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
      thu: Option<string>
      ///Specify the time zone for rule evaluation. When a [valid time zone city name](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones#List) is provided, Gateway always uses the current time for that time zone. When this parameter is omitted, Gateway uses the time zone determined from the user's IP address. Colo time zone is used when the user's IP address does not resolve to a location.
      time_zone: Option<string>
      ///Specify the time intervals when the rule is active on Tuesdays, in the increasing order from 00:00-24:00. If this parameter omitted, the rule is deactivated on Tuesdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
      tue: Option<string>
      ///Specify the time intervals when the rule is active on Wednesdays, in the increasing order from 00:00-24:00. If this parameter omitted, the rule is deactivated on Wednesdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
      wed: Option<string> }
    ///Creates an instance of zero-trust-gatewayschedule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayschedule`` =
        { fri = None
          mon = None
          sat = None
          sun = None
          thu = None
          time_zone = None
          tue = None
          wed = None }

type ``zero-trust-gatewayschemas-responsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayschemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayschemas-responsecollectionErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayschemas-responsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayschemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayschemas-responsecollectionMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayschemas-responsecollection`` =
    { errors: Option<list<``zero-trust-gatewayschemas-responsecollectionErrors``>>
      messages: Option<list<``zero-trust-gatewayschemas-responsecollectionMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result_info: Option<``zero-trust-gatewayresultinfo``>
      result: Option<list<``zero-trust-gatewaylists``>> }
    ///Creates an instance of zero-trust-gatewayschemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayschemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``zero-trust-gatewayschemas-singleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayschemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayschemas-singleresponseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewayschemas-singleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewayschemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewayschemas-singleresponseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewayschemas-singleresponse`` =
    { errors: Option<list<``zero-trust-gatewayschemas-singleresponseErrors``>>
      messages: Option<list<``zero-trust-gatewayschemas-singleresponseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewaylocations``> }
    ///Creates an instance of zero-trust-gatewayschemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewayschemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``zero-trust-gatewaysettings`` =
    { created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Provide the Base64-encoded HPKE public key that encrypts SSH session logs. See https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/use-cases/ssh/ssh-infrastructure-access/#enable-ssh-command-logging.
      public_key: Option<``zero-trust-gatewaypublickey``>
      ///Identify the seed ID.
      seed_id: Option<``zero-trust-gatewayauditsshsettingscomponents-schemas-uuid``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``> }
    ///Creates an instance of zero-trust-gatewaysettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaysettings`` =
        { created_at = None
          public_key = None
          seed_id = None
          updated_at = None }

type ``zero-trust-gatewaysingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaysingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaysingleresponseErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaysingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaysingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaysingleresponseMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewaysingleresponse`` =
    { errors: Option<list<``zero-trust-gatewaysingleresponseErrors``>>
      messages: Option<list<``zero-trust-gatewaysingleresponseMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewaycertificates``> }
    ///Creates an instance of zero-trust-gatewaysingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaysingleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``zero-trust-gatewaysingleresponsewithlistitemsErrors`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaysingleresponsewithlistitemsErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaysingleresponsewithlistitemsErrors`` =
        { code = code; message = message }

type ``zero-trust-gatewaysingleresponsewithlistitemsMessages`` =
    { code: int
      message: string }
    ///Creates an instance of zero-trust-gatewaysingleresponsewithlistitemsMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-gatewaysingleresponsewithlistitemsMessages`` =
        { code = code; message = message }

type ``zero-trust-gatewaysingleresponsewithlistitemsResultItems`` =
    { created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Provide the list item description (optional).
      description: Option<``zero-trust-gatewaydescriptionitem``>
      ///Specify the item value.
      value: Option<``zero-trust-gatewayvalue``> }
    ///Creates an instance of zero-trust-gatewaysingleresponsewithlistitemsResultItems with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaysingleresponsewithlistitemsResultItems`` =
        { created_at = None
          description = None
          value = None }

type ``zero-trust-gatewaysingleresponsewithlistitemsResult`` =
    { created_at: Option<``zero-trust-gatewayreadonlytimestamp``>
      ///Provide the list description.
      description: Option<``zero-trust-gatewaydescription``>
      ///Identify the API resource with a UUID.
      id: Option<``zero-trust-gatewayschemas-uuid``>
      ///Provide the list items.
      items: Option<list<``zero-trust-gatewaysingleresponsewithlistitemsResultItems``>>
      ///Specify the list name.
      name: Option<``zero-trust-gatewayname``>
      ///Specify the list type.
      ``type``: Option<``zero-trust-gatewayschemas-type``>
      updated_at: Option<``zero-trust-gatewayreadonlytimestamp``> }
    ///Creates an instance of zero-trust-gatewaysingleresponsewithlistitemsResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaysingleresponsewithlistitemsResult`` =
        { created_at = None
          description = None
          id = None
          items = None
          name = None
          ``type`` = None
          updated_at = None }

type ``zero-trust-gatewaysingleresponsewithlistitems`` =
    { errors: Option<list<``zero-trust-gatewaysingleresponsewithlistitemsErrors``>>
      messages: Option<list<``zero-trust-gatewaysingleresponsewithlistitemsMessages``>>
      ///Indicate whether the API call was successful.
      success: Option<bool>
      result: Option<``zero-trust-gatewaysingleresponsewithlistitemsResult``> }
    ///Creates an instance of zero-trust-gatewaysingleresponsewithlistitems with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaysingleresponsewithlistitems`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``zero-trust-gatewaysubcategory`` =
    { ///Indicate whether the category is in beta and subject to change.
      beta: Option<``zero-trust-gatewaybeta``>
      ///Specify which account types can create policies for this category. `blocked` Blocks unconditionally for all accounts. `removalPending` Allows removal from policies but disables addition. `noBlock` Prevents blocking.
      ``class``: Option<``zero-trust-gatewayclass``>
      ///Provide a short summary of domains in the category.
      description: Option<``zero-trust-gatewaycomponents-schemas-description``>
      ///Identify this category. Only one category per ID.
      id: Option<``zero-trust-gatewayid``>
      ///Specify the category name.
      name: Option<``zero-trust-gatewaycategoriescomponents-schemas-name``> }
    ///Creates an instance of zero-trust-gatewaysubcategory with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaysubcategory`` =
        { beta = None
          ``class`` = None
          description = None
          id = None
          name = None }

///Specify whether to inspect encrypted HTTP traffic.
type ``zero-trust-gatewaytls-settings`` =
    { ///Specify whether to inspect encrypted HTTP traffic.
      enabled: Option<bool> }
    ///Creates an instance of zero-trust-gatewaytls-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-gatewaytls-settings`` = { enabled = None }

[<RequireQualifiedAccess>]
type ZeroTrustAccountsGetZeroTrustAccountInformation =
    ///Zero Trust account information response.
    | OK of payload: ``zero-trust-gatewaygatewayaccount``

[<RequireQualifiedAccess>]
type ZeroTrustAccountsCreateZeroTrustAccount =
    ///Create Zero Trust account response.
    | OK of payload: ``zero-trust-gatewaygatewayaccount``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayApplicationAndApplicationTypeMappingsListApplicationAndApplicationTypeMappings =
    ///List application and application type mappings response.
    | OK of payload: ``zero-trust-gatewayapp-typescomponents-schemas-responsecollection``

[<RequireQualifiedAccess>]
type ZeroTrustApplicationsReviewStatusList =
    ///List applications review status response.
    | OK of payload: ``zero-trust-gatewayapplicationsreviewstatusresponse``

type ZeroTrustApplicationsReviewStatusUpdatePayload =
    { ///Contains the ids of the approved applications.
      approved_apps: ``zero-trust-gatewayapprovedapps``
      ///Contains the ids of the applications in review.
      in_review_apps: ``zero-trust-gatewayinreviewapps``
      ///Contains the ids of the unapproved applications.
      unapproved_apps: ``zero-trust-gatewayunapprovedapps`` }
    ///Creates an instance of ZeroTrustApplicationsReviewStatusUpdatePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (approved_apps: ``zero-trust-gatewayapprovedapps``,
                          in_review_apps: ``zero-trust-gatewayinreviewapps``,
                          unapproved_apps: ``zero-trust-gatewayunapprovedapps``): ZeroTrustApplicationsReviewStatusUpdatePayload =
        { approved_apps = approved_apps
          in_review_apps = in_review_apps
          unapproved_apps = unapproved_apps }

[<RequireQualifiedAccess>]
type ZeroTrustApplicationsReviewStatusUpdate =
    ///Update applications review status response.
    | OK of payload: ``zero-trust-gatewayapplicationsreviewstatusresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGetAuditSshSettings =
    ///Get Zero Trust SSH settings response.
    | OK of payload: ``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponse``

type ZeroTrustUpdateAuditSshSettingsPayload =
    { ///Provide the Base64-encoded HPKE public key that encrypts SSH session logs. See https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/use-cases/ssh/ssh-infrastructure-access/#enable-ssh-command-logging.
      public_key: ``zero-trust-gatewaypublickey`` }
    ///Creates an instance of ZeroTrustUpdateAuditSshSettingsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (public_key: ``zero-trust-gatewaypublickey``): ZeroTrustUpdateAuditSshSettingsPayload =
        { public_key = public_key }

[<RequireQualifiedAccess>]
type ZeroTrustUpdateAuditSshSettings =
    ///Update Zero Trust SSH settings response.
    | OK of payload: ``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustRotateSshAccountSeed =
    ///Rotate Zero Trust SSH account seed response.
    | OK of payload: ``zero-trust-gatewayauditsshsettingscomponents-schemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayCategoriesListCategories =
    ///List categories response.
    | OK of payload: ``zero-trust-gatewaycategoriescomponents-schemas-responsecollection``

[<RequireQualifiedAccess>]
type ZeroTrustCertificatesListZeroTrustCertificates =
    ///Lists Zero Trust certificates response.
    | OK of payload: ``zero-trust-gatewayresponsecollection``

[<RequireQualifiedAccess>]
type ZeroTrustCertificatesCreateZeroTrustCertificate =
    ///Creates Zero Trust certificate response.
    | OK of payload: ``zero-trust-gatewaysingleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustCertificatesDeleteZeroTrustCertificate =
    ///Deletes Zero Trust certificate response.
    | OK of payload: ``zero-trust-gatewaysingleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustCertificatesZeroTrustCertificateDetails =
    ///Gets Zero Trust certificate details response.
    | OK of payload: ``zero-trust-gatewaysingleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustCertificatesActivateZeroTrustCertificate =
    ///Activates Zero Trust certificate details response.
    | Accepted of payload: ``zero-trust-gatewaysingleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustCertificatesDeactivateZeroTrustCertificate =
    ///Deactivate Zero Trust certificate details response.
    | Created of payload: ``zero-trust-gatewaysingleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustAccountsGetZeroTrustAccountConfiguration =
    ///Zero Trust account configuration response.
    | OK of payload: ``zero-trust-gatewaygatewayaccountconfig``

[<RequireQualifiedAccess>]
type ZeroTrustAccountsPatchZeroTrustAccountConfiguration =
    ///Zero Trust account configuration response.
    | OK of payload: ``zero-trust-gatewaygatewayaccountconfig``

[<RequireQualifiedAccess>]
type ZeroTrustAccountsUpdateZeroTrustAccountConfiguration =
    ///Zero Trust account configuration response.
    | OK of payload: ``zero-trust-gatewaygatewayaccountconfig``

[<RequireQualifiedAccess>]
type ZeroTrustAccountsGetZeroTrustCertificateConfiguration =
    ///Zero Trust account configuration response.
    | OK of payload: ``zero-trust-gatewaycustom-certificate-settings``

[<RequireQualifiedAccess>]
type ZeroTrustListsListZeroTrustLists =
    ///List Zero Trust lists response.
    | OK of payload: ``zero-trust-gatewayschemas-responsecollection``

type ZeroTrustListsCreateZeroTrustListPayloadItems =
    { ///Provide the list item description (optional).
      description: Option<``zero-trust-gatewaydescriptionitem``>
      ///Specify the item value.
      value: Option<``zero-trust-gatewayvalue``> }
    ///Creates an instance of ZeroTrustListsCreateZeroTrustListPayloadItems with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ZeroTrustListsCreateZeroTrustListPayloadItems = { description = None; value = None }

type ZeroTrustListsCreateZeroTrustListPayload =
    { ///Provide the list description.
      description: Option<``zero-trust-gatewaydescription``>
      ///Add items to the list.
      items: Option<list<ZeroTrustListsCreateZeroTrustListPayloadItems>>
      ///Specify the list name.
      name: ``zero-trust-gatewayname``
      ///Specify the list type.
      ``type``: ``zero-trust-gatewayschemas-type`` }
    ///Creates an instance of ZeroTrustListsCreateZeroTrustListPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``zero-trust-gatewayname``, ``type``: ``zero-trust-gatewayschemas-type``): ZeroTrustListsCreateZeroTrustListPayload =
        { description = None
          items = None
          name = name
          ``type`` = ``type`` }

[<RequireQualifiedAccess>]
type ZeroTrustListsCreateZeroTrustList =
    ///Create Zero Trust list response.
    | OK of payload: ``zero-trust-gatewaysingleresponsewithlistitems``

[<RequireQualifiedAccess>]
type ZeroTrustListsDeleteZeroTrustList =
    ///Delete Zero Trust list response.
    | OK of payload: ``zero-trust-gatewayemptyresponse``

[<RequireQualifiedAccess>]
type ZeroTrustListsZeroTrustListDetails =
    ///Get Zero Trust list details response.
    | OK of payload: ``zero-trust-gatewaylistsingleresponse``

type Append =
    { ///Provide the list item description (optional).
      description: Option<``zero-trust-gatewaydescriptionitem``>
      ///Specify the item value.
      value: Option<``zero-trust-gatewayvalue``> }
    ///Creates an instance of Append with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Append = { description = None; value = None }

type ZeroTrustListsPatchZeroTrustListPayload =
    { ///Add items to the list.
      append: Option<list<Append>>
      ///Lists of item values you want to remove.
      remove: Option<list<``zero-trust-gatewayvalue``>> }
    ///Creates an instance of ZeroTrustListsPatchZeroTrustListPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ZeroTrustListsPatchZeroTrustListPayload = { append = None; remove = None }

[<RequireQualifiedAccess>]
type ZeroTrustListsPatchZeroTrustList =
    ///Patch Zero Trust list response.
    | OK of payload: ``zero-trust-gatewaylistsingleresponse``

type ZeroTrustListsUpdateZeroTrustListPayloadItems =
    { ///Provide the list item description (optional).
      description: Option<``zero-trust-gatewaydescriptionitem``>
      ///Specify the item value.
      value: Option<``zero-trust-gatewayvalue``> }
    ///Creates an instance of ZeroTrustListsUpdateZeroTrustListPayloadItems with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ZeroTrustListsUpdateZeroTrustListPayloadItems = { description = None; value = None }

type ZeroTrustListsUpdateZeroTrustListPayload =
    { ///Provide the list description.
      description: Option<``zero-trust-gatewaydescription``>
      ///Add items to the list.
      items: Option<list<ZeroTrustListsUpdateZeroTrustListPayloadItems>>
      ///Specify the list name.
      name: ``zero-trust-gatewayname`` }
    ///Creates an instance of ZeroTrustListsUpdateZeroTrustListPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``zero-trust-gatewayname``): ZeroTrustListsUpdateZeroTrustListPayload =
        { description = None
          items = None
          name = name }

[<RequireQualifiedAccess>]
type ZeroTrustListsUpdateZeroTrustList =
    ///Update Zero Trust list response.
    | OK of payload: ``zero-trust-gatewaylistsingleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustListsZeroTrustListItems =
    ///Get Zero Trust list items response.
    | OK of payload: ``zero-trust-gatewaylistitemresponsecollection``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayLocationsListZeroTrustGatewayLocations =
    ///Lists Zero Trust Gateway locations response.
    | OK of payload: ``zero-trust-gatewaycomponents-schemas-responsecollection``

type ZeroTrustGatewayLocationsCreateZeroTrustGatewayLocationPayload =
    { ///Indicate whether this location is the default location.
      client_default: Option<``zero-trust-gatewayclient-default``>
      ///Specify the identifier of the pair of IPv4 addresses assigned to this location. When creating a location, if this field is absent or set to null, the pair of shared IPv4 addresses (0e4a32c6-6fb8-4858-9296-98f51631e8e6) is auto-assigned. When updating a location, if this field is absent or set to null, the pre-assigned pair remains unchanged.
      dns_destination_ips_id: Option<``zero-trust-gatewaydns-destination-ips-id-write``>
      ///Indicate whether the location must resolve EDNS queries.
      ecs_support: Option<``zero-trust-gatewayecs-support``>
      ///Configure the destination endpoints for this location.
      endpoints: Option<``zero-trust-gatewayendpoints``>
      ///Specify the location name.
      name: ``zero-trust-gatewayschemas-name``
      ///Specify the list of network ranges from which requests at this location originate. The list takes effect only if it is non-empty and the IPv4 endpoint is enabled for this location.
      networks: Option<``zero-trust-gatewayipv4networks``> }
    ///Creates an instance of ZeroTrustGatewayLocationsCreateZeroTrustGatewayLocationPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``zero-trust-gatewayschemas-name``): ZeroTrustGatewayLocationsCreateZeroTrustGatewayLocationPayload =
        { client_default = None
          dns_destination_ips_id = None
          ecs_support = None
          endpoints = None
          name = name
          networks = None }

[<RequireQualifiedAccess>]
type ZeroTrustGatewayLocationsCreateZeroTrustGatewayLocation =
    ///Creates a Zero Trust Gateway location response.
    | OK of payload: ``zero-trust-gatewayschemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayLocationsDeleteZeroTrustGatewayLocation =
    ///Deletes a Zero Trust Gateway location response.
    | OK of payload: ``zero-trust-gatewayemptyresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayLocationsZeroTrustGatewayLocationDetails =
    ///Gets Zero Trust Gateway location details response.
    | OK of payload: ``zero-trust-gatewayschemas-singleresponse``

type ZeroTrustGatewayLocationsUpdateZeroTrustGatewayLocationPayload =
    { ///Indicate whether this location is the default location.
      client_default: Option<``zero-trust-gatewayclient-default``>
      ///Specify the identifier of the pair of IPv4 addresses assigned to this location. When creating a location, if this field is absent or set to null, the pair of shared IPv4 addresses (0e4a32c6-6fb8-4858-9296-98f51631e8e6) is auto-assigned. When updating a location, if this field is absent or set to null, the pre-assigned pair remains unchanged.
      dns_destination_ips_id: Option<``zero-trust-gatewaydns-destination-ips-id-write``>
      ///Indicate whether the location must resolve EDNS queries.
      ecs_support: Option<``zero-trust-gatewayecs-support``>
      ///Configure the destination endpoints for this location.
      endpoints: Option<``zero-trust-gatewayendpoints``>
      ///Specify the location name.
      name: ``zero-trust-gatewayschemas-name``
      ///Specify the list of network ranges from which requests at this location originate. The list takes effect only if it is non-empty and the IPv4 endpoint is enabled for this location.
      networks: Option<``zero-trust-gatewayipv4networks``> }
    ///Creates an instance of ZeroTrustGatewayLocationsUpdateZeroTrustGatewayLocationPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``zero-trust-gatewayschemas-name``): ZeroTrustGatewayLocationsUpdateZeroTrustGatewayLocationPayload =
        { client_default = None
          dns_destination_ips_id = None
          ecs_support = None
          endpoints = None
          name = name
          networks = None }

[<RequireQualifiedAccess>]
type ZeroTrustGatewayLocationsUpdateZeroTrustGatewayLocation =
    ///Updates a Zero Trust Gateway location response.
    | OK of payload: ``zero-trust-gatewayschemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustAccountsGetLoggingSettingsForTheZeroTrustAccount =
    ///Logging settings retrieval response.
    | OK of payload: ``zero-trust-gatewaygateway-account-logging-settings-response``

[<RequireQualifiedAccess>]
type ZeroTrustAccountsUpdateLoggingSettingsForTheZeroTrustAccount =
    ///Logging settings update response.
    | OK of payload: ``zero-trust-gatewaygateway-account-logging-settings-response``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayPacfilesList =
    ///Returns a list of PAC files response.
    | OK of payload: ``zero-trust-gatewaypacfilescomponents-schemas-responsecollection``

type ZeroTrustGatewayPacfilesCreatePacfilePayload =
    { ///Actual contents of the PAC file
      contents: ``zero-trust-gatewaycontents``
      ///Detailed description of the PAC file.
      description: Option<``zero-trust-gatewaypacfilescomponents-schemas-description``>
      ///Name of the PAC file.
      name: ``zero-trust-gatewaypacfilescomponents-schemas-name``
      ///URL-friendly version of the PAC file name. If not provided, it will be auto-generated
      slug: Option<string> }
    ///Creates an instance of ZeroTrustGatewayPacfilesCreatePacfilePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (contents: ``zero-trust-gatewaycontents``,
                          name: ``zero-trust-gatewaypacfilescomponents-schemas-name``): ZeroTrustGatewayPacfilesCreatePacfilePayload =
        { contents = contents
          description = None
          name = name
          slug = None }

[<RequireQualifiedAccess>]
type ZeroTrustGatewayPacfilesCreatePacfile =
    ///Returns a created PAC file response.
    | OK of payload: ``zero-trust-gatewaypacfilescomponents-schemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayPacfilesDelete =
    ///Returns a deleted PAC file response.
    | OK of payload: ``zero-trust-gatewayemptyresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayPacfilesDetails =
    ///Returns a PAC file response.
    | OK of payload: ``zero-trust-gatewaypacfilescomponents-schemas-singleresponse``

type ZeroTrustGatewayPacfilesUpdatePayload =
    { ///Actual contents of the PAC file
      contents: ``zero-trust-gatewaycontents``
      ///Detailed description of the PAC file.
      description: ``zero-trust-gatewaypacfilescomponents-schemas-description``
      ///Name of the PAC file.
      name: ``zero-trust-gatewaypacfilescomponents-schemas-name`` }
    ///Creates an instance of ZeroTrustGatewayPacfilesUpdatePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (contents: ``zero-trust-gatewaycontents``,
                          description: ``zero-trust-gatewaypacfilescomponents-schemas-description``,
                          name: ``zero-trust-gatewaypacfilescomponents-schemas-name``): ZeroTrustGatewayPacfilesUpdatePayload =
        { contents = contents
          description = description
          name = name }

[<RequireQualifiedAccess>]
type ZeroTrustGatewayPacfilesUpdate =
    ///Update a Zero Trust Gateway PAC file response.
    | OK of payload: ``zero-trust-gatewaypacfilescomponents-schemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayProxyEndpointsListProxyEndpoints =
    ///Returns a list of proxy endpoints response.
    | OK of payload: ``zero-trust-gatewayproxy-endpointscomponents-schemas-responsecollection``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayProxyEndpointsCreateProxyEndpoint =
    ///Returns a created proxy endpoint response.
    | OK of payload: ``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayProxyEndpointsDeleteProxyEndpoint =
    ///Returns a deleted proxy endpoint response.
    | OK of payload: ``zero-trust-gatewayemptyresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayProxyEndpointsProxyEndpointDetails =
    ///Returns a proxy endpoint response.
    | OK of payload: ``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponse``

type ZeroTrustGatewayProxyEndpointsUpdateProxyEndpointPayload =
    { ///Specify the list of CIDRs to restrict ingress connections.
      ips: Option<``zero-trust-gatewayips``>
      ///Specify the name of the proxy endpoint.
      name: Option<``zero-trust-gatewayproxy-endpointscomponents-schemas-name``> }
    ///Creates an instance of ZeroTrustGatewayProxyEndpointsUpdateProxyEndpointPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ZeroTrustGatewayProxyEndpointsUpdateProxyEndpointPayload = { ips = None; name = None }

[<RequireQualifiedAccess>]
type ZeroTrustGatewayProxyEndpointsUpdateProxyEndpoint =
    ///Returns an updated proxy endpoint response.
    | OK of payload: ``zero-trust-gatewayproxy-endpointscomponents-schemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayRulesListZeroTrustGatewayRules =
    ///List Zero Trust Gateway rules response.
    | OK of payload: ``zero-trust-gatewayrulescomponents-schemas-responsecollection``

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ZeroTrustGatewayRulesCreateZeroTrustGatewayRulePayloadFilters =
    | [<CompiledName "http">] Http
    | [<CompiledName "dns">] Dns
    | [<CompiledName "l4">] L4
    | [<CompiledName "egress">] Egress
    | [<CompiledName "dns_resolver">] Dns_resolver
    member this.Format() =
        match this with
        | Http -> "http"
        | Dns -> "dns"
        | L4 -> "l4"
        | Egress -> "egress"
        | Dns_resolver -> "dns_resolver"

type ZeroTrustGatewayRulesCreateZeroTrustGatewayRulePayload =
    { ///Specify the action to perform when the associated traffic, identity, and device posture expressions either absent or evaluate to `true`.
      action: ``zero-trust-gatewayaction``
      ///Specify the rule description.
      description: Option<``zero-trust-gatewayschemas-description``>
      ///Specify the wirefilter expression used for device posture check. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
      device_posture: Option<``zero-trust-gatewaydeviceposture``>
      ///Specify whether the rule is enabled.
      enabled: Option<``zero-trust-gatewayenabled``>
      ///Defines the expiration time stamp and default duration of a DNS policy. Takes precedence over the policy's `schedule` configuration, if any. This  does not apply to HTTP or network policies. Settable only for `dns` rules.
      expiration: Option<``zero-trust-gatewayexpiration``>
      ///Specify the protocol or layer to evaluate the traffic, identity, and device posture expressions. Can only contain a single value.
      filters: Option<list<ZeroTrustGatewayRulesCreateZeroTrustGatewayRulePayloadFilters>>
      ///Specify the wirefilter expression used for identity matching. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
      identity: Option<``zero-trust-gatewayidentity``>
      ///Specify the rule name.
      name: ``zero-trust-gatewaycomponents-schemas-name``
      ///Set the order of your rules. Lower values indicate higher precedence. At each processing phase, evaluate applicable rules in ascending order of this value. Refer to [Order of enforcement](http://developers.cloudflare.com/learning-paths/secure-internet-traffic/understand-policies/order-of-enforcement/#manage-precedence-with-terraform) to manage precedence via Terraform.
      precedence: Option<``zero-trust-gatewayprecedence``>
      ///Defines settings for this rule. Settings apply only to specific rule types and must use compatible selectors. If Terraform detects drift, confirm the setting supports your rule type and check whether the API modifies the value. Use API-returned values in your configuration to prevent drift.
      rule_settings: Option<``zero-trust-gatewayrule-settings``>
      ///Defines the schedule for activating DNS policies. Settable only for `dns` and `dns_resolver` rules.
      schedule: Option<``zero-trust-gatewayschedule``>
      ///Specify the wirefilter expression used for traffic matching. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
      traffic: Option<``zero-trust-gatewaytraffic``> }
    ///Creates an instance of ZeroTrustGatewayRulesCreateZeroTrustGatewayRulePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: ``zero-trust-gatewayaction``, name: ``zero-trust-gatewaycomponents-schemas-name``): ZeroTrustGatewayRulesCreateZeroTrustGatewayRulePayload =
        { action = action
          description = None
          device_posture = None
          enabled = None
          expiration = None
          filters = None
          identity = None
          name = name
          precedence = None
          rule_settings = None
          schedule = None
          traffic = None }

[<RequireQualifiedAccess>]
type ZeroTrustGatewayRulesCreateZeroTrustGatewayRule =
    ///Create a Zero Trust Gateway rule response.
    | OK of payload: ``zero-trust-gatewaycomponents-schemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayRulesListZeroTrustGatewayRulesTenant =
    ///List Zero Trust Gateway rules response.
    | OK of payload: ``zero-trust-gatewayrulescomponents-schemas-responsecollection``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayRulesDeleteZeroTrustGatewayRule =
    ///Delete a Zero Trust Gateway rule response.
    | OK of payload: ``zero-trust-gatewayemptyresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayRulesZeroTrustGatewayRuleDetails =
    ///Get Zero Trust Gateway rule details response.
    | OK of payload: ``zero-trust-gatewaycomponents-schemas-singleresponse``

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ZeroTrustGatewayRulesUpdateZeroTrustGatewayRulePayloadFilters =
    | [<CompiledName "http">] Http
    | [<CompiledName "dns">] Dns
    | [<CompiledName "l4">] L4
    | [<CompiledName "egress">] Egress
    | [<CompiledName "dns_resolver">] Dns_resolver
    member this.Format() =
        match this with
        | Http -> "http"
        | Dns -> "dns"
        | L4 -> "l4"
        | Egress -> "egress"
        | Dns_resolver -> "dns_resolver"

type ZeroTrustGatewayRulesUpdateZeroTrustGatewayRulePayload =
    { ///Specify the action to perform when the associated traffic, identity, and device posture expressions either absent or evaluate to `true`.
      action: ``zero-trust-gatewayaction``
      ///Specify the rule description.
      description: Option<``zero-trust-gatewayschemas-description``>
      ///Specify the wirefilter expression used for device posture check. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
      device_posture: Option<``zero-trust-gatewaydeviceposture``>
      ///Specify whether the rule is enabled.
      enabled: Option<``zero-trust-gatewayenabled``>
      ///Defines the expiration time stamp and default duration of a DNS policy. Takes precedence over the policy's `schedule` configuration, if any. This  does not apply to HTTP or network policies. Settable only for `dns` rules.
      expiration: Option<``zero-trust-gatewayexpiration``>
      ///Specify the protocol or layer to evaluate the traffic, identity, and device posture expressions. Can only contain a single value.
      filters: Option<list<ZeroTrustGatewayRulesUpdateZeroTrustGatewayRulePayloadFilters>>
      ///Specify the wirefilter expression used for identity matching. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
      identity: Option<``zero-trust-gatewayidentity``>
      ///Specify the rule name.
      name: ``zero-trust-gatewaycomponents-schemas-name``
      ///Set the order of your rules. Lower values indicate higher precedence. At each processing phase, evaluate applicable rules in ascending order of this value. Refer to [Order of enforcement](http://developers.cloudflare.com/learning-paths/secure-internet-traffic/understand-policies/order-of-enforcement/#manage-precedence-with-terraform) to manage precedence via Terraform.
      precedence: Option<``zero-trust-gatewayprecedence``>
      ///Defines settings for this rule. Settings apply only to specific rule types and must use compatible selectors. If Terraform detects drift, confirm the setting supports your rule type and check whether the API modifies the value. Use API-returned values in your configuration to prevent drift.
      rule_settings: Option<``zero-trust-gatewayrule-settings``>
      ///Defines the schedule for activating DNS policies. Settable only for `dns` and `dns_resolver` rules.
      schedule: Option<``zero-trust-gatewayschedule``>
      ///Specify the wirefilter expression used for traffic matching. The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
      traffic: Option<``zero-trust-gatewaytraffic``> }
    ///Creates an instance of ZeroTrustGatewayRulesUpdateZeroTrustGatewayRulePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: ``zero-trust-gatewayaction``, name: ``zero-trust-gatewaycomponents-schemas-name``): ZeroTrustGatewayRulesUpdateZeroTrustGatewayRulePayload =
        { action = action
          description = None
          device_posture = None
          enabled = None
          expiration = None
          filters = None
          identity = None
          name = name
          precedence = None
          rule_settings = None
          schedule = None
          traffic = None }

[<RequireQualifiedAccess>]
type ZeroTrustGatewayRulesUpdateZeroTrustGatewayRule =
    ///Update a Zero Trust Gateway rule response.
    | OK of payload: ``zero-trust-gatewaycomponents-schemas-singleresponse``

[<RequireQualifiedAccess>]
type ZeroTrustGatewayRulesResetExpirationZeroTrustGatewayRule =
    ///Reset the expiration of a Zero Trust Gateway rule response.
    | OK of payload: ``zero-trust-gatewaycomponents-schemas-singleresponse``
