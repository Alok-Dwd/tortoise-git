using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AuditTrailReportOptions
    {
        public string LocationCode { get; set; }
        public int OptionId { get; set; }
        public int LanguageCode { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }
        public bool? GroupByOption { get; set; }
        public bool? SortByOption { get; set; }
    }
}
