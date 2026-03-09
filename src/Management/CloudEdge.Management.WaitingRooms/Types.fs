namespace rec Fidelity.CloudEdge.Management.WaitingRooms.Types

// Auto-generated type aliases (Hawaii normalization fix)
type waitingroom_create_rule = waitingroomcreaterule

// Auto-generated stub types (missing from Hawaii output)
type results = string

type waitingroomadditionalroutesArrayItem =
    { ///The hostname to which this waiting room will be applied (no wildcards). The hostname must be the primary domain, subdomain, or custom hostname (if using SSL for SaaS) of this zone. Please do not include the scheme (http:// or https://).
      host: Option<string>
      ///Sets the path within the host to enable the waiting room on. The waiting room will be enabled for all subpaths as well. If there are two waiting rooms on the same subpath, the waiting room for the most specific path will be chosen. Wildcards and query parameters are not supported.
      path: Option<string> }
    ///Creates an instance of waitingroomadditionalroutesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomadditionalroutesArrayItem = { host = None; path = None }

type waitingroomadditionalroutes = list<waitingroomadditionalroutesArrayItem>
///Appends a '_' + a custom suffix to the end of Cloudflare Waiting Room's cookie name(__cf_waitingroom). If `cookie_suffix` is "abcd", the cookie name will be `__cf_waitingroom_abcd`. This field is required if using `additional_routes`.
type waitingroomcookiesuffix = string

///Only available for the Waiting Room Advanced subscription. This is a template html file that will be rendered at the edge. If no custom_page_html is provided, the default waiting room will be used. The template is based on mustache ( https://mustache.github.io/ ). There are several variables that are evaluated by the Cloudflare edge:
///1. {{`waitTimeKnown`}} Acts like a boolean value that indicates the behavior to take when wait time is not available, for instance when queue_all is **true**.
///2. {{`waitTimeFormatted`}} Estimated wait time for the user. For example, five minutes. Alternatively, you can use:
///3. {{`waitTime`}} Number of minutes of estimated wait for a user.
///4. {{`waitTimeHours`}} Number of hours of estimated wait for a user (`Math.floor(waitTime/60)`).
///5. {{`waitTimeHourMinutes`}} Number of minutes above the `waitTimeHours` value (`waitTime%60`).
///6. {{`queueIsFull`}} Changes to **true** when no more people can be added to the queue.
///To view the full list of variables, look at the `cfWaitingRoom` object described under the `json_response_enabled` property in other Waiting Room API calls.
type waitingroomcustompagehtml = string

///The language of the default page template. If no default_template_language is provided, then `en-US` (English) will be used.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type waitingroomdefaulttemplatelanguage =
    | [<CompiledName "en-US">] EnUS
    | [<CompiledName "es-ES">] EsES
    | [<CompiledName "de-DE">] DeDE
    | [<CompiledName "fr-FR">] FrFR
    | [<CompiledName "it-IT">] ItIT
    | [<CompiledName "ja-JP">] JaJP
    | [<CompiledName "ko-KR">] KoKR
    | [<CompiledName "pt-BR">] PtBR
    | [<CompiledName "zh-CN">] ZhCN
    | [<CompiledName "zh-TW">] ZhTW
    | [<CompiledName "nl-NL">] NlNL
    | [<CompiledName "pl-PL">] PlPL
    | [<CompiledName "id-ID">] IdID
    | [<CompiledName "tr-TR">] TrTR
    | [<CompiledName "ar-EG">] ArEG
    | [<CompiledName "ru-RU">] RuRU
    | [<CompiledName "fa-IR">] FaIR
    | [<CompiledName "bg-BG">] BgBG
    | [<CompiledName "hr-HR">] HrHR
    | [<CompiledName "cs-CZ">] CsCZ
    | [<CompiledName "da-DK">] DaDK
    | [<CompiledName "fi-FI">] FiFI
    | [<CompiledName "lt-LT">] LtLT
    | [<CompiledName "ms-MY">] MsMY
    | [<CompiledName "nb-NO">] NbNO
    | [<CompiledName "ro-RO">] RoRO
    | [<CompiledName "el-GR">] ElGR
    | [<CompiledName "he-IL">] HeIL
    | [<CompiledName "hi-IN">] HiIN
    | [<CompiledName "hu-HU">] HuHU
    | [<CompiledName "sr-BA">] SrBA
    | [<CompiledName "sk-SK">] SkSK
    | [<CompiledName "sl-SI">] SlSI
    | [<CompiledName "sv-SE">] SvSE
    | [<CompiledName "tl-PH">] TlPH
    | [<CompiledName "th-TH">] ThTH
    | [<CompiledName "uk-UA">] UkUA
    | [<CompiledName "vi-VN">] ViVN
    member this.Format() =
        match this with
        | EnUS -> "en-US"
        | EsES -> "es-ES"
        | DeDE -> "de-DE"
        | FrFR -> "fr-FR"
        | ItIT -> "it-IT"
        | JaJP -> "ja-JP"
        | KoKR -> "ko-KR"
        | PtBR -> "pt-BR"
        | ZhCN -> "zh-CN"
        | ZhTW -> "zh-TW"
        | NlNL -> "nl-NL"
        | PlPL -> "pl-PL"
        | IdID -> "id-ID"
        | TrTR -> "tr-TR"
        | ArEG -> "ar-EG"
        | RuRU -> "ru-RU"
        | FaIR -> "fa-IR"
        | BgBG -> "bg-BG"
        | HrHR -> "hr-HR"
        | CsCZ -> "cs-CZ"
        | DaDK -> "da-DK"
        | FiFI -> "fi-FI"
        | LtLT -> "lt-LT"
        | MsMY -> "ms-MY"
        | NbNO -> "nb-NO"
        | RoRO -> "ro-RO"
        | ElGR -> "el-GR"
        | HeIL -> "he-IL"
        | HiIN -> "hi-IN"
        | HuHU -> "hu-HU"
        | SrBA -> "sr-BA"
        | SkSK -> "sk-SK"
        | SlSI -> "sl-SI"
        | SvSE -> "sv-SE"
        | TlPH -> "tl-PH"
        | ThTH -> "th-TH"
        | UkUA -> "uk-UA"
        | ViVN -> "vi-VN"

///A note that you can use to add more details about the waiting room.
type waitingroomdescription = string
type waitingroomdisablesessionrenewal = bool

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnumForwaitingroomenabledorigincommands =
    | [<CompiledName "revoke">] Revoke
    member this.Format() =
        match this with
        | Revoke -> "revoke"

type waitingroomenabledorigincommands = list<EnumForwaitingroomenabledorigincommands>
type waitingroomestimatedqueuedusers = int
type waitingroomestimatedtotalactiveusers = int
///If set, the event will override the waiting room's `custom_page_html` property while it is active. If null, the event will inherit it.
type waitingroomeventcustompagehtml = string
///A note that you can use to add more details about the event.
type waitingroomeventdescription = string
type waitingroomeventdetailscustompagehtml = string
type waitingroomeventdetailsdisablesessionrenewal = bool
type waitingroomeventdetailsnewusersperminute = int
type waitingroomeventdetailsqueueingmethod = string
type waitingroomeventdetailssessionduration = int
type waitingroomeventdetailstotalactiveusers = int
type waitingroomeventdisablesessionrenewal = bool
///An ISO 8601 timestamp that marks the end of the event.
type waitingroomeventendtime = string
type waitingroomeventid = string
///A unique name to identify the event. Only alphanumeric characters, hyphens and underscores are allowed.
type waitingroomeventname = string
type waitingroomeventnewusersperminute = int
///An ISO 8601 timestamp that marks when to begin queueing all users before the event starts. The prequeue must start at least five minutes before `event_start_time`.
type waitingroomeventprequeuestarttime = string
///If set, the event will override the waiting room's `queueing_method` property while it is active. If null, the event will inherit it.
type waitingroomeventqueueingmethod = string
type waitingroomeventsessionduration = int
type waitingroomeventshuffleateventstart = bool
///An ISO 8601 timestamp that marks the start of the event. At this time, queued users will be processed with the event's configuration. The start time must be at least one minute before `event_end_time`.
type waitingroomeventstarttime = string
type waitingroomeventsuspended = bool
type waitingroomeventtotalactiveusers = int

///If set, the event will override the waiting room's `turnstile_action` property while it is active. If null, the event will inherit it.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type waitingroomeventturnstileaction =
    | [<CompiledName "log">] Log
    | [<CompiledName "infinite_queue">] Infinite_queue
    member this.Format() =
        match this with
        | Log -> "log"
        | Infinite_queue -> "infinite_queue"

///If set, the event will override the waiting room's `turnstile_mode` property while it is active. If null, the event will inherit it.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type waitingroomeventturnstilemode =
    | [<CompiledName "off">] Off
    | [<CompiledName "invisible">] Invisible
    | [<CompiledName "visible_non_interactive">] Visible_non_interactive
    | [<CompiledName "visible_managed">] Visible_managed
    member this.Format() =
        match this with
        | Off -> "off"
        | Invisible -> "invisible"
        | Visible_non_interactive -> "visible_non_interactive"
        | Visible_managed -> "visible_managed"

///The host name to which the waiting room will be applied (no wildcards). Please do not include the scheme (http:// or https://). The host and path combination must be unique.
type waitingroomhost = string
///Identifier.
type waitingroomidentifier = string
type waitingroomjsonresponseenabled = bool
type waitingroommaxestimatedtimeminutes = int

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type waitingroommessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of waitingroommessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): waitingroommessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type waitingroommessages = list<waitingroommessagesArrayItem>
///A unique name to identify the waiting room. Only alphanumeric characters, hyphens and underscores are allowed.
type waitingroomname = string
type waitingroomnewusersperminute = int
///An ISO 8601 timestamp that marks when the next event will begin queueing.
type waitingroomnexteventprequeuestarttime = string
///An ISO 8601 timestamp that marks when the next event will start.
type waitingroomnexteventstarttime = string
///Sets the path within the host to enable the waiting room on. The waiting room will be enabled for all subpaths as well. If there are two waiting rooms on the same subpath, the waiting room for the most specific path will be chosen. Wildcards and query parameters are not supported.
type waitingroompath = string
///URL where the custom waiting room page can temporarily be previewed.
type waitingroompreviewurl = string
type waitingroomqueueall = bool

