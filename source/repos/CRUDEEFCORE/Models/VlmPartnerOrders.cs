using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VlmPartnerOrders
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string VlmPartnerOrderNumber { get; set; }
        public string VlmPartnerId { get; set; }
        public DateTime? OrderAssignTimeStamp { get; set; }
        public DateTime? OrderAssignConfirmTimeStamp { get; set; }
        public DateTime? OrderAllocateTimeStamp { get; set; }
        public DateTime? DriverArriveTimeStamp { get; set; }
        public DateTime? OrderOutTimeStamp { get; set; }
        public DateTime? OrderDeliveryTimeStamp { get; set; }
        public string VlmPartnerOrderAssignMessage { get; set; }
        public string VlmPartnerOrderAllocateMessage { get; set; }
        public string VlmPartnerOrderDriverArriveMessage { get; set; }
        public string VlmPartnerOrderOutMessage { get; set; }
        public string VlmPartnerOrderDeliveredMessage { get; set; }
        public string VlmPartnerOrderStatusCode { get; set; }
        public string VlmOrderStatusCode { get; set; }
        public string DriverName { get; set; }
        public string DriverPhoneNumber { get; set; }
        public bool? IsActive { get; set; }
        public bool IsReconciled { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }

        public virtual Orders Orders { get; set; }
        public virtual VlmOrderStatus VlmOrderStatusCodeNavigation { get; set; }
        public virtual VlmPartner VlmPartner { get; set; }
    }
}
