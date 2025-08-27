using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIStock.Core
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            // Add application services here, e.g.:
            // services.AddTransient<IMyService, MyService>();
            return services;
        }
    }
}
