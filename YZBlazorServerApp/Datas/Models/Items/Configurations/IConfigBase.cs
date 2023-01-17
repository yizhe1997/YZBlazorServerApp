namespace YZBlazorServerApp.Datas.Models.Items.Configurations
{
    public interface IConfigBase
    {
        public string? ConfigCode { get; set; }
        public decimal ConfigPriceMultiplier { get; set; }
        public string? ConfigImageUrl { get; set; }
        public string? ConfigDescription { get; set; }
        public bool ConfigIsDefault { get; set; }
    }
}
