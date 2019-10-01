using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderTypeOptions
    {
        public string LocationCode { get; set; }
        public string OrderTypeCode { get; set; }
        public short PrintLabelEventCode { get; set; }
        public short PrintReceiptEventCode { get; set; }
    }
}
