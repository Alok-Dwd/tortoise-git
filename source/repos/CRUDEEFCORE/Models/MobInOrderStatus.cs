using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MobInOrderStatus
    {
        public MobInOrderStatus()
        {
            MobInOrders = new HashSet<MobInOrders>();
        }

        public string MobInOrderStatusCode { get; set; }
        public string MobInOrderStatusDescription { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }

        public virtual ICollection<MobInOrders> MobInOrders { get; set; }
    }
}
