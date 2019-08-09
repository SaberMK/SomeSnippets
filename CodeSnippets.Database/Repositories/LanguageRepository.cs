using CodeSnippets.Database.Base;
using CodeSnippets.Database.Concrete;
using CodeSnippets.Database.Concrete.Interfaces;
using CodeSnippets.Database.Repositories.Interfaces;
using CodeSnippets.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippets.Database.Repositories
{
    public class LanguageRepository : RepositoryBase<Language, CodeSnippetsDbContext>, ILanguageRepository
    {
        public LanguageRepository(ICodeSnippetsDbContextFactory contextFactory) : base(contextFactory)
        {
        }
    }
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(language => language.Id);

            builder.Property(language => language.Name)
                .HasMaxLength(30);

        }
    }
}
