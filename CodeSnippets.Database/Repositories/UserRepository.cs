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
    public class UserRepository : RepositoryBase<User, CodeSnippetsDbContext>, IUserRepository
    {
        public UserRepository(ICodeSnippetsDbContextFactory contextFactory) : base(contextFactory)
        {
        }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);

            builder.Property(user => user.Username)
                .HasMaxLength(30);

            builder.Property(user => user.Password)
                .HasMaxLength(30);

            builder.Property(user => user.AccessLevel)
                .HasDefaultValue(AccessLevel.USER);
        }
    }
}
