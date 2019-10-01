using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CouponRuleEngine
    {
        public string LocationCode { get; set; }
        public string CouponCode { get; set; }
        public int PrimaryItemCount { get; set; }
        public int DiscountItemCount { get; set; }
        public int DiscountType { get; set; }
        public short? AnyItem { get; set; }
        public int DiscountItemCountLimit { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
