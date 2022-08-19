using Fung.BLL.Services;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Fung_API.ConfigurationExtensions
{
    public static class AppConfigurationExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<AuthService>();
        }

        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(conf =>
            {
                //conf.AddProfile<UserProfile>();
            },
            Assembly.GetExecutingAssembly());
                
        }
    }
}
