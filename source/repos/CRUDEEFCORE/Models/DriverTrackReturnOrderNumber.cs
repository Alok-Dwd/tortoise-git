using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DriverTrackReturnOrderNumber
    {
        public int? TransactionId { get; set; }
        public string LocationCode { get; set; }
        public string DriverId { get; set; }
        public string RfId { get; set; }
        public string LogType { get; set; }
        public DateTime? BeforeExeInvokeTimeStamp { get; set; }
        public DateTime? AfterExeInvokeTimeStamp { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? Added { get; set; }
    }
}
