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
    public sealed class ResourceAws
    {
        public readonly string? AccessKey;
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        public readonly string HealthcheckRegion;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
        public readonly string? RoleArn;
        public readonly string? RoleExternalId;
        public readonly string? SecretAccessKey;
        public readonly string? SecretStoreAccessKeyKey;
        public readonly string? SecretStoreAccessKeyPath;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        public readonly string? SecretStoreRoleArnKey;
        public readonly string? SecretStoreRoleArnPath;
        public readonly string? SecretStoreRoleExternalIdKey;
        public readonly string? SecretStoreRoleExternalIdPath;
        public readonly string? SecretStoreSecretAccessKeyKey;
        public readonly string? SecretStoreSecretAccessKeyPath;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private ResourceAws(
            string? accessKey,

            string? bindInterface,

            string? egressFilter,

            string healthcheckRegion,

            string name,

            string? roleArn,

            string? roleExternalId,

            string? secretAccessKey,

            string? secretStoreAccessKeyKey,

            string? secretStoreAccessKeyPath,

            string? secretStoreId,

            string? secretStoreRoleArnKey,

            string? secretStoreRoleArnPath,

            string? secretStoreRoleExternalIdKey,

            string? secretStoreRoleExternalIdPath,

            string? secretStoreSecretAccessKeyKey,

            string? secretStoreSecretAccessKeyPath,

            ImmutableDictionary<string, string>? tags)
        {
            AccessKey = accessKey;
            BindInterface = bindInterface;
            EgressFilter = egressFilter;
            HealthcheckRegion = healthcheckRegion;
            Name = name;
            RoleArn = roleArn;
            RoleExternalId = roleExternalId;
            SecretAccessKey = secretAccessKey;
            SecretStoreAccessKeyKey = secretStoreAccessKeyKey;
            SecretStoreAccessKeyPath = secretStoreAccessKeyPath;
            SecretStoreId = secretStoreId;
            SecretStoreRoleArnKey = secretStoreRoleArnKey;
            SecretStoreRoleArnPath = secretStoreRoleArnPath;
            SecretStoreRoleExternalIdKey = secretStoreRoleExternalIdKey;
            SecretStoreRoleExternalIdPath = secretStoreRoleExternalIdPath;
            SecretStoreSecretAccessKeyKey = secretStoreSecretAccessKeyKey;
            SecretStoreSecretAccessKeyPath = secretStoreSecretAccessKeyPath;
            Tags = tags;
        }
    }
}
