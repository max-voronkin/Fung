using Fung.BLL.Hubs;
using Fung.BLL.JWT;
using Fung.BLL.MappingProfiles;
using Fung.BLL.Options;
using Fung.BLL.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using SendGrid.Extensions.DependencyInjection;
using Fung.BLL.Email;
using Fung.BLL.Services.Email;
using Mailjet.Client;

namespace Fung_API.ConfigurationExtensions
{
    public static class AppConfigurationExtensions
    {
        public static void ConfigureJwt(this IServiceCollection services, IConfiguration configuration)
        {
            var secretKey = configuration["JwtIssuerOptions:Key"];
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey));

            var jwtOptions = configuration.GetSection(nameof(JwtIssuerOptions));

            // Configure JwtIssuerOptions
            services.Configure<JwtIssuerOptions>(options =>
            {
                options.SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            });

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,

                ValidateAudience = false,

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                RequireExpirationTime = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(configureOptions =>
            {
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;

                configureOptions.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("Token-Expired", "true");
                        }
                        return Task.CompletedTask;
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

            services.AddSwagger();

            services.AddScoped<AuthService>();
            services.AddScoped<UserService>();
            services.AddScoped<StationService>();
            services.AddScoped<TankService>();
            services.AddScoped<LevelTransactionService>();
            services.AddScoped<InputService>();
            services.AddScoped<SettingsService>();
            services.AddScoped<IEmailService, MailJetEmailService>();

            services.AddScoped<LastLevelTransactionHub>();

        }

        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(conf =>
            {
                conf.AddProfile<UserMappingProfile>();
                conf.AddProfile<StationMappingProfile>();
                conf.AddProfile<FuelTankMappingProfile>();
                conf.AddProfile<LevelIndicatorMappingProfile>();
                conf.AddProfile<RemainingTransactionsMappingProfile>();
                conf.AddProfile<SettingsMappingProfile>();
            },
            Assembly.GetExecutingAssembly());
        }

        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then " +
                    "your token in the text input below.",
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Fung.API", Version = "v1" });
            });
        }

        public static void ConfigureEmailServices(this IServiceCollection services, IConfiguration configuration)
        {
            var emailOptions = new EmailOptions();
            configuration.GetSection("EmailOptions").Bind(emailOptions);
            services.AddSingleton(emailOptions);

            #region SendGrid

            //var options = new SendGridOptions();
            //configuration.GetSection(nameof(SendGridOptions)).Bind(options);
            //services.AddSendGrid(opt =>
            //{
            //    opt.ApiKey = options.ApiKey;
            //});

            #endregion

            #region MailJet 

            var mailJetOptions = new MailJetOptions();
            var section = configuration.GetSection("MailJetOptions");
            section.Bind(mailJetOptions);
            services.AddSingleton(mailJetOptions);

            services.AddHttpClient<IMailjetClient, MailjetClient>(client =>
            {
                client.SetDefaultSettings();
                client.UseBasicAuthentication(mailJetOptions.ApiKey, mailJetOptions.ApiSecret);
            });
            services.Configure<MailJetOptions>(section);

            #endregion
        }
    }
}
