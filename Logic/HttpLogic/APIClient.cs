namespace BeeckerWebLurker.Logic.HttpLogic;

public class APIClient : IDisposable
{
    private readonly RestClientOptions? _options;
    public RestClient? Client;

    /*
    string response_type = "code";
    string client_id = "x";
    string client_secret = "x";
    string redirect_uri = "youtube.googleapis.com";
    string scope = "photo+offlince_access";
    */


    //initialisiert ein API Client zwecks nutzung im weiteren Verfahren
    public APIClient(string baseUri)
    {
        RestClientOptions _options = new($"{baseUri}")
        { Authenticator = new HttpBasicAuthenticator("client id placeholder", "client secret placeholder") };

        RestClient Client = new(_options);
    }



    public static void StartAuthenticationFlow()
    {
        /* 
        Soll Authentifizierung starten. Die Implementierungsweise bzgl. der Authentifizierung ist egal. Der User wird zum einloggen im Browser aufgefordert.
        Nach dem erfolgreichen Einloggen erhält der Client eine Antwort. Mittels diesem Antwort und rest des gesamten Prozesses, soll dann über 
        Youtube Data eine beliebige Youtube playlist erstellt werden. Diese Lösung soll dann für zukünftige Projekte genutzt werden. 
        */

        APIClient Session = new(Endpoints.baseUri);




        //Process.Start(new ProcessStartInfo("cmd", $"/c start {Session.Client.BaseAddress}") { CreateNoWindow = true });
    }



    public void Dispose()
    {
        Client?.Dispose();
        GC.SuppressFinalize(this);
    }
}
