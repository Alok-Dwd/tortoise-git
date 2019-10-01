using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArTransactions
    {
        public ArTransactions()
        {
            ArTransactionsDetailArTransactions = new HashSet<ArTransactionsDetail>();
            ArTransactionsDetailArTransactionsNavigation = new HashSet<ArTransactionsDetail>();
        }

        public string LocationCode { get; set; }
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CustomerCode { get; set; }
        public int TransactionType { get; set; }
        public DateTime? DueDate { get; set; }
        public string TransactionNumber { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? PaymentLineNumber { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public byte? CreditPaymentType { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CurrencyAmount { get; set; }
        public string CheckCreditNumber { get; set; }
        public short TransactionStatus { get; set; }
        public string Comments { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? CreditTransactionId { get; set; }
        public string CompanyCode { get; set; }
        public byte? IsAdvance { get; set; }
        public string EventName { get; set; }
        public string EventVenue { get; set; }

        public virtual ArTransactionTypes ArTransactionTypes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<ArTransactionsDetail> ArTransactionsDetailArTransactions { get; set; }
        public virtual ICollection<ArTransactionsDetail> ArTransactionsDetailArTransactionsNavigation { get; set; }
    }
}
