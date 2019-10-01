using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class KitchenDelayPrint
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public DateTime PrintDateTime { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
