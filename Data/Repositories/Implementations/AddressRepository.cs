using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class AddressRepository : Repository<Address> , IAddressRepository
    {
        public AddressRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
