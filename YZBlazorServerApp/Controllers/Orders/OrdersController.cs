using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YZBlazorServerApp.Datas;
using YZBlazorServerApp.Datas.Models.Orders;

namespace YZBlazorServerApp.Controllers.Orders
{
    [Route("orders")]
    public class OrdersController : ApiBaseController
    {
        private readonly DatabaseContext _db;

        public OrdersController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
            return (await _db.Orders.Include(x => x.OrderLines).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderDetail([FromRoute] Guid id)
        {
            Order? order = await _db.Orders.Include(x => x.OrderLines).FirstOrDefaultAsync(x => x.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        [HttpPost]
        public async Task CreateOrder(Order order)
        {
            //order.CreatedTime = DateTime.Now;

            _db.Orders.Attach(order);
            await _db.SaveChangesAsync();
        }

        [HttpPut]
        public async Task<ActionResult<Order>> UpdateOrder(Order order)
        {
            _db.Entry(order).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return order;
        }
    }
}
