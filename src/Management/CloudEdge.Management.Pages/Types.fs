namespace rec Fidelity.CloudEdge.Management.Pages.Types

// Auto-generated stub types (missing from Hawaii output)
type alias = string
type push = string
type results = string

///The domain name.
type pagesdomainname = string
///Identifier.
type pagesidentifier = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type pagesmessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of pagesmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): pagesmessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type pagesmessages = list<pagesmessagesArrayItem>
///Name of the project.
type pagesprojectname = string

type ErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ErrorsSource = { pointer = None }

type Errors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<ErrorsSource> }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type MessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): MessagesSource = { pointer = None }

type Messages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<MessagesSource> }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Messages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Resultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``pagesapi-response-collection`` =
    { errors: list<Errors>
      messages: list<Messages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<Resultinfo> }
    ///Creates an instance of pagesapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>, messages: list<Messages>, success: bool): ``pagesapi-response-collection`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None }

type ``pagesapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pagesapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pagesapi-response-commonErrorsSource`` = { pointer = None }

type ``pagesapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pagesapi-response-commonErrorsSource``> }
    ///Creates an instance of pagesapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pagesapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pagesapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pagesapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pagesapi-response-commonMessagesSource`` = { pointer = None }

type ``pagesapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pagesapi-response-commonMessagesSource``> }
    ///Creates an instance of pagesapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pagesapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pagesapi-response-common`` =
    { errors: list<``pagesapi-response-commonErrors``>
      messages: list<``pagesapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of pagesapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pagesapi-response-commonErrors``>,
                          messages: list<``pagesapi-response-commonMessages``>,
                          success: bool): ``pagesapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``pagesapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of pagesapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``pagesapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

///Configs for the project build process.
type pagesbuildconfig =
    { ///Enable build caching for the project.
      build_caching: Option<bool>
      ///Command used to build project.
      build_command: Option<string>
      ///Assets output directory of the build.
      destination_dir: Option<string>
      ///Directory to run the command.
      root_dir: Option<string>
      ///The classifying tag for analytics.
      web_analytics_tag: string
      ///The auth token for analytics.
      web_analytics_token: string }
    ///Creates an instance of pagesbuildconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (web_analytics_tag: string, web_analytics_token: string): pagesbuildconfig =
        { build_caching = None
          build_command = None
          destination_dir = None
          root_dir = None
          web_analytics_tag = web_analytics_tag
          web_analytics_token = web_analytics_token }

///Additional info about the trigger.
type Metadata =
    { ///Where the trigger happened.
      branch: string
      ///Whether the deployment trigger commit was dirty.
      commit_dirty: bool
      ///Hash of the deployment trigger commit.
      commit_hash: string
      ///Message of the deployment trigger commit.
      commit_message: string }
    ///Creates an instance of Metadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (branch: string, commit_dirty: bool, commit_hash: string, commit_message: string): Metadata =
        { branch = branch
          commit_dirty = commit_dirty
          commit_hash = commit_hash
          commit_message = commit_message }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "github:push">] ``Github:push``
    | [<CompiledName "ad_hoc">] Ad_hoc
    | [<CompiledName "deploy_hook">] Deploy_hook
    member this.Format() =
        match this with
        | ``Github:push`` -> "github:push"
        | Ad_hoc -> "ad_hoc"
        | Deploy_hook -> "deploy_hook"

///Info about what caused the deployment.
type Deploymenttrigger =
    { ///Additional info about the trigger.
      metadata: Metadata
      ///What caused the deployment.
      ``type``: Type }
    ///Creates an instance of Deploymenttrigger with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (metadata: Metadata, ``type``: Type): Deploymenttrigger =
        { metadata = metadata
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Environment =
    | [<CompiledName "preview">] Preview
    | [<CompiledName "production">] Production
    member this.Format() =
        match this with
        | Preview -> "preview"
        | Production -> "production"

type pagesdeployment =
    { ///A list of alias URLs pointing to this deployment.
      aliases: list<string>
      ///Configs for the project build process.
      build_config: pagesbuildconfig
      ///When the deployment was created.
      created_on: System.DateTimeOffset
      ///Info about what caused the deployment.
      deployment_trigger: Deploymenttrigger
      ///Environment variables used for builds and Pages Functions.
      env_vars: Map<string, Option<string>>
      ///Type of deploy.
      environment: Environment
      ///Id of the deployment.
      id: string
      ///If the deployment has been skipped.
      is_skipped: bool
      ///The status of the deployment.
      latest_stage: pagesstage
      ///When the deployment was last modified.
      modified_on: System.DateTimeOffset
      ///Id of the project.
      project_id: string
      ///Name of the project.
      project_name: pagesprojectname
      ///Short Id (8 character) of the deployment.
      short_id: string
      ///Configs for the project source control.
      source: pagessource
      ///List of past stages.
      stages: list<pagesstage>
      ///The live URL to view this deployment.
      url: string
      ///Whether the deployment uses functions.
      uses_functions: Option<bool> }
    ///Creates an instance of pagesdeployment with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (aliases: list<string>,
                          build_config: pagesbuildconfig,
                          created_on: System.DateTimeOffset,
                          deployment_trigger: Deploymenttrigger,
                          env_vars: Map<string, Option<string>>,
                          environment: Environment,
                          id: string,
                          is_skipped: bool,
                          latest_stage: pagesstage,
                          modified_on: System.DateTimeOffset,
                          project_id: string,
                          project_name: pagesprojectname,
                          short_id: string,
                          source: pagessource,
                          stages: list<pagesstage>,
                          url: string): pagesdeployment =
        { aliases = aliases
          build_config = build_config
          created_on = created_on
          deployment_trigger = deployment_trigger
          env_vars = env_vars
          environment = environment
          id = id
          is_skipped = is_skipped
          latest_stage = latest_stage
          modified_on = modified_on
          project_id = project_id
          project_name = project_name
          short_id = short_id
          source = source
          stages = stages
          url = url
          uses_functions = None }

///Limits for Pages Functions.
type Limits =
    { ///CPU time limit in milliseconds.
      cpu_ms: int }
    ///Creates an instance of Limits with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cpu_ms: int): Limits = { cpu_ms = cpu_ms }

///Placement setting used for Pages Functions.
type Placement =
    { ///Placement mode.
      mode: string }
    ///Creates an instance of Placement with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (mode: string): Placement = { mode = mode }

type pagesdeploymentconfigvalues =
    { ///Constellation bindings used for Pages Functions.
      ai_bindings: Option<Map<string, string>>
      ///Whether to always use the latest compatibility date for Pages Functions.
      always_use_latest_compatibility_date: bool
      ///Analytics Engine bindings used for Pages Functions.
      analytics_engine_datasets: Option<Map<string, string>>
      ///Browser bindings used for Pages Functions.
      browsers: Option<Map<string, Option<string>>>
      ///The major version of the build image to use for Pages Functions.
      build_image_major_version: int
      ///Compatibility date used for Pages Functions.
      compatibility_date: string
      ///Compatibility flags used for Pages Functions.
      compatibility_flags: list<string>
      ///D1 databases used for Pages Functions.
      d1_databases: Option<Map<string, string>>
      ///Durable Object namespaces used for Pages Functions.
      durable_object_namespaces: Option<Map<string, string>>
      ///Environment variables used for builds and Pages Functions.
      env_vars: Map<string, Option<string>>
      ///Whether to fail open when the deployment config cannot be applied.
      fail_open: bool
      ///Hyperdrive bindings used for Pages Functions.
      hyperdrive_bindings: Option<Map<string, string>>
      ///KV namespaces used for Pages Functions.
      kv_namespaces: Option<Map<string, string>>
      ///Limits for Pages Functions.
      limits: Option<Limits>
      ///mTLS bindings used for Pages Functions.
      mtls_certificates: Option<Map<string, string>>
      ///Placement setting used for Pages Functions.
      placement: Option<Placement>
      ///Queue Producer bindings used for Pages Functions.
      queue_producers: Option<Map<string, string>>
      ///R2 buckets used for Pages Functions.
      r2_buckets: Option<Map<string, string>>
      ///Services used for Pages Functions.
      services: Option<Map<string, string>>
      ///Vectorize bindings used for Pages Functions.
      vectorize_bindings: Option<Map<string, string>>
      ///Hash of the Wrangler configuration used for the deployment.
      wrangler_config_hash: Option<string> }
    ///Creates an instance of pagesdeploymentconfigvalues with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (always_use_latest_compatibility_date: bool,
                          build_image_major_version: int,
                          compatibility_date: string,
                          compatibility_flags: list<string>,
                          env_vars: Map<string, Option<string>>,
                          fail_open: bool): pagesdeploymentconfigvalues =
        { ai_bindings = None
          always_use_latest_compatibility_date = always_use_latest_compatibility_date
          analytics_engine_datasets = None
          browsers = None
          build_image_major_version = build_image_major_version
          compatibility_date = compatibility_date
          compatibility_flags = compatibility_flags
          d1_databases = None
          durable_object_namespaces = None
          env_vars = env_vars
          fail_open = fail_open
          hyperdrive_bindings = None
          kv_namespaces = None
          limits = None
          mtls_certificates = None
          placement = None
          queue_producers = None
          r2_buckets = None
          services = None
          vectorize_bindings = None
          wrangler_config_hash = None }

