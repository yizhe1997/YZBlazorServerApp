using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YZBlazorServerApp.Datas;
using YZBlazorServerApp.Datas.Models.Items;

namespace YZBlazorServerApp.Controllers.Items
{
    [Route("items")]
    public class ItemsController : ApiBaseController
    {
        private readonly DatabaseContext _db;

        public ItemsController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetItems()
        {
            return (await _db.Items
                .Include(x => x.ConfigSizeGroups)
                .ThenInclude(x => x.ConfigSizes)
                .Include(x => x.ConfigTypeGroups)
                .ThenInclude(x => x.ConfigTypes)
                .ToListAsync())
                .OrderByDescending(s => s.ItemDescription)
                .ToList();
        }
    }
}
