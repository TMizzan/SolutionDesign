using System;
using System.Collections;
using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        #region "Properties"

        public string CustomerId;
        public System.Collections.Generic.List<Product> Products;
        public decimal Total;
        public decimal Discount;
        public DateTime OrderDate;
        public string OrderNumber;

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
