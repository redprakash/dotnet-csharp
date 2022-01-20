using System;

namespace MyUserInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("***** Welcome to User Info App ****");
            string loginUserName = "prakash";
            string loginPassword = "dotnet";
            bool isValid = false;
            while (!isValid)
            {

                Console.WriteLine("\n Please enter your username");
                var userInputUserName = Console.ReadLine();
                Console.WriteLine("\n Please enter your password");
                var userInputPassword = Console.ReadLine();
                if (userInputUserName == loginUserName && userInputPassword == loginPassword)
                {
                    Console.WriteLine($"Welcome {loginUserName}");
                    Console.WriteLine("------------------------------");
                    
                    Users users = new Users();
                    users.GetUserInfo();
                    
                    Console.WriteLine("*************** Your Details ***************");
                    users.DisplayUserInfo();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Credentials, please try again");
                    isValid = false;

                }
            }

        }
    }
}