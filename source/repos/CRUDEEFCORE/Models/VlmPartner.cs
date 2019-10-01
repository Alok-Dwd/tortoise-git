using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VlmPartner
    {
        public VlmPartner()
        {
            VlmPartnerOrders = new HashSet<VlmPartnerOrders>();
        }

        public string LocationCode { get; set; }
        public string VlmPartnerId { get; set; }
        public string VlmPartnerDescription { get; set; }
        public string VlmPartnerDllClassName { get; set; }
        public string VlmPartnerDllName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefaultPartner { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }

        public virtual ICollection<VlmPartnerOrders> VlmPartnerOrders { get; set; }
    }
}
