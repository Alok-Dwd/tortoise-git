using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemDisCoupons
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string CouponCode { get; set; }
        public decimal? Discount { get; set; }
        public short StatusCode { get; set; }
        public short Priority { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
