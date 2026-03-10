using System;
using System.Collections.Generic;
using System.Text;

namespace day7.Strategy
{
    public class NoDiscount : IDiscountStrategy
    {
        public string Name { get; } = "Ingen rabat";

        public decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice;
        }
    }
}
