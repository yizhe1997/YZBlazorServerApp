namespace YZBlazorServerApp.Datas.Models.Items
{
    public interface IItem
    {
        public decimal ItemPrice { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemImageUrl { get; set; }
    }
}
