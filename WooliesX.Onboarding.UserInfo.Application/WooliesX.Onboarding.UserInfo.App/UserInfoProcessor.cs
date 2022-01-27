using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WooliesX.Onboarding.UserInfo.App
{
    public class UserInfoProcessor : IUserInfoProcessor
    {
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
        public string GetUserInfo()
        {

            Console.WriteLine("Please enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("Please enter your mobile num");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine("Please enter your address");
            string address = Console.ReadLine();

            var userObj = new Users()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                MobileNumber = mobileNumber

            };
            return DisplayUserInfo(userObj);
        }
        private string DisplayUserInfo(Users userObj)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Hi, {userObj.FirstName} {userObj.LastName}");
            //Console.WriteLine($"Hi, {FirstName} {LastName}");

            sb.Append($"You are {userObj.Age} years old");
            sb.Append($"Someone can contact you on { userObj.MobileNumber}");
            sb.Append($"Your address is {userObj.Address}");
            return sb.ToString();

        }
    }
}
