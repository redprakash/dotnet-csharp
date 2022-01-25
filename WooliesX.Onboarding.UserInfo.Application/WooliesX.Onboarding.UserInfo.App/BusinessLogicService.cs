using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooliesX.Onboarding.UserInfo.App
{
    public  class BusinessLogicService
    {

        private readonly IUserInfoProcessor _userInfoProcessor;
        public BusinessLogicService(IUserInfoProcessor userInfoProcessor)
        {
            _userInfoProcessor = userInfoProcessor;
            userInfoProcessor.ValidateUser();
            userInfoProcessor.DisplayUserInfo();
        }
    }
}
