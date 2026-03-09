namespace rec Fidelity.CloudEdge.Management.Queues.Types

// Auto-generated stub types (missing from Hawaii output)
type messages = string
type ``mqconsumer-response`` = string
type mqproducer = string
type queues = string
type seconds = string
type unacknowledged = string

type ``mqapi-v4-errorArrayItem`` =
    { code: int
      message: string }
    ///Creates an instance of mqapi-v4-errorArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``mqapi-v4-errorArrayItem`` = { code = code; message = message }

type ``mqapi-v4-error`` = list<``mqapi-v4-errorArrayItem``>
type ``mqapi-v4-message`` = list<string>
type ``mqbatch-size`` = float
///A Resource identifier.
type mqidentifier = string
///An ID that represents an "in-flight" message that has been pulled from a Queue. You must hold on to this ID and use it to acknowledge this message.
type ``mqlease-id`` = string
type ``mqmax-concurrency`` = float
type ``mqmax-retries`` = float
type ``mqmax-wait-time`` = float
type ``mqqueue-name`` = string

type ``mqqueue-pull-batchArrayItem`` =
    { attempts: Option<float>
      body: Option<string>
      id: Option<string>
      ///An ID that represents an "in-flight" message that has been pulled from a Queue. You must hold on to this ID and use it to acknowledge this message.
      lease_id: Option<``mqlease-id``>
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      timestamp_ms: Option<float> }
    ///Creates an instance of mqqueue-pull-batchArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqqueue-pull-batchArrayItem`` =
        { attempts = None
          body = None
          id = None
          lease_id = None
          metadata = None
          timestamp_ms = None }

type ``mqqueue-pull-batch`` = list<``mqqueue-pull-batchArrayItem``>
type ``mqretry-delay`` = float
///Name of a Worker
type ``mqscript-name`` = string
type ``mqvisibility-timeout`` = float

type Errors =
    { code: int
      message: string }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors = { code = code; message = message }

type ``mqapi-v4-failure`` =
    { errors: Option<list<Errors>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool> }
    ///Creates an instance of mqapi-v4-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqapi-v4-failure`` =
        { errors = None
          messages = None
          success = None }

type ``mqapi-v4-successErrors`` =
    { code: int
      message: string }
    ///Creates an instance of mqapi-v4-successErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``mqapi-v4-successErrors`` = { code = code; message = message }

type ``mqapi-v4-success`` =
    { errors: Option<list<``mqapi-v4-successErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool> }
    ///Creates an instance of mqapi-v4-success with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqapi-v4-success`` =
        { errors = None
          messages = None
          success = None }

type Settings =
    { ///The maximum number of messages to include in a batch.
      batch_size: Option<``mqbatch-size``>
      ///The maximum number of retries
      max_retries: Option<``mqmax-retries``>
      ///The number of seconds to delay before making the message available for another attempt.
      retry_delay: Option<``mqretry-delay``>
      ///The number of milliseconds that a message is exclusively leased. After the timeout, the message becomes available for another attempt.
      visibility_timeout_ms: Option<``mqvisibility-timeout``> }
    ///Creates an instance of Settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Settings =
        { batch_size = None
          max_retries = None
          retry_delay = None
          visibility_timeout_ms = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "http_pull">] Http_pull
    member this.Format() =
        match this with
        | Http_pull -> "http_pull"

type ``mqhttp-consumer-request`` =
    { dead_letter_queue: Option<``mqqueue-name``>
      settings: Option<Settings>
      ``type``: Type }
    ///Creates an instance of mqhttp-consumer-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: Type): ``mqhttp-consumer-request`` =
        { dead_letter_queue = None
          settings = None
          ``type`` = ``type`` }

