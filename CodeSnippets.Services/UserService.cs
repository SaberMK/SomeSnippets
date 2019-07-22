using CodeSnippets.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippets.Services
{
    public class UserService : IUserService
    {
        public string GetTestString()
        {
            return "Response!";
        }
    }
}
