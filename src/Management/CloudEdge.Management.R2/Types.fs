namespace rec Fidelity.CloudEdge.Management.R2.Types

// Auto-generated stub types (missing from Hawaii output)
type ciphers = string
type maintenance = string
type objects = string
type results = string
type storage = string

///Use this to identify the account.
type ``r2-data-catalogaccount-id`` = string

type ``r2-data-catalogapi-response-errorsArrayItem`` =
    { ///Specifies the error code.
      code: int
      ///Describes the error.
      message: string }
    ///Creates an instance of r2-data-catalogapi-response-errorsArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-data-catalogapi-response-errorsArrayItem`` =
        { code = code; message = message }

type ``r2-data-catalogapi-response-errors`` = list<``r2-data-catalogapi-response-errorsArrayItem``>

type ``r2-data-catalogapi-response-messagesArrayItem`` =
    { ///Specifies the message code.
      code: int
      ///Contains the message text.
      message: string }
    ///Creates an instance of r2-data-catalogapi-response-messagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-data-catalogapi-response-messagesArrayItem`` =
        { code = code; message = message }

type ``r2-data-catalogapi-response-messages`` = list<``r2-data-catalogapi-response-messagesArrayItem``>
type ``r2-data-catalogapi-response-success`` = bool
///Specifies the R2 bucket name.
type ``r2-data-catalogbucket-name`` = string

///Specifies the state of maintenance operations.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2-data-catalogcatalog-maintenance-state`` =
    | [<CompiledName "enabled">] Enabled
    | [<CompiledName "disabled">] Disabled
    member this.Format() =
        match this with
        | Enabled -> "enabled"
        | Disabled -> "disabled"

///Indicates the status of the catalog.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2-data-catalogcatalog-status`` =
    | [<CompiledName "active">] Active
    | [<CompiledName "inactive">] Inactive
    member this.Format() =
        match this with
        | Active -> "active"
        | Inactive -> "inactive"

///Sets the target file size for compaction in megabytes. Defaults to "128".
type ``r2-data-catalogcatalog-target-file-size`` = string

///Shows the credential configuration status.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2-data-catalogcredential-status`` =
    | [<CompiledName "present">] Present
    | [<CompiledName "absent">] Absent
    member this.Format() =
        match this with
        | Present -> "present"
        | Absent -> "absent"

///Specifies the hierarchical namespace parts as an array of strings.
///For example, ["bronze", "analytics"] represents the namespace "bronze.analytics".
type ``r2-data-catalognamespace-identifier`` = list<string>

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2-slurperJobStatus`` =
    | [<CompiledName "running">] Running
    | [<CompiledName "paused">] Paused
    | [<CompiledName "aborted">] Aborted
    | [<CompiledName "completed">] Completed
    member this.Format() =
        match this with
        | Running -> "running"
        | Paused -> "paused"
        | Aborted -> "aborted"
        | Completed -> "completed"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2-slurperJurisdiction`` =
    | [<CompiledName "default">] Default
    | [<CompiledName "eu">] Eu
    | [<CompiledName "fedramp">] Fedramp
    member this.Format() =
        match this with
        | Default -> "default"
        | Eu -> "eu"
        | Fedramp -> "fedramp"

type ``r2-slurperapi-v4-errorArrayItem`` =
    { code: int
      message: string }
    ///Creates an instance of r2-slurperapi-v4-errorArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-slurperapi-v4-errorArrayItem`` =
        { code = code; message = message }

type ``r2-slurperapi-v4-error`` = list<``r2-slurperapi-v4-errorArrayItem``>
type ``r2-slurperapi-v4-message`` = list<string>
///Account ID.
type r2accountidentifier = string

///Location of the bucket.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2bucketlocation =
    | [<CompiledName "apac">] Apac
    | [<CompiledName "eeur">] Eeur
    | [<CompiledName "enam">] Enam
    | [<CompiledName "weur">] Weur
    | [<CompiledName "wnam">] Wnam
    | [<CompiledName "oc">] Oc
    member this.Format() =
        match this with
        | Apac -> "apac"
        | Eeur -> "eeur"
        | Enam -> "enam"
        | Weur -> "weur"
        | Wnam -> "wnam"
        | Oc -> "oc"

///Name of the bucket.
type r2bucketname = string
///Name of the custom domain.
type r2domainname = string

type r2errorsArrayItem =
    { code: int
      message: string }
    ///Creates an instance of r2errorsArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): r2errorsArrayItem = { code = code; message = message }

type r2errors = list<r2errorsArrayItem>

///Jurisdiction where objects in this bucket are guaranteed to be stored.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2jurisdiction =
    | [<CompiledName "default">] Default
    | [<CompiledName "eu">] Eu
    | [<CompiledName "fedramp">] Fedramp
    member this.Format() =
        match this with
        | Default -> "default"
        | Eu -> "eu"
        | Fedramp -> "fedramp"

type r2messages = list<string>
///Queue ID.
type r2queueidentifier = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2r2-action`` =
    | [<CompiledName "PutObject">] PutObject
    | [<CompiledName "CopyObject">] CopyObject
    | [<CompiledName "DeleteObject">] DeleteObject
    | [<CompiledName "CompleteMultipartUpload">] CompleteMultipartUpload
    | [<CompiledName "LifecycleDeletion">] LifecycleDeletion
    member this.Format() =
        match this with
        | PutObject -> "PutObject"
        | CopyObject -> "CopyObject"
        | DeleteObject -> "DeleteObject"
        | CompleteMultipartUpload -> "CompleteMultipartUpload"
        | LifecycleDeletion -> "LifecycleDeletion"

///Storage class for newly uploaded objects, unless specified otherwise.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2storageclass =
    | [<CompiledName "Standard">] Standard
    | [<CompiledName "InfrequentAccess">] InfrequentAccess
    member this.Format() =
        match this with
        | Standard -> "Standard"
        | InfrequentAccess -> "InfrequentAccess"

type Errors =
    { ///Specifies the error code.
      code: int
      ///Describes the error.
      message: string }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors = { code = code; message = message }

type Messages =
    { ///Specifies the message code.
      code: int
      ///Contains the message text.
      message: string }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Messages = { code = code; message = message }

type Resultinfo =
    { ///Indicates the number of results in this page.
      count: Option<int>
      ///Specifies the current page number.
      page: Option<int>
      ///Specifies the number of results per page.
      per_page: Option<int>
      ///Specifies the total number of results.
      total_count: Option<int> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``r2-data-catalogapi-response-collection`` =
    { ///Contains errors if the API call was unsuccessful.
      errors: list<Errors>
      ///Contains informational messages.
      messages: list<Messages>
      ///Indicates whether the API call was successful.
      success: ``r2-data-catalogapi-response-success``
      result_info: Option<Resultinfo> }
    ///Creates an instance of r2-data-catalogapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>,
                          messages: list<Messages>,
                          success: ``r2-data-catalogapi-response-success``): ``r2-data-catalogapi-response-collection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None }

type ``r2-data-catalogapi-response-common-failureErrors`` =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of r2-data-catalogapi-response-common-failureErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-data-catalogapi-response-common-failureErrors`` = { code = None; message = None }

type ``r2-data-catalogapi-response-common-failure`` =
    { errors: Option<list<``r2-data-catalogapi-response-common-failureErrors``>>
      messages: Option<Newtonsoft.Json.Linq.JArray>
      success: Option<bool> }
    ///Creates an instance of r2-data-catalogapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-data-catalogapi-response-common-failure`` =
        { errors = None
          messages = None
          success = None }

type ``r2-data-catalogapi-response-singleErrors`` =
    { ///Specifies the error code.
      code: int
      ///Describes the error.
      message: string }
    ///Creates an instance of r2-data-catalogapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-data-catalogapi-response-singleErrors`` =
        { code = code; message = message }

type ``r2-data-catalogapi-response-singleMessages`` =
    { ///Specifies the message code.
      code: int
      ///Contains the message text.
      message: string }
    ///Creates an instance of r2-data-catalogapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-data-catalogapi-response-singleMessages`` =
        { code = code; message = message }

type ``r2-data-catalogapi-response-single`` =
    { ///Contains errors if the API call was unsuccessful.
      errors: list<``r2-data-catalogapi-response-singleErrors``>
      ///Contains informational messages.
      messages: list<``r2-data-catalogapi-response-singleMessages``>
      ///Indicates whether the API call was successful.
      success: ``r2-data-catalogapi-response-success`` }
    ///Creates an instance of r2-data-catalogapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-data-catalogapi-response-singleErrors``>,
                          messages: list<``r2-data-catalogapi-response-singleMessages``>,
                          success: ``r2-data-catalogapi-response-success``): ``r2-data-catalogapi-response-single`` =
        { errors = errors
          messages = messages
          success = success }

///Configures maintenance for the catalog.
type Maintenanceconfig =
    { ///Configures compaction for catalog maintenance.
      compaction: Option<``r2-data-catalogcatalog-compaction-config``>
      ///Configures snapshot expiration settings.
      snapshot_expiration: Option<``r2-data-catalogsnapshot-expiration-config``> }
    ///Creates an instance of Maintenanceconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Maintenanceconfig =
        { compaction = None
          snapshot_expiration = None }

