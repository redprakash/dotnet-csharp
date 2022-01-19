using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class CustomerRepository
    {
        // Retreive one customer
       public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if(customerId == 1)
            {
                customer.FirstName = "Prakash";
                customer.LastName = "Poudel";
                customer.EmailAddress = "poudel@gmail.com";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
