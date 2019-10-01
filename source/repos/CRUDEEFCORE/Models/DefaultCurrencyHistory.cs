using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DefaultCurrencyHistory
    {
        public string LocationCode { get; set; }
        public string DefaultCurrency { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
