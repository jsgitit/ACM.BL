using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ACM.BL
{
    public class ProductRepository
    {
        //constructor
        public Product Retrieve(int productID)
        {
            var product = new Product(productID);
            if (productID == 1)
            {
                product.ProductName = "Soap";
                product.Description = "Really good soap!";
                product.CurrentPrice = 2.99M;
            }
            var myobject = new Object();

            return product;
        }
        public bool Save(Product product)  // this same method should be implemented for other entities.
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // call insert stored procedure
                    }
                    else
                    {
                        // call update stored procedure
                    }
                }
                else
                {
                    success = false;
                }

            }
            return success;
        }
    }
}
