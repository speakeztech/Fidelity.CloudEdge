namespace rec Fidelity.CloudEdge.Management.Email.Types

///Account Identifier
type ``email-securityAccountId`` = string
type ``email-securityAllowPolicyId`` = int
type ``email-securityBlockedSenderId`` = int

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityDeliveryMode`` =
    | [<CompiledName "DIRECT">] DIRECT
    | [<CompiledName "BCC">] BCC
    | [<CompiledName "JOURNAL">] JOURNAL
    | [<CompiledName "API">] API
    | [<CompiledName "RETRO_SCAN">] RETRO_SCAN
    member this.Format() =
        match this with
        | DIRECT -> "DIRECT"
        | BCC -> "BCC"
        | JOURNAL -> "JOURNAL"
        | API -> "API"
        | RETRO_SCAN -> "RETRO_SCAN"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityDispositionLabel`` =
    | [<CompiledName "MALICIOUS">] MALICIOUS
    | [<CompiledName "MALICIOUS-BEC">] MALICIOUSBEC
    | [<CompiledName "SUSPICIOUS">] SUSPICIOUS
    | [<CompiledName "SPOOF">] SPOOF
    | [<CompiledName "SPAM">] SPAM
    | [<CompiledName "BULK">] BULK
    | [<CompiledName "ENCRYPTED">] ENCRYPTED
    | [<CompiledName "EXTERNAL">] EXTERNAL
    | [<CompiledName "UNKNOWN">] UNKNOWN
    | [<CompiledName "NONE">] NONE
    member this.Format() =
        match this with
        | MALICIOUS -> "MALICIOUS"
        | MALICIOUSBEC -> "MALICIOUS-BEC"
        | SUSPICIOUS -> "SUSPICIOUS"
        | SPOOF -> "SPOOF"
        | SPAM -> "SPAM"
        | BULK -> "BULK"
        | ENCRYPTED -> "ENCRYPTED"
        | EXTERNAL -> "EXTERNAL"
        | UNKNOWN -> "UNKNOWN"
        | NONE -> "NONE"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityMessageDeliveryMode`` =
    | [<CompiledName "DIRECT">] DIRECT
    | [<CompiledName "BCC">] BCC
    | [<CompiledName "JOURNAL">] JOURNAL
    | [<CompiledName "REVIEW_SUBMISSION">] REVIEW_SUBMISSION
    | [<CompiledName "DMARC_UNVERIFIED">] DMARC_UNVERIFIED
    | [<CompiledName "DMARC_FAILURE_REPORT">] DMARC_FAILURE_REPORT
    | [<CompiledName "DMARC_AGGREGATE_REPORT">] DMARC_AGGREGATE_REPORT
    | [<CompiledName "THREAT_INTEL_SUBMISSION">] THREAT_INTEL_SUBMISSION
    | [<CompiledName "SIMULATION_SUBMISSION">] SIMULATION_SUBMISSION
    | [<CompiledName "API">] API
    | [<CompiledName "RETRO_SCAN">] RETRO_SCAN
    member this.Format() =
        match this with
        | DIRECT -> "DIRECT"
        | BCC -> "BCC"
        | JOURNAL -> "JOURNAL"
        | REVIEW_SUBMISSION -> "REVIEW_SUBMISSION"
        | DMARC_UNVERIFIED -> "DMARC_UNVERIFIED"
        | DMARC_FAILURE_REPORT -> "DMARC_FAILURE_REPORT"
        | DMARC_AGGREGATE_REPORT -> "DMARC_AGGREGATE_REPORT"
        | THREAT_INTEL_SUBMISSION -> "THREAT_INTEL_SUBMISSION"
        | SIMULATION_SUBMISSION -> "SIMULATION_SUBMISSION"
        | API -> "API"
        | RETRO_SCAN -> "RETRO_SCAN"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityPatternType`` =
    | [<CompiledName "EMAIL">] EMAIL
    | [<CompiledName "DOMAIN">] DOMAIN
    | [<CompiledName "IP">] IP
    | [<CompiledName "UNKNOWN">] UNKNOWN
    member this.Format() =
        match this with
        | EMAIL -> "EMAIL"
        | DOMAIN -> "DOMAIN"
        | IP -> "IP"
        | UNKNOWN -> "UNKNOWN"

///The identifier of the message.
type ``email-securityPostfixId`` = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityScannableFolder`` =
    | [<CompiledName "AllItems">] AllItems
    | [<CompiledName "Inbox">] Inbox
    member this.Format() =
        match this with
        | AllItems -> "AllItems"
        | Inbox -> "Inbox"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securitySortingDirection`` =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"

type ``email-securityTrustedDomainId`` = int

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityValidationStatus`` =
    | [<CompiledName "pass">] Pass
    | [<CompiledName "neutral">] Neutral
    | [<CompiledName "fail">] Fail
    | [<CompiledName "error">] Error
    | [<CompiledName "none">] None
    member this.Format() =
        match this with
        | Pass -> "pass"
        | Neutral -> "neutral"
        | Fail -> "fail"
        | Error -> "error"
        | None -> "none"

///Identifier.
type emailaccountid = string
///The date and time the destination address has been created.
type emailcreated = System.DateTimeOffset
///Destination address identifier.
type emaildestinationaddressidentifier = string
///Destination address tag. (Deprecated, replaced by destination address identifier)
type emaildestinationaddresstag = string
///The contact email address of the user.
type emailemail = string
type emailemailroutinggetresponsednserrors = list<emailemailroutinggetresponsednserror>
///The date and time the settings have been created.
type emailemailsettingcreated = System.DateTimeOffset
type emailemailsettingenabled = bool
///Email Routing settings identifier.
type emailemailsettingidentifier = string
///The date and time the settings have been modified.
type emailemailsettingmodified = System.DateTimeOffset
///Domain of your zone.
type emailemailsettingname = string
type ``emailemailsettingskip-wizard`` = bool

///Show the state of your account, and the type or configuration error.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type emailemailsettingstatus =
    | [<CompiledName "ready">] Ready
    | [<CompiledName "unconfigured">] Unconfigured
    | [<CompiledName "misconfigured">] Misconfigured
    | [<CompiledName "misconfigured/locked">] MisconfiguredLocked
    | [<CompiledName "unlocked">] Unlocked
    member this.Format() =
        match this with
        | Ready -> "ready"
        | Unconfigured -> "unconfigured"
        | Misconfigured -> "misconfigured"
        | MisconfiguredLocked -> "misconfigured/locked"
        | Unlocked -> "unlocked"

///Email Routing settings tag. (Deprecated, replaced by Email Routing settings identifier)
type emailemailsettingtag = string
///Identifier.
type emailidentifier = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type emailmessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of emailmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailmessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailmessages = list<emailmessagesArrayItem>
///The date and time the destination address was last modified.
type emailmodified = System.DateTimeOffset
type emailruleactions = list<emailruleaction>
type ``emailrulecatchall-actions`` = list<``emailrulecatchall-action``>
type ``emailrulecatchall-matchers`` = list<``emailrulecatchall-matcher``>
type emailruleenabled = bool
///Routing rule identifier.
type emailruleidentifier = string
type emailrulematchers = list<emailrulematcher>
///Routing rule name.
type emailrulename = string
type emailrulepriority = float
///Routing rule tag. (Deprecated, replaced by routing rule identifier)
type emailruletag = string
///Sending subdomain identifier.
type emailsendingsubdomainidentifier = string
///The date and time the destination address has been verified. Null means not verified yet.
type emailverified = System.DateTimeOffset
///Identifier.
type emailzoneid = string

