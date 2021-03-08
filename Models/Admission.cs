using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Admission
    {
        public int IDAdmission { get; set; }
        public int IDResident { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public double TreatmentFee { get; set; }
        public string IisActive { get; set; }
        public string Notes { get; set; }
        public double TotalBilling { get; set; }
        public double OverallBalance { get; set; }
        public char StopTFBilling { get; set; }
        public string Status { get; set; }
        public int IDRank { get; set; }
        public string Phase { get; set; }
    }
}