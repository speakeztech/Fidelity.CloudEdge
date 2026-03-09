namespace rec Fidelity.CloudEdge.Management.Builds.Types

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type buildsBuildOutcome =
    | [<CompiledName "success">] Success
    | [<CompiledName "fail">] Fail
    | [<CompiledName "skipped">] Skipped
    | [<CompiledName "cancelled">] Cancelled
    | [<CompiledName "terminated">] Terminated
    member this.Format() =
        match this with
        | Success -> "success"
        | Fail -> "fail"
        | Skipped -> "skipped"
        | Cancelled -> "cancelled"
        | Terminated -> "terminated"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type buildsBuildStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "initializing">] Initializing
    | [<CompiledName "running">] Running
    | [<CompiledName "stopped">] Stopped
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Initializing -> "initializing"
        | Running -> "running"
        | Stopped -> "stopped"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type buildsBuildTriggerSource =
    | [<CompiledName "push">] Push
    | [<CompiledName "pull_request">] Pull_request
    | [<CompiledName "manual">] Manual
    | [<CompiledName "api">] Api
    member this.Format() =
        match this with
        | Push -> "push"
        | Pull_request -> "pull_request"
        | Manual -> "manual"
        | Api -> "api"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type buildsPackageManager =
    | [<CompiledName "npm">] Npm
    | [<CompiledName "yarn">] Yarn
    | [<CompiledName "pnpm">] Pnpm
    | [<CompiledName "bun">] Bun
    | [<CompiledName "uv">] Uv
    member this.Format() =
        match this with
        | Npm -> "npm"
        | Yarn -> "yarn"
        | Pnpm -> "pnpm"
        | Bun -> "bun"
        | Uv -> "uv"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type buildsSCMProviderType =
    | [<CompiledName "github">] Github
    member this.Format() =
        match this with
        | Github -> "github"

///Account identifier.
type buildsaccountid = string
///Git branch name.
type buildsbranch = string
type buildsbranchexcludes = list<string>
type buildsbranchincludes = list<string>
type buildsbuildcachingenabled = bool
type buildsbuildcommand = string
type buildsbuildtokenname = string
///Build token UUID.
type buildsbuildtokenuuid = System.Guid
///Build UUID.
type buildsbuilduuid = System.Guid
type buildscloudflaretokenid = string
///Git commit hash
type buildscommithash = string
type buildscreatedon = System.DateTimeOffset
///Pagination cursor for log retrieval.
type buildscursor = string
type buildsdeletedon = System.DateTimeOffset
type buildsdeploycommand = string
///Environment variable key.
type buildsenvironmentvariablekey = string
///External script identifier.
type buildsexternalscriptid = string
///Comma-separated list of external script IDs (max 20).
type buildsexternalscriptids = string
type buildsissecret = bool
type buildsmodifiedon = System.DateTimeOffset
type buildsownertype = string
type buildspathexcludes = list<string>
type buildspathincludes = list<string>
///Provider account identifier.
type buildsprovideraccountid = string
type buildsprovideraccountname = string
///Repository connection UUID.
type buildsrepoconnectionuuid = System.Guid
///Repository identifier.
type buildsrepoid = string
type buildsreponame = string
///Root directory path.
type buildsrootdirectory = string
type buildsstoppedon = System.DateTimeOffset
type buildstriggername = string
///Trigger UUID.
type buildstriggeruuid = System.Guid
///Comma-separated list of version UUIDs (max 20).
type buildsversionids = string

type Errors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Errors = { code = None; message = None }

type buildsAPIResponse =
    { errors: list<Errors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of buildsAPIResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>,
                          messages: list<string>,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): buildsAPIResponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type buildsBuildLogsResponse =
    { ///Pagination cursor for log retrieval.
      cursor: Option<buildscursor>
      lines: Option<list<list<string>>>
      truncated: Option<bool> }
    ///Creates an instance of buildsBuildLogsResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsBuildLogsResponse =
        { cursor = None
          lines = None
          truncated = None }

