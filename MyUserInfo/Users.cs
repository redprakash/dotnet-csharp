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

       




    }
}
