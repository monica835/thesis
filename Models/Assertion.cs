using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Assertion
    {
        public int IDAssertion { get; set; }
        public string Description { get; set; }
        public int IDAdmission { get; set; }
        public DateTime AssertionDate { get; set; }
        public int IDAssertionCategory { get; set; }
        public double Qty { get; set; }
        public double Price { get; set; }
        public double Markup { get; set; }
        public double MarkupValue { get; set; }
        public double SubTotal { get; set; }
        public string Notes { get; set; }
        public int IDChargeToCodep { get; set; }
        public DateTime PostedDate { get; set; }
    }
}