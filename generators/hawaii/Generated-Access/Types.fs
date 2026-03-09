namespace rec Fidelity.CloudEdge.Management.Access.Types

// Auto-generated type aliases (Hawaii normalization fix)
type access_approval_group = accessapprovalgroup
type access_rdp_clipboard_format = accessrdpclipboardformat
type ``access_schemas-approval_group`` = ``accessschemas-approvalgroup``
type access_seat = accessseat

// Auto-generated stub types (missing from Hawaii output)
type access_rule = string
type ``access_schemas-scim_config_single_authentication`` = string
type access_scim_config_single_authentication = string
type accessappid = string
type accessapprequest = string
type accessappresponse = string
type accessdestinations = string
type ``accessschemas-allowedheaders`` = string
type ``accessschemas-allowedorigins`` = string
type applications = string
type approvals = string
type apps = string
type attrname = string
type authentication = string
type basic = string
type days = string
type execution = string
type names = string
type oasis = string
type precedence = string
type results = string
type risk = string
type unspecified = string
type uri = string
type your = string

type accessaccessseat = bool
///The event that occurred, such as a login attempt.
type accessaction = string
type accessactivedevicecount = float
type accessallowallheaders = bool
type accessallowallmethods = bool
type accessallowallorigins = bool
type accessallowauthenticateviawarp = bool
type accessallowcredentials = bool
type accessallowemailalias = bool
type accessallowiframe = bool
type accessallowed = bool
type accessallowedclipboardlocaltoremoteformats = list<access_rdp_clipboard_format>
type accessallowedclipboardremotetolocalformats = list<access_rdp_clipboard_format>
///Allowed HTTP request headers.
type accessallowedheaders = list<string>
///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
type accessallowedidps = list<string>

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnumForaccessallowedmethods =
    | [<CompiledName "GET">] GET
    | [<CompiledName "POST">] POST
    | [<CompiledName "HEAD">] HEAD
    | [<CompiledName "PUT">] PUT
    | [<CompiledName "DELETE">] DELETE
    | [<CompiledName "CONNECT">] CONNECT
    | [<CompiledName "OPTIONS">] OPTIONS
    | [<CompiledName "TRACE">] TRACE
    | [<CompiledName "PATCH">] PATCH
    member this.Format() =
        match this with
        | GET -> "GET"
        | POST -> "POST"
        | HEAD -> "HEAD"
        | PUT -> "PUT"
        | DELETE -> "DELETE"
        | CONNECT -> "CONNECT"
        | OPTIONS -> "OPTIONS"
        | TRACE -> "TRACE"
        | PATCH -> "PATCH"

type accessallowedmethods = list<EnumForaccessallowedmethods>
///Allowed origins.
type accessallowedorigins = list<string>
type accessappcount = int
///The URL of the Access application.
type accessappdomain = string
///The image URL of the logo shown in the App Launcher header.
type accessapplauncherlogourl = string
type accessapplaunchervisible = bool
///The unique identifier for the Access application.
type accessappuid = string
type accessapprovalgroups = list<access_approval_group>
type accessapprovalrequired = bool
///The name of the application.
type ``accessappscomponents-schemas-name`` = string
///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
type ``accessappscomponents-schemas-sessionduration`` = string
///The hostnames of the applications that will use this certificate.
type accessassociatedhostnames = list<string>
///The Application Audience (AUD) tag. Identifies the application associated with the CA.
type accessaud = string
///The unique subdomain assigned to your Zero Trust organization.
type accessauthdomain = string
///The unique identifier for the MFA device.
type accessauthenticatorid = string
type accessautoredirecttoidentity = bool
///The background color of the App Launcher page.
type accessbgcolor = string
///The name of the Bookmark application.
type ``accessbookmarkscomponents-schemas-name`` = string
///The background color of the log in button on the landing page.
type accessbuttoncolor = string
///The color of the text in the log in button on the landing page.
type accessbuttontextcolor = string
///The name of the certificate.
type ``accesscertificatescomponents-schemas-name`` = string
///The name of the certificate.
type ``accesscertificatescomponents-schemas-name-2`` = string
///The unique Cloudflare-generated Id of the SCIM Group resource; also known as the "Id".
type accesscfresourceid = string
///The Client ID for the service token. Access will check for this value in the `CF-Access-Client-ID` request header.
type accessclientid = string
///The Client Secret for the service token. Access will check for this value in the `CF-Access-Client-Secret` request header.
type accessclientsecret = string
type accessclientsecretversion = float
///The Application Audience (AUD) tag. Identifies the application associated with the CA.
type ``accesscomponents-schemas-aud`` = string
///The domain and path that Access will secure.
type ``accesscomponents-schemas-domain`` = string
///The email address of the authenticating user.
type ``accesscomponents-schemas-email`` = string
type ``accesscomponents-schemas-exclude`` = list<access_rule>
///The ID of the CA.
type ``accesscomponents-schemas-id`` = string
type ``accesscomponents-schemas-identifier`` = string
///The name of the identity provider, shown to users on the login page.
type ``accesscomponents-schemas-name`` = string
type ``accesscomponents-schemas-require`` = list<access_rule>
///The amount of time that tokens issued for the application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
type ``accesscomponents-schemas-sessionduration`` = string

///The application type.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accesscomponents-schemas-type`` =
    | [<CompiledName "self_hosted">] Self_hosted
    | [<CompiledName "saas">] Saas
    | [<CompiledName "ssh">] Ssh
    | [<CompiledName "vnc">] Vnc
    | [<CompiledName "app_launcher">] App_launcher
    | [<CompiledName "warp">] Warp
    | [<CompiledName "biso">] Biso
    | [<CompiledName "bookmark">] Bookmark
    | [<CompiledName "dash_sso">] Dash_sso
    member this.Format() =
        match this with
        | Self_hosted -> "self_hosted"
        | Saas -> "saas"
        | Ssh -> "ssh"
        | Vnc -> "vnc"
        | App_launcher -> "app_launcher"
        | Warp -> "warp"
        | Biso -> "biso"
        | Bookmark -> "bookmark"
        | Dash_sso -> "dash_sso"

///The IdP used to authenticate.
type accessconnection = string
///Custom page name.
type ``accesscustom-pagescomponents-schemas-name`` = string
///The custom error message shown to a user when they are denied access to the application.
type accesscustomdenymessage = string
///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
type accesscustomdenyurl = string
///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
type accesscustomnonidentitydenyurl = string
type accessdaysuntilnextrotation = float

///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessdecision =
    | [<CompiledName "allow">] Allow
    | [<CompiledName "deny">] Deny
    | [<CompiledName "non_identity">] Non_identity
    | [<CompiledName "bypass">] Bypass
    member this.Format() =
        match this with
        | Allow -> "allow"
        | Deny -> "deny"
        | Non_identity -> "non_identity"
        | Bypass -> "bypass"

type accessdenyunmatchedrequests = bool
///Contains zone names to exempt from the `deny_unmatched_requests` feature. Requests to a subdomain in an exempted zone will block unauthenticated traffic by default if there is a configured Access application and policy that matches the request.
type accessdenyunmatchedrequestsexemptedzonenames = list<string>

///The chronological order used to sort the logs.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessdirection =
    | [<CompiledName "desc">] Desc
    | [<CompiledName "asc">] Asc
    member this.Format() =
        match this with
        | Desc -> "desc"
        | Asc -> "asc"

///The duration the DoH JWT is valid for. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.  Note that the maximum duration for this setting is the same as the key rotation period on the account. Default expiration is 24h
type accessdohjwtduration = string
///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
type accessdomain = string
///The duration for how long the service token will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. The default is 1 year in hours (8760h).
type accessduration = string
///The email address of the SCIM User resource.
type accessemail = string
type accessenablebindingcookie = bool
type accessexclude = list<access_rule>
///The IdP-generated Id of the SCIM resource.
type accessexternalId = string
///The MD5 fingerprint of the certificate.
type accessfingerprint = string

type accessfooterlinksArrayItem =
    { ///The hypertext in the footer link.
      name: string
      ///the hyperlink in the footer link.
      url: string }
    ///Creates an instance of accessfooterlinksArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, url: string): accessfooterlinksArrayItem = { name = name; url = url }

type accessfooterlinks = list<accessfooterlinksArrayItem>
type accessgatewayseat = bool
///The display name of the SCIM Group resource.
type ``accessgroups-name`` = string
///The name of the Access group.
type ``accessgroupscomponents-schemas-name`` = string
///The name of the Access group.
type ``accessgroupscomponents-schemas-name-2`` = string
///The background color of the App Launcher header.
type accessheaderbgcolor = string
type accesshttponlycookieattribute = bool
///The unique Cloudflare-generated Id of the SCIM resource.
type accessid = string
///Identifier.
type accessidentifier = string
///The unique Id of the IdP that has SCIM enabled.
type accessidpid = list<string>
///The IdP-generated Id of the SCIM Group resource; also known as the "external Id".
type accessidpresourceid = string
///The URL of the image shown on the landing page.
type accessimageurl = string
type accessinclude = list<access_rule>
///The IP address of the authenticating user.
type accessip = string
type accessisdefault = bool
type accessisuireadonly = bool
type accessisolationrequired = bool
type accesskeyrotationintervaldays = float
///The timestamp of the previous key rotation.
type accesslastkeyrotationat = System.DateTimeOffset
///The time at which the user last successfully logged in.
type accesslastsuccessfullogin = System.DateTimeOffset
type accesslimit = int
///The image URL for the logo shown in the App Launcher dashboard.
type accesslogourl = string
type accessmaxage = float
///The message shown on the landing page.
type accessmessage = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type accessmessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of accessmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessmessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessmessages = list<accessmessagesArrayItem>
type accessmfarequiredforallapps = bool
///The name of your Zero Trust organization.
type accessname = string
type accessnonce = string
type accessoptionspreflightbypass = bool
///The name of your Zero Trust organization.
type ``accessorganizationscomponents-schemas-name`` = string
type accesspathcookieattribute = bool
type accesspercentapproved = int
type accesspercentblocked = int
type accesspercenterrored = int
type accesspercentusersprocessed = int
///The name of the Access policy.
type ``accesspoliciescomponents-schemas-name`` = string
///The name of the Access policy.
type ``accesspolicycomponents-schemas-name`` = string
///The UUID of the policy test.
type accesspolicytestid = string
type accessport = int
type accessprecedence = int
///The expiration of the previous `client_secret`. This can be modified at any point after a rotation. For example, you may extend it further into the future if you need more time to update services with the new secret; or move it into the past to immediately invalidate the previous token in case of compromise.
type accesspreviousclientsecretexpiresat = System.DateTimeOffset

///The communication protocol your application secures.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessprotocolinfraapp =
    | [<CompiledName "SSH">] SSH
    member this.Format() =
        match this with
        | SSH -> "SSH"

///The communication protocol your application secures.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessprotocolselfhostedapp =
    | [<CompiledName "RDP">] RDP
    member this.Format() =
        match this with
        | RDP -> "RDP"

///The public key to add to your SSH server configuration.
type accesspublickey = string
///A custom message that will appear on the purpose justification screen.
type accesspurposejustificationprompt = string
type accesspurposejustificationrequired = bool
///The unique identifier for the request to Cloudflare.
type accessrayid = string

///Clipboard format for RDP connections.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessrdpclipboardformat =
    | [<CompiledName "text">] Text
    member this.Format() =
        match this with
        | Text -> "text"

///Allows matching Access Service Tokens passed HTTP in a single header with this name.
///This works as an alternative to the (CF-Access-Client-Id, CF-Access-Client-Secret) pair of headers.
///The header value will be interpreted as a json object similar to:
///  {
///    "cf-access-client-id": "88bf3b6d86161464f6509f7219099e57.access.example.com",
///    "cf-access-client-secret": "bdd31cbc4dec990953e39163fbbb194c93313ca9f0a6e420346af9d326b1d2a5"
///  }
type accessreadservicetokensfromheader = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnumForaccessrequestmethod =
    | [<CompiledName "DELETE">] DELETE
    | [<CompiledName "PATCH">] PATCH
    | [<CompiledName "POST">] POST
    | [<CompiledName "PUT">] PUT
    member this.Format() =
        match this with
        | DELETE -> "DELETE"
        | PATCH -> "PATCH"
        | POST -> "POST"
        | PUT -> "PUT"

type accessrequestmethod = list<EnumForaccessrequestmethod>
///The unique Cloudflare-generated Id of the SCIM resource.
type ``accessrequests-cfresourceid`` = string
///The IdP-generated Id of the SCIM resource.
type ``accessrequests-idpresourceid`` = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``EnumForaccessrequests-status`` =
    | [<CompiledName "FAILURE">] FAILURE
    | [<CompiledName "SUCCESS">] SUCCESS
    member this.Format() =
        match this with
        | FAILURE -> "FAILURE"
        | SUCCESS -> "SUCCESS"

type ``accessrequests-status`` = list<``EnumForaccessrequests-status``>
type accessrequire = list<access_rule>
///The display name of the SCIM Group resource.
type accessresourcegroupname = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnumForaccessresourcetype =
    | [<CompiledName "USER">] USER
    | [<CompiledName "GROUP">] GROUP
    member this.Format() =
        match this with
        | USER -> "USER"
        | GROUP -> "GROUP"

type accessresourcetype = list<EnumForaccessresourcetype>
///The email address of the SCIM User resource.
type accessresourceuseremail = string
///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
type accesssamesitecookieattribute = string
type ``accessschemas-accessseat`` = bool
type ``accessschemas-allowauthenticateviawarp`` = bool
type ``accessschemas-appcount`` = int
type ``accessschemas-applaunchervisible`` = bool
type ``accessschemas-approvalgroups`` = list<``access_schemas-approval_group``>
type ``accessschemas-approvalrequired`` = bool
///The hostnames of the applications that will use this certificate.
type ``accessschemas-associatedhostnames`` = list<string>
///Audience tag.
type ``accessschemas-aud`` = string
///The unique subdomain assigned to your Zero Trust organization.
type ``accessschemas-authdomain`` = string
type ``accessschemas-autoredirecttoidentity`` = bool
///The custom URL a user is redirected to when they are denied access to the application.
type ``accessschemas-customdenyurl`` = string
///The custom pages that will be displayed when applicable for this application
type ``accessschemas-custompages`` = list<string>

///The action Access will take if a user matches this policy.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-decision`` =
    | [<CompiledName "allow">] Allow
    | [<CompiledName "deny">] Deny
    | [<CompiledName "non_identity">] Non_identity
    | [<CompiledName "bypass">] Bypass
    member this.Format() =
        match this with
        | Allow -> "allow"
        | Deny -> "deny"
        | Non_identity -> "non_identity"
        | Bypass -> "bypass"

///The domain of the Bookmark application.
type ``accessschemas-domain`` = string
///The duration for how long the service token will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. The default is 1 year in hours (8760h).
type ``accessschemas-duration`` = string
///The email of the user.
type ``accessschemas-email`` = string
type ``accessschemas-exclude`` = list<access_rule>
type ``accessschemas-gatewayseat`` = bool
///The ID of the CA.
type ``accessschemas-id`` = string
///Identifier.
type ``accessschemas-identifier`` = string
type ``accessschemas-include`` = list<access_rule>
type ``accessschemas-isuireadonly`` = bool
type ``accessschemas-isolationrequired`` = bool
///The image URL for the logo shown in the App Launcher dashboard.
type ``accessschemas-logourl`` = string
///The name of the service token.
type ``accessschemas-name`` = string
type ``accessschemas-optionspreflightbypass`` = bool
type ``accessschemas-precedence`` = int
type ``accessschemas-purposejustificationrequired`` = bool
type ``accessschemas-require`` = list<access_rule>
type ``accessschemas-scimconfigmultiauthentication`` = list<``access_schemas-scim_config_single_authentication``>
///The unique API identifier for the Zero Trust seat.
type ``accessschemas-seatuid`` = string
///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
type ``accessschemas-sessionduration`` = string

///Custom page type.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-type`` =
    | [<CompiledName "identity_denied">] Identity_denied
    | [<CompiledName "forbidden">] Forbidden
    member this.Format() =
        match this with
        | Identity_denied -> "identity_denied"
        | Forbidden -> "forbidden"

///The amount of time a user seat is inactive before it expires. When the user seat exceeds the set time of inactivity, the user is removed as an active seat and no longer counts against your Teams seat count. Must be in the format `300ms` or `2h45m`. Valid time units are: `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
type ``accessschemas-userseatexpirationinactivetime`` = string
///The UUID of the policy
type ``accessschemas-uuid`` = string
type accessscimconfigmultiauthentication = list<access_scim_config_single_authentication>
///The unique API identifier for the Zero Trust seat.
type accessseatuid = string
type accessseatsdefinition = list<access_seat>
///List of public domains that Access will secure. This field is deprecated in favor of `destinations` and will be supported until **November 21, 2025.** If `destinations` are provided, then `self_hosted_domains` will be ignored.
type accessselfhosteddomains = list<string>
///The name of the service token.
type ``accessservice-tokenscomponents-schemas-name`` = string
type accessserviceauth401redirect = bool
///The amount of time that tokens issued for applications will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
type accesssessionduration = string
///the timestamp of the earliest update log.
type accesssince = System.DateTimeOffset
type accessskipapplauncherloginpage = bool
type accessskipinterstitial = bool

///The status of the policy test request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessstatus =
    | [<CompiledName "success">] Success
    member this.Format() =
        match this with
        | Success -> "success"

///The tags you want assigned to an application. Tags are used to filter applications in the App Launcher dashboard.
type accesstags = list<string>
///The name of the tag
type ``accesstagscomponents-schemas-name`` = string
type accesstimestamp = System.DateTimeOffset
///The title shown on the landing page.
type accesstitle = string
type accesstotalusers = int

///The application type.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesstype =
    | [<CompiledName "self_hosted">] Self_hosted
    | [<CompiledName "saas">] Saas
    | [<CompiledName "ssh">] Ssh
    | [<CompiledName "vnc">] Vnc
    | [<CompiledName "app_launcher">] App_launcher
    | [<CompiledName "warp">] Warp
    | [<CompiledName "biso">] Biso
    | [<CompiledName "bookmark">] Bookmark
    | [<CompiledName "dash_sso">] Dash_sso
    | [<CompiledName "infrastructure">] Infrastructure
    | [<CompiledName "rdp">] Rdp
    | [<CompiledName "mcp">] Mcp
    | [<CompiledName "mcp_portal">] Mcp_portal
    | [<CompiledName "proxy_endpoint">] Proxy_endpoint
    member this.Format() =
        match this with
        | Self_hosted -> "self_hosted"
        | Saas -> "saas"
        | Ssh -> "ssh"
        | Vnc -> "vnc"
        | App_launcher -> "app_launcher"
        | Warp -> "warp"
        | Biso -> "biso"
        | Bookmark -> "bookmark"
        | Dash_sso -> "dash_sso"
        | Infrastructure -> "infrastructure"
        | Rdp -> "rdp"
        | Mcp -> "mcp"
        | Mcp_portal -> "mcp_portal"
        | Proxy_endpoint -> "proxy_endpoint"

///A description of the reason why the UI read only field is being toggled.
type accessuireadonlytogglereason = string
///The unique API identifier for the user.
type accessuid = string
///the timestamp of the most-recent update log.
type accessuntil = System.DateTimeOffset

///The status of the policy test.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessupdatestatus =
    | [<CompiledName "blocked">] Blocked
    | [<CompiledName "processing">] Processing
    | [<CompiledName "exceeded time">] ExceededTime
    | [<CompiledName "complete">] Complete
    member this.Format() =
        match this with
        | Blocked -> "blocked"
        | Processing -> "processing"
        | ExceededTime -> "exceeded time"
        | Complete -> "complete"

type accessuseclientlessisolationapplauncherurl = bool
///The UUID of the authenticating user.
type accessuserid = System.Guid

///Policy evaluation result for an individual user.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessuserresult =
    | [<CompiledName "approved">] Approved
    | [<CompiledName "blocked">] Blocked
    | [<CompiledName "error">] Error
    member this.Format() =
        match this with
        | Approved -> "approved"
        | Blocked -> "blocked"
        | Error -> "error"

///The amount of time a user seat is inactive before it expires. When the user seat exceeds the set time of inactivity, the user is removed as an active seat and no longer counts against your Teams seat count.  Minimum value for this setting is 1 month (730h). Must be in the format `300ms` or `2h45m`. Valid time units are: `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
type accessuserseatexpirationinactivetime = string
///The username of the SCIM User resource.
type accessusername = string
///Contains the Unix usernames that may be used when connecting over SSH.
type accessusernames = list<string>
///The unique Cloudflare-generated Id of the SCIM User resource; also known as the "Id".
type ``accessusers-cfresourceid`` = string
///The IdP-generated Id of the SCIM User resource; also known as the "external Id".
type ``accessusers-idpresourceid`` = string
///The name of the SCIM User resource.
type ``accessusers-name`` = string
type accessusersapproved = int
type accessusersblocked = int
///The name of the user.
type ``accessuserscomponents-schemas-name`` = string
type accessuserserrored = int
///UUID.
type accessuuid = string
///The amount of time that tokens issued for applications will be valid. Must be in the format `30m` or `2h45m`. Valid time units are: m, h.
type accesswarpauthsessionduration = string

type ``accessaccess-requests`` =
    { ///The event that occurred, such as a login attempt.
      action: Option<accessaction>
      ///The result of the authentication event.
      allowed: Option<accessallowed>
      ///The URL of the Access application.
      app_domain: Option<accessappdomain>
      ///The unique identifier for the Access application.
      app_uid: Option<accessappuid>
      ///The IdP used to authenticate.
      connection: Option<accessconnection>
      created_at: Option<accesstimestamp>
      ///The IP address of the authenticating user.
      ip_address: Option<accessip>
      ///The unique identifier for the request to Cloudflare.
      ray_id: Option<accessrayid>
      ///The email address of the authenticating user.
      user_email: Option<``accesscomponents-schemas-email``> }
    ///Creates an instance of accessaccess-requests with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessaccess-requests`` =
        { action = None
          allowed = None
          app_domain = None
          app_uid = None
          connection = None
          created_at = None
          ip_address = None
          ray_id = None
          user_email = None }

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

type ``accessaccess-requestscomponents-schemas-responsecollection`` =
    { errors: list<Errors>
      messages: list<Messages>
      ///Whether the API call was successful.
      success: bool
      result: Option<list<``accessaccess-requests``>> }
    ///Creates an instance of accessaccess-requestscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>, messages: list<Messages>, success: bool): ``accessaccess-requestscomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type Group =
    { ///The ID of a previously created Access group.
      id: string }
    ///Creates an instance of Group with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): Group = { id = id }

///Matches an Access group.
type accessaccessgrouprule =
    { group: Group }
    ///Creates an instance of accessaccessgrouprule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (group: Group): accessaccessgrouprule = { group = group }

type accessactivesessionresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessactivesessionresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessactivesessionresponseErrorsSource = { pointer = None }

type accessactivesessionresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessactivesessionresponseErrorsSource> }
    ///Creates an instance of accessactivesessionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessactivesessionresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessactivesessionresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessactivesessionresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessactivesessionresponseMessagesSource = { pointer = None }

type accessactivesessionresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessactivesessionresponseMessagesSource> }
    ///Creates an instance of accessactivesessionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessactivesessionresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Idp =
    { id: Option<string>
      ``type``: Option<string> }
    ///Creates an instance of Idp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Idp = { id = None; ``type`` = None }

type Mtlsauth =
    { auth_status: Option<string>
      cert_issuer_dn: Option<string>
      cert_issuer_ski: Option<string>
      cert_presented: Option<bool>
      cert_serial: Option<string> }
    ///Creates an instance of Mtlsauth with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Mtlsauth =
        { auth_status = None
          cert_issuer_dn = None
          cert_issuer_ski = None
          cert_presented = None
          cert_serial = None }

type Result =
    { account_id: Option<string>
      auth_status: Option<string>
      common_name: Option<string>
      devicePosture: Option<Map<string, ``accessschemas-deviceposturerule``>>
      device_id: Option<string>
      device_sessions: Option<Map<string, accessdevicesession>>
      email: Option<string>
      geo: Option<accessgeo>
      iat: Option<float>
      idp: Option<Idp>
      ip: Option<string>
      is_gateway: Option<bool>
      is_warp: Option<bool>
      mtls_auth: Option<Mtlsauth>
      service_token_id: Option<string>
      service_token_status: Option<bool>
      user_uuid: Option<string>
      version: Option<float>
      isActive: Option<bool> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result =
        { account_id = None
          auth_status = None
          common_name = None
          devicePosture = None
          device_id = None
          device_sessions = None
          email = None
          geo = None
          iat = None
          idp = None
          ip = None
          is_gateway = None
          is_warp = None
          mtls_auth = None
          service_token_id = None
          service_token_status = None
          user_uuid = None
          version = None
          isActive = None }

type accessactivesessionresponse =
    { errors: list<accessactivesessionresponseErrors>
      messages: list<accessactivesessionresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<Result> }
    ///Creates an instance of accessactivesessionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessactivesessionresponseErrors>,
                          messages: list<accessactivesessionresponseMessages>,
                          success: bool): accessactivesessionresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accessactivesessionsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessactivesessionsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessactivesessionsresponseErrorsSource = { pointer = None }

type accessactivesessionsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessactivesessionsresponseErrorsSource> }
    ///Creates an instance of accessactivesessionsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessactivesessionsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessactivesessionsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessactivesessionsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessactivesessionsresponseMessagesSource = { pointer = None }

type accessactivesessionsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessactivesessionsresponseMessagesSource> }
    ///Creates an instance of accessactivesessionsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessactivesessionsresponseMessages =
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

type Metadata =
    { apps: Option<Map<string, string>>
      expires: Option<int>
      iat: Option<int>
      nonce: Option<string>
      ttl: Option<int> }
    ///Creates an instance of Metadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Metadata =
        { apps = None
          expires = None
          iat = None
          nonce = None
          ttl = None }

type accessactivesessionsresponseResult =
    { expiration: Option<int>
      metadata: Option<Metadata>
      name: Option<string> }
    ///Creates an instance of accessactivesessionsresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessactivesessionsresponseResult =
        { expiration = None
          metadata = None
          name = None }

type accessactivesessionsresponse =
    { errors: list<accessactivesessionsresponseErrors>
      messages: list<accessactivesessionsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<Resultinfo>
      result: Option<list<accessactivesessionsresponseResult>> }
    ///Creates an instance of accessactivesessionsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessactivesessionsresponseErrors>,
                          messages: list<accessactivesessionsresponseMessages>,
                          success: bool): accessactivesessionsresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

///Matches any valid Access Service Token
type accessanyvalidservicetokenrule =
    { ///An empty object which matches on all service tokens.
      any_valid_service_token: Newtonsoft.Json.Linq.JObject }
    ///Creates an instance of accessanyvalidservicetokenrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (any_valid_service_token: Newtonsoft.Json.Linq.JObject): accessanyvalidservicetokenrule =
        { any_valid_service_token = any_valid_service_token }

type ``accessapi-response-collectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapi-response-collectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapi-response-collectionErrorsSource`` = { pointer = None }

type ``accessapi-response-collectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapi-response-collectionErrorsSource``> }
    ///Creates an instance of accessapi-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapi-response-collectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapi-response-collectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapi-response-collectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapi-response-collectionMessagesSource`` = { pointer = None }

type ``accessapi-response-collectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapi-response-collectionMessagesSource``> }
    ///Creates an instance of accessapi-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapi-response-collectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapi-response-collectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessapi-response-collectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapi-response-collectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessapi-response-collection`` =
    { errors: Option<list<``accessapi-response-collectionErrors``>>
      messages: Option<list<``accessapi-response-collectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``accessapi-response-collectionResultinfo``> }
    ///Creates an instance of accessapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``accessapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapi-response-commonErrorsSource`` = { pointer = None }

type ``accessapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapi-response-commonErrorsSource``> }
    ///Creates an instance of accessapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapi-response-commonMessagesSource`` = { pointer = None }

type ``accessapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapi-response-commonMessagesSource``> }
    ///Creates an instance of accessapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapi-response-common`` =
    { errors: list<``accessapi-response-commonErrors``>
      messages: list<``accessapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of accessapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessapi-response-commonErrors``>,
                          messages: list<``accessapi-response-commonMessages``>,
                          success: bool): ``accessapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``accessapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of accessapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``accessapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``accessapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapi-response-singleErrorsSource`` = { pointer = None }

type ``accessapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapi-response-singleErrorsSource``> }
    ///Creates an instance of accessapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapi-response-singleMessagesSource`` = { pointer = None }

type ``accessapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapi-response-singleMessagesSource``> }
    ///Creates an instance of accessapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapi-response-single`` =
    { errors: Option<list<``accessapi-response-singleErrors``>>
      messages: Option<list<``accessapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of accessapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapi-response-single`` =
        { errors = None
          messages = None
          success = None }

type ``accessapp-policiescomponents-schemas-idresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapp-policiescomponents-schemas-idresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapp-policiescomponents-schemas-idresponseErrorsSource`` = { pointer = None }

type ``accessapp-policiescomponents-schemas-idresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapp-policiescomponents-schemas-idresponseErrorsSource``> }
    ///Creates an instance of accessapp-policiescomponents-schemas-idresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapp-policiescomponents-schemas-idresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapp-policiescomponents-schemas-idresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapp-policiescomponents-schemas-idresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapp-policiescomponents-schemas-idresponseMessagesSource`` = { pointer = None }

type ``accessapp-policiescomponents-schemas-idresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapp-policiescomponents-schemas-idresponseMessagesSource``> }
    ///Creates an instance of accessapp-policiescomponents-schemas-idresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapp-policiescomponents-schemas-idresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapp-policiescomponents-schemas-idresponseResult`` =
    { ///UUID.
      id: Option<accessuuid> }
    ///Creates an instance of accessapp-policiescomponents-schemas-idresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapp-policiescomponents-schemas-idresponseResult`` = { id = None }

type ``accessapp-policiescomponents-schemas-idresponse`` =
    { errors: list<``accessapp-policiescomponents-schemas-idresponseErrors``>
      messages: list<``accessapp-policiescomponents-schemas-idresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``accessapp-policiescomponents-schemas-idresponseResult``> }
    ///Creates an instance of accessapp-policiescomponents-schemas-idresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessapp-policiescomponents-schemas-idresponseErrors``>,
                          messages: list<``accessapp-policiescomponents-schemas-idresponseMessages``>,
                          success: bool): ``accessapp-policiescomponents-schemas-idresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``accessapp-policiescomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapp-policiescomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapp-policiescomponents-schemas-responsecollectionErrorsSource`` =
        { pointer = None }

type ``accessapp-policiescomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapp-policiescomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessapp-policiescomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapp-policiescomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapp-policiescomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapp-policiescomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapp-policiescomponents-schemas-responsecollectionMessagesSource`` =
        { pointer = None }

type ``accessapp-policiescomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapp-policiescomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessapp-policiescomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapp-policiescomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapp-policiescomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessapp-policiescomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapp-policiescomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessapp-policiescomponents-schemas-responsecollection`` =
    { errors: list<``accessapp-policiescomponents-schemas-responsecollectionErrors``>
      messages: list<``accessapp-policiescomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accessapp-policiescomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accessapppolicyresponse>> }
    ///Creates an instance of accessapp-policiescomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessapp-policiescomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accessapp-policiescomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accessapp-policiescomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accessapp-policiescomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapp-policiescomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapp-policiescomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accessapp-policiescomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapp-policiescomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessapp-policiescomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapp-policiescomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapp-policiescomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessapp-policiescomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessapp-policiescomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accessapp-policiescomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessapp-policiescomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessapp-policiescomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessapp-policiescomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessapp-policiescomponents-schemas-singleresponse`` =
    { errors: list<``accessapp-policiescomponents-schemas-singleresponseErrors``>
      messages: list<``accessapp-policiescomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<accessapppolicyresponse> }
    ///Creates an instance of accessapp-policiescomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessapp-policiescomponents-schemas-singleresponseErrors``>,
                          messages: list<``accessapp-policiescomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accessapp-policiescomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type Footerlinks =
    { ///The hypertext in the footer link.
      name: string
      ///the hyperlink in the footer link.
      url: string }
    ///Creates an instance of Footerlinks with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, url: string): Footerlinks = { name = name; url = url }

type accessapplauncherprops =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: Option<accessdomain>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///The application type.
      ``type``: Option<accesstype>
      ///The image URL of the logo shown in the App Launcher header.
      app_launcher_logo_url: Option<accessapplauncherlogourl>
      ///The background color of the App Launcher page.
      bg_color: Option<accessbgcolor>
      ///The links in the App Launcher footer.
      footer_links: Option<list<Footerlinks>>
      ///The background color of the App Launcher header.
      header_bg_color: Option<accessheaderbgcolor>
      ///The design of the App Launcher landing page shown to users when they log in.
      landing_page_design: Option<accesslandingpagedesign>
      ///Determines when to skip the App Launcher landing page.
      skip_app_launcher_login_page: Option<accessskipapplauncherloginpage> }
    ///Creates an instance of accessapplauncherprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessapplauncherprops =
        { allowed_idps = None
          auto_redirect_to_identity = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          domain = None
          name = None
          session_duration = None
          ``type`` = None
          app_launcher_logo_url = None
          bg_color = None
          footer_links = None
          header_bg_color = None
          landing_page_design = None
          skip_app_launcher_login_page = None }

///A JSON that links a reusable policy to an application.
type accessapppolicylink =
    { ///The UUID of the policy
      id: Option<``accessschemas-uuid``>
      ///The order of execution for this policy. Must be unique for each policy within an app.
      precedence: Option<accessprecedence> }
    ///Creates an instance of accessapppolicylink with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessapppolicylink = { id = None; precedence = None }

type accessapppolicyrequest =
    { ///The order of execution for this policy. Must be unique for each policy within an app.
      precedence: Option<accessprecedence>
      ///Administrators who can approve a temporary authentication request.
      approval_groups: Option<accessapprovalgroups>
      ///Requires the user to request access from an administrator at the start of each session.
      approval_required: Option<accessapprovalrequired>
      ///The rules that define how users may connect to targets secured by your application.
      connection_rules: Option<accessconnectionrules>
      ///Require this application to be served in an isolated browser for users matching this policy. 'Client Web Isolation' must be on for the account in order to use this feature.
      isolation_required: Option<accessisolationrequired>
      ///Configures multi-factor authentication (MFA) settings.
      mfa_config: Option<accessmfaconfig>
      ///A custom message that will appear on the purpose justification screen.
      purpose_justification_prompt: Option<accesspurposejustificationprompt>
      ///Require users to enter a justification when they log in to the application.
      purpose_justification_required: Option<accesspurposejustificationrequired>
      ///The amount of time that tokens issued for the application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accesscomponents-schemas-sessionduration``>
      ///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
      decision: Option<accessdecision>
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accessschemas-exclude``>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<``accessschemas-include``>
      ///The name of the Access policy.
      name: Option<``accesspolicycomponents-schemas-name``>
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accessschemas-require``> }
    ///Creates an instance of accessapppolicyrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessapppolicyrequest =
        { precedence = None
          approval_groups = None
          approval_required = None
          connection_rules = None
          isolation_required = None
          mfa_config = None
          purpose_justification_prompt = None
          purpose_justification_required = None
          session_duration = None
          decision = None
          exclude = None
          ``include`` = None
          name = None
          require = None }

