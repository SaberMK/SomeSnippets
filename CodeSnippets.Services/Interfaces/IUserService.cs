using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CodeSnippets.Entities.Entities;

namespace CodeSnippets.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> GetTestString();
        Task<bool> IsUserExists(string username);
        Task<User> AuthUser(string username, string password);
        Task<User> RegisterUser(string username, string password);
    }
}