type Pullrequest =
    { created_on: Option<buildscreatedon>
      pull_request_url: Option<string> }
    ///Creates an instance of Pullrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Pullrequest =
        { created_on = None
          pull_request_url = None }

///Trigger information without build_token_uuid
type Trigger =
    { branch_excludes: Option<buildsbranchexcludes>
      branch_includes: Option<buildsbranchincludes>
      build_caching_enabled: Option<buildsbuildcachingenabled>
      build_command: Option<buildsbuildcommand>
      created_on: Option<buildscreatedon>
      deleted_on: Option<buildsdeletedon>
      deploy_command: Option<buildsdeploycommand>
      ///External script identifier.
      external_script_id: Option<buildsexternalscriptid>
      modified_on: Option<buildsmodifiedon>
      path_excludes: Option<buildspathexcludes>
      path_includes: Option<buildspathincludes>
      repo_connection: Option<buildsUpsertRepoConnectionResponse>
      ///Root directory path.
      root_directory: Option<buildsrootdirectory>
      trigger_name: Option<buildstriggername>
      ///Trigger UUID.
      trigger_uuid: Option<buildstriggeruuid> }
    ///Creates an instance of Trigger with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Trigger =
        { branch_excludes = None
          branch_includes = None
          build_caching_enabled = None
          build_command = None
          created_on = None
          deleted_on = None
          deploy_command = None
          external_script_id = None
          modified_on = None
          path_excludes = None
          path_includes = None
          repo_connection = None
          root_directory = None
          trigger_name = None
          trigger_uuid = None }

type buildsBuildResponse =
    { build_outcome: Option<buildsBuildOutcome>
      build_trigger_metadata: Option<buildsBuildTriggerMetadataResponse>
      ///Build UUID.
      build_uuid: Option<buildsbuilduuid>
      created_on: Option<buildscreatedon>
      initializing_on: Option<System.DateTimeOffset>
      modified_on: Option<buildsmodifiedon>
      pull_request: Option<Pullrequest>
      running_on: Option<System.DateTimeOffset>
      status: Option<buildsBuildStatus>
      stopped_on: Option<buildsstoppedon>
      ///Trigger information without build_token_uuid
      trigger: Option<Trigger> }
    ///Creates an instance of buildsBuildResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsBuildResponse =
        { build_outcome = None
          build_trigger_metadata = None
          build_uuid = None
          created_on = None
          initializing_on = None
          modified_on = None
          pull_request = None
          running_on = None
          status = None
          stopped_on = None
          trigger = None }

type buildsBuildSeedRepoInput =
    { ///Git branch name.
      branch: buildsbranch
      files: Option<list<buildsBuildSeedRepoInputFile>>
      owner: string
      path: string
      provider: buildsSCMProviderType
      repository: string }
    ///Creates an instance of buildsBuildSeedRepoInput with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (branch: buildsbranch,
                          owner: string,
                          path: string,
                          provider: buildsSCMProviderType,
                          repository: string): buildsBuildSeedRepoInput =
        { branch = branch
          files = None
          owner = owner
          path = path
          provider = provider
          repository = repository }

type buildsBuildSeedRepoInputFile =
    { content: string
      filename: string
      isBase64: Option<bool>
      ///Text to replace in the file
      replace: Option<string> }
    ///Creates an instance of buildsBuildSeedRepoInputFile with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, filename: string): buildsBuildSeedRepoInputFile =
        { content = content
          filename = filename
          isBase64 = None
          replace = None }

