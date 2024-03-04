namespace BeeckerWebLurker.Logic;

public class AuthenticationFlow
{
    public static void StartAuthenticationFlow()
    {
        /* Soll Authentifizierung starten. Dies soll durch öffnen des Standard Browsers geschehen. Der User wird zum einloggen im Browser aufgefordert.
         Nach dem erfolgreichen Einloggen erhält der Client eine Antwort. Mittels dieser Antwort und rest des gesamten Prozesses, soll dann über 
        Youtube Analytics Daten abgerufen werden. Diese Lösung soll dann für zukünftige Projekte genutzt werden. */



        Process.Start(new ProcessStartInfo("cmd", $"/c start {"www.google.de"}") { CreateNoWindow = true });
    }
}
