// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using _Azure.Lro.RpcLegacy;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="LegacyClient"/> to client builder. </summary>
    public static partial class AzureLroRpcLegacyClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="LegacyClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        public static IAzureClientBuilder<LegacyClient, LegacyClientOptions> AddLegacyClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<LegacyClient, LegacyClientOptions>((options) => new LegacyClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="LegacyClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<LegacyClient, LegacyClientOptions> AddLegacyClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<LegacyClient, LegacyClientOptions>(configuration);
        }
    }
}