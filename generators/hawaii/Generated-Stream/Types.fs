namespace rec Fidelity.CloudEdge.Management.Stream.Types

///The account identifier tag.
type streamaccountidentifier = string
///Lists the origins allowed to display the video. Enter allowed origin domains in an array and use `*` for wildcard subdomains. Empty arrays allow the video to be viewed on any origin.
type streamallowedOrigins = list<string>
type streamasc = bool
type streamaudiodefault = bool
///The unique identifier for an additional audio track.
type streamaudioidentifier = string
///A string to uniquely identify the track amongst other audio track labels for the specified video.
type streamaudiolabel = string

///Specifies the processing status of the video.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type streamaudiostate =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "ready">] Ready
    | [<CompiledName "error">] Error
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Ready -> "ready"
        | Error -> "error"

///The status of a generated caption.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type streamcaptionstatus =
    | [<CompiledName "ready">] Ready
    | [<CompiledName "inprogress">] Inprogress
    | [<CompiledName "error">] Error
    member this.Format() =
        match this with
        | Ready -> "ready"
        | Inprogress -> "inprogress"
        | Error -> "error"

///The unique video identifier (UID).
type streamclippedfromvideouid = string
///The date and time the clip was created.
type streamclippingcreated = System.DateTimeOffset
///The date and time the media item was created.
type streamcreated = System.DateTimeOffset
///A user-defined identifier for the media creator.
type streamcreator = string
type streamdirectuser = bool
type streamdownloadpercentcomplete = float

///The status of a generated download.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type streamdownloadstatus =
    | [<CompiledName "ready">] Ready
    | [<CompiledName "inprogress">] Inprogress
    | [<CompiledName "error">] Error
    member this.Format() =
        match this with
        | Ready -> "ready"
        | Inprogress -> "inprogress"
        | Error -> "error"

///The type of downloads available are: `default`, `audio`.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type streamdownloadtype =
    | [<CompiledName "default">] Default
    | [<CompiledName "audio">] Audio
    member this.Format() =
        match this with
        | Default -> "default"
        | Audio -> "audio"

///The URL to access the generated download.
type streamdownloadurl = string
///The source URL for a downloaded image. If the watermark profile was created via direct upload, this field is null.
type streamdownloadedFrom = string
type streamduration = float
///Lists videos created before the specified date.
type streamend = System.DateTimeOffset
type streamendtimeseconds = int
///Specifies why the video failed to encode. This field is empty if the video is not in an `error` state. Preferred for programmatic use.
type streamerrorReasonCode = string
///Specifies why the video failed to encode using a human readable error message in English. This field is empty if the video is not in an `error` state.
type streamerrorReasonText = string
type streamgeneratedcaption = bool
type streamheight = int
///A Cloudflare-generated unique identifier for a media item.
type streamidentifier = string
type streamincludecounts = bool
///The secret key to use when streaming via RTMPS to a live input.
type streaminputrtmpsstreamkey = string
///The RTMPS URL you provide to the broadcaster, which they stream live video to.
type streaminputrtmpsurl = string
///The identifier of the live input to use when streaming via SRT.
type streaminputsrtstreamid = string
///The secret key to use when streaming via SRT to a live input.
type streaminputsrtstreampassphrase = string
///The SRT URL you provide to the broadcaster, which they stream live video to.
type streaminputsrturl = string
///The WebRTC URL you provide to the broadcaster, which they stream live video to.
type streaminputwebrtcurl = string
///The signing key in JWK format.
type streamjwk = string
///The language label displayed in the native language to users.
type streamlabel = string
///The language tag in BCP 47 format.
type streamlanguage = string
///The live input ID used to upload a video with Stream Live.
type streamliveInput = string
///The date and time the live input was created.
type streamliveinputcreated = System.DateTimeOffset
///Sets the creator ID asssociated with this live input.
type streamliveinputdefaultcreator = string
type streamliveinputenabled = bool
///A unique identifier for a live input.
type streamliveinputidentifier = string
///The date and time the live input was last modified.
type streamliveinputmodified = System.DateTimeOffset
///Lists the origins allowed to display videos created with this input. Enter allowed origin domains in an array and use `*` for wildcard subdomains. An empty array allows videos to be viewed on any origin.
type streamliveinputrecordingallowedOrigins = list<string>
type streamliveinputrecordingdeletion = float
type streamliveinputrecordinghideLiveViewerCount = bool

///Specifies the recording behavior for the live input. Set this value to `off` to prevent a recording. Set the value to `automatic` to begin a recording and transition to on-demand after Stream Live stops receiving input.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type streamliveinputrecordingmode =
    | [<CompiledName "off">] Off
    | [<CompiledName "automatic">] Automatic
    member this.Format() =
        match this with
        | Off -> "off"
        | Automatic -> "automatic"

type streamliveinputrecordingrequireSignedURLs = bool
type streamliveinputrecordingtimeoutSeconds = int

///The connection status of a live input.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type streamliveinputstatus =
    | [<CompiledName "connected">] Connected
    | [<CompiledName "reconnected">] Reconnected
    | [<CompiledName "reconnecting">] Reconnecting
    | [<CompiledName "client_disconnect">] Client_disconnect
    | [<CompiledName "ttl_exceeded">] Ttl_exceeded
    | [<CompiledName "failed_to_connect">] Failed_to_connect
    | [<CompiledName "failed_to_reconnect">] Failed_to_reconnect
    | [<CompiledName "new_configuration_accepted">] New_configuration_accepted
    member this.Format() =
        match this with
        | Connected -> "connected"
        | Reconnected -> "reconnected"
        | Reconnecting -> "reconnecting"
        | Client_disconnect -> "client_disconnect"
        | Ttl_exceeded -> "ttl_exceeded"
        | Failed_to_connect -> "failed_to_connect"
        | Failed_to_reconnect -> "failed_to_reconnect"
        | New_configuration_accepted -> "new_configuration_accepted"

type streammaxDurationSeconds = int

///Specifies the processing status for all quality levels for a video.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type streammediastate =
    | [<CompiledName "pendingupload">] Pendingupload
    | [<CompiledName "downloading">] Downloading
    | [<CompiledName "queued">] Queued
    | [<CompiledName "inprogress">] Inprogress
    | [<CompiledName "ready">] Ready
    | [<CompiledName "error">] Error
    | [<CompiledName "live-inprogress">] LiveInprogress
    member this.Format() =
        match this with
        | Pendingupload -> "pendingupload"
        | Downloading -> "downloading"
        | Queued -> "queued"
        | Inprogress -> "inprogress"
        | Ready -> "ready"
        | Error -> "error"
        | LiveInprogress -> "live-inprogress"

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type streammessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of streammessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streammessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streammessages = list<streammessagesArrayItem>
///The date and time the media item was last modified.
type streammodified = System.DateTimeOffset
///A short description of the watermark profile.
type streamname = string
///The URL where webhooks will be sent.
type streamnotificationUrl = string
///The date and time when the video upload URL is no longer valid for direct user uploads.
type streamoneTimeUploadExpiry = System.DateTimeOffset
type streamopacity = float
type streamoutputenabled = bool
///A unique identifier for the output.
type streamoutputidentifier = string
///The streamKey used to authenticate against an output's target.
type streamoutputstreamKey = string
///The URL an output uses to restream.
type streamoutputurl = string
type streampadding = float
///Indicates the progress as a percentage between 0 and 100.
type streampctComplete = string
///The signing key in PEM format.
type streampem = string
///The secret key to use for playback via RTMPS.
type streamplaybackrtmpsstreamkey = string
///The URL used to play live video over RTMPS.
type streamplaybackrtmpsurl = string
///The identifier of the live input to use for playback via SRT.
type streamplaybacksrtstreamid = string
///The secret key to use for playback via SRT.
type streamplaybacksrtstreampassphrase = string
///The URL used to play live video over SRT.
type streamplaybacksrturl = string
///The URL used to play live video over WebRTC.
type streamplaybackwebrtcurl = string
///The location of the image. Valid positions are: `upperRight`, `upperLeft`, `lowerLeft`, `lowerRight`, and `center`. Note that `center` ignores the `padding` parameter.
type streamposition = string
///The video's preview page URI. This field is omitted until encoding is complete.
type streampreview = string
type streamreadyToStream = bool
///Indicates the time at which the video became playable. The field is empty if the video is not ready for viewing or the live stream is still in progress.
type streamreadyToStreamAt = System.DateTimeOffset
type streamrequireSignedURLs = bool
type streamscale = float
///Indicates the date and time at which the video will be deleted. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion. If specified, must be at least 30 days from upload time.
type streamscheduledDeletion = System.DateTimeOffset
///Identifier.
type ``streamschemas-identifier`` = string
///Provides a partial word match of the `name` key in the `meta` field. Slow for medium to large video libraries. May be unavailable for very large libraries.
type streamsearch = string
///The date and time a signing key was created.
type streamsigningkeycreated = System.DateTimeOffset
type streamsize = float
///Lists videos created after the specified date.
type streamstart = System.DateTimeOffset
type streamstarttimeseconds = int
type streamthumbnailTimestampPct = float
///The media item's thumbnail URI. This field is omitted until encoding is complete.
type streamthumbnailurl = string

