using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EodLog
    {
        public string LocationCode { get; set; }
        public DateTime? SystemDate { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? EodStartDatetime { get; set; }
        public DateTime? EodEndDatetime { get; set; }
        public decimal EodrunningFlag { get; set; }
        public DateTime? FlagChangeDatetime { get; set; }
        public string EodFlagReasonText { get; set; }
    }
}
