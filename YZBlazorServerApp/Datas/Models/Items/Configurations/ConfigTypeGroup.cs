namespace YZBlazorServerApp.Datas.Models.Items.Configurations
{
    public class ConfigTypeGroup : ConfigGroupBaseAbs
    {
        public List<ConfigType> ConfigTypes { get; set; } = new List<ConfigType>();
    }
}
