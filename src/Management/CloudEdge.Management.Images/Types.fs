namespace rec Fidelity.CloudEdge.Management.Images.Types

///Account identifier tag.
type imagesaccountidentifier = string
///Can set the creator field with an internal user ID.
type imagesimagecreator = string
///Image file name.
type imagesimagefilename = string
///URI to hero variant for an image.
type imagesimageherourl = string
///Image unique identifier.
type imagesimageidentifier = string
///Key name.
type imagesimagekeyname = string
///Key value.
type imagesimagekeyvalue = string
///URI to original variant for an image.
type imagesimageoriginalurl = string
type imagesimagerequireSignedURLs = bool
///URI to thumbnail variant for an image.
type imagesimagethumbnailurl = string
///When the media item was uploaded.
type imagesimageuploaded = System.DateTimeOffset

///The fit property describes how the width and height dimensions should be interpreted.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type imagesimagevariantfit =
    | [<CompiledName "scale-down">] ScaleDown
    | [<CompiledName "contain">] Contain
    | [<CompiledName "cover">] Cover
    | [<CompiledName "crop">] Crop
    | [<CompiledName "pad">] Pad
    member this.Format() =
        match this with
        | ScaleDown -> "scale-down"
        | Contain -> "contain"
        | Cover -> "cover"
        | Crop -> "crop"
        | Pad -> "pad"

type imagesimagevariantheight = float
type imagesimagevariantidentifier = string
type imagesimagevariantneverRequireSignedURLs = bool

///What EXIF data should be preserved in the output image.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type imagesimagevariantschemasmetadata =
    | [<CompiledName "keep">] Keep
    | [<CompiledName "copyright">] Copyright
    | [<CompiledName "none">] None
    member this.Format() =
        match this with
        | Keep -> "keep"
        | Copyright -> "copyright"
        | None -> "none"

type imagesimagevariantwidth = float
///Continuation token to fetch next page. Passed as a query param when requesting List V2 api endpoint.
type imagesimageslistcontinuationtoken = string
type imagesimagesstatsallowed = float

// Type aliases for Hawaii sanitization compatibility
type imagesimagevariants = imagesimagevariantsresponse
type imagesimagesstatscurrent = float

type imagesmessagesArrayItem =
    { code: int
      message: string }
    ///Creates an instance of imagesmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesmessagesArrayItem = { code = code; message = message }

type imagesmessages = list<imagesmessagesArrayItem>
type imagessigningkeyidentifier = string

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

