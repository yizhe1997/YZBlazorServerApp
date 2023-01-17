using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YZBlazorServerApp.Datas;
using YZBlazorServerApp.Datas.Models.Users;

namespace YZBlazorServerApp.Controllers.Users.Customers
{
    [Route("customers")]
    public class CustomersController : ApiBaseController
    {
        private readonly DatabaseContext _db;

        public CustomersController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            return (await _db.Customers.ToListAsync());
        }
    }
}
