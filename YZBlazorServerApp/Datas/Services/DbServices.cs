using YZBlazorServerApp.Datas.Models.Addresses;
using YZBlazorServerApp.Datas.Models.Items;
using YZBlazorServerApp.Datas.Models.Items.Configurations;
using YZBlazorServerApp.Datas.Models.Users;

namespace YZBlazorServerApp.Datas.Services
{
    /// <summary>
    ///     Functions are classified are classified into 2 regions - one for initializing data for new db 
    ///     and the other to update tables for exisiting db. Primarily used in Program.cs
    /// </summary>
    public class DbServices
    {
        private readonly DatabaseContext _dbContext;
        private readonly ILogger<DbServices> _logger;

        public DbServices(DatabaseContext dbContext, ILogger<DbServices> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        #region Initialize

        // remove after done
        public void InitializeItemsForDevelopment()
        {
            if (_dbContext.Items.Count() == 0)
            {
                var items = new List<Item>()
                {
                    new Item()
                    {
                        ItemPrice = 55.55m,
                        ItemCode = "F00",
                        ItemDescription = "deez nuts",
                        ItemImageUrl = "https://www.mssqltips.com/tipimages2/6269_simple-sql-server-database-diagram.007.png"
                    },
                    new Item()
                    {
                        ItemPrice = 66.55m,
                        ItemCode = "F01",
                        ItemDescription = "anya likes peanutsu",
                        ItemImageUrl = "https://www.mssqltips.com/images/GetFreeSQLTips_black_box.png",
                        ConfigSizeGroups = new List<ConfigSizeGroup>()
                        {
                            new ConfigSizeGroup()
                            {
                                ConfigGroupCode = "D01",
                                ConfigGroupDescription = "dick length",
                                ConfigSizeGroupUnit = "mm",
                                ConfigSizes = new List<ConfigSize>()
                                {
                                    new ConfigSize()
                                    {
                                        ConfigSizeVal = 1,
                                        ConfigCode = "Z01",
                                        ConfigPriceMultiplier = 2,
                                        ConfigImageUrl = "",
                                        ConfigDescription = "smollest pp",
                                        ConfigIsDefault = true
                                    }
                                }
                            },
                            new ConfigSizeGroup()
                            {
                                ConfigGroupCode = "A01",
                                ConfigGroupDescription = "Ass length",
                                ConfigSizeGroupUnit = "mm",
                                ConfigSizes = new List<ConfigSize>()
                                {
                                    new ConfigSize()
                                    {
                                        ConfigSizeVal = 1,
                                        ConfigCode = "X01",
                                        ConfigPriceMultiplier = 3,
                                        ConfigImageUrl = "",
                                        ConfigDescription = "smollest ass"
                                    }
                                }
                            },
                        }
                    }
                };
                _dbContext.Items.AddRange(items);
            }

            if (_dbContext.Customers.Count() == 0)
            {
                var customers = new List<Customer>()
                {
                    new Customer()
                    {
                        FirstName = "sugma",
                        MiddleName = "deez",
                        LastName = "nutz"
                    },
                    new Customer()
                    {
                        FirstName = "sugma2",
                        MiddleName = "deez2",
                        LastName = "nutz2"
                    },
                };
                _dbContext.Customers.AddRange(customers);
            }

            if (_dbContext.Addresses.Count() == 0)
            {
                var addresses = new List<Address>()
                {
                    new Address()
                    {
                        Name = "sugma",
                        Line1 = "deezllllllll",
                        City = "awooga",
                        Region = "umullll",
                        PostalCode = "47000"
                    }
                };
                _dbContext.Addresses.AddRange(addresses);
            }

            _dbContext.SaveChanges();
        }

        #endregion

        #region Update


        #endregion
    }
}
