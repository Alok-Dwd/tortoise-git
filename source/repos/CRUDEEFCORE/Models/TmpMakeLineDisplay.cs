using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class TmpMakeLineDisplay
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public short LineNumber { get; set; }
        public int? DeviceId { get; set; }
        public DateTime? OrderSaved { get; set; }
        public string OrderTypeCode { get; set; }
        public int? MakeQty { get; set; }
        public int? Quantity { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string ToppingCodes { get; set; }
        public string ToppingDescriptions { get; set; }
        public DateTime? ActualOrderDate { get; set; }
        public int? CustomerCode { get; set; }
        public string Instructions { get; set; }
        public string Description { get; set; }
        public DateTime? KitchenDisplayTime { get; set; }
        public int? GridDisplay { get; set; }
        public string WorkStaionName { get; set; }
        public int? OrderStatus { get; set; }
        public int? ProductType { get; set; }
        public int? OrderStatusCode { get; set; }
        public string OrderTime { get; set; }
        public DateTime? OrderDateTime { get; set; }
        public string OtsNumber { get; set; }
        public string OrderTakerId { get; set; }
        public DateTime Added { get; set; }
    }
}
