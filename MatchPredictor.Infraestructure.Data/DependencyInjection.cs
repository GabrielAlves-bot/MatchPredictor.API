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
            options.UseSqlServer(configuration.GetConnectionString("DBConnection")));

            services.AddScoped<IMatchProvider, MatchProvider>();
            services.AddScoped<IMatchRepository, MatchRepository>();
        }
    }
}