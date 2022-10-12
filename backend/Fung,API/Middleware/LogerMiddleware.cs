using Fung.BLL.Exceptions;
using Fung.COMMON.Enums;
using Newtonsoft.Json;
using System.Net;

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
                    // there is should be my custom exceptions 
                    case InvalidLoginCredentialsException e:
                        await HandleInvalidCredentialExceptionAsync(httpContext, e);
                        break;
                    case UserAlreadyExistsException e:
                        await HandleUserAlreadyExistsExceptionAsync(httpContext, e);
                        break;
                    case InvalidTokenException e:
                        await HandleInvalidTokenExceptionAsync(httpContext, e);
                        break;
                    case NotFoundException e:
                        await HandleNotFoundExceptionAsync(httpContext, e);
                        break;
                    default:
                        await HandleAnyExceptionAsync(httpContext, exception);
                        break;
                }
            }
        }

        private async Task HandleAnyExceptionAsync(HttpContext context, Exception ex)
        {
            logger.LogError($"Type: [{ex.GetType()}] {ex.Message}");
            await CreateExceptionAsync(context);
        }
        private async Task HandleInvalidCredentialExceptionAsync(HttpContext context, InvalidLoginCredentialsException ex)
        {
            logger.LogError($"Type: [{ex.GetType()}] {ex.Message}");
            await CreateExceptionAsync(context, HttpStatusCode.Forbidden, ex.Message, ErrorCode.InvalidLoginCredentials);
        }

        private async Task HandleUserAlreadyExistsExceptionAsync(HttpContext context, UserAlreadyExistsException ex)
        {
            logger.LogError($"Type: [{ex.GetType()}] {ex.Message}");
            await CreateExceptionAsync(context, HttpStatusCode.Forbidden, ex.Message, ErrorCode.UserAlreadyExists);
        }

        private async Task HandleInvalidTokenExceptionAsync(HttpContext context, InvalidTokenException ex)
        {
            logger.LogError($"Type: [{ex.GetType()}] {ex.Message}");
            await CreateExceptionAsync(context, HttpStatusCode.Forbidden, ex.Message, ErrorCode.InvalidToken);
        }

        private async Task HandleNotFoundExceptionAsync(HttpContext context, NotFoundException ex)
        {
            logger.LogError($"Type: [{ex.GetType()}] {ex.Message}");
            await CreateExceptionAsync(context, HttpStatusCode.NotFound, ex.Message, ErrorCode.NotFound);
        }

        private async Task CreateExceptionAsync(HttpContext context, HttpStatusCode statusCode = HttpStatusCode.InternalServerError,
            string errorMessage = "Not provided", ErrorCode errorCode = ErrorCode.Generic)
        {
            object errorBody = new { error = errorMessage, errorCode = errorCode };
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            await context.Response.WriteAsync(JsonConvert.SerializeObject(errorBody));
        }
    }
}
