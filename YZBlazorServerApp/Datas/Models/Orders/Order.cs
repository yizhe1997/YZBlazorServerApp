using System.ComponentModel.DataAnnotations;
using YZBlazorServerApp.Datas.Models.Abstracts;
using YZBlazorServerApp.Datas.Models.Addresses;
using YZBlazorServerApp.Datas.Models.Users;

namespace YZBlazorServerApp.Datas.Models.Orders
{
    public class Order : AuditableModel
    {
        [Required]
        public Customer? Customer { get; set; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public Address? DeliveryAddress { get; set; }
        public string? DeliveryStatus { get; set; }

        #region Helpers

        public decimal GetTotalPrice() => OrderLines.Sum(p => p.TotalPrice);
        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");

        #endregion
    }
}
