using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        public CategoryRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