///Specifies the TUS protocol version. This value must be included in every upload request.
///Notes: The only supported version of TUS protocol is 1.0.0.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type streamtusresumable =
    | [<CompiledName "1.0.0">] Numeric_1Numeric_0Numeric_0
    member this.Format() =
        match this with
        | Numeric_1Numeric_0Numeric_0 -> "1.0.0"

///Specifies whether the video is `vod` or `live`.
type streamtype = string
type streamuploadlength = int

///Comma-separated key-value pairs following the TUS protocol specification. Values are Base-64 encoded.
///Supported keys: `name`, `requiresignedurls`, `allowedorigins`, `thumbnailtimestamppct`, `watermark`, `scheduleddeletion`, `maxdurationseconds`.
type streamuploadmetadata = string

///The date and time the media item was uploaded.
type streamuploaded = System.DateTimeOffset
///Provides a fast, exact string match on the `name` key in the `meta` field.
type streamvideoname = string
///The date and a time a watermark profile was created.
type streamwatermarkcreated = System.DateTimeOffset
///The unique identifier for a watermark profile.
type streamwatermarkidentifier = string
type streamwatermarksize = float
type streamwidth = int

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Action =
    | [<CompiledName "allow">] Allow
    | [<CompiledName "block">] Block
    member this.Format() =
        match this with
        | Allow -> "allow"
        | Block -> "block"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "any">] Any
    | [<CompiledName "ip.src">] IpSrc
    | [<CompiledName "ip.geoip.country">] IpGeoipCountry
    member this.Format() =
        match this with
        | Any -> "any"
        | IpSrc -> "ip.src"
        | IpGeoipCountry -> "ip.geoip.country"

///Defines rules for fine-grained control over content than signed URL tokens alone. Access rules primarily make tokens conditionally valid based on user information. Access Rules are specified on token payloads as the `accessRules` property containing an array of Rule objects.
type streamaccessRules =
    { ///The action to take when a request matches a rule. If the action is `block`, the signed token blocks views for viewers matching the rule.
      action: Option<Action>
      ///An array of 2-letter country codes in ISO 3166-1 Alpha-2 format used to match requests.
      country: Option<list<string>>
      ///An array of IPv4 or IPV6 addresses or CIDRs used to match requests.
      ip: Option<list<string>>
      ///Lists available rule types to match for requests. An `any` type matches all requests and can be used as a wildcard to apply default actions after other rules.
      ``type``: Option<Type> }
    ///Creates an instance of streamaccessRules with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamaccessRules =
        { action = None
          country = None
          ip = None
          ``type`` = None }

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

type streamaddAudioTrackResponse =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<streamadditionalAudio> }
    ///Creates an instance of streamaddAudioTrackResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamaddAudioTrackResponse =
        { errors = None
          messages = None
          success = None
          result = None }

type streamadditionalAudio =
    { ///Denotes whether the audio track will be played by default in a player.
      ``default``: Option<streamaudiodefault>
      ///A string to uniquely identify the track amongst other audio track labels for the specified video.
      label: Option<streamaudiolabel>
      ///Specifies the processing status of the video.
      status: Option<streamaudiostate>
      ///A Cloudflare-generated unique identifier for a media item.
      uid: Option<streamidentifier> }
    ///Creates an instance of streamadditionalAudio with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamadditionalAudio =
        { ``default`` = None
          label = None
          status = None
          uid = None }

type ``streamapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of streamapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``streamapi-response-commonErrorsSource`` = { pointer = None }

type ``streamapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``streamapi-response-commonErrorsSource``> }
    ///Creates an instance of streamapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``streamapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``streamapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of streamapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``streamapi-response-commonMessagesSource`` = { pointer = None }

type ``streamapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``streamapi-response-commonMessagesSource``> }
    ///Creates an instance of streamapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``streamapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``streamapi-response-common`` =
    { errors: list<``streamapi-response-commonErrors``>
      messages: list<``streamapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of streamapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``streamapi-response-commonErrors``>,
                          messages: list<``streamapi-response-commonMessages``>,
                          success: bool): ``streamapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``streamapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of streamapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``streamapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``streamapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of streamapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``streamapi-response-singleErrorsSource`` = { pointer = None }

type ``streamapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``streamapi-response-singleErrorsSource``> }
    ///Creates an instance of streamapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``streamapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``streamapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of streamapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``streamapi-response-singleMessagesSource`` = { pointer = None }

type ``streamapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``streamapi-response-singleMessagesSource``> }
    ///Creates an instance of streamapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``streamapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``streamapi-response-single`` =
    { errors: Option<list<``streamapi-response-singleErrors``>>
      messages: Option<list<``streamapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of streamapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``streamapi-response-single`` =
        { errors = None
          messages = None
          success = None }

type streamcaptionbasicupload =
    { ///The WebVTT file containing the caption or subtitle content.
      file: string }
    ///Creates an instance of streamcaptionbasicupload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (file: string): streamcaptionbasicupload = { file = file }

type streamcaptions =
    { ///Whether the caption was generated via AI.
      generated: Option<streamgeneratedcaption>
      ///The language label displayed in the native language to users.
      label: Option<streamlabel>
      ///The language tag in BCP 47 format.
      language: Option<streamlanguage>
      ///The status of a generated caption.
      status: Option<streamcaptionstatus> }
    ///Creates an instance of streamcaptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamcaptions =
        { generated = None
          label = None
          language = None
          status = None }

type streamclipResponseSingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamclipResponseSingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamclipResponseSingleErrorsSource = { pointer = None }

type streamclipResponseSingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamclipResponseSingleErrorsSource> }
    ///Creates an instance of streamclipResponseSingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamclipResponseSingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamclipResponseSingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamclipResponseSingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamclipResponseSingleMessagesSource = { pointer = None }

type streamclipResponseSingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamclipResponseSingleMessagesSource> }
    ///Creates an instance of streamclipResponseSingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamclipResponseSingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamclipResponseSingle =
    { errors: Option<list<streamclipResponseSingleErrors>>
      messages: Option<list<streamclipResponseSingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of streamclipResponseSingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamclipResponseSingle =
        { errors = None
          messages = None
          success = None
          result = None }

type streamclipping =
    { ///Lists the origins allowed to display the video. Enter allowed origin domains in an array and use `*` for wildcard subdomains. Empty arrays allow the video to be viewed on any origin.
      allowedOrigins: Option<streamallowedOrigins>
      ///The unique video identifier (UID).
      clippedFromVideoUID: Option<streamclippedfromvideouid>
      ///The date and time the clip was created.
      created: Option<streamclippingcreated>
      ///A user-defined identifier for the media creator.
      creator: Option<streamcreator>
      ///Specifies the end time for the video clip in seconds.
      endTimeSeconds: Option<streamendtimeseconds>
      ///The maximum duration in seconds for a video upload. Can be set for a video that is not yet uploaded to limit its duration. Uploads that exceed the specified duration will fail during processing. A value of `-1` means the value is unknown.
      maxDurationSeconds: Option<streammaxDurationSeconds>
      ///A user modifiable key-value store used to reference other systems of record for managing videos.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///The date and time the live input was last modified.
      modified: Option<streamliveinputmodified>
      playback: Option<streamplayback>
      ///The video's preview page URI. This field is omitted until encoding is complete.
      preview: Option<streampreview>
      ///Indicates whether the video can be a accessed using the UID. When set to `true`, a signed token must be generated with a signing key to view the video.
      requireSignedURLs: Option<streamrequireSignedURLs>
      ///Specifies the start time for the video clip in seconds.
      startTimeSeconds: Option<streamstarttimeseconds>
      ///Specifies the processing status for all quality levels for a video.
      status: Option<streammediastate>
      ///The timestamp for a thumbnail image calculated as a percentage value of the video's duration. To convert from a second-wise timestamp to a percentage, divide the desired timestamp by the total duration of the video.  If this value is not set, the default thumbnail image is taken from 0s of the video.
      thumbnailTimestampPct: Option<streamthumbnailTimestampPct>
      watermark: Option<streamwatermarkAtUpload> }
    ///Creates an instance of streamclipping with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamclipping =
        { allowedOrigins = None
          clippedFromVideoUID = None
          created = None
          creator = None
          endTimeSeconds = None
          maxDurationSeconds = None
          meta = None
          modified = None
          playback = None
          preview = None
          requireSignedURLs = None
          startTimeSeconds = None
          status = None
          thumbnailTimestampPct = None
          watermark = None }

type streamcopyAudioTrack =
    { ///A string to uniquely identify the track amongst other audio track labels for the specified video.
      label: streamaudiolabel
      ///An audio track URL. The server must be publicly routable and support `HTTP HEAD` requests and `HTTP GET` range requests. The server should respond to `HTTP HEAD` requests with a `content-range` header that includes the size of the file.
      url: Option<string> }
    ///Creates an instance of streamcopyAudioTrack with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (label: streamaudiolabel): streamcopyAudioTrack = { label = label; url = None }

type streamcreateinputrequest =
    { ///Sets the creator ID asssociated with this live input.
      defaultCreator: Option<streamliveinputdefaultcreator>
      ///Indicates the number of days after which the live inputs recordings will be deleted. When a stream completes and the recording is ready, the value is used to calculate a scheduled deletion date for that recording. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion.
      deleteRecordingAfterDays: Option<streamliveinputrecordingdeletion>
      ///Indicates whether the live input is enabled and can accept streams.
      enabled: Option<streamliveinputenabled>
      ///A user modifiable key-value store used to reference other systems of record for managing live inputs.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///Records the input to a Cloudflare Stream video. Behavior depends on the mode. In most cases, the video will initially be viewable as a live video and transition to on-demand after a condition is satisfied.
      recording: Option<streamliveinputrecordingsettings> }
    ///Creates an instance of streamcreateinputrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamcreateinputrequest =
        { defaultCreator = None
          deleteRecordingAfterDays = None
          enabled = None
          meta = None
          recording = None }

type streamcreateoutputrequest =
    { ///When enabled, live video streamed to the associated live input will be sent to the output URL. When disabled, live video will not be sent to the output URL, even when streaming to the associated live input. Use this to control precisely when you start and stop simulcasting to specific destinations like YouTube and Twitch.
      enabled: Option<streamoutputenabled>
      ///The streamKey used to authenticate against an output's target.
      streamKey: streamoutputstreamKey
      ///The URL an output uses to restream.
      url: streamoutputurl }
    ///Creates an instance of streamcreateoutputrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (streamKey: streamoutputstreamKey, url: streamoutputurl): streamcreateoutputrequest =
        { enabled = None
          streamKey = streamKey
          url = url }

type streamdeletedresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamdeletedresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdeletedresponseErrorsSource = { pointer = None }

type streamdeletedresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamdeletedresponseErrorsSource> }
    ///Creates an instance of streamdeletedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamdeletedresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamdeletedresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamdeletedresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdeletedresponseMessagesSource = { pointer = None }

type streamdeletedresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamdeletedresponseMessagesSource> }
    ///Creates an instance of streamdeletedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamdeletedresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamdeletedresponse =
    { errors: Option<list<streamdeletedresponseErrors>>
      messages: Option<list<streamdeletedresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<string> }
    ///Creates an instance of streamdeletedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdeletedresponse =
        { errors = None
          messages = None
          success = None
          result = None }

type streamdirectuploadrequest =
    { ///Lists the origins allowed to display the video. Enter allowed origin domains in an array and use `*` for wildcard subdomains. Empty arrays allow the video to be viewed on any origin.
      allowedOrigins: Option<streamallowedOrigins>
      ///A user-defined identifier for the media creator.
      creator: Option<streamcreator>
      ///The date and time after upload when videos will not be accepted.
      expiry: Option<System.DateTimeOffset>
      ///The maximum duration in seconds for a video upload. Can be set for a video that is not yet uploaded to limit its duration. Uploads that exceed the specified duration will fail during processing. A value of `-1` means the value is unknown.
      maxDurationSeconds: streammaxDurationSeconds
      ///A user modifiable key-value store used to reference other systems of record for managing videos.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///Indicates whether the video can be a accessed using the UID. When set to `true`, a signed token must be generated with a signing key to view the video.
      requireSignedURLs: Option<streamrequireSignedURLs>
      ///Indicates the date and time at which the video will be deleted. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion. If specified, must be at least 30 days from upload time.
      scheduledDeletion: Option<streamscheduledDeletion>
      ///The timestamp for a thumbnail image calculated as a percentage value of the video's duration. To convert from a second-wise timestamp to a percentage, divide the desired timestamp by the total duration of the video.  If this value is not set, the default thumbnail image is taken from 0s of the video.
      thumbnailTimestampPct: Option<streamthumbnailTimestampPct>
      watermark: Option<streamwatermarkatupload> }
    ///Creates an instance of streamdirectuploadrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (maxDurationSeconds: streammaxDurationSeconds): streamdirectuploadrequest =
        { allowedOrigins = None
          creator = None
          expiry = None
          maxDurationSeconds = maxDurationSeconds
          meta = None
          requireSignedURLs = None
          scheduledDeletion = None
          thumbnailTimestampPct = None
          watermark = None }

type streamdirectuploadresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamdirectuploadresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdirectuploadresponseErrorsSource = { pointer = None }

type streamdirectuploadresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamdirectuploadresponseErrorsSource> }
    ///Creates an instance of streamdirectuploadresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamdirectuploadresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamdirectuploadresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamdirectuploadresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdirectuploadresponseMessagesSource = { pointer = None }

type streamdirectuploadresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamdirectuploadresponseMessagesSource> }
    ///Creates an instance of streamdirectuploadresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamdirectuploadresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Result =
    { ///Indicates the date and time at which the video will be deleted. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion. If specified, must be at least 30 days from upload time.
      scheduledDeletion: Option<streamscheduledDeletion>
      ///A Cloudflare-generated unique identifier for a media item.
      uid: Option<streamidentifier>
      ///The URL an unauthenticated upload can use for a single `HTTP POST multipart/form-data` request.
      uploadURL: Option<string>
      watermark: Option<streamwatermarks> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result =
        { scheduledDeletion = None
          uid = None
          uploadURL = None
          watermark = None }

type streamdirectuploadresponse =
    { errors: Option<list<streamdirectuploadresponseErrors>>
      messages: Option<list<streamdirectuploadresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Result> }
    ///Creates an instance of streamdirectuploadresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdirectuploadresponse =
        { errors = None
          messages = None
          success = None
          result = None }

type streamdownloads =
    { ///Indicates the progress as a percentage between 0 and 100.
      percentComplete: Option<streamdownloadpercentcomplete>
      ///The status of a generated download.
      status: Option<streamdownloadstatus>
      ///The URL to access the generated download.
      url: Option<streamdownloadurl> }
    ///Creates an instance of streamdownloads with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdownloads =
        { percentComplete = None
          status = None
          url = None }

type streamdownloadsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamdownloadsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdownloadsresponseErrorsSource = { pointer = None }

type streamdownloadsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamdownloadsresponseErrorsSource> }
    ///Creates an instance of streamdownloadsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamdownloadsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamdownloadsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamdownloadsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdownloadsresponseMessagesSource = { pointer = None }

type streamdownloadsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamdownloadsresponseMessagesSource> }
    ///Creates an instance of streamdownloadsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamdownloadsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

///An object with download type keys. Each key is optional and only present if that download type has been created.
type streamdownloadsresponseResult =
    { ///The audio-only download. Only present if this download type has been created.
      audio: Option<Newtonsoft.Json.Linq.JToken>
      ///The default video download. Only present if this download type has been created.
      ``default``: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of streamdownloadsresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdownloadsresponseResult = { audio = None; ``default`` = None }

type streamdownloadsresponse =
    { errors: Option<list<streamdownloadsresponseErrors>>
      messages: Option<list<streamdownloadsresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      ///An object with download type keys. Each key is optional and only present if that download type has been created.
      result: Option<streamdownloadsresponseResult> }
    ///Creates an instance of streamdownloadsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdownloadsresponse =
        { errors = None
          messages = None
          success = None
          result = None }

type streamdownloadsresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamdownloadsresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdownloadsresponsesingleErrorsSource = { pointer = None }

type streamdownloadsresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamdownloadsresponsesingleErrorsSource> }
    ///Creates an instance of streamdownloadsresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamdownloadsresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamdownloadsresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamdownloadsresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdownloadsresponsesingleMessagesSource = { pointer = None }

type streamdownloadsresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamdownloadsresponsesingleMessagesSource> }
    ///Creates an instance of streamdownloadsresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamdownloadsresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamdownloadsresponsesingle =
    { errors: Option<list<streamdownloadsresponsesingleErrors>>
      messages: Option<list<streamdownloadsresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<streamdownloads> }
    ///Creates an instance of streamdownloadsresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamdownloadsresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type streameditAudioTrack =
    { ///Denotes whether the audio track will be played by default in a player.
      ``default``: Option<streamaudiodefault>
      ///A string to uniquely identify the track amongst other audio track labels for the specified video.
      label: Option<streamaudiolabel> }
    ///Creates an instance of streameditAudioTrack with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streameditAudioTrack = { ``default`` = None; label = None }

type streaminput =
    { ///The video height in pixels. A value of `-1` means the height is unknown. The value becomes available after the upload and before the video is ready.
      height: Option<int>
      ///The video width in pixels. A value of `-1` means the width is unknown. The value becomes available after the upload and before the video is ready.
      width: Option<int> }
    ///Creates an instance of streaminput with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streaminput = { height = None; width = None }

///Details for streaming to an live input using RTMPS.
type streaminputrtmps =
    { ///The secret key to use when streaming via RTMPS to a live input.
      streamKey: Option<streaminputrtmpsstreamkey>
      ///The RTMPS URL you provide to the broadcaster, which they stream live video to.
      url: Option<streaminputrtmpsurl> }
    ///Creates an instance of streaminputrtmps with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streaminputrtmps = { streamKey = None; url = None }