///Sets the queueing method used by the waiting room. Changing this parameter from the **default** queueing method is only available for the Waiting Room Advanced subscription. Regardless of the queueing method, if `queue_all` is enabled or an event is prequeueing, users in the waiting room will not be accepted to the origin. These users will always see a waiting room page that refreshes automatically. The valid queueing methods are:
///1. `fifo` **(default)**: First-In-First-Out queue where customers gain access in the order they arrived.
///2. `random`: Random queue where customers gain access randomly, regardless of arrival time.
///3. `passthrough`: Users will pass directly through the waiting room and into the origin website. As a result, any configured limits will not be respected while this is enabled. This method can be used as an alternative to disabling a waiting room (with `suspended`) so that analytics are still reported. This can be used if you wish to allow all traffic normally, but want to restrict traffic during a waiting room event, or vice versa.
///4. `reject`: Users will be immediately rejected from the waiting room. As a result, no users will reach the origin website while this is enabled. This can be used if you wish to reject all traffic while performing maintenance, block traffic during a specified period of time (an event), or block traffic while events are not occurring. Consider a waiting room used for vaccine distribution that only allows traffic during sign-up events, and otherwise blocks all traffic. For this case, the waiting room uses `reject`, and its events override this with `fifo`, `random`, or `passthrough`. When this queueing method is enabled and neither `queueAll` is enabled nor an event is prequeueing, the waiting room page **will not refresh automatically**.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type waitingroomqueueingmethod =
    | [<CompiledName "fifo">] Fifo
    | [<CompiledName "random">] Random
    | [<CompiledName "passthrough">] Passthrough
    | [<CompiledName "reject">] Reject
    member this.Format() =
        match this with
        | Fifo -> "fifo"
        | Random -> "random"
        | Passthrough -> "passthrough"
        | Reject -> "reject"

[<RequireQualifiedAccess>]
type waitingroomqueueingstatuscode =
    | Waitingroomqueueingstatuscode200 = 200
    | Waitingroomqueueingstatuscode202 = 202
    | Waitingroomqueueingstatuscode429 = 429

///The action to take when the expression matches.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type waitingroomruleaction =
    | [<CompiledName "bypass_waiting_room">] Bypass_waiting_room
    member this.Format() =
        match this with
        | Bypass_waiting_room -> "bypass_waiting_room"

///The description of the rule.
type waitingroomruledescription = string
type waitingroomruleenabled = bool
///Criteria defining when there is a match for the current rule.
type waitingroomruleexpression = string
///The ID of the rule.
type waitingroomruleid = string
///The version of the rule.
type waitingroomruleversion = string
type waitingroomsearchenginecrawlerbypass = bool
type waitingroomsessionduration = int

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type waitingroomstatus =
    | [<CompiledName "event_prequeueing">] Event_prequeueing
    | [<CompiledName "not_queueing">] Not_queueing
    | [<CompiledName "queueing">] Queueing
    | [<CompiledName "suspended">] Suspended
    member this.Format() =
        match this with
        | Event_prequeueing -> "event_prequeueing"
        | Not_queueing -> "not_queueing"
        | Queueing -> "queueing"
        | Suspended -> "suspended"

type waitingroomstatuseventid = string
type waitingroomsuspended = bool
type waitingroomtimestamp = System.DateTimeOffset
type waitingroomtotalactiveusers = int

///Which action to take when a bot is detected using Turnstile. `log` will
///have no impact on queueing behavior, simply keeping track of how many
///bots are detected in Waiting Room Analytics. `infinite_queue` will send
///bots to a false queueing state, where they will never reach your
///origin. `infinite_queue` requires Advanced Waiting Room.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type waitingroomturnstileaction =
    | [<CompiledName "log">] Log
    | [<CompiledName "infinite_queue">] Infinite_queue
    member this.Format() =
        match this with
        | Log -> "log"
        | Infinite_queue -> "infinite_queue"

///Which Turnstile widget type to use for detecting bot traffic. See
///[the Turnstile documentation](https://developers.cloudflare.com/turnstile/concepts/widget/#widget-types)
///for the definitions of these widget types. Set to `off` to disable the
///Turnstile integration entirely. Setting this to anything other than
///`off` or `invisible` requires Advanced Waiting Room.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type waitingroomturnstilemode =
    | [<CompiledName "off">] Off
    | [<CompiledName "invisible">] Invisible
    | [<CompiledName "visible_non_interactive">] Visible_non_interactive
    | [<CompiledName "visible_managed">] Visible_managed
    member this.Format() =
        match this with
        | Off -> "off"
        | Invisible -> "invisible"
        | Visible_non_interactive -> "visible_non_interactive"
        | Visible_managed -> "visible_managed"

type waitingroomupdaterules = list<waitingroom_create_rule>
type waitingroomwaitingroomid = string

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

type ``waitingroomapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<Resultinfo> }
    ///Creates an instance of waitingroomapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``waitingroomapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``waitingroomapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of waitingroomapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``waitingroomapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``waitingroomapi-response-single`` =
    { result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of waitingroomapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``waitingroomapi-response-single`` = { result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Samesite =
    | [<CompiledName "auto">] Auto
    | [<CompiledName "lax">] Lax
    | [<CompiledName "none">] None
    | [<CompiledName "strict">] Strict
    member this.Format() =
        match this with
        | Auto -> "auto"
        | Lax -> "lax"
        | None -> "none"
        | Strict -> "strict"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Secure =
    | [<CompiledName "auto">] Auto
    | [<CompiledName "always">] Always
    | [<CompiledName "never">] Never
    member this.Format() =
        match this with
        | Auto -> "auto"
        | Always -> "always"
        | Never -> "never"

///Configures cookie attributes for the waiting room cookie. This encrypted cookie stores a user's status in the waiting room, such as queue position.
type waitingroomcookieattributes =
    { ///Configures the SameSite attribute on the waiting room cookie. Value `auto` will be translated to `lax` or `none` depending if **Always Use HTTPS** is enabled. Note that when using value `none`, the secure attribute cannot be set to `never`.
      samesite: Option<Samesite>
      ///Configures the Secure attribute on the waiting room cookie. Value `always` indicates that the Secure attribute will be set in the Set-Cookie header, `never` indicates that the Secure attribute will not be set, and `auto` will set the Secure attribute depending if **Always Use HTTPS** is enabled.
      secure: Option<Secure> }
    ///Creates an instance of waitingroomcookieattributes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomcookieattributes = { samesite = None; secure = None }

type waitingroomcreaterule =
    { ///The action to take when the expression matches.
      action: waitingroomruleaction
      ///The description of the rule.
      description: Option<waitingroomruledescription>
      ///When set to true, the rule is enabled.
      enabled: Option<waitingroomruleenabled>
      ///Criteria defining when there is a match for the current rule.
      expression: waitingroomruleexpression }
    ///Creates an instance of waitingroomcreaterule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: waitingroomruleaction, expression: waitingroomruleexpression): waitingroomcreaterule =
        { action = action
          description = None
          enabled = None
          expression = expression }

type waitingroomeventdetailsresponse =
    { result: waitingroomeventdetailsresult }
    ///Creates an instance of waitingroomeventdetailsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (result: waitingroomeventdetailsresult): waitingroomeventdetailsresponse = { result = result }

type waitingroomeventdetailsresult =
    { created_on: Option<waitingroomtimestamp>
      custom_page_html: Option<waitingroomeventdetailscustompagehtml>
      ///A note that you can use to add more details about the event.
      description: Option<waitingroomeventdescription>
      disable_session_renewal: Option<waitingroomeventdetailsdisablesessionrenewal>
      ///An ISO 8601 timestamp that marks the end of the event.
      event_end_time: Option<waitingroomeventendtime>
      ///An ISO 8601 timestamp that marks the start of the event. At this time, queued users will be processed with the event's configuration. The start time must be at least one minute before `event_end_time`.
      event_start_time: Option<waitingroomeventstarttime>
      id: Option<waitingroomeventid>
      modified_on: Option<waitingroomtimestamp>
      ///A unique name to identify the event. Only alphanumeric characters, hyphens and underscores are allowed.
      name: Option<waitingroomeventname>
      new_users_per_minute: Option<waitingroomeventdetailsnewusersperminute>
      ///An ISO 8601 timestamp that marks when to begin queueing all users before the event starts. The prequeue must start at least five minutes before `event_start_time`.
      prequeue_start_time: Option<waitingroomeventprequeuestarttime>
      queueing_method: Option<waitingroomeventdetailsqueueingmethod>
      session_duration: Option<waitingroomeventdetailssessionduration>
      ///If enabled, users in the prequeue will be shuffled randomly at the `event_start_time`. Requires that `prequeue_start_time` is not null. This is useful for situations when many users will join the event prequeue at the same time and you want to shuffle them to ensure fairness. Naturally, it makes the most sense to enable this feature when the `queueing_method` during the event respects ordering such as **fifo**, or else the shuffling may be unnecessary.
      shuffle_at_event_start: Option<waitingroomeventshuffleateventstart>
      ///Suspends or allows an event. If set to `true`, the event is ignored and traffic will be handled based on the waiting room configuration.
      suspended: Option<waitingroomeventsuspended>
      total_active_users: Option<waitingroomeventdetailstotalactiveusers> }
    ///Creates an instance of waitingroomeventdetailsresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomeventdetailsresult =
        { created_on = None
          custom_page_html = None
          description = None
          disable_session_renewal = None
          event_end_time = None
          event_start_time = None
          id = None
          modified_on = None
          name = None
          new_users_per_minute = None
          prequeue_start_time = None
          queueing_method = None
          session_duration = None
          shuffle_at_event_start = None
          suspended = None
          total_active_users = None }

type Result =
    { id: Option<waitingroomeventid> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result = { id = None }

type waitingroomeventidresponse =
    { result: Result }
    ///Creates an instance of waitingroomeventidresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (result: Result): waitingroomeventidresponse = { result = result }

type waitingroomeventresponse =
    { result: waitingroomeventresult }
    ///Creates an instance of waitingroomeventresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (result: waitingroomeventresult): waitingroomeventresponse = { result = result }

type waitingroomeventresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of waitingroomeventresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomeventresponsecollectionErrorsSource = { pointer = None }

type waitingroomeventresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<waitingroomeventresponsecollectionErrorsSource> }
    ///Creates an instance of waitingroomeventresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): waitingroomeventresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type waitingroomeventresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of waitingroomeventresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomeventresponsecollectionMessagesSource = { pointer = None }

type waitingroomeventresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<waitingroomeventresponsecollectionMessagesSource> }
    ///Creates an instance of waitingroomeventresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): waitingroomeventresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type waitingroomeventresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of waitingroomeventresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomeventresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type waitingroomeventresponsecollection =
    { errors: list<waitingroomeventresponsecollectionErrors>
      messages: list<waitingroomeventresponsecollectionMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<waitingroomeventresponsecollectionResultinfo>
      result: Option<list<waitingroomeventresult>> }
    ///Creates an instance of waitingroomeventresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<waitingroomeventresponsecollectionErrors>,
                          messages: list<waitingroomeventresponsecollectionMessages>,
                          success: bool): waitingroomeventresponsecollection =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type waitingroomeventresult =
    { created_on: Option<waitingroomtimestamp>
      ///If set, the event will override the waiting room's `custom_page_html` property while it is active. If null, the event will inherit it.
      custom_page_html: Option<waitingroomeventcustompagehtml>
      ///A note that you can use to add more details about the event.
      description: Option<waitingroomeventdescription>
      ///If set, the event will override the waiting room's `disable_session_renewal` property while it is active. If null, the event will inherit it.
      disable_session_renewal: Option<waitingroomeventdisablesessionrenewal>
      ///An ISO 8601 timestamp that marks the end of the event.
      event_end_time: Option<waitingroomeventendtime>
      ///An ISO 8601 timestamp that marks the start of the event. At this time, queued users will be processed with the event's configuration. The start time must be at least one minute before `event_end_time`.
      event_start_time: Option<waitingroomeventstarttime>
      id: Option<waitingroomeventid>
      modified_on: Option<waitingroomtimestamp>
      ///A unique name to identify the event. Only alphanumeric characters, hyphens and underscores are allowed.
      name: Option<waitingroomeventname>
      ///If set, the event will override the waiting room's `new_users_per_minute` property while it is active. If null, the event will inherit it. This can only be set if the event's `total_active_users` property is also set.
      new_users_per_minute: Option<waitingroomeventnewusersperminute>
      ///An ISO 8601 timestamp that marks when to begin queueing all users before the event starts. The prequeue must start at least five minutes before `event_start_time`.
      prequeue_start_time: Option<waitingroomeventprequeuestarttime>
      ///If set, the event will override the waiting room's `queueing_method` property while it is active. If null, the event will inherit it.
      queueing_method: Option<waitingroomeventqueueingmethod>
      ///If set, the event will override the waiting room's `session_duration` property while it is active. If null, the event will inherit it.
      session_duration: Option<waitingroomeventsessionduration>
      ///If enabled, users in the prequeue will be shuffled randomly at the `event_start_time`. Requires that `prequeue_start_time` is not null. This is useful for situations when many users will join the event prequeue at the same time and you want to shuffle them to ensure fairness. Naturally, it makes the most sense to enable this feature when the `queueing_method` during the event respects ordering such as **fifo**, or else the shuffling may be unnecessary.
      shuffle_at_event_start: Option<waitingroomeventshuffleateventstart>
      ///Suspends or allows an event. If set to `true`, the event is ignored and traffic will be handled based on the waiting room configuration.
      suspended: Option<waitingroomeventsuspended>
      ///If set, the event will override the waiting room's `total_active_users` property while it is active. If null, the event will inherit it. This can only be set if the event's `new_users_per_minute` property is also set.
      total_active_users: Option<waitingroomeventtotalactiveusers>
      ///If set, the event will override the waiting room's `turnstile_action` property while it is active. If null, the event will inherit it.
      turnstile_action: Option<waitingroomeventturnstileaction>
      ///If set, the event will override the waiting room's `turnstile_mode` property while it is active. If null, the event will inherit it.
      turnstile_mode: Option<waitingroomeventturnstilemode> }
    ///Creates an instance of waitingroomeventresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomeventresult =
        { created_on = None
          custom_page_html = None
          description = None
          disable_session_renewal = None
          event_end_time = None
          event_start_time = None
          id = None
          modified_on = None
          name = None
          new_users_per_minute = None
          prequeue_start_time = None
          queueing_method = None
          session_duration = None
          shuffle_at_event_start = None
          suspended = None
          total_active_users = None
          turnstile_action = None
          turnstile_mode = None }

