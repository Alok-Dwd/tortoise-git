using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class InventoryItems
    {
        public InventoryItems()
        {
            DailyInventory = new HashSet<DailyInventory>();
            DailyInventoryDetail = new HashSet<DailyInventoryDetail>();
            DailyInventoryPrep = new HashSet<DailyInventoryPrep>();
            DailyInventoryPrepDetail = new HashSet<DailyInventoryPrepDetail>();
            DeliveryAmount = new HashSet<DeliveryAmount>();
        }

        public string LocationCode { get; set; }
        public string InventoryCode { get; set; }
        public short DisplayOrder { get; set; }
        public string Description { get; set; }
        public short StatusCode { get; set; }
        public int CountTypeCode { get; set; }
        public string InventoryTypeCode { get; set; }
        public short InventoryItemTypeCode { get; set; }
        public string OrderUnit { get; set; }
        public decimal Price { get; set; }
        public string CountUnit { get; set; }
        public float CountOrder { get; set; }
        public string PortionUnit { get; set; }
        public float PortionCount { get; set; }
        public string VendorCode { get; set; }
        public int MaxStockingLevel { get; set; }
        public int MinStockingLevel { get; set; }
        public string VendorItemCode { get; set; }
        public byte[] InstructionsImage { get; set; }
        public short PrepDays { get; set; }
        public short PrepHours { get; set; }
        public short PrepMinutes { get; set; }
        public short ReadyDays { get; set; }
        public short ReadyHours { get; set; }
        public short ReadyMinutes { get; set; }
        public short ShelfLifeDays { get; set; }
        public short ShelfLifeHours { get; set; }
        public short ShelfLifeMinutes { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual ICollection<DailyInventory> DailyInventory { get; set; }
        public virtual ICollection<DailyInventoryDetail> DailyInventoryDetail { get; set; }
        public virtual ICollection<DailyInventoryPrep> DailyInventoryPrep { get; set; }
        public virtual ICollection<DailyInventoryPrepDetail> DailyInventoryPrepDetail { get; set; }
        public virtual ICollection<DeliveryAmount> DeliveryAmount { get; set; }
    }
}
