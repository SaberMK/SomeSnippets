using CodeSnippets.Database.Repositories;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Entities.Entities.M2MMappings;
using CodeSnippets.Services.Interfaces;
using CodeSnippets.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CodeSnippets.Database.Repositories.M2MMappings;
using CodeSnippets.Database.Repositories.Interfaces;
using CodeSnippets.Database.Repositories.M2MMappings.Interfaces;

namespace CodeSnippets.Services
{
    [DependencyInjection(typeof(ISnippetService), DependencyInjectionScope.Scoped)]
    public class SnippetService : ISnippetService
    {
        readonly IUserRepository _userRepository;
        readonly ISnippetRepository _snippetRepository;
        readonly ISnippetTagRepository _snippetTagRepository;
        readonly ILanguageRepository _languageRepository;
        readonly ITagRepository _tagReposory;
        public SnippetService(IUserRepository userRepository, ISnippetRepository snippetRepository,
            ILanguageRepository languageRepository, ITagRepository tagRepository,
            ISnippetTagRepository snippetTagRepository)
        {
            _userRepository = userRepository;
            _snippetRepository = snippetRepository;
            _languageRepository = languageRepository;
            _tagReposory = tagRepository;
            _snippetTagRepository = snippetTagRepository;
        }
        public async Task<Snippet> AddSnippet(string name, string description, User author, Language language, ICollection<Tag> tags)
        {
            var snippet = new Snippet()
            {
                Name = name,
                Description = description,
                Author = author,
                Language = language
            };

            snippet.SnippetTags = await BindTagsToSnippet(snippet, tags);

            await _snippetRepository.AddAsync(snippet);
            await _snippetRepository.CommitAsync();
            await _snippetTagRepository.CommitAsync();

            return snippet;
        }

        private async Task<ICollection<SnippetTag>> BindTagsToSnippet(Snippet snippet, ICollection<Tag> tags)
        {
            var snippetTags = tags.Select(tag => new SnippetTag()
            {
                Snippet = snippet,
                Tag = tag
            }).ToArray();
            await _snippetTagRepository.AddAsync(snippetTags);
            return snippetTags;
        }
    }
}
