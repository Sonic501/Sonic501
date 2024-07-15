using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class OrderService : BaseService, IOrderService
    {
        public Task<IActionResult> CreateOrder(OrderCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetOrder(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetOrders(OrderFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateOrder(Guid id, OrderUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

