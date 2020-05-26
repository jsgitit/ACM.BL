using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        //constructor
        public Product()
        {

        }

        public Product(int productID)
        {
            ProductID = productID;

        }
        //properties
        private string productName;
        public int ProductID { get; private set; }
        public string ProductName {
            get {
                return productName.InsertSpaces();
            }
            set {
                productName = value;
            }
        }


        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }



        //methods
        public string Log() => $"{ProductID}: {ProductName} Description: {Description} Status: {EntityState}";
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                isValid = false;
            if (CurrentPrice == null) 
                isValid = false;

            return isValid;
        }

      
    }



}
