using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {

        //Construtor
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        //properties
        private AddressRepository addressRepository { get; set; }

        public Customer Retrieve(int customerID)
        {
            var customer = new Customer(customerID);

            // pretend we're reading in a customer from the database...
            if (customerID == 1)
            {
                customer.FirstName = "Joe";
                customer.LastName = "Smith";
                customer.EmailAddress = "Joe@home.com";
                customer.AddressList = addressRepository.RetrieveByCustomerID(customerID).ToList();

            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true; //assume it was saved to the database for now.
        }
    }
}
