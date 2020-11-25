using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Ideasky.Modular.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddIdeaskyModule(this IServiceCollection services, Assembly[] assemblies)
        {
            services.AddSingleton<IModuleLoader, ModuleLoader>();
            var loader = services.GetSingletonInstanceOrNull<IModuleLoader>();
            var modules = loader.LoadModules(assemblies);
            foreach (var item in modules)
            {
                item.ConfigureServices(new ConfigureServicesContext(services));
            }
        }
        public static T GetSingletonInstanceOrNull<T>(this IServiceCollection services)
        {
            var servictType = services
                .FirstOrDefault(d => d.ServiceType == typeof(T) && d.Lifetime == ServiceLifetime.Singleton);
            if (servictType?.ImplementationInstance != null)
            {
                return (T)servictType.ImplementationInstance;
            }

            if (servictType?.ImplementationFactory != null)
            {
                return (T)servictType.ImplementationFactory.Invoke(null);
            }

            return default(T);
        }
    }
}
