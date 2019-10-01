using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CurrencyExchange
    {
        public string LocationCode { get; set; }
        public DateTime SystemDate { get; set; }
        public string CurrencyCode { get; set; }
        public float ExchangeRate { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual CurrencyType CurrencyType { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
