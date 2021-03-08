using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class CodepUpdates
    {
        public int IDUpdate { get; set; }
        public DateTime DateUpdate { get; set; }
        public DateTime DateLog { get; set; }
        public string UpdateType { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdateSummary { get; set; }
        public int IDAdmission { get; set; }
    }
}