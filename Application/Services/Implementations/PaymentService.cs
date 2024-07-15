using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.Implementations
{
    public class PaymentService : BaseService, IPaymentService
    {
        public Task<IActionResult> CreatePayment(PaymentCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetPayment(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetPayments(PaymentFilterModel filter, PaginationRequestModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdatePayment(Guid id, PaymentUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}

