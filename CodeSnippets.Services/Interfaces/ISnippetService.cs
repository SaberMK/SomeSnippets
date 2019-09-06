using CodeSnippets.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Services.Interfaces
{
    public interface ISnippetService
    {
        Task<Snippet> AddSnippet(string name, string description, string code, User author, Language language, ICollection<Tag> tags);
    }
}