type ``email-securityAllowPolicy`` =
    { comments: Option<string>
      ///Messages from this sender will be exempted from Spam, Spoof and Bulk dispositions.
      ///Note: This will not exempt messages with Malicious or Suspicious dispositions.
      is_acceptable_sender: Option<bool>
      ///Messages to this recipient will bypass all detections.
      is_exempt_recipient: Option<bool>
      is_regex: Option<bool>
      ///Messages from this sender will bypass all detections and link following.
      is_trusted_sender: Option<bool>
      pattern: Option<string>
      pattern_type: Option<``email-securityPatternType``>
      ///Enforce DMARC, SPF or DKIM authentication.
      ///When on, Email Security only honors policies that pass authentication.
      verify_sender: Option<bool>
      created_at: Option<System.DateTimeOffset>
      ///The unique identifier for the allow policy.
      id: Option<``email-securityAllowPolicyId``>
      last_modified: Option<System.DateTimeOffset> }
    ///Creates an instance of email-securityAllowPolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityAllowPolicy`` =
        { comments = None
          is_acceptable_sender = None
          is_exempt_recipient = None
          is_regex = None
          is_trusted_sender = None
          pattern = None
          pattern_type = None
          verify_sender = None
          created_at = None
          id = None
          last_modified = None }

type ``email-securityApiResponseCommon`` =
    { errors: list<``email-securityMessage``>
      messages: list<``email-securityMessage``>
      success: bool }
    ///Creates an instance of email-securityApiResponseCommon with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``email-securityMessage``>,
                          messages: list<``email-securityMessage``>,
                          success: bool): ``email-securityApiResponseCommon`` =
        { errors = errors
          messages = messages
          success = success }

type ``email-securityAttachment`` =
    { content_type: Option<string>
      detection: Option<Newtonsoft.Json.Linq.JToken>
      encrypted: Option<bool>
      name: Option<string>
      size: int }
    ///Creates an instance of email-securityAttachment with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (size: int): ``email-securityAttachment`` =
        { content_type = None
          detection = None
          encrypted = None
          name = None
          size = size }

type ``email-securityBlockedSender`` =
    { comments: Option<string>
      is_regex: Option<bool>
      pattern: Option<string>
      pattern_type: Option<``email-securityPatternType``>
      created_at: Option<System.DateTimeOffset>
      ///The unique identifier for the allow policy.
      id: Option<``email-securityBlockedSenderId``>
      last_modified: Option<System.DateTimeOffset> }
    ///Creates an instance of email-securityBlockedSender with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityBlockedSender`` =
        { comments = None
          is_regex = None
          pattern = None
          pattern_type = None
          created_at = None
          id = None
          last_modified = None }

type ``email-securityCreateAllowPolicy`` =
    { comments: Option<string>
      ///Messages from this sender will be exempted from Spam, Spoof and Bulk dispositions.
      ///Note: This will not exempt messages with Malicious or Suspicious dispositions.
      is_acceptable_sender: bool
      ///Messages to this recipient will bypass all detections.
      is_exempt_recipient: bool
      is_regex: bool
      ///Messages from this sender will bypass all detections and link following.
      is_trusted_sender: bool
      pattern: string
      pattern_type: ``email-securityPatternType``
      ///Enforce DMARC, SPF or DKIM authentication.
      ///When on, Email Security only honors policies that pass authentication.
      verify_sender: bool }
    ///Creates an instance of email-securityCreateAllowPolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (is_acceptable_sender: bool,
                          is_exempt_recipient: bool,
                          is_regex: bool,
                          is_trusted_sender: bool,
                          pattern: string,
                          pattern_type: ``email-securityPatternType``,
                          verify_sender: bool): ``email-securityCreateAllowPolicy`` =
        { comments = None
          is_acceptable_sender = is_acceptable_sender
          is_exempt_recipient = is_exempt_recipient
          is_regex = is_regex
          is_trusted_sender = is_trusted_sender
          pattern = pattern
          pattern_type = pattern_type
          verify_sender = verify_sender }

type ``email-securityCreateBlockedSender`` =
    { comments: Option<string>
      is_regex: bool
      pattern: string
      pattern_type: ``email-securityPatternType`` }
    ///Creates an instance of email-securityCreateBlockedSender with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (is_regex: bool, pattern: string, pattern_type: ``email-securityPatternType``): ``email-securityCreateBlockedSender`` =
        { comments = None
          is_regex = is_regex
          pattern = pattern
          pattern_type = pattern_type }

type ``email-securityCreateDisplayName`` =
    { email: string
      is_email_regex: bool
      name: string }
    ///Creates an instance of email-securityCreateDisplayName with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: string, is_email_regex: bool, name: string): ``email-securityCreateDisplayName`` =
        { email = email
          is_email_regex = is_email_regex
          name = name }

type ``email-securityCreateTrustedDomain`` =
    { comments: Option<string>
      ///Select to prevent recently registered domains from triggering a
      ///Suspicious or Malicious disposition.
      is_recent: bool
      is_regex: bool
      ///Select for partner or other approved domains that have similar
      ///spelling to your connected domains. Prevents listed domains from
      ///triggering a Spoof disposition.
      is_similarity: bool
      pattern: string }
    ///Creates an instance of email-securityCreateTrustedDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (is_recent: bool, is_regex: bool, is_similarity: bool, pattern: string): ``email-securityCreateTrustedDomain`` =
        { comments = None
          is_recent = is_recent
          is_regex = is_regex
          is_similarity = is_similarity
          pattern = pattern }

type ``email-securityCursorWithLegacyResultInfo`` =
    { count: int
      next: Option<string>
      ///number of items per page
      per_page: int
      previous: Option<string> }
    ///Creates an instance of email-securityCursorWithLegacyResultInfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: int, per_page: int): ``email-securityCursorWithLegacyResultInfo`` =
        { count = count
          next = None
          per_page = per_page
          previous = None }

type ``email-securityDisplayName`` =
    { email: Option<string>
      is_email_regex: Option<bool>
      name: Option<string>
      comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      directory_id: Option<Newtonsoft.Json.Linq.JToken>
      directory_node_id: Option<Newtonsoft.Json.Linq.JToken>
      id: Option<int>
      last_modified: Option<System.DateTimeOffset>
      provenance: Option<string> }
    ///Creates an instance of email-securityDisplayName with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityDisplayName`` =
        { email = None
          is_email_regex = None
          name = None
          comments = None
          created_at = None
          directory_id = None
          directory_node_id = None
          id = None
          last_modified = None
          provenance = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Regions =
    | [<CompiledName "GLOBAL">] GLOBAL
    | [<CompiledName "AU">] AU
    | [<CompiledName "DE">] DE
    | [<CompiledName "IN">] IN
    | [<CompiledName "US">] US
    member this.Format() =
        match this with
        | GLOBAL -> "GLOBAL"
        | AU -> "AU"
        | DE -> "DE"
        | IN -> "IN"
        | US -> "US"

type ``email-securityDomain`` =
    { allowed_delivery_modes: list<``email-securityDeliveryMode``>
      authorization: Option<Newtonsoft.Json.Linq.JToken>
      created_at: System.DateTimeOffset
      dmarc_status: Option<Newtonsoft.Json.Linq.JToken>
      domain: string
      drop_dispositions: list<``email-securityDispositionLabel``>
      emails_processed: Option<Newtonsoft.Json.Linq.JToken>
      folder: Option<Newtonsoft.Json.Linq.JToken>
      ///The unique identifier for the domain.
      id: int
      inbox_provider: Option<Newtonsoft.Json.Linq.JToken>
      integration_id: Option<System.Guid>
      ip_restrictions: list<string>
      last_modified: System.DateTimeOffset
      lookback_hops: int
      o365_tenant_id: Option<string>
      regions: list<Regions>
      require_tls_inbound: Option<bool>
      require_tls_outbound: Option<bool>
      spf_status: Option<Newtonsoft.Json.Linq.JToken>
      transport: string }
    ///Creates an instance of email-securityDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (allowed_delivery_modes: list<``email-securityDeliveryMode``>,
                          created_at: System.DateTimeOffset,
                          domain: string,
                          drop_dispositions: list<``email-securityDispositionLabel``>,
                          id: int,
                          ip_restrictions: list<string>,
                          last_modified: System.DateTimeOffset,
                          lookback_hops: int,
                          regions: list<Regions>,
                          transport: string): ``email-securityDomain`` =
        { allowed_delivery_modes = allowed_delivery_modes
          authorization = None
          created_at = created_at
          dmarc_status = None
          domain = domain
          drop_dispositions = drop_dispositions
          emails_processed = None
          folder = None
          id = id
          inbox_provider = None
          integration_id = None
          ip_restrictions = ip_restrictions
          last_modified = last_modified
          lookback_hops = lookback_hops
          o365_tenant_id = None
          regions = regions
          require_tls_inbound = None
          require_tls_outbound = None
          spf_status = None
          transport = transport }

