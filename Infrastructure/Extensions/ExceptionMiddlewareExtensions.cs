using Infrastructure.Middleware;
using Microsoft.AspNetCore.Builder;

namespace Infrastructure.Extensions;

public static class ExceptionMiddlewareExtensions
{
    public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ExceptionMiddleware>();
    }
}