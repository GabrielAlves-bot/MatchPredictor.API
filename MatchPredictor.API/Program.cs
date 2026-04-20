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

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            builder.Services.AddDomainServices();
            builder.Services.AddApplicationServices();
            builder.Services.AddInfraestructureServices(configuration);

            var app = builder.Build();

            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.Run();
        }
    }
}