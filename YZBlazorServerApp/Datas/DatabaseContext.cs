using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YZBlazorServerApp.Datas.Models.Addresses;
using YZBlazorServerApp.Datas.Models.Items;
using YZBlazorServerApp.Datas.Models.Items.Configurations;
using YZBlazorServerApp.Datas.Models.Orders;
using YZBlazorServerApp.Datas.Models.Users;

namespace YZBlazorServerApp.Datas
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        #region DataSet

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<LineConfigSizeGroup> LineConfigSizeGroups { get; set; }
        public DbSet<LineConfigTypeGroup> LineConfigTypeGroups { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ConfigSizeGroup> ConfigSizeGroups { get; set; }
        public DbSet<ConfigSize> ConfigSizes { get; set; }
        public DbSet<ConfigTypeGroup> ConfigTypeGroups { get; set; }
        public DbSet<ConfigType> ConfigTypes { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DefineDataModels(modelBuilder);
        }

        #region Helpers

        private void DefineDataModels(ModelBuilder modelBuilder)
        {
            #region Item Properties

            //modelBuilder.Entity<Address>();

            #endregion
        }

        #endregion
    }
}