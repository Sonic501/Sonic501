using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class OrderRepository : Repository<Order> , IOrderRepository
    {
        public OrderRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
