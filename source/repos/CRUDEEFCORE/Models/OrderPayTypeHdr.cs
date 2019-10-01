using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderPayTypeHdr
    {
        public OrderPayTypeHdr()
        {
            SrsReconcileDetl = new HashSet<SrsReconcileDetl>();
        }

        public int SalesPayId { get; set; }
        public string LocationCode { get; set; }
        public string SalesPayHead { get; set; }
        public bool? IsActive { get; set; }
        public bool IsEditable { get; set; }
        public int? DisplaySequence { get; set; }

        public virtual ICollection<SrsReconcileDetl> SrsReconcileDetl { get; set; }
    }
}
