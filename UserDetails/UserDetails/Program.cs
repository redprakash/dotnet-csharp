using System;
namespace UserDetails
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the UserDetails Appp \n");
            bool valid = false;
            static void getUserDetails()
            {
                Console.WriteLine("Enter your First Name");
                Users.inputUserFirstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name");
                Users.inputUserLastName = Console.ReadLine();
                Console.WriteLine("Enter your email");
                Users.inputUserEmail = Console.ReadLine();
                Console.WriteLine("Enter your phone Number");
                Users.inputUserPhone = Console.ReadLine();
               
               
            }
            static void displayUsersDetails()
            {
                Console.WriteLine($"Your full name is :- {Users.inputUserFirstName}  {Users.inputUserLastName}");
                Console.WriteLine($"Your Email is :- {Users.inputUserEmail}");
                Console.WriteLine($"Your phone number is :- {Users.inputUserPhone}");
            }
           
           
            while (!valid)
            {
                Console.WriteLine("\n Please enter your username");
                var userInputUserName = Console.ReadLine();
                Console.WriteLine("\n Please enter your password");
                var userInputPassword = Console.ReadLine();

                if (userInputUserName == Users.userName && userInputPassword == Users.password)
                {
                    Console.WriteLine($"Welcome {Users.userName}");
                    getUserDetails();
                    Console.WriteLine("*************** Your Details ***************");
                    displayUsersDetails();
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Credentials, please try again");
                    valid = false;
                   
                }
            }

            
           
           
        }
    }
}