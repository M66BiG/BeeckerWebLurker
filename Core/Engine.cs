namespace BeeckerWebLurker.Core;


public class Engine(IConfiguration Configuration, ILogger<Engine> logger) : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        ProjectAuthModel authenticationData = Credentials.GetCredentials(Configuration);

        APIClient.StartAuthenticationFlow(authenticationData);

        TcpServer tcpServer = new TcpServer();

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
