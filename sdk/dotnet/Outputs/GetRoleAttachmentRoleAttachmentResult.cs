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
    public sealed class GetRoleAttachmentRoleAttachmentResult
    {
        /// <summary>
        /// The id of the attached role of this RoleAttachment.
        /// </summary>
        public readonly string? AttachedRoleId;
        /// <summary>
        /// The id of the composite role of this RoleAttachment.
        /// </summary>
        public readonly string? CompositeRoleId;
        /// <summary>
        /// Unique identifier of the RoleAttachment.
        /// </summary>
        public readonly string? Id;

        [OutputConstructor]
        private GetRoleAttachmentRoleAttachmentResult(
            string? attachedRoleId,

            string? compositeRoleId,

            string? id)
        {
            AttachedRoleId = attachedRoleId;
            CompositeRoleId = compositeRoleId;
            Id = id;
        }
    }
}
