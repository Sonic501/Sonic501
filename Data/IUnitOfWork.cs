using Microsoft.EntityFrameworkCore.Storage;

namespace Data
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        IDbContextTransaction Transaction();
    }
}
