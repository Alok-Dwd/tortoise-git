using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MobInHeartBeatStatus
    {
        public int Id { get; set; }
        public short IsConected { get; set; }
        public short CurrentBcpmode { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
    }
}
