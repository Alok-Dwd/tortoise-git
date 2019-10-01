using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class InventoryToppingPercentages
    {
        public string LocationCode { get; set; }
        public string ToppingCode { get; set; }
        public short ToppingCount { get; set; }
        public float PercentUsed { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
