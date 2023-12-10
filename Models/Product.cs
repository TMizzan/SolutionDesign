using System;

namespace Models
{
    public class Product
    {
        #region "Properties"

        public string OrderNumber { get; set; }

        public string ProductId { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal UnitPrice { get; set; }

        public string UPCCode { get; set; }

        public int QuantityOnHand { get; set; }

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
