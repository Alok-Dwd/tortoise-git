using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PulseApiorderData
    {
        public PulseApiorderData()
        {
            PulseApiorderDataDtl = new HashSet<PulseApiorderDataDtl>();
        }

        public string Version { get; set; }
        public DateTime? OrderLastUpdate { get; set; }
        public DateTime? CurrentDateTime { get; set; }
        public string StoreNumber { get; set; }
        public string OrderDateOrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerAddress3 { get; set; }
        public string CustomerAddress4 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerPostalCode { get; set; }
        public string OrderComments { get; set; }
        public string ServiceMethod { get; set; }
        public DateTime? OrderSaveDateTime { get; set; }
        public string OrderDescription { get; set; }
        public decimal? OrderListPrice { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? OrderLineWithDiscount { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? SalesTax1Amount { get; set; }
        public decimal? SalesTax2Amount { get; set; }
        public decimal? BottleDepositAmount { get; set; }
        public decimal? OrderFinalPrice { get; set; }
        public decimal? BalanceDue { get; set; }
        public DateTime? OrderTakeComplete { get; set; }
        public int? OrderTakeTime { get; set; }
        public string CsrId { get; set; }
        public string CsrFirstName { get; set; }
        public string OrderSourceCode { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? OrderSaveStartTime { get; set; }
        public int? OrderLoadTime { get; set; }
        public DateTime? OrderLoadDateTime { get; set; }
        public int? OvenTime { get; set; }
        public DateTime? RackDateTime { get; set; }
        public int? RackTime { get; set; }
        public DateTime? DispatchDateTime { get; set; }
        public string DriverId { get; set; }
        public string DriverFirstName { get; set; }
        public int? RunStopSeq { get; set; }
        public int? RunStopCount { get; set; }
        public int? DeliveryTime { get; set; }
        public DateTime? DeliveryDateTime { get; set; }
        public DateTime? DriverReturnDateTime { get; set; }
        public int? MakeLineItemCount { get; set; }
        public string OrderKey { get; set; }
        public string ManagerId { get; set; }
        public string ManagerFirstName { get; set; }
        public string OrderDetail { get; set; }
        public decimal? SalesTax3Amount { get; set; }
        public decimal? SalesTax4Amount { get; set; }
        public decimal? SalesTax5Amount { get; set; }
        public DateTime? Added { get; set; }

        public virtual ICollection<PulseApiorderDataDtl> PulseApiorderDataDtl { get; set; }
    }
}
