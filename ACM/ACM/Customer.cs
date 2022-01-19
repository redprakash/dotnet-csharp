using System;
namespace ACM
{
    public class Customer
    {
        public int CustomerId { get;private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        private string? _lastName;
        public string LastName
        {
            get { return _lastName; } 
            set { _lastName = value; } 
        }

        //Now lets create a property for a fullName
        public string FullName
        {
            get { return LastName + "," + FirstName; }
        }

        public bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            return isValid;
        }
        public bool Save()
        {
            return true;
        }
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
       
    }
}