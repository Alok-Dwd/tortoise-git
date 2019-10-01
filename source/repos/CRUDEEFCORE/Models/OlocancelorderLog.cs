using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OlocancelorderLog
    {
        public string LocationCode { get; set; }
        public decimal OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ActualOrderDate { get; set; }
        public string TentNumber { get; set; }
        public decimal CancelApiStatus { get; set; }
        public decimal RefundApiStatus { get; set; }
        public DateTime? OrderCancelDate { get; set; }
        public DateTime? CancelApiDate { get; set; }
        public DateTime? RefundApiDate { get; set; }
        public string ErrMessage { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public decimal RetryCount { get; set; }
    }
}
