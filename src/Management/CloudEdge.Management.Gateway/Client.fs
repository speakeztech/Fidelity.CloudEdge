namespace rec Fidelity.CloudEdge.Management.Gateway

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Gateway.Types
open Fidelity.CloudEdge.Management.Gateway.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type GatewayClient(httpClient: HttpClient) =
    ///<summary>
    ///Retrieve information about the current Zero Trust account.
    ///</summary>
    member this.ZeroTrustAccountsGetZeroTrustAccountInformation
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/gateway" requestParts cancellationToken

            return ZeroTrustAccountsGetZeroTrustAccountInformation.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a Zero Trust account for an existing Cloudflare account.
    ///</summary>
    member this.ZeroTrustAccountsCreateZeroTrustAccount(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/gateway" requestParts cancellationToken

            return ZeroTrustAccountsCreateZeroTrustAccount.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List all application and application type mappings.
    ///</summary>
    member this.ZeroTrustGatewayApplicationAndApplicationTypeMappingsListApplicationAndApplicationTypeMappings
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/app_types"
                    requestParts
                    cancellationToken

            return
                ZeroTrustGatewayApplicationAndApplicationTypeMappingsListApplicationAndApplicationTypeMappings.OK(
                    Serializer.deserialize content
                )
        }

    ///<summary>
    ///Retrieve the statuses of your applications.
    ///</summary>
    member this.ZeroTrustApplicationsReviewStatusList(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/apps/review_status"
                    requestParts
                    cancellationToken

            return ZeroTrustApplicationsReviewStatusList.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update the statuses of your applications.
    ///</summary>
    member this.ZeroTrustApplicationsReviewStatusUpdate
        (
            accountId: string,
            body: ZeroTrustApplicationsReviewStatusUpdatePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/gateway/apps/review_status"
                    requestParts
                    cancellationToken

            return ZeroTrustApplicationsReviewStatusUpdate.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve all Zero Trust Audit SSH and SSH with Access for Infrastructure settings for an account.
    ///</summary>
    member this.ZeroTrustGetAuditSshSettings(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/audit_ssh_settings"
                    requestParts
                    cancellationToken

            return ZeroTrustGetAuditSshSettings.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update Zero Trust Audit SSH and SSH with Access for Infrastructure settings for an account.
    ///</summary>
    member this.ZeroTrustUpdateAuditSshSettings
        (
            accountId: string,
            body: ZeroTrustUpdateAuditSshSettingsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/gateway/audit_ssh_settings"
                    requestParts
                    cancellationToken

            return ZeroTrustUpdateAuditSshSettings.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Rotate the SSH account seed that generates the host key identity when connecting through the Cloudflare SSH Proxy.
    ///</summary>
    member this.ZeroTrustRotateSshAccountSeed(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/gateway/audit_ssh_settings/rotate_seed"
                    requestParts
                    cancellationToken

            return ZeroTrustRotateSshAccountSeed.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List all categories.
    ///</summary>
    member this.ZeroTrustGatewayCategoriesListCategories(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/categories"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayCategoriesListCategories.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List all Zero Trust certificates for an account.
    ///</summary>
    member this.ZeroTrustCertificatesListZeroTrustCertificates
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/certificates"
                    requestParts
                    cancellationToken

            return ZeroTrustCertificatesListZeroTrustCertificates.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Zero Trust certificate.
    ///</summary>
    member this.ZeroTrustCertificatesCreateZeroTrustCertificate
        (
            accountId: string,
            body: ``zero-trust-gatewaygenerate-cert-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/gateway/certificates"
                    requestParts
                    cancellationToken

            return ZeroTrustCertificatesCreateZeroTrustCertificate.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a gateway-managed Zero Trust certificate. You must deactivate the certificate from the edge (inactive) before deleting it.
    ///</summary>
    member this.ZeroTrustCertificatesDeleteZeroTrustCertificate
        (
            certificateId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("certificate_id", certificateId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/gateway/certificates/{certificate_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustCertificatesDeleteZeroTrustCertificate.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a single Zero Trust certificate.
    ///</summary>
    member this.ZeroTrustCertificatesZeroTrustCertificateDetails
        (
            certificateId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("certificate_id", certificateId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/certificates/{certificate_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustCertificatesZeroTrustCertificateDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Bind a single Zero Trust certificate to the edge.
    ///</summary>
    member this.ZeroTrustCertificatesActivateZeroTrustCertificate
        (
            certificateId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("certificate_id", certificateId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/gateway/certificates/{certificate_id}/activate"
                    requestParts
                    cancellationToken

            return ZeroTrustCertificatesActivateZeroTrustCertificate.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Unbind a single Zero Trust certificate from the edge.
    ///</summary>
    member this.ZeroTrustCertificatesDeactivateZeroTrustCertificate
        (
            certificateId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("certificate_id", certificateId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/gateway/certificates/{certificate_id}/deactivate"
                    requestParts
                    cancellationToken

            return ZeroTrustCertificatesDeactivateZeroTrustCertificate.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve the current Zero Trust account configuration.
    ///</summary>
    member this.ZeroTrustAccountsGetZeroTrustAccountConfiguration
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/configuration"
                    requestParts
                    cancellationToken

            return ZeroTrustAccountsGetZeroTrustAccountConfiguration.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update (PATCH) a single subcollection of settings such as `antivirus`, `tls_decrypt`, `activity_log`, `block_page`, `browser_isolation`, `fips`, `body_scanning`, or `certificate` without updating the entire configuration object. This endpoint returns an error if any settings collection lacks proper configuration.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="body">Specify account settings.</param>
    ///<param name="cancellationToken"></param>
    member this.ZeroTrustAccountsPatchZeroTrustAccountConfiguration
        (
            accountId: string,
            body: ``zero-trust-gatewaygateway-account-settings``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/gateway/configuration"
                    requestParts
                    cancellationToken

            return ZeroTrustAccountsPatchZeroTrustAccountConfiguration.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update the current Zero Trust account configuration.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="body">Specify account settings.</param>
    ///<param name="cancellationToken"></param>
    member this.ZeroTrustAccountsUpdateZeroTrustAccountConfiguration
        (
            accountId: string,
            body: ``zero-trust-gatewaygateway-account-settings``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/gateway/configuration"
                    requestParts
                    cancellationToken

            return ZeroTrustAccountsUpdateZeroTrustAccountConfiguration.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch all Zero Trust lists for an account.
    ///</summary>
    member this.ZeroTrustListsListZeroTrustLists
        (
            accountId: string,
            ?``type``: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if ``type``.IsSome then
                      RequestPart.query ("type", ``type``.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/gateway/lists" requestParts cancellationToken

            return ZeroTrustListsListZeroTrustLists.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Zero Trust list.
    ///</summary>
    member this.ZeroTrustListsCreateZeroTrustList
        (
            accountId: string,
            body: ZeroTrustListsCreateZeroTrustListPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/gateway/lists" requestParts cancellationToken

            return ZeroTrustListsCreateZeroTrustList.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a Zero Trust list.
    ///</summary>
    member this.ZeroTrustListsDeleteZeroTrustList
        (
            listId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("list_id", listId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/gateway/lists/{list_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustListsDeleteZeroTrustList.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch a single Zero Trust list.
    ///</summary>
    member this.ZeroTrustListsZeroTrustListDetails
        (
            listId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("list_id", listId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/lists/{list_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustListsZeroTrustListDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Appends or removes an item from a configured Zero Trust list.
    ///</summary>
    member this.ZeroTrustListsPatchZeroTrustList
        (
            listId: string,
            accountId: string,
            body: ZeroTrustListsPatchZeroTrustListPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("list_id", listId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/gateway/lists/{list_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustListsPatchZeroTrustList.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a configured Zero Trust list. Skips updating list items if not included in the payload. A non empty list items will overwrite the existing list.
    ///</summary>
    member this.ZeroTrustListsUpdateZeroTrustList
        (
            listId: string,
            accountId: string,
            body: ZeroTrustListsUpdateZeroTrustListPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("list_id", listId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/gateway/lists/{list_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustListsUpdateZeroTrustList.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch all items in a single Zero Trust list.
    ///</summary>
    member this.ZeroTrustListsZeroTrustListItems
        (
            listId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("list_id", listId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/lists/{list_id}/items"
                    requestParts
                    cancellationToken

            return ZeroTrustListsZeroTrustListItems.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List Zero Trust Gateway locations for an account.
    ///</summary>
    member this.ZeroTrustGatewayLocationsListZeroTrustGatewayLocations
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/locations"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayLocationsListZeroTrustGatewayLocations.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Zero Trust Gateway location.
    ///</summary>
    member this.ZeroTrustGatewayLocationsCreateZeroTrustGatewayLocation
        (
            accountId: string,
            body: ZeroTrustGatewayLocationsCreateZeroTrustGatewayLocationPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/gateway/locations"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayLocationsCreateZeroTrustGatewayLocation.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a configured Zero Trust Gateway location.
    ///</summary>
    member this.ZeroTrustGatewayLocationsDeleteZeroTrustGatewayLocation
        (
            locationId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("location_id", locationId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/gateway/locations/{location_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayLocationsDeleteZeroTrustGatewayLocation.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a single Zero Trust Gateway location.
    ///</summary>
    member this.ZeroTrustGatewayLocationsZeroTrustGatewayLocationDetails
        (
            locationId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("location_id", locationId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/locations/{location_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayLocationsZeroTrustGatewayLocationDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a configured Zero Trust Gateway location.
    ///</summary>
    member this.ZeroTrustGatewayLocationsUpdateZeroTrustGatewayLocation
        (
            locationId: string,
            accountId: string,
            body: ZeroTrustGatewayLocationsUpdateZeroTrustGatewayLocationPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("location_id", locationId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/gateway/locations/{location_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayLocationsUpdateZeroTrustGatewayLocation.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve the current logging settings for the Zero Trust account.
    ///</summary>
    member this.ZeroTrustAccountsGetLoggingSettingsForTheZeroTrustAccount
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/gateway/logging" requestParts cancellationToken

            return ZeroTrustAccountsGetLoggingSettingsForTheZeroTrustAccount.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update logging settings for the current Zero Trust account.
    ///</summary>
    member this.ZeroTrustAccountsUpdateLoggingSettingsForTheZeroTrustAccount
        (
            accountId: string,
            body: ``zero-trust-gatewaygateway-account-logging-settings``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync httpClient "/accounts/{account_id}/gateway/logging" requestParts cancellationToken

            return ZeroTrustAccountsUpdateLoggingSettingsForTheZeroTrustAccount.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List all Zero Trust Gateway PAC files for an account.
    ///</summary>
    member this.ZeroTrustGatewayPacfilesList(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/gateway/pacfiles" requestParts cancellationToken

            return ZeroTrustGatewayPacfilesList.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Zero Trust Gateway PAC file.
    ///</summary>
    member this.ZeroTrustGatewayPacfilesCreatePacfile
        (
            accountId: string,
            body: ZeroTrustGatewayPacfilesCreatePacfilePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/gateway/pacfiles"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayPacfilesCreatePacfile.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a configured Zero Trust Gateway PAC file.
    ///</summary>
    member this.ZeroTrustGatewayPacfilesDelete
        (
            pacfileId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pacfile_id", pacfileId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/gateway/pacfiles/{pacfile_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayPacfilesDelete.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a single Zero Trust Gateway PAC file.
    ///</summary>
    member this.ZeroTrustGatewayPacfilesDetails
        (
            pacfileId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pacfile_id", pacfileId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/pacfiles/{pacfile_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayPacfilesDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a configured Zero Trust Gateway PAC file.
    ///</summary>
    member this.ZeroTrustGatewayPacfilesUpdate
        (
            pacfileId: string,
            accountId: string,
            body: ZeroTrustGatewayPacfilesUpdatePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("pacfile_id", pacfileId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/gateway/pacfiles/{pacfile_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayPacfilesUpdate.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List all Zero Trust Gateway proxy endpoints for an account.
    ///</summary>
    member this.ZeroTrustGatewayProxyEndpointsListProxyEndpoints
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/proxy_endpoints"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayProxyEndpointsListProxyEndpoints.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Zero Trust Gateway proxy endpoint.
    ///</summary>
    member this.ZeroTrustGatewayProxyEndpointsCreateProxyEndpoint
        (
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/gateway/proxy_endpoints"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayProxyEndpointsCreateProxyEndpoint.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a configured Zero Trust Gateway proxy endpoint.
    ///</summary>
    member this.ZeroTrustGatewayProxyEndpointsDeleteProxyEndpoint
        (
            proxyEndpointId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("proxy_endpoint_id", proxyEndpointId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/gateway/proxy_endpoints/{proxy_endpoint_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayProxyEndpointsDeleteProxyEndpoint.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a single Zero Trust Gateway proxy endpoint.
    ///</summary>
    member this.ZeroTrustGatewayProxyEndpointsProxyEndpointDetails
        (
            proxyEndpointId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("proxy_endpoint_id", proxyEndpointId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/proxy_endpoints/{proxy_endpoint_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayProxyEndpointsProxyEndpointDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a configured Zero Trust Gateway proxy endpoint.
    ///</summary>
    member this.ZeroTrustGatewayProxyEndpointsUpdateProxyEndpoint
        (
            proxyEndpointId: string,
            accountId: string,
            body: ZeroTrustGatewayProxyEndpointsUpdateProxyEndpointPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("proxy_endpoint_id", proxyEndpointId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/gateway/proxy_endpoints/{proxy_endpoint_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayProxyEndpointsUpdateProxyEndpoint.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List Zero Trust Gateway rules for an account.
    ///</summary>
    member this.ZeroTrustGatewayRulesListZeroTrustGatewayRules
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/gateway/rules" requestParts cancellationToken

            return ZeroTrustGatewayRulesListZeroTrustGatewayRules.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Zero Trust Gateway rule.
    ///</summary>
    member this.ZeroTrustGatewayRulesCreateZeroTrustGatewayRule
        (
            accountId: string,
            body: ZeroTrustGatewayRulesCreateZeroTrustGatewayRulePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/gateway/rules" requestParts cancellationToken

            return ZeroTrustGatewayRulesCreateZeroTrustGatewayRule.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List Zero Trust Gateway rules for the parent account of an account in the MSP configuration.
    ///</summary>
    member this.ZeroTrustGatewayRulesListZeroTrustGatewayRulesTenant
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/rules/tenant"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayRulesListZeroTrustGatewayRulesTenant.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a Zero Trust Gateway rule.
    ///</summary>
    member this.ZeroTrustGatewayRulesDeleteZeroTrustGatewayRule
        (
            ruleId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("rule_id", ruleId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/gateway/rules/{rule_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayRulesDeleteZeroTrustGatewayRule.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a single Zero Trust Gateway rule.
    ///</summary>
    member this.ZeroTrustGatewayRulesZeroTrustGatewayRuleDetails
        (
            ruleId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("rule_id", ruleId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/gateway/rules/{rule_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayRulesZeroTrustGatewayRuleDetails.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a configured Zero Trust Gateway rule.
    ///</summary>
    member this.ZeroTrustGatewayRulesUpdateZeroTrustGatewayRule
        (
            ruleId: string,
            accountId: string,
            body: ZeroTrustGatewayRulesUpdateZeroTrustGatewayRulePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("rule_id", ruleId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/gateway/rules/{rule_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayRulesUpdateZeroTrustGatewayRule.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Resets the expiration of a Zero Trust Gateway Rule if its duration elapsed and it has a default duration. The Zero Trust Gateway Rule must have values  for both `expiration.expires_at` and `expiration.duration`.
    ///</summary>
    member this.ZeroTrustGatewayRulesResetExpirationZeroTrustGatewayRule
        (
            ruleId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("rule_id", ruleId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/gateway/rules/{rule_id}/reset_expiration"
                    requestParts
                    cancellationToken

            return ZeroTrustGatewayRulesResetExpirationZeroTrustGatewayRule.OK(Serializer.deserialize content)
        }