///Details for streaming to a live input using SRT.
type streaminputsrt =
    { ///The secret key to use when streaming via SRT to a live input.
      passphrase: Option<streaminputsrtstreampassphrase>
      ///The identifier of the live input to use when streaming via SRT.
      streamId: Option<streaminputsrtstreamid>
      ///The SRT URL you provide to the broadcaster, which they stream live video to.
      url: Option<streaminputsrturl> }
    ///Creates an instance of streaminputsrt with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streaminputsrt =
        { passphrase = None
          streamId = None
          url = None }

///Details for streaming to a live input using WebRTC.
type streaminputwebrtc =
    { ///The WebRTC URL you provide to the broadcaster, which they stream live video to.
      url: Option<streaminputwebrtcurl> }
    ///Creates an instance of streaminputwebrtc with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streaminputwebrtc = { url = None }

type streamkeygenerationresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamkeygenerationresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamkeygenerationresponseErrorsSource = { pointer = None }

type streamkeygenerationresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamkeygenerationresponseErrorsSource> }
    ///Creates an instance of streamkeygenerationresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamkeygenerationresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamkeygenerationresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamkeygenerationresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamkeygenerationresponseMessagesSource = { pointer = None }

type streamkeygenerationresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamkeygenerationresponseMessagesSource> }
    ///Creates an instance of streamkeygenerationresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamkeygenerationresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamkeygenerationresponse =
    { errors: Option<list<streamkeygenerationresponseErrors>>
      messages: Option<list<streamkeygenerationresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<streamkeys> }
    ///Creates an instance of streamkeygenerationresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamkeygenerationresponse =
        { errors = None
          messages = None
          success = None
          result = None }

type streamkeyresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamkeyresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamkeyresponsecollectionErrorsSource = { pointer = None }

type streamkeyresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamkeyresponsecollectionErrorsSource> }
    ///Creates an instance of streamkeyresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamkeyresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamkeyresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamkeyresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamkeyresponsecollectionMessagesSource = { pointer = None }

type streamkeyresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamkeyresponsecollectionMessagesSource> }
    ///Creates an instance of streamkeyresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamkeyresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamkeyresponsecollectionResult =
    { ///The date and time a signing key was created.
      created: Option<streamsigningkeycreated>
      ///Identifier.
      id: Option<``streamschemas-identifier``> }
    ///Creates an instance of streamkeyresponsecollectionResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamkeyresponsecollectionResult = { created = None; id = None }

type streamkeyresponsecollection =
    { errors: Option<list<streamkeyresponsecollectionErrors>>
      messages: Option<list<streamkeyresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<streamkeyresponsecollectionResult>> }
    ///Creates an instance of streamkeyresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamkeyresponsecollection =
        { errors = None
          messages = None
          success = None
          result = None }

type streamkeys =
    { ///The date and time a signing key was created.
      created: Option<streamsigningkeycreated>
      ///Identifier.
      id: Option<``streamschemas-identifier``>
      ///The signing key in JWK format.
      jwk: Option<streamjwk>
      ///The signing key in PEM format.
      pem: Option<streampem> }
    ///Creates an instance of streamkeys with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamkeys =
        { created = None
          id = None
          jwk = None
          pem = None }

type streamlanguageresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamlanguageresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamlanguageresponsecollectionErrorsSource = { pointer = None }

type streamlanguageresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamlanguageresponsecollectionErrorsSource> }
    ///Creates an instance of streamlanguageresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamlanguageresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamlanguageresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamlanguageresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamlanguageresponsecollectionMessagesSource = { pointer = None }

type streamlanguageresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamlanguageresponsecollectionMessagesSource> }
    ///Creates an instance of streamlanguageresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamlanguageresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamlanguageresponsecollection =
    { errors: Option<list<streamlanguageresponsecollectionErrors>>
      messages: Option<list<streamlanguageresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<streamcaptions>> }
    ///Creates an instance of streamlanguageresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamlanguageresponsecollection =
        { errors = None
          messages = None
          success = None
          result = None }

type streamlanguageresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamlanguageresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamlanguageresponsesingleErrorsSource = { pointer = None }

type streamlanguageresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamlanguageresponsesingleErrorsSource> }
    ///Creates an instance of streamlanguageresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamlanguageresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamlanguageresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamlanguageresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamlanguageresponsesingleMessagesSource = { pointer = None }

type streamlanguageresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamlanguageresponsesingleMessagesSource> }
    ///Creates an instance of streamlanguageresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamlanguageresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamlanguageresponsesingle =
    { errors: Option<list<streamlanguageresponsesingleErrors>>
      messages: Option<list<streamlanguageresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<streamcaptions> }
    ///Creates an instance of streamlanguageresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamlanguageresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type streamlistAudioTrackResponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamlistAudioTrackResponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamlistAudioTrackResponseErrorsSource = { pointer = None }

type streamlistAudioTrackResponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamlistAudioTrackResponseErrorsSource> }
    ///Creates an instance of streamlistAudioTrackResponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamlistAudioTrackResponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamlistAudioTrackResponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamlistAudioTrackResponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamlistAudioTrackResponseMessagesSource = { pointer = None }

type streamlistAudioTrackResponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamlistAudioTrackResponseMessagesSource> }
    ///Creates an instance of streamlistAudioTrackResponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamlistAudioTrackResponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamlistAudioTrackResponse =
    { errors: Option<list<streamlistAudioTrackResponseErrors>>
      messages: Option<list<streamlistAudioTrackResponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<streamadditionalAudio>> }
    ///Creates an instance of streamlistAudioTrackResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamlistAudioTrackResponse =
        { errors = None
          messages = None
          success = None
          result = None }

///Details about a live input.
type streamliveinput =
    { ///The date and time the live input was created.
      created: Option<streamliveinputcreated>
      ///Indicates the number of days after which the live inputs recordings will be deleted. When a stream completes and the recording is ready, the value is used to calculate a scheduled deletion date for that recording. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion.
      deleteRecordingAfterDays: Option<streamliveinputrecordingdeletion>
      ///Indicates whether the live input is enabled and can accept streams.
      enabled: Option<streamliveinputenabled>
      ///A user modifiable key-value store used to reference other systems of record for managing live inputs.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///The date and time the live input was last modified.
      modified: Option<streamliveinputmodified>
      ///Records the input to a Cloudflare Stream video. Behavior depends on the mode. In most cases, the video will initially be viewable as a live video and transition to on-demand after a condition is satisfied.
      recording: Option<streamliveinputrecordingsettings>
      ///Details for streaming to an live input using RTMPS.
      rtmps: Option<streaminputrtmps>
      ///Details for playback from an live input using RTMPS.
      rtmpsPlayback: Option<streamplaybackrtmps>
      ///Details for streaming to a live input using SRT.
      srt: Option<streaminputsrt>
      ///Details for playback from an live input using SRT.
      srtPlayback: Option<streamplaybacksrt>
      ///The connection status of a live input.
      status: Option<streamliveinputstatus>
      ///A unique identifier for a live input.
      uid: Option<streamliveinputidentifier>
      ///Details for streaming to a live input using WebRTC.
      webRTC: Option<streaminputwebrtc>
      ///Details for playback from a live input using WebRTC.
      webRTCPlayback: Option<streamplaybackwebrtc> }
    ///Creates an instance of streamliveinput with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinput =
        { created = None
          deleteRecordingAfterDays = None
          enabled = None
          meta = None
          modified = None
          recording = None
          rtmps = None
          rtmpsPlayback = None
          srt = None
          srtPlayback = None
          status = None
          uid = None
          webRTC = None
          webRTCPlayback = None }

type streamliveinputobjectwithouturl =
    { ///The date and time the live input was created.
      created: Option<streamliveinputcreated>
      ///Indicates the number of days after which the live inputs recordings will be deleted. When a stream completes and the recording is ready, the value is used to calculate a scheduled deletion date for that recording. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion.
      deleteRecordingAfterDays: Option<streamliveinputrecordingdeletion>
      ///Indicates whether the live input is enabled and can accept streams.
      enabled: Option<streamliveinputenabled>
      ///A user modifiable key-value store used to reference other systems of record for managing live inputs.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///The date and time the live input was last modified.
      modified: Option<streamliveinputmodified>
      ///A unique identifier for a live input.
      uid: Option<streamliveinputidentifier> }
    ///Creates an instance of streamliveinputobjectwithouturl with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinputobjectwithouturl =
        { created = None
          deleteRecordingAfterDays = None
          enabled = None
          meta = None
          modified = None
          uid = None }

///Records the input to a Cloudflare Stream video. Behavior depends on the mode. In most cases, the video will initially be viewable as a live video and transition to on-demand after a condition is satisfied.
type streamliveinputrecordingsettings =
    { ///Lists the origins allowed to display videos created with this input. Enter allowed origin domains in an array and use `*` for wildcard subdomains. An empty array allows videos to be viewed on any origin.
      allowedOrigins: Option<streamliveinputrecordingallowedOrigins>
      ///Disables reporting the number of live viewers when this property is set to `true`.
      hideLiveViewerCount: Option<streamliveinputrecordinghideLiveViewerCount>
      ///Specifies the recording behavior for the live input. Set this value to `off` to prevent a recording. Set the value to `automatic` to begin a recording and transition to on-demand after Stream Live stops receiving input.
      mode: Option<streamliveinputrecordingmode>
      ///Indicates if a video using the live input has the `requireSignedURLs` property set. Also enforces access controls on any video recording of the livestream with the live input.
      requireSignedURLs: Option<streamliveinputrecordingrequireSignedURLs>
      ///Determines the amount of time a live input configured in `automatic` mode should wait before a recording transitions from live to on-demand. `0` is recommended for most use cases and indicates the platform default should be used.
      timeoutSeconds: Option<streamliveinputrecordingtimeoutSeconds> }
    ///Creates an instance of streamliveinputrecordingsettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinputrecordingsettings =
        { allowedOrigins = None
          hideLiveViewerCount = None
          mode = None
          requireSignedURLs = None
          timeoutSeconds = None }

type streamliveinputresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamliveinputresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinputresponsecollectionErrorsSource = { pointer = None }

type streamliveinputresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamliveinputresponsecollectionErrorsSource> }
    ///Creates an instance of streamliveinputresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamliveinputresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamliveinputresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamliveinputresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinputresponsecollectionMessagesSource = { pointer = None }

type streamliveinputresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamliveinputresponsecollectionMessagesSource> }
    ///Creates an instance of streamliveinputresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamliveinputresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamliveinputresponsecollectionResult =
    { liveInputs: Option<list<streamliveinputobjectwithouturl>>
      ///The total number of remaining live inputs based on cursor position.
      range: Option<int>
      ///The total number of live inputs that match the provided filters.
      total: Option<int> }
    ///Creates an instance of streamliveinputresponsecollectionResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinputresponsecollectionResult =
        { liveInputs = None
          range = None
          total = None }

type streamliveinputresponsecollection =
    { errors: Option<list<streamliveinputresponsecollectionErrors>>
      messages: Option<list<streamliveinputresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<streamliveinputresponsecollectionResult> }
    ///Creates an instance of streamliveinputresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinputresponsecollection =
        { errors = None
          messages = None
          success = None
          result = None }

type streamliveinputresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamliveinputresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinputresponsesingleErrorsSource = { pointer = None }

type streamliveinputresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamliveinputresponsesingleErrorsSource> }
    ///Creates an instance of streamliveinputresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamliveinputresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamliveinputresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamliveinputresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinputresponsesingleMessagesSource = { pointer = None }

type streamliveinputresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamliveinputresponsesingleMessagesSource> }
    ///Creates an instance of streamliveinputresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamliveinputresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamliveinputresponsesingle =
    { errors: Option<list<streamliveinputresponsesingleErrors>>
      messages: Option<list<streamliveinputresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      ///Details about a live input.
      result: Option<streamliveinput> }
    ///Creates an instance of streamliveinputresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamliveinputresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

///Specifies a detailed status for a video. If the `state` is `inprogress` or `error`, the `step` field returns `encoding` or `manifest`. If the `state` is `inprogress`, `pctComplete` returns a number between 0 and 100 to indicate the approximate percent of completion. If the `state` is `error`, `errorReasonCode` and `errorReasonText` provide additional details.
type streammediastatus =
    { ///Specifies why the video failed to encode. This field is empty if the video is not in an `error` state. Preferred for programmatic use.
      errorReasonCode: Option<streamerrorReasonCode>
      ///Specifies why the video failed to encode using a human readable error message in English. This field is empty if the video is not in an `error` state.
      errorReasonText: Option<streamerrorReasonText>
      ///Indicates the progress as a percentage between 0 and 100.
      pctComplete: Option<streampctComplete>
      ///Specifies the processing status for all quality levels for a video.
      state: Option<streammediastate> }
    ///Creates an instance of streammediastatus with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streammediastatus =
        { errorReasonCode = None
          errorReasonText = None
          pctComplete = None
          state = None }

type streamoutput =
    { ///When enabled, live video streamed to the associated live input will be sent to the output URL. When disabled, live video will not be sent to the output URL, even when streaming to the associated live input. Use this to control precisely when you start and stop simulcasting to specific destinations like YouTube and Twitch.
      enabled: Option<streamoutputenabled>
      ///The streamKey used to authenticate against an output's target.
      streamKey: Option<streamoutputstreamKey>
      ///A unique identifier for the output.
      uid: Option<streamoutputidentifier>
      ///The URL an output uses to restream.
      url: Option<streamoutputurl> }
    ///Creates an instance of streamoutput with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamoutput =
        { enabled = None
          streamKey = None
          uid = None
          url = None }

type streamoutputresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamoutputresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamoutputresponsecollectionErrorsSource = { pointer = None }

type streamoutputresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamoutputresponsecollectionErrorsSource> }
    ///Creates an instance of streamoutputresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamoutputresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamoutputresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamoutputresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamoutputresponsecollectionMessagesSource = { pointer = None }

type streamoutputresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamoutputresponsecollectionMessagesSource> }
    ///Creates an instance of streamoutputresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamoutputresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamoutputresponsecollection =
    { errors: Option<list<streamoutputresponsecollectionErrors>>
      messages: Option<list<streamoutputresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<streamoutput>> }
    ///Creates an instance of streamoutputresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamoutputresponsecollection =
        { errors = None
          messages = None
          success = None
          result = None }

type streamoutputresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamoutputresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamoutputresponsesingleErrorsSource = { pointer = None }

type streamoutputresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamoutputresponsesingleErrorsSource> }
    ///Creates an instance of streamoutputresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamoutputresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamoutputresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamoutputresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamoutputresponsesingleMessagesSource = { pointer = None }

type streamoutputresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamoutputresponsesingleMessagesSource> }
    ///Creates an instance of streamoutputresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamoutputresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamoutputresponsesingle =
    { errors: Option<list<streamoutputresponsesingleErrors>>
      messages: Option<list<streamoutputresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of streamoutputresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamoutputresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type streamplayback =
    { ///DASH Media Presentation Description for the video.
      dash: Option<string>
      ///The HLS manifest for the video.
      hls: Option<string> }
    ///Creates an instance of streamplayback with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamplayback = { dash = None; hls = None }

///Details for playback from an live input using RTMPS.
type streamplaybackrtmps =
    { ///The secret key to use for playback via RTMPS.
      streamKey: Option<streamplaybackrtmpsstreamkey>
      ///The URL used to play live video over RTMPS.
      url: Option<streamplaybackrtmpsurl> }
    ///Creates an instance of streamplaybackrtmps with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamplaybackrtmps = { streamKey = None; url = None }

///Details for playback from an live input using SRT.
type streamplaybacksrt =
    { ///The secret key to use for playback via SRT.
      passphrase: Option<streamplaybacksrtstreampassphrase>
      ///The identifier of the live input to use for playback via SRT.
      streamId: Option<streamplaybacksrtstreamid>
      ///The URL used to play live video over SRT.
      url: Option<streamplaybacksrturl> }
    ///Creates an instance of streamplaybacksrt with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamplaybacksrt =
        { passphrase = None
          streamId = None
          url = None }

///Details for playback from a live input using WebRTC.
type streamplaybackwebrtc =
    { ///The URL used to play live video over WebRTC.
      url: Option<streamplaybackwebrtcurl> }
    ///Creates an instance of streamplaybackwebrtc with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamplaybackwebrtc = { url = None }

type streamsignedtokenrequest =
    { ///The optional list of access rule constraints on the token. Access can be blocked or allowed based on an IP, IP range, or by country. Access rules are evaluated from first to last. If a rule matches, the associated action is applied and no further rules are evaluated.
      accessRules: Option<list<streamaccessRules>>
      ///The optional boolean value that enables using signed tokens to access MP4 download links for a video.
      downloadable: Option<bool>
      ///The optional unix epoch timestamp that specficies the time after a token is not accepted. The maximum time specification is 24 hours from issuing time. If this field is not set, the default is one hour after issuing.
      exp: Option<int>
      ///The optional ID of a Stream signing key. If present, the `pem` field is also required.
      id: Option<string>
      ///The optional unix epoch timestamp that specifies the time before a the token is not accepted. If this field is not set, the default is one hour before issuing.
      nbf: Option<int>
      ///The optional base64 encoded private key in PEM format associated with a Stream signing key. If present, the `id` field is also required.
      pem: Option<string> }
    ///Creates an instance of streamsignedtokenrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamsignedtokenrequest =
        { accessRules = None
          downloadable = None
          exp = None
          id = None
          nbf = None
          pem = None }

type streamsignedtokenresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamsignedtokenresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamsignedtokenresponseErrorsSource = { pointer = None }

type streamsignedtokenresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamsignedtokenresponseErrorsSource> }
    ///Creates an instance of streamsignedtokenresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamsignedtokenresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamsignedtokenresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamsignedtokenresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamsignedtokenresponseMessagesSource = { pointer = None }

type streamsignedtokenresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamsignedtokenresponseMessagesSource> }
    ///Creates an instance of streamsignedtokenresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamsignedtokenresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamsignedtokenresponseResult =
    { ///The signed token used with the signed URLs feature.
      token: Option<string> }
    ///Creates an instance of streamsignedtokenresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamsignedtokenresponseResult = { token = None }

