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
    public sealed class ResourcePostgres
    {
        /// <summary>
        /// Bind interface
        /// </summary>
        public readonly string? BindInterface;
        public readonly string Database;
        /// <summary>
        /// A filter applied to the routing logic to pin datasource to nodes.
        /// </summary>
        public readonly string? EgressFilter;
        public readonly string Hostname;
        /// <summary>
        /// Unique human-readable name of the Resource.
        /// </summary>
        public readonly string Name;
        public readonly bool? OverrideDatabase;
        public readonly string? Password;
        public readonly int? Port;
        public readonly int? PortOverride;
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
        private ResourcePostgres(
            string? bindInterface,

            string database,

            string? egressFilter,

            string hostname,

            string name,

            bool? overrideDatabase,

            string? password,

            int? port,

            int? portOverride,

            string? secretStoreId,

            string? secretStorePasswordKey,

            string? secretStorePasswordPath,

            string? secretStoreUsernameKey,

            string? secretStoreUsernamePath,

            ImmutableDictionary<string, string>? tags,

            string? username)
        {
            BindInterface = bindInterface;
            Database = database;
            EgressFilter = egressFilter;
            Hostname = hostname;
            Name = name;
            OverrideDatabase = overrideDatabase;
            Password = password;
            Port = port;
            PortOverride = portOverride;
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
