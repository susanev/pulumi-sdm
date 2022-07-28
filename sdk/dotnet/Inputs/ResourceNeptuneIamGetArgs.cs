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

    public sealed class ResourceNeptuneIamGetArgs : Pulumi.ResourceArgs
    {
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        /// <summary>
        /// Bind interface
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        [Input("endpoint", required: true)]
        public Input<string> Endpoint { get; set; } = null!;

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("portOverride")]
        public Input<int>? PortOverride { get; set; }

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

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

        public ResourceNeptuneIamGetArgs()
        {
        }
    }
}