type streamsignedtokenresponse =
    { errors: Option<list<streamsignedtokenresponseErrors>>
      messages: Option<list<streamsignedtokenresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<streamsignedtokenresponseResult> }
    ///Creates an instance of streamsignedtokenresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamsignedtokenresponse =
        { errors = None
          messages = None
          success = None
          result = None }

type streamstorageuseresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamstorageuseresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamstorageuseresponseErrorsSource = { pointer = None }

type streamstorageuseresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamstorageuseresponseErrorsSource> }
    ///Creates an instance of streamstorageuseresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamstorageuseresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamstorageuseresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamstorageuseresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamstorageuseresponseMessagesSource = { pointer = None }

type streamstorageuseresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamstorageuseresponseMessagesSource> }
    ///Creates an instance of streamstorageuseresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamstorageuseresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamstorageuseresponseResult =
    { ///A user-defined identifier for the media creator.
      creator: Option<streamcreator>
      ///The total minutes of video content stored in the account.
      totalStorageMinutes: Option<int>
      ///The storage capacity alloted for the account.
      totalStorageMinutesLimit: Option<int>
      ///The total count of videos associated with the account.
      videoCount: Option<int> }
    ///Creates an instance of streamstorageuseresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamstorageuseresponseResult =
        { creator = None
          totalStorageMinutes = None
          totalStorageMinutesLimit = None
          videoCount = None }

type streamstorageuseresponse =
    { errors: Option<list<streamstorageuseresponseErrors>>
      messages: Option<list<streamstorageuseresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<streamstorageuseresponseResult> }
    ///Creates an instance of streamstorageuseresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamstorageuseresponse =
        { errors = None
          messages = None
          success = None
          result = None }

type streamupdateinputrequest =
    { ///Sets the creator ID asssociated with this live input.
      defaultCreator: Option<streamliveinputdefaultcreator>
      ///Indicates the number of days after which the live inputs recordings will be deleted. When a stream completes and the recording is ready, the value is used to calculate a scheduled deletion date for that recording. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion.
      deleteRecordingAfterDays: Option<streamliveinputrecordingdeletion>
      ///Indicates whether the live input is enabled and can accept streams.
      enabled: Option<streamliveinputenabled>
      ///A user modifiable key-value store used to reference other systems of record for managing live inputs.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///Records the input to a Cloudflare Stream video. Behavior depends on the mode. In most cases, the video will initially be viewable as a live video and transition to on-demand after a condition is satisfied.
      recording: Option<streamliveinputrecordingsettings> }
    ///Creates an instance of streamupdateinputrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamupdateinputrequest =
        { defaultCreator = None
          deleteRecordingAfterDays = None
          enabled = None
          meta = None
          recording = None }

type streamupdateoutputrequest =
    { ///When enabled, live video streamed to the associated live input will be sent to the output URL. When disabled, live video will not be sent to the output URL, even when streaming to the associated live input. Use this to control precisely when you start and stop simulcasting to specific destinations like YouTube and Twitch.
      enabled: streamoutputenabled }
    ///Creates an instance of streamupdateoutputrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: streamoutputenabled): streamupdateoutputrequest = { enabled = enabled }

type streamvideoClipStandard =
    { ///Lists the origins allowed to display the video. Enter allowed origin domains in an array and use `*` for wildcard subdomains. Empty arrays allow the video to be viewed on any origin.
      allowedOrigins: Option<streamallowedOrigins>
      ///The unique video identifier (UID).
      clippedFromVideoUID: streamclippedfromvideouid
      ///A user-defined identifier for the media creator.
      creator: Option<streamcreator>
      ///Specifies the end time for the video clip in seconds.
      endTimeSeconds: streamendtimeseconds
      ///The maximum duration in seconds for a video upload. Can be set for a video that is not yet uploaded to limit its duration. Uploads that exceed the specified duration will fail during processing. A value of `-1` means the value is unknown.
      maxDurationSeconds: Option<streammaxDurationSeconds>
      ///Indicates whether the video can be a accessed using the UID. When set to `true`, a signed token must be generated with a signing key to view the video.
      requireSignedURLs: Option<streamrequireSignedURLs>
      ///Specifies the start time for the video clip in seconds.
      startTimeSeconds: streamstarttimeseconds
      ///The timestamp for a thumbnail image calculated as a percentage value of the video's duration. To convert from a second-wise timestamp to a percentage, divide the desired timestamp by the total duration of the video.  If this value is not set, the default thumbnail image is taken from 0s of the video.
      thumbnailTimestampPct: Option<streamthumbnailTimestampPct>
      watermark: Option<streamwatermarkAtUpload> }
    ///Creates an instance of streamvideoClipStandard with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (clippedFromVideoUID: streamclippedfromvideouid,
                          endTimeSeconds: streamendtimeseconds,
                          startTimeSeconds: streamstarttimeseconds): streamvideoClipStandard =
        { allowedOrigins = None
          clippedFromVideoUID = clippedFromVideoUID
          creator = None
          endTimeSeconds = endTimeSeconds
          maxDurationSeconds = None
          requireSignedURLs = None
          startTimeSeconds = startTimeSeconds
          thumbnailTimestampPct = None
          watermark = None }

type streamvideocopyrequest =
    { ///Lists the origins allowed to display the video. Enter allowed origin domains in an array and use `*` for wildcard subdomains. Empty arrays allow the video to be viewed on any origin.
      allowedOrigins: Option<streamallowedOrigins>
      ///A user-defined identifier for the media creator.
      creator: Option<streamcreator>
      ///A user modifiable key-value store used to reference other systems of record for managing videos.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///Indicates whether the video can be a accessed using the UID. When set to `true`, a signed token must be generated with a signing key to view the video.
      requireSignedURLs: Option<streamrequireSignedURLs>
      ///Indicates the date and time at which the video will be deleted. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion. If specified, must be at least 30 days from upload time.
      scheduledDeletion: Option<streamscheduledDeletion>
      ///The timestamp for a thumbnail image calculated as a percentage value of the video's duration. To convert from a second-wise timestamp to a percentage, divide the desired timestamp by the total duration of the video.  If this value is not set, the default thumbnail image is taken from 0s of the video.
      thumbnailTimestampPct: Option<streamthumbnailTimestampPct>
      ///A video's URL. The server must be publicly routable and support `HTTP HEAD` requests and `HTTP GET` range requests. The server should respond to `HTTP HEAD` requests with a `content-range` header that includes the size of the file.
      url: string
      watermark: Option<streamwatermarkatupload> }
    ///Creates an instance of streamvideocopyrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (url: string): streamvideocopyrequest =
        { allowedOrigins = None
          creator = None
          meta = None
          requireSignedURLs = None
          scheduledDeletion = None
          thumbnailTimestampPct = None
          url = url
          watermark = None }

type streamvideoresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamvideoresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamvideoresponsecollectionErrorsSource = { pointer = None }

type streamvideoresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamvideoresponsecollectionErrorsSource> }
    ///Creates an instance of streamvideoresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamvideoresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamvideoresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamvideoresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamvideoresponsecollectionMessagesSource = { pointer = None }

type streamvideoresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamvideoresponsecollectionMessagesSource> }
    ///Creates an instance of streamvideoresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamvideoresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamvideoresponsecollection =
    { errors: Option<list<streamvideoresponsecollectionErrors>>
      messages: Option<list<streamvideoresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<streamvideos>>
      ///The total number of remaining videos based on cursor position.
      range: Option<int>
      ///The total number of videos that match the provided filters.
      total: Option<int> }
    ///Creates an instance of streamvideoresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamvideoresponsecollection =
        { errors = None
          messages = None
          success = None
          result = None
          range = None
          total = None }

type streamvideoresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamvideoresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamvideoresponsesingleErrorsSource = { pointer = None }

type streamvideoresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamvideoresponsesingleErrorsSource> }
    ///Creates an instance of streamvideoresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamvideoresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamvideoresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamvideoresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamvideoresponsesingleMessagesSource = { pointer = None }

type streamvideoresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamvideoresponsesingleMessagesSource> }
    ///Creates an instance of streamvideoresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamvideoresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamvideoresponsesingle =
    { errors: Option<list<streamvideoresponsesingleErrors>>
      messages: Option<list<streamvideoresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<streamvideos> }
    ///Creates an instance of streamvideoresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamvideoresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type streamvideoupdate =
    { ///Lists the origins allowed to display the video. Enter allowed origin domains in an array and use `*` for wildcard subdomains. Empty arrays allow the video to be viewed on any origin.
      allowedOrigins: Option<streamallowedOrigins>
      ///A user-defined identifier for the media creator.
      creator: Option<streamcreator>
      ///The maximum duration in seconds for a video upload. Can be set for a video that is not yet uploaded to limit its duration. Uploads that exceed the specified duration will fail during processing. A value of `-1` means the value is unknown.
      maxDurationSeconds: Option<streammaxDurationSeconds>
      ///A user modifiable key-value store used to reference other systems of record for managing videos.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///Indicates whether the video can be a accessed using the UID. When set to `true`, a signed token must be generated with a signing key to view the video.
      requireSignedURLs: Option<streamrequireSignedURLs>
      ///Indicates the date and time at which the video will be deleted. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion. If specified, must be at least 30 days from upload time.
      scheduledDeletion: Option<streamscheduledDeletion>
      ///The timestamp for a thumbnail image calculated as a percentage value of the video's duration. To convert from a second-wise timestamp to a percentage, divide the desired timestamp by the total duration of the video.  If this value is not set, the default thumbnail image is taken from 0s of the video.
      thumbnailTimestampPct: Option<streamthumbnailTimestampPct>
      ///The date and time when the video upload URL is no longer valid for direct user uploads.
      uploadExpiry: Option<streamoneTimeUploadExpiry> }
    ///Creates an instance of streamvideoupdate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamvideoupdate =
        { allowedOrigins = None
          creator = None
          maxDurationSeconds = None
          meta = None
          requireSignedURLs = None
          scheduledDeletion = None
          thumbnailTimestampPct = None
          uploadExpiry = None }

