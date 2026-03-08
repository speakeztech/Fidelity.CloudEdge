namespace rec Fidelity.CloudEdge.Management.Email

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Email.Types
open Fidelity.CloudEdge.Management.Email.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type EmailClient(httpClient: HttpClient) =
    ///<summary>
    ///Returns information for each email that matches the search parameter(s).
    ///If the search takes too long, the endpoint returns 202 with a Location header
    ///pointing to a polling endpoint where results can be retrieved once ready.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="start">
    ///The beginning of the search date range.
    ///Defaults to `now - 30 days` if not provided.
    ///</param>
    ///<param name="end">
    ///The end of the search date range.
    ///Defaults to `now` if not provided.
    ///</param>
    ///<param name="query">
    ///The space-delimited term used in the query. The search is case-insensitive.
    ///The content of the following email metadata fields are searched:
    ///* alert_id
    ///* CC
    ///* From (envelope_from)
    ///* From Name
    ///* final_disposition
    ///* md5 hash (of any attachment)
    ///* sha1 hash (of any attachment)
    ///* sha256 hash (of any attachment)
    ///* name (of any attachment)
    ///* Reason
    ///* Received DateTime (yyyy-mm-ddThh:mm:ss)
    ///* Sent DateTime (yyyy-mm-ddThh:mm:ss)
    ///* ReplyTo
    ///* To (envelope_to)
    ///* To Name
    ///* Message-ID
    ///* smtp_helo_server_ip
    ///* smtp_previous_hop_ip
    ///* x_originating_ip
    ///* Subject
    ///</param>
    ///<param name="detectionsOnly">Determines if the search results will include detections or not.</param>
    ///<param name="actionLog">Determines if the message action log is included in the response.</param>
    ///<param name="finalDisposition">The dispositions the search filters by.</param>
    ///<param name="metric"></param>
    ///<param name="messageAction">The message actions the search filters by.</param>
    ///<param name="recipient">Filter by recipient. Matches either an email address or a domain.</param>
    ///<param name="sender">Filter by sender. Matches either an email address or a domain.</param>
    ///<param name="alertId"></param>
    ///<param name="domain">Filter by a domain found in the email: sender domain, recipient domain, or a domain in a link.</param>
    ///<param name="messageId"></param>
    ///<param name="subject">Search for messages containing individual keywords in any order within the subject.</param>
    ///<param name="exactSubject">Search for messages with an exact subject match.</param>
    ///<param name="cursor"></param>
    ///<param name="perPage">The number of results per page.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityInvestigate
        (
            accountId: string,
            ?start: System.DateTimeOffset,
            ?``end``: System.DateTimeOffset,
            ?query: string,
            ?detectionsOnly: bool,
            ?actionLog: bool,
            ?finalDisposition: string,
            ?metric: string,
            ?messageAction: string,
            ?recipient: string,
            ?sender: string,
            ?alertId: string,
            ?domain: string,
            ?messageId: string,
            ?subject: string,
            ?exactSubject: string,
            ?cursor: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if start.IsSome then
                      RequestPart.query ("start", start.Value)
                  if ``end``.IsSome then
                      RequestPart.query ("end", ``end``.Value)
                  if query.IsSome then
                      RequestPart.query ("query", query.Value)
                  if detectionsOnly.IsSome then
                      RequestPart.query ("detections_only", detectionsOnly.Value)
                  if actionLog.IsSome then
                      RequestPart.query ("action_log", actionLog.Value)
                  if finalDisposition.IsSome then
                      RequestPart.query ("final_disposition", finalDisposition.Value)
                  if metric.IsSome then
                      RequestPart.query ("metric", metric.Value)
                  if messageAction.IsSome then
                      RequestPart.query ("message_action", messageAction.Value)
                  if recipient.IsSome then
                      RequestPart.query ("recipient", recipient.Value)
                  if sender.IsSome then
                      RequestPart.query ("sender", sender.Value)
                  if alertId.IsSome then
                      RequestPart.query ("alert_id", alertId.Value)
                  if domain.IsSome then
                      RequestPart.query ("domain", domain.Value)
                  if messageId.IsSome then
                      RequestPart.query ("message_id", messageId.Value)
                  if subject.IsSome then
                      RequestPart.query ("subject", subject.Value)
                  if exactSubject.IsSome then
                      RequestPart.query ("exact_subject", exactSubject.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityInvestigate.OK(Serializer.deserialize content)
            | 202 -> return EmailSecurityInvestigate.Accepted(Serializer.deserialize content)
            | _ -> return EmailSecurityInvestigate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Maximum batch size: 1000 messages per request
    ///</summary>
    member this.EmailSecurityPostBulkMessageMove
        (
            accountId: string,
            body: EmailSecurityPostBulkMessageMovePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/move"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityPostBulkMessageMove.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityPostBulkMessageMove.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Generates a preview of an email message for safe viewing without executing any
    ///embedded content.
    ///</summary>
    member this.EmailSecurityPostPreview
        (
            accountId: string,
            body: EmailSecurityPostPreviewPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/preview"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityPostPreview.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityPostPreview.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Releases a quarantined email message, allowing it to be delivered to the recipient.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="body">A list of messages identfied by their `postfix_id`s that should be released.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityPostRelease(accountId: string, body: list<string>, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/release"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityPostRelease.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityPostRelease.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves detailed information about a specific email message, including headers,
    ///metadata, and security scan results.
    ///</summary>
    member this.EmailSecurityGetMessage(accountId: string, postfixId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("postfix_id", postfixId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{postfix_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessage.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessage.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns detection details such as threat categories and sender information for non-benign messages.
    ///</summary>
    member this.EmailSecurityGetMessageDetections
        (
            accountId: string,
            postfixId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("postfix_id", postfixId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{postfix_id}/detections"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessageDetections.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessageDetections.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Moves a single email message to a different folder or changes its quarantine status.
    ///</summary>
    member this.EmailSecurityPostMessageMove
        (
            accountId: string,
            postfixId: string,
            body: EmailSecurityPostMessageMovePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("postfix_id", postfixId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{postfix_id}/move"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityPostMessageMove.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityPostMessageMove.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a preview of the message body as a base64 encoded PNG image for non-benign messages.
    ///</summary>
    member this.EmailSecurityGetMessagePreview
        (
            accountId: string,
            postfixId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("postfix_id", postfixId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{postfix_id}/preview"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessagePreview.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessagePreview.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the raw eml of any non-benign message.
    ///</summary>
    member this.EmailSecurityGetMessageRaw
        (
            accountId: string,
            postfixId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("postfix_id", postfixId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{postfix_id}/raw"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessageRaw.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessageRaw.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Submits an email message for reclassification, updating its threat assessment
    ///based on new analysis.
    ///</summary>
    member this.EmailSecurityPostReclassify
        (
            accountId: string,
            postfixId: string,
            body: EmailSecurityPostReclassifyPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("postfix_id", postfixId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{postfix_id}/reclassify"
                    requestParts
                    cancellationToken

            match int status with
            | 202 -> return EmailSecurityPostReclassify.Accepted(Serializer.deserialize content)
            | _ -> return EmailSecurityPostReclassify.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets the delivery trace for an email message, showing its path through email
    ///security processing.
    ///</summary>
    member this.EmailSecurityGetMessageTrace
        (
            accountId: string,
            postfixId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("postfix_id", postfixId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{postfix_id}/trace"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessageTrace.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessageTrace.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves `PhishGuard` reports showing phishing attempts and suspicious email patterns
    ///detected.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="start">The beginning of the search date range (RFC3339 format).</param>
    ///<param name="end">The end of the search date range (RFC3339 format).</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetPhishguardReports
        (
            accountId: string,
            ?start: System.DateTimeOffset,
            ?``end``: System.DateTimeOffset,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if start.IsSome then
                      RequestPart.query ("start", start.Value)
                  if ``end``.IsSome then
                      RequestPart.query ("end", ``end``.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/phishguard/reports"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetPhishguardReports.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetPhishguardReports.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists, searches, and sorts an account’s email allow policies.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">The page number of paginated results.</param>
    ///<param name="perPage">The number of results per page.</param>
    ///<param name="order">The field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="search">
    ///Allows searching in multiple properties of a record simultaneously.
    ///This parameter is intended for human users, not automation. Its exact
    ///behavior is intentionally left unspecified and is subject to change
    ///in the future.
    ///</param>
    ///<param name="isTrustedSender"></param>
    ///<param name="isExemptRecipient"></param>
    ///<param name="isAcceptableSender"></param>
    ///<param name="verifySender"></param>
    ///<param name="patternType"></param>
    ///<param name="pattern"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListAllowPolicies
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?order: string,
            ?direction: string,
            ?search: string,
            ?isTrustedSender: bool,
            ?isExemptRecipient: bool,
            ?isAcceptableSender: bool,
            ?verifySender: bool,
            ?patternType: string,
            ?pattern: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if isTrustedSender.IsSome then
                      RequestPart.query ("is_trusted_sender", isTrustedSender.Value)
                  if isExemptRecipient.IsSome then
                      RequestPart.query ("is_exempt_recipient", isExemptRecipient.Value)
                  if isAcceptableSender.IsSome then
                      RequestPart.query ("is_acceptable_sender", isAcceptableSender.Value)
                  if verifySender.IsSome then
                      RequestPart.query ("verify_sender", verifySender.Value)
                  if patternType.IsSome then
                      RequestPart.query ("pattern_type", patternType.Value)
                  if pattern.IsSome then
                      RequestPart.query ("pattern", pattern.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListAllowPolicies.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListAllowPolicies.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new email allow policy that permits specific senders, domains, or patterns
    ///to bypass security scanning.
    ///</summary>
    member this.EmailSecurityCreateAllowPolicy
        (
            accountId: string,
            body: ``email-securityCreateAllowPolicy``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateAllowPolicy.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateAllowPolicy.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Send a Batch of Allow Policies API calls to be executed together.
    ///</summary>
    member this.EmailSecurityBatchAllowPolicies
        (
            accountId: string,
            body: EmailSecurityBatchAllowPoliciesPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityBatchAllowPolicies.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityBatchAllowPolicies.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes an email allow policy. Previously allowed senders will be subject to normal
    ///security scanning.
    ///</summary>
    member this.EmailSecurityDeleteAllowPolicy
        (
            accountId: string,
            policyId: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_id", policyId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies/{policy_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteAllowPolicy.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteAllowPolicy.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific email allow policy, including its matching criteria
    ///and scope.
    ///</summary>
    member this.EmailSecurityGetAllowPolicy(accountId: string, policyId: int, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_id", policyId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies/{policy_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetAllowPolicy.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetAllowPolicy.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing email allow policy, modifying its matching criteria or scope.
    ///</summary>
    member this.EmailSecurityUpdateAllowPolicy
        (
            accountId: string,
            policyId: int,
            body: ``email-securityUpdateAllowPolicy``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_id", policyId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies/{policy_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateAllowPolicy.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateAllowPolicy.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all blocked sender entries with their patterns and block reasons.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">The page number of paginated results.</param>
    ///<param name="perPage">The number of results per page.</param>
    ///<param name="order">The field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="search">
    ///Allows searching in multiple properties of a record simultaneously.
    ///This parameter is intended for human users, not automation. Its exact
    ///behavior is intentionally left unspecified and is subject to change
    ///in the future.
    ///</param>
    ///<param name="patternType"></param>
    ///<param name="pattern"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListBlockedSenders
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?order: string,
            ?direction: string,
            ?search: string,
            ?patternType: string,
            ?pattern: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if patternType.IsSome then
                      RequestPart.query ("pattern_type", patternType.Value)
                  if pattern.IsSome then
                      RequestPart.query ("pattern", pattern.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListBlockedSenders.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListBlockedSenders.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Adds a sender pattern to the email block list, preventing messages from matching
    ///senders from being delivered.
    ///</summary>
    member this.EmailSecurityCreateBlockedSender
        (
            accountId: string,
            body: ``email-securityCreateBlockedSender``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateBlockedSender.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateBlockedSender.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Send a Batch of Block Senders API calls to be executed together.
    ///</summary>
    member this.EmailSecurityBatchBlockedSenders
        (
            accountId: string,
            body: EmailSecurityBatchBlockedSendersPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityBatchBlockedSenders.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityBatchBlockedSenders.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a sender from the email block list, allowing their messages to be delivered
    ///normally.
    ///</summary>
    member this.EmailSecurityDeleteBlockedSender
        (
            accountId: string,
            patternId: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pattern_id", patternId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders/{pattern_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteBlockedSender.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteBlockedSender.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets information about a specific blocked sender entry, including the pattern and
    ///block reason.
    ///</summary>
    member this.EmailSecurityGetBlockedSender
        (
            accountId: string,
            patternId: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pattern_id", patternId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders/{pattern_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetBlockedSender.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetBlockedSender.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Modifies a blocked sender entry, updating its pattern or block reason.
    ///</summary>
    member this.EmailSecurityUpdateBlockedSender
        (
            accountId: string,
            patternId: int,
            body: ``email-securityUpdateBlockedSender``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pattern_id", patternId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders/{pattern_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateBlockedSender.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateBlockedSender.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Bulk removes multiple domains from email security configuration in a single request.
    ///</summary>
    member this.EmailSecurityDeleteDomains
        (
            accountId: string,
            body: EmailSecurityDeleteDomainsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/domains"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteDomains.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteDomains.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists, searches, and sorts an account’s email domains.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">The page number of paginated results.</param>
    ///<param name="perPage">The number of results per page.</param>
    ///<param name="order">The field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="search">
    ///Allows searching in multiple properties of a record simultaneously.
    ///This parameter is intended for human users, not automation. Its exact
    ///behavior is intentionally left unspecified and is subject to change
    ///in the future.
    ///</param>
    ///<param name="allowedDeliveryMode">Filters response to domains with the provided delivery mode.</param>
    ///<param name="domain">Filters results by the provided domains, allowing for multiple occurrences.</param>
    ///<param name="activeDeliveryMode">Filters response to domains with the currently active delivery mode.</param>
    ///<param name="integrationId">Filters response to domains with the provided integration ID.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListDomains
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?order: string,
            ?direction: string,
            ?search: string,
            ?allowedDeliveryMode: string,
            ?domain: list<string>,
            ?activeDeliveryMode: string,
            ?integrationId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if allowedDeliveryMode.IsSome then
                      RequestPart.query ("allowed_delivery_mode", allowedDeliveryMode.Value)
                  if domain.IsSome then
                      RequestPart.query ("domain", domain.Value)
                  if activeDeliveryMode.IsSome then
                      RequestPart.query ("active_delivery_mode", activeDeliveryMode.Value)
                  if integrationId.IsSome then
                      RequestPart.query ("integration_id", integrationId.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/domains"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListDomains.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListDomains.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Unprotect an email domain
    ///</summary>
    member this.EmailSecurityDeleteDomain(accountId: string, domainId: int, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_id", domainId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/domains/{domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets configuration details for a specific domain in email security.
    ///</summary>
    member this.EmailSecurityGetDomain(accountId: string, domainId: int, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_id", domainId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/domains/{domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates configuration for a domain in email security.
    ///</summary>
    member this.EmailSecurityUpdateDomain
        (
            accountId: string,
            domainId: int,
            body: EmailSecurityUpdateDomainPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_id", domainId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/domains/{domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists, searches, and sorts entries in the impersonation registry.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">The page number of paginated results.</param>
    ///<param name="perPage">The number of results per page.</param>
    ///<param name="order">The field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="search">
    ///Allows searching in multiple properties of a record simultaneously.
    ///This parameter is intended for human users, not automation. Its exact
    ///behavior is intentionally left unspecified and is subject to change
    ///in the future.
    ///</param>
    ///<param name="provenance"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListDisplayNames
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?order: string,
            ?direction: string,
            ?search: string,
            ?provenance: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if provenance.IsSome then
                      RequestPart.query ("provenance", provenance.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListDisplayNames.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListDisplayNames.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a display name entry for email security impersonation protection.
    ///</summary>
    member this.EmailSecurityCreateDisplayName
        (
            accountId: string,
            body: ``email-securityCreateDisplayName``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateDisplayName.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateDisplayName.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a display name from impersonation protection monitoring.
    ///</summary>
    member this.EmailSecurityDeleteDisplayName
        (
            accountId: string,
            displayNameId: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("display_name_id", displayNameId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry/{display_name_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteDisplayName.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteDisplayName.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves a display name entry used for impersonation protection.
    ///</summary>
    member this.EmailSecurityGetDisplayName
        (
            accountId: string,
            displayNameId: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("display_name_id", displayNameId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry/{display_name_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetDisplayName.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetDisplayName.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a display name entry used for impersonation protection.
    ///</summary>
    member this.EmailSecurityUpdateDisplayName
        (
            accountId: string,
            displayNameId: int,
            body: EmailSecurityUpdateDisplayNamePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("display_name_id", displayNameId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry/{display_name_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateDisplayName.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateDisplayName.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Send a Batch of `sending_domain_restrictions` API calls to be executed together.
    ///</summary>
    member this.EmailSecurityBatchSendingDomainRestrictions
        (
            accountId: string,
            body: EmailSecurityBatchSendingDomainRestrictionsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/sending_domain_restrictions/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityBatchSendingDomainRestrictions.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityBatchSendingDomainRestrictions.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists, searches, and sorts an account’s trusted email domains.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">The page number of paginated results.</param>
    ///<param name="perPage">The number of results per page.</param>
    ///<param name="order">The field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="search">
    ///Allows searching in multiple properties of a record simultaneously.
    ///This parameter is intended for human users, not automation. Its exact
    ///behavior is intentionally left unspecified and is subject to change
    ///in the future.
    ///</param>
    ///<param name="isRecent"></param>
    ///<param name="isSimilarity"></param>
    ///<param name="pattern"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListTrustedDomains
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?order: string,
            ?direction: string,
            ?search: string,
            ?isRecent: bool,
            ?isSimilarity: bool,
            ?pattern: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if isRecent.IsSome then
                      RequestPart.query ("is_recent", isRecent.Value)
                  if isSimilarity.IsSome then
                      RequestPart.query ("is_similarity", isSimilarity.Value)
                  if pattern.IsSome then
                      RequestPart.query ("pattern", pattern.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListTrustedDomains.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListTrustedDomains.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Adds a domain to the trusted domains list for email security, reducing false positive
    ///detections.
    ///</summary>
    member this.EmailSecurityCreateTrustedDomain(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateTrustedDomain.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateTrustedDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Send a Batch of Trusted Domains API calls to be executed together.
    ///</summary>
    member this.EmailSecurityBatchTrustedDomains
        (
            accountId: string,
            body: EmailSecurityBatchTrustedDomainsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityBatchTrustedDomains.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityBatchTrustedDomains.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a domain from the trusted domains list, subjecting it to normal security
    ///scanning.
    ///</summary>
    member this.EmailSecurityDeleteTrustedDomain
        (
            accountId: string,
            trustedDomainId: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trusted_domain_id", trustedDomainId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains/{trusted_domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteTrustedDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteTrustedDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets information about a specific trusted domain entry.
    ///</summary>
    member this.EmailSecurityGetTrustedDomain
        (
            accountId: string,
            trustedDomainId: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trusted_domain_id", trustedDomainId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains/{trusted_domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetTrustedDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetTrustedDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Modifies a trusted domain entry's configuration.
    ///</summary>
    member this.EmailSecurityUpdateTrustedDomain
        (
            accountId: string,
            trustedDomainId: int,
            body: EmailSecurityUpdateTrustedDomainPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trusted_domain_id", trustedDomainId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains/{trusted_domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateTrustedDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateTrustedDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///This endpoint returns information for submissions to made to reclassify emails.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="start">
    ///The beginning of the search date range.
    ///Defaults to `now - 30 days` if not provided.
    ///</param>
    ///<param name="end">
    ///The end of the search date range.
    ///Defaults to `now` if not provided.
    ///</param>
    ///<param name="type"></param>
    ///<param name="submissionId"></param>
    ///<param name="originalDisposition"></param>
    ///<param name="requestedDisposition"></param>
    ///<param name="outcomeDisposition"></param>
    ///<param name="status"></param>
    ///<param name="query"></param>
    ///<param name="customerStatus"></param>
    ///<param name="page">The page number of paginated results.</param>
    ///<param name="perPage">The number of results per page.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecuritySubmissions
        (
            accountId: string,
            ?start: System.DateTimeOffset,
            ?``end``: System.DateTimeOffset,
            ?``type``: string,
            ?submissionId: string,
            ?originalDisposition: string,
            ?requestedDisposition: string,
            ?outcomeDisposition: string,
            ?status: string,
            ?query: string,
            ?customerStatus: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if start.IsSome then
                      RequestPart.query ("start", start.Value)
                  if ``end``.IsSome then
                      RequestPart.query ("end", ``end``.Value)
                  if ``type``.IsSome then
                      RequestPart.query ("type", ``type``.Value)
                  if submissionId.IsSome then
                      RequestPart.query ("submission_id", submissionId.Value)
                  if originalDisposition.IsSome then
                      RequestPart.query ("original_disposition", originalDisposition.Value)
                  if requestedDisposition.IsSome then
                      RequestPart.query ("requested_disposition", requestedDisposition.Value)
                  if outcomeDisposition.IsSome then
                      RequestPart.query ("outcome_disposition", outcomeDisposition.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if query.IsSome then
                      RequestPart.query ("query", query.Value)
                  if customerStatus.IsSome then
                      RequestPart.query ("customer_status", customerStatus.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/submissions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecuritySubmissions.OK(Serializer.deserialize content)
            | _ -> return EmailSecuritySubmissions.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists existing destination addresses.
    ///</summary>
    member this.EmailRoutingDestinationAddressesListDestinationAddresses
        (
            accountId: string,
            ?page: float,
            ?perPage: float,
            ?direction: string,
            ?verified: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if verified.IsSome then
                      RequestPart.query ("verified", verified.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/addresses"
                    requestParts
                    cancellationToken

            return EmailRoutingDestinationAddressesListDestinationAddresses.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a destination address to forward your emails to. Destination addresses need to be verified before they can be used.
    ///</summary>
    member this.EmailRoutingDestinationAddressesCreateADestinationAddress
        (
            accountId: string,
            body: emailcreatedestinationaddressproperties,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/addresses"
                    requestParts
                    cancellationToken

            return EmailRoutingDestinationAddressesCreateADestinationAddress.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a specific destination address.
    ///</summary>
    member this.EmailRoutingDestinationAddressesDeleteDestinationAddress
        (
            destinationAddressIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("destination_address_identifier", destinationAddressIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/addresses/{destination_address_identifier}"
                    requestParts
                    cancellationToken

            return EmailRoutingDestinationAddressesDeleteDestinationAddress.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets information for a specific destination email already created.
    ///</summary>
    member this.EmailRoutingDestinationAddressesGetADestinationAddress
        (
            destinationAddressIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("destination_address_identifier", destinationAddressIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/addresses/{destination_address_identifier}"
                    requestParts
                    cancellationToken

            return EmailRoutingDestinationAddressesGetADestinationAddress.OK(Serializer.deserialize content)
        }
