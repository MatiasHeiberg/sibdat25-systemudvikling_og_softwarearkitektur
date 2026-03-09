using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class PriceCalculator : IPriceCalculator
    {
        public decimal CalculateTotal(decimal price, int quantity)
        {
            return quantity * price;
        }
    }
}
