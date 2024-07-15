using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Domain.Models.Updates
{
    public interface TagService
    {
        Task<IActionResult> GetTags(TagFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetTag(Guid id);
 Task<IActionResult> CreateTag(TagCreateModel model);
Task<IActionResult> UpdateTag(Guid id, TagUpdateModel model);
    }
}
