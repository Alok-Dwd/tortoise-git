using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CouponBogo
    {
        public string LocationCode { get; set; }
        public string CouponCode { get; set; }
        public int TotalItemCount { get; set; }
        public int FreeCount { get; set; }
        public bool IsMinItem { get; set; }
        public bool? Status { get; set; }
    }
}
