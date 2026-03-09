namespace rec Fidelity.CloudEdge.Management.Magic

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Magic.Types
open Fidelity.CloudEdge.Management.Magic.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type MagicClient(httpClient: HttpClient) =
    ///<summary>
    ///Delete all DNS Protection rules for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteDnsProtectionRulesForAccount(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_dns_protection/configs/dns_protection/rules"
                    requestParts
                    cancellationToken

            return DeleteDnsProtectionRulesForAccount.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List all DNS Protection rules for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="page">The page number for pagination. Defaults to 1.</param>
    ///<param name="perPage">The number of items per page. Must be between 10 and 1000. Defaults to 25.</param>
    ///<param name="order">The field to order by. Defaults to 'prefix'.</param>
    ///<param name="direction">The direction of ordering (ASC or DESC). Defaults to 'ASC'.</param>
    ///<param name="cancellationToken"></param>
    member this.ListDnsProtectionRulesForAccount
        (
            accountId: string,
            ?page: int64,
            ?perPage: int64,
            ?order: string,
            ?direction: string,
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
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_dns_protection/configs/dns_protection/rules"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListDnsProtectionRulesForAccount.OK(Serializer.deserialize content)
            | _ -> return ListDnsProtectionRulesForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a DNS Protection rule for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateDnsProtectionRule
        (
            accountId: string,
            body: dosNewDnsProtectionRule,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_dns_protection/configs/dns_protection/rules"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateDnsProtectionRule.OK(Serializer.deserialize content)
            | _ -> return CreateDnsProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a DNS Protection rule specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="ruleId">The UUID of the DNS Protection rule to delete.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteDnsProtectionRule(accountId: string, ruleId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("rule_id", ruleId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_dns_protection/configs/dns_protection/rules/{rule_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteDnsProtectionRule.OK(Serializer.deserialize content)
            | _ -> return DeleteDnsProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a DNS Protection rule specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="ruleId">The UUID of the DNS Protection rule.</param>
    ///<param name="cancellationToken"></param>
    member this.GetDnsProtectionRule(accountId: string, ruleId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("rule_id", ruleId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_dns_protection/configs/dns_protection/rules/{rule_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetDnsProtectionRule.OK(Serializer.deserialize content)
            | _ -> return GetDnsProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a DNS Protection rule specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="ruleId">The UUID of the DNS Protection rule to update.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdateDnsProtectionRule
        (
            accountId: string,
            ruleId: string,
            body: dosDnsProtectionRuleUpdate,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("rule_id", ruleId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_dns_protection/configs/dns_protection/rules/{rule_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateDnsProtectionRule.OK(Serializer.deserialize content)
            | _ -> return UpdateDnsProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete all allowlist prefixes for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteAllowlistPrefixesForAccount(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/allowlist"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteAllowlistPrefixesForAccount.OK(Serializer.deserialize content)
            | _ -> return DeleteAllowlistPrefixesForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all allowlist prefixes for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="page">The page number for pagination. Defaults to 1.</param>
    ///<param name="perPage">The number of items per page. Must be between 10 and 1000. Defaults to 25.</param>
    ///<param name="order">The field to order by. Defaults to 'prefix'.</param>
    ///<param name="direction">The direction of ordering (ASC or DESC). Defaults to 'ASC'.</param>
    ///<param name="cancellationToken"></param>
    member this.ListAllowlistPrefixesForAccount
        (
            accountId: string,
            ?page: int64,
            ?perPage: int64,
            ?order: string,
            ?direction: string,
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
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/allowlist"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListAllowlistPrefixesForAccount.OK(Serializer.deserialize content)
            | _ -> return ListAllowlistPrefixesForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create an allowlist prefix for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateAllowlistedPrefix
        (
            accountId: string,
            body: dosNewInfraPrefix,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/allowlist"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateAllowlistedPrefix.OK(Serializer.deserialize content)
            | _ -> return CreateAllowlistedPrefix.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete the allowlist prefix for an account given a UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="prefixId">The UUID of the allowlist prefix to delete.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteAllowlistPrefix(accountId: string, prefixId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("prefix_id", prefixId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/allowlist/{prefix_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteAllowlistPrefix.OK(Serializer.deserialize content)
            | _ -> return DeleteAllowlistPrefix.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get an allowlist prefix specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="prefixId">The UUID of the allowlist prefix.</param>
    ///<param name="cancellationToken"></param>
    member this.GetAllowlistPrefix(accountId: string, prefixId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("prefix_id", prefixId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/allowlist/{prefix_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetAllowlistPrefix.OK(Serializer.deserialize content)
            | _ -> return GetAllowlistPrefix.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update an allowlist prefix specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="prefixId">The UUID of the allowlist prefix to update.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdateAllowlistPrefix
        (
            accountId: string,
            prefixId: string,
            body: dosInfraPrefixUpdate,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("prefix_id", prefixId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/allowlist/{prefix_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateAllowlistPrefix.OK(Serializer.deserialize content)
            | _ -> return UpdateAllowlistPrefix.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete all prefixes for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="cancellationToken"></param>
    member this.DeletePrefixesForAccount(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/prefixes"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeletePrefixesForAccount.OK(Serializer.deserialize content)
            | _ -> return DeletePrefixesForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all prefixes for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="page">The page number for pagination. Defaults to 1.</param>
    ///<param name="perPage">The number of items per page. Must be between 10 and 1000. Defaults to 25.</param>
    ///<param name="order">The field to order by. Defaults to 'prefix'.</param>
    ///<param name="direction">The direction of ordering (ASC or DESC). Defaults to 'ASC'.</param>
    ///<param name="cancellationToken"></param>
    member this.ListPrefixesForAccount
        (
            accountId: string,
            ?page: int64,
            ?perPage: int64,
            ?order: string,
            ?direction: string,
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
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/prefixes"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListPrefixesForAccount.OK(Serializer.deserialize content)
            | _ -> return ListPrefixesForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a prefix for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreatePrefix(accountId: string, body: dosNewPrefix, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/prefixes"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreatePrefix.OK(Serializer.deserialize content)
            | _ -> return CreatePrefix.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create multiple prefixes for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.BulkCreatePrefixes
        (
            accountId: string,
            body: BulkCreatePrefixesPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/prefixes/bulk"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BulkCreatePrefixes.OK(Serializer.deserialize content)
            | _ -> return BulkCreatePrefixes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete the prefix for an account given a UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="prefixId">The UUID of the prefix to delete.</param>
    ///<param name="cancellationToken"></param>
    member this.DeletePrefix(accountId: string, prefixId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("prefix_id", prefixId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/prefixes/{prefix_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeletePrefix.OK(Serializer.deserialize content)
            | _ -> return DeletePrefix.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a prefix specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="prefixId">The UUID of the prefix.</param>
    ///<param name="cancellationToken"></param>
    member this.GetPrefix(accountId: string, prefixId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("prefix_id", prefixId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/prefixes/{prefix_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetPrefix.OK(Serializer.deserialize content)
            | _ -> return GetPrefix.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a prefix specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="prefixId">The UUID of the prefix to update.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdatePrefix
        (
            accountId: string,
            prefixId: string,
            body: dosPrefixUpdate,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("prefix_id", prefixId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/prefixes/{prefix_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdatePrefix.OK(Serializer.deserialize content)
            | _ -> return UpdatePrefix.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete all SYN Protection filters for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteSynProtectionFiltersForAccount(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/filters"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteSynProtectionFiltersForAccount.OK(Serializer.deserialize content)
            | _ -> return DeleteSynProtectionFiltersForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all SYN Protection filters for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="mode">The mode of the filters to get. Optional. Valid values: 'enabled', 'disabled', 'monitoring'.</param>
    ///<param name="page">The page number for pagination. Defaults to 1.</param>
    ///<param name="perPage">The number of items per page. Must be between 10 and 1000. Defaults to 25.</param>
    ///<param name="order">The field to order by. Defaults to 'prefix'.</param>
    ///<param name="direction">The direction of ordering (ASC or DESC). Defaults to 'ASC'.</param>
    ///<param name="cancellationToken"></param>
    member this.ListSynProtectionFiltersForAccount
        (
            accountId: string,
            ?mode: string,
            ?page: int64,
            ?perPage: int64,
            ?order: string,
            ?direction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if mode.IsSome then
                      RequestPart.query ("mode", mode.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/filters"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListSynProtectionFiltersForAccount.OK(Serializer.deserialize content)
            | _ -> return ListSynProtectionFiltersForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a SYN Protection filter for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateSynProtectionFilter
        (
            accountId: string,
            body: dosNewExpressionFilter,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/filters"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateSynProtectionFilter.OK(Serializer.deserialize content)
            | _ -> return CreateSynProtectionFilter.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a SYN Protection filter specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="filterId">The UUID of the filter to delete.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteSynProtectionFilter(accountId: string, filterId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("filter_id", filterId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/filters/{filter_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteSynProtectionFilter.OK(Serializer.deserialize content)
            | _ -> return DeleteSynProtectionFilter.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a SYN Protection filter specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="filterId">The UUID of the filter to retrieve.</param>
    ///<param name="cancellationToken"></param>
    member this.GetSynProtectionFilter(accountId: string, filterId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("filter_id", filterId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/filters/{filter_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetSynProtectionFilter.OK(Serializer.deserialize content)
            | _ -> return GetSynProtectionFilter.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a SYN Protection filter specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="filterId">The UUID of the filter to update.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdateSynProtectionFilter
        (
            accountId: string,
            filterId: string,
            body: dosExpressionFilterUpdate,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("filter_id", filterId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/filters/{filter_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateSynProtectionFilter.OK(Serializer.deserialize content)
            | _ -> return UpdateSynProtectionFilter.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete all SYN Protection rules for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteSynProtectionRulesForAccount(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/rules"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteSynProtectionRulesForAccount.OK(Serializer.deserialize content)
            | _ -> return DeleteSynProtectionRulesForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all SYN Protection rules for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="page">The page number for pagination. Defaults to 1.</param>
    ///<param name="perPage">The number of items per page. Must be between 10 and 1000. Defaults to 25.</param>
    ///<param name="order">The field to order by. Defaults to 'prefix'.</param>
    ///<param name="direction">The direction of ordering (ASC or DESC). Defaults to 'ASC'.</param>
    ///<param name="cancellationToken"></param>
    member this.ListSynProtectionRulesForAccount
        (
            accountId: string,
            ?page: int64,
            ?perPage: int64,
            ?order: string,
            ?direction: string,
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
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/rules"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListSynProtectionRulesForAccount.OK(Serializer.deserialize content)
            | _ -> return ListSynProtectionRulesForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a SYN Protection rule for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateSynProtectionRule
        (
            accountId: string,
            body: dosNewSynProtectionRule,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/rules"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateSynProtectionRule.OK(Serializer.deserialize content)
            | _ -> return CreateSynProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a SYN Protection rule specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="ruleId">The UUID of the SYN Protection rule to delete.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteSynProtectionRule(accountId: string, ruleId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("rule_id", ruleId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/rules/{rule_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteSynProtectionRule.OK(Serializer.deserialize content)
            | _ -> return DeleteSynProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a SYN Protection rule specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="ruleId">The UUID of the SYN Protection rule.</param>
    ///<param name="cancellationToken"></param>
    member this.GetSynProtectionRule(accountId: string, ruleId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("rule_id", ruleId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/rules/{rule_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetSynProtectionRule.OK(Serializer.deserialize content)
            | _ -> return GetSynProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a SYN Protection rule specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="ruleId">The UUID of the SYN Protection rule to update.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdateSynProtectionRule
        (
            accountId: string,
            ruleId: string,
            body: dosSynProtectionRuleUpdate,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("rule_id", ruleId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/syn_protection/rules/{rule_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateSynProtectionRule.OK(Serializer.deserialize content)
            | _ -> return UpdateSynProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete all TCP Flow Protection filters for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteTcpFlowProtectionFiltersForAccount(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/filters"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteTcpFlowProtectionFiltersForAccount.OK(Serializer.deserialize content)
            | _ -> return DeleteTcpFlowProtectionFiltersForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all TCP Flow Protection filters for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="mode">The mode of the filters to get. Optional. Valid values: 'enabled', 'disabled', 'monitoring'.</param>
    ///<param name="page">The page number for pagination. Defaults to 1.</param>
    ///<param name="perPage">The number of items per page. Must be between 10 and 1000. Defaults to 25.</param>
    ///<param name="order">The field to order by. Defaults to 'prefix'.</param>
    ///<param name="direction">The direction of ordering (ASC or DESC). Defaults to 'ASC'.</param>
    ///<param name="cancellationToken"></param>
    member this.ListTcpFlowProtectionFiltersForAccount
        (
            accountId: string,
            ?mode: string,
            ?page: int64,
            ?perPage: int64,
            ?order: string,
            ?direction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if mode.IsSome then
                      RequestPart.query ("mode", mode.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/filters"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListTcpFlowProtectionFiltersForAccount.OK(Serializer.deserialize content)
            | _ -> return ListTcpFlowProtectionFiltersForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a TCP Flow Protection filter for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateTcpFlowProtectionFilter
        (
            accountId: string,
            body: dosNewExpressionFilter,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/filters"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateTcpFlowProtectionFilter.OK(Serializer.deserialize content)
            | _ -> return CreateTcpFlowProtectionFilter.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a TCP Flow Protection filter specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="filterId">The UUID of the filter to delete.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteTcpFlowProtectionFilter
        (
            accountId: string,
            filterId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("filter_id", filterId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/filters/{filter_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteTcpFlowProtectionFilter.OK(Serializer.deserialize content)
            | _ -> return DeleteTcpFlowProtectionFilter.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a TCP Flow Protection filter specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="filterId">The UUID of the filter to retrieve.</param>
    ///<param name="cancellationToken"></param>
    member this.GetTcpFlowProtectionFilter(accountId: string, filterId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("filter_id", filterId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/filters/{filter_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetTcpFlowProtectionFilter.OK(Serializer.deserialize content)
            | _ -> return GetTcpFlowProtectionFilter.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a TCP Flow Protection filter specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="filterId">The UUID of the filter to update.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdateTcpFlowProtectionFilter
        (
            accountId: string,
            filterId: string,
            body: dosExpressionFilterUpdate,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("filter_id", filterId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/filters/{filter_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateTcpFlowProtectionFilter.OK(Serializer.deserialize content)
            | _ -> return UpdateTcpFlowProtectionFilter.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete all TCP Flow Protection rules for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteTcpFlowProtectionRulesForAccount(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/rules"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteTcpFlowProtectionRulesForAccount.OK(Serializer.deserialize content)
            | _ -> return DeleteTcpFlowProtectionRulesForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all TCP Flow Protection rules for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="page">The page number for pagination. Defaults to 1.</param>
    ///<param name="perPage">The number of items per page. Must be between 10 and 1000. Defaults to 25.</param>
    ///<param name="order">The field to order by. Defaults to 'prefix'.</param>
    ///<param name="direction">The direction of ordering (ASC or DESC). Defaults to 'ASC'.</param>
    ///<param name="cancellationToken"></param>
    member this.ListTcpFlowProtectionRulesForAccount
        (
            accountId: string,
            ?page: int64,
            ?perPage: int64,
            ?order: string,
            ?direction: string,
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
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/rules"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListTcpFlowProtectionRulesForAccount.OK(Serializer.deserialize content)
            | _ -> return ListTcpFlowProtectionRulesForAccount.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a TCP Flow Protection rule for an account.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateTcpFlowProtectionRule
        (
            accountId: string,
            body: dosNewTcpFlowProtectionRule,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/rules"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateTcpFlowProtectionRule.OK(Serializer.deserialize content)
            | _ -> return CreateTcpFlowProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a TCP Flow Protection rule specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="ruleId">The UUID of the TCP Flow Protection rule to delete.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteTcpFlowProtectionRule(accountId: string, ruleId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("rule_id", ruleId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/rules/{rule_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteTcpFlowProtectionRule.OK(Serializer.deserialize content)
            | _ -> return DeleteTcpFlowProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a TCP Flow Protection rule specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="ruleId">The UUID of the TCP Flow Protection rule.</param>
    ///<param name="cancellationToken"></param>
    member this.GetTcpFlowProtectionRule(accountId: string, ruleId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("rule_id", ruleId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/rules/{rule_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetTcpFlowProtectionRule.OK(Serializer.deserialize content)
            | _ -> return GetTcpFlowProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a TCP Flow Protection rule specified by the given UUID.
    ///</summary>
    ///<param name="accountId">The ID of the account.</param>
    ///<param name="ruleId">The UUID of the TCP Flow Protection rule to update.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdateTcpFlowProtectionRule
        (
            accountId: string,
            ruleId: string,
            body: dosTcpFlowProtectionRuleUpdate,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("rule_id", ruleId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_flow_protection/rules/{rule_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateTcpFlowProtectionRule.OK(Serializer.deserialize content)
            | _ -> return UpdateTcpFlowProtectionRule.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get the protection status of the account.
    ///</summary>
    ///<param name="accountId">The account ID.</param>
    ///<param name="cancellationToken"></param>
    member this.GetProtectionStatus(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_protection_status"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetProtectionStatus.OK(Serializer.deserialize content)
            | _ -> return GetProtectionStatus.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update the protection status of the account.
    ///</summary>
    ///<param name="accountId">The account ID.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdateProtectionStatus
        (
            accountId: string,
            body: dosUpdateProtectionStatus,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/advanced_tcp_protection/configs/tcp_protection_status"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateProtectionStatus.OK(Serializer.deserialize content)
            | _ -> return UpdateProtectionStatus.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists Apps associated with an account.
    ///</summary>
    member this.MagicAccountAppsListApps(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/magic/apps" requestParts cancellationToken

            match int status with
            | 200 -> return MagicAccountAppsListApps.OK(Serializer.deserialize content)
            | _ -> return MagicAccountAppsListApps.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new App for an account
    ///</summary>
    member this.MagicAccountAppsAddApp
        (
            accountId: string,
            body: magicappaddsinglerequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/magic/apps" requestParts cancellationToken

            match int status with
            | 201 -> return MagicAccountAppsAddApp.Created(Serializer.deserialize content)
            | _ -> return MagicAccountAppsAddApp.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes specific Account App.
    ///</summary>
    member this.MagicAccountAppsDeleteApp
        (
            accountId: string,
            accountAppId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("account_app_id", accountAppId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/apps/{account_app_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicAccountAppsDeleteApp.OK(Serializer.deserialize content)
            | _ -> return MagicAccountAppsDeleteApp.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an Account App
    ///</summary>
    member this.MagicAccountAppsPatchApp
        (
            accountId: string,
            accountAppId: string,
            body: magicappupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("account_app_id", accountAppId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/apps/{account_app_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicAccountAppsPatchApp.OK(Serializer.deserialize content)
            | _ -> return MagicAccountAppsPatchApp.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an Account App
    ///</summary>
    member this.MagicAccountAppsUpdateApp
        (
            accountId: string,
            accountAppId: string,
            body: magicappupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("account_app_id", accountAppId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/apps/{account_app_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicAccountAppsUpdateApp.OK(Serializer.deserialize content)
            | _ -> return MagicAccountAppsUpdateApp.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists interconnects associated with an account.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the response body will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicInterconnectsListInterconnects
        (
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cf_interconnects"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicInterconnectsListInterconnects.OK(Serializer.deserialize content)
            | _ -> return MagicInterconnectsListInterconnects.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates multiple interconnects associated with an account. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the request and response bodies will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicInterconnectsUpdateMultipleInterconnects
        (
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/cf_interconnects"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicInterconnectsUpdateMultipleInterconnects.OK(Serializer.deserialize content)
            | _ -> return MagicInterconnectsUpdateMultipleInterconnects.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists details for a specific interconnect.
    ///</summary>
    ///<param name="cfInterconnectId"></param>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the response body will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicInterconnectsListInterconnectDetails
        (
            cfInterconnectId: string,
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("cf_interconnect_id", cfInterconnectId)
                  RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cf_interconnects/{cf_interconnect_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicInterconnectsListInterconnectDetails.OK(Serializer.deserialize content)
            | _ -> return MagicInterconnectsListInterconnectDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a specific interconnect associated with an account. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="cfInterconnectId"></param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the request and response bodies will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicInterconnectsUpdateInterconnect
        (
            cfInterconnectId: string,
            accountId: string,
            body: magicinterconnecttunnelupdaterequest,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("cf_interconnect_id", cfInterconnectId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/cf_interconnects/{cf_interconnect_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicInterconnectsUpdateInterconnect.OK(Serializer.deserialize content)
            | _ -> return MagicInterconnectsUpdateInterconnect.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List Catalog Syncs (Closed Beta).
    ///</summary>
    member this.CatalogSyncsList(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/catalog-syncs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CatalogSyncsList.OK(Serializer.deserialize content)
            | 400 -> return CatalogSyncsList.BadRequest(Serializer.deserialize content)
            | 401 -> return CatalogSyncsList.Unauthorized(Serializer.deserialize content)
            | 403 -> return CatalogSyncsList.Forbidden(Serializer.deserialize content)
            | 404 -> return CatalogSyncsList.NotFound(Serializer.deserialize content)
            | _ -> return CatalogSyncsList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Catalog Sync (Closed Beta).
    ///</summary>
    member this.CatalogSyncsCreate
        (
            accountId: string,
            body: mcncreatecatalogsyncrequest,
            ?forwarded: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if forwarded.IsSome then
                      RequestPart.header ("forwarded", forwarded.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/catalog-syncs"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return CatalogSyncsCreate.Created(Serializer.deserialize content)
            | 400 -> return CatalogSyncsCreate.BadRequest(Serializer.deserialize content)
            | 401 -> return CatalogSyncsCreate.Unauthorized(Serializer.deserialize content)
            | 403 -> return CatalogSyncsCreate.Forbidden(Serializer.deserialize content)
            | 409 -> return CatalogSyncsCreate.Conflict(Serializer.deserialize content)
            | 422 -> return CatalogSyncsCreate.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return CatalogSyncsCreate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///List prebuilt catalog sync policies (Closed Beta).
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="destinationType">Specify type of destination, omit to return all.</param>
    ///<param name="cancellationToken"></param>
    member this.CatalogSyncsPrebuiltPoliciesList
        (
            accountId: string,
            ?destinationType: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if destinationType.IsSome then
                      RequestPart.query ("destination_type", destinationType.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/catalog-syncs/prebuilt-policies"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CatalogSyncsPrebuiltPoliciesList.OK(Serializer.deserialize content)
            | 400 -> return CatalogSyncsPrebuiltPoliciesList.BadRequest(Serializer.deserialize content)
            | 401 -> return CatalogSyncsPrebuiltPoliciesList.Unauthorized(Serializer.deserialize content)
            | 403 -> return CatalogSyncsPrebuiltPoliciesList.Forbidden(Serializer.deserialize content)
            | _ -> return CatalogSyncsPrebuiltPoliciesList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a Catalog Sync (Closed Beta).
    ///</summary>
    member this.CatalogSyncsDelete
        (
            accountId: string,
            syncId: System.Guid,
            ?deleteDestination: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sync_id", syncId)
                  if deleteDestination.IsSome then
                      RequestPart.query ("delete_destination", deleteDestination.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/catalog-syncs/{sync_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CatalogSyncsDelete.OK(Serializer.deserialize content)
            | 400 -> return CatalogSyncsDelete.BadRequest(Serializer.deserialize content)
            | 401 -> return CatalogSyncsDelete.Unauthorized(Serializer.deserialize content)
            | 403 -> return CatalogSyncsDelete.Forbidden(Serializer.deserialize content)
            | 404 -> return CatalogSyncsDelete.NotFound(Serializer.deserialize content)
            | 409 -> return CatalogSyncsDelete.Conflict(Serializer.deserialize content)
            | _ -> return CatalogSyncsDelete.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Read a Catalog Sync (Closed Beta).
    ///</summary>
    member this.CatalogSyncsRead(accountId: string, syncId: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sync_id", syncId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/catalog-syncs/{sync_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CatalogSyncsRead.OK(Serializer.deserialize content)
            | 400 -> return CatalogSyncsRead.BadRequest(Serializer.deserialize content)
            | 401 -> return CatalogSyncsRead.Unauthorized(Serializer.deserialize content)
            | 403 -> return CatalogSyncsRead.Forbidden(Serializer.deserialize content)
            | 404 -> return CatalogSyncsRead.NotFound(Serializer.deserialize content)
            | _ -> return CatalogSyncsRead.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a Catalog Sync (Closed Beta).
    ///</summary>
    member this.CatalogSyncsPatch
        (
            accountId: string,
            syncId: System.Guid,
            body: mcnupdatecatalogsyncrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sync_id", syncId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/catalog-syncs/{sync_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CatalogSyncsPatch.OK(Serializer.deserialize content)
            | 400 -> return CatalogSyncsPatch.BadRequest(Serializer.deserialize content)
            | 401 -> return CatalogSyncsPatch.Unauthorized(Serializer.deserialize content)
            | 403 -> return CatalogSyncsPatch.Forbidden(Serializer.deserialize content)
            | 404 -> return CatalogSyncsPatch.NotFound(Serializer.deserialize content)
            | 409 -> return CatalogSyncsPatch.Conflict(Serializer.deserialize content)
            | 422 -> return CatalogSyncsPatch.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return CatalogSyncsPatch.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a Catalog Sync (Closed Beta).
    ///</summary>
    member this.CatalogSyncsUpdate
        (
            accountId: string,
            syncId: System.Guid,
            body: mcnupdatecatalogsyncrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sync_id", syncId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/catalog-syncs/{sync_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CatalogSyncsUpdate.OK(Serializer.deserialize content)
            | 400 -> return CatalogSyncsUpdate.BadRequest(Serializer.deserialize content)
            | 401 -> return CatalogSyncsUpdate.Unauthorized(Serializer.deserialize content)
            | 403 -> return CatalogSyncsUpdate.Forbidden(Serializer.deserialize content)
            | 404 -> return CatalogSyncsUpdate.NotFound(Serializer.deserialize content)
            | 409 -> return CatalogSyncsUpdate.Conflict(Serializer.deserialize content)
            | 422 -> return CatalogSyncsUpdate.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return CatalogSyncsUpdate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Refresh a Catalog Sync's destination by running the sync policy against latest resource catalog (Closed Beta).
    ///</summary>
    member this.CatalogSyncsRefresh(accountId: string, syncId: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sync_id", syncId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/catalog-syncs/{sync_id}/refresh"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CatalogSyncsRefresh.OK(Serializer.deserialize content)
            | 400 -> return CatalogSyncsRefresh.BadRequest(Serializer.deserialize content)
            | 401 -> return CatalogSyncsRefresh.Unauthorized(Serializer.deserialize content)
            | 403 -> return CatalogSyncsRefresh.Forbidden(Serializer.deserialize content)
            | 404 -> return CatalogSyncsRefresh.NotFound(Serializer.deserialize content)
            | 409 -> return CatalogSyncsRefresh.Conflict(Serializer.deserialize content)
            | 422 -> return CatalogSyncsRefresh.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return CatalogSyncsRefresh.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///List On-ramps (Closed Beta).
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="orderBy">One of ["updated_at", "id", "cloud_type", "name"].</param>
    ///<param name="desc"></param>
    ///<param name="status"></param>
    ///<param name="vpcs"></param>
    ///<param name="cancellationToken"></param>
    member this.OnrampsList
        (
            accountId: string,
            ?orderBy: string,
            ?desc: bool,
            ?status: bool,
            ?vpcs: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if desc.IsSome then
                      RequestPart.query ("desc", desc.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if vpcs.IsSome then
                      RequestPart.query ("vpcs", vpcs.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OnrampsList.OK(Serializer.deserialize content)
            | 400 -> return OnrampsList.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsList.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsList.Forbidden(Serializer.deserialize content)
            | _ -> return OnrampsList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new On-ramp (Closed Beta).
    ///</summary>
    member this.OnrampsCreate
        (
            accountId: string,
            body: mcncreateonramprequest,
            ?forwarded: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if forwarded.IsSome then
                      RequestPart.header ("forwarded", forwarded.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return OnrampsCreate.Created(Serializer.deserialize content)
            | 400 -> return OnrampsCreate.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsCreate.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsCreate.Forbidden(Serializer.deserialize content)
            | 409 -> return OnrampsCreate.Conflict(Serializer.deserialize content)
            | 422 -> return OnrampsCreate.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return OnrampsCreate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Read the Magic WAN Address Space (Closed Beta).
    ///</summary>
    member this.OnrampsMwanAddrSpaceRead(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/magic_wan_address_space"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OnrampsMwanAddrSpaceRead.OK(Serializer.deserialize content)
            | 400 -> return OnrampsMwanAddrSpaceRead.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsMwanAddrSpaceRead.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsMwanAddrSpaceRead.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsMwanAddrSpaceRead.NotFound(Serializer.deserialize content)
            | _ -> return OnrampsMwanAddrSpaceRead.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update the Magic WAN Address Space (Closed Beta).
    ///</summary>
    member this.OnrampsMwanAddrSpacePatch
        (
            accountId: string,
            body: mcnupdatemagicwanaddressspacerequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/magic_wan_address_space"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OnrampsMwanAddrSpacePatch.OK(Serializer.deserialize content)
            | 400 -> return OnrampsMwanAddrSpacePatch.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsMwanAddrSpacePatch.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsMwanAddrSpacePatch.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsMwanAddrSpacePatch.NotFound(Serializer.deserialize content)
            | 422 -> return OnrampsMwanAddrSpacePatch.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return OnrampsMwanAddrSpacePatch.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update the Magic WAN Address Space (Closed Beta).
    ///</summary>
    member this.OnrampsMwanAddrSpaceUpdate
        (
            accountId: string,
            body: mcnupdatemagicwanaddressspacerequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/magic_wan_address_space"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OnrampsMwanAddrSpaceUpdate.OK(Serializer.deserialize content)
            | 400 -> return OnrampsMwanAddrSpaceUpdate.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsMwanAddrSpaceUpdate.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsMwanAddrSpaceUpdate.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsMwanAddrSpaceUpdate.NotFound(Serializer.deserialize content)
            | 422 -> return OnrampsMwanAddrSpaceUpdate.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return OnrampsMwanAddrSpaceUpdate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete an On-ramp (Closed Beta).
    ///</summary>
    member this.OnrampsDelete
        (
            accountId: string,
            onrampId: System.Guid,
            ?destroy: bool,
            ?force: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("onramp_id", onrampId)
                  if destroy.IsSome then
                      RequestPart.query ("destroy", destroy.Value)
                  if force.IsSome then
                      RequestPart.query ("force", force.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/{onramp_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OnrampsDelete.OK(Serializer.deserialize content)
            | 400 -> return OnrampsDelete.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsDelete.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsDelete.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsDelete.NotFound(Serializer.deserialize content)
            | 409 -> return OnrampsDelete.Conflict(Serializer.deserialize content)
            | _ -> return OnrampsDelete.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Read an On-ramp (Closed Beta).
    ///</summary>
    member this.OnrampsRead
        (
            accountId: string,
            onrampId: System.Guid,
            ?status: bool,
            ?vpcs: bool,
            ?postApplyResources: bool,
            ?plannedResources: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("onramp_id", onrampId)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if vpcs.IsSome then
                      RequestPart.query ("vpcs", vpcs.Value)
                  if postApplyResources.IsSome then
                      RequestPart.query ("post_apply_resources", postApplyResources.Value)
                  if plannedResources.IsSome then
                      RequestPart.query ("planned_resources", plannedResources.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/{onramp_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OnrampsRead.OK(Serializer.deserialize content)
            | 400 -> return OnrampsRead.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsRead.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsRead.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsRead.NotFound(Serializer.deserialize content)
            | _ -> return OnrampsRead.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update an On-ramp (Closed Beta).
    ///</summary>
    member this.OnrampsPatch
        (
            accountId: string,
            onrampId: System.Guid,
            body: mcnupdateonramprequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("onramp_id", onrampId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/{onramp_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OnrampsPatch.OK(Serializer.deserialize content)
            | 400 -> return OnrampsPatch.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsPatch.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsPatch.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsPatch.NotFound(Serializer.deserialize content)
            | 409 -> return OnrampsPatch.Conflict(Serializer.deserialize content)
            | 422 -> return OnrampsPatch.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return OnrampsPatch.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update an On-ramp (Closed Beta).
    ///</summary>
    member this.OnrampsUpdate
        (
            accountId: string,
            onrampId: System.Guid,
            body: mcnupdateonramprequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("onramp_id", onrampId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/{onramp_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OnrampsUpdate.OK(Serializer.deserialize content)
            | 400 -> return OnrampsUpdate.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsUpdate.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsUpdate.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsUpdate.NotFound(Serializer.deserialize content)
            | 409 -> return OnrampsUpdate.Conflict(Serializer.deserialize content)
            | 422 -> return OnrampsUpdate.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return OnrampsUpdate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Apply an On-ramp (Closed Beta).
    ///</summary>
    member this.OnrampsApply(accountId: string, onrampId: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("onramp_id", onrampId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/{onramp_id}/apply"
                    requestParts
                    cancellationToken

            match int status with
            | 202 -> return OnrampsApply.Accepted(Serializer.deserialize content)
            | 400 -> return OnrampsApply.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsApply.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsApply.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsApply.NotFound(Serializer.deserialize content)
            | 409 -> return OnrampsApply.Conflict(Serializer.deserialize content)
            | _ -> return OnrampsApply.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Export an On-ramp to terraform ready file(s) (Closed Beta).
    ///</summary>
    member this.OnrampsExport(accountId: string, onrampId: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("onramp_id", onrampId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/{onramp_id}/export"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return OnrampsExport.Created content
            | 400 -> return OnrampsExport.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsExport.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsExport.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsExport.NotFound(Serializer.deserialize content)
            | 409 -> return OnrampsExport.Conflict(Serializer.deserialize content)
            | _ -> return OnrampsExport.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Plan an On-ramp (Closed Beta).
    ///</summary>
    member this.OnrampsPlan(accountId: string, onrampId: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("onramp_id", onrampId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/onramps/{onramp_id}/plan"
                    requestParts
                    cancellationToken

            match int status with
            | 202 -> return OnrampsPlan.Accepted(Serializer.deserialize content)
            | 400 -> return OnrampsPlan.BadRequest(Serializer.deserialize content)
            | 401 -> return OnrampsPlan.Unauthorized(Serializer.deserialize content)
            | 403 -> return OnrampsPlan.Forbidden(Serializer.deserialize content)
            | 404 -> return OnrampsPlan.NotFound(Serializer.deserialize content)
            | 409 -> return OnrampsPlan.Conflict(Serializer.deserialize content)
            | _ -> return OnrampsPlan.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///List Cloud Integrations (Closed Beta).
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="status"></param>
    ///<param name="orderBy">One of ["updated_at", "id", "cloud_type", "name"].</param>
    ///<param name="desc"></param>
    ///<param name="cloudflare"></param>
    ///<param name="cancellationToken"></param>
    member this.ProvidersList
        (
            accountId: string,
            ?status: bool,
            ?orderBy: string,
            ?desc: bool,
            ?cloudflare: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if desc.IsSome then
                      RequestPart.query ("desc", desc.Value)
                  if cloudflare.IsSome then
                      RequestPart.query ("cloudflare", cloudflare.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/providers"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ProvidersList.OK(Serializer.deserialize content)
            | 400 -> return ProvidersList.BadRequest(Serializer.deserialize content)
            | 401 -> return ProvidersList.Unauthorized(Serializer.deserialize content)
            | 403 -> return ProvidersList.Forbidden(Serializer.deserialize content)
            | _ -> return ProvidersList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new Cloud Integration (Closed Beta).
    ///</summary>
    member this.ProvidersCreate
        (
            accountId: string,
            body: mcncreateproviderrequest,
            ?forwarded: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if forwarded.IsSome then
                      RequestPart.header ("forwarded", forwarded.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/providers"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return ProvidersCreate.Created(Serializer.deserialize content)
            | 400 -> return ProvidersCreate.BadRequest(Serializer.deserialize content)
            | 401 -> return ProvidersCreate.Unauthorized(Serializer.deserialize content)
            | 403 -> return ProvidersCreate.Forbidden(Serializer.deserialize content)
            | 409 -> return ProvidersCreate.Conflict(Serializer.deserialize content)
            | 422 -> return ProvidersCreate.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return ProvidersCreate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Run discovery for all Cloud Integrations in an account (Closed Beta).
    ///</summary>
    member this.ProvidersDiscoverAll(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/providers/discover"
                    requestParts
                    cancellationToken

            match int status with
            | 202 -> return ProvidersDiscoverAll.Accepted(Serializer.deserialize content)
            | 400 -> return ProvidersDiscoverAll.BadRequest(Serializer.deserialize content)
            | 401 -> return ProvidersDiscoverAll.Unauthorized(Serializer.deserialize content)
            | 403 -> return ProvidersDiscoverAll.Forbidden(Serializer.deserialize content)
            | 409 -> return ProvidersDiscoverAll.Conflict(Serializer.deserialize content)
            | _ -> return ProvidersDiscoverAll.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a Cloud Integration (Closed Beta).
    ///</summary>
    member this.ProvidersDelete(accountId: string, providerId: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("provider_id", providerId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/providers/{provider_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ProvidersDelete.OK(Serializer.deserialize content)
            | 400 -> return ProvidersDelete.BadRequest(Serializer.deserialize content)
            | 401 -> return ProvidersDelete.Unauthorized(Serializer.deserialize content)
            | 403 -> return ProvidersDelete.Forbidden(Serializer.deserialize content)
            | 404 -> return ProvidersDelete.NotFound(Serializer.deserialize content)
            | _ -> return ProvidersDelete.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Read a Cloud Integration (Closed Beta).
    ///</summary>
    member this.ProvidersRead
        (
            accountId: string,
            providerId: System.Guid,
            ?status: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("provider_id", providerId)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/providers/{provider_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ProvidersRead.OK(Serializer.deserialize content)
            | 400 -> return ProvidersRead.BadRequest(Serializer.deserialize content)
            | 401 -> return ProvidersRead.Unauthorized(Serializer.deserialize content)
            | 403 -> return ProvidersRead.Forbidden(Serializer.deserialize content)
            | 404 -> return ProvidersRead.NotFound(Serializer.deserialize content)
            | _ -> return ProvidersRead.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a Cloud Integration (Closed Beta).
    ///</summary>
    member this.ProvidersPatch
        (
            accountId: string,
            providerId: System.Guid,
            body: mcnupdateproviderrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("provider_id", providerId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/providers/{provider_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ProvidersPatch.OK(Serializer.deserialize content)
            | 400 -> return ProvidersPatch.BadRequest(Serializer.deserialize content)
            | 401 -> return ProvidersPatch.Unauthorized(Serializer.deserialize content)
            | 403 -> return ProvidersPatch.Forbidden(Serializer.deserialize content)
            | 404 -> return ProvidersPatch.NotFound(Serializer.deserialize content)
            | 409 -> return ProvidersPatch.Conflict(Serializer.deserialize content)
            | 422 -> return ProvidersPatch.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return ProvidersPatch.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a Cloud Integration (Closed Beta).
    ///</summary>
    member this.ProvidersUpdate
        (
            accountId: string,
            providerId: System.Guid,
            body: mcnupdateproviderrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("provider_id", providerId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/providers/{provider_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ProvidersUpdate.OK(Serializer.deserialize content)
            | 400 -> return ProvidersUpdate.BadRequest(Serializer.deserialize content)
            | 401 -> return ProvidersUpdate.Unauthorized(Serializer.deserialize content)
            | 403 -> return ProvidersUpdate.Forbidden(Serializer.deserialize content)
            | 404 -> return ProvidersUpdate.NotFound(Serializer.deserialize content)
            | 409 -> return ProvidersUpdate.Conflict(Serializer.deserialize content)
            | 422 -> return ProvidersUpdate.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return ProvidersUpdate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Run discovery for a Cloud Integration (Closed Beta).
    ///</summary>
    member this.ProvidersDiscover
        (
            accountId: string,
            providerId: System.Guid,
            ?v2: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("provider_id", providerId)
                  if v2.IsSome then
                      RequestPart.query ("v2", v2.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/providers/{provider_id}/discover"
                    requestParts
                    cancellationToken

            match int status with
            | 202 -> return ProvidersDiscover.Accepted(Serializer.deserialize content)
            | 400 -> return ProvidersDiscover.BadRequest(Serializer.deserialize content)
            | 401 -> return ProvidersDiscover.Unauthorized(Serializer.deserialize content)
            | 403 -> return ProvidersDiscover.Forbidden(Serializer.deserialize content)
            | 404 -> return ProvidersDiscover.NotFound(Serializer.deserialize content)
            | 409 -> return ProvidersDiscover.Conflict(Serializer.deserialize content)
            | _ -> return ProvidersDiscover.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get initial configuration to complete Cloud Integration setup (Closed Beta).
    ///</summary>
    member this.ProvidersInitialSetup
        (
            accountId: string,
            providerId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("provider_id", providerId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/providers/{provider_id}/initial_setup"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ProvidersInitialSetup.OK(Serializer.deserialize content)
            | 400 -> return ProvidersInitialSetup.BadRequest(Serializer.deserialize content)
            | 401 -> return ProvidersInitialSetup.Unauthorized(Serializer.deserialize content)
            | 403 -> return ProvidersInitialSetup.Forbidden(Serializer.deserialize content)
            | 404 -> return ProvidersInitialSetup.NotFound(Serializer.deserialize content)
            | _ -> return ProvidersInitialSetup.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///List resources in the Resource Catalog (Closed Beta).
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="providerId"></param>
    ///<param name="resourceType"></param>
    ///<param name="resourceId"></param>
    ///<param name="region"></param>
    ///<param name="resourceGroup"></param>
    ///<param name="managed"></param>
    ///<param name="search"></param>
    ///<param name="orderBy">One of ["id", "resource_type", "region"].</param>
    ///<param name="desc"></param>
    ///<param name="perPage"></param>
    ///<param name="page"></param>
    ///<param name="cloudflare"></param>
    ///<param name="v2"></param>
    ///<param name="cancellationToken"></param>
    member this.ResourcesCatalogList
        (
            accountId: string,
            ?providerId: string,
            ?resourceType: list<string>,
            ?resourceId: list<System.Guid>,
            ?region: string,
            ?resourceGroup: string,
            ?managed: bool,
            ?search: list<string>,
            ?orderBy: string,
            ?desc: bool,
            ?perPage: int,
            ?page: int,
            ?cloudflare: bool,
            ?v2: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if providerId.IsSome then
                      RequestPart.query ("provider_id", providerId.Value)
                  if resourceType.IsSome then
                      RequestPart.query ("resource_type", resourceType.Value)
                  if resourceId.IsSome then
                      RequestPart.query ("resource_id", resourceId.Value)
                  if region.IsSome then
                      RequestPart.query ("region", region.Value)
                  if resourceGroup.IsSome then
                      RequestPart.query ("resource_group", resourceGroup.Value)
                  if managed.IsSome then
                      RequestPart.query ("managed", managed.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if desc.IsSome then
                      RequestPart.query ("desc", desc.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if cloudflare.IsSome then
                      RequestPart.query ("cloudflare", cloudflare.Value)
                  if v2.IsSome then
                      RequestPart.query ("v2", v2.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/resources"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ResourcesCatalogList.OK(Serializer.deserialize content)
            | 400 -> return ResourcesCatalogList.BadRequest(Serializer.deserialize content)
            | 401 -> return ResourcesCatalogList.Unauthorized(Serializer.deserialize content)
            | 403 -> return ResourcesCatalogList.Forbidden(Serializer.deserialize content)
            | 404 -> return ResourcesCatalogList.NotFound(Serializer.deserialize content)
            | _ -> return ResourcesCatalogList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Export resources in the Resource Catalog as a JSON file (Closed Beta).
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="providerId"></param>
    ///<param name="resourceType"></param>
    ///<param name="resourceId"></param>
    ///<param name="region"></param>
    ///<param name="resourceGroup"></param>
    ///<param name="search"></param>
    ///<param name="orderBy">One of ["id", "resource_type", "region"].</param>
    ///<param name="desc"></param>
    ///<param name="v2"></param>
    ///<param name="cancellationToken"></param>
    member this.ResourcesCatalogExport
        (
            accountId: string,
            ?providerId: string,
            ?resourceType: list<string>,
            ?resourceId: list<System.Guid>,
            ?region: string,
            ?resourceGroup: string,
            ?search: list<string>,
            ?orderBy: string,
            ?desc: bool,
            ?v2: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if providerId.IsSome then
                      RequestPart.query ("provider_id", providerId.Value)
                  if resourceType.IsSome then
                      RequestPart.query ("resource_type", resourceType.Value)
                  if resourceId.IsSome then
                      RequestPart.query ("resource_id", resourceId.Value)
                  if region.IsSome then
                      RequestPart.query ("region", region.Value)
                  if resourceGroup.IsSome then
                      RequestPart.query ("resource_group", resourceGroup.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if desc.IsSome then
                      RequestPart.query ("desc", desc.Value)
                  if v2.IsSome then
                      RequestPart.query ("v2", v2.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/resources/export"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ResourcesCatalogExport.OK content
            | 400 -> return ResourcesCatalogExport.BadRequest(Serializer.deserialize content)
            | 401 -> return ResourcesCatalogExport.Unauthorized(Serializer.deserialize content)
            | 403 -> return ResourcesCatalogExport.Forbidden(Serializer.deserialize content)
            | 404 -> return ResourcesCatalogExport.NotFound(Serializer.deserialize content)
            | _ -> return ResourcesCatalogExport.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Preview Rego query result against the latest resource catalog (Closed Beta).
    ///</summary>
    member this.ResourcesCatalogPolicyPreview
        (
            accountId: string,
            body: mcnresourcescatalogpolicypreviewrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/resources/policy-preview"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ResourcesCatalogPolicyPreview.OK(Serializer.deserialize content)
            | 400 -> return ResourcesCatalogPolicyPreview.BadRequest(Serializer.deserialize content)
            | 401 -> return ResourcesCatalogPolicyPreview.Unauthorized(Serializer.deserialize content)
            | 403 -> return ResourcesCatalogPolicyPreview.Forbidden(Serializer.deserialize content)
            | 422 -> return ResourcesCatalogPolicyPreview.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return ResourcesCatalogPolicyPreview.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Read an resource from the Resource Catalog (Closed Beta).
    ///</summary>
    member this.ResourcesCatalogRead
        (
            accountId: string,
            resourceId: System.Guid,
            ?v2: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("resource_id", resourceId)
                  if v2.IsSome then
                      RequestPart.query ("v2", v2.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/cloud/resources/{resource_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ResourcesCatalogRead.OK(Serializer.deserialize content)
            | 400 -> return ResourcesCatalogRead.BadRequest(Serializer.deserialize content)
            | 401 -> return ResourcesCatalogRead.Unauthorized(Serializer.deserialize content)
            | 403 -> return ResourcesCatalogRead.Forbidden(Serializer.deserialize content)
            | 404 -> return ResourcesCatalogRead.NotFound(Serializer.deserialize content)
            | _ -> return ResourcesCatalogRead.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///List Connectors
    ///</summary>
    member this.MconnConnectorList(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/magic/connectors" requestParts cancellationToken

            match int status with
            | 200 -> return MconnConnectorList.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorList.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorList.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorList.Forbidden(Serializer.deserialize content)
            | _ -> return MconnConnectorList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Add a connector to your account
    ///</summary>
    member this.MconnConnectorCreate
        (
            accountId: string,
            body: mconncustomerconnectorcreaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorCreate.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorCreate.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorCreate.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorCreate.Forbidden(Serializer.deserialize content)
            | 404 -> return MconnConnectorCreate.NotFound(Serializer.deserialize content)
            | 409 -> return MconnConnectorCreate.Conflict(Serializer.deserialize content)
            | _ -> return MconnConnectorCreate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a connector from your account
    ///</summary>
    member this.MconnConnectorDelete(accountId: string, connectorId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorDelete.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorDelete.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorDelete.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorDelete.Forbidden(Serializer.deserialize content)
            | 404 -> return MconnConnectorDelete.NotFound(Serializer.deserialize content)
            | _ -> return MconnConnectorDelete.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetch Connector
    ///</summary>
    member this.MconnConnectorFetch(accountId: string, connectorId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorFetch.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorFetch.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorFetch.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorFetch.Forbidden(Serializer.deserialize content)
            | 404 -> return MconnConnectorFetch.NotFound(Serializer.deserialize content)
            | _ -> return MconnConnectorFetch.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Edit Connector to update specific properties or Re-provision License Key
    ///</summary>
    member this.MconnConnectorUpdate
        (
            accountId: string,
            connectorId: string,
            body: mconncustomerconnectorupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorUpdate.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorUpdate.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorUpdate.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorUpdate.Forbidden(Serializer.deserialize content)
            | 404 -> return MconnConnectorUpdate.NotFound(Serializer.deserialize content)
            | _ -> return MconnConnectorUpdate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Replace Connector or Re-provision License Key
    ///</summary>
    member this.MconnConnectorReplace
        (
            accountId: string,
            connectorId: string,
            body: mconncustomerconnectorupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorReplace.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorReplace.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorReplace.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorReplace.Forbidden(Serializer.deserialize content)
            | 404 -> return MconnConnectorReplace.NotFound(Serializer.deserialize content)
            | _ -> return MconnConnectorReplace.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///List Events
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="connectorId"></param>
    ///<param name="from"></param>
    ///<param name="to"></param>
    ///<param name="limit"></param>
    ///<param name="cursor"></param>
    ///<param name="k">Filter by event kind</param>
    ///<param name="cancellationToken"></param>
    member this.MconnConnectorTelemetryEventsList
        (
            accountId: string,
            connectorId: string,
            from: float,
            ``to``: float,
            ?limit: float,
            ?cursor: string,
            ?k: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId)
                  RequestPart.query ("from", from)
                  RequestPart.query ("to", ``to``)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value)
                  if k.IsSome then
                      RequestPart.query ("k", k.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}/telemetry/events"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorTelemetryEventsList.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorTelemetryEventsList.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorTelemetryEventsList.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorTelemetryEventsList.Forbidden(Serializer.deserialize content)
            | _ -> return MconnConnectorTelemetryEventsList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get latest Events
    ///</summary>
    member this.MconnConnectorTelemetryEventsListLatest
        (
            accountId: string,
            connectorId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}/telemetry/events/latest"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorTelemetryEventsListLatest.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorTelemetryEventsListLatest.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorTelemetryEventsListLatest.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorTelemetryEventsListLatest.Forbidden(Serializer.deserialize content)
            | 404 -> return MconnConnectorTelemetryEventsListLatest.NotFound(Serializer.deserialize content)
            | _ -> return MconnConnectorTelemetryEventsListLatest.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get Event
    ///</summary>
    member this.MconnConnectorTelemetryEventsGet
        (
            accountId: string,
            connectorId: string,
            eventT: float,
            eventN: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId)
                  RequestPart.path ("event_t", eventT)
                  RequestPart.path ("event_n", eventN) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}/telemetry/events/{event_t}.{event_n}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorTelemetryEventsGet.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorTelemetryEventsGet.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorTelemetryEventsGet.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorTelemetryEventsGet.Forbidden(Serializer.deserialize content)
            | 404 -> return MconnConnectorTelemetryEventsGet.NotFound(Serializer.deserialize content)
            | _ -> return MconnConnectorTelemetryEventsGet.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///List Snapshots
    ///</summary>
    member this.MconnConnectorTelemetrySnapshotsList
        (
            accountId: string,
            connectorId: string,
            from: float,
            ``to``: float,
            ?limit: float,
            ?cursor: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId)
                  RequestPart.query ("from", from)
                  RequestPart.query ("to", ``to``)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}/telemetry/snapshots"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorTelemetrySnapshotsList.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorTelemetrySnapshotsList.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorTelemetrySnapshotsList.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorTelemetrySnapshotsList.Forbidden(Serializer.deserialize content)
            | _ -> return MconnConnectorTelemetrySnapshotsList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get latest Snapshots
    ///</summary>
    member this.MconnConnectorTelemetrySnapshotsListLatest
        (
            accountId: string,
            connectorId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}/telemetry/snapshots/latest"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorTelemetrySnapshotsListLatest.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorTelemetrySnapshotsListLatest.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorTelemetrySnapshotsListLatest.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorTelemetrySnapshotsListLatest.Forbidden(Serializer.deserialize content)
            | 404 -> return MconnConnectorTelemetrySnapshotsListLatest.NotFound(Serializer.deserialize content)
            | _ -> return MconnConnectorTelemetrySnapshotsListLatest.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get Snapshot
    ///</summary>
    member this.MconnConnectorTelemetrySnapshotsGet
        (
            accountId: string,
            connectorId: string,
            snapshotT: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("connector_id", connectorId)
                  RequestPart.path ("snapshot_t", snapshotT) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/connectors/{connector_id}/telemetry/snapshots/{snapshot_t}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MconnConnectorTelemetrySnapshotsGet.OK(Serializer.deserialize content)
            | 400 -> return MconnConnectorTelemetrySnapshotsGet.BadRequest(Serializer.deserialize content)
            | 401 -> return MconnConnectorTelemetrySnapshotsGet.Unauthorized(Serializer.deserialize content)
            | 403 -> return MconnConnectorTelemetrySnapshotsGet.Forbidden(Serializer.deserialize content)
            | 404 -> return MconnConnectorTelemetrySnapshotsGet.NotFound(Serializer.deserialize content)
            | _ -> return MconnConnectorTelemetrySnapshotsGet.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists GRE tunnels associated with an account.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the response body will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicGreTunnelsListGreTunnels
        (
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/gre_tunnels"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicGreTunnelsListGreTunnels.OK(Serializer.deserialize content)
            | _ -> return MagicGreTunnelsListGreTunnels.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new GRE tunnel. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the request and response bodies will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicGreTunnelsCreateGreTunnels
        (
            accountId: string,
            body: magiccreategretunnelrequest,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/gre_tunnels"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicGreTunnelsCreateGreTunnels.OK(Serializer.deserialize content)
            | _ -> return MagicGreTunnelsCreateGreTunnels.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates multiple GRE tunnels. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the request and response bodies will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicGreTunnelsUpdateMultipleGreTunnels
        (
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/gre_tunnels"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicGreTunnelsUpdateMultipleGreTunnels.OK(Serializer.deserialize content)
            | _ -> return MagicGreTunnelsUpdateMultipleGreTunnels.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Disables and removes a specific static GRE tunnel. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="greTunnelId"></param>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the response body will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicGreTunnelsDeleteGreTunnel
        (
            greTunnelId: string,
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("gre_tunnel_id", greTunnelId)
                  RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/gre_tunnels/{gre_tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicGreTunnelsDeleteGreTunnel.OK(Serializer.deserialize content)
            | _ -> return MagicGreTunnelsDeleteGreTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists informtion for a specific GRE tunnel.
    ///</summary>
    ///<param name="greTunnelId"></param>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the response body will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicGreTunnelsListGreTunnelDetails
        (
            greTunnelId: string,
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("gre_tunnel_id", greTunnelId)
                  RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/gre_tunnels/{gre_tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicGreTunnelsListGreTunnelDetails.OK(Serializer.deserialize content)
            | _ -> return MagicGreTunnelsListGreTunnelDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a specific GRE tunnel. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="greTunnelId"></param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the request and response bodies will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicGreTunnelsUpdateGreTunnel
        (
            greTunnelId: string,
            accountId: string,
            body: magicgretunnelupdaterequest,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("gre_tunnel_id", greTunnelId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/gre_tunnels/{gre_tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicGreTunnelsUpdateGreTunnel.OK(Serializer.deserialize content)
            | _ -> return MagicGreTunnelsUpdateGreTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists IPsec tunnels associated with an account.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the response body will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicIpsecTunnelsListIpsecTunnels
        (
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/ipsec_tunnels"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicIpsecTunnelsListIpsecTunnels.OK(Serializer.deserialize content)
            | _ -> return MagicIpsecTunnelsListIpsecTunnels.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new IPsec tunnel associated with an account. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the request and response bodies will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicIpsecTunnelsCreateIpsecTunnels
        (
            accountId: string,
            body: magicipsectunneladdrequest,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/ipsec_tunnels"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicIpsecTunnelsCreateIpsecTunnels.OK(Serializer.deserialize content)
            | _ -> return MagicIpsecTunnelsCreateIpsecTunnels.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update multiple IPsec tunnels associated with an account. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the request and response bodies will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicIpsecTunnelsUpdateMultipleIpsecTunnels
        (
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/ipsec_tunnels"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicIpsecTunnelsUpdateMultipleIpsecTunnels.OK(Serializer.deserialize content)
            | _ -> return MagicIpsecTunnelsUpdateMultipleIpsecTunnels.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Disables and removes a specific static IPsec Tunnel associated with an account. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="ipsecTunnelId"></param>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the response body will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicIpsecTunnelsDeleteIpsecTunnel
        (
            ipsecTunnelId: string,
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("ipsec_tunnel_id", ipsecTunnelId)
                  RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/ipsec_tunnels/{ipsec_tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicIpsecTunnelsDeleteIpsecTunnel.OK(Serializer.deserialize content)
            | _ -> return MagicIpsecTunnelsDeleteIpsecTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists details for a specific IPsec tunnel.
    ///</summary>
    ///<param name="ipsecTunnelId"></param>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the response body will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicIpsecTunnelsListIpsecTunnelDetails
        (
            ipsecTunnelId: string,
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("ipsec_tunnel_id", ipsecTunnelId)
                  RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/ipsec_tunnels/{ipsec_tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicIpsecTunnelsListIpsecTunnelDetails.OK(Serializer.deserialize content)
            | _ -> return MagicIpsecTunnelsListIpsecTunnelDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a specific IPsec tunnel associated with an account. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes.
    ///</summary>
    ///<param name="ipsecTunnelId"></param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the request and response bodies will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicIpsecTunnelsUpdateIpsecTunnel
        (
            ipsecTunnelId: string,
            accountId: string,
            body: magicipsectunneladdsinglerequest,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("ipsec_tunnel_id", ipsecTunnelId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/ipsec_tunnels/{ipsec_tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicIpsecTunnelsUpdateIpsecTunnel.OK(Serializer.deserialize content)
            | _ -> return MagicIpsecTunnelsUpdateIpsecTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Generates a Pre Shared Key for a specific IPsec tunnel used in the IKE session. Use `?validate_only=true` as an optional query parameter to only run validation without persisting changes. After a PSK is generated, the PSK is immediately persisted to Cloudflare's edge and cannot be retrieved later. Note the PSK in a safe place.
    ///</summary>
    member this.``MagicIpsecTunnelsGeneratePreSharedKey(Psk)ForIpsecTunnels``
        (
            ipsecTunnelId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("ipsec_tunnel_id", ipsecTunnelId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/ipsec_tunnels/{ipsec_tunnel_id}/psk_generate"
                    requestParts
                    cancellationToken

            match int status with
            | 200 ->
                return ``MagicIpsecTunnelsGeneratePreSharedKey(Psk)ForIpsecTunnels``.OK(Serializer.deserialize content)
            | _ ->
                return
                    ``MagicIpsecTunnelsGeneratePreSharedKey(Psk)ForIpsecTunnels``.BadRequest(
                        Serializer.deserialize content
                    )
        }

    ///<summary>
    ///Delete multiple Magic static routes.
    ///</summary>
    member this.MagicStaticRoutesDeleteManyRoutes
        (
            accountId: string,
            body: magicroutedeletemanyrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.deleteAsync httpClient "/accounts/{account_id}/magic/routes" requestParts cancellationToken

            match int status with
            | 200 -> return MagicStaticRoutesDeleteManyRoutes.OK(Serializer.deserialize content)
            | _ -> return MagicStaticRoutesDeleteManyRoutes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List all Magic static routes.
    ///</summary>
    member this.MagicStaticRoutesListRoutes(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/magic/routes" requestParts cancellationToken

            match int status with
            | 200 -> return MagicStaticRoutesListRoutes.OK(Serializer.deserialize content)
            | _ -> return MagicStaticRoutesListRoutes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Magic static route. Use `?validate_only=true` as an optional query parameter to run validation only without persisting changes.
    ///</summary>
    member this.MagicStaticRoutesCreateRoutes
        (
            accountId: string,
            body: magiccreaterouterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/magic/routes" requestParts cancellationToken

            match int status with
            | 200 -> return MagicStaticRoutesCreateRoutes.OK(Serializer.deserialize content)
            | _ -> return MagicStaticRoutesCreateRoutes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update multiple Magic static routes. Use `?validate_only=true` as an optional query parameter to run validation only without persisting changes. Only fields for a route that need to be changed need be provided.
    ///</summary>
    member this.MagicStaticRoutesUpdateManyRoutes
        (
            accountId: string,
            body: magicrouteupdatemanyrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync httpClient "/accounts/{account_id}/magic/routes" requestParts cancellationToken

            match int status with
            | 200 -> return MagicStaticRoutesUpdateManyRoutes.OK(Serializer.deserialize content)
            | _ -> return MagicStaticRoutesUpdateManyRoutes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Disable and remove a specific Magic static route.
    ///</summary>
    member this.MagicStaticRoutesDeleteRoute
        (
            routeId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("route_id", routeId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/routes/{route_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicStaticRoutesDeleteRoute.OK(Serializer.deserialize content)
            | _ -> return MagicStaticRoutesDeleteRoute.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a specific Magic static route.
    ///</summary>
    member this.MagicStaticRoutesRouteDetails
        (
            routeId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("route_id", routeId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/routes/{route_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicStaticRoutesRouteDetails.OK(Serializer.deserialize content)
            | _ -> return MagicStaticRoutesRouteDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a specific Magic static route. Use `?validate_only=true` as an optional query parameter to run validation only without persisting changes.
    ///</summary>
    member this.MagicStaticRoutesUpdateRoute
        (
            routeId: string,
            accountId: string,
            body: magicrouteupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("route_id", routeId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/routes/{route_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicStaticRoutesUpdateRoute.OK(Serializer.deserialize content)
            | _ -> return MagicStaticRoutesUpdateRoute.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists Sites associated with an account. Use connectorid query param to return sites where connectorid matches either site.ConnectorID or site.SecondaryConnectorID.
    ///</summary>
    member this.MagicSitesListSites(accountId: string, ?connectorid: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if connectorid.IsSome then
                      RequestPart.query ("connectorid", connectorid.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/magic/sites" requestParts cancellationToken

            match int status with
            | 200 -> return MagicSitesListSites.OK(Serializer.deserialize content)
            | _ -> return MagicSitesListSites.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Site
    ///</summary>
    member this.MagicSitesCreateSite
        (
            accountId: string,
            body: magicsitesaddsinglerequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/magic/sites" requestParts cancellationToken

            match int status with
            | 200 -> return MagicSitesCreateSite.OK(Serializer.deserialize content)
            | _ -> return MagicSitesCreateSite.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a specific Site.
    ///</summary>
    member this.MagicSitesDeleteSite(siteId: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSitesDeleteSite.OK(Serializer.deserialize content)
            | _ -> return MagicSitesDeleteSite.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a specific Site.
    ///</summary>
    ///<param name="siteId"></param>
    ///<param name="accountId"></param>
    ///<param name="xMagicNewHcTarget">If true, the health check target in the response body will be presented using the new object format. Defaults to false.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicSitesSiteDetails
        (
            siteId: string,
            accountId: string,
            ?xMagicNewHcTarget: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  if xMagicNewHcTarget.IsSome then
                      RequestPart.header ("x-magic-new-hc-target", xMagicNewHcTarget.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSitesSiteDetails.OK(Serializer.deserialize content)
            | _ -> return MagicSitesSiteDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Patch a specific Site.
    ///</summary>
    member this.MagicSitesPatchSite
        (
            siteId: string,
            accountId: string,
            body: magicsiteupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSitesPatchSite.OK(Serializer.deserialize content)
            | _ -> return MagicSitesPatchSite.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a specific Site.
    ///</summary>
    member this.MagicSitesUpdateSite
        (
            siteId: string,
            accountId: string,
            body: magicsiteupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSitesUpdateSite.OK(Serializer.deserialize content)
            | _ -> return MagicSitesUpdateSite.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists Site ACLs associated with an account.
    ///</summary>
    member this.MagicSiteAclsListAcls(accountId: string, siteId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/acls"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAclsListAcls.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAclsListAcls.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Site ACL.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="siteId"></param>
    ///<param name="body">Bidirectional ACL policy for local network traffic within a site.</param>
    ///<param name="cancellationToken"></param>
    member this.MagicSiteAclsCreateAcl
        (
            accountId: string,
            siteId: string,
            body: magicaclsaddsinglerequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/acls"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAclsCreateAcl.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAclsCreateAcl.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a specific Site ACL.
    ///</summary>
    member this.MagicSiteAclsDeleteAcl
        (
            siteId: string,
            accountId: string,
            aclId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("acl_id", aclId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/acls/{acl_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAclsDeleteAcl.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAclsDeleteAcl.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a specific Site ACL.
    ///</summary>
    member this.MagicSiteAclsAclDetails
        (
            siteId: string,
            accountId: string,
            aclId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("acl_id", aclId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/acls/{acl_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAclsAclDetails.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAclsAclDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Patch a specific Site ACL.
    ///</summary>
    member this.MagicSiteAclsPatchAcl
        (
            siteId: string,
            accountId: string,
            aclId: string,
            body: magicaclupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("acl_id", aclId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/acls/{acl_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAclsPatchAcl.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAclsPatchAcl.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a specific Site ACL.
    ///</summary>
    member this.MagicSiteAclsUpdateAcl
        (
            siteId: string,
            accountId: string,
            aclId: string,
            body: magicaclupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("acl_id", aclId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/acls/{acl_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAclsUpdateAcl.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAclsUpdateAcl.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists App Configs associated with a site.
    ///</summary>
    member this.MagicSiteAppConfigsListAppConfigs
        (
            accountId: string,
            siteId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/app_configs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAppConfigsListAppConfigs.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAppConfigsListAppConfigs.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new App Config for a site
    ///</summary>
    member this.MagicSiteAppConfigsAddAppConfig
        (
            accountId: string,
            siteId: string,
            body: magicappconfigaddsinglerequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/app_configs"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return MagicSiteAppConfigsAddAppConfig.Created(Serializer.deserialize content)
            | _ -> return MagicSiteAppConfigsAddAppConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes specific App Config associated with a site.
    ///</summary>
    member this.MagicSiteAppConfigsDeleteAppConfig
        (
            accountId: string,
            siteId: string,
            appConfigId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.path ("app_config_id", appConfigId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/app_configs/{app_config_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAppConfigsDeleteAppConfig.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAppConfigsDeleteAppConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an App Config for a site
    ///</summary>
    member this.MagicSiteAppConfigsPatchAppConfig
        (
            accountId: string,
            siteId: string,
            appConfigId: string,
            body: magicappconfigupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.path ("app_config_id", appConfigId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/app_configs/{app_config_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAppConfigsPatchAppConfig.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAppConfigsPatchAppConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an App Config for a site
    ///</summary>
    member this.MagicSiteAppConfigsUpdateAppConfig
        (
            accountId: string,
            siteId: string,
            appConfigId: string,
            body: magicappconfigupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.path ("app_config_id", appConfigId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/app_configs/{app_config_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteAppConfigsUpdateAppConfig.OK(Serializer.deserialize content)
            | _ -> return MagicSiteAppConfigsUpdateAppConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists Site LANs associated with an account.
    ///</summary>
    member this.MagicSiteLansListLans(accountId: string, siteId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/lans"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteLansListLans.OK(Serializer.deserialize content)
            | _ -> return MagicSiteLansListLans.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Site LAN. If the site is in high availability mode, static_addressing is required along with secondary and virtual address.
    ///</summary>
    member this.MagicSiteLansCreateLan
        (
            accountId: string,
            siteId: string,
            body: magiclansaddsinglerequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/lans"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteLansCreateLan.OK(Serializer.deserialize content)
            | _ -> return MagicSiteLansCreateLan.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a specific Site LAN.
    ///</summary>
    member this.MagicSiteLansDeleteLan
        (
            siteId: string,
            accountId: string,
            lanId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("lan_id", lanId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/lans/{lan_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteLansDeleteLan.OK(Serializer.deserialize content)
            | _ -> return MagicSiteLansDeleteLan.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a specific Site LAN.
    ///</summary>
    member this.MagicSiteLansLanDetails
        (
            siteId: string,
            accountId: string,
            lanId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("lan_id", lanId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/lans/{lan_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteLansLanDetails.OK(Serializer.deserialize content)
            | _ -> return MagicSiteLansLanDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Patch a specific Site LAN.
    ///</summary>
    member this.MagicSiteLansPatchLan
        (
            siteId: string,
            accountId: string,
            lanId: string,
            body: magiclanupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("lan_id", lanId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/lans/{lan_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteLansPatchLan.OK(Serializer.deserialize content)
            | _ -> return MagicSiteLansPatchLan.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a specific Site LAN.
    ///</summary>
    member this.MagicSiteLansUpdateLan
        (
            siteId: string,
            accountId: string,
            lanId: string,
            body: magiclanupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("lan_id", lanId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/lans/{lan_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteLansUpdateLan.OK(Serializer.deserialize content)
            | _ -> return MagicSiteLansUpdateLan.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove NetFlow configuration for a site.
    ///</summary>
    member this.MagicSiteNetflowConfigDeleteNetflowConfig
        (
            accountId: string,
            siteId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/netflow_config"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteNetflowConfigDeleteNetflowConfig.OK(Serializer.deserialize content)
            | _ -> return MagicSiteNetflowConfigDeleteNetflowConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get NetFlow configuration for a site.
    ///</summary>
    member this.MagicSiteNetflowConfigDetails
        (
            accountId: string,
            siteId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/netflow_config"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteNetflowConfigDetails.OK(Serializer.deserialize content)
            | _ -> return MagicSiteNetflowConfigDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates NetFlow configuration for a site.
    ///</summary>
    member this.MagicSiteNetflowConfigPatchNetflowConfig
        (
            accountId: string,
            siteId: string,
            body: magicnetflowconfigrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/netflow_config"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteNetflowConfigPatchNetflowConfig.OK(Serializer.deserialize content)
            | _ -> return MagicSiteNetflowConfigPatchNetflowConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a NetFlow configuration for a site.
    ///</summary>
    member this.MagicSiteNetflowConfigCreateNetflowConfig
        (
            accountId: string,
            siteId: string,
            body: magicnetflowconfigrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/netflow_config"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return MagicSiteNetflowConfigCreateNetflowConfig.Created(Serializer.deserialize content)
            | _ -> return MagicSiteNetflowConfigCreateNetflowConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates NetFlow configuration for a site (partial update).
    ///</summary>
    member this.MagicSiteNetflowConfigUpdateNetflowConfig
        (
            accountId: string,
            siteId: string,
            body: magicnetflowconfigrequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/netflow_config"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteNetflowConfigUpdateNetflowConfig.OK(Serializer.deserialize content)
            | _ -> return MagicSiteNetflowConfigUpdateNetflowConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists Site WANs associated with an account.
    ///</summary>
    member this.MagicSiteWansListWans(accountId: string, siteId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/wans"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteWansListWans.OK(Serializer.deserialize content)
            | _ -> return MagicSiteWansListWans.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Site WAN.
    ///</summary>
    member this.MagicSiteWansCreateWan
        (
            accountId: string,
            siteId: string,
            body: magicwansaddsinglerequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("site_id", siteId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/wans"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteWansCreateWan.OK(Serializer.deserialize content)
            | _ -> return MagicSiteWansCreateWan.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a specific Site WAN.
    ///</summary>
    member this.MagicSiteWansDeleteWan
        (
            siteId: string,
            accountId: string,
            wanId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("wan_id", wanId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/wans/{wan_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteWansDeleteWan.OK(Serializer.deserialize content)
            | _ -> return MagicSiteWansDeleteWan.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a specific Site WAN.
    ///</summary>
    member this.MagicSiteWansWanDetails
        (
            siteId: string,
            accountId: string,
            wanId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("wan_id", wanId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/wans/{wan_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteWansWanDetails.OK(Serializer.deserialize content)
            | _ -> return MagicSiteWansWanDetails.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Patch a specific Site WAN.
    ///</summary>
    member this.MagicSiteWansPatchWan
        (
            siteId: string,
            accountId: string,
            wanId: string,
            body: magicwanupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("wan_id", wanId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/wans/{wan_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteWansPatchWan.OK(Serializer.deserialize content)
            | _ -> return MagicSiteWansPatchWan.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Update a specific Site WAN.
    ///</summary>
    member this.MagicSiteWansUpdateWan
        (
            siteId: string,
            accountId: string,
            wanId: string,
            body: magicwanupdaterequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("site_id", siteId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("wan_id", wanId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/magic/sites/{site_id}/wans/{wan_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MagicSiteWansUpdateWan.OK(Serializer.deserialize content)
            | _ -> return MagicSiteWansUpdateWan.BadRequest(Serializer.deserialize content)
        }
