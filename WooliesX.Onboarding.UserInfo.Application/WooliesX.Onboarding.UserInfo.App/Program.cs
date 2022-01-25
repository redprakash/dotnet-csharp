using System;
namespace WooliesX.Onboarding.UserInfo.App
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            BusinessLogicService objBusinessLogic = new BusinessLogicService(new Users());
            
        }
    }
}