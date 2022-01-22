﻿using System;
namespace WooliesX.Onboarding.UserInfo.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var processor = new UserInfoProcessor();
            var users = new Users();
            bool isUserValid = processor.ValidateUser();
            if (isUserValid)
            {
               
                users.GetUserInfo();
                users.DisplayUserInfo();
            }
            else
            {
                Console.WriteLine("Invalid Creditinals please try again");
                processor.ValidateUser();
            }
           

            
           
           
           
        }
    }
}