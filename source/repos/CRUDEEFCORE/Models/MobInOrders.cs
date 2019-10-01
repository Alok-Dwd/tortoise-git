using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MobInOrders
    {
        public int MobInOrderId { get; set; }
        public string FkLocationCode { get; set; }
        public int FkOrderNumber { get; set; }
        public DateTime FkOrderDate { get; set; }
        public DateTime? OrderOutTimeStamp { get; set; }
        public DateTime? OrderInTimeStamp { get; set; }
        public DateTime? OrderDeliveryPosTimeStamp { get; set; }
        public DateTime? OrderRoutePosTimeStamp { get; set; }
        public DateTime? OrderReturnPosTimeStamp { get; set; }
        public DateTime? OrderReachedPosTimeStamp { get; set; }
        public DateTime? OrderDeliveryTimeStamp { get; set; }
        public DateTime? OrderReachedTimeStamp { get; set; }
        public int IsNullTimeStamp { get; set; }
        public string OrderAssignMessage { get; set; }
        public string OrderOutMessage { get; set; }
        public string OrderInMessage { get; set; }
        public string OrderDeliveredMessage { get; set; }
        public string OrderReachedMessage { get; set; }
        public int OrderStatusCode { get; set; }
        public string FkMobInOrderStatusCode { get; set; }
        public string FkEmployeeCode { get; set; }
        public bool? IsActive { get; set; }
        public bool ApiStatus { get; set; }
        public bool IsCanceled { get; set; }
        public bool PosStatus { get; set; }
        public int FailCount { get; set; }
        public int BcpStatus { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Orders Fk { get; set; }
        public virtual MobInOrderStatus FkMobInOrderStatusCodeNavigation { get; set; }
    }
}
