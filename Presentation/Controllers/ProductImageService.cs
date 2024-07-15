using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/productimages")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageService _productimageService;
        public ProductImagesController(IProductImageService productimageService)
        {
            _productimageService = productimageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductImages([FromQuery] ProductImageFilterModel filter, [FromQuery] PaginationRequestModel pagination)
        {
            try
            {
                return await _productimageService.GetProductImages(filter, pagination);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetProductImage([FromRoute] Guid id)
        {
            try
            {
                return await _productimageService.GetProductImage(id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImage([FromForm] ProductImageCreateModel model)
        {
            try
            {
                return await _productimageService.CreateProductImage(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateProductImage([FromRoute] Guid id, [FromForm] ProductImageUpdateModel model)
        {
            try
            {
                return await _productimageService.UpdateProductImage(id, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

