namespace rec Fidelity.CloudEdge.Management.D1.Types

///Account identifier tag.
type ``d1account-identifier`` = string
///Specifies the timestamp the resource was created as an ISO8601 string.
type ``d1created-at`` = System.DateTimeOffset
///D1 database identifier (UUID).
type ``d1database-identifier`` = string
///D1 database name.
type ``d1database-name`` = string
type ``d1database-version`` = string
type ``d1file-size`` = float

///Specify the location to restrict the D1 database to run and store data. If this option is present, the location hint is ignored.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type d1jurisdiction =
    | [<CompiledName "eu">] Eu
    | [<CompiledName "fedramp">] Fedramp
    member this.Format() =
        match this with
        | Eu -> "eu"
        | Fedramp -> "fedramp"

///Specify the location to restrict the D1 database to run and store data. If this option is present, the location hint is ignored.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``d1jurisdiction-nullable`` =
    | [<CompiledName "eu">] Eu
    | [<CompiledName "fedramp">] Fedramp
    member this.Format() =
        match this with
        | Eu -> "eu"
        | Fedramp -> "fedramp"

type d1messagesArrayItem =
    { code: int
      message: string }
    ///Creates an instance of d1messagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): d1messagesArrayItem = { code = code; message = message }

type d1messages = list<d1messagesArrayItem>
type d1params = list<string>

///Specify the region to create the D1 primary, if available. If this option is omitted, the D1 will be created as close as possible to the current user.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``d1primary-location-hint`` =
    | [<CompiledName "wnam">] Wnam
    | [<CompiledName "enam">] Enam
    | [<CompiledName "weur">] Weur
    | [<CompiledName "eeur">] Eeur
    | [<CompiledName "apac">] Apac
    | [<CompiledName "oc">] Oc
    member this.Format() =
        match this with
        | Wnam -> "wnam"
        | Enam -> "enam"
        | Weur -> "weur"
        | Eeur -> "eeur"
        | Apac -> "apac"
        | Oc -> "oc"

///The read replication mode for the database. Use 'auto' to create replicas and allow D1 automatically place them around the world, or 'disabled' to not use any database replicas (it can take a few hours for all replicas to be deleted).
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``d1read-replication-mode`` =
    | [<CompiledName "auto">] Auto
    | [<CompiledName "disabled">] Disabled
    member this.Format() =
        match this with
        | Auto -> "auto"
        | Disabled -> "disabled"

///The three letters airport code of the colo that handled the query.
type ``d1served-by-colo`` = string

///Region location hint of the database instance that handled the query.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``d1served-by-region`` =
    | [<CompiledName "WNAM">] WNAM
    | [<CompiledName "ENAM">] ENAM
    | [<CompiledName "WEUR">] WEUR
    | [<CompiledName "EEUR">] EEUR
    | [<CompiledName "APAC">] APAC
    | [<CompiledName "OC">] OC
    member this.Format() =
        match this with
        | WNAM -> "WNAM"
        | ENAM -> "ENAM"
        | WEUR -> "WEUR"
        | EEUR -> "EEUR"
        | APAC -> "APAC"
        | OC -> "OC"

///Your SQL query. Supports multiple statements, joined by semicolons, which will be executed as a batch.
type d1sql = string
type ``d1table-count`` = float
///A bookmark representing a specific state of the database at a specific point in time.
type ``d1time-travel-bookmark`` = string
///An ISO 8601 timestamp used for time travel operations. The database will be restored to the nearest available bookmark at or before this timestamp.
type ``d1time-travel-timestamp`` = System.DateTimeOffset

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

