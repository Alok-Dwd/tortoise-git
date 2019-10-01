using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class WastageDetail
    {
        public int TransId { get; set; }
        public string LocationCode { get; set; }
        public string Inventoryitem { get; set; }
        public DateTime? InventoryDate { get; set; }
        public int? WastageReson { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? Added { get; set; }
        public string AddedBy { get; set; }
    }
}
