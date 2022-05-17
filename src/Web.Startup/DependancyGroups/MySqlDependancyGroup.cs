namespace Web.Startup.DependancyGroups
{
    using Web.Data.Persistence;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class MySqlDependancyGroup : IDependancyGroup
    {
        private IConfiguration Configuration { get; }

        public MySqlDependancyGroup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void RegisterDependancies(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<Context>(
                options => options.UseMySQL(Configuration.GetConnectionString("DefaultConnection"),
                    options => options.MigrationsAssembly("Web.Data"))
            );

            // register database repositories here.
        }
    }
}