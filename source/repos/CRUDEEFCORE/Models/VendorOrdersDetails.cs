using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VendorOrdersDetails
    {
        public string LocationCode { get; set; }
        public int VendorOrderId { get; set; }
        public string InventoryCode { get; set; }
        public string InventoryDescription { get; set; }
        public string InventoryCountType { get; set; }
        public string VendorItemCode { get; set; }
        public string OrderUnit { get; set; }
        public decimal AmountNeeded { get; set; }
        public decimal CurrentInventory { get; set; }
        public decimal SuggestedOrder { get; set; }
        public decimal ActualOrder { get; set; }
        public decimal Price { get; set; }
        public decimal OrderCost { get; set; }
        public int MaxStockingLevel { get; set; }
        public int MinStockingLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
