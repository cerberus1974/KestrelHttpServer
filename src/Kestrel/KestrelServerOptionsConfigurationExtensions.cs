// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.Configuration;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
    public static class KestrelServerOptionsConfigurationExtensions
    {
        /// <summary>
        /// Creates a configuration loader for setting up Kestrel.
        /// </summary>
        public static KestrelConfigurationLoader Configure(this KestrelServerOptions options)
        {
            var loader = new KestrelConfigurationLoader(options, new ConfigurationBuilder().Build());
            options.ConfigurationLoader = loader;
            return loader;
        }

        /// <summary>
        /// Creates a configuration loader for setting up Kestrel that takes an IConfiguration as input.
        /// </summary>
        public static KestrelConfigurationLoader Configure(this KestrelServerOptions options, IConfiguration config)
        {
            var loader = new KestrelConfigurationLoader(options, config);
            options.ConfigurationLoader = loader;
            return loader;
        }
    }
}
