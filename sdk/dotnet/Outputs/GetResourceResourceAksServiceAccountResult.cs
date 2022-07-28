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
    public sealed class GetResourceResourceAksServiceAccountResult
    {
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        public readonly string? HealthcheckNamespace;
        public readonly string? Hostname;
        /// <summary>
        /// Unique identifier of the Resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string? Name;
        public readonly int? Port;
        public readonly string? RemoteIdentityGroupId;
        public readonly string? RemoteIdentityHealthcheckUsername;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// * kubernetes_user_impersonation:
        /// </summary>
        public readonly string? Token;

        [OutputConstructor]
        private GetResourceResourceAksServiceAccountResult(
            string? bindInterface,

            string? egressFilter,

            string? healthcheckNamespace,

            string? hostname,

            string? id,

            string? name,

            int? port,

            string? remoteIdentityGroupId,

            string? remoteIdentityHealthcheckUsername,

            string? secretStoreId,

            ImmutableDictionary<string, string>? tags,

            string? token)
        {
            BindInterface = bindInterface;
            EgressFilter = egressFilter;
            HealthcheckNamespace = healthcheckNamespace;
            Hostname = hostname;
            Id = id;
            Name = name;
            Port = port;
            RemoteIdentityGroupId = remoteIdentityGroupId;
            RemoteIdentityHealthcheckUsername = remoteIdentityHealthcheckUsername;
            SecretStoreId = secretStoreId;
            Tags = tags;
            Token = token;
        }
    }
}
