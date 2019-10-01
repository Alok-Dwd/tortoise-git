using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class RoaLog
    {
        public long RoaLogNo { get; set; }
        public string LocationCode { get; set; }
        public DateTime? LogDate { get; set; }
        public string GateWay { get; set; }
        public string GateWayIp { get; set; }
        public bool? Lan { get; set; }
        public bool? Socket { get; set; }
        public bool? DataBase { get; set; }
        public bool? SendMessage { get; set; }
        public string ErrDescription { get; set; }
    }
}
