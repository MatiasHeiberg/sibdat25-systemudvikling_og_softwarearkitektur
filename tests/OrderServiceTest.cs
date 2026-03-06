using OrderSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrderSystemTest
{
    public class OrderServiceTest
    {
        [Theory]
        [InlineData("test1", 200, 3)]
        [InlineData("test2", 0, 1)]
        public void Should_CalculateTotal_When_OrderIsCreated(string productName, decimal price, int quantity)
        {
            var service = new OrderService();
            var expected = price * quantity;

            var result = service.CreateOrder(productName, price, quantity).TotalPrice;

            Assert.Equal(expected, result);
        }
    }
}
