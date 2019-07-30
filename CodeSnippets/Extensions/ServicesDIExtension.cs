using AutoMapper;
using CodeSnippets.Database;
using CodeSnippets.Database.Contexts;
using CodeSnippets.Database.Interfaces;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Services;
using CodeSnippets.Services.Interfaces;
using CodeSnippets.Utils.Interfaces;
using CodeSnippets.Utils.ResponseCreators;
using CodeSnippets.Utils.User;
using Microsoft.EntityFrameworkCore;
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
            AddContexts(services);
            AddServices(services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }

        private static void AddContexts(IServiceCollection services)
        {
            services.AddSingleton<IUserContext, UserContext>();
            services.AddSingleton<IUserPasswordEncoder, UserPasswordDoubleBase64Encoder>();
            services.AddSingleton<IResponseCreator, ResponseCreator>();
            services.AddSingleton<IUserTokenCreator>(s => new UserTokenHMACCreator("☺☺☺"));
        }
    }
}