type waitingroompatchrule =
    { ///The action to take when the expression matches.
      action: waitingroomruleaction
      ///The description of the rule.
      description: Option<waitingroomruledescription>
      ///When set to true, the rule is enabled.
      enabled: Option<waitingroomruleenabled>
      ///Criteria defining when there is a match for the current rule.
      expression: waitingroomruleexpression
      ///Reorder the position of a rule
      position: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of waitingroompatchrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: waitingroomruleaction, expression: waitingroomruleexpression): waitingroompatchrule =
        { action = action
          description = None
          enabled = None
          expression = expression
          position = None }

type waitingroompreviewresponseResult =
    { ///URL where the custom waiting room page can temporarily be previewed.
      preview_url: Option<waitingroompreviewurl> }
    ///Creates an instance of waitingroompreviewresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroompreviewresponseResult = { preview_url = None }

type waitingroompreviewresponse =
    { result: waitingroompreviewresponseResult }
    ///Creates an instance of waitingroompreviewresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (result: waitingroompreviewresponseResult): waitingroompreviewresponse = { result = result }

type waitingroomqueryevent =
    { ///If set, the event will override the waiting room's `custom_page_html` property while it is active. If null, the event will inherit it.
      custom_page_html: Option<waitingroomeventcustompagehtml>
      ///A note that you can use to add more details about the event.
      description: Option<waitingroomeventdescription>
      ///If set, the event will override the waiting room's `disable_session_renewal` property while it is active. If null, the event will inherit it.
      disable_session_renewal: Option<waitingroomeventdisablesessionrenewal>
      ///An ISO 8601 timestamp that marks the end of the event.
      event_end_time: waitingroomeventendtime
      ///An ISO 8601 timestamp that marks the start of the event. At this time, queued users will be processed with the event's configuration. The start time must be at least one minute before `event_end_time`.
      event_start_time: waitingroomeventstarttime
      ///A unique name to identify the event. Only alphanumeric characters, hyphens and underscores are allowed.
      name: waitingroomeventname
      ///If set, the event will override the waiting room's `new_users_per_minute` property while it is active. If null, the event will inherit it. This can only be set if the event's `total_active_users` property is also set.
      new_users_per_minute: Option<waitingroomeventnewusersperminute>
      ///An ISO 8601 timestamp that marks when to begin queueing all users before the event starts. The prequeue must start at least five minutes before `event_start_time`.
      prequeue_start_time: Option<waitingroomeventprequeuestarttime>
      ///If set, the event will override the waiting room's `queueing_method` property while it is active. If null, the event will inherit it.
      queueing_method: Option<waitingroomeventqueueingmethod>
      ///If set, the event will override the waiting room's `session_duration` property while it is active. If null, the event will inherit it.
      session_duration: Option<waitingroomeventsessionduration>
      ///If enabled, users in the prequeue will be shuffled randomly at the `event_start_time`. Requires that `prequeue_start_time` is not null. This is useful for situations when many users will join the event prequeue at the same time and you want to shuffle them to ensure fairness. Naturally, it makes the most sense to enable this feature when the `queueing_method` during the event respects ordering such as **fifo**, or else the shuffling may be unnecessary.
      shuffle_at_event_start: Option<waitingroomeventshuffleateventstart>
      ///Suspends or allows an event. If set to `true`, the event is ignored and traffic will be handled based on the waiting room configuration.
      suspended: Option<waitingroomeventsuspended>
      ///If set, the event will override the waiting room's `total_active_users` property while it is active. If null, the event will inherit it. This can only be set if the event's `new_users_per_minute` property is also set.
      total_active_users: Option<waitingroomeventtotalactiveusers>
      ///If set, the event will override the waiting room's `turnstile_action` property while it is active. If null, the event will inherit it.
      turnstile_action: Option<waitingroomeventturnstileaction>
      ///If set, the event will override the waiting room's `turnstile_mode` property while it is active. If null, the event will inherit it.
      turnstile_mode: Option<waitingroomeventturnstilemode> }
    ///Creates an instance of waitingroomqueryevent with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (event_end_time: waitingroomeventendtime,
                          event_start_time: waitingroomeventstarttime,
                          name: waitingroomeventname): waitingroomqueryevent =
        { custom_page_html = None
          description = None
          disable_session_renewal = None
          event_end_time = event_end_time
          event_start_time = event_start_time
          name = name
          new_users_per_minute = None
          prequeue_start_time = None
          queueing_method = None
          session_duration = None
          shuffle_at_event_start = None
          suspended = None
          total_active_users = None
          turnstile_action = None
          turnstile_mode = None }

type waitingroomquerypreview =
    { ///Only available for the Waiting Room Advanced subscription. This is a template html file that will be rendered at the edge. If no custom_page_html is provided, the default waiting room will be used. The template is based on mustache ( https://mustache.github.io/ ). There are several variables that are evaluated by the Cloudflare edge:
      ///1. {{`waitTimeKnown`}} Acts like a boolean value that indicates the behavior to take when wait time is not available, for instance when queue_all is **true**.
      ///2. {{`waitTimeFormatted`}} Estimated wait time for the user. For example, five minutes. Alternatively, you can use:
      ///3. {{`waitTime`}} Number of minutes of estimated wait for a user.
      ///4. {{`waitTimeHours`}} Number of hours of estimated wait for a user (`Math.floor(waitTime/60)`).
      ///5. {{`waitTimeHourMinutes`}} Number of minutes above the `waitTimeHours` value (`waitTime%60`).
      ///6. {{`queueIsFull`}} Changes to **true** when no more people can be added to the queue.
      ///To view the full list of variables, look at the `cfWaitingRoom` object described under the `json_response_enabled` property in other Waiting Room API calls.
      custom_html: waitingroomcustompagehtml }
    ///Creates an instance of waitingroomquerypreview with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (custom_html: waitingroomcustompagehtml): waitingroomquerypreview =
        { custom_html = custom_html }

type Additionalroutes =
    { ///The hostname to which this waiting room will be applied (no wildcards). The hostname must be the primary domain, subdomain, or custom hostname (if using SSL for SaaS) of this zone. Please do not include the scheme (http:// or https://).
      host: Option<string>
      ///Sets the path within the host to enable the waiting room on. The waiting room will be enabled for all subpaths as well. If there are two waiting rooms on the same subpath, the waiting room for the most specific path will be chosen. Wildcards and query parameters are not supported.
      path: Option<string> }
    ///Creates an instance of Additionalroutes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Additionalroutes = { host = None; path = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Enabled_origin_commands =
    | [<CompiledName "revoke">] Revoke
    member this.Format() =
        match this with
        | Revoke -> "revoke"

