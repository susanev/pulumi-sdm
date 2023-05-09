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

    public sealed class ResourceAzureCertificateArgs : global::Pulumi.ResourceArgs
    {
        [Input("appId")]
        public Input<string>? AppId { get; set; }

        /// <summary>
        /// Bind interface
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        [Input("clientCertificate")]
        private Input<string>? _clientCertificate;
        public Input<string>? ClientCertificate
        {
            get => _clientCertificate;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _clientCertificate = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("portOverride")]
        public Input<int>? PortOverride { get; set; }

        [Input("secretStoreAppIdKey")]
        public Input<string>? SecretStoreAppIdKey { get; set; }

        [Input("secretStoreAppIdPath")]
        public Input<string>? SecretStoreAppIdPath { get; set; }

        [Input("secretStoreClientCertificateKey")]
        public Input<string>? SecretStoreClientCertificateKey { get; set; }

        [Input("secretStoreClientCertificatePath")]
        public Input<string>? SecretStoreClientCertificatePath { get; set; }

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

        /// <summary>
        /// * azure_mysql:
        /// </summary>
        [Input("secretStoreTenantIdKey")]
        public Input<string>? SecretStoreTenantIdKey { get; set; }

        [Input("secretStoreTenantIdPath")]
        public Input<string>? SecretStoreTenantIdPath { get; set; }

        /// <summary>
        /// Subdomain is the local DNS address.  (e.g. app-prod1 turns into app-prod1.your-org-name.sdm.network)
        /// </summary>
        [Input("subdomain")]
        public Input<string>? Subdomain { get; set; }

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

        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        public ResourceAzureCertificateArgs()
        {
        }
        public static new ResourceAzureCertificateArgs Empty => new ResourceAzureCertificateArgs();
    }
}
