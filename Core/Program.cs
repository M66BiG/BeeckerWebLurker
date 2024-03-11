
using BeeckerWebLurker.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

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
                             .AddUserSecrets<Program>();
            }
            catch
            {
                // ignore
            }
        });

        await Engine.StartEngine();
    }
}