type waitingroomquerywaitingroom =
    { ///Only available for the Waiting Room Advanced subscription. Additional hostname and path combinations to which this waiting room will be applied. There is an implied wildcard at the end of the path. The hostname and path combination must be unique to this and all other waiting rooms.
      additional_routes: Option<list<Additionalroutes>>
      ///Configures cookie attributes for the waiting room cookie. This encrypted cookie stores a user's status in the waiting room, such as queue position.
      cookie_attributes: Option<waitingroomcookieattributes>
      ///Appends a '_' + a custom suffix to the end of Cloudflare Waiting Room's cookie name(__cf_waitingroom). If `cookie_suffix` is "abcd", the cookie name will be `__cf_waitingroom_abcd`. This field is required if using `additional_routes`.
      cookie_suffix: Option<waitingroomcookiesuffix>
      ///Only available for the Waiting Room Advanced subscription. This is a template html file that will be rendered at the edge. If no custom_page_html is provided, the default waiting room will be used. The template is based on mustache ( https://mustache.github.io/ ). There are several variables that are evaluated by the Cloudflare edge:
      ///1. {{`waitTimeKnown`}} Acts like a boolean value that indicates the behavior to take when wait time is not available, for instance when queue_all is **true**.
      ///2. {{`waitTimeFormatted`}} Estimated wait time for the user. For example, five minutes. Alternatively, you can use:
      ///3. {{`waitTime`}} Number of minutes of estimated wait for a user.
      ///4. {{`waitTimeHours`}} Number of hours of estimated wait for a user (`Math.floor(waitTime/60)`).
      ///5. {{`waitTimeHourMinutes`}} Number of minutes above the `waitTimeHours` value (`waitTime%60`).
      ///6. {{`queueIsFull`}} Changes to **true** when no more people can be added to the queue.
      ///To view the full list of variables, look at the `cfWaitingRoom` object described under the `json_response_enabled` property in other Waiting Room API calls.
      custom_page_html: Option<waitingroomcustompagehtml>
      ///The language of the default page template. If no default_template_language is provided, then `en-US` (English) will be used.
      default_template_language: Option<waitingroomdefaulttemplatelanguage>
      ///A note that you can use to add more details about the waiting room.
      description: Option<waitingroomdescription>
      ///Only available for the Waiting Room Advanced subscription. Disables automatic renewal of session cookies. If `true`, an accepted user will have session_duration minutes to browse the site. After that, they will have to go through the waiting room again. If `false`, a user's session cookie will be automatically renewed on every request.
      disable_session_renewal: Option<waitingroomdisablesessionrenewal>
      ///A list of enabled origin commands.
      enabled_origin_commands: Option<list<Enabled_origin_commands>>
      ///The host name to which the waiting room will be applied (no wildcards). Please do not include the scheme (http:// or https://). The host and path combination must be unique.
      host: waitingroomhost
      ///Only available for the Waiting Room Advanced subscription. If `true`, requests to the waiting room with the header `Accept: application/json` will receive a JSON response object with information on the user's status in the waiting room as opposed to the configured static HTML page. This JSON response object has one property `cfWaitingRoom` which is an object containing the following fields:
      ///1. `inWaitingRoom`: Boolean indicating if the user is in the waiting room (always **true**).
      ///2. `waitTimeKnown`: Boolean indicating if the current estimated wait times are accurate. If **false**, they are not available.
      ///3. `waitTime`: Valid only when `waitTimeKnown` is **true**. Integer indicating the current estimated time in minutes the user will wait in the waiting room. When `queueingMethod` is **random**, this is set to `waitTime50Percentile`.
      ///4. `waitTime25Percentile`: Valid only when `queueingMethod` is **random** and `waitTimeKnown` is **true**. Integer indicating the current estimated maximum wait time for the 25% of users that gain entry the fastest (25th percentile).
      ///5. `waitTime50Percentile`: Valid only when `queueingMethod` is **random** and `waitTimeKnown` is **true**. Integer indicating the current estimated maximum wait time for the 50% of users that gain entry the fastest (50th percentile). In other words, half of the queued users are expected to let into the origin website before `waitTime50Percentile` and half are expected to be let in after it.
      ///6. `waitTime75Percentile`: Valid only when `queueingMethod` is **random** and `waitTimeKnown` is **true**. Integer indicating the current estimated maximum wait time for the 75% of users that gain entry the fastest (75th percentile).
      ///7. `waitTimeFormatted`: String displaying the `waitTime` formatted in English for users. If `waitTimeKnown` is **false**, `waitTimeFormatted` will display **unavailable**.
      ///8. `queueIsFull`: Boolean indicating if the waiting room's queue is currently full and not accepting new users at the moment.
      ///9. `queueAll`: Boolean indicating if all users will be queued in the waiting room and no one will be let into the origin website.
      ///10. `lastUpdated`: String displaying the timestamp as an ISO 8601 string of the user's last attempt to leave the waiting room and be let into the origin website. The user is able to make another attempt after `refreshIntervalSeconds` past this time. If the user makes a request too soon, it will be ignored and `lastUpdated` will not change.
      ///11. `refreshIntervalSeconds`: Integer indicating the number of seconds after `lastUpdated` until the user is able to make another attempt to leave the waiting room and be let into the origin website. When the `queueingMethod` is `reject`, there is no specified refresh time —\_it will always be **zero**.
      ///12. `queueingMethod`: The queueing method currently used by the waiting room. It is either **fifo**, **random**, **passthrough**, or **reject**.
      ///13. `isFIFOQueue`: Boolean indicating if the waiting room uses a FIFO (First-In-First-Out) queue.
      ///14. `isRandomQueue`: Boolean indicating if the waiting room uses a Random queue where users gain access randomly.
      ///15. `isPassthroughQueue`: Boolean indicating if the waiting room uses a passthrough queue. Keep in mind that when passthrough is enabled, this JSON response will only exist when `queueAll` is **true** or `isEventPrequeueing` is **true** because in all other cases requests will go directly to the origin.
      ///16. `isRejectQueue`: Boolean indicating if the waiting room uses a reject queue.
      ///17. `isEventActive`: Boolean indicating if an event is currently occurring. Events are able to change a waiting room's behavior during a specified period of time. For additional information, look at the event properties `prequeue_start_time`, `event_start_time`, and `event_end_time` in the documentation for creating waiting room events. Events are considered active between these start and end times, as well as during the prequeueing period if it exists.
      ///18. `isEventPrequeueing`: Valid only when `isEventActive` is **true**. Boolean indicating if an event is currently prequeueing users before it starts.
      ///19. `timeUntilEventStart`: Valid only when `isEventPrequeueing` is **true**. Integer indicating the number of minutes until the event starts.
      ///20. `timeUntilEventStartFormatted`: String displaying the `timeUntilEventStart` formatted in English for users. If `isEventPrequeueing` is **false**, `timeUntilEventStartFormatted` will display **unavailable**.
      ///21. `timeUntilEventEnd`: Valid only when `isEventActive` is **true**. Integer indicating the number of minutes until the event ends.
      ///22. `timeUntilEventEndFormatted`: String displaying the `timeUntilEventEnd` formatted in English for users. If `isEventActive` is **false**, `timeUntilEventEndFormatted` will display **unavailable**.
      ///23. `shuffleAtEventStart`: Valid only when `isEventActive` is **true**. Boolean indicating if the users in the prequeue are shuffled randomly when the event starts.
      ///24. `turnstile`: Empty when turnstile isn't enabled. String displaying an html tag to display the Turnstile widget. Please add the `{{{turnstile}}}` tag to the `custom_html` template to ensure the Turnstile widget appears.
      ///25. `infiniteQueue`: Boolean indicating whether the response is for a user in the infinite queue.
      ///An example cURL to a waiting room could be:
      ///	curl -X GET "https://example.com/waitingroom" \
      ///		-H "Accept: application/json"
      ///If `json_response_enabled` is **true** and the request hits the waiting room, an example JSON response when `queueingMethod` is **fifo** and no event is active could be:
      ///	{
      ///		"cfWaitingRoom": {
      ///			"inWaitingRoom": true,
      ///			"waitTimeKnown": true,
      ///			"waitTime": 10,
      ///			"waitTime25Percentile": 0,
      ///			"waitTime50Percentile": 0,
      ///			"waitTime75Percentile": 0,
      ///			"waitTimeFormatted": "10 minutes",
      ///			"queueIsFull": false,
      ///			"queueAll": false,
      ///			"lastUpdated": "2020-08-03T23:46:00.000Z",
      ///			"refreshIntervalSeconds": 20,
      ///			"queueingMethod": "fifo",
      ///			"isFIFOQueue": true,
      ///			"isRandomQueue": false,
      ///			"isPassthroughQueue": false,
      ///			"isRejectQueue": false,
      ///			"isEventActive": false,
      ///			"isEventPrequeueing": false,
      ///			"timeUntilEventStart": 0,
      ///			"timeUntilEventStartFormatted": "unavailable",
      ///			"timeUntilEventEnd": 0,
      ///			"timeUntilEventEndFormatted": "unavailable",
      ///			"shuffleAtEventStart": false
      ///		}
      ///	}
      ///If `json_response_enabled` is **true** and the request hits the waiting room, an example JSON response when `queueingMethod` is **random** and an event is active could be:
      ///	{
      ///		"cfWaitingRoom": {
      ///			"inWaitingRoom": true,
      ///			"waitTimeKnown": true,
      ///			"waitTime": 10,
      ///			"waitTime25Percentile": 5,
      ///			"waitTime50Percentile": 10,
      ///			"waitTime75Percentile": 15,
      ///			"waitTimeFormatted": "5 minutes to 15 minutes",
      ///			"queueIsFull": false,
      ///			"queueAll": false,
      ///			"lastUpdated": "2020-08-03T23:46:00.000Z",
      ///			"refreshIntervalSeconds": 20,
      ///			"queueingMethod": "random",
      ///			"isFIFOQueue": false,
      ///			"isRandomQueue": true,
      ///			"isPassthroughQueue": false,
      ///			"isRejectQueue": false,
      ///			"isEventActive": true,
      ///			"isEventPrequeueing": false,
      ///			"timeUntilEventStart": 0,
      ///			"timeUntilEventStartFormatted": "unavailable",
      ///			"timeUntilEventEnd": 15,
      ///			"timeUntilEventEndFormatted": "15 minutes",
      ///			"shuffleAtEventStart": true
      ///		}
      ///	}
      json_response_enabled: Option<waitingroomjsonresponseenabled>
      ///A unique name to identify the waiting room. Only alphanumeric characters, hyphens and underscores are allowed.
      name: waitingroomname
      ///Sets the number of new users that will be let into the route every minute. This value is used as baseline for the number of users that are let in per minute. So it is possible that there is a little more or little less traffic coming to the route based on the traffic patterns at that time around the world.
      new_users_per_minute: waitingroomnewusersperminute
      ///Sets the path within the host to enable the waiting room on. The waiting room will be enabled for all subpaths as well. If there are two waiting rooms on the same subpath, the waiting room for the most specific path will be chosen. Wildcards and query parameters are not supported.
      path: Option<waitingroompath>
      ///If queue_all is `true`, all the traffic that is coming to a route will be sent to the waiting room. No new traffic can get to the route once this field is set and estimated time will become unavailable.
      queue_all: Option<waitingroomqueueall>
      ///Sets the queueing method used by the waiting room. Changing this parameter from the **default** queueing method is only available for the Waiting Room Advanced subscription. Regardless of the queueing method, if `queue_all` is enabled or an event is prequeueing, users in the waiting room will not be accepted to the origin. These users will always see a waiting room page that refreshes automatically. The valid queueing methods are:
      ///1. `fifo` **(default)**: First-In-First-Out queue where customers gain access in the order they arrived.
      ///2. `random`: Random queue where customers gain access randomly, regardless of arrival time.
      ///3. `passthrough`: Users will pass directly through the waiting room and into the origin website. As a result, any configured limits will not be respected while this is enabled. This method can be used as an alternative to disabling a waiting room (with `suspended`) so that analytics are still reported. This can be used if you wish to allow all traffic normally, but want to restrict traffic during a waiting room event, or vice versa.
      ///4. `reject`: Users will be immediately rejected from the waiting room. As a result, no users will reach the origin website while this is enabled. This can be used if you wish to reject all traffic while performing maintenance, block traffic during a specified period of time (an event), or block traffic while events are not occurring. Consider a waiting room used for vaccine distribution that only allows traffic during sign-up events, and otherwise blocks all traffic. For this case, the waiting room uses `reject`, and its events override this with `fifo`, `random`, or `passthrough`. When this queueing method is enabled and neither `queueAll` is enabled nor an event is prequeueing, the waiting room page **will not refresh automatically**.
      queueing_method: Option<waitingroomqueueingmethod>
      ///HTTP status code returned to a user while in the queue.
      queueing_status_code: Option<waitingroomqueueingstatuscode>
      ///Lifetime of a cookie (in minutes) set by Cloudflare for users who get access to the route. If a user is not seen by Cloudflare again in that time period, they will be treated as a new user that visits the route.
      session_duration: Option<waitingroomsessionduration>
      ///Suspends or allows traffic going to the waiting room. If set to `true`, the traffic will not go to the waiting room.
      suspended: Option<waitingroomsuspended>
      ///Sets the total number of active user sessions on the route at a point in time. A route is a combination of host and path on which a waiting room is available. This value is used as a baseline for the total number of active user sessions on the route. It is possible to have a situation where there are more or less active users sessions on the route based on the traffic patterns at that time around the world.
      total_active_users: waitingroomtotalactiveusers
      ///Which action to take when a bot is detected using Turnstile. `log` will
      ///have no impact on queueing behavior, simply keeping track of how many
      ///bots are detected in Waiting Room Analytics. `infinite_queue` will send
      ///bots to a false queueing state, where they will never reach your
      ///origin. `infinite_queue` requires Advanced Waiting Room.
      turnstile_action: Option<waitingroomturnstileaction>
      ///Which Turnstile widget type to use for detecting bot traffic. See
      ///[the Turnstile documentation](https://developers.cloudflare.com/turnstile/concepts/widget/#widget-types)
      ///for the definitions of these widget types. Set to `off` to disable the
      ///Turnstile integration entirely. Setting this to anything other than
      ///`off` or `invisible` requires Advanced Waiting Room.
      turnstile_mode: Option<waitingroomturnstilemode> }
    ///Creates an instance of waitingroomquerywaitingroom with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (host: waitingroomhost,
                          name: waitingroomname,
                          new_users_per_minute: waitingroomnewusersperminute,
                          total_active_users: waitingroomtotalactiveusers): waitingroomquerywaitingroom =
        { additional_routes = None
          cookie_attributes = None
          cookie_suffix = None
          custom_page_html = None
          default_template_language = None
          description = None
          disable_session_renewal = None
          enabled_origin_commands = None
          host = host
          json_response_enabled = None
          name = name
          new_users_per_minute = new_users_per_minute
          path = None
          queue_all = None
          queueing_method = None
          queueing_status_code = None
          session_duration = None
          suspended = None
          total_active_users = total_active_users
          turnstile_action = None
          turnstile_mode = None }

type waitingroomresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of waitingroomresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomresponsecollectionErrorsSource = { pointer = None }

type waitingroomresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<waitingroomresponsecollectionErrorsSource> }
    ///Creates an instance of waitingroomresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): waitingroomresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type waitingroomresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of waitingroomresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomresponsecollectionMessagesSource = { pointer = None }

type waitingroomresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<waitingroomresponsecollectionMessagesSource> }
    ///Creates an instance of waitingroomresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): waitingroomresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type waitingroomresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of waitingroomresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type waitingroomresponsecollection =
    { errors: list<waitingroomresponsecollectionErrors>
      messages: list<waitingroomresponsecollectionMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<waitingroomresponsecollectionResultinfo>
      result: Option<list<waitingroomwaitingroom>> }
    ///Creates an instance of waitingroomresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<waitingroomresponsecollectionErrors>,
                          messages: list<waitingroomresponsecollectionMessages>,
                          success: bool): waitingroomresponsecollection =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type waitingroomruleresult =
    { ///The action to take when the expression matches.
      action: Option<waitingroomruleaction>
      ///The description of the rule.
      description: Option<waitingroomruledescription>
      ///When set to true, the rule is enabled.
      enabled: Option<waitingroomruleenabled>
      ///Criteria defining when there is a match for the current rule.
      expression: Option<waitingroomruleexpression>
      ///The ID of the rule.
      id: Option<waitingroomruleid>
      last_updated: Option<waitingroomtimestamp>
      ///The version of the rule.
      version: Option<waitingroomruleversion> }
    ///Creates an instance of waitingroomruleresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomruleresult =
        { action = None
          description = None
          enabled = None
          expression = None
          id = None
          last_updated = None
          version = None }

type waitingroomrulesresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of waitingroomrulesresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomrulesresponsecollectionErrorsSource = { pointer = None }

type waitingroomrulesresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<waitingroomrulesresponsecollectionErrorsSource> }
    ///Creates an instance of waitingroomrulesresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): waitingroomrulesresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type waitingroomrulesresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of waitingroomrulesresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomrulesresponsecollectionMessagesSource = { pointer = None }

type waitingroomrulesresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<waitingroomrulesresponsecollectionMessagesSource> }
    ///Creates an instance of waitingroomrulesresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): waitingroomrulesresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type waitingroomrulesresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of waitingroomrulesresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomrulesresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type waitingroomrulesresponsecollection =
    { errors: list<waitingroomrulesresponsecollectionErrors>
      messages: list<waitingroomrulesresponsecollectionMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<waitingroomrulesresponsecollectionResultinfo>
      result: Option<list<waitingroomruleresult>> }
    ///Creates an instance of waitingroomrulesresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<waitingroomrulesresponsecollectionErrors>,
                          messages: list<waitingroomrulesresponsecollectionMessages>,
                          success: bool): waitingroomrulesresponsecollection =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``waitingroomschemas-api-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of waitingroomschemas-api-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``waitingroomschemas-api-response-commonErrorsSource`` = { pointer = None }

type ``waitingroomschemas-api-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``waitingroomschemas-api-response-commonErrorsSource``> }
    ///Creates an instance of waitingroomschemas-api-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``waitingroomschemas-api-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``waitingroomschemas-api-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of waitingroomschemas-api-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``waitingroomschemas-api-response-commonMessagesSource`` = { pointer = None }

type ``waitingroomschemas-api-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``waitingroomschemas-api-response-commonMessagesSource``> }
    ///Creates an instance of waitingroomschemas-api-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``waitingroomschemas-api-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``waitingroomschemas-api-response-common`` =
    { errors: list<``waitingroomschemas-api-response-commonErrors``>
      messages: list<``waitingroomschemas-api-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of waitingroomschemas-api-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``waitingroomschemas-api-response-commonErrors``>,
                          messages: list<``waitingroomschemas-api-response-commonMessages``>,
                          success: bool): ``waitingroomschemas-api-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type waitingroomsingleresponse =
    { result: waitingroomwaitingroom }
    ///Creates an instance of waitingroomsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (result: waitingroomwaitingroom): waitingroomsingleresponse = { result = result }

type waitingroomstatusresponseResult =
    { estimated_queued_users: Option<waitingroomestimatedqueuedusers>
      estimated_total_active_users: Option<waitingroomestimatedtotalactiveusers>
      event_id: Option<waitingroomstatuseventid>
      max_estimated_time_minutes: Option<waitingroommaxestimatedtimeminutes>
      status: Option<waitingroomstatus> }
    ///Creates an instance of waitingroomstatusresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomstatusresponseResult =
        { estimated_queued_users = None
          estimated_total_active_users = None
          event_id = None
          max_estimated_time_minutes = None
          status = None }

type waitingroomstatusresponse =
    { result: waitingroomstatusresponseResult }
    ///Creates an instance of waitingroomstatusresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (result: waitingroomstatusresponseResult): waitingroomstatusresponse = { result = result }

type waitingroomwaitingroomidresponseResult =
    { id: Option<waitingroomwaitingroomid> }
    ///Creates an instance of waitingroomwaitingroomidresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomwaitingroomidresponseResult = { id = None }

type waitingroomwaitingroomidresponse =
    { result: waitingroomwaitingroomidresponseResult }
    ///Creates an instance of waitingroomwaitingroomidresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (result: waitingroomwaitingroomidresponseResult): waitingroomwaitingroomidresponse =
        { result = result }

type waitingroomwaitingroomAdditionalroutes =
    { ///The hostname to which this waiting room will be applied (no wildcards). The hostname must be the primary domain, subdomain, or custom hostname (if using SSL for SaaS) of this zone. Please do not include the scheme (http:// or https://).
      host: Option<string>
      ///Sets the path within the host to enable the waiting room on. The waiting room will be enabled for all subpaths as well. If there are two waiting rooms on the same subpath, the waiting room for the most specific path will be chosen. Wildcards and query parameters are not supported.
      path: Option<string> }
    ///Creates an instance of waitingroomwaitingroomAdditionalroutes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomwaitingroomAdditionalroutes = { host = None; path = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type waitingroomwaitingroomEnabled_origin_commands =
    | [<CompiledName "revoke">] Revoke
    member this.Format() =
        match this with
        | Revoke -> "revoke"

