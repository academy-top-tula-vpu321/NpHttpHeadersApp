var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) =>
{
    context.Request.Headers.TryGetValue("User-Agent", out var userAgent);
    context.Request.Headers.TryGetValue("My-Header", out var myHeader);

    return $"User agent: {userAgent}, my header: {myHeader}";
});

app.Run();
