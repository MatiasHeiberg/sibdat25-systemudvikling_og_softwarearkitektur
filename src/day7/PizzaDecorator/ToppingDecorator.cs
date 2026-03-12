using System;
using System.Collections.Generic;
using System.Text;

namespace day7.PizzaDecorator
{
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza pizza;

        public ToppingDecorator(IPizza pizza) => this.pizza = pizza;
        public abstract decimal CalculatePrice();
        public abstract string GetDescription();
    }
}
