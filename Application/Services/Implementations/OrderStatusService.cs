using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class OrderStatusService : BaseService, IOrderStatusService
    {
        public Task<IActionResult> CreateOrderStatus(OrderStatusCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetOrderStatus(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetOrderStatuss(OrderStatusFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateOrderStatus(Guid id, OrderStatusUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

