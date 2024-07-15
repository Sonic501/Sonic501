using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Domain.Models.Updates
{
    public interface EcommerceContextService
    {
        Task<IActionResult> GetEcommerceContexts(EcommerceContextFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetEcommerceContext(Guid id);
 Task<IActionResult> CreateEcommerceContext(EcommerceContextCreateModel model);
Task<IActionResult> UpdateEcommerceContext(Guid id, EcommerceContextUpdateModel model);
    }
}
