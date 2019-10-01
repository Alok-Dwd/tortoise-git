using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GstSacMaster
    {
        public string LocationCode { get; set; }
        public string SacCode { get; set; }
        public string OrderTypeCode { get; set; }
        public short StatusCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
