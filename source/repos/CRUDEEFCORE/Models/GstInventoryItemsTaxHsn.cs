using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GstInventoryItemsTaxHsn
    {
        public string LocationCode { get; set; }
        public string InventoryCode { get; set; }
        public int GstTaxCategoryId { get; set; }
        public string HsnSacCode { get; set; }
        public short StatusCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
