using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemIfc
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string InventoryCode { get; set; }
        public float Amount { get; set; }
        public bool? ApplyCarryOut { get; set; }
        public bool? ApplyDelivery { get; set; }
        public bool? ApplyDineIn { get; set; }
        public bool? ApplyPickUp { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
