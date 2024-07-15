using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Application.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<IActionResult> GetPayments(PaymentFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetPayment(Guid id);
 Task<IActionResult> CreatePayment(PaymentCreateModel model);
Task<IActionResult> UpdatePayment(Guid id, PaymentUpdateModel model);
    }
}
