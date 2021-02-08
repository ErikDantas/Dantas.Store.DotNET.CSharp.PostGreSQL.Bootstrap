using Dantas.Store.Domain.Contracts.Repositories;
using Dantas.Store.Domain.Entities;
using System.Linq;

namespace Dantas.Store.Data.EF.Repositories
{
    public class RepositoryAccountEF : RepositoryEF<Account>, IRepositoryAccount
    {
        public Account Get(string email)
        {
            return _context.accounts.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }
    }
}
