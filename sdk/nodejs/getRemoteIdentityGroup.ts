// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * A RemoteIdentityGroup defines a group of remote identities.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pulumi/sdm";
 *
 * const defaultRemoteIdentityGroup = pulumi.output(sdm.getRemoteIdentityGroup({
 *     name: "default",
 * }));
 * ```
 */
export function getRemoteIdentityGroup(args?: GetRemoteIdentityGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetRemoteIdentityGroupResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("sdm:index/getRemoteIdentityGroup:getRemoteIdentityGroup", {
        "id": args.id,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getRemoteIdentityGroup.
 */
export interface GetRemoteIdentityGroupArgs {
    /**
     * Unique identifier of the RemoteIdentityGroup.
     */
    id?: string;
    /**
     * Unique human-readable name of the RemoteIdentityGroup.
     */
    name?: string;
}

/**
 * A collection of values returned by getRemoteIdentityGroup.
 */
export interface GetRemoteIdentityGroupResult {
    /**
     * Unique identifier of the RemoteIdentityGroup.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * Unique human-readable name of the RemoteIdentityGroup.
     */
    readonly name?: string;
    /**
     * A list where each element has the following attributes:
     */
    readonly remoteIdentityGroups: outputs.GetRemoteIdentityGroupRemoteIdentityGroup[];
}

export function getRemoteIdentityGroupOutput(args?: GetRemoteIdentityGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRemoteIdentityGroupResult> {
    return pulumi.output(args).apply(a => getRemoteIdentityGroup(a, opts))
}

/**
 * A collection of arguments for invoking getRemoteIdentityGroup.
 */
export interface GetRemoteIdentityGroupOutputArgs {
    /**
     * Unique identifier of the RemoteIdentityGroup.
     */
    id?: pulumi.Input<string>;
    /**
     * Unique human-readable name of the RemoteIdentityGroup.
     */
    name?: pulumi.Input<string>;
}
