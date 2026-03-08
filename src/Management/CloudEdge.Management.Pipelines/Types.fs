namespace rec Fidelity.CloudEdge.Management.Pipelines.Types

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``cloudflare-pipelinesDecimalEncoding`` =
    | [<CompiledName "number">] Number
    | [<CompiledName "string">] String
    | [<CompiledName "bytes">] Bytes
    member this.Format() =
        match this with
        | Number -> "number"
        | String -> "string"
        | Bytes -> "bytes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``cloudflare-pipelinesParquetCompression`` =
    | [<CompiledName "uncompressed">] Uncompressed
    | [<CompiledName "snappy">] Snappy
    | [<CompiledName "gzip">] Gzip
    | [<CompiledName "zstd">] Zstd
    | [<CompiledName "lz4">] Lz4
    member this.Format() =
        match this with
        | Uncompressed -> "uncompressed"
        | Snappy -> "snappy"
        | Gzip -> "gzip"
        | Zstd -> "zstd"
        | Lz4 -> "lz4"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``cloudflare-pipelinesTimestampFormat`` =
    | [<CompiledName "rfc3339">] Rfc3339
    | [<CompiledName "unix_millis">] Unix_millis
    member this.Format() =
        match this with
        | Rfc3339 -> "rfc3339"
        | Unix_millis -> "unix_millis"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``cloudflare-pipelinesTimestampUnit`` =
    | [<CompiledName "second">] Second
    | [<CompiledName "millisecond">] Millisecond
    | [<CompiledName "microsecond">] Microsecond
    | [<CompiledName "nanosecond">] Nanosecond
    member this.Format() =
        match this with
        | Second -> "second"
        | Millisecond -> "millisecond"
        | Microsecond -> "microsecond"
        | Nanosecond -> "nanosecond"

type ``cloudflare-pipelinesworker-pipelines-common-success`` = bool
///Specifies the public ID of the account.
type ``cloudflare-pipelinesworkers-pipelines-account-id`` = string
///Specifies the public ID of the pipeline.
type ``cloudflare-pipelinesworkers-pipelines-pipeline-id`` = string
///Specifies the publid ID of the sink.
type ``cloudflare-pipelinesworkers-pipelines-sink-id`` = string
///Specifies the public ID of the stream.
type ``cloudflare-pipelinesworkers-pipelines-stream-id`` = string

type ``cloudflare-pipelinesConnectionSchema`` =
    { fields: Option<list<``cloudflare-pipelinesSourceField``>>
      format: Option<Newtonsoft.Json.Linq.JToken>
      inferred: Option<bool> }
    ///Creates an instance of cloudflare-pipelinesConnectionSchema with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesConnectionSchema`` =
        { fields = None
          format = None
          inferred = None }

type ``cloudflare-pipelinesJsonFormat`` =
    { decimal_encoding: Option<``cloudflare-pipelinesDecimalEncoding``>
      timestamp_format: Option<``cloudflare-pipelinesTimestampFormat``>
      unstructured: Option<bool> }
    ///Creates an instance of cloudflare-pipelinesJsonFormat with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesJsonFormat`` =
        { decimal_encoding = None
          timestamp_format = None
          unstructured = None }

type ``cloudflare-pipelinesListField`` =
    { items: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of cloudflare-pipelinesListField with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (items: Newtonsoft.Json.Linq.JToken): ``cloudflare-pipelinesListField`` = { items = items }

type ``cloudflare-pipelinesParquetFormat`` =
    { compression: Option<``cloudflare-pipelinesParquetCompression``>
      row_group_bytes: Option<int64> }
    ///Creates an instance of cloudflare-pipelinesParquetFormat with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesParquetFormat`` =
        { compression = None
          row_group_bytes = None }

type ``cloudflare-pipelinesPipelineEdge`` =
    { dest_id: int
      edge_type: string
      key_type: string
      src_id: int
      value_type: string }
    ///Creates an instance of cloudflare-pipelinesPipelineEdge with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (dest_id: int, edge_type: string, key_type: string, src_id: int, value_type: string): ``cloudflare-pipelinesPipelineEdge`` =
        { dest_id = dest_id
          edge_type = edge_type
          key_type = key_type
          src_id = src_id
          value_type = value_type }

type ``cloudflare-pipelinesPipelineGraph`` =
    { edges: list<``cloudflare-pipelinesPipelineEdge``>
      nodes: list<``cloudflare-pipelinesPipelineNode``> }
    ///Creates an instance of cloudflare-pipelinesPipelineGraph with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (edges: list<``cloudflare-pipelinesPipelineEdge``>,
                          nodes: list<``cloudflare-pipelinesPipelineNode``>): ``cloudflare-pipelinesPipelineGraph`` =
        { edges = edges; nodes = nodes }

type ``cloudflare-pipelinesPipelineNode`` =
    { description: string
      node_id: int
      operator: string
      parallelism: int }
    ///Creates an instance of cloudflare-pipelinesPipelineNode with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (description: string, node_id: int, operator: string, parallelism: int): ``cloudflare-pipelinesPipelineNode`` =
        { description = description
          node_id = node_id
          operator = operator
          parallelism = parallelism }

type ``cloudflare-pipelinesSourceField`` =
    { metadata_key: Option<string>
      name: Option<string>
      required: Option<bool>
      sql_name: Option<string> }
    ///Creates an instance of cloudflare-pipelinesSourceField with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesSourceField`` =
        { metadata_key = None
          name = None
          required = None
          sql_name = None }

type ``cloudflare-pipelinesStructField`` =
    { fields: list<``cloudflare-pipelinesSourceField``>
      name: Option<string> }
    ///Creates an instance of cloudflare-pipelinesStructField with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (fields: list<``cloudflare-pipelinesSourceField``>): ``cloudflare-pipelinesStructField`` =
        { fields = fields; name = None }

