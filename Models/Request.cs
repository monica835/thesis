using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Request
    {
        public int IDRequest { get; set; }
        public DateTime DateRequest { get; set; }
        public DateTime DateNeeded { get; set; }
        public string RequestedBy { get; set; }
        public string RequestName { get; set; }
        public double Budget { get; set; }
        public string ApprovedBy { get; set; }
        public int IDRequestStatus { get; set; }
        public string ApproverNotes { get; set; }
        public DateTime DateApproved { get; set; }
        public string RequestorEmail { get; set; }
        public DateTime DateAcc { get; set; }
        public string RequestorNotes { get; set; }
    }
}