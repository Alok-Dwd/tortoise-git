using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CurrencyType
    {
        public CurrencyType()
        {
            AppControl = new HashSet<AppControl>();
            CurrencyCommonBills = new HashSet<CurrencyCommonBills>();
            CurrencyExchange = new HashSet<CurrencyExchange>();
        }

        public string LocationCode { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public string OrderDescription { get; set; }
        public string Symbol { get; set; }
        public string PositiveFormat { get; set; }
        public string NegativeFormat { get; set; }
        public string Decimal { get; set; }
        public short? DecimalPlaces { get; set; }
        public string GroupingSymbol { get; set; }
        public short? DigitsInGroup { get; set; }
        public bool? TextColor { get; set; }
        public int DisplayOrder { get; set; }
        public byte[] CurrencyImage { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<AppControl> AppControl { get; set; }
        public virtual ICollection<CurrencyCommonBills> CurrencyCommonBills { get; set; }
        public virtual ICollection<CurrencyExchange> CurrencyExchange { get; set; }
    }
}
