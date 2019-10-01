using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderDigitalPayment
    {
        public string LocationCode { get; set; }
        public int TransactionId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? PayTypeCode { get; set; }
        public byte[] CardNumber { get; set; }
        public byte[] ExpiryDate { get; set; }
        public string Tid { get; set; }
        public string PaymentMode { get; set; }
        public TimeSpan? TransactionTime { get; set; }
        public string BatchNumber { get; set; }
        public decimal? Amount { get; set; }
        public string CardType { get; set; }
        public string InvoiceNumber { get; set; }
        public string AcquireName { get; set; }
        public string ApprovalCode { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string EdcrefId { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
