namespace rec Fidelity.CloudEdge.Management.Stream

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Stream.Types
open Fidelity.CloudEdge.Management.Stream.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type StreamClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists up to 1000 videos from a single request. For a specific range, refer to the optional parameters.
    ///</summary>
    member this.StreamVideosListVideos
        (
            accountId: string,
            ?status: string,
            ?creator: string,
            ?``type``: string,
            ?asc: bool,
            ?videoName: string,
            ?search: string,
            ?start: System.DateTimeOffset,
            ?``end``: System.DateTimeOffset,
            ?includeCounts: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if creator.IsSome then
                      RequestPart.query ("creator", creator.Value)
                  if ``type``.IsSome then
                      RequestPart.query ("type", ``type``.Value)
                  if asc.IsSome then
                      RequestPart.query ("asc", asc.Value)
                  if videoName.IsSome then
                      RequestPart.query ("video_name", videoName.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if start.IsSome then
                      RequestPart.query ("start", start.Value)
                  if ``end``.IsSome then
                      RequestPart.query ("end", ``end``.Value)
                  if includeCounts.IsSome then
                      RequestPart.query ("include_counts", includeCounts.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/stream" requestParts cancellationToken

            match int status with
            | 200 -> return StreamVideosListVideos.OK(Serializer.deserialize content)
            | _ -> return StreamVideosListVideos.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Initiates a video upload using the TUS protocol. On success, the server responds with a status code 201 (created) and includes a `location` header to indicate where the content should be uploaded. Refer to https://tus.io for protocol details.
    ///</summary>
    member this.StreamVideosInitiateVideoUploadsUsingTus
        (
            tusResumable: string,
            uploadLength: int,
            accountId: string,
            ?uploadCreator: string,
            ?uploadMetadata: string,
            ?directUser: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.header ("Tus-Resumable", tusResumable)
                  RequestPart.header ("Upload-Length", uploadLength)
                  RequestPart.path ("account_id", accountId)
                  if uploadCreator.IsSome then
                      RequestPart.header ("Upload-Creator", uploadCreator.Value)
                  if uploadMetadata.IsSome then
                      RequestPart.header ("Upload-Metadata", uploadMetadata.Value)
                  if directUser.IsSome then
                      RequestPart.query ("direct_user", directUser.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/stream" requestParts cancellationToken

            match int status with
            | 200 -> return StreamVideosInitiateVideoUploadsUsingTus.OK(Serializer.deserialize content)
            | _ -> return StreamVideosInitiateVideoUploadsUsingTus.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Clips a video based on the specified start and end times provided in seconds.
    ///</summary>
    member this.StreamVideoClippingClipVideosGivenAStartAndEndTime
        (
            accountId: string,
            body: streamvideoClipStandard,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/stream/clip" requestParts cancellationToken

            match int status with
            | 200 -> return StreamVideoClippingClipVideosGivenAStartAndEndTime.OK(Serializer.deserialize content)
            | _ -> return StreamVideoClippingClipVideosGivenAStartAndEndTime.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Uploads a video to Stream from a provided URL.
    ///</summary>
    member this.StreamVideosUploadVideosFromAUrl
        (
            accountId: string,
            body: streamvideocopyrequest,
            ?uploadCreator: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if uploadCreator.IsSome then
                      RequestPart.header ("Upload-Creator", uploadCreator.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/stream/copy" requestParts cancellationToken

            match int status with
            | 200 -> return StreamVideosUploadVideosFromAUrl.OK(Serializer.deserialize content)
            | _ -> return StreamVideosUploadVideosFromAUrl.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a direct upload that allows video uploads without an API key.
    ///</summary>
    member this.StreamVideosUploadVideosViaDirectUploadUrLs
        (
            accountId: string,
            body: streamdirectuploadrequest,
            ?uploadCreator: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if uploadCreator.IsSome then
                      RequestPart.header ("Upload-Creator", uploadCreator.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/direct_upload"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamVideosUploadVideosViaDirectUploadUrLs.OK(Serializer.deserialize content)
            | _ -> return StreamVideosUploadVideosViaDirectUploadUrLs.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists the video ID and creation date and time when a signing key was created.
    ///</summary>
    member this.StreamSigningKeysListSigningKeys(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/stream/keys" requestParts cancellationToken

            match int status with
            | 200 -> return StreamSigningKeysListSigningKeys.OK(Serializer.deserialize content)
            | _ -> return StreamSigningKeysListSigningKeys.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates an RSA private key in PEM and JWK formats. Key files are only displayed once after creation. Keys are created, used, and deleted independently of videos, and every key can sign any video.
    ///</summary>
    member this.StreamSigningKeysCreateSigningKeys(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/stream/keys" requestParts cancellationToken

            match int status with
            | 200 -> return StreamSigningKeysCreateSigningKeys.OK(Serializer.deserialize content)
            | _ -> return StreamSigningKeysCreateSigningKeys.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes signing keys and revokes all signed URLs generated with the key.
    ///</summary>
    member this.StreamSigningKeysDeleteSigningKeys
        (
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/keys/{identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamSigningKeysDeleteSigningKeys.OK(Serializer.deserialize content)
            | _ -> return StreamSigningKeysDeleteSigningKeys.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists the live inputs created for an account. To get the credentials needed to stream to a specific live input, request a single live input.
    ///</summary>
    member this.StreamLiveInputsListLiveInputs
        (
            accountId: string,
            ?includeCounts: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if includeCounts.IsSome then
                      RequestPart.query ("include_counts", includeCounts.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamLiveInputsListLiveInputs.OK(Serializer.deserialize content)
            | _ -> return StreamLiveInputsListLiveInputs.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a live input, and returns credentials that you or your users can use to stream live video to Cloudflare Stream.
    ///</summary>
    member this.StreamLiveInputsCreateALiveInput
        (
            accountId: string,
            body: streamcreateinputrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamLiveInputsCreateALiveInput.OK(Serializer.deserialize content)
            | _ -> return StreamLiveInputsCreateALiveInput.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Prevents a live input from being streamed to and makes the live input inaccessible to any future API calls.
    ///</summary>
    member this.StreamLiveInputsDeleteALiveInput
        (
            liveInputIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("live_input_identifier", liveInputIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs/{live_input_identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamLiveInputsDeleteALiveInput.OK(Serializer.deserialize content)
            | _ -> return StreamLiveInputsDeleteALiveInput.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details of an existing live input.
    ///</summary>
    member this.StreamLiveInputsRetrieveALiveInput
        (
            liveInputIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("live_input_identifier", liveInputIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs/{live_input_identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamLiveInputsRetrieveALiveInput.OK(Serializer.deserialize content)
            | _ -> return StreamLiveInputsRetrieveALiveInput.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a specified live input.
    ///</summary>
    member this.StreamLiveInputsUpdateALiveInput
        (
            liveInputIdentifier: string,
            accountId: string,
            body: streamupdateinputrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("live_input_identifier", liveInputIdentifier)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs/{live_input_identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamLiveInputsUpdateALiveInput.OK(Serializer.deserialize content)
            | _ -> return StreamLiveInputsUpdateALiveInput.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Prevents a live input from being streamed to and makes the live input inaccessible to any future API calls until enabled.
    ///</summary>
    member this.StreamLiveInputsDisableALiveInput
        (
            liveInputIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("live_input_identifier", liveInputIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs/{live_input_identifier}/disable"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamLiveInputsDisableALiveInput.OK(Serializer.deserialize content)
            | _ -> return StreamLiveInputsDisableALiveInput.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Allows a live input to be streamed to and makes the live input accessible to any future API calls.
    ///</summary>
    member this.StreamLiveInputsEnableALiveInput
        (
            liveInputIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("live_input_identifier", liveInputIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs/{live_input_identifier}/enable"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamLiveInputsEnableALiveInput.OK(Serializer.deserialize content)
            | _ -> return StreamLiveInputsEnableALiveInput.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves all outputs associated with a specified live input.
    ///</summary>
    member this.StreamLiveInputsListAllOutputsAssociatedWithASpecifiedLiveInput
        (
            liveInputIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("live_input_identifier", liveInputIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs/{live_input_identifier}/outputs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 ->
                return
                    StreamLiveInputsListAllOutputsAssociatedWithASpecifiedLiveInput.OK(Serializer.deserialize content)
            | _ ->
                return
                    StreamLiveInputsListAllOutputsAssociatedWithASpecifiedLiveInput.BadRequest(
                        Serializer.deserialize content
                    )
        }

    ///<summary>
    ///Creates a new output that can be used to simulcast or restream live video to other RTMP or SRT destinations. Outputs are always linked to a specific live input — one live input can have many outputs.
    ///</summary>
    member this.``StreamLiveInputsCreateANewOutput,ConnectedToALiveInput``
        (
            liveInputIdentifier: string,
            accountId: string,
            body: streamcreateoutputrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("live_input_identifier", liveInputIdentifier)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs/{live_input_identifier}/outputs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 ->
                return ``StreamLiveInputsCreateANewOutput,ConnectedToALiveInput``.OK(Serializer.deserialize content)
            | _ ->
                return
                    ``StreamLiveInputsCreateANewOutput,ConnectedToALiveInput``.BadRequest(
                        Serializer.deserialize content
                    )
        }

    ///<summary>
    ///Deletes an output and removes it from the associated live input.
    ///</summary>
    member this.StreamLiveInputsDeleteAnOutput
        (
            outputIdentifier: string,
            liveInputIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("output_identifier", outputIdentifier)
                  RequestPart.path ("live_input_identifier", liveInputIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs/{live_input_identifier}/outputs/{output_identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamLiveInputsDeleteAnOutput.OK(Serializer.deserialize content)
            | _ -> return StreamLiveInputsDeleteAnOutput.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the state of an output.
    ///</summary>
    member this.StreamLiveInputsUpdateAnOutput
        (
            outputIdentifier: string,
            liveInputIdentifier: string,
            accountId: string,
            body: streamupdateoutputrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("output_identifier", outputIdentifier)
                  RequestPart.path ("live_input_identifier", liveInputIdentifier)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/stream/live_inputs/{live_input_identifier}/outputs/{output_identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamLiveInputsUpdateAnOutput.OK(Serializer.deserialize content)
            | _ -> return StreamLiveInputsUpdateAnOutput.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns information about an account's storage use.
    ///</summary>
    member this.StreamVideosStorageUsage(accountId: string, ?creator: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if creator.IsSome then
                      RequestPart.query ("creator", creator.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/storage-usage"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamVideosStorageUsage.OK(Serializer.deserialize content)
            | _ -> return StreamVideosStorageUsage.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all watermark profiles for an account.
    ///</summary>
    member this.StreamWatermarkProfileListWatermarkProfiles(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/watermarks"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamWatermarkProfileListWatermarkProfiles.OK(Serializer.deserialize content)
            | _ -> return StreamWatermarkProfileListWatermarkProfiles.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates watermark profiles using a single `HTTP POST multipart/form-data` request.
    ///</summary>
    member this.StreamWatermarkProfileCreateWatermarkProfilesViaBasicUpload
        (
            accountId: string,
            body: streamwatermarkbasicupload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/watermarks"
                    requestParts
                    cancellationToken

            match int status with
            | 200 ->
                return StreamWatermarkProfileCreateWatermarkProfilesViaBasicUpload.OK(Serializer.deserialize content)
            | _ ->
                return
                    StreamWatermarkProfileCreateWatermarkProfilesViaBasicUpload.BadRequest(
                        Serializer.deserialize content
                    )
        }

    ///<summary>
    ///Deletes a watermark profile.
    ///</summary>
    member this.StreamWatermarkProfileDeleteWatermarkProfiles
        (
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/watermarks/{identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamWatermarkProfileDeleteWatermarkProfiles.OK(Serializer.deserialize content)
            | _ -> return StreamWatermarkProfileDeleteWatermarkProfiles.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a single watermark profile.
    ///</summary>
    member this.StreamWatermarkProfileWatermarkProfileDetails
        (
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/watermarks/{identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamWatermarkProfileWatermarkProfileDetails.OK(Serializer.deserialize content)
            | _ -> return StreamWatermarkProfileWatermarkProfileDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a webhook.
    ///</summary>
    member this.StreamWebhookDeleteWebhooks(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/webhook"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamWebhookDeleteWebhooks.OK(Serializer.deserialize content)
            | _ -> return StreamWebhookDeleteWebhooks.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves a list of webhooks.
    ///</summary>
    member this.StreamWebhookViewWebhooks(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/stream/webhook" requestParts cancellationToken

            match int status with
            | 200 -> return StreamWebhookViewWebhooks.OK(Serializer.deserialize content)
            | _ -> return StreamWebhookViewWebhooks.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a webhook notification.
    ///</summary>
    member this.StreamWebhookCreateWebhooks
        (
            accountId: string,
            body: streamwebhookrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync httpClient "/accounts/{account_id}/stream/webhook" requestParts cancellationToken

            match int status with
            | 200 -> return StreamWebhookCreateWebhooks.OK(Serializer.deserialize content)
            | _ -> return StreamWebhookCreateWebhooks.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a video and its copies from Cloudflare Stream.
    ///</summary>
    member this.StreamVideosDeleteVideo(identifier: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamVideosDeleteVideo.OK(Serializer.deserialize content)
            | _ -> return StreamVideosDeleteVideo.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches details for a single video.
    ///</summary>
    member this.StreamVideosRetrieveVideoDetails
        (
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamVideosRetrieveVideoDetails.OK(Serializer.deserialize content)
            | _ -> return StreamVideosRetrieveVideoDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Edit details for a single video.
    ///</summary>
    member this.StreamVideosUpdateVideoDetails
        (
            identifier: string,
            accountId: string,
            body: streamvideoupdate,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamVideosUpdateVideoDetails.OK(Serializer.deserialize content)
            | _ -> return StreamVideosUpdateVideoDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists additional audio tracks on a video. Note this API will not return information for audio attached to the video upload.
    ///</summary>
    member this.ListAudioTracks(accountId: string, identifier: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("identifier", identifier) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/audio"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListAudioTracks.OK(Serializer.deserialize content)
            | _ -> return ListAudioTracks.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Adds an additional audio track to a video using the provided audio track URL.
    ///</summary>
    member this.AddAudioTrack
        (
            accountId: string,
            identifier: string,
            body: streamcopyAudioTrack,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("identifier", identifier)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/audio/copy"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AddAudioTrack.OK(Serializer.deserialize content)
            | _ -> return AddAudioTrack.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes additional audio tracks on a video. Deleting a default audio track is not allowed. You must assign another audio track as default prior to deletion.
    ///</summary>
    member this.DeleteAudioTracks
        (
            accountId: string,
            identifier: string,
            audioIdentifier: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("identifier", identifier)
                  RequestPart.path ("audio_identifier", audioIdentifier) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/audio/{audio_identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteAudioTracks.OK(Serializer.deserialize content)
            | _ -> return DeleteAudioTracks.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Edits additional audio tracks on a video. Editing the default status of an audio track to `true` will mark all other audio tracks on the video default status to `false`.
    ///</summary>
    member this.EditAudioTracks
        (
            accountId: string,
            identifier: string,
            audioIdentifier: string,
            body: streameditAudioTrack,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("identifier", identifier)
                  RequestPart.path ("audio_identifier", audioIdentifier)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/audio/{audio_identifier}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EditAudioTracks.OK(Serializer.deserialize content)
            | _ -> return EditAudioTracks.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists the available captions or subtitles for a specific video.
    ///</summary>
    member this.StreamSubtitlesCaptionsListCaptionsOrSubtitles
        (
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/captions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamSubtitlesCaptionsListCaptionsOrSubtitles.OK(Serializer.deserialize content)
            | _ -> return StreamSubtitlesCaptionsListCaptionsOrSubtitles.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes the captions or subtitles from a video.
    ///</summary>
    member this.StreamSubtitlesCaptionsDeleteCaptionsOrSubtitles
        (
            language: string,
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("language", language)
                  RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/captions/{language}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamSubtitlesCaptionsDeleteCaptionsOrSubtitles.OK(Serializer.deserialize content)
            | _ -> return StreamSubtitlesCaptionsDeleteCaptionsOrSubtitles.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists the captions or subtitles for provided language.
    ///</summary>
    member this.StreamSubtitlesCaptionsGetCaptionOrSubtitleForLanguage
        (
            language: string,
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("language", language)
                  RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/captions/{language}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamSubtitlesCaptionsGetCaptionOrSubtitleForLanguage.OK(Serializer.deserialize content)
            | _ ->
                return StreamSubtitlesCaptionsGetCaptionOrSubtitleForLanguage.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Uploads the caption or subtitle file to the endpoint for a specific BCP47 language. One caption or subtitle file per language is allowed.
    ///</summary>
    member this.StreamSubtitlesCaptionsUploadCaptionsOrSubtitles
        (
            language: string,
            identifier: string,
            accountId: string,
            body: streamcaptionbasicupload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("language", language)
                  RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/captions/{language}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamSubtitlesCaptionsUploadCaptionsOrSubtitles.OK(Serializer.deserialize content)
            | _ -> return StreamSubtitlesCaptionsUploadCaptionsOrSubtitles.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Generate captions or subtitles for provided language via AI.
    ///</summary>
    member this.StreamSubtitlesCaptionsGenerateCaptionOrSubtitleForLanguage
        (
            language: string,
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("language", language)
                  RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/captions/{language}/generate"
                    requestParts
                    cancellationToken

            match int status with
            | 200 ->
                return StreamSubtitlesCaptionsGenerateCaptionOrSubtitleForLanguage.OK(Serializer.deserialize content)
            | _ ->
                return
                    StreamSubtitlesCaptionsGenerateCaptionOrSubtitleForLanguage.BadRequest(
                        Serializer.deserialize content
                    )
        }

    ///<summary>
    ///Return WebVTT captions for a provided language.
    ///</summary>
    member this.StreamSubtitlesCaptionsGetVttCaptionOrSubtitle
        (
            language: string,
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("language", language)
                  RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/captions/{language}/vtt"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamSubtitlesCaptionsGetVttCaptionOrSubtitle.OK content
            | _ -> return StreamSubtitlesCaptionsGetVttCaptionOrSubtitle.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete the downloads for a video. Use `/downloads/{download_type}` instead for type-specific downloads. Available types are `default` and `audio`.
    ///</summary>
    member this.StreamMP4DownloadsDeleteDownloads
        (
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/downloads"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamMP4DownloadsDeleteDownloads.OK(Serializer.deserialize content)
            | _ -> return StreamMP4DownloadsDeleteDownloads.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists the downloads created for a video.
    ///</summary>
    member this.StreamMP4DownloadsListDownloads
        (
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/downloads"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamMP4DownloadsListDownloads.OK(Serializer.deserialize content)
            | _ -> return StreamMP4DownloadsListDownloads.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a download for a video when a video is ready to view. Use `/downloads/{download_type}` instead for type-specific downloads. Available types are `default` and `audio`.
    ///</summary>
    member this.StreamMP4DownloadsCreateDownloads
        (
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/downloads"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamMP4DownloadsCreateDownloads.OK(Serializer.deserialize content)
            | _ -> return StreamMP4DownloadsCreateDownloads.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete specific type of download. For backwards-compatibility, DELETE requests to /downloads will delete the default download.
    ///</summary>
    member this.StreamDownloadsDeleteTypeSpecificDownloads
        (
            identifier: string,
            accountId: string,
            downloadType: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("download_type", downloadType) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/downloads/{download_type}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamDownloadsDeleteTypeSpecificDownloads.OK(Serializer.deserialize content)
            | _ -> return StreamDownloadsDeleteTypeSpecificDownloads.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a download for a video of specified type. For backwards-compatibility, POST requests to /downloads will enable the default download.
    ///</summary>
    member this.StreamDownloadsCreateTypeSpecificDownloads
        (
            identifier: string,
            accountId: string,
            downloadType: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("download_type", downloadType) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/downloads/{download_type}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamDownloadsCreateTypeSpecificDownloads.OK(Serializer.deserialize content)
            | _ -> return StreamDownloadsCreateTypeSpecificDownloads.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches an HTML code snippet to embed a video in a web page delivered through Cloudflare. On success, returns an HTML fragment for use on web pages to display a video. On failure, returns a JSON response body.
    ///</summary>
    member this.StreamVideosRetreieveEmbedCodeHtml
        (
            identifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/embed"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamVideosRetreieveEmbedCodeHtml.OK content
            | _ -> return StreamVideosRetreieveEmbedCodeHtml.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a signed URL token for a video. If a body is not provided in the request, a token is created with default values.
    ///</summary>
    member this.StreamVideosCreateSignedUrlTokensForVideos
        (
            identifier: string,
            accountId: string,
            body: streamsignedtokenrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identifier", identifier)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/stream/{identifier}/token"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return StreamVideosCreateSignedUrlTokensForVideos.OK(Serializer.deserialize content)
            | _ -> return StreamVideosCreateSignedUrlTokensForVideos.BadRequest(Serializer.deserialize content)
        }
