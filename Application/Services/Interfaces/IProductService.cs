using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<IActionResult> GetProducts(ProductFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetProduct(Guid id);
 Task<IActionResult> CreateProduct(ProductCreateModel model);
Task<IActionResult> UpdateProduct(Guid id, ProductUpdateModel model);
    }
}
