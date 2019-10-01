using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class TimeClockBiometric
    {
        public string LocationCode { get; set; }
        public string EmployeeCode { get; set; }
        public string PositionCode { get; set; }
        public DateTime SystemDate { get; set; }
        public byte DateShiftNumber { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public DateTime? BiometricTimeIn { get; set; }
        public DateTime? BiometricTimeOut { get; set; }
    }
}
