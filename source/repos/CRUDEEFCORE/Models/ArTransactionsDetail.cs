using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArTransactionsDetail
    {
        public string LocationCode { get; set; }
        public int TransactionDetailId { get; set; }
        public int TransactionId { get; set; }
        public int ReferenceId { get; set; }
        public decimal AmountApplied { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual ArTransactions ArTransactions { get; set; }
        public virtual ArTransactions ArTransactionsNavigation { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