type waitingroomwaitingroom =
    { ///Only available for the Waiting Room Advanced subscription. Additional hostname and path combinations to which this waiting room will be applied. There is an implied wildcard at the end of the path. The hostname and path combination must be unique to this and all other waiting rooms.
      additional_routes: Option<list<waitingroomwaitingroomAdditionalroutes>>
      ///Configures cookie attributes for the waiting room cookie. This encrypted cookie stores a user's status in the waiting room, such as queue position.
      cookie_attributes: Option<waitingroomcookieattributes>
      ///Appends a '_' + a custom suffix to the end of Cloudflare Waiting Room's cookie name(__cf_waitingroom). If `cookie_suffix` is "abcd", the cookie name will be `__cf_waitingroom_abcd`. This field is required if using `additional_routes`.
      cookie_suffix: Option<waitingroomcookiesuffix>
      created_on: Option<waitingroomtimestamp>
      ///Only available for the Waiting Room Advanced subscription. This is a template html file that will be rendered at the edge. If no custom_page_html is provided, the default waiting room will be used. The template is based on mustache ( https://mustache.github.io/ ). There are several variables that are evaluated by the Cloudflare edge:
      ///1. {{`waitTimeKnown`}} Acts like a boolean value that indicates the behavior to take when wait time is not available, for instance when queue_all is **true**.
      ///2. {{`waitTimeFormatted`}} Estimated wait time for the user. For example, five minutes. Alternatively, you can use:
      ///3. {{`waitTime`}} Number of minutes of estimated wait for a user.
      ///4. {{`waitTimeHours`}} Number of hours of estimated wait for a user (`Math.floor(waitTime/60)`).
      ///5. {{`waitTimeHourMinutes`}} Number of minutes above the `waitTimeHours` value (`waitTime%60`).
      ///6. {{`queueIsFull`}} Changes to **true** when no more people can be added to the queue.
      ///To view the full list of variables, look at the `cfWaitingRoom` object described under the `json_response_enabled` property in other Waiting Room API calls.
      custom_page_html: Option<waitingroomcustompagehtml>
      ///The language of the default page template. If no default_template_language is provided, then `en-US` (English) will be used.
      default_template_language: Option<waitingroomdefaulttemplatelanguage>
      ///A note that you can use to add more details about the waiting room.
      description: Option<waitingroomdescription>
      ///Only available for the Waiting Room Advanced subscription. Disables automatic renewal of session cookies. If `true`, an accepted user will have session_duration minutes to browse the site. After that, they will have to go through the waiting room again. If `false`, a user's session cookie will be automatically renewed on every request.
      disable_session_renewal: Option<waitingroomdisablesessionrenewal>
      ///A list of enabled origin commands.
      enabled_origin_commands: Option<list<waitingroomwaitingroomEnabled_origin_commands>>
      ///The host name to which the waiting room will be applied (no wildcards). Please do not include the scheme (http:// or https://). The host and path combination must be unique.
      host: Option<waitingroomhost>
      id: Option<waitingroomwaitingroomid>
      ///Only available for the Waiting Room Advanced subscription. If `true`, requests to the waiting room with the header `Accept: application/json` will receive a JSON response object with information on the user's status in the waiting room as opposed to the configured static HTML page. This JSON response object has one property `cfWaitingRoom` which is an object containing the following fields:
      ///1. `inWaitingRoom`: Boolean indicating if the user is in the waiting room (always **true**).
      ///2. `waitTimeKnown`: Boolean indicating if the current estimated wait times are accurate. If **false**, they are not available.
      ///3. `waitTime`: Valid only when `waitTimeKnown` is **true**. Integer indicating the current estimated time in minutes the user will wait in the waiting room. When `queueingMethod` is **random**, this is set to `waitTime50Percentile`.
      ///4. `waitTime25Percentile`: Valid only when `queueingMethod` is **random** and `waitTimeKnown` is **true**. Integer indicating the current estimated maximum wait time for the 25% of users that gain entry the fastest (25th percentile).
      ///5. `waitTime50Percentile`: Valid only when `queueingMethod` is **random** and `waitTimeKnown` is **true**. Integer indicating the current estimated maximum wait time for the 50% of users that gain entry the fastest (50th percentile). In other words, half of the queued users are expected to let into the origin website before `waitTime50Percentile` and half are expected to be let in after it.
      ///6. `waitTime75Percentile`: Valid only when `queueingMethod` is **random** and `waitTimeKnown` is **true**. Integer indicating the current estimated maximum wait time for the 75% of users that gain entry the fastest (75th percentile).
      ///7. `waitTimeFormatted`: String displaying the `waitTime` formatted in English for users. If `waitTimeKnown` is **false**, `waitTimeFormatted` will display **unavailable**.
      ///8. `queueIsFull`: Boolean indicating if the waiting room's queue is currently full and not accepting new users at the moment.
      ///9. `queueAll`: Boolean indicating if all users will be queued in the waiting room and no one will be let into the origin website.
      ///10. `lastUpdated`: String displaying the timestamp as an ISO 8601 string of the user's last attempt to leave the waiting room and be let into the origin website. The user is able to make another attempt after `refreshIntervalSeconds` past this time. If the user makes a request too soon, it will be ignored and `lastUpdated` will not change.
      ///11. `refreshIntervalSeconds`: Integer indicating the number of seconds after `lastUpdated` until the user is able to make another attempt to leave the waiting room and be let into the origin website. When the `queueingMethod` is `reject`, there is no specified refresh time —\_it will always be **zero**.
      ///12. `queueingMethod`: The queueing method currently used by the waiting room. It is either **fifo**, **random**, **passthrough**, or **reject**.
      ///13. `isFIFOQueue`: Boolean indicating if the waiting room uses a FIFO (First-In-First-Out) queue.
      ///14. `isRandomQueue`: Boolean indicating if the waiting room uses a Random queue where users gain access randomly.
      ///15. `isPassthroughQueue`: Boolean indicating if the waiting room uses a passthrough queue. Keep in mind that when passthrough is enabled, this JSON response will only exist when `queueAll` is **true** or `isEventPrequeueing` is **true** because in all other cases requests will go directly to the origin.
      ///16. `isRejectQueue`: Boolean indicating if the waiting room uses a reject queue.
      ///17. `isEventActive`: Boolean indicating if an event is currently occurring. Events are able to change a waiting room's behavior during a specified period of time. For additional information, look at the event properties `prequeue_start_time`, `event_start_time`, and `event_end_time` in the documentation for creating waiting room events. Events are considered active between these start and end times, as well as during the prequeueing period if it exists.
      ///18. `isEventPrequeueing`: Valid only when `isEventActive` is **true**. Boolean indicating if an event is currently prequeueing users before it starts.
      ///19. `timeUntilEventStart`: Valid only when `isEventPrequeueing` is **true**. Integer indicating the number of minutes until the event starts.
      ///20. `timeUntilEventStartFormatted`: String displaying the `timeUntilEventStart` formatted in English for users. If `isEventPrequeueing` is **false**, `timeUntilEventStartFormatted` will display **unavailable**.
      ///21. `timeUntilEventEnd`: Valid only when `isEventActive` is **true**. Integer indicating the number of minutes until the event ends.
      ///22. `timeUntilEventEndFormatted`: String displaying the `timeUntilEventEnd` formatted in English for users. If `isEventActive` is **false**, `timeUntilEventEndFormatted` will display **unavailable**.
      ///23. `shuffleAtEventStart`: Valid only when `isEventActive` is **true**. Boolean indicating if the users in the prequeue are shuffled randomly when the event starts.
      ///24. `turnstile`: Empty when turnstile isn't enabled. String displaying an html tag to display the Turnstile widget. Please add the `{{{turnstile}}}` tag to the `custom_html` template to ensure the Turnstile widget appears.
      ///25. `infiniteQueue`: Boolean indicating whether the response is for a user in the infinite queue.
      ///An example cURL to a waiting room could be:
      ///	curl -X GET "https://example.com/waitingroom" \
      ///		-H "Accept: application/json"
      ///If `json_response_enabled` is **true** and the request hits the waiting room, an example JSON response when `queueingMethod` is **fifo** and no event is active could be:
      ///	{
      ///		"cfWaitingRoom": {
      ///			"inWaitingRoom": true,
      ///			"waitTimeKnown": true,
      ///			"waitTime": 10,
      ///			"waitTime25Percentile": 0,
      ///			"waitTime50Percentile": 0,
      ///			"waitTime75Percentile": 0,
      ///			"waitTimeFormatted": "10 minutes",
      ///			"queueIsFull": false,
      ///			"queueAll": false,
      ///			"lastUpdated": "2020-08-03T23:46:00.000Z",
      ///			"refreshIntervalSeconds": 20,
      ///			"queueingMethod": "fifo",
      ///			"isFIFOQueue": true,
      ///			"isRandomQueue": false,
      ///			"isPassthroughQueue": false,
      ///			"isRejectQueue": false,
      ///			"isEventActive": false,
      ///			"isEventPrequeueing": false,
      ///			"timeUntilEventStart": 0,
      ///			"timeUntilEventStartFormatted": "unavailable",
      ///			"timeUntilEventEnd": 0,
      ///			"timeUntilEventEndFormatted": "unavailable",
      ///			"shuffleAtEventStart": false
      ///		}
      ///	}
      ///If `json_response_enabled` is **true** and the request hits the waiting room, an example JSON response when `queueingMethod` is **random** and an event is active could be:
      ///	{
      ///		"cfWaitingRoom": {
      ///			"inWaitingRoom": true,
      ///			"waitTimeKnown": true,
      ///			"waitTime": 10,
      ///			"waitTime25Percentile": 5,
      ///			"waitTime50Percentile": 10,
      ///			"waitTime75Percentile": 15,
      ///			"waitTimeFormatted": "5 minutes to 15 minutes",
      ///			"queueIsFull": false,
      ///			"queueAll": false,
      ///			"lastUpdated": "2020-08-03T23:46:00.000Z",
      ///			"refreshIntervalSeconds": 20,
      ///			"queueingMethod": "random",
      ///			"isFIFOQueue": false,
      ///			"isRandomQueue": true,
      ///			"isPassthroughQueue": false,
      ///			"isRejectQueue": false,
      ///			"isEventActive": true,
      ///			"isEventPrequeueing": false,
      ///			"timeUntilEventStart": 0,
      ///			"timeUntilEventStartFormatted": "unavailable",
      ///			"timeUntilEventEnd": 15,
      ///			"timeUntilEventEndFormatted": "15 minutes",
      ///			"shuffleAtEventStart": true
      ///		}
      ///	}
      json_response_enabled: Option<waitingroomjsonresponseenabled>
      modified_on: Option<waitingroomtimestamp>
      ///A unique name to identify the waiting room. Only alphanumeric characters, hyphens and underscores are allowed.
      name: Option<waitingroomname>
      ///Sets the number of new users that will be let into the route every minute. This value is used as baseline for the number of users that are let in per minute. So it is possible that there is a little more or little less traffic coming to the route based on the traffic patterns at that time around the world.
      new_users_per_minute: Option<waitingroomnewusersperminute>
      ///An ISO 8601 timestamp that marks when the next event will begin queueing.
      next_event_prequeue_start_time: Option<waitingroomnexteventprequeuestarttime>
      ///An ISO 8601 timestamp that marks when the next event will start.
      next_event_start_time: Option<waitingroomnexteventstarttime>
      ///Sets the path within the host to enable the waiting room on. The waiting room will be enabled for all subpaths as well. If there are two waiting rooms on the same subpath, the waiting room for the most specific path will be chosen. Wildcards and query parameters are not supported.
      path: Option<waitingroompath>
      ///If queue_all is `true`, all the traffic that is coming to a route will be sent to the waiting room. No new traffic can get to the route once this field is set and estimated time will become unavailable.
      queue_all: Option<waitingroomqueueall>
      ///Sets the queueing method used by the waiting room. Changing this parameter from the **default** queueing method is only available for the Waiting Room Advanced subscription. Regardless of the queueing method, if `queue_all` is enabled or an event is prequeueing, users in the waiting room will not be accepted to the origin. These users will always see a waiting room page that refreshes automatically. The valid queueing methods are:
      ///1. `fifo` **(default)**: First-In-First-Out queue where customers gain access in the order they arrived.
      ///2. `random`: Random queue where customers gain access randomly, regardless of arrival time.
      ///3. `passthrough`: Users will pass directly through the waiting room and into the origin website. As a result, any configured limits will not be respected while this is enabled. This method can be used as an alternative to disabling a waiting room (with `suspended`) so that analytics are still reported. This can be used if you wish to allow all traffic normally, but want to restrict traffic during a waiting room event, or vice versa.
      ///4. `reject`: Users will be immediately rejected from the waiting room. As a result, no users will reach the origin website while this is enabled. This can be used if you wish to reject all traffic while performing maintenance, block traffic during a specified period of time (an event), or block traffic while events are not occurring. Consider a waiting room used for vaccine distribution that only allows traffic during sign-up events, and otherwise blocks all traffic. For this case, the waiting room uses `reject`, and its events override this with `fifo`, `random`, or `passthrough`. When this queueing method is enabled and neither `queueAll` is enabled nor an event is prequeueing, the waiting room page **will not refresh automatically**.
      queueing_method: Option<waitingroomqueueingmethod>
      ///HTTP status code returned to a user while in the queue.
      queueing_status_code: Option<waitingroomqueueingstatuscode>
      ///Lifetime of a cookie (in minutes) set by Cloudflare for users who get access to the route. If a user is not seen by Cloudflare again in that time period, they will be treated as a new user that visits the route.
      session_duration: Option<waitingroomsessionduration>
      ///Suspends or allows traffic going to the waiting room. If set to `true`, the traffic will not go to the waiting room.
      suspended: Option<waitingroomsuspended>
      ///Sets the total number of active user sessions on the route at a point in time. A route is a combination of host and path on which a waiting room is available. This value is used as a baseline for the total number of active user sessions on the route. It is possible to have a situation where there are more or less active users sessions on the route based on the traffic patterns at that time around the world.
      total_active_users: Option<waitingroomtotalactiveusers>
      ///Which action to take when a bot is detected using Turnstile. `log` will
      ///have no impact on queueing behavior, simply keeping track of how many
      ///bots are detected in Waiting Room Analytics. `infinite_queue` will send
      ///bots to a false queueing state, where they will never reach your
      ///origin. `infinite_queue` requires Advanced Waiting Room.
      turnstile_action: Option<waitingroomturnstileaction>
      ///Which Turnstile widget type to use for detecting bot traffic. See
      ///[the Turnstile documentation](https://developers.cloudflare.com/turnstile/concepts/widget/#widget-types)
      ///for the definitions of these widget types. Set to `off` to disable the
      ///Turnstile integration entirely. Setting this to anything other than
      ///`off` or `invisible` requires Advanced Waiting Room.
      turnstile_mode: Option<waitingroomturnstilemode> }
    ///Creates an instance of waitingroomwaitingroom with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomwaitingroom =
        { additional_routes = None
          cookie_attributes = None
          cookie_suffix = None
          created_on = None
          custom_page_html = None
          default_template_language = None
          description = None
          disable_session_renewal = None
          enabled_origin_commands = None
          host = None
          id = None
          json_response_enabled = None
          modified_on = None
          name = None
          new_users_per_minute = None
          next_event_prequeue_start_time = None
          next_event_start_time = None
          path = None
          queue_all = None
          queueing_method = None
          queueing_status_code = None
          session_duration = None
          suspended = None
          total_active_users = None
          turnstile_action = None
          turnstile_mode = None }