type ``email-securityLink`` =
    { href: string
      text: Option<string> }
    ///Creates an instance of email-securityLink with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (href: string): ``email-securityLink`` = { href = href; text = None }

type Findings =
    { attachment: Option<string>
      detail: Option<string>
      detection: Option<Newtonsoft.Json.Linq.JToken>
      field: Option<string>
      name: Option<string>
      portion: Option<string>
      reason: Option<string>
      score: Option<float>
      value: Option<string> }
    ///Creates an instance of Findings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Findings =
        { attachment = None
          detail = None
          detection = None
          field = None
          name = None
          portion = None
          reason = None
          score = None
          value = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Post_delivery_operations =
    | [<CompiledName "PREVIEW">] PREVIEW
    | [<CompiledName "QUARANTINE_RELEASE">] QUARANTINE_RELEASE
    | [<CompiledName "SUBMISSION">] SUBMISSION
    | [<CompiledName "MOVE">] MOVE
    member this.Format() =
        match this with
        | PREVIEW -> "PREVIEW"
        | QUARANTINE_RELEASE -> "QUARANTINE_RELEASE"
        | SUBMISSION -> "SUBMISSION"
        | MOVE -> "MOVE"

type Properties =
    { allowlisted_pattern: Option<string>
      allowlisted_pattern_type: Option<Newtonsoft.Json.Linq.JToken>
      blocklisted_message: Option<bool>
      blocklisted_pattern: Option<string>
      whitelisted_pattern_type: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of Properties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Properties =
        { allowlisted_pattern = None
          allowlisted_pattern_type = None
          blocklisted_message = None
          blocklisted_pattern = None
          whitelisted_pattern_type = None }

type ``email-securityMailsearchMessage`` =
    { action_log: Option<Newtonsoft.Json.Linq.JToken>
      alert_id: Option<string>
      client_recipients: Option<list<string>>
      delivery_mode: Option<Newtonsoft.Json.Linq.JToken>
      detection_reasons: Option<list<string>>
      edf_hash: Option<string>
      envelope_from: Option<string>
      envelope_to: Option<list<string>>
      final_disposition: Option<Newtonsoft.Json.Linq.JToken>
      findings: Option<list<Findings>>
      from: Option<string>
      from_name: Option<string>
      htmltext_structure_hash: Option<string>
      is_phish_submission: Option<bool>
      is_quarantined: Option<bool>
      message_id: Option<string>
      post_delivery_operations: Option<list<Post_delivery_operations>>
      ///The identifier of the message.
      postfix_id: Option<``email-securityPostfixId``>
      postfix_id_outbound: Option<string>
      properties: Option<Properties>
      replyto: Option<string>
      sent_date: Option<string>
      subject: Option<string>
      threat_categories: Option<list<string>>
      ``to``: Option<list<string>>
      to_name: Option<list<string>>
      ts: Option<string>
      validation: Option<Newtonsoft.Json.Linq.JToken>
      id: Option<string> }
    ///Creates an instance of email-securityMailsearchMessage with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityMailsearchMessage`` =
        { action_log = None
          alert_id = None
          client_recipients = None
          delivery_mode = None
          detection_reasons = None
          edf_hash = None
          envelope_from = None
          envelope_to = None
          final_disposition = None
          findings = None
          from = None
          from_name = None
          htmltext_structure_hash = None
          is_phish_submission = None
          is_quarantined = None
          message_id = None
          post_delivery_operations = None
          postfix_id = None
          postfix_id_outbound = None
          properties = None
          replyto = None
          sent_date = None
          subject = None
          threat_categories = None
          ``to`` = None
          to_name = None
          ts = None
          validation = None
          id = None }

type ``email-securityMessage`` =
    { code: int
      message: string }
    ///Creates an instance of email-securityMessage with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``email-securityMessage`` = { code = code; message = message }

type ``email-securityMessageHeader`` =
    { name: string
      value: string }
    ///Creates an instance of email-securityMessageHeader with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, value: string): ``email-securityMessageHeader`` = { name = name; value = value }

type ``email-securityMoveResponseItem`` =
    { completed_timestamp: System.DateTimeOffset
      destination: Option<string>
      message_id: Option<string>
      operation: Option<string>
      recipient: Option<string>
      status: Option<string>
      success: bool }
    ///Creates an instance of email-securityMoveResponseItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (completed_timestamp: System.DateTimeOffset, success: bool): ``email-securityMoveResponseItem`` =
        { completed_timestamp = completed_timestamp
          destination = None
          message_id = None
          operation = None
          recipient = None
          status = None
          success = success }

type Fields =
    { from: Option<string>
      postfix_id: Option<string>
      ``to``: list<string>
      ts: System.DateTimeOffset }
    ///Creates an instance of Fields with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``to``: list<string>, ts: System.DateTimeOffset): Fields =
        { from = None
          postfix_id = None
          ``to`` = ``to``
          ts = ts }

type ``email-securityPhishGuardReport`` =
    { content: string
      created_at: System.DateTimeOffset
      disposition: ``email-securityDispositionLabel``
      fields: Fields
      id: int
      priority: string
      tags: Option<list<``email-securityPhishGuardReportTag``>>
      title: string
      ts: System.DateTimeOffset
      updated_at: System.DateTimeOffset }
    ///Creates an instance of email-securityPhishGuardReport with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string,
                          created_at: System.DateTimeOffset,
                          disposition: ``email-securityDispositionLabel``,
                          fields: Fields,
                          id: int,
                          priority: string,
                          title: string,
                          ts: System.DateTimeOffset,
                          updated_at: System.DateTimeOffset): ``email-securityPhishGuardReport`` =
        { content = content
          created_at = created_at
          disposition = disposition
          fields = fields
          id = id
          priority = priority
          tags = None
          title = title
          ts = ts
          updated_at = updated_at }

type ``email-securityPhishGuardReportTag`` =
    { category: string
      value: string }
    ///Creates an instance of email-securityPhishGuardReportTag with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (category: string, value: string): ``email-securityPhishGuardReportTag`` =
        { category = category; value = value }

type ``email-securityReleaseResponse`` =
    { delivered: Option<list<string>>
      failed: Option<list<string>>
      undelivered: Option<list<string>>
      id: Option<string>
      ///The identifier of the message.
      postfix_id: Option<``email-securityPostfixId``> }
    ///Creates an instance of email-securityReleaseResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityReleaseResponse`` =
        { delivered = None
          failed = None
          undelivered = None
          id = None
          postfix_id = None }

type ``email-securityResultInfo`` =
    { ///Total number of results for the requested service
      count: int
      ///Current page within paginated list of results
      page: int
      ///Number of results per page of results
      per_page: int
      ///Total results available without any search parameters
      total_count: int }
    ///Creates an instance of email-securityResultInfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: int, page: int, per_page: int, total_count: int): ``email-securityResultInfo`` =
        { count = count
          page = page
          per_page = per_page
          total_count = total_count }

type ``email-securitySubmission`` =
    { customer_status: Option<Newtonsoft.Json.Linq.JToken>
      original_disposition: Option<Newtonsoft.Json.Linq.JToken>
      original_edf_hash: Option<string>
      outcome: Option<string>
      outcome_disposition: Option<Newtonsoft.Json.Linq.JToken>
      requested_by: Option<string>
      requested_disposition: Option<Newtonsoft.Json.Linq.JToken>
      requested_ts: System.DateTimeOffset
      status: Option<string>
      subject: Option<string>
      submission_id: string
      ``type``: Option<string> }
    ///Creates an instance of email-securitySubmission with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (requested_ts: System.DateTimeOffset, submission_id: string): ``email-securitySubmission`` =
        { customer_status = None
          original_disposition = None
          original_edf_hash = None
          outcome = None
          outcome_disposition = None
          requested_by = None
          requested_disposition = None
          requested_ts = requested_ts
          status = None
          subject = None
          submission_id = submission_id
          ``type`` = None }

type ``email-securityThreatCategory`` =
    { description: Option<string>
      id: int64
      name: Option<string> }
    ///Creates an instance of email-securityThreatCategory with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: int64): ``email-securityThreatCategory`` =
        { description = None
          id = id
          name = None }

type ``email-securityTraceLine`` =
    { lineno: int64
      message: string
      ts: System.DateTimeOffset }
    ///Creates an instance of email-securityTraceLine with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (lineno: int64, message: string, ts: System.DateTimeOffset): ``email-securityTraceLine`` =
        { lineno = lineno
          message = message
          ts = ts }

type ``email-securityTrustedDomain`` =
    { comments: Option<string>
      ///Select to prevent recently registered domains from triggering a
      ///Suspicious or Malicious disposition.
      is_recent: Option<bool>
      is_regex: Option<bool>
      ///Select for partner or other approved domains that have similar
      ///spelling to your connected domains. Prevents listed domains from
      ///triggering a Spoof disposition.
      is_similarity: Option<bool>
      pattern: Option<string>
      created_at: Option<System.DateTimeOffset>
      ///The unique identifier for the trusted domain.
      id: Option<int>
      last_modified: Option<System.DateTimeOffset> }
    ///Creates an instance of email-securityTrustedDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityTrustedDomain`` =
        { comments = None
          is_recent = None
          is_regex = None
          is_similarity = None
          pattern = None
          created_at = None
          id = None
          last_modified = None }

type ``email-securityUpdateAllowPolicy`` =
    { comments: Option<string>
      ///Messages from this sender will be exempted from Spam, Spoof and Bulk dispositions.
      ///Note: This will not exempt messages with Malicious or Suspicious dispositions.
      is_acceptable_sender: Option<bool>
      ///Messages to this recipient will bypass all detections.
      is_exempt_recipient: Option<bool>
      is_regex: Option<bool>
      ///Messages from this sender will bypass all detections and link following.
      is_trusted_sender: Option<bool>
      pattern: Option<string>
      pattern_type: Option<Newtonsoft.Json.Linq.JToken>
      ///Enforce DMARC, SPF or DKIM authentication.
      ///When on, Email Security only honors policies that pass authentication.
      verify_sender: Option<bool> }
    ///Creates an instance of email-securityUpdateAllowPolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateAllowPolicy`` =
        { comments = None
          is_acceptable_sender = None
          is_exempt_recipient = None
          is_regex = None
          is_trusted_sender = None
          pattern = None
          pattern_type = None
          verify_sender = None }

type ``email-securityUpdateBlockedSender`` =
    { comments: Option<string>
      is_regex: Option<bool>
      pattern: Option<string>
      pattern_type: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of email-securityUpdateBlockedSender with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateBlockedSender`` =
        { comments = None
          is_regex = None
          pattern = None
          pattern_type = None }

type ``email-securityUpdateTrustedDomain`` =
    { comments: Option<string>
      ///Select to prevent recently registered domains from triggering a
      ///Suspicious or Malicious disposition.
      is_recent: Option<bool>
      is_regex: Option<bool>
      ///Select for partner or other approved domains that have similar
      ///spelling to your connected domains. Prevents listed domains from
      ///triggering a Spoof disposition.
      is_similarity: Option<bool>
      pattern: Option<string> }
    ///Creates an instance of email-securityUpdateTrustedDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateTrustedDomain`` =
        { comments = None
          is_recent = None
          is_regex = None
          is_similarity = None
          pattern = None }

type emailaddresses =
    { ///The date and time the destination address has been created.
      created: Option<emailcreated>
      ///The contact email address of the user.
      email: Option<emailemail>
      ///Destination address identifier.
      id: Option<emaildestinationaddressidentifier>
      ///The date and time the destination address was last modified.
      modified: Option<emailmodified>
      ///The date and time the destination address has been verified. Null means not verified yet.
      verified: Option<emailverified> }
    ///Creates an instance of emailaddresses with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailaddresses =
        { created = None
          email = None
          id = None
          modified = None
          verified = None }

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

type ``emailapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<Resultinfo> }
    ///Creates an instance of emailapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``emailapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-commonErrorsSource`` = { pointer = None }

type ``emailapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-commonErrorsSource``> }
    ///Creates an instance of emailapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-commonMessagesSource`` = { pointer = None }

