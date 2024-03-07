namespace BeeckerWebLurker.Logic.HttpLogic;

internal class WebLogic
{
    public HttpClient client { get; set; }
    //UserModel user { get; set; }

    string response_type = "code";
    string client_id = "T5dgem4mQLMCpuTFfu33a4PL";
    string redirect_uri = "https://www.oauth.com/playground/authorization-code.html";
    string scope = "photo+offlince_access";
    public string state = "VV3vZLNdhJAgqC1R";

    private WebLogic()
    {
        //user = UserModel.GetUserCredentials();
        client = StartHttpClient();
        
    }

    private HttpClient StartHttpClient()
    {
        HttpClient client = new HttpClient();

        client.BaseAddress = new Uri($"https://authorization-server.com/authorize?response_type={response_type}&client_id={client_id}&redirect_uri={redirect_uri}&scope={scope}&state={state}");

        

        return client;
    }

    public static WebLogic StartSession()
    {

        WebLogic Session = new();


        return Session;
    }

    
}
