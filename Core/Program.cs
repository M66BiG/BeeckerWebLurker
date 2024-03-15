using BeeckerWebLurker.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateLogger();

        var builder = Host.CreateDefaultBuilder(args)
            .UseSerilog(Log.Logger)
            .ConfigureAppConfiguration((hostContext, configBuilder) =>
            {
                try
                {
                    configBuilder.AddEnvironmentVariables()
                                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true) //fügt appsettings.json hinzu
                                 .AddUserSecrets<Program>(); //implementiert UserSecrets falls vorhanden
                }
                catch
                {
                    // ignore
                }
            })
            .ConfigureServices(services =>
            {
                services.AddHostedService<Engine>();

            }).Build();

        builder.Run();
    }
}