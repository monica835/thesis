using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class InquiryCommLog
    {
        public int IDInquiryCommLog { get; set; }
        public int IDInquiry { get; set; }
        public DateTime CommDate { get; set; }
        public string InitiatedBy { get; set; }
        public string CommDetails { get; set; }
    }
}