using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class CashAdvancePayment
    {
        public int IDCA { get; set; }
        public DateTime DateCA { get; set; }
        public int IDStaff { get; set; }
        public double Amount { get; set; }
        public string Notes { get; set; }
        public char IsPaid { get; set; }
    }
}