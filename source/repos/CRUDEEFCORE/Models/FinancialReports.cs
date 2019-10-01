using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FinancialReports
    {
        public string LocationCode { get; set; }
        public int FinancialReportId { get; set; }
        public string FinancialReportDescription { get; set; }
        public int FrDesignId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
