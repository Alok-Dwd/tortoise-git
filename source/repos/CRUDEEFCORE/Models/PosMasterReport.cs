using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PosMasterReport
    {
        public string LocationCode { get; set; }
        public int ReportId { get; set; }
        public string SpName { get; set; }
        public string Descripition { get; set; }
        public bool Active { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
