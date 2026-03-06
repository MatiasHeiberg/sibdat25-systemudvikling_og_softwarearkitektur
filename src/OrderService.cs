using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderService
    {
        public Order CreateOrder(string productName, decimal price, int quantity)
        {
            decimal totalPrice = new PriceCalculator().CalculatePrice(quantity, price);
            Product product = new Product(productName, price);
            Order order = new Order(product, quantity, totalPrice);
            new ConsoleLogger().Log($"New order: {quantity} {productName} at a total price of {totalPrice}");
            return order;
        }
    }
}
