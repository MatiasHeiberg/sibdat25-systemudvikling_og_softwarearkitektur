using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderService
    {
        private readonly IPriceCalculator _calculator;
        private readonly ILogger _logger;

        public OrderService(IPriceCalculator calculator, ILogger logger)
        {
            this._calculator = calculator;
            this._logger = logger;
        }
        public Order CreateOrder(string productName, decimal price, int quantity)
        {
            var totalPrice = _calculator.CalculateTotal(price, quantity);
            Product product = new Product(productName, price);
            Order order = new Order(product, quantity, totalPrice);

            _logger.Log($"New order: {quantity} {productName} at a total price of {totalPrice}");
            return order;
        }
    }
}
