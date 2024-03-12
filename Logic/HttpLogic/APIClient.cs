namespace BeeckerWebLurker.Logic.HttpLogic;

public class APIClient
{
    private readonly RestClientOptions? _options;
    public RestClient? Client;

    //initialisiert ein API Client zwecks nutzung im weiteren Verfahren
    public APIClient(string baseUri, string client_id, string client_secret)
    {
        RestClientOptions _options = new(baseUri)
        { 
            Authenticator = new HttpBasicAuthenticator(client_id, client_secret) 
        };

        RestClient Client = new(_options);
    }



    public static void StartAuthenticationFlow(ProjectAuthModel auth)
    {
        /* 
        Soll Authentifizierung starten. Die Implementierungsweise bzgl. der Authentifizierung ist egal. Der User wird zum einloggen im Browser aufgefordert.
        Nach dem erfolgreichen Einloggen erhält der Client eine Antwort. Mittels diesem Antwort und rest des gesamten Prozesses, soll dann über 
        Youtube Data eine beliebige Youtube playlist erstellt werden. Diese Lösung soll dann für zukünftige Projekte genutzt werden. 
        */

        
        Console.WriteLine("");
        APIClient Session = new(Endpoints.baseUri, auth.client_id, auth.client_secret);

    }

}
