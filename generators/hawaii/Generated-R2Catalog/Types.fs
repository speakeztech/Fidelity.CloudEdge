namespace rec Fidelity.CloudEdge.Management.R2Catalog.Types

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

type Errors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Errors = { code = None; message = None }

type ``r2-data-catalogapi-response-common-failure`` =
    { errors: Option<list<Errors>>
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

type Messages =
    { ///Specifies the message code.
      code: int
      ///Contains the message text.
      message: string }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Messages = { code = code; message = message }

type ``r2-data-catalogapi-response-single`` =
    { ///Contains errors if the API call was unsuccessful.
      errors: list<``r2-data-catalogapi-response-singleErrors``>
      ///Contains informational messages.
      messages: list<Messages>
      ///Indicates whether the API call was successful.
      success: ``r2-data-catalogapi-response-success`` }
    ///Creates an instance of r2-data-catalogapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-data-catalogapi-response-singleErrors``>,
                          messages: list<Messages>,
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

[<RequireQualifiedAccess>]
type ListCatalogs =
    ///List of R2 catalogs.
    | OK of payload: string
    ///Bad request.
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetCatalogDetails =
    ///R2 catalog details.
    | OK of payload: string
    ///Bad request.
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Catalog not found.
    | NotFound of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type StoreCredentials =
    ///Credentials stored successfully.
    | OK of payload: string
    ///Bad request.
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Catalog not found.
    | NotFound of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type DisableCatalog =
    ///Catalog disabled successfully.
    | NoContent of payload: Newtonsoft.Json.Linq.JToken
    ///Bad request.
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Catalog not found.
    | NotFound of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type EnableCatalog =
    ///Catalog enabled successfully.
    | OK of payload: string
    ///Bad request.
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Catalog already enabled.
    | Conflict of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetMaintenanceConfig =
    ///Maintenance configuration retrieved successfully.
    | OK of payload: string
    ///Bad request.
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Catalog not found.
    | NotFound of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type UpdateMaintenanceConfig =
    ///Maintenance configuration updated successfully.
    | OK of payload: string
    ///Bad request.
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Catalog not found.
    | NotFound of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type ListNamespaces =
    ///List of namespaces retrieved successfully.
    | OK of payload: string
    ///Bad request (e.g., invalid page_size, malformed parent namespace).
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Catalog not found.
    | NotFound of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type ListTables =
    ///List of tables retrieved successfully.
    | OK of payload: string
    ///Bad request (e.g., invalid page_size, malformed namespace).
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Catalog or namespace not found.
    | NotFound of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetTableMaintenanceConfig =
    ///Table maintenance configuration retrieved successfully.
    | OK of payload: string
    ///Bad request.
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Table not found.
    | NotFound of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``

[<RequireQualifiedAccess>]
type UpdateTableMaintenanceConfig =
    ///Table maintenance configuration updated successfully.
    | OK of payload: string
    ///Bad request.
    | BadRequest of payload: ``r2-data-catalogapi-response-common-failure``
    ///Authentication failed.
    | Unauthorized of payload: ``r2-data-catalogapi-response-common-failure``
    ///Forbidden.
    | Forbidden of payload: ``r2-data-catalogapi-response-common-failure``
    ///Table not found.
    | NotFound of payload: ``r2-data-catalogapi-response-common-failure``
    ///Internal server error.
    | InternalServerError of payload: ``r2-data-catalogapi-response-common-failure``
