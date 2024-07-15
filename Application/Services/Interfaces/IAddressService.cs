using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IAddressService
    {
        Task<IActionResult> GetAddresss(AddressFilterModel filter, PaginationRequestModel pagination);
        Task<IActionResult> GetAddress(Guid id);
        Task<IActionResult> CreateAddress(AddressCreateModel model);
        Task<IActionResult> UpdateAddress(Guid id, AddressUpdateModel model);
    }
}
