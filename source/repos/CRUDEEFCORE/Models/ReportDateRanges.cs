using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ReportDateRanges
    {
        public int RangeId { get; set; }
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }
        public short? TypicalDays { get; set; }
    }
}
