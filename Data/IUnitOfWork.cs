using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace Data
{
    public interface IUnitOfWork
    {   
        public IAccountRepository Account { get; }
        public ICategoryRepository Category { get; }    
        public ICommentRepository Comment { get; }
        public IOrderRepository Order { get; }  
        public IProductRepository Product { get; }  
        public IPaymentRepository Payment { get; }
        public IRatingRepository Rating { get; }
        public ITagRepository Tag { get; }  
        public IShippingDetailRepository ShippingDetail { get; }    
        IDbContextTransaction Transaction();
        void BeginTransaction();
        void Commit();
        void Rollback();
        void Dispose();
        Task<int> SaveChangesAsync();
    }
}
