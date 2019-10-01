using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DeliveryAmount
    {
        public int DeliveryId { get; set; }
        public string LocationCode { get; set; }
        public string InventoryCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitCost { get; set; }

        public virtual Deliveries Deliveries { get; set; }
        public virtual InventoryItems InventoryItems { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
