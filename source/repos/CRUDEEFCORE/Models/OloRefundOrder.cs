using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OloRefundOrder
    {
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Status { get; set; }
        public string ErrorStatus { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
