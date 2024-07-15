using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class AddressService : BaseService, IAddressService
    {
        public Task<IActionResult> CreateAddress(AddressCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetAddress(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetAddresss(AddressFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateAddress(Guid id, AddressUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