///Limits for Pages Functions.
type pagesdeploymentconfigvaluesrequestLimits =
    { ///CPU time limit in milliseconds.
      cpu_ms: int }
    ///Creates an instance of pagesdeploymentconfigvaluesrequestLimits with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cpu_ms: int): pagesdeploymentconfigvaluesrequestLimits = { cpu_ms = cpu_ms }

///Placement setting used for Pages Functions.
type pagesdeploymentconfigvaluesrequestPlacement =
    { ///Placement mode.
      mode: string }
    ///Creates an instance of pagesdeploymentconfigvaluesrequestPlacement with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (mode: string): pagesdeploymentconfigvaluesrequestPlacement = { mode = mode }

type pagesdeploymentconfigvaluesrequest =
    { ///Constellation bindings used for Pages Functions.
      ai_bindings: Option<Map<string, Option<string>>>
      ///Whether to always use the latest compatibility date for Pages Functions.
      always_use_latest_compatibility_date: Option<bool>
      ///Analytics Engine bindings used for Pages Functions.
      analytics_engine_datasets: Option<Map<string, Option<string>>>
      ///Browser bindings used for Pages Functions.
      browsers: Option<Map<string, Option<string>>>
      ///The major version of the build image to use for Pages Functions.
      build_image_major_version: Option<int>
      ///Compatibility date used for Pages Functions.
      compatibility_date: Option<string>
      ///Compatibility flags used for Pages Functions.
      compatibility_flags: Option<list<string>>
      ///D1 databases used for Pages Functions.
      d1_databases: Option<Map<string, Option<string>>>
      ///Durable Object namespaces used for Pages Functions.
      durable_object_namespaces: Option<Map<string, Option<string>>>
      ///Environment variables used for builds and Pages Functions.
      env_vars: Option<Map<string, Option<string>>>
      ///Whether to fail open when the deployment config cannot be applied.
      fail_open: Option<bool>
      ///Hyperdrive bindings used for Pages Functions.
      hyperdrive_bindings: Option<Map<string, Option<string>>>
      ///KV namespaces used for Pages Functions.
      kv_namespaces: Option<Map<string, Option<string>>>
      ///Limits for Pages Functions.
      limits: Option<pagesdeploymentconfigvaluesrequestLimits>
      ///mTLS bindings used for Pages Functions.
      mtls_certificates: Option<Map<string, Option<string>>>
      ///Placement setting used for Pages Functions.
      placement: Option<pagesdeploymentconfigvaluesrequestPlacement>
      ///Queue Producer bindings used for Pages Functions.
      queue_producers: Option<Map<string, Option<string>>>
      ///R2 buckets used for Pages Functions.
      r2_buckets: Option<Map<string, Option<string>>>
      ///Services used for Pages Functions.
      services: Option<Map<string, Option<string>>>
      ///Vectorize bindings used for Pages Functions.
      vectorize_bindings: Option<Map<string, Option<string>>>
      ///Hash of the Wrangler configuration used for the deployment.
      wrangler_config_hash: Option<string> }
    ///Creates an instance of pagesdeploymentconfigvaluesrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): pagesdeploymentconfigvaluesrequest =
        { ai_bindings = None
          always_use_latest_compatibility_date = None
          analytics_engine_datasets = None
          browsers = None
          build_image_major_version = None
          compatibility_date = None
          compatibility_flags = None
          d1_databases = None
          durable_object_namespaces = None
          env_vars = None
          fail_open = None
          hyperdrive_bindings = None
          kv_namespaces = None
          limits = None
          mtls_certificates = None
          placement = None
          queue_producers = None
          r2_buckets = None
          services = None
          vectorize_bindings = None
          wrangler_config_hash = None }

type Data =
    { line: string
      ts: string }
    ///Creates an instance of Data with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (line: string, ts: string): Data = { line = line; ts = ts }

type pagesdeploymentlog =
    { data: list<Data>
      includes_container_logs: bool
      total: int }
    ///Creates an instance of pagesdeploymentlog with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data: list<Data>, includes_container_logs: bool, total: int): pagesdeploymentlog =
        { data = data
          includes_container_logs = includes_container_logs
          total = total }

///Additional info about the trigger.
type pagesdeploymentsDeploymenttriggerMetadata =
    { ///Where the trigger happened.
      branch: string
      ///Whether the deployment trigger commit was dirty.
      commit_dirty: bool
      ///Hash of the deployment trigger commit.
      commit_hash: string
      ///Message of the deployment trigger commit.
      commit_message: string }
    ///Creates an instance of pagesdeploymentsDeploymenttriggerMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (branch: string, commit_dirty: bool, commit_hash: string, commit_message: string): pagesdeploymentsDeploymenttriggerMetadata =
        { branch = branch
          commit_dirty = commit_dirty
          commit_hash = commit_hash
          commit_message = commit_message }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type pagesdeploymentsDeploymenttriggerType =
    | [<CompiledName "github:push">] ``Github:push``
    | [<CompiledName "ad_hoc">] Ad_hoc
    | [<CompiledName "deploy_hook">] Deploy_hook
    member this.Format() =
        match this with
        | ``Github:push`` -> "github:push"
        | Ad_hoc -> "ad_hoc"
        | Deploy_hook -> "deploy_hook"

