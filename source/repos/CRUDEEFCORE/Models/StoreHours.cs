using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class StoreHours
    {
        public string LocationCode { get; set; }
        public short DayOfWeek { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
