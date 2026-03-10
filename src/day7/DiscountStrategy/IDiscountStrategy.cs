using System;
using System.Collections.Generic;
using System.Text;

namespace day7.Strategy
{
    public interface IDiscountStrategy
    {
        string Name { get; }
        decimal ApplyDiscount(decimal totalPrice);
    }
}
