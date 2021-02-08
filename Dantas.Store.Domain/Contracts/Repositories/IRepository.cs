using Dantas.Store.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Dantas.Store.Domain.Contracts.Repositories
{
    public interface IRepository<T> : IDisposable where T:Entity
    {
        IEnumerable<T> FindAll();
        T Get(int id);

        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        
    }
}
