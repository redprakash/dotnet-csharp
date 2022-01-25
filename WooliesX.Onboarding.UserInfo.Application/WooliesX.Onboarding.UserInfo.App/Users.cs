using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooliesX.Onboarding.UserInfo.App
{
    public class Users : IUserInfoProcessor
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobileNumber { get; set; }
        public string? Address { get; set; }
        private string? age;
        public string? Age
        {
            get { return age; }
            set { age = value; }
        }
        private readonly string loginUserName = "admin";
        private readonly string loginUserPassword = "admin";

        public void ValidateUser()
        {

            Console.WriteLine("\n Please enter your username");
            var userInputUserName = Console.ReadLine();
            Console.WriteLine("\n Please enter your password");
            var userInputPassword = Console.ReadLine();

            if (userInputUserName == loginUserName && userInputPassword == loginUserPassword)
            {
               
                GetUserInfo();
               
            }
            else
            {
                Console.WriteLine("Invalid Creditinals please try again");
                ValidateUser();
            }

        }
        public void GetUserInfo()
        {

            Console.WriteLine("Please enter first name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Please enter last name");
            LastName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            Age = Console.ReadLine();
            Console.WriteLine("Please enter your mobile num");
            MobileNumber = Console.ReadLine();
            Console.WriteLine("Please enter your address");
            Address = Console.ReadLine();
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine($"Hi, {FirstName} {LastName}");

            Console.WriteLine($"You are {Age} years old");
            Console.WriteLine($"Someone can contact you on { MobileNumber}");
            Console.WriteLine($"Your address is {Address}");

        }



    }
}
