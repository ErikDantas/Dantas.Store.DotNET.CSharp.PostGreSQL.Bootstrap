using Dantas.Store.Domain.Contracts.Repositories;
using Dantas.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Dantas.Store.Data.EF.Repositories
{
    public class RepositoryEF<T> : IRepository<T> where T : Entity
    {

        protected readonly DantasStoreContext _context = new DantasStoreContext();


        public IEnumerable<T> FindAll()
        {
            return _context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }



        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
