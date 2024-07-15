using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Domain.Models.Updates
{
    public interface AddressService
    {
        Task<IActionResult> GetAddresss(AddressFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetAddress(Guid id);
 Task<IActionResult> CreateAddress(AddressCreateModel model);
Task<IActionResult> UpdateAddress(Guid id, AddressUpdateModel model);
    }
}
