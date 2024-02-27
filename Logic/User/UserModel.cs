namespace BeeckerWebLurker.Logic.User
{
    internal class UserModel
    {
        private readonly string client_id = "kdhvMUKvjOlH849S4a-WqAmR";
        private readonly string client_secret = "x8eKkUGkEdaG8FIFGp9Fa3hW-Nex5sSNnNMRgkF6BMvLXF0G";
        private readonly string login = "cloudy-shrike@example.com";
        private readonly string password = "Good-Falcon-22";
        private Token? token { get; set; }


        private string state { get; set; }

        public static UserModel GetUserCredentials()
        {
            return new UserModel { };
        }

        public void TestFunction()
        {
            Console.WriteLine("This is a Test");
        }

        private UserModel GetUserState(UserModel user, HttpClient client)
        {
            return user;
        }




    }
}
