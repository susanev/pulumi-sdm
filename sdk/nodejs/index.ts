// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

// Export members:
export { AccountArgs, AccountState } from "./account";
export type Account = import("./account").Account;
export const Account: typeof import("./account").Account = null as any;
utilities.lazyLoad(exports, ["Account"], () => require("./account"));

export { AccountAttachmentArgs, AccountAttachmentState } from "./accountAttachment";
export type AccountAttachment = import("./accountAttachment").AccountAttachment;
export const AccountAttachment: typeof import("./accountAttachment").AccountAttachment = null as any;
utilities.lazyLoad(exports, ["AccountAttachment"], () => require("./accountAttachment"));

export { GetAccountArgs, GetAccountResult, GetAccountOutputArgs } from "./getAccount";
export const getAccount: typeof import("./getAccount").getAccount = null as any;
export const getAccountOutput: typeof import("./getAccount").getAccountOutput = null as any;
utilities.lazyLoad(exports, ["getAccount","getAccountOutput"], () => require("./getAccount"));

export { GetAccountAttachmentArgs, GetAccountAttachmentResult, GetAccountAttachmentOutputArgs } from "./getAccountAttachment";
export const getAccountAttachment: typeof import("./getAccountAttachment").getAccountAttachment = null as any;
export const getAccountAttachmentOutput: typeof import("./getAccountAttachment").getAccountAttachmentOutput = null as any;
utilities.lazyLoad(exports, ["getAccountAttachment","getAccountAttachmentOutput"], () => require("./getAccountAttachment"));

export { GetNodeArgs, GetNodeResult, GetNodeOutputArgs } from "./getNode";
export const getNode: typeof import("./getNode").getNode = null as any;
export const getNodeOutput: typeof import("./getNode").getNodeOutput = null as any;
utilities.lazyLoad(exports, ["getNode","getNodeOutput"], () => require("./getNode"));

export { GetRemoteIdentityArgs, GetRemoteIdentityResult, GetRemoteIdentityOutputArgs } from "./getRemoteIdentity";
export const getRemoteIdentity: typeof import("./getRemoteIdentity").getRemoteIdentity = null as any;
export const getRemoteIdentityOutput: typeof import("./getRemoteIdentity").getRemoteIdentityOutput = null as any;
utilities.lazyLoad(exports, ["getRemoteIdentity","getRemoteIdentityOutput"], () => require("./getRemoteIdentity"));

export { GetRemoteIdentityGroupArgs, GetRemoteIdentityGroupResult, GetRemoteIdentityGroupOutputArgs } from "./getRemoteIdentityGroup";
export const getRemoteIdentityGroup: typeof import("./getRemoteIdentityGroup").getRemoteIdentityGroup = null as any;
export const getRemoteIdentityGroupOutput: typeof import("./getRemoteIdentityGroup").getRemoteIdentityGroupOutput = null as any;
utilities.lazyLoad(exports, ["getRemoteIdentityGroup","getRemoteIdentityGroupOutput"], () => require("./getRemoteIdentityGroup"));

export { GetResourceArgs, GetResourceResult, GetResourceOutputArgs } from "./getResource";
export const getResource: typeof import("./getResource").getResource = null as any;
export const getResourceOutput: typeof import("./getResource").getResourceOutput = null as any;
utilities.lazyLoad(exports, ["getResource","getResourceOutput"], () => require("./getResource"));

export { GetRoleArgs, GetRoleResult, GetRoleOutputArgs } from "./getRole";
export const getRole: typeof import("./getRole").getRole = null as any;
export const getRoleOutput: typeof import("./getRole").getRoleOutput = null as any;
utilities.lazyLoad(exports, ["getRole","getRoleOutput"], () => require("./getRole"));

export { GetSecretStoreArgs, GetSecretStoreResult, GetSecretStoreOutputArgs } from "./getSecretStore";
export const getSecretStore: typeof import("./getSecretStore").getSecretStore = null as any;
export const getSecretStoreOutput: typeof import("./getSecretStore").getSecretStoreOutput = null as any;
utilities.lazyLoad(exports, ["getSecretStore","getSecretStoreOutput"], () => require("./getSecretStore"));

