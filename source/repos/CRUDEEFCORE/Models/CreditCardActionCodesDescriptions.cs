using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardActionCodesDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte ActionCode { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }

        public virtual CreditCardActionCodes CreditCardActionCodes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
