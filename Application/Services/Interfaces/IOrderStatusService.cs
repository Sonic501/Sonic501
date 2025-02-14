using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IOrderStatusService
    {
        Task<IActionResult> GetOrderStatuss(OrderStatusFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetOrderStatus(Guid id);
 Task<IActionResult> CreateOrderStatus(OrderStatusCreateModel model);
Task<IActionResult> UpdateOrderStatus(Guid id, OrderStatusUpdateModel model);
    }
}
