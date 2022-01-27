using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooliesX.Onboarding.UserInfo.App
{
    public interface IUserInfoProcessor
    {
        public string GetUserInfo();
       
        public void ValidateUser();
    }
}
