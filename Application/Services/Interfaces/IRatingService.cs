using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IRatingService
    {
        Task<IActionResult> GetRatings(RatingFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetRating(Guid id);
 Task<IActionResult> CreateRating(RatingCreateModel model);
Task<IActionResult> UpdateRating(Guid id, RatingUpdateModel model);
    }
}
