using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VersionInfo
    {
        public string LocationCode { get; set; }
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Version { get; set; }
        public DateTime? AddedDate { get; set; }
        public string AddedBy { get; set; }
        public bool? Status { get; set; }
        public int? UpdateCount { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
