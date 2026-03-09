namespace rec Fidelity.CloudEdge.Management.Pages

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Pages.Types
open Fidelity.CloudEdge.Management.Pages.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type PagesClient(httpClient: HttpClient) =
    ///<summary>
    ///Fetch a list of all user projects.
    ///</summary>
    member this.PagesProjectGetProjects
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/pages/projects" requestParts cancellationToken

            match int status with
            | 200 -> return PagesProjectGetProjects.OK(Serializer.deserialize content)
            | _ -> return PagesProjectGetProjects.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new project.
    ///</summary>
    member this.PagesProjectCreateProject
        (
            accountId: string,
            body: PagesProjectCreateProjectPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/pages/projects" requestParts cancellationToken

            match int status with
            | 200 -> return PagesProjectCreateProject.OK(Serializer.deserialize content)
            | _ -> return PagesProjectCreateProject.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a project by name.
    ///</summary>
    member this.PagesProjectDeleteProject
        (
            projectName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesProjectDeleteProject.OK(Serializer.deserialize content)
            | _ -> return PagesProjectDeleteProject.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch a project by name.
    ///</summary>
    member this.PagesProjectGetProject(projectName: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesProjectGetProject.OK(Serializer.deserialize content)
            | _ -> return PagesProjectGetProject.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Set new attributes for an existing project. Modify environment variables. To delete an environment variable, set the key to null.
    ///</summary>
    member this.PagesProjectUpdateProject
        (
            projectName: string,
            accountId: string,
            body: PagesProjectUpdateProjectPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesProjectUpdateProject.OK(Serializer.deserialize content)
            | _ -> return PagesProjectUpdateProject.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch a list of project deployments.
    ///</summary>
    member this.PagesDeploymentGetDeployments
        (
            projectName: string,
            accountId: string,
            ?env: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId)
                  if env.IsSome then
                      RequestPart.query ("env", env.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/deployments"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDeploymentGetDeployments.OK(Serializer.deserialize content)
            | _ -> return PagesDeploymentGetDeployments.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Start a new deployment from production. The repository and account must have already been authorized on the Cloudflare Pages dashboard.
    ///</summary>
    member this.PagesDeploymentCreateDeployment
        (
            projectName: string,
            accountId: string,
            body: PagesDeploymentCreateDeploymentPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/deployments"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDeploymentCreateDeployment.OK(Serializer.deserialize content)
            | _ -> return PagesDeploymentCreateDeployment.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a deployment.
    ///</summary>
    member this.PagesDeploymentDeleteDeployment
        (
            deploymentId: string,
            projectName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("deployment_id", deploymentId)
                  RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/deployments/{deployment_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDeploymentDeleteDeployment.OK(Serializer.deserialize content)
            | _ -> return PagesDeploymentDeleteDeployment.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch information about a deployment.
    ///</summary>
    member this.PagesDeploymentGetDeploymentInfo
        (
            deploymentId: string,
            projectName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("deployment_id", deploymentId)
                  RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/deployments/{deployment_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDeploymentGetDeploymentInfo.OK(Serializer.deserialize content)
            | _ -> return PagesDeploymentGetDeploymentInfo.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch deployment logs for a project.
    ///</summary>
    member this.PagesDeploymentGetDeploymentLogs
        (
            deploymentId: string,
            projectName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("deployment_id", deploymentId)
                  RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/deployments/{deployment_id}/history/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDeploymentGetDeploymentLogs.OK(Serializer.deserialize content)
            | _ -> return PagesDeploymentGetDeploymentLogs.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retry a previous deployment.
    ///</summary>
    member this.PagesDeploymentRetryDeployment
        (
            deploymentId: string,
            projectName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("deployment_id", deploymentId)
                  RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/deployments/{deployment_id}/retry"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDeploymentRetryDeployment.OK(Serializer.deserialize content)
            | _ -> return PagesDeploymentRetryDeployment.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Rollback the production deployment to a previous deployment. You can only rollback to succesful builds on production.
    ///</summary>
    member this.PagesDeploymentRollbackDeployment
        (
            deploymentId: string,
            projectName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("deployment_id", deploymentId)
                  RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/deployments/{deployment_id}/rollback"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDeploymentRollbackDeployment.OK(Serializer.deserialize content)
            | _ -> return PagesDeploymentRollbackDeployment.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch a list of all domains associated with a Pages project.
    ///</summary>
    member this.PagesDomainsGetDomains(projectName: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/domains"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDomainsGetDomains.OK(Serializer.deserialize content)
            | _ -> return PagesDomainsGetDomains.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Add a new domain for the Pages project.
    ///</summary>
    member this.PagesDomainsAddDomain
        (
            projectName: string,
            accountId: string,
            body: PagesDomainsAddDomainPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/domains"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDomainsAddDomain.OK(Serializer.deserialize content)
            | _ -> return PagesDomainsAddDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a Pages project's domain.
    ///</summary>
    member this.PagesDomainsDeleteDomain
        (
            domainName: string,
            projectName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("domain_name", domainName)
                  RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/domains/{domain_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDomainsDeleteDomain.OK(Serializer.deserialize content)
            | _ -> return PagesDomainsDeleteDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch a single domain.
    ///</summary>
    member this.PagesDomainsGetDomain
        (
            domainName: string,
            projectName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("domain_name", domainName)
                  RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/domains/{domain_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDomainsGetDomain.OK(Serializer.deserialize content)
            | _ -> return PagesDomainsGetDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retry the validation status of a single domain.
    ///</summary>
    member this.PagesDomainsPatchDomain
        (
            domainName: string,
            projectName: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("domain_name", domainName)
                  RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/domains/{domain_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesDomainsPatchDomain.OK(Serializer.deserialize content)
            | _ -> return PagesDomainsPatchDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Purge all cached build artifacts for a Pages project
    ///</summary>
    member this.PagesPurgeBuildCache(projectName: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("project_name", projectName)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/pages/projects/{project_name}/purge_build_cache"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PagesPurgeBuildCache.OK(Serializer.deserialize content)
            | _ -> return PagesPurgeBuildCache.BadRequest(Serializer.deserialize content)
        }
