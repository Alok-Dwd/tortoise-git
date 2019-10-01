using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FinancialReportDesignDetails
    {
        public string LocationCode { get; set; }
        public int FrDesignId { get; set; }
        public int FrLineId { get; set; }
        public string FrAccountCode { get; set; }
        public string FrAccountDescription { get; set; }
        public int DisplayOrder { get; set; }
        public byte IndentionLevel { get; set; }
        public int LineType { get; set; }
        public int? LabelFormatType { get; set; }
        public int? DataFormatType { get; set; }
        public int? ActualDataSource { get; set; }
        public decimal? ActualDataAmount { get; set; }
        public int? BudgetDataSource { get; set; }
        public decimal? BudgetDataAmount { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
