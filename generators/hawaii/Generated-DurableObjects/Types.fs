namespace rec Fidelity.CloudEdge.Management.DurableObjects.Types

// Auto-generated stub types (missing from Hawaii output)
type results = string

///Opaque token indicating the position from which to continue when requesting the next set of records. A valid value for the cursor can be obtained from the cursors object in the result_info structure.
type workerscursor = string
///Identifier.
type workersidentifier = string

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
///ID of the namespace.
type ``workersschemas-id`` = string

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

type ``workersapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<Resultinfo> }
    ///Creates an instance of workersapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workersapi-response-collection`` =
        { errors = None
          messages = None
          success = None
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

type workersobject =
    { ///Whether the Durable Object has stored data.
      hasStoredData: Option<bool>
      ///ID of the Durable Object.
      id: Option<string> }
    ///Creates an instance of workersobject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): workersobject = { hasStoredData = None; id = None }

type ``durable-objects-namespace-list-namespacesresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of durable-objects-namespace-list-namespacesresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``durable-objects-namespace-list-namespacesresponseErrorsSource`` = { pointer = None }

type ``durable-objects-namespace-list-namespacesresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``durable-objects-namespace-list-namespacesresponseErrorsSource``> }
    ///Creates an instance of durable-objects-namespace-list-namespacesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``durable-objects-namespace-list-namespacesresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``durable-objects-namespace-list-namespacesresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of durable-objects-namespace-list-namespacesresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``durable-objects-namespace-list-namespacesresponseMessagesSource`` = { pointer = None }

type ``durable-objects-namespace-list-namespacesresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``durable-objects-namespace-list-namespacesresponseMessagesSource``> }
    ///Creates an instance of durable-objects-namespace-list-namespacesresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``durable-objects-namespace-list-namespacesresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``durable-objects-namespace-list-namespacesresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of durable-objects-namespace-list-namespacesresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``durable-objects-namespace-list-namespacesresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``durable-objects-namespace-list-namespacesresponse`` =
    { errors: list<``durable-objects-namespace-list-namespacesresponseErrors``>
      messages: list<``durable-objects-namespace-list-namespacesresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``durable-objects-namespace-list-namespacesresponseResultinfo``>
      result: Option<list<workersnamespace>> }
    ///Creates an instance of durable-objects-namespace-list-namespacesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``durable-objects-namespace-list-namespacesresponseErrors``>,
                          messages: list<``durable-objects-namespace-list-namespacesresponseMessages``>,
                          success: bool): ``durable-objects-namespace-list-namespacesresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``durable-objects-namespace-list-objectsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of durable-objects-namespace-list-objectsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``durable-objects-namespace-list-objectsresponseErrorsSource`` = { pointer = None }

type ``durable-objects-namespace-list-objectsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``durable-objects-namespace-list-objectsresponseErrorsSource``> }
    ///Creates an instance of durable-objects-namespace-list-objectsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``durable-objects-namespace-list-objectsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``durable-objects-namespace-list-objectsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of durable-objects-namespace-list-objectsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``durable-objects-namespace-list-objectsresponseMessagesSource`` = { pointer = None }

type ``durable-objects-namespace-list-objectsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``durable-objects-namespace-list-objectsresponseMessagesSource``> }
    ///Creates an instance of durable-objects-namespace-list-objectsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``durable-objects-namespace-list-objectsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``durable-objects-namespace-list-objectsresponseResultinfo`` =
    { ///Total results returned based on your list parameters.
      count: Option<float>
      ///Opaque token indicating the position from which to continue when requesting the next set of records. A valid value for the cursor can be obtained from the cursors object in the result_info structure.
      cursor: Option<workerscursor> }
    ///Creates an instance of durable-objects-namespace-list-objectsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``durable-objects-namespace-list-objectsresponseResultinfo`` =
        { count = None; cursor = None }

type ``durable-objects-namespace-list-objectsresponse`` =
    { errors: list<``durable-objects-namespace-list-objectsresponseErrors``>
      messages: list<``durable-objects-namespace-list-objectsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``durable-objects-namespace-list-objectsresponseResultinfo``>
      result: Option<list<workersobject>> }
    ///Creates an instance of durable-objects-namespace-list-objectsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``durable-objects-namespace-list-objectsresponseErrors``>,
                          messages: list<``durable-objects-namespace-list-objectsresponseMessages``>,
                          success: bool): ``durable-objects-namespace-list-objectsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

[<RequireQualifiedAccess>]
type DurableObjectsNamespaceListNamespaces =
    ///List Namespaces response.
    | OK of payload: ``durable-objects-namespace-list-namespacesresponse``
    ///List Namespaces response failure.
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type DurableObjectsNamespaceListObjects =
    ///List Objects response.
    | OK of payload: ``durable-objects-namespace-list-objectsresponse``
    ///List Objects response failure.
    | BadRequest of payload: string
