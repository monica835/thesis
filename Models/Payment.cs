using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Payment
    {
        public int IDPayment { get; set; }
        public DateTime PaidDate { get; set; }
        public int IDAdmission { get; set; }
        public double TotalPaid { get; set; }
        public int IDPaymentMethod { get; set; }
        public string Bank { get; set; }
        public string CheckNo { get; set; }
        public DateTime CheckDate { get; set; }
        public string Notes { get; set; }
        public char IsVerified { get; set; }
        public DateTime PostedDate { get; set; }
    }
}