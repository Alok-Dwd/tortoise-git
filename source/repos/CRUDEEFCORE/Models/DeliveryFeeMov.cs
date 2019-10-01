using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DeliveryFeeMov
    {
        public string LocationCode { get; set; }
        public string OrderTypeCode { get; set; }
        public short? StatusCode { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public decimal? MinOrderValue { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? LastModify { get; set; }
    }
}
