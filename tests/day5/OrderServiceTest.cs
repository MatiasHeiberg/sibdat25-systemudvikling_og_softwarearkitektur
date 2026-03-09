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
        // Skrevet til at teste coupled application kode, derfor skal alle objekterne oprettes for at CreateOrder() kan testes
        [Theory]
        [InlineData("test1", 200, 3)]
        [InlineData("test2", 0, 1)]
        public void Should_CalculateTotal_When_OrderIsCreated(string productName, decimal price, int quantity)
        {
            var service = new OrderService(
            new PriceCalculator(),
            new ConsoleLogger());
            var expected = price * quantity;

            var result = service.CreateOrder(productName, price, quantity).TotalPrice;

            Assert.Equal(expected, result);
        }
    }
}
