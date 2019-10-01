using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstReceiptTransaction
    {
        public string XmlfileName { get; set; }
        public string LocationCode { get; set; }
        public string SenderLocationCode { get; set; }
        public string InvoiceNumber { get; set; }
        public string InventoryCode { get; set; }
        public string Description { get; set; }
        public string OrderUnit { get; set; }
        public string CountUnit { get; set; }
        public decimal? Price { get; set; }
        public decimal? TransferQty { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int? DeliveryId { get; set; }
    }
}
