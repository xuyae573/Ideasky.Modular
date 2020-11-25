using System;

namespace Ideasky.Modular
{
    public interface IIdeaskyModule
    {
        void ConfigureServices(ConfigureServicesContext context);
    }
}
