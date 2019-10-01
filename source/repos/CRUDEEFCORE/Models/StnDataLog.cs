using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class StnDataLog
    {
        public int RequestId { get; set; }
        public int? DeliveryId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryType { get; set; }
        public int? RecordCount { get; set; }
        public int? Status { get; set; }
        public string RequestData { get; set; }
        public string Response { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? Added { get; set; }
    }
}
