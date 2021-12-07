using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplBill3.Models
{
    public class TipCalculator
    {
        public decimal total { get; set; }
        public decimal tipPercentage { get; set; }
        public decimal tipAmount { get; set; }
        public decimal newTotal { get; set; }
        public decimal percentageConvert { get; set; }

    }
}