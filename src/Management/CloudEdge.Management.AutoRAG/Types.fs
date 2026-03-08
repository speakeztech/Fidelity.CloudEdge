namespace rec Fidelity.CloudEdge.Management.AutoRAG.Types

type Rankingoptions =
    { ranker: Option<string>
      score_threshold: Option<float> }
    ///Creates an instance of Rankingoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Rankingoptions =
        { ranker = None
          score_threshold = None }

type Reranking =
    { enabled: Option<bool>
      model: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of Reranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Reranking = { enabled = None; model = None }

type AutoragConfigAiSearchPayload =
    { filters: Option<Newtonsoft.Json.Linq.JToken>
      max_num_results: Option<int>
      model: Option<Newtonsoft.Json.Linq.JToken>
      query: string
      ranking_options: Option<Rankingoptions>
      reranking: Option<Reranking>
      rewrite_query: Option<bool>
      stream: Option<bool>
      system_prompt: Option<string> }
    ///Creates an instance of AutoragConfigAiSearchPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (query: string): AutoragConfigAiSearchPayload =
        { filters = None
          max_num_results = None
          model = None
          query = query
          ranking_options = None
          reranking = None
          rewrite_query = None
          stream = None
          system_prompt = None }

type Content =
    { text: Option<string>
      ``type``: Option<string> }

type Data =
    { attributes: Option<Newtonsoft.Json.Linq.JObject>
      content: Option<list<Content>>
      file_id: Option<string>
      filename: Option<string>
      score: float }

type Result =
    { data: Option<list<Data>>
      has_more: Option<bool>
      next_page: Option<string>
      object: Option<string>
      response: string
      search_query: string }

type AutoragConfigAiSearch_OK = { result: Result; success: bool }
type Errors = { code: float; message: string }
type AutoragConfigAiSearch_NotFound = { errors: list<Errors>; success: bool }

[<RequireQualifiedAccess>]
type AutoragConfigAiSearch =
    ///Returns the log details
    | OK of payload: AutoragConfigAiSearch_OK
    ///Not Found
    | NotFound of payload: AutoragConfigAiSearch_NotFound

type AutoragConfigFiles_OKResult = { error: string; key: string }

type Resultinfo =
    { count: int
      page: int
      per_page: Option<int>
      total_count: int }

type AutoragConfigFiles_OK =
    { result: list<AutoragConfigFiles_OKResult>
      result_info: Resultinfo
      success: bool }

type AutoragConfigFiles_NotFoundErrors = { code: float; message: string }

type AutoragConfigFiles_NotFound =
    { errors: list<AutoragConfigFiles_NotFoundErrors>
      success: bool }

type AutoragConfigFiles_ServiceUnavailableErrors = { code: float; message: string }

type AutoragConfigFiles_ServiceUnavailable =
    { errors: list<AutoragConfigFiles_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AutoragConfigFiles =
    ///Returns the AI Search files
    | OK of payload: AutoragConfigFiles_OK
    ///autorag_not_found
    | NotFound of payload: AutoragConfigFiles_NotFound
    ///unable_to_connect_to_autorag
    | ServiceUnavailable of payload: AutoragConfigFiles_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Source =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AutoragConfigListJobs_OKResult =
    { end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: Source
      started_at: Option<string> }

type AutoragConfigListJobs_OKResultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AutoragConfigListJobs_OK =
    { result: list<AutoragConfigListJobs_OKResult>
      result_info: AutoragConfigListJobs_OKResultinfo
      success: bool }

type AutoragConfigListJobs_NotFoundErrors = { code: float; message: string }

type AutoragConfigListJobs_NotFound =
    { errors: list<AutoragConfigListJobs_NotFoundErrors>
      success: bool }

type AutoragConfigListJobs_ServiceUnavailableErrors = { code: float; message: string }

type AutoragConfigListJobs_ServiceUnavailable =
    { errors: list<AutoragConfigListJobs_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AutoragConfigListJobs =
    ///Returns a list of AutoRAG Jobs
    | OK of payload: AutoragConfigListJobs_OK
    ///autorag_not_found
    | NotFound of payload: AutoragConfigListJobs_NotFound
    ///unable_to_connect_to_autorag
    | ServiceUnavailable of payload: AutoragConfigListJobs_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AutoragConfigGetJob_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AutoragConfigGetJob_OKResult =
    { end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AutoragConfigGetJob_OKResultSource
      started_at: Option<string> }

type AutoragConfigGetJob_OK =
    { result: AutoragConfigGetJob_OKResult
      success: bool }

type AutoragConfigGetJob_NotFoundErrors = { code: float; message: string }

type AutoragConfigGetJob_NotFound =
    { errors: list<AutoragConfigGetJob_NotFoundErrors>
      success: bool }

type AutoragConfigGetJob_ServiceUnavailableErrors = { code: float; message: string }

type AutoragConfigGetJob_ServiceUnavailable =
    { errors: list<AutoragConfigGetJob_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AutoragConfigGetJob =
    ///Returns a AutoRAG Job Details
    | OK of payload: AutoragConfigGetJob_OK
    ///job_not_found
    | NotFound of payload: AutoragConfigGetJob_NotFound
    ///unable_to_connect_to_autorag
    | ServiceUnavailable of payload: AutoragConfigGetJob_ServiceUnavailable

type AutoragConfigListJobLogs_OKResult =
    { created_at: float
      id: int
      message: string
      message_type: int }

type AutoragConfigListJobLogs_OKResultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AutoragConfigListJobLogs_OK =
    { result: list<AutoragConfigListJobLogs_OKResult>
      result_info: AutoragConfigListJobLogs_OKResultinfo
      success: bool }

type AutoragConfigListJobLogs_NotFoundErrors = { code: float; message: string }

type AutoragConfigListJobLogs_NotFound =
    { errors: list<AutoragConfigListJobLogs_NotFoundErrors>
      success: bool }

type AutoragConfigListJobLogs_ServiceUnavailableErrors = { code: float; message: string }

type AutoragConfigListJobLogs_ServiceUnavailable =
    { errors: list<AutoragConfigListJobLogs_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AutoragConfigListJobLogs =
    ///Returns a list of AutoRAG Job Logs
    | OK of payload: AutoragConfigListJobLogs_OK
    ///autorag_not_found
    | NotFound of payload: AutoragConfigListJobLogs_NotFound
    ///unable_to_connect_to_autorag
    | ServiceUnavailable of payload: AutoragConfigListJobLogs_ServiceUnavailable

type AutoragConfigSearchPayloadRankingoptions =
    { ranker: Option<string>
      score_threshold: Option<float> }
    ///Creates an instance of AutoragConfigSearchPayloadRankingoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AutoragConfigSearchPayloadRankingoptions =
        { ranker = None
          score_threshold = None }

type AutoragConfigSearchPayloadReranking =
    { enabled: Option<bool>
      model: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of AutoragConfigSearchPayloadReranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AutoragConfigSearchPayloadReranking = { enabled = None; model = None }

type AutoragConfigSearchPayload =
    { filters: Option<Newtonsoft.Json.Linq.JToken>
      max_num_results: Option<int>
      query: string
      ranking_options: Option<AutoragConfigSearchPayloadRankingoptions>
      reranking: Option<AutoragConfigSearchPayloadReranking>
      rewrite_query: Option<bool> }
    ///Creates an instance of AutoragConfigSearchPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (query: string): AutoragConfigSearchPayload =
        { filters = None
          max_num_results = None
          query = query
          ranking_options = None
          reranking = None
          rewrite_query = None }

type AutoragConfigSearch_OKResultDataContent =
    { text: Option<string>
      ``type``: Option<string> }

type AutoragConfigSearch_OKResultData =
    { attributes: Option<Newtonsoft.Json.Linq.JObject>
      content: Option<list<AutoragConfigSearch_OKResultDataContent>>
      file_id: Option<string>
      filename: Option<string>
      score: float }

type AutoragConfigSearch_OKResult =
    { data: Option<list<AutoragConfigSearch_OKResultData>>
      has_more: Option<bool>
      next_page: Option<string>
      object: Option<string>
      search_query: string }

type AutoragConfigSearch_OK =
    { result: AutoragConfigSearch_OKResult
      success: bool }

type AutoragConfigSearch_NotFoundErrors = { code: float; message: string }

type AutoragConfigSearch_NotFound =
    { errors: list<AutoragConfigSearch_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AutoragConfigSearch =
    ///Returns the log details
    | OK of payload: AutoragConfigSearch_OK
    ///Not Found
    | NotFound of payload: AutoragConfigSearch_NotFound

type AutoragConfigSync_OKResult = { job_id: string }

type AutoragConfigSync_OK =
    { result: AutoragConfigSync_OKResult
      success: bool }

type AutoragConfigSync_BadRequestErrors = { code: float; message: string }

type AutoragConfigSync_BadRequest =
    { errors: list<AutoragConfigSync_BadRequestErrors>
      success: bool }

type AutoragConfigSync_NotFoundErrors = { code: float; message: string }

type AutoragConfigSync_NotFound =
    { errors: list<AutoragConfigSync_NotFoundErrors>
      success: bool }

type AutoragConfigSync_ServiceUnavailableErrors = { code: float; message: string }

type AutoragConfigSync_ServiceUnavailable =
    { errors: list<AutoragConfigSync_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AutoragConfigSync =
    ///Returns the autorag sync status
    | OK of payload: AutoragConfigSync_OK
    ///autorag_is_paused
    | BadRequest of payload: AutoragConfigSync_BadRequest
    ///autorag_not_found
    | NotFound of payload: AutoragConfigSync_NotFound
    ///unable_to_connect_to_autorag
    | ServiceUnavailable of payload: AutoragConfigSync_ServiceUnavailable
