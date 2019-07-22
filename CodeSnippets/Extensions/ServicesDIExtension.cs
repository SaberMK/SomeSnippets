using CodeSnippets.Services;
using CodeSnippets.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSnippets.Extensions
{
    public static class ServicesDIExtension
    {
        public static void AddServicesDI (this IServiceCollection services)
        {
            services.AddSingleton<IUserService, UserService>();
        }
    }
}
