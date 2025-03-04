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

    public sealed class NodeRelayArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Device is a read only device name uploaded by the gateway process when  it comes online.
        /// </summary>
        [Input("device")]
        public Input<string>? Device { get; set; }

        /// <summary>
        /// GatewayFilter can be used to restrict the peering between relays and gateways.
        /// </summary>
        [Input("gatewayFilter")]
        public Input<string>? GatewayFilter { get; set; }

        /// <summary>
        /// Location is a read only network location uploaded by the gateway process when it comes online.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Unique human-readable name of the Relay. Node names must include only letters, numbers, and hyphens (no spaces, underscores, or other special characters). Generated if not provided on create.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

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

        [Input("token")]
        private Input<string>? _token;
        public Input<string>? Token
        {
            get => _token;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _token = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Version is a read only sdm binary version uploaded by the gateway process when it comes online.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public NodeRelayArgs()
        {
        }
        public static new NodeRelayArgs Empty => new NodeRelayArgs();
    }
}
