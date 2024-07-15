using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/orderstatuss")]
    [ApiController]
    public class OrderStatussController : ControllerBase
    {
        private readonly IOrderStatusService _orderstatusService;
        public OrderStatussController(IOrderStatusService orderstatusService)
        {
            _orderstatusService = orderstatusService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderStatuss([FromQuery] OrderStatusFilterModel filter, [FromQuery] PaginationRequestModel pagination)
        {
            try
            {
                return await _orderstatusService.GetOrderStatuss(filter, pagination);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOrderStatus([FromRoute] Guid id)
        {
            try
            {
                return await _orderstatusService.GetOrderStatus(id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderStatus([FromForm] OrderStatusCreateModel model)
        {
            try
            {
                return await _orderstatusService.CreateOrderStatus(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateOrderStatus([FromRoute] Guid id, [FromForm] OrderStatusUpdateModel model)
        {
            try
            {
                return await _orderstatusService.UpdateOrderStatus(id, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

