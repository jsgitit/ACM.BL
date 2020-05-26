using Acme.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        //constructor
        public Customer() : this(0)
        {
            // "this(0)" calls Customer(0). It's called constructor chaining. 
            // It ensures AddressList field will not be null.
        }

        public Customer(int customerID)
        {
            CustomerID = customerID;
            AddressList = new List<Address>();
        }

        //properties
        public int CustomerID { get; private set; }
        public string CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public List<Address> AddressList { get; set; }
        public static int Count { get; set; }

        //methods

        public string Log() => $"{CustomerID}: {FullName} Email: {EmailAddress} Status: {EntityState}";
        public override string ToString() => FullName;
        public override bool Validate()
        {
            var isValid = true; // assume true
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

    }

}