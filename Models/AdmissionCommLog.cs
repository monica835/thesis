using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class AdmissionCommLog
    {
        public int IDAdmissionCommLog { get; set; }
        public int IDAdmission { get; set; }
        public DateTime LogDate { get; set; }
        public string Details { get; set; }
        public string PostedBy { get; set; }
    }
}