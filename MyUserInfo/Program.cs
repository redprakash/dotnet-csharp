using System;

namespace MyUserInfo
{
    public class Program
    {
        Users users = new Users();
        public void GetUserInfo()
        {
            Console.WriteLine("Please enter first name");
            users.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter last name");
            users.LastName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            users.Age =  Console.ReadLine();
            Console.WriteLine("Please enter your mobile num");
            users.MobileNumber = Console.ReadLine();
            Console.WriteLine("Please enter your address");
            users.Address = Console.ReadLine();
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine($"Hi, {users.FirstName} {users.LastName}");
           
            Console.WriteLine($"You are {users.Age} years old");
            Console.WriteLine($"Someone can contact you on { users.MobileNumber}");
            Console.WriteLine($"Your address is {users.Address}");

        }
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
                    var instanceOfProgram = new Program();
                    instanceOfProgram.GetUserInfo();
                    
                    Console.WriteLine("*************** Your Details ***************");
                    instanceOfProgram.DisplayUserInfo();
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