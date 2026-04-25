using MatchPredictor.Domain.Builders;
using MatchPredictor.Domain.Builders.Interfaces;
using MatchPredictor.Domain.Services;
using MatchPredictor.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MatchPredictor.Domain
{
    public static class DependencyInjection
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            //Services
            services.AddScoped<IMatchService, MatchService>();
            services.AddScoped<IGuessService, GuessService>();

            //Builders
            services.AddScoped<IGuessBuilder, GuessBuilder>();
        }
    }
}