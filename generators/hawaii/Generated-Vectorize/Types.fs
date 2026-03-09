namespace rec Fidelity.CloudEdge.Management.Vectorize.Types

// Auto-generated stub types (missing from Hawaii output)
type dimensions = string
type indexed = string
type metadata = string
type results = string
type vector = string
type vectors = string

///Identifier
type vectorizeidentifier = string
///Specifies the description of the index.
type ``vectorizeindex-description`` = string
type ``vectorizeindex-dimensions`` = int

type ``vectorizeindex-get-vectors-by-id-responseArrayItem`` =
    { ///Identifier for a Vector
      id: Option<``vectorizevector-identifier``>
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      ``namespace``: Option<string>
      values: Option<list<float>> }
    ///Creates an instance of vectorizeindex-get-vectors-by-id-responseArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-get-vectors-by-id-responseArrayItem`` =
        { id = None
          metadata = None
          ``namespace`` = None
          values = None }

type ``vectorizeindex-get-vectors-by-id-response`` = list<``vectorizeindex-get-vectors-by-id-responseArrayItem``>

///Specifies the type of metric to use calculating distance.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vectorizeindex-metric`` =
    | [<CompiledName "cosine">] Cosine
    | [<CompiledName "euclidean">] Euclidean
    | [<CompiledName "dot-product">] DotProduct
    member this.Format() =
        match this with
        | Cosine -> "cosine"
        | Euclidean -> "euclidean"
        | DotProduct -> "dot-product"

type ``vectorizeindex-name`` = string

///Specifies the preset to use for the index.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vectorizeindex-preset`` =
    | [<CompiledName "@cf/baai/bge-small-en-v1.5">] ``@cfBaaiBgeSmallEnV1Numeric_5``
    | [<CompiledName "@cf/baai/bge-base-en-v1.5">] ``@cfBaaiBgeBaseEnV1Numeric_5``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "openai/text-embedding-ada-002">] OpenaiTextEmbeddingAdaNumeric_002
    | [<CompiledName "cohere/embed-multilingual-v2.0">] CohereEmbedMultilingualV2Numeric_0
    member this.Format() =
        match this with
        | ``@cfBaaiBgeSmallEnV1Numeric_5`` -> "@cf/baai/bge-small-en-v1.5"
        | ``@cfBaaiBgeBaseEnV1Numeric_5`` -> "@cf/baai/bge-base-en-v1.5"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | OpenaiTextEmbeddingAdaNumeric_002 -> "openai/text-embedding-ada-002"
        | CohereEmbedMultilingualV2Numeric_0 -> "cohere/embed-multilingual-v2.0"

type vectorizemessagesArrayItem =
    { code: int
      message: string }
    ///Creates an instance of vectorizemessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): vectorizemessagesArrayItem = { code = code; message = message }

type vectorizemessages = list<vectorizemessagesArrayItem>
///Identifier for a Vector
type ``vectorizevector-identifier`` = string

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

type ``vectorizeapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool>
      result_info: Option<vectorizeresultinfo> }
    ///Creates an instance of vectorizeapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeapi-response-collection`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type ``vectorizeapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorizeapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorizeapi-response-commonErrors`` =
        { code = code; message = message }

type ``vectorizeapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorizeapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorizeapi-response-commonMessages`` =
        { code = code; message = message }

type ``vectorizeapi-response-common`` =
    { errors: list<``vectorizeapi-response-commonErrors``>
      messages: list<``vectorizeapi-response-commonMessages``>
      result: Newtonsoft.Json.Linq.JToken
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorizeapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorizeapi-response-commonErrors``>,
                          messages: list<``vectorizeapi-response-commonMessages``>,
                          result: Newtonsoft.Json.Linq.JToken,
                          success: bool): ``vectorizeapi-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorizeapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorizeapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``vectorizeapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorizeapi-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorizeapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorizeapi-response-singleErrors`` =
        { code = code; message = message }

type ``vectorizeapi-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorizeapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorizeapi-response-singleMessages`` =
        { code = code; message = message }

type Result = Map<string, Newtonsoft.Json.Linq.JToken>

