using System.Runtime.CompilerServices;

namespace BeeckerWebLurker.Logic.User
{
    internal class UserModel
    {
        private readonly string client_id = "b3aBZENcX3J5Vd-VaOqJPHAu";
        private readonly string client_secret = "dAM0HaxeEfquz5Ih1ZAR74Un8HwBlt_2RLUtEot6blCQLgM3";
        private readonly string login = "handsome-nightingale@example.com";
        private readonly string password = "Envious-Heron-80";
        private Token? token { get; set; }

        private string scope = "photo+offline_access";

        private string? state { get; set; }

        public static UserModel GetUserCredentials()
        {
            return new UserModel { };
        }

        private UserModel GetUserState(UserModel user, HttpClient client)
        {
            return user;
        }




    }
}
