using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CustomerGstin
    {
        public string LocationCode { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public int CustomerCode { get; set; }
        public string Gstin { get; set; }
        public string PanNumber { get; set; }
        public string DataPoint1 { get; set; }
        public string DataPoint2 { get; set; }
        public string DataPoint3 { get; set; }
        public string DataPoint4 { get; set; }
        public string DataPoint5 { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
