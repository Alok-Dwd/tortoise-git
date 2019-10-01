using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardActionCodes
    {
        public CreditCardActionCodes()
        {
            CreditCardActionCodesDescriptions = new HashSet<CreditCardActionCodesDescriptions>();
        }

        public string LocationCode { get; set; }
        public byte ActionCode { get; set; }
        public string Description { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<CreditCardActionCodesDescriptions> CreditCardActionCodesDescriptions { get; set; }
    }
}
