using Commander.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Commander.Configurations {
    public static class ServicesConfiguration {
        public static void ConfigureRepositories(this IServiceCollection services) {
            services.AddScoped<ICommanderRepository, CommanderSqlRepository>();
        }
    }
}
