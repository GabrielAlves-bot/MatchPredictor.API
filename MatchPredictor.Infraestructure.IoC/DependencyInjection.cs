using MatchPredictor.Infraestructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MatchPredictor.Infraestructure.IoC
{
    public static class DependencyInjection
    {
        public static void AddInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureIfraData(configuration);
        }
    }
}