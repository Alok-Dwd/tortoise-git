using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DeliveryFee
    {
        public string LocationCode { get; set; }
        public decimal? MinValue { get; set; }
        public decimal? MaxValue { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public short? StatusCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? LastModify { get; set; }
    }
}
