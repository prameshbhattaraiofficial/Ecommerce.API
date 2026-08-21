using Ecommerce.Infrastructure;

namespace Ecommerce.API
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddApiDI(this IServiceCollection services)
        {

            services.AddApiDI().AddInfrastructureDI();
            // Register application services here
            return services;
        }
    }
}
