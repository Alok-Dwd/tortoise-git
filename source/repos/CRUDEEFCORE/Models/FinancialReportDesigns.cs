using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FinancialReportDesigns
    {
        public string LocationCode { get; set; }
        public int FrDesignId { get; set; }
        public string FrDesignDescription { get; set; }
        public byte FinancialReportType { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
