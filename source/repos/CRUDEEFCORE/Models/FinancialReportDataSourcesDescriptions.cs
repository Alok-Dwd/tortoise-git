using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FinancialReportDataSourcesDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int DataSource { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }
    }
}
