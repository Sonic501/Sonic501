using Data.Repositories.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EcommerceContext _context;

    public UnitOfWork(EcommerceContext context)
    {
        _context = context;
    }
        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public IDbContextTransaction Transaction()
        {
            return _context.Database.BeginTransaction();
        }
        public IAccountRepository Account => throw new NotImplementedException();

        public ICategoryRepository Category => throw new NotImplementedException();

        public ICommentRepository Comment => throw new NotImplementedException();

        public IOrderRepository Order => throw new NotImplementedException();

        public IProductRepository Product => throw new NotImplementedException();

        public IPaymentRepository Payment => throw new NotImplementedException();

        public IRatingRepository Rating => throw new NotImplementedException();

        public ITagRepository Tag => throw new NotImplementedException();

        public IShippingDetailRepository ShippingDetail => throw new NotImplementedException();



     


    }
}
