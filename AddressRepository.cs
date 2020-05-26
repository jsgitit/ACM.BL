using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressID)
        {

            // Create the insteanace of the Address class, and,
            // pass in the requested addressID
            var address = new Address(addressID);

            // Code that retrieves the address from DB would live here

            // Use  temporary code to populate two addresses in the Address List

            if (addressID == 0)
            {
                address.AddressType = 1;
                address.Street1 = "Street 1";
                address.Street2 = "Street 2";
                address.City = "Portland";
                address.State = "Oregon";
                address.Zip = "97000";
                address.Country = "USA";
            }

            return address;

        }

        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            // Create the insteanace of the Address class, and,
            // pass in the requested addressID
            var addressList = new List<Address>();
            var address = new Address(0)
            {
                AddressType = 1,
                Street1 = "1 Street Address line",
                Street2 = "Residential",
                City = "Portland",
                State = "Oregon",
                Zip = "97001",
                Country = "USA"
            };
            addressList.Add(address);
            
            address = new Address(0)
            {
                AddressType = 2,
                Street1 = "2 Street Address line",
                Street2 = "Business",
                City = "Portland",
                State = "Oregon",
                Zip = "97002",
                Country = "USA"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
