using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class BioForceLog
    {
        public string LocationCode { get; set; }
        public string EmpCode { get; set; }
        public string MgrId { get; set; }
        public string Role { get; set; }
        public DateTime? TimeIn { get; set; }
        public string Reason { get; set; }
        public DateTime? Added { get; set; }
        public int? ReasonId { get; set; }
    }
}
