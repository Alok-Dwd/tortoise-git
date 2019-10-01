using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GstStoreCityMaster
    {
        public string LocationCode { get; set; }
        public int? CityCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
