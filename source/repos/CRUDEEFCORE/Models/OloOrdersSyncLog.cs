using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OloOrdersSyncLog
    {
        public string LocationCode { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ServiceCallUrl { get; set; }
        public string ApiData { get; set; }
        public string OloOrderMessage { get; set; }
        public string OrderStatusCode { get; set; }
        public DateTime? CallInvokeTimeStamp { get; set; }
        public bool? IsSucess { get; set; }
        public string AddedBy { get; set; }
        public int? FailCount { get; set; }
    }
}
