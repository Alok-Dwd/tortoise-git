using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GstInventoryMaster
    {
        public string MaterialDescription { get; set; }
        public string Material { get; set; }
        public string Hsn { get; set; }
        public string GstRates { get; set; }
        public string CessRate { get; set; }
        public string PosCode { get; set; }
    }
}