type ``cloudflare-pipelinesTimestampField`` =
    { unit: Option<``cloudflare-pipelinesTimestampUnit``> }
    ///Creates an instance of cloudflare-pipelinesTimestampField with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesTimestampField`` = { unit = None }

type Credentials =
    { ///Cloudflare Account ID for the bucket
      access_key_id: string
      ///Cloudflare Account ID for the bucket
      secret_access_key: string }
    ///Creates an instance of Credentials with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (access_key_id: string, secret_access_key: string): Credentials =
        { access_key_id = access_key_id
          secret_access_key = secret_access_key }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Strategy =
    | [<CompiledName "serial">] Serial
    | [<CompiledName "uuid">] Uuid
    | [<CompiledName "uuid_v7">] Uuid_v7
    | [<CompiledName "ulid">] Ulid
    member this.Format() =
        match this with
        | Serial -> "serial"
        | Uuid -> "uuid"
        | Uuid_v7 -> "uuid_v7"
        | Ulid -> "ulid"

///Controls filename prefix/suffix and strategy.
type Filenaming =
    { ///The prefix to use in file name. i.e prefix-&amp;lt;uuid&amp;gt;.parquet
      prefix: Option<string>
      ///Filename generation strategy.
      strategy: Option<Strategy>
      ///This will overwrite the default file suffix. i.e .parquet, use with caution
      suffix: Option<string> }
    ///Creates an instance of Filenaming with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Filenaming =
        { prefix = None
          strategy = None
          suffix = None }

///Data-layout partitioning for sinks.
type Partitioning =
    { ///The pattern of the date string
      time_pattern: Option<string> }
    ///Creates an instance of Partitioning with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Partitioning = { time_pattern = None }

///Rolling policy for file sinks (when &amp; why to close a file and open a new one).
type Rollingpolicy =
    { ///Files will be rolled after reaching this number of bytes
      file_size_bytes: Option<int>
      ///Number of seconds of inactivity to wait before rolling over to a new file
      inactivity_seconds: Option<int>
      ///Number of seconds to wait before rolling over to a new file
      interval_seconds: Option<int> }
    ///Creates an instance of Rollingpolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Rollingpolicy =
        { file_size_bytes = None
          inactivity_seconds = None
          interval_seconds = None }

