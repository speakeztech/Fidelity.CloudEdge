namespace rec Fidelity.CloudEdge.Management.BrowserRendering.Types

type Errors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type Meta =
    { status: Option<float>
      title: Option<string> }

type BrapiPostContent_OK =
    { errors: Option<list<Errors>>
      meta: Meta
      ///HTML content
      result: Option<string>
      ///Response status
      success: bool }

type BrapiPostContent_BadRequestErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostContent_BadRequest =
    { errors: Option<list<BrapiPostContent_BadRequestErrors>>
      ///Response status
      success: bool }

type BrapiPostContent_UnprocessableEntityErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostContent_UnprocessableEntity =
    { errors: Option<list<BrapiPostContent_UnprocessableEntityErrors>>
      ///Response status
      success: bool }

type BrapiPostContent_InternalServerErrorErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostContent_InternalServerError =
    { errors: Option<list<BrapiPostContent_InternalServerErrorErrors>>
      ///Response status
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostContent =
    ///Returns the page's content
    | OK of payload: BrapiPostContent_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostContent_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostContent_UnprocessableEntity
    ///Internal server error
    | InternalServerError of payload: BrapiPostContent_InternalServerError

type BrapiPostJson_OKErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostJson_OK =
    { errors: Option<list<BrapiPostJson_OKErrors>>
      result: Map<string, Option<string>>
      ///Response status
      success: bool }

type BrapiPostJson_BadRequestErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostJson_BadRequest =
    { errors: Option<list<BrapiPostJson_BadRequestErrors>>
      ///Response status
      success: bool }

type BrapiPostJson_UnprocessableEntityErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostJson_UnprocessableEntity =
    { errors: Option<list<BrapiPostJson_UnprocessableEntityErrors>>
      ///Raw AI response will be returned, if it couldn't be parsed into valid JSON.
      rawAiResponse: Option<string>
      ///Response status
      success: bool }

type BrapiPostJson_InternalServerErrorErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostJson_InternalServerError =
    { errors: Option<list<BrapiPostJson_InternalServerErrorErrors>>
      ///Response status
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostJson =
    ///Returns the JSON based on a user prompt or json schema
    | OK of payload: BrapiPostJson_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostJson_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostJson_UnprocessableEntity
    ///Internal server error
    | InternalServerError of payload: BrapiPostJson_InternalServerError

type BrapiPostLinks_OKErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostLinks_OK =
    { errors: Option<list<BrapiPostLinks_OKErrors>>
      result: list<string>
      ///Response status
      success: bool }

type BrapiPostLinks_BadRequestErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostLinks_BadRequest =
    { errors: Option<list<BrapiPostLinks_BadRequestErrors>>
      ///Response status
      success: bool }

type BrapiPostLinks_UnprocessableEntityErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostLinks_UnprocessableEntity =
    { errors: Option<list<BrapiPostLinks_UnprocessableEntityErrors>>
      ///Response status
      success: bool }

type BrapiPostLinks_InternalServerErrorErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostLinks_InternalServerError =
    { errors: Option<list<BrapiPostLinks_InternalServerErrorErrors>>
      ///Response status
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostLinks =
    ///Returns the links
    | OK of payload: BrapiPostLinks_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostLinks_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostLinks_UnprocessableEntity
    ///Internal server error
    | InternalServerError of payload: BrapiPostLinks_InternalServerError

type BrapiPostMarkdown_OKErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostMarkdown_OK =
    { errors: Option<list<BrapiPostMarkdown_OKErrors>>
      ///Markdown
      result: Option<string>
      ///Response status
      success: bool }

type BrapiPostMarkdown_BadRequestErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostMarkdown_BadRequest =
    { errors: Option<list<BrapiPostMarkdown_BadRequestErrors>>
      ///Response status
      success: bool }

type BrapiPostMarkdown_UnprocessableEntityErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostMarkdown_UnprocessableEntity =
    { errors: Option<list<BrapiPostMarkdown_UnprocessableEntityErrors>>
      ///Response status
      success: bool }

type BrapiPostMarkdown_InternalServerErrorErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostMarkdown_InternalServerError =
    { errors: Option<list<BrapiPostMarkdown_InternalServerErrorErrors>>
      ///Response status
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostMarkdown =
    ///Returns the page markdown
    | OK of payload: BrapiPostMarkdown_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostMarkdown_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostMarkdown_UnprocessableEntity
    ///Internal server error
    | InternalServerError of payload: BrapiPostMarkdown_InternalServerError

type BrapiPostPdf_BadRequestErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostPdf_BadRequest =
    { errors: Option<list<BrapiPostPdf_BadRequestErrors>>
      ///Response status
      success: bool }

type BrapiPostPdf_UnprocessableEntityErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostPdf_UnprocessableEntity =
    { errors: Option<list<BrapiPostPdf_UnprocessableEntityErrors>>
      ///Response status
      success: bool }

type BrapiPostPdf_InternalServerErrorErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostPdf_InternalServerError =
    { errors: Option<list<BrapiPostPdf_InternalServerErrorErrors>>
      ///Response status
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostPdf =
    ///Returns the pdf
    | OK of payload: string
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostPdf_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostPdf_UnprocessableEntity
    ///Internal server error
    | InternalServerError of payload: BrapiPostPdf_InternalServerError

type BrapiPostScrape_OKErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type Attributes =
    { ///Attribute name
      name: string
      ///Attribute value
      value: string }

type Results =
    { attributes: list<Attributes>
      ///Element height
      height: float
      ///Html content
      html: string
      ///Element left
      left: float
      ///Text content
      text: string
      ///Element top
      top: float
      ///Element width
      width: float }

type Result =
    { results: Results
      ///Selector
      selector: string }

type BrapiPostScrape_OK =
    { errors: Option<list<BrapiPostScrape_OKErrors>>
      result: list<Result>
      ///Response status
      success: bool }

type BrapiPostScrape_BadRequestErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostScrape_BadRequest =
    { errors: Option<list<BrapiPostScrape_BadRequestErrors>>
      ///Response status
      success: bool }

type BrapiPostScrape_UnprocessableEntityErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostScrape_UnprocessableEntity =
    { errors: Option<list<BrapiPostScrape_UnprocessableEntityErrors>>
      ///Response status
      success: bool }

type BrapiPostScrape_InternalServerErrorErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostScrape_InternalServerError =
    { errors: Option<list<BrapiPostScrape_InternalServerErrorErrors>>
      ///Response status
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostScrape =
    ///Returns the scraped elements
    | OK of payload: BrapiPostScrape_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostScrape_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostScrape_UnprocessableEntity
    ///Internal server error
    | InternalServerError of payload: BrapiPostScrape_InternalServerError

type BrapiPostScreenshot_OKErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostScreenshot_OK =
    { errors: Option<list<BrapiPostScreenshot_OKErrors>>
      ///Response status
      success: bool }

type BrapiPostScreenshot_BadRequestErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostScreenshot_BadRequest =
    { errors: Option<list<BrapiPostScreenshot_BadRequestErrors>>
      ///Response status
      success: bool }

type BrapiPostScreenshot_UnprocessableEntityErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostScreenshot_UnprocessableEntity =
    { errors: Option<list<BrapiPostScreenshot_UnprocessableEntityErrors>>
      ///Response status
      success: bool }

type BrapiPostScreenshot_InternalServerErrorErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostScreenshot_InternalServerError =
    { errors: Option<list<BrapiPostScreenshot_InternalServerErrorErrors>>
      ///Response status
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostScreenshot =
    ///Returns the screenshot
    | OK of payload: BrapiPostScreenshot_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostScreenshot_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostScreenshot_UnprocessableEntity
    ///Internal server error
    | InternalServerError of payload: BrapiPostScreenshot_InternalServerError

type BrapiPostSnapshot_OKErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostSnapshot_OKMeta =
    { status: Option<float>
      title: Option<string> }

type BrapiPostSnapshot_OKResult =
    { ///HTML content
      content: string
      ///Base64 encoded image
      screenshot: string }

type BrapiPostSnapshot_OK =
    { errors: Option<list<BrapiPostSnapshot_OKErrors>>
      meta: BrapiPostSnapshot_OKMeta
      result: Option<BrapiPostSnapshot_OKResult>
      ///Response status
      success: bool }

type BrapiPostSnapshot_BadRequestErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostSnapshot_BadRequest =
    { errors: Option<list<BrapiPostSnapshot_BadRequestErrors>>
      ///Response status
      success: bool }

type BrapiPostSnapshot_UnprocessableEntityErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostSnapshot_UnprocessableEntity =
    { errors: Option<list<BrapiPostSnapshot_UnprocessableEntityErrors>>
      ///Response status
      success: bool }

type BrapiPostSnapshot_InternalServerErrorErrors =
    { ///Error code
      code: float
      ///Error Message
      message: string }

type BrapiPostSnapshot_InternalServerError =
    { errors: Option<list<BrapiPostSnapshot_InternalServerErrorErrors>>
      ///Response status
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostSnapshot =
    ///Returns the screenshot
    | OK of payload: BrapiPostSnapshot_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostSnapshot_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostSnapshot_UnprocessableEntity
    ///Internal server error
    | InternalServerError of payload: BrapiPostSnapshot_InternalServerError
