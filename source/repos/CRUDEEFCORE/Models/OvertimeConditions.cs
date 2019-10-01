using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OvertimeConditions
    {
        public string LocationCode { get; set; }
        public short OvertimeCode { get; set; }
        public float? PayCalc { get; set; }
        public byte? Hours { get; set; }
        public bool DayOrWeek { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