type buildsBuildTriggerMetadataResponse =
    { author: Option<string>
      ///Git branch name.
      branch: Option<buildsbranch>
      build_command: Option<buildsbuildcommand>
      build_token_name: Option<buildsbuildtokenname>
      ///Build token UUID.
      build_token_uuid: Option<buildsbuildtokenuuid>
      build_trigger_source: Option<buildsBuildTriggerSource>
      ///Git commit hash
      commit_hash: Option<buildscommithash>
      commit_message: Option<string>
      deploy_command: Option<buildsdeploycommand>
      environment_variables: Option<Map<string, string>>
      provider_account_name: Option<buildsprovideraccountname>
      provider_type: Option<buildsSCMProviderType>
      repo_name: Option<buildsreponame>
      ///Root directory path.
      root_directory: Option<buildsrootdirectory> }
    ///Creates an instance of buildsBuildTriggerMetadataResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsBuildTriggerMetadataResponse =
        { author = None
          branch = None
          build_command = None
          build_token_name = None
          build_token_uuid = None
          build_trigger_source = None
          commit_hash = None
          commit_message = None
          deploy_command = None
          environment_variables = None
          provider_account_name = None
          provider_type = None
          repo_name = None
          root_directory = None }

type buildsBuildsByVersionResponse =
    { builds: Option<Map<string, buildsBuildResponse>> }
    ///Creates an instance of buildsBuildsByVersionResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsBuildsByVersionResponse = { builds = None }

type buildsCanceledBuildResponse =
    { build_outcome: Option<buildsBuildOutcome>
      ///Build UUID.
      build_uuid: Option<buildsbuilduuid>
      stopped_on: Option<buildsstoppedon> }
    ///Creates an instance of buildsCanceledBuildResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsCanceledBuildResponse =
        { build_outcome = None
          build_uuid = None
          stopped_on = None }

type buildsConfigAutofillResponse =
    { config_file: Option<string>
      default_worker_name: Option<string>
      env_worker_names: Option<Map<string, string>>
      package_manager: Option<string>
      scripts: Option<Map<string, string>> }
    ///Creates an instance of buildsConfigAutofillResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsConfigAutofillResponse =
        { config_file = None
          default_worker_name = None
          env_worker_names = None
          package_manager = None
          scripts = None }

type buildsCreateBuildRequest =
    { ///Git branch name (required if commit_hash not provided)
      branch: Option<Newtonsoft.Json.Linq.JToken>
      ///Git commit hash (required if branch not provided)
      commit_hash: Option<Newtonsoft.Json.Linq.JToken>
      seed_repo: Option<buildsBuildSeedRepoInput> }
    ///Creates an instance of buildsCreateBuildRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsCreateBuildRequest =
        { branch = None
          commit_hash = None
          seed_repo = None }

type buildsCreateBuildTokenRequest =
    { build_token_name: buildsbuildtokenname
      build_token_secret: string
      cloudflare_token_id: buildscloudflaretokenid }
    ///Creates an instance of buildsCreateBuildTokenRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (build_token_name: buildsbuildtokenname,
                          build_token_secret: string,
                          cloudflare_token_id: buildscloudflaretokenid): buildsCreateBuildTokenRequest =
        { build_token_name = build_token_name
          build_token_secret = build_token_secret
          cloudflare_token_id = cloudflare_token_id }

type buildsCreateBuildTokenResponse =
    { build_token_name: Option<buildsbuildtokenname>
      ///Build token UUID.
      build_token_uuid: Option<buildsbuildtokenuuid>
      cloudflare_token_id: Option<buildscloudflaretokenid>
      owner_type: Option<buildsownertype> }
    ///Creates an instance of buildsCreateBuildTokenResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsCreateBuildTokenResponse =
        { build_token_name = None
          build_token_uuid = None
          cloudflare_token_id = None
          owner_type = None }