type ``d1api-response-common`` =
    { errors: list<Errors>
      messages: list<Messages>
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of d1api-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>,
                          messages: list<Messages>,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``d1api-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``d1api-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of d1api-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``d1api-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

///The details of the D1 database.
type ``d1database-details-response`` =
    { ///Specifies the timestamp the resource was created as an ISO8601 string.
      created_at: Option<``d1created-at``>
      ///The D1 database's size, in bytes.
      file_size: Option<``d1file-size``>
      ///Specify the location to restrict the D1 database to run and store data. If this option is present, the location hint is ignored.
      jurisdiction: Option<``d1jurisdiction-nullable``>
      ///D1 database name.
      name: Option<``d1database-name``>
      num_tables: Option<``d1table-count``>
      ///Configuration for D1 read replication.
      read_replication: Option<``d1read-replication-details``>
      ///D1 database identifier (UUID).
      uuid: Option<``d1database-identifier``>
      version: Option<``d1database-version``> }
    ///Creates an instance of d1database-details-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``d1database-details-response`` =
        { created_at = None
          file_size = None
          jurisdiction = None
          name = None
          num_tables = None
          read_replication = None
          uuid = None
          version = None }

type ``d1database-response`` =
    { ///Specifies the timestamp the resource was created as an ISO8601 string.
      created_at: Option<``d1created-at``>
      ///Specify the location to restrict the D1 database to run and store data. If this option is present, the location hint is ignored.
      jurisdiction: Option<``d1jurisdiction-nullable``>
      ///D1 database name.
      name: Option<``d1database-name``>
      ///D1 database identifier (UUID).
      uuid: Option<``d1database-identifier``>
      version: Option<``d1database-version``> }
    ///Creates an instance of d1database-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``d1database-response`` =
        { created_at = None
          jurisdiction = None
          name = None
          uuid = None
          version = None }

///Configuration for D1 read replication.
type Readreplication =
    { ///The read replication mode for the database. Use 'auto' to create replicas and allow D1 automatically place them around the world, or 'disabled' to not use any database replicas (it can take a few hours for all replicas to be deleted).
      mode: ``d1read-replication-mode`` }
    ///Creates an instance of Readreplication with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (mode: ``d1read-replication-mode``): Readreplication = { mode = mode }

type ``d1database-update-partial-request-body`` =
    { ///Configuration for D1 read replication.
      read_replication: Option<Readreplication> }
    ///Creates an instance of d1database-update-partial-request-body with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``d1database-update-partial-request-body`` = { read_replication = None }

///Configuration for D1 read replication.
type ``d1database-update-request-bodyReadreplication`` =
    { ///The read replication mode for the database. Use 'auto' to create replicas and allow D1 automatically place them around the world, or 'disabled' to not use any database replicas (it can take a few hours for all replicas to be deleted).
      mode: ``d1read-replication-mode`` }
    ///Creates an instance of d1database-update-request-bodyReadreplication with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (mode: ``d1read-replication-mode``): ``d1database-update-request-bodyReadreplication`` =
        { mode = mode }

type ``d1database-update-request-body`` =
    { ///Configuration for D1 read replication.
      read_replication: ``d1database-update-request-bodyReadreplication`` }
    ///Creates an instance of d1database-update-request-body with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (read_replication: ``d1database-update-request-bodyReadreplication``): ``d1database-update-request-body`` =
        { read_replication = read_replication }

///Various durations for the query.
type Timings =
    { ///The duration of the SQL query execution inside the database. Does not include any network communication.
      sql_duration_ms: Option<float> }
    ///Creates an instance of Timings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Timings = { sql_duration_ms = None }

type ``d1query-meta`` =
    { ///Denotes if the database has been altered in some way, like deleting rows.
      changed_db: Option<bool>
      ///Rough indication of how many rows were modified by the query, as provided by SQLite's `sqlite3_total_changes()`.
      changes: Option<float>
      ///The duration of the SQL query execution inside the database. Does not include any network communication.
      duration: Option<float>
      ///The row ID of the last inserted row in a table with an `INTEGER PRIMARY KEY` as provided by SQLite. Tables created with `WITHOUT ROWID` do not populate this.
      last_row_id: Option<float>
      ///Number of rows read during the SQL query execution, including indices (not all rows are necessarily returned).
      rows_read: Option<float>
      ///Number of rows written during the SQL query execution, including indices.
      rows_written: Option<float>
      ///The three letters airport code of the colo that handled the query.
      served_by_colo: Option<``d1served-by-colo``>
      ///Denotes if the query has been handled by the database primary instance.
      served_by_primary: Option<bool>
      ///Region location hint of the database instance that handled the query.
      served_by_region: Option<``d1served-by-region``>
      ///Size of the database after the query committed, in bytes.
      size_after: Option<float>
      ///Various durations for the query.
      timings: Option<Timings> }
    ///Creates an instance of d1query-meta with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``d1query-meta`` =
        { changed_db = None
          changes = None
          duration = None
          last_row_id = None
          rows_read = None
          rows_written = None
          served_by_colo = None
          served_by_primary = None
          served_by_region = None
          size_after = None
          timings = None }

type ``d1query-result-response`` =
    { meta: Option<``d1query-meta``>
      results: Option<Newtonsoft.Json.Linq.JArray>
      success: Option<bool> }
    ///Creates an instance of d1query-result-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``d1query-result-response`` =
        { meta = None
          results = None
          success = None }

type Results =
    { columns: Option<list<string>>
      rows: Option<list<list<string>>> }
    ///Creates an instance of Results with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Results = { columns = None; rows = None }

type ``d1raw-result-response`` =
    { meta: Option<``d1query-meta``>
      results: Option<Results>
      success: Option<bool> }
    ///Creates an instance of d1raw-result-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``d1raw-result-response`` =
        { meta = None
          results = None
          success = None }

///Configuration for D1 read replication.
type ``d1read-replication-details`` =
    { ///The read replication mode for the database. Use 'auto' to create replicas and allow D1 automatically place them around the world, or 'disabled' to not use any database replicas (it can take a few hours for all replicas to be deleted).
      mode: ``d1read-replication-mode`` }
    ///Creates an instance of d1read-replication-details with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (mode: ``d1read-replication-mode``): ``d1read-replication-details`` = { mode = mode }

///A single query with or without parameters
type ``d1single-query`` =
    { ``params``: Option<d1params>
      ///Your SQL query. Supports multiple statements, joined by semicolons, which will be executed as a batch.
      sql: d1sql }
    ///Creates an instance of d1single-query with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (sql: d1sql): ``d1single-query`` = { ``params`` = None; sql = sql }

///Response from a time travel restore operation.
type ``d1time-travel-restore-response`` =
    { bookmark: Option<Newtonsoft.Json.Linq.JToken>
      ///A message describing the result of the restore operation.
      message: Option<string>
      previous_bookmark: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of d1time-travel-restore-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``d1time-travel-restore-response`` =
        { bookmark = None
          message = None
          previous_bookmark = None }

[<RequireQualifiedAccess>]
type D1ListDatabases =
    ///List D1 databases response
    | OK of payload: string

type D1CreateDatabasePayload =
    { ///Specify the location to restrict the D1 database to run and store data. If this option is present, the location hint is ignored.
      jurisdiction: Option<d1jurisdiction>
      ///D1 database name.
      name: ``d1database-name``
      ///Specify the region to create the D1 primary, if available. If this option is omitted, the D1 will be created as close as possible to the current user.
      primary_location_hint: Option<``d1primary-location-hint``> }
    ///Creates an instance of D1CreateDatabasePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``d1database-name``): D1CreateDatabasePayload =
        { jurisdiction = None
          name = name
          primary_location_hint = None }

[<RequireQualifiedAccess>]
type D1CreateDatabase =
    ///Returns the created D1 database's metadata
    | OK of payload: string

[<RequireQualifiedAccess>]
type D1DeleteDatabase =
    ///Delete D1 database response
    | OK of payload: string

[<RequireQualifiedAccess>]
type D1GetDatabase =
    ///Database details response
    | OK of payload: string

[<RequireQualifiedAccess>]
type D1UpdatePartialDatabase =
    ///Database details response
    | OK of payload: string

[<RequireQualifiedAccess>]
type D1UpdateDatabase =
    ///Database details response
    | OK of payload: string

[<RequireQualifiedAccess>]
type D1QueryDatabase =
    ///Query response
    | OK of payload: string

[<RequireQualifiedAccess>]
type D1RawDatabaseQuery =
    ///Raw query response
    | OK of payload: string
