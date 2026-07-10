using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace StacyClouds.GnuSirTerry.Net;

public class GnuSirTerryMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        context
            .Response
            .Headers
            .Add(new KeyValuePair<string, StringValues>(
                "X-Clacks-Overhead", 
                "GNU Terry Pratchett"));
        
        await next(context);
    }
}

// Extension method for cleaner registration
public static class GnuSirTerryMiddlewareExtensions
{
    public static IApplicationBuilder UseGnuSirTerryMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<GnuSirTerryMiddleware>();
    }
}