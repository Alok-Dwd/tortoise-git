using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class InventoryItemNutritionalValues
    {
        public string LocationCode { get; set; }
        public string NutritionalItemCode { get; set; }
        public string InventoryCode { get; set; }
        public float NutritionalValue { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
