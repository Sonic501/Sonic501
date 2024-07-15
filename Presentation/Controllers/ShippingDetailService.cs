using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/shippingdetails")]
    [ApiController]
    public class ShippingDetailsController : ControllerBase
    {
        private readonly IShippingDetailService _shippingdetailService;
        public ShippingDetailsController(IShippingDetailService shippingdetailService)
        {
            _shippingdetailService = shippingdetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetShippingDetails([FromQuery] ShippingDetailFilterModel filter, [FromQuery] PaginationRequestModel pagination)
        {
            try
            {
                return await _shippingdetailService.GetShippingDetails(filter, pagination);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetShippingDetail([FromRoute] Guid id)
        {
            try
            {
                return await _shippingdetailService.GetShippingDetail(id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateShippingDetail([FromForm] ShippingDetailCreateModel model)
        {
            try
            {
                return await _shippingdetailService.CreateShippingDetail(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateShippingDetail([FromRoute] Guid id, [FromForm] ShippingDetailUpdateModel model)
        {
            try
            {
                return await _shippingdetailService.UpdateShippingDetail(id, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

