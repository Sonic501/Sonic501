using Data.Repositories.Interfaces;
using Domain.Entities;
namespace Data.Repositories.Implementations
{
    public class CommentRepository : Repository<Comment> , ICommentRepository
    {
        public CommentRepository(EcommerceContext context) : base(context)
        {
        }
    }
}
