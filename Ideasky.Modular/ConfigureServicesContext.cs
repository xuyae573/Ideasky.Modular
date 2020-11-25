using Ideasky.Modular.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ideasky.Modular
{
    public class ConfigureServicesContext
    {
        public IServiceCollection Services { get; }

        public ConfigureServicesContext(IServiceCollection services)
        {
            Services = services;
        }

        public IConfiguration GetConfiguration()
        {
            var implemenInstance = Services.GetSingletonInstanceOrNull<IConfiguration>();
            return implemenInstance;
        }
    }
}
