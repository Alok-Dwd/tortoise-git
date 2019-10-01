using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GstInventoryItemsDomFinal
    {
        public string InventoryCode { get; set; }
        public string Hsn { get; set; }
        public string GstRates { get; set; }
        public int TaxCategoryId { get; set; }
    }
}
