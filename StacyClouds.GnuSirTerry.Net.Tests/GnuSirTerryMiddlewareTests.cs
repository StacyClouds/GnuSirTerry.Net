using Microsoft.AspNetCore.Http;
using NSubstitute;
using Shouldly;
using StacyClouds.GnuSirTerry.Net;
using Xunit;

namespace StacyClouds.GnuSirTerry.Tests;

public class GnuSirTerryMiddlewareTests
{
    [Fact]
    public async Task InvokeAsync_AddsXClacksOverheadHeader()
    {
        var context = new DefaultHttpContext();
        var next = Substitute.For<RequestDelegate>();
        var middleware = new GnuSirTerryMiddleware(next);

        await middleware.InvokeAsync(context);

        context.Response.Headers["X-Clacks-Overhead"].ToString().ShouldBe("GNU Terry Pratchett");
    }

    [Fact]
    public async Task InvokeAsync_CallsNext()
    {
        var context = new DefaultHttpContext();
        var next = Substitute.For<RequestDelegate>();
        var middleware = new GnuSirTerryMiddleware(next);

        await middleware.InvokeAsync(context);

        await next.Received(1)(context);
    }
}
