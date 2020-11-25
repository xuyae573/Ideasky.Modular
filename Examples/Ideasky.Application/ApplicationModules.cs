using Ideasky.Modular;
using Ideasky_Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Ideasky.Application
{
    public class ApplicationModule: IdeaskyModule
    {
        public override void ConfigureServices(ConfigureServicesContext context)
        {
            context.Services.AddScoped<IBookService, BookService>();
        }
    }
}
