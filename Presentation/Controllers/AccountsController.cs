using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly EcommerceContext _context;
        public AccountsController(EcommerceContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccount()
        {
            return await _context.Accounts.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> CreateAcount()
        {
            Account acc = new Account();
            acc.Id = Guid.NewGuid();
            acc.FirstName = "Nguyen Thi";
            acc.LastName = "Minh Chau";
            acc.Email = "sonic@gmail.com";
            acc.Role = "Admin";

            _context.Accounts.Add(acc);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}