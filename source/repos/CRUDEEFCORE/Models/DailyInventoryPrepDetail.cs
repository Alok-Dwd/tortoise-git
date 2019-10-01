using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DailyInventoryPrepDetail
    {
        public string LocationCode { get; set; }
        public int PrepId { get; set; }
        public string SubInventoryCode { get; set; }
        public string SubInventoryDescription { get; set; }
        public bool Ingredient { get; set; }
        public float Amount { get; set; }
        public byte InventoryUnit { get; set; }
        public string OrderUnit { get; set; }
        public decimal UnitCost { get; set; }
        public string CountUnit { get; set; }
        public float CountOrder { get; set; }
        public string PortionUnit { get; set; }
        public float PortionCount { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual DailyInventoryPrep DailyInventoryPrep { get; set; }
        public virtual InventoryItems InventoryItems { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
