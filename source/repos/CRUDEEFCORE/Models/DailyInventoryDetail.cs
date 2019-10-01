using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DailyInventoryDetail
    {
        public string LocationCode { get; set; }
        public string InventoryCode { get; set; }
        public DateTime EiDate { get; set; }
        public string OrderUnit { get; set; }
        public decimal Price { get; set; }
        public string CountUnit { get; set; }
        public float CountOrder { get; set; }
        public string PortionUnit { get; set; }
        public float PortionCount { get; set; }
        public float EndingOrderCount { get; set; }
        public float EndingCountCount { get; set; }
        public float EndingPortionCount { get; set; }
        public float WasteOrderCount { get; set; }
        public float WasteCountCount { get; set; }
        public float WastePortionCount { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual InventoryItems InventoryItems { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
