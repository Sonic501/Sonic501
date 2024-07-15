using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class AccountService : BaseService, IAccountService
    {
        public Task<IActionResult> CreateAccount(AccountCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetAccount(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetAccounts(AccountFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateAccount(Guid id, AccountUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

