using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MileageTypeSalesRanges
    {
        public string LocationCode { get; set; }
        public byte MileageTypeCode { get; set; }
        public float BeginRange { get; set; }
        public float EndRange { get; set; }
        public float RangeAmount { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
