using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooliesX.Onboarding.UserInfo.App
{
    public interface IUserInfoProcessor
    {
        public void GetUserInfo();
        public void DisplayUserInfo();
        public void ValidateUser();
    }
}
