namespace rec Fidelity.CloudEdge.Management.KV.Types

// Auto-generated type aliases (Hawaii normalization fix)
type ``workers-kv_key_name_bulk`` = ``workers-kvkeynamebulk``

// Auto-generated stub types (missing from Hawaii output)
type keys = string
type results = string
type seconds = string
type ``workers-kvvalue`` = string

type ``workers-kvbulkdelete`` = list<``workers-kv_key_name_bulk``>

type ``workers-kvbulkwriteArrayItem`` =
    { ///Indicates whether or not the server should base64 decode the value before storing it. Useful for writing values that wouldn't otherwise be valid JSON strings, such as images.
      base64: Option<bool>
      ///Expires the key at a certain time, measured in number of seconds since the UNIX epoch.
      expiration: Option<``workers-kvexpiration``>
      ///Expires the key after a number of seconds. Must be at least 60.
      expiration_ttl: Option<``workers-kvexpirationttl``>
      ///A key's name. The name may be at most 512 bytes. All printable, non-whitespace characters are valid.
      key: ``workers-kvkeynamebulk``
      ///Arbitrary JSON that is associated with a key.
      metadata: Option<``workers-kvlistmetadata``>
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
    { errors: list<Errors>
      messages: list<Messages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``workers-kvresultinfo``> }
    ///Creates an instance of workers-kvapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>, messages: list<Messages>, success: bool): ``workers-kvapi-response-collection`` =
        { errors = errors
          messages = messages
          success = success
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
    { errors: list<``workers-kvapi-response-common-no-resultErrors``>
      messages: list<``workers-kvapi-response-common-no-resultMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of workers-kvapi-response-common-no-result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kvapi-response-common-no-resultErrors``>,
                          messages: list<``workers-kvapi-response-common-no-resultMessages``>,
                          success: bool): ``workers-kvapi-response-common-no-result`` =
        { errors = errors
          messages = messages
          success = success
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
      ///Arbitrary JSON that is associated with a key.
      metadata: Option<``workers-kvlistmetadata``>
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

type ``workers-kv-namespace-list-namespacesresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-list-namespacesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-list-namespacesresponseErrors`` =
        { code = code; message = message }

type ``workers-kv-namespace-list-namespacesresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-list-namespacesresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-list-namespacesresponseMessages`` =
        { code = code; message = message }

type ``workers-kv-namespace-list-namespacesresponse`` =
    { errors: list<``workers-kv-namespace-list-namespacesresponseErrors``>
      messages: list<``workers-kv-namespace-list-namespacesresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``workers-kvresultinfo``>
      result: Option<list<``workers-kvnamespace``>> }
    ///Creates an instance of workers-kv-namespace-list-namespacesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kv-namespace-list-namespacesresponseErrors``>,
                          messages: list<``workers-kv-namespace-list-namespacesresponseMessages``>,
                          success: bool): ``workers-kv-namespace-list-namespacesresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``workers-kv-namespace-create-a-namespaceresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-create-a-namespaceresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-create-a-namespaceresponseErrors`` =
        { code = code; message = message }

type ``workers-kv-namespace-create-a-namespaceresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-create-a-namespaceresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-create-a-namespaceresponseMessages`` =
        { code = code; message = message }

type ``workers-kv-namespace-create-a-namespaceresponse`` =
    { errors: list<``workers-kv-namespace-create-a-namespaceresponseErrors``>
      messages: list<``workers-kv-namespace-create-a-namespaceresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``workers-kvnamespace``> }
    ///Creates an instance of workers-kv-namespace-create-a-namespaceresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kv-namespace-create-a-namespaceresponseErrors``>,
                          messages: list<``workers-kv-namespace-create-a-namespaceresponseMessages``>,
                          success: bool): ``workers-kv-namespace-create-a-namespaceresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workers-kv-namespace-get-a-namespaceresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-get-a-namespaceresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-get-a-namespaceresponseErrors`` =
        { code = code; message = message }

type ``workers-kv-namespace-get-a-namespaceresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-get-a-namespaceresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-get-a-namespaceresponseMessages`` =
        { code = code; message = message }

type ``workers-kv-namespace-get-a-namespaceresponse`` =
    { errors: list<``workers-kv-namespace-get-a-namespaceresponseErrors``>
      messages: list<``workers-kv-namespace-get-a-namespaceresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``workers-kvnamespace``> }
    ///Creates an instance of workers-kv-namespace-get-a-namespaceresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kv-namespace-get-a-namespaceresponseErrors``>,
                          messages: list<``workers-kv-namespace-get-a-namespaceresponseMessages``>,
                          success: bool): ``workers-kv-namespace-get-a-namespaceresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workers-kv-namespace-rename-a-namespaceresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-rename-a-namespaceresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-rename-a-namespaceresponseErrors`` =
        { code = code; message = message }

