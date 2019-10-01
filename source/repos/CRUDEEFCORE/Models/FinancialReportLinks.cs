using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FinancialReportLinks
    {
        public string LocationCode { get; set; }
        public int FrDesignId { get; set; }
        public int FrParentLineId { get; set; }
        public int FrLinkId { get; set; }
        public byte FrLinkType { get; set; }
        public int? AccountId { get; set; }
        public int? FrChildLineId { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
