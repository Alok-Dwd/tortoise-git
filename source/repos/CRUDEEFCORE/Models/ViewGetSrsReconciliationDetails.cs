using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewGetSrsReconciliationDetails
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public string OrderTypeCode { get; set; }
        public string OrderTypeDesc { get; set; }
        public string DriverName { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? SalesVariance { get; set; }
        public int OrderPayTypeCode { get; set; }
        public string OrderPayTypeDesc { get; set; }
        public DateTime? TransactionTime { get; set; }
        public int PaymentLineNumber { get; set; }
        public int Sequence { get; set; }
        public int? TransactionId { get; set; }
        public string BankInfo { get; set; }
        public string TentNumber { get; set; }
        public string Tid { get; set; }
        public string BatchNumber { get; set; }
        public string AcquireName { get; set; }
        public string CardType { get; set; }
        public string PaymentMode { get; set; }
        public string InvoiceNumber { get; set; }
        public string ApprovalCode { get; set; }
        public string ResponseCode { get; set; }
        public string EdcrefId { get; set; }
        public string CashOutId { get; set; }
        public string AddedBy { get; set; }
        public int SalesPayId { get; set; }
        public string SalesPayHead { get; set; }
        public bool? DelayedOrder { get; set; }
    }
}
