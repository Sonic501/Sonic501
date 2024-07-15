using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/ecommercecontexts")]
    [ApiController]
    public class EcommerceContextsController : ControllerBase
    {
        private readonly IEcommerceContextService _ecommercecontextService;
        public EcommerceContextsController(IEcommerceContextService ecommercecontextService)
        {
            _ecommercecontextService = ecommercecontextService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEcommerceContexts([FromQuery] EcommerceContextFilterModel filter, [FromQuery] PaginationRequestModel pagination)
        {
            try
            {
                return await _ecommercecontextService.GetEcommerceContexts(filter, pagination);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetEcommerceContext([FromRoute] Guid id)
        {
            try
            {
                return await _ecommercecontextService.GetEcommerceContext(id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateEcommerceContext([FromForm] EcommerceContextCreateModel model)
        {
            try
            {
                return await _ecommercecontextService.CreateEcommerceContext(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateEcommerceContext([FromRoute] Guid id, [FromForm] EcommerceContextUpdateModel model)
        {
            try
            {
                return await _ecommercecontextService.UpdateEcommerceContext(id, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

