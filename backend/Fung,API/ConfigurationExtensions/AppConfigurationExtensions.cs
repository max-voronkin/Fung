using Fung.BLL.Services;
using System.Runtime.CompilerServices;

namespace Fung_API.ConfigurationExtensions
{
    public static class AppConfigurationExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AuthService>();
        }
    }
}
