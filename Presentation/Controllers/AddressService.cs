using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/addresss")]
    [ApiController]
    public class AddresssController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddresssController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAddresss([FromQuery] AddressFilterModel filter, [FromQuery] PaginationRequestModel pagination)
        {
            try
            {
                return await _addressService.GetAddresss(filter, pagination);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAddress([FromRoute] Guid id)
        {
            try
            {
                return await _addressService.GetAddress(id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress([FromForm] AddressCreateModel model)
        {
            try
            {
                return await _addressService.CreateAddress(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateAddress([FromRoute] Guid id, [FromForm] AddressUpdateModel model)
        {
            try
            {
                return await _addressService.UpdateAddress(id, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

