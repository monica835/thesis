using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class ResidentActivity
    {
        public int IDResidentActivityLog { get; set; }
        public DateTime LogDate { get; set; }
        public int IDAdmission { get; set; }
        public string Position { get; set; }
        public string Activity { get; set; }
        public string PostedBy { get; set; }
    }
}