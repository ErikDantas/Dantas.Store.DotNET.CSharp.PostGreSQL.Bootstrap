using Dantas.Store.Domain.Entities;
using System.Collections.Generic;

namespace Dantas.Store.Domain.Contracts.Repositories
{
    public interface IRepositoryProduct : IRepository<Product>
    {
        IEnumerable<Product> GetByNameContains(string contains);
    }
}
