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
    public sealed class GetRemoteIdentityRemoteIdentityResult
    {
        /// <summary>
        /// The account for this remote identity.
        /// </summary>
        public readonly string? AccountId;
        /// <summary>
        /// Unique identifier of the RemoteIdentity.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The remote identity group.
        /// </summary>
        public readonly string? RemoteIdentityGroupId;
        /// <summary>
        /// The username to be used as the remote identity for this account.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private GetRemoteIdentityRemoteIdentityResult(
            string? accountId,

            string? id,

            string? remoteIdentityGroupId,

            string? username)
        {
            AccountId = accountId;
            Id = id;
            RemoteIdentityGroupId = remoteIdentityGroupId;
            Username = username;
        }
    }
}
