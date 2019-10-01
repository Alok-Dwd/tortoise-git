using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderTransactionRefund
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public short OrderPayTypeCode { get; set; }
        public decimal? RefundAmount { get; set; }
        public byte? RefundTransactionStatusCode { get; set; }
        public string RefundMessage { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public int Sequence { get; set; }
    }
}
