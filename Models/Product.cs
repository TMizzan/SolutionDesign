using System;

namespace Models
{
    public class Product
    {
        #region "Properties"

        public string OrderNumber;

        public string ProductId;

        public string ShortDescription;

        public string LongDescription;

        public decimal UnitPrice;

        public string UPCCode;

        public int QuantityOnHand;

        #endregion

        #region "Constructors"

        public Product() {}

        public Product(string orderNumber,
                       string productId,
                       string shortDescription,
                       string longDescription,
                       decimal unitPrice,
                       string upcCode,
                       int quantityOnHand)
        {
            OrderNumber      = orderNumber;
            ProductId        = productId;
            ShortDescription = shortDescription;
            LongDescription  = longDescription;
            UnitPrice        = unitPrice;
            UPCCode          = upcCode;
            QuantityOnHand   = quantityOnHand;
        }

        #endregion
    }
}
