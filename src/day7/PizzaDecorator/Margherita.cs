using System;
using System.Collections.Generic;
using System.Text;

namespace day7.PizzaDecorator
{
    public class Margherita : IPizza  
    {
        public decimal CalculatePrice() => 59m;

        public string GetDescription() => "Margherita";
    }
}
