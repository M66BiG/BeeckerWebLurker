namespace BeeckerWebLurker.Logic.HttpLogic;

internal class WebLogic
{
    UserModel user { get; set; }
    public HttpClient client { get; set; }

    private WebLogic()
    {
        user = UserModel.GetUserCredentials();
        client = StartHttpClient();
    }

    public static WebLogic StartSession()
    {
        WebLogic Session = new();


        return Session;
    }

    private HttpClient StartHttpClient()
    {
        HttpClient client = new HttpClient();

        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

        return client;
    }
}
