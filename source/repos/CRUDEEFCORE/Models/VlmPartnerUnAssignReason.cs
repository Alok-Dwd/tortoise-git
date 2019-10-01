using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VlmPartnerUnAssignReason
    {
        public string VlmPartnerUnAssignReasonId { get; set; }
        public string VlmPartnerUnAssignReasonDesc { get; set; }
        public bool IsActive { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
    }
}
