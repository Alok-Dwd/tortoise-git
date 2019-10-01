using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SrsReconcileHdr
    {
        public SrsReconcileHdr()
        {
            SrsReconcileDetl = new HashSet<SrsReconcileDetl>();
            SrsReconcileOrderDetails = new HashSet<SrsReconcileOrderDetails>();
        }

        public string LocationCode { get; set; }
        public int ReconcileId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal GrossSales { get; set; }
        public decimal PosSales { get; set; }
        public decimal SalesVariance { get; set; }
        public string PreparedBy { get; set; }
        public DateTime PreparedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? FinalSubmit { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<SrsReconcileDetl> SrsReconcileDetl { get; set; }
        public virtual ICollection<SrsReconcileOrderDetails> SrsReconcileOrderDetails { get; set; }
    }
}
