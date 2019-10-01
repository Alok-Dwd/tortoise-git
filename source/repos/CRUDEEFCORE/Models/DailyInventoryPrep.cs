using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DailyInventoryPrep
    {
        public DailyInventoryPrep()
        {
            DailyInventoryPrepDetail = new HashSet<DailyInventoryPrepDetail>();
        }

        public string LocationCode { get; set; }
        public int PrepId { get; set; }
        public DateTime SystemDate { get; set; }
        public string InventoryCode { get; set; }
        public string InventoryDescription { get; set; }
        public string OrderUnit { get; set; }
        public string PreparedBy { get; set; }
        public float PrepAmount { get; set; }
        public short PrepDays { get; set; }
        public short PrepHours { get; set; }
        public short PrepMinutes { get; set; }
        public short ReadyDays { get; set; }
        public short ReadyHours { get; set; }
        public short ReadyMinutes { get; set; }
        public short ShelfLifeDays { get; set; }
        public short ShelfLifeHours { get; set; }
        public short ShelfLifeMinutes { get; set; }
        public decimal RecipeCost { get; set; }
        public decimal YieldValue { get; set; }
        public DateTime CompletedDate { get; set; }
        public DateTime ReadyDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime? ProductReceived { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual InventoryItems InventoryItems { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<DailyInventoryPrepDetail> DailyInventoryPrepDetail { get; set; }
    }
}
