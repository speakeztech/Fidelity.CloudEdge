namespace rec Fidelity.CloudEdge.Management.Hyperdrive.Types

// Auto-generated stub types (missing from Hawaii output)
type results = string
type your = string

///The name of the Hyperdrive configuration. Used to identify the configuration in the Cloudflare dashboard and API.
type ``hyperdrivehyperdrive-name`` = string
type ``hyperdrivehyperdrive-origin-connection-limit`` = int

///Specifies the URL scheme used to connect to your origin database.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``hyperdrivehyperdrive-scheme`` =
    | [<CompiledName "postgres">] Postgres
    | [<CompiledName "postgresql">] Postgresql
    | [<CompiledName "mysql">] Mysql
    member this.Format() =
        match this with
        | Postgres -> "postgres"
        | Postgresql -> "postgresql"
        | Mysql -> "mysql"

///Define configurations using a unique string identifier.
type hyperdriveidentifier = string

type hyperdrivemessagesArrayItem =
    { code: int
      message: string }
    ///Creates an instance of hyperdrivemessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): hyperdrivemessagesArrayItem = { code = code; message = message }

type hyperdrivemessages = list<hyperdrivemessagesArrayItem>

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

type ``hyperdriveapi-response-collection`` =
    { errors: list<Errors>
      messages: list<Messages>
      result: Newtonsoft.Json.Linq.JObject
      ///Return the status of the API call success.
      success: bool
      result_info: Option<hyperdriveresultinfo> }
    ///Creates an instance of hyperdriveapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>,
                          messages: list<Messages>,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``hyperdriveapi-response-collection`` =
        { errors = errors
          messages = messages
          result = result
          success = success
          result_info = None }

type ``hyperdriveapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of hyperdriveapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``hyperdriveapi-response-commonErrors`` =
        { code = code; message = message }

type ``hyperdriveapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of hyperdriveapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``hyperdriveapi-response-commonMessages`` =
        { code = code; message = message }

type ``hyperdriveapi-response-common`` =
    { errors: list<``hyperdriveapi-response-commonErrors``>
      messages: list<``hyperdriveapi-response-commonMessages``>
      result: Newtonsoft.Json.Linq.JObject
      ///Return the status of the API call success.
      success: bool }
    ///Creates an instance of hyperdriveapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``hyperdriveapi-response-commonErrors``>,
                          messages: list<``hyperdriveapi-response-commonMessages``>,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``hyperdriveapi-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``hyperdriveapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Return the status of the API call success.
      success: bool }
    ///Creates an instance of hyperdriveapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``hyperdriveapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``hyperdriveapi-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of hyperdriveapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``hyperdriveapi-response-singleErrors`` =
        { code = code; message = message }

type ``hyperdriveapi-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of hyperdriveapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``hyperdriveapi-response-singleMessages`` =
        { code = code; message = message }

type ``hyperdriveapi-response-single`` =
    { errors: Option<list<``hyperdriveapi-response-singleErrors``>>
      messages: Option<list<``hyperdriveapi-response-singleMessages``>>
      result: Option<Newtonsoft.Json.Linq.JObject>
      ///Return the status of the API call success.
      success: Option<bool> }
    ///Creates an instance of hyperdriveapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``hyperdriveapi-response-single`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``hyperdrivehyperdrive-caching-common`` =
    { ///Set to true to disable caching of SQL responses. Default is false.
      disabled: Option<bool> }
    ///Creates an instance of hyperdrivehyperdrive-caching-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``hyperdrivehyperdrive-caching-common`` = { disabled = None }

type ``hyperdrivehyperdrive-caching-disabled`` =
    { ///Set to true to disable caching of SQL responses. Default is false.
      disabled: Option<bool> }
    ///Creates an instance of hyperdrivehyperdrive-caching-disabled with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``hyperdrivehyperdrive-caching-disabled`` = { disabled = None }

type ``hyperdrivehyperdrive-caching-enabled`` =
    { ///Set to true to disable caching of SQL responses. Default is false.
      disabled: Option<bool>
      ///Specify the maximum duration (in seconds) items should persist in the cache. Defaults to 60 seconds if not specified.
      max_age: Option<int>
      ///Specify the number of seconds the cache may serve a stale response. Defaults to 15 seconds if not specified.
      stale_while_revalidate: Option<int> }
    ///Creates an instance of hyperdrivehyperdrive-caching-enabled with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``hyperdrivehyperdrive-caching-enabled`` =
        { disabled = None
          max_age = None
          stale_while_revalidate = None }

