using YZBlazorServerApp.Datas.Models.Abstracts;
using YZBlazorServerApp.Datas.Models.Items.Configurations;

namespace YZBlazorServerApp.Datas.Models.Items
{
    public class Item : AuditableModel , IItem
    {
        public decimal ItemPrice { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemImageUrl { get; set; }

        #region Properties

        public List<ConfigSizeGroup> ConfigSizeGroups { get; set; } = new List<ConfigSizeGroup>();
        public List<ConfigTypeGroup> ConfigTypeGroups { get; set; } = new List<ConfigTypeGroup>();

        #endregion

        #region Helpers

        // Finance
        public string GetFormattedTotalPrice(decimal qty, Dictionary<ConfigSizeGroup, ConfigSize> configSizeGroupConfigSizeDict, Dictionary<ConfigTypeGroup, ConfigType> configTypeGroupGonfigTypeDict) =>
            GetTotalPrice(qty, configSizeGroupConfigSizeDict, configTypeGroupGonfigTypeDict).ToString("0.00");
        public decimal GetTotalPrice(decimal qty, Dictionary<ConfigSizeGroup, ConfigSize> configSizeGroupConfigSizeDict, Dictionary<ConfigTypeGroup, ConfigType> configTypeGroupGonfigTypeDict) =>
            GetUnitPrice(configSizeGroupConfigSizeDict, configTypeGroupGonfigTypeDict) * qty;
        public string GetFormattedUnitPrice(Dictionary<ConfigSizeGroup, ConfigSize> configSizeGroupConfigSizeDict, Dictionary<ConfigTypeGroup, ConfigType> configTypeGroupGonfigTypeDict) =>
            GetUnitPrice(configSizeGroupConfigSizeDict, configTypeGroupGonfigTypeDict).ToString("0.00");
        public decimal GetUnitPrice(Dictionary<ConfigSizeGroup, ConfigSize> configSizeGroupConfigSizeDict, Dictionary<ConfigTypeGroup, ConfigType> configTypeGroupGonfigTypeDict) =>
            (GetConfigSizePriceMultipliersTotal(configSizeGroupConfigSizeDict) * GetConfigTypePriceMultipliersTotal(configTypeGroupGonfigTypeDict) * ItemPrice);
        public decimal GetConfigSizePriceMultipliersTotal(Dictionary<ConfigSizeGroup, ConfigSize> configSizeGroupConfigSizeDict)
        {
            decimal multiplier = 1;

            if (!configSizeGroupConfigSizeDict.Any())
                configSizeGroupConfigSizeDict = GetConfigSizeGroupDefaultsDict();

            foreach (var rec in configSizeGroupConfigSizeDict)
            {
                multiplier *= GetConfigSizePriceMultiplier(rec.Key.Id, rec.Value.Id);
            }

            return multiplier;
        }
        public decimal GetConfigTypePriceMultipliersTotal(Dictionary<ConfigTypeGroup, ConfigType> configTypeGroupGonfigTypeDict)
        {
            decimal multiplier = 1;

            if (!configTypeGroupGonfigTypeDict.Any())
                configTypeGroupGonfigTypeDict = GetConfigTypeGroupDefaultsDict();

            foreach (var rec in configTypeGroupGonfigTypeDict)
            {
                multiplier *= GetConfigTypePriceMultiplier(rec.Key.Id, rec.Value.Id);
            }

            return multiplier;
        }
        public decimal GetConfigSizePriceMultiplier(Guid configSizeGroupId, Guid configSizeId = default(Guid)) =>
            ConfigSizeGroups.FirstOrDefault(x => x.Id == configSizeGroupId)?.ConfigSizes.FirstOrDefault(x => x.Id == configSizeId)?.ConfigPriceMultiplier ?? 1;
        public decimal GetConfigTypePriceMultiplier(Guid configTypeGroupId, Guid configTypeId = default(Guid)) =>
            ConfigTypeGroups.FirstOrDefault(x => x.Id == configTypeGroupId)?.ConfigTypes.FirstOrDefault(x => x.Id == configTypeId)?.ConfigPriceMultiplier ?? 1;

        // Configs
        public Dictionary<ConfigSizeGroup, ConfigSize> GetConfigSizeGroupDefaultsDict()
        {
            Dictionary<ConfigSizeGroup, ConfigSize> configSizeGroupIdConfigSizeIdDict = new Dictionary<ConfigSizeGroup, ConfigSize>();

            foreach (var configSizeGroup in ConfigSizeGroups)
            {
                configSizeGroupIdConfigSizeIdDict.Add(configSizeGroup, GetConfigSizeDefault(configSizeGroup));
            }

            return configSizeGroupIdConfigSizeIdDict;
        }
        public Dictionary<ConfigTypeGroup, ConfigType> GetConfigTypeGroupDefaultsDict()
        {
            Dictionary<ConfigTypeGroup, ConfigType> configTypeGroupIdConfigTypeIdDict = new Dictionary<ConfigTypeGroup, ConfigType>();

            foreach (var ConfigTypeGroup in ConfigTypeGroups)
            {
                configTypeGroupIdConfigTypeIdDict.Add(ConfigTypeGroup, GetConfigTypeDefault(ConfigTypeGroup));
            }

            return configTypeGroupIdConfigTypeIdDict;
        }
        public ConfigSize GetConfigSizeDefault(ConfigSizeGroup configSizeGroup)
        {
            return configSizeGroup?.ConfigSizes?.FirstOrDefault(x => x.ConfigIsDefault == true) ??
                configSizeGroup?.ConfigSizes?.FirstOrDefault() ?? 
                new ConfigSize();
        }
        public ConfigType GetConfigTypeDefault(ConfigTypeGroup configTypeGroup)
        {
            return configTypeGroup?.ConfigTypes?.FirstOrDefault(x => x.ConfigIsDefault == true) ??
                configTypeGroup?.ConfigTypes?.FirstOrDefault() ?? 
                new ConfigType();
        }
        public bool HasConfigs() => ConfigSizeGroups.Any() || ConfigTypeGroups.Any();

        #endregion
    }
}
