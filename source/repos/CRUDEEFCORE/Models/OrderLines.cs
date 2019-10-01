using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderLines
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public short LineNumber { get; set; }
        public short Sequence { get; set; }
        public short OrderLineStatusCode { get; set; }
        public DateTime? OvenTime { get; set; }
        public float Quantity { get; set; }
        public string ComboMenuCode { get; set; }
        public string ComboSizeCode { get; set; }
        public short ComboGroup { get; set; }
        public short ComboItemNumber { get; set; }
        public int MenuTypeId { get; set; }
        public string MenuCategoryCode { get; set; }
        public string MenuCode { get; set; }
        public short MenuItemTypeCode { get; set; }
        public string SizeCode { get; set; }
        public string CouponCode { get; set; }
        public bool? CouponTaxable { get; set; }
        public short CouponTypeCode { get; set; }
        public bool? CouponAdjustment { get; set; }
        public decimal CouponAmount { get; set; }
        public decimal CouponMinPrice { get; set; }
        public decimal Price { get; set; }
        public decimal MenuPrice { get; set; }
        public decimal MenuPrice2 { get; set; }
        public decimal BottleDeposit { get; set; }
        public bool? Deleted { get; set; }
        public string ToppingCodes { get; set; }
        public string ToppingDescriptions { get; set; }
        public bool? CalculateIfc { get; set; }
        public short DoublesGroup { get; set; }
        public DateTime? OrderSavedTime { get; set; }
        public int? Modifying { get; set; }
        public decimal OrderCouponAmount { get; set; }
        public decimal OrderLineCouponAmount { get; set; }
        public decimal OrderLineNoTaxDiscount { get; set; }
        public decimal OrderLineTaxDiscount { get; set; }
        public decimal OrderNoTaxDiscount { get; set; }
        public decimal OrderTaxDiscount { get; set; }
        public decimal CreditDiscount { get; set; }
        public decimal OrderLineTaxableSale1 { get; set; }
        public decimal OrderLineTaxableSale2 { get; set; }
        public decimal OrderLineNonTaxableSale { get; set; }
        public decimal OrderLineTax1 { get; set; }
        public decimal OrderLineTax2 { get; set; }
        public decimal OrderLineTotal { get; set; }
        public string OrigMenuCode { get; set; }
        public string ToppingString { get; set; }
        public bool? Manual { get; set; }
        public float? ToppingCount { get; set; }
        public bool? DoublesBypassed { get; set; }
        public string InstructionString { get; set; }
        public decimal BasePrice { get; set; }
        public decimal BasePrice2 { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
