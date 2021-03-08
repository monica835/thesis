using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class FacilityReport
    {
        public int IDFacilityReport { get; set; }
        public DateTime ReportDate { get; set; }
        public string Activity { get; set; }
        public string PostedBy { get; set; }
    }
}