type streamvideos =
    { ///Lists the origins allowed to display the video. Enter allowed origin domains in an array and use `*` for wildcard subdomains. Empty arrays allow the video to be viewed on any origin.
      allowedOrigins: Option<streamallowedOrigins>
      ///The date and time the media item was created.
      created: Option<streamcreated>
      ///A user-defined identifier for the media creator.
      creator: Option<streamcreator>
      ///The duration of the video in seconds. A value of `-1` means the duration is unknown. The duration becomes available after the upload and before the video is ready.
      duration: Option<streamduration>
      input: Option<streaminput>
      ///The live input ID used to upload a video with Stream Live.
      liveInput: Option<streamliveInput>
      ///The maximum duration in seconds for a video upload. Can be set for a video that is not yet uploaded to limit its duration. Uploads that exceed the specified duration will fail during processing. A value of `-1` means the value is unknown.
      maxDurationSeconds: Option<streammaxDurationSeconds>
      ///A user modifiable key-value store used to reference other systems of record for managing videos.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///The date and time the media item was last modified.
      modified: Option<streammodified>
      playback: Option<streamplayback>
      ///The video's preview page URI. This field is omitted until encoding is complete.
      preview: Option<streampreview>
      ///Indicates whether the video is playable. The field is empty if the video is not ready for viewing or the live stream is still in progress.
      readyToStream: Option<streamreadyToStream>
      ///Indicates the time at which the video became playable. The field is empty if the video is not ready for viewing or the live stream is still in progress.
      readyToStreamAt: Option<streamreadyToStreamAt>
      ///Indicates whether the video can be a accessed using the UID. When set to `true`, a signed token must be generated with a signing key to view the video.
      requireSignedURLs: Option<streamrequireSignedURLs>
      ///Indicates the date and time at which the video will be deleted. Omit the field to indicate no change, or include with a `null` value to remove an existing scheduled deletion. If specified, must be at least 30 days from upload time.
      scheduledDeletion: Option<streamscheduledDeletion>
      ///The size of the media item in bytes.
      size: Option<streamsize>
      ///Specifies a detailed status for a video. If the `state` is `inprogress` or `error`, the `step` field returns `encoding` or `manifest`. If the `state` is `inprogress`, `pctComplete` returns a number between 0 and 100 to indicate the approximate percent of completion. If the `state` is `error`, `errorReasonCode` and `errorReasonText` provide additional details.
      status: Option<Newtonsoft.Json.Linq.JToken>
      ///The media item's thumbnail URI. This field is omitted until encoding is complete.
      thumbnail: Option<streamthumbnailurl>
      ///The timestamp for a thumbnail image calculated as a percentage value of the video's duration. To convert from a second-wise timestamp to a percentage, divide the desired timestamp by the total duration of the video.  If this value is not set, the default thumbnail image is taken from 0s of the video.
      thumbnailTimestampPct: Option<streamthumbnailTimestampPct>
      ///A Cloudflare-generated unique identifier for a media item.
      uid: Option<streamidentifier>
      ///The date and time when the video upload URL is no longer valid for direct user uploads.
      uploadExpiry: Option<streamoneTimeUploadExpiry>
      ///The date and time the media item was uploaded.
      uploaded: Option<streamuploaded>
      watermark: Option<streamwatermarks> }
    ///Creates an instance of streamvideos with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamvideos =
        { allowedOrigins = None
          created = None
          creator = None
          duration = None
          input = None
          liveInput = None
          maxDurationSeconds = None
          meta = None
          modified = None
          playback = None
          preview = None
          readyToStream = None
          readyToStreamAt = None
          requireSignedURLs = None
          scheduledDeletion = None
          size = None
          status = None
          thumbnail = None
          thumbnailTimestampPct = None
          uid = None
          uploadExpiry = None
          uploaded = None
          watermark = None }

type streamwatermarkAtUpload =
    { ///The unique identifier for the watermark profile.
      uid: Option<string> }
    ///Creates an instance of streamwatermarkAtUpload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwatermarkAtUpload = { uid = None }

type streamwatermarkatupload =
    { ///The unique identifier for the watermark profile.
      uid: Option<string> }
    ///Creates an instance of streamwatermarkatupload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwatermarkatupload = { uid = None }

type streamwatermarkbasicupload =
    { ///The image file to upload.
      file: string
      ///A short description of the watermark profile.
      name: Option<streamname>
      ///The translucency of the image. A value of `0.0` makes the image completely transparent, and `1.0` makes the image completely opaque. Note that if the image is already semi-transparent, setting this to `1.0` will not make the image completely opaque.
      opacity: Option<streamopacity>
      ///The whitespace between the adjacent edges (determined by position) of the video and the image. `0.0` indicates no padding, and `1.0` indicates a fully padded video width or length, as determined by the algorithm.
      padding: Option<streampadding>
      ///The location of the image. Valid positions are: `upperRight`, `upperLeft`, `lowerLeft`, `lowerRight`, and `center`. Note that `center` ignores the `padding` parameter.
      position: Option<streamposition>
      ///The size of the image relative to the overall size of the video. This parameter will adapt to horizontal and vertical videos automatically. `0.0` indicates no scaling (use the size of the image as-is), and `1.0 `fills the entire video.
      scale: Option<streamscale> }
    ///Creates an instance of streamwatermarkbasicupload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (file: string): streamwatermarkbasicupload =
        { file = file
          name = None
          opacity = None
          padding = None
          position = None
          scale = None }

type streamwatermarkresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamwatermarkresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwatermarkresponsecollectionErrorsSource = { pointer = None }

type streamwatermarkresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamwatermarkresponsecollectionErrorsSource> }
    ///Creates an instance of streamwatermarkresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamwatermarkresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamwatermarkresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamwatermarkresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwatermarkresponsecollectionMessagesSource = { pointer = None }

type streamwatermarkresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamwatermarkresponsecollectionMessagesSource> }
    ///Creates an instance of streamwatermarkresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamwatermarkresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamwatermarkresponsecollection =
    { errors: Option<list<streamwatermarkresponsecollectionErrors>>
      messages: Option<list<streamwatermarkresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<streamwatermarks>> }
    ///Creates an instance of streamwatermarkresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwatermarkresponsecollection =
        { errors = None
          messages = None
          success = None
          result = None }

type streamwatermarkresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamwatermarkresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwatermarkresponsesingleErrorsSource = { pointer = None }

type streamwatermarkresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamwatermarkresponsesingleErrorsSource> }
    ///Creates an instance of streamwatermarkresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamwatermarkresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamwatermarkresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamwatermarkresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwatermarkresponsesingleMessagesSource = { pointer = None }

type streamwatermarkresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamwatermarkresponsesingleMessagesSource> }
    ///Creates an instance of streamwatermarkresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamwatermarkresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamwatermarkresponsesingle =
    { errors: Option<list<streamwatermarkresponsesingleErrors>>
      messages: Option<list<streamwatermarkresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<streamwatermarks> }
    ///Creates an instance of streamwatermarkresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwatermarkresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type streamwatermarks =
    { ///The date and a time a watermark profile was created.
      created: Option<streamwatermarkcreated>
      ///The source URL for a downloaded image. If the watermark profile was created via direct upload, this field is null.
      downloadedFrom: Option<streamdownloadedFrom>
      ///The height of the image in pixels.
      height: Option<streamheight>
      ///A short description of the watermark profile.
      name: Option<streamname>
      ///The translucency of the image. A value of `0.0` makes the image completely transparent, and `1.0` makes the image completely opaque. Note that if the image is already semi-transparent, setting this to `1.0` will not make the image completely opaque.
      opacity: Option<streamopacity>
      ///The whitespace between the adjacent edges (determined by position) of the video and the image. `0.0` indicates no padding, and `1.0` indicates a fully padded video width or length, as determined by the algorithm.
      padding: Option<streampadding>
      ///The location of the image. Valid positions are: `upperRight`, `upperLeft`, `lowerLeft`, `lowerRight`, and `center`. Note that `center` ignores the `padding` parameter.
      position: Option<streamposition>
      ///The size of the image relative to the overall size of the video. This parameter will adapt to horizontal and vertical videos automatically. `0.0` indicates no scaling (use the size of the image as-is), and `1.0 `fills the entire video.
      scale: Option<streamscale>
      ///The size of the image in bytes.
      size: Option<streamwatermarksize>
      ///The unique identifier for a watermark profile.
      uid: Option<streamwatermarkidentifier>
      ///The width of the image in pixels.
      width: Option<streamwidth> }
    ///Creates an instance of streamwatermarks with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwatermarks =
        { created = None
          downloadedFrom = None
          height = None
          name = None
          opacity = None
          padding = None
          position = None
          scale = None
          size = None
          uid = None
          width = None }

