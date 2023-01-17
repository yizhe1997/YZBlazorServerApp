using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YZBlazorServerApp.Datas;
using YZBlazorServerApp.Datas.Models.Addresses;

namespace YZBlazorServerApp.Controllers.Addresses
{
    [Route("addresses")]
    public class AddressesController : ApiBaseController
    {
        private readonly DatabaseContext _db;

        public AddressesController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAddresses()
        {
            return (await _db.Addresses.ToListAsync());
        }
    }
}
