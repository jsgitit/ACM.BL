using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class Order: EntityBase, ILoggable
    {
        //constructor
        public Order() : this(0)
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
            OrderItems = new List<OrderItem>();

        }

        //properties
        public int OrderID { get; private set; }
        public int CustomerID { get; set; }
        public DateTimeOffset? OrderDate{ get; set; }
        public int ShippingAddressID { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public string Log() => $"{OrderID} Date: {this.OrderDate.Value.Date} Status: {this.EntityState}";

        //methods
        public override bool Validate()  
        {
            return true;
        }

    }
}
