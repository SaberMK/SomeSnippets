using CodeSnippets.Database.Interfaces;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Database.Contexts
{
    public class UserContext : DbContext, IUserContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public new void Add(User entity)
        {
            Users.Add(entity);
        }

        public void Commit()
        {
            SaveChanges();
        }

        public async Task CommitAsync()
        {
            await SaveChangesAsync();
        }

        public IQueryable<User> Query()
        {
            return Users as IQueryable<User>;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(user => user.Id);

            modelBuilder.Entity<User>()
                .Property(user => user.Username)
                .HasMaxLength(30)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.Password)
                .HasMaxLength(30)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.RegistrationDate)
                .IsRequired();


        }

        //public UserContext(DbContextOptions options) : base(options) //AAAAAAAAAAAAAAAAAAAAAAAAAAA TODO
        //{
        //    Database.EnsureCreated();
        //}
    }
}