///Info about what caused the deployment.
type pagesdeploymentsDeploymenttrigger =
    { ///Additional info about the trigger.
      metadata: pagesdeploymentsDeploymenttriggerMetadata
      ///What caused the deployment.
      ``type``: pagesdeploymentsDeploymenttriggerType }
    ///Creates an instance of pagesdeploymentsDeploymenttrigger with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (metadata: pagesdeploymentsDeploymenttriggerMetadata,
                          ``type``: pagesdeploymentsDeploymenttriggerType): pagesdeploymentsDeploymenttrigger =
        { metadata = metadata
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type pagesdeploymentsEnvironment =
    | [<CompiledName "preview">] Preview
    | [<CompiledName "production">] Production
    member this.Format() =
        match this with
        | Preview -> "preview"
        | Production -> "production"

type pagesdeployments =
    { ///A list of alias URLs pointing to this deployment.
      aliases: list<string>
      ///Configs for the project build process.
      build_config: pagesbuildconfig
      ///When the deployment was created.
      created_on: System.DateTimeOffset
      ///Info about what caused the deployment.
      deployment_trigger: pagesdeploymentsDeploymenttrigger
      ///Environment variables used for builds and Pages Functions.
      env_vars: Map<string, Option<string>>
      ///Type of deploy.
      environment: pagesdeploymentsEnvironment
      ///Id of the deployment.
      id: string
      ///If the deployment has been skipped.
      is_skipped: bool
      ///The status of the deployment.
      latest_stage: pagesstage
      ///When the deployment was last modified.
      modified_on: System.DateTimeOffset
      ///Id of the project.
      project_id: string
      ///Name of the project.
      project_name: pagesprojectname
      ///Short Id (8 character) of the deployment.
      short_id: string
      ///Configs for the project source control.
      source: pagessource
      ///List of past stages.
      stages: list<pagesstage>
      ///The live URL to view this deployment.
      url: string
      ///Whether the deployment uses functions.
      uses_functions: Option<bool> }
    ///Creates an instance of pagesdeployments with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (aliases: list<string>,
                          build_config: pagesbuildconfig,
                          created_on: System.DateTimeOffset,
                          deployment_trigger: pagesdeploymentsDeploymenttrigger,
                          env_vars: Map<string, Option<string>>,
                          environment: pagesdeploymentsEnvironment,
                          id: string,
                          is_skipped: bool,
                          latest_stage: pagesstage,
                          modified_on: System.DateTimeOffset,
                          project_id: string,
                          project_name: pagesprojectname,
                          short_id: string,
                          source: pagessource,
                          stages: list<pagesstage>,
                          url: string): pagesdeployments =
        { aliases = aliases
          build_config = build_config
          created_on = created_on
          deployment_trigger = deployment_trigger
          env_vars = env_vars
          environment = environment
          id = id
          is_skipped = is_skipped
          latest_stage = latest_stage
          modified_on = modified_on
          project_id = project_id
          project_name = project_name
          short_id = short_id
          source = source
          stages = stages
          url = url
          uses_functions = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Certificateauthority =
    | [<CompiledName "google">] Google
    | [<CompiledName "lets_encrypt">] Lets_encrypt
    member this.Format() =
        match this with
        | Google -> "google"
        | Lets_encrypt -> "lets_encrypt"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "initializing">] Initializing
    | [<CompiledName "pending">] Pending
    | [<CompiledName "active">] Active
    | [<CompiledName "deactivated">] Deactivated
    | [<CompiledName "blocked">] Blocked
    | [<CompiledName "error">] Error
    member this.Format() =
        match this with
        | Initializing -> "initializing"
        | Pending -> "pending"
        | Active -> "active"
        | Deactivated -> "deactivated"
        | Blocked -> "blocked"
        | Error -> "error"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Method =
    | [<CompiledName "http">] Http
    | [<CompiledName "txt">] Txt
    member this.Format() =
        match this with
        | Http -> "http"
        | Txt -> "txt"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ValidationdataStatus =
    | [<CompiledName "initializing">] Initializing
    | [<CompiledName "pending">] Pending
    | [<CompiledName "active">] Active
    | [<CompiledName "deactivated">] Deactivated
    | [<CompiledName "error">] Error
    member this.Format() =
        match this with
        | Initializing -> "initializing"
        | Pending -> "pending"
        | Active -> "active"
        | Deactivated -> "deactivated"
        | Error -> "error"

type Validationdata =
    { error_message: Option<string>
      method: Method
      status: ValidationdataStatus
      txt_name: Option<string>
      txt_value: Option<string> }
    ///Creates an instance of Validationdata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (method: Method, status: ValidationdataStatus): Validationdata =
        { error_message = None
          method = method
          status = status
          txt_name = None
          txt_value = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VerificationdataStatus =
    | [<CompiledName "pending">] Pending
    | [<CompiledName "active">] Active
    | [<CompiledName "deactivated">] Deactivated
    | [<CompiledName "blocked">] Blocked
    | [<CompiledName "error">] Error
    member this.Format() =
        match this with
        | Pending -> "pending"
        | Active -> "active"
        | Deactivated -> "deactivated"
        | Blocked -> "blocked"
        | Error -> "error"

type Verificationdata =
    { error_message: Option<string>
      status: VerificationdataStatus }
    ///Creates an instance of Verificationdata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (status: VerificationdataStatus): Verificationdata =
        { error_message = None
          status = status }

type pagesdomain =
    { certificate_authority: Certificateauthority
      created_on: string
      domain_id: string
      id: string
      ///The domain name.
      name: pagesdomainname
      status: Status
      validation_data: Validationdata
      verification_data: Verificationdata
      zone_tag: string }
    ///Creates an instance of pagesdomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (certificate_authority: Certificateauthority,
                          created_on: string,
                          domain_id: string,
                          id: string,
                          name: pagesdomainname,
                          status: Status,
                          validation_data: Validationdata,
                          verification_data: Verificationdata,
                          zone_tag: string): pagesdomain =
        { certificate_authority = certificate_authority
          created_on = created_on
          domain_id = domain_id
          id = id
          name = name
          status = status
          validation_data = validation_data
          verification_data = verification_data
          zone_tag = zone_tag }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type pagesplaintextenvvarType =
    | [<CompiledName "plain_text">] Plain_text
    member this.Format() =
        match this with
        | Plain_text -> "plain_text"

///A plaintext environment variable.
type pagesplaintextenvvar =
    { ``type``: pagesplaintextenvvarType
      ///Environment variable value.
      value: string }
    ///Creates an instance of pagesplaintextenvvar with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: pagesplaintextenvvarType, value: string): pagesplaintextenvvar =
        { ``type`` = ``type``; value = value }

///Configs for deployments in a project.
type Deploymentconfigs =
    { ///Configs for preview deploys.
      preview: Newtonsoft.Json.Linq.JToken
      ///Configs for production deploys.
      production: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of Deploymentconfigs with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (preview: Newtonsoft.Json.Linq.JToken, production: Newtonsoft.Json.Linq.JToken): Deploymentconfigs =
        { preview = preview
          production = production }

type pagesproject =
    { ///Configs for the project build process.
      build_config: Option<pagesbuildconfig>
      canonical_deployment: Newtonsoft.Json.Linq.JToken
      ///When the project was created.
      created_on: System.DateTimeOffset
      ///Configs for deployments in a project.
      deployment_configs: Deploymentconfigs
      ///A list of associated custom domains for the project.
      domains: Option<list<string>>
      ///Framework the project is using.
      framework: string
      ///Version of the framework the project is using.
      framework_version: string
      ///ID of the project.
      id: string
      latest_deployment: Newtonsoft.Json.Linq.JToken
      ///Name of the project.
      name: pagesprojectname
      ///Name of the preview script.
      preview_script_name: string
      ///Production branch of the project. Used to identify production deployments.
      production_branch: string
      ///Name of the production script.
      production_script_name: string
      ///Configs for the project source control.
      source: Option<pagessource>
      ///The Cloudflare subdomain associated with the project.
      subdomain: Option<string>
      ///Whether the project uses functions.
      uses_functions: bool }
    ///Creates an instance of pagesproject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (canonical_deployment: Newtonsoft.Json.Linq.JToken,
                          created_on: System.DateTimeOffset,
                          deployment_configs: Deploymentconfigs,
                          framework: string,
                          framework_version: string,
                          id: string,
                          latest_deployment: Newtonsoft.Json.Linq.JToken,
                          name: pagesprojectname,
                          preview_script_name: string,
                          production_branch: string,
                          production_script_name: string,
                          uses_functions: bool): pagesproject =
        { build_config = None
          canonical_deployment = canonical_deployment
          created_on = created_on
          deployment_configs = deployment_configs
          domains = None
          framework = framework
          framework_version = framework_version
          id = id
          latest_deployment = latest_deployment
          name = name
          preview_script_name = preview_script_name
          production_branch = production_branch
          production_script_name = production_script_name
          source = None
          subdomain = None
          uses_functions = uses_functions }