type accessapppolicyresponse =
    { ///Administrators who can approve a temporary authentication request.
      approval_groups: Option<accessapprovalgroups>
      ///Requires the user to request access from an administrator at the start of each session.
      approval_required: Option<accessapprovalrequired>
      ///The rules that define how users may connect to targets secured by your application.
      connection_rules: Option<accessconnectionrules>
      ///Require this application to be served in an isolated browser for users matching this policy. 'Client Web Isolation' must be on for the account in order to use this feature.
      isolation_required: Option<accessisolationrequired>
      ///Configures multi-factor authentication (MFA) settings.
      mfa_config: Option<accessmfaconfig>
      ///A custom message that will appear on the purpose justification screen.
      purpose_justification_prompt: Option<accesspurposejustificationprompt>
      ///Require users to enter a justification when they log in to the application.
      purpose_justification_required: Option<accesspurposejustificationrequired>
      ///The amount of time that tokens issued for the application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accesscomponents-schemas-sessionduration``>
      created_at: Option<accesstimestamp>
      ///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
      decision: Option<accessdecision>
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accessschemas-exclude``>
      ///The UUID of the policy
      id: Option<``accessschemas-uuid``>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<``accessschemas-include``>
      ///The name of the Access policy.
      name: Option<``accesspolicycomponents-schemas-name``>
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accessschemas-require``>
      updated_at: Option<accesstimestamp>
      ///The order of execution for this policy. Must be unique for each policy within an app.
      precedence: Option<accessprecedence> }
    ///Creates an instance of accessapppolicyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessapppolicyresponse =
        { approval_groups = None
          approval_required = None
          connection_rules = None
          isolation_required = None
          mfa_config = None
          purpose_justification_prompt = None
          purpose_justification_required = None
          session_duration = None
          created_at = None
          decision = None
          exclude = None
          id = None
          ``include`` = None
          name = None
          require = None
          updated_at = None
          precedence = None }

type accessappreqembeddedpolicies =
    { ///The policies that Access applies to the application, in ascending order of precedence. Items can reference existing policies or create new policies exclusive to the application.
      policies: Option<list<string>> }
    ///Creates an instance of accessappreqembeddedpolicies with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessappreqembeddedpolicies = { policies = None }

type accessappreqembeddedscimconfig =
    { ///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
      scim_config: Option<accessscimconfig> }
    ///Creates an instance of accessappreqembeddedscimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessappreqembeddedscimconfig = { scim_config = None }

///The policies that Access applies to the application.
type accessapprespembeddedpolicies =
    { policies: Option<list<accessapppolicyresponse>> }
    ///Creates an instance of accessapprespembeddedpolicies with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessapprespembeddedpolicies = { policies = None }

///Contains the targets secured by the application.
type accessapprespembeddedtargetcriteriainfra =
    { target_criteria: Option<list<accesstargetcriteriainfraapp>> }
    ///Creates an instance of accessapprespembeddedtargetcriteriainfra with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessapprespembeddedtargetcriteriainfra = { target_criteria = None }

///Contains the targets secured by the application.
type accessapprespembeddedtargetcriteriaselfhosted =
    { target_criteria: Option<list<accesstargetcriteriaselfhostedapp>> }
    ///Creates an instance of accessapprespembeddedtargetcriteriaselfhosted with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessapprespembeddedtargetcriteriaselfhosted = { target_criteria = None }

type accessappsettingsrequest =
    { ///Enables loading application content in an iFrame.
      allow_iframe: Option<accessallowiframe>
      ///Enables automatic authentication through cloudflared.
      skip_interstitial: Option<accessskipinterstitial> }
    ///Creates an instance of accessappsettingsrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessappsettingsrequest =
        { allow_iframe = None
          skip_interstitial = None }

type accessappsettingsresponse =
    { ///Enables loading application content in an iFrame.
      allow_iframe: Option<accessallowiframe>
      ///Enables automatic authentication through cloudflared.
      skip_interstitial: Option<accessskipinterstitial> }
    ///Creates an instance of accessappsettingsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessappsettingsresponse =
        { allow_iframe = None
          skip_interstitial = None }

///A group of email addresses that can approve a temporary authentication request.
type accessapprovalgroup =
    { ///The number of approvals needed to obtain access.
      approvals_needed: float
      ///A list of emails that can approve the access request.
      email_addresses: Option<list<string>>
      ///The UUID of an re-usable email list.
      email_list_uuid: Option<string> }
    ///Creates an instance of accessapprovalgroup with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (approvals_needed: float): accessapprovalgroup =
        { approvals_needed = approvals_needed
          email_addresses = None
          email_list_uuid = None }

type accessapps = Map<string, Newtonsoft.Json.Linq.JToken>

type ``accessappscomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessappscomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accessappscomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessappscomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessappscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessappscomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessappscomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessappscomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accessappscomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessappscomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessappscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessappscomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessappscomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessappscomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessappscomponents-schemas-responsecollection`` =
    { errors: list<``accessappscomponents-schemas-responsecollectionErrors``>
      messages: list<``accessappscomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accessappscomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accessappresponse>> }
    ///Creates an instance of accessappscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessappscomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accessappscomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accessappscomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accessappscomponents-schemas-responsecollection-2ErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessappscomponents-schemas-responsecollection-2ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-responsecollection-2ErrorsSource`` = { pointer = None }

type ``accessappscomponents-schemas-responsecollection-2Errors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessappscomponents-schemas-responsecollection-2ErrorsSource``> }
    ///Creates an instance of accessappscomponents-schemas-responsecollection-2Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessappscomponents-schemas-responsecollection-2Errors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessappscomponents-schemas-responsecollection-2MessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessappscomponents-schemas-responsecollection-2MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-responsecollection-2MessagesSource`` = { pointer = None }

type ``accessappscomponents-schemas-responsecollection-2Messages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessappscomponents-schemas-responsecollection-2MessagesSource``> }
    ///Creates an instance of accessappscomponents-schemas-responsecollection-2Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessappscomponents-schemas-responsecollection-2Messages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessappscomponents-schemas-responsecollection-2Resultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessappscomponents-schemas-responsecollection-2Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-responsecollection-2Resultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessappscomponents-schemas-responsecollection-2`` =
    { errors: Option<list<``accessappscomponents-schemas-responsecollection-2Errors``>>
      messages: Option<list<``accessappscomponents-schemas-responsecollection-2Messages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``accessappscomponents-schemas-responsecollection-2Resultinfo``>
      result: Option<list<accessapps>> }
    ///Creates an instance of accessappscomponents-schemas-responsecollection-2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-responsecollection-2`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``accessappscomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessappscomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accessappscomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessappscomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessappscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessappscomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessappscomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessappscomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accessappscomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessappscomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessappscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessappscomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessappscomponents-schemas-singleresponse`` =
    { errors: list<``accessappscomponents-schemas-singleresponseErrors``>
      messages: list<``accessappscomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accessappscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessappscomponents-schemas-singleresponseErrors``>,
                          messages: list<``accessappscomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accessappscomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``accessappscomponents-schemas-singleresponse-2ErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessappscomponents-schemas-singleresponse-2ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-singleresponse-2ErrorsSource`` = { pointer = None }

type ``accessappscomponents-schemas-singleresponse-2Errors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessappscomponents-schemas-singleresponse-2ErrorsSource``> }
    ///Creates an instance of accessappscomponents-schemas-singleresponse-2Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessappscomponents-schemas-singleresponse-2Errors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessappscomponents-schemas-singleresponse-2MessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessappscomponents-schemas-singleresponse-2MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-singleresponse-2MessagesSource`` = { pointer = None }

type ``accessappscomponents-schemas-singleresponse-2Messages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessappscomponents-schemas-singleresponse-2MessagesSource``> }
    ///Creates an instance of accessappscomponents-schemas-singleresponse-2Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessappscomponents-schemas-singleresponse-2Messages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessappscomponents-schemas-singleresponse-2`` =
    { errors: Option<list<``accessappscomponents-schemas-singleresponse-2Errors``>>
      messages: Option<list<``accessappscomponents-schemas-singleresponse-2Messages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<accessapps> }
    ///Creates an instance of accessappscomponents-schemas-singleresponse-2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessappscomponents-schemas-singleresponse-2`` =
        { errors = None
          messages = None
          success = None
          result = None }

type Authcontext =
    { ///The ACID of an Authentication context.
      ac_id: string
      ///The ID of an Authentication context.
      id: string
      ///The ID of your Azure identity provider.
      identity_provider_id: string }
    ///Creates an instance of Authcontext with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ac_id: string, id: string, identity_provider_id: string): Authcontext =
        { ac_id = ac_id
          id = id
          identity_provider_id = identity_provider_id }

///Matches an Azure Authentication Context.
///Requires an Azure identity provider.
type accessauthcontextrule =
    { auth_context: Authcontext }
    ///Creates an instance of accessauthcontextrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (auth_context: Authcontext): accessauthcontextrule = { auth_context = auth_context }

type Authmethod =
    { ///The type of authentication method https://datatracker.ietf.org/doc/html/rfc8176#section-2.
      auth_method: string }
    ///Creates an instance of Authmethod with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (auth_method: string): Authmethod = { auth_method = auth_method }

///Enforce different MFA options
type accessauthenticationmethodrule =
    { auth_method: Authmethod }
    ///Creates an instance of accessauthenticationmethodrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (auth_method: Authmethod): accessauthenticationmethodrule = { auth_method = auth_method }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Identityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type Scimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<Identityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of Scimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Scimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Prompt =
    | [<CompiledName "login">] Login
    | [<CompiledName "select_account">] Select_account
    | [<CompiledName "none">] None
    member this.Format() =
        match this with
        | Login -> "login"
        | Select_account -> "select_account"
        | None -> "none"

type Config =
    { ///Your OAuth Client ID
      client_id: Option<string>
      ///Your OAuth Client Secret
      client_secret: Option<string>
      ///Custom claims
      claims: Option<list<string>>
      ///The claim name for email in the id_token response.
      email_claim_name: Option<string>
      ///Should Cloudflare try to load authentication contexts from your account
      conditional_access_enabled: Option<bool>
      ///Your Azure directory uuid
      directory_id: Option<string>
      ///Indicates the type of user interaction that is required. prompt=login forces the user to enter their credentials on that request, negating single-sign on. prompt=none is the opposite. It ensures that the user isn't presented with any interactive prompt. If the request can't be completed silently by using single-sign on, the Microsoft identity platform returns an interaction_required error. prompt=select_account interrupts single sign-on providing account selection experience listing all the accounts either in session or any remembered account or an option to choose to use a different account altogether.
      prompt: Option<Prompt>
      ///Should Cloudflare try to load groups from your account
      support_groups: Option<bool> }
    ///Creates an instance of Config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Config =
        { client_id = None
          client_secret = None
          claims = None
          email_claim_name = None
          conditional_access_enabled = None
          directory_id = None
          prompt = None
          support_groups = None }

type accessazureAD =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<Scimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<Type> }
    ///Creates an instance of accessazureAD with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessazureAD =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type AzureAD =
    { ///The ID of an Azure group.
      id: string
      ///The ID of your Azure identity provider.
      identity_provider_id: string }
    ///Creates an instance of AzureAD with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string, identity_provider_id: string): AzureAD =
        { id = id
          identity_provider_id = identity_provider_id }

///Matches an Azure group.
///Requires an Azure identity provider.
type accessazuregrouprule =
    { azureAD: AzureAD }
    ///Creates an instance of accessazuregrouprule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (azureAD: AzureAD): accessazuregrouprule = { azureAD = azureAD }

type accessbasepolicyreq =
    { ///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
      decision: accessdecision
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accessschemas-exclude``>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: ``accessschemas-include``
      ///The name of the Access policy.
      name: ``accesspolicycomponents-schemas-name``
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accessschemas-require``> }
    ///Creates an instance of accessbasepolicyreq with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (decision: accessdecision,
                          ``include``: ``accessschemas-include``,
                          name: ``accesspolicycomponents-schemas-name``): accessbasepolicyreq =
        { decision = decision
          exclude = None
          ``include`` = ``include``
          name = name
          require = None }

type accessbasepolicyresp =
    { created_at: Option<accesstimestamp>
      ///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
      decision: Option<accessdecision>
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accessschemas-exclude``>
      ///The UUID of the policy
      id: Option<``accessschemas-uuid``>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<``accessschemas-include``>
      ///The name of the Access policy.
      name: Option<``accesspolicycomponents-schemas-name``>
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accessschemas-require``>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accessbasepolicyresp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessbasepolicyresp =
        { created_at = None
          decision = None
          exclude = None
          id = None
          ``include`` = None
          name = None
          require = None
          updated_at = None }

type accessbasicappresponseprops =
    { ///Audience tag.
      aud: Option<``accessschemas-aud``>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      ///UUID.
      id: Option<accessuuid>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accessbasicappresponseprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessbasicappresponseprops =
        { aud = None
          created_at = None
          id = None
          updated_at = None }

type accessbisoprops =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: Option<accessdomain>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///The application type.
      ``type``: Option<accesstype> }
    ///Creates an instance of accessbisoprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessbisoprops =
        { allowed_idps = None
          auto_redirect_to_identity = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          domain = None
          name = None
          session_duration = None
          ``type`` = None }

type accessbookmarkprops =
    { ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///The URL or domain of the bookmark.
      domain: Option<string>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The tags you want assigned to an application. Tags are used to filter applications in the App Launcher dashboard.
      tags: Option<accesstags>
      ///The application type.
      ``type``: Option<accesstype> }
    ///Creates an instance of accessbookmarkprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessbookmarkprops =
        { app_launcher_visible = None
          domain = None
          logo_url = None
          name = None
          tags = None
          ``type`` = None }

type accessbookmarks =
    { ///Displays the application in the App Launcher.
      app_launcher_visible: Option<``accessschemas-applaunchervisible``>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      ///The domain of the Bookmark application.
      domain: Option<``accessschemas-domain``>
      ///The unique identifier for the Bookmark application.
      id: Option<string>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<``accessschemas-logourl``>
      ///The name of the Bookmark application.
      name: Option<``accessbookmarkscomponents-schemas-name``>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accessbookmarks with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessbookmarks =
        { app_launcher_visible = None
          created_at = None
          domain = None
          id = None
          logo_url = None
          name = None
          updated_at = None }

type ``accessbookmarkscomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessbookmarkscomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessbookmarkscomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accessbookmarkscomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessbookmarkscomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessbookmarkscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessbookmarkscomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessbookmarkscomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessbookmarkscomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessbookmarkscomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accessbookmarkscomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessbookmarkscomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessbookmarkscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessbookmarkscomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessbookmarkscomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessbookmarkscomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessbookmarkscomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessbookmarkscomponents-schemas-responsecollection`` =
    { errors: list<``accessbookmarkscomponents-schemas-responsecollectionErrors``>
      messages: list<``accessbookmarkscomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accessbookmarkscomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accessbookmarks>> }
    ///Creates an instance of accessbookmarkscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessbookmarkscomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accessbookmarkscomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accessbookmarkscomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accessbookmarkscomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessbookmarkscomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessbookmarkscomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accessbookmarkscomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessbookmarkscomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessbookmarkscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessbookmarkscomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessbookmarkscomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessbookmarkscomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessbookmarkscomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accessbookmarkscomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessbookmarkscomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessbookmarkscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessbookmarkscomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessbookmarkscomponents-schemas-singleresponse`` =
    { errors: list<``accessbookmarkscomponents-schemas-singleresponseErrors``>
      messages: list<``accessbookmarkscomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<accessbookmarks> }
    ///Creates an instance of accessbookmarkscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessbookmarkscomponents-schemas-singleresponseErrors``>,
                          messages: list<``accessbookmarkscomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accessbookmarkscomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accessca =
    { ///The Application Audience (AUD) tag. Identifies the application associated with the CA.
      aud: Option<accessaud>
      ///The ID of the CA.
      id: Option<``accessschemas-id``>
      ///The public key to add to your SSH server configuration.
      public_key: Option<accesspublickey> }
    ///Creates an instance of accessca with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessca =
        { aud = None
          id = None
          public_key = None }

type ``accesscacomponents-schemas-idresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-idresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-idresponseErrorsSource`` = { pointer = None }

type ``accesscacomponents-schemas-idresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-idresponseErrorsSource``> }
    ///Creates an instance of accesscacomponents-schemas-idresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-idresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-idresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-idresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-idresponseMessagesSource`` = { pointer = None }

type ``accesscacomponents-schemas-idresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-idresponseMessagesSource``> }
    ///Creates an instance of accesscacomponents-schemas-idresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-idresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-idresponseResult`` =
    { ///The ID of the CA.
      id: Option<``accesscomponents-schemas-id``> }
    ///Creates an instance of accesscacomponents-schemas-idresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-idresponseResult`` = { id = None }

type ``accesscacomponents-schemas-idresponse`` =
    { errors: Option<list<``accesscacomponents-schemas-idresponseErrors``>>
      messages: Option<list<``accesscacomponents-schemas-idresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<``accesscacomponents-schemas-idresponseResult``> }
    ///Creates an instance of accesscacomponents-schemas-idresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-idresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``accesscacomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accesscacomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accesscacomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accesscacomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accesscacomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accesscacomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accesscacomponents-schemas-responsecollection`` =
    { errors: list<``accesscacomponents-schemas-responsecollectionErrors``>
      messages: list<``accesscacomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accesscacomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accessca>> }
    ///Creates an instance of accesscacomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesscacomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accesscacomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accesscacomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accesscacomponents-schemas-responsecollection-2ErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-responsecollection-2ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-responsecollection-2ErrorsSource`` = { pointer = None }

type ``accesscacomponents-schemas-responsecollection-2Errors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-responsecollection-2ErrorsSource``> }
    ///Creates an instance of accesscacomponents-schemas-responsecollection-2Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-responsecollection-2Errors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-responsecollection-2MessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-responsecollection-2MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-responsecollection-2MessagesSource`` = { pointer = None }

type ``accesscacomponents-schemas-responsecollection-2Messages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-responsecollection-2MessagesSource``> }
    ///Creates an instance of accesscacomponents-schemas-responsecollection-2Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-responsecollection-2Messages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-responsecollection-2Resultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accesscacomponents-schemas-responsecollection-2Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-responsecollection-2Resultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accesscacomponents-schemas-responsecollection-2`` =
    { errors: Option<list<``accesscacomponents-schemas-responsecollection-2Errors``>>
      messages: Option<list<``accesscacomponents-schemas-responsecollection-2Messages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``accesscacomponents-schemas-responsecollection-2Resultinfo``>
      result: Option<list<``accessschemas-ca``>> }
    ///Creates an instance of accesscacomponents-schemas-responsecollection-2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-responsecollection-2`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``accesscacomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accesscacomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accesscacomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accesscacomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accesscacomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-singleresponse`` =
    { errors: list<``accesscacomponents-schemas-singleresponseErrors``>
      messages: list<``accesscacomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<accessca> }
    ///Creates an instance of accesscacomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesscacomponents-schemas-singleresponseErrors``>,
                          messages: list<``accesscacomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accesscacomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``accesscacomponents-schemas-singleresponse-2ErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-singleresponse-2ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-singleresponse-2ErrorsSource`` = { pointer = None }

type ``accesscacomponents-schemas-singleresponse-2Errors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-singleresponse-2ErrorsSource``> }
    ///Creates an instance of accesscacomponents-schemas-singleresponse-2Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-singleresponse-2Errors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-singleresponse-2MessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscacomponents-schemas-singleresponse-2MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-singleresponse-2MessagesSource`` = { pointer = None }

type ``accesscacomponents-schemas-singleresponse-2Messages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscacomponents-schemas-singleresponse-2MessagesSource``> }
    ///Creates an instance of accesscacomponents-schemas-singleresponse-2Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscacomponents-schemas-singleresponse-2Messages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscacomponents-schemas-singleresponse-2`` =
    { errors: Option<list<``accesscacomponents-schemas-singleresponse-2Errors``>>
      messages: Option<list<``accesscacomponents-schemas-singleresponse-2Messages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<``accessschemas-ca``> }
    ///Creates an instance of accesscacomponents-schemas-singleresponse-2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscacomponents-schemas-singleresponse-2`` =
        { errors = None
          messages = None
          success = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesscentrifyScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accesscentrifyScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accesscentrifyScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accesscentrifyScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesscentrifyScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesscentrifyType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accesscentrify =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accesscentrifyScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accesscentrifyType> }
    ///Creates an instance of accesscentrify with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesscentrify =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

///Matches any valid client certificate.
type accesscertificaterule =
    { certificate: Newtonsoft.Json.Linq.JObject }
    ///Creates an instance of accesscertificaterule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (certificate: Newtonsoft.Json.Linq.JObject): accesscertificaterule =
        { certificate = certificate }

type accesscertificates =
    { ///The hostnames of the applications that will use this certificate.
      associated_hostnames: Option<accessassociatedhostnames>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      expires_on: Option<accesstimestamp>
      ///The MD5 fingerprint of the certificate.
      fingerprint: Option<accessfingerprint>
      ///The ID of the application that will use this certificate.
      id: Option<string>
      ///The name of the certificate.
      name: Option<``accesscertificatescomponents-schemas-name``>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accesscertificates with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesscertificates =
        { associated_hostnames = None
          created_at = None
          expires_on = None
          fingerprint = None
          id = None
          name = None
          updated_at = None }

type ``accesscertificatescomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-responsecollectionErrorsSource`` =
        { pointer = None }

type ``accesscertificatescomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscertificatescomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscertificatescomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscertificatescomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-responsecollectionMessagesSource`` =
        { pointer = None }

type ``accesscertificatescomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscertificatescomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscertificatescomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscertificatescomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accesscertificatescomponents-schemas-responsecollection`` =
    { errors: list<``accesscertificatescomponents-schemas-responsecollectionErrors``>
      messages: list<``accesscertificatescomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accesscertificatescomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accesscertificates>> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesscertificatescomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accesscertificatescomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accesscertificatescomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accesscertificatescomponents-schemas-responsecollection-2ErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollection-2ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-responsecollection-2ErrorsSource`` =
        { pointer = None }

type ``accesscertificatescomponents-schemas-responsecollection-2Errors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscertificatescomponents-schemas-responsecollection-2ErrorsSource``> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollection-2Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscertificatescomponents-schemas-responsecollection-2Errors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscertificatescomponents-schemas-responsecollection-2MessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollection-2MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-responsecollection-2MessagesSource`` =
        { pointer = None }

type ``accesscertificatescomponents-schemas-responsecollection-2Messages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscertificatescomponents-schemas-responsecollection-2MessagesSource``> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollection-2Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscertificatescomponents-schemas-responsecollection-2Messages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscertificatescomponents-schemas-responsecollection-2Resultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollection-2Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-responsecollection-2Resultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accesscertificatescomponents-schemas-responsecollection-2`` =
    { errors: Option<list<``accesscertificatescomponents-schemas-responsecollection-2Errors``>>
      messages: Option<list<``accesscertificatescomponents-schemas-responsecollection-2Messages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``accesscertificatescomponents-schemas-responsecollection-2Resultinfo``>
      result: Option<list<``accesscomponents-schemas-certificates``>> }
    ///Creates an instance of accesscertificatescomponents-schemas-responsecollection-2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-responsecollection-2`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``accesscertificatescomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accesscertificatescomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscertificatescomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscertificatescomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscertificatescomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accesscertificatescomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscertificatescomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscertificatescomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscertificatescomponents-schemas-singleresponse`` =
    { errors: list<``accesscertificatescomponents-schemas-singleresponseErrors``>
      messages: list<``accesscertificatescomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<accesscertificates> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesscertificatescomponents-schemas-singleresponseErrors``>,
                          messages: list<``accesscertificatescomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accesscertificatescomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``accesscertificatescomponents-schemas-singleresponse-2ErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponse-2ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-singleresponse-2ErrorsSource`` = { pointer = None }

type ``accesscertificatescomponents-schemas-singleresponse-2Errors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscertificatescomponents-schemas-singleresponse-2ErrorsSource``> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponse-2Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscertificatescomponents-schemas-singleresponse-2Errors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscertificatescomponents-schemas-singleresponse-2MessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponse-2MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-singleresponse-2MessagesSource`` =
        { pointer = None }

type ``accesscertificatescomponents-schemas-singleresponse-2Messages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscertificatescomponents-schemas-singleresponse-2MessagesSource``> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponse-2Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscertificatescomponents-schemas-singleresponse-2Messages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscertificatescomponents-schemas-singleresponse-2`` =
    { errors: Option<list<``accesscertificatescomponents-schemas-singleresponse-2Errors``>>
      messages: Option<list<``accesscertificatescomponents-schemas-singleresponse-2Messages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<``accesscomponents-schemas-certificates``> }
    ///Creates an instance of accesscertificatescomponents-schemas-singleresponse-2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscertificatescomponents-schemas-singleresponse-2`` =
        { errors = None
          messages = None
          success = None
          result = None }

type Commonname =
    { ///The common name to match.
      common_name: string }
    ///Creates an instance of Commonname with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (common_name: string): Commonname = { common_name = common_name }

///Matches a specific common name.
type accesscommonnamerule =
    { common_name: Commonname }
    ///Creates an instance of accesscommonnamerule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (common_name: Commonname): accesscommonnamerule = { common_name = common_name }

type ``accesscomponents-schemas-certificates`` =
    { ///The hostnames of the applications that will use this certificate.
      associated_hostnames: Option<``accessschemas-associatedhostnames``>
      created_at: Option<accesstimestamp>
      expires_on: Option<accesstimestamp>
      ///The MD5 fingerprint of the certificate.
      fingerprint: Option<accessfingerprint>
      ///The ID of the application that will use this certificate.
      id: Option<Newtonsoft.Json.Linq.JToken>
      ///The name of the certificate.
      name: Option<``accesscertificatescomponents-schemas-name-2``>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accesscomponents-schemas-certificates with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-certificates`` =
        { associated_hostnames = None
          created_at = None
          expires_on = None
          fingerprint = None
          id = None
          name = None
          updated_at = None }

type ``accesscomponents-schemas-groups`` =
    { created_at: Option<accesstimestamp>
      ///Rules evaluated with a NOT logical operator. To match a policy, a user cannot meet any of the Exclude rules.
      exclude: Option<accessexclude>
      ///UUID.
      id: Option<accessuuid>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<accessinclude>
      ///The name of the Access group.
      name: Option<``accessgroupscomponents-schemas-name-2``>
      ///Rules evaluated with an AND logical operator. To match a policy, a user must meet all of the Require rules.
      require: Option<accessrequire>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accesscomponents-schemas-groups with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-groups`` =
        { created_at = None
          exclude = None
          id = None
          ``include`` = None
          name = None
          require = None
          updated_at = None }

type ``accesscomponents-schemas-idresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscomponents-schemas-idresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-idresponseErrorsSource`` = { pointer = None }

type ``accesscomponents-schemas-idresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscomponents-schemas-idresponseErrorsSource``> }
    ///Creates an instance of accesscomponents-schemas-idresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscomponents-schemas-idresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscomponents-schemas-idresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscomponents-schemas-idresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-idresponseMessagesSource`` = { pointer = None }

type ``accesscomponents-schemas-idresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscomponents-schemas-idresponseMessagesSource``> }
    ///Creates an instance of accesscomponents-schemas-idresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscomponents-schemas-idresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscomponents-schemas-idresponseResult`` =
    { ///UUID.
      id: Option<accessuuid> }
    ///Creates an instance of accesscomponents-schemas-idresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-idresponseResult`` = { id = None }

type ``accesscomponents-schemas-idresponse`` =
    { errors: list<``accesscomponents-schemas-idresponseErrors``>
      messages: list<``accesscomponents-schemas-idresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``accesscomponents-schemas-idresponseResult``> }
    ///Creates an instance of accesscomponents-schemas-idresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesscomponents-schemas-idresponseErrors``>,
                          messages: list<``accesscomponents-schemas-idresponseMessages``>,
                          success: bool): ``accesscomponents-schemas-idresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``accesscomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accesscomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accesscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accesscomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accesscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accesscomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accesscomponents-schemas-responsecollection`` =
    { errors: list<``accesscomponents-schemas-responsecollectionErrors``>
      messages: list<``accesscomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accesscomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<``accessservice-tokens``>> }
    ///Creates an instance of accesscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesscomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accesscomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accesscomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accesscomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accesscomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accesscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accesscomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accesscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscomponents-schemas-singleresponse`` =
    { errors: list<``accesscomponents-schemas-singleresponseErrors``>
      messages: list<``accesscomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``accessidentity-providers``> }
    ///Creates an instance of accesscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesscomponents-schemas-singleresponseErrors``>,
                          messages: list<``accesscomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accesscomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

///The rules that define how users may connect to targets secured by your application.
type accessconnectionrules =
    { ///The RDP-specific rules that define clipboard behavior for RDP connections.
      rdp: Option<accessconnectionrulesrdp> }
    ///Creates an instance of accessconnectionrules with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessconnectionrules = { rdp = None }

///The rules that define how users may connect to the targets secured by your application.
type accessconnectionrulesinfra =
    { ///The SSH-specific rules that define how users may connect to the targets secured by your application.
      ssh: Option<accessconnectionrulesssh> }
    ///Creates an instance of accessconnectionrulesinfra with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessconnectionrulesinfra = { ssh = None }

///The RDP-specific rules that define clipboard behavior for RDP connections.
type accessconnectionrulesrdp =
    { ///Clipboard formats allowed when copying from local machine to remote RDP session.
      allowed_clipboard_local_to_remote_formats: Option<list<accessrdpclipboardformat>>
      ///Clipboard formats allowed when copying from remote RDP session to local machine.
      allowed_clipboard_remote_to_local_formats: Option<list<accessrdpclipboardformat>> }
    ///Creates an instance of accessconnectionrulesrdp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessconnectionrulesrdp =
        { allowed_clipboard_local_to_remote_formats = None
          allowed_clipboard_remote_to_local_formats = None }

///The SSH-specific rules that define how users may connect to the targets secured by your application.
type accessconnectionrulesssh =
    { ///Enables using Identity Provider email alias as SSH username.
      allow_email_alias: Option<accessallowemailalias>
      ///Contains the Unix usernames that may be used when connecting over SSH.
      usernames: accessusernames }
    ///Creates an instance of accessconnectionrulesssh with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (usernames: accessusernames): accessconnectionrulesssh =
        { allow_email_alias = None
          usernames = usernames }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Allowed_methods =
    | [<CompiledName "GET">] GET
    | [<CompiledName "POST">] POST
    | [<CompiledName "HEAD">] HEAD
    | [<CompiledName "PUT">] PUT
    | [<CompiledName "DELETE">] DELETE
    | [<CompiledName "CONNECT">] CONNECT
    | [<CompiledName "OPTIONS">] OPTIONS
    | [<CompiledName "TRACE">] TRACE
    | [<CompiledName "PATCH">] PATCH
    member this.Format() =
        match this with
        | GET -> "GET"
        | POST -> "POST"
        | HEAD -> "HEAD"
        | PUT -> "PUT"
        | DELETE -> "DELETE"
        | CONNECT -> "CONNECT"
        | OPTIONS -> "OPTIONS"
        | TRACE -> "TRACE"
        | PATCH -> "PATCH"

type accesscorsheaders =
    { ///Allows all HTTP request headers.
      allow_all_headers: Option<accessallowallheaders>
      ///Allows all HTTP request methods.
      allow_all_methods: Option<accessallowallmethods>
      ///Allows all origins.
      allow_all_origins: Option<accessallowallorigins>
      ///When set to `true`, includes credentials (cookies, authorization headers, or TLS client certificates) with requests.
      allow_credentials: Option<accessallowcredentials>
      ///Allowed HTTP request headers.
      allowed_headers: Option<accessallowedheaders>
      ///Allowed HTTP request methods.
      allowed_methods: Option<list<Allowed_methods>>
      ///Allowed origins.
      allowed_origins: Option<accessallowedorigins>
      ///The maximum number of seconds the results of a preflight request can be cached.
      max_age: Option<accessmaxage> }
    ///Creates an instance of accesscorsheaders with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesscorsheaders =
        { allow_all_headers = None
          allow_all_methods = None
          allow_all_origins = None
          allow_credentials = None
          allowed_headers = None
          allowed_methods = None
          allowed_origins = None
          max_age = None }

type Geo =
    { ///The country code that should be matched.
      country_code: string }
    ///Creates an instance of Geo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (country_code: string): Geo = { country_code = country_code }

///Matches a specific country
type accesscountryrule =
    { geo: Geo }
    ///Creates an instance of accesscountryrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (geo: Geo): accesscountryrule = { geo = geo }

type accesscreateresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesscreateresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesscreateresponseErrorsSource = { pointer = None }

type accesscreateresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesscreateresponseErrorsSource> }
    ///Creates an instance of accesscreateresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesscreateresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesscreateresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesscreateresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesscreateresponseMessagesSource = { pointer = None }

type accesscreateresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesscreateresponseMessagesSource> }
    ///Creates an instance of accesscreateresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesscreateresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesscreateresponseResult =
    { ///The Client ID for the service token. Access will check for this value in the `CF-Access-Client-ID` request header.
      client_id: Option<accessclientid>
      ///The Client Secret for the service token. Access will check for this value in the `CF-Access-Client-Secret` request header.
      client_secret: Option<accessclientsecret>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      ///The duration for how long the service token will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. The default is 1 year in hours (8760h).
      duration: Option<accessduration>
      ///The ID of the service token.
      id: Option<string>
      ///The name of the service token.
      name: Option<``accessschemas-name``>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accesscreateresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesscreateresponseResult =
        { client_id = None
          client_secret = None
          created_at = None
          duration = None
          id = None
          name = None
          updated_at = None }

type accesscreateresponse =
    { errors: list<accesscreateresponseErrors>
      messages: list<accesscreateresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<accesscreateresponseResult> }
    ///Creates an instance of accesscreateresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accesscreateresponseErrors>,
                          messages: list<accesscreateresponseMessages>,
                          success: bool): accesscreateresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accesscreatedat = Map<string, Newtonsoft.Json.Linq.JToken>

type ``accesscustom-claims-support`` =
    { ///Custom claims
      claims: Option<list<string>>
      ///The claim name for email in the id_token response.
      email_claim_name: Option<string> }
    ///Creates an instance of accesscustom-claims-support with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscustom-claims-support`` =
        { claims = None
          email_claim_name = None }

type ``accesscustom-pagescomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscustom-pagescomponents-schemas-responsecollectionErrorsSource`` =
        { pointer = None }

type ``accesscustom-pagescomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscustom-pagescomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscustom-pagescomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscustom-pagescomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscustom-pagescomponents-schemas-responsecollectionMessagesSource`` =
        { pointer = None }

