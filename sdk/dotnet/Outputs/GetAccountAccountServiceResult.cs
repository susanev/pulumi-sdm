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
    public sealed class GetAccountAccountServiceResult
    {
        /// <summary>
        /// Unique identifier of the User.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Unique human-readable name of the Service.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The User's suspended state.
        /// </summary>
        public readonly bool? Suspended;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetAccountAccountServiceResult(
            string? id,

            string? name,

            bool? suspended,

            ImmutableDictionary<string, string>? tags)
        {
            Id = id;
            Name = name;
            Suspended = suspended;
            Tags = tags;
        }
    }
}