type ``emailapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-commonMessagesSource``> }
    ///Creates an instance of emailapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-common`` =
    { errors: list<``emailapi-response-commonErrors``>
      messages: list<``emailapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of emailapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``emailapi-response-commonErrors``>,
                          messages: list<``emailapi-response-commonMessages``>,
                          success: bool): ``emailapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``emailapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-singleErrorsSource`` = { pointer = None }

type ``emailapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-singleErrorsSource``> }
    ///Creates an instance of emailapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-singleMessagesSource`` = { pointer = None }

type ``emailapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-singleMessagesSource``> }
    ///Creates an instance of emailapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-single`` =
    { errors: Option<list<``emailapi-response-singleErrors``>>
      messages: Option<list<``emailapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of emailapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-single`` =
        { errors = None
          messages = None
          success = None }

type emailcatchallrule =
    { ///List actions for the catch-all routing rule.
      actions: Option<``emailrulecatchall-actions``>
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Routing rule identifier.
      id: Option<emailruleidentifier>
      ///List of matchers for the catch-all routing rule.
      matchers: Option<``emailrulecatchall-matchers``>
      ///Routing rule name.
      name: Option<emailrulename> }
    ///Creates an instance of emailcatchallrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailcatchallrule =
        { actions = None
          enabled = None
          id = None
          matchers = None
          name = None }

type emailcatchallruleresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailcatchallruleresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailcatchallruleresponsesingleErrorsSource = { pointer = None }

type emailcatchallruleresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailcatchallruleresponsesingleErrorsSource> }
    ///Creates an instance of emailcatchallruleresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailcatchallruleresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailcatchallruleresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailcatchallruleresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailcatchallruleresponsesingleMessagesSource = { pointer = None }

type emailcatchallruleresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailcatchallruleresponsesingleMessagesSource> }
    ///Creates an instance of emailcatchallruleresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailcatchallruleresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailcatchallruleresponsesingle =
    { errors: Option<list<emailcatchallruleresponsesingleErrors>>
      messages: Option<list<emailcatchallruleresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<emailcatchallrule> }
    ///Creates an instance of emailcatchallruleresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailcatchallruleresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type emailcreatedestinationaddressproperties =
    { ///The contact email address of the user.
      email: emailemail }
    ///Creates an instance of emailcreatedestinationaddressproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: emailemail): emailcreatedestinationaddressproperties = { email = email }

type emailcreateruleproperties =
    { ///List actions patterns.
      actions: emailruleactions
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Matching patterns to forward to your actions.
      matchers: emailrulematchers
      ///Routing rule name.
      name: Option<emailrulename>
      ///Priority of the routing rule.
      priority: Option<emailrulepriority> }
    ///Creates an instance of emailcreateruleproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (actions: emailruleactions, matchers: emailrulematchers): emailcreateruleproperties =
        { actions = actions
          enabled = None
          matchers = matchers
          name = None
          priority = None }

type emailcreatesendingsubdomainproperties =
    { ///The subdomain name. Must be within the zone.
      name: string }
    ///Creates an instance of emailcreatesendingsubdomainproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): emailcreatesendingsubdomainproperties = { name = name }

type emaildestinationaddressproperties =
    { ///The date and time the destination address has been created.
      created: Option<emailcreated>
      ///The contact email address of the user.
      email: Option<emailemail>
      ///Destination address identifier.
      id: Option<emaildestinationaddressidentifier>
      ///The date and time the destination address was last modified.
      modified: Option<emailmodified>
      ///The date and time the destination address has been verified. Null means not verified yet.
      verified: Option<emailverified> }
    ///Creates an instance of emaildestinationaddressproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressproperties =
        { created = None
          email = None
          id = None
          modified = None
          verified = None }

type emaildestinationaddressresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildestinationaddressresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressresponsesingleErrorsSource = { pointer = None }

type emaildestinationaddressresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildestinationaddressresponsesingleErrorsSource> }
    ///Creates an instance of emaildestinationaddressresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildestinationaddressresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildestinationaddressresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildestinationaddressresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressresponsesingleMessagesSource = { pointer = None }

type emaildestinationaddressresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildestinationaddressresponsesingleMessagesSource> }
    ///Creates an instance of emaildestinationaddressresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildestinationaddressresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildestinationaddressresponsesingle =
    { errors: Option<list<emaildestinationaddressresponsesingleErrors>>
      messages: Option<list<emaildestinationaddressresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<emailaddresses> }
    ///Creates an instance of emaildestinationaddressresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type emaildestinationaddressesresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressesresponsecollectionErrorsSource = { pointer = None }

type emaildestinationaddressesresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildestinationaddressesresponsecollectionErrorsSource> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildestinationaddressesresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildestinationaddressesresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressesresponsecollectionMessagesSource = { pointer = None }

type emaildestinationaddressesresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildestinationaddressesresponsecollectionMessagesSource> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildestinationaddressesresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildestinationaddressesresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressesresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ResultinfoFromemaildestinationaddressesresponsecollection =
    { count: Option<Newtonsoft.Json.Linq.JToken>
      page: Option<Newtonsoft.Json.Linq.JToken>
      per_page: Option<Newtonsoft.Json.Linq.JToken>
      total_count: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of ResultinfoFromemaildestinationaddressesresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ResultinfoFromemaildestinationaddressesresponsecollection =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emaildestinationaddressesresponsecollection =
    { errors: Option<list<emaildestinationaddressesresponsecollectionErrors>>
      messages: Option<list<emaildestinationaddressesresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<emaildestinationaddressesresponsecollectionResultinfo>
      result: Option<list<emailaddresses>> }
    ///Creates an instance of emaildestinationaddressesresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressesresponsecollection =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "A">] A
    | [<CompiledName "AAAA">] AAAA
    | [<CompiledName "CNAME">] CNAME
    | [<CompiledName "HTTPS">] HTTPS
    | [<CompiledName "TXT">] TXT
    | [<CompiledName "SRV">] SRV
    | [<CompiledName "LOC">] LOC
    | [<CompiledName "MX">] MX
    | [<CompiledName "NS">] NS
    | [<CompiledName "CERT">] CERT
    | [<CompiledName "DNSKEY">] DNSKEY
    | [<CompiledName "DS">] DS
    | [<CompiledName "NAPTR">] NAPTR
    | [<CompiledName "SMIMEA">] SMIMEA
    | [<CompiledName "SSHFP">] SSHFP
    | [<CompiledName "SVCB">] SVCB
    | [<CompiledName "TLSA">] TLSA
    | [<CompiledName "URI">] URI
    member this.Format() =
        match this with
        | A -> "A"
        | AAAA -> "AAAA"
        | CNAME -> "CNAME"
        | HTTPS -> "HTTPS"
        | TXT -> "TXT"
        | SRV -> "SRV"
        | LOC -> "LOC"
        | MX -> "MX"
        | NS -> "NS"
        | CERT -> "CERT"
        | DNSKEY -> "DNSKEY"
        | DS -> "DS"
        | NAPTR -> "NAPTR"
        | SMIMEA -> "SMIMEA"
        | SSHFP -> "SSHFP"
        | SVCB -> "SVCB"
        | TLSA -> "TLSA"
        | URI -> "URI"

///List of records needed to enable an Email Routing zone.
type emaildnsrecord =
    { ///DNS record content.
      content: Option<string>
      ///DNS record name (or @ for the zone apex).
      name: Option<string>
      ///Required for MX, SRV and URI records. Unused by other record types. Records with lower priorities are preferred.
      priority: Option<float>
      ///Time to live, in seconds, of the DNS record. Must be between 60 and 86400, or 1 for 'automatic'.
      ttl: Option<float>
      ///DNS record type.
      ``type``: Option<Type> }
    ///Creates an instance of emaildnsrecord with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnsrecord =
        { content = None
          name = None
          priority = None
          ttl = None
          ``type`` = None }

type emaildnssettingsresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildnssettingsresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnssettingsresponsecollectionErrorsSource = { pointer = None }

type emaildnssettingsresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildnssettingsresponsecollectionErrorsSource> }
    ///Creates an instance of emaildnssettingsresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildnssettingsresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildnssettingsresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildnssettingsresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnssettingsresponsecollectionMessagesSource = { pointer = None }

type emaildnssettingsresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildnssettingsresponsecollectionMessagesSource> }
    ///Creates an instance of emaildnssettingsresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildnssettingsresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildnssettingsresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emaildnssettingsresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnssettingsresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emaildnssettingsresponsecollection =
    { errors: Option<list<emaildnssettingsresponsecollectionErrors>>
      messages: Option<list<emaildnssettingsresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<emaildnssettingsresponsecollectionResultinfo>
      result: Option<list<emaildnsrecord>> }
    ///Creates an instance of emaildnssettingsresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnssettingsresponsecollection =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type emailemailroutingdnsqueryresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailemailroutingdnsqueryresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutingdnsqueryresponseErrorsSource = { pointer = None }

type emailemailroutingdnsqueryresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailemailroutingdnsqueryresponseErrorsSource> }
    ///Creates an instance of emailemailroutingdnsqueryresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailemailroutingdnsqueryresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailemailroutingdnsqueryresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailemailroutingdnsqueryresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutingdnsqueryresponseMessagesSource = { pointer = None }

type emailemailroutingdnsqueryresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailemailroutingdnsqueryresponseMessagesSource> }
    ///Creates an instance of emailemailroutingdnsqueryresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailemailroutingdnsqueryresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailemailroutingdnsqueryresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailemailroutingdnsqueryresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutingdnsqueryresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type Result =
    { errors: Option<emailemailroutinggetresponsednserrors>
      record: Option<list<emaildnsrecord>> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result = { errors = None; record = None }

type emailemailroutingdnsqueryresponse =
    { errors: Option<list<emailemailroutingdnsqueryresponseErrors>>
      messages: Option<list<emailemailroutingdnsqueryresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<emailemailroutingdnsqueryresponseResultinfo>
      result: Option<Result> }
    ///Creates an instance of emailemailroutingdnsqueryresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutingdnsqueryresponse =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type emailemailroutinggetresponsednserror =
    { code: Option<string>
      ///List of records needed to enable an Email Routing zone.
      missing: Option<emaildnsrecord> }
    ///Creates an instance of emailemailroutinggetresponsednserror with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutinggetresponsednserror = { code = None; missing = None }

type emailemailsettingdnsrequestbody =
    { ///Domain of your zone.
      name: Option<emailemailsettingname> }
    ///Creates an instance of emailemailsettingdnsrequestbody with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailsettingdnsrequestbody = { name = None }

type emailemailsettingsproperties =
    { ///The date and time the settings have been created.
      created: Option<emailemailsettingcreated>
      ///State of the zone settings for Email Routing.
      enabled: emailemailsettingenabled
      ///Email Routing settings identifier.
      id: emailemailsettingidentifier
      ///The date and time the settings have been modified.
      modified: Option<emailemailsettingmodified>
      ///Domain of your zone.
      name: emailemailsettingname
      ///Flag to check if the user skipped the configuration wizard.
      skip_wizard: Option<``emailemailsettingskip-wizard``>
      ///Show the state of your account, and the type or configuration error.
      status: Option<emailemailsettingstatus> }
    ///Creates an instance of emailemailsettingsproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: emailemailsettingenabled,
                          id: emailemailsettingidentifier,
                          name: emailemailsettingname): emailemailsettingsproperties =
        { created = None
          enabled = enabled
          id = id
          modified = None
          name = name
          skip_wizard = None
          status = None }

type emailemailsettingsresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailemailsettingsresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailsettingsresponsesingleErrorsSource = { pointer = None }

type emailemailsettingsresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailemailsettingsresponsesingleErrorsSource> }
    ///Creates an instance of emailemailsettingsresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailemailsettingsresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailemailsettingsresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailemailsettingsresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailsettingsresponsesingleMessagesSource = { pointer = None }

type emailemailsettingsresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailemailsettingsresponsesingleMessagesSource> }
    ///Creates an instance of emailemailsettingsresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailemailsettingsresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailemailsettingsresponsesingle =
    { errors: Option<list<emailemailsettingsresponsesingleErrors>>
      messages: Option<list<emailemailsettingsresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<emailsettings> }
    ///Creates an instance of emailemailsettingsresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailsettingsresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type emailruleactionType =
    | [<CompiledName "drop">] Drop
    | [<CompiledName "forward">] Forward
    | [<CompiledName "worker">] Worker
    member this.Format() =
        match this with
        | Drop -> "drop"
        | Forward -> "forward"
        | Worker -> "worker"

///Actions pattern.
type emailruleaction =
    { ///Type of supported action.
      ``type``: emailruleactionType
      value: Option<list<string>> }
    ///Creates an instance of emailruleaction with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: emailruleactionType): emailruleaction = { ``type`` = ``type``; value = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``emailrulecatchall-actionType`` =
    | [<CompiledName "drop">] Drop
    | [<CompiledName "forward">] Forward
    | [<CompiledName "worker">] Worker
    member this.Format() =
        match this with
        | Drop -> "drop"
        | Forward -> "forward"
        | Worker -> "worker"

///Action for the catch-all routing rule.
type ``emailrulecatchall-action`` =
    { ///Type of action for catch-all rule.
      ``type``: ``emailrulecatchall-actionType``
      value: Option<list<string>> }
    ///Creates an instance of emailrulecatchall-action with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``emailrulecatchall-actionType``): ``emailrulecatchall-action`` =
        { ``type`` = ``type``; value = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``emailrulecatchall-matcherType`` =
    | [<CompiledName "all">] All
    member this.Format() =
        match this with
        | All -> "all"

///Matcher for catch-all routing rule.
type ``emailrulecatchall-matcher`` =
    { ///Type of matcher. Default is 'all'.
      ``type``: ``emailrulecatchall-matcherType`` }
    ///Creates an instance of emailrulecatchall-matcher with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``emailrulecatchall-matcherType``): ``emailrulecatchall-matcher`` =
        { ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Field =
    | [<CompiledName "to">] To
    member this.Format() =
        match this with
        | To -> "to"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type emailrulematcherType =
    | [<CompiledName "all">] All
    | [<CompiledName "literal">] Literal
    member this.Format() =
        match this with
        | All -> "all"
        | Literal -> "literal"

///Matching pattern to forward your actions.
type emailrulematcher =
    { ///Field for type matcher.
      field: Option<Field>
      ///Type of matcher.
      ``type``: emailrulematcherType
      ///Value for matcher.
      value: Option<string> }
    ///Creates an instance of emailrulematcher with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: emailrulematcherType): emailrulematcher =
        { field = None
          ``type`` = ``type``
          value = None }

type emailruleproperties =
    { ///List actions patterns.
      actions: Option<emailruleactions>
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Routing rule identifier.
      id: Option<emailruleidentifier>
      ///Matching patterns to forward to your actions.
      matchers: Option<emailrulematchers>
      ///Routing rule name.
      name: Option<emailrulename>
      ///Priority of the routing rule.
      priority: Option<emailrulepriority> }
    ///Creates an instance of emailruleproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailruleproperties =
        { actions = None
          enabled = None
          id = None
          matchers = None
          name = None
          priority = None }

type emailruleresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailruleresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailruleresponsesingleErrorsSource = { pointer = None }

type emailruleresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailruleresponsesingleErrorsSource> }
    ///Creates an instance of emailruleresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailruleresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailruleresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailruleresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailruleresponsesingleMessagesSource = { pointer = None }

type emailruleresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailruleresponsesingleMessagesSource> }
    ///Creates an instance of emailruleresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailruleresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailruleresponsesingle =
    { errors: Option<list<emailruleresponsesingleErrors>>
      messages: Option<list<emailruleresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<emailrules> }
    ///Creates an instance of emailruleresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailruleresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type emailrules =
    { ///List actions patterns.
      actions: Option<emailruleactions>
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Routing rule identifier.
      id: Option<emailruleidentifier>
      ///Matching patterns to forward to your actions.
      matchers: Option<emailrulematchers>
      ///Routing rule name.
      name: Option<emailrulename>
      ///Priority of the routing rule.
      priority: Option<emailrulepriority> }
    ///Creates an instance of emailrules with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrules =
        { actions = None
          enabled = None
          id = None
          matchers = None
          name = None
          priority = None }

type emailrulesresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailrulesresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrulesresponsecollectionErrorsSource = { pointer = None }

type emailrulesresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailrulesresponsecollectionErrorsSource> }
    ///Creates an instance of emailrulesresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailrulesresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailrulesresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailrulesresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrulesresponsecollectionMessagesSource = { pointer = None }

type emailrulesresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailrulesresponsecollectionMessagesSource> }
    ///Creates an instance of emailrulesresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailrulesresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailrulesresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailrulesresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrulesresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ResultinfoFromemailrulesresponsecollection =
    { count: Option<Newtonsoft.Json.Linq.JToken>
      page: Option<Newtonsoft.Json.Linq.JToken>
      per_page: Option<Newtonsoft.Json.Linq.JToken>
      total_count: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of ResultinfoFromemailrulesresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ResultinfoFromemailrulesresponsecollection =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailrulesresponsecollection =
    { errors: Option<list<emailrulesresponsecollectionErrors>>
      messages: Option<list<emailrulesresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<emailrulesresponsecollectionResultinfo>
      result: Option<list<emailrules>> }
    ///Creates an instance of emailrulesresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrulesresponsecollection =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type emailsendingsubdomain =
    { ///The date and time the destination address has been created.
      created: Option<emailcreated>
      ///The DKIM selector used for email signing.
      email_sending_dkim_selector: Option<string>
      ///Whether Email Sending is enabled on this subdomain.
      email_sending_enabled: Option<bool>
      ///The return-path domain used for bounce handling.
      email_sending_return_path_domain: Option<string>
      ///Whether Email Routing (receiving) is enabled on this subdomain. Read-only; included for informational purposes since both services share the subdomain row.
      enabled: Option<bool>
      ///The date and time the destination address was last modified.
      modified: Option<emailmodified>
      ///The subdomain domain name.
      name: Option<string>
      ///Sending subdomain identifier.
      tag: Option<emailsendingsubdomainidentifier> }
    ///Creates an instance of emailsendingsubdomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomain =
        { created = None
          email_sending_dkim_selector = None
          email_sending_enabled = None
          email_sending_return_path_domain = None
          enabled = None
          modified = None
          name = None
          tag = None }

type emailsendingsubdomainproperties =
    { ///The date and time the destination address has been created.
      created: Option<emailcreated>
      ///The DKIM selector used for email signing.
      email_sending_dkim_selector: Option<string>
      ///Whether Email Sending is enabled on this subdomain.
      email_sending_enabled: bool
      ///The return-path domain used for bounce handling.
      email_sending_return_path_domain: Option<string>
      ///Whether Email Routing (receiving) is enabled on this subdomain. Read-only; included for informational purposes since both services share the subdomain row.
      enabled: Option<bool>
      ///The date and time the destination address was last modified.
      modified: Option<emailmodified>
      ///The subdomain domain name.
      name: string
      ///Sending subdomain identifier.
      tag: emailsendingsubdomainidentifier }
    ///Creates an instance of emailsendingsubdomainproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email_sending_enabled: bool, name: string, tag: emailsendingsubdomainidentifier): emailsendingsubdomainproperties =
        { created = None
          email_sending_dkim_selector = None
          email_sending_enabled = email_sending_enabled
          email_sending_return_path_domain = None
          enabled = None
          modified = None
          name = name
          tag = tag }

type emailsendingsubdomainresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainresponsesingleErrorsSource = { pointer = None }

type emailsendingsubdomainresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainresponsesingleErrorsSource> }
    ///Creates an instance of emailsendingsubdomainresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainresponsesingleMessagesSource = { pointer = None }

type emailsendingsubdomainresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainresponsesingleMessagesSource> }
    ///Creates an instance of emailsendingsubdomainresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainresponsesingle =
    { errors: Option<list<emailsendingsubdomainresponsesingleErrors>>
      messages: Option<list<emailsendingsubdomainresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<Newtonsoft.Json.Linq.JToken> }
    ///Creates an instance of emailsendingsubdomainresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type emailsendingsubdomainsresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainsresponsecollectionErrorsSource = { pointer = None }

type emailsendingsubdomainsresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainsresponsecollectionErrorsSource> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainsresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainsresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainsresponsecollectionMessagesSource = { pointer = None }

type emailsendingsubdomainsresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainsresponsecollectionMessagesSource> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainsresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainsresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainsresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailsendingsubdomainsresponsecollection =
    { errors: Option<list<emailsendingsubdomainsresponsecollectionErrors>>
      messages: Option<list<emailsendingsubdomainsresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<emailsendingsubdomainsresponsecollectionResultinfo>
      result: Option<list<emailsendingsubdomain>> }
    ///Creates an instance of emailsendingsubdomainsresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainsresponsecollection =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type emailsettings =
    { ///The date and time the settings have been created.
      created: Option<emailemailsettingcreated>
      ///State of the zone settings for Email Routing.
      enabled: Option<emailemailsettingenabled>
      ///Email Routing settings identifier.
      id: Option<emailemailsettingidentifier>
      ///The date and time the settings have been modified.
      modified: Option<emailemailsettingmodified>
      ///Domain of your zone.
      name: Option<emailemailsettingname>
      ///Flag to check if the user skipped the configuration wizard.
      skip_wizard: Option<``emailemailsettingskip-wizard``>
      ///Show the state of your account, and the type or configuration error.
      status: Option<emailemailsettingstatus> }
    ///Creates an instance of emailsettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsettings =
        { created = None
          enabled = None
          id = None
          modified = None
          name = None
          skip_wizard = None
          status = None }

type emailupdatecatchallruleproperties =
    { ///List actions for the catch-all routing rule.
      actions: ``emailrulecatchall-actions``
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///List of matchers for the catch-all routing rule.
      matchers: ``emailrulecatchall-matchers``
      ///Routing rule name.
      name: Option<emailrulename> }
    ///Creates an instance of emailupdatecatchallruleproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (actions: ``emailrulecatchall-actions``, matchers: ``emailrulecatchall-matchers``): emailupdatecatchallruleproperties =
        { actions = actions
          enabled = None
          matchers = matchers
          name = None }

type emailupdateruleproperties =
    { ///List actions patterns.
      actions: emailruleactions
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Matching patterns to forward to your actions.
      matchers: emailrulematchers
      ///Routing rule name.
      name: Option<emailrulename>
      ///Priority of the routing rule.
      priority: Option<emailrulepriority> }
    ///Creates an instance of emailupdateruleproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (actions: emailruleactions, matchers: emailrulematchers): emailupdateruleproperties =
        { actions = actions
          enabled = None
          matchers = matchers
          name = None
          priority = None }

[<RequireQualifiedAccess>]
type EmailSecurityInvestigate =
    ///Contains the search results for the provided query.
    | OK of payload: string
    ///The search is taking longer than expected. Use the Location header to poll for results.
    | Accepted of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Destination =
    | [<CompiledName "Inbox">] Inbox
    | [<CompiledName "JunkEmail">] JunkEmail
    | [<CompiledName "DeletedItems">] DeletedItems
    | [<CompiledName "RecoverableItemsDeletions">] RecoverableItemsDeletions
    | [<CompiledName "RecoverableItemsPurges">] RecoverableItemsPurges
    member this.Format() =
        match this with
        | Inbox -> "Inbox"
        | JunkEmail -> "JunkEmail"
        | DeletedItems -> "DeletedItems"
        | RecoverableItemsDeletions -> "RecoverableItemsDeletions"
        | RecoverableItemsPurges -> "RecoverableItemsPurges"

type EmailSecurityPostBulkMessageMovePayload =
    { destination: Destination
      ///List of message IDs to move.
      ids: Option<list<string>> }
    ///Creates an instance of EmailSecurityPostBulkMessageMovePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination: Destination): EmailSecurityPostBulkMessageMovePayload =
        { destination = destination
          ids = None }

[<RequireQualifiedAccess>]
type EmailSecurityPostBulkMessageMove =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

type EmailSecurityPostPreviewPayload =
    { ///The identifier of the message.
      postfix_id: ``email-securityPostfixId`` }
    ///Creates an instance of EmailSecurityPostPreviewPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (postfix_id: ``email-securityPostfixId``): EmailSecurityPostPreviewPayload =
        { postfix_id = postfix_id }

[<RequireQualifiedAccess>]
type EmailSecurityPostPreview =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityPostRelease =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetMessage =
    ///Contains the email message details.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetMessageDetections =
    ///Contains the email message details.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EmailSecurityPostMessageMovePayloadDestination =
    | [<CompiledName "Inbox">] Inbox
    | [<CompiledName "JunkEmail">] JunkEmail
    | [<CompiledName "DeletedItems">] DeletedItems
    | [<CompiledName "RecoverableItemsDeletions">] RecoverableItemsDeletions
    | [<CompiledName "RecoverableItemsPurges">] RecoverableItemsPurges
    member this.Format() =
        match this with
        | Inbox -> "Inbox"
        | JunkEmail -> "JunkEmail"
        | DeletedItems -> "DeletedItems"
        | RecoverableItemsDeletions -> "RecoverableItemsDeletions"
        | RecoverableItemsPurges -> "RecoverableItemsPurges"

type EmailSecurityPostMessageMovePayload =
    { destination: EmailSecurityPostMessageMovePayloadDestination }
    ///Creates an instance of EmailSecurityPostMessageMovePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination: EmailSecurityPostMessageMovePayloadDestination): EmailSecurityPostMessageMovePayload =
        { destination = destination }

[<RequireQualifiedAccess>]
type EmailSecurityPostMessageMove =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetMessagePreview =
    ///Contains a preview of the email.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetMessageRaw =
    ///Contains the raw content of the email.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Expecteddisposition =
    | [<CompiledName "NONE">] NONE
    | [<CompiledName "BULK">] BULK
    | [<CompiledName "MALICIOUS">] MALICIOUS
    | [<CompiledName "SPAM">] SPAM
    | [<CompiledName "SPOOF">] SPOOF
    | [<CompiledName "SUSPICIOUS">] SUSPICIOUS
    member this.Format() =
        match this with
        | NONE -> "NONE"
        | BULK -> "BULK"
        | MALICIOUS -> "MALICIOUS"
        | SPAM -> "SPAM"
        | SPOOF -> "SPOOF"
        | SUSPICIOUS -> "SUSPICIOUS"

type EmailSecurityPostReclassifyPayload =
    { ///Base64 encoded content of the EML file
      eml_content: Option<string>
      escalated_submission_id: Option<string>
      expected_disposition: Expecteddisposition }
    ///Creates an instance of EmailSecurityPostReclassifyPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (expected_disposition: Expecteddisposition): EmailSecurityPostReclassifyPayload =
        { eml_content = None
          escalated_submission_id = None
          expected_disposition = expected_disposition }

[<RequireQualifiedAccess>]
type EmailSecurityPostReclassify =
    | Accepted of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetMessageTrace =
    ///Contains the email trace.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetPhishguardReports =
    ///Contains a list of PhishGuard reports.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityListAllowPolicies =
    ///Contains a list of allow policies for the account.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityCreateAllowPolicy =
    ///Contains the newly created policy.
    | Created of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

type Deletes =
    { ///The unique identifier for the allow policy.
      id: int }
    ///Creates an instance of Deletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: int): Deletes = { id = id }

