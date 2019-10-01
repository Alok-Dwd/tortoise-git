using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderTransaction
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int PaymentLineNumber { get; set; }
        public short Sequence { get; set; }
        public string ComputerName { get; set; }
        public short OrderStatusCode { get; set; }
        public string CashOutId { get; set; }
        public byte CashOutShift { get; set; }
        public DateTime CashOutTime { get; set; }
        public short OrderPayTypeCode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Amount { get; set; }
        public decimal Tip { get; set; }
        public int WorkstationId { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
