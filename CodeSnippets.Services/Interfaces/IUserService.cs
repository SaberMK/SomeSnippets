using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> GetTestString();
    }
}
