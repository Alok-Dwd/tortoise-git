using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SrsReconcileDetl
    {
        public int ReconcileId { get; set; }
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int SalesPayId { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsEditable { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual OrderPayTypeHdr OrderPayTypeHdr { get; set; }
        public virtual SrsReconcileHdr SrsReconcileHdr { get; set; }
    }
}
