using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VlmOrderStatus
    {
        public VlmOrderStatus()
        {
            VlmPartnerOrders = new HashSet<VlmPartnerOrders>();
        }

        public string VlmOrderStatusCode { get; set; }
        public string VlmOrderStatusDescription { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }

        public virtual ICollection<VlmPartnerOrders> VlmPartnerOrders { get; set; }
    }
}
