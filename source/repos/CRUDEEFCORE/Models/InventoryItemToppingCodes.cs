using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class InventoryItemToppingCodes
    {
        public string LocationCode { get; set; }
        public string InventoryCode { get; set; }
        public string ToppingCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
