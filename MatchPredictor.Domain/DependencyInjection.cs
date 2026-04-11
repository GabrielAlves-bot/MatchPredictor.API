using MatchPredictor.Domain.Interfaces;
using MatchPredictor.Domain.Services;
using MatchPredictor.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MatchPredictor.Domain
{
    public static class DependencyInjection
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IMatchService, MatchService>();
        }
    }
}