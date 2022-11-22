using Microsoft.Extensions.DependencyInjection;
using RpgChestMVC.Domain.Interfaces;
using RpgChestMVC.Infrastructure.Repositories;

namespace RpgChestMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IFullArmorRepository, FullArmorRepository>();
            services.AddTransient<ISingleItemRepository, SingleItemRepository>();
            return services;
        }

    }
}
