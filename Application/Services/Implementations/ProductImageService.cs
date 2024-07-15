using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class ProductImageService : BaseService, IProductImageService
    {
        public Task<IActionResult> CreateProductImage(ProductImageCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetProductImage(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetProductImages(ProductImageFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateProductImage(Guid id, ProductImageUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

