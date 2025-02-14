using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Domain.Models.Updates
{
    public interface CommentService
    {
        Task<IActionResult> GetComments(CommentFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetComment(Guid id);
 Task<IActionResult> CreateComment(CommentCreateModel model);
Task<IActionResult> UpdateComment(Guid id, CommentUpdateModel model);
    }
}
