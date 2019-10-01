using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderPaymentSavedMode
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int PaymentLineNumber { get; set; }
        public int Sequence { get; set; }
        public short OrderPayTypeCode { get; set; }
        public decimal AmountTendered { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal ChangeDue { get; set; }
        public decimal? CurrencyAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string CheckInfo { get; set; }
        public bool Deleted { get; set; }
        public string CashOutId { get; set; }
        public byte CashOutShift { get; set; }
        public DateTime? CashOutTime { get; set; }
        public decimal Tip { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public int? TransactionId { get; set; }
        public bool? DriverCheckIn { get; set; }
        public bool? ManagerCheckIn { get; set; }
        public int? ManagerApproved { get; set; }
        public bool? Ispay { get; set; }
    }
}
