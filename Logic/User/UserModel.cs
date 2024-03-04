namespace BeeckerWebLurker.Logic.User;

public class UserModel
{
    /*private readonly string client_id = "bNAt3YYE9rrSlMkM2bpFqyb0";
    private readonly string client_secret = "MNIoMxpTCJNVt7wPSHGOvKjx1ghn3Va3fykqvSHGEofRgvrI";
    private readonly string login = "wrong-angelfish@example.com";
    private readonly string password = "Unsightly-Macaw-71";*/

    private Token? _token;
    private string _state;

    public UserModel GetUserState(UserModel user, HttpClient client)
    {
        return user;
    }
}
