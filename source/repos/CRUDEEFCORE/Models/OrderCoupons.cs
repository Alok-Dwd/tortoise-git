using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderCoupons
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public int OrdCpnNbr { get; set; }
        public int OrdCpnRevNbr { get; set; }
        public string OrdCpnUpdateUserCode { get; set; }
        public DateTime? OrdCpnUpdateDate { get; set; }
        public string CouponCode { get; set; }
        public int OrdCpnQty { get; set; }
        public decimal? OrdCpnOverrideValue { get; set; }
        public decimal OrdCpnCouponDiscountAmt { get; set; }
        public bool OrdCpnIsCollected { get; set; }
        public string OrdCpnExtendedCode { get; set; }
        public string OrdCpnDescriptiveText { get; set; }
        public decimal OrdCpnBlockModifyDiscountAmt { get; set; }
        public string OrdCpnCampaignCode { get; set; }
        public string OrdCpnCampaignCodePhoneNumber { get; set; }
    }
}
