using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArTransactionStatusTypes
    {
        public ArTransactionStatusTypes()
        {
            ArTransactionStatusTypesDescriptions = new HashSet<ArTransactionStatusTypesDescriptions>();
        }

        public string LocationCode { get; set; }
        public int TransactionStatusTypeCode { get; set; }
        public string TransactionStatusDescription { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<ArTransactionStatusTypesDescriptions> ArTransactionStatusTypesDescriptions { get; set; }
    }
}
