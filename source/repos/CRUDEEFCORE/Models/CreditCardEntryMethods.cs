using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardEntryMethods
    {
        public CreditCardEntryMethods()
        {
            CreditCardEntryMethodsDescriptions = new HashSet<CreditCardEntryMethodsDescriptions>();
        }

        public string LocationCode { get; set; }
        public byte EntryMethod { get; set; }
        public string Description { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<CreditCardEntryMethodsDescriptions> CreditCardEntryMethodsDescriptions { get; set; }
    }
}
