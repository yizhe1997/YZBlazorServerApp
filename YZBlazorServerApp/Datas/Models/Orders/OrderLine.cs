using System.ComponentModel.DataAnnotations;
using YZBlazorServerApp.Datas.Models.Abstracts;
using YZBlazorServerApp.Datas.Models.Items;
using YZBlazorServerApp.Datas.Models.Items.Configurations;

namespace YZBlazorServerApp.Datas.Models.Orders
{
    public class OrderLine : AuditableModel, IItem
    {
        public Guid ItemId { get; set; }

        #region IItem

        public decimal ItemPrice { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemImageUrl { get; set; }

        #endregion

        public decimal Qty { get; set; }
        public List<LineConfigSizeGroup> LineConfigSizeGroups { get; set; } = new List<LineConfigSizeGroup>();
        public List<LineConfigTypeGroup> LineConfigTypeGroups { get; set; } = new List<LineConfigTypeGroup>();
        public decimal TotalPrice { get; set; }
        public decimal UnitPrice { get; set; }

        #region Helpers

        public string GetFormattedUnitPrice() => UnitPrice.ToString("0.00");
        public string GetFormattedTotalPrice() => TotalPrice.ToString("0.00");

        #endregion
    }

    public class LineConfigSizeGroup : BaseModel, IConfigBase, IConfigGroupBase
    {
        public string? ConfigGroupCode { get; set; }
        public string? ConfigGroupDescription { get; set; }
        public Guid ConfigSizeGroupId { get; set; }

        public string? ConfigCode { get; set; }
        public decimal ConfigPriceMultiplier { get; set; } = 1;
        public string? ConfigImageUrl { get; set; }
        public string? ConfigDescription { get; set; }
        public bool ConfigIsDefault { get; set; }
        public Guid ConfigSizeId { get; set; }
    }

    public class LineConfigTypeGroup : BaseModel, IConfigBase, IConfigGroupBase
    {
        public string? ConfigGroupCode { get; set; }
        public string? ConfigGroupDescription { get; set; }
        public Guid ConfigTypeGroupId { get; set; }

        public string? ConfigCode { get; set; }
        public decimal ConfigPriceMultiplier { get; set; } = 1;
        public string? ConfigImageUrl { get; set; }
        public string? ConfigDescription { get; set; }
        public bool ConfigIsDefault { get; set; }
        public Guid ConfigTypeId { get; set; }
    }
}
