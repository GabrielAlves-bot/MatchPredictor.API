using MatchPredictor.Domain.Interfaces;
using MatchPredictor.Infraestructure.Data.Context;
using MatchPredictor.Infraestructure.Data.Providers;
using MatchPredictor.Infraestructure.Data.Repositorys;
using MatchPredictor.Infraestructure.Data.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MatchPredictor.Infraestructure.Data
{
    public static class DependencyInjection
    {
        public static void ConfigureIfraData(this IServiceCollection services, IConfiguration configuration)
        {
            //Contexts
            services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DBConnection")));

            //Providers
            services.AddScoped<IMatchProvider, MatchProvider>();
            services.AddScoped<IGuessProvider, GuessProvider>();

            //Repositorys
            services.AddScoped<IMatchRepository, MatchRepository>();
            services.AddScoped<IGuessRepository, GuessRepository>();
        }
    }
}