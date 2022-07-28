// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm.Inputs
{

    public sealed class ResourceAmazonEksGetArgs : Pulumi.ResourceArgs
    {
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        /// <summary>
        /// Bind interface
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        [Input("certificateAuthority")]
        public Input<string>? CertificateAuthority { get; set; }

        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        [Input("endpoint", required: true)]
        public Input<string> Endpoint { get; set; } = null!;

        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        [Input("healthcheckNamespace")]
        public Input<string>? HealthcheckNamespace { get; set; }

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("remoteIdentityGroupId")]
        public Input<string>? RemoteIdentityGroupId { get; set; }

        [Input("remoteIdentityHealthcheckUsername")]
        public Input<string>? RemoteIdentityHealthcheckUsername { get; set; }

        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        [Input("roleExternalId")]
        public Input<string>? RoleExternalId { get; set; }

        [Input("secretAccessKey")]
        public Input<string>? SecretAccessKey { get; set; }

        [Input("secretStoreAccessKeyKey")]
        public Input<string>? SecretStoreAccessKeyKey { get; set; }

        [Input("secretStoreAccessKeyPath")]
        public Input<string>? SecretStoreAccessKeyPath { get; set; }

        [Input("secretStoreCertificateAuthorityKey")]
        public Input<string>? SecretStoreCertificateAuthorityKey { get; set; }

        [Input("secretStoreCertificateAuthorityPath")]
        public Input<string>? SecretStoreCertificateAuthorityPath { get; set; }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

        [Input("secretStoreRoleArnKey")]
        public Input<string>? SecretStoreRoleArnKey { get; set; }

        [Input("secretStoreRoleArnPath")]
        public Input<string>? SecretStoreRoleArnPath { get; set; }

        [Input("secretStoreRoleExternalIdKey")]
        public Input<string>? SecretStoreRoleExternalIdKey { get; set; }

        [Input("secretStoreRoleExternalIdPath")]
        public Input<string>? SecretStoreRoleExternalIdPath { get; set; }

        [Input("secretStoreSecretAccessKeyKey")]
        public Input<string>? SecretStoreSecretAccessKeyKey { get; set; }

        [Input("secretStoreSecretAccessKeyPath")]
        public Input<string>? SecretStoreSecretAccessKeyPath { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ResourceAmazonEksGetArgs()
        {
        }
    }
}
