using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VersionControlExceptionalFile
    {
        public int Id { get; set; }
        public string SetupName { get; set; }
        public string LocationCode { get; set; }
        public string FileName { get; set; }
        public DateTime? AddedDate { get; set; }
        public string AddedBy { get; set; }
        public string IpAddress { get; set; }
        public bool? IsSync { get; set; }
    }
}
