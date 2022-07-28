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
    public sealed class GetResourceResourceAzureCertificateResult
    {
        public readonly string? AppId;
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        public readonly string? ClientCertificate;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// Unique identifier of the Resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// * azure_postgres:
        /// </summary>
        public readonly string? TenantId;

        [OutputConstructor]
        private GetResourceResourceAzureCertificateResult(
            string? appId,

            string? bindInterface,

            string? clientCertificate,

            string? egressFilter,

            string? id,

            string? name,

            string? secretStoreId,

            ImmutableDictionary<string, string>? tags,

            string? tenantId)
        {
            AppId = appId;
            BindInterface = bindInterface;
            ClientCertificate = clientCertificate;
            EgressFilter = egressFilter;
            Id = id;
            Name = name;
            SecretStoreId = secretStoreId;
            Tags = tags;
            TenantId = tenantId;
        }
    }
}
