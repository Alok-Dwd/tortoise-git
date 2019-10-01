using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VsThresholds
    {
        public string LocationCode { get; set; }
        public int ThresholdId { get; set; }
        public string Window { get; set; }
        public byte? Alert { get; set; }
    }
}
