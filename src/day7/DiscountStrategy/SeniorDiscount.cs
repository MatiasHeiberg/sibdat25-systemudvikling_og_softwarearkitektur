using System;
using System.Collections.Generic;
using System.Text;

namespace day7.Strategy
{
    internal class SeniorDiscount : IDiscountStrategy
    {
        public string Name { get; } = "SeniorDiscount (10%)";

        public decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice * 0.9m;
        }
    }
}
