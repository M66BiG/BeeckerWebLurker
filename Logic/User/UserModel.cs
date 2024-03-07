using System.Runtime.CompilerServices;

namespace BeeckerWebLurker.Logic.User
{
    internal class UserModel
    {
        //private readonly string client_id = "T5dgem4mQLMCpuTFfu33a4PL";
        //private readonly string client_secret = "0aZGglOeYmh4z4i48492_YXhs7l75L78dSouseUa3BjofOcG";
        //private readonly string login = "puzzled-wren@example.com";
        //private readonly string password = "Inexpensive-Elk-32";
        private Token? token { get; set; }

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
