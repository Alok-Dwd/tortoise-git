using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class RouteStationSettings
    {
        public string LocationCode { get; set; }
        public short UpdateSeconds { get; set; }
        public short MaxOrders { get; set; }
        public short LateTime { get; set; }
        public bool? ProtectNonDelivery { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
