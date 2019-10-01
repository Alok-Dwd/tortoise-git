using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AodTimeMapping
    {
        public string LocationCode { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string Day { get; set; }
        public bool DineIn { get; set; }
        public bool Delivery { get; set; }
        public bool Odc { get; set; }
        public bool CarryOut { get; set; }
        public bool LateDiscount { get; set; }
        public bool Tsg { get; set; }
        public int? MinTime { get; set; }
        public int? MaxTime { get; set; }
        public bool? Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