type ``accesscustom-pagescomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscustom-pagescomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscustom-pagescomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscustom-pagescomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscustom-pagescomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accesscustom-pagescomponents-schemas-responsecollection`` =
    { errors: list<``accesscustom-pagescomponents-schemas-responsecollectionErrors``>
      messages: list<``accesscustom-pagescomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accesscustom-pagescomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accesscustompagewithouthtml>> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesscustom-pagescomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accesscustom-pagescomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accesscustom-pagescomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accesscustom-pagescomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscustom-pagescomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accesscustom-pagescomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscustom-pagescomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscustom-pagescomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscustom-pagescomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesscustom-pagescomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accesscustom-pagescomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesscustom-pagescomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesscustom-pagescomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesscustom-pagescomponents-schemas-singleresponse`` =
    { errors: list<``accesscustom-pagescomponents-schemas-singleresponseErrors``>
      messages: list<``accesscustom-pagescomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<accesscustompage> }
    ///Creates an instance of accesscustom-pagescomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesscustom-pagescomponents-schemas-singleresponseErrors``>,
                          messages: list<``accesscustom-pagescomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accesscustom-pagescomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accesscustompage =
    { ///Number of apps the custom page is assigned to.
      app_count: Option<``accessschemas-appcount``>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      ///Custom page HTML.
      custom_html: string
      ///Custom page name.
      name: ``accesscustom-pagescomponents-schemas-name``
      ///Custom page type.
      ``type``: ``accessschemas-type``
      ///UUID.
      uid: Option<accessuuid>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accesscustompage with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (custom_html: string,
                          name: ``accesscustom-pagescomponents-schemas-name``,
                          ``type``: ``accessschemas-type``): accesscustompage =
        { app_count = None
          created_at = None
          custom_html = custom_html
          name = name
          ``type`` = ``type``
          uid = None
          updated_at = None }

type accesscustompagewithouthtml =
    { ///Number of apps the custom page is assigned to.
      app_count: Option<``accessschemas-appcount``>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      ///Custom page name.
      name: ``accesscustom-pagescomponents-schemas-name``
      ///Custom page type.
      ``type``: ``accessschemas-type``
      ///UUID.
      uid: Option<accessuuid>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accesscustompagewithouthtml with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``accesscustom-pagescomponents-schemas-name``, ``type``: ``accessschemas-type``): accesscustompagewithouthtml =
        { app_count = None
          created_at = None
          name = name
          ``type`` = ``type``
          uid = None
          updated_at = None }

type accesscustompages =
    { ///The uid of the custom page to use when a user is denied access after failing a non-identity rule.
      forbidden: Option<string>
      ///The uid of the custom page to use when a user is denied access.
      identity_denied: Option<string> }
    ///Creates an instance of accesscustompages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesscustompages =
        { forbidden = None
          identity_denied = None }

type accessdeleteauthenticatorresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessdeleteauthenticatorresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessdeleteauthenticatorresponseErrorsSource = { pointer = None }

type accessdeleteauthenticatorresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessdeleteauthenticatorresponseErrorsSource> }
    ///Creates an instance of accessdeleteauthenticatorresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessdeleteauthenticatorresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessdeleteauthenticatorresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessdeleteauthenticatorresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessdeleteauthenticatorresponseMessagesSource = { pointer = None }

type accessdeleteauthenticatorresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessdeleteauthenticatorresponseMessagesSource> }
    ///Creates an instance of accessdeleteauthenticatorresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessdeleteauthenticatorresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessdeleteauthenticatorresponse =
    { errors: list<accessdeleteauthenticatorresponseErrors>
      messages: list<accessdeleteauthenticatorresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of accessdeleteauthenticatorresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessdeleteauthenticatorresponseErrors>,
                          messages: list<accessdeleteauthenticatorresponseMessages>,
                          success: bool): accessdeleteauthenticatorresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accessdeleteuserresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessdeleteuserresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessdeleteuserresponseErrorsSource = { pointer = None }

type accessdeleteuserresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessdeleteuserresponseErrorsSource> }
    ///Creates an instance of accessdeleteuserresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessdeleteuserresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessdeleteuserresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessdeleteuserresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessdeleteuserresponseMessagesSource = { pointer = None }

type accessdeleteuserresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessdeleteuserresponseMessagesSource> }
    ///Creates an instance of accessdeleteuserresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessdeleteuserresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessdeleteuserresponse =
    { errors: list<accessdeleteuserresponseErrors>
      messages: list<accessdeleteuserresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of accessdeleteuserresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessdeleteuserresponseErrors>,
                          messages: list<accessdeleteuserresponseMessages>,
                          success: bool): accessdeleteuserresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accessdeviceposturecheck =
    { exists: Option<bool>
      path: Option<string> }
    ///Creates an instance of accessdeviceposturecheck with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessdeviceposturecheck = { exists = None; path = None }

type Deviceposture =
    { ///The ID of a device posture integration.
      integration_uid: string }
    ///Creates an instance of Deviceposture with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (integration_uid: string): Deviceposture = { integration_uid = integration_uid }

///Enforces a device posture rule has run successfully
type accessdeviceposturerule =
    { device_posture: Deviceposture }
    ///Creates an instance of accessdeviceposturerule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (device_posture: Deviceposture): accessdeviceposturerule = { device_posture = device_posture }

type accessdevicesession =
    { last_authenticated: Option<float> }
    ///Creates an instance of accessdevicesession with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessdevicesession = { last_authenticated = None }

type Emaildomain =
    { ///The email domain to match.
      domain: string }
    ///Creates an instance of Emaildomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: string): Emaildomain = { domain = domain }

///Match an entire email domain.
type accessdomainrule =
    { email_domain: Emaildomain }
    ///Creates an instance of accessdomainrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email_domain: Emaildomain): accessdomainrule = { email_domain = email_domain }

type Emaillist =
    { ///The ID of a previously created email list.
      id: string }
    ///Creates an instance of Emaillist with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): Emaillist = { id = id }

///Matches an email address from a list.
type accessemaillistrule =
    { email_list: Emaillist }
    ///Creates an instance of accessemaillistrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email_list: Emaillist): accessemaillistrule = { email_list = email_list }

type Email =
    { ///The email of the user.
      email: string }
    ///Creates an instance of Email with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: string): Email = { email = email }

///Matches a specific email.
type accessemailrule =
    { email: Email }
    ///Creates an instance of accessemailrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: Email): accessemailrule = { email = email }

type accessemptyresponse =
    { result: Option<bool>
      success: Option<bool> }
    ///Creates an instance of accessemptyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessemptyresponse = { result = None; success = None }

///Matches everyone.
type accesseveryonerule =
    { ///An empty object which matches on all users.
      everyone: Newtonsoft.Json.Linq.JObject }
    ///Creates an instance of accesseveryonerule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (everyone: Newtonsoft.Json.Linq.JObject): accesseveryonerule = { everyone = everyone }

type Externalevaluation =
    { ///The API endpoint containing your business logic.
      evaluate_url: string
      ///The API endpoint containing the key that Access uses to verify that the response came from your API.
      keys_url: string }
    ///Creates an instance of Externalevaluation with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (evaluate_url: string, keys_url: string): Externalevaluation =
        { evaluate_url = evaluate_url
          keys_url = keys_url }

///Create Allow or Block policies which evaluate the user based on custom criteria.
type accessexternalevaluationrule =
    { external_evaluation: Externalevaluation }
    ///Creates an instance of accessexternalevaluationrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (external_evaluation: Externalevaluation): accessexternalevaluationrule =
        { external_evaluation = external_evaluation }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessfacebookScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accessfacebookScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accessfacebookScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessfacebookScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessfacebookScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessfacebookType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accessfacebook =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accessfacebookScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accessfacebookType> }
    ///Creates an instance of accessfacebook with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessfacebook =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type accessfailedloginresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessfailedloginresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessfailedloginresponseErrorsSource = { pointer = None }

type accessfailedloginresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessfailedloginresponseErrorsSource> }
    ///Creates an instance of accessfailedloginresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessfailedloginresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessfailedloginresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessfailedloginresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessfailedloginresponseMessagesSource = { pointer = None }

type accessfailedloginresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessfailedloginresponseMessagesSource> }
    ///Creates an instance of accessfailedloginresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessfailedloginresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessfailedloginresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessfailedloginresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessfailedloginresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type accessfailedloginresponseResult =
    { expiration: Option<int>
      metadata: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of accessfailedloginresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessfailedloginresponseResult = { expiration = None; metadata = None }

type accessfailedloginresponse =
    { errors: list<accessfailedloginresponseErrors>
      messages: list<accessfailedloginresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<accessfailedloginresponseResultinfo>
      result: Option<list<accessfailedloginresponseResult>> }
    ///Creates an instance of accessfailedloginresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessfailedloginresponseErrors>,
                          messages: list<accessfailedloginresponseMessages>,
                          success: bool): accessfailedloginresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type accessfeatureappprops =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: Option<accessdomain>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///The application type.
      ``type``: accesstype }
    ///Creates an instance of accessfeatureappprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: accesstype): accessfeatureappprops =
        { allowed_idps = None
          auto_redirect_to_identity = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          domain = None
          name = None
          session_duration = None
          ``type`` = ``type`` }

type ``accessgatewaycacomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgatewaycacomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgatewaycacomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accessgatewaycacomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgatewaycacomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessgatewaycacomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgatewaycacomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgatewaycacomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgatewaycacomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgatewaycacomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accessgatewaycacomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgatewaycacomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessgatewaycacomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgatewaycacomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgatewaycacomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessgatewaycacomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgatewaycacomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessgatewaycacomponents-schemas-responsecollection`` =
    { errors: list<``accessgatewaycacomponents-schemas-responsecollectionErrors``>
      messages: list<``accessgatewaycacomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accessgatewaycacomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<``accessschemas-certificates``>> }
    ///Creates an instance of accessgatewaycacomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessgatewaycacomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accessgatewaycacomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accessgatewaycacomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accessgatewaycacomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgatewaycacomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgatewaycacomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accessgatewaycacomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgatewaycacomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessgatewaycacomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgatewaycacomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgatewaycacomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgatewaycacomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgatewaycacomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accessgatewaycacomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgatewaycacomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessgatewaycacomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgatewaycacomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgatewaycacomponents-schemas-singleresponse`` =
    { errors: list<``accessgatewaycacomponents-schemas-singleresponseErrors``>
      messages: list<``accessgatewaycacomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``accessschemas-certificates``> }
    ///Creates an instance of accessgatewaycacomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessgatewaycacomponents-schemas-singleresponseErrors``>,
                          messages: list<``accessgatewaycacomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accessgatewaycacomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``accessgeneric-oauth-config`` =
    { ///Your OAuth Client ID
      client_id: Option<string>
      ///Your OAuth Client Secret
      client_secret: Option<string> }
    ///Creates an instance of accessgeneric-oauth-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgeneric-oauth-config`` =
        { client_id = None
          client_secret = None }

type accessgeo =
    { country: Option<string> }
    ///Creates an instance of accessgeo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessgeo = { country = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessgithubScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accessgithubScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accessgithubScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessgithubScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessgithubScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessgithubType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accessgithub =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accessgithubScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accessgithubType> }
    ///Creates an instance of accessgithub with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessgithub =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type ``Github-organization`` =
    { ///The ID of your Github identity provider.
      identity_provider_id: string
      ///The name of the organization.
      name: string
      ///The name of the team
      team: Option<string> }
    ///Creates an instance of Github-organization with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (identity_provider_id: string, name: string): ``Github-organization`` =
        { identity_provider_id = identity_provider_id
          name = name
          team = None }

///Matches a Github organization.
///Requires a Github identity provider.
type accessgithuborganizationrule =
    { ``github-organization``: ``Github-organization`` }
    ///Creates an instance of accessgithuborganizationrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``github-organization``: ``Github-organization``): accessgithuborganizationrule =
        { ``github-organization`` = ``github-organization`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessgoogleScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accessgoogleScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accessgoogleScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessgoogleScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessgoogleScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessgoogleType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accessgoogle =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accessgoogleScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accessgoogleType> }
    ///Creates an instance of accessgoogle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessgoogle =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessgoogle-appsScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessgoogle-appsScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessgoogle-appsScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessgoogle-appsScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgoogle-appsScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessgoogle-appsType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessgoogle-apps`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessgoogle-appsScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessgoogle-appsType``> }
    ///Creates an instance of accessgoogle-apps with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgoogle-apps`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type accessgroups =
    { ///The display name of the SCIM Group resource.
      displayName: Option<string>
      ///The IdP-generated Id of the SCIM resource.
      externalId: Option<accessexternalId>
      ///The unique Cloudflare-generated Id of the SCIM resource.
      id: Option<accessid>
      ///The metadata of the SCIM resource.
      meta: Option<accessmeta>
      ///The list of URIs which indicate the attributes contained within a SCIM resource.
      schemas: Option<list<string>> }
    ///Creates an instance of accessgroups with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessgroups =
        { displayName = None
          externalId = None
          id = None
          meta = None
          schemas = None }

type ``accessgroupscomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgroupscomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgroupscomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accessgroupscomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgroupscomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessgroupscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgroupscomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgroupscomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgroupscomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgroupscomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accessgroupscomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgroupscomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessgroupscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgroupscomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgroupscomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessgroupscomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgroupscomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessgroupscomponents-schemas-responsecollection`` =
    { errors: Option<list<``accessgroupscomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``accessgroupscomponents-schemas-responsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``accessgroupscomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<``accesscomponents-schemas-groups``>> }
    ///Creates an instance of accessgroupscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgroupscomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``accessgroupscomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgroupscomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accessgroupscomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgroupscomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgroupscomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgroupscomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgroupscomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accessgroupscomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgroupscomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgroupscomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgroupscomponents-schemas-singleresponse`` =
    { errors: list<``accessgroupscomponents-schemas-singleresponseErrors``>
      messages: list<``accessgroupscomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``accessschemas-groups``> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessgroupscomponents-schemas-singleresponseErrors``>,
                          messages: list<``accessgroupscomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accessgroupscomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``accessgroupscomponents-schemas-singleresponse-2ErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponse-2ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgroupscomponents-schemas-singleresponse-2ErrorsSource`` = { pointer = None }

type ``accessgroupscomponents-schemas-singleresponse-2Errors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgroupscomponents-schemas-singleresponse-2ErrorsSource``> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponse-2Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgroupscomponents-schemas-singleresponse-2Errors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgroupscomponents-schemas-singleresponse-2MessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponse-2MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgroupscomponents-schemas-singleresponse-2MessagesSource`` = { pointer = None }

type ``accessgroupscomponents-schemas-singleresponse-2Messages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessgroupscomponents-schemas-singleresponse-2MessagesSource``> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponse-2Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessgroupscomponents-schemas-singleresponse-2Messages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessgroupscomponents-schemas-singleresponse-2`` =
    { errors: Option<list<``accessgroupscomponents-schemas-singleresponse-2Errors``>>
      messages: Option<list<``accessgroupscomponents-schemas-singleresponse-2Messages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<``accesscomponents-schemas-groups``> }
    ///Creates an instance of accessgroupscomponents-schemas-singleresponse-2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessgroupscomponents-schemas-singleresponse-2`` =
        { errors = None
          messages = None
          success = None
          result = None }

type Gsuite =
    { ///The email of the Google Workspace group.
      email: string
      ///The ID of your Google Workspace identity provider.
      identity_provider_id: string }
    ///Creates an instance of Gsuite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: string, identity_provider_id: string): Gsuite =
        { email = email
          identity_provider_id = identity_provider_id }

///Matches a group in Google Workspace.
///Requires a Google Workspace identity provider.
type accessgsuitegrouprule =
    { gsuite: Gsuite }
    ///Creates an instance of accessgsuitegrouprule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (gsuite: Gsuite): accessgsuitegrouprule = { gsuite = gsuite }

type accessidresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessidresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessidresponseErrorsSource = { pointer = None }

type accessidresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessidresponseErrorsSource> }
    ///Creates an instance of accessidresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessidresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessidresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessidresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessidresponseMessagesSource = { pointer = None }

type accessidresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessidresponseMessagesSource> }
    ///Creates an instance of accessidresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessidresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessidresponseResult =
    { ///UUID.
      id: Option<accessuuid> }
    ///Creates an instance of accessidresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessidresponseResult = { id = None }

type accessidresponse =
    { errors: list<accessidresponseErrors>
      messages: list<accessidresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<accessidresponseResult> }
    ///Creates an instance of accessidresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessidresponseErrors>, messages: list<accessidresponseMessages>, success: bool): accessidresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accessidentityIdp =
    { id: Option<string>
      ``type``: Option<string> }
    ///Creates an instance of accessidentityIdp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessidentityIdp = { id = None; ``type`` = None }

type accessidentityMtlsauth =
    { auth_status: Option<string>
      cert_issuer_dn: Option<string>
      cert_issuer_ski: Option<string>
      cert_presented: Option<bool>
      cert_serial: Option<string> }
    ///Creates an instance of accessidentityMtlsauth with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessidentityMtlsauth =
        { auth_status = None
          cert_issuer_dn = None
          cert_issuer_ski = None
          cert_presented = None
          cert_serial = None }