type buildsCreateTriggerRequest =
    { branch_excludes: buildsbranchexcludes
      branch_includes: buildsbranchincludes
      build_caching_enabled: Option<buildsbuildcachingenabled>
      build_command: buildsbuildcommand
      ///Build token UUID.
      build_token_uuid: buildsbuildtokenuuid
      deploy_command: buildsdeploycommand
      ///External script identifier.
      external_script_id: buildsexternalscriptid
      path_excludes: buildspathexcludes
      path_includes: buildspathincludes
      ///Repository connection UUID.
      repo_connection_uuid: buildsrepoconnectionuuid
      ///Root directory path.
      root_directory: buildsrootdirectory
      trigger_name: buildstriggername }
    ///Creates an instance of buildsCreateTriggerRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (branch_excludes: buildsbranchexcludes,
                          branch_includes: buildsbranchincludes,
                          build_command: buildsbuildcommand,
                          build_token_uuid: buildsbuildtokenuuid,
                          deploy_command: buildsdeploycommand,
                          external_script_id: buildsexternalscriptid,
                          path_excludes: buildspathexcludes,
                          path_includes: buildspathincludes,
                          repo_connection_uuid: buildsrepoconnectionuuid,
                          root_directory: buildsrootdirectory,
                          trigger_name: buildstriggername): buildsCreateTriggerRequest =
        { branch_excludes = branch_excludes
          branch_includes = branch_includes
          build_caching_enabled = None
          build_command = build_command
          build_token_uuid = build_token_uuid
          deploy_command = deploy_command
          external_script_id = external_script_id
          path_excludes = path_excludes
          path_includes = path_includes
          repo_connection_uuid = repo_connection_uuid
          root_directory = root_directory
          trigger_name = trigger_name }

type buildsErrorResponseErrors =
    { code: Option<int>
      message: string }
    ///Creates an instance of buildsErrorResponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (message: string): buildsErrorResponseErrors = { code = None; message = message }

type buildsErrorResponse =
    { errors: list<buildsErrorResponseErrors>
      messages: list<string>
      result: Newtonsoft.Json.Linq.JObject
      success: bool }
    ///Creates an instance of buildsErrorResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<buildsErrorResponseErrors>,
                          messages: list<string>,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): buildsErrorResponse =
        { errors = errors
          messages = messages
          result = result
          success = success }

type buildsGetAccountLimitResponse =
    { ///When build minutes will refresh (only for non-paid plans)
      build_minutes_refresh_on: Option<System.DateTimeOffset>
      ///Whether build minutes limit has been reached (only for non-paid plans)
      has_reached_build_minutes_limit: Option<bool> }
    ///Creates an instance of buildsGetAccountLimitResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsGetAccountLimitResponse =
        { build_minutes_refresh_on = None
          has_reached_build_minutes_limit = None }

type buildsInsertBuildResponse =
    { ///Build UUID.
      build_uuid: Option<buildsbuilduuid>
      created_on: Option<buildscreatedon> }
    ///Creates an instance of buildsInsertBuildResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsInsertBuildResponse = { build_uuid = None; created_on = None }

type buildsLatestBuildsResponse =
    { builds: Option<Map<string, buildsBuildResponse>> }
    ///Creates an instance of buildsLatestBuildsResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsLatestBuildsResponse = { builds = None }

type buildsListTokensResponse =
    { build_token_name: Option<buildsbuildtokenname>
      ///Build token UUID.
      build_token_uuid: Option<buildsbuildtokenuuid>
      cloudflare_token_id: Option<buildscloudflaretokenid>
      owner_type: Option<buildsownertype> }
    ///Creates an instance of buildsListTokensResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsListTokensResponse =
        { build_token_name = None
          build_token_uuid = None
          cloudflare_token_id = None
          owner_type = None }

