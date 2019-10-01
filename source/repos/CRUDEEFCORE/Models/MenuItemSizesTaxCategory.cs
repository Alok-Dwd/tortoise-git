using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemSizesTaxCategory
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public int TaxCategoryId { get; set; }
        public bool TaxableByMargin { get; set; }
        public decimal Tax1TaxableAmount { get; set; }
        public decimal Tax2TaxableAmount { get; set; }
        public decimal Tax3TaxableAmount { get; set; }
        public decimal Tax4TaxableAmount { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
