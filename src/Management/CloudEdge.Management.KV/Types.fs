namespace rec Fidelity.CloudEdge.Management.KV.Types

type ``workers-kvbulkdelete`` = list<``workers-kvkeynamebulk``>

type ``workers-kvbulkwriteArrayItem`` =
    { ///Indicates whether or not the server should base64 decode the value before storing it. Useful for writing values that wouldn't otherwise be valid JSON strings, such as images.
      base64: Option<bool>
      ///Expires the key at a certain time, measured in number of seconds since the UNIX epoch.
      expiration: Option<``workers-kvexpiration``>
      ///Expires the key after a number of seconds. Must be at least 60.
      expiration_ttl: Option<``workers-kvexpirationttl``>
      ///A key's name. The name may be at most 512 bytes. All printable, non-whitespace characters are valid.
      key: ``workers-kvkeynamebulk``
      metadata: Option<Newtonsoft.Json.Linq.JToken>
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
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``workers-kvresultinfo``> }
    ///Creates an instance of workers-kvapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workers-kvapi-response-collection`` =
        { errors = None
          messages = None
          success = None
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
    { errors: Option<list<``workers-kvapi-response-common-no-resultErrors``>>
      messages: Option<list<``workers-kvapi-response-common-no-resultMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of workers-kvapi-response-common-no-result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``workers-kvapi-response-common-no-result`` =
        { errors = None
          messages = None
          success = None
          result = None }

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
      metadata: Option<Newtonsoft.Json.Linq.JToken>
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

[<RequireQualifiedAccess>]
type WorkersKvNamespaceListNamespaces =
    ///List Namespaces response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceCreateANamespace =
    ///Create a Namespace response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceRemoveANamespace =
    ///Remove a Namespace response.
    | OK of payload: ``workers-kvapi-response-common-no-result``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceGetANamespace =
    ///Get a Namespace response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceRenameANamespace =
    ///Rename a Namespace response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceDeleteMultipleKeyValuePairsDeprecated =
    ///Delete multiple key-value pairs response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceWriteMultipleKeyValuePairs =
    ///Write multiple key-value pairs response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceListANamespace'SKeys =
    ///List a Namespace's Keys response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceReadTheMetadataForAKey =
    ///Read the metadata for a key response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceDeleteKeyValuePair =
    ///Delete key-value pair response.
    | OK of payload: ``workers-kvapi-response-common-no-result``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceReadKeyValuePair =
    ///Read key-value pair response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceWriteKeyValuePairWithMetadata =
    ///Write key-value pair with metadata response.
    | OK of payload: ``workers-kvapi-response-common-no-result``
