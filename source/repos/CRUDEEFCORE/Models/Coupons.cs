using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Coupons
    {
        public string LocationCode { get; set; }
        public string CouponCode { get; set; }
        public string Description { get; set; }
        public short CouponTypeCode { get; set; }
        public decimal Amount { get; set; }
        public bool? Adjustment { get; set; }
        public bool? Taxable { get; set; }
        public short StatusCode { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int DisplayOrder { get; set; }
        public bool? AnyItem { get; set; }
        public bool? EntireOrder { get; set; }
        public decimal MinPrice { get; set; }
        public bool ProtectCoupon { get; set; }
        public short RemoteOrderAvailability { get; set; }
        public bool GiftCardActivationDiscount { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual CouponsCapping CouponsCapping { get; set; }
    }
}