type ``mqhttp-consumer-responseSettings`` =
    { ///The maximum number of messages to include in a batch.
      batch_size: Option<``mqbatch-size``>
      ///The maximum number of retries
      max_retries: Option<``mqmax-retries``>
      ///The number of seconds to delay before making the message available for another attempt.
      retry_delay: Option<``mqretry-delay``>
      ///The number of milliseconds that a message is exclusively leased. After the timeout, the message becomes available for another attempt.
      visibility_timeout_ms: Option<``mqvisibility-timeout``> }
    ///Creates an instance of mqhttp-consumer-responseSettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqhttp-consumer-responseSettings`` =
        { batch_size = None
          max_retries = None
          retry_delay = None
          visibility_timeout_ms = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqhttp-consumer-responseType`` =
    | [<CompiledName "http_pull">] Http_pull
    member this.Format() =
        match this with
        | Http_pull -> "http_pull"

type ``mqhttp-consumer-response`` =
    { ///A Resource identifier.
      consumer_id: Option<mqidentifier>
      created_on: Option<System.DateTimeOffset>
      ///Name of the dead letter queue, or empty string if not configured
      dead_letter_queue: Option<string>
      queue_name: Option<``mqqueue-name``>
      settings: Option<``mqhttp-consumer-responseSettings``>
      ``type``: Option<``mqhttp-consumer-responseType``> }
    ///Creates an instance of mqhttp-consumer-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqhttp-consumer-response`` =
        { consumer_id = None
          created_on = None
          dead_letter_queue = None
          queue_name = None
          settings = None
          ``type`` = None }

type mqqueue =
    { consumers: Option<list<``mqconsumer-response``>>
      consumers_total_count: Option<float>
      created_on: Option<string>
      modified_on: Option<string>
      producers: Option<list<mqproducer>>
      producers_total_count: Option<float>
      queue_id: Option<string>
      queue_name: Option<``mqqueue-name``>
      settings: Option<``mqqueue-settings``> }
    ///Creates an instance of mqqueue with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mqqueue =
        { consumers = None
          consumers_total_count = None
          created_on = None
          modified_on = None
          producers = None
          producers_total_count = None
          queue_id = None
          queue_name = None
          settings = None }

type ``mqqueue-batch`` =
    { ///The number of seconds to wait for attempting to deliver this batch to consumers
      delay_seconds: Option<float>
      messages: Option<list<``mqqueue-message``>> }
    ///Creates an instance of mqqueue-batch with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqqueue-batch`` =
        { delay_seconds = None
          messages = None }

type ``mqqueue-message`` =
    { ///The number of seconds to wait for attempting to deliver this message to consumers
      delay_seconds: Option<float> }
    ///Creates an instance of mqqueue-message with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqqueue-message`` = { delay_seconds = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Contenttype =
    | [<CompiledName "json">] Json
    member this.Format() =
        match this with
        | Json -> "json"

type ``mqqueue-message-json`` =
    { body: Option<Newtonsoft.Json.Linq.JObject>
      content_type: Option<Contenttype> }
    ///Creates an instance of mqqueue-message-json with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqqueue-message-json`` = { body = None; content_type = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqqueue-message-textContenttype`` =
    | [<CompiledName "text">] Text
    member this.Format() =
        match this with
        | Text -> "text"

type ``mqqueue-message-text`` =
    { body: Option<string>
      content_type: Option<``mqqueue-message-textContenttype``> }
    ///Creates an instance of mqqueue-message-text with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqqueue-message-text`` = { body = None; content_type = None }

type ``mqqueue-settings`` =
    { ///Number of seconds to delay delivery of all messages to consumers.
      delivery_delay: Option<float>
      ///Indicates if message delivery to consumers is currently paused.
      delivery_paused: Option<bool>
      ///Number of seconds after which an unconsumed message will be delayed.
      message_retention_period: Option<float> }
    ///Creates an instance of mqqueue-settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqqueue-settings`` =
        { delivery_delay = None
          delivery_paused = None
          message_retention_period = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqr2-producerType`` =
    | [<CompiledName "r2_bucket">] R2_bucket
    member this.Format() =
        match this with
        | R2_bucket -> "r2_bucket"

type ``mqr2-producer`` =
    { bucket_name: Option<string>
      ``type``: Option<``mqr2-producerType``> }
    ///Creates an instance of mqr2-producer with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqr2-producer`` = { bucket_name = None; ``type`` = None }

type ``mqworker-consumer-requestSettings`` =
    { ///The maximum number of messages to include in a batch.
      batch_size: Option<``mqbatch-size``>
      ///Maximum number of concurrent consumers that may consume from this Queue. Set to `null` to automatically opt in to the platform's maximum (recommended).
      max_concurrency: Option<``mqmax-concurrency``>
      ///The maximum number of retries
      max_retries: Option<``mqmax-retries``>
      ///The number of milliseconds to wait for a batch to fill up before attempting to deliver it
      max_wait_time_ms: Option<``mqmax-wait-time``>
      ///The number of seconds to delay before making the message available for another attempt.
      retry_delay: Option<``mqretry-delay``> }
    ///Creates an instance of mqworker-consumer-requestSettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqworker-consumer-requestSettings`` =
        { batch_size = None
          max_concurrency = None
          max_retries = None
          max_wait_time_ms = None
          retry_delay = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqworker-consumer-requestType`` =
    | [<CompiledName "worker">] Worker
    member this.Format() =
        match this with
        | Worker -> "worker"

type ``mqworker-consumer-request`` =
    { dead_letter_queue: Option<``mqqueue-name``>
      ///Name of a Worker
      script_name: ``mqscript-name``
      settings: Option<``mqworker-consumer-requestSettings``>
      ``type``: ``mqworker-consumer-requestType`` }
    ///Creates an instance of mqworker-consumer-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (script_name: ``mqscript-name``, ``type``: ``mqworker-consumer-requestType``): ``mqworker-consumer-request`` =
        { dead_letter_queue = None
          script_name = script_name
          settings = None
          ``type`` = ``type`` }

type ``mqworker-consumer-responseSettings`` =
    { ///The maximum number of messages to include in a batch.
      batch_size: Option<``mqbatch-size``>
      ///Maximum number of concurrent consumers that may consume from this Queue. Set to `null` to automatically opt in to the platform's maximum (recommended).
      max_concurrency: Option<``mqmax-concurrency``>
      ///The maximum number of retries
      max_retries: Option<``mqmax-retries``>
      ///The number of milliseconds to wait for a batch to fill up before attempting to deliver it
      max_wait_time_ms: Option<``mqmax-wait-time``>
      ///The number of seconds to delay before making the message available for another attempt.
      retry_delay: Option<``mqretry-delay``> }
    ///Creates an instance of mqworker-consumer-responseSettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqworker-consumer-responseSettings`` =
        { batch_size = None
          max_concurrency = None
          max_retries = None
          max_wait_time_ms = None
          retry_delay = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqworker-consumer-responseType`` =
    | [<CompiledName "worker">] Worker
    member this.Format() =
        match this with
        | Worker -> "worker"

type ``mqworker-consumer-response`` =
    { ///A Resource identifier.
      consumer_id: Option<mqidentifier>
      created_on: Option<System.DateTimeOffset>
      ///Name of the dead letter queue, or empty string if not configured
      dead_letter_queue: Option<string>
      queue_name: Option<``mqqueue-name``>
      ///Name of a Worker
      script_name: Option<``mqscript-name``>
      settings: Option<``mqworker-consumer-responseSettings``>
      ``type``: Option<``mqworker-consumer-responseType``> }
    ///Creates an instance of mqworker-consumer-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqworker-consumer-response`` =
        { consumer_id = None
          created_on = None
          dead_letter_queue = None
          queue_name = None
          script_name = None
          settings = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqworker-producerType`` =
    | [<CompiledName "worker">] Worker
    member this.Format() =
        match this with
        | Worker -> "worker"

type ``mqworker-producer`` =
    { script: Option<string>
      ``type``: Option<``mqworker-producerType``> }
    ///Creates an instance of mqworker-producer with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqworker-producer`` = { script = None; ``type`` = None }

type ``queues-listresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-listresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-listresponseErrors`` =
        { code = code; message = message }

type Resultinfo =
    { ///Total number of queues
      count: Option<float>
      ///Current page within paginated list of queues
      page: Option<float>
      ///Number of queues per page
      per_page: Option<float>
      ///Total queues available without any search parameters
      total_count: Option<float>
      ///Total pages available without any search parameters
      total_pages: Option<float> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type ``queues-listresponse`` =
    { errors: Option<list<``queues-listresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<list<mqqueue>>
      result_info: Option<Resultinfo> }
    ///Creates an instance of queues-listresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-listresponse`` =
        { errors = None
          messages = None
          success = None
          result = None
          result_info = None }

type ``queues-createresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-createresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-createresponseErrors`` =
        { code = code; message = message }

type ``queues-createresponse`` =
    { errors: Option<list<``queues-createresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<mqqueue> }
    ///Creates an instance of queues-createresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-createresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-getresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-getresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-getresponseErrors`` = { code = code; message = message }

type ``queues-getresponse`` =
    { errors: Option<list<``queues-getresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<mqqueue> }
    ///Creates an instance of queues-getresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-getresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-update-partialresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-update-partialresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-update-partialresponseErrors`` =
        { code = code; message = message }

type Result =
    { consumers: Option<list<``mqconsumer-response``>>
      consumers_total_count: Option<float>
      created_on: Option<string>
      modified_on: Option<string>
      producers: Option<list<mqproducer>>
      producers_total_count: Option<float>
      queue_id: Option<string>
      queue_name: Option<``mqqueue-name``>
      settings: Option<``mqqueue-settings``> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result =
        { consumers = None
          consumers_total_count = None
          created_on = None
          modified_on = None
          producers = None
          producers_total_count = None
          queue_id = None
          queue_name = None
          settings = None }

type ``queues-update-partialresponse`` =
    { errors: Option<list<``queues-update-partialresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<Result> }
    ///Creates an instance of queues-update-partialresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-update-partialresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-updateresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-updateresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-updateresponseErrors`` =
        { code = code; message = message }

type ``queues-updateresponseResult`` =
    { consumers: Option<list<``mqconsumer-response``>>
      consumers_total_count: Option<float>
      created_on: Option<string>
      modified_on: Option<string>
      producers: Option<list<mqproducer>>
      producers_total_count: Option<float>
      queue_id: Option<string>
      queue_name: Option<``mqqueue-name``>
      settings: Option<``mqqueue-settings``> }
    ///Creates an instance of queues-updateresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-updateresponseResult`` =
        { consumers = None
          consumers_total_count = None
          created_on = None
          modified_on = None
          producers = None
          producers_total_count = None
          queue_id = None
          queue_name = None
          settings = None }

type ``queues-updateresponse`` =
    { errors: Option<list<``queues-updateresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<``queues-updateresponseResult``> }
    ///Creates an instance of queues-updateresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-updateresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-list-consumersresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-list-consumersresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-list-consumersresponseErrors`` =
        { code = code; message = message }

type ``queues-list-consumersresponse`` =
    { errors: Option<list<``queues-list-consumersresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<list<``mqconsumer-response``>> }
    ///Creates an instance of queues-list-consumersresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-list-consumersresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-create-consumerresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-create-consumerresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-create-consumerresponseErrors`` =
        { code = code; message = message }

type ``queues-create-consumerresponse`` =
    { errors: Option<list<``queues-create-consumerresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      ///Response body representing a consumer
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of queues-create-consumerresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-create-consumerresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-get-consumerresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-get-consumerresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-get-consumerresponseErrors`` =
        { code = code; message = message }

type ``queues-get-consumerresponse`` =
    { errors: Option<list<``queues-get-consumerresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      ///Response body representing a consumer
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of queues-get-consumerresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-get-consumerresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-update-consumerresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-update-consumerresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-update-consumerresponseErrors`` =
        { code = code; message = message }

type ``queues-update-consumerresponse`` =
    { errors: Option<list<``queues-update-consumerresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      ///Response body representing a consumer
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of queues-update-consumerresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-update-consumerresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-ack-messagesresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-ack-messagesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-ack-messagesresponseErrors`` =
        { code = code; message = message }

type ``queues-ack-messagesresponseResult`` =
    { ///The number of messages that were succesfully acknowledged.
      ackCount: Option<float>
      ///The number of messages that were succesfully retried.
      retryCount: Option<float>
      warnings: Option<list<string>> }
    ///Creates an instance of queues-ack-messagesresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-ack-messagesresponseResult`` =
        { ackCount = None
          retryCount = None
          warnings = None }

type ``queues-ack-messagesresponse`` =
    { errors: Option<list<``queues-ack-messagesresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<``queues-ack-messagesresponseResult``> }
    ///Creates an instance of queues-ack-messagesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-ack-messagesresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-pull-messagesresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-pull-messagesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-pull-messagesresponseErrors`` =
        { code = code; message = message }

type Messages =
    { attempts: Option<float>
      body: Option<string>
      id: Option<string>
      ///An ID that represents an "in-flight" message that has been pulled from a Queue. You must hold on to this ID and use it to acknowledge this message.
      lease_id: Option<``mqlease-id``>
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      timestamp_ms: Option<float> }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Messages =
        { attempts = None
          body = None
          id = None
          lease_id = None
          metadata = None
          timestamp_ms = None }

type ``queues-pull-messagesresponseResult`` =
    { ///The number of unacknowledged messages in the queue
      message_backlog_count: Option<float>
      messages: Option<list<Messages>> }
    ///Creates an instance of queues-pull-messagesresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-pull-messagesresponseResult`` =
        { message_backlog_count = None
          messages = None }

type ``queues-pull-messagesresponse`` =
    { errors: Option<list<``queues-pull-messagesresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<``queues-pull-messagesresponseResult``> }
    ///Creates an instance of queues-pull-messagesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-pull-messagesresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-purge-getresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-purge-getresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-purge-getresponseErrors`` =
        { code = code; message = message }

type ``queues-purge-getresponseResult`` =
    { ///Indicates if the last purge operation completed successfully.
      completed: Option<string>
      ///Timestamp when the last purge operation started.
      started_at: Option<string> }
    ///Creates an instance of queues-purge-getresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-purge-getresponseResult`` = { completed = None; started_at = None }

type ``queues-purge-getresponse`` =
    { errors: Option<list<``queues-purge-getresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<``queues-purge-getresponseResult``> }
    ///Creates an instance of queues-purge-getresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-purge-getresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``queues-purgeresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of queues-purgeresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``queues-purgeresponseErrors`` =
        { code = code; message = message }

type ``queues-purgeresponseResult`` =
    { consumers: Option<list<``mqconsumer-response``>>
      consumers_total_count: Option<float>
      created_on: Option<string>
      modified_on: Option<string>
      producers: Option<list<mqproducer>>
      producers_total_count: Option<float>
      queue_id: Option<string>
      queue_name: Option<``mqqueue-name``>
      settings: Option<``mqqueue-settings``> }
    ///Creates an instance of queues-purgeresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-purgeresponseResult`` =
        { consumers = None
          consumers_total_count = None
          created_on = None
          modified_on = None
          producers = None
          producers_total_count = None
          queue_id = None
          queue_name = None
          settings = None }

type ``queues-purgeresponse`` =
    { errors: Option<list<``queues-purgeresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<``queues-purgeresponseResult``> }
    ///Creates an instance of queues-purgeresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``queues-purgeresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

[<RequireQualifiedAccess>]
type QueuesList =
    ///List of all Queues that belong to this account
    | OK of payload: ``queues-listresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

type QueuesCreatePayload =
    { queue_name: ``mqqueue-name`` }
    ///Creates an instance of QueuesCreatePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (queue_name: ``mqqueue-name``): QueuesCreatePayload = { queue_name = queue_name }

[<RequireQualifiedAccess>]
type QueuesCreate =
    ///Created Queue
    | OK of payload: ``queues-createresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesDelete =
    ///Successful delete
    | OK of payload: ``mqapi-v4-success``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesGet =
    ///Details of the requested Queue
    | OK of payload: ``queues-getresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesUpdatePartial =
    ///Updated Queue
    | OK of payload: ``queues-update-partialresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesUpdate =
    ///Updated Queue
    | OK of payload: ``queues-updateresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesListConsumers =
    ///All consumers attached to this Queue
    | OK of payload: ``queues-list-consumersresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesCreateConsumer =
    ///Create Queue Consumer response.
    | OK of payload: ``queues-create-consumerresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesDeleteConsumer =
    ///Successful consumer delete
    | OK of payload: ``mqapi-v4-success``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesGetConsumer =
    ///Get Queue Consumer response.
    | OK of payload: ``queues-get-consumerresponse``
    ///Get Queue Consumer response failure.
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesUpdateConsumer =
    ///Update Queue Consumer response.
    | OK of payload: ``queues-update-consumerresponse``
    ///Update Queue Consumer response failure.
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesPushMessage =
    ///Successful message ingestion
    | OK of payload: ``mqapi-v4-success``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

type Acks =
    { ///An ID that represents an "in-flight" message that has been pulled from a Queue. You must hold on to this ID and use it to acknowledge this message.
      lease_id: Option<``mqlease-id``> }
    ///Creates an instance of Acks with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Acks = { lease_id = None }

type Retries =
    { ///The number of seconds to delay before making the message available for another attempt.
      delay_seconds: Option<``mqretry-delay``>
      ///An ID that represents an "in-flight" message that has been pulled from a Queue. You must hold on to this ID and use it to acknowledge this message.
      lease_id: Option<``mqlease-id``> }
    ///Creates an instance of Retries with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Retries =
        { delay_seconds = None
          lease_id = None }

type QueuesAckMessagesPayload =
    { acks: Option<list<Acks>>
      retries: Option<list<Retries>> }
    ///Creates an instance of QueuesAckMessagesPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): QueuesAckMessagesPayload = { acks = None; retries = None }

[<RequireQualifiedAccess>]
type QueuesAckMessages =
    ///Details of ACKs and retries
    | OK of payload: ``queues-ack-messagesresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesPushMessages =
    ///Successful batch ingestion
    | OK of payload: ``mqapi-v4-success``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

type QueuesPullMessagesPayload =
    { ///The maximum number of messages to include in a batch.
      batch_size: Option<``mqbatch-size``>
      ///The number of milliseconds that a message is exclusively leased. After the timeout, the message becomes available for another attempt.
      visibility_timeout_ms: Option<``mqvisibility-timeout``> }
    ///Creates an instance of QueuesPullMessagesPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): QueuesPullMessagesPayload =
        { batch_size = None
          visibility_timeout_ms = None }

[<RequireQualifiedAccess>]
type QueuesPullMessages =
    ///A batch of messages in the Queue
    | OK of payload: ``queues-pull-messagesresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type QueuesPurgeGet =
    ///Details of the requested Queue
    | OK of payload: ``queues-purge-getresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

type QueuesPurgePayload =
    { ///Confimation that all messages will be deleted permanently.
      delete_messages_permanently: Option<bool> }
    ///Creates an instance of QueuesPurgePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): QueuesPurgePayload = { delete_messages_permanently = None }

[<RequireQualifiedAccess>]
type QueuesPurge =
    ///Updated Queue
    | OK of payload: ``queues-purgeresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``
