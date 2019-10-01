using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CouponsCapping
    {
        public string LocationCode { get; set; }
        public string CouponCode { get; set; }
        public bool CappingStatus { get; set; }
        public decimal? MinOrderAmount { get; set; }
        public decimal? MaxCouponAmount { get; set; }
        public bool LineCouponExcluded { get; set; }
        public bool? ApplyCombo { get; set; }
        public bool ApplyDelivery { get; set; }
        public bool ApplyDineIn { get; set; }
        public bool ApplyCarryOut { get; set; }
        public bool ApplyOdc { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? LastModify { get; set; }

        public virtual Coupons Coupons { get; set; }
    }
}
