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
    public sealed class SecretStoreAws
    {
        /// <summary>
        /// Unique human-readable name of the SecretStore.
        /// </summary>
        public readonly string Name;
        public readonly string Region;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private SecretStoreAws(
            string name,

            string region,

            ImmutableDictionary<string, string>? tags)
        {
            Name = name;
            Region = region;
            Tags = tags;
        }
    }
}
