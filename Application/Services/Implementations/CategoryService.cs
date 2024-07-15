using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class CategoryService : BaseService, ICategoryService
    {
        public Task<IActionResult> CreateCategory(CategoryCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetCategory(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetCategorys(CategoryFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateCategory(Guid id, CategoryUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

