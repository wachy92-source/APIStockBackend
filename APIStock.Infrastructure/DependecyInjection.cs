using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using APIStock.Infrastructure.Repositories;
using APIStock.Core.Interfaces;


namespace APIStock.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            // Registramos IStockRepository con StockRepository
            services.AddScoped<IStockRepository>(sp => new StockRepository(connectionString));
            return services;
        }
    }
}

