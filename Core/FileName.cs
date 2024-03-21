namespace BeeckerWebLurker.Logic.HttpServer;

public class HttpSeverLogic
{
    public string BearerToken { get; set; }

    private Task _app;

    public async Task StartServer(string[] args)
    {
        args ??= [];

        var builder = WebApplication.CreateSlimBuilder(args);

        var app = builder.Build();

        app.MapPost("/", async httpContext =>
        {
            BearerToken = httpContext.Request.Headers.Authorization.FirstOrDefault(h => h?.StartsWith("Bearer") ?? false);
        });

        _app = app.RunAsync();
    }
}