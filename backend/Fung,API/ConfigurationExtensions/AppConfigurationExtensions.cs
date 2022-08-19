using Fung.BLL.JWT;
using Fung.BLL.MappingProfiles;
using Fung.BLL.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Fung_API.ConfigurationExtensions
{
    public static class AppConfigurationExtensions
    {
        public static void ConfigureJwt(this IServiceCollection services, IConfiguration configuration)
        {
            var secretKey = configuration["JwtIssuerOptions:Key"];
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey));

            var jwtOptions = configuration.GetSection("JwtIssuerOptions");

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = jwtOptions["Issuer"],

                        ValidateAudience = true,
                        ValidAudience = jwtOptions["Audience"],

                        ValidateIssuerSigningKey = true,
                        ValidateLifetime = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions["Key"]))
                    };

                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context =>
                        {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                                context.Response.Headers.Add("Token-expired", "true");

                            return System.Threading.Tasks.Task.CompletedTask;
                        }
                    };
                });
        }

        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtIssuerOptions = new JwtIssuerOptions();
            configuration.GetSection("JwtIssuerOptions").Bind(jwtIssuerOptions);
            services.AddSingleton(jwtIssuerOptions);
            services.ConfigureJwt(configuration);
            services.AddScoped<JwtFactory>();

            services.AddScoped<AuthService>();
            services.AddScoped<UserService>();
   
        }

        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(conf =>
            {
                conf.AddProfile<UserMappingProfile>();
            },
            Assembly.GetExecutingAssembly()); 
        }
    }
}