type ``cloudflare-pipelinesr2Table`` =
    { ///Cloudflare Account ID for the bucket
      account_id: string
      ///R2 Bucket to write to
      bucket: string
      credentials: Credentials
      ///Controls filename prefix/suffix and strategy.
      file_naming: Option<Filenaming>
      ///Jurisdiction this bucket is hosted in
      jurisdiction: Option<string>
      ///Data-layout partitioning for sinks.
      partitioning: Option<Partitioning>
      ///Subpath within the bucket to write to
      path: Option<string>
      ///Rolling policy for file sinks (when &amp; why to close a file and open a new one).
      rolling_policy: Option<Rollingpolicy> }
    ///Creates an instance of cloudflare-pipelinesr2Table with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (account_id: string, bucket: string, credentials: Credentials): ``cloudflare-pipelinesr2Table`` =
        { account_id = account_id
          bucket = bucket
          credentials = credentials
          file_naming = None
          jurisdiction = None
          partitioning = None
          path = None
          rolling_policy = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``cloudflare-pipelinesr2TablePublicFilenamingStrategy`` =
    | [<CompiledName "serial">] Serial
    | [<CompiledName "uuid">] Uuid
    | [<CompiledName "uuid_v7">] Uuid_v7
    | [<CompiledName "ulid">] Ulid
    member this.Format() =
        match this with
        | Serial -> "serial"
        | Uuid -> "uuid"
        | Uuid_v7 -> "uuid_v7"
        | Ulid -> "ulid"

///Controls filename prefix/suffix and strategy.
type ``cloudflare-pipelinesr2TablePublicFilenaming`` =
    { ///The prefix to use in file name. i.e prefix-&amp;lt;uuid&amp;gt;.parquet
      prefix: Option<string>
      ///Filename generation strategy.
      strategy: Option<``cloudflare-pipelinesr2TablePublicFilenamingStrategy``>
      ///This will overwrite the default file suffix. i.e .parquet, use with caution
      suffix: Option<string> }
    ///Creates an instance of cloudflare-pipelinesr2TablePublicFilenaming with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesr2TablePublicFilenaming`` =
        { prefix = None
          strategy = None
          suffix = None }

///Data-layout partitioning for sinks.
type ``cloudflare-pipelinesr2TablePublicPartitioning`` =
    { ///The pattern of the date string
      time_pattern: Option<string> }
    ///Creates an instance of cloudflare-pipelinesr2TablePublicPartitioning with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesr2TablePublicPartitioning`` = { time_pattern = None }

///Rolling policy for file sinks (when &amp; why to close a file and open a new one).
type ``cloudflare-pipelinesr2TablePublicRollingpolicy`` =
    { ///Files will be rolled after reaching this number of bytes
      file_size_bytes: Option<int>
      ///Number of seconds of inactivity to wait before rolling over to a new file
      inactivity_seconds: Option<int>
      ///Number of seconds to wait before rolling over to a new file
      interval_seconds: Option<int> }
    ///Creates an instance of cloudflare-pipelinesr2TablePublicRollingpolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesr2TablePublicRollingpolicy`` =
        { file_size_bytes = None
          inactivity_seconds = None
          interval_seconds = None }

///R2 Sink public configuration.
type ``cloudflare-pipelinesr2TablePublic`` =
    { ///Cloudflare Account ID for the bucket
      account_id: string
      ///R2 Bucket to write to
      bucket: string
      ///Controls filename prefix/suffix and strategy.
      file_naming: Option<``cloudflare-pipelinesr2TablePublicFilenaming``>
      ///Jurisdiction this bucket is hosted in
      jurisdiction: Option<string>
      ///Data-layout partitioning for sinks.
      partitioning: Option<``cloudflare-pipelinesr2TablePublicPartitioning``>
      ///Subpath within the bucket to write to
      path: Option<string>
      ///Rolling policy for file sinks (when &amp; why to close a file and open a new one).
      rolling_policy: Option<``cloudflare-pipelinesr2TablePublicRollingpolicy``> }
    ///Creates an instance of cloudflare-pipelinesr2TablePublic with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (account_id: string, bucket: string): ``cloudflare-pipelinesr2TablePublic`` =
        { account_id = account_id
          bucket = bucket
          file_naming = None
          jurisdiction = None
          partitioning = None
          path = None
          rolling_policy = None }

///Rolling policy for file sinks (when &amp; why to close a file and open a new one).
type ``cloudflare-pipelinesr2datacatalogTableRollingpolicy`` =
    { ///Files will be rolled after reaching this number of bytes
      file_size_bytes: Option<int>
      ///Number of seconds of inactivity to wait before rolling over to a new file
      inactivity_seconds: Option<int>
      ///Number of seconds to wait before rolling over to a new file
      interval_seconds: Option<int> }
    ///Creates an instance of cloudflare-pipelinesr2datacatalogTableRollingpolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesr2datacatalogTableRollingpolicy`` =
        { file_size_bytes = None
          inactivity_seconds = None
          interval_seconds = None }

///R2 Data Catalog Sink
type ``cloudflare-pipelinesr2datacatalogTable`` =
    { ///Cloudflare Account ID
      account_id: string
      ///The R2 Bucket that hosts this catalog
      bucket: string
      ///Table namespace
      ``namespace``: Option<string>
      ///Rolling policy for file sinks (when &amp; why to close a file and open a new one).
      rolling_policy: Option<``cloudflare-pipelinesr2datacatalogTableRollingpolicy``>
      ///Table name
      table_name: string
      ///Authentication token
      token: string }
    ///Creates an instance of cloudflare-pipelinesr2datacatalogTable with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (account_id: string, bucket: string, table_name: string, token: string): ``cloudflare-pipelinesr2datacatalogTable`` =
        { account_id = account_id
          bucket = bucket
          ``namespace`` = None
          rolling_policy = None
          table_name = table_name
          token = token }

///Rolling policy for file sinks (when &amp; why to close a file and open a new one).
type ``cloudflare-pipelinesr2datacatalogTablePublicRollingpolicy`` =
    { ///Files will be rolled after reaching this number of bytes
      file_size_bytes: Option<int>
      ///Number of seconds of inactivity to wait before rolling over to a new file
      inactivity_seconds: Option<int>
      ///Number of seconds to wait before rolling over to a new file
      interval_seconds: Option<int> }
    ///Creates an instance of cloudflare-pipelinesr2datacatalogTablePublicRollingpolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``cloudflare-pipelinesr2datacatalogTablePublicRollingpolicy`` =
        { file_size_bytes = None
          inactivity_seconds = None
          interval_seconds = None }

///R2 Data Catalog Sink public configuration.
type ``cloudflare-pipelinesr2datacatalogTablePublic`` =
    { ///Cloudflare Account ID
      account_id: string
      ///The R2 Bucket that hosts this catalog
      bucket: string
      ///Table namespace
      ``namespace``: Option<string>
      ///Rolling policy for file sinks (when &amp; why to close a file and open a new one).
      rolling_policy: Option<``cloudflare-pipelinesr2datacatalogTablePublicRollingpolicy``>
      ///Table name
      table_name: string }
    ///Creates an instance of cloudflare-pipelinesr2datacatalogTablePublic with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (account_id: string, bucket: string, table_name: string): ``cloudflare-pipelinesr2datacatalogTablePublic`` =
        { account_id = account_id
          bucket = bucket
          ``namespace`` = None
          rolling_policy = None
          table_name = table_name }

type Batch =
    { ///Specifies rough maximum size of files.
      max_bytes: int
      ///Specifies duration to wait to aggregate batches files.
      max_duration_s: float
      ///Specifies rough maximum number of rows per file.
      max_rows: int }
    ///Creates an instance of Batch with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (max_bytes: int, max_duration_s: float, max_rows: int): Batch =
        { max_bytes = max_bytes
          max_duration_s = max_duration_s
          max_rows = max_rows }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "none">] None
    | [<CompiledName "gzip">] Gzip
    | [<CompiledName "deflate">] Deflate
    member this.Format() =
        match this with
        | None -> "none"
        | Gzip -> "gzip"
        | Deflate -> "deflate"

type Compression =
    { ///Specifies the desired compression algorithm and format.
      ``type``: Type }
    ///Creates an instance of Compression with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: Type): Compression = { ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Format =
    | [<CompiledName "json">] Json
    member this.Format() =
        match this with
        | Json -> "json"

type Path =
    { ///Specifies the R2 Bucket to store files.
      bucket: string
      ///Specifies the name pattern to for individual data files.
      filename: Option<Newtonsoft.Json.Linq.JToken>
      ///Specifies the name pattern for directory.
      filepath: Option<string>
      ///Specifies the base directory within the bucket.
      prefix: Option<string> }
    ///Creates an instance of Path with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket: string): Path =
        { bucket = bucket
          filename = None
          filepath = None
          prefix = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DestinationType =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type Destination =
    { batch: Batch
      compression: Compression
      ///Specifies the format of data to deliver.
      format: Format
      path: Path
      ///Specifies the type of destination.
      ``type``: DestinationType }
    ///Creates an instance of Destination with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (batch: Batch, compression: Compression, format: Format, path: Path, ``type``: DestinationType): Destination =
        { batch = batch
          compression = compression
          format = format
          path = path
          ``type`` = ``type`` }

///[DEPRECATED] Describes the configuration of a pipeline. Use the new streams/sinks/pipelines API instead.
type ``cloudflare-pipelinesworkers-pipelines-pipeline`` =
    { destination: Destination
      ///Indicates the endpoint URL to send traffic.
      endpoint: string
      ///Specifies the pipeline identifier.
      id: string
      ///Defines the name of the pipeline.
      name: string
      source: list<string>
      ///Indicates the version number of last saved configuration.
      version: float }
    ///Creates an instance of cloudflare-pipelinesworkers-pipelines-pipeline with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination: Destination,
                          endpoint: string,
                          id: string,
                          name: string,
                          source: list<string>,
                          version: float): ``cloudflare-pipelinesworkers-pipelines-pipeline`` =
        { destination = destination
          endpoint = endpoint
          id = id
          name = name
          source = source
          version = version }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``cloudflare-pipelinesworkerspipelinesbindingsourceFormat`` =
    | [<CompiledName "json">] Json
    member this.Format() =
        match this with
        | Json -> "json"

