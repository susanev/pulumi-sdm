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
    public sealed class GetResourceResourceDynamoDbResult
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
        public readonly string? Endpoint;
        /// <summary>
        /// Unique identifier of the Resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string? Name;
        public readonly int? PortOverride;
        public readonly string? Region;
        public readonly string? RoleArn;
        public readonly string? RoleExternalId;
        public readonly string? SecretAccessKey;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetResourceResourceDynamoDbResult(
            string? accessKey,

            string? bindInterface,

            string? egressFilter,

            string? endpoint,

            string? id,

            string? name,

            int? portOverride,

            string? region,

            string? roleArn,

            string? roleExternalId,

            string? secretAccessKey,

            string? secretStoreId,

            ImmutableDictionary<string, string>? tags)
        {
            AccessKey = accessKey;
            BindInterface = bindInterface;
            EgressFilter = egressFilter;
            Endpoint = endpoint;
            Id = id;
            Name = name;
            PortOverride = portOverride;
            Region = region;
            RoleArn = roleArn;
            RoleExternalId = roleExternalId;
            SecretAccessKey = secretAccessKey;
            SecretStoreId = secretStoreId;
            Tags = tags;
        }
    }
}
