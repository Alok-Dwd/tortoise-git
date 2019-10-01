using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OfflineLogReason
    {
        public string LocationCode { get; set; }
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string TicketId { get; set; }
        public DateTime DownDate { get; set; }
        public DateTime UpDate { get; set; }
        public string DownTime { get; set; }
        public string Uptime { get; set; }
        public bool? Status { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
