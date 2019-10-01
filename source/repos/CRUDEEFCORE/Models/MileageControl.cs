using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MileageControl
    {
        public string LocationCode { get; set; }
        public byte MileageTypeCode { get; set; }
        public decimal? MinIrsMileageRate { get; set; }
        public decimal? MaxIrsMileageRate { get; set; }
        public decimal? PercentForCarTop { get; set; }
        public decimal? DefaultMileageRate1 { get; set; }
        public decimal? DefaultMileageRate2 { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
