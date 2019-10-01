using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AodLog
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public string CouponCode { get; set; }
        public decimal CouponAmount { get; set; }
        public bool? IsActive { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string DynamicCouponCode { get; set; }
        public int Sequence { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
