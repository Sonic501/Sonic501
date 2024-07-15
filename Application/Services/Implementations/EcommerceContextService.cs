using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class EcommerceContextService : BaseService, IEcommerceContextService
    {
        public Task<IActionResult> CreateEcommerceContext(EcommerceContextCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetEcommerceContext(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetEcommerceContexts(EcommerceContextFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateEcommerceContext(Guid id, EcommerceContextUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

