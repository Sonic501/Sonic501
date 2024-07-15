using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/orderproducts")]
    [ApiController]
    public class OrderProductsController : ControllerBase
    {
        private readonly IOrderProductService _orderproductService;
        public OrderProductsController(IOrderProductService orderproductService)
        {
            _orderproductService = orderproductService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderProducts([FromQuery] OrderProductFilterModel filter, [FromQuery] PaginationRequestModel pagination)
        {
            try
            {
                return await _orderproductService.GetOrderProducts(filter, pagination);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOrderProduct([FromRoute] Guid id)
        {
            try
            {
                return await _orderproductService.GetOrderProduct(id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderProduct([FromForm] OrderProductCreateModel model)
        {
            try
            {
                return await _orderproductService.CreateOrderProduct(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateOrderProduct([FromRoute] Guid id, [FromForm] OrderProductUpdateModel model)
        {
            try
            {
                return await _orderproductService.UpdateOrderProduct(id, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

