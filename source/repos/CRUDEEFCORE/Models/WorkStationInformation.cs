using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class WorkStationInformation
    {
        public string LocationCode { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public int? WorkstationId { get; set; }
        public int? TakerId { get; set; }
    }
}
