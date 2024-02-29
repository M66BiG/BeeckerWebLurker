namespace BeeckerWebLurker.Logic.User;

public class UserModel
{
    /*private readonly string client_id = "kdhvMUKvjOlH849S4a-WqAmR";
    private readonly string client_secret = "x8eKkUGkEdaG8FIFGp9Fa3hW-Nex5sSNnNMRgkF6BMvLXF0G";
    private readonly string login = "cloudy-shrike@example.com";
    private readonly string password = "Good-Falcon-22";*/

    private Token? _token;
    private string _state;

    private UserModel GetUserState(UserModel user, HttpClient client)
    {
        return user;
    }
}
