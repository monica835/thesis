using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Staff
    {
        public int IDStaff { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string ContactNo { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime DateTerminated { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
    }
}