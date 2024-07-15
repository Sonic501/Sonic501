using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class PaymentRepository : Repository<Payment> , IPaymentRepository
    {
        public PaymentRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
