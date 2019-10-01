using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CurrencyCommonBills
    {
        public string LocationCode { get; set; }
        public string CurrencyCode { get; set; }
        public string BillCode { get; set; }
        public string OrderDescription { get; set; }
        public decimal Amount { get; set; }
        public int DisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual CurrencyType CurrencyType { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