type buildsPaginationInfo =
    { count: Option<int>
      page: Option<int>
      per_page: Option<int>
      total_count: Option<int>
      total_pages: Option<int> }
    ///Creates an instance of buildsPaginationInfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsPaginationInfo =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type buildsTriggerResponse =
    { branch_excludes: Option<buildsbranchexcludes>
      branch_includes: Option<buildsbranchincludes>
      build_caching_enabled: Option<buildsbuildcachingenabled>
      build_command: Option<buildsbuildcommand>
      build_token_name: Option<buildsbuildtokenname>
      ///Build token UUID.
      build_token_uuid: Option<buildsbuildtokenuuid>
      created_on: Option<buildscreatedon>
      deleted_on: Option<buildsdeletedon>
      deploy_command: Option<buildsdeploycommand>
      ///External script identifier.
      external_script_id: Option<buildsexternalscriptid>
      modified_on: Option<buildsmodifiedon>
      path_excludes: Option<buildspathexcludes>
      path_includes: Option<buildspathincludes>
      repo_connection: Option<buildsUpsertRepoConnectionResponse>
      ///Root directory path.
      root_directory: Option<buildsrootdirectory>
      trigger_name: Option<buildstriggername>
      ///Trigger UUID.
      trigger_uuid: Option<buildstriggeruuid> }
    ///Creates an instance of buildsTriggerResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsTriggerResponse =
        { branch_excludes = None
          branch_includes = None
          build_caching_enabled = None
          build_command = None
          build_token_name = None
          build_token_uuid = None
          created_on = None
          deleted_on = None
          deploy_command = None
          external_script_id = None
          modified_on = None
          path_excludes = None
          path_includes = None
          repo_connection = None
          root_directory = None
          trigger_name = None
          trigger_uuid = None }

type buildsUpdateTriggerRequest =
    { branch_excludes: Option<buildsbranchexcludes>
      branch_includes: Option<buildsbranchincludes>
      build_caching_enabled: Option<buildsbuildcachingenabled>
      build_command: Option<buildsbuildcommand>
      ///Build token UUID.
      build_token_uuid: Option<buildsbuildtokenuuid>
      deploy_command: Option<buildsdeploycommand>
      path_excludes: Option<buildspathexcludes>
      path_includes: Option<buildspathincludes>
      ///Root directory path.
      root_directory: Option<buildsrootdirectory>
      trigger_name: Option<buildstriggername> }
    ///Creates an instance of buildsUpdateTriggerRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsUpdateTriggerRequest =
        { branch_excludes = None
          branch_includes = None
          build_caching_enabled = None
          build_command = None
          build_token_uuid = None
          deploy_command = None
          path_excludes = None
          path_includes = None
          root_directory = None
          trigger_name = None }

type buildsUpsertRepoConnectionRequest =
    { ///Provider account identifier.
      provider_account_id: buildsprovideraccountid
      provider_account_name: buildsprovideraccountname
      provider_type: buildsSCMProviderType
      ///Repository identifier.
      repo_id: buildsrepoid
      repo_name: buildsreponame }
    ///Creates an instance of buildsUpsertRepoConnectionRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (provider_account_id: buildsprovideraccountid,
                          provider_account_name: buildsprovideraccountname,
                          provider_type: buildsSCMProviderType,
                          repo_id: buildsrepoid,
                          repo_name: buildsreponame): buildsUpsertRepoConnectionRequest =
        { provider_account_id = provider_account_id
          provider_account_name = provider_account_name
          provider_type = provider_type
          repo_id = repo_id
          repo_name = repo_name }

type buildsUpsertRepoConnectionResponse =
    { created_on: Option<buildscreatedon>
      deleted_on: Option<buildsdeletedon>
      modified_on: Option<buildsmodifiedon>
      ///Provider account identifier.
      provider_account_id: Option<buildsprovideraccountid>
      provider_account_name: Option<buildsprovideraccountname>
      provider_type: Option<buildsSCMProviderType>
      ///Repository connection UUID.
      repo_connection_uuid: Option<buildsrepoconnectionuuid>
      ///Repository identifier.
      repo_id: Option<buildsrepoid>
      repo_name: Option<buildsreponame> }
    ///Creates an instance of buildsUpsertRepoConnectionResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): buildsUpsertRepoConnectionResponse =
        { created_on = None
          deleted_on = None
          modified_on = None
          provider_account_id = None
          provider_account_name = None
          provider_type = None
          repo_connection_uuid = None
          repo_id = None
          repo_name = None }

type getAccountLimitsresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getAccountLimitsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getAccountLimitsresponseErrors = { code = None; message = None }

type getAccountLimitsresponse =
    { errors: list<getAccountLimitsresponseErrors>
      messages: list<string>
      result: buildsGetAccountLimitResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of getAccountLimitsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<getAccountLimitsresponseErrors>,
                          messages: list<string>,
                          result: buildsGetAccountLimitResponse,
                          success: bool): getAccountLimitsresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type getBuildsByVersionIdsresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getBuildsByVersionIdsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getBuildsByVersionIdsresponseErrors = { code = None; message = None }

type getBuildsByVersionIdsresponse =
    { errors: list<getBuildsByVersionIdsresponseErrors>
      messages: list<string>
      result: buildsBuildsByVersionResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of getBuildsByVersionIdsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<getBuildsByVersionIdsresponseErrors>,
                          messages: list<string>,
                          result: buildsBuildsByVersionResponse,
                          success: bool): getBuildsByVersionIdsresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type getLatestBuildsByScriptsresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getLatestBuildsByScriptsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getLatestBuildsByScriptsresponseErrors = { code = None; message = None }

type getLatestBuildsByScriptsresponse =
    { errors: list<getLatestBuildsByScriptsresponseErrors>
      messages: list<string>
      result: buildsLatestBuildsResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of getLatestBuildsByScriptsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<getLatestBuildsByScriptsresponseErrors>,
                          messages: list<string>,
                          result: buildsLatestBuildsResponse,
                          success: bool): getLatestBuildsByScriptsresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type getBuildByUuidresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getBuildByUuidresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getBuildByUuidresponseErrors = { code = None; message = None }

type getBuildByUuidresponse =
    { errors: list<getBuildByUuidresponseErrors>
      messages: list<string>
      result: buildsBuildResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of getBuildByUuidresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<getBuildByUuidresponseErrors>,
                          messages: list<string>,
                          result: buildsBuildResponse,
                          success: bool): getBuildByUuidresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type cancelBuildByUuidresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of cancelBuildByUuidresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): cancelBuildByUuidresponseErrors = { code = None; message = None }

type cancelBuildByUuidresponse =
    { errors: list<cancelBuildByUuidresponseErrors>
      messages: list<string>
      result: buildsCanceledBuildResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of cancelBuildByUuidresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<cancelBuildByUuidresponseErrors>,
                          messages: list<string>,
                          result: buildsCanceledBuildResponse,
                          success: bool): cancelBuildByUuidresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type getBuildLogsresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getBuildLogsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getBuildLogsresponseErrors = { code = None; message = None }

type getBuildLogsresponse =
    { errors: list<getBuildLogsresponseErrors>
      messages: list<string>
      result: buildsBuildLogsResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of getBuildLogsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<getBuildLogsresponseErrors>,
                          messages: list<string>,
                          result: buildsBuildLogsResponse,
                          success: bool): getBuildLogsresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type upsertRepoConnectionresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of upsertRepoConnectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): upsertRepoConnectionresponseErrors = { code = None; message = None }

type upsertRepoConnectionresponse =
    { errors: list<upsertRepoConnectionresponseErrors>
      messages: list<string>
      result: buildsUpsertRepoConnectionResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of upsertRepoConnectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<upsertRepoConnectionresponseErrors>,
                          messages: list<string>,
                          result: buildsUpsertRepoConnectionResponse,
                          success: bool): upsertRepoConnectionresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type getWorkerConfigAutofillresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getWorkerConfigAutofillresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getWorkerConfigAutofillresponseErrors = { code = None; message = None }

