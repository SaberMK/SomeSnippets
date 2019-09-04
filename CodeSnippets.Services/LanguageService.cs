using CodeSnippets.Database.Repositories.Interfaces;
using CodeSnippets.Services.Interfaces;
using CodeSnippets.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Services
{
    [DependencyInjection(typeof(ILanguageService), DependencyInjectionScope.Scoped)]
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;
        public LanguageService(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public IEnumerable<string> GetAllLanguages()
        {
            return _languageRepository.Query().Select(lang => lang.Name);
        }
    }
}
