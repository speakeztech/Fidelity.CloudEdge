namespace rec Fidelity.CloudEdge.Management.SecretsStore.Types

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``secrets-storeSecretStatus`` =
    | [<CompiledName "pending">] Pending
    | [<CompiledName "active">] Active
    | [<CompiledName "deleted">] Deleted
    member this.Format() =
        match this with
        | Pending -> "pending"
        | Active -> "active"
        | Deleted -> "deleted"

///Account Identifier
type ``secrets-storeaccountidentifier`` = string
///Freeform text describing the secret
type ``secrets-storecomment`` = string
///Whenthe secret was created.
type ``secrets-storecreated`` = System.DateTimeOffset
///Secret identifier tag.
type ``secrets-storeidentifier`` = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type ``secrets-storemessagesArrayItem`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of secrets-storemessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storemessagesArrayItem`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storemessages`` = list<``secrets-storemessagesArrayItem``>
///When the secret was modified.
type ``secrets-storemodified`` = System.DateTimeOffset
type ``secrets-storequota`` = float
///The list of services that can use this secret.
type ``secrets-storescopes`` = list<string>
///The name of the secret
type ``secrets-storesecretname`` = string
///Store Identifier
type ``secrets-storestoreidentifier`` = string
///The name of the store
type ``secrets-storestorename`` = string
type ``secrets-storeusage`` = float
///The value of the secret. Note that this is 'write only' - no API reponse will provide this value, it is only used to create/modify secrets.
type ``secrets-storevalue`` = string

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

type ``secrets-storeapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<Resultinfo> }
    ///Creates an instance of secrets-storeapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storeapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``secrets-storeapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storeapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storeapi-response-commonErrorsSource`` = { pointer = None }

type ``secrets-storeapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storeapi-response-commonErrorsSource``> }
    ///Creates an instance of secrets-storeapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storeapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storeapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storeapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storeapi-response-commonMessagesSource`` = { pointer = None }

type ``secrets-storeapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storeapi-response-commonMessagesSource``> }
    ///Creates an instance of secrets-storeapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storeapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storeapi-response-common`` =
    { errors: list<``secrets-storeapi-response-commonErrors``>
      messages: list<``secrets-storeapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of secrets-storeapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``secrets-storeapi-response-commonErrors``>,
                          messages: list<``secrets-storeapi-response-commonMessages``>,
                          success: bool): ``secrets-storeapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``secrets-storeapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of secrets-storeapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``secrets-storeapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``secrets-storecreateSecretObject`` =
    { ///Freeform text describing the secret
      comment: Option<``secrets-storecomment``>
      ///The name of the secret
      name: ``secrets-storesecretname``
      ///The list of services that can use this secret.
      scopes: ``secrets-storescopes``
      ///The value of the secret. Note that this is 'write only' - no API reponse will provide this value, it is only used to create/modify secrets.
      value: ``secrets-storevalue`` }
    ///Creates an instance of secrets-storecreateSecretObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``secrets-storesecretname``,
                          scopes: ``secrets-storescopes``,
                          value: ``secrets-storevalue``): ``secrets-storecreateSecretObject`` =
        { comment = None
          name = name
          scopes = scopes
          value = value }

type ``secrets-storecreateStoreObject`` =
    { ///The name of the store
      name: ``secrets-storestorename`` }
    ///Creates an instance of secrets-storecreateStoreObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``secrets-storestorename``): ``secrets-storecreateStoreObject`` = { name = name }

type ``secrets-storedeleteSecretObject`` =
    { ///Secret identifier tag.
      id: ``secrets-storeidentifier`` }
    ///Creates an instance of secrets-storedeleteSecretObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``secrets-storeidentifier``): ``secrets-storedeleteSecretObject`` = { id = id }

type ``secrets-storeduplicateSecretObject`` =
    { ///Freeform text describing the secret
      comment: Option<``secrets-storecomment``>
      ///The name of the secret
      name: ``secrets-storesecretname``
      ///The list of services that can use this secret.
      scopes: ``secrets-storescopes`` }
    ///Creates an instance of secrets-storeduplicateSecretObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``secrets-storesecretname``, scopes: ``secrets-storescopes``): ``secrets-storeduplicateSecretObject`` =
        { comment = None
          name = name
          scopes = scopes }

type ``secrets-storepatchSecretObject`` =
    { ///Freeform text describing the secret
      comment: Option<``secrets-storecomment``>
      ///The list of services that can use this secret.
      scopes: Option<``secrets-storescopes``> }
    ///Creates an instance of secrets-storepatchSecretObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storepatchSecretObject`` = { comment = None; scopes = None }

