using Dantas.Store.Domain.Contracts.Repositories;
using Dantas.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Dantas.Store.Data.EF.Repositories
{
    public class RepositoryProductEF : RepositoryEF<Product>, IRepositoryProduct
    {
        public IEnumerable<Product> GetByNameContains(string contains)
        {
            return _context.products.Where(x => x.Name.Contains(contains));
        }
    }
}
