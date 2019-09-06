using CodeSnippets.Database.Repositories;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Services.Interfaces;
using CodeSnippets.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CodeSnippets.Database.Repositories.Interfaces;

namespace CodeSnippets.Services
{
    [DependencyInjection(typeof(ITagService), DependencyInjectionScope.Scoped)]
    public class TagService : ITagService
    {
        ITagRepository _tagRepository;
        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task<ICollection<Tag>> AddOrUpdateTags(string[] tags)
        {
            //var tagEntities = tags.Select(tag => new Tag()
            //{
            //    Content = tag
            //}).ToArray();

            var tagEntities = new List<Tag>();

            foreach(var tag in tags)
            {
                var tagEntity = _tagRepository.Query().FirstOrDefault(x => x.Content == tag);
                if (tagEntity == null)
                {
                    tagEntity = await _tagRepository.AddAsync(new Tag()
                    {
                        Content = tag
                    });
                    await _tagRepository.CommitAsync();
                    tagEntity = _tagRepository.Query().FirstOrDefault(x => x.Content == tag);
                }
                tagEntities.Add(tagEntity);
            }

            await _tagRepository.CommitAsync();
            return tagEntities;
            //tagEntities = tagEntities.Select(tag => _tagRepository.AddOrUpdate(tag)).ToArray();
            //await _tagRepository.CommitAsync();

            //var a = tagEntities.Select(x => _tagRepository.Update(x)).ToArray();
            //return tagEntities;
        }
    }
}
