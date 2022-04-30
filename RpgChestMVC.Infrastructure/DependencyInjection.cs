using Microsoft.Extensions.DependencyInjection;
using RpgChestMVC.Domain.Interfaces;
using RpgChestMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChestMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IItemRepository, ItemRepository>();
            return services;
        }

    }
}
