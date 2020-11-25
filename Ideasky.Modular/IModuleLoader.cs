using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ideasky.Modular
{
    public interface IModuleLoader
    {
        IEnumerable<IIdeaskyModule> LoadModules(Assembly[] assemblies);
    }
}
