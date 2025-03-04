// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## Import
 *
 * SecretStore can be imported using the id, e.g.,
 *
 * ```sh
 *  $ pulumi import sdm:index/secretStore:SecretStore example se-12345678
 * ```
 */
export class SecretStore extends pulumi.CustomResource {
    /**
     * Get an existing SecretStore resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SecretStoreState, opts?: pulumi.CustomResourceOptions): SecretStore {
        return new SecretStore(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sdm:index/secretStore:SecretStore';

    /**
     * Returns true if the given object is an instance of SecretStore.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SecretStore {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SecretStore.__pulumiType;
    }

    public readonly aws!: pulumi.Output<outputs.SecretStoreAws | undefined>;
    public readonly azureStore!: pulumi.Output<outputs.SecretStoreAzureStore | undefined>;
    public readonly cyberarkConjur!: pulumi.Output<outputs.SecretStoreCyberarkConjur | undefined>;
    public readonly cyberarkPam!: pulumi.Output<outputs.SecretStoreCyberarkPam | undefined>;
    /**
     * CyberarkPAMExperimentalStore is currently unstable, and its API may change, or it may be removed, without a major
     * version bump.
     */
    public readonly cyberarkPamExperimental!: pulumi.Output<outputs.SecretStoreCyberarkPamExperimental | undefined>;
    public readonly delineaStore!: pulumi.Output<outputs.SecretStoreDelineaStore | undefined>;
    public readonly gcpStore!: pulumi.Output<outputs.SecretStoreGcpStore | undefined>;
    public readonly vaultApprole!: pulumi.Output<outputs.SecretStoreVaultApprole | undefined>;
    public readonly vaultTls!: pulumi.Output<outputs.SecretStoreVaultTls | undefined>;
    public readonly vaultToken!: pulumi.Output<outputs.SecretStoreVaultToken | undefined>;

    /**
     * Create a SecretStore resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: SecretStoreArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SecretStoreArgs | SecretStoreState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SecretStoreState | undefined;
            resourceInputs["aws"] = state ? state.aws : undefined;
            resourceInputs["azureStore"] = state ? state.azureStore : undefined;
            resourceInputs["cyberarkConjur"] = state ? state.cyberarkConjur : undefined;
            resourceInputs["cyberarkPam"] = state ? state.cyberarkPam : undefined;
            resourceInputs["cyberarkPamExperimental"] = state ? state.cyberarkPamExperimental : undefined;
            resourceInputs["delineaStore"] = state ? state.delineaStore : undefined;
            resourceInputs["gcpStore"] = state ? state.gcpStore : undefined;
            resourceInputs["vaultApprole"] = state ? state.vaultApprole : undefined;
            resourceInputs["vaultTls"] = state ? state.vaultTls : undefined;
            resourceInputs["vaultToken"] = state ? state.vaultToken : undefined;
        } else {
            const args = argsOrState as SecretStoreArgs | undefined;
            resourceInputs["aws"] = args ? args.aws : undefined;
            resourceInputs["azureStore"] = args ? args.azureStore : undefined;
            resourceInputs["cyberarkConjur"] = args ? args.cyberarkConjur : undefined;
            resourceInputs["cyberarkPam"] = args ? args.cyberarkPam : undefined;
            resourceInputs["cyberarkPamExperimental"] = args ? args.cyberarkPamExperimental : undefined;
            resourceInputs["delineaStore"] = args ? args.delineaStore : undefined;
            resourceInputs["gcpStore"] = args ? args.gcpStore : undefined;
            resourceInputs["vaultApprole"] = args ? args.vaultApprole : undefined;
            resourceInputs["vaultTls"] = args ? args.vaultTls : undefined;
            resourceInputs["vaultToken"] = args ? args.vaultToken : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SecretStore.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SecretStore resources.
 */
export interface SecretStoreState {
    aws?: pulumi.Input<inputs.SecretStoreAws>;
    azureStore?: pulumi.Input<inputs.SecretStoreAzureStore>;
    cyberarkConjur?: pulumi.Input<inputs.SecretStoreCyberarkConjur>;
    cyberarkPam?: pulumi.Input<inputs.SecretStoreCyberarkPam>;
    /**
     * CyberarkPAMExperimentalStore is currently unstable, and its API may change, or it may be removed, without a major
     * version bump.
     */
    cyberarkPamExperimental?: pulumi.Input<inputs.SecretStoreCyberarkPamExperimental>;
    delineaStore?: pulumi.Input<inputs.SecretStoreDelineaStore>;
    gcpStore?: pulumi.Input<inputs.SecretStoreGcpStore>;
    vaultApprole?: pulumi.Input<inputs.SecretStoreVaultApprole>;
    vaultTls?: pulumi.Input<inputs.SecretStoreVaultTls>;
    vaultToken?: pulumi.Input<inputs.SecretStoreVaultToken>;
}

/**
 * The set of arguments for constructing a SecretStore resource.
 */
export interface SecretStoreArgs {
    aws?: pulumi.Input<inputs.SecretStoreAws>;
    azureStore?: pulumi.Input<inputs.SecretStoreAzureStore>;
    cyberarkConjur?: pulumi.Input<inputs.SecretStoreCyberarkConjur>;
    cyberarkPam?: pulumi.Input<inputs.SecretStoreCyberarkPam>;
    /**
     * CyberarkPAMExperimentalStore is currently unstable, and its API may change, or it may be removed, without a major
     * version bump.
     */
    cyberarkPamExperimental?: pulumi.Input<inputs.SecretStoreCyberarkPamExperimental>;
    delineaStore?: pulumi.Input<inputs.SecretStoreDelineaStore>;
    gcpStore?: pulumi.Input<inputs.SecretStoreGcpStore>;
    vaultApprole?: pulumi.Input<inputs.SecretStoreVaultApprole>;
    vaultTls?: pulumi.Input<inputs.SecretStoreVaultTls>;
    vaultToken?: pulumi.Input<inputs.SecretStoreVaultToken>;
}
