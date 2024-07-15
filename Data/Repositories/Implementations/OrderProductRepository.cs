using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class OrderProductRepository : Repository<OrderProduct> , IOrderProductRepository
    {
        public OrderProductRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