type getWorkerConfigAutofillresponse =
    { errors: list<getWorkerConfigAutofillresponseErrors>
      messages: list<string>
      result: buildsConfigAutofillResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of getWorkerConfigAutofillresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<getWorkerConfigAutofillresponseErrors>,
                          messages: list<string>,
                          result: buildsConfigAutofillResponse,
                          success: bool): getWorkerConfigAutofillresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type listBuildTokensresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of listBuildTokensresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): listBuildTokensresponseErrors = { code = None; message = None }

type listBuildTokensresponse =
    { errors: list<listBuildTokensresponseErrors>
      messages: list<string>
      result: list<buildsListTokensResponse>
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of listBuildTokensresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<listBuildTokensresponseErrors>,
                          messages: list<string>,
                          result: list<buildsListTokensResponse>,
                          success: bool): listBuildTokensresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type createBuildTokenresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of createBuildTokenresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): createBuildTokenresponseErrors = { code = None; message = None }

type createBuildTokenresponse =
    { errors: list<createBuildTokenresponseErrors>
      messages: list<string>
      result: buildsCreateBuildTokenResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of createBuildTokenresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<createBuildTokenresponseErrors>,
                          messages: list<string>,
                          result: buildsCreateBuildTokenResponse,
                          success: bool): createBuildTokenresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type createTriggerresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of createTriggerresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): createTriggerresponseErrors = { code = None; message = None }

type createTriggerresponse =
    { errors: list<createTriggerresponseErrors>
      messages: list<string>
      result: buildsTriggerResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of createTriggerresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<createTriggerresponseErrors>,
                          messages: list<string>,
                          result: buildsTriggerResponse,
                          success: bool): createTriggerresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type updateTriggerresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of updateTriggerresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): updateTriggerresponseErrors = { code = None; message = None }

type updateTriggerresponse =
    { errors: list<updateTriggerresponseErrors>
      messages: list<string>
      result: buildsTriggerResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of updateTriggerresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<updateTriggerresponseErrors>,
                          messages: list<string>,
                          result: buildsTriggerResponse,
                          success: bool): updateTriggerresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type createManualBuildresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of createManualBuildresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): createManualBuildresponseErrors = { code = None; message = None }

type createManualBuildresponse =
    { errors: list<createManualBuildresponseErrors>
      messages: list<string>
      result: buildsInsertBuildResponse
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of createManualBuildresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<createManualBuildresponseErrors>,
                          messages: list<string>,
                          result: buildsInsertBuildResponse,
                          success: bool): createManualBuildresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type listEnvironmentVariablesresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of listEnvironmentVariablesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): listEnvironmentVariablesresponseErrors = { code = None; message = None }

type listEnvironmentVariablesresponse =
    { errors: list<listEnvironmentVariablesresponseErrors>
      messages: list<string>
      result: Map<string, string>
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of listEnvironmentVariablesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<listEnvironmentVariablesresponseErrors>,
                          messages: list<string>,
                          result: Map<string, string>,
                          success: bool): listEnvironmentVariablesresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type upsertEnvironmentVariablesresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of upsertEnvironmentVariablesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): upsertEnvironmentVariablesresponseErrors = { code = None; message = None }

type upsertEnvironmentVariablesresponse =
    { errors: list<upsertEnvironmentVariablesresponseErrors>
      messages: list<string>
      result: Map<string, string>
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of upsertEnvironmentVariablesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<upsertEnvironmentVariablesresponseErrors>,
                          messages: list<string>,
                          result: Map<string, string>,
                          success: bool): upsertEnvironmentVariablesresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type listBuildsByScriptresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of listBuildsByScriptresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): listBuildsByScriptresponseErrors = { code = None; message = None }

type listBuildsByScriptresponse =
    { errors: list<listBuildsByScriptresponseErrors>
      messages: list<string>
      result: list<buildsBuildResponse>
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of listBuildsByScriptresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<listBuildsByScriptresponseErrors>,
                          messages: list<string>,
                          result: list<buildsBuildResponse>,
                          success: bool): listBuildsByScriptresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

type listTriggersByScriptresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of listTriggersByScriptresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): listTriggersByScriptresponseErrors = { code = None; message = None }

type listTriggersByScriptresponse =
    { errors: list<listTriggersByScriptresponseErrors>
      messages: list<string>
      result: list<buildsTriggerResponse>
      result_info: Option<buildsPaginationInfo>
      success: bool }
    ///Creates an instance of listTriggersByScriptresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<listTriggersByScriptresponseErrors>,
                          messages: list<string>,
                          result: list<buildsTriggerResponse>,
                          success: bool): listTriggersByScriptresponse =
        { errors = errors
          messages = messages
          result = result
          result_info = None
          success = success }

[<RequireQualifiedAccess>]
type GetAccountLimits =
    ///Account limits retrieved successfully
    | OK of payload: getAccountLimitsresponse

[<RequireQualifiedAccess>]
type GetBuildsByVersionIds =
    ///Builds retrieved successfully
    | OK of payload: getBuildsByVersionIdsresponse

[<RequireQualifiedAccess>]
type GetLatestBuildsByScripts =
    ///Latest builds retrieved successfully
    | OK of payload: getLatestBuildsByScriptsresponse

[<RequireQualifiedAccess>]
type GetBuildByUuid =
    ///Build retrieved successfully
    | OK of payload: getBuildByUuidresponse
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type CancelBuildByUuid =
    ///Build canceled successfully
    | OK of payload: cancelBuildByUuidresponse
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type GetBuildLogs =
    ///Build logs retrieved successfully
    | OK of payload: getBuildLogsresponse
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type UpsertRepoConnection =
    ///Repository connection upserted successfully
    | OK of payload: upsertRepoConnectionresponse

[<RequireQualifiedAccess>]
type DeleteRepoConnection =
    | OK of payload: Newtonsoft.Json.Linq.JToken
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type GetWorkerConfigAutofill =
    ///Configuration autofill data retrieved successfully
    | OK of payload: getWorkerConfigAutofillresponse

[<RequireQualifiedAccess>]
type ListBuildTokens =
    ///Build tokens retrieved successfully
    | OK of payload: listBuildTokensresponse

[<RequireQualifiedAccess>]
type CreateBuildToken =
    ///Build token created successfully
    | OK of payload: createBuildTokenresponse

[<RequireQualifiedAccess>]
type DeleteBuildToken =
    | OK of payload: Newtonsoft.Json.Linq.JToken
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type CreateTrigger =
    ///Trigger created successfully
    | OK of payload: createTriggerresponse

[<RequireQualifiedAccess>]
type DeleteTrigger =
    | OK of payload: Newtonsoft.Json.Linq.JToken
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type UpdateTrigger =
    ///Trigger updated successfully
    | OK of payload: updateTriggerresponse
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type CreateManualBuild =
    ///Build created successfully
    | OK of payload: createManualBuildresponse

[<RequireQualifiedAccess>]
type ListEnvironmentVariables =
    ///Environment variables retrieved successfully
    | OK of payload: listEnvironmentVariablesresponse

[<RequireQualifiedAccess>]
type UpsertEnvironmentVariables =
    ///Environment variables updated successfully
    | OK of payload: upsertEnvironmentVariablesresponse
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type DeleteEnvironmentVariable =
    | OK of payload: Newtonsoft.Json.Linq.JToken
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type PurgeBuildCache =
    | OK of payload: Newtonsoft.Json.Linq.JToken
    | NotFound of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type ListBuildsByScript =
    ///Builds retrieved successfully
    | OK of payload: listBuildsByScriptresponse

[<RequireQualifiedAccess>]
type ListTriggersByScript =
    ///Triggers retrieved successfully
    | OK of payload: listTriggersByScriptresponse
