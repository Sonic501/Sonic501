using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Domain.Models.Updates
{
    public interface CategoryService
    {
        Task<IActionResult> GetCategorys(CategoryFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetCategory(Guid id);
 Task<IActionResult> CreateCategory(CategoryCreateModel model);
Task<IActionResult> UpdateCategory(Guid id, CategoryUpdateModel model);
    }
}
