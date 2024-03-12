using System;

namespace BeeckerWebLurker.Core;


internal class Engine
{
    public static async Task StartEngine(IHost builder)
    {
        /*In dieser Funktion sollen die relevanten Variablen gespeichert werden, um Aktionen innerhalb des Clients durchzuführen. Ob das nötig ist, oder nicht wird sich im Laufe ergeben*/

        var cred = ActivatorUtilities.CreateInstance<Credentials>(builder.Services);

        ProjectAuthModel authenticationData = cred.GetCredentials();

        APIClient.StartAuthenticationFlow(authenticationData);

    }
}
