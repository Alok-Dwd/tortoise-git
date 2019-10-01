using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstTmpTax
    {
        public string InventoryItem { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public int? TaxId { get; set; }
        public decimal? TaxIdRate { get; set; }
        public int? TaxCalcId { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxAmount { get; set; }
    }
}