type ``hyperdrivehyperdrive-config`` =
    { caching: Option<Newtonsoft.Json.Linq.JObject>
      ///Defines the creation time of the Hyperdrive configuration.
      created_on: Option<System.DateTimeOffset>
      ///Define configurations using a unique string identifier.
      id: hyperdriveidentifier
      ///Defines the last modified time of the Hyperdrive configuration.
      modified_on: Option<System.DateTimeOffset>
      mtls: Option<``hyperdrivehyperdrive-mtls``>
      ///The name of the Hyperdrive configuration. Used to identify the configuration in the Cloudflare dashboard and API.
      name: ``hyperdrivehyperdrive-name``
      origin: Newtonsoft.Json.Linq.JObject
      ///The (soft) maximum number of connections the Hyperdrive is allowed to make to the origin database.
      origin_connection_limit: Option<``hyperdrivehyperdrive-origin-connection-limit``> }
    ///Creates an instance of hyperdrivehyperdrive-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: hyperdriveidentifier,
                          name: ``hyperdrivehyperdrive-name``,
                          origin: Newtonsoft.Json.Linq.JObject): ``hyperdrivehyperdrive-config`` =
        { caching = None
          created_on = None
          id = id
          modified_on = None
          mtls = None
          name = name
          origin = origin
          origin_connection_limit = None }

type Origin = Map<string, Newtonsoft.Json.Linq.JToken>

type ``hyperdrivehyperdrive-config-patch`` =
    { caching: Option<Newtonsoft.Json.Linq.JObject>
      mtls: Option<``hyperdrivehyperdrive-mtls``>
      ///The name of the Hyperdrive configuration. Used to identify the configuration in the Cloudflare dashboard and API.
      name: Option<``hyperdrivehyperdrive-name``>
      origin: Option<Origin>
      ///The (soft) maximum number of connections the Hyperdrive is allowed to make to the origin database.
      origin_connection_limit: Option<``hyperdrivehyperdrive-origin-connection-limit``> }
    ///Creates an instance of hyperdrivehyperdrive-config-patch with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``hyperdrivehyperdrive-config-patch`` =
        { caching = None
          mtls = None
          name = None
          origin = None
          origin_connection_limit = None }

type ``hyperdrivehyperdrive-config-response`` =
    { caching: Newtonsoft.Json.Linq.JObject
      ///Defines the creation time of the Hyperdrive configuration.
      created_on: Option<System.DateTimeOffset>
      ///Define configurations using a unique string identifier.
      id: Option<hyperdriveidentifier>
      ///Defines the last modified time of the Hyperdrive configuration.
      modified_on: Option<System.DateTimeOffset>
      mtls: Option<``hyperdrivehyperdrive-mtls``>
      ///The name of the Hyperdrive configuration. Used to identify the configuration in the Cloudflare dashboard and API.
      name: Option<``hyperdrivehyperdrive-name``>
      origin: Option<Newtonsoft.Json.Linq.JObject>
      ///The (soft) maximum number of connections the Hyperdrive is allowed to make to the origin database.
      origin_connection_limit: Option<``hyperdrivehyperdrive-origin-connection-limit``> }
    ///Creates an instance of hyperdrivehyperdrive-config-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (caching: Newtonsoft.Json.Linq.JObject): ``hyperdrivehyperdrive-config-response`` =
        { caching = caching
          created_on = None
          id = None
          modified_on = None
          mtls = None
          name = None
          origin = None
          origin_connection_limit = None }

type ``hyperdrivehyperdrive-database`` =
    { ///Set the name of your origin database.
      database: Option<string>
      ///Set the password needed to access your origin database. The API never returns this write-only value.
      password: Option<string>
      ///Specifies the URL scheme used to connect to your origin database.
      scheme: Option<``hyperdrivehyperdrive-scheme``>
      ///Set the user of your origin database.
      user: Option<string> }
    ///Creates an instance of hyperdrivehyperdrive-database with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``hyperdrivehyperdrive-database`` =
        { database = None
          password = None
          scheme = None
          user = None }

type ``hyperdrivehyperdrive-database-full`` =
    { ///Set the name of your origin database.
      database: string
      ///Set the password needed to access your origin database. The API never returns this write-only value.
      password: string
      ///Specifies the URL scheme used to connect to your origin database.
      scheme: ``hyperdrivehyperdrive-scheme``
      ///Set the user of your origin database.
      user: string }
    ///Creates an instance of hyperdrivehyperdrive-database-full with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (database: string, password: string, scheme: ``hyperdrivehyperdrive-scheme``, user: string): ``hyperdrivehyperdrive-database-full`` =
        { database = database
          password = password
          scheme = scheme
          user = user }

