using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DeliveryFeeExemptedItem
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public short? MovApply { get; set; }
        public short? DelApply { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? LastModify { get; set; }

        public virtual MenuItemSizes MenuItemSizes { get; set; }
    }
}
