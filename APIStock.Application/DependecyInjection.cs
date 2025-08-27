using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIStock.Core.Entities;
using APIStock.Core.Interfaces;


namespace APIStock.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<StockService>(); // Inyectable
            return services;
        }
    }
}


