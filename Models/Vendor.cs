using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Vendor
    {
        public int IDVendor { get; set; }
        public string VendorName { get; set; }
        public string ContactPerson { get; set; }
        public string COntactNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public char IsActive { get; set; }
        public string TIN { get; set; }
    }
}