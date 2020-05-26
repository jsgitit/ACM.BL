using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {

        //constructor
        public OrderItem()
        {

        }

        public OrderItem(int orderItemID)
        {
            OrderItemID = orderItemID;
        }

        //properties
        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        //methods
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0)
                isValid = false;
            if (ProductID <= 0)
                isValid = false;
            if (PurchasePrice == null) 
                isValid = false;
            
            return isValid;
        }

        public OrderItem Retrieve(int orderItemID)
        {
            return new OrderItem();
        }

        public void Save()
        {

        }
    }
}
