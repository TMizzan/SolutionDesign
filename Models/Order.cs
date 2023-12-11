using System;
using System.Collections;
using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        #region "Properties"

        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderNumber { get; set; }

        public System.Collections.Generic.List<Product> Products { get; set; }

        public decimal Total { get; set; }

        public decimal Discount { get; set; }

        #endregion

        #region "Constructors"

        public Order() {}

        public Order(string customerId,
                     DateTime orderDate,
                     string orderNumber,
                     System.Collections.Generic.List<Product> products,
                     decimal total,
                     decimal discount)
        {
            CustomerId = customerId;
            OrderDate  = orderDate;
            Products   = products;
            Total      = total;
            Discount   = discount;
        }

        #endregion
    }
}
