using YZBlazorServerApp.Datas.Models.Abstracts;

namespace YZBlazorServerApp.Datas.Models.Items.Configurations
{
    public abstract class ConfigBaseAbs : AuditableModel, IConfigBase
    {
        public string? ConfigCode { get; set; }
        public decimal ConfigPriceMultiplier { get; set; } = 1;
        public string? ConfigImageUrl { get; set; }
        public string? ConfigDescription { get; set; }
        public bool ConfigIsDefault { get; set; }
    }
}
