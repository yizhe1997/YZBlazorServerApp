namespace YZBlazorServerApp.Datas.Models.Items.Configurations
{
    public class ConfigSizeGroup : ConfigGroupBaseAbs
    {
        public string? ConfigSizeGroupUnit { get; set; }
        public List<ConfigSize> ConfigSizes { get; set; } = new List<ConfigSize>();

        #region Helpers

        public virtual decimal GetMaxSize() => ConfigSizes.Any() ? ConfigSizes.Select(x => x.ConfigSizeVal).Max() : 0;
        public virtual decimal GetMinSize() => ConfigSizes.Any() ? ConfigSizes.Select(x => x.ConfigSizeVal).Min() : 0;
        public virtual List<decimal> GetSizeListDesc() => ConfigSizes.Select(x => x.ConfigSizeVal).OrderByDescending(x => x).ToList();
        public virtual string GetFormattedConfigSizeUnitPrice(Guid configSizeId, decimal BasePrice) => (ConfigSizes.FirstOrDefault(x => x.Id == configSizeId)?.ConfigPriceMultiplier * BasePrice)?.ToString("0.00") ?? "0.00";

        #endregion
    }
}
