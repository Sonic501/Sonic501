using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class TagService : BaseService, ITagService
    {
        public Task<IActionResult> CreateTag(TagCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetTag(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetTags(TagFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateTag(Guid id, TagUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

