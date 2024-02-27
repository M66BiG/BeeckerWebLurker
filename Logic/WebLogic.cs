namespace BeeckerWebLurker.Logic;

internal class WebLogic
{
    


    public static UserModel StartSession()
    {
        UserModel testUser = UserModel.GetUserCredentials();

        






        testUser.TestFunction();

        return testUser;
    }

    private HttpClient StartHttpClient()
    {
        HttpClient client = new HttpClient();

        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
        return new HttpClient();
    }
}
