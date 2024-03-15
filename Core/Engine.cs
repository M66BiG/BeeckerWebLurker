namespace BeeckerWebLurker.Core;


public class Engine(IConfiguration Configuration, ILogger<Engine> logger) : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("Placeholder".AddName());

        ProjectAuthModel authenticationData = Credentials.GetCredentials(Configuration);

        APIClient.StartAuthenticationFlow(authenticationData);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