type waitingroomzonesettings =
    { ///Whether to allow verified search engine crawlers to bypass all waiting rooms on this zone.
      ///Verified search engine crawlers will not be tracked or counted by the waiting room system,
      ///and will not appear in waiting room analytics.
      search_engine_crawler_bypass: Option<waitingroomsearchenginecrawlerbypass> }
    ///Creates an instance of waitingroomzonesettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): waitingroomzonesettings = { search_engine_crawler_bypass = None }

type waitingroomzonesettingsresponseResult =
    { ///Whether to allow verified search engine crawlers to bypass all waiting rooms on this zone.
      ///Verified search engine crawlers will not be tracked or counted by the waiting room system,
      ///and will not appear in waiting room analytics.
      search_engine_crawler_bypass: waitingroomsearchenginecrawlerbypass }
    ///Creates an instance of waitingroomzonesettingsresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (search_engine_crawler_bypass: waitingroomsearchenginecrawlerbypass): waitingroomzonesettingsresponseResult =
        { search_engine_crawler_bypass = search_engine_crawler_bypass }

type waitingroomzonesettingsresponse =
    { result: waitingroomzonesettingsresponseResult }
    ///Creates an instance of waitingroomzonesettingsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (result: waitingroomzonesettingsresponseResult): waitingroomzonesettingsresponse =
        { result = result }

type WaitingRoomListWaitingRooms_BadRequestErrorsSource = { pointer: Option<string> }

type WaitingRoomListWaitingRooms_BadRequestErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomListWaitingRooms_BadRequestErrorsSource> }

type WaitingRoomListWaitingRooms_BadRequestMessagesSource = { pointer: Option<string> }

type WaitingRoomListWaitingRooms_BadRequestMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomListWaitingRooms_BadRequestMessagesSource> }

type WaitingRoomListWaitingRooms_BadRequestResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }

type WaitingRoomListWaitingRooms_BadRequest =
    { errors: Option<list<WaitingRoomListWaitingRooms_BadRequestErrors>>
      messages: Option<list<WaitingRoomListWaitingRooms_BadRequestMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<WaitingRoomListWaitingRooms_BadRequestResultinfo>
      result: Option<list<waitingroomwaitingroom>> }

[<RequireQualifiedAccess>]
type WaitingRoomListWaitingRooms =
    ///List waiting rooms for zone response
    | OK of payload: waitingroomresponsecollection
    ///List waiting rooms for zone response failure
    | BadRequest of payload: WaitingRoomListWaitingRooms_BadRequest