///[DEPRECATED] Worker binding source configuration. Use the new streams API instead.
type ``cloudflare-pipelinesworkerspipelinesbindingsource`` =
    { ///Specifies the format of source data.
      format: ``cloudflare-pipelinesworkerspipelinesbindingsourceFormat``
      ``type``: string }
    ///Creates an instance of cloudflare-pipelinesworkerspipelinesbindingsource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (format: ``cloudflare-pipelinesworkerspipelinesbindingsourceFormat``, ``type``: string): ``cloudflare-pipelinesworkerspipelinesbindingsource`` =
        { format = format; ``type`` = ``type`` }

type Cors =
    { ///Specifies allowed origins to allow Cross Origin HTTP Requests.
      origins: Option<list<string>> }
    ///Creates an instance of Cors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Cors = { origins = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``cloudflare-pipelinesworkerspipelineshttpsourceFormat`` =
    | [<CompiledName "json">] Json
    member this.Format() =
        match this with
        | Json -> "json"

///[DEPRECATED] HTTP source configuration. Use the new streams API instead.
type ``cloudflare-pipelinesworkerspipelineshttpsource`` =
    { ///Specifies whether authentication is required to send to this pipeline via HTTP.
      authentication: Option<bool>
      cors: Option<Cors>
      ///Specifies the format of source data.
      format: ``cloudflare-pipelinesworkerspipelineshttpsourceFormat``
      ``type``: string }
    ///Creates an instance of cloudflare-pipelinesworkerspipelineshttpsource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (format: ``cloudflare-pipelinesworkerspipelineshttpsourceFormat``, ``type``: string): ``cloudflare-pipelinesworkerspipelineshttpsource`` =
        { authentication = None
          cors = None
          format = format
          ``type`` = ``type`` }

type Resultinfo =
    { ///Indicates the number of items on current page.
      count: float
      ///Indicates the current page number.
      page: float
      ///Indicates the number of items per page.
      per_page: float
      ///Indicates the total number of items.
      total_count: float }

