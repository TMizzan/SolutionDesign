using System;
using System.Collections;
using System.Collections.Generic;
using Models;

namespace DesignPatterns
{
    /// <summary>
    /// Order Number Validation
    /// </summary>
    public class OrderNumberSpecification : ISpecification<Models.Order>
    {
        public OrderNumberSpecification() { }

        public bool IsValid(Models.Order order)
        {
            return (order.OrderNumber != string.Empty) && (order.OrderNumber.Length >= 9);

        }
    }

    /// <summary>
    ///   Order Products Validation
    /// </summary>
    public class OrderProductsSpecification : ISpecification<Models.Order>
    {
        public OrderProductsSpecification() { }

        public bool IsValid(Models.Order order)
        {
            bool valid = true;

            foreach(Models.Product product in order.Products)
            {
                valid = (product.ProductId != string.Empty) &&
                        (product.UPCCode != string.Empty) &&
                        (product.ProductId.Length > 5) &&
                        (product.UPCCode.Length > 9) &&
                        (product.QuantityOnHand > 0);

                // Exit Loop If Any Product Does Not Validate
                if (valid == false)
                {
                    break;
                }
            }

            return valid;
        }
    }

    /// <summary>
    /// Order Total Validation
    /// </summary>
    public class OrderTotalSpecification : ISpecification<Models.Order>
    {
        public OrderTotalSpecification() { }

        public bool IsValid(Models.Order order)
        {
            return (order.Total > 0) && (order.Total <= 100);

        }
    }
}
