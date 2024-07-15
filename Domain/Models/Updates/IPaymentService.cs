using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Mvc;
namespace Domain.Models.Updates
{
    public interface PaymentService
    {
        Task<IActionResult> GetPayments(PaymentFilterModel filter, PaginationRequestModel pagination);
  Task<IActionResult> GetPayment(Guid id);
 Task<IActionResult> CreatePayment(PaymentCreateModel model);
Task<IActionResult> UpdatePayment(Guid id, PaymentUpdateModel model);
    }
}
