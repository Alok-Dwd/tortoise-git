using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CouponsExemptedItems
    {
        public string LocationCode { get; set; }
        public string CouponCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public bool? ExemptedStatus { get; set; }
        public bool? OrderValueExempted { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
