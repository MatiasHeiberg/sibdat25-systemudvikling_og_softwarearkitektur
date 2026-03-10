using day7.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace day7Tests.Green
{
    public class OrderService
    {
        private readonly ILogger _logger;

        public OrderService(ILogger logger)
        {
            _logger = logger;
        }
        public Order CreateOrder(OrderContext context, IDiscountStrategy discount)
        {
    
            Product product = new Product() { Name = context.ProductName, Price = context.ProductPrice };
           
            Order order = new Order() { Product = product, Quantity = context.Quantity, CustomerMail = context.CustomerEmail, CustomerName = context.CustomerName};
            order.CalculateTotal();

            order.TotalPrice = discount.ApplyDiscount(order.TotalPrice);
            order.DiscountApplied = discount.Name;
           _logger.Log($"Ordre oprettet: {context.Quantity}x {context.ProductName} = {order.TotalPrice} kr.");

            return order;
        }
    }
}
