using System;
using System.Collections.Generic;
using System.Text;

namespace day6.excersise4
{
    public class TaxCalculator
    {
        public decimal CalculateTax(decimal grossPay)
        {
            decimal tax = grossPay * 0.38m;
            decimal netPay = grossPay - tax;
            return netPay;
        }
    }
}