///Configs for deployments in a project.
type ``pagesproject-objectDeploymentconfigs`` =
    { ///Configs for preview deploys.
      preview: Newtonsoft.Json.Linq.JToken
      ///Configs for production deploys.
      production: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of pagesproject-objectDeploymentconfigs with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (preview: Newtonsoft.Json.Linq.JToken, production: Newtonsoft.Json.Linq.JToken): ``pagesproject-objectDeploymentconfigs`` =
        { preview = preview
          production = production }

type ``pagesproject-object`` =
    { ///Configs for the project build process.
      build_config: Option<pagesbuildconfig>
      canonical_deployment: Newtonsoft.Json.Linq.JToken
      ///When the project was created.
      created_on: System.DateTimeOffset
      ///Configs for deployments in a project.
      deployment_configs: ``pagesproject-objectDeploymentconfigs``
      ///A list of associated custom domains for the project.
      domains: Option<list<string>>
      ///Framework the project is using.
      framework: string
      ///Version of the framework the project is using.
      framework_version: string
      ///ID of the project.
      id: string
      latest_deployment: Newtonsoft.Json.Linq.JToken
      ///Name of the project.
      name: pagesprojectname
      ///Name of the preview script.
      preview_script_name: string
      ///Production branch of the project. Used to identify production deployments.
      production_branch: string
      ///Name of the production script.
      production_script_name: string
      ///Configs for the project source control.
      source: Option<pagessource>
      ///The Cloudflare subdomain associated with the project.
      subdomain: Option<string>
      ///Whether the project uses functions.
      uses_functions: bool }
    ///Creates an instance of pagesproject-object with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (canonical_deployment: Newtonsoft.Json.Linq.JToken,
                          created_on: System.DateTimeOffset,
                          deployment_configs: ``pagesproject-objectDeploymentconfigs``,
                          framework: string,
                          framework_version: string,
                          id: string,
                          latest_deployment: Newtonsoft.Json.Linq.JToken,
                          name: pagesprojectname,
                          preview_script_name: string,
                          production_branch: string,
                          production_script_name: string,
                          uses_functions: bool): ``pagesproject-object`` =
        { build_config = None
          canonical_deployment = canonical_deployment
          created_on = created_on
          deployment_configs = deployment_configs
          domains = None
          framework = framework
          framework_version = framework_version
          id = id
          latest_deployment = latest_deployment
          name = name
          preview_script_name = preview_script_name
          production_branch = production_branch
          production_script_name = production_script_name
          source = None
          subdomain = None
          uses_functions = uses_functions }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type pagessecrettextenvvarType =
    | [<CompiledName "secret_text">] Secret_text
    member this.Format() =
        match this with
        | Secret_text -> "secret_text"

///An encrypted environment variable.
type pagessecrettextenvvar =
    { ``type``: pagessecrettextenvvarType
      ///Secret value.
      value: string }
    ///Creates an instance of pagessecrettextenvvar with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: pagessecrettextenvvarType, value: string): pagessecrettextenvvar =
        { ``type`` = ``type``; value = value }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Previewdeploymentsetting =
    | [<CompiledName "all">] All
    | [<CompiledName "none">] None
    | [<CompiledName "custom">] Custom
    member this.Format() =
        match this with
        | All -> "all"
        | None -> "none"
        | Custom -> "custom"

type Config =
    { ///The owner of the repository.
      owner: string
      ///The owner ID of the repository.
      owner_id: string
      ///A list of paths that should be excluded from triggering a preview deployment. Wildcard syntax (`*`) is supported.
      path_excludes: list<string>
      ///A list of paths that should be watched to trigger a preview deployment. Wildcard syntax (`*`) is supported.
      path_includes: list<string>
      ///Whether to enable PR comments.
      pr_comments_enabled: bool
      ///A list of branches that should not trigger a preview deployment. Wildcard syntax (`*`) is supported. Must be used with `preview_deployment_setting` set to `custom`.
      preview_branch_excludes: list<string>
      ///A list of branches that should trigger a preview deployment. Wildcard syntax (`*`) is supported. Must be used with `preview_deployment_setting` set to `custom`.
      preview_branch_includes: list<string>
      ///Controls whether commits to preview branches trigger a preview deployment.
      preview_deployment_setting: Previewdeploymentsetting
      ///The production branch of the repository.
      production_branch: string
      ///Whether to trigger a production deployment on commits to the production branch.
      production_deployments_enabled: bool
      ///The ID of the repository.
      repo_id: string
      ///The name of the repository.
      repo_name: string }
    ///Creates an instance of Config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (owner: string,
                          owner_id: string,
                          path_excludes: list<string>,
                          path_includes: list<string>,
                          pr_comments_enabled: bool,
                          preview_branch_excludes: list<string>,
                          preview_branch_includes: list<string>,
                          preview_deployment_setting: Previewdeploymentsetting,
                          production_branch: string,
                          production_deployments_enabled: bool,
                          repo_id: string,
                          repo_name: string): Config =
        { owner = owner
          owner_id = owner_id
          path_excludes = path_excludes
          path_includes = path_includes
          pr_comments_enabled = pr_comments_enabled
          preview_branch_excludes = preview_branch_excludes
          preview_branch_includes = preview_branch_includes
          preview_deployment_setting = preview_deployment_setting
          production_branch = production_branch
          production_deployments_enabled = production_deployments_enabled
          repo_id = repo_id
          repo_name = repo_name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type pagessourceType =
    | [<CompiledName "github">] Github
    | [<CompiledName "gitlab">] Gitlab
    member this.Format() =
        match this with
        | Github -> "github"
        | Gitlab -> "gitlab"

///Configs for the project source control.
type pagessource =
    { config: Config
      ///The source control management provider.
      ``type``: pagessourceType }
    ///Creates an instance of pagessource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (config: Config, ``type``: pagessourceType): pagessource =
        { config = config; ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Name =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "initialize">] Initialize
    | [<CompiledName "clone_repo">] Clone_repo
    | [<CompiledName "build">] Build
    | [<CompiledName "deploy">] Deploy
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Initialize -> "initialize"
        | Clone_repo -> "clone_repo"
        | Build -> "build"
        | Deploy -> "deploy"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type pagesstageStatus =
    | [<CompiledName "success">] Success
    | [<CompiledName "idle">] Idle
    | [<CompiledName "active">] Active
    | [<CompiledName "failure">] Failure
    | [<CompiledName "canceled">] Canceled
    member this.Format() =
        match this with
        | Success -> "success"
        | Idle -> "idle"
        | Active -> "active"
        | Failure -> "failure"
        | Canceled -> "canceled"

///The status of the deployment.
type pagesstage =
    { ///When the stage ended.
      ended_on: System.DateTimeOffset
      ///The current build stage.
      name: Name
      ///When the stage started.
      started_on: System.DateTimeOffset
      ///State of the current stage.
      status: pagesstageStatus }
    ///Creates an instance of pagesstage with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ended_on: System.DateTimeOffset,
                          name: Name,
                          started_on: System.DateTimeOffset,
                          status: pagesstageStatus): pagesstage =
        { ended_on = ended_on
          name = name
          started_on = started_on
          status = status }

type ``pages-project-get-projectsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-get-projectsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-get-projectsresponseErrorsSource`` = { pointer = None }

type ``pages-project-get-projectsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-get-projectsresponseErrorsSource``> }
    ///Creates an instance of pages-project-get-projectsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-get-projectsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-get-projectsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-get-projectsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-get-projectsresponseMessagesSource`` = { pointer = None }

type ``pages-project-get-projectsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-get-projectsresponseMessagesSource``> }
    ///Creates an instance of pages-project-get-projectsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-get-projectsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-get-projectsresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of pages-project-get-projectsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-get-projectsresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``pages-project-get-projectsresponse`` =
    { errors: list<``pages-project-get-projectsresponseErrors``>
      messages: list<``pages-project-get-projectsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``pages-project-get-projectsresponseResultinfo``>
      result: list<pagesproject> }
    ///Creates an instance of pages-project-get-projectsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-project-get-projectsresponseErrors``>,
                          messages: list<``pages-project-get-projectsresponseMessages``>,
                          success: bool,
                          result: list<pagesproject>): ``pages-project-get-projectsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = result }

type ``pages-project-create-projectresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-create-projectresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-create-projectresponseErrorsSource`` = { pointer = None }

type ``pages-project-create-projectresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-create-projectresponseErrorsSource``> }
    ///Creates an instance of pages-project-create-projectresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-create-projectresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-create-projectresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-create-projectresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-create-projectresponseMessagesSource`` = { pointer = None }

