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

    public sealed class ResourceAksGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bind interface
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        [Input("certificateAuthority")]
        public Input<string>? CertificateAuthority { get; set; }

        [Input("clientCertificate")]
        public Input<string>? ClientCertificate { get; set; }

        [Input("clientKey")]
        public Input<string>? ClientKey { get; set; }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        [Input("healthcheckNamespace")]
        public Input<string>? HealthcheckNamespace { get; set; }

        [Input("hostname", required: true)]
        public Input<string> Hostname { get; set; } = null!;

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("portOverride")]
        public Input<int>? PortOverride { get; set; }

        [Input("remoteIdentityGroupId")]
        public Input<string>? RemoteIdentityGroupId { get; set; }

        [Input("remoteIdentityHealthcheckUsername")]
        public Input<string>? RemoteIdentityHealthcheckUsername { get; set; }

        [Input("secretStoreCertificateAuthorityKey")]
        public Input<string>? SecretStoreCertificateAuthorityKey { get; set; }

        [Input("secretStoreCertificateAuthorityPath")]
        public Input<string>? SecretStoreCertificateAuthorityPath { get; set; }

        [Input("secretStoreClientCertificateKey")]
        public Input<string>? SecretStoreClientCertificateKey { get; set; }

        [Input("secretStoreClientCertificatePath")]
        public Input<string>? SecretStoreClientCertificatePath { get; set; }

        [Input("secretStoreClientKeyKey")]
        public Input<string>? SecretStoreClientKeyKey { get; set; }

        [Input("secretStoreClientKeyPath")]
        public Input<string>? SecretStoreClientKeyPath { get; set; }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

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

        public ResourceAksGetArgs()
        {
        }
    }
}
