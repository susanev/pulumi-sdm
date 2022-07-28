# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetSshCaPubkeyResult',
    'AwaitableGetSshCaPubkeyResult',
    'get_ssh_ca_pubkey',
    'get_ssh_ca_pubkey_output',
]

@pulumi.output_type
class GetSshCaPubkeyResult:
    """
    A collection of values returned by getSshCaPubkey.
    """
    def __init__(__self__, id=None, public_key=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if public_key and not isinstance(public_key, str):
            raise TypeError("Expected argument 'public_key' to be a str")
        pulumi.set(__self__, "public_key", public_key)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        a generated id representing this request.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="publicKey")
    def public_key(self) -> Optional[str]:
        """
        the SSH Certificate Authority public key.
        """
        return pulumi.get(self, "public_key")


class AwaitableGetSshCaPubkeyResult(GetSshCaPubkeyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSshCaPubkeyResult(
            id=self.id,
            public_key=self.public_key)


def get_ssh_ca_pubkey(id: Optional[str] = None,
                      public_key: Optional[str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSshCaPubkeyResult:
    """
    The SSH CA Pubkey is a public key used for setting up SSH resources.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    ssh_pubkey_query = sdm.get_ssh_ca_pubkey()
    ```


    :param str id: a generated id representing this request.
    :param str public_key: the SSH Certificate Authority public key.
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['publicKey'] = public_key
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('sdm:index/getSshCaPubkey:getSshCaPubkey', __args__, opts=opts, typ=GetSshCaPubkeyResult).value

    return AwaitableGetSshCaPubkeyResult(
        id=__ret__.id,
        public_key=__ret__.public_key)


@_utilities.lift_output_func(get_ssh_ca_pubkey)
def get_ssh_ca_pubkey_output(id: Optional[pulumi.Input[Optional[str]]] = None,
                             public_key: Optional[pulumi.Input[Optional[str]]] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSshCaPubkeyResult]:
    """
    The SSH CA Pubkey is a public key used for setting up SSH resources.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_sdm as sdm

    ssh_pubkey_query = sdm.get_ssh_ca_pubkey()
    ```


    :param str id: a generated id representing this request.
    :param str public_key: the SSH Certificate Authority public key.
    """
    ...
