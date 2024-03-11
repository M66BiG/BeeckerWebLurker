namespace BeeckerWebLurker.Logic.HttpLogic;

public class APIClient : IDisposable
{
    private readonly RestClientOptions? _options;
    public RestClient? Client;

    //initialisiert ein API Client zwecks nutzung im weiteren Verfahren
    public APIClient(string baseUri, string client_id, string client_secret)
    {
        RestClientOptions _options = new($"{baseUri}")
        { Authenticator = new HttpBasicAuthenticator(client_id, client_secret) };

        RestClient Client = new(_options);
    }



    public static void StartAuthenticationFlow()
    {
        /* 
        Soll Authentifizierung starten. Die Implementierungsweise bzgl. der Authentifizierung ist egal. Der User wird zum einloggen im Browser aufgefordert.
        Nach dem erfolgreichen Einloggen erhält der Client eine Antwort. Mittels diesem Antwort und rest des gesamten Prozesses, soll dann über 
        Youtube Data eine beliebige Youtube playlist erstellt werden. Diese Lösung soll dann für zukünftige Projekte genutzt werden. 
        */

        Credentials credentials = Credentials.GetCredentials();
        Console.WriteLine("");
        APIClient Session = new(Endpoints.baseUri, credentials.client_id, credentials.client_secret);




        //Process.Start(new ProcessStartInfo("cmd", $"/c start {Session.Client.BaseAddress}") { CreateNoWindow = true });
    }



    public void Dispose()
    {
        Client?.Dispose();
        GC.SuppressFinalize(this);
    }
}
