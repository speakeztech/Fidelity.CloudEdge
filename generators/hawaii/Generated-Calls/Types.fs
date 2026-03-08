namespace rec Fidelity.CloudEdge.Management.Calls.Types

///The account identifier tag.
type callsaccountidentifier = string
///The date and time the item was created.
type callscreated = System.DateTimeOffset
///A Cloudflare-generated unique identifier for a item.
type callsidentifier = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type callsmessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of callsmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsmessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsmessages = list<callsmessagesArrayItem>
///The date and time the item was last modified.
type callsmodified = System.DateTimeOffset
///A short description of Calls app, not shown to end users.
type callsname = string
///Bearer token
type callssecret = string
///Bearer token
type callsturnkey = string
///A short description of a TURN key, not shown to end users.
type callsturnkeyname = string

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

type ``callsapi-response-common`` =
    { errors: list<Errors>
      messages: list<Messages>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of callsapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>, messages: list<Messages>, success: bool): ``callsapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``callsapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of callsapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``callsapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``callsapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of callsapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``callsapi-response-singleErrorsSource`` = { pointer = None }

type ``callsapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``callsapi-response-singleErrorsSource``> }
    ///Creates an instance of callsapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``callsapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``callsapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of callsapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``callsapi-response-singleMessagesSource`` = { pointer = None }

type ``callsapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``callsapi-response-singleMessagesSource``> }
    ///Creates an instance of callsapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``callsapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``callsapi-response-single`` =
    { errors: Option<list<``callsapi-response-singleErrors``>>
      messages: Option<list<``callsapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of callsapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``callsapi-response-single`` =
        { errors = None
          messages = None
          success = None }

type callsapp =
    { ///The date and time the item was created.
      created: Option<callscreated>
      ///The date and time the item was last modified.
      modified: Option<callsmodified>
      ///A short description of Calls app, not shown to end users.
      name: Option<callsname>
      ///A Cloudflare-generated unique identifier for a item.
      uid: Option<callsidentifier> }
    ///Creates an instance of callsapp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsapp =
        { created = None
          modified = None
          name = None
          uid = None }

type callsappeditablefields =
    { ///A short description of Calls app, not shown to end users.
      name: Option<callsname> }
    ///Creates an instance of callsappeditablefields with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappeditablefields = { name = None }

type callsappresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of callsappresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappresponsecollectionErrorsSource = { pointer = None }

type callsappresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsappresponsecollectionErrorsSource> }
    ///Creates an instance of callsappresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsappresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsappresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of callsappresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappresponsecollectionMessagesSource = { pointer = None }

type callsappresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsappresponsecollectionMessagesSource> }
    ///Creates an instance of callsappresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsappresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsappresponsecollection =
    { errors: Option<list<callsappresponsecollectionErrors>>
      messages: Option<list<callsappresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<callsapp>> }
    ///Creates an instance of callsappresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappresponsecollection =
        { errors = None
          messages = None
          success = None
          result = None }

type callsappresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of callsappresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappresponsesingleErrorsSource = { pointer = None }

type callsappresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsappresponsesingleErrorsSource> }
    ///Creates an instance of callsappresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsappresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsappresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of callsappresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappresponsesingleMessagesSource = { pointer = None }

type callsappresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsappresponsesingleMessagesSource> }
    ///Creates an instance of callsappresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsappresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsappresponsesingle =
    { errors: Option<list<callsappresponsesingleErrors>>
      messages: Option<list<callsappresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<callsapp> }
    ///Creates an instance of callsappresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type callsappresponsesinglewithsecretErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of callsappresponsesinglewithsecretErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappresponsesinglewithsecretErrorsSource = { pointer = None }

type callsappresponsesinglewithsecretErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsappresponsesinglewithsecretErrorsSource> }
    ///Creates an instance of callsappresponsesinglewithsecretErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsappresponsesinglewithsecretErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsappresponsesinglewithsecretMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of callsappresponsesinglewithsecretMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappresponsesinglewithsecretMessagesSource = { pointer = None }

type callsappresponsesinglewithsecretMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsappresponsesinglewithsecretMessagesSource> }
    ///Creates an instance of callsappresponsesinglewithsecretMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsappresponsesinglewithsecretMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsappresponsesinglewithsecret =
    { errors: Option<list<callsappresponsesinglewithsecretErrors>>
      messages: Option<list<callsappresponsesinglewithsecretMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<callsappwithsecret> }
    ///Creates an instance of callsappresponsesinglewithsecret with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappresponsesinglewithsecret =
        { errors = None
          messages = None
          success = None
          result = None }

type callsappwithsecret =
    { ///The date and time the item was created.
      created: Option<callscreated>
      ///The date and time the item was last modified.
      modified: Option<callsmodified>
      ///A short description of Calls app, not shown to end users.
      name: Option<callsname>
      ///Bearer token
      secret: Option<callssecret>
      ///A Cloudflare-generated unique identifier for a item.
      uid: Option<callsidentifier> }
    ///Creates an instance of callsappwithsecret with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsappwithsecret =
        { created = None
          modified = None
          name = None
          secret = None
          uid = None }

type callsturnkeycollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of callsturnkeycollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeycollectionErrorsSource = { pointer = None }

type callsturnkeycollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsturnkeycollectionErrorsSource> }
    ///Creates an instance of callsturnkeycollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsturnkeycollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsturnkeycollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of callsturnkeycollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeycollectionMessagesSource = { pointer = None }

type callsturnkeycollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsturnkeycollectionMessagesSource> }
    ///Creates an instance of callsturnkeycollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsturnkeycollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsturnkeycollection =
    { errors: Option<list<callsturnkeycollectionErrors>>
      messages: Option<list<callsturnkeycollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<callsturnkeyobject>> }
    ///Creates an instance of callsturnkeycollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeycollection =
        { errors = None
          messages = None
          success = None
          result = None }