type ``hyperdrivehyperdrive-mtls`` =
    { ///Define CA certificate ID obtained after uploading CA cert.
      ca_certificate_id: Option<string>
      ///Define mTLS certificate ID obtained after uploading client cert.
      mtls_certificate_id: Option<string>
      ///Set SSL mode to 'require', 'verify-ca', or 'verify-full' to verify the CA.
      sslmode: Option<string> }
    ///Creates an instance of hyperdrivehyperdrive-mtls with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``hyperdrivehyperdrive-mtls`` =
        { ca_certificate_id = None
          mtls_certificate_id = None
          sslmode = None }

type ``hyperdrivehyperdrive-origin`` =
    { ///Set the name of your origin database.
      database: Option<string>
      ///Set the password needed to access your origin database. The API never returns this write-only value.
      password: Option<string>
      ///Specifies the URL scheme used to connect to your origin database.
      scheme: Option<``hyperdrivehyperdrive-scheme``>
      ///Set the user of your origin database.
      user: Option<string> }
    ///Creates an instance of hyperdrivehyperdrive-origin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``hyperdrivehyperdrive-origin`` =
        { database = None
          password = None
          scheme = None
          user = None }

type ``hyperdriveinternet-origin`` =
    { ///Defines the host (hostname or IP) of your origin database.
      host: string
      ///Defines the port of your origin database. Defaults to 5432 for PostgreSQL or 3306 for MySQL if not specified.
      port: int }
    ///Creates an instance of hyperdriveinternet-origin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (host: string, port: int): ``hyperdriveinternet-origin`` = { host = host; port = port }

type ``hyperdriveover-access-origin`` =
    { ///Defines the Client ID of the Access token to use when connecting to the origin database.
      access_client_id: string
      ///Defines the Client Secret of the Access Token to use when connecting to the origin database. The API never returns this write-only value.
      access_client_secret: string
      ///Defines the host (hostname or IP) of your origin database.
      host: string }
    ///Creates an instance of hyperdriveover-access-origin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (access_client_id: string, access_client_secret: string, host: string): ``hyperdriveover-access-origin`` =
        { access_client_id = access_client_id
          access_client_secret = access_client_secret
          host = host }

type hyperdriveresultinfo =
    { ///Defines the total number of results for the requested service.
      count: Option<float>
      ///Defines the current page within paginated list of results.
      page: Option<float>
      ///Defines the number of results per page of results.
      per_page: Option<float>
      ///Defines the total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of hyperdriveresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): hyperdriveresultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``list-hyperdriveresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of list-hyperdriveresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-hyperdriveresponseErrors`` =
        { code = code; message = message }

type ``list-hyperdriveresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of list-hyperdriveresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-hyperdriveresponseMessages`` =
        { code = code; message = message }

type ``list-hyperdriveresponse`` =
    { errors: list<``list-hyperdriveresponseErrors``>
      messages: list<``list-hyperdriveresponseMessages``>
      result: list<``hyperdrivehyperdrive-config-response``>
      ///Return the status of the API call success.
      success: bool
      result_info: Option<hyperdriveresultinfo> }
    ///Creates an instance of list-hyperdriveresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``list-hyperdriveresponseErrors``>,
                          messages: list<``list-hyperdriveresponseMessages``>,
                          result: list<``hyperdrivehyperdrive-config-response``>,
                          success: bool): ``list-hyperdriveresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success
          result_info = None }

type ``create-hyperdriveresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of create-hyperdriveresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-hyperdriveresponseErrors`` =
        { code = code; message = message }

type ``create-hyperdriveresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of create-hyperdriveresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-hyperdriveresponseMessages`` =
        { code = code; message = message }

type ``create-hyperdriveresponse`` =
    { errors: list<``create-hyperdriveresponseErrors``>
      messages: list<``create-hyperdriveresponseMessages``>
      result: ``hyperdrivehyperdrive-config-response``
      ///Return the status of the API call success.
      success: bool }
    ///Creates an instance of create-hyperdriveresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``create-hyperdriveresponseErrors``>,
                          messages: list<``create-hyperdriveresponseMessages``>,
                          result: ``hyperdrivehyperdrive-config-response``,
                          success: bool): ``create-hyperdriveresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``delete-hyperdriveresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of delete-hyperdriveresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``delete-hyperdriveresponseErrors`` =
        { code = code; message = message }

type ``delete-hyperdriveresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of delete-hyperdriveresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``delete-hyperdriveresponseMessages`` =
        { code = code; message = message }

