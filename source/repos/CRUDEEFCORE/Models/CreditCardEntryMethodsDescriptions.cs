using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardEntryMethodsDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte EntryMethod { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }

        public virtual CreditCardEntryMethods CreditCardEntryMethods { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
