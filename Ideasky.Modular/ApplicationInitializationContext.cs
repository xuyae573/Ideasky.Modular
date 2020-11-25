using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ideasky.Modular
{
    public class ApplicationInitializationContext
    {
        public IServiceProvider ServiceProvider { get; set; }

        public ApplicationInitializationContext(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
