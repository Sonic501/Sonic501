using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class OrderProductService : BaseService, IOrderProductService
    {
        public Task<IActionResult> CreateOrderProduct(OrderProductCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetOrderProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetOrderProducts(OrderProductFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateOrderProduct(Guid id, OrderProductUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

