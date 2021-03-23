using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ModularMonolith.Modules.Portfolios.Core;

[assembly:InternalsVisibleTo("ModularMonolith.Bootstrapper")]
namespace ModularMonolith.Modules.Portfolios.Api
{
    internal static class PortfoliosModule
    {
        public static IServiceCollection AddPortfoliosModule(this IServiceCollection services)
        {
            services.AddCore();
            
            return services;
        }

        public static IApplicationBuilder UsePortfoliosModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}