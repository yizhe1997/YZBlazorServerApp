using YZBlazorServerApp.Datas.Models.Abstracts;

namespace YZBlazorServerApp.Datas.Models.Items.Configurations
{
    public abstract class ConfigGroupBaseAbs : AuditableModel, IConfigGroupBase
    {
        public string? ConfigGroupCode { get; set; }
        public string? ConfigGroupDescription { get; set; }
    }
}