///Contains R2 Data Catalog information.
type ``r2-data-catalogcatalog`` =
    { ///Specifies the associated R2 bucket name.
      bucket: string
      ///Shows the credential configuration status.
      credential_status: Option<string>
      ///Use this to uniquely identify the catalog.
      id: System.Guid
      ///Configures maintenance for the catalog.
      maintenance_config: Option<Maintenanceconfig>
      ///Specifies the catalog name (generated from account and bucket name).
      name: string
      ///Indicates the status of the catalog.
      status: ``r2-data-catalogcatalog-status`` }
    ///Creates an instance of r2-data-catalogcatalog with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket: string, id: System.Guid, name: string, status: ``r2-data-catalogcatalog-status``): ``r2-data-catalogcatalog`` =
        { bucket = bucket
          credential_status = None
          id = id
          maintenance_config = None
          name = name
          status = status }

///Contains response from activating an R2 bucket as a catalog.
type ``r2-data-catalogcatalog-activation-response`` =
    { ///Use this to uniquely identify the activated catalog.
      id: System.Guid
      ///Specifies the name of the activated catalog.
      name: string }
    ///Creates an instance of r2-data-catalogcatalog-activation-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: System.Guid, name: string): ``r2-data-catalogcatalog-activation-response`` =
        { id = id; name = name }

///Configures compaction for catalog maintenance.
type ``r2-data-catalogcatalog-compaction-config`` =
    { ///Specifies the state of maintenance operations.
      state: ``r2-data-catalogcatalog-maintenance-state``
      ///Sets the target file size for compaction in megabytes. Defaults to "128".
      target_size_mb: ``r2-data-catalogcatalog-target-file-size`` }
    ///Creates an instance of r2-data-catalogcatalog-compaction-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (state: ``r2-data-catalogcatalog-maintenance-state``,
                          target_size_mb: ``r2-data-catalogcatalog-target-file-size``): ``r2-data-catalogcatalog-compaction-config`` =
        { state = state
          target_size_mb = target_size_mb }

///Contains request to store catalog credentials.
type ``r2-data-catalogcatalog-credential-request`` =
    { ///Provides the Cloudflare API token for accessing R2.
      token: string }
    ///Creates an instance of r2-data-catalogcatalog-credential-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (token: string): ``r2-data-catalogcatalog-credential-request`` = { token = token }

///Contains the list of catalogs.
type ``r2-data-catalogcatalog-list`` =
    { ///Lists catalogs in the account.
      warehouses: list<``r2-data-catalogcatalog``> }
    ///Creates an instance of r2-data-catalogcatalog-list with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (warehouses: list<``r2-data-catalogcatalog``>): ``r2-data-catalogcatalog-list`` =
        { warehouses = warehouses }

///Configures maintenance for the catalog.
type ``r2-data-catalogcatalog-maintenance-config`` =
    { ///Configures compaction for catalog maintenance.
      compaction: Option<``r2-data-catalogcatalog-compaction-config``>
      ///Configures snapshot expiration settings.
      snapshot_expiration: Option<``r2-data-catalogsnapshot-expiration-config``> }
    ///Creates an instance of r2-data-catalogcatalog-maintenance-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-data-catalogcatalog-maintenance-config`` =
        { compaction = None
          snapshot_expiration = None }

///Contains maintenance configuration and credential status.
type ``r2-data-catalogcatalog-maintenance-config-response`` =
    { ///Shows the credential configuration status.
      credential_status: ``r2-data-catalogcredential-status``
      ///Configures maintenance for the catalog.
      maintenance_config: ``r2-data-catalogcatalog-maintenance-config`` }
    ///Creates an instance of r2-data-catalogcatalog-maintenance-config-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (credential_status: ``r2-data-catalogcredential-status``,
                          maintenance_config: ``r2-data-catalogcatalog-maintenance-config``): ``r2-data-catalogcatalog-maintenance-config-response`` =
        { credential_status = credential_status
          maintenance_config = maintenance_config }

///Contains request to update catalog maintenance configuration.
type ``r2-data-catalogcatalog-maintenance-update-request`` =
    { ///Updates compaction configuration (all fields optional).
      compaction: Option<``r2-data-catalogcompaction-update-params``>
      ///Updates snapshot expiration configuration (all fields optional).
      snapshot_expiration: Option<``r2-data-catalogsnapshot-expiration-update-params``> }
    ///Creates an instance of r2-data-catalogcatalog-maintenance-update-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-data-catalogcatalog-maintenance-update-request`` =
        { compaction = None
          snapshot_expiration = None }

///Updates compaction configuration (all fields optional).
type ``r2-data-catalogcompaction-update-params`` =
    { ///Updates the state optionally.
      state: Option<Newtonsoft.Json.Linq.JToken>
      ///Updates the target file size optionally.
      target_size_mb: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of r2-data-catalogcompaction-update-params with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-data-catalogcompaction-update-params`` = { state = None; target_size_mb = None }

///Contains maintenance update parameters.
type ``r2-data-catalogmaintenance-update-params`` =
    { ///Updates compaction configuration (all fields optional).
      compaction: Option<``r2-data-catalogcompaction-update-params``>
      ///Updates snapshot expiration configuration (all fields optional).
      snapshot_expiration: Option<``r2-data-catalogsnapshot-expiration-update-params``> }
    ///Creates an instance of r2-data-catalogmaintenance-update-params with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-data-catalogmaintenance-update-params`` =
        { compaction = None
          snapshot_expiration = None }

///Contains namespace with metadata details.
type ``r2-data-catalognamespace-details`` =
    { ///Indicates the creation timestamp in ISO 8601 format.
      created_at: Option<System.DateTimeOffset>
      ///Specifies the hierarchical namespace parts as an array of strings.
      ///For example, ["bronze", "analytics"] represents the namespace "bronze.analytics".
      ``namespace``: ``r2-data-catalognamespace-identifier``
      ///Contains the UUID that persists across renames.
      namespace_uuid: System.Guid
      ///Shows the last update timestamp in ISO 8601 format. Null if never updated.
      updated_at: Option<System.DateTimeOffset> }
    ///Creates an instance of r2-data-catalognamespace-details with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``namespace``: ``r2-data-catalognamespace-identifier``, namespace_uuid: System.Guid): ``r2-data-catalognamespace-details`` =
        { created_at = None
          ``namespace`` = ``namespace``
          namespace_uuid = namespace_uuid
          updated_at = None }

///Contains the list of namespaces with optional pagination.
type ``r2-data-catalognamespace-list-response`` =
    { ///Contains detailed metadata for each namespace when return_details is true.
      ///Each object includes the namespace, UUID, and timestamps.
      details: Option<list<``r2-data-catalognamespace-details``>>
      ///Contains UUIDs for each namespace when return_uuids is true.
      ///The order corresponds to the namespaces array.
      namespace_uuids: Option<list<System.Guid>>
      ///Lists namespaces in the catalog.
      namespaces: list<``r2-data-catalognamespace-identifier``>
      ///Use this opaque token to fetch the next page of results.
      ///A null or absent value indicates the last page.
      next_page_token: Option<string> }
    ///Creates an instance of r2-data-catalognamespace-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (namespaces: list<``r2-data-catalognamespace-identifier``>): ``r2-data-catalognamespace-list-response`` =
        { details = None
          namespace_uuids = None
          namespaces = namespaces
          next_page_token = None }

///Configures snapshot expiration settings.
type ``r2-data-catalogsnapshot-expiration-config`` =
    { ///Specifies the maximum age for snapshots. The system deletes snapshots older than this age.
      ///Format: &amp;lt;number&amp;gt;&amp;lt;unit&amp;gt; where unit is d (days), h (hours), m (minutes), or s (seconds).
      ///Examples: "7d" (7 days), "48h" (48 hours), "2880m" (2,880 minutes).
      ///Defaults to "7d".
      max_snapshot_age: string
      ///Specifies the minimum number of snapshots to retain. Defaults to 100.
      min_snapshots_to_keep: int64
      ///Specifies the state of maintenance operations.
      state: ``r2-data-catalogcatalog-maintenance-state`` }
    ///Creates an instance of r2-data-catalogsnapshot-expiration-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (max_snapshot_age: string,
                          min_snapshots_to_keep: int64,
                          state: ``r2-data-catalogcatalog-maintenance-state``): ``r2-data-catalogsnapshot-expiration-config`` =
        { max_snapshot_age = max_snapshot_age
          min_snapshots_to_keep = min_snapshots_to_keep
          state = state }

///Updates snapshot expiration configuration (all fields optional).
type ``r2-data-catalogsnapshot-expiration-update-params`` =
    { ///Updates the maximum age for snapshots optionally.
      max_snapshot_age: Option<string>
      ///Updates the minimum number of snapshots to retain optionally.
      min_snapshots_to_keep: Option<int64>
      ///Updates the state optionally.
      state: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of r2-data-catalogsnapshot-expiration-update-params with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-data-catalogsnapshot-expiration-update-params`` =
        { max_snapshot_age = None
          min_snapshots_to_keep = None
          state = None }

///Configures compaction settings for table optimization.
type ``r2-data-catalogtable-compaction-config`` =
    { ///Specifies the state of maintenance operations.
      state: ``r2-data-catalogcatalog-maintenance-state``
      ///Sets the target file size for compaction in megabytes. Defaults to "128".
      target_size_mb: ``r2-data-catalogcatalog-target-file-size`` }
    ///Creates an instance of r2-data-catalogtable-compaction-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (state: ``r2-data-catalogcatalog-maintenance-state``,
                          target_size_mb: ``r2-data-catalogcatalog-target-file-size``): ``r2-data-catalogtable-compaction-config`` =
        { state = state
          target_size_mb = target_size_mb }

