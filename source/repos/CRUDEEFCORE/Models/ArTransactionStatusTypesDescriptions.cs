using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArTransactionStatusTypesDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int TransactionStatusTypeCode { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }

        public virtual ArTransactionStatusTypes ArTransactionStatusTypes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
