// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## Import
 *
 * AccountGrant can be imported using the id, e.g.,
 *
 * ```sh
 *  $ pulumi import sdm:index/accountGrant:AccountGrant example ag-12345678
 * ```
 */
export class AccountGrant extends pulumi.CustomResource {
    /**
     * Get an existing AccountGrant resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AccountGrantState, opts?: pulumi.CustomResourceOptions): AccountGrant {
        return new AccountGrant(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/accountGrant:AccountGrant';

    /**
     * Returns true if the given object is an instance of AccountGrant.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AccountGrant {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AccountGrant.__pulumiType;
    }

    /**
     * The account id of this AccountGrant.
     */
    public readonly accountId!: pulumi.Output<string>;
    /**
     * The resource id of this AccountGrant.
     */
    public readonly resourceId!: pulumi.Output<string>;

    /**
     * Create a AccountGrant resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccountGrantArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AccountGrantArgs | AccountGrantState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AccountGrantState | undefined;
            resourceInputs["accountId"] = state ? state.accountId : undefined;
            resourceInputs["resourceId"] = state ? state.resourceId : undefined;
        } else {
            const args = argsOrState as AccountGrantArgs | undefined;
            if ((!args || args.accountId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'accountId'");
            }
            if ((!args || args.resourceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceId'");
            }
            resourceInputs["accountId"] = args ? args.accountId : undefined;
            resourceInputs["resourceId"] = args ? args.resourceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AccountGrant.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AccountGrant resources.
 */
export interface AccountGrantState {
    /**
     * The account id of this AccountGrant.
     */
    accountId?: pulumi.Input<string>;
    /**
     * The resource id of this AccountGrant.
     */
    resourceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AccountGrant resource.
 */
export interface AccountGrantArgs {
    /**
     * The account id of this AccountGrant.
     */
    accountId: pulumi.Input<string>;
    /**
     * The resource id of this AccountGrant.
     */
    resourceId: pulumi.Input<string>;
}
