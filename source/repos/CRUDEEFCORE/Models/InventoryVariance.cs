using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class InventoryVariance
    {
        public string InventoryName { get; set; }
        public decimal? InventoryUsed { get; set; }
        public decimal? InventoryIdeal { get; set; }
        public decimal? InventoryVariance1 { get; set; }
    }
}
