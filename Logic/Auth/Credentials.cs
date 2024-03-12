namespace BeeckerWebLurker.Logic.Auth;

/*
 Klasse um Datei auszuwerten
 */
public class Credentials
{
    
    private readonly IConfiguration _configuration;

    public Credentials(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    //Funktion um client_id und client_secret zu erlangen
    public ProjectAuthModel GetCredentials()
    {
        var section = _configuration.GetSection("installed") ;

        ProjectAuthModel auth = new()
        {
            client_id = section["client_id"],
            client_secret = section["client_secret"]
        };

        if (string.IsNullOrEmpty(auth.client_id) || string.IsNullOrEmpty(auth.client_secret))
            throw new ArgumentNullException("client_id", "Fehler beim befüllen des Models");


        Console.WriteLine(auth.client_id);
        Console.WriteLine(auth.client_secret);

        return auth ;
    }
}
