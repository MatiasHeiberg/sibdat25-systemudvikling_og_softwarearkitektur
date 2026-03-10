using System;
using System.Collections.Generic;
using System.Text;

namespace day7.Strategy
{
    internal class EmployeeDiscount : IDiscountStrategy
    {
        public string Name { get; } = $"Medarbejderrabat ({200:C})";

        public decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice - 200;
        }
    }
}
