using MatchPredictor.Application.Services;
using MatchPredictor.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MatchPredictor.Application
{
    public static class DependencyInjection
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IMatchAppService, MatchAppService>();
        }
    }
}