type Result =
    { ///Continuation token to fetch next page. Passed as a query param when requesting List V2 api endpoint.
      continuation_token: Option<imagesimageslistcontinuationtoken> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result = { continuation_token = None }

type ``imagesapi-response-collection-v2`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesapi-response-collection-v2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``imagesapi-response-collection-v2`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``imagesapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of imagesapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``imagesapi-response-commonErrors`` =
        { code = code; message = message }

type ``imagesapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of imagesapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``imagesapi-response-commonMessages`` =
        { code = code; message = message }

type ``imagesapi-response-common`` =
    { errors: list<``imagesapi-response-commonErrors``>
      messages: list<``imagesapi-response-commonMessages``>
      result: Newtonsoft.Json.Linq.JToken
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of imagesapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``imagesapi-response-commonErrors``>,
                          messages: list<``imagesapi-response-commonMessages``>,
                          result: Newtonsoft.Json.Linq.JToken,
                          success: bool): ``imagesapi-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``imagesapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of imagesapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``imagesapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``imagesapi-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of imagesapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``imagesapi-response-singleErrors`` =
        { code = code; message = message }

type ``imagesapi-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of imagesapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``imagesapi-response-singleMessages`` =
        { code = code; message = message }

type ``imagesapi-response-single`` =
    { errors: Option<list<``imagesapi-response-singleErrors``>>
      messages: Option<list<``imagesapi-response-singleMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``imagesapi-response-single`` =
        { errors = None
          messages = None
          result = None
          success = None }

type imagesdeletedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of imagesdeletedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesdeletedresponseErrors = { code = code; message = message }

type imagesdeletedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of imagesdeletedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesdeletedresponseMessages =
        { code = code; message = message }

type imagesdeletedresponse =
    { errors: Option<list<imagesdeletedresponseErrors>>
      messages: Option<list<imagesdeletedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesdeletedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesdeletedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type imagesimage =
    { ///Can set the creator field with an internal user ID.
      creator: Option<imagesimagecreator>
      ///Image file name.
      filename: Option<imagesimagefilename>
      ///Image unique identifier.
      id: Option<imagesimageidentifier>
      ///User modifiable key-value store. Can be used for keeping references to another system of record for managing images. Metadata must not exceed 1024 bytes.
      meta: Option<Newtonsoft.Json.Linq.JObject>
      ///Indicates whether the image can be a accessed only using it's UID. If set to true, a signed token needs to be generated with a signing key to view the image.
      requireSignedURLs: Option<imagesimagerequireSignedURLs>
      ///When the media item was uploaded.
      uploaded: Option<imagesimageuploaded>
      ///Object specifying available variants for an image.
      variants: Option<imagesimagevariants> }
    ///Creates an instance of imagesimage with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimage =
        { creator = None
          filename = None
          id = None
          meta = None
          requireSignedURLs = None
          uploaded = None
          variants = None }

type imagesimagebasicupload =
    { ///Can set the creator field with an internal user ID.
      creator: Option<string>
      ///An image binary data. Only needed when type is uploading a file.
      file: Option<string>
      ///An optional custom unique identifier for your image.
      id: Option<string>
      ///User modifiable key-value store. Can use used for keeping references to another system of record for managing images.
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      ///Indicates whether the image requires a signature token for the access.
      requireSignedURLs: Option<bool>
      ///A URL to fetch an image from origin. Only needed when type is uploading from a URL.
      url: Option<string> }
    ///Creates an instance of imagesimagebasicupload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagebasicupload =
        { creator = None
          file = None
          id = None
          metadata = None
          requireSignedURLs = None
          url = None }

type imagesimagedirectuploadrequestv2 =
    { ///Can set the creator field with an internal user ID.
      creator: Option<string>
      ///The date after which the upload will not be accepted. Minimum: Now + 2 minutes. Maximum: Now + 6 hours.
      expiry: Option<System.DateTimeOffset>
      ///Optional Image Custom ID. Up to 1024 chars. Can include any number of subpaths, and utf8 characters. Cannot start nor end with a / (forward slash). Cannot be a UUID.
      id: Option<string>
      ///User modifiable key-value store. Can be used for keeping references to another system of record, for managing images.
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      ///Indicates whether the image requires a signature token to be accessed.
      requireSignedURLs: Option<bool> }
    ///Creates an instance of imagesimagedirectuploadrequestv2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagedirectuploadrequestv2 =
        { creator = None
          expiry = None
          id = None
          metadata = None
          requireSignedURLs = None }

type imagesimagedirectuploadresponsev2Errors =
    { code: int
      message: string }
    ///Creates an instance of imagesimagedirectuploadresponsev2Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagedirectuploadresponsev2Errors =
        { code = code; message = message }

type imagesimagedirectuploadresponsev2Messages =
    { code: int
      message: string }
    ///Creates an instance of imagesimagedirectuploadresponsev2Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagedirectuploadresponsev2Messages =
        { code = code; message = message }

type imagesimagedirectuploadresponsev2 =
    { errors: Option<list<imagesimagedirectuploadresponsev2Errors>>
      messages: Option<list<imagesimagedirectuploadresponsev2Messages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesimagedirectuploadresponsev2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagedirectuploadresponsev2 =
        { errors = None
          messages = None
          result = None
          success = None }

type imagesimagekeyresponsecollectionErrors =
    { code: int
      message: string }
    ///Creates an instance of imagesimagekeyresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagekeyresponsecollectionErrors =
        { code = code; message = message }

type imagesimagekeyresponsecollectionMessages =
    { code: int
      message: string }
    ///Creates an instance of imagesimagekeyresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagekeyresponsecollectionMessages =
        { code = code; message = message }

type imagesimagekeyresponsecollection =
    { errors: Option<list<imagesimagekeyresponsecollectionErrors>>
      messages: Option<list<imagesimagekeyresponsecollectionMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesimagekeyresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagekeyresponsecollection =
        { errors = None
          messages = None
          result = None
          success = None }

type imagesimagekeys =
    { ///Key name.
      name: Option<imagesimagekeyname>
      ///Key value.
      value: Option<imagesimagekeyvalue> }
    ///Creates an instance of imagesimagekeys with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagekeys = { name = None; value = None }

type imagesimagekeysresponse =
    { keys: Option<list<imagesimagekeys>> }
    ///Creates an instance of imagesimagekeysresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagekeysresponse = { keys = None }

type imagesimagepatchrequest =
    { ///Can set the creator field with an internal user ID.
      creator: Option<string>
      ///User modifiable key-value store. Can be used for keeping references to another system of record for managing images. No change if not specified.
      metadata: Option<Newtonsoft.Json.Linq.JObject>
      ///Indicates whether the image can be accessed using only its UID. If set to `true`, a signed token needs to be generated with a signing key to view the image. Returns a new UID on a change. No change if not specified.
      requireSignedURLs: Option<bool> }
    ///Creates an instance of imagesimagepatchrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagepatchrequest =
        { creator = None
          metadata = None
          requireSignedURLs = None }

type imagesimageresponsesingleErrors =
    { code: int
      message: string }
    ///Creates an instance of imagesimageresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimageresponsesingleErrors =
        { code = code; message = message }

type imagesimageresponsesingleMessages =
    { code: int
      message: string }
    ///Creates an instance of imagesimageresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimageresponsesingleMessages =
        { code = code; message = message }

type imagesimageresponsesingle =
    { errors: Option<list<imagesimageresponsesingleErrors>>
      messages: Option<list<imagesimageresponsesingleMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesimageresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimageresponsesingle =
        { errors = None
          messages = None
          result = None
          success = None }

type imagesimagevariantdefinition =
    { id: imagesimagevariantidentifier
      ///Indicates whether the variant can access an image without a signature, regardless of image access control.
      neverRequireSignedURLs: Option<imagesimagevariantneverRequireSignedURLs>
      ///Allows you to define image resizing sizes for different use cases.
      options: imagesimagevariantoptions }
    ///Creates an instance of imagesimagevariantdefinition with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: imagesimagevariantidentifier, options: imagesimagevariantoptions): imagesimagevariantdefinition =
        { id = id
          neverRequireSignedURLs = None
          options = options }

type imagesimagevariantlistresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of imagesimagevariantlistresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagevariantlistresponseErrors =
        { code = code; message = message }

type imagesimagevariantlistresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of imagesimagevariantlistresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagevariantlistresponseMessages =
        { code = code; message = message }

type imagesimagevariantlistresponse =
    { errors: Option<list<imagesimagevariantlistresponseErrors>>
      messages: Option<list<imagesimagevariantlistresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesimagevariantlistresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagevariantlistresponse =
        { errors = None
          messages = None
          result = None
          success = None }

///Allows you to define image resizing sizes for different use cases.
type imagesimagevariantoptions =
    { ///The fit property describes how the width and height dimensions should be interpreted.
      fit: imagesimagevariantfit
      ///Maximum height in image pixels.
      height: imagesimagevariantheight
      ///What EXIF data should be preserved in the output image.
      metadata: imagesimagevariantschemasmetadata
      ///Maximum width in image pixels.
      width: imagesimagevariantwidth }
    ///Creates an instance of imagesimagevariantoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (fit: imagesimagevariantfit,
                          height: imagesimagevariantheight,
                          metadata: imagesimagevariantschemasmetadata,
                          width: imagesimagevariantwidth): imagesimagevariantoptions =
        { fit = fit
          height = height
          metadata = metadata
          width = width }

type imagesimagevariantpatchrequest =
    { ///Indicates whether the variant can access an image without a signature, regardless of image access control.
      neverRequireSignedURLs: Option<imagesimagevariantneverRequireSignedURLs>
      ///Allows you to define image resizing sizes for different use cases.
      options: imagesimagevariantoptions }
    ///Creates an instance of imagesimagevariantpatchrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (options: imagesimagevariantoptions): imagesimagevariantpatchrequest =
        { neverRequireSignedURLs = None
          options = options }

type Hero =
    { id: imagesimagevariantidentifier
      ///Indicates whether the variant can access an image without a signature, regardless of image access control.
      neverRequireSignedURLs: Option<imagesimagevariantneverRequireSignedURLs>
      ///Allows you to define image resizing sizes for different use cases.
      options: imagesimagevariantoptions }
    ///Creates an instance of Hero with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: imagesimagevariantidentifier, options: imagesimagevariantoptions): Hero =
        { id = id
          neverRequireSignedURLs = None
          options = options }

type imagesimagevariantpublicrequest =
    { hero: Option<Hero> }
    ///Creates an instance of imagesimagevariantpublicrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagevariantpublicrequest = { hero = None }

type imagesimagevariantresponse =
    { variant: Option<imagesimagevariantdefinition> }
    ///Creates an instance of imagesimagevariantresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagevariantresponse = { variant = None }

type imagesimagevariantsimpleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of imagesimagevariantsimpleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagevariantsimpleresponseErrors =
        { code = code; message = message }

type imagesimagevariantsimpleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of imagesimagevariantsimpleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagevariantsimpleresponseMessages =
        { code = code; message = message }

type imagesimagevariantsimpleresponse =
    { errors: Option<list<imagesimagevariantsimpleresponseErrors>>
      messages: Option<list<imagesimagevariantsimpleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesimagevariantsimpleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagevariantsimpleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type imagesimagevariantsresponse =
    { variants: Option<imagesimagevariantpublicrequest> }
    ///Creates an instance of imagesimagevariantsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagevariantsresponse = { variants = None }

type imagesimageslistresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of imagesimageslistresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimageslistresponseErrors =
        { code = code; message = message }

type imagesimageslistresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of imagesimageslistresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimageslistresponseMessages =
        { code = code; message = message }

type imagesimageslistresponseResult =
    { images: Option<list<imagesimage>> }
    ///Creates an instance of imagesimageslistresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimageslistresponseResult = { images = None }

type imagesimageslistresponse =
    { errors: Option<list<imagesimageslistresponseErrors>>
      messages: Option<list<imagesimageslistresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesimageslistresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimageslistresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type imagesimageslistresponsev2Errors =
    { code: int
      message: string }
    ///Creates an instance of imagesimageslistresponsev2Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimageslistresponsev2Errors =
        { code = code; message = message }

type imagesimageslistresponsev2Messages =
    { code: int
      message: string }
    ///Creates an instance of imagesimageslistresponsev2Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimageslistresponsev2Messages =
        { code = code; message = message }

type imagesimageslistresponsev2Result =
    { ///Continuation token to fetch next page. Passed as a query param when requesting List V2 api endpoint.
      continuation_token: Option<imagesimageslistcontinuationtoken> }
    ///Creates an instance of imagesimageslistresponsev2Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimageslistresponsev2Result = { continuation_token = None }

type ResultFromimagesimageslistresponsev2 =
    { images: Option<list<imagesimage>> }
    ///Creates an instance of ResultFromimagesimageslistresponsev2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ResultFromimagesimageslistresponsev2 = { images = None }

type imagesimageslistresponsev2 =
    { errors: Option<list<imagesimageslistresponsev2Errors>>
      messages: Option<list<imagesimageslistresponsev2Messages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesimageslistresponsev2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimageslistresponsev2 =
        { errors = None
          messages = None
          result = None
          success = None }

type imagesimagesstats =
    { count: Option<imagesimagesstatscount> }
    ///Creates an instance of imagesimagesstats with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagesstats = { count = None }

type imagesimagesstatscount =
    { ///Cloudflare Images allowed usage.
      allowed: Option<imagesimagesstatsallowed>
      ///Cloudflare Images current usage.
      current: Option<imagesimagesstatscurrent> }
    ///Creates an instance of imagesimagesstatscount with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagesstatscount = { allowed = None; current = None }

type imagesimagesstatsresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of imagesimagesstatsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagesstatsresponseErrors =
        { code = code; message = message }

type imagesimagesstatsresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of imagesimagesstatsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): imagesimagesstatsresponseMessages =
        { code = code; message = message }

type imagesimagesstatsresponse =
    { errors: Option<list<imagesimagesstatsresponseErrors>>
      messages: Option<list<imagesimagesstatsresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of imagesimagesstatsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): imagesimagesstatsresponse =
        { errors = None
          messages = None
          result = None
          success = None }

[<RequireQualifiedAccess>]
type CloudflareImagesListImages =
    ///List images response
    | OK of payload: imagesimageslistresponse

[<RequireQualifiedAccess>]
type CloudflareImagesUploadAnImageViaUrl =
    ///Upload an image response
    | OK of payload: imagesimageresponsesingle

[<RequireQualifiedAccess>]
type CloudflareImagesKeysListSigningKeys =
    ///List Signing Keys response
    | OK of payload: imagesimagekeyresponsecollection

[<RequireQualifiedAccess>]
type CloudflareImagesKeysDeleteSigningKey =
    ///Delete Signing Key response
    | OK of payload: imagesimagekeyresponsecollection

[<RequireQualifiedAccess>]
type CloudflareImagesKeysAddSigningKey =
    ///Add Signing Key response
    | OK of payload: imagesimagekeyresponsecollection

[<RequireQualifiedAccess>]
type CloudflareImagesImagesUsageStatistics =
    ///Images usage statistics response
    | OK of payload: imagesimagesstatsresponse

[<RequireQualifiedAccess>]
type CloudflareImagesVariantsListVariants =
    ///List variants response
    | OK of payload: imagesimagevariantlistresponse

[<RequireQualifiedAccess>]
type CloudflareImagesVariantsCreateAVariant =
    ///Create a variant response
    | OK of payload: imagesimagevariantsimpleresponse

[<RequireQualifiedAccess>]
type CloudflareImagesVariantsDeleteAVariant =
    ///Delete a variant response
    | OK of payload: imagesdeletedresponse

[<RequireQualifiedAccess>]
type CloudflareImagesVariantsVariantDetails =
    ///Variant details response
    | OK of payload: imagesimagevariantsimpleresponse

[<RequireQualifiedAccess>]
type CloudflareImagesVariantsUpdateAVariant =
    ///Update a variant response
    | OK of payload: imagesimagevariantsimpleresponse

[<RequireQualifiedAccess>]
type CloudflareImagesDeleteImage =
    ///Delete image response
    | OK of payload: imagesdeletedresponse

[<RequireQualifiedAccess>]
type CloudflareImagesImageDetails =
    ///Image details response
    | OK of payload: imagesimageresponsesingle

[<RequireQualifiedAccess>]
type CloudflareImagesUpdateImage =
    ///Update image response
    | OK of payload: imagesimageresponsesingle

[<RequireQualifiedAccess>]
type CloudflareImagesBaseImage =
    ///Base image response. Returns uploaded image data.
    | OK of payload: string

[<RequireQualifiedAccess>]
type CloudflareImagesListImagesV2 =
    ///List images response
    | OK of payload: imagesimageslistresponsev2
    ///Bad request
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type CloudflareImagesCreateAuthenticatedDirectUploadUrlV2 =
    ///Create authenticated direct upload URL V2 response
    | OK of payload: imagesimagedirectuploadresponsev2
