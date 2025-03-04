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
    public sealed class GetResourceResourceSshResult
    {
        public readonly bool? AllowDeprecatedKeyExchanges;
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        public readonly string? Hostname;
        /// <summary>
        /// Unique identifier of the Resource.
        /// </summary>
        public readonly string? Id;
        public readonly string? KeyType;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string? Name;
        public readonly int? Port;
        public readonly bool? PortForwarding;
        public readonly int? PortOverride;
        public readonly string PublicKey;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        public readonly string? Subdomain;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        public readonly string? Username;

        [OutputConstructor]
        private GetResourceResourceSshResult(
            bool? allowDeprecatedKeyExchanges,

            string? bindInterface,

            string? egressFilter,

            string? hostname,

            string? id,

            string? keyType,

            string? name,

            int? port,

            bool? portForwarding,

            int? portOverride,

            string publicKey,

            string? secretStoreId,

            string? subdomain,

            ImmutableDictionary<string, string>? tags,

            string? username)
        {
            AllowDeprecatedKeyExchanges = allowDeprecatedKeyExchanges;
            BindInterface = bindInterface;
            EgressFilter = egressFilter;
            Hostname = hostname;
            Id = id;
            KeyType = keyType;
            Name = name;
            Port = port;
            PortForwarding = portForwarding;
            PortOverride = portOverride;
            PublicKey = publicKey;
            SecretStoreId = secretStoreId;
            Subdomain = subdomain;
            Tags = tags;
            Username = username;
        }
    }
}
