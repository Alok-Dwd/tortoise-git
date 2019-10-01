using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FinancialReportTypesDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte FinancialReportType { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }
    }
}
