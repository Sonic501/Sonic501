using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class RatingRepository : Repository<Rating> , IRatingRepository
    {
        public RatingRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