type ``pages-project-create-projectresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-create-projectresponseMessagesSource``> }
    ///Creates an instance of pages-project-create-projectresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-create-projectresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-create-projectresponse`` =
    { errors: list<``pages-project-create-projectresponseErrors``>
      messages: list<``pages-project-create-projectresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesproject }
    ///Creates an instance of pages-project-create-projectresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-project-create-projectresponseErrors``>,
                          messages: list<``pages-project-create-projectresponseMessages``>,
                          success: bool,
                          result: pagesproject): ``pages-project-create-projectresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-project-delete-projectresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-delete-projectresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-delete-projectresponseErrorsSource`` = { pointer = None }

type ``pages-project-delete-projectresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-delete-projectresponseErrorsSource``> }
    ///Creates an instance of pages-project-delete-projectresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-delete-projectresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-delete-projectresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-delete-projectresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-delete-projectresponseMessagesSource`` = { pointer = None }

type ``pages-project-delete-projectresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-delete-projectresponseMessagesSource``> }
    ///Creates an instance of pages-project-delete-projectresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-delete-projectresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-delete-projectresponse`` =
    { errors: list<``pages-project-delete-projectresponseErrors``>
      messages: list<``pages-project-delete-projectresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Newtonsoft.Json.Linq.JObject }
    ///Creates an instance of pages-project-delete-projectresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-project-delete-projectresponseErrors``>,
                          messages: list<``pages-project-delete-projectresponseMessages``>,
                          success: bool,
                          result: Newtonsoft.Json.Linq.JObject): ``pages-project-delete-projectresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-project-get-projectresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-get-projectresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-get-projectresponseErrorsSource`` = { pointer = None }

type ``pages-project-get-projectresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-get-projectresponseErrorsSource``> }
    ///Creates an instance of pages-project-get-projectresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-get-projectresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-get-projectresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-get-projectresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-get-projectresponseMessagesSource`` = { pointer = None }

type ``pages-project-get-projectresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-get-projectresponseMessagesSource``> }
    ///Creates an instance of pages-project-get-projectresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-get-projectresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-get-projectresponse`` =
    { errors: list<``pages-project-get-projectresponseErrors``>
      messages: list<``pages-project-get-projectresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesproject }
    ///Creates an instance of pages-project-get-projectresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-project-get-projectresponseErrors``>,
                          messages: list<``pages-project-get-projectresponseMessages``>,
                          success: bool,
                          result: pagesproject): ``pages-project-get-projectresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-project-update-projectresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-update-projectresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-update-projectresponseErrorsSource`` = { pointer = None }

type ``pages-project-update-projectresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-update-projectresponseErrorsSource``> }
    ///Creates an instance of pages-project-update-projectresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-update-projectresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-update-projectresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-project-update-projectresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-project-update-projectresponseMessagesSource`` = { pointer = None }

type ``pages-project-update-projectresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-project-update-projectresponseMessagesSource``> }
    ///Creates an instance of pages-project-update-projectresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-project-update-projectresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-project-update-projectresponse`` =
    { errors: list<``pages-project-update-projectresponseErrors``>
      messages: list<``pages-project-update-projectresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesproject }
    ///Creates an instance of pages-project-update-projectresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-project-update-projectresponseErrors``>,
                          messages: list<``pages-project-update-projectresponseMessages``>,
                          success: bool,
                          result: pagesproject): ``pages-project-update-projectresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-deployment-get-deploymentsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-get-deploymentsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-get-deploymentsresponseErrorsSource`` = { pointer = None }

type ``pages-deployment-get-deploymentsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-get-deploymentsresponseErrorsSource``> }
    ///Creates an instance of pages-deployment-get-deploymentsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-get-deploymentsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-get-deploymentsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-get-deploymentsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-get-deploymentsresponseMessagesSource`` = { pointer = None }

type ``pages-deployment-get-deploymentsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-get-deploymentsresponseMessagesSource``> }
    ///Creates an instance of pages-deployment-get-deploymentsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-get-deploymentsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-get-deploymentsresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of pages-deployment-get-deploymentsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-get-deploymentsresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``pages-deployment-get-deploymentsresponse`` =
    { errors: list<``pages-deployment-get-deploymentsresponseErrors``>
      messages: list<``pages-deployment-get-deploymentsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``pages-deployment-get-deploymentsresponseResultinfo``>
      result: list<pagesdeployment> }
    ///Creates an instance of pages-deployment-get-deploymentsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-deployment-get-deploymentsresponseErrors``>,
                          messages: list<``pages-deployment-get-deploymentsresponseMessages``>,
                          success: bool,
                          result: list<pagesdeployment>): ``pages-deployment-get-deploymentsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = result }

type ``pages-deployment-create-deploymentresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-create-deploymentresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-create-deploymentresponseErrorsSource`` = { pointer = None }

type ``pages-deployment-create-deploymentresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-create-deploymentresponseErrorsSource``> }
    ///Creates an instance of pages-deployment-create-deploymentresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-create-deploymentresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-create-deploymentresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-create-deploymentresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-create-deploymentresponseMessagesSource`` = { pointer = None }

type ``pages-deployment-create-deploymentresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-create-deploymentresponseMessagesSource``> }
    ///Creates an instance of pages-deployment-create-deploymentresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-create-deploymentresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-create-deploymentresponse`` =
    { errors: list<``pages-deployment-create-deploymentresponseErrors``>
      messages: list<``pages-deployment-create-deploymentresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesdeployment }
    ///Creates an instance of pages-deployment-create-deploymentresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-deployment-create-deploymentresponseErrors``>,
                          messages: list<``pages-deployment-create-deploymentresponseMessages``>,
                          success: bool,
                          result: pagesdeployment): ``pages-deployment-create-deploymentresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-deployment-delete-deploymentresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-delete-deploymentresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-delete-deploymentresponseErrorsSource`` = { pointer = None }

type ``pages-deployment-delete-deploymentresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-delete-deploymentresponseErrorsSource``> }
    ///Creates an instance of pages-deployment-delete-deploymentresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-delete-deploymentresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-delete-deploymentresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-delete-deploymentresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-delete-deploymentresponseMessagesSource`` = { pointer = None }

type ``pages-deployment-delete-deploymentresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-delete-deploymentresponseMessagesSource``> }
    ///Creates an instance of pages-deployment-delete-deploymentresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-delete-deploymentresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-delete-deploymentresponse`` =
    { errors: list<``pages-deployment-delete-deploymentresponseErrors``>
      messages: list<``pages-deployment-delete-deploymentresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Newtonsoft.Json.Linq.JObject }
    ///Creates an instance of pages-deployment-delete-deploymentresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-deployment-delete-deploymentresponseErrors``>,
                          messages: list<``pages-deployment-delete-deploymentresponseMessages``>,
                          success: bool,
                          result: Newtonsoft.Json.Linq.JObject): ``pages-deployment-delete-deploymentresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-deployment-get-deployment-inforesponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-get-deployment-inforesponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-get-deployment-inforesponseErrorsSource`` = { pointer = None }

type ``pages-deployment-get-deployment-inforesponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-get-deployment-inforesponseErrorsSource``> }
    ///Creates an instance of pages-deployment-get-deployment-inforesponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-get-deployment-inforesponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-get-deployment-inforesponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-get-deployment-inforesponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-get-deployment-inforesponseMessagesSource`` = { pointer = None }

type ``pages-deployment-get-deployment-inforesponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-get-deployment-inforesponseMessagesSource``> }
    ///Creates an instance of pages-deployment-get-deployment-inforesponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-get-deployment-inforesponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-get-deployment-inforesponse`` =
    { errors: list<``pages-deployment-get-deployment-inforesponseErrors``>
      messages: list<``pages-deployment-get-deployment-inforesponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesdeployment }
    ///Creates an instance of pages-deployment-get-deployment-inforesponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-deployment-get-deployment-inforesponseErrors``>,
                          messages: list<``pages-deployment-get-deployment-inforesponseMessages``>,
                          success: bool,
                          result: pagesdeployment): ``pages-deployment-get-deployment-inforesponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-deployment-get-deployment-logsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-get-deployment-logsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-get-deployment-logsresponseErrorsSource`` = { pointer = None }

