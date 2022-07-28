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
    public static class GetRoleGrant
    {
        /// <summary>
        /// A RoleGrant connects a resource to a role, granting members of the role access to that resource.
        /// 
        ///  Deprecated: use Role access rules instead.
        /// This data source is deprecated.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var roleGrantQuery = Output.Create(Sdm.GetRoleGrant.InvokeAsync(new Sdm.GetRoleGrantArgs
        ///         {
        ///             RoleId = "r-0009994",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetRoleGrantResult> InvokeAsync(GetRoleGrantArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRoleGrantResult>("sdm:index/getRoleGrant:getRoleGrant", args ?? new GetRoleGrantArgs(), options.WithDefaults());

        /// <summary>
        /// A RoleGrant connects a resource to a role, granting members of the role access to that resource.
        /// 
        ///  Deprecated: use Role access rules instead.
        /// This data source is deprecated.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Sdm = Pulumi.Sdm;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var roleGrantQuery = Output.Create(Sdm.GetRoleGrant.InvokeAsync(new Sdm.GetRoleGrantArgs
        ///         {
        ///             RoleId = "r-0009994",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetRoleGrantResult> Invoke(GetRoleGrantInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetRoleGrantResult>("sdm:index/getRoleGrant:getRoleGrant", args ?? new GetRoleGrantInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRoleGrantArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the RoleGrant.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The id of the resource of this RoleGrant.
        /// </summary>
        [Input("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// The id of the attached role of this RoleGrant.
        /// </summary>
        [Input("roleId")]
        public string? RoleId { get; set; }

        public GetRoleGrantArgs()
        {
        }
    }

    public sealed class GetRoleGrantInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique identifier of the RoleGrant.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The id of the resource of this RoleGrant.
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        /// <summary>
        /// The id of the attached role of this RoleGrant.
        /// </summary>
        [Input("roleId")]
        public Input<string>? RoleId { get; set; }

        public GetRoleGrantInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetRoleGrantResult
    {
        /// <summary>
        /// Unique identifier of the RoleGrant.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// a list of strings of ids of data sources that match the given arguments.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// The id of the resource of this RoleGrant.
        /// </summary>
        public readonly string? ResourceId;
        /// <summary>
        /// A list where each element has the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRoleGrantRoleGrantResult> RoleGrants;
        /// <summary>
        /// The id of the attached role of this RoleGrant.
        /// </summary>
        public readonly string? RoleId;

        [OutputConstructor]
        private GetRoleGrantResult(
            string? id,

            ImmutableArray<string> ids,

            string? resourceId,

            ImmutableArray<Outputs.GetRoleGrantRoleGrantResult> roleGrants,

            string? roleId)
        {
            Id = id;
            Ids = ids;
            ResourceId = resourceId;
            RoleGrants = roleGrants;
            RoleId = roleId;
        }
    }
}
