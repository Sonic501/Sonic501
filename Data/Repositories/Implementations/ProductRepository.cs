using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class ProductRepository : Repository<Product> , IProductRepository
    {
        public ProductRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
