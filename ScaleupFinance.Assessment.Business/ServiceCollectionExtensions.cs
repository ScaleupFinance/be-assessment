using Microsoft.Extensions.DependencyInjection;
using ScaleupFinance.Assessment.Business.Services;

namespace ScaleupFinance.Assesment.Business
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {
            services.AddScoped<IBrandService, BrandService>();
        }
    }
}
