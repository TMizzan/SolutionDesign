using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using DesignPatterns;

namespace SolutionDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Specification Pattern Test
                Console.WriteLine($"{System.DateTime.Now.ToShortDateString() } " +
                                  $"{System.DateTime.Now.ToShortTimeString() } " +
                                  $"Order Result Validation: {ValidateOrder()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception :  {ex.ToString()}");
            }

            // Allow User To View Results And End Console Program
            Console.ReadLine();
        }

        private static Models.Order BuildOrder()
        {
            return new Models.Order
            {
                CustomerId  = "C100",
                OrderNumber = "123456789",
                OrderDate   = Convert.ToDateTime("1/1/2024"),
                Products    = new System.Collections.Generic.List<Models.Product>
                                { new Models.Product("123456789", "P34567", "Mug", "Thermal Mug", 12.50M, "UPC9747393000", 50),
                                  new Models.Product("123456789", "T45678", "Tee", "Tee Shirt", 26.00M, "UPC8647393001", 60)},
                Total       = 38.50M,
                Discount    = 10
            };
        }

        private static bool ValidateOrder()
        {
            DesignPatterns.OrderNumberSpecification orderNumberSpecification     = new DesignPatterns.OrderNumberSpecification();
            DesignPatterns.OrderProductsSpecification orderProductsSpecification = new DesignPatterns.OrderProductsSpecification();
            DesignPatterns.OrderTotalSpecification orderTotalSpecification       = new DesignPatterns.OrderTotalSpecification();

            System.Collections.Generic.List<DesignPatterns.ISpecification<Order>> andSpecifications =
                new System.Collections.Generic.List<DesignPatterns.ISpecification<Order>>
                {orderNumberSpecification, orderProductsSpecification, orderTotalSpecification};

            Models.Order order = BuildOrder();

            bool valid = new DesignPatterns.AndSpecification<Order>(andSpecifications).IsValid(order);

            return valid;
        }
    }
}
