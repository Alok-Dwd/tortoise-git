using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PayrollControl
    {
        public string LocationCode { get; set; }
        public DateTime StartingDate { get; set; }
        public byte PayrollTypeCode { get; set; }
        public bool Monthly { get; set; }
        public byte? NumberOfDays { get; set; }
        public int? OvertimeConditions { get; set; }
        public bool ApplyOvertimeContract { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
