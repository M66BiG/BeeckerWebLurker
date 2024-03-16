namespace BeeckerWebLurker.Logic.Auth;

/*
 Klasse um Datei auszuwerten
 */

public class Credentials
{
    //Funktion um client_id und client_secret zu erlangen
    public static ProjectAuthModel GetCredentials(IConfiguration configuration)
    {

        var section = configuration.GetSection("installed");

        ProjectAuthModel auth = new()
        {
            client_id = section["client_id"],
            client_secret = section["client_secret"]
        };

        if (string.IsNullOrEmpty(auth.client_id) || string.IsNullOrEmpty(auth.client_secret))
            throw new ArgumentNullException("client_id", "Fehler beim befüllen des Models");
        return auth ;
    }
}
