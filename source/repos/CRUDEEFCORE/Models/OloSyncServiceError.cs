using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OloSyncServiceError
    {
        public string LocationCode { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderTypeCode { get; set; }
        public string TentNumber { get; set; }
        public string OrderStatusCode { get; set; }
        public string ServiceErrorEvent { get; set; }
        public string ServiceErrorMessage { get; set; }
        public DateTime? Added { get; set; }
    }
}
