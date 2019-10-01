using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PcDeviceQueueDaily
    {
        public string LocationCode { get; set; }
        public int DeviceId { get; set; }
        public int Sequence { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string PhoneNumber { get; set; }
        public string SendText { get; set; }
        public byte LineDisplayRow { get; set; }
        public byte LineDisplayColumn { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
