using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OnsMenuItemIfcToppings
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string InventoryCode { get; set; }
        public int? NumberOfToppings { get; set; }
        public float? LightAmount { get; set; }
        public float? SingleAmount { get; set; }
        public float? ExtraAmount { get; set; }
        public float? DoubleAmount { get; set; }
        public float? TripleAmount { get; set; }
        public string AddedBy { get; set; }
        public string Added { get; set; }
    }
}
