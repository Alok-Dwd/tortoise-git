using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OfflineLog
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string PosInvoice { get; set; }
        public string MannualInvoice { get; set; }
        public bool Status { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
