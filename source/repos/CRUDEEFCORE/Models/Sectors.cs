using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Sectors
    {
        public string LocationCode { get; set; }
        public int SectorKey { get; set; }
        public int StreetCode { get; set; }
        public string LowerBound { get; set; }
        public string UpperBound { get; set; }
        public short OddEven { get; set; }
        public string SectorCode { get; set; }
        public decimal AdditionalDeliveryFee { get; set; }
        public bool? OutOfArea { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
