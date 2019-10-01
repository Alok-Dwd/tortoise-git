using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PosupdateLogs
    {
        public string LocationCode { get; set; }
        public bool? Status { get; set; }
        public string Description { get; set; }
        public string PosNumber { get; set; }
        public DateTime? PosDate { get; set; }
        public string Remarks { get; set; }
        public string Version { get; set; }
        public string Source { get; set; }
    }
}
