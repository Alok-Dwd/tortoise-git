using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewOloadvanceSales
    {
        public string StrCode { get; set; }
        public DateTime? ClDate { get; set; }
        public int? OrderNo { get; set; }
        public string InvoiceNumber { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? OrderSavedDate { get; set; }
        public DateTime? OrderDeliveryDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public string TentNumber { get; set; }
        public decimal? OrderAmountBeforTax { get; set; }
        public decimal? Gst { get; set; }
        public decimal? OrderAmount { get; set; }
        public decimal? RefundAmountOfTheDay { get; set; }
        public decimal? PosSalesOnTheDayOfDelivaryAfterEod { get; set; }
        public DateTime? CancellationDate { get; set; }
        public string CancellationReason { get; set; }
        public string CouponCode { get; set; }
        public string Advcollection { get; set; }
        public decimal? TotalValue { get; set; }
        public string Type { get; set; }
    }
}
