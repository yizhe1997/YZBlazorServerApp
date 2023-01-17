using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace YZBlazorServerApp.Infrastructures.EFCore
{
    public static class ProgramExtensions
    {
        public static void AddEFCoreServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<Datas.DatabaseContext>(options =>
            {
                options.UseSqlServer(connectionString);
                options.EnableSensitiveDataLogging(true);
            });
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Datas.DatabaseContext>();
        }

        /// <summary>
        /// The EFCore service is only used to apply latest migration atm.
        /// </summary>
        public static void UseEFCoreServices(this IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<Datas.DatabaseContext>();
            context.Database.Migrate();
        }
    }
}
