using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class AdmissionVitalSigns
    {
        public int IDVitalSign { get; set; }
        public int IDAdmission { get; set; }
        public DateTime Performed { get; set; }
        public string BloodPressure { get; set; }
        public string PulseRate { get; set; }
        public string Weight { get; set; }
    }
}