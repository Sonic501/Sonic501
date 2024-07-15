using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IOrderProductService
    {
        Task<IActionResult> GetOrderProducts(OrderProductFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetOrderProduct(Guid id);
 Task<IActionResult> CreateOrderProduct(OrderProductCreateModel model);
Task<IActionResult> UpdateOrderProduct(Guid id, OrderProductUpdateModel model);
    }
}
