namespace BeeckerWebLurker.Logic.HttpLogic;

internal class WebLogic
{
    public HttpClient client { get; set; }
    UserModel user { get; set; }

    string redirect_uri = "https://www.oauth.com/playground/authorization-code.html";

    private WebLogic()
    {
        user = UserModel.GetUserCredentials();
        client = StartHttpClient(user);
        
    }

    private HttpClient StartHttpClient(UserModel user)
    {
        HttpClient client = new HttpClient();

        client.BaseAddress = new Uri("https://authorization-server.com/authorize?" + );

        return client;
    }

    public static WebLogic StartSession()
    {

        WebLogic Session = new();


        return Session;
    }

    
}
