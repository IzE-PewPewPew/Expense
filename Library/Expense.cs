using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseLib
{
    public class Expense
    {
        public int No { get; set; } = 0;
        public string Descr { get; set; } = "";
        public double Amount { get; set; } = 0.0;
    }
}
