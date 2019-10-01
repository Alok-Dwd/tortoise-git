using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Period
    {
        public string LocationCode { get; set; }
        public string YearCode { get; set; }
        public string PeriodCode { get; set; }
        public string PeriodDescription { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
