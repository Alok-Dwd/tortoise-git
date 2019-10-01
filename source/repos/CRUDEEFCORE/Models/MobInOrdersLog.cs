using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MobInOrdersLog
    {
        public string FkLocationCode { get; set; }
        public int FkOrderNumber { get; set; }
        public DateTime FkOrderDate { get; set; }
        public string ServiceCallUrl { get; set; }
        public string FarEyeOrderMessage { get; set; }
        public string OrderStatusMessage { get; set; }
        public string OrderStatusCode { get; set; }
        public DateTime CallInvokeTimeStamp { get; set; }
        public DateTime CallCompleteTimeStamp { get; set; }
        public bool IsSucess { get; set; }
        public string RequestData { get; set; }
        public string ResponseData { get; set; }
        public int LogType { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }

        public virtual Orders Fk { get; set; }
    }
}
