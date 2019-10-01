using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FinancialReportTypes
    {
        public string LocationCode { get; set; }
        public byte FinancialReportType { get; set; }
        public string Description { get; set; }
    }
}
