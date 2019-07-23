using CodeSnippets.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippets.Database.Interfaces
{
    public interface IUserContext : IRepository<User>
    {
    }
}
