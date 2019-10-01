using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstTransactionDetl
    {
        public int? TransactionId { get; set; }
        public string InvoiceNumber { get; set; }
        public string InventoryCode { get; set; }
        public string Description { get; set; }
        public string OrderUnit { get; set; }
        public string CountUnit { get; set; }
        public decimal? Price { get; set; }
        public decimal? TransferQty { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ConFactor { get; set; }
    }
}
