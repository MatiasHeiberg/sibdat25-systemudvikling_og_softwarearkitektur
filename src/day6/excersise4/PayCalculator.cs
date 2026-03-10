using System;
using System.Collections.Generic;
using System.Text;

namespace day6.excersise4
{
    public class PayCalculator
    {
        public decimal Calculate(string type, decimal baseSalary, int hoursWorked)
        {
            decimal pay = 0;
            if (type == "FullTime")
                pay = baseSalary;
            else if (type == "PartTime")
                pay = hoursWorked * 150m;
            else if (type == "Freelancer")
                pay = hoursWorked * 200m;

            return pay;
        }
    }
}

