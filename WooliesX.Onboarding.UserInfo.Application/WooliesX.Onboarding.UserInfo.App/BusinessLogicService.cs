using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooliesX.Onboarding.UserInfo.App
{
    public  class BusinessLogicService
    {

        IUserInfoProcessor userInfoProcessor;
        public BusinessLogicService(IUserInfoProcessor _userInfoProcessor)
        {
            userInfoProcessor = _userInfoProcessor;
            userInfoProcessor.ValidateUser();
            userInfoProcessor.DisplayUserInfo();
        }
    }
}
