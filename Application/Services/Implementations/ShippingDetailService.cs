using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class ShippingDetailService : BaseService, IShippingDetailService
    {
        public Task<IActionResult> CreateShippingDetail(ShippingDetailCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetShippingDetail(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetShippingDetails(ShippingDetailFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateShippingDetail(Guid id, ShippingDetailUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

