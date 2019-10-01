using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AvgOrd
    {
        public string Dpinum { get; set; }
        public string LocationCode { get; set; }
        public string Name { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? OrderHour { get; set; }
        public decimal? OrderCnt { get; set; }
        public decimal? DayOfWeek { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string OrdTyp { get; set; }
        public string Added { get; set; }
        public DateTime? SysDate { get; set; }
    }
}