type GetV4AccountsByAccountIdPipelinesDeprecated_OK =
    { result_info: Resultinfo
      results: list<``cloudflare-pipelinesworkers-pipelines-pipeline``>
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesDeprecated =
    ///[DEPRECATED] Lists the pipelines. Use /pipelines/v1/pipelines instead.
    | OK of payload: GetV4AccountsByAccountIdPipelinesDeprecated_OK

type PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationBatch =
    { ///Specifies rough maximum size of files.
      max_bytes: Option<int>
      ///Specifies duration to wait to aggregate batches files.
      max_duration_s: Option<float>
      ///Specifies rough maximum number of rows per file.
      max_rows: Option<int> }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationBatch with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationBatch =
        { max_bytes = None
          max_duration_s = None
          max_rows = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCompressionType =
    | [<CompiledName "none">] None
    | [<CompiledName "gzip">] Gzip
    | [<CompiledName "deflate">] Deflate
    member this.Format() =
        match this with
        | None -> "none"
        | Gzip -> "gzip"
        | Deflate -> "deflate"

type PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCompression =
    { ///Specifies the desired compression algorithm and format.
      ``type``: Option<PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCompressionType> }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCompression with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCompression =
        { ``type`` = None }

type PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCredentials =
    { ///Specifies the R2 Bucket Access Key Id.
      access_key_id: string
      ///Specifies the R2 Endpoint.
      endpoint: string
      ///Specifies the R2 Bucket Secret Access Key.
      secret_access_key: string }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCredentials with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (access_key_id: string, endpoint: string, secret_access_key: string): PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCredentials =
        { access_key_id = access_key_id
          endpoint = endpoint
          secret_access_key = secret_access_key }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationFormat =
    | [<CompiledName "json">] Json
    member this.Format() =
        match this with
        | Json -> "json"

type PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationPath =
    { ///Specifies the R2 Bucket to store files.
      bucket: string
      ///Specifies the name pattern to for individual data files.
      filename: Option<Newtonsoft.Json.Linq.JToken>
      ///Specifies the name pattern for directory.
      filepath: Option<string>
      ///Specifies the base directory within the bucket.
      prefix: Option<string> }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationPath with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket: string): PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationPath =
        { bucket = bucket
          filename = None
          filepath = None
          prefix = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationType =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestination =
    { batch: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationBatch
      compression: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCompression
      credentials: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCredentials
      ///Specifies the format of data to deliver.
      format: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationFormat
      path: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationPath
      ///Specifies the type of destination.
      ``type``: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationType }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestination with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (batch: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationBatch,
                          compression: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCompression,
                          credentials: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationCredentials,
                          format: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationFormat,
                          path: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationPath,
                          ``type``: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestinationType): PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestination =
        { batch = batch
          compression = compression
          credentials = credentials
          format = format
          path = path
          ``type`` = ``type`` }

type PostV4AccountsByAccountIdPipelinesDeprecatedPayload =
    { destination: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestination
      ///Defines the name of the pipeline.
      name: string
      source: list<string> }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesDeprecatedPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination: PostV4AccountsByAccountIdPipelinesDeprecatedPayloadDestination,
                          name: string,
                          source: list<string>): PostV4AccountsByAccountIdPipelinesDeprecatedPayload =
        { destination = destination
          name = name
          source = source }

type PostV4AccountsByAccountIdPipelinesDeprecated_OK =
    { ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesDeprecated =
    ///[DEPRECATED] Indicates a successfully created pipeline. Use /pipelines/v1/pipelines instead.
    | OK of payload: PostV4AccountsByAccountIdPipelinesDeprecated_OK

type Result =
    { created_at: string
      ///Indicates a unique identifier for this pipeline.
      id: string
      modified_at: string
      ///Indicates the name of the Pipeline.
      name: string
      ///Specifies SQL for the Pipeline processing flow.
      sql: string
      ///Indicates the current status of the Pipeline.
      status: string }

type GetV4AccountsByAccountIdPipelinesV1Pipelines_OKResultinfo =
    { ///Indicates the number of items on current page.
      count: float
      ///Indicates the current page number.
      page: float
      ///Indicates the number of items per page.
      per_page: float
      ///Indicates the total number of items.
      total_count: float }

type GetV4AccountsByAccountIdPipelinesV1Pipelines_OK =
    { result: list<Result>
      result_info: GetV4AccountsByAccountIdPipelinesV1Pipelines_OKResultinfo
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesV1Pipelines =
    ///Indicates a successfully listed Pipelines.
    | OK of payload: GetV4AccountsByAccountIdPipelinesV1Pipelines_OK

type PostV4AccountsByAccountIdPipelinesV1PipelinesPayload =
    { ///Specifies the name of the Pipeline.
      name: string
      ///Specifies SQL for the Pipeline processing flow.
      sql: string }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesV1PipelinesPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, sql: string): PostV4AccountsByAccountIdPipelinesV1PipelinesPayload =
        { name = name; sql = sql }

type PostV4AccountsByAccountIdPipelinesV1Pipelines_OKResult =
    { created_at: string
      ///Indicates a unique identifier for this pipeline.
      id: string
      modified_at: string
      ///Indicates the name of the Pipeline.
      name: string
      ///Specifies SQL for the Pipeline processing flow.
      sql: string
      ///Indicates the current status of the Pipeline.
      status: string }

type PostV4AccountsByAccountIdPipelinesV1Pipelines_OK =
    { result: PostV4AccountsByAccountIdPipelinesV1Pipelines_OKResult
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesV1Pipelines =
    ///Indicates a successfully created Pipeline.
    | OK of payload: PostV4AccountsByAccountIdPipelinesV1Pipelines_OK

[<RequireQualifiedAccess>]
type DeleteV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId =
    ///Indicates a successfully deleted Pipeline.
    | OK of payload: Newtonsoft.Json.Linq.JToken

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TablesType =
    | [<CompiledName "stream">] Stream
    | [<CompiledName "sink">] Sink
    member this.Format() =
        match this with
        | Stream -> "stream"
        | Sink -> "sink"

type Tables =
    { ///Unique identifier for the connection (stream or sink).
      id: string
      ///Latest available version of the connection.
      latest: int
      ///Name of the connection.
      name: string
      ///Type of the connection.
      ``type``: TablesType
      ///Current version of the connection used by this pipeline.
      version: int }

type GetV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId_OKResult =
    { created_at: string
      ///Indicates a unique identifier for this pipeline.
      id: string
      modified_at: string
      ///Indicates the name of the Pipeline.
      name: string
      ///Specifies SQL for the Pipeline processing flow.
      sql: string
      ///Indicates the current status of the Pipeline.
      status: string
      ///List of streams and sinks used by this pipeline.
      tables: list<Tables> }

type GetV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId_OK =
    { result: GetV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId_OKResult
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId =
    ///Indicates a successfully retrieved Pipeline.
    | OK of payload: GetV4AccountsByAccountIdPipelinesV1PipelinesByPipelineId_OK

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesV1Sinks_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "r2_data_catalog">] R2_data_catalog
    member this.Format() =
        match this with
        | R2 -> "r2"
        | R2_data_catalog -> "r2_data_catalog"

type GetV4AccountsByAccountIdPipelinesV1Sinks_OKResult =
    { ///Defines the configuration of the R2 Sink.
      config: Option<Newtonsoft.Json.Linq.JToken>
      created_at: System.DateTimeOffset
      format: Option<Newtonsoft.Json.Linq.JToken>
      ///Indicates a unique identifier for this sink.
      id: string
      modified_at: System.DateTimeOffset
      ///Defines the name of the Sink.
      name: string
      schema: Option<``cloudflare-pipelinesConnectionSchema``>
      ///Specifies the type of sink.
      ``type``: GetV4AccountsByAccountIdPipelinesV1Sinks_OKResultType }

type GetV4AccountsByAccountIdPipelinesV1Sinks_OKResultinfo =
    { ///Indicates the number of items on current page.
      count: float
      ///Indicates the current page number.
      page: float
      ///Indicates the number of items per page.
      per_page: float
      ///Indicates the total number of items.
      total_count: float }

type GetV4AccountsByAccountIdPipelinesV1Sinks_OK =
    { result: list<GetV4AccountsByAccountIdPipelinesV1Sinks_OKResult>
      result_info: GetV4AccountsByAccountIdPipelinesV1Sinks_OKResultinfo
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesV1Sinks =
    ///Indicates successfully listed Sinks.
    | OK of payload: GetV4AccountsByAccountIdPipelinesV1Sinks_OK

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesV1SinksPayloadType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "r2_data_catalog">] R2_data_catalog
    member this.Format() =
        match this with
        | R2 -> "r2"
        | R2_data_catalog -> "r2_data_catalog"

type PostV4AccountsByAccountIdPipelinesV1SinksPayload =
    { ///Defines the configuration of the R2 Sink.
      config: Option<Newtonsoft.Json.Linq.JToken>
      format: Option<Newtonsoft.Json.Linq.JToken>
      ///Defines the name of the Sink.
      name: string
      schema: Option<``cloudflare-pipelinesConnectionSchema``>
      ///Specifies the type of sink.
      ``type``: PostV4AccountsByAccountIdPipelinesV1SinksPayloadType }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesV1SinksPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, ``type``: PostV4AccountsByAccountIdPipelinesV1SinksPayloadType): PostV4AccountsByAccountIdPipelinesV1SinksPayload =
        { config = None
          format = None
          name = name
          schema = None
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesV1Sinks_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "r2_data_catalog">] R2_data_catalog
    member this.Format() =
        match this with
        | R2 -> "r2"
        | R2_data_catalog -> "r2_data_catalog"

type PostV4AccountsByAccountIdPipelinesV1Sinks_OKResult =
    { config: Option<Newtonsoft.Json.Linq.JToken>
      created_at: System.DateTimeOffset
      format: Option<Newtonsoft.Json.Linq.JToken>
      ///Indicates a unique identifier for this sink.
      id: string
      modified_at: System.DateTimeOffset
      ///Defines the name of the Sink.
      name: string
      schema: Option<``cloudflare-pipelinesConnectionSchema``>
      ///Specifies the type of sink.
      ``type``: PostV4AccountsByAccountIdPipelinesV1Sinks_OKResultType }

type PostV4AccountsByAccountIdPipelinesV1Sinks_OK =
    { result: PostV4AccountsByAccountIdPipelinesV1Sinks_OKResult
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesV1Sinks =
    ///Indicates a successfully created Sink.
    | OK of payload: PostV4AccountsByAccountIdPipelinesV1Sinks_OK

[<RequireQualifiedAccess>]
type DeleteV4AccountsByAccountIdPipelinesV1SinksBySinkId =
    ///Indicates a successfully deleted Sink.
    | OK of payload: Newtonsoft.Json.Linq.JToken

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesV1SinksBySinkId_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "r2_data_catalog">] R2_data_catalog
    member this.Format() =
        match this with
        | R2 -> "r2"
        | R2_data_catalog -> "r2_data_catalog"

type GetV4AccountsByAccountIdPipelinesV1SinksBySinkId_OKResult =
    { ///Defines the configuration of the R2 Sink.
      config: Option<Newtonsoft.Json.Linq.JToken>
      created_at: System.DateTimeOffset
      format: Option<Newtonsoft.Json.Linq.JToken>
      ///Indicates a unique identifier for this sink.
      id: string
      modified_at: System.DateTimeOffset
      ///Defines the name of the Sink.
      name: string
      schema: Option<``cloudflare-pipelinesConnectionSchema``>
      ///Specifies the type of sink.
      ``type``: GetV4AccountsByAccountIdPipelinesV1SinksBySinkId_OKResultType }

type GetV4AccountsByAccountIdPipelinesV1SinksBySinkId_OK =
    { result: GetV4AccountsByAccountIdPipelinesV1SinksBySinkId_OKResult
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesV1SinksBySinkId =
    ///Indicates that Sink was retrieved.
    | OK of payload: GetV4AccountsByAccountIdPipelinesV1SinksBySinkId_OK

///Specifies the CORS options for the HTTP endpoint.
type HttpCors = { origins: Option<list<string>> }

type Http =
    { ///Indicates that authentication is required for the HTTP endpoint.
      authentication: bool
      ///Specifies the CORS options for the HTTP endpoint.
      cors: Option<HttpCors>
      ///Indicates that the HTTP endpoint is enabled.
      enabled: bool }

type Workerbinding =
    { ///Indicates that the worker binding is enabled.
      enabled: bool }

type GetV4AccountsByAccountIdPipelinesV1Streams_OKResult =
    { created_at: System.DateTimeOffset
      ///Indicates the endpoint URL of this stream.
      endpoint: Option<string>
      format: Option<Newtonsoft.Json.Linq.JToken>
      http: Http
      ///Indicates a unique identifier for this stream.
      id: string
      modified_at: System.DateTimeOffset
      ///Indicates the name of the Stream.
      name: string
      schema: Option<``cloudflare-pipelinesConnectionSchema``>
      ///Indicates the current version of this stream.
      version: int
      worker_binding: Workerbinding }

type GetV4AccountsByAccountIdPipelinesV1Streams_OKResultinfo =
    { ///Indicates the number of items on current page.
      count: float
      ///Indicates the current page number.
      page: float
      ///Indicates the number of items per page.
      per_page: float
      ///Indicates the total number of items.
      total_count: float }

type GetV4AccountsByAccountIdPipelinesV1Streams_OK =
    { result: list<GetV4AccountsByAccountIdPipelinesV1Streams_OKResult>
      result_info: GetV4AccountsByAccountIdPipelinesV1Streams_OKResultinfo
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesV1Streams =
    ///Indicates a successfully created Stream.
    | OK of payload: GetV4AccountsByAccountIdPipelinesV1Streams_OK

///Specifies the CORS options for the HTTP endpoint.
type PostV4AccountsByAccountIdPipelinesV1StreamsPayloadHttpCors =
    { origins: Option<list<string>> }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesV1StreamsPayloadHttpCors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PostV4AccountsByAccountIdPipelinesV1StreamsPayloadHttpCors = { origins = None }

type PostV4AccountsByAccountIdPipelinesV1StreamsPayloadHttp =
    { ///Indicates that authentication is required for the HTTP endpoint.
      authentication: bool
      ///Specifies the CORS options for the HTTP endpoint.
      cors: Option<PostV4AccountsByAccountIdPipelinesV1StreamsPayloadHttpCors>
      ///Indicates that the HTTP endpoint is enabled.
      enabled: bool }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesV1StreamsPayloadHttp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (authentication: bool, enabled: bool): PostV4AccountsByAccountIdPipelinesV1StreamsPayloadHttp =
        { authentication = authentication
          cors = None
          enabled = enabled }

type PostV4AccountsByAccountIdPipelinesV1StreamsPayloadWorkerbinding =
    { ///Indicates that the worker binding is enabled.
      enabled: bool }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesV1StreamsPayloadWorkerbinding with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool): PostV4AccountsByAccountIdPipelinesV1StreamsPayloadWorkerbinding =
        { enabled = enabled }

type PostV4AccountsByAccountIdPipelinesV1StreamsPayload =
    { format: Option<Newtonsoft.Json.Linq.JToken>
      http: Option<PostV4AccountsByAccountIdPipelinesV1StreamsPayloadHttp>
      ///Specifies the name of the Stream.
      name: string
      schema: Option<``cloudflare-pipelinesConnectionSchema``>
      worker_binding: Option<PostV4AccountsByAccountIdPipelinesV1StreamsPayloadWorkerbinding> }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesV1StreamsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): PostV4AccountsByAccountIdPipelinesV1StreamsPayload =
        { format = None
          http = None
          name = name
          schema = None
          worker_binding = None }

///Specifies the CORS options for the HTTP endpoint.
type PostV4AccountsByAccountIdPipelinesV1Streams_OKResultHttpCors = { origins: Option<list<string>> }

type PostV4AccountsByAccountIdPipelinesV1Streams_OKResultHttp =
    { ///Indicates that authentication is required for the HTTP endpoint.
      authentication: bool
      ///Specifies the CORS options for the HTTP endpoint.
      cors: Option<PostV4AccountsByAccountIdPipelinesV1Streams_OKResultHttpCors>
      ///Indicates that the HTTP endpoint is enabled.
      enabled: bool }

type PostV4AccountsByAccountIdPipelinesV1Streams_OKResultWorkerbinding =
    { ///Indicates that the worker binding is enabled.
      enabled: bool }

type PostV4AccountsByAccountIdPipelinesV1Streams_OKResult =
    { created_at: System.DateTimeOffset
      ///Indicates the endpoint URL of this stream.
      endpoint: Option<string>
      format: Option<Newtonsoft.Json.Linq.JToken>
      http: PostV4AccountsByAccountIdPipelinesV1Streams_OKResultHttp
      ///Indicates a unique identifier for this stream.
      id: string
      modified_at: System.DateTimeOffset
      ///Indicates the name of the Stream.
      name: string
      schema: Option<``cloudflare-pipelinesConnectionSchema``>
      ///Indicates the current version of this stream.
      version: int
      worker_binding: PostV4AccountsByAccountIdPipelinesV1Streams_OKResultWorkerbinding }

type PostV4AccountsByAccountIdPipelinesV1Streams_OK =
    { result: PostV4AccountsByAccountIdPipelinesV1Streams_OKResult
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesV1Streams =
    ///Indicates a successfully created Stream.
    | OK of payload: PostV4AccountsByAccountIdPipelinesV1Streams_OK

[<RequireQualifiedAccess>]
type DeleteV4AccountsByAccountIdPipelinesV1StreamsByStreamId =
    ///Indicates a successfully deleted Stream.
    | OK of payload: Newtonsoft.Json.Linq.JToken

///Specifies the CORS options for the HTTP endpoint.
type GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultHttpCors = { origins: Option<list<string>> }

type GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultHttp =
    { ///Indicates that authentication is required for the HTTP endpoint.
      authentication: bool
      ///Specifies the CORS options for the HTTP endpoint.
      cors: Option<GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultHttpCors>
      ///Indicates that the HTTP endpoint is enabled.
      enabled: bool }

type GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultWorkerbinding =
    { ///Indicates that the worker binding is enabled.
      enabled: bool }

type GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResult =
    { created_at: System.DateTimeOffset
      ///Indicates the endpoint URL of this stream.
      endpoint: Option<string>
      format: Option<Newtonsoft.Json.Linq.JToken>
      http: GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultHttp
      ///Indicates a unique identifier for this stream.
      id: string
      modified_at: System.DateTimeOffset
      ///Indicates the name of the Stream.
      name: string
      schema: Option<``cloudflare-pipelinesConnectionSchema``>
      ///Indicates the current version of this stream.
      version: int
      worker_binding: GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultWorkerbinding }

type GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OK =
    { result: GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResult
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId =
    ///Indicates a successfully retrieved Stream.
    | OK of payload: GetV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OK

///Specifies the CORS options for the HTTP endpoint.
type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadHttpCors =
    { origins: Option<list<string>> }
    ///Creates an instance of PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadHttpCors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadHttpCors = { origins = None }

type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadHttp =
    { ///Indicates that authentication is required for the HTTP endpoint.
      authentication: bool
      ///Specifies the CORS options for the HTTP endpoint.
      cors: Option<PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadHttpCors>
      ///Indicates that the HTTP endpoint is enabled.
      enabled: bool }
    ///Creates an instance of PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadHttp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (authentication: bool, enabled: bool): PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadHttp =
        { authentication = authentication
          cors = None
          enabled = enabled }

type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadWorkerbinding =
    { ///Indicates that the worker binding is enabled.
      enabled: bool }
    ///Creates an instance of PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadWorkerbinding with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool): PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadWorkerbinding =
        { enabled = enabled }

type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayload =
    { http: Option<PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadHttp>
      worker_binding: Option<PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayloadWorkerbinding> }
    ///Creates an instance of PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamIdPayload =
        { http = None; worker_binding = None }

///Specifies the CORS options for the HTTP endpoint.
type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultHttpCors = { origins: Option<list<string>> }

type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultHttp =
    { ///Indicates that authentication is required for the HTTP endpoint.
      authentication: bool
      ///Specifies the CORS options for the HTTP endpoint.
      cors: Option<PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultHttpCors>
      ///Indicates that the HTTP endpoint is enabled.
      enabled: bool }

type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultWorkerbinding =
    { ///Indicates that the worker binding is enabled.
      enabled: bool }

type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResult =
    { created_at: System.DateTimeOffset
      ///Indicates the endpoint URL of this stream.
      endpoint: Option<string>
      format: Option<Newtonsoft.Json.Linq.JToken>
      http: PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultHttp
      ///Indicates a unique identifier for this stream.
      id: string
      modified_at: System.DateTimeOffset
      ///Indicates the name of the Stream.
      name: string
      ///Indicates the current version of this stream.
      version: int
      worker_binding: PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResultWorkerbinding }

type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OK =
    { result: PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OKResult
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId =
    ///Indicates a successfully updated Stream.
    | OK of payload: PatchV4AccountsByAccountIdPipelinesV1StreamsByStreamId_OK

type PostV4AccountsByAccountIdPipelinesV1ValidateSqlPayload =
    { ///Specifies SQL to validate.
      sql: string }
    ///Creates an instance of PostV4AccountsByAccountIdPipelinesV1ValidateSqlPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (sql: string): PostV4AccountsByAccountIdPipelinesV1ValidateSqlPayload = { sql = sql }

type PostV4AccountsByAccountIdPipelinesV1ValidateSql_OKResult =
    { graph: Option<``cloudflare-pipelinesPipelineGraph``>
      ///Indicates tables involved in the processing.
      tables: Map<string, string> }

type PostV4AccountsByAccountIdPipelinesV1ValidateSql_OK =
    { result: PostV4AccountsByAccountIdPipelinesV1ValidateSql_OKResult
      ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type PostV4AccountsByAccountIdPipelinesV1ValidateSql =
    ///Indicates SQL validation success.
    | OK of payload: PostV4AccountsByAccountIdPipelinesV1ValidateSql_OK

[<RequireQualifiedAccess>]
type DeleteV4AccountsByAccountIdPipelinesByPipelineNameDeprecated =
    ///[DEPRECATED] Indicates a successfully deleted pipeline.
    | OK of payload: Newtonsoft.Json.Linq.JToken

type GetV4AccountsByAccountIdPipelinesByPipelineNameDeprecated_OK =
    { ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

type Errors = { code: float; message: string }

type GetV4AccountsByAccountIdPipelinesByPipelineNameDeprecated_NotFound =
    { errors: list<Errors>
      results: Newtonsoft.Json.Linq.JObject
      success: Newtonsoft.Json.Linq.JToken }

[<RequireQualifiedAccess>]
type GetV4AccountsByAccountIdPipelinesByPipelineNameDeprecated =
    ///[DEPRECATED] Describes the configuration of a pipeline.
    | OK of payload: GetV4AccountsByAccountIdPipelinesByPipelineNameDeprecated_OK
    ///Indicates that the pipeline was not found.
    | NotFound of payload: GetV4AccountsByAccountIdPipelinesByPipelineNameDeprecated_NotFound

type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationBatch =
    { ///Specifies rough maximum size of files.
      max_bytes: Option<int>
      ///Specifies duration to wait to aggregate batches files.
      max_duration_s: Option<float>
      ///Specifies rough maximum number of rows per file.
      max_rows: Option<int> }
    ///Creates an instance of PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationBatch with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationBatch =
        { max_bytes = None
          max_duration_s = None
          max_rows = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCompressionType =
    | [<CompiledName "none">] None
    | [<CompiledName "gzip">] Gzip
    | [<CompiledName "deflate">] Deflate
    member this.Format() =
        match this with
        | None -> "none"
        | Gzip -> "gzip"
        | Deflate -> "deflate"

type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCompression =
    { ///Specifies the desired compression algorithm and format.
      ``type``: Option<PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCompressionType> }
    ///Creates an instance of PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCompression with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCompression =
        { ``type`` = None }

type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCredentials =
    { ///Specifies the R2 Bucket Access Key Id.
      access_key_id: string
      ///Specifies the R2 Endpoint.
      endpoint: string
      ///Specifies the R2 Bucket Secret Access Key.
      secret_access_key: string }
    ///Creates an instance of PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCredentials with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (access_key_id: string, endpoint: string, secret_access_key: string): PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCredentials =
        { access_key_id = access_key_id
          endpoint = endpoint
          secret_access_key = secret_access_key }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationFormat =
    | [<CompiledName "json">] Json
    member this.Format() =
        match this with
        | Json -> "json"

type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationPath =
    { ///Specifies the R2 Bucket to store files.
      bucket: string
      ///Specifies the name pattern to for individual data files.
      filename: Option<Newtonsoft.Json.Linq.JToken>
      ///Specifies the name pattern for directory.
      filepath: Option<string>
      ///Specifies the base directory within the bucket.
      prefix: Option<string> }
    ///Creates an instance of PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationPath with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (bucket: string): PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationPath =
        { bucket = bucket
          filename = None
          filepath = None
          prefix = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationType =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestination =
    { batch: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationBatch
      compression: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCompression
      credentials: Option<PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCredentials>
      ///Specifies the format of data to deliver.
      format: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationFormat
      path: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationPath
      ///Specifies the type of destination.
      ``type``: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationType }
    ///Creates an instance of PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestination with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (batch: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationBatch,
                          compression: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationCompression,
                          format: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationFormat,
                          path: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationPath,
                          ``type``: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestinationType): PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestination =
        { batch = batch
          compression = compression
          credentials = None
          format = format
          path = path
          ``type`` = ``type`` }

type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayload =
    { destination: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestination
      ///Defines the name of the pipeline.
      name: string
      source: list<string> }
    ///Creates an instance of PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayloadDestination,
                          name: string,
                          source: list<string>): PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecatedPayload =
        { destination = destination
          name = name
          source = source }

type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecated_OK =
    { ///Indicates whether the API call was successful.
      success: ``cloudflare-pipelinesworker-pipelines-common-success`` }

[<RequireQualifiedAccess>]
type PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecated =
    ///[DEPRECATED] Indicates a successfully updated pipeline.
    | OK of payload: PutV4AccountsByAccountIdPipelinesByPipelineNameDeprecated_OK
