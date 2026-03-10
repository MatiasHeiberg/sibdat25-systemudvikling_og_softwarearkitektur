using day7.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace day7Tests.Green
{
    public class OrderContext
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public IDiscountStrategy DiscountType { get; set; } // "ingen", "student", "senior", "medarbejder"
    }

}
