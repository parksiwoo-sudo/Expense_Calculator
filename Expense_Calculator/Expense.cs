using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Calculator
{
    public class Expense
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
