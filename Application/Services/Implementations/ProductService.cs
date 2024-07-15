using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class ProductService : BaseService, IProductService
    {
        public Task<IActionResult> CreateProduct(ProductCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetProducts(ProductFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateProduct(Guid id, ProductUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

