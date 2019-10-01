using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class TempIstStnData
    {
        public string LocationCode { get; set; }
        public int? DeliveryId { get; set; }
        public string VendorCode { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string InventoryCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