type ``pages-deployment-get-deployment-logsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-get-deployment-logsresponseErrorsSource``> }
    ///Creates an instance of pages-deployment-get-deployment-logsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-get-deployment-logsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-get-deployment-logsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-get-deployment-logsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-get-deployment-logsresponseMessagesSource`` = { pointer = None }

type ``pages-deployment-get-deployment-logsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-get-deployment-logsresponseMessagesSource``> }
    ///Creates an instance of pages-deployment-get-deployment-logsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-get-deployment-logsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-get-deployment-logsresponse`` =
    { errors: list<``pages-deployment-get-deployment-logsresponseErrors``>
      messages: list<``pages-deployment-get-deployment-logsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesdeploymentlog }
    ///Creates an instance of pages-deployment-get-deployment-logsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-deployment-get-deployment-logsresponseErrors``>,
                          messages: list<``pages-deployment-get-deployment-logsresponseMessages``>,
                          success: bool,
                          result: pagesdeploymentlog): ``pages-deployment-get-deployment-logsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-deployment-retry-deploymentresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-retry-deploymentresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-retry-deploymentresponseErrorsSource`` = { pointer = None }

type ``pages-deployment-retry-deploymentresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-retry-deploymentresponseErrorsSource``> }
    ///Creates an instance of pages-deployment-retry-deploymentresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-retry-deploymentresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-retry-deploymentresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-retry-deploymentresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-retry-deploymentresponseMessagesSource`` = { pointer = None }

type ``pages-deployment-retry-deploymentresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-retry-deploymentresponseMessagesSource``> }
    ///Creates an instance of pages-deployment-retry-deploymentresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-retry-deploymentresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-retry-deploymentresponse`` =
    { errors: list<``pages-deployment-retry-deploymentresponseErrors``>
      messages: list<``pages-deployment-retry-deploymentresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesdeployment }
    ///Creates an instance of pages-deployment-retry-deploymentresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-deployment-retry-deploymentresponseErrors``>,
                          messages: list<``pages-deployment-retry-deploymentresponseMessages``>,
                          success: bool,
                          result: pagesdeployment): ``pages-deployment-retry-deploymentresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-deployment-rollback-deploymentresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-rollback-deploymentresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-rollback-deploymentresponseErrorsSource`` = { pointer = None }

type ``pages-deployment-rollback-deploymentresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-rollback-deploymentresponseErrorsSource``> }
    ///Creates an instance of pages-deployment-rollback-deploymentresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-rollback-deploymentresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-rollback-deploymentresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-deployment-rollback-deploymentresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-deployment-rollback-deploymentresponseMessagesSource`` = { pointer = None }

type ``pages-deployment-rollback-deploymentresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-deployment-rollback-deploymentresponseMessagesSource``> }
    ///Creates an instance of pages-deployment-rollback-deploymentresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-deployment-rollback-deploymentresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-deployment-rollback-deploymentresponse`` =
    { errors: list<``pages-deployment-rollback-deploymentresponseErrors``>
      messages: list<``pages-deployment-rollback-deploymentresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesdeployment }
    ///Creates an instance of pages-deployment-rollback-deploymentresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-deployment-rollback-deploymentresponseErrors``>,
                          messages: list<``pages-deployment-rollback-deploymentresponseMessages``>,
                          success: bool,
                          result: pagesdeployment): ``pages-deployment-rollback-deploymentresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-domains-get-domainsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-get-domainsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-get-domainsresponseErrorsSource`` = { pointer = None }

type ``pages-domains-get-domainsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-get-domainsresponseErrorsSource``> }
    ///Creates an instance of pages-domains-get-domainsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-get-domainsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-get-domainsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-get-domainsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-get-domainsresponseMessagesSource`` = { pointer = None }

type ``pages-domains-get-domainsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-get-domainsresponseMessagesSource``> }
    ///Creates an instance of pages-domains-get-domainsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-get-domainsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-get-domainsresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of pages-domains-get-domainsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-get-domainsresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``pages-domains-get-domainsresponse`` =
    { errors: list<``pages-domains-get-domainsresponseErrors``>
      messages: list<``pages-domains-get-domainsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``pages-domains-get-domainsresponseResultinfo``>
      result: list<pagesdomain> }
    ///Creates an instance of pages-domains-get-domainsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-domains-get-domainsresponseErrors``>,
                          messages: list<``pages-domains-get-domainsresponseMessages``>,
                          success: bool,
                          result: list<pagesdomain>): ``pages-domains-get-domainsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = result }

type ``pages-domains-add-domainresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-add-domainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-add-domainresponseErrorsSource`` = { pointer = None }

type ``pages-domains-add-domainresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-add-domainresponseErrorsSource``> }
    ///Creates an instance of pages-domains-add-domainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-add-domainresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-add-domainresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-add-domainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-add-domainresponseMessagesSource`` = { pointer = None }

type ``pages-domains-add-domainresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-add-domainresponseMessagesSource``> }
    ///Creates an instance of pages-domains-add-domainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-add-domainresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-add-domainresponse`` =
    { errors: list<``pages-domains-add-domainresponseErrors``>
      messages: list<``pages-domains-add-domainresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesdomain }
    ///Creates an instance of pages-domains-add-domainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-domains-add-domainresponseErrors``>,
                          messages: list<``pages-domains-add-domainresponseMessages``>,
                          success: bool,
                          result: pagesdomain): ``pages-domains-add-domainresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-domains-delete-domainresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-delete-domainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-delete-domainresponseErrorsSource`` = { pointer = None }

type ``pages-domains-delete-domainresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-delete-domainresponseErrorsSource``> }
    ///Creates an instance of pages-domains-delete-domainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-delete-domainresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-delete-domainresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-delete-domainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-delete-domainresponseMessagesSource`` = { pointer = None }

type ``pages-domains-delete-domainresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-delete-domainresponseMessagesSource``> }
    ///Creates an instance of pages-domains-delete-domainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-delete-domainresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-delete-domainresponse`` =
    { errors: list<``pages-domains-delete-domainresponseErrors``>
      messages: list<``pages-domains-delete-domainresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Newtonsoft.Json.Linq.JObject }
    ///Creates an instance of pages-domains-delete-domainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-domains-delete-domainresponseErrors``>,
                          messages: list<``pages-domains-delete-domainresponseMessages``>,
                          success: bool,
                          result: Newtonsoft.Json.Linq.JObject): ``pages-domains-delete-domainresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-domains-get-domainresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-get-domainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-get-domainresponseErrorsSource`` = { pointer = None }

type ``pages-domains-get-domainresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-get-domainresponseErrorsSource``> }
    ///Creates an instance of pages-domains-get-domainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-get-domainresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-get-domainresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-get-domainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-get-domainresponseMessagesSource`` = { pointer = None }

type ``pages-domains-get-domainresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-get-domainresponseMessagesSource``> }
    ///Creates an instance of pages-domains-get-domainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-get-domainresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-get-domainresponse`` =
    { errors: list<``pages-domains-get-domainresponseErrors``>
      messages: list<``pages-domains-get-domainresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesdomain }
    ///Creates an instance of pages-domains-get-domainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-domains-get-domainresponseErrors``>,
                          messages: list<``pages-domains-get-domainresponseMessages``>,
                          success: bool,
                          result: pagesdomain): ``pages-domains-get-domainresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-domains-patch-domainresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-patch-domainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-patch-domainresponseErrorsSource`` = { pointer = None }

type ``pages-domains-patch-domainresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-patch-domainresponseErrorsSource``> }
    ///Creates an instance of pages-domains-patch-domainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-patch-domainresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-patch-domainresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-domains-patch-domainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-domains-patch-domainresponseMessagesSource`` = { pointer = None }

type ``pages-domains-patch-domainresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-domains-patch-domainresponseMessagesSource``> }
    ///Creates an instance of pages-domains-patch-domainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-domains-patch-domainresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-domains-patch-domainresponse`` =
    { errors: list<``pages-domains-patch-domainresponseErrors``>
      messages: list<``pages-domains-patch-domainresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: pagesdomain }
    ///Creates an instance of pages-domains-patch-domainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-domains-patch-domainresponseErrors``>,
                          messages: list<``pages-domains-patch-domainresponseMessages``>,
                          success: bool,
                          result: pagesdomain): ``pages-domains-patch-domainresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

