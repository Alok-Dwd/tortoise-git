using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GstRegions
    {
        public string LocationCode { get; set; }
        public int RegionCode { get; set; }
        public string RegionName { get; set; }
        public string RegionAbbr { get; set; }
        public bool? DriverLicenseDob { get; set; }
        public bool? AddedManually { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public string StateCode { get; set; }
    }
}
