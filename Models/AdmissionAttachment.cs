using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class AdmissionAttachment
    {
        public int IDAdmAttachment { get; set; }
        public int IDAdmission { get; set; }
        public string Description { get; set; }
        public string Filename { get; set; }
        public byte[] UploadedFile { get; set; }
        public int IDAttachment { get; set; }
    }
}