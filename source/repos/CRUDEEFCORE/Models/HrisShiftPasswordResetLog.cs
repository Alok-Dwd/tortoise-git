using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class HrisShiftPasswordResetLog
    {
        public string LocationCode { get; set; }
        public string LoginEmployeeCode { get; set; }
        public string EmployeeCode { get; set; }
        public string EventType { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? SystemDate { get; set; }
    }
}
