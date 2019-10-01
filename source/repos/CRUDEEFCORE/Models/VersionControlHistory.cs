using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VersionControlHistory
    {
        public string LocationCode { get; set; }
        public int? ParentId { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string SubType { get; set; }
        public string OldVersion { get; set; }
        public string NewVersion { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public string IpAddress { get; set; }
        public bool IsSetup { get; set; }
        public bool FromFileWatcher { get; set; }
        public bool IsAbort { get; set; }
    }
}