type EmailSecurityBatchAllowPoliciesPayload =
    { deletes: list<Deletes>
      patches: list<string>
      posts: list<``email-securityCreateAllowPolicy``>
      puts: list<string> }
    ///Creates an instance of EmailSecurityBatchAllowPoliciesPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<Deletes>,
                          patches: list<string>,
                          posts: list<``email-securityCreateAllowPolicy``>,
                          puts: list<string>): EmailSecurityBatchAllowPoliciesPayload =
        { deletes = deletes
          patches = patches
          posts = posts
          puts = puts }

[<RequireQualifiedAccess>]
type EmailSecurityBatchAllowPolicies =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityDeleteAllowPolicy =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetAllowPolicy =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityUpdateAllowPolicy =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityListBlockedSenders =
    ///Contains a list of blocked senders for the account.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityCreateBlockedSender =
    ///Contains the newly created pattern.
    | Created of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

type EmailSecurityBatchBlockedSendersPayloadDeletes =
    { ///The unique identifier for the allow policy.
      id: int }
    ///Creates an instance of EmailSecurityBatchBlockedSendersPayloadDeletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: int): EmailSecurityBatchBlockedSendersPayloadDeletes = { id = id }

type EmailSecurityBatchBlockedSendersPayload =
    { deletes: list<EmailSecurityBatchBlockedSendersPayloadDeletes>
      patches: list<string>
      posts: list<``email-securityCreateBlockedSender``>
      puts: list<string> }
    ///Creates an instance of EmailSecurityBatchBlockedSendersPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<EmailSecurityBatchBlockedSendersPayloadDeletes>,
                          patches: list<string>,
                          posts: list<``email-securityCreateBlockedSender``>,
                          puts: list<string>): EmailSecurityBatchBlockedSendersPayload =
        { deletes = deletes
          patches = patches
          posts = posts
          puts = puts }

[<RequireQualifiedAccess>]
type EmailSecurityBatchBlockedSenders =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityDeleteBlockedSender =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetBlockedSender =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityUpdateBlockedSender =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

type EmailSecurityDeleteDomainsPayloadArrayItem =
    { ///The unique identifier for the domain.
      id: int }
    ///Creates an instance of EmailSecurityDeleteDomainsPayloadArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: int): EmailSecurityDeleteDomainsPayloadArrayItem = { id = id }

type EmailSecurityDeleteDomainsPayload = list<EmailSecurityDeleteDomainsPayloadArrayItem>

[<RequireQualifiedAccess>]
type EmailSecurityDeleteDomains =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityListDomains =
    ///Contains a list of domains for the account.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityDeleteDomain =
    ///Deletes the domain with the provided id.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetDomain =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EmailSecurityUpdateDomainPayloadRegions =
    | [<CompiledName "GLOBAL">] GLOBAL
    | [<CompiledName "AU">] AU
    | [<CompiledName "DE">] DE
    | [<CompiledName "IN">] IN
    | [<CompiledName "US">] US
    member this.Format() =
        match this with
        | GLOBAL -> "GLOBAL"
        | AU -> "AU"
        | DE -> "DE"
        | IN -> "IN"
        | US -> "US"

type EmailSecurityUpdateDomainPayload =
    { allowed_delivery_modes: Option<list<``email-securityDeliveryMode``>>
      domain: Option<string>
      drop_dispositions: Option<list<``email-securityDispositionLabel``>>
      folder: Option<Newtonsoft.Json.Linq.JToken>
      integration_id: Option<System.Guid>
      ip_restrictions: list<string>
      lookback_hops: Option<int>
      regions: Option<list<EmailSecurityUpdateDomainPayloadRegions>>
      require_tls_inbound: Option<bool>
      require_tls_outbound: Option<bool>
      transport: Option<string> }
    ///Creates an instance of EmailSecurityUpdateDomainPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ip_restrictions: list<string>): EmailSecurityUpdateDomainPayload =
        { allowed_delivery_modes = None
          domain = None
          drop_dispositions = None
          folder = None
          integration_id = None
          ip_restrictions = ip_restrictions
          lookback_hops = None
          regions = None
          require_tls_inbound = None
          require_tls_outbound = None
          transport = None }

[<RequireQualifiedAccess>]
type EmailSecurityUpdateDomain =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityListDisplayNames =
    ///Contains the list of impersonation registry entries for the account.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityCreateDisplayName =
    | Created of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityDeleteDisplayName =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetDisplayName =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

type EmailSecurityUpdateDisplayNamePayload =
    { email: Option<string>
      is_email_regex: Option<bool>
      name: Option<string> }
    ///Creates an instance of EmailSecurityUpdateDisplayNamePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): EmailSecurityUpdateDisplayNamePayload =
        { email = None
          is_email_regex = None
          name = None }

[<RequireQualifiedAccess>]
type EmailSecurityUpdateDisplayName =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

type EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes =
    { id: int }
    ///Creates an instance of EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: int): EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes = { id = id }

type EmailSecurityBatchSendingDomainRestrictionsPayload =
    { deletes: list<EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes> }
    ///Creates an instance of EmailSecurityBatchSendingDomainRestrictionsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes>): EmailSecurityBatchSendingDomainRestrictionsPayload =
        { deletes = deletes }

[<RequireQualifiedAccess>]
type EmailSecurityBatchSendingDomainRestrictions =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityListTrustedDomains =
    ///Contains the list of trusted domains for the account.
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityCreateTrustedDomain =
    ///Contains the new trusted domain in the shape of the request body.
    | Created of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

type EmailSecurityBatchTrustedDomainsPayloadDeletes =
    { ///The unique identifier for the trusted domain.
      id: int }
    ///Creates an instance of EmailSecurityBatchTrustedDomainsPayloadDeletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: int): EmailSecurityBatchTrustedDomainsPayloadDeletes = { id = id }

type EmailSecurityBatchTrustedDomainsPayload =
    { deletes: list<EmailSecurityBatchTrustedDomainsPayloadDeletes>
      patches: list<string>
      posts: list<``email-securityCreateTrustedDomain``>
      puts: list<string> }
    ///Creates an instance of EmailSecurityBatchTrustedDomainsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<EmailSecurityBatchTrustedDomainsPayloadDeletes>,
                          patches: list<string>,
                          posts: list<``email-securityCreateTrustedDomain``>,
                          puts: list<string>): EmailSecurityBatchTrustedDomainsPayload =
        { deletes = deletes
          patches = patches
          posts = posts
          puts = puts }

[<RequireQualifiedAccess>]
type EmailSecurityBatchTrustedDomains =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityDeleteTrustedDomain =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecurityGetTrustedDomain =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

type EmailSecurityUpdateTrustedDomainPayload =
    { comments: Option<string>
      ///Select to prevent recently registered domains from triggering a
      ///Suspicious or Malicious disposition.
      is_recent: Option<bool>
      is_regex: Option<bool>
      ///Select for partner or other approved domains that have similar
      ///spelling to your connected domains. Prevents listed domains from
      ///triggering a Spoof disposition.
      is_similarity: Option<bool>
      pattern: Option<string> }
    ///Creates an instance of EmailSecurityUpdateTrustedDomainPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): EmailSecurityUpdateTrustedDomainPayload =
        { comments = None
          is_recent = None
          is_regex = None
          is_similarity = None
          pattern = None }

[<RequireQualifiedAccess>]
type EmailSecurityUpdateTrustedDomain =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailSecuritySubmissions =
    | OK of payload: string
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EmailRoutingDestinationAddressesListDestinationAddresses =
    ///List destination addresses response
    | OK of payload: emaildestinationaddressesresponsecollection

[<RequireQualifiedAccess>]
type EmailRoutingDestinationAddressesCreateADestinationAddress =
    ///Create a destination address response
    | OK of payload: emaildestinationaddressresponsesingle

[<RequireQualifiedAccess>]
type EmailRoutingDestinationAddressesDeleteDestinationAddress =
    ///Delete destination address response
    | OK of payload: emaildestinationaddressresponsesingle

[<RequireQualifiedAccess>]
type EmailRoutingDestinationAddressesGetADestinationAddress =
    ///Get a destination address response
    | OK of payload: emaildestinationaddressresponsesingle
