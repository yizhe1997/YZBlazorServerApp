using Microsoft.AspNetCore.Mvc;
using YZBlazorServerApp.Datas;
using YZBlazorServerApp.Datas.Models.Orders;

namespace YZBlazorServerApp.Controllers.Orders.OrderLines
{
    [Route("orderlines")]
    public class OrderLinesController : ApiBaseController
    {
        private readonly DatabaseContext _db;

        public OrderLinesController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateOrderLine(OrderLine orderLine)
        {
            //order.CreatedTime = DateTime.Now;

            _db.OrderLines.Attach(orderLine);
            await _db.SaveChangesAsync();

            return orderLine.Id;
        }

        [HttpDelete]
        public async Task Delete(Guid id)
        {
            OrderLine? orderLine = await _db.OrderLines.FindAsync(id);
            
            if(orderLine != null)
            {
                _db.OrderLines.Remove(orderLine);
                await _db.SaveChangesAsync();
            }
        }
    }
}
