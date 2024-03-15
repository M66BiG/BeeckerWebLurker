
namespace BeeckerWebLurker.Core;


internal class Engine : IHostedService
{

    public static async Task StartEngine(ProjectAuthModel authenticationData)
    {
        /*In dieser Funktion sollen die relevanten Variablen gespeichert werden, um Aktionen innerhalb des Clients durchzuführen. Ob das nötig ist, oder nicht wird sich im Laufe ergeben*/

        

        

    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Programm hier");


        ProjectAuthModel authenticationData = Credentials.GetCredentials();

        APIClient.StartAuthenticationFlow(authenticationData);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();

        
    }
}
