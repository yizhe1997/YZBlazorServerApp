using YZBlazorServerApp.Datas.Models.Orders;
using YZBlazorServerApp.Datas.Models.Items;
using YZBlazorServerApp.Datas.Models.Items.Configurations;

namespace YZBlazorServerApp.Pages.Items
{
    public class ItemConfigDialogService
    {
        public Item? ConfiguringItem { get; private set; }
        public bool ShowingConfigureDialog { get; private set; }
        public Datas.Models.Orders.Order Order { get; private set; } = new Datas.Models.Orders.Order();
        public Dictionary<ConfigSizeGroup, ConfigSize> ConfigSizeGroupConfigSizeDict { get; set; } = new Dictionary<ConfigSizeGroup, ConfigSize>();
        public Dictionary<ConfigTypeGroup, ConfigType> ConfigTypeGroupGonfigTypeDict { get; set; } = new Dictionary<ConfigTypeGroup, ConfigType>();

        public void DisplayItemConfigurationDialog(Item item)
        {
            ConfiguringItem = item;

            ConfigSizeGroupConfigSizeDict = ConfiguringItem.GetConfigSizeGroupDefaultsDict();
            ConfigTypeGroupGonfigTypeDict = ConfiguringItem.GetConfigTypeGroupDefaultsDict();

            ShowingConfigureDialog = true;
        }

        public void ResetOrder()
        {
            Order = new Datas.Models.Orders.Order();
        }

        public void CancelConfigurationDialog()
        {
            ConfiguringItem = null;

            ShowingConfigureDialog = false;
        }

        // on selecting a value from the drop down update the dictionary of ....
        public void OnSelectConfiguration()
        {

        }

        public void RemoveConfiguredItemFromCart(OrderLine line)
        {
            Order.OrderLines.Remove(line);
        }

        public void AddToCartFromConfigDialog()
        {
            #region Mapping configurations

            List<LineConfigSizeGroup> lineConfigSizeGroups = new List<LineConfigSizeGroup>();
            List<LineConfigTypeGroup> lineConfigTypeGroups = new List<LineConfigTypeGroup>();

            foreach (var item in ConfigSizeGroupConfigSizeDict)
            {
                lineConfigSizeGroups.Add
                    (
                        new LineConfigSizeGroup
                        {
                            ConfigGroupCode = item.Key.ConfigGroupCode,
                            ConfigGroupDescription = item.Key.ConfigGroupCode,
                            ConfigSizeGroupId = item.Key.Id,

                            ConfigCode = item.Value.ConfigCode,
                            ConfigPriceMultiplier = item.Value.ConfigPriceMultiplier,
                            ConfigImageUrl = item.Value.ConfigImageUrl,
                            ConfigDescription = item.Value.ConfigCode,
                            ConfigIsDefault = item.Value.ConfigIsDefault,
                            ConfigSizeId = item.Value.Id
                        }
                    );
            }

            foreach (var item in ConfigTypeGroupGonfigTypeDict)
            {
                lineConfigTypeGroups.Add
                    (
                        new LineConfigTypeGroup
                        {
                            ConfigGroupCode = item.Key.ConfigGroupCode,
                            ConfigGroupDescription = item.Key.ConfigGroupCode,
                            ConfigTypeGroupId = item.Key.Id,

                            ConfigCode = item.Value.ConfigCode,
                            ConfigPriceMultiplier = item.Value.ConfigPriceMultiplier,
                            ConfigImageUrl = item.Value.ConfigImageUrl,
                            ConfigDescription = item.Value.ConfigCode,
                            ConfigIsDefault = item.Value.ConfigIsDefault,
                            ConfigTypeId = item.Value.Id
                        }
                    );
            }


            #endregion
            
            decimal defaultQty = 1;
            decimal unitPrice;
            Order.OrderLines.Add
                (
                    new OrderLine
                    {
                        ItemId = ConfiguringItem?.Id ?? Guid.Empty,
                        ItemPrice = ConfiguringItem?.ItemPrice ?? 0,
                        ItemCode = ConfiguringItem?.ItemCode,
                        ItemDescription = ConfiguringItem?.ItemDescription,
                        ItemImageUrl = ConfiguringItem?.ItemImageUrl,
                        LineConfigSizeGroups = lineConfigSizeGroups,
                        LineConfigTypeGroups = lineConfigTypeGroups,
                        Qty = defaultQty, // let user change this in dialog also
                        UnitPrice = unitPrice = ConfiguringItem?.GetUnitPrice(ConfigSizeGroupConfigSizeDict, ConfigTypeGroupGonfigTypeDict) ?? 0,
                        TotalPrice = unitPrice * defaultQty
                    }
                );

            ConfiguringItem = null;

            ShowingConfigureDialog = false;
        }
    }
}
