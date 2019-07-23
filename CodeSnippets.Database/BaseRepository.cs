using CodeSnippets.Database.Interfaces;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Database
{
    //public class BaseRepository<TEntity> : IRepository<IEntity> 
    //{
    //    protected DbSet<TEntity> Entities {get; set;}

    //    public BaseRepository(DbSet<TEntity> entities)
    //    {
    //        Entities = entities;
    //    }

    //    public void Add(User entity)
    //    {
    //        Entities.Add((IEntity)entity);
    //    }

    //    public void Commit()
    //    {
    //        SaveChanges();
    //    }

    //    public async Task CommitAsync()
    //    {
    //        await SaveChangesAsync();
    //    }

    //    public IQueryable<User> Query()
    //    {
    //        return Users as IQueryable<User>;
    //    }
    //}
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
