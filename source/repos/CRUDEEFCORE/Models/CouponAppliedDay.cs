using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CouponAppliedDay
    {
        public string LocationCode { get; set; }
        public string CouponCode { get; set; }
        public int SequenceNumber { get; set; }
        public bool? Status { get; set; }
    }
}