type WaitingRoomCreateWaitingRoom_BadRequest =
    { result: Option<waitingroomwaitingroom>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomCreateWaitingRoom =
    ///Create waiting room response
    | OK of payload: waitingroomsingleresponse
    ///Create waiting room response failure
    | BadRequest of payload: WaitingRoomCreateWaitingRoom_BadRequest

type WaitingRoomCreateACustomWaitingRoomPagePreview_BadRequestResult =
    { ///URL where the custom waiting room page can temporarily be previewed.
      preview_url: Option<waitingroompreviewurl> }

type WaitingRoomCreateACustomWaitingRoomPagePreview_BadRequest =
    { result: Option<WaitingRoomCreateACustomWaitingRoomPagePreview_BadRequestResult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomCreateACustomWaitingRoomPagePreview =
    ///Create a custom waiting room page preview response
    | OK of payload: waitingroompreviewresponse
    ///Create a custom waiting room page preview response failure
    | BadRequest of payload: WaitingRoomCreateACustomWaitingRoomPagePreview_BadRequest

type WaitingRoomGetZoneSettings_BadRequestResult =
    { ///Whether to allow verified search engine crawlers to bypass all waiting rooms on this zone.
      ///Verified search engine crawlers will not be tracked or counted by the waiting room system,
      ///and will not appear in waiting room analytics.
      search_engine_crawler_bypass: waitingroomsearchenginecrawlerbypass }

type WaitingRoomGetZoneSettings_BadRequest =
    { result: Option<WaitingRoomGetZoneSettings_BadRequestResult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomGetZoneSettings =
    ///The current zone-level Waiting Room settings
    | OK of payload: waitingroomzonesettingsresponse
    ///The current zone-level Waiting Room settings response failure
    | BadRequest of payload: WaitingRoomGetZoneSettings_BadRequest

type WaitingRoomPatchZoneSettings_BadRequestResult =
    { ///Whether to allow verified search engine crawlers to bypass all waiting rooms on this zone.
      ///Verified search engine crawlers will not be tracked or counted by the waiting room system,
      ///and will not appear in waiting room analytics.
      search_engine_crawler_bypass: waitingroomsearchenginecrawlerbypass }

type WaitingRoomPatchZoneSettings_BadRequest =
    { result: Option<WaitingRoomPatchZoneSettings_BadRequestResult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomPatchZoneSettings =
    ///The updated zone-level Waiting Room settings
    | OK of payload: waitingroomzonesettingsresponse
    ///The zone-level Waiting Room settings response failure
    | BadRequest of payload: WaitingRoomPatchZoneSettings_BadRequest

type WaitingRoomUpdateZoneSettings_BadRequestResult =
    { ///Whether to allow verified search engine crawlers to bypass all waiting rooms on this zone.
      ///Verified search engine crawlers will not be tracked or counted by the waiting room system,
      ///and will not appear in waiting room analytics.
      search_engine_crawler_bypass: waitingroomsearchenginecrawlerbypass }

type WaitingRoomUpdateZoneSettings_BadRequest =
    { result: Option<WaitingRoomUpdateZoneSettings_BadRequestResult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomUpdateZoneSettings =
    ///The updated zone-level Waiting Room settings
    | OK of payload: waitingroomzonesettingsresponse
    ///The zone-level Waiting Room settings response failure
    | BadRequest of payload: WaitingRoomUpdateZoneSettings_BadRequest

type WaitingRoomDeleteWaitingRoom_BadRequestResult =
    { id: Option<waitingroomwaitingroomid> }

type WaitingRoomDeleteWaitingRoom_BadRequest =
    { result: Option<WaitingRoomDeleteWaitingRoom_BadRequestResult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomDeleteWaitingRoom =
    ///Delete waiting room response
    | OK of payload: waitingroomwaitingroomidresponse
    ///Delete waiting room response failure
    | BadRequest of payload: WaitingRoomDeleteWaitingRoom_BadRequest

type WaitingRoomWaitingRoomDetails_BadRequest =
    { result: Option<waitingroomwaitingroom>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomWaitingRoomDetails =
    ///Waiting room details response
    | OK of payload: waitingroomsingleresponse
    ///Waiting room details response failure
    | BadRequest of payload: WaitingRoomWaitingRoomDetails_BadRequest

type WaitingRoomPatchWaitingRoom_BadRequest =
    { result: Option<waitingroomwaitingroom>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomPatchWaitingRoom =
    ///Patch waiting room response
    | OK of payload: waitingroomsingleresponse
    ///Patch waiting room response failure
    | BadRequest of payload: WaitingRoomPatchWaitingRoom_BadRequest

type WaitingRoomUpdateWaitingRoom_BadRequest =
    { result: Option<waitingroomwaitingroom>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomUpdateWaitingRoom =
    ///Update waiting room response
    | OK of payload: waitingroomsingleresponse
    ///Update waiting room response failure
    | BadRequest of payload: WaitingRoomUpdateWaitingRoom_BadRequest

type WaitingRoomListEvents_BadRequestErrorsSource = { pointer: Option<string> }

type WaitingRoomListEvents_BadRequestErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomListEvents_BadRequestErrorsSource> }

type WaitingRoomListEvents_BadRequestMessagesSource = { pointer: Option<string> }

type WaitingRoomListEvents_BadRequestMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomListEvents_BadRequestMessagesSource> }

type WaitingRoomListEvents_BadRequestResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }

type WaitingRoomListEvents_BadRequest =
    { errors: Option<list<WaitingRoomListEvents_BadRequestErrors>>
      messages: Option<list<WaitingRoomListEvents_BadRequestMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<WaitingRoomListEvents_BadRequestResultinfo>
      result: Option<list<waitingroomeventresult>> }

[<RequireQualifiedAccess>]
type WaitingRoomListEvents =
    ///List events response
    | OK of payload: waitingroomeventresponsecollection
    ///List events response failure
    | BadRequest of payload: WaitingRoomListEvents_BadRequest

type WaitingRoomCreateEvent_BadRequest =
    { result: Option<waitingroomeventresult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomCreateEvent =
    ///Create event response
    | OK of payload: waitingroomeventresponse
    ///Create event response failure
    | BadRequest of payload: WaitingRoomCreateEvent_BadRequest

type WaitingRoomDeleteEvent_BadRequestResult = { id: Option<waitingroomeventid> }

type WaitingRoomDeleteEvent_BadRequest =
    { result: Option<WaitingRoomDeleteEvent_BadRequestResult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomDeleteEvent =
    ///Delete event response
    | OK of payload: waitingroomeventidresponse
    ///Delete event response failure
    | BadRequest of payload: WaitingRoomDeleteEvent_BadRequest

type WaitingRoomEventDetails_BadRequest =
    { result: Option<waitingroomeventresult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomEventDetails =
    ///Event details response
    | OK of payload: waitingroomeventresponse
    ///Event details response failure
    | BadRequest of payload: WaitingRoomEventDetails_BadRequest

type WaitingRoomPatchEvent_BadRequest =
    { result: Option<waitingroomeventresult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomPatchEvent =
    ///Patch event response
    | OK of payload: waitingroomeventresponse
    ///Patch event response failure
    | BadRequest of payload: WaitingRoomPatchEvent_BadRequest

type WaitingRoomUpdateEvent_BadRequest =
    { result: Option<waitingroomeventresult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomUpdateEvent =
    ///Update event response
    | OK of payload: waitingroomeventresponse
    ///Update event response failure
    | BadRequest of payload: WaitingRoomUpdateEvent_BadRequest

type WaitingRoomPreviewActiveEventDetails_BadRequest =
    { result: Option<waitingroomeventdetailsresult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomPreviewActiveEventDetails =
    ///Preview active event details response
    | OK of payload: waitingroomeventdetailsresponse
    ///Preview active event details response failure
    | BadRequest of payload: WaitingRoomPreviewActiveEventDetails_BadRequest

type WaitingRoomListWaitingRoomRules_BadRequestErrorsSource = { pointer: Option<string> }

type WaitingRoomListWaitingRoomRules_BadRequestErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomListWaitingRoomRules_BadRequestErrorsSource> }

type WaitingRoomListWaitingRoomRules_BadRequestMessagesSource = { pointer: Option<string> }

type WaitingRoomListWaitingRoomRules_BadRequestMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomListWaitingRoomRules_BadRequestMessagesSource> }

type WaitingRoomListWaitingRoomRules_BadRequestResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }

type WaitingRoomListWaitingRoomRules_BadRequest =
    { errors: Option<list<WaitingRoomListWaitingRoomRules_BadRequestErrors>>
      messages: Option<list<WaitingRoomListWaitingRoomRules_BadRequestMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<WaitingRoomListWaitingRoomRules_BadRequestResultinfo>
      result: Option<list<waitingroomruleresult>> }

[<RequireQualifiedAccess>]
type WaitingRoomListWaitingRoomRules =
    ///List Waiting Room Rules response
    | OK of payload: waitingroomrulesresponsecollection
    ///List Waiting Room Rules response failure
    | BadRequest of payload: WaitingRoomListWaitingRoomRules_BadRequest

type WaitingRoomCreateWaitingRoomRule_BadRequestErrorsSource = { pointer: Option<string> }

type WaitingRoomCreateWaitingRoomRule_BadRequestErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomCreateWaitingRoomRule_BadRequestErrorsSource> }

type WaitingRoomCreateWaitingRoomRule_BadRequestMessagesSource = { pointer: Option<string> }

type WaitingRoomCreateWaitingRoomRule_BadRequestMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomCreateWaitingRoomRule_BadRequestMessagesSource> }

type WaitingRoomCreateWaitingRoomRule_BadRequestResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }

type WaitingRoomCreateWaitingRoomRule_BadRequest =
    { errors: Option<list<WaitingRoomCreateWaitingRoomRule_BadRequestErrors>>
      messages: Option<list<WaitingRoomCreateWaitingRoomRule_BadRequestMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<WaitingRoomCreateWaitingRoomRule_BadRequestResultinfo>
      result: Option<list<waitingroomruleresult>> }

[<RequireQualifiedAccess>]
type WaitingRoomCreateWaitingRoomRule =
    ///Create Waiting Room Rule response
    | OK of payload: waitingroomrulesresponsecollection
    ///Create Waiting Room Rule response failure
    | BadRequest of payload: WaitingRoomCreateWaitingRoomRule_BadRequest

type WaitingRoomReplaceWaitingRoomRules_BadRequestErrorsSource = { pointer: Option<string> }

type WaitingRoomReplaceWaitingRoomRules_BadRequestErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomReplaceWaitingRoomRules_BadRequestErrorsSource> }

type WaitingRoomReplaceWaitingRoomRules_BadRequestMessagesSource = { pointer: Option<string> }

type WaitingRoomReplaceWaitingRoomRules_BadRequestMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomReplaceWaitingRoomRules_BadRequestMessagesSource> }

type WaitingRoomReplaceWaitingRoomRules_BadRequestResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }

type WaitingRoomReplaceWaitingRoomRules_BadRequest =
    { errors: Option<list<WaitingRoomReplaceWaitingRoomRules_BadRequestErrors>>
      messages: Option<list<WaitingRoomReplaceWaitingRoomRules_BadRequestMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<WaitingRoomReplaceWaitingRoomRules_BadRequestResultinfo>
      result: Option<list<waitingroomruleresult>> }

[<RequireQualifiedAccess>]
type WaitingRoomReplaceWaitingRoomRules =
    ///Replace Waiting Room Rules response
    | OK of payload: waitingroomrulesresponsecollection
    ///Replace Waiting Room Rules response failure
    | BadRequest of payload: WaitingRoomReplaceWaitingRoomRules_BadRequest

type WaitingRoomDeleteWaitingRoomRule_BadRequestErrorsSource = { pointer: Option<string> }

type WaitingRoomDeleteWaitingRoomRule_BadRequestErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomDeleteWaitingRoomRule_BadRequestErrorsSource> }

type WaitingRoomDeleteWaitingRoomRule_BadRequestMessagesSource = { pointer: Option<string> }

type WaitingRoomDeleteWaitingRoomRule_BadRequestMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomDeleteWaitingRoomRule_BadRequestMessagesSource> }

type WaitingRoomDeleteWaitingRoomRule_BadRequestResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }

type WaitingRoomDeleteWaitingRoomRule_BadRequest =
    { errors: Option<list<WaitingRoomDeleteWaitingRoomRule_BadRequestErrors>>
      messages: Option<list<WaitingRoomDeleteWaitingRoomRule_BadRequestMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<WaitingRoomDeleteWaitingRoomRule_BadRequestResultinfo>
      result: Option<list<waitingroomruleresult>> }

[<RequireQualifiedAccess>]
type WaitingRoomDeleteWaitingRoomRule =
    ///Delete Waiting Room Rule response
    | OK of payload: waitingroomrulesresponsecollection
    ///Delete Waiting Room Rule response failure
    | BadRequest of payload: WaitingRoomDeleteWaitingRoomRule_BadRequest

type WaitingRoomPatchWaitingRoomRule_BadRequestErrorsSource = { pointer: Option<string> }

type WaitingRoomPatchWaitingRoomRule_BadRequestErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomPatchWaitingRoomRule_BadRequestErrorsSource> }

type WaitingRoomPatchWaitingRoomRule_BadRequestMessagesSource = { pointer: Option<string> }

type WaitingRoomPatchWaitingRoomRule_BadRequestMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<WaitingRoomPatchWaitingRoomRule_BadRequestMessagesSource> }

type WaitingRoomPatchWaitingRoomRule_BadRequestResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }

type WaitingRoomPatchWaitingRoomRule_BadRequest =
    { errors: Option<list<WaitingRoomPatchWaitingRoomRule_BadRequestErrors>>
      messages: Option<list<WaitingRoomPatchWaitingRoomRule_BadRequestMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<WaitingRoomPatchWaitingRoomRule_BadRequestResultinfo>
      result: Option<list<waitingroomruleresult>> }

[<RequireQualifiedAccess>]
type WaitingRoomPatchWaitingRoomRule =
    ///Patch Waiting Room Rule response
    | OK of payload: waitingroomrulesresponsecollection
    ///Patch Waiting Room Rule response failure
    | BadRequest of payload: WaitingRoomPatchWaitingRoomRule_BadRequest

type WaitingRoomGetWaitingRoomStatus_BadRequestResult =
    { estimated_queued_users: Option<waitingroomestimatedqueuedusers>
      estimated_total_active_users: Option<waitingroomestimatedtotalactiveusers>
      event_id: Option<waitingroomstatuseventid>
      max_estimated_time_minutes: Option<waitingroommaxestimatedtimeminutes>
      status: Option<waitingroomstatus> }

type WaitingRoomGetWaitingRoomStatus_BadRequest =
    { result: Option<WaitingRoomGetWaitingRoomStatus_BadRequestResult>
      errors: Option<Newtonsoft.Json.Linq.JToken>
      messages: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }

[<RequireQualifiedAccess>]
type WaitingRoomGetWaitingRoomStatus =
    ///Get waiting room status response
    | OK of payload: waitingroomstatusresponse
    ///Get waiting room status response failure
    | BadRequest of payload: WaitingRoomGetWaitingRoomStatus_BadRequest
