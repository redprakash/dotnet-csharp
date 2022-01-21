using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooliesX.Onboarding.UserInfo.App
{
    internal class UserInfoProcessor
    {
        private readonly string loginUserName = "admin";
        private readonly string loginUserPassword = "admin";

        
        public bool ValidateUser(string userName, string userPassword)
        {
            if(userName == loginUserName && userPassword == loginUserPassword)
            {
                return true;
            }
                return false;
          
        }

    }
}
