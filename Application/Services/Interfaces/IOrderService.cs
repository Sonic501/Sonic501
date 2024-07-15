using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IOrderService
    {
        Task<IActionResult> GetOrders(OrderFilterModel filter, PaginationRequestModel pagination);
        Task<IActionResult> GetOrder(Guid id);
        Task<IActionResult> CreateOrder(OrderCreateModel model);
        Task<IActionResult> UpdateOrder(Guid id, OrderUpdateModel model);
    }
}
