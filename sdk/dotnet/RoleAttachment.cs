// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Sdm
{
    /// <summary>
    /// ## Import
    /// 
    /// RoleAttachment can be imported using the id, e.g.,
    /// 
    /// ```sh
    ///  $ pulumi import sdm:index/roleAttachment:RoleAttachment example ra-12345678
    /// ```
    /// </summary>
    [SdmResourceType("sdm:index/roleAttachment:RoleAttachment")]
    public partial class RoleAttachment : Pulumi.CustomResource
    {
        /// <summary>
        /// The id of the attached role of this RoleAttachment.
        /// </summary>
        [Output("attachedRoleId")]
        public Output<string> AttachedRoleId { get; private set; } = null!;

        /// <summary>
        /// The id of the composite role of this RoleAttachment.
        /// </summary>
        [Output("compositeRoleId")]
        public Output<string> CompositeRoleId { get; private set; } = null!;


        /// <summary>
        /// Create a RoleAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RoleAttachment(string name, RoleAttachmentArgs args, CustomResourceOptions? options = null)
            : base("sdm:index/roleAttachment:RoleAttachment", name, args ?? new RoleAttachmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RoleAttachment(string name, Input<string> id, RoleAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("sdm:index/roleAttachment:RoleAttachment", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/pierskarsenbarg/pulumi-sdm/releases/download/${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing RoleAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RoleAttachment Get(string name, Input<string> id, RoleAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new RoleAttachment(name, id, state, options);
        }
    }

    public sealed class RoleAttachmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id of the attached role of this RoleAttachment.
        /// </summary>
        [Input("attachedRoleId", required: true)]
        public Input<string> AttachedRoleId { get; set; } = null!;

        /// <summary>
        /// The id of the composite role of this RoleAttachment.
        /// </summary>
        [Input("compositeRoleId", required: true)]
        public Input<string> CompositeRoleId { get; set; } = null!;

        public RoleAttachmentArgs()
        {
        }
    }

    public sealed class RoleAttachmentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id of the attached role of this RoleAttachment.
        /// </summary>
        [Input("attachedRoleId")]
        public Input<string>? AttachedRoleId { get; set; }

        /// <summary>
        /// The id of the composite role of this RoleAttachment.
        /// </summary>
        [Input("compositeRoleId")]
        public Input<string>? CompositeRoleId { get; set; }

        public RoleAttachmentState()
        {
        }
    }
}
