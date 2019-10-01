﻿using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DailyInventoryLog
    {
        public string LocationCode { get; set; }
        public string InventoryCode { get; set; }
        public DateTime EiDate { get; set; }
        public decimal? EiQty { get; set; }
        public decimal? Ifc { get; set; }
        public decimal? EiPrice { get; set; }
        public decimal? OrderQty { get; set; }
        public byte EiOverrideFlag { get; set; }
        public decimal Waste { get; set; }
        public float? CountOrder { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public decimal? Flag { get; set; }
    }
}