type streamwebhookrequest =
    { ///The URL where webhooks will be sent.
      notificationUrl: streamnotificationUrl }
    ///Creates an instance of streamwebhookrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (notificationUrl: streamnotificationUrl): streamwebhookrequest =
        { notificationUrl = notificationUrl }

type streamwebhookresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of streamwebhookresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwebhookresponsesingleErrorsSource = { pointer = None }

type streamwebhookresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamwebhookresponsesingleErrorsSource> }
    ///Creates an instance of streamwebhookresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamwebhookresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamwebhookresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of streamwebhookresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwebhookresponsesingleMessagesSource = { pointer = None }

type streamwebhookresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<streamwebhookresponsesingleMessagesSource> }
    ///Creates an instance of streamwebhookresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): streamwebhookresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type streamwebhookresponsesingle =
    { errors: Option<list<streamwebhookresponsesingleErrors>>
      messages: Option<list<streamwebhookresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of streamwebhookresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): streamwebhookresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

[<RequireQualifiedAccess>]
type StreamVideosListVideos =
    ///List videos response.
    | OK of payload: streamvideoresponsecollection

[<RequireQualifiedAccess>]
type StreamVideosInitiateVideoUploadsUsingTus =
    ///Initiate video uploads using TUS response.
    | OK of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type StreamVideoClippingClipVideosGivenAStartAndEndTime =
    ///Clip videos given a start and end time response.
    | OK of payload: streamclipResponseSingle

[<RequireQualifiedAccess>]
type StreamVideosUploadVideosFromAUrl =
    ///Upload videos from a URL response.
    | OK of payload: streamvideoresponsesingle

[<RequireQualifiedAccess>]
type StreamVideosUploadVideosViaDirectUploadUrLs =
    ///Upload videos via direct upload URLs response.
    | OK of payload: streamdirectuploadresponse

[<RequireQualifiedAccess>]
type StreamSigningKeysListSigningKeys =
    ///List signing keys response.
    | OK of payload: streamkeyresponsecollection

[<RequireQualifiedAccess>]
type StreamSigningKeysCreateSigningKeys =
    ///Create signing keys response.
    | OK of payload: streamkeygenerationresponse

[<RequireQualifiedAccess>]
type StreamSigningKeysDeleteSigningKeys =
    ///Delete signing keys response.
    | OK of payload: streamdeletedresponse

[<RequireQualifiedAccess>]
type StreamLiveInputsListLiveInputs =
    ///List live inputs response.
    | OK of payload: streamliveinputresponsecollection

[<RequireQualifiedAccess>]
type StreamLiveInputsCreateALiveInput =
    ///Create a live input response.
    | OK of payload: streamliveinputresponsesingle

[<RequireQualifiedAccess>]
type StreamLiveInputsDeleteALiveInput =
    ///Delete a live input response.
    | OK of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type StreamLiveInputsRetrieveALiveInput =
    ///Retrieve a live input response.
    | OK of payload: streamliveinputresponsesingle

[<RequireQualifiedAccess>]
type StreamLiveInputsUpdateALiveInput =
    ///Update a live input response.
    | OK of payload: streamliveinputresponsesingle

[<RequireQualifiedAccess>]
type StreamLiveInputsDisableALiveInput =
    ///Disable a live input response.
    | OK of payload: streamliveinputresponsesingle

[<RequireQualifiedAccess>]
type StreamLiveInputsEnableALiveInput =
    ///Enable a live input response.
    | OK of payload: streamliveinputresponsesingle

[<RequireQualifiedAccess>]
type StreamLiveInputsListAllOutputsAssociatedWithASpecifiedLiveInput =
    ///List all outputs associated with a specified live input response.
    | OK of payload: streamoutputresponsecollection

[<RequireQualifiedAccess>]
type ``StreamLiveInputsCreateANewOutput,ConnectedToALiveInput`` =
    ///Create a new output, connected to a live input response.
    | OK of payload: streamoutputresponsesingle

[<RequireQualifiedAccess>]
type StreamLiveInputsDeleteAnOutput =
    ///Delete an output response.
    | OK of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type StreamLiveInputsUpdateAnOutput =
    ///Update an output response.
    | OK of payload: streamoutputresponsesingle

[<RequireQualifiedAccess>]
type StreamVideosStorageUsage =
    ///Returns information about an account's storage use response.
    | OK of payload: streamstorageuseresponse

[<RequireQualifiedAccess>]
type StreamWatermarkProfileListWatermarkProfiles =
    ///List watermark profiles response.
    | OK of payload: streamwatermarkresponsecollection

[<RequireQualifiedAccess>]
type StreamWatermarkProfileCreateWatermarkProfilesViaBasicUpload =
    ///Create watermark profiles via basic upload response.
    | OK of payload: streamwatermarkresponsesingle

[<RequireQualifiedAccess>]
type StreamWatermarkProfileDeleteWatermarkProfiles =
    ///Delete watermark profiles response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type StreamWatermarkProfileWatermarkProfileDetails =
    ///Watermark profile details response.
    | OK of payload: streamwatermarkresponsesingle

[<RequireQualifiedAccess>]
type StreamWebhookDeleteWebhooks =
    ///Delete webhooks response.
    | OK of payload: streamdeletedresponse

[<RequireQualifiedAccess>]
type StreamWebhookViewWebhooks =
    ///View webhooks response.
    | OK of payload: streamwebhookresponsesingle

[<RequireQualifiedAccess>]
type StreamWebhookCreateWebhooks =
    ///Create webhooks response.
    | OK of payload: streamwebhookresponsesingle

[<RequireQualifiedAccess>]
type StreamVideosDeleteVideo =
    ///Delete video response.
    | OK of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type StreamVideosRetrieveVideoDetails =
    ///Retrieve video details response.
    | OK of payload: streamvideoresponsesingle

[<RequireQualifiedAccess>]
type StreamVideosUpdateVideoDetails =
    ///Edit video details response.
    | OK of payload: streamvideoresponsesingle

[<RequireQualifiedAccess>]
type ListAudioTracks =
    ///Lists additional audio tracks on a video.
    | OK of payload: streamlistAudioTrackResponse

[<RequireQualifiedAccess>]
type AddAudioTrack =
    ///Add audio tracks to a video.
    | OK of payload: streamaddAudioTrackResponse

[<RequireQualifiedAccess>]
type DeleteAudioTracks =
    ///Deletes additional audio tracks on a video.
    | OK of payload: streamdeletedresponse

[<RequireQualifiedAccess>]
type EditAudioTracks =
    ///Edits additional audio tracks on a video.
    | OK of payload: streamaddAudioTrackResponse

[<RequireQualifiedAccess>]
type StreamSubtitlesCaptionsListCaptionsOrSubtitles =
    ///List captions or subtitles response.
    | OK of payload: streamlanguageresponsecollection

[<RequireQualifiedAccess>]
type StreamSubtitlesCaptionsDeleteCaptionsOrSubtitles =
    ///Delete captions or subtitles response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type StreamSubtitlesCaptionsGetCaptionOrSubtitleForLanguage =
    ///List captions or subtitles response for a provided language.
    | OK of payload: streamlanguageresponsesingle

[<RequireQualifiedAccess>]
type StreamSubtitlesCaptionsUploadCaptionsOrSubtitles =
    ///Upload captions or subtitles response.
    | OK of payload: streamlanguageresponsesingle

[<RequireQualifiedAccess>]
type StreamSubtitlesCaptionsGenerateCaptionOrSubtitleForLanguage =
    ///Generate captions or subtitles response for a provided language.
    | OK of payload: streamlanguageresponsesingle

[<RequireQualifiedAccess>]
type StreamSubtitlesCaptionsGetVttCaptionOrSubtitle =
    ///Return WebVTT caption or subtitle response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type StreamMP4DownloadsDeleteDownloads =
    ///Delete downloads response.
    | OK of payload: streamdeletedresponse

[<RequireQualifiedAccess>]
type StreamMP4DownloadsListDownloads =
    ///List downloads response.
    | OK of payload: streamdownloadsresponse

[<RequireQualifiedAccess>]
type StreamMP4DownloadsCreateDownloads =
    ///Create downloads response.
    | OK of payload: streamdownloadsresponsesingle

[<RequireQualifiedAccess>]
type StreamDownloadsDeleteTypeSpecificDownloads =
    ///Delete downloads response.
    | OK of payload: streamdeletedresponse

[<RequireQualifiedAccess>]
type StreamDownloadsCreateTypeSpecificDownloads =
    ///Create download of specified type response.
    | OK of payload: streamdownloadsresponse

[<RequireQualifiedAccess>]
type StreamVideosRetreieveEmbedCodeHtml =
    ///Retreieve embed Code HTML response.
    | OK of payload: string

[<RequireQualifiedAccess>]
type StreamVideosCreateSignedUrlTokensForVideos =
    ///Create signed URL tokens for videos response.
    | OK of payload: streamsignedtokenresponse
