using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgChestMVC.Application.Interfaces;
using RpgChestMVC.Application.Services;
using System.Reflection;

namespace RpgChestMVC.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication (this IServiceCollection services)
        {
            services.AddTransient<IFullArmorService, ItemService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }

    }
}
