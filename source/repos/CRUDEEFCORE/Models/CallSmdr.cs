using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CallSmdr
    {
        public string PortId { get; set; }
        public DateTime? CallDateTime { get; set; }
        public int? OrderNumber { get; set; }
        public string CallerId { get; set; }
        public string CustomerName { get; set; }
        public bool IsMissed { get; set; }
        public bool IsCleared { get; set; }
        public DateTime? ClearDateTime { get; set; }
        public bool IsCallback { get; set; }
        public bool IsCallbackConnected { get; set; }
        public decimal? IfYesAmount { get; set; }
        public string IfNoRemarks { get; set; }
        public short? RepeatCount { get; set; }
        public string LocationCode { get; set; }
        public string AgentId { get; set; }
        public int? TrunkId { get; set; }
        public string Origin { get; set; }
        public string Reason { get; set; }
        public string CalledId { get; set; }
        public string ConnectId { get; set; }
        public string RedirectingId { get; set; }
        public string RedirectionId { get; set; }
        public int? DialTime { get; set; }
        public int? RingTime { get; set; }
        public int? TalkTime { get; set; }
        public int? HoldTime { get; set; }
        public int? WrapTime { get; set; }
        public bool? IsOnHoldDisconnected { get; set; }
        public bool? IsDisconnected { get; set; }
        public bool? IsOutbound { get; set; }
        public bool? IsExternal { get; set; }
        public string StoreCode { get; set; }
    }
}
