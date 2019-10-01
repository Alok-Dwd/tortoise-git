using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SalesPeriodHours
    {
        public string LocationCode { get; set; }
        public string SalesPeriodCode { get; set; }
        public short DayOfWeek { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
