using Commander.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Commander.Configurations {
    public static class ConfigureConnections {
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services,
            IConfiguration configuration) {
            var builder = new SqlConnectionStringBuilder(configuration.GetConnectionString("CommanderDB")) {
                Password = configuration.GetValue<string>("DataBase:Pwd"),
                UserID = configuration.GetValue<string>("DataBase:User")
            };
            services.AddDbContextPool<CommanderContext>(options => options.UseSqlServer(builder.ConnectionString));
            return services;
        }
    }
}
