using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class AdmissionBillilng
    {
        public int IDAdmissionBilling { get; set; }
        public int IDAdmission { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime GeneratedDate { get; set; }
        public double Amount { get; set; }
        public string Notes { get; set; }
        public DateTime PostedDate { get; set; }
        public string GeneratedBy { get; set; }
    }
}