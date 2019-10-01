using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Orders
    {
        public Orders()
        {
            AodLog = new HashSet<AodLog>();
            MobInOrderCancel = new HashSet<MobInOrderCancel>();
            MobInOrders = new HashSet<MobInOrders>();
            MobInOrdersLog = new HashSet<MobInOrdersLog>();
            OloOts = new HashSet<OloOts>();
            OrderWallet = new HashSet<OrderWallet>();
            VlmPartnerOrders = new HashSet<VlmPartnerOrders>();
        }

        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int OldOrderNumber { get; set; }
        public bool? BeingModified { get; set; }
        public string Modifying { get; set; }
        public int CustomerCode { get; set; }
        public string CustomerRoom { get; set; }
        public string CustomerName { get; set; }
        public string Comments { get; set; }
        public DateTime? ActualOrderDate { get; set; }
        public short OrderStatusCode { get; set; }
        public string OrderTypeCode { get; set; }
        public bool? PayNow { get; set; }
        public DateTime? OrderSaved { get; set; }
        public short OrderTime { get; set; }
        public decimal SalesTax1 { get; set; }
        public decimal SalesTax2 { get; set; }
        public decimal Credit { get; set; }
        public decimal CouponTotal { get; set; }
        public decimal SubTotal { get; set; }
        public string CouponCode { get; set; }
        public bool? CouponTaxable { get; set; }
        public short CouponTypeCode { get; set; }
        public bool? CouponAdjustment { get; set; }
        public decimal CouponAmount { get; set; }
        public DateTime? RouteTime { get; set; }
        public string DriverId { get; set; }
        public string DriverShift { get; set; }
        public DateTime? ReturnTime { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public decimal? DeliveryFee { get; set; }
        public decimal TaxableSales1 { get; set; }
        public decimal TaxableSales2 { get; set; }
        public decimal NonTaxableSales { get; set; }
        public int NumberInParty { get; set; }
        public string ComputerName { get; set; }
        public DateTime? KitchenDisplayTime { get; set; }
        public decimal FinalTotal { get; set; }
        public decimal OrderLineAdjustments { get; set; }
        public decimal OrderAdjustments { get; set; }
        public decimal OrderLineCouponTotal { get; set; }
        public decimal OrderCouponTotal { get; set; }
        public decimal DeliveryFeeTax1 { get; set; }
        public decimal DeliveryFeeTax2 { get; set; }
        public bool? DelayedOrder { get; set; }
        public string OrderTakerId { get; set; }
        public string OrderTakerShift { get; set; }
        public string TentNumber { get; set; }
        public DateTime? ClosedOrderTime { get; set; }
        public int WorkstationId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public decimal? Roudingoff { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual ICollection<AodLog> AodLog { get; set; }
        public virtual ICollection<MobInOrderCancel> MobInOrderCancel { get; set; }
        public virtual ICollection<MobInOrders> MobInOrders { get; set; }
        public virtual ICollection<MobInOrdersLog> MobInOrdersLog { get; set; }
        public virtual ICollection<OloOts> OloOts { get; set; }
        public virtual ICollection<OrderWallet> OrderWallet { get; set; }
        public virtual ICollection<VlmPartnerOrders> VlmPartnerOrders { get; set; }
    }
}