type ``workers-kv-namespace-rename-a-namespaceresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-rename-a-namespaceresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-rename-a-namespaceresponseMessages`` =
        { code = code; message = message }

type ``workers-kv-namespace-rename-a-namespaceresponse`` =
    { errors: list<``workers-kv-namespace-rename-a-namespaceresponseErrors``>
      messages: list<``workers-kv-namespace-rename-a-namespaceresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: ``workers-kvnamespace`` }
    ///Creates an instance of workers-kv-namespace-rename-a-namespaceresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kv-namespace-rename-a-namespaceresponseErrors``>,
                          messages: list<``workers-kv-namespace-rename-a-namespaceresponseMessages``>,
                          success: bool,
                          result: ``workers-kvnamespace``): ``workers-kv-namespace-rename-a-namespaceresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseErrors`` =
        { code = code; message = message }

type ``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseMessages`` =
        { code = code; message = message }

type ``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponse`` =
    { errors: list<``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseErrors``>
      messages: list<``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``workers-kvbulk-result``> }
    ///Creates an instance of workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseErrors``>,
                          messages: list<``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponseMessages``>,
                          success: bool): ``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workers-kv-namespace-write-multiple-key-value-pairsresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-write-multiple-key-value-pairsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-write-multiple-key-value-pairsresponseErrors`` =
        { code = code; message = message }

type ``workers-kv-namespace-write-multiple-key-value-pairsresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-write-multiple-key-value-pairsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-write-multiple-key-value-pairsresponseMessages`` =
        { code = code; message = message }

type ``workers-kv-namespace-write-multiple-key-value-pairsresponse`` =
    { errors: list<``workers-kv-namespace-write-multiple-key-value-pairsresponseErrors``>
      messages: list<``workers-kv-namespace-write-multiple-key-value-pairsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``workers-kvbulk-result``> }
    ///Creates an instance of workers-kv-namespace-write-multiple-key-value-pairsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kv-namespace-write-multiple-key-value-pairsresponseErrors``>,
                          messages: list<``workers-kv-namespace-write-multiple-key-value-pairsresponseMessages``>,
                          success: bool): ``workers-kv-namespace-write-multiple-key-value-pairsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``workers-kv-namespace-list-a-namespace-s-keysresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-list-a-namespace-s-keysresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-list-a-namespace-s-keysresponseErrors`` =
        { code = code; message = message }

type ``workers-kv-namespace-list-a-namespace-s-keysresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-list-a-namespace-s-keysresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-list-a-namespace-s-keysresponseMessages`` =
        { code = code; message = message }

type ``workers-kv-namespace-list-a-namespace-s-keysresponse`` =
    { errors: list<``workers-kv-namespace-list-a-namespace-s-keysresponseErrors``>
      messages: list<``workers-kv-namespace-list-a-namespace-s-keysresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<list<``workers-kvkey``>>
      result_info: Option<``workers-kvcursorresultinfo``> }
    ///Creates an instance of workers-kv-namespace-list-a-namespace-s-keysresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kv-namespace-list-a-namespace-s-keysresponseErrors``>,
                          messages: list<``workers-kv-namespace-list-a-namespace-s-keysresponseMessages``>,
                          success: bool): ``workers-kv-namespace-list-a-namespace-s-keysresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``workers-kv-namespace-read-the-metadata-for-a-keyresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-read-the-metadata-for-a-keyresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-read-the-metadata-for-a-keyresponseErrors`` =
        { code = code; message = message }

