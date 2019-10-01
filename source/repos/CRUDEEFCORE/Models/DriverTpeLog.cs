using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DriverTpeLog
    {
        public int? TransactionId { get; set; }
        public string LocationCode { get; set; }
        public string LogType { get; set; }
        public string Message { get; set; }
        public string RetryCount { get; set; }
        public DateTime? Added { get; set; }
    }
}
