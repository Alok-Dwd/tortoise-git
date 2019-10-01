using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class InventoryType
    {
        public string LocationCode { get; set; }
        public string InventoryTypeCode { get; set; }
        public string Description { get; set; }
        public bool? Food { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