type ``workers-kv-namespace-read-the-metadata-for-a-keyresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of workers-kv-namespace-read-the-metadata-for-a-keyresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``workers-kv-namespace-read-the-metadata-for-a-keyresponseMessages`` =
        { code = code; message = message }

type ``workers-kv-namespace-read-the-metadata-for-a-keyresponse`` =
    { errors: list<``workers-kv-namespace-read-the-metadata-for-a-keyresponseErrors``>
      messages: list<``workers-kv-namespace-read-the-metadata-for-a-keyresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      ///Arbitrary JSON that is associated with a key.
      result: Option<``workers-kvlistmetadata``> }
    ///Creates an instance of workers-kv-namespace-read-the-metadata-for-a-keyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``workers-kv-namespace-read-the-metadata-for-a-keyresponseErrors``>,
                          messages: list<``workers-kv-namespace-read-the-metadata-for-a-keyresponseMessages``>,
                          success: bool): ``workers-kv-namespace-read-the-metadata-for-a-keyresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

[<RequireQualifiedAccess>]
type WorkersKvNamespaceListNamespaces =
    ///List Namespaces response.
    | OK of payload: ``workers-kv-namespace-list-namespacesresponse``
    ///List Namespaces response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceCreateANamespace =
    ///Create a Namespace response.
    | OK of payload: ``workers-kv-namespace-create-a-namespaceresponse``
    ///Create a Namespace response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceRemoveANamespace =
    ///Remove a Namespace response.
    | OK of payload: ``workers-kvapi-response-common-no-result``
    ///Remove a Namespace response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceGetANamespace =
    ///Get a Namespace response.
    | OK of payload: ``workers-kv-namespace-get-a-namespaceresponse``
    ///Get a Namespace response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceRenameANamespace =
    ///Rename a Namespace response.
    | OK of payload: ``workers-kv-namespace-rename-a-namespaceresponse``
    ///Rename a Namespace response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceDeleteMultipleKeyValuePairsDeprecated =
    ///Delete multiple key-value pairs response.
    | OK of payload: ``workers-kv-namespace-delete-multiple-key-value-pairs-deprecatedresponse``
    ///Delete multiple key-value pairs response failure.
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceWriteMultipleKeyValuePairs =
    ///Write multiple key-value pairs response.
    | OK of payload: ``workers-kv-namespace-write-multiple-key-value-pairsresponse``
    ///Write multiple key-value pairs response failure.
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type WorkersKvNamespaceListANamespace'SKeys =
    ///List a Namespace's Keys response.
    | OK of payload: ``workers-kv-namespace-list-a-namespace-s-keysresponse``
    ///List a Namespace's Keys response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceReadTheMetadataForAKey =
    ///Read the metadata for a key response.
    | OK of payload: ``workers-kv-namespace-read-the-metadata-for-a-keyresponse``
    ///Read the metadata for a key response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceDeleteKeyValuePair =
    ///Delete key-value pair response.
    | OK of payload: ``workers-kvapi-response-common-no-result``
    ///Delete key-value pair response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceReadKeyValuePair =
    ///Read key-value pair response.
    | OK of payload: ``workers-kvvalue``
    ///Read key-value pair response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``

[<RequireQualifiedAccess>]
type WorkersKvNamespaceWriteKeyValuePairWithMetadata =
    ///Write key-value pair with metadata response.
    | OK of payload: ``workers-kvapi-response-common-no-result``
    ///Write key-value pair with metadata response failure.
    | BadRequest of payload: ``workers-kvapi-response-common-failure``