///Contains table with metadata.
type ``r2-data-catalogtable-details`` =
    { ///Indicates the creation timestamp in ISO 8601 format.
      created_at: Option<System.DateTimeOffset>
      ///Specifies a unique table identifier within a catalog.
      identifier: ``r2-data-catalogtable-identifier``
      ///Specifies the base S3 URI for table storage location.
      location: Option<string>
      ///Contains the S3 URI to table metadata file. Null for staged tables.
      metadata_location: Option<string>
      ///Contains the UUID that persists across renames.
      table_uuid: System.Guid
      ///Shows the last update timestamp in ISO 8601 format. Null if never updated.
      updated_at: Option<System.DateTimeOffset> }
    ///Creates an instance of r2-data-catalogtable-details with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (identifier: ``r2-data-catalogtable-identifier``, table_uuid: System.Guid): ``r2-data-catalogtable-details`` =
        { created_at = None
          identifier = identifier
          location = None
          metadata_location = None
          table_uuid = table_uuid
          updated_at = None }

///Specifies a unique table identifier within a catalog.
type ``r2-data-catalogtable-identifier`` =
    { ///Specifies the table name.
      name: string
      ///Specifies the hierarchical namespace parts as an array of strings.
      ///For example, ["bronze", "analytics"] represents the namespace "bronze.analytics".
      ``namespace``: ``r2-data-catalognamespace-identifier`` }
    ///Creates an instance of r2-data-catalogtable-identifier with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, ``namespace``: ``r2-data-catalognamespace-identifier``): ``r2-data-catalogtable-identifier`` =
        { name = name
          ``namespace`` = ``namespace`` }

///Contains the list of tables with optional pagination.
type ``r2-data-catalogtable-list-response`` =
    { ///Contains detailed metadata for each table when return_details is true.
      ///Each object includes identifier, UUID, timestamps, and locations.
      details: Option<list<``r2-data-catalogtable-details``>>
      ///Lists tables in the namespace.
      identifiers: list<``r2-data-catalogtable-identifier``>
      ///Use this opaque token to fetch the next page of results.
      ///A null or absent value indicates the last page.
      next_page_token: Option<string>
      ///Contains UUIDs for each table when return_uuids is true.
      ///The order corresponds to the identifiers array.
      table_uuids: Option<list<System.Guid>> }
    ///Creates an instance of r2-data-catalogtable-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (identifiers: list<``r2-data-catalogtable-identifier``>): ``r2-data-catalogtable-list-response`` =
        { details = None
          identifiers = identifiers
          next_page_token = None
          table_uuids = None }

///Configures maintenance for the table.
type ``r2-data-catalogtable-maintenance-config`` =
    { ///Configures compaction settings for table optimization.
      compaction: Option<``r2-data-catalogtable-compaction-config``>
      ///Configures snapshot expiration settings.
      snapshot_expiration: Option<``r2-data-catalogsnapshot-expiration-config``> }
    ///Creates an instance of r2-data-catalogtable-maintenance-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-data-catalogtable-maintenance-config`` =
        { compaction = None
          snapshot_expiration = None }

///Contains table maintenance configuration.
type ``r2-data-catalogtable-maintenance-config-response`` =
    { ///Configures maintenance for the table.
      maintenance_config: ``r2-data-catalogtable-maintenance-config`` }
    ///Creates an instance of r2-data-catalogtable-maintenance-config-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (maintenance_config: ``r2-data-catalogtable-maintenance-config``): ``r2-data-catalogtable-maintenance-config-response`` =
        { maintenance_config = maintenance_config }

///Contains request to update table maintenance configuration.
type ``r2-data-catalogtable-maintenance-update-request`` =
    { ///Updates compaction configuration (all fields optional).
      compaction: Option<``r2-data-catalogcompaction-update-params``>
      ///Updates snapshot expiration configuration (all fields optional).
      snapshot_expiration: Option<``r2-data-catalogsnapshot-expiration-update-params``> }
    ///Creates an instance of r2-data-catalogtable-maintenance-update-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-data-catalogtable-maintenance-update-request`` =
        { compaction = None
          snapshot_expiration = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ConnectivityStatus =
    | [<CompiledName "success">] Success
    | [<CompiledName "error">] Error
    member this.Format() =
        match this with
        | Success -> "success"
        | Error -> "error"

type ``r2-slurperConnectivityResponse`` =
    { connectivityStatus: Option<ConnectivityStatus> }
    ///Creates an instance of r2-slurperConnectivityResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-slurperConnectivityResponse`` = { connectivityStatus = None }

type ``r2-slurperCreateJobRequest`` =
    { overwrite: Option<bool>
      source: Option<Newtonsoft.Json.Linq.JObject>
      target: Option<``r2-slurperR2TargetSchema``> }
    ///Creates an instance of r2-slurperCreateJobRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-slurperCreateJobRequest`` =
        { overwrite = None
          source = None
          target = None }

type ``r2-slurperGCSLikeCredsSchema`` =
    { clientEmail: string
      privateKey: string }
    ///Creates an instance of r2-slurperGCSLikeCredsSchema with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (clientEmail: string, privateKey: string): ``r2-slurperGCSLikeCredsSchema`` =
        { clientEmail = clientEmail
          privateKey = privateKey }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Vendor =
    | [<CompiledName "gcs">] Gcs
    member this.Format() =
        match this with
        | Gcs -> "gcs"

type ``r2-slurperGCSSourceSchema`` =
    { bucket: string
      keys: Option<list<string>>
      pathPrefix: Option<string>
      secret: ``r2-slurperGCSLikeCredsSchema``
      vendor: Vendor }
    ///Creates an instance of r2-slurperGCSSourceSchema with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket: string, secret: ``r2-slurperGCSLikeCredsSchema``, vendor: Vendor): ``r2-slurperGCSSourceSchema`` =
        { bucket = bucket
          keys = None
          pathPrefix = None
          secret = secret
          vendor = vendor }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type LogType =
    | [<CompiledName "migrationStart">] MigrationStart
    | [<CompiledName "migrationComplete">] MigrationComplete
    | [<CompiledName "migrationAbort">] MigrationAbort
    | [<CompiledName "migrationError">] MigrationError
    | [<CompiledName "migrationPause">] MigrationPause
    | [<CompiledName "migrationResume">] MigrationResume
    | [<CompiledName "migrationErrorFailedContinuation">] MigrationErrorFailedContinuation
    | [<CompiledName "importErrorRetryExhaustion">] ImportErrorRetryExhaustion
    | [<CompiledName "importSkippedStorageClass">] ImportSkippedStorageClass
    | [<CompiledName "importSkippedOversized">] ImportSkippedOversized
    | [<CompiledName "importSkippedEmptyObject">] ImportSkippedEmptyObject
    | [<CompiledName "importSkippedUnsupportedContentType">] ImportSkippedUnsupportedContentType
    | [<CompiledName "importSkippedExcludedContentType">] ImportSkippedExcludedContentType
    | [<CompiledName "importSkippedInvalidMedia">] ImportSkippedInvalidMedia
    | [<CompiledName "importSkippedRequiresRetrieval">] ImportSkippedRequiresRetrieval
    member this.Format() =
        match this with
        | MigrationStart -> "migrationStart"
        | MigrationComplete -> "migrationComplete"
        | MigrationAbort -> "migrationAbort"
        | MigrationError -> "migrationError"
        | MigrationPause -> "migrationPause"
        | MigrationResume -> "migrationResume"
        | MigrationErrorFailedContinuation -> "migrationErrorFailedContinuation"
        | ImportErrorRetryExhaustion -> "importErrorRetryExhaustion"
        | ImportSkippedStorageClass -> "importSkippedStorageClass"
        | ImportSkippedOversized -> "importSkippedOversized"
        | ImportSkippedEmptyObject -> "importSkippedEmptyObject"
        | ImportSkippedUnsupportedContentType -> "importSkippedUnsupportedContentType"
        | ImportSkippedExcludedContentType -> "importSkippedExcludedContentType"
        | ImportSkippedInvalidMedia -> "importSkippedInvalidMedia"
        | ImportSkippedRequiresRetrieval -> "importSkippedRequiresRetrieval"

type ``r2-slurperJobLogResponse`` =
    { createdAt: Option<string>
      job: Option<string>
      logType: Option<LogType>
      message: Option<string>
      objectKey: Option<string> }
    ///Creates an instance of r2-slurperJobLogResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-slurperJobLogResponse`` =
        { createdAt = None
          job = None
          logType = None
          message = None
          objectKey = None }

type ``r2-slurperJobProgressResponse`` =
    { createdAt: Option<string>
      failedObjects: Option<int>
      id: Option<string>
      objects: Option<int>
      skippedObjects: Option<int>
      status: Option<``r2-slurperJobStatus``>
      transferredObjects: Option<int> }
    ///Creates an instance of r2-slurperJobProgressResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-slurperJobProgressResponse`` =
        { createdAt = None
          failedObjects = None
          id = None
          objects = None
          skippedObjects = None
          status = None
          transferredObjects = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TargetVendor =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type Target =
    { bucket: Option<string>
      jurisdiction: Option<``r2-slurperJurisdiction``>
      vendor: Option<TargetVendor> }
    ///Creates an instance of Target with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Target =
        { bucket = None
          jurisdiction = None
          vendor = None }

type ``r2-slurperJobResponse`` =
    { createdAt: Option<string>
      finishedAt: Option<string>
      id: Option<string>
      overwrite: Option<bool>
      source: Option<Newtonsoft.Json.Linq.JToken>
      status: Option<``r2-slurperJobStatus``>
      target: Option<Target> }
    ///Creates an instance of r2-slurperJobResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-slurperJobResponse`` =
        { createdAt = None
          finishedAt = None
          id = None
          overwrite = None
          source = None
          status = None
          target = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2-slurperR2SourceSchemaVendor`` =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type ``r2-slurperR2SourceSchema`` =
    { bucket: string
      jurisdiction: Option<``r2-slurperJurisdiction``>
      keys: Option<list<string>>
      pathPrefix: Option<string>
      secret: ``r2-slurperS3LikeCredsSchema``
      vendor: ``r2-slurperR2SourceSchemaVendor`` }
    ///Creates an instance of r2-slurperR2SourceSchema with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket: string,
                          secret: ``r2-slurperS3LikeCredsSchema``,
                          vendor: ``r2-slurperR2SourceSchemaVendor``): ``r2-slurperR2SourceSchema`` =
        { bucket = bucket
          jurisdiction = None
          keys = None
          pathPrefix = None
          secret = secret
          vendor = vendor }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2-slurperR2TargetSchemaVendor`` =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type ``r2-slurperR2TargetSchema`` =
    { bucket: string
      jurisdiction: Option<``r2-slurperJurisdiction``>
      secret: ``r2-slurperS3LikeCredsSchema``
      vendor: ``r2-slurperR2TargetSchemaVendor`` }
    ///Creates an instance of r2-slurperR2TargetSchema with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket: string,
                          secret: ``r2-slurperS3LikeCredsSchema``,
                          vendor: ``r2-slurperR2TargetSchemaVendor``): ``r2-slurperR2TargetSchema`` =
        { bucket = bucket
          jurisdiction = None
          secret = secret
          vendor = vendor }

type ``r2-slurperS3LikeCredsSchema`` =
    { accessKeyId: string
      secretAccessKey: string }
    ///Creates an instance of r2-slurperS3LikeCredsSchema with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (accessKeyId: string, secretAccessKey: string): ``r2-slurperS3LikeCredsSchema`` =
        { accessKeyId = accessKeyId
          secretAccessKey = secretAccessKey }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2-slurperS3SourceSchemaVendor`` =
    | [<CompiledName "s3">] S3
    member this.Format() =
        match this with
        | S3 -> "s3"

type ``r2-slurperS3SourceSchema`` =
    { bucket: string
      endpoint: Option<string>
      keys: Option<list<string>>
      pathPrefix: Option<string>
      region: Option<string>
      secret: ``r2-slurperS3LikeCredsSchema``
      vendor: ``r2-slurperS3SourceSchemaVendor`` }
    ///Creates an instance of r2-slurperS3SourceSchema with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket: string,
                          secret: ``r2-slurperS3LikeCredsSchema``,
                          vendor: ``r2-slurperS3SourceSchemaVendor``): ``r2-slurperS3SourceSchema`` =
        { bucket = bucket
          endpoint = None
          keys = None
          pathPrefix = None
          region = None
          secret = secret
          vendor = vendor }

