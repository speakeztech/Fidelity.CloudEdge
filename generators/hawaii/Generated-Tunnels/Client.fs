namespace rec Fidelity.CloudEdge.Management.Tunnels

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Tunnels.Types
open Fidelity.CloudEdge.Management.Tunnels.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type TunnelsClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists and filters Cloudflare Tunnels in an account.
    ///</summary>
    member this.CloudflareTunnelListCloudflareTunnels
        (
            accountId: string,
            ?name: string,
            ?isDeleted: bool,
            ?existedAt: string,
            ?uuid: System.Guid,
            ?wasActiveAt: System.DateTimeOffset,
            ?wasInactiveAt: System.DateTimeOffset,
            ?includePrefix: string,
            ?excludePrefix: string,
            ?status: string,
            ?perPage: float,
            ?page: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if isDeleted.IsSome then
                      RequestPart.query ("is_deleted", isDeleted.Value)
                  if existedAt.IsSome then
                      RequestPart.query ("existed_at", existedAt.Value)
                  if uuid.IsSome then
                      RequestPart.query ("uuid", uuid.Value)
                  if wasActiveAt.IsSome then
                      RequestPart.query ("was_active_at", wasActiveAt.Value)
                  if wasInactiveAt.IsSome then
                      RequestPart.query ("was_inactive_at", wasInactiveAt.Value)
                  if includePrefix.IsSome then
                      RequestPart.query ("include_prefix", includePrefix.Value)
                  if excludePrefix.IsSome then
                      RequestPart.query ("exclude_prefix", excludePrefix.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/cfd_tunnel" requestParts cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelListCloudflareTunnels.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelListCloudflareTunnels.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Cloudflare Tunnel in an account.
    ///</summary>
    member this.CloudflareTunnelCreateACloudflareTunnel
        (
            accountId: string,
            body: CloudflareTunnelCreateACloudflareTunnelPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/cfd_tunnel" requestParts cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelCreateACloudflareTunnel.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelCreateACloudflareTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a Cloudflare Tunnel from an account.
    ///</summary>
    member this.CloudflareTunnelDeleteACloudflareTunnel
        (
            accountId: string,
            tunnelId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelDeleteACloudflareTunnel.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelDeleteACloudflareTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single Cloudflare Tunnel.
    ///</summary>
    member this.CloudflareTunnelGetACloudflareTunnel
        (
            accountId: string,
            tunnelId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelGetACloudflareTunnel.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelGetACloudflareTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing Cloudflare Tunnel.
    ///</summary>
    member this.CloudflareTunnelUpdateACloudflareTunnel
        (
            tunnelId: System.Guid,
            accountId: string,
            body: CloudflareTunnelUpdateACloudflareTunnelPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("tunnel_id", tunnelId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelUpdateACloudflareTunnel.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelUpdateACloudflareTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets the configuration for a remotely-managed tunnel
    ///</summary>
    member this.CloudflareTunnelConfigurationGetConfiguration
        (
            accountId: string,
            tunnelId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}/configurations"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelConfigurationGetConfiguration.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelConfigurationGetConfiguration.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Adds or updates the configuration for a remotely-managed tunnel.
    ///</summary>
    member this.CloudflareTunnelConfigurationPutConfiguration
        (
            accountId: string,
            tunnelId: System.Guid,
            body: CloudflareTunnelConfigurationPutConfigurationPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}/configurations"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelConfigurationPutConfiguration.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelConfigurationPutConfiguration.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a connection (aka Cloudflare Tunnel Connector) from a Cloudflare Tunnel independently of its current state. If no connector id (client_id) is provided all connectors will be removed. We recommend running this command after rotating tokens.
    ///</summary>
    member this.CloudflareTunnelCleanUpCloudflareTunnelConnections
        (
            accountId: string,
            tunnelId: System.Guid,
            ?clientId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId)
                  if clientId.IsSome then
                      RequestPart.query ("client_id", clientId.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}/connections"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelCleanUpCloudflareTunnelConnections.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelCleanUpCloudflareTunnelConnections.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches connection details for a Cloudflare Tunnel.
    ///</summary>
    member this.CloudflareTunnelListCloudflareTunnelConnections
        (
            accountId: string,
            tunnelId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}/connections"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelListCloudflareTunnelConnections.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelListCloudflareTunnelConnections.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches connector and connection details for a Cloudflare Tunnel.
    ///</summary>
    member this.CloudflareTunnelGetCloudflareTunnelConnector
        (
            accountId: string,
            tunnelId: System.Guid,
            connectorId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId)
                  RequestPart.path ("connector_id", connectorId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}/connectors/{connector_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelGetCloudflareTunnelConnector.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelGetCloudflareTunnelConnector.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets a management token used to access the management resources (i.e. Streaming Logs) of a tunnel.
    ///</summary>
    member this.CloudflareTunnelGetACloudflareTunnelManagementToken
        (
            accountId: string,
            tunnelId: System.Guid,
            body: CloudflareTunnelGetACloudflareTunnelManagementTokenPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}/management"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelGetACloudflareTunnelManagementToken.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelGetACloudflareTunnelManagementToken.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets the token used to associate cloudflared with a specific tunnel.
    ///</summary>
    member this.CloudflareTunnelGetACloudflareTunnelToken
        (
            accountId: string,
            tunnelId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/cfd_tunnel/{tunnel_id}/token"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelGetACloudflareTunnelToken.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelGetACloudflareTunnelToken.BadRequest(Serializer.deserialize content)
        }
