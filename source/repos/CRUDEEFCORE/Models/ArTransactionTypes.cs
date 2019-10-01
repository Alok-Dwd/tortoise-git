using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArTransactionTypes
    {
        public ArTransactionTypes()
        {
            ArTransactionTypesDescriptions = new HashSet<ArTransactionTypesDescriptions>();
            ArTransactions = new HashSet<ArTransactions>();
        }

        public string LocationCode { get; set; }
        public int TransactionTypeCode { get; set; }
        public string TransactionDescription { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<ArTransactionTypesDescriptions> ArTransactionTypesDescriptions { get; set; }
        public virtual ICollection<ArTransactions> ArTransactions { get; set; }
    }
}
