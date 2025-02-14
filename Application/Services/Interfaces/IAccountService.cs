using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IAccountService
    {
        Task<IActionResult> GetAccounts(AccountFilterModel filter, PaginationRequestModel pagination);
        Task<IActionResult> GetAccount(Guid id);
        Task<IActionResult> CreateAccount(AccountCreateModel model);
        Task<IActionResult> UpdateAccount(Guid id, AccountUpdateModel model);
    }
}
