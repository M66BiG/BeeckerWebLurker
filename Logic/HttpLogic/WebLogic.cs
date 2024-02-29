namespace BeeckerWebLurker.Logic.HttpLogic;

public class WebLogic
{
    public UserModel User { get; set; }
    public HttpClient Client { get; set; }

    public WebLogic()
    {
        User = new UserModel();
        Client = CreateHttpClient();
    }

    private HttpClient CreateHttpClient()
    {
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com/")
        };

        return client;
    }
}
