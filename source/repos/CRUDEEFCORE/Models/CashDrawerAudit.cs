using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CashDrawerAudit
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int WorkstationId { get; set; }
        public short Sequence { get; set; }
        public string ComputerName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal OrderPayments { get; set; }
        public decimal VoidedOrderPayments { get; set; }
        public decimal TotalOrderPayments { get; set; }
        public decimal CashSalesTotal { get; set; }
        public decimal CreditCardSalesTotal { get; set; }
        public decimal CheckSalesTotal { get; set; }
        public decimal ArSalesTotal { get; set; }
        public decimal GiftCardSalesTotal { get; set; }
        public decimal TotalPayments { get; set; }
        public decimal TipTotal { get; set; }
        public decimal StartTillAmount { get; set; }
        public decimal TillToAccount { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