type ``pages-purge-build-cacheresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-purge-build-cacheresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-purge-build-cacheresponseErrorsSource`` = { pointer = None }

type ``pages-purge-build-cacheresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-purge-build-cacheresponseErrorsSource``> }
    ///Creates an instance of pages-purge-build-cacheresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-purge-build-cacheresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-purge-build-cacheresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of pages-purge-build-cacheresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``pages-purge-build-cacheresponseMessagesSource`` = { pointer = None }

type ``pages-purge-build-cacheresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``pages-purge-build-cacheresponseMessagesSource``> }
    ///Creates an instance of pages-purge-build-cacheresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``pages-purge-build-cacheresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``pages-purge-build-cacheresponse`` =
    { errors: list<``pages-purge-build-cacheresponseErrors``>
      messages: list<``pages-purge-build-cacheresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Newtonsoft.Json.Linq.JObject }
    ///Creates an instance of pages-purge-build-cacheresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``pages-purge-build-cacheresponseErrors``>,
                          messages: list<``pages-purge-build-cacheresponseMessages``>,
                          success: bool,
                          result: Newtonsoft.Json.Linq.JObject): ``pages-purge-build-cacheresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = result }

[<RequireQualifiedAccess>]
type PagesProjectGetProjects =
    ///Get projects response.
    | OK of payload: ``pages-project-get-projectsresponse``
    ///Get projects response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

///Configs for the project build process.
type Buildconfig =
    { ///Enable build caching for the project.
      build_caching: Option<bool>
      ///Command used to build project.
      build_command: Option<string>
      ///Output directory of the build.
      destination_dir: Option<string>
      ///Directory to run the command.
      root_dir: Option<string>
      ///The classifying tag for analytics.
      web_analytics_tag: Option<string>
      ///The auth token for analytics.
      web_analytics_token: Option<string> }
    ///Creates an instance of Buildconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Buildconfig =
        { build_caching = None
          build_command = None
          destination_dir = None
          root_dir = None
          web_analytics_tag = None
          web_analytics_token = None }