type accessidentity =
    { account_id: Option<string>
      auth_status: Option<string>
      common_name: Option<string>
      devicePosture: Option<Map<string, ``accessschemas-deviceposturerule``>>
      device_id: Option<string>
      device_sessions: Option<Map<string, accessdevicesession>>
      email: Option<string>
      geo: Option<accessgeo>
      iat: Option<float>
      idp: Option<accessidentityIdp>
      ip: Option<string>
      is_gateway: Option<bool>
      is_warp: Option<bool>
      mtls_auth: Option<accessidentityMtlsauth>
      service_token_id: Option<string>
      service_token_status: Option<bool>
      user_uuid: Option<string>
      version: Option<float> }
    ///Creates an instance of accessidentity with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessidentity =
        { account_id = None
          auth_status = None
          common_name = None
          devicePosture = None
          device_id = None
          device_sessions = None
          email = None
          geo = None
          iat = None
          idp = None
          ip = None
          is_gateway = None
          is_warp = None
          mtls_auth = None
          service_token_id = None
          service_token_status = None
          user_uuid = None
          version = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessidentity-providerScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessidentity-providerScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessidentity-providerScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessidentity-providerScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessidentity-providerScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessidentity-providerType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessidentity-provider`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Newtonsoft.Json.Linq.JObject
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: ``accesscomponents-schemas-name``
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessidentity-providerScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: ``accessidentity-providerType`` }
    ///Creates an instance of accessidentity-provider with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (config: Newtonsoft.Json.Linq.JObject,
                          name: ``accesscomponents-schemas-name``,
                          ``type``: ``accessidentity-providerType``): ``accessidentity-provider`` =
        { config = config
          id = None
          name = name
          scim_config = None
          ``type`` = ``type`` }

type ``accessidentity-providers`` = Map<string, Newtonsoft.Json.Linq.JToken>

type ``accessidentity-providerscomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessidentity-providerscomponents-schemas-responsecollectionErrorsSource`` =
        { pointer = None }

type ``accessidentity-providerscomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessidentity-providerscomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessidentity-providerscomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessidentity-providerscomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessidentity-providerscomponents-schemas-responsecollectionMessagesSource`` =
        { pointer = None }

type ``accessidentity-providerscomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessidentity-providerscomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessidentity-providerscomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessidentity-providerscomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessidentity-providerscomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessidentity-providerscomponents-schemas-responsecollection`` =
    { errors: Option<list<``accessidentity-providerscomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``accessidentity-providerscomponents-schemas-responsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``accessidentity-providerscomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<string>> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessidentity-providerscomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``accessidentity-providerscomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessidentity-providerscomponents-schemas-singleresponseErrorsSource`` =
        { pointer = None }

type ``accessidentity-providerscomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessidentity-providerscomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessidentity-providerscomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessidentity-providerscomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessidentity-providerscomponents-schemas-singleresponseMessagesSource`` =
        { pointer = None }

type ``accessidentity-providerscomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessidentity-providerscomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessidentity-providerscomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessidentity-providerscomponents-schemas-singleresponse`` =
    { errors: Option<list<``accessidentity-providerscomponents-schemas-singleresponseErrors``>>
      messages: Option<list<``accessidentity-providerscomponents-schemas-singleresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accessidentity-providerscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessidentity-providerscomponents-schemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type accessinfraappreqembeddedpolicies =
    { ///The policies that Access applies to the application.
      policies: Option<list<accessinfrapolicyreq>> }
    ///Creates an instance of accessinfraappreqembeddedpolicies with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessinfraappreqembeddedpolicies = { policies = None }

///The policies that Access applies to the application.
type accessinfraapprespembeddedpolicies =
    { policies: Option<list<accessinfrapolicyresp>> }
    ///Creates an instance of accessinfraapprespembeddedpolicies with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessinfraapprespembeddedpolicies = { policies = None }

type accessinfrapolicyreq =
    { ///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
      decision: Option<accessdecision>
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accessschemas-exclude``>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<``accessschemas-include``>
      ///The name of the Access policy.
      name: Option<``accesspolicycomponents-schemas-name``>
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accessschemas-require``>
      ///The rules that define how users may connect to the targets secured by your application.
      connection_rules: Option<accessconnectionrulesinfra> }
    ///Creates an instance of accessinfrapolicyreq with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessinfrapolicyreq =
        { decision = None
          exclude = None
          ``include`` = None
          name = None
          require = None
          connection_rules = None }

type accessinfrapolicyresp =
    { created_at: Option<accesstimestamp>
      ///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
      decision: Option<accessdecision>
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accessschemas-exclude``>
      ///The UUID of the policy
      id: Option<``accessschemas-uuid``>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<``accessschemas-include``>
      ///The name of the Access policy.
      name: Option<``accesspolicycomponents-schemas-name``>
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accessschemas-require``>
      updated_at: Option<accesstimestamp>
      ///The rules that define how users may connect to the targets secured by your application.
      connection_rules: Option<accessconnectionrulesinfra> }
    ///Creates an instance of accessinfrapolicyresp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessinfrapolicyresp =
        { created_at = None
          decision = None
          exclude = None
          id = None
          ``include`` = None
          name = None
          require = None
          updated_at = None
          connection_rules = None }

type accessinfraprops =
    { ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The application type.
      ``type``: accesstype
      target_criteria: list<accesstargetcriteriainfraapp> }
    ///Creates an instance of accessinfraprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: accesstype, target_criteria: list<accesstargetcriteriainfraapp>): accessinfraprops =
        { name = None
          ``type`` = ``type``
          target_criteria = target_criteria }

type Iplist =
    { ///The ID of a previously created IP list.
      id: string }
    ///Creates an instance of Iplist with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): Iplist = { id = id }

///Matches an IP address from a list.
type accessiplistrule =
    { ip_list: Iplist }
    ///Creates an instance of accessiplistrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ip_list: Iplist): accessiplistrule = { ip_list = ip_list }

type Ip =
    { ///An IPv4 or IPv6 CIDR block.
      ip: string }
    ///Creates an instance of Ip with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ip: string): Ip = { ip = ip }

///Matches an IP address block.
type accessiprule =
    { ip: Ip }
    ///Creates an instance of accessiprule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ip: Ip): accessiprule = { ip = ip }

type accesskeyconfig =
    { ///The number of days until the next key rotation.
      days_until_next_rotation: Option<accessdaysuntilnextrotation>
      ///The number of days between key rotations.
      key_rotation_interval_days: Option<accesskeyrotationintervaldays>
      ///The timestamp of the previous key rotation.
      last_key_rotation_at: Option<accesslastkeyrotationat> }
    ///Creates an instance of accesskeyconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesskeyconfig =
        { days_until_next_rotation = None
          key_rotation_interval_days = None
          last_key_rotation_at = None }

type ``accesskeyscomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesskeyscomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesskeyscomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accesskeyscomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesskeyscomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accesskeyscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesskeyscomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesskeyscomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesskeyscomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesskeyscomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accesskeyscomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesskeyscomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accesskeyscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesskeyscomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesskeyscomponents-schemas-singleresponse`` =
    { errors: list<``accesskeyscomponents-schemas-singleresponseErrors``>
      messages: list<``accesskeyscomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<accesskeyconfig> }
    ///Creates an instance of accesskeyscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesskeyscomponents-schemas-singleresponseErrors``>,
                          messages: list<``accesskeyscomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accesskeyscomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

///The design of the App Launcher landing page shown to users when they log in.
type accesslandingpagedesign =
    { ///The background color of the log in button on the landing page.
      button_color: Option<accessbuttoncolor>
      ///The color of the text in the log in button on the landing page.
      button_text_color: Option<accessbuttontextcolor>
      ///The URL of the image shown on the landing page.
      image_url: Option<accessimageurl>
      ///The message shown on the landing page.
      message: Option<accessmessage>
      ///The title shown on the landing page.
      title: Option<accesstitle> }
    ///Creates an instance of accesslandingpagedesign with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesslandingpagedesign =
        { button_color = None
          button_text_color = None
          image_url = None
          message = None
          title = None }

type accesslastseenidentityresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesslastseenidentityresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesslastseenidentityresponseErrorsSource = { pointer = None }

type accesslastseenidentityresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesslastseenidentityresponseErrorsSource> }
    ///Creates an instance of accesslastseenidentityresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesslastseenidentityresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesslastseenidentityresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesslastseenidentityresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesslastseenidentityresponseMessagesSource = { pointer = None }

type accesslastseenidentityresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesslastseenidentityresponseMessagesSource> }
    ///Creates an instance of accesslastseenidentityresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesslastseenidentityresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesslastseenidentityresponseResultIdp =
    { id: Option<string>
      ``type``: Option<string> }
    ///Creates an instance of accesslastseenidentityresponseResultIdp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesslastseenidentityresponseResultIdp = { id = None; ``type`` = None }

type accesslastseenidentityresponseResultMtlsauth =
    { auth_status: Option<string>
      cert_issuer_dn: Option<string>
      cert_issuer_ski: Option<string>
      cert_presented: Option<bool>
      cert_serial: Option<string> }
    ///Creates an instance of accesslastseenidentityresponseResultMtlsauth with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesslastseenidentityresponseResultMtlsauth =
        { auth_status = None
          cert_issuer_dn = None
          cert_issuer_ski = None
          cert_presented = None
          cert_serial = None }

type accesslastseenidentityresponseResult =
    { account_id: Option<string>
      auth_status: Option<string>
      common_name: Option<string>
      devicePosture: Option<Map<string, ``accessschemas-deviceposturerule``>>
      device_id: Option<string>
      device_sessions: Option<Map<string, accessdevicesession>>
      email: Option<string>
      geo: Option<accessgeo>
      iat: Option<float>
      idp: Option<accesslastseenidentityresponseResultIdp>
      ip: Option<string>
      is_gateway: Option<bool>
      is_warp: Option<bool>
      mtls_auth: Option<accesslastseenidentityresponseResultMtlsauth>
      service_token_id: Option<string>
      service_token_status: Option<bool>
      user_uuid: Option<string>
      version: Option<float> }
    ///Creates an instance of accesslastseenidentityresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesslastseenidentityresponseResult =
        { account_id = None
          auth_status = None
          common_name = None
          devicePosture = None
          device_id = None
          device_sessions = None
          email = None
          geo = None
          iat = None
          idp = None
          ip = None
          is_gateway = None
          is_warp = None
          mtls_auth = None
          service_token_id = None
          service_token_status = None
          user_uuid = None
          version = None }

type accesslastseenidentityresponse =
    { errors: list<accesslastseenidentityresponseErrors>
      messages: list<accesslastseenidentityresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<accesslastseenidentityresponseResult> }
    ///Creates an instance of accesslastseenidentityresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accesslastseenidentityresponseErrors>,
                          messages: list<accesslastseenidentityresponseMessages>,
                          success: bool): accesslastseenidentityresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type Linkedapptoken =
    { ///The ID of an Access OIDC SaaS application
      app_uid: string }
    ///Creates an instance of Linkedapptoken with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (app_uid: string): Linkedapptoken = { app_uid = app_uid }

///Matches OAuth 2.0 access tokens issued by the specified Access OIDC SaaS application. Only compatible with non_identity and bypass decisions.
type accesslinkedapptokenrule =
    { linked_app_token: Linkedapptoken }
    ///Creates an instance of accesslinkedapptokenrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (linked_app_token: Linkedapptoken): accesslinkedapptokenrule =
        { linked_app_token = linked_app_token }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesslinkedinScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accesslinkedinScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accesslinkedinScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accesslinkedinScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesslinkedinScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesslinkedinType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accesslinkedin =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accesslinkedinScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accesslinkedinType> }
    ///Creates an instance of accesslinkedin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesslinkedin =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type accesslogindesign =
    { ///The background color on your login page.
      background_color: Option<string>
      ///The text at the bottom of your login page.
      footer_text: Option<string>
      ///The text at the top of your login page.
      header_text: Option<string>
      ///The URL of the logo on your login page.
      logo_path: Option<string>
      ///The text color on your login page.
      text_color: Option<string> }
    ///Creates an instance of accesslogindesign with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesslogindesign =
        { background_color = None
          footer_text = None
          header_text = None
          logo_path = None
          text_color = None }

type Loginmethod =
    { ///The ID of an identity provider.
      id: string }
    ///Creates an instance of Loginmethod with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): Loginmethod = { id = id }

///Matches a specific identity provider id.
type accessloginmethodrule =
    { login_method: Loginmethod }
    ///Creates an instance of accessloginmethodrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (login_method: Loginmethod): accessloginmethodrule = { login_method = login_method }

type accessmcpportalprops =
    { ///When set to true, users can authenticate to this application using their WARP session.  When set to false this application will always require direct IdP authentication. This setting always overrides the organization setting for WARP authentication.
      allow_authenticate_via_warp: Option<``accessschemas-allowauthenticateviawarp``>
      ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The custom error message shown to a user when they are denied access to the application.
      custom_deny_message: Option<accesscustomdenymessage>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///List of destinations secured by Access. This supersedes `self_hosted_domains` to allow for more flexibility in defining different types of domains. If `destinations` are provided, then `self_hosted_domains` will be ignored.
      destinations: Option<accessdestinations>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: Option<accessdomain>
      ///Enables the HttpOnly cookie attribute, which increases security against XSS attacks.
      http_only_cookie_attribute: Option<accesshttponlycookieattribute>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///**Beta:** Optional configuration for managing an OAuth authorization flow controlled by Access. When set, Access will act as the OAuth authorization server for this application. Only compatible with OAuth clients that support [RFC 8707](https://datatracker.ietf.org/doc/html/rfc8707) (Resource Indicators for OAuth 2.0). This feature is currently in beta.
      oauth_configuration: Option<accessoauthconfiguration>
      ///Allows options preflight requests to bypass Access authentication and go directly to the origin. Cannot turn on if cors_headers is set.
      options_preflight_bypass: Option<accessoptionspreflightbypass>
      ///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
      same_site_cookie_attribute: Option<accesssamesitecookieattribute>
      ///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
      scim_config: Option<accessscimconfig>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///The tags you want assigned to an application. Tags are used to filter applications in the App Launcher dashboard.
      tags: Option<accesstags>
      ///The application type.
      ``type``: accesstype }
    ///Creates an instance of accessmcpportalprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: accesstype): accessmcpportalprops =
        { allow_authenticate_via_warp = None
          allowed_idps = None
          auto_redirect_to_identity = None
          custom_deny_message = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          destinations = None
          domain = None
          http_only_cookie_attribute = None
          logo_url = None
          name = None
          oauth_configuration = None
          options_preflight_bypass = None
          same_site_cookie_attribute = None
          scim_config = None
          session_duration = None
          tags = None
          ``type`` = ``type`` }

type accessmcpprops =
    { ///When set to true, users can authenticate to this application using their WARP session.  When set to false this application will always require direct IdP authentication. This setting always overrides the organization setting for WARP authentication.
      allow_authenticate_via_warp: Option<``accessschemas-allowauthenticateviawarp``>
      ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The custom error message shown to a user when they are denied access to the application.
      custom_deny_message: Option<accesscustomdenymessage>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///List of destinations secured by Access. This supersedes `self_hosted_domains` to allow for more flexibility in defining different types of domains. If `destinations` are provided, then `self_hosted_domains` will be ignored.
      destinations: Option<accessdestinations>
      ///Enables the HttpOnly cookie attribute, which increases security against XSS attacks.
      http_only_cookie_attribute: Option<accesshttponlycookieattribute>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///**Beta:** Optional configuration for managing an OAuth authorization flow controlled by Access. When set, Access will act as the OAuth authorization server for this application. Only compatible with OAuth clients that support [RFC 8707](https://datatracker.ietf.org/doc/html/rfc8707) (Resource Indicators for OAuth 2.0). This feature is currently in beta.
      oauth_configuration: Option<accessoauthconfiguration>
      ///Allows options preflight requests to bypass Access authentication and go directly to the origin. Cannot turn on if cors_headers is set.
      options_preflight_bypass: Option<accessoptionspreflightbypass>
      ///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
      same_site_cookie_attribute: Option<accesssamesitecookieattribute>
      ///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
      scim_config: Option<accessscimconfig>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///The tags you want assigned to an application. Tags are used to filter applications in the App Launcher dashboard.
      tags: Option<accesstags>
      ///The application type.
      ``type``: accesstype }
    ///Creates an instance of accessmcpprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: accesstype): accessmcpprops =
        { allow_authenticate_via_warp = None
          allowed_idps = None
          auto_redirect_to_identity = None
          custom_deny_message = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          destinations = None
          http_only_cookie_attribute = None
          logo_url = None
          name = None
          oauth_configuration = None
          options_preflight_bypass = None
          same_site_cookie_attribute = None
          scim_config = None
          session_duration = None
          tags = None
          ``type`` = ``type`` }

///The metadata of the SCIM resource.
type accessmeta =
    { ///The timestamp of when the SCIM resource was created.
      created: Option<System.DateTimeOffset>
      ///The timestamp of when the SCIM resource was last modified.
      lastModified: Option<System.DateTimeOffset> }
    ///Creates an instance of accessmeta with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessmeta = { created = None; lastModified = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Allowed_authenticators =
    | [<CompiledName "totp">] Totp
    | [<CompiledName "biometrics">] Biometrics
    | [<CompiledName "security_key">] Security_key
    member this.Format() =
        match this with
        | Totp -> "totp"
        | Biometrics -> "biometrics"
        | Security_key -> "security_key"

///Configures multi-factor authentication (MFA) settings.
type accessmfaconfig =
    { ///Lists the MFA methods that users can authenticate with.
      allowed_authenticators: Option<list<Allowed_authenticators>>
      ///Indicates whether to disable MFA for this resource. This option is available at the application and policy level.
      mfa_disabled: Option<bool>
      ///Defines the duration of an MFA session. Must be in minutes (m) or hours (h). Minimum: 0m. Maximum: 720h (30 days). Examples:`5m` or `24h`.
      session_duration: Option<string> }
    ///Creates an instance of accessmfaconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessmfaconfig =
        { allowed_authenticators = None
          mfa_disabled = None
          session_duration = None }

type accessnameresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessnameresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessnameresponseErrorsSource = { pointer = None }

type accessnameresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessnameresponseErrorsSource> }
    ///Creates an instance of accessnameresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessnameresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessnameresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessnameresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessnameresponseMessagesSource = { pointer = None }

type accessnameresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessnameresponseMessagesSource> }
    ///Creates an instance of accessnameresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessnameresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessnameresponseResult =
    { ///The name of the tag
      name: Option<``accesstagscomponents-schemas-name``> }
    ///Creates an instance of accessnameresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessnameresponseResult = { name = None }

type accessnameresponse =
    { errors: list<accessnameresponseErrors>
      messages: list<accessnameresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<accessnameresponseResult> }
    ///Creates an instance of accessnameresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessnameresponseErrors>,
                          messages: list<accessnameresponseMessages>,
                          success: bool): accessnameresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

///Settings for OAuth dynamic client registration.
type Dynamicclientregistration =
    { ///Allows any client with redirect URIs on localhost.
      allow_any_on_localhost: Option<bool>
      ///Allows any client with redirect URIs on 127.0.0.1.
      allow_any_on_loopback: Option<bool>
      ///The URIs that are allowed as redirect URIs for dynamically registered clients. Must use the `https` protocol. Paths may end in `/*` to match all sub-paths.
      allowed_uris: Option<list<string>>
      ///Whether dynamic client registration is enabled.
      enabled: Option<bool> }
    ///Creates an instance of Dynamicclientregistration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Dynamicclientregistration =
        { allow_any_on_localhost = None
          allow_any_on_loopback = None
          allowed_uris = None
          enabled = None }

///Settings for OAuth grant behavior.
type Grant =
    { ///The lifetime of the access token. Must be in the format `300ms` or `2h45m`. Valid time units are ns, us (or µs), ms, s, m, h.
      access_token_lifetime: Option<string>
      ///The duration of the OAuth session. Must be in the format `300ms` or `2h45m`. Valid time units are ns, us (or µs), ms, s, m, h.
      session_duration: Option<string> }
    ///Creates an instance of Grant with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Grant =
        { access_token_lifetime = None
          session_duration = None }

///**Beta:** Optional configuration for managing an OAuth authorization flow controlled by Access. When set, Access will act as the OAuth authorization server for this application. Only compatible with OAuth clients that support [RFC 8707](https://datatracker.ietf.org/doc/html/rfc8707) (Resource Indicators for OAuth 2.0). This feature is currently in beta.
type accessoauthconfiguration =
    { ///Settings for OAuth dynamic client registration.
      dynamic_client_registration: Option<Dynamicclientregistration>
      ///Whether the OAuth configuration is enabled for this application. When set to `false`, Access will not handle OAuth for this application. Defaults to `true` if omitted.
      enabled: Option<bool>
      ///Settings for OAuth grant behavior.
      grant: Option<Grant> }
    ///Creates an instance of accessoauthconfiguration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessoauthconfiguration =
        { dynamic_client_registration = None
          enabled = None
          grant = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessoidcScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accessoidcScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accessoidcScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessoidcScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessoidcScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessoidcType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accessoidc =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accessoidcScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accessoidcType> }
    ///Creates an instance of accessoidc with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessoidc =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type Oidc =
    { ///The name of the OIDC claim.
      claim_name: string
      ///The OIDC claim value to look for.
      claim_value: string
      ///The ID of your OIDC identity provider.
      identity_provider_id: string }
    ///Creates an instance of Oidc with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (claim_name: string, claim_value: string, identity_provider_id: string): Oidc =
        { claim_name = claim_name
          claim_value = claim_value
          identity_provider_id = identity_provider_id }

///Matches an OIDC claim.
///Requires an OIDC identity provider.
type accessoidcclaimrule =
    { oidc: Oidc }
    ///Creates an instance of accessoidcclaimrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (oidc: Oidc): accessoidcclaimrule = { oidc = oidc }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Authtype =
    | [<CompiledName "saml">] Saml
    | [<CompiledName "oidc">] Oidc
    member this.Format() =
        match this with
        | Saml -> "saml"
        | Oidc -> "oidc"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Scope =
    | [<CompiledName "groups">] Groups
    | [<CompiledName "profile">] Profile
    | [<CompiledName "email">] Email
    | [<CompiledName "openid">] Openid
    member this.Format() =
        match this with
        | Groups -> "groups"
        | Profile -> "profile"
        | Email -> "email"
        | Openid -> "openid"

type CustomclaimsSource =
    { ///The name of the IdP claim.
      name: Option<string>
      ///A mapping from IdP ID to claim name.
      name_by_idp: Option<Map<string, string>> }
    ///Creates an instance of CustomclaimsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): CustomclaimsSource = { name = None; name_by_idp = None }

type Customclaims =
    { ///The name of the claim.
      name: Option<string>
      ///If the claim is required when building an OIDC token.
      required: Option<bool>
      ///The scope of the claim.
      scope: Option<Scope>
      source: Option<CustomclaimsSource> }
    ///Creates an instance of Customclaims with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Customclaims =
        { name = None
          required = None
          scope = None
          source = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Grant_types =
    | [<CompiledName "authorization_code">] Authorization_code
    | [<CompiledName "authorization_code_with_pkce">] Authorization_code_with_pkce
    | [<CompiledName "refresh_tokens">] Refresh_tokens
    | [<CompiledName "hybrid">] Hybrid
    | [<CompiledName "implicit">] Implicit
    member this.Format() =
        match this with
        | Authorization_code -> "authorization_code"
        | Authorization_code_with_pkce -> "authorization_code_with_pkce"
        | Refresh_tokens -> "refresh_tokens"
        | Hybrid -> "hybrid"
        | Implicit -> "implicit"

type Hybridandimplicitoptions =
    { ///If an Access Token should be returned from the OIDC Authorization endpoint
      return_access_token_from_authorization_endpoint: Option<bool>
      ///If an ID Token should be returned from the OIDC Authorization endpoint
      return_id_token_from_authorization_endpoint: Option<bool> }
    ///Creates an instance of Hybridandimplicitoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Hybridandimplicitoptions =
        { return_access_token_from_authorization_endpoint = None
          return_id_token_from_authorization_endpoint = None }

type Refreshtokenoptions =
    { ///How long a refresh token will be valid for after creation. Valid units are m,h,d. Must be longer than 1m.
      lifetime: Option<string> }
    ///Creates an instance of Refreshtokenoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Refreshtokenoptions = { lifetime = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Scopes =
    | [<CompiledName "openid">] Openid
    | [<CompiledName "groups">] Groups
    | [<CompiledName "email">] Email
    | [<CompiledName "profile">] Profile
    member this.Format() =
        match this with
        | Openid -> "openid"
        | Groups -> "groups"
        | Email -> "email"
        | Profile -> "profile"

type accessoidcsaasapp =
    { ///The lifetime of the OIDC Access Token after creation. Valid units are m,h. Must be greater than or equal to 1m and less than or equal to 24h.
      access_token_lifetime: Option<string>
      ///If client secret should be required on the token endpoint when authorization_code_with_pkce grant is used.
      allow_pkce_without_client_secret: Option<bool>
      ///The URL where this applications tile redirects users
      app_launcher_url: Option<string>
      ///Identifier of the authentication protocol used for the saas app. Required for OIDC.
      auth_type: Option<Authtype>
      ///The application client id
      client_id: Option<string>
      ///The application client secret, only returned on POST request.
      client_secret: Option<string>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      custom_claims: Option<list<Customclaims>>
      ///The OIDC flows supported by this application
      grant_types: Option<list<Grant_types>>
      ///A regex to filter Cloudflare groups returned in ID token and userinfo endpoint
      group_filter_regex: Option<string>
      hybrid_and_implicit_options: Option<Hybridandimplicitoptions>
      ///The Access public certificate that will be used to verify your identity.
      public_key: Option<string>
      ///The permitted URL's for Cloudflare to return Authorization codes and Access/ID tokens
      redirect_uris: Option<list<string>>
      refresh_token_options: Option<Refreshtokenoptions>
      ///Define the user information shared with access, "offline_access" scope will be automatically enabled if refresh tokens are enabled
      scopes: Option<list<Scopes>>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accessoidcsaasapp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessoidcsaasapp =
        { access_token_lifetime = None
          allow_pkce_without_client_secret = None
          app_launcher_url = None
          auth_type = None
          client_id = None
          client_secret = None
          created_at = None
          custom_claims = None
          grant_types = None
          group_filter_regex = None
          hybrid_and_implicit_options = None
          public_key = None
          redirect_uris = None
          refresh_token_options = None
          scopes = None
          updated_at = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessoktaScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accessoktaScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accessoktaScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessoktaScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessoktaScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessoktaType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accessokta =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accessoktaScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accessoktaType> }
    ///Creates an instance of accessokta with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessokta =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type Okta =
    { ///The ID of your Okta identity provider.
      identity_provider_id: string
      ///The name of the Okta group.
      name: string }
    ///Creates an instance of Okta with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (identity_provider_id: string, name: string): Okta =
        { identity_provider_id = identity_provider_id
          name = name }

///Matches an Okta group.
///Requires an Okta identity provider.
type accessoktagrouprule =
    { okta: Okta }
    ///Creates an instance of accessoktagrouprule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (okta: Okta): accessoktagrouprule = { okta = okta }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessoneloginScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accessoneloginScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accessoneloginScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessoneloginScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessoneloginScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessoneloginType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accessonelogin =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accessoneloginScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accessoneloginType> }
    ///Creates an instance of accessonelogin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessonelogin =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessonetimepinScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accessonetimepinScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accessonetimepinScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessonetimepinScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessonetimepinScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessonetimepinType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accessonetimepinConfig =
    { redirect_url: Option<string> }
    ///Creates an instance of accessonetimepinConfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessonetimepinConfig = { redirect_url = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TypeFromaccessonetimepin =
    | [<CompiledName "onetimepin">] Onetimepin
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"

type accessonetimepin =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accessonetimepinScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accessonetimepinType> }
    ///Creates an instance of accessonetimepin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessonetimepin =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessorgmfaconfigAllowed_authenticators =
    | [<CompiledName "totp">] Totp
    | [<CompiledName "biometrics">] Biometrics
    | [<CompiledName "security_key">] Security_key
    member this.Format() =
        match this with
        | Totp -> "totp"
        | Biometrics -> "biometrics"
        | Security_key -> "security_key"

///Configures multi-factor authentication (MFA) settings for an organization.
type accessorgmfaconfig =
    { ///Lists the MFA methods that users can authenticate with.
      allowed_authenticators: Option<list<accessorgmfaconfigAllowed_authenticators>>
      ///Defines the duration of an MFA session. Must be in minutes (m) or hours (h). Minimum: 0m. Maximum: 720h (30 days). Examples:`5m` or `24h`.
      session_duration: Option<string> }
    ///Creates an instance of accessorgmfaconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessorgmfaconfig =
        { allowed_authenticators = None
          session_duration = None }

type accessorganizations =
    { ///When set to true, users can authenticate via WARP for any application in your organization. Application settings will take precedence over this value.
      allow_authenticate_via_warp: Option<accessallowauthenticateviawarp>
      ///The unique subdomain assigned to your Zero Trust organization.
      auth_domain: Option<accessauthdomain>
      ///When set to `true`, users skip the identity provider selection step during login.
      auto_redirect_to_identity: Option<accessautoredirecttoidentity>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      custom_pages: Option<accesscustompages>
      ///Determines whether to deny all requests to Cloudflare-protected resources that lack an associated Access application. If enabled, you must explicitly configure an Access application and policy to allow traffic to your Cloudflare-protected resources. For domains you want to be public across all subdomains, add the domain to the `deny_unmatched_requests_exempted_zone_names` array.
      deny_unmatched_requests: Option<accessdenyunmatchedrequests>
      ///Contains zone names to exempt from the `deny_unmatched_requests` feature. Requests to a subdomain in an exempted zone will block unauthenticated traffic by default if there is a configured Access application and policy that matches the request.
      deny_unmatched_requests_exempted_zone_names: Option<accessdenyunmatchedrequestsexemptedzonenames>
      ///Lock all settings as Read-Only in the Dashboard, regardless of user permission. Updates may only be made via the API or Terraform for this account when enabled.
      is_ui_read_only: Option<accessisuireadonly>
      login_design: Option<accesslogindesign>
      ///Configures multi-factor authentication (MFA) settings for an organization.
      mfa_config: Option<accessorgmfaconfig>
      ///Determines whether global MFA settings apply to applications by default. The organization must have MFA enabled with at least one authentication method and a session duration configured.
      mfa_required_for_all_apps: Option<accessmfarequiredforallapps>
      ///The name of your Zero Trust organization.
      name: Option<accessname>
      ///The amount of time that tokens issued for applications will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<accesssessionduration>
      ///A description of the reason why the UI read only field is being toggled.
      ui_read_only_toggle_reason: Option<accessuireadonlytogglereason>
      updated_at: Option<Newtonsoft.Json.Linq.JToken>
      ///The amount of time a user seat is inactive before it expires. When the user seat exceeds the set time of inactivity, the user is removed as an active seat and no longer counts against your Teams seat count.  Minimum value for this setting is 1 month (730h). Must be in the format `300ms` or `2h45m`. Valid time units are: `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
      user_seat_expiration_inactive_time: Option<accessuserseatexpirationinactivetime>
      ///The amount of time that tokens issued for applications will be valid. Must be in the format `30m` or `2h45m`. Valid time units are: m, h.
      warp_auth_session_duration: Option<accesswarpauthsessionduration> }
    ///Creates an instance of accessorganizations with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessorganizations =
        { allow_authenticate_via_warp = None
          auth_domain = None
          auto_redirect_to_identity = None
          created_at = None
          custom_pages = None
          deny_unmatched_requests = None
          deny_unmatched_requests_exempted_zone_names = None
          is_ui_read_only = None
          login_design = None
          mfa_config = None
          mfa_required_for_all_apps = None
          name = None
          session_duration = None
          ui_read_only_toggle_reason = None
          updated_at = None
          user_seat_expiration_inactive_time = None
          warp_auth_session_duration = None }

type ``accessorganizationscomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessorganizationscomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessorganizationscomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accessorganizationscomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessorganizationscomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessorganizationscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessorganizationscomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessorganizationscomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessorganizationscomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessorganizationscomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accessorganizationscomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessorganizationscomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessorganizationscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessorganizationscomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessorganizationscomponents-schemas-singleresponse`` =
    { errors: Option<list<``accessorganizationscomponents-schemas-singleresponseErrors``>>
      messages: Option<list<``accessorganizationscomponents-schemas-singleresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<``accessschemas-organizations``> }
    ///Creates an instance of accessorganizationscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessorganizationscomponents-schemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesspingoneScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accesspingoneScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accesspingoneScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accesspingoneScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspingoneScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesspingoneType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accesspingone =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accesspingoneScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accesspingoneType> }
    ///Creates an instance of accesspingone with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspingone =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type accesspolicies =
    { ///Administrators who can approve a temporary authentication request.
      approval_groups: Option<``accessschemas-approvalgroups``>
      ///Requires the user to request access from an administrator at the start of each session.
      approval_required: Option<``accessschemas-approvalrequired``>
      created_at: Option<accesstimestamp>
      ///The action Access will take if a user matches this policy.
      decision: Option<``accessschemas-decision``>
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accesscomponents-schemas-exclude``>
      ///UUID.
      id: Option<accessuuid>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<accessinclude>
      ///Require this application to be served in an isolated browser for users matching this policy.
      isolation_required: Option<``accessschemas-isolationrequired``>
      ///The name of the Access policy.
      name: Option<``accesspoliciescomponents-schemas-name``>
      ///The order of execution for this policy. Must be unique for each policy.
      precedence: Option<``accessschemas-precedence``>
      ///A custom message that will appear on the purpose justification screen.
      purpose_justification_prompt: Option<accesspurposejustificationprompt>
      ///Require users to enter a justification when they log in to the application.
      purpose_justification_required: Option<``accessschemas-purposejustificationrequired``>
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accesscomponents-schemas-require``>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accesspolicies with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicies =
        { approval_groups = None
          approval_required = None
          created_at = None
          decision = None
          exclude = None
          id = None
          ``include`` = None
          isolation_required = None
          name = None
          precedence = None
          purpose_justification_prompt = None
          purpose_justification_required = None
          require = None
          updated_at = None }

type ``accesspoliciescomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesspoliciescomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesspoliciescomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accesspoliciescomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesspoliciescomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accesspoliciescomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesspoliciescomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesspoliciescomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesspoliciescomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesspoliciescomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accesspoliciescomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesspoliciescomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accesspoliciescomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesspoliciescomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesspoliciescomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accesspoliciescomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesspoliciescomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accesspoliciescomponents-schemas-responsecollection`` =
    { errors: Option<list<``accesspoliciescomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``accesspoliciescomponents-schemas-responsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``accesspoliciescomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accesspolicies>> }
    ///Creates an instance of accesspoliciescomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesspoliciescomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``accesspoliciescomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesspoliciescomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesspoliciescomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accesspoliciescomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesspoliciescomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accesspoliciescomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesspoliciescomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesspoliciescomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesspoliciescomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesspoliciescomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accesspoliciescomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesspoliciescomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accesspoliciescomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesspoliciescomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesspoliciescomponents-schemas-singleresponse`` =
    { errors: Option<list<``accesspoliciescomponents-schemas-singleresponseErrors``>>
      messages: Option<list<``accesspoliciescomponents-schemas-singleresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<accesspolicies> }
    ///Creates an instance of accesspoliciescomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesspoliciescomponents-schemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type accesspolicycheckresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesspolicycheckresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicycheckresponseErrorsSource = { pointer = None }

type accesspolicycheckresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesspolicycheckresponseErrorsSource> }
    ///Creates an instance of accesspolicycheckresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesspolicycheckresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesspolicycheckresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesspolicycheckresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicycheckresponseMessagesSource = { pointer = None }

type accesspolicycheckresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesspolicycheckresponseMessagesSource> }
    ///Creates an instance of accesspolicycheckresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesspolicycheckresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Appstate =
    { ///UUID.
      app_uid: Option<accessuuid>
      aud: Option<string>
      hostname: Option<string>
      name: Option<string>
      policies: Option<Newtonsoft.Json.Linq.JArray>
      status: Option<string> }
    ///Creates an instance of Appstate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Appstate =
        { app_uid = None
          aud = None
          hostname = None
          name = None
          policies = None
          status = None }

type UseridentityGeo =
    { country: Option<string> }
    ///Creates an instance of UseridentityGeo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): UseridentityGeo = { country = None }

type Useridentity =
    { account_id: Option<string>
      device_sessions: Option<Newtonsoft.Json.Linq.JObject>
      email: Option<string>
      geo: Option<UseridentityGeo>
      iat: Option<int>
      id: Option<string>
      is_gateway: Option<bool>
      is_warp: Option<bool>
      name: Option<string>
      ///UUID.
      user_uuid: Option<accessuuid>
      version: Option<int> }
    ///Creates an instance of Useridentity with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Useridentity =
        { account_id = None
          device_sessions = None
          email = None
          geo = None
          iat = None
          id = None
          is_gateway = None
          is_warp = None
          name = None
          user_uuid = None
          version = None }

type accesspolicycheckresponseResult =
    { app_state: Option<Appstate>
      user_identity: Option<Useridentity> }
    ///Creates an instance of accesspolicycheckresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicycheckresponseResult =
        { app_state = None
          user_identity = None }

type accesspolicycheckresponse =
    { errors: list<accesspolicycheckresponseErrors>
      messages: list<accesspolicycheckresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<accesspolicycheckresponseResult> }
    ///Creates an instance of accesspolicycheckresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accesspolicycheckresponseErrors>,
                          messages: list<accesspolicycheckresponseMessages>,
                          success: bool): accesspolicycheckresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accesspolicyinitreq =
    { policies: Option<list<string>> }
    ///Creates an instance of accesspolicyinitreq with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyinitreq = { policies = None }

type accesspolicyinitrespErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesspolicyinitrespErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyinitrespErrorsSource = { pointer = None }

type accesspolicyinitrespErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesspolicyinitrespErrorsSource> }
    ///Creates an instance of accesspolicyinitrespErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesspolicyinitrespErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesspolicyinitrespMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesspolicyinitrespMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyinitrespMessagesSource = { pointer = None }

type accesspolicyinitrespMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesspolicyinitrespMessagesSource> }
    ///Creates an instance of accesspolicyinitrespMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesspolicyinitrespMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesspolicyinitrespResult =
    { ///The UUID of the policy test.
      id: Option<accesspolicytestid>
      ///The status of the policy test request.
      status: Option<accessstatus> }
    ///Creates an instance of accesspolicyinitrespResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyinitrespResult = { id = None; status = None }

type accesspolicyinitresp =
    { errors: list<accesspolicyinitrespErrors>
      messages: list<accesspolicyinitrespMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<accesspolicyinitrespResult> }
    ///Creates an instance of accesspolicyinitresp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accesspolicyinitrespErrors>,
                          messages: list<accesspolicyinitrespMessages>,
                          success: bool): accesspolicyinitresp =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accesspolicyreq =
    { ///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
      decision: Option<accessdecision>
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accessschemas-exclude``>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<``accessschemas-include``>
      ///The name of the Access policy.
      name: Option<``accesspolicycomponents-schemas-name``>
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accessschemas-require``>
      ///Administrators who can approve a temporary authentication request.
      approval_groups: Option<accessapprovalgroups>
      ///Requires the user to request access from an administrator at the start of each session.
      approval_required: Option<accessapprovalrequired>
      ///The rules that define how users may connect to targets secured by your application.
      connection_rules: Option<accessconnectionrules>
      ///Require this application to be served in an isolated browser for users matching this policy. 'Client Web Isolation' must be on for the account in order to use this feature.
      isolation_required: Option<accessisolationrequired>
      ///Configures multi-factor authentication (MFA) settings.
      mfa_config: Option<accessmfaconfig>
      ///A custom message that will appear on the purpose justification screen.
      purpose_justification_prompt: Option<accesspurposejustificationprompt>
      ///Require users to enter a justification when they log in to the application.
      purpose_justification_required: Option<accesspurposejustificationrequired>
      ///The amount of time that tokens issued for the application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accesscomponents-schemas-sessionduration``> }
    ///Creates an instance of accesspolicyreq with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyreq =
        { decision = None
          exclude = None
          ``include`` = None
          name = None
          require = None
          approval_groups = None
          approval_required = None
          connection_rules = None
          isolation_required = None
          mfa_config = None
          purpose_justification_prompt = None
          purpose_justification_required = None
          session_duration = None }

type accesspolicyresp =
    { created_at: Option<accesstimestamp>
      ///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
      decision: Option<accessdecision>
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accessschemas-exclude``>
      ///The UUID of the policy
      id: Option<``accessschemas-uuid``>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<``accessschemas-include``>
      ///The name of the Access policy.
      name: Option<``accesspolicycomponents-schemas-name``>
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accessschemas-require``>
      updated_at: Option<accesstimestamp>
      ///Administrators who can approve a temporary authentication request.
      approval_groups: Option<accessapprovalgroups>
      ///Requires the user to request access from an administrator at the start of each session.
      approval_required: Option<accessapprovalrequired>
      ///The rules that define how users may connect to targets secured by your application.
      connection_rules: Option<accessconnectionrules>
      ///Require this application to be served in an isolated browser for users matching this policy. 'Client Web Isolation' must be on for the account in order to use this feature.
      isolation_required: Option<accessisolationrequired>
      ///Configures multi-factor authentication (MFA) settings.
      mfa_config: Option<accessmfaconfig>
      ///A custom message that will appear on the purpose justification screen.
      purpose_justification_prompt: Option<accesspurposejustificationprompt>
      ///Require users to enter a justification when they log in to the application.
      purpose_justification_required: Option<accesspurposejustificationrequired>
      ///The amount of time that tokens issued for the application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accesscomponents-schemas-sessionduration``> }
    ///Creates an instance of accesspolicyresp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyresp =
        { created_at = None
          decision = None
          exclude = None
          id = None
          ``include`` = None
          name = None
          require = None
          updated_at = None
          approval_groups = None
          approval_required = None
          connection_rules = None
          isolation_required = None
          mfa_config = None
          purpose_justification_prompt = None
          purpose_justification_required = None
          session_duration = None }

type accesspolicyupdaterespErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesspolicyupdaterespErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyupdaterespErrorsSource = { pointer = None }

type accesspolicyupdaterespErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesspolicyupdaterespErrorsSource> }
    ///Creates an instance of accesspolicyupdaterespErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesspolicyupdaterespErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesspolicyupdaterespMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesspolicyupdaterespMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyupdaterespMessagesSource = { pointer = None }

type accesspolicyupdaterespMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesspolicyupdaterespMessagesSource> }
    ///Creates an instance of accesspolicyupdaterespMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesspolicyupdaterespMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesspolicyupdaterespResult =
    { ///The UUID of the policy test.
      id: Option<accesspolicytestid>
      ///The percentage of (processed) users approved based on policy evaluation results.
      percent_approved: Option<accesspercentapproved>
      ///The percentage of (processed) users blocked based on policy evaluation results.
      percent_blocked: Option<accesspercentblocked>
      ///The percentage of (processed) users errored based on policy evaluation results.
      percent_errored: Option<accesspercenterrored>
      ///The percentage of users processed so far (of the entire user base).
      percent_users_processed: Option<accesspercentusersprocessed>
      ///The status of the policy test.
      status: Option<accessupdatestatus>
      ///The total number of users in the user base.
      total_users: Option<accesstotalusers>
      ///The number of (processed) users approved based on policy evaluation results.
      users_approved: Option<accessusersapproved>
      ///The number of (processed) users blocked based on policy evaluation results.
      users_blocked: Option<accessusersblocked>
      ///The number of (processed) users errored based on policy evaluation results.
      users_errored: Option<accessuserserrored> }
    ///Creates an instance of accesspolicyupdaterespResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyupdaterespResult =
        { id = None
          percent_approved = None
          percent_blocked = None
          percent_errored = None
          percent_users_processed = None
          status = None
          total_users = None
          users_approved = None
          users_blocked = None
          users_errored = None }

type accesspolicyupdateresp =
    { errors: list<accesspolicyupdaterespErrors>
      messages: list<accesspolicyupdaterespMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<accesspolicyupdaterespResult> }
    ///Creates an instance of accesspolicyupdateresp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accesspolicyupdaterespErrors>,
                          messages: list<accesspolicyupdaterespMessages>,
                          success: bool): accesspolicyupdateresp =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accesspolicyusers =
    { ///The email of the user.
      email: Option<``accessschemas-email``>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the user.
      name: Option<``accessuserscomponents-schemas-name``>
      ///Policy evaluation result for an individual user.
      status: Option<accessuserresult> }
    ///Creates an instance of accesspolicyusers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyusers =
        { email = None
          id = None
          name = None
          status = None }

type accesspolicyusersrespErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesspolicyusersrespErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyusersrespErrorsSource = { pointer = None }

type accesspolicyusersrespErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesspolicyusersrespErrorsSource> }
    ///Creates an instance of accesspolicyusersrespErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesspolicyusersrespErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesspolicyusersrespMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesspolicyusersrespMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesspolicyusersrespMessagesSource = { pointer = None }

type accesspolicyusersrespMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesspolicyusersrespMessagesSource> }
    ///Creates an instance of accesspolicyusersrespMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesspolicyusersrespMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesspolicyusersresp =
    { errors: list<accesspolicyusersrespErrors>
      messages: list<accesspolicyusersrespMessages>
      ///Whether the API call was successful.
      success: bool
      ///Page of processed users.
      result: Option<list<accesspolicyusers>> }
    ///Creates an instance of accesspolicyusersresp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accesspolicyusersrespErrors>,
                          messages: list<accesspolicyusersrespMessages>,
                          success: bool): accesspolicyusersresp =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accessproxyendpointprops =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: Option<accessdomain>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///The application type.
      ``type``: Option<accesstype> }
    ///Creates an instance of accessproxyendpointprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessproxyendpointprops =
        { allowed_idps = None
          auto_redirect_to_identity = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          domain = None
          name = None
          session_duration = None
          ``type`` = None }

type accessrdpprops =
    { target_criteria: list<accesstargetcriteriaselfhostedapp>
      ///When set to true, users can authenticate to this application using their WARP session.  When set to false this application will always require direct IdP authentication. This setting always overrides the organization setting for WARP authentication.
      allow_authenticate_via_warp: Option<``accessschemas-allowauthenticateviawarp``>
      ///Enables loading application content in an iFrame.
      allow_iframe: Option<accessallowiframe>
      ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      cors_headers: Option<accesscorsheaders>
      ///The custom error message shown to a user when they are denied access to the application.
      custom_deny_message: Option<accesscustomdenymessage>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///List of destinations secured by Access. This supersedes `self_hosted_domains` to allow for more flexibility in defining different types of domains. If `destinations` are provided, then `self_hosted_domains` will be ignored.
      destinations: Option<accessdestinations>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: Option<accessdomain>
      ///Enables the binding cookie, which increases security against compromised authorization tokens and CSRF attacks.
      enable_binding_cookie: Option<accessenablebindingcookie>
      ///Enables the HttpOnly cookie attribute, which increases security against XSS attacks.
      http_only_cookie_attribute: Option<accesshttponlycookieattribute>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///Configures multi-factor authentication (MFA) settings.
      mfa_config: Option<accessmfaconfig>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///**Beta:** Optional configuration for managing an OAuth authorization flow controlled by Access. When set, Access will act as the OAuth authorization server for this application. Only compatible with OAuth clients that support [RFC 8707](https://datatracker.ietf.org/doc/html/rfc8707) (Resource Indicators for OAuth 2.0). This feature is currently in beta.
      oauth_configuration: Option<accessoauthconfiguration>
      ///Allows options preflight requests to bypass Access authentication and go directly to the origin. Cannot turn on if cors_headers is set.
      options_preflight_bypass: Option<accessoptionspreflightbypass>
      ///Enables cookie paths to scope an application's JWT to the application path. If disabled, the JWT will scope to the hostname by default
      path_cookie_attribute: Option<accesspathcookieattribute>
      ///Allows matching Access Service Tokens passed HTTP in a single header with this name.
      ///This works as an alternative to the (CF-Access-Client-Id, CF-Access-Client-Secret) pair of headers.
      ///The header value will be interpreted as a json object similar to:
      ///  {
      ///    "cf-access-client-id": "88bf3b6d86161464f6509f7219099e57.access.example.com",
      ///    "cf-access-client-secret": "bdd31cbc4dec990953e39163fbbb194c93313ca9f0a6e420346af9d326b1d2a5"
      ///  }
      read_service_tokens_from_header: Option<accessreadservicetokensfromheader>
      ///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
      same_site_cookie_attribute: Option<accesssamesitecookieattribute>
      ///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
      scim_config: Option<accessscimconfig>
      ///Returns a 401 status code when the request is blocked by a Service Auth policy.
      service_auth_401_redirect: Option<accessserviceauth401redirect>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///Enables automatic authentication through cloudflared.
      skip_interstitial: Option<accessskipinterstitial>
      ///The tags you want assigned to an application. Tags are used to filter applications in the App Launcher dashboard.
      tags: Option<accesstags>
      ///The application type.
      ``type``: Option<accesstype>
      ///Determines if users can access this application via a clientless browser isolation URL.
      ///This allows users to access private domains without connecting to Gateway. The option requires
      ///Clientless Browser Isolation to be set up with policies that allow users of this application.
      use_clientless_isolation_app_launcher_url: Option<accessuseclientlessisolationapplauncherurl> }
    ///Creates an instance of accessrdpprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (target_criteria: list<accesstargetcriteriaselfhostedapp>): accessrdpprops =
        { target_criteria = target_criteria
          allow_authenticate_via_warp = None
          allow_iframe = None
          allowed_idps = None
          app_launcher_visible = None
          auto_redirect_to_identity = None
          cors_headers = None
          custom_deny_message = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          destinations = None
          domain = None
          enable_binding_cookie = None
          http_only_cookie_attribute = None
          logo_url = None
          mfa_config = None
          name = None
          oauth_configuration = None
          options_preflight_bypass = None
          path_cookie_attribute = None
          read_service_tokens_from_header = None
          same_site_cookie_attribute = None
          scim_config = None
          service_auth_401_redirect = None
          session_duration = None
          skip_interstitial = None
          tags = None
          ``type`` = None
          use_clientless_isolation_app_launcher_url = None }

type accessresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessresponsecollectionErrorsSource = { pointer = None }

type accessresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessresponsecollectionErrorsSource> }
    ///Creates an instance of accessresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessresponsecollectionMessagesSource = { pointer = None }

type accessresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessresponsecollectionMessagesSource> }
    ///Creates an instance of accessresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type accessresponsecollection =
    { errors: list<accessresponsecollectionErrors>
      messages: list<accessresponsecollectionMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<accessresponsecollectionResultinfo>
      result: Option<list<string>> }
    ///Creates an instance of accessresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessresponsecollectionErrors>,
                          messages: list<accessresponsecollectionMessages>,
                          success: bool): accessresponsecollection =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type accessresponsecollectionhostnamesErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessresponsecollectionhostnamesErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessresponsecollectionhostnamesErrorsSource = { pointer = None }

type accessresponsecollectionhostnamesErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessresponsecollectionhostnamesErrorsSource> }
    ///Creates an instance of accessresponsecollectionhostnamesErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessresponsecollectionhostnamesErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessresponsecollectionhostnamesMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessresponsecollectionhostnamesMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessresponsecollectionhostnamesMessagesSource = { pointer = None }

type accessresponsecollectionhostnamesMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessresponsecollectionhostnamesMessagesSource> }
    ///Creates an instance of accessresponsecollectionhostnamesMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessresponsecollectionhostnamesMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessresponsecollectionhostnamesResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessresponsecollectionhostnamesResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessresponsecollectionhostnamesResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type accessresponsecollectionhostnames =
    { errors: list<accessresponsecollectionhostnamesErrors>
      messages: list<accessresponsecollectionhostnamesMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<accessresponsecollectionhostnamesResultinfo>
      result: Option<list<accesssettings>> }
    ///Creates an instance of accessresponsecollectionhostnames with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessresponsecollectionhostnamesErrors>,
                          messages: list<accessresponsecollectionhostnamesMessages>,
                          success: bool): accessresponsecollectionhostnames =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type accessresponses =
    { ///The unique Cloudflare-generated Id of the SCIM resource.
      cf_resource_id: Option<string>
      ///The error message which is generated when the status of the SCIM request is 'FAILURE'.
      error_description: Option<string>
      ///The unique Id of the IdP that has SCIM enabled.
      idp_id: Option<string>
      ///The IdP-generated Id of the SCIM resource.
      idp_resource_id: Option<string>
      logged_at: Option<accesstimestamp>
      ///The JSON-encoded string body of the SCIM request.
      request_body: Option<string>
      ///The request method of the SCIM request.
      request_method: Option<string>
      ///The display name of the SCIM Group resource if it exists.
      resource_group_name: Option<string>
      ///The resource type of the SCIM request.
      resource_type: Option<string>
      ///The email address of the SCIM User resource if it exists.
      resource_user_email: Option<string>
      ///The status of the SCIM request.
      status: Option<string> }
    ///Creates an instance of accessresponses with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessresponses =
        { cf_resource_id = None
          error_description = None
          idp_id = None
          idp_resource_id = None
          logged_at = None
          request_body = None
          request_method = None
          resource_group_name = None
          resource_type = None
          resource_user_email = None
          status = None }

type ``accessreusable-policiescomponents-schemas-idresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-idresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessreusable-policiescomponents-schemas-idresponseErrorsSource`` = { pointer = None }

type ``accessreusable-policiescomponents-schemas-idresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessreusable-policiescomponents-schemas-idresponseErrorsSource``> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-idresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessreusable-policiescomponents-schemas-idresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessreusable-policiescomponents-schemas-idresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-idresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessreusable-policiescomponents-schemas-idresponseMessagesSource`` = { pointer = None }

type ``accessreusable-policiescomponents-schemas-idresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessreusable-policiescomponents-schemas-idresponseMessagesSource``> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-idresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessreusable-policiescomponents-schemas-idresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessreusable-policiescomponents-schemas-idresponseResult`` =
    { ///The UUID of the policy
      id: Option<``accessschemas-uuid``> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-idresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessreusable-policiescomponents-schemas-idresponseResult`` = { id = None }

type ``accessreusable-policiescomponents-schemas-idresponse`` =
    { errors: list<``accessreusable-policiescomponents-schemas-idresponseErrors``>
      messages: list<``accessreusable-policiescomponents-schemas-idresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``accessreusable-policiescomponents-schemas-idresponseResult``> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-idresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessreusable-policiescomponents-schemas-idresponseErrors``>,
                          messages: list<``accessreusable-policiescomponents-schemas-idresponseMessages``>,
                          success: bool): ``accessreusable-policiescomponents-schemas-idresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``accessreusable-policiescomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessreusable-policiescomponents-schemas-responsecollectionErrorsSource`` =
        { pointer = None }

type ``accessreusable-policiescomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessreusable-policiescomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessreusable-policiescomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessreusable-policiescomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessreusable-policiescomponents-schemas-responsecollectionMessagesSource`` =
        { pointer = None }

type ``accessreusable-policiescomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessreusable-policiescomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessreusable-policiescomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessreusable-policiescomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessreusable-policiescomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessreusable-policiescomponents-schemas-responsecollection`` =
    { errors: list<``accessreusable-policiescomponents-schemas-responsecollectionErrors``>
      messages: list<``accessreusable-policiescomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accessreusable-policiescomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accessreusablepolicyresp>> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessreusable-policiescomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accessreusable-policiescomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accessreusable-policiescomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accessreusable-policiescomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessreusable-policiescomponents-schemas-singleresponseErrorsSource`` =
        { pointer = None }

type ``accessreusable-policiescomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessreusable-policiescomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessreusable-policiescomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessreusable-policiescomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessreusable-policiescomponents-schemas-singleresponseMessagesSource`` =
        { pointer = None }

type ``accessreusable-policiescomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessreusable-policiescomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessreusable-policiescomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessreusable-policiescomponents-schemas-singleresponse`` =
    { errors: list<``accessreusable-policiescomponents-schemas-singleresponseErrors``>
      messages: list<``accessreusable-policiescomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<accessreusablepolicyresp> }
    ///Creates an instance of accessreusable-policiescomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessreusable-policiescomponents-schemas-singleresponseErrors``>,
                          messages: list<``accessreusable-policiescomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accessreusable-policiescomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accessreusablepolicyresp =
    { ///Administrators who can approve a temporary authentication request.
      approval_groups: Option<accessapprovalgroups>
      ///Requires the user to request access from an administrator at the start of each session.
      approval_required: Option<accessapprovalrequired>
      ///The rules that define how users may connect to targets secured by your application.
      connection_rules: Option<accessconnectionrules>
      ///Require this application to be served in an isolated browser for users matching this policy. 'Client Web Isolation' must be on for the account in order to use this feature.
      isolation_required: Option<accessisolationrequired>
      ///Configures multi-factor authentication (MFA) settings.
      mfa_config: Option<accessmfaconfig>
      ///A custom message that will appear on the purpose justification screen.
      purpose_justification_prompt: Option<accesspurposejustificationprompt>
      ///Require users to enter a justification when they log in to the application.
      purpose_justification_required: Option<accesspurposejustificationrequired>
      ///The amount of time that tokens issued for the application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accesscomponents-schemas-sessionduration``>
      created_at: Option<accesstimestamp>
      ///The action Access will take if a user matches this policy. Infrastructure application policies can only use the Allow action.
      decision: Option<accessdecision>
      ///Rules evaluated with a NOT logical operator. To match the policy, a user cannot meet any of the Exclude rules.
      exclude: Option<``accessschemas-exclude``>
      ///The UUID of the policy
      id: Option<``accessschemas-uuid``>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<``accessschemas-include``>
      ///The name of the Access policy.
      name: Option<``accesspolicycomponents-schemas-name``>
      ///Rules evaluated with an AND logical operator. To match the policy, a user must meet all of the Require rules.
      require: Option<``accessschemas-require``>
      updated_at: Option<accesstimestamp>
      ///Number of access applications currently using this policy.
      app_count: Option<accessappcount>
      reusable: Option<bool> }
    ///Creates an instance of accessreusablepolicyresp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessreusablepolicyresp =
        { approval_groups = None
          approval_required = None
          connection_rules = None
          isolation_required = None
          mfa_config = None
          purpose_justification_prompt = None
          purpose_justification_required = None
          session_duration = None
          created_at = None
          decision = None
          exclude = None
          id = None
          ``include`` = None
          name = None
          require = None
          updated_at = None
          app_count = None
          reusable = None }

type accesssaasprops =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      saas_app: Option<Newtonsoft.Json.Linq.JObject>
      ///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
      scim_config: Option<accessscimconfig>
      ///The tags you want assigned to an application. Tags are used to filter applications in the App Launcher dashboard.
      tags: Option<accesstags>
      ///The application type.
      ``type``: Option<accesstype> }
    ///Creates an instance of accesssaasprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssaasprops =
        { allowed_idps = None
          app_launcher_visible = None
          auto_redirect_to_identity = None
          custom_pages = None
          logo_url = None
          name = None
          saas_app = None
          scim_config = None
          tags = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesssamlScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accesssamlScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accesssamlScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accesssamlScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssamlScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesssamlType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type Headerattributes =
    { ///attribute name from the IDP
      attribute_name: Option<string>
      ///header that will be added on the request to the origin
      header_name: Option<string> }
    ///Creates an instance of Headerattributes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Headerattributes =
        { attribute_name = None
          header_name = None }

type accesssamlConfig =
    { ///A list of SAML attribute names that will be added to your signed JWT token and can be used in SAML policy rules.
      attributes: Option<list<string>>
      ///The attribute name for email in the SAML response.
      email_attribute_name: Option<string>
      ///Add a list of attribute names that will be returned in the response header from the Access callback.
      header_attributes: Option<list<Headerattributes>>
      ///X509 certificate to verify the signature in the SAML authentication response
      idp_public_certs: Option<list<string>>
      ///IdP Entity ID or Issuer URL
      issuer_url: Option<string>
      ///Sign the SAML authentication request with Access credentials. To verify the signature, use the public key from the Access certs endpoints.
      sign_request: Option<bool>
      ///URL to send the SAML authentication requests to
      sso_target_url: Option<string> }
    ///Creates an instance of accesssamlConfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssamlConfig =
        { attributes = None
          email_attribute_name = None
          header_attributes = None
          idp_public_certs = None
          issuer_url = None
          sign_request = None
          sso_target_url = None }

type accesssaml =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accesssamlScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accesssamlType> }
    ///Creates an instance of accesssaml with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssaml =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type Saml =
    { ///The name of the SAML attribute.
      attribute_name: string
      ///The SAML attribute value to look for.
      attribute_value: string
      ///The ID of your SAML identity provider.
      identity_provider_id: string }
    ///Creates an instance of Saml with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (attribute_name: string, attribute_value: string, identity_provider_id: string): Saml =
        { attribute_name = attribute_name
          attribute_value = attribute_value
          identity_provider_id = identity_provider_id }

///Matches a SAML group.
///Requires a SAML identity provider.
type accesssamlgrouprule =
    { saml: Saml }
    ///Creates an instance of accesssamlgrouprule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (saml: Saml): accesssamlgrouprule = { saml = saml }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accesssamlsaasappAuthtype =
    | [<CompiledName "saml">] Saml
    | [<CompiledName "oidc">] Oidc
    member this.Format() =
        match this with
        | Saml -> "saml"
        | Oidc -> "oidc"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Nameformat =
    | [<CompiledName "urn:oasis:names:tc:SAML:2.0:attrname-format:unspecified">] ``Urn:oasis:names:tc:SAML:2AttrnameFormat:unspecified``
    | [<CompiledName "urn:oasis:names:tc:SAML:2.0:attrname-format:basic">] ``Urn:oasis:names:tc:SAML:2AttrnameFormat:basic``
    | [<CompiledName "urn:oasis:names:tc:SAML:2.0:attrname-format:uri">] ``Urn:oasis:names:tc:SAML:2AttrnameFormat:uri``
    member this.Format() =
        match this with
        | ``Urn:oasis:names:tc:SAML:2AttrnameFormat:unspecified`` ->
            "urn:oasis:names:tc:SAML:2.0:attrname-format:unspecified"
        | ``Urn:oasis:names:tc:SAML:2AttrnameFormat:basic`` -> "urn:oasis:names:tc:SAML:2.0:attrname-format:basic"
        | ``Urn:oasis:names:tc:SAML:2AttrnameFormat:uri`` -> "urn:oasis:names:tc:SAML:2.0:attrname-format:uri"

type Namebyidp =
    { ///The UID of the IdP.
      idp_id: Option<string>
      ///The name of the IdP provided attribute.
      source_name: Option<string> }
    ///Creates an instance of Namebyidp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Namebyidp = { idp_id = None; source_name = None }

type CustomattributesSource =
    { ///The name of the IdP attribute.
      name: Option<string>
      ///A mapping from IdP ID to attribute name.
      name_by_idp: Option<list<Namebyidp>> }
    ///Creates an instance of CustomattributesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): CustomattributesSource = { name = None; name_by_idp = None }

type Customattributes =
    { ///The SAML FriendlyName of the attribute.
      friendly_name: Option<string>
      ///The name of the attribute.
      name: Option<string>
      ///A globally unique name for an identity or service provider.
      name_format: Option<Nameformat>
      ///If the attribute is required when building a SAML assertion.
      required: Option<bool>
      source: Option<CustomattributesSource> }
    ///Creates an instance of Customattributes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Customattributes =
        { friendly_name = None
          name = None
          name_format = None
          required = None
          source = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Nameidformat =
    | [<CompiledName "id">] Id
    | [<CompiledName "email">] Email
    member this.Format() =
        match this with
        | Id -> "id"
        | Email -> "email"

type accesssamlsaasapp =
    { ///Optional identifier indicating the authentication protocol used for the saas app. Required for OIDC. Default if unset is "saml"
      auth_type: Option<accesssamlsaasappAuthtype>
      ///The service provider's endpoint that is responsible for receiving and parsing a SAML assertion.
      consumer_service_url: Option<string>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      custom_attributes: Option<list<Customattributes>>
      ///The URL that the user will be redirected to after a successful login for IDP initiated logins.
      default_relay_state: Option<string>
      ///The unique identifier for your SaaS application.
      idp_entity_id: Option<string>
      ///The format of the name identifier sent to the SaaS application.
      name_id_format: Option<Nameidformat>
      ///A [JSONata](https://jsonata.org/) expression that transforms an application's user identities into a NameID value for its SAML assertion. This expression should evaluate to a singular string. The output of this expression can override the `name_id_format` setting.
      name_id_transform_jsonata: Option<string>
      ///The Access public certificate that will be used to verify your identity.
      public_key: Option<string>
      ///A [JSONata] (https://jsonata.org/) expression that transforms an application's user identities into attribute assertions in the SAML response. The expression can transform id, email, name, and groups values. It can also transform fields listed in the saml_attributes or oidc_fields of the identity provider used to authenticate. The output of this expression must be a JSON object.
      saml_attribute_transform_jsonata: Option<string>
      ///A globally unique name for an identity or service provider.
      sp_entity_id: Option<string>
      ///The endpoint where your SaaS application will send login requests.
      sso_endpoint: Option<string>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accesssamlsaasapp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssamlsaasapp =
        { auth_type = None
          consumer_service_url = None
          created_at = None
          custom_attributes = None
          default_relay_state = None
          idp_entity_id = None
          name_id_format = None
          name_id_transform_jsonata = None
          public_key = None
          saml_attribute_transform_jsonata = None
          sp_entity_id = None
          sso_endpoint = None
          updated_at = None }

type ``accessschemas-applauncherprops`` =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The domain and path that Access will secure.
      domain: Option<``accesscomponents-schemas-domain``>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accessappscomponents-schemas-sessionduration``>
      ///The application type.
      ``type``: Option<``accesscomponents-schemas-type``> }
    ///Creates an instance of accessschemas-applauncherprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-applauncherprops`` =
        { allowed_idps = None
          auto_redirect_to_identity = None
          domain = None
          name = None
          session_duration = None
          ``type`` = None }

///A group of email addresses that can approve a temporary authentication request.
type ``accessschemas-approvalgroup`` =
    { ///The number of approvals needed to obtain access.
      approvals_needed: float
      ///A list of emails that can approve the access request.
      email_addresses: Option<list<string>>
      ///The UUID of an re-usable email list.
      email_list_uuid: Option<string> }
    ///Creates an instance of accessschemas-approvalgroup with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (approvals_needed: float): ``accessschemas-approvalgroup`` =
        { approvals_needed = approvals_needed
          email_addresses = None
          email_list_uuid = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-azureADScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-azureADScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-azureADScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-azureADScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-azureADScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-azureADType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-azureAD`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-azureADScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-azureADType``> }
    ///Creates an instance of accessschemas-azureAD with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-azureAD`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type ``accessschemas-basicappresponseprops`` =
    { ///Audience tag.
      aud: Option<``accessschemas-aud``>
      created_at: Option<accesstimestamp>
      ///UUID.
      id: Option<accessuuid>
      ///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
      scim_config: Option<``accessschemas-scimconfig``>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accessschemas-basicappresponseprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-basicappresponseprops`` =
        { aud = None
          created_at = None
          id = None
          scim_config = None
          updated_at = None }

type ``accessschemas-bisoprops`` =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The domain and path that Access will secure.
      domain: Option<``accesscomponents-schemas-domain``>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accessappscomponents-schemas-sessionduration``>
      ///The application type.
      ``type``: Option<``accesscomponents-schemas-type``> }
    ///Creates an instance of accessschemas-bisoprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-bisoprops`` =
        { allowed_idps = None
          auto_redirect_to_identity = None
          domain = None
          name = None
          session_duration = None
          ``type`` = None }

type ``accessschemas-bookmarkprops`` =
    { app_launcher_visible: Option<Newtonsoft.Json.Linq.JToken>
      ///The URL or domain of the bookmark.
      domain: Newtonsoft.Json.Linq.JToken
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The application type.
      ``type``: string }
    ///Creates an instance of accessschemas-bookmarkprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: Newtonsoft.Json.Linq.JToken, ``type``: string): ``accessschemas-bookmarkprops`` =
        { app_launcher_visible = None
          domain = domain
          logo_url = None
          name = None
          ``type`` = ``type`` }

type ``accessschemas-ca`` =
    { ///The Application Audience (AUD) tag. Identifies the application associated with the CA.
      aud: Option<``accesscomponents-schemas-aud``>
      ///The ID of the CA.
      id: Option<``accesscomponents-schemas-id``>
      ///The public key to add to your SSH server configuration.
      public_key: Option<accesspublickey> }
    ///Creates an instance of accessschemas-ca with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-ca`` =
        { aud = None
          id = None
          public_key = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-centrifyScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-centrifyScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-centrifyScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-centrifyScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-centrifyScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-centrifyType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-centrify`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-centrifyScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-centrifyType``> }
    ///Creates an instance of accessschemas-centrify with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-centrify`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type ``accessschemas-certificates`` =
    { ///The key ID of this certificate.
      id: Option<string>
      ///The public key of this certificate.
      public_key: Option<string> }
    ///Creates an instance of accessschemas-certificates with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-certificates`` = { id = None; public_key = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-corsheadersAllowed_methods`` =
    | [<CompiledName "GET">] GET
    | [<CompiledName "POST">] POST
    | [<CompiledName "HEAD">] HEAD
    | [<CompiledName "PUT">] PUT
    | [<CompiledName "DELETE">] DELETE
    | [<CompiledName "CONNECT">] CONNECT
    | [<CompiledName "OPTIONS">] OPTIONS
    | [<CompiledName "TRACE">] TRACE
    | [<CompiledName "PATCH">] PATCH
    member this.Format() =
        match this with
        | GET -> "GET"
        | POST -> "POST"
        | HEAD -> "HEAD"
        | PUT -> "PUT"
        | DELETE -> "DELETE"
        | CONNECT -> "CONNECT"
        | OPTIONS -> "OPTIONS"
        | TRACE -> "TRACE"
        | PATCH -> "PATCH"

type ``accessschemas-corsheaders`` =
    { ///Allows all HTTP request headers.
      allow_all_headers: Option<accessallowallheaders>
      ///Allows all HTTP request methods.
      allow_all_methods: Option<accessallowallmethods>
      ///Allows all origins.
      allow_all_origins: Option<accessallowallorigins>
      ///When set to `true`, includes credentials (cookies, authorization headers, or TLS client certificates) with requests.
      allow_credentials: Option<accessallowcredentials>
      ///Allowed HTTP request headers.
      allowed_headers: Option<``accessschemas-allowedheaders``>
      ///Allowed HTTP request methods.
      allowed_methods: Option<list<``accessschemas-corsheadersAllowed_methods``>>
      ///Allowed origins.
      allowed_origins: Option<``accessschemas-allowedorigins``>
      ///The maximum number of seconds the results of a preflight request can be cached.
      max_age: Option<accessmaxage> }
    ///Creates an instance of accessschemas-corsheaders with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-corsheaders`` =
        { allow_all_headers = None
          allow_all_methods = None
          allow_all_origins = None
          allow_credentials = None
          allowed_headers = None
          allowed_methods = None
          allowed_origins = None
          max_age = None }

type ``accessschemas-createresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-createresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-createresponseErrorsSource`` = { pointer = None }

type ``accessschemas-createresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-createresponseErrorsSource``> }
    ///Creates an instance of accessschemas-createresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-createresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-createresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-createresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-createresponseMessagesSource`` = { pointer = None }

type ``accessschemas-createresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-createresponseMessagesSource``> }
    ///Creates an instance of accessschemas-createresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-createresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-createresponse`` =
    { errors: Option<list<``accessschemas-createresponseErrors``>>
      messages: Option<list<``accessschemas-createresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accessschemas-createresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-createresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``accessschemas-deviceposturerule`` =
    { check: Option<accessdeviceposturecheck>
      data: Option<Newtonsoft.Json.Linq.JObject>
      description: Option<string>
      error: Option<string>
      id: Option<string>
      rule_name: Option<string>
      success: Option<bool>
      timestamp: Option<string>
      ``type``: Option<string> }
    ///Creates an instance of accessschemas-deviceposturerule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-deviceposturerule`` =
        { check = None
          data = None
          description = None
          error = None
          id = None
          rule_name = None
          success = None
          timestamp = None
          ``type`` = None }

type ``accessschemas-emptyresponse`` =
    { result: Option<Newtonsoft.Json.Linq.JObject>
      success: Option<bool> }
    ///Creates an instance of accessschemas-emptyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-emptyresponse`` = { result = None; success = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-facebookScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-facebookScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-facebookScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-facebookScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-facebookScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-facebookType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-facebook`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-facebookScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-facebookType``> }
    ///Creates an instance of accessschemas-facebook with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-facebook`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type ``accessschemas-featureappprops`` =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The domain and path that Access will secure.
      domain: Option<``accesscomponents-schemas-domain``>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accessappscomponents-schemas-sessionduration``>
      ///The application type.
      ``type``: ``accesscomponents-schemas-type`` }
    ///Creates an instance of accessschemas-featureappprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``accesscomponents-schemas-type``): ``accessschemas-featureappprops`` =
        { allowed_idps = None
          auto_redirect_to_identity = None
          domain = None
          name = None
          session_duration = None
          ``type`` = ``type`` }

type ``accessschemas-generic-oauth-config`` =
    { ///Your OAuth Client ID
      client_id: Option<string>
      ///Your OAuth Client Secret
      client_secret: Option<string> }
    ///Creates an instance of accessschemas-generic-oauth-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-generic-oauth-config`` =
        { client_id = None
          client_secret = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-githubScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-githubScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-githubScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-githubScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-githubScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-githubType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-github`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-githubScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-githubType``> }
    ///Creates an instance of accessschemas-github with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-github`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-googleScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-googleScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-googleScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-googleScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-googleScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-googleType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-google`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-googleScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-googleType``> }
    ///Creates an instance of accessschemas-google with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-google`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-google-appsScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-google-appsScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-google-appsScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-google-appsScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-google-appsScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-google-appsType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-google-apps`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-google-appsScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-google-appsType``> }
    ///Creates an instance of accessschemas-google-apps with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-google-apps`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type ``accessschemas-groups`` =
    { created_at: Option<Newtonsoft.Json.Linq.JToken>
      ///Rules evaluated with a NOT logical operator. To match a policy, a user cannot meet any of the Exclude rules.
      exclude: Option<accessexclude>
      ///UUID.
      id: Option<accessuuid>
      ///Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.
      ``include``: Option<accessinclude>
      ///Rules evaluated with an AND logical operator. To match a policy, a user must meet all of the Require rules.
      is_default: Option<accessrequire>
      ///The name of the Access group.
      name: Option<``accessgroupscomponents-schemas-name``>
      ///Rules evaluated with an AND logical operator. To match a policy, a user must meet all of the Require rules.
      require: Option<accessrequire>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accessschemas-groups with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-groups`` =
        { created_at = None
          exclude = None
          id = None
          ``include`` = None
          is_default = None
          name = None
          require = None
          updated_at = None }

type ``accessschemas-idresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-idresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-idresponseErrorsSource`` = { pointer = None }

type ``accessschemas-idresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-idresponseErrorsSource``> }
    ///Creates an instance of accessschemas-idresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-idresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-idresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-idresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-idresponseMessagesSource`` = { pointer = None }

type ``accessschemas-idresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-idresponseMessagesSource``> }
    ///Creates an instance of accessschemas-idresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-idresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-idresponseResult`` =
    { ///The ID of the CA.
      id: Option<``accessschemas-id``> }
    ///Creates an instance of accessschemas-idresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-idresponseResult`` = { id = None }

type ``accessschemas-idresponse`` =
    { errors: list<``accessschemas-idresponseErrors``>
      messages: list<``accessschemas-idresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``accessschemas-idresponseResult``> }
    ///Creates an instance of accessschemas-idresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessschemas-idresponseErrors``>,
                          messages: list<``accessschemas-idresponseMessages``>,
                          success: bool): ``accessschemas-idresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-identity-providerScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-identity-providerScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-identity-providerScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-identity-providerScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-identity-providerScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-identity-providerType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-identity-provider`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Newtonsoft.Json.Linq.JObject
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: ``accesscomponents-schemas-name``
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-identity-providerScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: ``accessschemas-identity-providerType`` }
    ///Creates an instance of accessschemas-identity-provider with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (config: Newtonsoft.Json.Linq.JObject,
                          name: ``accesscomponents-schemas-name``,
                          ``type``: ``accessschemas-identity-providerType``): ``accessschemas-identity-provider`` =
        { config = config
          id = None
          name = name
          scim_config = None
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-linkedinScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-linkedinScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-linkedinScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-linkedinScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-linkedinScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-linkedinType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-linkedin`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-linkedinScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-linkedinType``> }
    ///Creates an instance of accessschemas-linkedin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-linkedin`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type ``accessschemas-logindesign`` =
    { ///The background color on your login page.
      background_color: Option<string>
      ///The text at the bottom of your login page.
      footer_text: Option<string>
      ///The text at the top of your login page.
      header_text: Option<string>
      ///The URL of the logo on your login page.
      logo_path: Option<string>
      ///The text color on your login page.
      text_color: Option<string> }
    ///Creates an instance of accessschemas-logindesign with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-logindesign`` =
        { background_color = None
          footer_text = None
          header_text = None
          logo_path = None
          text_color = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oidcScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-oidcScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-oidcScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-oidcScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oidcScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oidcType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-oidc`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-oidcScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-oidcType``> }
    ///Creates an instance of accessschemas-oidc with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oidc`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oidcsaasappAuthtype`` =
    | [<CompiledName "saml">] Saml
    | [<CompiledName "oidc">] Oidc
    member this.Format() =
        match this with
        | Saml -> "saml"
        | Oidc -> "oidc"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oidcsaasappCustomclaimsScope`` =
    | [<CompiledName "groups">] Groups
    | [<CompiledName "profile">] Profile
    | [<CompiledName "email">] Email
    | [<CompiledName "openid">] Openid
    member this.Format() =
        match this with
        | Groups -> "groups"
        | Profile -> "profile"
        | Email -> "email"
        | Openid -> "openid"

type ``accessschemas-oidcsaasappCustomclaimsSourceNamebyidp`` =
    { ///The UID of the IdP.
      idp_id: Option<string>
      ///The name of the IdP provided attribute.
      source_name: Option<string> }
    ///Creates an instance of accessschemas-oidcsaasappCustomclaimsSourceNamebyidp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oidcsaasappCustomclaimsSourceNamebyidp`` =
        { idp_id = None; source_name = None }

type ``accessschemas-oidcsaasappCustomclaimsSource`` =
    { ///The name of the IdP claim.
      name: Option<string>
      ///A mapping from IdP ID to attribute name.
      name_by_idp: Option<list<``accessschemas-oidcsaasappCustomclaimsSourceNamebyidp``>> }
    ///Creates an instance of accessschemas-oidcsaasappCustomclaimsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oidcsaasappCustomclaimsSource`` = { name = None; name_by_idp = None }

type ``accessschemas-oidcsaasappCustomclaims`` =
    { ///The name of the claim.
      name: Option<string>
      ///If the claim is required when building an OIDC token.
      required: Option<bool>
      ///The scope of the claim.
      scope: Option<``accessschemas-oidcsaasappCustomclaimsScope``>
      source: Option<``accessschemas-oidcsaasappCustomclaimsSource``> }
    ///Creates an instance of accessschemas-oidcsaasappCustomclaims with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oidcsaasappCustomclaims`` =
        { name = None
          required = None
          scope = None
          source = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oidcsaasappGrant_types`` =
    | [<CompiledName "authorization_code">] Authorization_code
    | [<CompiledName "authorization_code_with_pkce">] Authorization_code_with_pkce
    | [<CompiledName "refresh_tokens">] Refresh_tokens
    | [<CompiledName "hybrid">] Hybrid
    | [<CompiledName "implicit">] Implicit
    member this.Format() =
        match this with
        | Authorization_code -> "authorization_code"
        | Authorization_code_with_pkce -> "authorization_code_with_pkce"
        | Refresh_tokens -> "refresh_tokens"
        | Hybrid -> "hybrid"
        | Implicit -> "implicit"

type ``accessschemas-oidcsaasappHybridandimplicitoptions`` =
    { ///If an Access Token should be returned from the OIDC Authorization endpoint
      return_access_token_from_authorization_endpoint: Option<bool>
      ///If an ID Token should be returned from the OIDC Authorization endpoint
      return_id_token_from_authorization_endpoint: Option<bool> }
    ///Creates an instance of accessschemas-oidcsaasappHybridandimplicitoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oidcsaasappHybridandimplicitoptions`` =
        { return_access_token_from_authorization_endpoint = None
          return_id_token_from_authorization_endpoint = None }

type ``accessschemas-oidcsaasappRefreshtokenoptions`` =
    { ///How long a refresh token will be valid for after creation. Valid units are m,h,d. Must be longer than 1m.
      lifetime: Option<string> }
    ///Creates an instance of accessschemas-oidcsaasappRefreshtokenoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oidcsaasappRefreshtokenoptions`` = { lifetime = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oidcsaasappScopes`` =
    | [<CompiledName "openid">] Openid
    | [<CompiledName "groups">] Groups
    | [<CompiledName "email">] Email
    | [<CompiledName "profile">] Profile
    member this.Format() =
        match this with
        | Openid -> "openid"
        | Groups -> "groups"
        | Email -> "email"
        | Profile -> "profile"

type ``accessschemas-oidcsaasapp`` =
    { ///The lifetime of the OIDC Access Token after creation. Valid units are m,h. Must be greater than or equal to 1m and less than or equal to 24h.
      access_token_lifetime: Option<string>
      ///If client secret should be required on the token endpoint when authorization_code_with_pkce grant is used.
      allow_pkce_without_client_secret: Option<bool>
      ///The URL where this applications tile redirects users
      app_launcher_url: Option<string>
      ///Identifier of the authentication protocol used for the saas app. Required for OIDC.
      auth_type: Option<``accessschemas-oidcsaasappAuthtype``>
      ///The application client id
      client_id: Option<string>
      ///The application client secret, only returned on POST request.
      client_secret: Option<string>
      created_at: Option<accesstimestamp>
      custom_claims: Option<list<``accessschemas-oidcsaasappCustomclaims``>>
      ///The OIDC flows supported by this application
      grant_types: Option<list<``accessschemas-oidcsaasappGrant_types``>>
      ///A regex to filter Cloudflare groups returned in ID token and userinfo endpoint.
      group_filter_regex: Option<string>
      hybrid_and_implicit_options: Option<``accessschemas-oidcsaasappHybridandimplicitoptions``>
      ///The Access public certificate that will be used to verify your identity.
      public_key: Option<string>
      ///The permitted URL's for Cloudflare to return Authorization codes and Access/ID tokens
      redirect_uris: Option<list<string>>
      refresh_token_options: Option<``accessschemas-oidcsaasappRefreshtokenoptions``>
      ///Define the user information shared with access, "offline_access" scope will be automatically enabled if refresh tokens are enabled
      scopes: Option<list<``accessschemas-oidcsaasappScopes``>>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accessschemas-oidcsaasapp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oidcsaasapp`` =
        { access_token_lifetime = None
          allow_pkce_without_client_secret = None
          app_launcher_url = None
          auth_type = None
          client_id = None
          client_secret = None
          created_at = None
          custom_claims = None
          grant_types = None
          group_filter_regex = None
          hybrid_and_implicit_options = None
          public_key = None
          redirect_uris = None
          refresh_token_options = None
          scopes = None
          updated_at = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oktaScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-oktaScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-oktaScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-oktaScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oktaScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oktaType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-okta`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-oktaScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-oktaType``> }
    ///Creates an instance of accessschemas-okta with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-okta`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oneloginScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-oneloginScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-oneloginScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-oneloginScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-oneloginScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-oneloginType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-onelogin`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-oneloginScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-oneloginType``> }
    ///Creates an instance of accessschemas-onelogin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-onelogin`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-onetimepinScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-onetimepinScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-onetimepinScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-onetimepinScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-onetimepinScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-onetimepinType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-onetimepinConfig`` =
    { redirect_url: Option<string> }
    ///Creates an instance of accessschemas-onetimepinConfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-onetimepinConfig`` = { redirect_url = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``TypeFromaccessschemas-onetimepin`` =
    | [<CompiledName "onetimepin">] Onetimepin
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"

type ``accessschemas-onetimepin`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-onetimepinScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-onetimepinType``> }
    ///Creates an instance of accessschemas-onetimepin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-onetimepin`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type ``accessschemas-organizations`` =
    { ///The unique subdomain assigned to your Zero Trust organization.
      auth_domain: Option<``accessschemas-authdomain``>
      created_at: Option<accesstimestamp>
      ///Determines whether to deny all requests to Cloudflare-protected resources that lack an associated Access application. If enabled, you must explicitly configure an Access application and policy to allow traffic to your Cloudflare-protected resources. For domains you want to be public across all subdomains, add the domain to the `deny_unmatched_requests_exempted_zone_names` array.
      deny_unmatched_requests: Option<accessdenyunmatchedrequests>
      ///Contains zone names to exempt from the `deny_unmatched_requests` feature. Requests to a subdomain in an exempted zone will block unauthenticated traffic by default if there is a configured Access application and policy that matches the request.
      deny_unmatched_requests_exempted_zone_names: Option<accessdenyunmatchedrequestsexemptedzonenames>
      ///Lock all settings as Read-Only in the Dashboard, regardless of user permission. Updates may only be made via the API or Terraform for this account when enabled.
      is_ui_read_only: Option<``accessschemas-isuireadonly``>
      login_design: Option<Newtonsoft.Json.Linq.JToken>
      ///The name of your Zero Trust organization.
      name: Option<``accessorganizationscomponents-schemas-name``>
      ///A description of the reason why the UI read only field is being toggled.
      ui_read_only_toggle_reason: Option<accessuireadonlytogglereason>
      updated_at: Option<accesstimestamp>
      ///The amount of time a user seat is inactive before it expires. When the user seat exceeds the set time of inactivity, the user is removed as an active seat and no longer counts against your Teams seat count. Must be in the format `300ms` or `2h45m`. Valid time units are: `ns`, `us` (or `µs`), `ms`, `s`, `m`, `h`.
      user_seat_expiration_inactive_time: Option<``accessschemas-userseatexpirationinactivetime``> }
    ///Creates an instance of accessschemas-organizations with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-organizations`` =
        { auth_domain = None
          created_at = None
          deny_unmatched_requests = None
          deny_unmatched_requests_exempted_zone_names = None
          is_ui_read_only = None
          login_design = None
          name = None
          ui_read_only_toggle_reason = None
          updated_at = None
          user_seat_expiration_inactive_time = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-pingoneScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-pingoneScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-pingoneScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-pingoneScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-pingoneScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-pingoneType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-pingone`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-pingoneScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-pingoneType``> }
    ///Creates an instance of accessschemas-pingone with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-pingone`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type ``accessschemas-policycheckresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-policycheckresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-policycheckresponseErrorsSource`` = { pointer = None }

type ``accessschemas-policycheckresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-policycheckresponseErrorsSource``> }
    ///Creates an instance of accessschemas-policycheckresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-policycheckresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-policycheckresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-policycheckresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-policycheckresponseMessagesSource`` = { pointer = None }

type ``accessschemas-policycheckresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-policycheckresponseMessagesSource``> }
    ///Creates an instance of accessschemas-policycheckresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-policycheckresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-policycheckresponseResultAppstate`` =
    { ///UUID.
      app_uid: Option<accessuuid>
      aud: Option<string>
      hostname: Option<string>
      name: Option<string>
      policies: Option<list<string>>
      status: Option<string> }
    ///Creates an instance of accessschemas-policycheckresponseResultAppstate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-policycheckresponseResultAppstate`` =
        { app_uid = None
          aud = None
          hostname = None
          name = None
          policies = None
          status = None }

type ``accessschemas-policycheckresponseResultUseridentityGeo`` =
    { country: Option<string> }
    ///Creates an instance of accessschemas-policycheckresponseResultUseridentityGeo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-policycheckresponseResultUseridentityGeo`` = { country = None }

type ``accessschemas-policycheckresponseResultUseridentity`` =
    { account_id: Option<string>
      device_sessions: Option<Newtonsoft.Json.Linq.JObject>
      email: Option<string>
      geo: Option<``accessschemas-policycheckresponseResultUseridentityGeo``>
      iat: Option<int>
      id: Option<string>
      is_gateway: Option<bool>
      is_warp: Option<bool>
      name: Option<string>
      ///UUID.
      user_uuid: Option<accessuuid>
      version: Option<int> }
    ///Creates an instance of accessschemas-policycheckresponseResultUseridentity with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-policycheckresponseResultUseridentity`` =
        { account_id = None
          device_sessions = None
          email = None
          geo = None
          iat = None
          id = None
          is_gateway = None
          is_warp = None
          name = None
          user_uuid = None
          version = None }

type ``accessschemas-policycheckresponseResult`` =
    { app_state: Option<``accessschemas-policycheckresponseResultAppstate``>
      user_identity: Option<``accessschemas-policycheckresponseResultUseridentity``> }
    ///Creates an instance of accessschemas-policycheckresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-policycheckresponseResult`` =
        { app_state = None
          user_identity = None }

type ``accessschemas-policycheckresponse`` =
    { errors: Option<list<``accessschemas-policycheckresponseErrors``>>
      messages: Option<list<``accessschemas-policycheckresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<``accessschemas-policycheckresponseResult``> }
    ///Creates an instance of accessschemas-policycheckresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-policycheckresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``accessschemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accessschemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessschemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accessschemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessschemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessschemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessschemas-responsecollection`` =
    { errors: list<``accessschemas-responsecollectionErrors``>
      messages: list<``accessschemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accessschemas-responsecollectionResultinfo``>
      result: Option<list<``accessschemas-groups``>> }
    ///Creates an instance of accessschemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessschemas-responsecollectionErrors``>,
                          messages: list<``accessschemas-responsecollectionMessages``>,
                          success: bool): ``accessschemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accessschemas-responsecollectionhostnamesErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-responsecollectionhostnamesErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-responsecollectionhostnamesErrorsSource`` = { pointer = None }

type ``accessschemas-responsecollectionhostnamesErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-responsecollectionhostnamesErrorsSource``> }
    ///Creates an instance of accessschemas-responsecollectionhostnamesErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-responsecollectionhostnamesErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-responsecollectionhostnamesMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-responsecollectionhostnamesMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-responsecollectionhostnamesMessagesSource`` = { pointer = None }

type ``accessschemas-responsecollectionhostnamesMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-responsecollectionhostnamesMessagesSource``> }
    ///Creates an instance of accessschemas-responsecollectionhostnamesMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-responsecollectionhostnamesMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-responsecollectionhostnamesResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessschemas-responsecollectionhostnamesResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-responsecollectionhostnamesResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessschemas-responsecollectionhostnames`` =
    { errors: Option<list<``accessschemas-responsecollectionhostnamesErrors``>>
      messages: Option<list<``accessschemas-responsecollectionhostnamesMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``accessschemas-responsecollectionhostnamesResultinfo``>
      result: Option<list<``accessschemas-settings``>> }
    ///Creates an instance of accessschemas-responsecollectionhostnames with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-responsecollectionhostnames`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``accessschemas-saasprops`` =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      saas_app: Option<Newtonsoft.Json.Linq.JObject>
      ///The application type.
      ``type``: Option<string> }
    ///Creates an instance of accessschemas-saasprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-saasprops`` =
        { allowed_idps = None
          app_launcher_visible = None
          auto_redirect_to_identity = None
          logo_url = None
          name = None
          saas_app = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-samlScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-samlScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-samlScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-samlScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-samlScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-samlType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-samlConfigHeaderattributes`` =
    { ///attribute name from the IDP
      attribute_name: Option<string>
      ///header that will be added on the request to the origin
      header_name: Option<string> }
    ///Creates an instance of accessschemas-samlConfigHeaderattributes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-samlConfigHeaderattributes`` =
        { attribute_name = None
          header_name = None }

type ``accessschemas-samlConfig`` =
    { ///A list of SAML attribute names that will be added to your signed JWT token and can be used in SAML policy rules.
      attributes: Option<list<string>>
      ///The attribute name for email in the SAML response.
      email_attribute_name: Option<string>
      ///Add a list of attribute names that will be returned in the response header from the Access callback.
      header_attributes: Option<list<``accessschemas-samlConfigHeaderattributes``>>
      ///X509 certificate to verify the signature in the SAML authentication response
      idp_public_certs: Option<list<string>>
      ///IdP Entity ID or Issuer URL
      issuer_url: Option<string>
      ///Sign the SAML authentication request with Access credentials. To verify the signature, use the public key from the Access certs endpoints.
      sign_request: Option<bool>
      ///URL to send the SAML authentication requests to
      sso_target_url: Option<string> }
    ///Creates an instance of accessschemas-samlConfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-samlConfig`` =
        { attributes = None
          email_attribute_name = None
          header_attributes = None
          idp_public_certs = None
          issuer_url = None
          sign_request = None
          sso_target_url = None }

type ``accessschemas-saml`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-samlScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-samlType``> }
    ///Creates an instance of accessschemas-saml with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-saml`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-samlsaasappAuthtype`` =
    | [<CompiledName "saml">] Saml
    | [<CompiledName "oidc">] Oidc
    member this.Format() =
        match this with
        | Saml -> "saml"
        | Oidc -> "oidc"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-samlsaasappCustomattributesNameformat`` =
    | [<CompiledName "urn:oasis:names:tc:SAML:2.0:attrname-format:unspecified">] ``Urn:oasis:names:tc:SAML:2AttrnameFormat:unspecified``
    | [<CompiledName "urn:oasis:names:tc:SAML:2.0:attrname-format:basic">] ``Urn:oasis:names:tc:SAML:2AttrnameFormat:basic``
    | [<CompiledName "urn:oasis:names:tc:SAML:2.0:attrname-format:uri">] ``Urn:oasis:names:tc:SAML:2AttrnameFormat:uri``
    member this.Format() =
        match this with
        | ``Urn:oasis:names:tc:SAML:2AttrnameFormat:unspecified`` ->
            "urn:oasis:names:tc:SAML:2.0:attrname-format:unspecified"
        | ``Urn:oasis:names:tc:SAML:2AttrnameFormat:basic`` -> "urn:oasis:names:tc:SAML:2.0:attrname-format:basic"
        | ``Urn:oasis:names:tc:SAML:2AttrnameFormat:uri`` -> "urn:oasis:names:tc:SAML:2.0:attrname-format:uri"

type ``accessschemas-samlsaasappCustomattributesSource`` =
    { ///The name of the IdP attribute.
      name: Option<string>
      ///A mapping from IdP ID to attribute name.
      name_by_idp: Option<Map<string, string>> }
    ///Creates an instance of accessschemas-samlsaasappCustomattributesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-samlsaasappCustomattributesSource`` = { name = None; name_by_idp = None }

type ``accessschemas-samlsaasappCustomattributes`` =
    { ///The SAML FriendlyName of the attribute.
      friendly_name: Option<string>
      ///The name of the attribute.
      name: Option<string>
      ///A globally unique name for an identity or service provider.
      name_format: Option<``accessschemas-samlsaasappCustomattributesNameformat``>
      ///If the attribute is required when building a SAML assertion.
      required: Option<bool>
      source: Option<``accessschemas-samlsaasappCustomattributesSource``> }
    ///Creates an instance of accessschemas-samlsaasappCustomattributes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-samlsaasappCustomattributes`` =
        { friendly_name = None
          name = None
          name_format = None
          required = None
          source = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-samlsaasappNameidformat`` =
    | [<CompiledName "id">] Id
    | [<CompiledName "email">] Email
    member this.Format() =
        match this with
        | Id -> "id"
        | Email -> "email"

type ``accessschemas-samlsaasapp`` =
    { ///Optional identifier indicating the authentication protocol used for the saas app. Required for OIDC. Default if unset is "saml"
      auth_type: Option<``accessschemas-samlsaasappAuthtype``>
      ///The service provider's endpoint that is responsible for receiving and parsing a SAML assertion.
      consumer_service_url: Option<string>
      created_at: Option<accesstimestamp>
      custom_attributes: Option<list<``accessschemas-samlsaasappCustomattributes``>>
      ///The unique identifier for your SaaS application.
      idp_entity_id: Option<string>
      ///The format of the name identifier sent to the SaaS application.
      name_id_format: Option<``accessschemas-samlsaasappNameidformat``>
      ///A [JSONata](https://jsonata.org/) expression that transforms an application's user identities into a NameID value for its SAML assertion. This expression should evaluate to a singular string. The output of this expression can override the `name_id_format` setting.
      name_id_transform_jsonata: Option<string>
      ///The Access public certificate that will be used to verify your identity.
      public_key: Option<string>
      ///A globally unique name for an identity or service provider.
      sp_entity_id: Option<string>
      ///The endpoint where your SaaS application will send login requests.
      sso_endpoint: Option<string>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accessschemas-samlsaasapp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-samlsaasapp`` =
        { auth_type = None
          consumer_service_url = None
          created_at = None
          custom_attributes = None
          idp_entity_id = None
          name_id_format = None
          name_id_transform_jsonata = None
          public_key = None
          sp_entity_id = None
          sso_endpoint = None
          updated_at = None }

///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
type ``accessschemas-scimconfig`` =
    { authentication: Option<Newtonsoft.Json.Linq.JToken>
      ///If false, we propagate DELETE requests to the target application for SCIM resources. If true, we only set `active` to false on the SCIM resource. This is useful because some targets do not support DELETE operations.
      deactivate_on_delete: Option<bool>
      ///Whether SCIM provisioning is turned on for this application.
      enabled: Option<bool>
      ///The UID of the IdP to use as the source for SCIM resources to provision to this application.
      idp_uid: string
      ///A list of mappings to apply to SCIM resources before provisioning them in this application. These can transform or filter the resources to be provisioned.
      mappings: Option<list<accessscimconfigmapping>>
      ///The base URI for the application's SCIM-compatible API.
      remote_uri: string }
    ///Creates an instance of accessschemas-scimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (idp_uid: string, remote_uri: string): ``accessschemas-scimconfig`` =
        { authentication = None
          deactivate_on_delete = None
          enabled = None
          idp_uid = idp_uid
          mappings = None
          remote_uri = remote_uri }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Scheme =
    | [<CompiledName "oauthbearertoken">] Oauthbearertoken
    member this.Format() =
        match this with
        | Oauthbearertoken -> "oauthbearertoken"

///Attributes for configuring OAuth Bearer Token authentication scheme for SCIM provisioning to an application.
type ``accessschemas-scimconfigauthenticationoauthbearertoken`` =
    { ///The authentication scheme to use when making SCIM requests to this application.
      scheme: Scheme
      ///Token used to authenticate with the remote SCIM service.
      token: string }
    ///Creates an instance of accessschemas-scimconfigauthenticationoauthbearertoken with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (scheme: Scheme, token: string): ``accessschemas-scimconfigauthenticationoauthbearertoken`` =
        { scheme = scheme; token = token }

type ``accessschemas-selfhostedprops`` =
    { ///Enables loading application content in an iFrame.
      allow_iframe: Option<accessallowiframe>
      ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      cors_headers: Option<``accessschemas-corsheaders``>
      ///The custom error message shown to a user when they are denied access to the application.
      custom_deny_message: Option<accesscustomdenymessage>
      ///The custom URL a user is redirected to when they are denied access to the application.
      custom_deny_url: Option<``accessschemas-customdenyurl``>
      ///The domain and path that Access will secure.
      domain: ``accesscomponents-schemas-domain``
      ///Enables the binding cookie, which increases security against compromised authorization tokens and CSRF attacks.
      enable_binding_cookie: Option<accessenablebindingcookie>
      ///Enables the HttpOnly cookie attribute, which increases security against XSS attacks.
      http_only_cookie_attribute: Option<accesshttponlycookieattribute>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///Allows options preflight requests to bypass Access authentication and go directly to the origin. Cannot turn on if cors_headers is set.
      options_preflight_bypass: Option<``accessschemas-optionspreflightbypass``>
      ///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
      same_site_cookie_attribute: Option<accesssamesitecookieattribute>
      ///Returns a 401 status code when the request is blocked by a Service Auth policy.
      service_auth_401_redirect: Option<accessserviceauth401redirect>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accessappscomponents-schemas-sessionduration``>
      ///Enables automatic authentication through cloudflared.
      skip_interstitial: Option<accessskipinterstitial>
      ///The application type.
      ``type``: string
      ///Determines if users can access this application via a clientless browser isolation URL.
      ///This allows users to access private domains without connecting to Gateway. The option requires
      ///Clientless Browser Isolation to be set up with policies that allow users of this application.
      use_clientless_isolation_app_launcher_url: Option<accessuseclientlessisolationapplauncherurl> }
    ///Creates an instance of accessschemas-selfhostedprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: ``accesscomponents-schemas-domain``, ``type``: string): ``accessschemas-selfhostedprops`` =
        { allow_iframe = None
          allowed_idps = None
          app_launcher_visible = None
          auto_redirect_to_identity = None
          cors_headers = None
          custom_deny_message = None
          custom_deny_url = None
          domain = domain
          enable_binding_cookie = None
          http_only_cookie_attribute = None
          logo_url = None
          name = None
          options_preflight_bypass = None
          same_site_cookie_attribute = None
          service_auth_401_redirect = None
          session_duration = None
          skip_interstitial = None
          ``type`` = ``type``
          use_clientless_isolation_app_launcher_url = None }

type ``accessschemas-service-tokens`` =
    { ///The Client ID for the service token. Access will check for this value in the `CF-Access-Client-ID` request header.
      client_id: Option<accessclientid>
      created_at: Option<accesstimestamp>
      ///The duration for how long the service token will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. The default is 1 year in hours (8760h).
      duration: Option<``accessschemas-duration``>
      expires_at: Option<accesstimestamp>
      id: Option<Newtonsoft.Json.Linq.JToken>
      last_seen_at: Option<accesstimestamp>
      ///The name of the service token.
      name: Option<``accessservice-tokenscomponents-schemas-name``>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accessschemas-service-tokens with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-service-tokens`` =
        { client_id = None
          created_at = None
          duration = None
          expires_at = None
          id = None
          last_seen_at = None
          name = None
          updated_at = None }

type ``accessschemas-settings`` =
    { ///Request client certificates for this hostname in China. Can only be set to true if this zone is china network enabled.
      china_network: bool
      ///Client Certificate Forwarding is a feature that takes the client cert provided by the eyeball to the edge, and forwards it to the origin as a HTTP header to allow logging on the origin.
      client_certificate_forwarding: bool
      ///The hostname that these settings apply to.
      hostname: string }
    ///Creates an instance of accessschemas-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (china_network: bool, client_certificate_forwarding: bool, hostname: string): ``accessschemas-settings`` =
        { china_network = china_network
          client_certificate_forwarding = client_certificate_forwarding
          hostname = hostname }

type ``accessschemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-singleresponseErrorsSource`` = { pointer = None }

type ``accessschemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessschemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessschemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-singleresponseMessagesSource`` = { pointer = None }

type ``accessschemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessschemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessschemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessschemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessschemas-singleresponse`` =
    { errors: list<``accessschemas-singleresponseErrors``>
      messages: list<``accessschemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``accessservice-tokens``> }
    ///Creates an instance of accessschemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessschemas-singleresponseErrors``>,
                          messages: list<``accessschemas-singleresponseMessages``>,
                          success: bool): ``accessschemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``accessschemas-sshprops`` =
    { ///Enables loading application content in an iFrame.
      allow_iframe: Option<accessallowiframe>
      ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      cors_headers: Option<``accessschemas-corsheaders``>
      ///The custom error message shown to a user when they are denied access to the application.
      custom_deny_message: Option<accesscustomdenymessage>
      ///The custom URL a user is redirected to when they are denied access to the application.
      custom_deny_url: Option<``accessschemas-customdenyurl``>
      ///The domain and path that Access will secure.
      domain: Option<``accesscomponents-schemas-domain``>
      ///Enables the binding cookie, which increases security against compromised authorization tokens and CSRF attacks.
      enable_binding_cookie: Option<accessenablebindingcookie>
      ///Enables the HttpOnly cookie attribute, which increases security against XSS attacks.
      http_only_cookie_attribute: Option<accesshttponlycookieattribute>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///Allows options preflight requests to bypass Access authentication and go directly to the origin. Cannot turn on if cors_headers is set.
      options_preflight_bypass: Option<``accessschemas-optionspreflightbypass``>
      ///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
      same_site_cookie_attribute: Option<accesssamesitecookieattribute>
      ///Returns a 401 status code when the request is blocked by a Service Auth policy.
      service_auth_401_redirect: Option<accessserviceauth401redirect>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accessappscomponents-schemas-sessionduration``>
      ///Enables automatic authentication through cloudflared.
      skip_interstitial: Option<accessskipinterstitial>
      ///The application type.
      ``type``: Option<string>
      ///Determines if users can access this application via a clientless browser isolation URL.
      ///This allows users to access private domains without connecting to Gateway. The option requires
      ///Clientless Browser Isolation to be set up with policies that allow users of this application.
      use_clientless_isolation_app_launcher_url: Option<accessuseclientlessisolationapplauncherurl> }
    ///Creates an instance of accessschemas-sshprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-sshprops`` =
        { allow_iframe = None
          allowed_idps = None
          app_launcher_visible = None
          auto_redirect_to_identity = None
          cors_headers = None
          custom_deny_message = None
          custom_deny_url = None
          domain = None
          enable_binding_cookie = None
          http_only_cookie_attribute = None
          logo_url = None
          name = None
          options_preflight_bypass = None
          same_site_cookie_attribute = None
          service_auth_401_redirect = None
          session_duration = None
          skip_interstitial = None
          ``type`` = None
          use_clientless_isolation_app_launcher_url = None }

type ``accessschemas-users`` =
    { ///True if the user has authenticated with Cloudflare Access.
      access_seat: Option<``accessschemas-accessseat``>
      ///The number of active devices registered to the user.
      active_device_count: Option<accessactivedevicecount>
      created_at: Option<accesstimestamp>
      ///The email of the user.
      email: Option<``accessschemas-email``>
      ///True if the user has logged into the WARP client.
      gateway_seat: Option<``accessschemas-gatewayseat``>
      ///UUID.
      id: Option<accessuuid>
      ///The time at which the user last successfully logged in.
      last_successful_login: Option<accesslastsuccessfullogin>
      ///The name of the user.
      name: Option<``accessuserscomponents-schemas-name``>
      ///The unique API identifier for the Zero Trust seat.
      seat_uid: Option<``accessschemas-seatuid``>
      ///The unique API identifier for the user.
      uid: Option<accessuid>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accessschemas-users with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-users`` =
        { access_seat = None
          active_device_count = None
          created_at = None
          email = None
          gateway_seat = None
          id = None
          last_successful_login = None
          name = None
          seat_uid = None
          uid = None
          updated_at = None }

type ``accessschemas-vncprops`` =
    { ///Enables loading application content in an iFrame.
      allow_iframe: Option<accessallowiframe>
      ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      cors_headers: Option<``accessschemas-corsheaders``>
      ///The custom error message shown to a user when they are denied access to the application.
      custom_deny_message: Option<accesscustomdenymessage>
      ///The custom URL a user is redirected to when they are denied access to the application.
      custom_deny_url: Option<``accessschemas-customdenyurl``>
      ///The domain and path that Access will secure.
      domain: Option<``accesscomponents-schemas-domain``>
      ///Enables the binding cookie, which increases security against compromised authorization tokens and CSRF attacks.
      enable_binding_cookie: Option<accessenablebindingcookie>
      ///Enables the HttpOnly cookie attribute, which increases security against XSS attacks.
      http_only_cookie_attribute: Option<accesshttponlycookieattribute>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///Allows options preflight requests to bypass Access authentication and go directly to the origin. Cannot turn on if cors_headers is set.
      options_preflight_bypass: Option<``accessschemas-optionspreflightbypass``>
      ///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
      same_site_cookie_attribute: Option<accesssamesitecookieattribute>
      ///Returns a 401 status code when the request is blocked by a Service Auth policy.
      service_auth_401_redirect: Option<accessserviceauth401redirect>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accessappscomponents-schemas-sessionduration``>
      ///Enables automatic authentication through cloudflared.
      skip_interstitial: Option<accessskipinterstitial>
      ///The application type.
      ``type``: Option<string>
      ///Determines if users can access this application via a clientless browser isolation URL.
      ///This allows users to access private domains without connecting to Gateway. The option requires
      ///Clientless Browser Isolation to be set up with policies that allow users of this application.
      use_clientless_isolation_app_launcher_url: Option<accessuseclientlessisolationapplauncherurl> }
    ///Creates an instance of accessschemas-vncprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-vncprops`` =
        { allow_iframe = None
          allowed_idps = None
          app_launcher_visible = None
          auto_redirect_to_identity = None
          cors_headers = None
          custom_deny_message = None
          custom_deny_url = None
          domain = None
          enable_binding_cookie = None
          http_only_cookie_attribute = None
          logo_url = None
          name = None
          options_preflight_bypass = None
          same_site_cookie_attribute = None
          service_auth_401_redirect = None
          session_duration = None
          skip_interstitial = None
          ``type`` = None
          use_clientless_isolation_app_launcher_url = None }

type ``accessschemas-warpprops`` =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The domain and path that Access will secure.
      domain: Option<``accesscomponents-schemas-domain``>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.
      session_duration: Option<``accessappscomponents-schemas-sessionduration``>
      ///The application type.
      ``type``: Option<``accesscomponents-schemas-type``> }
    ///Creates an instance of accessschemas-warpprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-warpprops`` =
        { allowed_idps = None
          auto_redirect_to_identity = None
          domain = None
          name = None
          session_duration = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-yandexScimconfigIdentityupdatebehavior`` =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type ``accessschemas-yandexScimconfig`` =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<``accessschemas-yandexScimconfigIdentityupdatebehavior``>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests. If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessschemas-yandexScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-yandexScimconfig`` =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``accessschemas-yandexType`` =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type ``accessschemas-yandex`` =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<``accessschemas-yandexScimconfig``>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<``accessschemas-yandexType``> }
    ///Creates an instance of accessschemas-yandex with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessschemas-yandex`` =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
type accessscimconfig =
    { authentication: Option<Newtonsoft.Json.Linq.JToken>
      ///If false, propagates DELETE requests to the target application for SCIM resources. If true, sets 'active' to false on the SCIM resource. Note: Some targets do not support DELETE operations.
      deactivate_on_delete: Option<bool>
      ///Whether SCIM provisioning is turned on for this application.
      enabled: Option<bool>
      ///The UID of the IdP to use as the source for SCIM resources to provision to this application.
      idp_uid: string
      ///A list of mappings to apply to SCIM resources before provisioning them in this application. These can transform or filter the resources to be provisioned.
      mappings: Option<list<accessscimconfigmapping>>
      ///The base URI for the application's SCIM-compatible API.
      remote_uri: string }
    ///Creates an instance of accessscimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (idp_uid: string, remote_uri: string): accessscimconfig =
        { authentication = None
          deactivate_on_delete = None
          enabled = None
          idp_uid = idp_uid
          mappings = None
          remote_uri = remote_uri }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessscimconfigauthenticationaccessservicetokenScheme =
    | [<CompiledName "access_service_token">] Access_service_token
    member this.Format() =
        match this with
        | Access_service_token -> "access_service_token"

///Attributes for configuring Access Service Token authentication scheme for SCIM provisioning to an application.
type accessscimconfigauthenticationaccessservicetoken =
    { ///Client ID of the Access service token used to authenticate with the remote service.
      client_id: string
      ///Client secret of the Access service token used to authenticate with the remote service.
      client_secret: string
      ///The authentication scheme to use when making SCIM requests to this application.
      scheme: accessscimconfigauthenticationaccessservicetokenScheme }
    ///Creates an instance of accessscimconfigauthenticationaccessservicetoken with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (client_id: string,
                          client_secret: string,
                          scheme: accessscimconfigauthenticationaccessservicetokenScheme): accessscimconfigauthenticationaccessservicetoken =
        { client_id = client_id
          client_secret = client_secret
          scheme = scheme }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessscimconfigauthenticationhttpbasicScheme =
    | [<CompiledName "httpbasic">] Httpbasic
    member this.Format() =
        match this with
        | Httpbasic -> "httpbasic"

///Attributes for configuring HTTP Basic authentication scheme for SCIM provisioning to an application.
type accessscimconfigauthenticationhttpbasic =
    { ///Password used to authenticate with the remote SCIM service.
      password: string
      ///The authentication scheme to use when making SCIM requests to this application.
      scheme: accessscimconfigauthenticationhttpbasicScheme
      ///User name used to authenticate with the remote SCIM service.
      user: string }
    ///Creates an instance of accessscimconfigauthenticationhttpbasic with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (password: string, scheme: accessscimconfigauthenticationhttpbasicScheme, user: string): accessscimconfigauthenticationhttpbasic =
        { password = password
          scheme = scheme
          user = user }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessscimconfigauthenticationoauth2Scheme =
    | [<CompiledName "oauth2">] Oauth2
    member this.Format() =
        match this with
        | Oauth2 -> "oauth2"

///Attributes for configuring OAuth 2 authentication scheme for SCIM provisioning to an application.
type accessscimconfigauthenticationoauth2 =
    { ///URL used to generate the auth code used during token generation.
      authorization_url: string
      ///Client ID used to authenticate when generating a token for authenticating with the remote SCIM service.
      client_id: string
      ///Secret used to authenticate when generating a token for authenticating with the remove SCIM service.
      client_secret: string
      ///The authentication scheme to use when making SCIM requests to this application.
      scheme: accessscimconfigauthenticationoauth2Scheme
      ///The authorization scopes to request when generating the token used to authenticate with the remove SCIM service.
      scopes: Option<list<string>>
      ///URL used to generate the token used to authenticate with the remote SCIM service.
      token_url: string }
    ///Creates an instance of accessscimconfigauthenticationoauth2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (authorization_url: string,
                          client_id: string,
                          client_secret: string,
                          scheme: accessscimconfigauthenticationoauth2Scheme,
                          token_url: string): accessscimconfigauthenticationoauth2 =
        { authorization_url = authorization_url
          client_id = client_id
          client_secret = client_secret
          scheme = scheme
          scopes = None
          token_url = token_url }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessscimconfigauthenticationoauthbearertokenScheme =
    | [<CompiledName "oauthbearertoken">] Oauthbearertoken
    member this.Format() =
        match this with
        | Oauthbearertoken -> "oauthbearertoken"

///Attributes for configuring OAuth Bearer Token authentication scheme for SCIM provisioning to an application.
type accessscimconfigauthenticationoauthbearertoken =
    { ///The authentication scheme to use when making SCIM requests to this application.
      scheme: accessscimconfigauthenticationoauthbearertokenScheme
      ///Token used to authenticate with the remote SCIM service.
      token: string }
    ///Creates an instance of accessscimconfigauthenticationoauthbearertoken with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (scheme: accessscimconfigauthenticationoauthbearertokenScheme, token: string): accessscimconfigauthenticationoauthbearertoken =
        { scheme = scheme; token = token }

///Whether or not this mapping applies to creates, updates, or deletes.
type Operations =
    { ///Whether or not this mapping applies to create (POST) operations.
      create: Option<bool>
      ///Whether or not this mapping applies to DELETE operations.
      delete: Option<bool>
      ///Whether or not this mapping applies to update (PATCH/PUT) operations.
      update: Option<bool> }
    ///Creates an instance of Operations with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Operations =
        { create = None
          delete = None
          update = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Strictness =
    | [<CompiledName "strict">] Strict
    | [<CompiledName "passthrough">] Passthrough
    member this.Format() =
        match this with
        | Strict -> "strict"
        | Passthrough -> "passthrough"

///Transformations and filters applied to resources before they are provisioned in the remote SCIM service.
type accessscimconfigmapping =
    { ///Whether or not this mapping is enabled.
      enabled: Option<bool>
      ///A [SCIM filter expression](https://datatracker.ietf.org/doc/html/rfc7644#section-3.4.2.2) that matches resources that should be provisioned to this application.
      filter: Option<string>
      ///Whether or not this mapping applies to creates, updates, or deletes.
      operations: Option<Operations>
      ///Which SCIM resource type this mapping applies to.
      schema: string
      ///The level of adherence to outbound resource schemas when provisioning to this mapping. ‘Strict’ removes unknown values, while ‘passthrough’ passes unknown values to the target.
      strictness: Option<Strictness>
      ///A [JSONata](https://jsonata.org/) expression that transforms the resource before provisioning it in the application.
      transform_jsonata: Option<string> }
    ///Creates an instance of accessscimconfigmapping with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (schema: string): accessscimconfigmapping =
        { enabled = None
          filter = None
          operations = None
          schema = schema
          strictness = None
          transform_jsonata = None }

type accessscimgroupsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessscimgroupsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessscimgroupsresponseErrorsSource = { pointer = None }

type accessscimgroupsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessscimgroupsresponseErrorsSource> }
    ///Creates an instance of accessscimgroupsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessscimgroupsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessscimgroupsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessscimgroupsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessscimgroupsresponseMessagesSource = { pointer = None }

type accessscimgroupsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessscimgroupsresponseMessagesSource> }
    ///Creates an instance of accessscimgroupsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessscimgroupsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessscimgroupsresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessscimgroupsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessscimgroupsresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type accessscimgroupsresponse =
    { errors: list<accessscimgroupsresponseErrors>
      messages: list<accessscimgroupsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<accessscimgroupsresponseResultinfo>
      result: Option<list<accessgroups>> }
    ///Creates an instance of accessscimgroupsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessscimgroupsresponseErrors>,
                          messages: list<accessscimgroupsresponseMessages>,
                          success: bool): accessscimgroupsresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type accessscimupdatelogsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessscimupdatelogsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessscimupdatelogsresponseErrorsSource = { pointer = None }

type accessscimupdatelogsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessscimupdatelogsresponseErrorsSource> }
    ///Creates an instance of accessscimupdatelogsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessscimupdatelogsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessscimupdatelogsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessscimupdatelogsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessscimupdatelogsresponseMessagesSource = { pointer = None }

type accessscimupdatelogsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessscimupdatelogsresponseMessagesSource> }
    ///Creates an instance of accessscimupdatelogsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessscimupdatelogsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessscimupdatelogsresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessscimupdatelogsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessscimupdatelogsresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type accessscimupdatelogsresponse =
    { errors: list<accessscimupdatelogsresponseErrors>
      messages: list<accessscimupdatelogsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<accessscimupdatelogsresponseResultinfo>
      result: Option<list<accessresponses>> }
    ///Creates an instance of accessscimupdatelogsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessscimupdatelogsresponseErrors>,
                          messages: list<accessscimupdatelogsresponseMessages>,
                          success: bool): accessscimupdatelogsresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type accessscimusersresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accessscimusersresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessscimusersresponseErrorsSource = { pointer = None }

type accessscimusersresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessscimusersresponseErrorsSource> }
    ///Creates an instance of accessscimusersresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessscimusersresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessscimusersresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accessscimusersresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessscimusersresponseMessagesSource = { pointer = None }

type accessscimusersresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accessscimusersresponseMessagesSource> }
    ///Creates an instance of accessscimusersresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accessscimusersresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accessscimusersresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessscimusersresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessscimusersresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type accessscimusersresponse =
    { errors: list<accessscimusersresponseErrors>
      messages: list<accessscimusersresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<accessscimusersresponseResultinfo>
      result: Option<list<accessusers>> }
    ///Creates an instance of accessscimusersresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accessscimusersresponseErrors>,
                          messages: list<accessscimusersresponseMessages>,
                          success: bool): accessscimusersresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type accessseat =
    { ///True if the seat is part of Access.
      access_seat: accessaccessseat
      ///True if the seat is part of Gateway.
      gateway_seat: accessgatewayseat
      ///The unique API identifier for the Zero Trust seat.
      seat_uid: accessseatuid }
    ///Creates an instance of accessseat with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (access_seat: accessaccessseat, gateway_seat: accessgatewayseat, seat_uid: accessseatuid): accessseat =
        { access_seat = access_seat
          gateway_seat = gateway_seat
          seat_uid = seat_uid }

type accessseats =
    { ///True if the seat is part of Access.
      access_seat: Option<accessaccessseat>
      created_at: Option<accesstimestamp>
      ///True if the seat is part of Gateway.
      gateway_seat: Option<accessgatewayseat>
      ///The unique API identifier for the Zero Trust seat.
      seat_uid: Option<accessseatuid>
      updated_at: Option<accesstimestamp> }
    ///Creates an instance of accessseats with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessseats =
        { access_seat = None
          created_at = None
          gateway_seat = None
          seat_uid = None
          updated_at = None }

type ``accessseatscomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessseatscomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessseatscomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accessseatscomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessseatscomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessseatscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessseatscomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessseatscomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessseatscomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessseatscomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accessseatscomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessseatscomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessseatscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessseatscomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessseatscomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessseatscomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessseatscomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessseatscomponents-schemas-responsecollection`` =
    { errors: list<``accessseatscomponents-schemas-responsecollectionErrors``>
      messages: list<``accessseatscomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accessseatscomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accessseats>> }
    ///Creates an instance of accessseatscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessseatscomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accessseatscomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accessseatscomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type accessselfhostedprops =
    { ///When set to true, users can authenticate to this application using their WARP session.  When set to false this application will always require direct IdP authentication. This setting always overrides the organization setting for WARP authentication.
      allow_authenticate_via_warp: Option<``accessschemas-allowauthenticateviawarp``>
      ///Enables loading application content in an iFrame.
      allow_iframe: Option<accessallowiframe>
      ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      cors_headers: Option<accesscorsheaders>
      ///The custom error message shown to a user when they are denied access to the application.
      custom_deny_message: Option<accesscustomdenymessage>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///List of destinations secured by Access. This supersedes `self_hosted_domains` to allow for more flexibility in defining different types of domains. If `destinations` are provided, then `self_hosted_domains` will be ignored.
      destinations: Option<accessdestinations>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: accessdomain
      ///Enables the binding cookie, which increases security against compromised authorization tokens and CSRF attacks.
      enable_binding_cookie: Option<accessenablebindingcookie>
      ///Enables the HttpOnly cookie attribute, which increases security against XSS attacks.
      http_only_cookie_attribute: Option<accesshttponlycookieattribute>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///Configures multi-factor authentication (MFA) settings.
      mfa_config: Option<accessmfaconfig>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///**Beta:** Optional configuration for managing an OAuth authorization flow controlled by Access. When set, Access will act as the OAuth authorization server for this application. Only compatible with OAuth clients that support [RFC 8707](https://datatracker.ietf.org/doc/html/rfc8707) (Resource Indicators for OAuth 2.0). This feature is currently in beta.
      oauth_configuration: Option<accessoauthconfiguration>
      ///Allows options preflight requests to bypass Access authentication and go directly to the origin. Cannot turn on if cors_headers is set.
      options_preflight_bypass: Option<accessoptionspreflightbypass>
      ///Enables cookie paths to scope an application's JWT to the application path. If disabled, the JWT will scope to the hostname by default
      path_cookie_attribute: Option<accesspathcookieattribute>
      ///Allows matching Access Service Tokens passed HTTP in a single header with this name.
      ///This works as an alternative to the (CF-Access-Client-Id, CF-Access-Client-Secret) pair of headers.
      ///The header value will be interpreted as a json object similar to:
      ///  {
      ///    "cf-access-client-id": "88bf3b6d86161464f6509f7219099e57.access.example.com",
      ///    "cf-access-client-secret": "bdd31cbc4dec990953e39163fbbb194c93313ca9f0a6e420346af9d326b1d2a5"
      ///  }
      read_service_tokens_from_header: Option<accessreadservicetokensfromheader>
      ///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
      same_site_cookie_attribute: Option<accesssamesitecookieattribute>
      ///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
      scim_config: Option<accessscimconfig>
      ///Returns a 401 status code when the request is blocked by a Service Auth policy.
      service_auth_401_redirect: Option<accessserviceauth401redirect>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///Enables automatic authentication through cloudflared.
      skip_interstitial: Option<accessskipinterstitial>
      ///The tags you want assigned to an application. Tags are used to filter applications in the App Launcher dashboard.
      tags: Option<accesstags>
      ///The application type.
      ``type``: accesstype
      ///Determines if users can access this application via a clientless browser isolation URL.
      ///This allows users to access private domains without connecting to Gateway. The option requires
      ///Clientless Browser Isolation to be set up with policies that allow users of this application.
      use_clientless_isolation_app_launcher_url: Option<accessuseclientlessisolationapplauncherurl> }
    ///Creates an instance of accessselfhostedprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: accessdomain, ``type``: accesstype): accessselfhostedprops =
        { allow_authenticate_via_warp = None
          allow_iframe = None
          allowed_idps = None
          app_launcher_visible = None
          auto_redirect_to_identity = None
          cors_headers = None
          custom_deny_message = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          destinations = None
          domain = domain
          enable_binding_cookie = None
          http_only_cookie_attribute = None
          logo_url = None
          mfa_config = None
          name = None
          oauth_configuration = None
          options_preflight_bypass = None
          path_cookie_attribute = None
          read_service_tokens_from_header = None
          same_site_cookie_attribute = None
          scim_config = None
          service_auth_401_redirect = None
          session_duration = None
          skip_interstitial = None
          tags = None
          ``type`` = ``type``
          use_clientless_isolation_app_launcher_url = None }

type ``accessservice-tokens`` =
    { ///The Client ID for the service token. Access will check for this value in the `CF-Access-Client-ID` request header.
      client_id: Option<accessclientid>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      ///The duration for how long the service token will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. The default is 1 year in hours (8760h).
      duration: Option<accessduration>
      expires_at: Option<accesstimestamp>
      id: Option<Newtonsoft.Json.Linq.JToken>
      last_seen_at: Option<Newtonsoft.Json.Linq.JToken>
      ///The name of the service token.
      name: Option<``accessschemas-name``>
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accessservice-tokens with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessservice-tokens`` =
        { client_id = None
          created_at = None
          duration = None
          expires_at = None
          id = None
          last_seen_at = None
          name = None
          updated_at = None }

type ``accessservice-tokenscomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessservice-tokenscomponents-schemas-responsecollectionErrorsSource`` =
        { pointer = None }

type ``accessservice-tokenscomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessservice-tokenscomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessservice-tokenscomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessservice-tokenscomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessservice-tokenscomponents-schemas-responsecollectionMessagesSource`` =
        { pointer = None }

type ``accessservice-tokenscomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessservice-tokenscomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessservice-tokenscomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessservice-tokenscomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessservice-tokenscomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessservice-tokenscomponents-schemas-responsecollection`` =
    { errors: Option<list<``accessservice-tokenscomponents-schemas-responsecollectionErrors``>>
      messages: Option<list<``accessservice-tokenscomponents-schemas-responsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``accessservice-tokenscomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<``accessschemas-service-tokens``>> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessservice-tokenscomponents-schemas-responsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``accessservice-tokenscomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessservice-tokenscomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accessservice-tokenscomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessservice-tokenscomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessservice-tokenscomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessservice-tokenscomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessservice-tokenscomponents-schemas-singleresponseMessagesSource`` =
        { pointer = None }

type ``accessservice-tokenscomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessservice-tokenscomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessservice-tokenscomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessservice-tokenscomponents-schemas-singleresponse`` =
    { errors: Option<list<``accessservice-tokenscomponents-schemas-singleresponseErrors``>>
      messages: Option<list<``accessservice-tokenscomponents-schemas-singleresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<``accessschemas-service-tokens``> }
    ///Creates an instance of accessservice-tokenscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessservice-tokenscomponents-schemas-singleresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type Servicetoken =
    { ///The ID of a Service Token.
      token_id: string }
    ///Creates an instance of Servicetoken with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (token_id: string): Servicetoken = { token_id = token_id }

///Matches a specific Access Service Token
type accessservicetokenrule =
    { service_token: Servicetoken }
    ///Creates an instance of accessservicetokenrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (service_token: Servicetoken): accessservicetokenrule = { service_token = service_token }

type accesssettings =
    { ///Request client certificates for this hostname in China. Can only be set to true if this zone is china network enabled.
      china_network: bool
      ///Client Certificate Forwarding is a feature that takes the client cert provided by the eyeball to the edge, and forwards it to the origin as a HTTP header to allow logging on the origin.
      client_certificate_forwarding: bool
      ///The hostname that these settings apply to.
      hostname: string }
    ///Creates an instance of accesssettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (china_network: bool, client_certificate_forwarding: bool, hostname: string): accesssettings =
        { china_network = china_network
          client_certificate_forwarding = client_certificate_forwarding
          hostname = hostname }

type accesssingleresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesssingleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssingleresponseErrorsSource = { pointer = None }

type accesssingleresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesssingleresponseErrorsSource> }
    ///Creates an instance of accesssingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesssingleresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesssingleresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesssingleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssingleresponseMessagesSource = { pointer = None }

type accesssingleresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesssingleresponseMessagesSource> }
    ///Creates an instance of accesssingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesssingleresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesssingleresponse =
    { errors: list<accesssingleresponseErrors>
      messages: list<accesssingleresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<accessorganizations> }
    ///Creates an instance of accesssingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accesssingleresponseErrors>,
                          messages: list<accesssingleresponseMessages>,
                          success: bool): accesssingleresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accesssingleresponseupdateErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesssingleresponseupdateErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssingleresponseupdateErrorsSource = { pointer = None }

type accesssingleresponseupdateErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesssingleresponseupdateErrorsSource> }
    ///Creates an instance of accesssingleresponseupdateErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesssingleresponseupdateErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesssingleresponseupdateMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesssingleresponseupdateMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssingleresponseupdateMessagesSource = { pointer = None }

type accesssingleresponseupdateMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesssingleresponseupdateMessagesSource> }
    ///Creates an instance of accesssingleresponseupdateMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesssingleresponseupdateMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesssingleresponseupdate =
    { errors: Option<list<accesssingleresponseupdateErrors>>
      messages: Option<list<accesssingleresponseupdateMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<accessappsettingsresponse> }
    ///Creates an instance of accesssingleresponseupdate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssingleresponseupdate =
        { errors = None
          messages = None
          success = None
          result = None }

type accesssingleresponsewithouthtmlErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesssingleresponsewithouthtmlErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssingleresponsewithouthtmlErrorsSource = { pointer = None }

type accesssingleresponsewithouthtmlErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesssingleresponsewithouthtmlErrorsSource> }
    ///Creates an instance of accesssingleresponsewithouthtmlErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesssingleresponsewithouthtmlErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesssingleresponsewithouthtmlMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesssingleresponsewithouthtmlMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssingleresponsewithouthtmlMessagesSource = { pointer = None }

type accesssingleresponsewithouthtmlMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesssingleresponsewithouthtmlMessagesSource> }
    ///Creates an instance of accesssingleresponsewithouthtmlMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesssingleresponsewithouthtmlMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesssingleresponsewithouthtml =
    { errors: list<accesssingleresponsewithouthtmlErrors>
      messages: list<accesssingleresponsewithouthtmlMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<accesscustompagewithouthtml> }
    ///Creates an instance of accesssingleresponsewithouthtml with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accesssingleresponsewithouthtmlErrors>,
                          messages: list<accesssingleresponsewithouthtmlMessages>,
                          success: bool): accesssingleresponsewithouthtml =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accesssingleuserresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of accesssingleuserresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssingleuserresponseErrorsSource = { pointer = None }

type accesssingleuserresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesssingleuserresponseErrorsSource> }
    ///Creates an instance of accesssingleuserresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesssingleuserresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesssingleuserresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of accesssingleuserresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssingleuserresponseMessagesSource = { pointer = None }

type accesssingleuserresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<accesssingleuserresponseMessagesSource> }
    ///Creates an instance of accesssingleuserresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): accesssingleuserresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type accesssingleuserresponse =
    { errors: list<accesssingleuserresponseErrors>
      messages: list<accesssingleuserresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``accessschemas-users``> }
    ///Creates an instance of accesssingleuserresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<accesssingleuserresponseErrors>,
                          messages: list<accesssingleuserresponseMessages>,
                          success: bool): accesssingleuserresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accesssshprops =
    { ///When set to true, users can authenticate to this application using their WARP session.  When set to false this application will always require direct IdP authentication. This setting always overrides the organization setting for WARP authentication.
      allow_authenticate_via_warp: Option<``accessschemas-allowauthenticateviawarp``>
      ///Enables loading application content in an iFrame.
      allow_iframe: Option<accessallowiframe>
      ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      cors_headers: Option<accesscorsheaders>
      ///The custom error message shown to a user when they are denied access to the application.
      custom_deny_message: Option<accesscustomdenymessage>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///List of destinations secured by Access. This supersedes `self_hosted_domains` to allow for more flexibility in defining different types of domains. If `destinations` are provided, then `self_hosted_domains` will be ignored.
      destinations: Option<accessdestinations>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: Option<accessdomain>
      ///Enables the binding cookie, which increases security against compromised authorization tokens and CSRF attacks.
      enable_binding_cookie: Option<accessenablebindingcookie>
      ///Enables the HttpOnly cookie attribute, which increases security against XSS attacks.
      http_only_cookie_attribute: Option<accesshttponlycookieattribute>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///Configures multi-factor authentication (MFA) settings.
      mfa_config: Option<accessmfaconfig>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///**Beta:** Optional configuration for managing an OAuth authorization flow controlled by Access. When set, Access will act as the OAuth authorization server for this application. Only compatible with OAuth clients that support [RFC 8707](https://datatracker.ietf.org/doc/html/rfc8707) (Resource Indicators for OAuth 2.0). This feature is currently in beta.
      oauth_configuration: Option<accessoauthconfiguration>
      ///Allows options preflight requests to bypass Access authentication and go directly to the origin. Cannot turn on if cors_headers is set.
      options_preflight_bypass: Option<accessoptionspreflightbypass>
      ///Enables cookie paths to scope an application's JWT to the application path. If disabled, the JWT will scope to the hostname by default
      path_cookie_attribute: Option<accesspathcookieattribute>
      ///Allows matching Access Service Tokens passed HTTP in a single header with this name.
      ///This works as an alternative to the (CF-Access-Client-Id, CF-Access-Client-Secret) pair of headers.
      ///The header value will be interpreted as a json object similar to:
      ///  {
      ///    "cf-access-client-id": "88bf3b6d86161464f6509f7219099e57.access.example.com",
      ///    "cf-access-client-secret": "bdd31cbc4dec990953e39163fbbb194c93313ca9f0a6e420346af9d326b1d2a5"
      ///  }
      read_service_tokens_from_header: Option<accessreadservicetokensfromheader>
      ///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
      same_site_cookie_attribute: Option<accesssamesitecookieattribute>
      ///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
      scim_config: Option<accessscimconfig>
      ///Returns a 401 status code when the request is blocked by a Service Auth policy.
      service_auth_401_redirect: Option<accessserviceauth401redirect>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///Enables automatic authentication through cloudflared.
      skip_interstitial: Option<accessskipinterstitial>
      ///The tags you want assigned to an application. Tags are used to filter applications in the App Launcher dashboard.
      tags: Option<accesstags>
      ///The application type.
      ``type``: Option<accesstype>
      ///Determines if users can access this application via a clientless browser isolation URL.
      ///This allows users to access private domains without connecting to Gateway. The option requires
      ///Clientless Browser Isolation to be set up with policies that allow users of this application.
      use_clientless_isolation_app_launcher_url: Option<accessuseclientlessisolationapplauncherurl> }
    ///Creates an instance of accesssshprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesssshprops =
        { allow_authenticate_via_warp = None
          allow_iframe = None
          allowed_idps = None
          app_launcher_visible = None
          auto_redirect_to_identity = None
          cors_headers = None
          custom_deny_message = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          destinations = None
          domain = None
          enable_binding_cookie = None
          http_only_cookie_attribute = None
          logo_url = None
          mfa_config = None
          name = None
          oauth_configuration = None
          options_preflight_bypass = None
          path_cookie_attribute = None
          read_service_tokens_from_header = None
          same_site_cookie_attribute = None
          scim_config = None
          service_auth_401_redirect = None
          session_duration = None
          skip_interstitial = None
          tags = None
          ``type`` = None
          use_clientless_isolation_app_launcher_url = None }

///A tag
type accesstag =
    { ///The number of applications that have this tag
      app_count: Option<int>
      created_at: Option<Newtonsoft.Json.Linq.JToken>
      ///The name of the tag
      name: ``accesstagscomponents-schemas-name``
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accesstag with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``accesstagscomponents-schemas-name``): accesstag =
        { app_count = None
          created_at = None
          name = name
          updated_at = None }

///A tag
type accesstagwithoutappcount =
    { created_at: Option<Newtonsoft.Json.Linq.JToken>
      ///The name of the tag
      name: ``accesstagscomponents-schemas-name``
      updated_at: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accesstagwithoutappcount with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``accesstagscomponents-schemas-name``): accesstagwithoutappcount =
        { created_at = None
          name = name
          updated_at = None }

type ``accesstagscomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesstagscomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesstagscomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accesstagscomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesstagscomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accesstagscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesstagscomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesstagscomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesstagscomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesstagscomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accesstagscomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesstagscomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accesstagscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesstagscomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesstagscomponents-schemas-responsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of accesstagscomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesstagscomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accesstagscomponents-schemas-responsecollection`` =
    { errors: list<``accesstagscomponents-schemas-responsecollectionErrors``>
      messages: list<``accesstagscomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accesstagscomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<accesstag>> }
    ///Creates an instance of accesstagscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesstagscomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accesstagscomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accesstagscomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``accesstagscomponents-schemas-singleresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesstagscomponents-schemas-singleresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesstagscomponents-schemas-singleresponseErrorsSource`` = { pointer = None }

type ``accesstagscomponents-schemas-singleresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesstagscomponents-schemas-singleresponseErrorsSource``> }
    ///Creates an instance of accesstagscomponents-schemas-singleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesstagscomponents-schemas-singleresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesstagscomponents-schemas-singleresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accesstagscomponents-schemas-singleresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accesstagscomponents-schemas-singleresponseMessagesSource`` = { pointer = None }

type ``accesstagscomponents-schemas-singleresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accesstagscomponents-schemas-singleresponseMessagesSource``> }
    ///Creates an instance of accesstagscomponents-schemas-singleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accesstagscomponents-schemas-singleresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accesstagscomponents-schemas-singleresponse`` =
    { errors: list<``accesstagscomponents-schemas-singleresponseErrors``>
      messages: list<``accesstagscomponents-schemas-singleresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      ///A tag
      result: Option<accesstag> }
    ///Creates an instance of accesstagscomponents-schemas-singleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accesstagscomponents-schemas-singleresponseErrors``>,
                          messages: list<``accesstagscomponents-schemas-singleresponseMessages``>,
                          success: bool): ``accesstagscomponents-schemas-singleresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type accesstargetcriteriabase =
    { ///The port that the targets use for the chosen communication protocol. A port cannot be assigned to multiple protocols.
      port: accessport
      ///Contains a map of target attribute keys to target attribute values.
      target_attributes: Map<string, list<string>> }
    ///Creates an instance of accesstargetcriteriabase with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (port: accessport, target_attributes: Map<string, list<string>>): accesstargetcriteriabase =
        { port = port
          target_attributes = target_attributes }

type accesstargetcriteriainfraapp =
    { ///The port that the targets use for the chosen communication protocol. A port cannot be assigned to multiple protocols.
      port: Option<accessport>
      ///Contains a map of target attribute keys to target attribute values.
      target_attributes: Option<Map<string, list<string>>>
      ///The communication protocol your application secures.
      protocol: Option<accessprotocolinfraapp> }
    ///Creates an instance of accesstargetcriteriainfraapp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesstargetcriteriainfraapp =
        { port = None
          target_attributes = None
          protocol = None }

type accesstargetcriteriaselfhostedapp =
    { ///The port that the targets use for the chosen communication protocol. A port cannot be assigned to multiple protocols.
      port: Option<accessport>
      ///Contains a map of target attribute keys to target attribute values.
      target_attributes: Option<Map<string, list<string>>>
      ///The communication protocol your application secures.
      protocol: Option<accessprotocolselfhostedapp> }
    ///Creates an instance of accesstargetcriteriaselfhostedapp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesstargetcriteriaselfhostedapp =
        { port = None
          target_attributes = None
          protocol = None }

type accessupdatedat = Map<string, Newtonsoft.Json.Linq.JToken>

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type User_risk_score =
    | [<CompiledName "low">] Low
    | [<CompiledName "medium">] Medium
    | [<CompiledName "high">] High
    | [<CompiledName "unscored">] Unscored
    member this.Format() =
        match this with
        | Low -> "low"
        | Medium -> "medium"
        | High -> "high"
        | Unscored -> "unscored"

type Userriskscore =
    { ///A list of risk score levels to match. Values can be low, medium, high, or unscored.
      user_risk_score: list<User_risk_score> }
    ///Creates an instance of Userriskscore with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (user_risk_score: list<User_risk_score>): Userriskscore = { user_risk_score = user_risk_score }

///Matches a user's risk score.
type accessuserriskscorerule =
    { user_risk_score: Userriskscore }
    ///Creates an instance of accessuserriskscorerule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (user_risk_score: Userriskscore): accessuserriskscorerule =
        { user_risk_score = user_risk_score }

type Emails =
    { ///Indicates if the email address is the primary email belonging to the SCIM User resource.
      primary: Option<bool>
      ///Indicates the type of the email address.
      ``type``: Option<string>
      ///The email address of the SCIM User resource.
      value: Option<string> }
    ///Creates an instance of Emails with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Emails =
        { primary = None
          ``type`` = None
          value = None }

type accessusers =
    { ///Determines the status of the SCIM User resource.
      active: Option<bool>
      ///The name of the SCIM User resource.
      displayName: Option<string>
      emails: Option<list<Emails>>
      ///The IdP-generated Id of the SCIM resource.
      externalId: Option<string>
      ///The unique Cloudflare-generated Id of the SCIM resource.
      id: Option<accessid>
      ///The metadata of the SCIM resource.
      meta: Option<accessmeta>
      ///The list of URIs which indicate the attributes contained within a SCIM resource.
      schemas: Option<list<string>> }
    ///Creates an instance of accessusers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessusers =
        { active = None
          displayName = None
          emails = None
          externalId = None
          id = None
          meta = None
          schemas = None }

type ``accessuserscomponents-schemas-responsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessuserscomponents-schemas-responsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessuserscomponents-schemas-responsecollectionErrorsSource`` = { pointer = None }

type ``accessuserscomponents-schemas-responsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessuserscomponents-schemas-responsecollectionErrorsSource``> }
    ///Creates an instance of accessuserscomponents-schemas-responsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessuserscomponents-schemas-responsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessuserscomponents-schemas-responsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of accessuserscomponents-schemas-responsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessuserscomponents-schemas-responsecollectionMessagesSource`` = { pointer = None }

type ``accessuserscomponents-schemas-responsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``accessuserscomponents-schemas-responsecollectionMessagesSource``> }
    ///Creates an instance of accessuserscomponents-schemas-responsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``accessuserscomponents-schemas-responsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``accessuserscomponents-schemas-responsecollectionResultinfo`` =
    { count: Option<Newtonsoft.Json.Linq.JToken>
      page: Option<Newtonsoft.Json.Linq.JToken>
      per_page: Option<Newtonsoft.Json.Linq.JToken>
      total_count: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of accessuserscomponents-schemas-responsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``accessuserscomponents-schemas-responsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``accessuserscomponents-schemas-responsecollection`` =
    { errors: list<``accessuserscomponents-schemas-responsecollectionErrors``>
      messages: list<``accessuserscomponents-schemas-responsecollectionMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``accessuserscomponents-schemas-responsecollectionResultinfo``>
      result: Option<list<``accessschemas-users``>> }
    ///Creates an instance of accessuserscomponents-schemas-responsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``accessuserscomponents-schemas-responsecollectionErrors``>,
                          messages: list<``accessuserscomponents-schemas-responsecollectionMessages``>,
                          success: bool): ``accessuserscomponents-schemas-responsecollection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type accessvncprops =
    { ///When set to true, users can authenticate to this application using their WARP session.  When set to false this application will always require direct IdP authentication. This setting always overrides the organization setting for WARP authentication.
      allow_authenticate_via_warp: Option<``accessschemas-allowauthenticateviawarp``>
      ///Enables loading application content in an iFrame.
      allow_iframe: Option<accessallowiframe>
      ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///Displays the application in the App Launcher.
      app_launcher_visible: Option<accessapplaunchervisible>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      cors_headers: Option<accesscorsheaders>
      ///The custom error message shown to a user when they are denied access to the application.
      custom_deny_message: Option<accesscustomdenymessage>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///List of destinations secured by Access. This supersedes `self_hosted_domains` to allow for more flexibility in defining different types of domains. If `destinations` are provided, then `self_hosted_domains` will be ignored.
      destinations: Option<accessdestinations>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: Option<accessdomain>
      ///Enables the binding cookie, which increases security against compromised authorization tokens and CSRF attacks.
      enable_binding_cookie: Option<accessenablebindingcookie>
      ///Enables the HttpOnly cookie attribute, which increases security against XSS attacks.
      http_only_cookie_attribute: Option<accesshttponlycookieattribute>
      ///The image URL for the logo shown in the App Launcher dashboard.
      logo_url: Option<accesslogourl>
      ///Configures multi-factor authentication (MFA) settings.
      mfa_config: Option<accessmfaconfig>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///**Beta:** Optional configuration for managing an OAuth authorization flow controlled by Access. When set, Access will act as the OAuth authorization server for this application. Only compatible with OAuth clients that support [RFC 8707](https://datatracker.ietf.org/doc/html/rfc8707) (Resource Indicators for OAuth 2.0). This feature is currently in beta.
      oauth_configuration: Option<accessoauthconfiguration>
      ///Allows options preflight requests to bypass Access authentication and go directly to the origin. Cannot turn on if cors_headers is set.
      options_preflight_bypass: Option<accessoptionspreflightbypass>
      ///Enables cookie paths to scope an application's JWT to the application path. If disabled, the JWT will scope to the hostname by default
      path_cookie_attribute: Option<accesspathcookieattribute>
      ///Allows matching Access Service Tokens passed HTTP in a single header with this name.
      ///This works as an alternative to the (CF-Access-Client-Id, CF-Access-Client-Secret) pair of headers.
      ///The header value will be interpreted as a json object similar to:
      ///  {
      ///    "cf-access-client-id": "88bf3b6d86161464f6509f7219099e57.access.example.com",
      ///    "cf-access-client-secret": "bdd31cbc4dec990953e39163fbbb194c93313ca9f0a6e420346af9d326b1d2a5"
      ///  }
      read_service_tokens_from_header: Option<accessreadservicetokensfromheader>
      ///Sets the SameSite cookie setting, which provides increased security against CSRF attacks.
      same_site_cookie_attribute: Option<accesssamesitecookieattribute>
      ///Configuration for provisioning to this application via SCIM. This is currently in closed beta.
      scim_config: Option<accessscimconfig>
      ///Returns a 401 status code when the request is blocked by a Service Auth policy.
      service_auth_401_redirect: Option<accessserviceauth401redirect>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///Enables automatic authentication through cloudflared.
      skip_interstitial: Option<accessskipinterstitial>
      ///The tags you want assigned to an application. Tags are used to filter applications in the App Launcher dashboard.
      tags: Option<accesstags>
      ///The application type.
      ``type``: Option<accesstype>
      ///Determines if users can access this application via a clientless browser isolation URL.
      ///This allows users to access private domains without connecting to Gateway. The option requires
      ///Clientless Browser Isolation to be set up with policies that allow users of this application.
      use_clientless_isolation_app_launcher_url: Option<accessuseclientlessisolationapplauncherurl> }
    ///Creates an instance of accessvncprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessvncprops =
        { allow_authenticate_via_warp = None
          allow_iframe = None
          allowed_idps = None
          app_launcher_visible = None
          auto_redirect_to_identity = None
          cors_headers = None
          custom_deny_message = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          destinations = None
          domain = None
          enable_binding_cookie = None
          http_only_cookie_attribute = None
          logo_url = None
          mfa_config = None
          name = None
          oauth_configuration = None
          options_preflight_bypass = None
          path_cookie_attribute = None
          read_service_tokens_from_header = None
          same_site_cookie_attribute = None
          scim_config = None
          service_auth_401_redirect = None
          session_duration = None
          skip_interstitial = None
          tags = None
          ``type`` = None
          use_clientless_isolation_app_launcher_url = None }

type accesswarpprops =
    { ///The identity providers your users can select when connecting to this application. Defaults to all IdPs configured in your account.
      allowed_idps: Option<accessallowedidps>
      ///When set to `true`, users skip the identity provider selection step during login. You must specify only one identity provider in allowed_idps.
      auto_redirect_to_identity: Option<``accessschemas-autoredirecttoidentity``>
      ///The custom URL a user is redirected to when they are denied access to the application when failing identity-based rules.
      custom_deny_url: Option<accesscustomdenyurl>
      ///The custom URL a user is redirected to when they are denied access to the application when failing non-identity rules.
      custom_non_identity_deny_url: Option<accesscustomnonidentitydenyurl>
      ///The custom pages that will be displayed when applicable for this application
      custom_pages: Option<``accessschemas-custompages``>
      ///The primary hostname and path secured by Access. This domain will be displayed if the app is visible in the App Launcher.
      domain: Option<accessdomain>
      ///The name of the application.
      name: Option<``accessappscomponents-schemas-name``>
      ///The amount of time that tokens issued for this application will be valid. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h. Note: unsupported for infrastructure type applications.
      session_duration: Option<``accessschemas-sessionduration``>
      ///The application type.
      ``type``: Option<accesstype> }
    ///Creates an instance of accesswarpprops with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accesswarpprops =
        { allowed_idps = None
          auto_redirect_to_identity = None
          custom_deny_url = None
          custom_non_identity_deny_url = None
          custom_pages = None
          domain = None
          name = None
          session_duration = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessyandexScimconfigIdentityupdatebehavior =
    | [<CompiledName "automatic">] Automatic
    | [<CompiledName "reauth">] Reauth
    | [<CompiledName "no_action">] No_action
    member this.Format() =
        match this with
        | Automatic -> "automatic"
        | Reauth -> "reauth"
        | No_action -> "no_action"

///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
type accessyandexScimconfig =
    { ///A flag to enable or disable SCIM for the identity provider.
      enabled: Option<bool>
      ///Indicates how a SCIM event updates a user identity used for policy evaluation. Use "automatic" to automatically update a user's identity and augment it with fields from the SCIM user resource. Use "reauth" to force re-authentication on group membership updates, user identity update will only occur after successful re-authentication. With "reauth" identities will not contain fields from the SCIM user resource. With "no_action" identities will not be changed by SCIM updates in any way and users will not be prompted to reauthenticate.
      identity_update_behavior: Option<accessyandexScimconfigIdentityupdatebehavior>
      ///The base URL of Cloudflare's SCIM V2.0 API endpoint.
      scim_base_url: Option<string>
      ///A flag to remove a user's seat in Zero Trust when they have been deprovisioned in the Identity Provider.  This cannot be enabled unless user_deprovision is also enabled.
      seat_deprovision: Option<bool>
      ///A read-only token generated when the SCIM integration is enabled for the first time.  It is redacted on subsequent requests.  If you lose this you will need to refresh it at /access/identity_providers/:idpID/refresh_scim_secret.
      secret: Option<string>
      ///A flag to enable revoking a user's session in Access and Gateway when they have been deprovisioned in the Identity Provider.
      user_deprovision: Option<bool> }
    ///Creates an instance of accessyandexScimconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessyandexScimconfig =
        { enabled = None
          identity_update_behavior = None
          scim_base_url = None
          seat_deprovision = None
          secret = None
          user_deprovision = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type accessyandexType =
    | [<CompiledName "onetimepin">] Onetimepin
    | [<CompiledName "azureAD">] AzureAD
    | [<CompiledName "saml">] Saml
    | [<CompiledName "centrify">] Centrify
    | [<CompiledName "facebook">] Facebook
    | [<CompiledName "github">] Github
    | [<CompiledName "google-apps">] GoogleApps
    | [<CompiledName "google">] Google
    | [<CompiledName "linkedin">] Linkedin
    | [<CompiledName "oidc">] Oidc
    | [<CompiledName "okta">] Okta
    | [<CompiledName "onelogin">] Onelogin
    | [<CompiledName "pingone">] Pingone
    | [<CompiledName "yandex">] Yandex
    member this.Format() =
        match this with
        | Onetimepin -> "onetimepin"
        | AzureAD -> "azureAD"
        | Saml -> "saml"
        | Centrify -> "centrify"
        | Facebook -> "facebook"
        | Github -> "github"
        | GoogleApps -> "google-apps"
        | Google -> "google"
        | Linkedin -> "linkedin"
        | Oidc -> "oidc"
        | Okta -> "okta"
        | Onelogin -> "onelogin"
        | Pingone -> "pingone"
        | Yandex -> "yandex"

type accessyandex =
    { ///The configuration parameters for the identity provider. To view the required parameters for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      config: Option<Newtonsoft.Json.Linq.JObject>
      ///UUID.
      id: Option<accessuuid>
      ///The name of the identity provider, shown to users on the login page.
      name: Option<``accesscomponents-schemas-name``>
      ///The configuration settings for enabling a System for Cross-Domain Identity Management (SCIM) with the identity provider.
      scim_config: Option<accessyandexScimconfig>
      ///The type of identity provider. To determine the value for a specific provider, refer to our [developer documentation](https://developers.cloudflare.com/cloudflare-one/identity/idp-integration/).
      ``type``: Option<accessyandexType> }
    ///Creates an instance of accessyandex with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): accessyandex =
        { config = None
          id = None
          name = None
          scim_config = None
          ``type`` = None }

type ``access-applications-add-an-applicationresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of access-applications-add-an-applicationresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``access-applications-add-an-applicationresponseErrorsSource`` = { pointer = None }

type ``access-applications-add-an-applicationresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``access-applications-add-an-applicationresponseErrorsSource``> }
    ///Creates an instance of access-applications-add-an-applicationresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``access-applications-add-an-applicationresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``access-applications-add-an-applicationresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of access-applications-add-an-applicationresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``access-applications-add-an-applicationresponseMessagesSource`` = { pointer = None }

type ``access-applications-add-an-applicationresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``access-applications-add-an-applicationresponseMessagesSource``> }
    ///Creates an instance of access-applications-add-an-applicationresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``access-applications-add-an-applicationresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``access-applications-add-an-applicationresponse`` =
    { errors: list<``access-applications-add-an-applicationresponseErrors``>
      messages: list<``access-applications-add-an-applicationresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of access-applications-add-an-applicationresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``access-applications-add-an-applicationresponseErrors``>,
                          messages: list<``access-applications-add-an-applicationresponseMessages``>,
                          success: bool): ``access-applications-add-an-applicationresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``access-applications-update-an-access-applicationresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of access-applications-update-an-access-applicationresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``access-applications-update-an-access-applicationresponseErrorsSource`` =
        { pointer = None }

type ``access-applications-update-an-access-applicationresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``access-applications-update-an-access-applicationresponseErrorsSource``> }
    ///Creates an instance of access-applications-update-an-access-applicationresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``access-applications-update-an-access-applicationresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``access-applications-update-an-access-applicationresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of access-applications-update-an-access-applicationresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``access-applications-update-an-access-applicationresponseMessagesSource`` =
        { pointer = None }

type ``access-applications-update-an-access-applicationresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``access-applications-update-an-access-applicationresponseMessagesSource``> }
    ///Creates an instance of access-applications-update-an-access-applicationresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``access-applications-update-an-access-applicationresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``access-applications-update-an-access-applicationresponse`` =
    { errors: list<``access-applications-update-an-access-applicationresponseErrors``>
      messages: list<``access-applications-update-an-access-applicationresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of access-applications-update-an-access-applicationresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``access-applications-update-an-access-applicationresponseErrors``>,
                          messages: list<``access-applications-update-an-access-applicationresponseMessages``>,
                          success: bool): ``access-applications-update-an-access-applicationresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseErrorsSource`` =
        { pointer = None }

type ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseErrorsSource``> }
    ///Creates an instance of zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseMessagesSource`` =
        { pointer = None }

type ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseMessagesSource``> }
    ///Creates an instance of zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseResult`` =
    { ///The duration the DoH JWT is valid for. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.  Note that the maximum duration for this setting is the same as the key rotation period on the account.
      doh_jwt_duration: Option<string> }
    ///Creates an instance of zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseResult`` =
        { doh_jwt_duration = None }

type ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponse`` =
    { errors: list<``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseErrors``>
      messages: list<``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseResult``> }
    ///Creates an instance of zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseErrors``>,
                          messages: list<``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponseMessages``>,
                          success: bool): ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseErrorsSource`` =
        { pointer = None }

type ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseErrorsSource``> }
    ///Creates an instance of zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseMessagesSource`` =
        { pointer = None }

type ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseMessagesSource``> }
    ///Creates an instance of zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseResult`` =
    { ///The duration the DoH JWT is valid for. Must be in the format `300ms` or `2h45m`. Valid time units are: ns, us (or µs), ms, s, m, h.  Note that the maximum duration for this setting is the same as the key rotation period on the account. Default expiration is 24h
      doh_jwt_duration: Option<accessdohjwtduration> }
    ///Creates an instance of zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseResult`` =
        { doh_jwt_duration = None }

type ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponse`` =
    { errors: list<``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseErrors``>
      messages: list<``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseResult``> }
    ///Creates an instance of zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseErrors``>,
                          messages: list<``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponseMessages``>,
                          success: bool): ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type McpPortalsApiListPortals_OKResult =
    { created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      hostname: string
      ///portal id
      id: string
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      ///Route outbound MCP traffic through Zero Trust Secure Web Gateway
      secure_web_gateway: Option<bool> }

type McpPortalsApiListPortals_OK =
    { result: list<McpPortalsApiListPortals_OKResult>
      success: bool }

type McpPortalsApiListPortals_BadRequestErrors = { message: string }

type McpPortalsApiListPortals_BadRequest =
    { errors: list<McpPortalsApiListPortals_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiListPortals =
    ///List objects
    | OK of payload: McpPortalsApiListPortals_OK
    ///Bad Request
    | BadRequest of payload: McpPortalsApiListPortals_BadRequest

type Updatedprompts =
    { description: Option<string>
      enabled: Option<bool>
      name: string }
    ///Creates an instance of Updatedprompts with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): Updatedprompts =
        { description = None
          enabled = None
          name = name }

type Updatedtools =
    { description: Option<string>
      enabled: Option<bool>
      name: string }
    ///Creates an instance of Updatedtools with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): Updatedtools =
        { description = None
          enabled = None
          name = name }

type Servers =
    { default_disabled: Option<bool>
      on_behalf: Option<bool>
      ///server id
      server_id: string
      updated_prompts: Option<list<Updatedprompts>>
      updated_tools: Option<list<Updatedtools>> }
    ///Creates an instance of Servers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (server_id: string): Servers =
        { default_disabled = None
          on_behalf = None
          server_id = server_id
          updated_prompts = None
          updated_tools = None }

type McpPortalsApiCreatePortalsPayload =
    { description: Option<string>
      hostname: string
      ///portal id
      id: string
      name: string
      ///Route outbound MCP traffic through Zero Trust Secure Web Gateway
      secure_web_gateway: Option<bool>
      servers: Option<list<Servers>> }
    ///Creates an instance of McpPortalsApiCreatePortalsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (hostname: string, id: string, name: string): McpPortalsApiCreatePortalsPayload =
        { description = None
          hostname = hostname
          id = id
          name = name
          secure_web_gateway = None
          servers = None }

type McpPortalsApiCreatePortals_CreatedResult =
    { created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      hostname: string
      ///portal id
      id: string
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      ///Route outbound MCP traffic through Zero Trust Secure Web Gateway
      secure_web_gateway: Option<bool> }

type McpPortalsApiCreatePortals_Created =
    { result: McpPortalsApiCreatePortals_CreatedResult
      success: bool }

type McpPortalsApiCreatePortals_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type McpPortalsApiCreatePortals_BadRequest =
    { errors: list<McpPortalsApiCreatePortals_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiCreatePortals =
    ///Returns the created Object
    | Created of payload: McpPortalsApiCreatePortals_Created
    ///Input Validation Error
    | BadRequest of payload: McpPortalsApiCreatePortals_BadRequest

type McpPortalsApiDeletePortals_OKResult =
    { created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      hostname: string
      ///portal id
      id: string
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      ///Route outbound MCP traffic through Zero Trust Secure Web Gateway
      secure_web_gateway: Option<bool> }

type McpPortalsApiDeletePortals_OK =
    { result: McpPortalsApiDeletePortals_OKResult
      success: bool }

type McpPortalsApiDeletePortals_NotFoundErrors = { code: float; message: string }

type McpPortalsApiDeletePortals_NotFound =
    { errors: list<McpPortalsApiDeletePortals_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiDeletePortals =
    ///Returns the Object if it was successfully deleted
    | OK of payload: McpPortalsApiDeletePortals_OK
    ///Not Found
    | NotFound of payload: McpPortalsApiDeletePortals_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type McpPortalsApiFetchGateways_OKResultServersAuthtype =
    | [<CompiledName "oauth">] Oauth
    | [<CompiledName "bearer">] Bearer
    | [<CompiledName "unauthenticated">] Unauthenticated
    member this.Format() =
        match this with
        | Oauth -> "oauth"
        | Bearer -> "bearer"
        | Unauthenticated -> "unauthenticated"

type McpPortalsApiFetchGateways_OKResultServers =
    { auth_type: McpPortalsApiFetchGateways_OKResultServersAuthtype
      created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      default_disabled: Option<bool>
      description: Option<string>
      error: Option<string>
      hostname: string
      ///server id
      id: string
      last_successful_sync: Option<System.DateTimeOffset>
      last_synced: Option<System.DateTimeOffset>
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      on_behalf: Option<bool>
      prompts: Newtonsoft.Json.Linq.JArray
      status: Option<string>
      tools: Newtonsoft.Json.Linq.JArray
      updated_prompts: Newtonsoft.Json.Linq.JArray
      updated_tools: Newtonsoft.Json.Linq.JArray }

type McpPortalsApiFetchGateways_OKResult =
    { created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      hostname: string
      ///portal id
      id: string
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      ///Route outbound MCP traffic through Zero Trust Secure Web Gateway
      secure_web_gateway: Option<bool>
      servers: list<McpPortalsApiFetchGateways_OKResultServers> }

type McpPortalsApiFetchGateways_OK =
    { result: McpPortalsApiFetchGateways_OKResult
      success: bool }

type McpPortalsApiFetchGateways_NotFoundErrors = { code: float; message: string }

type McpPortalsApiFetchGateways_NotFound =
    { errors: list<McpPortalsApiFetchGateways_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiFetchGateways =
    ///Returns a single object if found
    | OK of payload: McpPortalsApiFetchGateways_OK
    ///Not Found
    | NotFound of payload: McpPortalsApiFetchGateways_NotFound

type McpPortalsApiUpdatePortalsPayloadServersUpdatedprompts =
    { description: Option<string>
      enabled: Option<bool>
      name: string }
    ///Creates an instance of McpPortalsApiUpdatePortalsPayloadServersUpdatedprompts with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): McpPortalsApiUpdatePortalsPayloadServersUpdatedprompts =
        { description = None
          enabled = None
          name = name }

type McpPortalsApiUpdatePortalsPayloadServersUpdatedtools =
    { description: Option<string>
      enabled: Option<bool>
      name: string }
    ///Creates an instance of McpPortalsApiUpdatePortalsPayloadServersUpdatedtools with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): McpPortalsApiUpdatePortalsPayloadServersUpdatedtools =
        { description = None
          enabled = None
          name = name }

type McpPortalsApiUpdatePortalsPayloadServers =
    { default_disabled: Option<bool>
      on_behalf: Option<bool>
      ///server id
      server_id: string
      updated_prompts: Option<list<McpPortalsApiUpdatePortalsPayloadServersUpdatedprompts>>
      updated_tools: Option<list<McpPortalsApiUpdatePortalsPayloadServersUpdatedtools>> }
    ///Creates an instance of McpPortalsApiUpdatePortalsPayloadServers with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (server_id: string): McpPortalsApiUpdatePortalsPayloadServers =
        { default_disabled = None
          on_behalf = None
          server_id = server_id
          updated_prompts = None
          updated_tools = None }

type McpPortalsApiUpdatePortalsPayload =
    { description: Option<string>
      hostname: Option<string>
      name: Option<string>
      ///Route outbound MCP traffic through Zero Trust Secure Web Gateway
      secure_web_gateway: Option<bool>
      servers: Option<list<McpPortalsApiUpdatePortalsPayloadServers>> }
    ///Creates an instance of McpPortalsApiUpdatePortalsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): McpPortalsApiUpdatePortalsPayload =
        { description = None
          hostname = None
          name = None
          secure_web_gateway = None
          servers = None }

type McpPortalsApiUpdatePortals_OKResult =
    { created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      hostname: string
      ///portal id
      id: string
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      ///Route outbound MCP traffic through Zero Trust Secure Web Gateway
      secure_web_gateway: Option<bool> }

type McpPortalsApiUpdatePortals_OK =
    { result: McpPortalsApiUpdatePortals_OKResult
      success: bool }

type McpPortalsApiUpdatePortals_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type McpPortalsApiUpdatePortals_BadRequest =
    { errors: list<McpPortalsApiUpdatePortals_BadRequestErrors>
      success: bool }

type McpPortalsApiUpdatePortals_NotFoundErrors = { code: float; message: string }

type McpPortalsApiUpdatePortals_NotFound =
    { errors: list<McpPortalsApiUpdatePortals_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiUpdatePortals =
    ///Returns the updated Object
    | OK of payload: McpPortalsApiUpdatePortals_OK
    ///Input Validation Error
    | BadRequest of payload: McpPortalsApiUpdatePortals_BadRequest
    ///Not Found
    | NotFound of payload: McpPortalsApiUpdatePortals_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type McpPortalsApiListServers_OKResultAuthtype =
    | [<CompiledName "oauth">] Oauth
    | [<CompiledName "bearer">] Bearer
    | [<CompiledName "unauthenticated">] Unauthenticated
    member this.Format() =
        match this with
        | Oauth -> "oauth"
        | Bearer -> "bearer"
        | Unauthenticated -> "unauthenticated"

type McpPortalsApiListServers_OKResult =
    { auth_type: McpPortalsApiListServers_OKResultAuthtype
      created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      error: Option<string>
      hostname: string
      ///server id
      id: string
      last_successful_sync: Option<System.DateTimeOffset>
      last_synced: Option<System.DateTimeOffset>
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      prompts: Newtonsoft.Json.Linq.JArray
      status: Option<string>
      tools: Newtonsoft.Json.Linq.JArray }

type McpPortalsApiListServers_OK =
    { result: list<McpPortalsApiListServers_OKResult>
      success: bool }

type McpPortalsApiListServers_BadRequestErrors = { message: string }

type McpPortalsApiListServers_BadRequest =
    { errors: list<McpPortalsApiListServers_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiListServers =
    ///List objects
    | OK of payload: McpPortalsApiListServers_OK
    ///Bad Request
    | BadRequest of payload: McpPortalsApiListServers_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type McpPortalsApiCreateServersPayloadAuthtype =
    | [<CompiledName "oauth">] Oauth
    | [<CompiledName "bearer">] Bearer
    | [<CompiledName "unauthenticated">] Unauthenticated
    member this.Format() =
        match this with
        | Oauth -> "oauth"
        | Bearer -> "bearer"
        | Unauthenticated -> "unauthenticated"

type McpPortalsApiCreateServersPayload =
    { auth_credentials: Option<string>
      auth_type: McpPortalsApiCreateServersPayloadAuthtype
      description: Option<string>
      hostname: string
      ///server id
      id: string
      name: string }
    ///Creates an instance of McpPortalsApiCreateServersPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (auth_type: McpPortalsApiCreateServersPayloadAuthtype,
                          hostname: string,
                          id: string,
                          name: string): McpPortalsApiCreateServersPayload =
        { auth_credentials = None
          auth_type = auth_type
          description = None
          hostname = hostname
          id = id
          name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type McpPortalsApiCreateServers_CreatedResultAuthtype =
    | [<CompiledName "oauth">] Oauth
    | [<CompiledName "bearer">] Bearer
    | [<CompiledName "unauthenticated">] Unauthenticated
    member this.Format() =
        match this with
        | Oauth -> "oauth"
        | Bearer -> "bearer"
        | Unauthenticated -> "unauthenticated"

type McpPortalsApiCreateServers_CreatedResult =
    { auth_type: McpPortalsApiCreateServers_CreatedResultAuthtype
      created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      error: Option<string>
      hostname: string
      ///server id
      id: string
      last_successful_sync: Option<System.DateTimeOffset>
      last_synced: Option<System.DateTimeOffset>
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      prompts: Newtonsoft.Json.Linq.JArray
      status: Option<string>
      tools: Newtonsoft.Json.Linq.JArray }

type McpPortalsApiCreateServers_Created =
    { result: McpPortalsApiCreateServers_CreatedResult
      success: bool }

type McpPortalsApiCreateServers_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type McpPortalsApiCreateServers_BadRequest =
    { errors: list<McpPortalsApiCreateServers_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiCreateServers =
    ///Returns the created Object
    | Created of payload: McpPortalsApiCreateServers_Created
    ///Input Validation Error
    | BadRequest of payload: McpPortalsApiCreateServers_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type McpPortalsApiDeleteServers_OKResultAuthtype =
    | [<CompiledName "oauth">] Oauth
    | [<CompiledName "bearer">] Bearer
    | [<CompiledName "unauthenticated">] Unauthenticated
    member this.Format() =
        match this with
        | Oauth -> "oauth"
        | Bearer -> "bearer"
        | Unauthenticated -> "unauthenticated"

type McpPortalsApiDeleteServers_OKResult =
    { auth_type: McpPortalsApiDeleteServers_OKResultAuthtype
      created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      error: Option<string>
      hostname: string
      ///server id
      id: string
      last_successful_sync: Option<System.DateTimeOffset>
      last_synced: Option<System.DateTimeOffset>
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      prompts: Newtonsoft.Json.Linq.JArray
      status: Option<string>
      tools: Newtonsoft.Json.Linq.JArray }

type McpPortalsApiDeleteServers_OK =
    { result: McpPortalsApiDeleteServers_OKResult
      success: bool }

type McpPortalsApiDeleteServers_NotFoundErrors = { code: float; message: string }

type McpPortalsApiDeleteServers_NotFound =
    { errors: list<McpPortalsApiDeleteServers_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiDeleteServers =
    ///Returns the Object if it was successfully deleted
    | OK of payload: McpPortalsApiDeleteServers_OK
    ///Not Found
    | NotFound of payload: McpPortalsApiDeleteServers_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type McpPortalsApiFetchServers_OKResultAuthtype =
    | [<CompiledName "oauth">] Oauth
    | [<CompiledName "bearer">] Bearer
    | [<CompiledName "unauthenticated">] Unauthenticated
    member this.Format() =
        match this with
        | Oauth -> "oauth"
        | Bearer -> "bearer"
        | Unauthenticated -> "unauthenticated"

type McpPortalsApiFetchServers_OKResult =
    { auth_type: McpPortalsApiFetchServers_OKResultAuthtype
      created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      error: Option<string>
      hostname: string
      ///server id
      id: string
      last_successful_sync: Option<System.DateTimeOffset>
      last_synced: Option<System.DateTimeOffset>
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      prompts: Newtonsoft.Json.Linq.JArray
      status: Option<string>
      tools: Newtonsoft.Json.Linq.JArray }

type McpPortalsApiFetchServers_OK =
    { result: McpPortalsApiFetchServers_OKResult
      success: bool }

type McpPortalsApiFetchServers_NotFoundErrors = { code: float; message: string }

type McpPortalsApiFetchServers_NotFound =
    { errors: list<McpPortalsApiFetchServers_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiFetchServers =
    ///Returns a single object if found
    | OK of payload: McpPortalsApiFetchServers_OK
    ///Not Found
    | NotFound of payload: McpPortalsApiFetchServers_NotFound

type McpPortalsApiUpdateServersPayload =
    { auth_credentials: Option<string>
      description: Option<string>
      name: Option<string> }
    ///Creates an instance of McpPortalsApiUpdateServersPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): McpPortalsApiUpdateServersPayload =
        { auth_credentials = None
          description = None
          name = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type McpPortalsApiUpdateServers_OKResultAuthtype =
    | [<CompiledName "oauth">] Oauth
    | [<CompiledName "bearer">] Bearer
    | [<CompiledName "unauthenticated">] Unauthenticated
    member this.Format() =
        match this with
        | Oauth -> "oauth"
        | Bearer -> "bearer"
        | Unauthenticated -> "unauthenticated"

type McpPortalsApiUpdateServers_OKResult =
    { auth_type: McpPortalsApiUpdateServers_OKResultAuthtype
      created_at: Option<System.DateTimeOffset>
      created_by: Option<string>
      description: Option<string>
      error: Option<string>
      hostname: string
      ///server id
      id: string
      last_successful_sync: Option<System.DateTimeOffset>
      last_synced: Option<System.DateTimeOffset>
      modified_at: Option<System.DateTimeOffset>
      modified_by: Option<string>
      name: string
      prompts: Newtonsoft.Json.Linq.JArray
      status: Option<string>
      tools: Newtonsoft.Json.Linq.JArray }

type McpPortalsApiUpdateServers_OK =
    { result: McpPortalsApiUpdateServers_OKResult
      success: bool }

type McpPortalsApiUpdateServers_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type McpPortalsApiUpdateServers_BadRequest =
    { errors: list<McpPortalsApiUpdateServers_BadRequestErrors>
      success: bool }

type McpPortalsApiUpdateServers_NotFoundErrors = { code: float; message: string }

type McpPortalsApiUpdateServers_NotFound =
    { errors: list<McpPortalsApiUpdateServers_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiUpdateServers =
    ///Returns the updated Object
    | OK of payload: McpPortalsApiUpdateServers_OK
    ///Input Validation Error
    | BadRequest of payload: McpPortalsApiUpdateServers_BadRequest
    ///Not Found
    | NotFound of payload: McpPortalsApiUpdateServers_NotFound

type McpPortalsApiSyncServer_OK =
    { result: Newtonsoft.Json.Linq.JObject
      success: bool }

type McpPortalsApiSyncServer_NotFoundErrors = { code: float; message: string }

type McpPortalsApiSyncServer_NotFound =
    { errors: list<McpPortalsApiSyncServer_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type McpPortalsApiSyncServer =
    | OK of payload: McpPortalsApiSyncServer_OK
    ///Not Found
    | NotFound of payload: McpPortalsApiSyncServer_NotFound

[<RequireQualifiedAccess>]
type AccessApplicationsListAccessApplications =
    ///List Access applications response
    | OK of payload: ``accessappscomponents-schemas-responsecollection``
    ///List Access applications response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessApplicationsAddAnApplication =
    ///Add an Access application response
    | Created of payload: ``access-applications-add-an-applicationresponse``
    ///Add an Access application response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessShortLivedCertificateCAsListShortLivedCertificateCAs =
    ///List short-lived certificate CAs response
    | OK of payload: ``accesscacomponents-schemas-responsecollection``
    ///List short-lived certificate CAs response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessApplicationsDeleteAnAccessApplication =
    ///Delete an Access application response
    | Accepted of payload: accessidresponse
    ///Delete an Access application response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessApplicationsGetAnAccessApplication =
    ///Get an Access application response
    | OK of payload: ``accessappscomponents-schemas-singleresponse``
    ///Get an Access application response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessApplicationsUpdateAnAccessApplication =
    ///Update an Access application response
    | OK of payload: ``access-applications-update-an-access-applicationresponse``
    ///Update an Access application response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessShortLivedCertificateCAsDeleteAShortLivedCertificateCa =
    ///Delete a short-lived certificate CA response
    | Accepted of payload: ``accessschemas-idresponse``
    ///Delete a short-lived certificate CA response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessShortLivedCertificateCAsGetAShortLivedCertificateCa =
    ///Get a short-lived certificate CA response
    | OK of payload: ``accesscacomponents-schemas-singleresponse``
    ///Get a short-lived certificate CA response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessShortLivedCertificateCAsCreateAShortLivedCertificateCa =
    ///Create a short-lived certificate CA response
    | OK of payload: ``accesscacomponents-schemas-singleresponse``
    ///Create a short-lived certificate CA response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesListAccessAppPolicies =
    ///List Access application policies response
    | OK of payload: ``accessapp-policiescomponents-schemas-responsecollection``
    ///List Access application policies response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesCreateAnAccessPolicy =
    ///Create an Access application policy response.
    | Created of payload: ``accessapp-policiescomponents-schemas-singleresponse``
    ///Create an Access application policy response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesDeleteAnAccessPolicy =
    ///Delete an Access application policy response.
    | Accepted of payload: ``accessapp-policiescomponents-schemas-idresponse``
    ///Delete an Access application policy response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesGetAnAccessPolicy =
    ///Get an Access policy response.
    | OK of payload: ``accessapp-policiescomponents-schemas-singleresponse``
    ///Get an Access policy response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesUpdateAnAccessPolicy =
    ///Update an Access application policy response.
    | OK of payload: ``accessapp-policiescomponents-schemas-singleresponse``
    ///Update an Access application policy response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesConvertReusable =
    ///Convert an Access application policy to a reusable policy
    | OK of payload: ``accessapp-policiescomponents-schemas-responsecollection``
    ///Convert an Access application policy to a reusable policy failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessApplicationsRevokeServiceTokens =
    ///Revoke application tokens response
    | Accepted of payload: ``accessschemas-emptyresponse``
    ///Revoke application tokens response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessApplicationsPatchUpdateAccessApplicationSettings =
    ///Update Access application settings response
    | Accepted of payload: string
    ///Update Access application settings response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessApplicationsPutUpdateAccessApplicationSettings =
    ///Update Access application settings response
    | Accepted of payload: string
    ///Update Access application settings response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessApplicationsTestAccessPolicies =
    ///Test Access policies response
    | OK of payload: accesspolicycheckresponse
    ///Test Access policies response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ``AccessBookmarkApplications(Deprecated)ListBookmarkApplications`` =
    ///List Bookmark applications response
    | OK of payload: ``accessbookmarkscomponents-schemas-responsecollection``
    ///List Bookmark applications response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ``AccessBookmarkApplications(Deprecated)DeleteABookmarkApplication`` =
    ///Delete a Bookmark application response
    | OK of payload: accessidresponse
    ///Delete a Bookmark application response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ``AccessBookmarkApplications(Deprecated)GetABookmarkApplication`` =
    ///Get a Bookmark application response
    | OK of payload: ``accessbookmarkscomponents-schemas-singleresponse``
    ///Get a Bookmark application response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ``AccessBookmarkApplications(Deprecated)CreateABookmarkApplication`` =
    ///Create a Bookmark application response
    | OK of payload: ``accessbookmarkscomponents-schemas-singleresponse``
    ///Create a Bookmark application response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ``AccessBookmarkApplications(Deprecated)UpdateABookmarkApplication`` =
    ///Update a Bookmark application response
    | OK of payload: ``accessbookmarkscomponents-schemas-singleresponse``
    ///Update a Bookmark application response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessMtlsAuthenticationListMtlsCertificates =
    ///List mTLS certificates response
    | OK of payload: ``accesscertificatescomponents-schemas-responsecollection``
    ///List mTLS certificates response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessMtlsAuthenticationAddAnMtlsCertificate =
    ///Add an mTLS certificate response
    | Created of payload: ``accesscertificatescomponents-schemas-singleresponse``
    ///Add an mTLS certificate response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessMtlsAuthenticationListMtlsCertificatesHostnameSettings =
    ///List mTLS hostname settings response
    | OK of payload: accessresponsecollectionhostnames
    ///List mTLS hostname settings response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

type AccessMtlsAuthenticationUpdateAnMtlsCertificateSettingsPayload =
    { settings: list<accesssettings> }
    ///Creates an instance of AccessMtlsAuthenticationUpdateAnMtlsCertificateSettingsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (settings: list<accesssettings>): AccessMtlsAuthenticationUpdateAnMtlsCertificateSettingsPayload =
        { settings = settings }

[<RequireQualifiedAccess>]
type AccessMtlsAuthenticationUpdateAnMtlsCertificateSettings =
    ///Update an mTLS certificates hostname settings response
    | Accepted of payload: accessresponsecollectionhostnames
    ///Update an mTLS certificates hostname settings failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessMtlsAuthenticationDeleteAnMtlsCertificate =
    ///Delete an mTLS certificate response
    | OK of payload: ``accesscomponents-schemas-idresponse``
    ///Delete an mTLS certificate response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessMtlsAuthenticationGetAnMtlsCertificate =
    ///Get an mTLS certificate response
    | OK of payload: ``accesscertificatescomponents-schemas-singleresponse``
    ///Get an mTLS certificate response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessMtlsAuthenticationUpdateAnMtlsCertificate =
    ///Update an mTLS certificate response
    | OK of payload: ``accesscertificatescomponents-schemas-singleresponse``
    ///Update an mTLS certificate response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessCustomPagesListCustomPages =
    ///List custom pages response
    | OK of payload: ``accesscustom-pagescomponents-schemas-responsecollection``
    ///List custom pages response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessCustomPagesCreateACustomPage =
    ///Create a custom page response
    | Created of payload: accesssingleresponsewithouthtml
    ///Create a custom page response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessCustomPagesDeleteACustomPage =
    ///Delete a custom page response
    | Accepted of payload: ``accesscomponents-schemas-idresponse``
    ///Delete a custom page response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessCustomPagesGetACustomPage =
    ///Get a custom page response
    | OK of payload: ``accesscustom-pagescomponents-schemas-singleresponse``
    ///Get a custom page response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessCustomPagesUpdateACustomPage =
    ///Update a custom page response
    | OK of payload: accesssingleresponsewithouthtml
    ///Update a custom page response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessGatewayCaListSSHCa =
    ///List SSH Certificate Authorities (CA) response
    | OK of payload: ``accessgatewaycacomponents-schemas-responsecollection``
    ///List SSH Certificate Authorities (CA) response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessGatewayCaAddAnSSHCa =
    ///Add a new SSH Certificate Authority (CA) response
    | Created of payload: ``accessgatewaycacomponents-schemas-singleresponse``
    ///Add a new SSH Certificate Authority (CA) response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessGatewayCaDeleteAnSSHCa =
    ///Delete an SSH Certificate Authority (CA) response
    | OK of payload: accessidresponse
    ///Delete an SSH Certificate Authority (CA) response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessGroupsListAccessGroups =
    ///List Access groups response
    | OK of payload: ``accessschemas-responsecollection``
    ///List Access groups response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessGroupsCreateAnAccessGroup =
    ///Create an Access group response
    | Created of payload: ``accessgroupscomponents-schemas-singleresponse``
    ///Create an Access group response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessGroupsDeleteAnAccessGroup =
    ///Delete an Access group response
    | Accepted of payload: accessidresponse
    ///Delete an Access group response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessGroupsGetAnAccessGroup =
    ///Get an Access group response
    | OK of payload: ``accessgroupscomponents-schemas-singleresponse``
    ///Get an Access group response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessGroupsUpdateAnAccessGroup =
    ///Update an Access group response
    | OK of payload: ``accessgroupscomponents-schemas-singleresponse``
    ///Update an Access group response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessIdentityProvidersListAccessIdentityProviders =
    ///List Access identity providers response
    | OK of payload: accessresponsecollection
    ///List Access identity providers response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessIdentityProvidersAddAnAccessIdentityProvider =
    ///Add an Access identity provider response
    | Created of payload: ``accesscomponents-schemas-singleresponse``
    ///Add an Access identity provider response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessIdentityProvidersDeleteAnAccessIdentityProvider =
    ///Delete an Access identity provider response
    | Accepted of payload: accessidresponse
    ///Delete an Access identity provider response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessIdentityProvidersGetAnAccessIdentityProvider =
    ///Get an Access identity provider response
    | OK of payload: ``accesscomponents-schemas-singleresponse``
    ///Get an Access identity provider response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessIdentityProvidersUpdateAnAccessIdentityProvider =
    ///Update an Access identity provider response
    | OK of payload: ``accesscomponents-schemas-singleresponse``
    ///Update an Access identity provider response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessIdentityProvidersListScimGroupResources =
    ///List SCIM Group resources response
    | OK of payload: accessscimgroupsresponse
    ///List SCIM Group resources response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessIdentityProvidersListScimUserResources =
    ///List SCIM User resources response
    | OK of payload: accessscimusersresponse
    ///List SCIM User resources response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessKeyConfigurationGetTheAccessKeyConfiguration =
    ///Get the Access key configuration response
    | OK of payload: ``accesskeyscomponents-schemas-singleresponse``
    ///Get the Access key configuration response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessKeyConfigurationUpdateTheAccessKeyConfiguration =
    ///Update the Access key configuration response
    | OK of payload: ``accesskeyscomponents-schemas-singleresponse``
    ///Update the Access key configuration response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessKeyConfigurationRotateAccessKeys =
    ///Rotate Access keys response
    | OK of payload: ``accesskeyscomponents-schemas-singleresponse``
    ///Rotate Access keys response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessAuthenticationLogsGetAccessAuthenticationLogs =
    ///Get Access authentication logs response
    | OK of payload: ``accessaccess-requestscomponents-schemas-responsecollection``
    ///Get Access authentication logs response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessScimUpdateLogsListAccessScimUpdateLogs =
    ///Get Access SCIM update logs response
    | OK of payload: accessscimupdatelogsresponse
    ///Get Access SCIM update logs response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustOrganizationGetYourZeroTrustOrganization =
    ///Get your Zero Trust organization response
    | OK of payload: accesssingleresponse
    ///Get your Zero Trust organization response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustOrganizationCreateYourZeroTrustOrganization =
    ///Create your Zero Trust organization response
    | Created of payload: accesssingleresponse
    ///Create your Zero Trust organization response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustOrganizationUpdateYourZeroTrustOrganization =
    ///Update your Zero Trust organization response
    | OK of payload: accesssingleresponse
    ///Update your Zero Trust organization response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustOrganizationGetYourZeroTrustOrganizationDohSettings =
    ///Get your Zero Trust organization DoH settings response
    | OK of payload: ``zero-trust-organization-get-your-zero-trust-organization-doh-settingsresponse``
    ///Get your Zero Trust organization DoH settings response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustOrganizationUpdateYourZeroTrustOrganizationDohSettings =
    ///Update your Zero Trust organization DoH settings response
    | Created of payload: ``zero-trust-organization-update-your-zero-trust-organization-doh-settingsresponse``
    ///Update your Zero Trust organization DoH settings response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustOrganizationRevokeAllAccessTokensForAUser =
    ///Revoke all Access tokens for a user response
    | OK of payload: accessemptyresponse

[<RequireQualifiedAccess>]
type AccessPoliciesListAccessReusablePolicies =
    ///List Access reusable policies response.
    | OK of payload: ``accessreusable-policiescomponents-schemas-responsecollection``
    ///List Access reusable policies response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesCreateAnAccessReusablePolicy =
    ///Create an Access reusable policy response.
    | Created of payload: ``accessreusable-policiescomponents-schemas-singleresponse``
    ///Create an Access reusable policy response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesDeleteAnAccessReusablePolicy =
    ///Delete an Access reusable policy response.
    | Accepted of payload: ``accessreusable-policiescomponents-schemas-idresponse``
    ///Delete an Access reusable policy response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesGetAnAccessReusablePolicy =
    ///Get an Access reusable policy response.
    | OK of payload: ``accessreusable-policiescomponents-schemas-singleresponse``
    ///Get an Access reusable policy response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPoliciesUpdateAnAccessReusablePolicy =
    ///Update an Access reusable policy response.
    | OK of payload: ``accessreusable-policiescomponents-schemas-singleresponse``
    ///Update an Access reusable policy response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPolicyTests =
    ///Start Access policy test response.
    | OK of payload: accesspolicyinitresp
    ///Start Access policy test response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPolicyTestsGetAnUpdate =
    ///Get an Access policy test update response.
    | OK of payload: accesspolicyupdateresp
    ///Get an Access policy test update response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessPolicyTestsGetAUserPage =
    ///Get an Access policy tester users page response.
    | OK of payload: accesspolicyusersresp
    ///Get an Access policy tester users page response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustSeatsUpdateAUserSeat =
    ///Update a user seat response
    | OK of payload: ``accessseatscomponents-schemas-responsecollection``
    ///Update a user seat response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessServiceTokensListServiceTokens =
    ///List service tokens response
    | OK of payload: ``accesscomponents-schemas-responsecollection``
    ///List service tokens response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessServiceTokensCreateAServiceToken =
    ///Create a service token response
    | Created of payload: accesscreateresponse
    ///Create a service token response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessServiceTokensDeleteAServiceToken =
    ///Delete a service token response
    | OK of payload: ``accessschemas-singleresponse``
    ///Delete a service token response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessServiceTokensGetAServiceToken =
    ///Get a service token response
    | OK of payload: ``accessschemas-singleresponse``
    ///Get a service token response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessServiceTokensUpdateAServiceToken =
    ///Update a service token response
    | OK of payload: ``accessschemas-singleresponse``
    ///Update a service token response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessServiceTokensRefreshAServiceToken =
    ///Refresh a service token response
    | OK of payload: ``accessschemas-singleresponse``
    ///Refresh a service token response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessServiceTokensRotateAServiceToken =
    ///Rotate a service token response
    | OK of payload: accesscreateresponse
    ///Rotate a service token response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessTagsListTags =
    ///List tags response
    | OK of payload: ``accesstagscomponents-schemas-responsecollection``
    ///List tags response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessTagsCreateTag =
    ///Create a tag response
    | Created of payload: ``accesstagscomponents-schemas-singleresponse``
    ///Create a tag response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessTagsDeleteATag =
    ///Delete a tag response
    | Accepted of payload: accessnameresponse
    ///Delete a tag response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessTagsGetATag =
    ///Get a tag response
    | OK of payload: ``accesstagscomponents-schemas-singleresponse``
    ///Get a tag response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type AccessTagsUpdateATag =
    ///Update a tag response
    | OK of payload: ``accesstagscomponents-schemas-singleresponse``
    ///Update a tag response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersGetUsers =
    ///Get users response
    | OK of payload: ``accessuserscomponents-schemas-responsecollection``
    ///Get users response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersCreateUser =
    ///Create user response
    | Created of payload: accesssingleuserresponse
    ///Create user response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersDeleteUser =
    ///Delete user response
    | Accepted of payload: accessdeleteuserresponse
    ///Delete user response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersGetUser =
    ///Get user response
    | OK of payload: accesssingleuserresponse
    ///Get user response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersUpdateUser =
    ///Update user response
    | OK of payload: accesssingleuserresponse
    ///Update user response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersGetActiveSessions =
    ///Get active sessions response
    | OK of payload: accessactivesessionsresponse
    ///Get active sessions response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersGetActiveSession =
    ///Get active session response
    | OK of payload: accessactivesessionresponse
    ///Get active session response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersGetFailedLogins =
    ///Get failed logins response
    | OK of payload: accessfailedloginresponse
    ///Get failed logins response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersGetLastSeenIdentity =
    ///Get active session response
    | OK of payload: accesslastseenidentityresponse
    ///Get active session response failure
    | BadRequest of payload: ``accessapi-response-common-failure``

[<RequireQualifiedAccess>]
type ZeroTrustUsersDeleteMfaAuthenticator =
    ///Delete authenticator response.
    | OK of payload: accessdeleteauthenticatorresponse
    ///Delete authenticator response failure.
    | BadRequest of payload: ``accessapi-response-common-failure``
