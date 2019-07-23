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
    }
}
