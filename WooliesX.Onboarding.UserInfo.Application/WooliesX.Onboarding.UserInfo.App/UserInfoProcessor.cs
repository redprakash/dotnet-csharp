using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooliesX.Onboarding.UserInfo.App
{
    public class UserInfoProcessor
    {
        private readonly string loginUserName = "admin";
        private readonly string loginUserPassword = "admin";

        public bool ValidateUser()
        {
          
            Console.WriteLine("\n Please enter your username");
            var userInputUserName = Console.ReadLine();
            Console.WriteLine("\n Please enter your password");
            var userInputPassword = Console.ReadLine();

            if (userInputUserName == loginUserName && userInputPassword == loginUserPassword)
            {
                return true;
            }
                return false;
          
        }
        

    }
}
