using AutoMapper;
using CodeSnippets.Database;
using CodeSnippets.Database.Concrete;
using CodeSnippets.Database.Concrete.Interfaces;
using CodeSnippets.Database.Interfaces;
using CodeSnippets.Database.Repositories;
using CodeSnippets.Database.Repositories.Interfaces;
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
            services.AddScoped<ICodeSnippetsDbContextFactory, CodeSnippetsDbContextFactory>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddSingleton<IUserPasswordEncoder, UserPasswordDoubleBase64Encoder>();
            services.AddSingleton<IResponseCreator, ResponseCreator>();
            services.AddSingleton<IUserTokenCreator>(s => new UserTokenHMACCreator("☺☺☺"));
        }
    }
}
