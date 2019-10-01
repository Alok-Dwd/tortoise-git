using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PulseApiorderDataDtl
    {
        public int DtlId { get; set; }
        public string OrderDateOrderNumber { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public float? Quantity { get; set; }

        public virtual PulseApiorderData OrderDateOrderNumberNavigation { get; set; }
    }
}
