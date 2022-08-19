using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;

namespace Fung_API.Middleware
{
    public class LogerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger logger;

        public LogerMiddleware(RequestDelegate next, ILogger logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception exception)
            {
                switch (exception)
                {
                    default:
                        await HandleAnyException(httpContext, exception);
                        break;
                }
            }
        }

        private async Task HandleAnyException(HttpContext context, Exception ex)
        {
            logger.LogError("{ex.Message}", ex.Message);
            await CreateExceptionAsync(context);
        }

        private async Task CreateExceptionAsync(HttpContext context, HttpStatusCode statusCode = HttpStatusCode.InternalServerError,
            object? errorBody = null)
        {
            errorBody ??= new { error = "Unknown error has occurred" };
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            await context.Response.WriteAsync(JsonConvert.SerializeObject(errorBody));
        }
    }
}
