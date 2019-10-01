using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OloOrders
    {
        public string LocationCode { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ActualOrderDate { get; set; }
        public DateTime? OrderSaved { get; set; }
        public decimal? OrderAmount { get; set; }
        public string OrderTypeCode { get; set; }
        public int? OrderStatusCode { get; set; }
        public string TentNumber { get; set; }
        public bool? DelayedOrder { get; set; }
        public string DriverId { get; set; }
        public bool? ApiStatus { get; set; }
        public string ApiResponceMessage { get; set; }
        public DateTime? KitchenPunchTimeStamp { get; set; }
        public bool? KitchenApiStatus { get; set; }
        public DateTime? OrderOutTimeStamp { get; set; }
        public bool? OrderOutApiStatus { get; set; }
        public DateTime? OrderInTimeStamp { get; set; }
        public bool? OrderInApiStatus { get; set; }
        public DateTime? DeliveryTimeStamp { get; set; }
        public bool? DeliveryApiStatus { get; set; }
        public DateTime? CancelPunchTimeStamp { get; set; }
        public bool? CancelApiStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? ReachedGateTimeStamp { get; set; }
        public bool? ReachedGateApiStatus { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
