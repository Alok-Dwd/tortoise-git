using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class UsrTaxInfo
    {
        public string LocationCode { get; set; }
        public string MultiTaxType { get; set; }
        public string TaxStructure { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string TaxRate1 { get; set; }
        public string TaxRate2 { get; set; }
        public string MessageBottom { get; set; }
        public string MessageTop { get; set; }
    }
}
