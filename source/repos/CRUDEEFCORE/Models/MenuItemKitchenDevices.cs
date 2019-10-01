using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemKitchenDevices
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public int DeviceId { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
