using System;
using System.Collections.Generic;
using System.Text;

namespace day7.Strategy
{
    public class StudentDiscount : IDiscountStrategy
    {
        public string Name { get; } = "Studenterrabat (15%)";

        public decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice * 0.85m;
        }
    }
}
