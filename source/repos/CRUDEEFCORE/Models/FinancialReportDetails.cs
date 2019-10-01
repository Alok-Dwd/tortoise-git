using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FinancialReportDetails
    {
        public string LocationCode { get; set; }
        public int FinancialReportId { get; set; }
        public int FinancialReportLineId { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal ActualPercent { get; set; }
        public decimal BudgetAmount { get; set; }
        public decimal BudgetPercent { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
