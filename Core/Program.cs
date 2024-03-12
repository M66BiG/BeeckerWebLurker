using BeeckerWebLurker.Core;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args)
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
        }).Build();

        await Engine.StartEngine(builder);
    }
}