using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DriverTrackOrderNumberDetails
    {
        public int? TransactionId { get; set; }
        public string LocationCode { get; set; }
        public string OrderNumber { get; set; }
        public string Assign { get; set; }
        public DateTime OrderDate { get; set; }
        public string TpeMessage { get; set; }
        public DateTime? Added { get; set; }
    }
}
