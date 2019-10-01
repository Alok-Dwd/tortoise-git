using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemCoupons
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string CouponCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public short StatusCode { get; set; }
    }
}
