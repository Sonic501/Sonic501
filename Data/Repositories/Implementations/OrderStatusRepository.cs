using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class OrderStatusRepository : Repository<OrderStatus> , IOrderStatusRepository
    {
        public OrderStatusRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