type ``secrets-storequotaresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storequotaresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storequotaresponseErrorsSource`` = { pointer = None }

type ``secrets-storequotaresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storequotaresponseErrorsSource``> }
    ///Creates an instance of secrets-storequotaresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storequotaresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storequotaresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storequotaresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storequotaresponseMessagesSource`` = { pointer = None }

type ``secrets-storequotaresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storequotaresponseMessagesSource``> }
    ///Creates an instance of secrets-storequotaresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storequotaresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storequotaresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of secrets-storequotaresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storequotaresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``secrets-storequotaresponse`` =
    { errors: Option<list<``secrets-storequotaresponseErrors``>>
      messages: Option<list<``secrets-storequotaresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``secrets-storequotaresponseResultinfo``>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of secrets-storequotaresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storequotaresponse`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``secrets-storesecretObject`` =
    { ///Freeform text describing the secret
      comment: Option<``secrets-storecomment``>
      ///Whenthe secret was created.
      created: ``secrets-storecreated``
      ///Secret identifier tag.
      id: ``secrets-storeidentifier``
      ///When the secret was modified.
      modified: ``secrets-storemodified``
      ///The name of the secret
      name: ``secrets-storesecretname``
      status: ``secrets-storeSecretStatus``
      ///Store Identifier
      store_id: ``secrets-storestoreidentifier`` }
    ///Creates an instance of secrets-storesecretObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created: ``secrets-storecreated``,
                          id: ``secrets-storeidentifier``,
                          modified: ``secrets-storemodified``,
                          name: ``secrets-storesecretname``,
                          status: ``secrets-storeSecretStatus``,
                          store_id: ``secrets-storestoreidentifier``): ``secrets-storesecretObject`` =
        { comment = None
          created = created
          id = id
          modified = modified
          name = name
          status = status
          store_id = store_id }

type ``secrets-storesecretresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storesecretresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storesecretresponseErrorsSource`` = { pointer = None }

type ``secrets-storesecretresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storesecretresponseErrorsSource``> }
    ///Creates an instance of secrets-storesecretresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storesecretresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storesecretresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storesecretresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storesecretresponseMessagesSource`` = { pointer = None }

type ``secrets-storesecretresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storesecretresponseMessagesSource``> }
    ///Creates an instance of secrets-storesecretresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storesecretresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storesecretresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of secrets-storesecretresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storesecretresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``secrets-storesecretresponse`` =
    { errors: Option<list<``secrets-storesecretresponseErrors``>>
      messages: Option<list<``secrets-storesecretresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``secrets-storesecretresponseResultinfo``>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of secrets-storesecretresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storesecretresponse`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``secrets-storesecretsUsageObject`` =
    { secrets: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of secrets-storesecretsUsageObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (secrets: Newtonsoft.Json.Linq.JToken): ``secrets-storesecretsUsageObject`` =
        { secrets = secrets }

type ``secrets-storesecretsresponsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storesecretsresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storesecretsresponsecollectionErrorsSource`` = { pointer = None }

type ``secrets-storesecretsresponsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storesecretsresponsecollectionErrorsSource``> }
    ///Creates an instance of secrets-storesecretsresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storesecretsresponsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storesecretsresponsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storesecretsresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storesecretsresponsecollectionMessagesSource`` = { pointer = None }

type ``secrets-storesecretsresponsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storesecretsresponsecollectionMessagesSource``> }
    ///Creates an instance of secrets-storesecretsresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storesecretsresponsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storesecretsresponsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of secrets-storesecretsresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storesecretsresponsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``secrets-storesecretsresponsecollection`` =
    { errors: Option<list<``secrets-storesecretsresponsecollectionErrors``>>
      messages: Option<list<``secrets-storesecretsresponsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``secrets-storesecretsresponsecollectionResultinfo``>
      result: Option<list<``secrets-storesecretObject``>> }
    ///Creates an instance of secrets-storesecretsresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storesecretsresponsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``secrets-storestoreObject`` =
    { ///Whenthe secret was created.
      created: ``secrets-storecreated``
      ///Store Identifier
      id: ``secrets-storestoreidentifier``
      ///When the secret was modified.
      modified: ``secrets-storemodified``
      ///The name of the store
      name: ``secrets-storestorename`` }
    ///Creates an instance of secrets-storestoreObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created: ``secrets-storecreated``,
                          id: ``secrets-storestoreidentifier``,
                          modified: ``secrets-storemodified``,
                          name: ``secrets-storestorename``): ``secrets-storestoreObject`` =
        { created = created
          id = id
          modified = modified
          name = name }

