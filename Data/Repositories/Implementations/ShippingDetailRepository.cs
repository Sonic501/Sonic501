using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class ShippingDetailRepository : Repository<ShippingDetail> , IShippingDetailRepository
    {
        public ShippingDetailRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
