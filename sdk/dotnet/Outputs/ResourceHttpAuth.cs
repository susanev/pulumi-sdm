// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm.Outputs
{

    [OutputType]
    public sealed class ResourceHttpAuth
    {
        public readonly string? AuthHeader;
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        public readonly string? DefaultPath;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        public readonly string? HeadersBlacklist;
        public readonly string HealthcheckPath;
        public readonly string? HostOverride;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        public readonly string Subdomain;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// * kubernetes:
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private ResourceHttpAuth(
            string? authHeader,

            string? bindInterface,

            string? defaultPath,

            string? egressFilter,

            string? headersBlacklist,

            string healthcheckPath,

            string? hostOverride,

            string name,

            string? secretStoreId,

            string subdomain,

            ImmutableDictionary<string, string>? tags,

            string url)
        {
            AuthHeader = authHeader;
            BindInterface = bindInterface;
            DefaultPath = defaultPath;
            EgressFilter = egressFilter;
            HeadersBlacklist = headersBlacklist;
            HealthcheckPath = healthcheckPath;
            HostOverride = hostOverride;
            Name = name;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
            Url = url;
        }
    }
}
