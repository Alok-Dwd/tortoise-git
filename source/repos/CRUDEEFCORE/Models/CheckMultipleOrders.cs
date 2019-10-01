using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CheckMultipleOrders
    {
        public string LocationCode { get; set; }
        public string TentNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public byte? OrderStatus { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? AddedDatetime { get; set; }
    }
}