export { GetSshCaPubkeyArgs, GetSshCaPubkeyResult, GetSshCaPubkeyOutputArgs } from "./getSshCaPubkey";
export const getSshCaPubkey: typeof import("./getSshCaPubkey").getSshCaPubkey = null as any;
export const getSshCaPubkeyOutput: typeof import("./getSshCaPubkey").getSshCaPubkeyOutput = null as any;
utilities.lazyLoad(exports, ["getSshCaPubkey","getSshCaPubkeyOutput"], () => require("./getSshCaPubkey"));

export { NodeArgs, NodeState } from "./node";
export type Node = import("./node").Node;
export const Node: typeof import("./node").Node = null as any;
utilities.lazyLoad(exports, ["Node"], () => require("./node"));

export { ProviderArgs } from "./provider";
export type Provider = import("./provider").Provider;
export const Provider: typeof import("./provider").Provider = null as any;
utilities.lazyLoad(exports, ["Provider"], () => require("./provider"));

export { RemoteIdentityArgs, RemoteIdentityState } from "./remoteIdentity";
export type RemoteIdentity = import("./remoteIdentity").RemoteIdentity;
export const RemoteIdentity: typeof import("./remoteIdentity").RemoteIdentity = null as any;
utilities.lazyLoad(exports, ["RemoteIdentity"], () => require("./remoteIdentity"));

export { ResourceArgs, ResourceState } from "./resource";
export type Resource = import("./resource").Resource;
export const Resource: typeof import("./resource").Resource = null as any;
utilities.lazyLoad(exports, ["Resource"], () => require("./resource"));

export { RoleArgs, RoleState } from "./role";
export type Role = import("./role").Role;
export const Role: typeof import("./role").Role = null as any;
utilities.lazyLoad(exports, ["Role"], () => require("./role"));

export { SecretStoreArgs, SecretStoreState } from "./secretStore";
export type SecretStore = import("./secretStore").SecretStore;
export const SecretStore: typeof import("./secretStore").SecretStore = null as any;
utilities.lazyLoad(exports, ["SecretStore"], () => require("./secretStore"));


// Export sub-modules:
import * as config from "./config";
import * as types from "./types";

export {
    config,
    types,
};

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "sdm:index/account:Account":
                return new Account(name, <any>undefined, { urn })
            case "sdm:index/accountAttachment:AccountAttachment":
                return new AccountAttachment(name, <any>undefined, { urn })
            case "sdm:index/node:Node":
                return new Node(name, <any>undefined, { urn })
            case "sdm:index/remoteIdentity:RemoteIdentity":
                return new RemoteIdentity(name, <any>undefined, { urn })
            case "sdm:index/resource:Resource":
                return new Resource(name, <any>undefined, { urn })
            case "sdm:index/role:Role":
                return new Role(name, <any>undefined, { urn })
            case "sdm:index/secretStore:SecretStore":
                return new SecretStore(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("sdm", "index/account", _module)
pulumi.runtime.registerResourceModule("sdm", "index/accountAttachment", _module)
pulumi.runtime.registerResourceModule("sdm", "index/node", _module)
pulumi.runtime.registerResourceModule("sdm", "index/remoteIdentity", _module)
pulumi.runtime.registerResourceModule("sdm", "index/resource", _module)
pulumi.runtime.registerResourceModule("sdm", "index/role", _module)
pulumi.runtime.registerResourceModule("sdm", "index/secretStore", _module)
pulumi.runtime.registerResourcePackage("sdm", {
    version: utilities.getVersion(),
    constructProvider: (name: string, type: string, urn: string): pulumi.ProviderResource => {
        if (type !== "pulumi:providers:sdm") {
            throw new Error(`unknown provider type ${type}`);
        }
        return new Provider(name, <any>undefined, { urn });
    },
});
