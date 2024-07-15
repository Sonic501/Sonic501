using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class RatingService : BaseService, IRatingService
    {
        public Task<IActionResult> CreateRating(RatingCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetRating(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetRatings(RatingFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateRating(Guid id, RatingUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

