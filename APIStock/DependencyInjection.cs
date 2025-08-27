using APIStock.Application;
using APIStock.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace APIStock
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services
                .AddApplication()
                .AddInfrastructure(connectionString);

            return services;
        }
    }
}
