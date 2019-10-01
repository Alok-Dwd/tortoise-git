using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class UpsellHistory
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public string MenuCategoryCode { get; set; }
        public int? Quantity { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
