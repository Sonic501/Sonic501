using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class ProductImageRepository : Repository<ProductImage> , IProductImageRepository
    {
        public ProductImageRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
