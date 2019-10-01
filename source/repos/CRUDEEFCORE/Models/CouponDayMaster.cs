using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CouponDayMaster
    {
        public string LocationCode { get; set; }
        public int? SequenceNumber { get; set; }
        public string DayName { get; set; }
        public bool? Status { get; set; }
    }
}
