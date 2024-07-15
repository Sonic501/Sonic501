using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class CommentService : BaseService, ICommentService
    {
        public Task<IActionResult> CreateComment(CommentCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetComment(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetComments(CommentFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateComment(Guid id, CommentUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

