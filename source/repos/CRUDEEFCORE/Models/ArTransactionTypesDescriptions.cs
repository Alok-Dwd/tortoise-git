using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArTransactionTypesDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int TransactionTypeCode { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }

        public virtual ArTransactionTypes ArTransactionTypes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
