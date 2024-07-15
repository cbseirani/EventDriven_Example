using System.Net;
using System.Text.Json;
using Infrastructure.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Middleware;

public class ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception e)
        {
            await HandleException(context, e);
        }
    }

    private Task HandleException(HttpContext context, Exception exception)
    {
        var statusCode = exception switch
        {
            ValidationException => ValidationException.StatusCode,
            NotFoundException => NotFoundException.StatusCode,
            _ => (int)HttpStatusCode.InternalServerError
        };

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = statusCode;
        
        logger.LogError(exception, "Exception thrown {exceptionType} - API responded with {status}",
            exception.GetType(), statusCode);

        return context.Response.WriteAsync(JsonSerializer.Serialize(exception.Message));
    }
}