using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IProductImageService
    {
        Task<IActionResult> GetProductImages(ProductImageFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetProductImage(Guid id);
 Task<IActionResult> CreateProductImage(ProductImageCreateModel model);
Task<IActionResult> UpdateProductImage(Guid id, ProductImageUpdateModel model);
    }
}
