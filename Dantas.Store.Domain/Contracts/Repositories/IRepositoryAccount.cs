using Dantas.Store.Domain.Entities;

namespace Dantas.Store.Domain.Contracts.Repositories
{
    public interface IRepositoryAccount : IRepository<Account>
    {
        Account Get(string email);
    }
}
