# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['RoleGrantArgs', 'RoleGrant']

@pulumi.input_type
class RoleGrantArgs:
    def __init__(__self__, *,
                 resource_id: pulumi.Input[str],
                 role_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a RoleGrant resource.
        :param pulumi.Input[str] resource_id: The id of the resource of this RoleGrant.
        :param pulumi.Input[str] role_id: The id of the attached role of this RoleGrant.
        """
        pulumi.set(__self__, "resource_id", resource_id)
        pulumi.set(__self__, "role_id", role_id)

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> pulumi.Input[str]:
        """
        The id of the resource of this RoleGrant.
        """
        return pulumi.get(self, "resource_id")

    @resource_id.setter
    def resource_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_id", value)

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> pulumi.Input[str]:
        """
        The id of the attached role of this RoleGrant.
        """
        return pulumi.get(self, "role_id")

    @role_id.setter
    def role_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "role_id", value)


@pulumi.input_type
class _RoleGrantState:
    def __init__(__self__, *,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 role_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering RoleGrant resources.
        :param pulumi.Input[str] resource_id: The id of the resource of this RoleGrant.
        :param pulumi.Input[str] role_id: The id of the attached role of this RoleGrant.
        """
        if resource_id is not None:
            pulumi.set(__self__, "resource_id", resource_id)
        if role_id is not None:
            pulumi.set(__self__, "role_id", role_id)

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[pulumi.Input[str]]:
        """
        The id of the resource of this RoleGrant.
        """
        return pulumi.get(self, "resource_id")

    @resource_id.setter
    def resource_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_id", value)

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> Optional[pulumi.Input[str]]:
        """
        The id of the attached role of this RoleGrant.
        """
        return pulumi.get(self, "role_id")

    @role_id.setter
    def role_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "role_id", value)


class RoleGrant(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 role_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        ## Import

        RoleGrant can be imported using the id, e.g.,

        ```sh
         $ pulumi import sdm:index/roleGrant:RoleGrant example rg-12345678
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] resource_id: The id of the resource of this RoleGrant.
        :param pulumi.Input[str] role_id: The id of the attached role of this RoleGrant.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RoleGrantArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## Import

        RoleGrant can be imported using the id, e.g.,

        ```sh
         $ pulumi import sdm:index/roleGrant:RoleGrant example rg-12345678
        ```

        :param str resource_name: The name of the resource.
        :param RoleGrantArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RoleGrantArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 role_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RoleGrantArgs.__new__(RoleGrantArgs)

            if resource_id is None and not opts.urn:
                raise TypeError("Missing required property 'resource_id'")
            __props__.__dict__["resource_id"] = resource_id
            if role_id is None and not opts.urn:
                raise TypeError("Missing required property 'role_id'")
            __props__.__dict__["role_id"] = role_id
        super(RoleGrant, __self__).__init__(
            'sdm:index/roleGrant:RoleGrant',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            resource_id: Optional[pulumi.Input[str]] = None,
            role_id: Optional[pulumi.Input[str]] = None) -> 'RoleGrant':
        """
        Get an existing RoleGrant resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] resource_id: The id of the resource of this RoleGrant.
        :param pulumi.Input[str] role_id: The id of the attached role of this RoleGrant.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RoleGrantState.__new__(_RoleGrantState)

        __props__.__dict__["resource_id"] = resource_id
        __props__.__dict__["role_id"] = role_id
        return RoleGrant(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> pulumi.Output[str]:
        """
        The id of the resource of this RoleGrant.
        """
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> pulumi.Output[str]:
        """
        The id of the attached role of this RoleGrant.
        """
        return pulumi.get(self, "role_id")

