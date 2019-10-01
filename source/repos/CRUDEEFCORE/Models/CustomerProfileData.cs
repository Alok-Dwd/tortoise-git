using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CustomerProfileData
    {
        public string LocationCode { get; set; }
        public int CustomerCode { get; set; }
        public int CustomerProfileTypeId { get; set; }
        public string CustomerProfileValue { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerProfileTypes CustomerProfileTypes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
