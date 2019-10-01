using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DeliveriesTmp
    {
        public string LocationCode { get; set; }
        public int? DeliveryId { get; set; }
        public string VendorCode { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryTypeCode { get; set; }
        public decimal? DeliveryAmount { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public decimal? DeliveryTax { get; set; }
        public string ListVendorCode { get; set; }
        public string AlternateVendorName { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