type ``delete-hyperdriveresponse`` =
    { errors: list<``delete-hyperdriveresponseErrors``>
      messages: list<``delete-hyperdriveresponseMessages``>
      result: Newtonsoft.Json.Linq.JObject
      ///Return the status of the API call success.
      success: bool }
    ///Creates an instance of delete-hyperdriveresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``delete-hyperdriveresponseErrors``>,
                          messages: list<``delete-hyperdriveresponseMessages``>,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``delete-hyperdriveresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``get-hyperdriveresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of get-hyperdriveresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-hyperdriveresponseErrors`` =
        { code = code; message = message }

type ``get-hyperdriveresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of get-hyperdriveresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-hyperdriveresponseMessages`` =
        { code = code; message = message }

type ``get-hyperdriveresponse`` =
    { errors: list<``get-hyperdriveresponseErrors``>
      messages: list<``get-hyperdriveresponseMessages``>
      result: ``hyperdrivehyperdrive-config-response``
      ///Return the status of the API call success.
      success: bool }
    ///Creates an instance of get-hyperdriveresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``get-hyperdriveresponseErrors``>,
                          messages: list<``get-hyperdriveresponseMessages``>,
                          result: ``hyperdrivehyperdrive-config-response``,
                          success: bool): ``get-hyperdriveresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``patch-hyperdriveresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of patch-hyperdriveresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``patch-hyperdriveresponseErrors`` =
        { code = code; message = message }

type ``patch-hyperdriveresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of patch-hyperdriveresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``patch-hyperdriveresponseMessages`` =
        { code = code; message = message }

type ``patch-hyperdriveresponse`` =
    { errors: list<``patch-hyperdriveresponseErrors``>
      messages: list<``patch-hyperdriveresponseMessages``>
      result: ``hyperdrivehyperdrive-config-response``
      ///Return the status of the API call success.
      success: bool }
    ///Creates an instance of patch-hyperdriveresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``patch-hyperdriveresponseErrors``>,
                          messages: list<``patch-hyperdriveresponseMessages``>,
                          result: ``hyperdrivehyperdrive-config-response``,
                          success: bool): ``patch-hyperdriveresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``update-hyperdriveresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of update-hyperdriveresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``update-hyperdriveresponseErrors`` =
        { code = code; message = message }

type ``update-hyperdriveresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of update-hyperdriveresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``update-hyperdriveresponseMessages`` =
        { code = code; message = message }

type ``update-hyperdriveresponse`` =
    { errors: list<``update-hyperdriveresponseErrors``>
      messages: list<``update-hyperdriveresponseMessages``>
      result: ``hyperdrivehyperdrive-config-response``
      ///Return the status of the API call success.
      success: bool }
    ///Creates an instance of update-hyperdriveresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``update-hyperdriveresponseErrors``>,
                          messages: list<``update-hyperdriveresponseMessages``>,
                          result: ``hyperdrivehyperdrive-config-response``,
                          success: bool): ``update-hyperdriveresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

[<RequireQualifiedAccess>]
type ListHyperdrive =
    ///List Hyperdrives Response.
    | OK of payload: ``list-hyperdriveresponse``
    ///List Hyperdrives Failure Response.
    | BadRequest of payload: ``hyperdriveapi-response-common-failure``

[<RequireQualifiedAccess>]
type CreateHyperdrive =
    ///Create Hyperdrive Response.
    | OK of payload: ``create-hyperdriveresponse``
    ///Create Hyperdrive Failure Response.
    | BadRequest of payload: ``hyperdriveapi-response-common-failure``

[<RequireQualifiedAccess>]
type DeleteHyperdrive =
    ///Delete Hyperdrive Response.
    | OK of payload: ``delete-hyperdriveresponse``
    ///Delete Hyperdrive Failure.
    | BadRequest of payload: ``hyperdriveapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetHyperdrive =
    ///Get Hyperdrive Response.
    | OK of payload: ``get-hyperdriveresponse``
    ///Get Hyperdrive Failure.
    | BadRequest of payload: ``hyperdriveapi-response-common-failure``

[<RequireQualifiedAccess>]
type PatchHyperdrive =
    ///Patch Hyperdrive Response.
    | OK of payload: ``patch-hyperdriveresponse``
    ///Patch Hyperdrive Failure Response.
    | BadRequest of payload: ``hyperdriveapi-response-common-failure``

[<RequireQualifiedAccess>]
type UpdateHyperdrive =
    ///Update Hyperdrive Response.
    | OK of payload: ``update-hyperdriveresponse``
    ///Update Hyperdrive Failure Response.
    | BadRequest of payload: ``hyperdriveapi-response-common-failure``
