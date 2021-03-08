using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Attachments
    {
        public int IDAttachment { get; set; }
        public string Description { get; set; }
        public string Filename { get; set; }
        public byte[] UploadedFile { get; set; }
        public int IDReference { get; set; }
        public string TableName { get; set; }
    }
}