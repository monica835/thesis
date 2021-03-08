using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class ExpensesForAssertion
    {
        public int IDChargeToCodep { get; set; }
        public DateTime ChargeDate { get; set; }
        public int IDAssertion { get; set; }
        public int IDExpense { get; set; }
        public string Description { get; set; }
    }
}