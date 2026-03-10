using day6.excersise4;
using System;
using System.Collections.Generic;
using System.Text;

namespace day6
{
    public class PayrollSystem
    {
        public void ProcessPayroll(string name, string type, decimal baseSalary, int hoursWorked)
        {
            // Beregn løn (varierer efter type)
            var payCalculator = new PayCalculator();
            var taxCalculator = new TaxCalculator();

            payCalculator.

            // Print lønseddel
            Console.WriteLine("=== Lønseddel ===");
            Console.WriteLine($"Navn: {name}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Bruttoløn: {pay:F2} kr");
            Console.WriteLine($"Skat (38%): {tax:F2} kr");
            Console.WriteLine($"Nettoløn: {netPay:F2} kr");
            Console.WriteLine();
        }
    }
}

