using Microsoft.Extensions.DependencyInjection;
using ModularMonolith.Modules.Portfolios.Core.DAL.Repositories;
using ModularMonolith.Modules.Portfolios.Core.Repositories;
using ModularMonolith.Modules.Portfolios.Core.Services;

namespace ModularMonolith.Modules.Portfolios.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddScoped<IMemberService, MemberService>();
            services.AddSingleton<IMemberRepository, InMemoryMemberRepository>();
            
            return services;
        }
    }
}