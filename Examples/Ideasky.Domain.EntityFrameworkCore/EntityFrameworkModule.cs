using Ideasky.Modular;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ideasky.Domain.EntityFrameworkCore
{
    public class EntityFrameworkModule : IdeaskyModule
    {
        public override void ConfigureServices(ConfigureServicesContext context)
        {
            context.Services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
