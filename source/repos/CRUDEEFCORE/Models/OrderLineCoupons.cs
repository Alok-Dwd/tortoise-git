using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderLineCoupons
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public short LineNumber { get; set; }
        public int OrdCpnNbr { get; set; }
        public int OrdLineQty { get; set; }
        public int OrdCpnQty { get; set; }
        public decimal OrdLineCpnCouponDiscountAmt { get; set; }
    }
}