type ``vectorizeapi-response-single`` =
    { errors: Option<list<``vectorizeapi-response-singleErrors``>>
      messages: Option<list<``vectorizeapi-response-singleMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of vectorizeapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeapi-response-single`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``vectorizecreate-index-request`` =
    { config: Newtonsoft.Json.Linq.JToken
      ///Specifies the description of the index.
      description: Option<``vectorizeindex-description``>
      name: ``vectorizeindex-name`` }
    ///Creates an instance of vectorizecreate-index-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (config: Newtonsoft.Json.Linq.JToken, name: ``vectorizeindex-name``): ``vectorizecreate-index-request`` =
        { config = config
          description = None
          name = name }

type ``vectorizecreate-index-response`` =
    { config: Option<``vectorizeindex-dimension-configuration``>
      ///Specifies the timestamp the resource was created as an ISO8601 string.
      created_on: Option<System.DateTimeOffset>
      ///Specifies the description of the index.
      description: Option<``vectorizeindex-description``>
      ///Specifies the timestamp the resource was modified as an ISO8601 string.
      modified_on: Option<System.DateTimeOffset>
      name: Option<``vectorizeindex-name``> }
    ///Creates an instance of vectorizecreate-index-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizecreate-index-response`` =
        { config = None
          created_on = None
          description = None
          modified_on = None
          name = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IndexType =
    | [<CompiledName "string">] String
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | String -> "string"
        | Number -> "number"
        | Boolean -> "boolean"

type ``vectorizecreate-metadata-index-request`` =
    { ///Specifies the type of metadata property to index.
      indexType: IndexType
      ///Specifies the metadata property to index.
      propertyName: string }
    ///Creates an instance of vectorizecreate-metadata-index-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (indexType: IndexType, propertyName: string): ``vectorizecreate-metadata-index-request`` =
        { indexType = indexType
          propertyName = propertyName }

type ``vectorizecreate-metadata-index-response`` =
    { ///The unique identifier for the async mutation operation containing the changeset.
      mutationId: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of vectorizecreate-metadata-index-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizecreate-metadata-index-response`` = { mutationId = None }

type ``vectorizedelete-metadata-index-request`` =
    { ///Specifies the metadata property for which the index must be deleted.
      propertyName: string }
    ///Creates an instance of vectorizedelete-metadata-index-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (propertyName: string): ``vectorizedelete-metadata-index-request`` =
        { propertyName = propertyName }

type ``vectorizedelete-metadata-index-response`` =
    { ///The unique identifier for the async mutation operation containing the changeset.
      mutationId: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of vectorizedelete-metadata-index-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizedelete-metadata-index-response`` = { mutationId = None }

type ``vectorizeindex-delete-vectors-by-id-request`` =
    { ///A list of vector identifiers to delete from the index indicated by the path.
      ids: Option<list<``vectorizevector-identifier``>> }
    ///Creates an instance of vectorizeindex-delete-vectors-by-id-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-delete-vectors-by-id-request`` = { ids = None }

type ``vectorizeindex-delete-vectors-by-id-response`` =
    { ///The count of the vectors successfully deleted.
      count: Option<int>
      ///Array of vector identifiers of the vectors that were successfully processed for deletion.
      ids: Option<list<``vectorizevector-identifier``>> }
    ///Creates an instance of vectorizeindex-delete-vectors-by-id-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-delete-vectors-by-id-response`` = { count = None; ids = None }

type ``vectorizeindex-delete-vectors-by-id-v2-response`` =
    { ///The unique identifier for the async mutation operation containing the changeset.
      mutationId: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of vectorizeindex-delete-vectors-by-id-v2-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-delete-vectors-by-id-v2-response`` = { mutationId = None }

type ``vectorizeindex-dimension-configuration`` =
    { ///Specifies the number of dimensions for the index
      dimensions: ``vectorizeindex-dimensions``
      ///Specifies the type of metric to use calculating distance.
      metric: ``vectorizeindex-metric`` }
    ///Creates an instance of vectorizeindex-dimension-configuration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (dimensions: ``vectorizeindex-dimensions``, metric: ``vectorizeindex-metric``): ``vectorizeindex-dimension-configuration`` =
        { dimensions = dimensions
          metric = metric }

type ``vectorizeindex-get-vectors-by-id-request`` =
    { ///A list of vector identifiers to retrieve from the index indicated by the path.
      ids: Option<list<``vectorizevector-identifier``>> }
    ///Creates an instance of vectorizeindex-get-vectors-by-id-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-get-vectors-by-id-request`` = { ids = None }

type ``vectorizeindex-info-response`` =
    { ///Specifies the number of dimensions for the index
      dimensions: Option<``vectorizeindex-dimensions``>
      ///Specifies the timestamp the last mutation batch was processed as an ISO8601 string.
      processedUpToDatetime: Option<System.DateTimeOffset>
      ///The unique identifier for the async mutation operation containing the changeset.
      processedUpToMutation: Option<Newtonsoft.Json.Linq.JToken>
      ///Specifies the number of vectors present in the index
      vectorCount: Option<int> }
    ///Creates an instance of vectorizeindex-info-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-info-response`` =
        { dimensions = None
          processedUpToDatetime = None
          processedUpToMutation = None
          vectorCount = None }

type ``vectorizeindex-insert-response`` =
    { ///Specifies the count of the vectors successfully inserted.
      count: Option<int>
      ///Array of vector identifiers of the vectors successfully inserted.
      ids: Option<list<``vectorizevector-identifier``>> }
    ///Creates an instance of vectorizeindex-insert-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-insert-response`` = { count = None; ids = None }

type ``vectorizeindex-insert-v2-response`` =
    { ///The unique identifier for the async mutation operation containing the changeset.
      mutationId: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of vectorizeindex-insert-v2-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-insert-v2-response`` = { mutationId = None }

type ``vectorizeindex-list-vectors-response`` =
    { ///Number of vectors returned in this response
      count: int
      ///When the cursor expires as an ISO8601 string
      cursorExpirationTimestamp: Option<System.DateTimeOffset>
      ///Whether there are more vectors available beyond this response
      isTruncated: bool
      ///Cursor for the next page of results
      nextCursor: Option<string>
      ///Total number of vectors in the index
      totalCount: int
      ///Array of vector items
      vectors: list<``vectorizevector-list-item``> }
    ///Creates an instance of vectorizeindex-list-vectors-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: int, isTruncated: bool, totalCount: int, vectors: list<``vectorizevector-list-item``>): ``vectorizeindex-list-vectors-response`` =
        { count = count
          cursorExpirationTimestamp = None
          isTruncated = isTruncated
          nextCursor = None
          totalCount = totalCount
          vectors = vectors }

type ``vectorizeindex-preset-configuration`` =
    { ///Specifies the preset to use for the index.
      preset: ``vectorizeindex-preset`` }
    ///Creates an instance of vectorizeindex-preset-configuration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (preset: ``vectorizeindex-preset``): ``vectorizeindex-preset-configuration`` =
        { preset = preset }

type ``vectorizeindex-query-request`` =
    { ///A metadata filter expression used to limit nearest neighbor results.
      filter: Option<Newtonsoft.Json.Linq.JObject>
      ///Whether to return the metadata associated with the closest vectors.
      returnMetadata: Option<bool>
      ///Whether to return the values associated with the closest vectors.
      returnValues: Option<bool>
      ///The number of nearest neighbors to find.
      topK: Option<float>
      ///The search vector that will be used to find the nearest neighbors.
      vector: list<float> }
    ///Creates an instance of vectorizeindex-query-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (vector: list<float>): ``vectorizeindex-query-request`` =
        { filter = None
          returnMetadata = None
          returnValues = None
          topK = None
          vector = vector }

type Matches =
    { ///Identifier for a Vector
      id: Option<``vectorizevector-identifier``>
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      ///The score of the vector according to the index's distance metric
      score: Option<float>
      values: Option<list<float>> }
    ///Creates an instance of Matches with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Matches =
        { id = None
          metadata = None
          score = None
          values = None }

type ``vectorizeindex-query-response`` =
    { ///Specifies the count of vectors returned by the search
      count: Option<int>
      ///Array of vectors matched by the search
      matches: Option<list<Matches>> }
    ///Creates an instance of vectorizeindex-query-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-query-response`` = { count = None; matches = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReturnMetadata =
    | [<CompiledName "none">] None
    | [<CompiledName "indexed">] Indexed
    | [<CompiledName "all">] All
    member this.Format() =
        match this with
        | None -> "none"
        | Indexed -> "indexed"
        | All -> "all"

type ``vectorizeindex-query-v2-request`` =
    { ///A metadata filter expression used to limit nearest neighbor results.
      filter: Option<Newtonsoft.Json.Linq.JObject>
      ///Whether to return no metadata, indexed metadata or all metadata associated with the closest vectors.
      returnMetadata: Option<ReturnMetadata>
      ///Whether to return the values associated with the closest vectors.
      returnValues: Option<bool>
      ///The number of nearest neighbors to find.
      topK: Option<float>
      ///The search vector that will be used to find the nearest neighbors.
      vector: list<float> }
    ///Creates an instance of vectorizeindex-query-v2-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (vector: list<float>): ``vectorizeindex-query-v2-request`` =
        { filter = None
          returnMetadata = None
          returnValues = None
          topK = None
          vector = vector }

type ``vectorizeindex-query-v2-responseMatches`` =
    { ///Identifier for a Vector
      id: Option<``vectorizevector-identifier``>
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      ``namespace``: Option<string>
      ///The score of the vector according to the index's distance metric
      score: Option<float>
      values: Option<list<float>> }
    ///Creates an instance of vectorizeindex-query-v2-responseMatches with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-query-v2-responseMatches`` =
        { id = None
          metadata = None
          ``namespace`` = None
          score = None
          values = None }

type ``vectorizeindex-query-v2-response`` =
    { ///Specifies the count of vectors returned by the search
      count: Option<int>
      ///Array of vectors matched by the search
      matches: Option<list<``vectorizeindex-query-v2-responseMatches``>> }
    ///Creates an instance of vectorizeindex-query-v2-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-query-v2-response`` = { count = None; matches = None }

type ``vectorizeindex-upsert-response`` =
    { ///Specifies the count of the vectors successfully inserted.
      count: Option<int>
      ///Array of vector identifiers of the vectors successfully inserted.
      ids: Option<list<``vectorizevector-identifier``>> }
    ///Creates an instance of vectorizeindex-upsert-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-upsert-response`` = { count = None; ids = None }

type ``vectorizeindex-upsert-v2-response`` =
    { ///The unique identifier for the async mutation operation containing the changeset.
      mutationId: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of vectorizeindex-upsert-v2-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizeindex-upsert-v2-response`` = { mutationId = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MetadataIndexesIndexType =
    | [<CompiledName "string">] String
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | String -> "string"
        | Number -> "number"
        | Boolean -> "boolean"

type MetadataIndexes =
    { ///Specifies the type of indexed metadata property.
      indexType: Option<MetadataIndexesIndexType>
      ///Specifies the indexed metadata property.
      propertyName: Option<string> }
    ///Creates an instance of MetadataIndexes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): MetadataIndexes =
        { indexType = None
          propertyName = None }

type ``vectorizelist-metadata-index-response`` =
    { ///Array of indexed metadata properties.
      metadataIndexes: Option<list<MetadataIndexes>> }
    ///Creates an instance of vectorizelist-metadata-index-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorizelist-metadata-index-response`` = { metadataIndexes = None }

type vectorizeresultinfo =
    { ///Total number of results for the requested service
      count: Option<float>
      ///Current page within paginated list of results
      page: Option<float>
      ///Number of results per page of results
      per_page: Option<float>
      ///Total results available without any search parameters
      total_count: Option<float> }
    ///Creates an instance of vectorizeresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): vectorizeresultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``vectorizeupdate-index-request`` =
    { ///Specifies the description of the index.
      description: ``vectorizeindex-description`` }
    ///Creates an instance of vectorizeupdate-index-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (description: ``vectorizeindex-description``): ``vectorizeupdate-index-request`` =
        { description = description }

type ``vectorizevector-list-item`` =
    { ///Identifier for a Vector
      id: ``vectorizevector-identifier`` }
    ///Creates an instance of vectorizevector-list-item with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``vectorizevector-identifier``): ``vectorizevector-list-item`` = { id = id }

type ``vectorize-list-vectorize-indexesresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-list-vectorize-indexesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-list-vectorize-indexesresponseErrors`` =
        { code = code; message = message }

type ``vectorize-list-vectorize-indexesresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-list-vectorize-indexesresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-list-vectorize-indexesresponseMessages`` =
        { code = code; message = message }

type ``vectorize-list-vectorize-indexesresponse`` =
    { errors: list<``vectorize-list-vectorize-indexesresponseErrors``>
      messages: list<``vectorize-list-vectorize-indexesresponseMessages``>
      result: list<``vectorizecreate-index-response``>
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-list-vectorize-indexesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-list-vectorize-indexesresponseErrors``>,
                          messages: list<``vectorize-list-vectorize-indexesresponseMessages``>,
                          result: list<``vectorizecreate-index-response``>,
                          success: bool): ``vectorize-list-vectorize-indexesresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-create-vectorize-indexresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-create-vectorize-indexresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-create-vectorize-indexresponseErrors`` =
        { code = code; message = message }

type ``vectorize-create-vectorize-indexresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-create-vectorize-indexresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-create-vectorize-indexresponseMessages`` =
        { code = code; message = message }

type ``vectorize-create-vectorize-indexresponse`` =
    { errors: list<``vectorize-create-vectorize-indexresponseErrors``>
      messages: list<``vectorize-create-vectorize-indexresponseMessages``>
      result: ``vectorizecreate-index-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-create-vectorize-indexresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-create-vectorize-indexresponseErrors``>,
                          messages: list<``vectorize-create-vectorize-indexresponseMessages``>,
                          result: ``vectorizecreate-index-response``,
                          success: bool): ``vectorize-create-vectorize-indexresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-delete-vectorize-indexresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-delete-vectorize-indexresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-delete-vectorize-indexresponseErrors`` =
        { code = code; message = message }

type ``vectorize-delete-vectorize-indexresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-delete-vectorize-indexresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-delete-vectorize-indexresponseMessages`` =
        { code = code; message = message }

type ``vectorize-delete-vectorize-indexresponse`` =
    { errors: list<``vectorize-delete-vectorize-indexresponseErrors``>
      messages: list<``vectorize-delete-vectorize-indexresponseMessages``>
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-delete-vectorize-indexresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-delete-vectorize-indexresponseErrors``>,
                          messages: list<``vectorize-delete-vectorize-indexresponseMessages``>,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``vectorize-delete-vectorize-indexresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-get-vectorize-indexresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-get-vectorize-indexresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-get-vectorize-indexresponseErrors`` =
        { code = code; message = message }

type ``vectorize-get-vectorize-indexresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-get-vectorize-indexresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-get-vectorize-indexresponseMessages`` =
        { code = code; message = message }

type ``vectorize-get-vectorize-indexresponse`` =
    { errors: list<``vectorize-get-vectorize-indexresponseErrors``>
      messages: list<``vectorize-get-vectorize-indexresponseMessages``>
      result: ``vectorizecreate-index-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-get-vectorize-indexresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-get-vectorize-indexresponseErrors``>,
                          messages: list<``vectorize-get-vectorize-indexresponseMessages``>,
                          result: ``vectorizecreate-index-response``,
                          success: bool): ``vectorize-get-vectorize-indexresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-delete-vectors-by-idresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-delete-vectors-by-idresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-delete-vectors-by-idresponseErrors`` =
        { code = code; message = message }

type ``vectorize-delete-vectors-by-idresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-delete-vectors-by-idresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-delete-vectors-by-idresponseMessages`` =
        { code = code; message = message }

type ``vectorize-delete-vectors-by-idresponse`` =
    { errors: list<``vectorize-delete-vectors-by-idresponseErrors``>
      messages: list<``vectorize-delete-vectors-by-idresponseMessages``>
      result: ``vectorizeindex-delete-vectors-by-id-v2-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-delete-vectors-by-idresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-delete-vectors-by-idresponseErrors``>,
                          messages: list<``vectorize-delete-vectors-by-idresponseMessages``>,
                          result: ``vectorizeindex-delete-vectors-by-id-v2-response``,
                          success: bool): ``vectorize-delete-vectors-by-idresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-get-vectors-by-idresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-get-vectors-by-idresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-get-vectors-by-idresponseErrors`` =
        { code = code; message = message }

type ``vectorize-get-vectors-by-idresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-get-vectors-by-idresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-get-vectors-by-idresponseMessages`` =
        { code = code; message = message }

type ``vectorize-get-vectors-by-idresponseResult`` =
    { ///Identifier for a Vector
      id: Option<``vectorizevector-identifier``>
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      ``namespace``: Option<string>
      values: Option<list<float>> }
    ///Creates an instance of vectorize-get-vectors-by-idresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vectorize-get-vectors-by-idresponseResult`` =
        { id = None
          metadata = None
          ``namespace`` = None
          values = None }

type ``vectorize-get-vectors-by-idresponse`` =
    { errors: list<``vectorize-get-vectors-by-idresponseErrors``>
      messages: list<``vectorize-get-vectors-by-idresponseMessages``>
      ///Array of vectors with matching ids.
      result: list<``vectorize-get-vectors-by-idresponseResult``>
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-get-vectors-by-idresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-get-vectors-by-idresponseErrors``>,
                          messages: list<``vectorize-get-vectors-by-idresponseMessages``>,
                          result: list<``vectorize-get-vectors-by-idresponseResult``>,
                          success: bool): ``vectorize-get-vectors-by-idresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-index-inforesponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-index-inforesponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-index-inforesponseErrors`` =
        { code = code; message = message }

type ``vectorize-index-inforesponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-index-inforesponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-index-inforesponseMessages`` =
        { code = code; message = message }

type ``vectorize-index-inforesponse`` =
    { errors: list<``vectorize-index-inforesponseErrors``>
      messages: list<``vectorize-index-inforesponseMessages``>
      result: ``vectorizeindex-info-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-index-inforesponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-index-inforesponseErrors``>,
                          messages: list<``vectorize-index-inforesponseMessages``>,
                          result: ``vectorizeindex-info-response``,
                          success: bool): ``vectorize-index-inforesponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-insert-vectorresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-insert-vectorresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-insert-vectorresponseErrors`` =
        { code = code; message = message }

type ``vectorize-insert-vectorresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-insert-vectorresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-insert-vectorresponseMessages`` =
        { code = code; message = message }

type ``vectorize-insert-vectorresponse`` =
    { errors: list<``vectorize-insert-vectorresponseErrors``>
      messages: list<``vectorize-insert-vectorresponseMessages``>
      result: ``vectorizeindex-insert-v2-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-insert-vectorresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-insert-vectorresponseErrors``>,
                          messages: list<``vectorize-insert-vectorresponseMessages``>,
                          result: ``vectorizeindex-insert-v2-response``,
                          success: bool): ``vectorize-insert-vectorresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-list-vectorsresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-list-vectorsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-list-vectorsresponseErrors`` =
        { code = code; message = message }

type ``vectorize-list-vectorsresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-list-vectorsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-list-vectorsresponseMessages`` =
        { code = code; message = message }

type ``vectorize-list-vectorsresponse`` =
    { errors: list<``vectorize-list-vectorsresponseErrors``>
      messages: list<``vectorize-list-vectorsresponseMessages``>
      result: ``vectorizeindex-list-vectors-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-list-vectorsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-list-vectorsresponseErrors``>,
                          messages: list<``vectorize-list-vectorsresponseMessages``>,
                          result: ``vectorizeindex-list-vectors-response``,
                          success: bool): ``vectorize-list-vectorsresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-create-metadata-indexresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-create-metadata-indexresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-create-metadata-indexresponseErrors`` =
        { code = code; message = message }

type ``vectorize-create-metadata-indexresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-create-metadata-indexresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-create-metadata-indexresponseMessages`` =
        { code = code; message = message }

type ``vectorize-create-metadata-indexresponse`` =
    { errors: list<``vectorize-create-metadata-indexresponseErrors``>
      messages: list<``vectorize-create-metadata-indexresponseMessages``>
      result: ``vectorizecreate-metadata-index-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-create-metadata-indexresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-create-metadata-indexresponseErrors``>,
                          messages: list<``vectorize-create-metadata-indexresponseMessages``>,
                          result: ``vectorizecreate-metadata-index-response``,
                          success: bool): ``vectorize-create-metadata-indexresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-delete-metadata-indexresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-delete-metadata-indexresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-delete-metadata-indexresponseErrors`` =
        { code = code; message = message }

type ``vectorize-delete-metadata-indexresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-delete-metadata-indexresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-delete-metadata-indexresponseMessages`` =
        { code = code; message = message }

type ``vectorize-delete-metadata-indexresponse`` =
    { errors: list<``vectorize-delete-metadata-indexresponseErrors``>
      messages: list<``vectorize-delete-metadata-indexresponseMessages``>
      result: ``vectorizedelete-metadata-index-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-delete-metadata-indexresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-delete-metadata-indexresponseErrors``>,
                          messages: list<``vectorize-delete-metadata-indexresponseMessages``>,
                          result: ``vectorizedelete-metadata-index-response``,
                          success: bool): ``vectorize-delete-metadata-indexresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-list-metadata-indexesresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-list-metadata-indexesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-list-metadata-indexesresponseErrors`` =
        { code = code; message = message }

type ``vectorize-list-metadata-indexesresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-list-metadata-indexesresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-list-metadata-indexesresponseMessages`` =
        { code = code; message = message }

type ``vectorize-list-metadata-indexesresponse`` =
    { errors: list<``vectorize-list-metadata-indexesresponseErrors``>
      messages: list<``vectorize-list-metadata-indexesresponseMessages``>
      result: ``vectorizelist-metadata-index-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-list-metadata-indexesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-list-metadata-indexesresponseErrors``>,
                          messages: list<``vectorize-list-metadata-indexesresponseMessages``>,
                          result: ``vectorizelist-metadata-index-response``,
                          success: bool): ``vectorize-list-metadata-indexesresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-query-vectorresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-query-vectorresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-query-vectorresponseErrors`` =
        { code = code; message = message }

type ``vectorize-query-vectorresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-query-vectorresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-query-vectorresponseMessages`` =
        { code = code; message = message }

type ``vectorize-query-vectorresponse`` =
    { errors: list<``vectorize-query-vectorresponseErrors``>
      messages: list<``vectorize-query-vectorresponseMessages``>
      result: ``vectorizeindex-query-v2-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-query-vectorresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-query-vectorresponseErrors``>,
                          messages: list<``vectorize-query-vectorresponseMessages``>,
                          result: ``vectorizeindex-query-v2-response``,
                          success: bool): ``vectorize-query-vectorresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``vectorize-upsert-vectorresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-upsert-vectorresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-upsert-vectorresponseErrors`` =
        { code = code; message = message }

type ``vectorize-upsert-vectorresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of vectorize-upsert-vectorresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vectorize-upsert-vectorresponseMessages`` =
        { code = code; message = message }

type ``vectorize-upsert-vectorresponse`` =
    { errors: list<``vectorize-upsert-vectorresponseErrors``>
      messages: list<``vectorize-upsert-vectorresponseMessages``>
      result: ``vectorizeindex-upsert-v2-response``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of vectorize-upsert-vectorresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vectorize-upsert-vectorresponseErrors``>,
                          messages: list<``vectorize-upsert-vectorresponseMessages``>,
                          result: ``vectorizeindex-upsert-v2-response``,
                          success: bool): ``vectorize-upsert-vectorresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

[<RequireQualifiedAccess>]
type VectorizeListVectorizeIndexes =
    ///List Vectorize Index Response
    | OK of payload: ``vectorize-list-vectorize-indexesresponse``
    ///List Vectorize Index Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeCreateVectorizeIndex =
    ///Create Vectorize Index Response
    | OK of payload: ``vectorize-create-vectorize-indexresponse``
    ///Create Vectorize Index Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeDeleteVectorizeIndex =
    ///Delete Vectorize Index Response
    | OK of payload: ``vectorize-delete-vectorize-indexresponse``
    ///Delete Vectorize Index Failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeGetVectorizeIndex =
    ///Get Vectorize Index Response
    | OK of payload: ``vectorize-get-vectorize-indexresponse``
    ///Get Vectorize Index Failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeDeleteVectorsById =
    ///Delete Vector Identifiers Response
    | OK of payload: ``vectorize-delete-vectors-by-idresponse``
    ///Delete Vector Identifiers Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeGetVectorsById =
    ///Get Vectors By Identifier Response
    | OK of payload: ``vectorize-get-vectors-by-idresponse``
    ///Get Vectors By Identifier Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeIndexInfo =
    ///Get Vectorize Index Info Response
    | OK of payload: ``vectorize-index-inforesponse``
    ///Get Vectorize Index Info Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeInsertVector =
    ///Insert Vectors Response
    | OK of payload: ``vectorize-insert-vectorresponse``
    ///Insert Vectors Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeListVectors =
    ///List Vectors Response
    | OK of payload: ``vectorize-list-vectorsresponse``
    ///List Vectors Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeCreateMetadataIndex =
    ///Create Metadata Index Response
    | OK of payload: ``vectorize-create-metadata-indexresponse``
    ///Create Metadata Index Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeDeleteMetadataIndex =
    ///Delete Metadata Index Response
    | OK of payload: ``vectorize-delete-metadata-indexresponse``
    ///Delete Metadata Index Failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeListMetadataIndexes =
    ///List Metadata Index Response
    | OK of payload: ``vectorize-list-metadata-indexesresponse``
    ///List Metadata Index Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeQueryVector =
    ///Query Vectors Response
    | OK of payload: ``vectorize-query-vectorresponse``
    ///Query Vectors Failure Response
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type VectorizeUpsertVector =
    ///Upsert Vectors Response
    | OK of payload: ``vectorize-upsert-vectorresponse``
    ///Upsert Vectors Failure Response
    | BadRequest of payload: string
