using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardTransactionTypes
    {
        public CreditCardTransactionTypes()
        {
            CreditCardTransactionTypesDescriptions = new HashSet<CreditCardTransactionTypesDescriptions>();
        }

        public string LocationCode { get; set; }
        public byte TransactionType { get; set; }
        public string Description { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<CreditCardTransactionTypesDescriptions> CreditCardTransactionTypesDescriptions { get; set; }
    }
}
