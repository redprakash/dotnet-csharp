using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUserInfo
{
    public class Users
    {
       
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobileNumber { get; set; }
        public string? Address { get; set; }
        private string? age;
        public string? Age
        {
            get { return age; }
            set { age = value; }
        }

        public void GetUserInfo()
        {

            Console.WriteLine("Please enter first name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Please enter last name");
            LastName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            Age = Console.ReadLine();
            Console.WriteLine("Please enter your mobile num");
            MobileNumber = Console.ReadLine();
            Console.WriteLine("Please enter your address");
            Address = Console.ReadLine();
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine($"Hi, {FirstName} {LastName}");

            Console.WriteLine($"You are {Age} years old");
            Console.WriteLine($"Someone can contact you on { MobileNumber}");
            Console.WriteLine($"Your address is {Address}");

        }



    }
}
