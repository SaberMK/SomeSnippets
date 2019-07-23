using CodeSnippets.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippets.Database.Interfaces
{
    public interface IRepository<IEntity>
    {
        void Commit();
        Task CommitAsync();
        void Add(IEntity entity);
        IQueryable<IEntity> Query();
    }
}