type ``secrets-storestoreresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storestoreresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storestoreresponseErrorsSource`` = { pointer = None }

type ``secrets-storestoreresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storestoreresponseErrorsSource``> }
    ///Creates an instance of secrets-storestoreresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storestoreresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storestoreresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storestoreresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storestoreresponseMessagesSource`` = { pointer = None }

type ``secrets-storestoreresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storestoreresponseMessagesSource``> }
    ///Creates an instance of secrets-storestoreresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storestoreresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storestoreresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of secrets-storestoreresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storestoreresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``secrets-storestoreresponse`` =
    { errors: Option<list<``secrets-storestoreresponseErrors``>>
      messages: Option<list<``secrets-storestoreresponseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``secrets-storestoreresponseResultinfo``>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of secrets-storestoreresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storestoreresponse`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``secrets-storestoresresponsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storestoresresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storestoresresponsecollectionErrorsSource`` = { pointer = None }

type ``secrets-storestoresresponsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storestoresresponsecollectionErrorsSource``> }
    ///Creates an instance of secrets-storestoresresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storestoresresponsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storestoresresponsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of secrets-storestoresresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storestoresresponsecollectionMessagesSource`` = { pointer = None }

type ``secrets-storestoresresponsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``secrets-storestoresresponsecollectionMessagesSource``> }
    ///Creates an instance of secrets-storestoresresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``secrets-storestoresresponsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``secrets-storestoresresponsecollectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of secrets-storestoresresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storestoresresponsecollectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``secrets-storestoresresponsecollection`` =
    { errors: Option<list<``secrets-storestoresresponsecollectionErrors``>>
      messages: Option<list<``secrets-storestoresresponsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``secrets-storestoresresponsecollectionResultinfo``>
      result: Option<list<``secrets-storestoreObject``>> }
    ///Creates an instance of secrets-storestoresresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``secrets-storestoresresponsecollection`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``secrets-storeusageQuotaObject`` =
    { ///The number of secrets the account is entitlted to use
      quota: ``secrets-storequota``
      ///The number of secrets the account is currently using
      usage: ``secrets-storeusage`` }
    ///Creates an instance of secrets-storeusageQuotaObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (quota: ``secrets-storequota``, usage: ``secrets-storeusage``): ``secrets-storeusageQuotaObject`` =
        { quota = quota; usage = usage }

[<RequireQualifiedAccess>]
type SecretsStoreQuota =
    ///Usage and quota
    | OK of payload: ``secrets-storequotaresponse``

[<RequireQualifiedAccess>]
type SecretsStoreList =
    ///List account stores response
    | OK of payload: ``secrets-storestoresresponsecollection``

[<RequireQualifiedAccess>]
type SecretsStoreCreate =
    ///store details
    | OK of payload: ``secrets-storestoresresponsecollection``

[<RequireQualifiedAccess>]
type SecretsStoreDeleteById =
    ///store details
    | OK of payload: ``secrets-storestoreresponse``

[<RequireQualifiedAccess>]
type SecretsStoreGetStoreById =
    ///store details
    | OK of payload: ``secrets-storestoreresponse``

[<RequireQualifiedAccess>]
type SecretsStoreDeleteBulk =
    ///secret detail
    | OK of payload: ``secrets-storesecretsresponsecollection``

[<RequireQualifiedAccess>]
type SecretsStoreSecretsList =
    ///List store secrets response
    | OK of payload: ``secrets-storesecretsresponsecollection``

[<RequireQualifiedAccess>]
type SecretsStoreSecretCreate =
    ///secret detail
    | OK of payload: ``secrets-storesecretsresponsecollection``

[<RequireQualifiedAccess>]
type SecretsStoreSecretDeleteById =
    ///secret detail
    | OK of payload: ``secrets-storesecretresponse``

[<RequireQualifiedAccess>]
type SecretsStoreGetById =
    ///secret detail
    | OK of payload: ``secrets-storesecretresponse``

[<RequireQualifiedAccess>]
type SecretsStorePatchById =
    ///secret detail
    | OK of payload: ``secrets-storesecretresponse``

[<RequireQualifiedAccess>]
type SecretsStoreDuplicateById =
    ///secret detail
    | OK of payload: ``secrets-storesecretresponse``
