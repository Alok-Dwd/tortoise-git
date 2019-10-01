using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ProductPricingTablePrices
    {
        public string LocationCode { get; set; }
        public string ProdCatCode { get; set; }
        public string PrPrcTblCode { get; set; }
        public int PptPriceSeq { get; set; }
        public string OptPrcTblCode { get; set; }
        public int PptPriceMinCount { get; set; }
        public int PptPriceMaxCount { get; set; }
        public decimal PptPricePrice { get; set; }
    }
}
