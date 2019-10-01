using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardTransaction
    {
        public string LocationCode { get; set; }
        public int TransactionId { get; set; }
        public byte CreditCardId { get; set; }
        public byte TransactionStatusCode { get; set; }
        public string Message { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public int? CustomerCode { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string StreetNumber { get; set; }
        public int? StreetCode { get; set; }
        public int? CrossStreetCode { get; set; }
        public string Suite { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string MailingAddress { get; set; }
        public string PostalCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderTypeCode { get; set; }
        public bool? PayNow { get; set; }
        public decimal? OrderAmount { get; set; }
        public int? WorkstationId { get; set; }
        public string ComputerName { get; set; }
        public string OrderTakerId { get; set; }
        public int OrderNumber { get; set; }
        public short? TransactionTime { get; set; }
        public decimal? RefundAmount { get; set; }
        public byte? RefundTransactionStatusCode { get; set; }
        public string RefundMessage { get; set; }
        public short? RefundTransactionTime { get; set; }
        public decimal? CancelAmount { get; set; }
        public byte? CancelTransactionStatusCode { get; set; }
        public string CancelMessage { get; set; }
        public short? CancelTransactionTime { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public string EdcrefId { get; set; }
    }
}
