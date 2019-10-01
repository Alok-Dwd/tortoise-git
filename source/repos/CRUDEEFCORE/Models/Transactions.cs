using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Transactions
    {
        public string LocationCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountId { get; set; }
        public int TransactionSequence { get; set; }
        public string AccountCode { get; set; }
        public string AccountDescription { get; set; }
        public byte AccountTypeCode { get; set; }
        public bool SystemAccount { get; set; }
        public byte PostingType { get; set; }
        public byte PostingDestination { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal? CurrencyAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string TransactionNumber { get; set; }
        public string TransactionDescription { get; set; }
        public byte TransactionPaymentType { get; set; }
        public string TransactionPaymentDescription { get; set; }
        public byte TransactionStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public string SubAccountCode { get; set; }
    }
}
