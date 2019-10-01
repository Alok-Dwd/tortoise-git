using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MobInOrderCancel
    {
        public int MobInOrderCancelId { get; set; }
        public string FkLocationCode { get; set; }
        public int FkOrderNumber { get; set; }
        public DateTime FkOrderDate { get; set; }
        public DateTime? ApiInvokeTimeStamp { get; set; }
        public DateTime? ApiCompleteTimeStamp { get; set; }
        public bool ApiStatus { get; set; }
        public int FailCount { get; set; }
        public int IsSucess { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int? BcpStatus { get; set; }

        public virtual Orders Fk { get; set; }
    }
}
