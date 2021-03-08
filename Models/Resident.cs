using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Resident
    {
        public int IDResident { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Codep { get; set; }
        public string Relationship { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}