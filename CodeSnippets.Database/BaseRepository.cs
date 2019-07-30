using CodeSnippets.Database.Interfaces;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Database
{
    public class BaseRepository<TEntity> : DbContext, IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected DbSet<TEntity> Entities { get; set; }

        public async Task Add(TEntity entity)
        {
            await Entities.AddAsync(entity);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connection = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer("Data Source=WINDOWS-6HPH7SV\\SQLEXPRESS;Initial Catalog=codesnippetsdb;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public void Commit()
        {
            SaveChanges();
        }

        public async Task CommitAsync()
        {
            await SaveChangesAsync();
        }
        
        public IQueryable<TEntity> Query()
        {
            return Entities as IQueryable<TEntity>;
        }
    }
    //public class BaseRepository<TEntity> :  DbContext, IRepository<TEntity> where TEntity : class, IEntity, new()
    //{
    //    //private DbSet<TEntity> Entities { get; set; }
    //    //public BaseRepository(DbContextOptions options) : base(options)
    //    //{

    //    //}
    //    //public void Commit()
    //    //{
    //    //    SaveChanges();
    //    //}
    //    //public async Task CommitAsync()
    //    //{
    //    //    await SaveChangesAsync();
    //    //}
    //    //public void Add(TEntity entity)
    //    //{
    //    //    Entities.Add(entity);
    //    //}
    //    //public IQueryable<TEntity> Query()
    //    //{
    //    //    return Entities;
    //    //}
    //}
}
