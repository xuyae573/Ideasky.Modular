using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ideasky.Modular
{
    public abstract class IdeaskyModule : IIdeaskyModule, IOnApplicationInitialization
    {
        public static bool IsIdeaskyModule(Type type)
        {
            var typeInfo = type.GetTypeInfo();

            return
                typeInfo.IsClass &&
                !typeInfo.IsAbstract &&
                !typeInfo.IsGenericType &&
                typeof(IdeaskyModule).GetTypeInfo().IsAssignableFrom(type);
        }

        public virtual void ConfigureServices(ConfigureServicesContext context)
        {
             
        }

        public virtual void OnApplicationInitialization(ApplicationInitializationContext context)
        {
             
        }
    }
}
