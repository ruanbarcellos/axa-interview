using AXA.Domain.Repository;
using AXA.Domain.Service;
using AXA.Infrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace AXA.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        /// <summary>
        /// Maps all interfaces to its implementations
        /// For .net core DependencyInjection container
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterMapping(this IServiceCollection services)
        {
            services
                .AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services
                .AddScoped<ITransactionService, TransactionService>()
                .AddScoped<ITransactionRepository, TransactionRepository>();
        }
    }
}
