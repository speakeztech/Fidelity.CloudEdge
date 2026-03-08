namespace rec Fidelity.CloudEdge.Management.AISearch.Types

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Cachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Datatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type Custommetadata =
    { data_type: Datatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Fusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type Metadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type Chatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type Mcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Technique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type Ratelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<Technique> }

type Searchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type Publicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<Chatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<Mcp>
      rate_limit: Option<Ratelimit>
      search_endpoint: Option<Searchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Direction =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type Boostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<Direction>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Keywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type Retrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<Boostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<Keywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Source =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type Crawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<Source> }

type Contentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type Parseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<Contentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Parsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Storagetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type Storeoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<Storagetype> }

type Webcrawler =
    { crawl_options: Option<Crawloptions>
      parse_options: Option<Parseoptions>
      parse_type: Option<Parsetype>
      store_options: Option<Storeoptions> }

type Sourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<Webcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type Result =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<Cachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<Custommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<Fusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<Metadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<Publicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<Retrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<Sourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<Type>
      vectorize_name: string }

type AiSearchListInstances_OK = { result: list<Result>; success: bool }

type Errors =
    { code: float
      message: string
      path: list<string> }

type AiSearchListInstances_BadRequest = { errors: list<Errors>; success: bool }

[<RequireQualifiedAccess>]
type AiSearchListInstances =
    ///List objects
    | OK of payload: AiSearchListInstances_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchListInstances_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchCreateInstancesPayloadCustommetadata =
    { data_type: AiSearchCreateInstancesPayloadCustommetadataDatatype
      field_name: string }
    ///Creates an instance of AiSearchCreateInstancesPayloadCustommetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data_type: AiSearchCreateInstancesPayloadCustommetadataDatatype, field_name: string): AiSearchCreateInstancesPayloadCustommetadata =
        { data_type = data_type
          field_name = field_name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchCreateInstancesPayloadMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }
    ///Creates an instance of AiSearchCreateInstancesPayloadMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadMetadata =
        { created_from_aisearch_wizard = None
          worker_domain = None }

type AiSearchCreateInstancesPayloadPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparamsChatcompletionsendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparamsChatcompletionsendpoint =
        { disabled = None }

type AiSearchCreateInstancesPayloadPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparamsMcp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparamsMcp =
        { description = None; disabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchCreateInstancesPayloadPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchCreateInstancesPayloadPublicendpointparamsRatelimitTechnique> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparamsRatelimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparamsRatelimit =
        { period_ms = None
          requests = None
          technique = None }

type AiSearchCreateInstancesPayloadPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparamsSearchendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparamsSearchendpoint = { disabled = None }

type AiSearchCreateInstancesPayloadPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchCreateInstancesPayloadPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchCreateInstancesPayloadPublicendpointparamsMcp>
      rate_limit: Option<AiSearchCreateInstancesPayloadPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchCreateInstancesPayloadPublicendpointparamsSearchendpoint> }
    ///Creates an instance of AiSearchCreateInstancesPayloadPublicendpointparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadPublicendpointparams =
        { authorized_hosts = None
          chat_completions_endpoint = None
          enabled = None
          mcp = None
          rate_limit = None
          search_endpoint = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchCreateInstancesPayloadRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchCreateInstancesPayloadRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchCreateInstancesPayloadRetrievaloptionsBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchCreateInstancesPayloadRetrievaloptionsBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchCreateInstancesPayloadRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchCreateInstancesPayloadRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchCreateInstancesPayloadRetrievaloptionsKeywordmatchmode> }
    ///Creates an instance of AiSearchCreateInstancesPayloadRetrievaloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadRetrievaloptions =
        { boost_by = None
          keyword_match_mode = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptionsSource> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptions =
        { depth = None
          include_external_links = None
          include_subdomains = None
          max_age = None
          source = None }

type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (path: string, selector: string): AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector =
        { path = path; selector = selector }

type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptions =
        { content_selector = None
          include_headers = None
          include_images = None
          specific_sitemaps = None
          use_browser_rendering = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptionsStoragetype> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (storage_id: string): AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptions =
        { r2_jurisdiction = None
          storage_id = storage_id
          storage_type = None }

type AiSearchCreateInstancesPayloadSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawlerStoreoptions> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparamsWebcrawler with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadSourceparamsWebcrawler =
        { crawl_options = None
          parse_options = None
          parse_type = None
          store_options = None }

type AiSearchCreateInstancesPayloadSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchCreateInstancesPayloadSourceparamsWebcrawler> }
    ///Creates an instance of AiSearchCreateInstancesPayloadSourceparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancesPayloadSourceparams =
        { exclude_items = None
          include_items = None
          prefix = None
          r2_jurisdiction = None
          web_crawler = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancesPayloadType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchCreateInstancesPayload =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchCreateInstancesPayloadCachethreshold>
      chunk: Option<bool>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      custom_metadata: Option<list<AiSearchCreateInstancesPayloadCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      fusion_method: Option<AiSearchCreateInstancesPayloadFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      max_num_results: Option<int>
      metadata: Option<AiSearchCreateInstancesPayloadMetadata>
      public_endpoint_params: Option<AiSearchCreateInstancesPayloadPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchCreateInstancesPayloadRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchCreateInstancesPayloadSourceparams>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchCreateInstancesPayloadType> }
    ///Creates an instance of AiSearchCreateInstancesPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): AiSearchCreateInstancesPayload =
        { ai_gateway_id = None
          ai_search_model = None
          cache = None
          cache_threshold = None
          chunk = None
          chunk_overlap = None
          chunk_size = None
          custom_metadata = None
          embedding_model = None
          fusion_method = None
          hybrid_search_enabled = None
          id = id
          max_num_results = None
          metadata = None
          public_endpoint_params = None
          reranking = None
          reranking_model = None
          retrieval_options = None
          rewrite_model = None
          rewrite_query = None
          score_threshold = None
          source = None
          source_params = None
          token_id = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchCreateInstances_CreatedResultCustommetadata =
    { data_type: AiSearchCreateInstances_CreatedResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchCreateInstances_CreatedResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchCreateInstances_CreatedResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchCreateInstances_CreatedResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchCreateInstances_CreatedResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsRatelimitTechnique> }

type AiSearchCreateInstances_CreatedResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchCreateInstances_CreatedResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchCreateInstances_CreatedResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchCreateInstances_CreatedResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchCreateInstances_CreatedResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchCreateInstances_CreatedResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchCreateInstances_CreatedResultRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchCreateInstances_CreatedResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchCreateInstances_CreatedResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchCreateInstances_CreatedResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchCreateInstances_CreatedResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstances_CreatedResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchCreateInstances_CreatedResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchCreateInstances_CreatedResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchCreateInstances_CreatedResultCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<AiSearchCreateInstances_CreatedResultFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchCreateInstances_CreatedResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchCreateInstances_CreatedResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchCreateInstances_CreatedResultRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchCreateInstances_CreatedResultSourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchCreateInstances_CreatedResultType>
      vectorize_name: string }

type AiSearchCreateInstances_Created =
    { result: AiSearchCreateInstances_CreatedResult
      success: bool }

type AiSearchCreateInstances_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchCreateInstances_BadRequest =
    { errors: list<AiSearchCreateInstances_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchCreateInstances =
    ///Returns the created Object
    | Created of payload: AiSearchCreateInstances_Created
    ///Input Validation Error
    | BadRequest of payload: AiSearchCreateInstances_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchDeleteInstances_OKResultCustommetadata =
    { data_type: AiSearchDeleteInstances_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchDeleteInstances_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchDeleteInstances_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchDeleteInstances_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchDeleteInstances_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchDeleteInstances_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchDeleteInstances_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchDeleteInstances_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchDeleteInstances_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchDeleteInstances_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchDeleteInstances_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchDeleteInstances_OKResultRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchDeleteInstances_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchDeleteInstances_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchDeleteInstances_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchDeleteInstances_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstances_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchDeleteInstances_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchDeleteInstances_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchDeleteInstances_OKResultCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<AiSearchDeleteInstances_OKResultFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchDeleteInstances_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchDeleteInstances_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchDeleteInstances_OKResultRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchDeleteInstances_OKResultSourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchDeleteInstances_OKResultType>
      vectorize_name: string }

type AiSearchDeleteInstances_OK =
    { result: AiSearchDeleteInstances_OKResult
      success: bool }

type AiSearchDeleteInstances_NotFoundErrors = { code: float; message: string }

type AiSearchDeleteInstances_NotFound =
    { errors: list<AiSearchDeleteInstances_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchDeleteInstances =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AiSearchDeleteInstances_OK
    ///Not Found
    | NotFound of payload: AiSearchDeleteInstances_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchFetchInstances_OKResultCustommetadata =
    { data_type: AiSearchFetchInstances_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchFetchInstances_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchFetchInstances_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchFetchInstances_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchFetchInstances_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchFetchInstances_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchFetchInstances_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchFetchInstances_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchFetchInstances_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchFetchInstances_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchFetchInstances_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchFetchInstances_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchFetchInstances_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchFetchInstances_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchFetchInstances_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchFetchInstances_OKResultRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchFetchInstances_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchFetchInstances_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchFetchInstances_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchFetchInstances_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchFetchInstances_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstances_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchFetchInstances_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchFetchInstances_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchFetchInstances_OKResultCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<AiSearchFetchInstances_OKResultFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchFetchInstances_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchFetchInstances_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchFetchInstances_OKResultRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchFetchInstances_OKResultSourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchFetchInstances_OKResultType>
      vectorize_name: string }

type AiSearchFetchInstances_OK =
    { result: AiSearchFetchInstances_OKResult
      success: bool }

type AiSearchFetchInstances_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchFetchInstances_BadRequest =
    { errors: list<AiSearchFetchInstances_BadRequestErrors>
      success: bool }

type AiSearchFetchInstances_NotFoundErrors = { code: float; message: string }

type AiSearchFetchInstances_NotFound =
    { errors: list<AiSearchFetchInstances_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchFetchInstances =
    ///Returns a single object if found
    | OK of payload: AiSearchFetchInstances_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchFetchInstances_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchFetchInstances_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchUpdateInstancesPayloadCustommetadata =
    { data_type: AiSearchUpdateInstancesPayloadCustommetadataDatatype
      field_name: string }
    ///Creates an instance of AiSearchUpdateInstancesPayloadCustommetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data_type: AiSearchUpdateInstancesPayloadCustommetadataDatatype, field_name: string): AiSearchUpdateInstancesPayloadCustommetadata =
        { data_type = data_type
          field_name = field_name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchUpdateInstancesPayloadMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadMetadata =
        { created_from_aisearch_wizard = None
          worker_domain = None }

type AiSearchUpdateInstancesPayloadPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparamsChatcompletionsendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparamsChatcompletionsendpoint =
        { disabled = None }

type AiSearchUpdateInstancesPayloadPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparamsMcp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparamsMcp =
        { description = None; disabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimitTechnique> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimit =
        { period_ms = None
          requests = None
          technique = None }

type AiSearchUpdateInstancesPayloadPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparamsSearchendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparamsSearchendpoint = { disabled = None }

type AiSearchUpdateInstancesPayloadPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsMcp>
      rate_limit: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchUpdateInstancesPayloadPublicendpointparamsSearchendpoint> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadPublicendpointparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadPublicendpointparams =
        { authorized_hosts = None
          chat_completions_endpoint = None
          enabled = None
          mcp = None
          rate_limit = None
          search_endpoint = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchUpdateInstancesPayloadRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchUpdateInstancesPayloadRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchUpdateInstancesPayloadRetrievaloptionsBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchUpdateInstancesPayloadRetrievaloptionsBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchUpdateInstancesPayloadRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchUpdateInstancesPayloadRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchUpdateInstancesPayloadRetrievaloptionsKeywordmatchmode> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadRetrievaloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadRetrievaloptions =
        { boost_by = None
          keyword_match_mode = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptionsSource> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptions =
        { depth = None
          include_external_links = None
          include_subdomains = None
          max_age = None
          source = None }

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (path: string, selector: string): AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector =
        { path = path; selector = selector }

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptions =
        { content_selector = None
          include_headers = None
          include_images = None
          specific_sitemaps = None
          use_browser_rendering = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptionsStoragetype> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (storage_id: string): AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptions =
        { r2_jurisdiction = None
          storage_id = storage_id
          storage_type = None }

type AiSearchUpdateInstancesPayloadSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawlerStoreoptions> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparamsWebcrawler with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadSourceparamsWebcrawler =
        { crawl_options = None
          parse_options = None
          parse_type = None
          store_options = None }

type AiSearchUpdateInstancesPayloadSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchUpdateInstancesPayloadSourceparamsWebcrawler> }
    ///Creates an instance of AiSearchUpdateInstancesPayloadSourceparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayloadSourceparams =
        { exclude_items = None
          include_items = None
          prefix = None
          r2_jurisdiction = None
          web_crawler = None }

type AiSearchUpdateInstancesPayload =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchUpdateInstancesPayloadCachethreshold>
      chunk: Option<bool>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      custom_metadata: Option<list<AiSearchUpdateInstancesPayloadCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      fusion_method: Option<AiSearchUpdateInstancesPayloadFusionmethod>
      hybrid_search_enabled: Option<bool>
      max_num_results: Option<int>
      metadata: Option<AiSearchUpdateInstancesPayloadMetadata>
      paused: Option<bool>
      public_endpoint_params: Option<AiSearchUpdateInstancesPayloadPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchUpdateInstancesPayloadRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source_params: Option<AiSearchUpdateInstancesPayloadSourceparams>
      summarization: Option<bool>
      summarization_model: Option<Newtonsoft.Json.Linq.JToken>
      system_prompt_ai_search: Option<string>
      system_prompt_index_summarization: Option<string>
      system_prompt_rewrite_query: Option<string>
      token_id: Option<System.Guid> }
    ///Creates an instance of AiSearchUpdateInstancesPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancesPayload =
        { ai_gateway_id = None
          ai_search_model = None
          cache = None
          cache_threshold = None
          chunk = None
          chunk_overlap = None
          chunk_size = None
          custom_metadata = None
          embedding_model = None
          fusion_method = None
          hybrid_search_enabled = None
          max_num_results = None
          metadata = None
          paused = None
          public_endpoint_params = None
          reranking = None
          reranking_model = None
          retrieval_options = None
          rewrite_model = None
          rewrite_query = None
          score_threshold = None
          source_params = None
          summarization = None
          summarization_model = None
          system_prompt_ai_search = None
          system_prompt_index_summarization = None
          system_prompt_rewrite_query = None
          token_id = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"

type AiSearchUpdateInstances_OKResultCustommetadata =
    { data_type: AiSearchUpdateInstances_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

type AiSearchUpdateInstances_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchUpdateInstances_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchUpdateInstances_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchUpdateInstances_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchUpdateInstances_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchUpdateInstances_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchUpdateInstances_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchUpdateInstances_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchUpdateInstances_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

type AiSearchUpdateInstances_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchUpdateInstances_OKResultRetrievaloptionsBoostby>>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchUpdateInstances_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchUpdateInstances_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchUpdateInstances_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchUpdateInstances_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstances_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchUpdateInstances_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Newtonsoft.Json.Linq.JToken>
      cache: Option<bool>
      cache_threshold: Option<AiSearchUpdateInstances_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchUpdateInstances_OKResultCustommetadata>>
      embedding_model: Option<Newtonsoft.Json.Linq.JToken>
      enable: Option<bool>
      fusion_method: Option<AiSearchUpdateInstances_OKResultFusionmethod>
      hybrid_search_enabled: Option<bool>
      ///Use your AI Search ID.
      id: string
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchUpdateInstances_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchUpdateInstances_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Newtonsoft.Json.Linq.JToken>
      retrieval_options: Option<AiSearchUpdateInstances_OKResultRetrievaloptions>
      rewrite_model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchUpdateInstances_OKResultSourceparams>
      status: Option<string>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchUpdateInstances_OKResultType>
      vectorize_name: string }

type AiSearchUpdateInstances_OK =
    { result: AiSearchUpdateInstances_OKResult
      success: bool }

type AiSearchUpdateInstances_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchUpdateInstances_BadRequest =
    { errors: list<AiSearchUpdateInstances_BadRequestErrors>
      success: bool }

type AiSearchUpdateInstances_NotFoundErrors = { code: float; message: string }

type AiSearchUpdateInstances_NotFound =
    { errors: list<AiSearchUpdateInstances_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchUpdateInstances =
    ///Returns the updated Object
    | OK of payload: AiSearchUpdateInstances_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchUpdateInstances_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchUpdateInstances_NotFound

type Queryrewrite =
    { enabled: Option<bool>
      model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_prompt: Option<string> }
    ///Creates an instance of Queryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Queryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type Reranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of Reranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Reranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type RetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<RetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of RetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): RetrievalBoostby = { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RetrievalKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Retrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type Retrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<RetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<Newtonsoft.Json.Linq.JObject>
      fusion_method: Option<RetrievalFusionmethod>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<RetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<Retrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of Retrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Retrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type Aisearchoptions =
    { query_rewrite: Option<Queryrewrite>
      reranking: Option<Reranking>
      retrieval: Option<Retrieval> }
    ///Creates an instance of Aisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Aisearchoptions =
        { query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Role =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type Messages =
    { content: string
      role: Role }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: Role): Messages = { content = content; role = role }

type AiSearchInstanceChatCompletionPayload =
    { ai_search_options: Option<Aisearchoptions>
      messages: list<Messages>
      model: Option<Newtonsoft.Json.Linq.JToken>
      stream: Option<bool> }
    ///Creates an instance of AiSearchInstanceChatCompletionPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<Messages>): AiSearchInstanceChatCompletionPayload =
        { ai_search_options = None
          messages = messages
          model = None
          stream = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MessageRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type Message = { content: string; role: MessageRole }

type Choices =
    { index: Option<int>
      message: Message }

type Item =
    { key: string
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      timestamp: Option<float> }

type Scoringdetails =
    { keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type Chunks =
    { id: string
      item: Option<Item>
      score: float
      scoring_details: Option<Scoringdetails>
      text: string
      ``type``: string }

type AiSearchInstanceChatCompletion_OK =
    { choices: list<Choices>
      chunks: list<Chunks>
      id: Option<string>
      model: Option<string>
      object: Option<string> }

type AiSearchInstanceChatCompletion_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceChatCompletion_NotFound =
    { errors: list<AiSearchInstanceChatCompletion_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceChatCompletion =
    ///Returns the chat completions results with retrieved files.
    | OK of payload: AiSearchInstanceChatCompletion_OK
    ///Not Found
    | NotFound of payload: AiSearchInstanceChatCompletion_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceListJobs_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceListJobs_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceListJobs_OKResultSource
      started_at: Option<string> }

type Resultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AiSearchInstanceListJobs_OK =
    { result: list<AiSearchInstanceListJobs_OKResult>
      result_info: Resultinfo
      success: bool }

type AiSearchInstanceListJobs_BadRequestErrors = { message: string }

type AiSearchInstanceListJobs_BadRequest =
    { errors: list<AiSearchInstanceListJobs_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceListJobs_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceListJobs_InternalServerError =
    { errors: list<AiSearchInstanceListJobs_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceListJobs =
    ///Returns a list of AI Search Jobs.
    | OK of payload: AiSearchInstanceListJobs_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceListJobs_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceListJobs_InternalServerError

type AiSearchInstanceCreateJobPayload =
    { description: Option<string> }
    ///Creates an instance of AiSearchInstanceCreateJobPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceCreateJobPayload = { description = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceCreateJob_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceCreateJob_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceCreateJob_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceCreateJob_OK =
    { result: AiSearchInstanceCreateJob_OKResult
      success: bool }

type AiSearchInstanceCreateJob_BadRequestErrors = { message: string }

type AiSearchInstanceCreateJob_BadRequest =
    { errors: list<AiSearchInstanceCreateJob_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceCreateJob_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceCreateJob_InternalServerError =
    { errors: list<AiSearchInstanceCreateJob_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceCreateJob =
    ///Returns the AI Search job id.
    | OK of payload: AiSearchInstanceCreateJob_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceCreateJob_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceCreateJob_InternalServerError

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceGetJob_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceGetJob_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceGetJob_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceGetJob_OK =
    { result: AiSearchInstanceGetJob_OKResult
      success: bool }

type AiSearchInstanceGetJob_BadRequestErrors = { message: string }

type AiSearchInstanceGetJob_BadRequest =
    { errors: list<AiSearchInstanceGetJob_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceGetJob_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceGetJob_InternalServerError =
    { errors: list<AiSearchInstanceGetJob_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceGetJob =
    ///Returns a AI Search Job Details.
    | OK of payload: AiSearchInstanceGetJob_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceGetJob_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceGetJob_InternalServerError

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Action =
    | [<CompiledName "cancel">] Cancel
    member this.Format() =
        match this with
        | Cancel -> "cancel"

type AiSearchInstanceChangeJobStatusPayload =
    { action: Action }
    ///Creates an instance of AiSearchInstanceChangeJobStatusPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: Action): AiSearchInstanceChangeJobStatusPayload = { action = action }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceChangeJobStatus_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceChangeJobStatus_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceChangeJobStatus_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceChangeJobStatus_OK =
    { result: AiSearchInstanceChangeJobStatus_OKResult
      success: bool }

type AiSearchInstanceChangeJobStatus_BadRequestErrors = { message: string }

type AiSearchInstanceChangeJobStatus_BadRequest =
    { errors: list<AiSearchInstanceChangeJobStatus_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceChangeJobStatus_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceChangeJobStatus_InternalServerError =
    { errors: list<AiSearchInstanceChangeJobStatus_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceChangeJobStatus =
    ///Returns the updated AI Search Job.
    | OK of payload: AiSearchInstanceChangeJobStatus_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceChangeJobStatus_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceChangeJobStatus_InternalServerError

type AiSearchInstanceListJobLogs_OKResult =
    { created_at: float
      id: int
      message: string
      message_type: int }

type AiSearchInstanceListJobLogs_OKResultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AiSearchInstanceListJobLogs_OK =
    { result: list<AiSearchInstanceListJobLogs_OKResult>
      result_info: AiSearchInstanceListJobLogs_OKResultinfo
      success: bool }

type AiSearchInstanceListJobLogs_BadRequestErrors = { message: string }

type AiSearchInstanceListJobLogs_BadRequest =
    { errors: list<AiSearchInstanceListJobLogs_BadRequestErrors>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }

type AiSearchInstanceListJobLogs_InternalServerErrorErrors = { code: float; message: string }

type AiSearchInstanceListJobLogs_InternalServerError =
    { errors: list<AiSearchInstanceListJobLogs_InternalServerErrorErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceListJobLogs =
    ///Returns a list of AI Search Job Logs.
    | OK of payload: AiSearchInstanceListJobLogs_OK
    ///Bad Request.
    | BadRequest of payload: AiSearchInstanceListJobLogs_BadRequest
    ///Internal Error.
    | InternalServerError of payload: AiSearchInstanceListJobLogs_InternalServerError

type AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite =
    { enabled: Option<bool>
      model: Option<Newtonsoft.Json.Linq.JToken>
      rewrite_prompt: Option<string> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type AiSearchInstanceSearchPayloadAisearchoptionsReranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsReranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsReranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode =
    | [<CompiledName "exact_match">] Exact_match
    | [<CompiledName "fuzzy_match">] Fuzzy_match
    member this.Format() =
        match this with
        | Exact_match -> "exact_match"
        | Fuzzy_match -> "fuzzy_match"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type AiSearchInstanceSearchPayloadAisearchoptionsRetrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<Newtonsoft.Json.Linq.JObject>
      fusion_method: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod>
      ///Controls how keyword search terms are matched. exact_match requires all terms to appear (AND); fuzzy_match returns results containing any term (OR). Defaults to exact_match.
      keyword_match_mode: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsRetrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsRetrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type AiSearchInstanceSearchPayloadAisearchoptions =
    { query_rewrite: Option<AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite>
      reranking: Option<AiSearchInstanceSearchPayloadAisearchoptionsReranking>
      retrieval: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrieval> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptions =
        { query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadMessagesRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type AiSearchInstanceSearchPayloadMessages =
    { content: string
      role: AiSearchInstanceSearchPayloadMessagesRole }
    ///Creates an instance of AiSearchInstanceSearchPayloadMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: AiSearchInstanceSearchPayloadMessagesRole): AiSearchInstanceSearchPayloadMessages =
        { content = content; role = role }

type AiSearchInstanceSearchPayload =
    { ai_search_options: Option<AiSearchInstanceSearchPayloadAisearchoptions>
      messages: list<AiSearchInstanceSearchPayloadMessages> }
    ///Creates an instance of AiSearchInstanceSearchPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<AiSearchInstanceSearchPayloadMessages>): AiSearchInstanceSearchPayload =
        { ai_search_options = None
          messages = messages }

type AiSearchInstanceSearch_OKResultChunksItem =
    { key: string
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      timestamp: Option<float> }

type AiSearchInstanceSearch_OKResultChunksScoringdetails =
    { keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type AiSearchInstanceSearch_OKResultChunks =
    { id: string
      item: Option<AiSearchInstanceSearch_OKResultChunksItem>
      score: float
      scoring_details: Option<AiSearchInstanceSearch_OKResultChunksScoringdetails>
      text: string
      ``type``: string }

type AiSearchInstanceSearch_OKResult =
    { chunks: list<AiSearchInstanceSearch_OKResultChunks>
      search_query: string }

type AiSearchInstanceSearch_OK =
    { result: AiSearchInstanceSearch_OKResult
      success: bool }

type AiSearchInstanceSearch_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceSearch_NotFound =
    { errors: list<AiSearchInstanceSearch_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceSearch =
    ///Returns the search results.
    | OK of payload: AiSearchInstanceSearch_OK
    ///Not Found
    | NotFound of payload: AiSearchInstanceSearch_NotFound

type AiSearchStats_OKResult =
    { completed: Option<int>
      error: Option<int>
      file_embed_errors: Option<Newtonsoft.Json.Linq.JObject>
      index_source_errors: Option<Newtonsoft.Json.Linq.JObject>
      last_activity: Option<System.DateTimeOffset>
      queued: Option<int>
      running: Option<int>
      skipped: Option<int> }

type AiSearchStats_OK =
    { result: AiSearchStats_OKResult
      success: bool }

type AiSearchStats_NotFoundErrors = { code: float; message: string }

type AiSearchStats_NotFound =
    { errors: list<AiSearchStats_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchStats =
    ///Returns the AI Search stats.
    | OK of payload: AiSearchStats_OK
    ///Not Found
    | NotFound of payload: AiSearchStats_NotFound

type AiSearchListTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchListTokens_OK =
    { result: list<AiSearchListTokens_OKResult>
      success: bool }

type AiSearchListTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchListTokens_BadRequest =
    { errors: list<AiSearchListTokens_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchListTokens =
    ///List objects
    | OK of payload: AiSearchListTokens_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchListTokens_BadRequest

type AiSearchCreateTokensPayload =
    { cf_api_id: string
      cf_api_key: string
      legacy: Option<bool>
      name: string }
    ///Creates an instance of AiSearchCreateTokensPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cf_api_id: string, cf_api_key: string, name: string): AiSearchCreateTokensPayload =
        { cf_api_id = cf_api_id
          cf_api_key = cf_api_key
          legacy = None
          name = name }

type AiSearchCreateTokens_CreatedResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchCreateTokens_Created =
    { result: AiSearchCreateTokens_CreatedResult
      success: bool }

type AiSearchCreateTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchCreateTokens_BadRequest =
    { errors: list<AiSearchCreateTokens_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchCreateTokens =
    ///Returns the created Object
    | Created of payload: AiSearchCreateTokens_Created
    ///Input Validation Error
    | BadRequest of payload: AiSearchCreateTokens_BadRequest

type AiSearchDeleteTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchDeleteTokens_OK =
    { result: AiSearchDeleteTokens_OKResult
      success: bool }

type AiSearchDeleteTokens_NotFoundErrors = { code: float; message: string }

type AiSearchDeleteTokens_NotFound =
    { errors: list<AiSearchDeleteTokens_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchDeleteTokens =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AiSearchDeleteTokens_OK
    ///Not Found
    | NotFound of payload: AiSearchDeleteTokens_NotFound

type AiSearchFetchTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchFetchTokens_OK =
    { result: AiSearchFetchTokens_OKResult
      success: bool }

type AiSearchFetchTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchFetchTokens_BadRequest =
    { errors: list<AiSearchFetchTokens_BadRequestErrors>
      success: bool }

type AiSearchFetchTokens_NotFoundErrors = { code: float; message: string }

type AiSearchFetchTokens_NotFound =
    { errors: list<AiSearchFetchTokens_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchFetchTokens =
    ///Returns a single object if found
    | OK of payload: AiSearchFetchTokens_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchFetchTokens_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchFetchTokens_NotFound

type AiSearchUpdateTokensPayload =
    { cf_api_id: string
      cf_api_key: string
      legacy: Option<bool>
      name: string }
    ///Creates an instance of AiSearchUpdateTokensPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cf_api_id: string, cf_api_key: string, name: string): AiSearchUpdateTokensPayload =
        { cf_api_id = cf_api_id
          cf_api_key = cf_api_key
          legacy = None
          name = name }

type AiSearchUpdateTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchUpdateTokens_OK =
    { result: AiSearchUpdateTokens_OKResult
      success: bool }

type AiSearchUpdateTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchUpdateTokens_BadRequest =
    { errors: list<AiSearchUpdateTokens_BadRequestErrors>
      success: bool }

type AiSearchUpdateTokens_NotFoundErrors = { code: float; message: string }

type AiSearchUpdateTokens_NotFound =
    { errors: list<AiSearchUpdateTokens_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchUpdateTokens =
    ///Returns the updated Object
    | OK of payload: AiSearchUpdateTokens_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchUpdateTokens_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchUpdateTokens_NotFound
