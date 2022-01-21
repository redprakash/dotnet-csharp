using System;
namespace WooliesX.Onboarding.UserInfo.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n Please enter your username");
            var userInputUserName = Console.ReadLine();
            Console.WriteLine("\n Please enter your password");
            var userInputPassword = Console.ReadLine();

            UserInfoProcessor processor = new UserInfoProcessor();
            if(processor.ValidateUser(userInputUserName, userInputPassword))
            {
                Console.WriteLine("Validated");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}