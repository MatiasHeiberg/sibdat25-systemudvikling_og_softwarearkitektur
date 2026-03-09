using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemTest
{
    public class FakePriceCalculator : OrderSystem.IPriceCalculator
    {
        private decimal _fakeResult = 1000m;
        public decimal CalculateTotal(decimal price, int quantity)
        {
            return _fakeResult;
        }
    }
}
