using Microsoft.Extensions.DependencyInjection;
using ScaleupFinance.Assessment.Data.Repositories;

namespace ScaleupFinance.Assessment.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataLayer(this IServiceCollection services)
        {
            services.AddScoped<IBrandRepository, BrandRepository>();
        }
    }
}
