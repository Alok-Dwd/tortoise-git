using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CouponHappyHour
    {
        public string LocationCode { get; set; }
        public string CouponCode { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public bool? Status { get; set; }
    }
}
