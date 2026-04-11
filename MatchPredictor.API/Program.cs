using MatchPredictor.Application;
using MatchPredictor.Domain;
using MatchPredictor.Infraestructure.IoC;

namespace MatchPredictor.API
{
    public partial class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            builder.Services.AddDomainServices();
            builder.Services.AddApplicationServices();
            builder.Services.AddInfraestructureServices(configuration);

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}