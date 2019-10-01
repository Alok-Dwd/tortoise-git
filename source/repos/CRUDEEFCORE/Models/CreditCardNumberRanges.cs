using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardNumberRanges
    {
        public string LocationCode { get; set; }
        public int CardRangeId { get; set; }
        public string CardDescription { get; set; }
        public int CardBeginRange { get; set; }
        public int CardEndRange { get; set; }
        public int CardLength { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
