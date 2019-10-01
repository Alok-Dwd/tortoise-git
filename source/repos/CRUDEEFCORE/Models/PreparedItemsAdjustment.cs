using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PreparedItemsAdjustment
    {
        public string LocationCode { get; set; }
        public string InventoryCode { get; set; }
        public string Desrciption { get; set; }
        public bool? Adjust { get; set; }
    }
}
