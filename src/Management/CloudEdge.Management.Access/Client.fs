namespace rec Fidelity.CloudEdge.Management.Access

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Access.Types
open Fidelity.CloudEdge.Management.Access.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type AccessClient(httpClient: HttpClient) =
    ///<summary>
    ///List MCP Portals
    ///</summary>
    member this.McpPortalsApiListPortals
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/portals"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return McpPortalsApiListPortals.OK(Serializer.deserialize content)
            | _ -> return McpPortalsApiListPortals.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new MCP Portal
    ///</summary>
    member this.McpPortalsApiCreatePortals
        (
            accountId: string,
            body: McpPortalsApiCreatePortalsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/portals"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return McpPortalsApiCreatePortals.Created(Serializer.deserialize content)
            | _ -> return McpPortalsApiCreatePortals.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a MCP Portal
    ///</summary>
    member this.McpPortalsApiDeletePortals(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/portals/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return McpPortalsApiDeletePortals.OK(Serializer.deserialize content)
            | _ -> return McpPortalsApiDeletePortals.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Read details of an MCP Portal
    ///</summary>
    member this.McpPortalsApiFetchGateways(id: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/portals/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return McpPortalsApiFetchGateways.OK(Serializer.deserialize content)
            | _ -> return McpPortalsApiFetchGateways.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a MCP Portal
    ///</summary>
    member this.McpPortalsApiUpdatePortals
        (
            id: string,
            accountId: string,
            body: McpPortalsApiUpdatePortalsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/portals/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return McpPortalsApiUpdatePortals.OK(Serializer.deserialize content)
            | 400 -> return McpPortalsApiUpdatePortals.BadRequest(Serializer.deserialize content)
            | _ -> return McpPortalsApiUpdatePortals.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///List MCP Servers
    ///</summary>
    member this.McpPortalsApiListServers
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/servers"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return McpPortalsApiListServers.OK(Serializer.deserialize content)
            | _ -> return McpPortalsApiListServers.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new MCP Server
    ///</summary>
    member this.McpPortalsApiCreateServers
        (
            accountId: string,
            body: McpPortalsApiCreateServersPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/servers"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return McpPortalsApiCreateServers.Created(Serializer.deserialize content)
            | _ -> return McpPortalsApiCreateServers.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a MCP Server
    ///</summary>
    member this.McpPortalsApiDeleteServers(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/servers/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return McpPortalsApiDeleteServers.OK(Serializer.deserialize content)
            | _ -> return McpPortalsApiDeleteServers.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Read the details of a MCP Server
    ///</summary>
    member this.McpPortalsApiFetchServers(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/servers/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return McpPortalsApiFetchServers.OK(Serializer.deserialize content)
            | _ -> return McpPortalsApiFetchServers.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a MCP Server
    ///</summary>
    member this.McpPortalsApiUpdateServers
        (
            id: string,
            accountId: string,
            body: McpPortalsApiUpdateServersPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/servers/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return McpPortalsApiUpdateServers.OK(Serializer.deserialize content)
            | 400 -> return McpPortalsApiUpdateServers.BadRequest(Serializer.deserialize content)
            | _ -> return McpPortalsApiUpdateServers.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Sync MCP Server Capabilities
    ///</summary>
    member this.McpPortalsApiSyncServer(id: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/ai-controls/mcp/servers/{id}/sync"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return McpPortalsApiSyncServer.OK(Serializer.deserialize content)
            | _ -> return McpPortalsApiSyncServer.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all Access applications in an account.
    ///</summary>
    member this.AccessApplicationsListAccessApplications
        (
            accountId: string,
            ?name: string,
            ?domain: string,
            ?aud: string,
            ?targetAttributes: string,
            ?exact: bool,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if domain.IsSome then
                      RequestPart.query ("domain", domain.Value)
                  if aud.IsSome then
                      RequestPart.query ("aud", aud.Value)
                  if targetAttributes.IsSome then
                      RequestPart.query ("target_attributes", targetAttributes.Value)
                  if exact.IsSome then
                      RequestPart.query ("exact", exact.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/access/apps" requestParts cancellationToken

            return AccessApplicationsListAccessApplications.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Adds a new application to Access.
    ///</summary>
    member this.AccessApplicationsAddAnApplication
        (
            accountId: string,
            body: accessapprequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/access/apps" requestParts cancellationToken

            return AccessApplicationsAddAnApplication.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists short-lived certificate CAs and their public keys.
    ///</summary>
    member this.AccessShortLivedCertificateCAsListShortLivedCertificateCAs
        (
            accountId: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/access/apps/ca" requestParts cancellationToken

            return AccessShortLivedCertificateCAsListShortLivedCertificateCAs.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an application from Access.
    ///</summary>
    member this.AccessApplicationsDeleteAnAccessApplication
        (
            appId: accessappid,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}"
                    requestParts
                    cancellationToken

            return AccessApplicationsDeleteAnAccessApplication.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches information about an Access application.
    ///</summary>
    member this.AccessApplicationsGetAnAccessApplication
        (
            appId: accessappid,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}"
                    requestParts
                    cancellationToken

            return AccessApplicationsGetAnAccessApplication.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an Access application.
    ///</summary>
    member this.AccessApplicationsUpdateAnAccessApplication
        (
            appId: accessappid,
            accountId: string,
            body: accessapprequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}"
                    requestParts
                    cancellationToken

            return AccessApplicationsUpdateAnAccessApplication.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a short-lived certificate CA.
    ///</summary>
    member this.AccessShortLivedCertificateCAsDeleteAShortLivedCertificateCa
        (
            appId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/ca"
                    requestParts
                    cancellationToken

            return AccessShortLivedCertificateCAsDeleteAShortLivedCertificateCa.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a short-lived certificate CA and its public key.
    ///</summary>
    member this.AccessShortLivedCertificateCAsGetAShortLivedCertificateCa
        (
            appId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/ca"
                    requestParts
                    cancellationToken

            return AccessShortLivedCertificateCAsGetAShortLivedCertificateCa.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Generates a new short-lived certificate CA and public key.
    ///</summary>
    member this.AccessShortLivedCertificateCAsCreateAShortLivedCertificateCa
        (
            appId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/ca"
                    requestParts
                    cancellationToken

            return AccessShortLivedCertificateCAsCreateAShortLivedCertificateCa.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists Access policies configured for an application. Returns both exclusively scoped and reusable policies used by the application.
    ///</summary>
    ///<param name="appId">The application ID.</param>
    ///<param name="accountId"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AccessPoliciesListAccessAppPolicies
        (
            appId: string,
            accountId: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/policies"
                    requestParts
                    cancellationToken

            return AccessPoliciesListAccessAppPolicies.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a policy applying exclusive to a single application that defines the users or groups who can reach it. We recommend creating a reusable policy instead and subsequently referencing its ID in the application's 'policies' array.
    ///</summary>
    ///<param name="appId">The application ID.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AccessPoliciesCreateAnAccessPolicy
        (
            appId: string,
            accountId: string,
            body: accessapppolicyrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/policies"
                    requestParts
                    cancellationToken

            return AccessPoliciesCreateAnAccessPolicy.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an Access policy specific to an application. To delete a reusable policy, use the /accounts/{account_id}/policies/{uid} endpoint.
    ///</summary>
    ///<param name="appId">The application ID.</param>
    ///<param name="policyId">The policy ID.</param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AccessPoliciesDeleteAnAccessPolicy
        (
            appId: string,
            policyId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("policy_id", policyId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/policies/{policy_id}"
                    requestParts
                    cancellationToken

            return AccessPoliciesDeleteAnAccessPolicy.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single Access policy configured for an application. Returns both exclusively owned and reusable policies used by the application.
    ///</summary>
    ///<param name="appId">The application ID.</param>
    ///<param name="policyId">The policy ID.</param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AccessPoliciesGetAnAccessPolicy
        (
            appId: string,
            policyId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("policy_id", policyId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/policies/{policy_id}"
                    requestParts
                    cancellationToken

            return AccessPoliciesGetAnAccessPolicy.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an Access policy specific to an application. To update a reusable policy, use the /accounts/{account_id}/policies/{uid} endpoint.
    ///</summary>
    ///<param name="appId">The application ID.</param>
    ///<param name="policyId">The policy ID.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AccessPoliciesUpdateAnAccessPolicy
        (
            appId: string,
            policyId: string,
            accountId: string,
            body: accessapppolicyrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("policy_id", policyId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/policies/{policy_id}"
                    requestParts
                    cancellationToken

            return AccessPoliciesUpdateAnAccessPolicy.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Converts an application-scoped policy to a reusable policy. The policy will no longer be exclusively scoped to the application. Further updates to the policy should go through the /accounts/{account_id}/policies/{uid} endpoint.
    ///</summary>
    ///<param name="appId">The application ID.</param>
    ///<param name="policyId">The policy ID.</param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AccessPoliciesConvertReusable
        (
            appId: string,
            policyId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("policy_id", policyId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/policies/{policy_id}/make_reusable"
                    requestParts
                    cancellationToken

            return AccessPoliciesConvertReusable.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Revokes all tokens issued for an application.
    ///</summary>
    member this.AccessApplicationsRevokeServiceTokens
        (
            appId: accessappid,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/revoke_tokens"
                    requestParts
                    cancellationToken

            return AccessApplicationsRevokeServiceTokens.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates Access application settings.
    ///</summary>
    member this.AccessApplicationsPatchUpdateAccessApplicationSettings
        (
            appId: accessappid,
            accountId: string,
            body: accessappsettingsrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/settings"
                    requestParts
                    cancellationToken

            return AccessApplicationsPatchUpdateAccessApplicationSettings.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates Access application settings.
    ///</summary>
    member this.AccessApplicationsPutUpdateAccessApplicationSettings
        (
            appId: accessappid,
            accountId: string,
            body: accessappsettingsrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/settings"
                    requestParts
                    cancellationToken

            return AccessApplicationsPutUpdateAccessApplicationSettings.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Tests if a specific user has permission to access an application.
    ///</summary>
    member this.AccessApplicationsTestAccessPolicies
        (
            appId: accessappid,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("app_id", appId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/apps/{app_id}/user_policy_checks"
                    requestParts
                    cancellationToken

            return AccessApplicationsTestAccessPolicies.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all mTLS root certificates.
    ///</summary>
    member this.AccessMtlsAuthenticationListMtlsCertificates
        (
            accountId: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/certificates"
                    requestParts
                    cancellationToken

            return AccessMtlsAuthenticationListMtlsCertificates.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Adds a new mTLS root certificate to Access.
    ///</summary>
    member this.AccessMtlsAuthenticationAddAnMtlsCertificate
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
                    "/accounts/{account_id}/access/certificates"
                    requestParts
                    cancellationToken

            return AccessMtlsAuthenticationAddAnMtlsCertificate.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///List all mTLS hostname settings for this account.
    ///</summary>
    member this.AccessMtlsAuthenticationListMtlsCertificatesHostnameSettings
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
                    "/accounts/{account_id}/access/certificates/settings"
                    requestParts
                    cancellationToken

            return AccessMtlsAuthenticationListMtlsCertificatesHostnameSettings.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an mTLS certificate's hostname settings.
    ///</summary>
    member this.AccessMtlsAuthenticationUpdateAnMtlsCertificateSettings
        (
            accountId: string,
            body: AccessMtlsAuthenticationUpdateAnMtlsCertificateSettingsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/certificates/settings"
                    requestParts
                    cancellationToken

            return AccessMtlsAuthenticationUpdateAnMtlsCertificateSettings.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an mTLS certificate.
    ///</summary>
    member this.AccessMtlsAuthenticationDeleteAnMtlsCertificate
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
                    "/accounts/{account_id}/access/certificates/{certificate_id}"
                    requestParts
                    cancellationToken

            return AccessMtlsAuthenticationDeleteAnMtlsCertificate.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single mTLS certificate.
    ///</summary>
    member this.AccessMtlsAuthenticationGetAnMtlsCertificate
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
                    "/accounts/{account_id}/access/certificates/{certificate_id}"
                    requestParts
                    cancellationToken

            return AccessMtlsAuthenticationGetAnMtlsCertificate.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a configured mTLS certificate.
    ///</summary>
    member this.AccessMtlsAuthenticationUpdateAnMtlsCertificate
        (
            certificateId: string,
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("certificate_id", certificateId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/certificates/{certificate_id}"
                    requestParts
                    cancellationToken

            return AccessMtlsAuthenticationUpdateAnMtlsCertificate.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List custom pages
    ///</summary>
    member this.AccessCustomPagesListCustomPages
        (
            accountId: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/custom_pages"
                    requestParts
                    cancellationToken

            return AccessCustomPagesListCustomPages.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a custom page
    ///</summary>
    member this.AccessCustomPagesCreateACustomPage
        (
            accountId: string,
            body: accesscustompage,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/custom_pages"
                    requestParts
                    cancellationToken

            return AccessCustomPagesCreateACustomPage.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a custom page
    ///</summary>
    member this.AccessCustomPagesDeleteACustomPage
        (
            customPageId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("custom_page_id", customPageId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/custom_pages/{custom_page_id}"
                    requestParts
                    cancellationToken

            return AccessCustomPagesDeleteACustomPage.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a custom page and also returns its HTML.
    ///</summary>
    member this.AccessCustomPagesGetACustomPage
        (
            customPageId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("custom_page_id", customPageId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/custom_pages/{custom_page_id}"
                    requestParts
                    cancellationToken

            return AccessCustomPagesGetACustomPage.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a custom page
    ///</summary>
    member this.AccessCustomPagesUpdateACustomPage
        (
            customPageId: string,
            accountId: string,
            body: accesscustompage,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("custom_page_id", customPageId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/custom_pages/{custom_page_id}"
                    requestParts
                    cancellationToken

            return AccessCustomPagesUpdateACustomPage.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists SSH Certificate Authorities (CA).
    ///</summary>
    member this.AccessGatewayCaListSSHCa(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/gateway_ca"
                    requestParts
                    cancellationToken

            return AccessGatewayCaListSSHCa.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Adds a new SSH Certificate Authority (CA).
    ///</summary>
    member this.AccessGatewayCaAddAnSSHCa(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/gateway_ca"
                    requestParts
                    cancellationToken

            return AccessGatewayCaAddAnSSHCa.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an SSH Certificate Authority.
    ///</summary>
    member this.AccessGatewayCaDeleteAnSSHCa
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
                    "/accounts/{account_id}/access/gateway_ca/{certificate_id}"
                    requestParts
                    cancellationToken

            return AccessGatewayCaDeleteAnSSHCa.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all Access groups.
    ///</summary>
    member this.AccessGroupsListAccessGroups
        (
            accountId: string,
            ?name: string,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/access/groups" requestParts cancellationToken

            return AccessGroupsListAccessGroups.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Access group.
    ///</summary>
    member this.AccessGroupsCreateAnAccessGroup
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
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/access/groups" requestParts cancellationToken

            return AccessGroupsCreateAnAccessGroup.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an Access group.
    ///</summary>
    member this.AccessGroupsDeleteAnAccessGroup
        (
            groupId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("group_id", groupId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/groups/{group_id}"
                    requestParts
                    cancellationToken

            return AccessGroupsDeleteAnAccessGroup.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single Access group.
    ///</summary>
    member this.AccessGroupsGetAnAccessGroup
        (
            groupId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("group_id", groupId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/groups/{group_id}"
                    requestParts
                    cancellationToken

            return AccessGroupsGetAnAccessGroup.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a configured Access group.
    ///</summary>
    member this.AccessGroupsUpdateAnAccessGroup
        (
            groupId: string,
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("group_id", groupId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/groups/{group_id}"
                    requestParts
                    cancellationToken

            return AccessGroupsUpdateAnAccessGroup.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all configured identity providers.
    ///</summary>
    member this.AccessIdentityProvidersListAccessIdentityProviders
        (
            accountId: string,
            ?scimEnabled: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if scimEnabled.IsSome then
                      RequestPart.query ("scim_enabled", scimEnabled.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/identity_providers"
                    requestParts
                    cancellationToken

            return AccessIdentityProvidersListAccessIdentityProviders.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Adds a new identity provider to Access.
    ///</summary>
    member this.AccessIdentityProvidersAddAnAccessIdentityProvider
        (
            accountId: string,
            body: ``accessidentity-providers``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/identity_providers"
                    requestParts
                    cancellationToken

            return AccessIdentityProvidersAddAnAccessIdentityProvider.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an identity provider from Access.
    ///</summary>
    member this.AccessIdentityProvidersDeleteAnAccessIdentityProvider
        (
            identityProviderId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identity_provider_id", identityProviderId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/identity_providers/{identity_provider_id}"
                    requestParts
                    cancellationToken

            return AccessIdentityProvidersDeleteAnAccessIdentityProvider.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a configured identity provider.
    ///</summary>
    member this.AccessIdentityProvidersGetAnAccessIdentityProvider
        (
            identityProviderId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identity_provider_id", identityProviderId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/identity_providers/{identity_provider_id}"
                    requestParts
                    cancellationToken

            return AccessIdentityProvidersGetAnAccessIdentityProvider.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a configured identity provider.
    ///</summary>
    member this.AccessIdentityProvidersUpdateAnAccessIdentityProvider
        (
            identityProviderId: string,
            accountId: string,
            body: ``accessidentity-providers``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identity_provider_id", identityProviderId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/identity_providers/{identity_provider_id}"
                    requestParts
                    cancellationToken

            return AccessIdentityProvidersUpdateAnAccessIdentityProvider.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists SCIM Group resources synced to Cloudflare via the System for Cross-domain Identity Management (SCIM).
    ///</summary>
    member this.AccessIdentityProvidersListScimGroupResources
        (
            identityProviderId: string,
            accountId: string,
            ?cfResourceId: string,
            ?idpResourceId: string,
            ?name: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identity_provider_id", identityProviderId)
                  RequestPart.path ("account_id", accountId)
                  if cfResourceId.IsSome then
                      RequestPart.query ("cf_resource_id", cfResourceId.Value)
                  if idpResourceId.IsSome then
                      RequestPart.query ("idp_resource_id", idpResourceId.Value)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/identity_providers/{identity_provider_id}/scim/groups"
                    requestParts
                    cancellationToken

            return AccessIdentityProvidersListScimGroupResources.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists SCIM User resources synced to Cloudflare via the System for Cross-domain Identity Management (SCIM).
    ///</summary>
    member this.AccessIdentityProvidersListScimUserResources
        (
            identityProviderId: string,
            accountId: string,
            ?cfResourceId: string,
            ?idpResourceId: string,
            ?username: string,
            ?email: string,
            ?name: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("identity_provider_id", identityProviderId)
                  RequestPart.path ("account_id", accountId)
                  if cfResourceId.IsSome then
                      RequestPart.query ("cf_resource_id", cfResourceId.Value)
                  if idpResourceId.IsSome then
                      RequestPart.query ("idp_resource_id", idpResourceId.Value)
                  if username.IsSome then
                      RequestPart.query ("username", username.Value)
                  if email.IsSome then
                      RequestPart.query ("email", email.Value)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/identity_providers/{identity_provider_id}/scim/users"
                    requestParts
                    cancellationToken

            return AccessIdentityProvidersListScimUserResources.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets the Access key rotation settings for an account.
    ///</summary>
    member this.AccessKeyConfigurationGetTheAccessKeyConfiguration
        (
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/access/keys" requestParts cancellationToken

            return AccessKeyConfigurationGetTheAccessKeyConfiguration.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the Access key rotation settings for an account.
    ///</summary>
    member this.AccessKeyConfigurationUpdateTheAccessKeyConfiguration
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
                OpenApiHttp.putAsync httpClient "/accounts/{account_id}/access/keys" requestParts cancellationToken

            return AccessKeyConfigurationUpdateTheAccessKeyConfiguration.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Perfoms a key rotation for an account.
    ///</summary>
    member this.AccessKeyConfigurationRotateAccessKeys(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/keys/rotate"
                    requestParts
                    cancellationToken

            return AccessKeyConfigurationRotateAccessKeys.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets a list of Access authentication audit logs for an account.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="limit">The maximum number of log entries to retrieve.</param>
    ///<param name="direction">The chronological sorting order for the logs.</param>
    ///<param name="since">The earliest event timestamp to query.</param>
    ///<param name="until">The latest event timestamp to query.</param>
    ///<param name="perPage"></param>
    ///<param name="email">
    ///Filter by user email. Defaults to substring matching. To force exact matching, set `email_exact=true`.
    ///Example (default): `email=@example.com` returns all events with that domain.
    ///Example (exact): `email=user@example.com&amp;email_exact=true` returns only that user.
    ///</param>
    ///<param name="emailExact">When true, `email` is matched exactly instead of substring matching.</param>
    ///<param name="userId">Filter by user UUID.</param>
    ///<param name="cancellationToken"></param>
    member this.AccessAuthenticationLogsGetAccessAuthenticationLogs
        (
            accountId: string,
            ?limit: int,
            ?direction: string,
            ?since: System.DateTimeOffset,
            ?until: System.DateTimeOffset,
            ?perPage: int,
            ?email: string,
            ?emailExact: bool,
            ?userId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if since.IsSome then
                      RequestPart.query ("since", since.Value)
                  if until.IsSome then
                      RequestPart.query ("until", until.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if email.IsSome then
                      RequestPart.query ("email", email.Value)
                  if emailExact.IsSome then
                      RequestPart.query ("email_exact", emailExact.Value)
                  if userId.IsSome then
                      RequestPart.query ("user_id", userId.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/logs/access_requests"
                    requestParts
                    cancellationToken

            return AccessAuthenticationLogsGetAccessAuthenticationLogs.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists Access SCIM update logs that maintain a record of updates made to User and Group resources synced to Cloudflare via the System for Cross-domain Identity Management (SCIM).
    ///</summary>
    member this.AccessScimUpdateLogsListAccessScimUpdateLogs
        (
            accountId: string,
            idpId: accessidpid,
            ?limit: int,
            ?direction: string,
            ?since: System.DateTimeOffset,
            ?until: System.DateTimeOffset,
            ?status: ``accessrequests-status``,
            ?resourceType: accessresourcetype,
            ?requestMethod: accessrequestmethod,
            ?resourceUserEmail: string,
            ?resourceGroupName: string,
            ?cfResourceId: string,
            ?idpResourceId: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.query ("idp_id", idpId)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if since.IsSome then
                      RequestPart.query ("since", since.Value)
                  if until.IsSome then
                      RequestPart.query ("until", until.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value |> List.map (fun x -> x.Format()))
                  if resourceType.IsSome then
                      RequestPart.query ("resource_type", resourceType.Value |> List.map (fun x -> x.Format()))
                  if requestMethod.IsSome then
                      RequestPart.query ("request_method", requestMethod.Value |> List.map (fun x -> x.Format()))
                  if resourceUserEmail.IsSome then
                      RequestPart.query ("resource_user_email", resourceUserEmail.Value)
                  if resourceGroupName.IsSome then
                      RequestPart.query ("resource_group_name", resourceGroupName.Value)
                  if cfResourceId.IsSome then
                      RequestPart.query ("cf_resource_id", cfResourceId.Value)
                  if idpResourceId.IsSome then
                      RequestPart.query ("idp_resource_id", idpResourceId.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/logs/scim/updates"
                    requestParts
                    cancellationToken

            return AccessScimUpdateLogsListAccessScimUpdateLogs.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the configuration for your Zero Trust organization.
    ///</summary>
    member this.ZeroTrustOrganizationGetYourZeroTrustOrganization
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
                    "/accounts/{account_id}/access/organizations"
                    requestParts
                    cancellationToken

            return ZeroTrustOrganizationGetYourZeroTrustOrganization.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Sets up a Zero Trust organization for your account.
    ///</summary>
    member this.ZeroTrustOrganizationCreateYourZeroTrustOrganization
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
                    "/accounts/{account_id}/access/organizations"
                    requestParts
                    cancellationToken

            return ZeroTrustOrganizationCreateYourZeroTrustOrganization.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the configuration for your Zero Trust organization.
    ///</summary>
    member this.ZeroTrustOrganizationUpdateYourZeroTrustOrganization
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
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/organizations"
                    requestParts
                    cancellationToken

            return ZeroTrustOrganizationUpdateYourZeroTrustOrganization.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the DoH settings for your Zero Trust organization.
    ///</summary>
    member this.ZeroTrustOrganizationGetYourZeroTrustOrganizationDohSettings
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
                    "/accounts/{account_id}/access/organizations/doh"
                    requestParts
                    cancellationToken

            return ZeroTrustOrganizationGetYourZeroTrustOrganizationDohSettings.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the DoH settings for your Zero Trust organization.
    ///</summary>
    member this.ZeroTrustOrganizationUpdateYourZeroTrustOrganizationDohSettings
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
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/organizations/doh"
                    requestParts
                    cancellationToken

            return
                ZeroTrustOrganizationUpdateYourZeroTrustOrganizationDohSettings.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Revokes a user's access across all applications.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="devices">When set to `true`, all devices associated with the user will be revoked.</param>
    ///<param name="cancellationToken"></param>
    member this.ZeroTrustOrganizationRevokeAllAccessTokensForAUser
        (
            accountId: string,
            body: string,
            ?devices: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if devices.IsSome then
                      RequestPart.query ("devices", devices.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/organizations/revoke_user"
                    requestParts
                    cancellationToken

            return ZeroTrustOrganizationRevokeAllAccessTokensForAUser.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists Access reusable policies.
    ///</summary>
    member this.AccessPoliciesListAccessReusablePolicies
        (
            accountId: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/access/policies" requestParts cancellationToken

            return AccessPoliciesListAccessReusablePolicies.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Access reusable policy.
    ///</summary>
    member this.AccessPoliciesCreateAnAccessReusablePolicy
        (
            accountId: string,
            body: accesspolicyreq,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/access/policies" requestParts cancellationToken

            return AccessPoliciesCreateAnAccessReusablePolicy.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes an Access reusable policy.
    ///</summary>
    member this.AccessPoliciesDeleteAnAccessReusablePolicy
        (
            accountId: string,
            policyId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_id", policyId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/policies/{policy_id}"
                    requestParts
                    cancellationToken

            return AccessPoliciesDeleteAnAccessReusablePolicy.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single Access reusable policy.
    ///</summary>
    member this.AccessPoliciesGetAnAccessReusablePolicy
        (
            accountId: string,
            policyId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_id", policyId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/policies/{policy_id}"
                    requestParts
                    cancellationToken

            return AccessPoliciesGetAnAccessReusablePolicy.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a Access reusable policy.
    ///</summary>
    member this.AccessPoliciesUpdateAnAccessReusablePolicy
        (
            accountId: string,
            policyId: string,
            body: accesspolicyreq,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_id", policyId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/policies/{policy_id}"
                    requestParts
                    cancellationToken

            return AccessPoliciesUpdateAnAccessReusablePolicy.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Starts an Access policy test.
    ///</summary>
    member this.AccessPolicyTests(accountId: string, body: accesspolicyinitreq, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/policy-tests"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccessPolicyTests.OK(Serializer.deserialize content)
            | _ -> return AccessPolicyTests.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches the current status of a given Access policy test.
    ///</summary>
    member this.AccessPolicyTestsGetAnUpdate
        (
            accountId: string,
            policyTestId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_test_id", policyTestId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/policy-tests/{policy_test_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccessPolicyTestsGetAnUpdate.OK(Serializer.deserialize content)
            | _ -> return AccessPolicyTestsGetAnUpdate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single page of user results from an Access policy test.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="policyTestId"></param>
    ///<param name="perPage"></param>
    ///<param name="status">Filter users by their policy evaluation status.</param>
    ///<param name="cancellationToken"></param>
    member this.AccessPolicyTestsGetAUserPage
        (
            accountId: string,
            policyTestId: string,
            ?perPage: int,
            ?status: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_test_id", policyTestId)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/policy-tests/{policy_test_id}/users"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AccessPolicyTestsGetAUserPage.OK(Serializer.deserialize content)
            | _ -> return AccessPolicyTestsGetAUserPage.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a user from a Zero Trust seat when both `access_seat` and `gateway_seat` are set to false.
    ///</summary>
    member this.ZeroTrustSeatsUpdateAUserSeat
        (
            accountId: accessidentifier,
            body: accessseatsdefinition,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync httpClient "/accounts/{account_id}/access/seats" requestParts cancellationToken

            return ZeroTrustSeatsUpdateAUserSeat.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all service tokens.
    ///</summary>
    member this.AccessServiceTokensListServiceTokens
        (
            accountId: string,
            ?name: string,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/service_tokens"
                    requestParts
                    cancellationToken

            return AccessServiceTokensListServiceTokens.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Generates a new service token. **Note:** This is the only time you can get the Client Secret. If you lose the Client Secret, you will have to rotate the Client Secret or create a new service token.
    ///</summary>
    member this.AccessServiceTokensCreateAServiceToken
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
                    "/accounts/{account_id}/access/service_tokens"
                    requestParts
                    cancellationToken

            return AccessServiceTokensCreateAServiceToken.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a service token.
    ///</summary>
    member this.AccessServiceTokensDeleteAServiceToken
        (
            serviceTokenId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("service_token_id", serviceTokenId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/service_tokens/{service_token_id}"
                    requestParts
                    cancellationToken

            return AccessServiceTokensDeleteAServiceToken.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single service token.
    ///</summary>
    member this.AccessServiceTokensGetAServiceToken
        (
            serviceTokenId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("service_token_id", serviceTokenId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/service_tokens/{service_token_id}"
                    requestParts
                    cancellationToken

            return AccessServiceTokensGetAServiceToken.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a configured service token.
    ///</summary>
    member this.AccessServiceTokensUpdateAServiceToken
        (
            serviceTokenId: string,
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("service_token_id", serviceTokenId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/service_tokens/{service_token_id}"
                    requestParts
                    cancellationToken

            return AccessServiceTokensUpdateAServiceToken.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Refreshes the expiration of a service token.
    ///</summary>
    member this.AccessServiceTokensRefreshAServiceToken
        (
            serviceTokenId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("service_token_id", serviceTokenId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/service_tokens/{service_token_id}/refresh"
                    requestParts
                    cancellationToken

            return AccessServiceTokensRefreshAServiceToken.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Generates a new Client Secret for a service token and revokes the old one.
    ///</summary>
    member this.AccessServiceTokensRotateAServiceToken
        (
            serviceTokenId: string,
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("service_token_id", serviceTokenId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/access/service_tokens/{service_token_id}/rotate"
                    requestParts
                    cancellationToken

            return AccessServiceTokensRotateAServiceToken.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List tags
    ///</summary>
    member this.AccessTagsListTags(accountId: string, ?perPage: int, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/access/tags" requestParts cancellationToken

            return AccessTagsListTags.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a tag
    ///</summary>
    member this.AccessTagsCreateTag(accountId: string, body: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/access/tags" requestParts cancellationToken

            return AccessTagsCreateTag.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a tag
    ///</summary>
    member this.AccessTagsDeleteATag(accountId: string, tagName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tag_name", tagName) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/tags/{tag_name}"
                    requestParts
                    cancellationToken

            return AccessTagsDeleteATag.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a tag
    ///</summary>
    member this.AccessTagsGetATag(accountId: string, tagName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tag_name", tagName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/tags/{tag_name}"
                    requestParts
                    cancellationToken

            return AccessTagsGetATag.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a tag
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="tagName"></param>
    ///<param name="body">A tag</param>
    ///<param name="cancellationToken"></param>
    member this.AccessTagsUpdateATag
        (
            accountId: string,
            tagName: string,
            body: accesstagwithoutappcount,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tag_name", tagName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/tags/{tag_name}"
                    requestParts
                    cancellationToken

            return AccessTagsUpdateATag.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets a list of users for an account.
    ///</summary>
    member this.ZeroTrustUsersGetUsers
        (
            accountId: string,
            ?name: string,
            ?email: string,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if email.IsSome then
                      RequestPart.query ("email", email.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/access/users" requestParts cancellationToken

            return ZeroTrustUsersGetUsers.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new user.
    ///</summary>
    member this.ZeroTrustUsersCreateUser(accountId: string, body: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/access/users" requestParts cancellationToken

            return ZeroTrustUsersCreateUser.Created(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a specific user for an account. This will also revoke any active seats and tokens for the user.
    ///</summary>
    member this.ZeroTrustUsersDeleteUser(userId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("user_id", userId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/users/{user_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustUsersDeleteUser.Accepted(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets a specific user for an account.
    ///</summary>
    member this.ZeroTrustUsersGetUser(userId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("user_id", userId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/users/{user_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustUsersGetUser.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a specific user's name for an account. Requires the user's current email as confirmation (email cannot be changed).
    ///</summary>
    member this.ZeroTrustUsersUpdateUser
        (
            userId: string,
            accountId: string,
            body: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("user_id", userId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/access/users/{user_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustUsersUpdateUser.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get active sessions for a single user.
    ///</summary>
    member this.ZeroTrustUsersGetActiveSessions
        (
            userId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("user_id", userId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/users/{user_id}/active_sessions"
                    requestParts
                    cancellationToken

            return ZeroTrustUsersGetActiveSessions.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get an active session for a single user.
    ///</summary>
    member this.ZeroTrustUsersGetActiveSession
        (
            userId: string,
            accountId: string,
            nonce: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("user_id", userId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("nonce", nonce) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/users/{user_id}/active_sessions/{nonce}"
                    requestParts
                    cancellationToken

            return ZeroTrustUsersGetActiveSession.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get all failed login attempts for a single user.
    ///</summary>
    member this.ZeroTrustUsersGetFailedLogins
        (
            userId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("user_id", userId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/users/{user_id}/failed_logins"
                    requestParts
                    cancellationToken

            return ZeroTrustUsersGetFailedLogins.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get last seen identity for a single user.
    ///</summary>
    member this.ZeroTrustUsersGetLastSeenIdentity
        (
            userId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("user_id", userId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/access/users/{user_id}/last_seen_identity"
                    requestParts
                    cancellationToken

            return ZeroTrustUsersGetLastSeenIdentity.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a specific MFA device for a user. This action is only available if MFA is turned on for the organization.
    ///</summary>
    member this.ZeroTrustUsersDeleteMfaAuthenticator
        (
            userId: string,
            accountId: string,
            authenticatorId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("user_id", userId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("authenticator_id", authenticatorId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/access/users/{user_id}/mfa_authenticators/{authenticator_id}"
                    requestParts
                    cancellationToken

            return ZeroTrustUsersDeleteMfaAuthenticator.OK(Serializer.deserialize content)
        }
