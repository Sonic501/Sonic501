using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class TagRepository : Repository<Tag> , ITagRepository
    {
        public TagRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
