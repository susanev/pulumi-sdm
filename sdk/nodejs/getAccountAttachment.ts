// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * AccountAttachments assign an account to a role.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as sdm from "@pulumi/sdm";
 *
 * const accountAttachmentQuery = pulumi.output(sdm.getAccountAttachment({
 *     accountId: "a-00000054",
 * }));
 * ```
 */
export function getAccountAttachment(args?: GetAccountAttachmentArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountAttachmentResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("sdm:index/getAccountAttachment:getAccountAttachment", {
        "accountId": args.accountId,
        "id": args.id,
        "roleId": args.roleId,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccountAttachment.
 */
export interface GetAccountAttachmentArgs {
    /**
     * The id of the account of this AccountAttachment.
     */
    accountId?: string;
    /**
     * Unique identifier of the AccountAttachment.
     */
    id?: string;
    /**
     * The id of the attached role of this AccountAttachment.
     */
    roleId?: string;
}

/**
 * A collection of values returned by getAccountAttachment.
 */
export interface GetAccountAttachmentResult {
    /**
     * A list where each element has the following attributes:
     */
    readonly accountAttachments: outputs.GetAccountAttachmentAccountAttachment[];
    /**
     * The id of the account of this AccountAttachment.
     */
    readonly accountId?: string;
    /**
     * Unique identifier of the AccountAttachment.
     */
    readonly id?: string;
    /**
     * a list of strings of ids of data sources that match the given arguments.
     */
    readonly ids: string[];
    /**
     * The id of the attached role of this AccountAttachment.
     */
    readonly roleId?: string;
}

export function getAccountAttachmentOutput(args?: GetAccountAttachmentOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccountAttachmentResult> {
    return pulumi.output(args).apply(a => getAccountAttachment(a, opts))
}

/**
 * A collection of arguments for invoking getAccountAttachment.
 */
export interface GetAccountAttachmentOutputArgs {
    /**
     * The id of the account of this AccountAttachment.
     */
    accountId?: pulumi.Input<string>;
    /**
     * Unique identifier of the AccountAttachment.
     */
    id?: pulumi.Input<string>;
    /**
     * The id of the attached role of this AccountAttachment.
     */
    roleId?: pulumi.Input<string>;
}
