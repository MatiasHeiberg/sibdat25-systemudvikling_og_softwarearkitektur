using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class PriceCalculator
    {
        public decimal CalculatePrice(int quantity, decimal price)
        {
            return quantity * price;
        }
    }
}
