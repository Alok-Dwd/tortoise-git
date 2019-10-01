using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MakeLineDisplayRemoteOrders
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int DeviceId { get; set; }
        public int WorkstationId { get; set; }
        public DateTime? KitchenDisplayTime { get; set; }
    }
}
