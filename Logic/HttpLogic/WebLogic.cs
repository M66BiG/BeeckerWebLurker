namespace BeeckerWebLurker.Logic.HttpLogic;

public class WebLogic
{
    //public UserModel User { get; set; }
    public HttpClient Client { get; set; }

    string response_type = "code";
    string client_id = "x";
    string client_secret = "x";
    string redirect_uri = "youtube.googleapis.com";
    string scope = "photo+offlince_access";
    public string state = "";


    public WebLogic()
    {
        //User = new UserModel();
        Client = CreateHttpClient();
    }

    private HttpClient CreateHttpClient()
    {
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("youtube.googleapis.com")
        };

        return client;
    }
}
