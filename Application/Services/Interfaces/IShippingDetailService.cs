using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IShippingDetailService
    {
        Task<IActionResult> GetShippingDetails(ShippingDetailFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetShippingDetail(Guid id);
 Task<IActionResult> CreateShippingDetail(ShippingDetailCreateModel model);
Task<IActionResult> UpdateShippingDetail(Guid id, ShippingDetailUpdateModel model);
    }
}
