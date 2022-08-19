using Fung.DAL;
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

            builder.Logging.ClearProviders();
            builder.Logging.AddNLog();


            builder.Services.AddDbContext<DataContext>(
                o => o.UseNpgsql(builder.Configuration.GetConnectionString("TasqueDb"),
                b => b.MigrationsAssembly(typeof(DataContext).Assembly.FullName))
                    .EnableDetailedErrors());

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}