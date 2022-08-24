using Fung.DAL;
using Fung_API.ConfigurationExtensions;
using Fung_API.Middleware;
using Microsoft.EntityFrameworkCore;
using NLog.Extensions.Logging;

namespace Fung_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.RegisterServices(builder.Configuration);
            builder.Services.RegisterAutoMapper();

            //Logger
            builder.Logging.ClearProviders();
            builder.Logging.AddNLog();

            //DB
            builder.Services.AddDbContext<DataContext>(
                o => o.UseNpgsql(builder.Configuration.GetConnectionString("FungDb"),
                b => b.MigrationsAssembly(typeof(DataContext).Assembly.FullName))
                    .EnableDetailedErrors());

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            //DB
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DataContext>();
                if (db.Database.GetPendingMigrations().Any())
                {
                    db.Database.Migrate();
                }
            }

            // Configure the HTTP request pipeline.
            app.UseMiddleware<LogerMiddleware>(app.Logger);


            app.UseCors(builder => builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("Token-Expired")
                .AllowCredentials()
                .WithOrigins("http://localhost:4200"));



            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}