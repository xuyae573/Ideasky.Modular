using System;
using System.Collections.Generic;
using System.Text;

namespace Ideasky.Modular
{
    public interface IOnApplicationInitialization
    {
        void OnApplicationInitialization(ApplicationInitializationContext context);
    }
}
