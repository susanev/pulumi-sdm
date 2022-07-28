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
    public sealed class ResourceKubernetesBasicAuth
    {
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        /// <summary>
        /// The path used to check the health of your connection.  Defaults to `default`.  This field is required, and is only marked as optional for backwards compatibility.
        /// </summary>
        public readonly string? HealthcheckNamespace;
        public readonly string Hostname;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
        public readonly string? Password;
        public readonly int Port;
        /// <summary>
        /// ID of the secret store containing credentials for this resource, if any.
        /// </summary>
        public readonly string? SecretStoreId;
        public readonly string? SecretStorePasswordKey;
        public readonly string? SecretStorePasswordPath;
        public readonly string? SecretStoreUsernameKey;
        public readonly string? SecretStoreUsernamePath;
        /// <summary>
        /// Tags is a map of key, value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        public readonly string? Username;

        [OutputConstructor]
        private ResourceKubernetesBasicAuth(
            string? bindInterface,

            string? egressFilter,

            string? healthcheckNamespace,

            string hostname,

            string name,

            string? password,

            int port,

            string? secretStoreId,

            string? secretStorePasswordKey,

            string? secretStorePasswordPath,

            string? secretStoreUsernameKey,

            string? secretStoreUsernamePath,

            ImmutableDictionary<string, string>? tags,

            string? username)
        {
            BindInterface = bindInterface;
            EgressFilter = egressFilter;
            HealthcheckNamespace = healthcheckNamespace;
            Hostname = hostname;
            Name = name;
            Password = password;
            Port = port;
            SecretStoreId = secretStoreId;
            SecretStorePasswordKey = secretStorePasswordKey;
            SecretStorePasswordPath = secretStorePasswordPath;
            SecretStoreUsernameKey = secretStoreUsernameKey;
            SecretStoreUsernamePath = secretStoreUsernamePath;
            Tags = tags;
            Username = username;
        }
    }
}
