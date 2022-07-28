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

    public sealed class ResourceMongoReplicaSetArgs : Pulumi.ResourceArgs
    {
        [Input("authDatabase", required: true)]
        public Input<string> AuthDatabase { get; set; } = null!;

        /// <summary>
        /// Bind interface
        /// </summary>
        [Input("bindInterface")]
        public Input<string>? BindInterface { get; set; }

        [Input("connectToReplica")]
        public Input<bool>? ConnectToReplica { get; set; }

        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        [Input("egressFilter")]
        public Input<string>? EgressFilter { get; set; }

        [Input("hostname", required: true)]
        public Input<string> Hostname { get; set; } = null!;

        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("password")]
        public Input<string>? Password { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("portOverride")]
        public Input<int>? PortOverride { get; set; }

        [Input("replicaSet", required: true)]
        public Input<string> ReplicaSet { get; set; } = null!;

        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        [Input("secretStoreId")]
        public Input<string>? SecretStoreId { get; set; }

        [Input("secretStorePasswordKey")]
        public Input<string>? SecretStorePasswordKey { get; set; }

        [Input("secretStorePasswordPath")]
        public Input<string>? SecretStorePasswordPath { get; set; }

        [Input("secretStoreUsernameKey")]
        public Input<string>? SecretStoreUsernameKey { get; set; }

        [Input("secretStoreUsernamePath")]
        public Input<string>? SecretStoreUsernamePath { get; set; }

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

        [Input("tlsRequired")]
        public Input<bool>? TlsRequired { get; set; }

        [Input("username")]
        public Input<string>? Username { get; set; }

        public ResourceMongoReplicaSetArgs()
        {
        }
    }
}
