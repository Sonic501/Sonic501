using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class AccountRepository : Repository<Account> , IAccountRepository
    {
        public AccountRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