///Configs for deployments in a project.
type PagesProjectCreateProjectPayloadDeploymentconfigs =
    { ///Configs for preview deploys.
      preview: Option<Newtonsoft.Json.Linq.JToken>
      ///Configs for production deploys.
      production: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of PagesProjectCreateProjectPayloadDeploymentconfigs with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PagesProjectCreateProjectPayloadDeploymentconfigs = { preview = None; production = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PagesProjectCreateProjectPayloadSourceConfigPreviewdeploymentsetting =
    | [<CompiledName "all">] All
    | [<CompiledName "none">] None
    | [<CompiledName "custom">] Custom
    member this.Format() =
        match this with
        | All -> "all"
        | None -> "none"
        | Custom -> "custom"

type PagesProjectCreateProjectPayloadSourceConfig =
    { ///The owner of the repository.
      owner: Option<string>
      ///The owner ID of the repository.
      owner_id: Option<string>
      ///A list of paths that should be excluded from triggering a preview deployment. Wildcard syntax (`*`) is supported.
      path_excludes: Option<list<string>>
      ///A list of paths that should be watched to trigger a preview deployment. Wildcard syntax (`*`) is supported.
      path_includes: Option<list<string>>
      ///Whether to enable PR comments.
      pr_comments_enabled: Option<bool>
      ///A list of branches that should not trigger a preview deployment. Wildcard syntax (`*`) is supported. Must be used with `preview_deployment_setting` set to `custom`.
      preview_branch_excludes: Option<list<string>>
      ///A list of branches that should trigger a preview deployment. Wildcard syntax (`*`) is supported. Must be used with `preview_deployment_setting` set to `custom`.
      preview_branch_includes: Option<list<string>>
      ///Controls whether commits to preview branches trigger a preview deployment.
      preview_deployment_setting: Option<PagesProjectCreateProjectPayloadSourceConfigPreviewdeploymentsetting>
      ///The production branch of the repository.
      production_branch: Option<string>
      ///Whether to trigger a production deployment on commits to the production branch.
      production_deployments_enabled: Option<bool>
      ///The ID of the repository.
      repo_id: Option<string>
      ///The name of the repository.
      repo_name: Option<string> }
    ///Creates an instance of PagesProjectCreateProjectPayloadSourceConfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PagesProjectCreateProjectPayloadSourceConfig =
        { owner = None
          owner_id = None
          path_excludes = None
          path_includes = None
          pr_comments_enabled = None
          preview_branch_excludes = None
          preview_branch_includes = None
          preview_deployment_setting = None
          production_branch = None
          production_deployments_enabled = None
          repo_id = None
          repo_name = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PagesProjectCreateProjectPayloadSourceType =
    | [<CompiledName "github">] Github
    | [<CompiledName "gitlab">] Gitlab
    member this.Format() =
        match this with
        | Github -> "github"
        | Gitlab -> "gitlab"

///Configs for the project source control.
type PagesProjectCreateProjectPayloadSource =
    { config: PagesProjectCreateProjectPayloadSourceConfig
      ///The source control management provider.
      ``type``: PagesProjectCreateProjectPayloadSourceType }
    ///Creates an instance of PagesProjectCreateProjectPayloadSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (config: PagesProjectCreateProjectPayloadSourceConfig,
                          ``type``: PagesProjectCreateProjectPayloadSourceType): PagesProjectCreateProjectPayloadSource =
        { config = config; ``type`` = ``type`` }

type PagesProjectCreateProjectPayload =
    { ///Configs for the project build process.
      build_config: Option<Buildconfig>
      ///Configs for deployments in a project.
      deployment_configs: Option<PagesProjectCreateProjectPayloadDeploymentconfigs>
      ///Name of the project.
      name: string
      ///Production branch of the project. Used to identify production deployments.
      production_branch: string
      ///Configs for the project source control.
      source: Option<PagesProjectCreateProjectPayloadSource> }
    ///Creates an instance of PagesProjectCreateProjectPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, production_branch: string): PagesProjectCreateProjectPayload =
        { build_config = None
          deployment_configs = None
          name = name
          production_branch = production_branch
          source = None }

[<RequireQualifiedAccess>]
type PagesProjectCreateProject =
    ///Create project response.
    | OK of payload: ``pages-project-create-projectresponse``
    ///Create project response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesProjectDeleteProject =
    ///Delete project response.
    | OK of payload: ``pages-project-delete-projectresponse``
    ///Delete project response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesProjectGetProject =
    ///Get project response.
    | OK of payload: ``pages-project-get-projectresponse``
    ///Get project response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

///Configs for the project build process.
type PagesProjectUpdateProjectPayloadBuildconfig =
    { ///Enable build caching for the project.
      build_caching: Option<bool>
      ///Command used to build project.
      build_command: Option<string>
      ///Output directory of the build.
      destination_dir: Option<string>
      ///Directory to run the command.
      root_dir: Option<string>
      ///The classifying tag for analytics.
      web_analytics_tag: Option<string>
      ///The auth token for analytics.
      web_analytics_token: Option<string> }
    ///Creates an instance of PagesProjectUpdateProjectPayloadBuildconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PagesProjectUpdateProjectPayloadBuildconfig =
        { build_caching = None
          build_command = None
          destination_dir = None
          root_dir = None
          web_analytics_tag = None
          web_analytics_token = None }

///Configs for deployments in a project.
type PagesProjectUpdateProjectPayloadDeploymentconfigs =
    { ///Configs for preview deploys.
      preview: Option<Newtonsoft.Json.Linq.JToken>
      ///Configs for production deploys.
      production: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of PagesProjectUpdateProjectPayloadDeploymentconfigs with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PagesProjectUpdateProjectPayloadDeploymentconfigs = { preview = None; production = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PagesProjectUpdateProjectPayloadSourceConfigPreviewdeploymentsetting =
    | [<CompiledName "all">] All
    | [<CompiledName "none">] None
    | [<CompiledName "custom">] Custom
    member this.Format() =
        match this with
        | All -> "all"
        | None -> "none"
        | Custom -> "custom"

type PagesProjectUpdateProjectPayloadSourceConfig =
    { ///The owner of the repository.
      owner: Option<string>
      ///The owner ID of the repository.
      owner_id: Option<string>
      ///A list of paths that should be excluded from triggering a preview deployment. Wildcard syntax (`*`) is supported.
      path_excludes: Option<list<string>>
      ///A list of paths that should be watched to trigger a preview deployment. Wildcard syntax (`*`) is supported.
      path_includes: Option<list<string>>
      ///Whether to enable PR comments.
      pr_comments_enabled: Option<bool>
      ///A list of branches that should not trigger a preview deployment. Wildcard syntax (`*`) is supported. Must be used with `preview_deployment_setting` set to `custom`.
      preview_branch_excludes: Option<list<string>>
      ///A list of branches that should trigger a preview deployment. Wildcard syntax (`*`) is supported. Must be used with `preview_deployment_setting` set to `custom`.
      preview_branch_includes: Option<list<string>>
      ///Controls whether commits to preview branches trigger a preview deployment.
      preview_deployment_setting: Option<PagesProjectUpdateProjectPayloadSourceConfigPreviewdeploymentsetting>
      ///The production branch of the repository.
      production_branch: Option<string>
      ///Whether to trigger a production deployment on commits to the production branch.
      production_deployments_enabled: Option<bool>
      ///The ID of the repository.
      repo_id: Option<string>
      ///The name of the repository.
      repo_name: Option<string> }
    ///Creates an instance of PagesProjectUpdateProjectPayloadSourceConfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PagesProjectUpdateProjectPayloadSourceConfig =
        { owner = None
          owner_id = None
          path_excludes = None
          path_includes = None
          pr_comments_enabled = None
          preview_branch_excludes = None
          preview_branch_includes = None
          preview_deployment_setting = None
          production_branch = None
          production_deployments_enabled = None
          repo_id = None
          repo_name = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PagesProjectUpdateProjectPayloadSourceType =
    | [<CompiledName "github">] Github
    | [<CompiledName "gitlab">] Gitlab
    member this.Format() =
        match this with
        | Github -> "github"
        | Gitlab -> "gitlab"

///Configs for the project source control.
type PagesProjectUpdateProjectPayloadSource =
    { config: PagesProjectUpdateProjectPayloadSourceConfig
      ///The source control management provider.
      ``type``: PagesProjectUpdateProjectPayloadSourceType }
    ///Creates an instance of PagesProjectUpdateProjectPayloadSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (config: PagesProjectUpdateProjectPayloadSourceConfig,
                          ``type``: PagesProjectUpdateProjectPayloadSourceType): PagesProjectUpdateProjectPayloadSource =
        { config = config; ``type`` = ``type`` }

type PagesProjectUpdateProjectPayload =
    { ///Configs for the project build process.
      build_config: Option<PagesProjectUpdateProjectPayloadBuildconfig>
      ///Configs for deployments in a project.
      deployment_configs: Option<PagesProjectUpdateProjectPayloadDeploymentconfigs>
      ///Name of the project.
      name: Option<string>
      ///Production branch of the project. Used to identify production deployments.
      production_branch: Option<string>
      ///Configs for the project source control.
      source: Option<PagesProjectUpdateProjectPayloadSource> }
    ///Creates an instance of PagesProjectUpdateProjectPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PagesProjectUpdateProjectPayload =
        { build_config = None
          deployment_configs = None
          name = None
          production_branch = None
          source = None }

[<RequireQualifiedAccess>]
type PagesProjectUpdateProject =
    ///Update project response.
    | OK of payload: ``pages-project-update-projectresponse``
    ///Update project response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDeploymentGetDeployments =
    ///Get deployments response.
    | OK of payload: ``pages-deployment-get-deploymentsresponse``
    ///Get deployments response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Commitdirty =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type PagesDeploymentCreateDeploymentPayload =
    { ///Headers configuration file for the deployment.
      _headers: Option<string>
      ///Redirects configuration file for the deployment.
      _redirects: Option<string>
      ///Routes configuration file defining routing rules.
      ``_routes.json``: Option<string>
      ///Worker bundle file in multipart/form-data format. Mutually exclusive with `_worker.js`.
      ///Cannot specify both `_worker.js` and `_worker.bundle` in the same request.
      ///Maximum size: 25 MiB.
      ``_worker.bundle``: Option<string>
      ///Worker JavaScript file. Mutually exclusive with `_worker.bundle`.
      ///Cannot specify both `_worker.js` and `_worker.bundle` in the same request.
      ``_worker.js``: Option<string>
      ///The branch to build the new deployment from. The `HEAD` of the branch will be used. If omitted, the production branch will be used by default.
      branch: Option<string>
      ///Boolean string indicating if the working directory has uncommitted changes.
      commit_dirty: Option<Commitdirty>
      ///Git commit SHA associated with this deployment.
      commit_hash: Option<string>
      ///Git commit message associated with this deployment.
      commit_message: Option<string>
      ///Functions routing configuration file.
      ``functions-filepath-routing-config.json``: Option<string>
      ///JSON string containing a manifest of files to deploy. Maps file paths to their content hashes.
      ///Required for direct upload deployments. Maximum 20,000 entries.
      manifest: Option<string>
      ///The build output directory path.
      pages_build_output_dir: Option<string>
      ///Hash of the Wrangler configuration file used for this deployment.
      wrangler_config_hash: Option<string> }

[<RequireQualifiedAccess>]
type PagesDeploymentCreateDeployment =
    ///Create deployment response.
    | OK of payload: ``pages-deployment-create-deploymentresponse``
    ///Create deployment response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDeploymentDeleteDeployment =
    ///Delete deployment response.
    | OK of payload: ``pages-deployment-delete-deploymentresponse``
    ///Delete deployment response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDeploymentGetDeploymentInfo =
    ///Get deployment info response.
    | OK of payload: ``pages-deployment-get-deployment-inforesponse``
    ///Get deployment info response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDeploymentGetDeploymentLogs =
    ///Get deployment logs response.
    | OK of payload: ``pages-deployment-get-deployment-logsresponse``
    ///Get deployment logs response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDeploymentRetryDeployment =
    ///Retry deployment response.
    | OK of payload: ``pages-deployment-retry-deploymentresponse``
    ///Retry deployment response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDeploymentRollbackDeployment =
    ///Rollback deployment response.
    | OK of payload: ``pages-deployment-rollback-deploymentresponse``
    ///Rollback deployment response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDomainsGetDomains =
    ///Get domains response.
    | OK of payload: ``pages-domains-get-domainsresponse``
    ///Get domains response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

type PagesDomainsAddDomainPayload =
    { ///The domain name.
      name: pagesdomainname }
    ///Creates an instance of PagesDomainsAddDomainPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: pagesdomainname): PagesDomainsAddDomainPayload = { name = name }

[<RequireQualifiedAccess>]
type PagesDomainsAddDomain =
    ///Add domain response.
    | OK of payload: ``pages-domains-add-domainresponse``
    ///Add domain response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDomainsDeleteDomain =
    ///Delete domain response.
    | OK of payload: ``pages-domains-delete-domainresponse``
    ///Delete domain response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDomainsGetDomain =
    ///Get domain response.
    | OK of payload: ``pages-domains-get-domainresponse``
    ///Get domain response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesDomainsPatchDomain =
    ///Patch domain response.
    | OK of payload: ``pages-domains-patch-domainresponse``
    ///Patch domain response failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``

[<RequireQualifiedAccess>]
type PagesPurgeBuildCache =
    ///Purge build cache response.
    | OK of payload: ``pages-purge-build-cacheresponse``
    ///Purge build cache failure.
    | BadRequest of payload: ``pagesapi-response-common-failure``
