using System;
using System.Collections.Generic;
using System.Text;

namespace day7.PizzaDecorator
{
    public interface IPizza
    {
        decimal CalculatePrice();
        string GetDescription();
    }
}
