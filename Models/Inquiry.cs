using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Inquiry
    {
        public int IDInquiry { get; set; }
        public DateTime InquiryDate { get; set; }
        public string Codep { get; set; }
        public string ContactNo { get; set; }
        public string Prospect { get; set; }
        public string Details { get; set; }
        public DateTime FollowUpOn { get; set; }
        public int IDInquiryStatus { get; set; }
    }
}