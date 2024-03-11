namespace BeeckerWebLurker.Logic.Auth;

/*
 Klasse um Datei auszuwerten
 */
public class Credentials
{
    public string? client_id;
    public string? client_secret;

    //Funktion um client_id und client_secret zu erlangen
    public static Credentials GetCredentials()
    {
        Credentials c = new();
        string filepath = c.GetFilePath(c);
        string jsonContent = "";

        try
        { 
            jsonContent = File.ReadAllText(filepath); 
        }
        catch
        {
            throw new Exception();
            
        }

        ProjectAuthModel? authModel = JsonConvert.DeserializeObject<ProjectAuthModel>(jsonContent);

        var credentials = new Credentials
        {
            client_id = authModel.installed.client_id,
            client_secret = authModel.installed.client_secret
        };

        return credentials;
    }

    //Funktion um Dateipfad zu bestimmen
    private string GetFilePath(Credentials c)
    {
        Console.WriteLine("1: Zuhause\n2: Arbeit\n3: Neuer Dateipfad (custom)");
        int choice = Convert.ToInt32(Console.ReadLine());

        return choice switch
        {
            1 => "",
            2 => "C:/Users/SipahiM/Desktop/clientsecret.json",
            3 => c.CustomFilePath(),
            _ => ""
        };
    }

    //Rekursive Funktion für Custom Dateipfad einzulesen
    private string CustomFilePath()
    {
        Console.WriteLine("Bitte tippe den Dateipfad ein.");
        string? s = Console.ReadLine();

        if (string.IsNullOrEmpty(s))
        {
            Console.WriteLine("Fehler: Es wurde nichts eingetippt.");
            return CustomFilePath();
        }
        return s;
    }
}
