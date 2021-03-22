using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

[assembly:InternalsVisibleTo("ModularMonolith.Bootstrapper")]
namespace ModularMonolith.Modules.Portfolios.Api
{
    internal static class PortfoliosModule
    {
        public static IServiceCollection AddPortfoliosModule(this IServiceCollection services)
        {
            return services;
        }

        public static IApplicationBuilder UsePortfoliosModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}