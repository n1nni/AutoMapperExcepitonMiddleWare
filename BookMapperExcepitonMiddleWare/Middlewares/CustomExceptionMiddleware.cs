using System.Text.Json;

namespace BookMapperExcepitonMiddleware.Middlewares
{
    // Custom Exception class for handling all possible exceptions that my occuar in this project
    public class CustomExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            var statusCode = 500;
            var response = new
            {
                status = statusCode,
                detail = exception.Message,
                customMessage = "custom exception message"
            };
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;
            await httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

    }
}
