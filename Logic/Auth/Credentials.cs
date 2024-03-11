namespace BeeckerWebLurker.Logic.Auth;

public class Credentials
{
    public string? client_id;
    public string? client_secret;

    public static Credentials GetCredentials()
    {
        string filepath = GetFilePath();
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
    private static string GetFilePath()
    {
        Console.WriteLine("1: Zuhause\n2: Arbeit\n3: Neuer Dateipfad (custom)");
        int choice = Convert.ToInt32(Console.ReadLine());


        return choice switch
        {
            1 => "",
            2 => "C:/Users/SipahiM/Desktop/clientsecret.json",
            3 => CustomFilePath(),
            _ => ""
        };
    }
    private static string CustomFilePath()
    {
        string? s = Console.ReadLine();

        if (string.IsNullOrEmpty(s))
            return CustomFilePath();
        return s;
    }
}
