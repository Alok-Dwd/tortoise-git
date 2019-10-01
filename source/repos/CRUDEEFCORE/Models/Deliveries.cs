using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Deliveries
    {
        public Deliveries()
        {
            DeliveryAmountNavigation = new HashSet<DeliveryAmount>();
        }

        public string LocationCode { get; set; }
        public int DeliveryId { get; set; }
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
        public DateTime Added { get; set; }
        public int? IsPrint { get; set; }
        public int? StnPost { get; set; }
        public string PosId { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<DeliveryAmount> DeliveryAmountNavigation { get; set; }
    }
}
