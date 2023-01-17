namespace YZBlazorServerApp.Datas.Services
{
    public static class ProgramExtensions
    {
        public static void AddDbServices(this IServiceCollection services)
        {
            services.AddTransient<DbServices>();
        }

        /// <summary>
        /// DB service includes initializing and update of data for db
        /// </summary>
        public static void UseDbServices(this IServiceProvider serviceProvider)
        {
            var initializer = serviceProvider.GetRequiredService<DbServices>();

            // To initialize db
            initializer.InitializeItemsForDevelopment();

            // To Update db
        }
    }
}
