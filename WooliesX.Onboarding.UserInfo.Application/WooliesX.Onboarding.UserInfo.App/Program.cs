using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
namespace WooliesX.Onboarding.UserInfo.App
{
    public class Program
    {

        //public Program(IUserInfoProcessor userInfoProcessor)
        //{
        //    _userInfoProcessor = userInfoProcessor;
        //    userInfoProcessor.ValidateUser();
        //    // userInfoProcessor.DisplayUserInfo();
        //}
        //private readonly IUserInfoProcessor _userInfoProcessor;
        
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureServices(
                services => services.AddSingleton<IUserInfoProcessor>());
         
            
        }
           

    }
    
}