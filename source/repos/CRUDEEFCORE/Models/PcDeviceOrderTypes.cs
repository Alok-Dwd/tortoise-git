using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PcDeviceOrderTypes
    {
        public string LocationCode { get; set; }
        public int DeviceId { get; set; }
        public string OrderTypeCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
