using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardTransactionTypesDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte TransactionType { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }

        public virtual CreditCardTransactionTypes CreditCardTransactionTypes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
