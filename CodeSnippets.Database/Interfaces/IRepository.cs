using CodeSnippets.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Database.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        void Commit();
        Task CommitAsync();
        Task Add(TEntity entity);
        IQueryable<TEntity> Query();
    }
}
