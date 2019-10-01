using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OnsMenuItemIfc
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string InventoryCode { get; set; }
        public float? Amount { get; set; }
        public bool? ApplyCarryout { get; set; }
        public bool? ApplyDelivery { get; set; }
        public bool? ApplyDinein { get; set; }
        public bool? ApplyPickup { get; set; }
        public string AddedBy { get; set; }
        public string Added { get; set; }
    }
}
