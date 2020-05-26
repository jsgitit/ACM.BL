using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        //constructor
        public Address()
        {

        }

        public Address(int addressID)
        {
            AddressID = addressID;
        }
        //properties
        public int AddressID { get; set; }
        public int AddressType { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        
        //methods
        public bool Validate()
        {
            var isValid = true;
            if (Zip == null) 
                isValid = false;

            return isValid;
        }
    }
}