type callsturnkeyeditablefields =
    { ///A short description of a TURN key, not shown to end users.
      name: Option<callsturnkeyname> }
    ///Creates an instance of callsturnkeyeditablefields with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeyeditablefields = { name = None }

type callsturnkeyobject =
    { ///The date and time the item was created.
      created: Option<callscreated>
      ///The date and time the item was last modified.
      modified: Option<callsmodified>
      ///A short description of Calls app, not shown to end users.
      name: Option<callsname>
      ///A Cloudflare-generated unique identifier for a item.
      uid: Option<callsidentifier> }
    ///Creates an instance of callsturnkeyobject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeyobject =
        { created = None
          modified = None
          name = None
          uid = None }

type callsturnkeyresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of callsturnkeyresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeyresponsecollectionErrorsSource = { pointer = None }

type callsturnkeyresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsturnkeyresponsecollectionErrorsSource> }
    ///Creates an instance of callsturnkeyresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsturnkeyresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsturnkeyresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of callsturnkeyresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeyresponsecollectionMessagesSource = { pointer = None }

type callsturnkeyresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsturnkeyresponsecollectionMessagesSource> }
    ///Creates an instance of callsturnkeyresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsturnkeyresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsturnkeyresponsecollection =
    { errors: Option<list<callsturnkeyresponsecollectionErrors>>
      messages: Option<list<callsturnkeyresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<callsturnkeyobject>> }
    ///Creates an instance of callsturnkeyresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeyresponsecollection =
        { errors = None
          messages = None
          success = None
          result = None }

type callsturnkeyresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of callsturnkeyresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeyresponsesingleErrorsSource = { pointer = None }

type callsturnkeyresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsturnkeyresponsesingleErrorsSource> }
    ///Creates an instance of callsturnkeyresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsturnkeyresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsturnkeyresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of callsturnkeyresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeyresponsesingleMessagesSource = { pointer = None }

type callsturnkeyresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsturnkeyresponsesingleMessagesSource> }
    ///Creates an instance of callsturnkeyresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsturnkeyresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsturnkeyresponsesingle =
    { errors: Option<list<callsturnkeyresponsesingleErrors>>
      messages: Option<list<callsturnkeyresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<callsturnkeyobject> }
    ///Creates an instance of callsturnkeyresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeyresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type callsturnkeysinglewithsecretErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of callsturnkeysinglewithsecretErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeysinglewithsecretErrorsSource = { pointer = None }

type callsturnkeysinglewithsecretErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsturnkeysinglewithsecretErrorsSource> }
    ///Creates an instance of callsturnkeysinglewithsecretErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsturnkeysinglewithsecretErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsturnkeysinglewithsecretMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of callsturnkeysinglewithsecretMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeysinglewithsecretMessagesSource = { pointer = None }

type callsturnkeysinglewithsecretMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<callsturnkeysinglewithsecretMessagesSource> }
    ///Creates an instance of callsturnkeysinglewithsecretMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): callsturnkeysinglewithsecretMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type callsturnkeysinglewithsecret =
    { errors: Option<list<callsturnkeysinglewithsecretErrors>>
      messages: Option<list<callsturnkeysinglewithsecretMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<callsturnkeywithkey> }
    ///Creates an instance of callsturnkeysinglewithsecret with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeysinglewithsecret =
        { errors = None
          messages = None
          success = None
          result = None }

type callsturnkeywithkey =
    { ///The date and time the item was created.
      created: Option<callscreated>
      ///Bearer token
      key: Option<callsturnkey>
      ///The date and time the item was last modified.
      modified: Option<callsmodified>
      ///A short description of a TURN key, not shown to end users.
      name: Option<callsturnkeyname>
      ///A Cloudflare-generated unique identifier for a item.
      uid: Option<callsidentifier> }
    ///Creates an instance of callsturnkeywithkey with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): callsturnkeywithkey =
        { created = None
          key = None
          modified = None
          name = None
          uid = None }

[<RequireQualifiedAccess>]
type CallsAppsList =
    ///List apps response
    | OK of payload: callsappresponsecollection

[<RequireQualifiedAccess>]
type CallsAppsCreateANewApp =
    ///Created a new app
    | Created of payload: callsappresponsesinglewithsecret

[<RequireQualifiedAccess>]
type CallsAppsDeleteApp =
    ///Delete app response
    | OK of payload: callsappresponsesingle

[<RequireQualifiedAccess>]
type CallsAppsRetrieveAppDetails =
    ///Retrieve app details response
    | OK of payload: callsappresponsesingle

[<RequireQualifiedAccess>]
type CallsAppsUpdateAppDetails =
    ///Edit app details response
    | OK of payload: callsappresponsesingle

[<RequireQualifiedAccess>]
type CallsTurnKeyList =
    ///List TURN key response
    | OK of payload: callsturnkeycollection

[<RequireQualifiedAccess>]
type CallsTurnKeyCreate =
    ///Created a new TURN key
    | Created of payload: callsturnkeysinglewithsecret

[<RequireQualifiedAccess>]
type CallsDeleteTurnKey =
    ///Delete TURN key response
    | OK of payload: callsturnkeyresponsesingle

[<RequireQualifiedAccess>]
type CallsRetrieveTurnKeyDetails =
    ///Retrieve TURN key details response
    | OK of payload: callsturnkeyresponsesingle

[<RequireQualifiedAccess>]
type CallsUpdateTurnKey =
    ///Edit TURN key details response
    | OK of payload: callsturnkeyresponsesingle