type ``r2-slurperapi-v4-failureErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-slurperapi-v4-failureErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-slurperapi-v4-failureErrors`` =
        { code = code; message = message }

type ``r2-slurperapi-v4-failure`` =
    { errors: Option<list<``r2-slurperapi-v4-failureErrors``>>
      messages: Option<``r2-slurperapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool> }
    ///Creates an instance of r2-slurperapi-v4-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-slurperapi-v4-failure`` =
        { errors = None
          messages = None
          success = None }

type ``r2-slurperapi-v4-successErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-slurperapi-v4-successErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-slurperapi-v4-successErrors`` =
        { code = code; message = message }

type ``r2-slurperapi-v4-success`` =
    { errors: Option<list<``r2-slurperapi-v4-successErrors``>>
      messages: Option<``r2-slurperapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool> }
    ///Creates an instance of r2-slurperapi-v4-success with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-slurperapi-v4-success`` =
        { errors = None
          messages = None
          success = None }

///Metrics based on the class they belong to.
type r2accountlevelmetrics =
    { ///Metrics based on what state they are in(uploaded or published).
      infrequentAccess: Option<r2classbasedmetrics>
      ///Metrics based on what state they are in(uploaded or published).
      standard: Option<r2classbasedmetrics> }
    ///Creates an instance of r2accountlevelmetrics with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2accountlevelmetrics =
        { infrequentAccess = None
          standard = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MinTLS =
    | [<CompiledName "1.0">] Numeric_1Numeric_0
    | [<CompiledName "1.1">] Numeric_1Numeric_1
    | [<CompiledName "1.2">] Numeric_1Numeric_2
    | [<CompiledName "1.3">] Numeric_1Numeric_3
    member this.Format() =
        match this with
        | Numeric_1Numeric_0 -> "1.0"
        | Numeric_1Numeric_1 -> "1.1"
        | Numeric_1Numeric_2 -> "1.2"
        | Numeric_1Numeric_3 -> "1.3"

type r2addcustomdomainrequest =
    { ///An allowlist of ciphers for TLS termination. These ciphers must be in the BoringSSL format.
      ciphers: Option<list<string>>
      ///Name of the custom domain to be added.
      domain: string
      ///Whether to enable public bucket access at the custom domain. If undefined, the domain will be enabled.
      enabled: bool
      ///Minimum TLS Version the custom domain will accept for incoming connections. If not set, defaults to 1.0.
      minTLS: Option<MinTLS>
      ///Zone ID of the custom domain.
      zoneId: string }
    ///Creates an instance of r2addcustomdomainrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: string, enabled: bool, zoneId: string): r2addcustomdomainrequest =
        { ciphers = None
          domain = domain
          enabled = enabled
          minTLS = None
          zoneId = zoneId }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2addcustomdomainresponseMinTLS =
    | [<CompiledName "1.0">] Numeric_1Numeric_0
    | [<CompiledName "1.1">] Numeric_1Numeric_1
    | [<CompiledName "1.2">] Numeric_1Numeric_2
    | [<CompiledName "1.3">] Numeric_1Numeric_3
    member this.Format() =
        match this with
        | Numeric_1Numeric_0 -> "1.0"
        | Numeric_1Numeric_1 -> "1.1"
        | Numeric_1Numeric_2 -> "1.2"
        | Numeric_1Numeric_3 -> "1.3"

type r2addcustomdomainresponse =
    { ///An allowlist of ciphers for TLS termination. These ciphers must be in the BoringSSL format.
      ciphers: Option<list<string>>
      ///Domain name of the affected custom domain.
      domain: string
      ///Whether this bucket is publicly accessible at the specified custom domain.
      enabled: bool
      ///Minimum TLS Version the custom domain will accept for incoming connections. If not set, defaults to 1.0.
      minTLS: Option<r2addcustomdomainresponseMinTLS> }
    ///Creates an instance of r2addcustomdomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: string, enabled: bool): r2addcustomdomainresponse =
        { ciphers = None
          domain = domain
          enabled = enabled
          minTLS = None }

///A single R2 bucket.
type r2bucket =
    { ///Creation timestamp.
      creation_date: Option<string>
      ///Jurisdiction where objects in this bucket are guaranteed to be stored.
      jurisdiction: Option<r2jurisdiction>
      ///Location of the bucket.
      location: Option<r2bucketlocation>
      ///Name of the bucket.
      name: Option<r2bucketname>
      ///Storage class for newly uploaded objects, unless specified otherwise.
      storage_class: Option<r2storageclass> }
    ///Creates an instance of r2bucket with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2bucket =
        { creation_date = None
          jurisdiction = None
          location = None
          name = None
          storage_class = None }

type ``r2bucket-config`` =
    { ///Name of the bucket.
      bucketName: Option<string>
      ///List of queues associated with the bucket.
      queues: Option<list<``r2queues-config``>> }
    ///Creates an instance of r2bucket-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2bucket-config`` = { bucketName = None; queues = None }

type ``r2bucket-lock-rule`` =
    { condition: Newtonsoft.Json.Linq.JToken
      ///Whether or not this rule is in effect.
      enabled: bool
      ///Unique identifier for this rule.
      id: string
      ///Rule will only apply to objects/uploads in the bucket that start with the given prefix, an empty prefix can be provided to scope rule to all objects/uploads.
      prefix: Option<string> }
    ///Creates an instance of r2bucket-lock-rule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (condition: Newtonsoft.Json.Linq.JToken, enabled: bool, id: string): ``r2bucket-lock-rule`` =
        { condition = condition
          enabled = enabled
          id = id
          prefix = None }

type ``r2bucket-lock-rule-config`` =
    { rules: Option<list<string>> }
    ///Creates an instance of r2bucket-lock-rule-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2bucket-lock-rule-config`` = { rules = None }

///Metrics based on what state they are in(uploaded or published).
type r2classbasedmetrics =
    { ///Metrics on number of objects/amount of storage used.
      published: Option<r2objectsizemetrics>
      ///Metrics on number of objects/amount of storage used.
      uploaded: Option<r2objectsizemetrics> }
    ///Creates an instance of r2classbasedmetrics with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2classbasedmetrics = { published = None; uploaded = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Methods =
    | [<CompiledName "GET">] GET
    | [<CompiledName "PUT">] PUT
    | [<CompiledName "POST">] POST
    | [<CompiledName "DELETE">] DELETE
    | [<CompiledName "HEAD">] HEAD
    member this.Format() =
        match this with
        | GET -> "GET"
        | PUT -> "PUT"
        | POST -> "POST"
        | DELETE -> "DELETE"
        | HEAD -> "HEAD"

///Object specifying allowed origins, methods and headers for this CORS rule.
type Allowed =
    { ///Specifies the value for the Access-Control-Allow-Headers header R2 sets when requesting objects in this bucket from a browser. Cross-origin requests that include custom headers (e.g. x-user-id) should specify these headers as AllowedHeaders.
      headers: Option<list<string>>
      ///Specifies the value for the Access-Control-Allow-Methods header R2 sets when requesting objects in a bucket from a browser.
      methods: list<Methods>
      ///Specifies the value for the Access-Control-Allow-Origin header R2 sets when requesting objects in a bucket from a browser.
      origins: list<string> }
    ///Creates an instance of Allowed with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (methods: list<Methods>, origins: list<string>): Allowed =
        { headers = None
          methods = methods
          origins = origins }

type ``r2cors-rule`` =
    { ///Object specifying allowed origins, methods and headers for this CORS rule.
      allowed: Allowed
      ///Specifies the headers that can be exposed back, and accessed by, the JavaScript making the cross-origin request. If you need to access headers beyond the safelisted response headers, such as Content-Encoding or cf-cache-status, you must specify it here.
      exposeHeaders: Option<list<string>>
      ///Identifier for this rule.
      id: Option<string>
      ///Specifies the amount of time (in seconds) browsers are allowed to cache CORS preflight responses. Browsers may limit this to 2 hours or less, even if the maximum value (86400) is specified.
      maxAgeSeconds: Option<float> }
    ///Creates an instance of r2cors-rule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (allowed: Allowed): ``r2cors-rule`` =
        { allowed = allowed
          exposeHeaders = None
          id = None
          maxAgeSeconds = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2editcustomdomainrequestMinTLS =
    | [<CompiledName "1.0">] Numeric_1Numeric_0
    | [<CompiledName "1.1">] Numeric_1Numeric_1
    | [<CompiledName "1.2">] Numeric_1Numeric_2
    | [<CompiledName "1.3">] Numeric_1Numeric_3
    member this.Format() =
        match this with
        | Numeric_1Numeric_0 -> "1.0"
        | Numeric_1Numeric_1 -> "1.1"
        | Numeric_1Numeric_2 -> "1.2"
        | Numeric_1Numeric_3 -> "1.3"

type r2editcustomdomainrequest =
    { ///An allowlist of ciphers for TLS termination. These ciphers must be in the BoringSSL format.
      ciphers: Option<list<string>>
      ///Whether to enable public bucket access at the specified custom domain.
      enabled: Option<bool>
      ///Minimum TLS Version the custom domain will accept for incoming connections. If not set, defaults to previous value.
      minTLS: Option<r2editcustomdomainrequestMinTLS> }
    ///Creates an instance of r2editcustomdomainrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2editcustomdomainrequest =
        { ciphers = None
          enabled = None
          minTLS = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2editcustomdomainresponseMinTLS =
    | [<CompiledName "1.0">] Numeric_1Numeric_0
    | [<CompiledName "1.1">] Numeric_1Numeric_1
    | [<CompiledName "1.2">] Numeric_1Numeric_2
    | [<CompiledName "1.3">] Numeric_1Numeric_3
    member this.Format() =
        match this with
        | Numeric_1Numeric_0 -> "1.0"
        | Numeric_1Numeric_1 -> "1.1"
        | Numeric_1Numeric_2 -> "1.2"
        | Numeric_1Numeric_3 -> "1.3"

type r2editcustomdomainresponse =
    { ///An allowlist of ciphers for TLS termination. These ciphers must be in the BoringSSL format.
      ciphers: Option<list<string>>
      ///Domain name of the affected custom domain.
      domain: string
      ///Whether this bucket is publicly accessible at the specified custom domain.
      enabled: Option<bool>
      ///Minimum TLS Version the custom domain will accept for incoming connections. If not set, defaults to 1.0.
      minTLS: Option<r2editcustomdomainresponseMinTLS> }
    ///Creates an instance of r2editcustomdomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: string): r2editcustomdomainresponse =
        { ciphers = None
          domain = domain
          enabled = None
          minTLS = None }

type r2editmanageddomainrequest =
    { ///Whether to enable public bucket access at the r2.dev domain.
      enabled: bool }
    ///Creates an instance of r2editmanageddomainrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool): r2editmanageddomainrequest = { enabled = enabled }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Provider =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

///R2 bucket to copy objects to.
type Destination =
    { ///ID of a Cloudflare API token.
      ///This is the value labelled "Access Key ID" when creating an API.
      ///token from the [R2 dashboard](https://dash.cloudflare.com/?to=/:account/r2/api-tokens).
      ///Sippy will use this token when writing objects to R2, so it is
      ///best to scope this token to the bucket you're enabling Sippy for.
      accessKeyId: Option<string>
      provider: Option<Provider>
      ///Value of a Cloudflare API token.
      ///This is the value labelled "Secret Access Key" when creating an API.
      ///token from the [R2 dashboard](https://dash.cloudflare.com/?to=/:account/r2/api-tokens).
      ///Sippy will use this token when writing objects to R2, so it is
      ///best to scope this token to the bucket you're enabling Sippy for.
      secretAccessKey: Option<string> }
    ///Creates an instance of Destination with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Destination =
        { accessKeyId = None
          provider = None
          secretAccessKey = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SourceProvider =
    | [<CompiledName "aws">] Aws
    member this.Format() =
        match this with
        | Aws -> "aws"

///AWS S3 bucket to copy objects from.
type Source =
    { ///Access Key ID of an IAM credential (ideally scoped to a single S3 bucket).
      accessKeyId: Option<string>
      ///Name of the AWS S3 bucket.
      bucket: Option<string>
      provider: Option<SourceProvider>
      ///Name of the AWS availability zone.
      region: Option<string>
      ///Secret Access Key of an IAM credential (ideally scoped to a single S3 bucket).
      secretAccessKey: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source =
        { accessKeyId = None
          bucket = None
          provider = None
          region = None
          secretAccessKey = None }

type r2enablesippyaws =
    { ///R2 bucket to copy objects to.
      destination: Option<Destination>
      ///AWS S3 bucket to copy objects from.
      source: Option<Source> }
    ///Creates an instance of r2enablesippyaws with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2enablesippyaws = { destination = None; source = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2enablesippygcsDestinationProvider =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

///R2 bucket to copy objects to.
type r2enablesippygcsDestination =
    { ///ID of a Cloudflare API token.
      ///This is the value labelled "Access Key ID" when creating an API.
      ///token from the [R2 dashboard](https://dash.cloudflare.com/?to=/:account/r2/api-tokens).
      ///Sippy will use this token when writing objects to R2, so it is
      ///best to scope this token to the bucket you're enabling Sippy for.
      accessKeyId: Option<string>
      provider: Option<r2enablesippygcsDestinationProvider>
      ///Value of a Cloudflare API token.
      ///This is the value labelled "Secret Access Key" when creating an API.
      ///token from the [R2 dashboard](https://dash.cloudflare.com/?to=/:account/r2/api-tokens).
      ///Sippy will use this token when writing objects to R2, so it is
      ///best to scope this token to the bucket you're enabling Sippy for.
      secretAccessKey: Option<string> }
    ///Creates an instance of r2enablesippygcsDestination with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2enablesippygcsDestination =
        { accessKeyId = None
          provider = None
          secretAccessKey = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2enablesippygcsSourceProvider =
    | [<CompiledName "gcs">] Gcs
    member this.Format() =
        match this with
        | Gcs -> "gcs"

///GCS bucket to copy objects from.
type r2enablesippygcsSource =
    { ///Name of the GCS bucket.
      bucket: Option<string>
      ///Client email of an IAM credential (ideally scoped to a single GCS bucket).
      clientEmail: Option<string>
      ///Private Key of an IAM credential (ideally scoped to a single GCS bucket).
      privateKey: Option<string>
      provider: Option<r2enablesippygcsSourceProvider> }
    ///Creates an instance of r2enablesippygcsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2enablesippygcsSource =
        { bucket = None
          clientEmail = None
          privateKey = None
          provider = None }

type r2enablesippygcs =
    { ///R2 bucket to copy objects to.
      destination: Option<r2enablesippygcsDestination>
      ///GCS bucket to copy objects from.
      source: Option<r2enablesippygcsSource> }
    ///Creates an instance of r2enablesippygcs with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2enablesippygcs = { destination = None; source = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2enablesippys3DestinationProvider =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

///R2 bucket to copy objects to.
type r2enablesippys3Destination =
    { ///ID of a Cloudflare API token.
      ///This is the value labelled "Access Key ID" when creating an API.
      ///token from the [R2 dashboard](https://dash.cloudflare.com/?to=/:account/r2/api-tokens).
      ///Sippy will use this token when writing objects to R2, so it is
      ///best to scope this token to the bucket you're enabling Sippy for.
      accessKeyId: Option<string>
      provider: Option<r2enablesippys3DestinationProvider>
      ///Value of a Cloudflare API token.
      ///This is the value labelled "Secret Access Key" when creating an API.
      ///token from the [R2 dashboard](https://dash.cloudflare.com/?to=/:account/r2/api-tokens).
      ///Sippy will use this token when writing objects to R2, so it is
      ///best to scope this token to the bucket you're enabling Sippy for.
      secretAccessKey: Option<string> }
    ///Creates an instance of r2enablesippys3Destination with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2enablesippys3Destination =
        { accessKeyId = None
          provider = None
          secretAccessKey = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2enablesippys3SourceProvider =
    | [<CompiledName "s3">] S3
    member this.Format() =
        match this with
        | S3 -> "s3"

///General S3-compatible provider to copy objects from.
type r2enablesippys3Source =
    { ///Access Key ID of an IAM credential (ideally scoped to a single S3 bucket).
      accessKeyId: Option<string>
      ///URL to the S3-compatible API of the bucket.
      bucketUrl: Option<string>
      provider: Option<r2enablesippys3SourceProvider>
      ///Secret Access Key of an IAM credential (ideally scoped to a single S3 bucket).
      secretAccessKey: Option<string> }
    ///Creates an instance of r2enablesippys3Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2enablesippys3Source =
        { accessKeyId = None
          bucketUrl = None
          provider = None
          secretAccessKey = None }

type r2enablesippys3 =
    { ///R2 bucket to copy objects to.
      destination: Option<r2enablesippys3Destination>
      ///General S3-compatible provider to copy objects from.
      source: Option<r2enablesippys3Source> }
    ///Creates an instance of r2enablesippys3 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2enablesippys3 = { destination = None; source = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2getcustomdomainresponseMinTLS =
    | [<CompiledName "1.0">] Numeric_1Numeric_0
    | [<CompiledName "1.1">] Numeric_1Numeric_1
    | [<CompiledName "1.2">] Numeric_1Numeric_2
    | [<CompiledName "1.3">] Numeric_1Numeric_3
    member this.Format() =
        match this with
        | Numeric_1Numeric_0 -> "1.0"
        | Numeric_1Numeric_1 -> "1.1"
        | Numeric_1Numeric_2 -> "1.2"
        | Numeric_1Numeric_3 -> "1.3"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Ownership =
    | [<CompiledName "pending">] Pending
    | [<CompiledName "active">] Active
    | [<CompiledName "deactivated">] Deactivated
    | [<CompiledName "blocked">] Blocked
    | [<CompiledName "error">] Error
    | [<CompiledName "unknown">] Unknown
    member this.Format() =
        match this with
        | Pending -> "pending"
        | Active -> "active"
        | Deactivated -> "deactivated"
        | Blocked -> "blocked"
        | Error -> "error"
        | Unknown -> "unknown"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Ssl =
    | [<CompiledName "initializing">] Initializing
    | [<CompiledName "pending">] Pending
    | [<CompiledName "active">] Active
    | [<CompiledName "deactivated">] Deactivated
    | [<CompiledName "error">] Error
    | [<CompiledName "unknown">] Unknown
    member this.Format() =
        match this with
        | Initializing -> "initializing"
        | Pending -> "pending"
        | Active -> "active"
        | Deactivated -> "deactivated"
        | Error -> "error"
        | Unknown -> "unknown"

type Status =
    { ///Ownership status of the domain.
      ownership: Ownership
      ///SSL certificate status.
      ssl: Ssl }
    ///Creates an instance of Status with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ownership: Ownership, ssl: Ssl): Status = { ownership = ownership; ssl = ssl }

type r2getcustomdomainresponse =
    { ///An allowlist of ciphers for TLS termination. These ciphers must be in the BoringSSL format.
      ciphers: Option<list<string>>
      ///Domain name of the custom domain to be added.
      domain: string
      ///Whether this bucket is publicly accessible at the specified custom domain.
      enabled: bool
      ///Minimum TLS Version the custom domain will accept for incoming connections. If not set, defaults to 1.0.
      minTLS: Option<r2getcustomdomainresponseMinTLS>
      status: Status
      ///Zone ID of the custom domain resides in.
      zoneId: Option<string>
      ///Zone that the custom domain resides in.
      zoneName: Option<string> }
    ///Creates an instance of r2getcustomdomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: string, enabled: bool, status: Status): r2getcustomdomainresponse =
        { ciphers = None
          domain = domain
          enabled = enabled
          minTLS = None
          status = status
          zoneId = None
          zoneName = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "Age">] Age
    member this.Format() =
        match this with
        | Age -> "Age"

///Condition for lifecycle transitions to apply after an object reaches an age in seconds.
type ``r2lifecycle-age-condition`` =
    { maxAge: int
      ``type``: Type }
    ///Creates an instance of r2lifecycle-age-condition with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (maxAge: int, ``type``: Type): ``r2lifecycle-age-condition`` =
        { maxAge = maxAge; ``type`` = ``type`` }

type ``r2lifecycle-config`` =
    { rules: Option<list<string>> }
    ///Creates an instance of r2lifecycle-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2lifecycle-config`` = { rules = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2lifecycle-date-conditionType`` =
    | [<CompiledName "Date">] Date
    member this.Format() =
        match this with
        | Date -> "Date"

///Condition for lifecycle transitions to apply on a specific date.
type ``r2lifecycle-date-condition`` =
    { date: System.DateTimeOffset
      ``type``: ``r2lifecycle-date-conditionType`` }
    ///Creates an instance of r2lifecycle-date-condition with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (date: System.DateTimeOffset, ``type``: ``r2lifecycle-date-conditionType``): ``r2lifecycle-date-condition`` =
        { date = date; ``type`` = ``type`` }

///Transition to abort ongoing multipart uploads.
type AbortMultipartUploadsTransition =
    { condition: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of AbortMultipartUploadsTransition with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AbortMultipartUploadsTransition = { condition = None }

///Conditions that apply to all transitions of this rule.
type Conditions =
    { ///Transitions will only apply to objects/uploads in the bucket that start with the given prefix, an empty prefix can be provided to scope rule to all objects/uploads.
      prefix: string }
    ///Creates an instance of Conditions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prefix: string): Conditions = { prefix = prefix }

///Transition to delete objects.
type DeleteObjectsTransition =
    { condition: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of DeleteObjectsTransition with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): DeleteObjectsTransition = { condition = None }

type ``r2lifecycle-rule`` =
    { ///Transition to abort ongoing multipart uploads.
      abortMultipartUploadsTransition: Option<AbortMultipartUploadsTransition>
      ///Conditions that apply to all transitions of this rule.
      conditions: Conditions
      ///Transition to delete objects.
      deleteObjectsTransition: Option<DeleteObjectsTransition>
      ///Whether or not this rule is in effect.
      enabled: bool
      ///Unique identifier for this rule.
      id: string
      ///Transitions to change the storage class of objects.
      storageClassTransitions: Option<list<string>> }
    ///Creates an instance of r2lifecycle-rule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (conditions: Conditions, enabled: bool, id: string): ``r2lifecycle-rule`` =
        { abortMultipartUploadsTransition = None
          conditions = conditions
          deleteObjectsTransition = None
          enabled = enabled
          id = id
          storageClassTransitions = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type StorageClass =
    | [<CompiledName "InfrequentAccess">] InfrequentAccess
    member this.Format() =
        match this with
        | InfrequentAccess -> "InfrequentAccess"

type ``r2lifecycle-storage-transition`` =
    { condition: Newtonsoft.Json.Linq.JToken
      storageClass: StorageClass }
    ///Creates an instance of r2lifecycle-storage-transition with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (condition: Newtonsoft.Json.Linq.JToken, storageClass: StorageClass): ``r2lifecycle-storage-transition`` =
        { condition = condition
          storageClass = storageClass }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DomainsMinTLS =
    | [<CompiledName "1.0">] Numeric_1Numeric_0
    | [<CompiledName "1.1">] Numeric_1Numeric_1
    | [<CompiledName "1.2">] Numeric_1Numeric_2
    | [<CompiledName "1.3">] Numeric_1Numeric_3
    member this.Format() =
        match this with
        | Numeric_1Numeric_0 -> "1.0"
        | Numeric_1Numeric_1 -> "1.1"
        | Numeric_1Numeric_2 -> "1.2"
        | Numeric_1Numeric_3 -> "1.3"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DomainsStatusOwnership =
    | [<CompiledName "pending">] Pending
    | [<CompiledName "active">] Active
    | [<CompiledName "deactivated">] Deactivated
    | [<CompiledName "blocked">] Blocked
    | [<CompiledName "error">] Error
    | [<CompiledName "unknown">] Unknown
    member this.Format() =
        match this with
        | Pending -> "pending"
        | Active -> "active"
        | Deactivated -> "deactivated"
        | Blocked -> "blocked"
        | Error -> "error"
        | Unknown -> "unknown"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DomainsStatusSsl =
    | [<CompiledName "initializing">] Initializing
    | [<CompiledName "pending">] Pending
    | [<CompiledName "active">] Active
    | [<CompiledName "deactivated">] Deactivated
    | [<CompiledName "error">] Error
    | [<CompiledName "unknown">] Unknown
    member this.Format() =
        match this with
        | Initializing -> "initializing"
        | Pending -> "pending"
        | Active -> "active"
        | Deactivated -> "deactivated"
        | Error -> "error"
        | Unknown -> "unknown"

type DomainsStatus =
    { ///Ownership status of the domain.
      ownership: DomainsStatusOwnership
      ///SSL certificate status.
      ssl: DomainsStatusSsl }
    ///Creates an instance of DomainsStatus with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ownership: DomainsStatusOwnership, ssl: DomainsStatusSsl): DomainsStatus =
        { ownership = ownership; ssl = ssl }

type Domains =
    { ///An allowlist of ciphers for TLS termination. These ciphers must be in the BoringSSL format.
      ciphers: Option<list<string>>
      ///Domain name of the custom domain to be added.
      domain: string
      ///Whether this bucket is publicly accessible at the specified custom domain.
      enabled: bool
      ///Minimum TLS Version the custom domain will accept for incoming connections. If not set, defaults to 1.0.
      minTLS: Option<DomainsMinTLS>
      status: DomainsStatus
      ///Zone ID of the custom domain resides in.
      zoneId: Option<string>
      ///Zone that the custom domain resides in.
      zoneName: Option<string> }
    ///Creates an instance of Domains with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: string, enabled: bool, status: DomainsStatus): Domains =
        { ciphers = None
          domain = domain
          enabled = enabled
          minTLS = None
          status = status
          zoneId = None
          zoneName = None }

type r2listcustomdomainsresponse =
    { domains: list<Domains> }
    ///Creates an instance of r2listcustomdomainsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domains: list<Domains>): r2listcustomdomainsresponse = { domains = domains }

///Configuration for local uploads on a bucket.
type r2localuploadsconfiguration =
    { ///Whether local uploads is enabled for this bucket. When enabled, object's data is written to the nearest region first, then asynchronously replicated to the bucket's primary region.
      enabled: Option<bool> }
    ///Creates an instance of r2localuploadsconfiguration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2localuploadsconfiguration = { enabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2lock-rule-age-conditionType`` =
    | [<CompiledName "Age">] Age
    member this.Format() =
        match this with
        | Age -> "Age"

///Condition to apply a lock rule to an object for how long in seconds.
type ``r2lock-rule-age-condition`` =
    { maxAgeSeconds: int
      ``type``: ``r2lock-rule-age-conditionType`` }
    ///Creates an instance of r2lock-rule-age-condition with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (maxAgeSeconds: int, ``type``: ``r2lock-rule-age-conditionType``): ``r2lock-rule-age-condition`` =
        { maxAgeSeconds = maxAgeSeconds
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2lock-rule-date-conditionType`` =
    | [<CompiledName "Date">] Date
    member this.Format() =
        match this with
        | Date -> "Date"

///Condition to apply a lock rule to an object until a specific date.
type ``r2lock-rule-date-condition`` =
    { date: System.DateTimeOffset
      ``type``: ``r2lock-rule-date-conditionType`` }
    ///Creates an instance of r2lock-rule-date-condition with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (date: System.DateTimeOffset, ``type``: ``r2lock-rule-date-conditionType``): ``r2lock-rule-date-condition`` =
        { date = date; ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2lock-rule-indefinite-conditionType`` =
    | [<CompiledName "Indefinite">] Indefinite
    member this.Format() =
        match this with
        | Indefinite -> "Indefinite"

///Condition to apply a lock rule indefinitely.
type ``r2lock-rule-indefinite-condition`` =
    { ``type``: ``r2lock-rule-indefinite-conditionType`` }
    ///Creates an instance of r2lock-rule-indefinite-condition with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``r2lock-rule-indefinite-conditionType``): ``r2lock-rule-indefinite-condition`` =
        { ``type`` = ``type`` }

type r2manageddomainresponse =
    { ///Bucket ID.
      bucketId: string
      ///Domain name of the bucket's r2.dev domain.
      domain: string
      ///Whether this bucket is publicly accessible at the r2.dev domain.
      enabled: bool }
    ///Creates an instance of r2manageddomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucketId: string, domain: string, enabled: bool): r2manageddomainresponse =
        { bucketId = bucketId
          domain = domain
          enabled = enabled }

///Metrics on number of objects/amount of storage used.
type r2objectsizemetrics =
    { ///Amount of.
      metadataSize: Option<float>
      ///Number of objects stored.
      objects: Option<float>
      ///Amount of storage used by object data.
      payloadSize: Option<float> }
    ///Creates an instance of r2objectsizemetrics with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2objectsizemetrics =
        { metadataSize = None
          objects = None
          payloadSize = None }

type ``r2queues-config`` =
    { ///Queue ID.
      queueId: Option<string>
      ///Name of the queue.
      queueName: Option<string>
      rules: Option<list<string>> }
    ///Creates an instance of r2queues-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2queues-config`` =
        { queueId = None
          queueName = None
          rules = None }

type r2removecustomdomainresponse =
    { ///Name of the removed custom domain.
      domain: string }
    ///Creates an instance of r2removecustomdomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: string): r2removecustomdomainresponse = { domain = domain }

type r2resultinfo =
    { ///A continuation token that should be used to fetch the next page of results.
      cursor: Option<string>
      ///Maximum number of results on this page.
      per_page: Option<float> }
    ///Creates an instance of r2resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2resultinfo = { cursor = None; per_page = None }

type r2rule =
    { ///Array of R2 object actions that will trigger notifications.
      actions: list<``r2r2-action``>
      ///A description that can be used to identify the event notification rule after creation.
      description: Option<string>
      ///Notifications will be sent only for objects with this prefix.
      prefix: Option<string>
      ///Notifications will be sent only for objects with this suffix.
      suffix: Option<string> }
    ///Creates an instance of r2rule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (actions: list<``r2r2-action``>): r2rule =
        { actions = actions
          description = None
          prefix = None
          suffix = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2sippyDestinationProvider =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

///Details about the configured destination bucket.
type r2sippyDestination =
    { ///ID of the Cloudflare API token used when writing objects to this
      ///bucket.
      accessKeyId: Option<string>
      account: Option<string>
      ///Name of the bucket on the provider.
      bucket: Option<string>
      provider: Option<r2sippyDestinationProvider> }
    ///Creates an instance of r2sippyDestination with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2sippyDestination =
        { accessKeyId = None
          account = None
          bucket = None
          provider = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2sippySourceProvider =
    | [<CompiledName "aws">] Aws
    | [<CompiledName "gcs">] Gcs
    | [<CompiledName "s3">] S3
    member this.Format() =
        match this with
        | Aws -> "aws"
        | Gcs -> "gcs"
        | S3 -> "s3"

///Details about the configured source bucket.
type r2sippySource =
    { ///Name of the bucket on the provider (AWS, GCS only).
      bucket: Option<string>
      ///S3-compatible URL (Generic S3-compatible providers only).
      bucketUrl: Option<string>
      provider: Option<r2sippySourceProvider>
      ///Region where the bucket resides (AWS only).
      region: Option<string> }
    ///Creates an instance of r2sippySource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2sippySource =
        { bucket = None
          bucketUrl = None
          provider = None
          region = None }

type r2sippy =
    { ///Details about the configured destination bucket.
      destination: Option<r2sippyDestination>
      ///State of Sippy for this bucket.
      enabled: Option<bool>
      ///Details about the configured source bucket.
      source: Option<r2sippySource> }
    ///Creates an instance of r2sippy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2sippy =
        { destination = None
          enabled = None
          source = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Permission =
    | [<CompiledName "admin-read-write">] AdminReadWrite
    | [<CompiledName "admin-read-only">] AdminReadOnly
    | [<CompiledName "object-read-write">] ObjectReadWrite
    | [<CompiledName "object-read-only">] ObjectReadOnly
    member this.Format() =
        match this with
        | AdminReadWrite -> "admin-read-write"
        | AdminReadOnly -> "admin-read-only"
        | ObjectReadWrite -> "object-read-write"
        | ObjectReadOnly -> "object-read-only"

type r2tempaccesscredsrequest =
    { ///Name of the R2 bucket.
      bucket: string
      ///Optional object paths to scope the credentials to.
      objects: Option<list<string>>
      ///The parent access key id to use for signing.
      parentAccessKeyId: string
      ///Permissions allowed on the credentials.
      permission: Permission
      ///Optional prefix paths to scope the credentials to.
      prefixes: Option<list<string>>
      ///How long the credentials will live for in seconds.
      ttlSeconds: float }
    ///Creates an instance of r2tempaccesscredsrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket: string, parentAccessKeyId: string, permission: Permission, ttlSeconds: float): r2tempaccesscredsrequest =
        { bucket = bucket
          objects = None
          parentAccessKeyId = parentAccessKeyId
          permission = permission
          prefixes = None
          ttlSeconds = ttlSeconds }

type r2tempaccesscredsresponse =
    { ///ID for new access key.
      accessKeyId: Option<string>
      ///Secret access key.
      secretAccessKey: Option<string>
      ///Security token.
      sessionToken: Option<string> }
    ///Creates an instance of r2tempaccesscredsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): r2tempaccesscredsresponse =
        { accessKeyId = None
          secretAccessKey = None
          sessionToken = None }

type r2v4responseErrors =
    { code: int
      message: string }
    ///Creates an instance of r2v4responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): r2v4responseErrors = { code = code; message = message }

type r2v4response =
    { errors: list<r2v4responseErrors>
      messages: r2messages
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2v4response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<r2v4responseErrors>,
                          messages: r2messages,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): r2v4response =
        { errors = errors
          messages = messages
          result = result
          success = success }

type r2v4responsefailureErrors =
    { code: int
      message: string }
    ///Creates an instance of r2v4responsefailureErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): r2v4responsefailureErrors = { code = code; message = message }

type r2v4responsefailure =
    { errors: list<r2v4responsefailureErrors>
      messages: r2messages
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2v4responsefailure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<r2v4responsefailureErrors>,
                          messages: r2messages,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): r2v4responsefailure =
        { errors = errors
          messages = messages
          result = result
          success = success }

type r2v4responselistErrors =
    { code: int
      message: string }
    ///Creates an instance of r2v4responselistErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): r2v4responselistErrors = { code = code; message = message }

type r2v4responselist =
    { errors: list<r2v4responselistErrors>
      messages: r2messages
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool
      result_info: Option<r2resultinfo> }
    ///Creates an instance of r2v4responselist with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<r2v4responselistErrors>,
                          messages: r2messages,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): r2v4responselist =
        { errors = errors
          messages = messages
          result = result
          success = success
          result_info = None }

type ``r2-list-bucketsresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-list-bucketsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-list-bucketsresponseErrors`` =
        { code = code; message = message }

type Result =
    { buckets: Option<list<r2bucket>> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result = { buckets = None }

type ``r2-list-bucketsresponse`` =
    { errors: list<``r2-list-bucketsresponseErrors``>
      messages: r2messages
      result: Result
      ///Whether the API call was successful.
      success: bool
      result_info: Option<r2resultinfo> }
    ///Creates an instance of r2-list-bucketsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-list-bucketsresponseErrors``>,
                          messages: r2messages,
                          result: Result,
                          success: bool): ``r2-list-bucketsresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success
          result_info = None }

type ``r2-create-bucketresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-create-bucketresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-create-bucketresponseErrors`` =
        { code = code; message = message }

type ``r2-create-bucketresponse`` =
    { errors: list<``r2-create-bucketresponseErrors``>
      messages: r2messages
      ///A single R2 bucket.
      result: r2bucket
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-create-bucketresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-create-bucketresponseErrors``>,
                          messages: r2messages,
                          result: r2bucket,
                          success: bool): ``r2-create-bucketresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``r2-get-bucketresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-get-bucketresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-get-bucketresponseErrors`` =
        { code = code; message = message }

type ``r2-get-bucketresponse`` =
    { errors: list<``r2-get-bucketresponseErrors``>
      messages: r2messages
      ///A single R2 bucket.
      result: r2bucket
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-get-bucketresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-get-bucketresponseErrors``>,
                          messages: r2messages,
                          result: r2bucket,
                          success: bool): ``r2-get-bucketresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``r2-patch-bucketresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-patch-bucketresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-patch-bucketresponseErrors`` =
        { code = code; message = message }

type ``r2-patch-bucketresponse`` =
    { errors: list<``r2-patch-bucketresponseErrors``>
      messages: r2messages
      ///A single R2 bucket.
      result: r2bucket
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-patch-bucketresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-patch-bucketresponseErrors``>,
                          messages: r2messages,
                          result: r2bucket,
                          success: bool): ``r2-patch-bucketresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``r2-delete-bucket-sippy-configresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-delete-bucket-sippy-configresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-delete-bucket-sippy-configresponseErrors`` =
        { code = code; message = message }

type ``r2-delete-bucket-sippy-configresponseResult`` =
    { enabled: Option<bool> }
    ///Creates an instance of r2-delete-bucket-sippy-configresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2-delete-bucket-sippy-configresponseResult`` = { enabled = None }

type ``r2-delete-bucket-sippy-configresponse`` =
    { errors: list<``r2-delete-bucket-sippy-configresponseErrors``>
      messages: r2messages
      result: ``r2-delete-bucket-sippy-configresponseResult``
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-delete-bucket-sippy-configresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-delete-bucket-sippy-configresponseErrors``>,
                          messages: r2messages,
                          result: ``r2-delete-bucket-sippy-configresponseResult``,
                          success: bool): ``r2-delete-bucket-sippy-configresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``r2-get-bucket-sippy-configresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-get-bucket-sippy-configresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-get-bucket-sippy-configresponseErrors`` =
        { code = code; message = message }

type ``r2-get-bucket-sippy-configresponse`` =
    { errors: list<``r2-get-bucket-sippy-configresponseErrors``>
      messages: r2messages
      result: r2sippy
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-get-bucket-sippy-configresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-get-bucket-sippy-configresponseErrors``>,
                          messages: r2messages,
                          result: r2sippy,
                          success: bool): ``r2-get-bucket-sippy-configresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``r2-put-bucket-sippy-configresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-put-bucket-sippy-configresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-put-bucket-sippy-configresponseErrors`` =
        { code = code; message = message }

type ``r2-put-bucket-sippy-configresponse`` =
    { errors: list<``r2-put-bucket-sippy-configresponseErrors``>
      messages: r2messages
      result: r2sippy
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-put-bucket-sippy-configresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-put-bucket-sippy-configresponseErrors``>,
                          messages: r2messages,
                          result: r2sippy,
                          success: bool): ``r2-put-bucket-sippy-configresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

[<RequireQualifiedAccess>]
type R2ListBuckets =
    ///List Buckets response.
    | OK of payload: ``r2-list-bucketsresponse``
    ///List Buckets response failure.
    | BadRequest of payload: r2v4responsefailure

type R2CreateBucketPayload =
    { ///Location of the bucket.
      locationHint: Option<r2bucketlocation>
      ///Name of the bucket.
      name: r2bucketname
      ///Storage class for newly uploaded objects, unless specified otherwise.
      storageClass: Option<r2storageclass> }
    ///Creates an instance of R2CreateBucketPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: r2bucketname): R2CreateBucketPayload =
        { locationHint = None
          name = name
          storageClass = None }

[<RequireQualifiedAccess>]
type R2CreateBucket =
    ///Create Bucket response.
    | OK of payload: ``r2-create-bucketresponse``
    ///Create Bucket response failure.
    | BadRequest of payload: r2v4responsefailure

[<RequireQualifiedAccess>]
type R2DeleteBucket =
    ///Delete Bucket response.
    | OK of payload: r2v4response
    ///Delete Bucket response failure.
    | BadRequest of payload: r2v4responsefailure

[<RequireQualifiedAccess>]
type R2GetBucket =
    ///Get Bucket response.
    | OK of payload: ``r2-get-bucketresponse``
    ///Get Bucket response failure.
    | BadRequest of payload: r2v4responsefailure

[<RequireQualifiedAccess>]
type R2PatchBucket =
    ///Patch Bucket response.
    | OK of payload: ``r2-patch-bucketresponse``
    ///Get Bucket response failure.
    | BadRequest of payload: r2v4responsefailure

[<RequireQualifiedAccess>]
type R2DeleteBucketSippyConfig =
    ///Delete Sippy Configuration response.
    | OK of payload: ``r2-delete-bucket-sippy-configresponse``
    ///Delete Sippy Configuration response failure.
    | BadRequest of payload: r2v4responsefailure

[<RequireQualifiedAccess>]
type R2GetBucketSippyConfig =
    ///Get Sippy Configuration response.
    | OK of payload: ``r2-get-bucket-sippy-configresponse``
    ///Get Sippy Configuration response failure.
    | BadRequest of payload: r2v4responsefailure

[<RequireQualifiedAccess>]
type R2PutBucketSippyConfig =
    ///Set Sippy Configuration response.
    | OK of payload: ``r2-put-bucket-sippy-configresponse``
    ///Get Sippy Configuration response failure.
    | BadRequest of payload: r2v4responsefailure
